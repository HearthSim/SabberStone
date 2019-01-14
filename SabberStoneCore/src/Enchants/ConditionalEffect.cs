//using System;
//using SabberStoneCore.Conditions;
//using SabberStoneCore.Enums;
//using SabberStoneCore.Model.Entities;

//namespace SabberStoneCore.Enchants
//{
//	/// <summary>
//	/// A class for handling conditional tag value variation.
//	/// </summary>
//	public class ConditionalEffect
//	{
//		public readonly GameTag Tag;
//		public readonly EffectOperator Operator;
//		private readonly Func<Character, int> _valueFunction;
//		private SelfCondition _condition;
//		public int LastValue { get; private set; }

//		public ConditionalEffect(GameTag tag, EffectOperator @operator, Func<Character, int> valueFunction)
//		{
//			Tag = tag;
//			Operator = @operator;
//			_valueFunction = valueFunction;
//		}

//		public ConditionalEffect(GameTag tag, SelfCondition condition)
//		{
//			Tag = tag;
//			Operator = EffectOperator.SET;
//			_condition = condition;
//			_valueFunction = p => _condition.Eval(p) ? 1 : 0;
//		}

//		public void ApplyTo(Character entity, bool isOneTurnEffect)
//		{
//			int value = _valueFunction(entity);

//			LastValue = value;
//			switch (Tag)
//			{
//				case GameTag.ATK:
//					ATK.Effect(Operator, value).ApplyTo(entity);
//					break;
//				case GameTag.HEALTH:
//					Health.Effect(Operator, value).ApplyTo(entity);
//					break;
//				default:
//					new Effect(Tag, Operator, value).ApplyTo(entity);
//					break;
//			}
//		}

//		public void ApplyAuraTo(Character playable)
//		{
//			int value = _valueFunction(playable);
//			LastValue = value;
//			switch (Tag)
//			{
//				case GameTag.ATK:
//					ATK.Effect(Operator, value).ApplyAuraTo(playable);
//					break;
//				case GameTag.HEALTH:
//					Health.Effect(Operator, value).ApplyAuraTo(playable);
//					break;
//				default:
//					new Effect(Tag, Operator, value).ApplyAuraTo(playable);
//					break;
//			}
//		}

//		public void RemoveFrom(Character entity)
//		{
//			switch (Tag)
//			{
//				case GameTag.ATK:
//					ATK.Effect(Operator, LastValue).RemoveFrom(entity);
//					break;
//				case GameTag.HEALTH:
//					Health.Effect(Operator, LastValue).RemoveFrom(entity);
//					break;
//				default:
//					new Effect(Tag, Operator, LastValue).RemoveFrom(entity);
//					break;
//			}
//		}

//		public void RemoveAuraFrom(Character playable)
//		{
//			switch (Tag)
//			{
//				case GameTag.ATK:
//					ATK.Effect(Operator, LastValue).RemoveAuraFrom(playable);
//					break;
//				case GameTag.HEALTH:
//					Health.Effect(Operator, LastValue).RemoveAuraFrom(playable);
//					break;
//				default:
//					new Effect(Tag, Operator, LastValue).RemoveAuraFrom(playable);
//					break;
//			}
//		}

//		public void RemoveValueFrom(Character playable)
//		{
//			LastValue = _valueFunction(playable);
//			RemoveAuraFrom(playable);
//		}

//		/// <summary>
//		/// Remove the last applied effect 
//		/// </summary>
//		/// <param name="entity"></param>
//		public void ReApplyTo(Character entity)
//		{
//			int value = _valueFunction(entity);

//			if (value == LastValue)
//				return;

//			switch (Tag)
//			{
//				case GameTag.ATK:
//					ATK.Effect(Operator, LastValue).RemoveFrom(entity);
//					ATK.Effect(Operator, value).ApplyTo(entity);
//					break;
//				case GameTag.HEALTH:
//					Health.Effect(Operator, LastValue).RemoveFrom(entity);
//					Health.Effect(Operator, value).ApplyTo(entity);
//					break;
//				default:
//					new Effect(Tag, Operator, LastValue).RemoveFrom(entity);
//					new Effect(Tag, Operator, value).ApplyTo(entity);
//					break;
//			}

//			LastValue = value;
//		}

//		public void ReApplyAuraTo(Character playable)
//		{
//			int value = _valueFunction(playable);

//			if (_condition != null && value == LastValue)
//				return;

//			switch (Tag)
//			{
//				case GameTag.ATK:
//					if (Operator == EffectOperator.SET)
//					{
//						playable._modifiedATK = 0;
//						ATK.Effect(EffectOperator.ADD, LastValue).RemoveAuraFrom(playable);
//						value = value - (playable.AuraEffects?.ATK ?? 0);
//						ATK.Effect(EffectOperator.ADD, value).ApplyAuraTo(playable);
//						break;
//					}

//					ATK.Effect(Operator, LastValue).RemoveAuraFrom(playable);
//					ATK.Effect(Operator, value).ApplyAuraTo(playable);
//					break;
//				case GameTag.HEALTH:
//					Health.Effect(Operator, LastValue).RemoveAuraFrom(playable);
//					Health.Effect(Operator, value).ApplyAuraTo(playable);
//					break;
//				default:
//					new Effect(Tag, Operator, LastValue).RemoveAuraFrom(playable);
//					new Effect(Tag, Operator, value).ApplyAuraTo(playable);
//					break;
//			}

//			LastValue = value;
//		}

//		/// <summary>
//		/// Performs deep copying of this.
//		/// </summary>
//		/// <returns></returns>
//		public ConditionalEffect Clone()
//		{
//			return new ConditionalEffect(Tag, Operator, _valueFunction)
//			{
//				_condition = _condition,
//				LastValue = LastValue
//			};
//		}
//	}
//}
