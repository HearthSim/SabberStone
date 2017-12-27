using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Enchants
{
	public enum AuraType
	{
		NONE, SELF, ADJACENT, ALL, EXCEPT_SOURCE
	}

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
			switch (Operator)
			{
				case EffectOperator.ADD:
					entity[Tag] += Value;
					return;
				case EffectOperator.SUB:
					entity[Tag] -= Value;
					return;
				case EffectOperator.MUL:
					entity[Tag] *= Value;
					return;
				case EffectOperator.SET:
					entity[Tag] = Value;
					return;
				default:
					throw new ArgumentOutOfRangeException();
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
	    public string EnchantmentId;
		public Controller Controller;
	    public int ControllerId;
	    public int TargetId;
	    public Effect[] Effects;
		private IPlayable Target;
	    //private bool _oneTurnEffect;

		public Enchant() { }

	    //public Enchant(Effect effect)
	    //{
		   // Effects = new[] {effect};
	    //}

	    public Enchant(GameTag tag, EffectOperator @operator, int value)
	    {
		    Effects = new[] {new Effect(tag, @operator, value)};
	    }

	    public Enchant(Effect effect)
	    {
		    Effects = new[] {effect};
	    }


		public bool IsOneTurnEffect { get; set; }

		public virtual void ActivateTo(IEntity entity, Enchantment enchantment)
	    {
		    for (int i = 0; i < Effects.Length; i++)
		    {
			    Effects[i].Apply(entity);
		    }

		    if (IsOneTurnEffect)
			    enchantment.EffectsToBeRemoved = Effects;
	    }
    }

	public class OngoingEffect : Enchant
	{
		private int _count;
		private int _targetId;
		private IEntity _target;
		public TriggerType UpdateTrigger;


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

		public bool ToBeUpdated { get; internal set; }

		public OngoingEffect(Effect effect, TriggerType updateTrigger = TriggerType.NONE) : base(effect)
		{
			UpdateTrigger = updateTrigger;
		}

		private OngoingEffect(OngoingEffect ongoingEffect)
		{
			Effects = ongoingEffect.Effects;
			UpdateTrigger = ongoingEffect.UpdateTrigger;
		}

		public override void ActivateTo(IEntity entity, Enchantment enchantment)
		{
			var instance = new OngoingEffect(this)
			{
				Game = entity.Game,
				Controller = entity.Controller,
				ControllerId = entity.Controller.Id,
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
