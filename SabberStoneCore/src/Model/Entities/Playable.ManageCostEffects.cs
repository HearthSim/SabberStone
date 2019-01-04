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
			private List<Effect> _costEffects;
			private AdaptiveCostEffect _adaptiveCostEffect;

			public bool ToBeUpdated { get; set; }

			/// <summary>
			/// Add a new Cost related effect to the owner.
			/// </summary>
			public void AddCostAura(Playable p, Effect e)
			{
				ToBeUpdated = true;

				if (_costEffects == null)
					_costEffects = new List<Effect> {e};
				else
					_costEffects.Add(e);
			}

			/// <summary>
			/// Remove a Cost related effect from the owner.
			/// </summary>
			public void RemoveCostAura(Effect e)
			{
				if (_costEffects == null)
					return;
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

			public void ResetCost(Playable playable)
			{
				_costEffects = null;
				_adaptiveCostEffect?.Remove();
				if (playable.Game.History)
					playable.Game.PowerHistory.Add(PowerHistoryBuilder.TagChange(playable.Id, GameTag.COST, playable.Card.Cost));
			}

			internal int GetCost(int c, Playable entity)
			{
				if (ToBeUpdated)
					return GetCostInternal(c, entity);
				return c;
			}

			private int GetCostInternal(int c, Playable entity)
			{
				// Apply cost effects next. (e.g. Naga Sea Witch)
				List<Effect> effects = _costEffects;
				if (effects != null)
					for (int i = 0; i < effects.Count; i++)
					{
						Effect e = _costEffects[i];
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

				// Lastly apply Adaptive Cost Effect (e.g. Giants)
				c = _adaptiveCostEffect?.Apply(c) ?? c;

				// Dismiss negative cost.
				if (c < 0) c = 0;

				ToBeUpdated = false;

				return c;
			}
		}

		private CostManager _costManager;
		protected int? _modifiedCost;

		public void AddCostAuraEffect(Effect e)
		{
			if (_costManager == null)
			{
				var costManager = new CostManager();
				costManager.AddCostAura(this, e);
				_costManager = costManager;
			}
			else
				_costManager.AddCostAura(this, e);
		}
	}
}
