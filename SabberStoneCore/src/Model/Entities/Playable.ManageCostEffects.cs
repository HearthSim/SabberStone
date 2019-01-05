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
		private class CostManager
		{
			private int _cachedValue;
			private bool _toBeUpdated;
			private List<Effect> _costEffects = new List<Effect>();
			private AdaptiveCostEffect _adaptiveCostEffect;

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

			public void ResetCost()
			{
				_costEffects = null;
				_adaptiveCostEffect?.Remove();
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
		}

		private CostManager _costManager;
		private int? _modifiedCost;

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

		internal void AddCostEnchantment(Effect e)
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

		internal void ResetCost()
		{
			_costManager.ResetCost();
			_costManager = null;
			_modifiedCost = null;

			if (_history)
				Game.PowerHistory.Add(PowerHistoryBuilder.TagChange(Id, GameTag.COST, Card.Cost));
		}
	}
}
