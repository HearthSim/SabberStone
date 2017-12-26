using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Enchants
{
    public class Enchant
    {
		public Game Game;
	    public string EnchantmentId;
		public Controller Controller;
	    public int ControllerId;
	    public int TargetId;
	    public Effect[] Effects;
		//public Trigger UpdateTrigger;
	    //public bool IsStacking;

		private IPlayable Target;

		public Enchant() { }

	    public Enchant(Effect effect)
	    {
		    Effects = new[] {effect};
	    }

	    public virtual void ActivateTo(IEntity entity)
	    {
		    for (int i = 0; i < Effects.Length; i++)
			    Effects[i].Apply(entity);
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

		public override void ActivateTo(IEntity entity)
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

			base.ActivateTo(entity);
		}

		public void Update()
		{
			if (!ToBeUpdated) return;

			base.ActivateTo(Target);
		}
	}

	public enum AuraType
	{
		NONE, SELF, ADJACENT, ALL, EXCEPT_SOURCE
	}

	public struct Effect
	{
		public GameTag Tag;
		public EffectOperator Operator;
		public int Value;

		public void Apply(IEntity entity)
		{
			switch (Operator)
			{
				case EffectOperator.ADD:
					entity[Tag] += Value;
					return;
				case EffectOperator.SUB:
					entity[Tag] -= Value;
					if (entity[Tag] < 0)
						entity[Tag] = 0;
					return;
				case EffectOperator.MUL:
					entity[Tag] *= Value;
					return;
				case EffectOperator.SET:
					if (entity[Tag] != Value)
						entity[Tag] = Value;
					return;
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
				case EffectOperator.MUL:
					throw new NotImplementedException();
				case EffectOperator.SET:
					entity[Tag] = 0;
					return;
			}
		}
	}

	public enum EffectOperator
	{
		ADD, SUB, MUL, SET
	}
}
