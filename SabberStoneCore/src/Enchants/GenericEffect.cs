using System;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Enchants
{
	internal abstract class Attr<T> where T : Playable
	{
		public abstract void Apply(T entity, EffectOperator @operator, int value);
		public abstract void ApplyAura(T entity, EffectOperator @operator, int value);
		public abstract void Remove(T entity, EffectOperator @operator, int value);
		public abstract void RemoveAura(T entity, EffectOperator @operator, int value);

		protected abstract ref int GetAuraRef(AuraEffects auraEffects);
	}

	internal abstract class IntAttr<T> : Attr<T> where T : Playable
	{
		protected abstract ref int? GetRef(T entity);

		protected abstract int GetCardValue(T entity);

		public override void Apply(T entity, EffectOperator @operator, int value)
		{
			ref int? target = ref GetRef(entity);

			if (@operator == EffectOperator.SET)
			{
				target = value;
				return;
			}

			int baseValue = target ?? GetCardValue(entity);

			switch (@operator)
			{
				case EffectOperator.ADD:
					target = baseValue + value;
					break;
				case EffectOperator.SUB:
					target = baseValue - value;
					break;
				case EffectOperator.MUL:
					target = baseValue * value;
					break;
				default:
					throw new ArgumentOutOfRangeException(nameof(@operator), @operator, null);
			}
		}

		public override void Remove(T entity, EffectOperator @operator, int value)
		{
			ref int? target = ref GetRef(entity);

			if (!target.HasValue)
				return;

			switch (@operator)
			{
				case EffectOperator.ADD:
					target -= value;
					break;
				case EffectOperator.SUB:
					target += value;
					break;
				default:
					throw new ArgumentOutOfRangeException(nameof(@operator), @operator, null);
			}
		}

		public override void ApplyAura(T entity, EffectOperator @operator, int value)
		{
			AuraEffects auraEffects = entity.AuraEffects;
			if (auraEffects == null)
			{
				auraEffects = new AuraEffects(entity.Card.Type);
				entity.AuraEffects = auraEffects;
			}

			ref int target = ref GetAuraRef(auraEffects);

			switch (@operator)
			{
				case EffectOperator.ADD:
					target += value;
					break;
				case EffectOperator.SUB:
					target -= value;
					break;
				case EffectOperator.MUL:
					target *= value;
					break;
				case EffectOperator.SET:
					GetRef(entity) = 0;
					target = value;
					break;
				default:
					throw new ArgumentOutOfRangeException(nameof(@operator), @operator, null);
			}
		}

		public override void RemoveAura(T entity, EffectOperator @operator, int value)
		{
			ref int target = ref GetAuraRef(entity.AuraEffects);

			switch (@operator)
			{
				case EffectOperator.ADD:
					target -= value;
					return;
				case EffectOperator.SUB:
					target += value;
					return;
				case EffectOperator.SET:
					target -= value;
					return;
				default:
					throw new NotImplementedException();
			}
		}
	}

	internal abstract class BoolAttr<T> : Attr<T> where T : Playable
	{
		protected abstract ref bool? GetRef(T entity);

		public override void Apply(T entity, EffectOperator @operator, int value)
		{
			ref bool? target = ref GetRef(entity);

			if (@operator != EffectOperator.SET)
				throw new ArgumentOutOfRangeException(nameof(@operator), @operator, null);

			target = value > 0;
		}

		public override void Remove(T entity, EffectOperator @operator, int value)
		{
			ref bool? target = ref GetRef(entity);

			target = false;
		}

		public override void ApplyAura(T entity, EffectOperator @operator, int value)
		{
			GetAuraRef(entity.AuraEffects)++;
		}

		public override void RemoveAura(T entity, EffectOperator @operator, int value)
		{
			GetAuraRef(entity.AuraEffects)--;
		}
	}

	internal readonly struct GenericEffect<T, F> : IEffect where T : Attr<F> where F : Playable
	{
		private readonly T _attr;
		private readonly EffectOperator _operator;
		private readonly int _value;

		public GenericEffect(T attr, EffectOperator @operator, int value)
		{
			_attr = attr;
			_operator = @operator;
			_value = value;
		}

		private void ApplyTo(F entity)
		{
			_attr.Apply(entity, _operator, _value);
		}

		public void ApplyTo(IEntity entity, bool isOneTurnEffect)
		{
			if (!(entity is F playable))
				throw new Exception();

			_attr.Apply(playable, _operator, _value);
		}

		public void ApplyAuraTo(IPlayable playable)
		{
			if (!(playable is F p))
				throw new Exception();

			_attr.ApplyAura(p, _operator, _value);
		}

		public void RemoveFrom(IEntity entity)
		{
			if (!(entity is F playable))
				throw new Exception();

			_attr.Remove(playable, _operator, _value);
		}

		public void RemoveAuraFrom(IPlayable playable)
		{
			if (!(playable is F p))
				throw new Exception();

			_attr.RemoveAura(p, _operator, _value);
		}

		public IEffect ChangeValue(int newValue)
		{
			return new GenericEffect<T, F>(_attr, _operator, newValue);
		}
	}
}
