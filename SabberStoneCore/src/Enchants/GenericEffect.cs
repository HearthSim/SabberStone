using System;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Enchants
{
	internal readonly struct GenericEffect<TAttr, T> : IEffect where TAttr : Attr<T> where T : Playable
	{
		private readonly TAttr _attr;
		private readonly EffectOperator _operator;
		private readonly int _value;

		internal GenericEffect(TAttr attr, EffectOperator @operator, int value)
		{
			_attr = attr;
			_operator = @operator;
			_value = value;
		}

		public void ApplyTo(T entity)
		{
			_attr.Apply(entity, _operator, _value);
		}

		public void ApplyAuraTo(T playable)
		{
			_attr.ApplyAura(playable, _operator, _value);
		}

		public void RemoveFrom(T entity)
		{
			_attr.Remove(entity, _operator, _value);
		}

		public void RemoveAuraFrom(T playable)
		{
			_attr.RemoveAura(playable, _operator, _value);
		}

		void IEffect.ApplyTo(IEntity entity, bool oneTurnEffect = false)
		{
			if (!(entity is T playable))
				throw new Exception($"Cannot apply {this} to an entity of type {entity.GetType()}");

			if (oneTurnEffect)
				playable.Game.OneTurnEffects.Add((playable.Id, this));

			ApplyTo(playable);
		}

		void IEffect.ApplyAuraTo(IPlayable playable)
		{
			if (!(playable is T p))
				throw new Exception($"Cannot apply {this} to an entity of type {playable.GetType()}");

			ApplyAuraTo(p);
		}

		void IEffect.RemoveFrom(IEntity entity)
		{
			if (!(entity is T playable))
				throw new Exception();

			RemoveFrom(playable);
		}

		void IEffect.RemoveAuraFrom(IPlayable playable)
		{
			if (!(playable is T p))
				throw new Exception();

			RemoveAuraFrom(p);
		}

		public IEffect ChangeValue(int newValue)
		{
			return new GenericEffect<TAttr, T>(_attr, _operator, newValue);
		}

		public override string ToString()
		{
			return $"{_operator} {_attr} {_value}";
		}
	}

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
			AuraEffects auraEffects = entity.AuraEffects;
			if (auraEffects == null)
			{
				auraEffects = new AuraEffects(entity.Card.Type);
				entity.AuraEffects = auraEffects;
			}

			GetAuraRef(auraEffects)++;
		}

		public override void RemoveAura(T entity, EffectOperator @operator, int value)
		{
			GetAuraRef(entity.AuraEffects)--;
		}
	}

	internal abstract class SelfContainedIntAttr<TSelf, TTarget> : IntAttr<TTarget>
		where TSelf : SelfContainedIntAttr<TSelf, TTarget>, new() where TTarget : Playable
	{
		private static readonly TSelf _singleton = new TSelf();

		public static GenericEffect<TSelf, TTarget> Effect(EffectOperator @operator, int value)
		{
			return new GenericEffect<TSelf, TTarget>(_singleton, @operator, value);
		}
	}

	internal abstract class SelfContainedBoolAttr<TSelf, TTarget> : BoolAttr<TTarget>
		where TSelf : SelfContainedBoolAttr<TSelf, TTarget>, new() where TTarget : Playable
	{
		private static readonly TSelf _singleton = new TSelf();

		public static GenericEffect<TSelf, TTarget> Effect(bool value = true)
		{
			return new GenericEffect<TSelf, TTarget>(_singleton, EffectOperator.SET, value ? 1 : 0);
		}
	}

	internal class Cost : SelfContainedIntAttr<Cost, Playable>
	{
		protected override ref int? GetRef(Playable entity)
		{
			return ref entity._modifiedCost;
		}

		protected override int GetCardValue(Playable entity)
		{
			return entity.Card.Cost;
		}

		protected override ref int GetAuraRef(AuraEffects auraEffects)
		{
			throw new NotImplementedException();
		}

		public override void Apply(Playable entity, EffectOperator @operator, int value)
		{
			base.Apply(entity, @operator, value);

			entity._costManager?.AddCostEnchantment(@operator, value);
		}

		public override void ApplyAura(Playable entity, EffectOperator @operator, int value)
		{
			Playable.CostManager costManager = entity._costManager;
			if (costManager == null)
			{
				costManager = new Playable.CostManager();
				entity._costManager = costManager;
			}

			costManager.AddCostAura(@operator, value);
		}

		public override void RemoveAura(Playable entity, EffectOperator @operator, int value)
		{
			entity._costManager?.RemoveCostAura(@operator, value);
		}
	}

	internal class ATK : SelfContainedIntAttr<ATK, Playable>
	{
		protected override ref int? GetRef(Playable entity)
		{
			if (entity is Character c)
				return ref c._modifiedATK;
			throw new NotImplementedException();
		}

		protected override int GetCardValue(Playable entity)
		{
			return entity.Card.ATK;
		}

		protected override ref int GetAuraRef(AuraEffects auraEffects)
		{
			return ref auraEffects._data[3];
		}

		public override void Apply(Playable entity, EffectOperator @operator, int value)
		{
			if (@operator == EffectOperator.SET)
			{
				for (int i = entity.Game.OneTurnEffects.Count - 1; i >= 0; i--)
				{
					(int id, IEffect eff) = entity.Game.OneTurnEffects[i];
					if (id != entity.Id || !(eff is GenericEffect<ATK, Playable>)) continue;
					entity.Game.OneTurnEffects.RemoveAt(i);
				}
			}

			if (entity is Character)
				base.Apply(entity, @operator, value);
			else
				new Effect(Enums.GameTag.ATK, @operator, value).ApplyTo(entity);
		}

		//public override void ApplyAura(Playable entity, EffectOperator @operator, int value)
		//{
		//	if (entity is Weapon)
		//		entity = entity.Controller.Hero;

		//	base.ApplyAura(entity, @operator, value);
		//}

		//public override void RemoveAura(Playable entity, EffectOperator @operator, int value)
		//{
		//	if (entity is Weapon)
		//		entity = entity.Controller.Hero;

		//	base.RemoveAura(entity, @operator, value);
		//}
	}

	internal class Health : SelfContainedIntAttr<Health, Character>
	{
		protected override ref int? GetRef(Character entity)
		{
			return ref entity._modifiedHealth;
		}

		protected override int GetCardValue(Character entity)
		{
			return entity.Card.Health;
		}

		protected override ref int GetAuraRef(AuraEffects auraEffects)
		{
			return ref auraEffects._data[4];
		}

		public override void Apply(Character entity, EffectOperator @operator, int value)
		{
			if (@operator == EffectOperator.SET)
			{
				if (entity is Hero h)
				{
					int hbh = h.BaseHealth;
					if (hbh > value)
						h.Damage = hbh - value;
					else
						h.Health = value;
					return;
				}

				if (entity is Minion m)
				{
					m.Health = value;
					return;
				}
			}

			base.Apply(entity, @operator, value);
		}

		public override void RemoveAura(Character entity, EffectOperator @operator, int value)
		{
			base.RemoveAura(entity, @operator, value);

			if (@operator == EffectOperator.ADD)
				entity.Damage -= value;
		}
	}

	internal class Stealth : SelfContainedBoolAttr<Stealth, Character>
	{
		protected override ref bool? GetRef(Character entity)
		{
			return ref entity._modifiedStealth;
		}

		protected override ref int GetAuraRef(AuraEffects auraEffects)
		{
			throw new NotImplementedException();
		}
	}

	internal class Taunt : SelfContainedBoolAttr<Taunt, Minion>
	{
		protected override ref bool? GetRef(Minion entity)
		{
			return ref entity._modifiedTaunt;
		}

		protected override ref int GetAuraRef(AuraEffects auraEffects)
		{
			return ref auraEffects._data[6];
		}
	}

	internal class CantBeTargetedBySpells : SelfContainedBoolAttr<CantBeTargetedBySpells, Character>
	{
		protected override ref int GetAuraRef(AuraEffects auraEffects)
		{
			return ref auraEffects._data[2];
		}

		protected override ref bool? GetRef(Character entity)
		{
			return ref entity._modifiedCantBeTargetedBySpells;
		}
	}
}
