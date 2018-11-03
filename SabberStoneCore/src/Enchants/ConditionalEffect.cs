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
			var value = _valueFunction((IPlayable)entity);

			LastValue = value;
			switch (Tag)
			{
				case GameTag.ATK:
					new AttackEffect(Operator, value).ApplyTo(entity);
					break;
				case GameTag.HEALTH:
					new HealthEffect(Operator, value).ApplyTo(entity);
					break;
				default:
					new Effect(Tag, Operator, value).ApplyTo(entity);
					break;
			}
		}

		public void ApplyTo(AuraEffects auraEffects)
		{
			var value = _valueFunction((IPlayable)auraEffects.Owner);
			LastValue = value;
			switch (Tag)
			{
				case GameTag.ATK:
					new AttackEffect(Operator, value).ApplyTo(auraEffects);
					break;
				case GameTag.HEALTH:
					new HealthEffect(Operator, value).ApplyTo(auraEffects);
					break;
				default:
					new Effect(Tag, Operator, value).ApplyTo(auraEffects);
					break;
			}
		}

		public void ApplyTo(ControllerAuraEffects controllerAuraEffects)
		{
			throw new NotImplementedException();
		}

		public void RemoveFrom(IEntity entity)
		{
			switch (Tag)
			{
				case GameTag.ATK:
					new AttackEffect(Operator, LastValue).RemoveFrom(entity);
					break;
				case GameTag.HEALTH:
					new HealthEffect(Operator, LastValue).RemoveFrom(entity);
					break;
				default:
					new Effect(Tag, Operator, LastValue).RemoveFrom(entity);
					break;
			}
		}

		public void RemoveFrom(AuraEffects auraEffects)
		{
			switch (Tag)
			{
				case GameTag.ATK:
					new AttackEffect(Operator, LastValue).RemoveFrom(auraEffects);
					break;
				case GameTag.HEALTH:
					new HealthEffect(Operator, LastValue).RemoveFrom(auraEffects);
					break;
				default:
					new Effect(Tag, Operator, LastValue).RemoveFrom(auraEffects);
					break;
			}
		}

		public void RemoveFrom(ControllerAuraEffects controllerAuraEffects)
		{
			throw new NotImplementedException();
		}

		public IEffect ChangeValue(int newValue)
		{
			throw new NotImplementedException();
		}

		public void RemoveValueFrom(AuraEffects auraEffects)
		{
			LastValue = _valueFunction((IPlayable)auraEffects.Owner);
			RemoveFrom(auraEffects);
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
					new AttackEffect(Operator, LastValue).RemoveFrom(entity);
					new AttackEffect(Operator, value).ApplyTo(entity);
					break;
				case GameTag.HEALTH:
					new HealthEffect(Operator, LastValue).RemoveFrom(entity);
					new HealthEffect(Operator, value).ApplyTo(entity);
					break;
				default:
					new Effect(Tag, Operator, LastValue).RemoveFrom(entity);
					new Effect(Tag, Operator, value).ApplyTo(entity);
					break;
			}

			LastValue = value;
		}

		public void ReApplyTo(AuraEffects auraEffects)
		{
			int value = _valueFunction((IPlayable)auraEffects.Owner);

			if (_condition != null && value == LastValue)
				return;

			switch (Tag)
			{
				case GameTag.ATK:
					if (Operator == EffectOperator.SET)
					{
						if (auraEffects.Owner is Character c)
							c._atkModifier = 0;
						new AttackEffect(EffectOperator.ADD, LastValue).RemoveFrom(auraEffects);
						value = value - auraEffects.AttackDamage;
						new AttackEffect(EffectOperator.ADD, value).ApplyTo(auraEffects);
						break;
					}

					new AttackEffect(Operator, LastValue).RemoveFrom(auraEffects);
					new AttackEffect(Operator, value).ApplyTo(auraEffects);
					break;
				case GameTag.HEALTH:
					new HealthEffect(Operator, LastValue).RemoveFrom(auraEffects);
					new HealthEffect(Operator, value).ApplyTo(auraEffects);
					break;
				default:
					new Effect(Tag, Operator, LastValue).RemoveFrom(auraEffects);
					new Effect(Tag, Operator, value).ApplyTo(auraEffects);
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
					return new AttackEffect(Operator, value);
				case GameTag.HEALTH:
					return new HealthEffect(Operator, value);
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
