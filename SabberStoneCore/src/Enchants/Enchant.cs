using System.Collections;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.Enchants
{
	public class Enchant
	{
		public static readonly Trigger RemoveWhenPlayedTrigger =
			new Trigger(TriggerType.PLAY_CARD)
			{
				TriggerSource = TriggerSource.ENCHANTMENT_TARGET,
				SingleTask = new RemoveEnchantmentTask(),
				RemoveAfterTriggered = true,
				IsAncillaryTrigger = true,
			};

		public readonly Effect[] Effects;
	    public bool UseScriptTag;
		
	    public Enchant(GameTag tag, EffectOperator @operator, int value)
	    {
		    Effects = new[] {new Effect(tag, @operator, value)};
	    }

	    public Enchant(params Effect[] effects)
	    {
			Effects = effects;
	    }

		/// <summary>
		/// Create an Enchant using Number value in the stack
		/// </summary>
		public Enchant(GameTag tag, EffectOperator @operator)
		{
			Effects = new[] {new Effect(tag, @operator, 0)};
			UseScriptTag = true;
		}


		public bool IsOneTurnEffect { get; set; }

		public bool RemoveWhenPlayed { get; set; }

		public virtual void ActivateTo(IEntity entity, Enchantment enchantment, int num1 = 0, int num2 = -1)
		{
			if (!UseScriptTag)
				for (int i = 0; i < Effects.Length; i++)
					Effects[i].Apply(entity, IsOneTurnEffect);
			else if (enchantment != null)
			{
				Effects[0].ChangeValue(enchantment[GameTag.TAG_SCRIPT_DATA_NUM_1]).Apply(entity, IsOneTurnEffect);

				if (Effects.Length != 2) return;

				if (enchantment[GameTag.TAG_SCRIPT_DATA_NUM_2] > 0)
					Effects[1].ChangeValue(enchantment[GameTag.TAG_SCRIPT_DATA_NUM_2]).Apply(entity, IsOneTurnEffect);
				else
					Effects[1].ChangeValue(enchantment[GameTag.TAG_SCRIPT_DATA_NUM_1]).Apply(entity, IsOneTurnEffect);
			}
			else
			{
				Effects[0].ChangeValue(num1).Apply(entity, IsOneTurnEffect);

				if (Effects.Length != 2) return;

				if (num2 > 0)
					Effects[1].ChangeValue(num2).Apply(entity, IsOneTurnEffect);
				else
					Effects[1].ChangeValue(num1).Apply(entity, IsOneTurnEffect);
			}
		}
    }

	/// <summary>
	/// Implementation of a kind of enchantment that its effect gradually grows due to a trigger.
	/// OngoingEnchant is narrowly used when the source of the trigger and 
	/// the target of the Enchantment is identical. (e.g. Mana Wyrm)
	/// </summary>
	public class OngoingEnchant : Enchant, IAura
	{
		public Game Game;
		private int _count = 1;
		private int _lastCount = 1;
		private int _targetId;
		private bool _toBeUpdated;
		private IEntity _target;

		public OngoingEnchant(params Effect[] effects) : base(effects) { }

		public int Count
		{
			get => _count;
			set
			{
				_count = value;
				_toBeUpdated = true;
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

		public override void ActivateTo(IEntity entity, Enchantment enchantment, int num1 = 0, int num2 = -1)
		{
			Clone((IPlayable) entity);

			base.ActivateTo(entity, enchantment);
		}

		public void Update()
		{
			if (!_toBeUpdated) return;

			int delta = _count - _lastCount;

			for (int i = 0 ; i < delta; i++)
				base.ActivateTo(Target, null);

			_lastCount = _count;

			_toBeUpdated = false;
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
}
