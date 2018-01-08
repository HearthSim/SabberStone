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
					break;
				default:
					throw new ArgumentException();
			}
		}

		public void Apply(AuraEffects auraEffects)
		{
			switch (Operator)
			{
				case EffectOperator.ADD:
					auraEffects[Tag] += Value;
					return;
				case EffectOperator.SUB:
					auraEffects[Tag] += Value;
					return;
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

			//if (IsOneTurnEffect)
			//	enchantment.EffectsToBeRemoved = Effects;
		}
    }

	public class OngoingEnchant : Enchant, IAura
	{
		private int _count;
		private int _lastCount;
		private int _targetId;
		private int _controllerId;
		private IEntity _target;
		private Controller _controller;

		public OngoingEnchant(params Effect[] effects) : base(effects) { }
		private OngoingEnchant() { }

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
			var instance = new OngoingEnchant(Effects)
			{
				Game = entity.Game,
				Target = entity
			};
			entity.OngoingEffect = instance;
			entity.Game.Auras.Add(instance);

			base.ActivateTo(entity, enchantment);
		}

		public void Update()
		{
			if (!ToBeUpdated) return;

			base.ActivateTo(Target, null);
		}

		public void Remove()
		{
			Target.OngoingEffect = null;
			Target.Game.Auras.Remove(this);
		}
	}

	
	
	public class AuraEffects
	{
		private int ATK;
		private int HEALTH;
		private int COST;
		private int SPELLPOWER;
		private int CHARGE;

		private int SPD;
		private int RESTORE_TO_DAMAGE;

		public int this[GameTag t]
		{
			get
			{
				switch (t)
				{
					case GameTag.ATK:
						return ATK;
					case GameTag.HEALTH:
						return HEALTH;
					case GameTag.CHARGE:
						return CHARGE;
					case GameTag.CURRENT_SPELLPOWER:
						return SPELLPOWER;
					case GameTag.RESTORE_TO_DAMAGE:
						return RESTORE_TO_DAMAGE;
					case GameTag.HERO_POWER_DOUBLE:
					case GameTag.HEALING_DOUBLE:
					case GameTag.SPELLPOWER_DOUBLE:
						return SPD;
					default:
						return 0;
				}
			}
			set
			{
				switch (t)
				{
					case GameTag.ATK:
						ATK = value;
						return;
					case GameTag.HEALTH:
						HEALTH = value;
						return;
					case GameTag.CHARGE:
						CHARGE = value;
						return;
					case GameTag.CURRENT_SPELLPOWER:
						SPELLPOWER = value;
						return;
					case GameTag.RESTORE_TO_DAMAGE:
						RESTORE_TO_DAMAGE = value;
						return;
					case GameTag.HERO_POWER_DOUBLE:
					case GameTag.HEALING_DOUBLE:
					case GameTag.SPELLPOWER_DOUBLE:
						SPD = value;
						return;
					default:
						return;
				}
			}
		}

		public void Update(IPlayable p)
		{
			//p[GameTag.ATK] = p.NativeTags[GameTag.ATK] + ATK;
			//p[GameTag.HEALTH] = p.NativeTags[GameTag.HEALTH] + HEALTH;
			//p[GameTag.COST] = p.NativeTags[GameTag.COST] + COST;
			//p[GameTag.SPELLPOWER] = p.NativeTags[GameTag.SPELLPOWER] + SPELLPOWER;
			//if (p.NativeTags[GameTag.CHARGE] == 0)
			//	p[GameTag.CHARGE] = CHARGE;
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
