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
using System.Collections.Generic;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class SwapAttackHealthTask : SimpleTask
	{
		private readonly Card _enchantmentCard;

		/// <summary>
		///     Changes the attack attribute of the given entity.
		/// </summary>
		public SwapAttackHealthTask(EntityType entityType, string enchantmentId)
		{
			Type = entityType;
			_enchantmentCard = Cards.FromId(enchantmentId);
		}

		public EntityType Type { get; set; }

		public override TaskState Process(in Game game, in Controller controller, in IEntity source,
			in IPlayable target,
			in TaskStack stack = null)
		{
			IEnumerable<IPlayable> entities =
				IncludeTask.GetEntities(Type, in controller, source, target, stack?.Playables);
			foreach (IPlayable p in entities)
			{
				if (!(p is Minion m))
					return TaskState.STOP;

				int atk = m.AttackDamage;
				int health = m.Health;

				if (game.History)
				{
					Enchantment instance =
						Enchantment.GetInstance(controller, (IPlayable) source, p, in _enchantmentCard);
					instance[GameTag.TAG_SCRIPT_DATA_NUM_1] = atk;
					instance[GameTag.TAG_SCRIPT_DATA_NUM_2] = health;
				}

				ATK.Effect(EffectOperator.SET, health).ApplyTo(m);
				Health.Effect(EffectOperator.SET, atk).ApplyTo(m);
			}

			return TaskState.COMPLETE;
		}
	}
}
