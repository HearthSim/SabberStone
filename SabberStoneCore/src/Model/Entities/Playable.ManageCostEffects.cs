using System;
using System.Collections.Generic;
using SabberStoneCore.Auras;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;

namespace SabberStoneCore.Model.Entities
{
	public partial class Playable
	{
		internal class CostManager
		{
			private int _cachedValue;
			private bool _toBeUpdated;

			private readonly List<(EffectOperator Operator, int Value)> _costEffects =
				new List<(EffectOperator @operator, int value)>();
			private AdaptiveCostEffect _adaptiveCostEffect;

			public CostManager()
			{
				_toBeUpdated = true;
			}

			public CostManager(AdaptiveCostEffect adaptiveEffect)
			{
				_adaptiveCostEffect = adaptiveEffect;
			}

			private CostManager(CostManager original)
			{
				_cachedValue = original._cachedValue;
				_toBeUpdated = original._toBeUpdated;
				_costEffects.AddRange(original._costEffects);
			}

			public int CachedValue
			{
				get => _cachedValue;
				set => _cachedValue = value;
			}

			/// <summary>
			/// Apply a new Cost effect of an <see cref="Aura"/>
			/// </summary>
			public void AddCostAura(EffectOperator @operator, int value)
			{
				_costEffects.Add((@operator, value));

				switch (@operator)
				{
					case EffectOperator.ADD:
						_cachedValue += value;
						break;
					case EffectOperator.SUB:
						_cachedValue -= value;
						break;
					case EffectOperator.SET:
						_cachedValue = value;
						break;
				}
			}

			/// <summary>
			/// Remove an applied Cost effect of an <see cref="Aura"/>.
			/// </summary>
			/// <exception cref="KeyNotFoundException"></exception>
			public void RemoveCostAura(EffectOperator @operator, int value)
			{
				if (!_costEffects.Remove((@operator, value)))
					throw new KeyNotFoundException($"Can't remove cost aura [{@operator} {value}]");

				switch (@operator)
				{
					case EffectOperator.SUB:
						_cachedValue += value;
						break;
					case EffectOperator.ADD:
						_cachedValue -= value;
						break;
					case EffectOperator.SET:
						_toBeUpdated = true;
						break;
				}

			}

			/// <summary>
			/// Activate <see cref="AdaptiveCostEffect"/> to calculate and reflect its result.
			/// </summary>
			public void ActivateAdaptiveEffect(AdaptiveCostEffect adaptiveCostEffect)
			{
				_adaptiveCostEffect = adaptiveCostEffect;
			}

			public void UpdateAdaptiveEffect(int setValue = -1)
			{
				if (setValue > 0)
					_cachedValue = setValue;
				else
					_toBeUpdated = true;
			}

			public void DeactivateAdaptiveEffect()
			{
				_adaptiveCostEffect = null;
			}

			/// <summary>
			/// Add a new permanent cost enchantment effect
			/// </summary>
			public void AddCostEnchantment(EffectOperator @operator, int value)
			{
				ref int c = ref _cachedValue;

				switch (@operator)
				{
					case EffectOperator.SUB:
						c -= value;
						break;
					case EffectOperator.ADD:
						c += value;
						break;
					case EffectOperator.SET:
						_toBeUpdated = true;
						break;
				}
			}

			public int GetCost(int c)
			{
				int cost = _toBeUpdated ? GetCostInternal(c) : _cachedValue;

				return cost > 0 ? cost : 0;
			}

			internal void QueueUpdate()
			{
				_toBeUpdated = true;
			}

			private int GetCostInternal(int c)
			{
				// 1. Get cost with enchantments first (c)
				// e.g. Emperor Thaurissan

				// 2. Apply cost aura effects next. (e.g. Naga Sea Witch, Sorcerer's Apprentice)
				List<(EffectOperator Operator, int Value)> effects = _costEffects;
				for (int i = 0; i < effects.Count; i++)
				{
					(EffectOperator Operator, int Value) e = effects[i];
					switch (e.Operator)
					{
						case EffectOperator.ADD:
							c += e.Value;
							break;
						case EffectOperator.SUB:
							c -= e.Value;
							break;
						case EffectOperator.SET:
							c = e.Value;
							break;
						default:
							throw new ArgumentOutOfRangeException();
					}
				}

				// 3. Lastly apply Adaptive Cost Effect (e.g. Giants)
				c = _adaptiveCostEffect?.Apply(c) ?? c;

				_cachedValue = c;

				_toBeUpdated = false;

				return c;
			}

			public CostManager Clone()
			{
				return new CostManager(this);
			}
		}

		internal CostManager _costManager;
		internal int? _modifiedCost;

		public int Cost
		{
			get =>
				_costManager?.GetCost(_modifiedCost ?? (_modifiedCost = Card.Cost).Value) ??
				(_modifiedCost.HasValue ? _modifiedCost < 0 ? 0 : _modifiedCost.Value : (_modifiedCost = Card.Cost).Value);
			set
			{
				_modifiedCost = value;

				if (_history)
					Game.PowerHistory.Add(PowerHistoryBuilder.TagChange(Id, GameTag.COST, Cost));
			}
		}

		internal void ResetCost()
		{
			_costManager = null;
			_modifiedCost = null;
			if (OngoingEffect is AdaptiveCostEffect ace)
				ace.Remove();

			if (_history)
				Game.PowerHistory.Add(PowerHistoryBuilder.TagChange(Id, GameTag.COST, Card.Cost));
		}
	}
}
