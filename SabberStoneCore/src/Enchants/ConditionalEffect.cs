using System;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Enchants
{
	/// <summary>
	/// A class for handling conditional tag value variation.
	/// </summary>
	public class ConditionalEffect : IEffect
	{
		public readonly GameTag Tag;
		public readonly EffectOperator Operator;
		private readonly Func<IPlayable, int> _valueFunction;
		private SelfCondition _condition;
		public int LastValue { get; private set; }

		public ConditionalEffect(GameTag tag, EffectOperator @operator, Func<IPlayable, int> valueFunction)
		{
			Tag = tag;
			Operator = @operator;
			_valueFunction = valueFunction;
		}

		public ConditionalEffect(GameTag tag, SelfCondition condition)
		{
			Tag = tag;
			Operator = EffectOperator.SET;
			_condition = condition;
			_valueFunction = p => _condition.Eval(p) ? 1 : 0;
		}

		public void ApplyTo(IEntity entity, bool isOneTurnEffect)
		{
			int value = _valueFunction((IPlayable)entity);

			LastValue = value;
			switch (Tag)
			{
				case GameTag.ATK:
					ATK.Effect(Operator, value).ApplyTo((Character)entity);
					break;
				case GameTag.HEALTH:
					Health.Effect(Operator, value).ApplyTo((Character)entity);
					break;
				default:
					new Effect(Tag, Operator, value).ApplyTo(entity);
					break;
			}
		}

		public void ApplyAuraTo(IPlayable playable)
		{
			int value = _valueFunction(playable);
			LastValue = value;
			switch (Tag)
			{
				case GameTag.ATK:
					ATK.Effect(Operator, value).ApplyAuraTo(playable);
					break;
				case GameTag.HEALTH:
					Health.Effect(Operator, value).ApplyAuraTo(playable);
					break;
				default:
					new Effect(Tag, Operator, value).ApplyAuraTo(playable);
					break;
			}
		}

		public void RemoveFrom(IEntity entity)
		{
			switch (Tag)
			{
				case GameTag.ATK:
					ATK.Effect(Operator, LastValue).RemoveFrom(entity);
					break;
				case GameTag.HEALTH:
					Health.Effect(Operator, LastValue).RemoveFrom(entity);
					break;
				default:
					new Effect(Tag, Operator, LastValue).RemoveFrom(entity);
					break;
			}
		}

		public void RemoveAuraFrom(IPlayable playable)
		{
			switch (Tag)
			{
				case GameTag.ATK:
					ATK.Effect(Operator, LastValue).RemoveAuraFrom(playable);
					break;
				case GameTag.HEALTH:
					Health.Effect(Operator, LastValue).RemoveAuraFrom(playable);
					break;
				default:
					new Effect(Tag, Operator, LastValue).RemoveAuraFrom(playable);
					break;
			}
		}

		public IEffect ChangeValue(int newValue)
		{
			throw new NotImplementedException();
		}

		public void RemoveValueFrom(IPlayable playable)
		{
			LastValue = _valueFunction(playable);
			RemoveAuraFrom(playable);
		}

		/// <summary>
		/// Remove the last applied effect 
		/// </summary>
		/// <param name="entity"></param>
		public void ReApplyTo(IPlayable entity)
		{
			int value = _valueFunction(entity);

			if (value == LastValue)
				return;

			switch (Tag)
			{
				case GameTag.ATK:
					ATK.Effect(Operator, LastValue).RemoveFrom(entity);
					ATK.Effect(Operator, value).ApplyTo(entity);
					break;
				case GameTag.HEALTH:
					Health.Effect(Operator, LastValue).RemoveFrom(entity);
					Health.Effect(Operator, value).ApplyTo(entity);
					break;
				default:
					new Effect(Tag, Operator, LastValue).RemoveFrom(entity);
					new Effect(Tag, Operator, value).ApplyTo(entity);
					break;
			}

			LastValue = value;
		}

		public void ReApplyAuraTo(IPlayable playable)
		{
			int value = _valueFunction(playable);

			if (_condition != null && value == LastValue)
				return;

			switch (Tag)
			{
				case GameTag.ATK:
					if (Operator == EffectOperator.SET)
					{
						if (playable is Character c)
							c._modifiedATK = 0;
						ATK.Effect(EffectOperator.ADD, LastValue).RemoveFrom(playable);
						value = value - playable.AuraEffects.ATK;
						ATK.Effect(EffectOperator.ADD, value).ApplyTo(playable);
						break;
					}

					ATK.Effect(Operator, LastValue).RemoveFrom(playable);
					ATK.Effect(Operator, value).ApplyTo(playable);
					break;
				case GameTag.HEALTH:
					Health.Effect(Operator, LastValue).RemoveFrom(playable);
					Health.Effect(Operator, value).ApplyTo(playable);
					break;
				default:
					new Effect(Tag, Operator, LastValue).RemoveAuraFrom(playable);
					new Effect(Tag, Operator, value).ApplyAuraTo(playable);
					break;
			}

			LastValue = value;
		}

		public IEffect GetInstance(IPlayable entity)
		{
			int value = _valueFunction(entity);
			switch (Tag)
			{
				case GameTag.ATK:
					return ATK.Effect(Operator, value);
				case GameTag.HEALTH:
					return Health.Effect(Operator, value);
				default:
					return new Effect(Tag, Operator, value);
			}
		}

		/// <summary>
		/// Performs deep copying of this.
		/// </summary>
		/// <returns></returns>
		public ConditionalEffect Clone()
		{
			return new ConditionalEffect(Tag, Operator, _valueFunction)
			{
				_condition = _condition,
				LastValue = LastValue
			};
		}
	}
}
