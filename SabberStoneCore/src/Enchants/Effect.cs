using System;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Enchants
{
	public enum EffectOperator
	{
		ADD, SUB, MUL, SET
	}

	public struct Effect : IEquatable<Effect>
	{
		public readonly GameTag Tag;
		public readonly EffectOperator Operator;
		public readonly int Value;


		public Effect(GameTag tag, EffectOperator @operator, int value)
		{
			Tag = tag;
			Operator = @operator;
			Value = value;

		}


		public void Apply(IEntity entity, bool oneTurnEffect = false)
		{
			if (!entity.NativeTags.ContainsKey(Tag))
				entity.NativeTags.Add(Tag, entity.Card[Tag]);

			if (oneTurnEffect)
				entity.Game.OneTurnEffects.Add((entity.Id, this));

			if (Tag == GameTag.COST)
				entity.AuraEffects.Checker = true;

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
					if (Tag == GameTag.ATK)
						for (int i = entity.Game.OneTurnEffects.Count - 1; i >= 0; i--)
						{
							(int id, Effect eff) = entity.Game.OneTurnEffects[i];
							if (id != entity.Id || eff.Tag != GameTag.ATK) continue;

							entity.Game.OneTurnEffects.Remove((id, eff));
						}
					else if (Tag == GameTag.HEALTH)
					{
						((ICharacter)entity).Health = Value;
						break;
					}
					else if (Tag == GameTag.WINDFURY)
					{
						Minion m = entity as Minion;
						if (m.NumAttacksThisTurn > 0 && m.IsExhausted)
							m.IsExhausted = false;
					}

					if (oneTurnEffect && entity.NativeTags[Tag] == Value)
						entity.Game.OneTurnEffects.Remove((entity.Id, this));

					entity.NativeTags[Tag] = Value;

					break;
	
				default:
					throw new ArgumentException();
			}
		}

		public void Apply(AuraEffects auraEffects)
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
					auraEffects[Tag] += Value;
					return;
				// TODO: SET Aura
				case EffectOperator.SET:
					auraEffects[Tag] += Value;
					return;
				default:
					throw new NotImplementedException();
			}
		}

		public void Apply(ControllerAuraEffects auraEffects)
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

		public void Remove(IEntity entity)
		{
			switch (Operator)
			{
				case EffectOperator.ADD:
					entity[Tag] -= Value;
					return;
				case EffectOperator.SUB:
					entity[Tag] += Value;
					return;
				case EffectOperator.SET:
					entity[Tag] = 0;		// unstable
					return;
			}
		}

		public void Remove(AuraEffects auraEffects)
		{
			if (Tag == GameTag.COST)
			{
				auraEffects.RemoveCostAura(this);
				return;
			}

			if (Tag == GameTag.HEALTH && Operator == EffectOperator.ADD)
			{
				((ICharacter)auraEffects.Owner).Damage -= Value;
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

		public void Remove(ControllerAuraEffects auraEffects)
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

		public Effect ChangeValue(int newValue)
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
}
