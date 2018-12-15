#region copyright
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License,
// or any later version.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
#endregion
using System.Collections.Generic;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SwapAttackHealthTask : SimpleTask
	{
		/// <summary>
		///  Changes the attack attribute of the given entity.
		/// </summary>
		public SwapAttackHealthTask(EntityType entityType, string enchantmentId)
		{
			Type = entityType;
			_enchantmentCard = Cards.FromId(enchantmentId);
		}

		private SwapAttackHealthTask(EntityType entityType, Card card)
		{
			Type = entityType;
			_enchantmentCard = card;
		}

		public EntityType Type { get; set; }

		private readonly Card _enchantmentCard;

		public override TaskState Process()
		{
			IEnumerable<IPlayable> entities = IncludeTask.GetEntities(Type, Controller, Source, Target, Playables);
			foreach (IPlayable p in entities)
			{
				var m = p as Minion;

				int atk = m.AttackDamage;
				int health = m.Health;

				if (Game.History)
				{
					Enchantment instance = Enchantment.GetInstance(Controller, (IPlayable) Source, p, _enchantmentCard);
					instance[GameTag.TAG_SCRIPT_DATA_NUM_1] = atk;
					instance[GameTag.TAG_SCRIPT_DATA_NUM_2] = health;
				}

				new Effect(GameTag.ATK, EffectOperator.SET, health).Apply(p);
				new Effect(GameTag.HEALTH, EffectOperator.SET, atk).Apply(p);
			}

			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			return new SwapAttackHealthTask(Type, _enchantmentCard);
		}
	}
}
