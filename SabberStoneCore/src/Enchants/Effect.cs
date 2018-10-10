using System;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Enchants
{
	public enum EffectOperator
	{
		ADD, SUB, MUL, SET
	}

	public interface IEffect
	{
		void ApplyTo(IEntity entity, bool isOneTurnEffect);
		void ApplyTo(AuraEffects auraEffects);
		void ApplyTo(ControllerAuraEffects controllerAuraEffects);

		void RemoveFrom(IEntity entity);
		void RemoveFrom(AuraEffects auraEffects);
		void RemoveFrom(ControllerAuraEffects controllerAuraEffects);

		IEffect ChangeValue(int newValue);
	}

	/// <summary>
	/// Represents an effect of <see cref="Aura"/>s or <see cref="Enchantment"/> cards.
	/// </summary>
	public readonly struct Effect : IEffect, IEquatable<Effect>
	{
		public readonly GameTag Tag;
		public readonly EffectOperator Operator;
		public readonly int Value;

		/// <summary>
		/// Create a new Effect. An Effect is consist of <see cref="GameTag"/>, <see cref="EffectOperator"/>, and <see cref="int"/> value.
		/// </summary>
		/// <param name="tag">The <see cref="GameTag"/> to be affected.</param>
		public Effect(GameTag tag, EffectOperator @operator, int value)
		{
			Tag = tag;
			Operator = @operator;
			Value = value;
		}

		/// <summary>
		/// Apply this effect to the target entity.
		/// </summary>
		public void ApplyTo(IEntity entity, bool oneTurnEffect = false)
		{
			if (!entity.NativeTags.ContainsKey(Tag))
				entity.NativeTags.Add(Tag, entity.Card[Tag]);

			if (oneTurnEffect)
				entity.Game.OneTurnEffects.Add((entity.Id, this));

			if (Tag == GameTag.COST)
				entity.AuraEffects.ToBeUpdated = true;

			switch (Operator)
			{
				case EffectOperator.ADD:
					entity.NativeTags[Tag] += Value;
					if (Tag == GameTag.SPELLPOWER)
						entity.Controller.CurrentSpellPower += Value;
					break;
				case EffectOperator.SUB:
					entity.NativeTags[Tag] -= Value;
					break;
				case EffectOperator.MUL:
					entity.NativeTags[Tag] *= Value;
					break;
				case EffectOperator.SET:
					// experimental implmentation for simulating tricky situations
					switch (Tag)
					{
						case GameTag.CHARGE:
							if (entity[GameTag.EXHAUSTED] == 1 && entity[GameTag.NUM_ATTACKS_THIS_TURN] == 0)
								entity[GameTag.EXHAUSTED] = 0;
							if (((Minion)entity).AttackableByRush)
								entity[GameTag.ATTACKABLE_BY_RUSH] = 0;
							break;
						case GameTag.WINDFURY:
							Minion m = entity as Minion;
							if (m.NumAttacksThisTurn > 0 && m.IsExhausted)
								m.IsExhausted = false;
							break;
						case GameTag.TAUNT:
							((Character) entity).HasTaunt = Value > 0;
							return;
						case GameTag.IMMUNE:
							if (entity is Character c)
								c.IsImmune = Value > 0;
							else
								break;
							return;
					}

					if (oneTurnEffect && entity.NativeTags[Tag] == Value)
						entity.Game.OneTurnEffects.Remove((entity.Id, this));

					entity.NativeTags[Tag] = Value;

					break;
	
				default:
					throw new ArgumentException();
			}
		}

		/// <summary>
		/// Apply this effect to the target as an aura effect.
		/// </summary>
		public void ApplyTo(AuraEffects auraEffects)
		{
			if (Tag == GameTag.COST)
			{
				auraEffects.AddCostAura(this);
				return;
			}

			switch (Operator)
			{
				case EffectOperator.ADD:
					auraEffects[Tag] += Value;
					return;
				case EffectOperator.SUB:
					auraEffects[Tag] -= Value;
					return;
				// TODO: SET Aura
				case EffectOperator.SET:
					auraEffects.Owner[Tag] = 0;
					auraEffects[Tag] = Value;
					return;
				default:
					throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Apply this effect to the target controller as an aura effect.
		/// </summary>
		public void ApplyTo(ControllerAuraEffects auraEffects)
		{
			switch (Operator)
			{
				case EffectOperator.ADD:
				case EffectOperator.SET:
					auraEffects[Tag] += Value;
					return;
				case EffectOperator.SUB:
					auraEffects[Tag] += Value;
					return;
				default:
					throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Remove this effect from the target entity.
		/// </summary>
		public void RemoveFrom(IEntity entity)
		{
			// TODO
			if (Tag == GameTag.COST)
			{
				if (!entity.NativeTags.ContainsKey(GameTag.COST))
					return;
			}

			switch (Operator)
			{
				case EffectOperator.ADD:
					entity[Tag] -= Value;
					if (Tag == GameTag.SPELLPOWER)
						entity.Controller.CurrentSpellPower -= Value;
					return;
				case EffectOperator.SUB:
					entity[Tag] = entity.NativeTags[Tag] + Value;
					return;
				case EffectOperator.SET:
					entity[Tag] = 0;		// unstable
					return;
			}
		}

		/// <summary>
		/// Remove ths aura effect from the target entity.
		/// </summary>
		public void RemoveFrom(AuraEffects auraEffects)
		{
			if (Tag == GameTag.COST)
			{
				auraEffects.RemoveCostAura(this);
				return;
			}

			switch (Operator)
			{
				case EffectOperator.ADD:
					auraEffects[Tag] -= Value;
					return;
				case EffectOperator.SUB:
					auraEffects[Tag] += Value;
					return;
				case EffectOperator.SET:
					auraEffects[Tag] -= Value;
					return;
			}
		}

		public void RemoveFrom(ControllerAuraEffects auraEffects)
		{
			switch (Operator)
			{
				case EffectOperator.ADD:
				case EffectOperator.SET:
					auraEffects[Tag] -= Value;
					return;
				case EffectOperator.SUB:
					auraEffects[Tag] += Value;
					return;
				default:
					throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Creates a new Effect having changed amount of <see cref="Value"/>.
		/// </summary>
		public IEffect ChangeValue(int newValue)
		{
			return new Effect(Tag, Operator, newValue);
		}


		public bool Equals(Effect other)
		{
			return Tag == other.Tag && Operator == other.Operator && Value == other.Value;
		}

		public override bool Equals(object obj)
		{
			if (obj is null) return false;
			return obj is Effect effect && Equals(effect);
		}

		public static bool operator ==(Effect e1, Effect e2) => e1.Equals(e2);

		public static bool operator !=(Effect e1, Effect e2) => !(e1.Equals(e2));

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = (int) Tag;
				hashCode = (hashCode * 397) ^ (int) Operator;
				hashCode = (hashCode * 397) ^ Value;
				return hashCode;
			}
		}
		public override string ToString()
		{
			return $"[{Operator} {Tag} {Value}]";
		}
	}

	public readonly struct AttackEffect : IEffect
	{
		private readonly EffectOperator _operator;
		private readonly int _value;

		public AttackEffect(EffectOperator @operator, int value)
		{
			_value = value;
			_operator = @operator;
		}

		public void ApplyTo(IEntity entity, bool isOneTurnEffect = false)
		{
			if (!(entity is Character c))
			{
				if (entity is Weapon w)
				{
					new Effect(GameTag.ATK, _operator, _value).ApplyTo(w);
					return;
				}
				throw new ArgumentException($"Can't apply attack enchant to a non-character {entity}");
			}

			ref int target = ref c._atkModifier;

			if (isOneTurnEffect)
				entity.Game.OneTurnEffects.Add((entity.Id, this));

			switch (_operator)
			{
				case EffectOperator.ADD:
					target += _value;
					break;
				case EffectOperator.MUL:
					target *= _value;
					break;
				case EffectOperator.SUB:
					target -= _value;
					break;
				case EffectOperator.SET:
					for (int i = entity.Game.OneTurnEffects.Count - 1; i >= 0; i--)
					{
						(int id, IEffect eff) = entity.Game.OneTurnEffects[i];
						if (id != entity.Id || !(eff is AttackEffect)) continue;
						entity.Game.OneTurnEffects.RemoveAt(i);
					}
					if (isOneTurnEffect && target == _value)
						entity.Game.OneTurnEffects.Remove((entity.Id, this));

					target = _value;
					break;
			}
		}

		public void ApplyTo(AuraEffects auraEffects)
		{
			switch (_operator)
			{
				case EffectOperator.ADD:
					auraEffects.AttackDamage += _value;
					return;
				case EffectOperator.SUB:
					auraEffects.AttackDamage -= _value;
					return;
				// TODO: SET Aura
				case EffectOperator.SET:
					if (!(auraEffects.Owner is Character c))
						throw new ArgumentException($"Can't apply attack enchant to a non-character {auraEffects.Owner}");
					c._atkModifier = 0;
					auraEffects.AttackDamage = _value;
					return;
				default:
					throw new NotImplementedException();
			}
		}

		public void ApplyTo(ControllerAuraEffects controllerAuraEffects)
		{
			throw new NotImplementedException();
		}

		public void RemoveFrom(IEntity entity)
		{
			if (!(entity is Character c)) throw new ArgumentException($"Can't apply attack enchant to a non-character {entity}");

			ref int target = ref c._atkModifier;

			switch (_operator)
			{
				case EffectOperator.ADD:
					target -= _value;
					return;
				case EffectOperator.SUB:
					target += _value;
					return;
				default:
					throw new NotImplementedException();
			}
		}

		public void RemoveFrom(AuraEffects auraEffects)
		{
			switch (_operator)
			{
				case EffectOperator.ADD:
					auraEffects.AttackDamage -= _value;
					return;
				case EffectOperator.SUB:
					auraEffects.AttackDamage += _value;
					return;
				case EffectOperator.SET:
					auraEffects.AttackDamage -= _value;
					return;
				case EffectOperator.MUL:
					throw new NotImplementedException();
			}
		}

		public void RemoveFrom(ControllerAuraEffects controllerAuraEffects)
		{
			throw new NotImplementedException();
		}

		public IEffect ChangeValue(int newValue)
		{
			return new AttackEffect(_operator, newValue);
		}
	}

	public readonly struct HealthEffect : IEffect
	{
		private readonly EffectOperator _operator;
		private readonly int _value;

		public HealthEffect(EffectOperator @operator, int value)
		{
			_operator = @operator;
			_value = value;
		}

		public void ApplyTo(IEntity entity, bool isOneTurnEffect = false)
		{
			if (!(entity is Character c)) throw new ArgumentException($"Can't apply attack enchant to a non-character {entity}");

			ref int target = ref c._healthModifier;

			if (isOneTurnEffect)
				entity.Game.OneTurnEffects.Add((entity.Id, this));

			switch (_operator)
			{
				case EffectOperator.ADD:
					target += _value;
					break;
				case EffectOperator.MUL:
					target *= _value;
					break;
				case EffectOperator.SUB:
					target -= _value;
					break;
				case EffectOperator.SET:
					if (entity is Hero h)
					{
						int hbh = h.BaseHealth;
						if (hbh > _value)
							h.Damage = hbh - _value;
						else
							h.Health = _value;
						return;
					}
					((Minion)entity).Health = _value;
					break;
			}
		}

		public void ApplyTo(AuraEffects auraEffects)
		{
			switch (_operator)
			{
				case EffectOperator.ADD:
					auraEffects.Health += _value;
					return;
				case EffectOperator.SUB:
					auraEffects.Health -= _value;
					return;
				// TODO: SET Aura
				case EffectOperator.SET:
					if (!(auraEffects.Owner is Character c))
						throw new ArgumentException($"Can't apply attack enchant to a non-character {auraEffects.Owner}");
					c._healthModifier = 0;
					auraEffects.Health = _value;
					return;
				default:
					throw new NotImplementedException();
			}
		}

		public void ApplyTo(ControllerAuraEffects controllerAuraEffects)
		{
			throw new NotImplementedException();
		}

		public void RemoveFrom(IEntity entity)
		{
			if (!(entity is Character c)) throw new ArgumentException($"Can't apply attack enchant to a non-character {entity}");

			ref int target = ref c._healthModifier;

			switch (_operator)
			{
				case EffectOperator.ADD:
					target -= _value;
					return;
				case EffectOperator.SUB:
					target += _value;
					return;
				default:
					throw new NotImplementedException();
			}
		}

		public void RemoveFrom(AuraEffects auraEffects)
		{
			switch (_operator)
			{
				case EffectOperator.ADD:
					auraEffects.Health -= _value;
					((Character)auraEffects.Owner).Damage -= _value;
					return;
				case EffectOperator.SUB:
					auraEffects.Health += _value;
					return;
				case EffectOperator.SET:
					auraEffects.Health -= _value;
					return;
				case EffectOperator.MUL:
					throw new NotImplementedException();
			}
		}

		public void RemoveFrom(ControllerAuraEffects controllerAuraEffects)
		{
			throw new NotImplementedException();
		}

		public IEffect ChangeValue(int newValue)
		{
			return new HealthEffect(_operator, newValue);
		}
	}

	public readonly struct StealthEffect : IEffect
	{
		public void ApplyTo(IEntity entity, bool isOneTurnEffect = false)
		{
			var c = (Character)entity;
			c.HasStealth = true;
		}

		public void ApplyTo(AuraEffects auraEffects)
		{
			throw new NotImplementedException();
		}

		public void ApplyTo(ControllerAuraEffects controllerAuraEffects)
		{
			throw new NotImplementedException();
		}

		public void RemoveFrom(IEntity entity)
		{
			var c = (Character)entity;
			c.HasStealth = false;
		}

		public void RemoveFrom(AuraEffects auraEffects)
		{
			throw new NotImplementedException();
		}

		public void RemoveFrom(ControllerAuraEffects controllerAuraEffects)
		{
			throw new NotImplementedException();
		}

		public IEffect ChangeValue(int newValue)
		{
			throw new NotImplementedException();
		}
	}
}
