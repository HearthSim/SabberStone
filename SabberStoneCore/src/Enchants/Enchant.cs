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
using System.Text;
using SabberStoneCore.Auras;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.Enchants
{
	/// <summary>
	/// Class to store attributes of the <see cref="Power"/> of an Enchantment Card.
	/// </summary>
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

		public readonly IEffect[] Effects;
	    public bool UseScriptTag;
		public bool IsOneTurnEffect;
		public bool RemoveWhenPlayed;

		public Enchant(GameTag tag, EffectOperator @operator, int value)
	    {
		    Effects = new IEffect[] {new Effect(tag, @operator, value)};
	    }

	    public Enchant(params IEffect[] effects)
	    {
			Effects = effects;
	    }

		/// <summary>
		/// Create an Enchant that uses the Number value in the stack.
		/// </summary>
		public Enchant(GameTag tag, EffectOperator @operator)
		{
			Effects = new IEffect[] {new Effect(tag, @operator, 0)};
			UseScriptTag = true;
		}

		/// <summary>
		/// Apply this Enchant's <see cref="Effect"/>s to the given entity.
		/// </summary>
		/// <param name="entity">The target entity.</param>
		/// <param name="enchantment">The indicator <see cref="Enchantment"/> entity. Can be null.</param>
		/// <param name="num1">Integer value for GameTag.TAG_SCRIPT_DATA_NUM_1.</param>
		/// <param name="num2">Integer value for GameTag.TAG_SCRIPT_DATA_NUM_2.</param>
		public virtual void ActivateTo(IEntity entity, Enchantment enchantment, int num1 = 0, int num2 = -1)
		{
			var effects = Effects;
			if (!UseScriptTag)
				for (int i = 0; i < effects.Length; i++)
					effects[i].ApplyTo(entity, IsOneTurnEffect);
			else if (enchantment != null)
			{
				effects[0].ChangeValue(enchantment[GameTag.TAG_SCRIPT_DATA_NUM_1]).ApplyTo(entity, IsOneTurnEffect);

				if (effects.Length < 2) return;

				if (enchantment[GameTag.TAG_SCRIPT_DATA_NUM_2] > 0)
					effects[1].ChangeValue(enchantment[GameTag.TAG_SCRIPT_DATA_NUM_2]).ApplyTo(entity, IsOneTurnEffect);
				else
					effects[1].ChangeValue(enchantment[GameTag.TAG_SCRIPT_DATA_NUM_1]).ApplyTo(entity, IsOneTurnEffect);

				for (int i = 2; i < effects.Length; i++)
					effects[i].ApplyTo(entity, IsOneTurnEffect);
			}
			else
			{
				effects[0].ChangeValue(num1).ApplyTo(entity, IsOneTurnEffect);

				if (effects.Length < 2) return;

				if (num2 > 0)
					effects[1].ChangeValue(num2).ApplyTo(entity, IsOneTurnEffect);
				else
					effects[1].ChangeValue(num1).ApplyTo(entity, IsOneTurnEffect);

				for (int i = 2; i < effects.Length; i++)
					effects[i].ApplyTo(entity, IsOneTurnEffect);
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
		//private int _targetId;
		private bool _toBeUpdated;
		//private IEntity _target;

		IPlayable IAura.Owner => Target;

		public OngoingEnchant(params IEffect[] effects) : base(effects) { }

		public int Count
		{
			get => _count;
			set
			{
				_count = value;
				_toBeUpdated = true;
			}
		}
		//public IEntity Target
		//{
		//	get => _target ?? (_target = Game.IdEntityDic[_targetId]);
		//	set
		//	{
		//		_targetId = value.Id;
		//		_target = value;
		//	}
		//}
		public IPlayable Target { get; set; }

		public override void ActivateTo(IEntity entity, Enchantment enchantment, int num1 = 0, int num2 = -1)
		{
			Clone((IPlayable) entity);

			base.ActivateTo(entity, enchantment, num1, num2);
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
			Target.OngoingEffect = null;
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

		void IAura.Activate(IPlayable owner)
		{
			throw new NotImplementedException();
		}

		public override string ToString()
		{
			var sb = new StringBuilder("[OE:");
			sb.Append(Target.Card.Name);
			sb.Append("]");
			sb.Append(_toBeUpdated ? "[U]" : "[NU]");
			return sb.ToString();
		}
	}
}
