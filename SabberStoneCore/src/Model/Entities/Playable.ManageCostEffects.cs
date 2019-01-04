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
			private List<Effect> _costEffects = new List<Effect>();
			private AdaptiveCostEffect _adaptiveCostEffect;
			private int _cache;

			public bool ToBeUpdated { get; set; }

			/// <summary>
			/// Add a new Cost related effect to the owner.
			/// </summary>
			public void AddCostAura(Effect e)
			{
				ToBeUpdated = true;

				_costEffects.Add(e);

				if (e.Operator == EffectOperator.SET)

			}

			/// <summary>
			/// Remove a Cost related effect from the owner.
			/// </summary>
			public void RemoveCostAura(Effect e)
			{
				ToBeUpdated = true;
				if (_costEffects.Remove(e)) return;

				throw new Exception($"Can't remove cost aura {e}");
			}

			/// <summary>
			/// Activate <see cref="AdaptiveCostEffect"/> to calculate and reflect its result.
			/// </summary>
			public void ActivateAdaptiveEffect(AdaptiveCostEffect adaptiveCostEffect)
			{
				_adaptiveCostEffect = adaptiveCostEffect;
			}

			public void ResetCost()
			{
				_costEffects = null;
				_adaptiveCostEffect?.Remove();
				if (playable.Game.History)
					playable.Game.PowerHistory.Add(PowerHistoryBuilder.TagChange(playable.Id, GameTag.COST, playable.Card.Cost));
			}

			public int GetCost(int c)
			{
				return ToBeUpdated ? _cache = GetCostInternal(c) : _cache;
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

				// Dismiss negative cost.
				if (c < 0) c = 0;

				ToBeUpdated = false;

				return c;
			}
		}

		private CostManager _costManager;
		protected int? _modifiedCost;

		internal void AddCostAuraEffect(Effect e)
		{
			if (_costManager == null)
			{
				var costManager = new CostManager();
				costManager.AddCostAura(e);
				_costManager = costManager;
			}
			else
				_costManager.AddCostAura(e);
		}

		internal void RemoveCostAuraEffect(Effect e)
		{
			if (_costManager == null)
			{
				var costManager = new CostManager();
				costManager.RemoveCostAura(e);
			}
			else
				_costManager.RemoveCostAura(e);
		}

		internal void AddCostEnchantment(Effect e)
		{
			switch (e.Operator)
			{
				case EffectOperator.ADD:
					_modifiedCost = _modifiedCost.GetValueOrDefault() + e.Value;
					_costManager._cac
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
}
