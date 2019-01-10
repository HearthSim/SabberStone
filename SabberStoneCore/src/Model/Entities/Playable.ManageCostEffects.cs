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
			private List<Effect> _costEffects = new List<Effect>();
			private AdaptiveCostEffect _adaptiveCostEffect;

			public CostManager() { }

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
			public void AddCostAura(in Effect e)
			{
				_costEffects.Add(e);

				ref int c = ref _cachedValue;

				switch (e.Operator)
				{
					case EffectOperator.SUB:
						c -= e.Value;
						break;
					case EffectOperator.ADD:
						c += e.Value;
						break;
					case EffectOperator.SET:
						c = e.Value;
						break;
				}
			}

			/// <summary>
			/// Remove an applied Cost effect of an <see cref="Aura"/>.
			/// </summary>
			/// <exception cref="KeyNotFoundException"></exception>
			public void RemoveCostAura(in Effect e)
			{
				//ToBeUpdated = true;
				//if (_costEffects.Remove(e)) return;

				//throw new Exception($"Can't remove cost aura {e}");

				if (!_costEffects.Remove(e))
					throw new KeyNotFoundException($"Can't remove cost aura {e}");

				ref int c = ref _cachedValue;

				switch (e.Operator)
				{
					case EffectOperator.SUB:
						c += e.Value;
						break;
					case EffectOperator.ADD:
						c -= e.Value;
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
			/// <param name="e"></param>
			public void AddCostEnchantment(in Effect e)
			{
				ref int c = ref _cachedValue;

				switch (e.Operator)
				{
					case EffectOperator.SUB:
						c += e.Value;
						break;
					case EffectOperator.ADD:
						c -= e.Value;
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
				List<Effect> effects = _costEffects;
				for (int i = 0; i < effects.Count; i++)
				{
					Effect e = effects[i];
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
				(_modifiedCost.HasValue ? _modifiedCost < 0 ? 0 : _modifiedCost.Value : Card.Cost);
			set
			{
				_modifiedCost = value;

				if (_history)
					Game.PowerHistory.Add(PowerHistoryBuilder.TagChange(Id, GameTag.COST, Card.Cost));
			}
		}

		internal void AddCostAuraEffect(Effect e)
		{
			if (_costManager == null)
			{
				var costManager = new CostManager();
				costManager.AddCostAura(in e);
				_costManager = costManager;
			}
			else
				_costManager.AddCostAura(in e);
		}

		internal void RemoveCostAuraEffect(Effect e)
		{
			if (_costManager == null)
			{
				var costManager = new CostManager();
				costManager.RemoveCostAura(in e);
			}
			else
				_costManager.RemoveCostAura(in e);
		}

		internal void AddCostEffect(Effect e)
		{
			switch (e.Operator)
			{
				case EffectOperator.ADD:
					_modifiedCost = _modifiedCost.GetValueOrDefault() + e.Value;
					break;
				case EffectOperator.SUB:
					_modifiedCost = _modifiedCost.GetValueOrDefault() - e.Value;
					break;
				case EffectOperator.SET:
					_modifiedCost = e.Value;
					break;
				default:
					throw new ArgumentOutOfRangeException();
			}

			_costManager?.AddCostEnchantment(in e);
		}

		//internal void ActivateAdaptiveCostEffect(AdaptiveCostEffect e)
		//{
		//	if (_costManager == null)
		//	{
		//		var costManager = new CostManager();
		//		costManager.ActivateAdaptiveEffect(e);
		//		_costManager = costManager;
		//	}
		//	else
		//	{
		//		_costManager.ActivateAdaptiveEffect(e);
		//	}
		//}

		//internal void UpdateAdaptiveCostEffect(int setValue = -1)
		//{
		//	if (setValue >= 0)
		//	{
		//		_costManager.CachedValue = setValue;
		//		return;
		//	}
		//	_costManager.QueueUpdate();
		//}

		//internal void DeactivateAdaptiveCostEffect()
		//{
		//	_costManager.DeactivateAdaptiveEffect();
		//}

		internal void ResetCost()
		{
			_costManager = null;
			_modifiedCost = null;

			if (_history)
				Game.PowerHistory.Add(PowerHistoryBuilder.TagChange(Id, GameTag.COST, Card.Cost));
		}
	}
}
