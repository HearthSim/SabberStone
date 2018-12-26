//using System;
//using System.Collections.Generic;
//using System.Text;
//using SabberStoneCore.Auras;
//using SabberStoneCore.Enchants;
//using SabberStoneCore.Enums;
//using SabberStoneCore.Kettle;
//using SabberStoneCore.Model.Entities;

//namespace SabberStoneCore.src.Model
//{
//	internal class CostManager
//	{
//		private int? _modifiedCost;
//		private List<Effect> _costEffects;
//		private AdaptiveCostEffect _adaptiveCostEffect;

//		internal bool ToBeUpdated { get; set; }

//		/// <summary>
//		/// Add a new Cost related effect to the owner.
//		/// </summary>
//		public void AddCostAura(in Effect e)
//		{
//			ToBeUpdated = true;

//			if (_costEffects == null)
//				_costEffects = new List<Effect> { e };
//			else
//				_costEffects.Add(e);
//		}

//		/// <summary>
//		/// Remove a Cost related effect from the owner.
//		/// </summary>
//		public void RemoveCostAura(in Effect e)
//		{
//			if (_costEffects == null)
//				return;
//			ToBeUpdated = true;
//			if (_costEffects.Remove(e)) return;

//			throw new Exception($"Can't remove cost aura {e}");
//		}

//		private void ResetCost(Playable playable)
//		{
//			if (_costEffects == null && _adaptiveCostEffect == null && _modifiedCost == null) return;

//			_costEffects = null;
//			_adaptiveCostEffect?.Remove();
//			_modifiedCost = null;
//			if (Owner.Game.History)
//				Owner.Game.PowerHistory.Add(PowerHistoryBuilder.TagChange(Owner.Id, GameTag.COST, Cost));
//		}

//		internal int GetCostInternal(Playable entity)
//		{
//			// Get base cost or modified cost first.
//			int c = _modifiedCost ?? entity.Card.Cost;

//			// Apply cost effects next. (e.g. Naga Sea Witch)
//			if (_costEffects != null)
//				foreach (Effect e in _costEffects)
//				{
//					switch (e.Operator)
//					{
//						case EffectOperator.ADD:
//							c += e.Value;
//							break;
//						case EffectOperator.SUB:
//							c -= e.Value;
//							if (c < 0) c = 0;
//							break;
//						case EffectOperator.SET:
//							c = e.Value;
//							break;
//						default:
//							throw new ArgumentOutOfRangeException();
//					}
//				}

//			// Lastly apply Adaptive Cost Effect (e.g. Giants)
//			if (_adaptiveCostEffect != null)
//				c = _adaptiveCostEffect.Apply(c);

//			// Dismiss negative cost.
//			if (c < 0) c = 0;

//			return c;
//		}
//	}
//}
