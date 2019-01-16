#region copyright
// SabberStone, Hearthstone Simulator in C# .NET Core
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
#endregion
using System;
using SabberStoneCore.Enums;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Enchants
{
	public enum EffectOperator
	{
		ADD, SUB, MUL, SET
	}

	/// <summary>
	/// Defines methods for tags value variation.
	/// </summary>
	public interface IEffect
	{
		void ApplyTo(IEntity entity, bool isOneTurnEffect = false);
		void ApplyAuraTo(IPlayable playable);
		//void ApplyTo(AuraEffects auraEffects);
		//void ApplyTo(ControllerAuraEffects controllerAuraEffects);

		void RemoveFrom(IEntity entity);
		void RemoveAuraFrom(IPlayable playable);
		//void RemoveFrom(AuraEffects auraEffects);
		//void RemoveFrom(ControllerAuraEffects controllerAuraEffects);

		IEffect ChangeValue(int newValue);
	}

	/// <summary>
	///	A structure for tag value variation.
	/// </summary>
	public readonly struct Effect : IEffect, IEquatable<Effect>
	{
		public readonly GameTag Tag;
		public readonly EffectOperator Operator;
		public readonly int Value;

		/// <summary>
		/// Create a new Effect. An Effect consists of <see cref="GameTag"/>, <see cref="EffectOperator"/>, and <see cref="int"/> value.
		/// </summary>
		/// <param name="tag">The <see cref="GameTag"/> to be affected.</param>
		/// <param name="operator">The operation this effect performs.</param>
		/// <param name="value">The right operand of the operator.</param>
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
							{
								var m = (Minion)entity;
								if (m.IsExhausted && m.NumAttacksThisTurn == 0)
									m.IsExhausted = false;
								if (m.AttackableByRush)
									m.AttackableByRush = false;
								break;
							}
						case GameTag.WINDFURY:
							{
								var m = (Minion)entity;
								if (m.NumAttacksThisTurn > 0 && m.IsExhausted)
									m.IsExhausted = false;
								break;
							}
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
		public void ApplyAuraTo(IPlayable playable)
		{
			AuraEffects auraEffects = playable.AuraEffects;
			if (auraEffects == null)
			{
				auraEffects = new AuraEffects(playable.Card.Type);
				playable.AuraEffects = auraEffects;
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
					//playable[Tag] = 0;
					auraEffects[Tag] = Value;

					if (playable is Minion m)
					{
						switch (Tag)
						{
							case GameTag.CHARGE:
								if (m.IsExhausted && m._numAttackThisTurn < 1)
									m.IsExhausted = false;
								if (m.AttackableByRush)
									m.AttackableByRush = false;
								break;
							case GameTag.RUSH:
								if (m.IsExhausted && m._numAttackThisTurn == 0)
								{
									m.IsExhausted = false;
									m.AttackableByRush = true;
									playable.Game.RushMinions.Add(playable.Id);
								}
								break;
							case GameTag.HEALTH_MINIMUM:
								m[GameTag.HEALTH_MINIMUM] = Value;
								break;
						}
					}
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
		public void RemoveAuraFrom(IPlayable playable)
		{
			switch (Operator)
			{
				case EffectOperator.ADD:
					playable.AuraEffects[Tag] -= Value;
					return;
				case EffectOperator.SUB:
					playable.AuraEffects[Tag] += Value;
					return;
				case EffectOperator.SET:
					playable.AuraEffects[Tag] -= Value;
					if (Tag == GameTag.RUSH)
					{
						var m = (Minion)playable;
						if (m.AttackableByRush && !m.IsExhausted)
						{
							if (m.IsRush || m.Card.Rush)
								return;

							m.AttackableByRush = false;
							m.IsExhausted = true;
							m.Game.RushMinions.Remove(m.Id);
						}
					}
					else if
						(Tag == GameTag.HEALTH_MINIMUM)
					{
						playable.NativeTags.Remove(GameTag.HEALTH_MINIMUM);
					}
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
}
