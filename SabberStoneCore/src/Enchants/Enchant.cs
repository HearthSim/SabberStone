using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks;

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

		public void Apply(IEntity entity)
		{
			if (!entity.NativeTags.ContainsKey(Tag))
				entity.NativeTags.Add(Tag, entity.Card[Tag]);

			switch (Operator)
			{
				case EffectOperator.ADD:
					entity.NativeTags[Tag] += Value;
					break;
				case EffectOperator.SUB:
					entity.NativeTags[Tag] -= Value;
					break;
				case EffectOperator.MUL:
					entity.NativeTags[Tag] *= Value;
					break;
				case EffectOperator.SET:
					entity.NativeTags[Tag] = Value;
					// experimental implmentation for simulating tricky situations
					if (Tag == GameTag.ATK)
						for (int i = entity.Game.OneTurnEffects.Count - 1; i >= 0; i--)
						{
							(int id, Effect eff) = entity.Game.OneTurnEffects[i];
							if (id != entity.Id || eff.Tag != GameTag.ATK) continue;

							entity.Game.OneTurnEffects.Remove((id, eff));
						}
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
					auraEffects[Tag] = Value;
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
					entity[Tag] = 0;
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
					auraEffects[Tag] = 0;
					return;
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
	}

	public class Enchant
    {
		public Game Game;
	    public readonly Effect[] Effects;
	    public bool UseScriptTag;
	    public ISimpleTask TaskToDoWhenThisIsRemoved;
		
	    public Enchant(GameTag tag, EffectOperator @operator, int value)
	    {
		    Effects = new[] {new Effect(tag, @operator, value)};
	    }

	    public Enchant(params Effect[] effects)
	    {
			Effects = effects;
	    }

		public bool IsOneTurnEffect { get; set; }

		public virtual void ActivateTo(IEntity entity, Enchantment enchantment, int num1 = 0, int num2 = -1)
		{
			if (!UseScriptTag)
				for (int i = 0; i < Effects.Length; i++)
					Effects[i].Apply(entity);
			else if (enchantment != null)
			{
				//for (int i = 0; i < Effects.Length; i++)
				//	new Effect(Effects[i].Tag, Effects[i].Operator, enchantment[GameTag.TAG_SCRIPT_DATA_NUM_1]).Apply(entity);
				Effects[0].ChangeValue(enchantment[GameTag.TAG_SCRIPT_DATA_NUM_1]).Apply(entity);

				if (Effects.Length != 2) return;

				if (enchantment[GameTag.TAG_SCRIPT_DATA_NUM_2] > 0)
					Effects[1].ChangeValue(enchantment[GameTag.TAG_SCRIPT_DATA_NUM_2]).Apply(entity);
				else
					Effects[1].ChangeValue(enchantment[GameTag.TAG_SCRIPT_DATA_NUM_1]).Apply(entity);
			}
			else
			{
				Effects[0].ChangeValue(num1).Apply(entity);

				if (Effects.Length != 2) return;

				if (num2 > 0)
					Effects[1].ChangeValue(num2).Apply(entity);
				else
					Effects[1].ChangeValue(num1).Apply(entity);
			}

			if (!IsOneTurnEffect) return;
			
			for (int i = 0; i < Effects.Length; i++)
				entity.Game.OneTurnEffects.Add((entity.Id, Effects[i]));
		}
    }

	public class OngoingEnchant : Enchant, IAura
	{
		private int _count = 1;
		private int _lastCount = 1;
		private int _targetId;
		private int _controllerId;
		private IEntity _target;
		private Controller _controller;

		public OngoingEnchant(params Effect[] effects) : base(effects) { }

		public int Count
		{
			get => _count;
			set
			{
				_count = value;
				ToBeUpdated = true;
			}
		}
		public IEntity Target
		{
			get => _target ?? (_target = Game.IdEntityDic[_targetId]);
			set
			{
				_targetId = value.Id;
				_target = value;
			}
		}
		public Controller Controller
		{
			get => _controller ?? (_controller = Game.ControllerById(_controllerId));
			set
			{
				_controllerId = Controller.Id;
				_controller = Controller;
			}
		}
		public bool ToBeUpdated { get; internal set; }
		public string EnchantmentCardId => "";

		public override void ActivateTo(IEntity entity, Enchantment enchantment, int num1 = 0, int num2 = -1)
		{
			Clone((IPlayable) entity);

			base.ActivateTo(entity, enchantment);
		}

		public void Update()
		{
			if (!ToBeUpdated) return;

			int delta = _count - _lastCount;

			for (int i = 0 ; i < delta; i++)
				base.ActivateTo(Target, null);

			_lastCount = _count;

			ToBeUpdated = false;
		}

		public void Remove()
		{
			((IPlayable)Target).OngoingEffect = null;
			Target.Game.Auras.Remove(this);
		}

		public void Clone(IPlayable clone)
		{
			var copy = new OngoingEnchant(Effects)
			{
				Game = clone.Game,
				Target = clone,
				IsOneTurnEffect = IsOneTurnEffect,
			};
			clone.OngoingEffect = copy;
			copy.Game.Auras.Add(copy);
		}
	}

	public class ComplexEffects : ICollection<Effect>
	{
		private readonly GameTag _tag;

		private readonly List<Effect> _effects = new List<Effect>();

		public ComplexEffects(GameTag tag)
		{
			_tag = tag;
		}

		public void Add(Effect effect)
		{
			_effects.Add(effect);
		}

		public void Clear()
		{
			_effects.Clear();
		}

		public bool Contains(Effect item)
		{
			return _effects.Contains(item);
		}

		public void CopyTo(Effect[] array, int arrayIndex)
		{
			_effects.CopyTo(array, arrayIndex);
		}

		public bool Remove(Effect item)
		{
			return _effects.Remove(item);
		}

		public int Count => _effects.Count;
		public bool IsReadOnly => false;

		public IEnumerator<Effect> GetEnumerator()
		{
			return _effects.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
