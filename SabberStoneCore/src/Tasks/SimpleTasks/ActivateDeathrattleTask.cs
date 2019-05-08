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
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class ActivateDeathrattleTask : SimpleTask
	{
		private readonly EntityType _type;

		public ActivateDeathrattleTask(EntityType type)
		{
			_type = type;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source,
			in IPlayable target,
			in TaskStack stack = null)
		{
			foreach (IPlayable p in IncludeTask.GetEntities(_type, controller, source, target, stack?.Playables))
			{
				p.ActivateTask(PowerActivation.DEATHRATTLE);
				if (p.AppliedEnchantments != null)
					foreach (Enchantment e in p.AppliedEnchantments)
					{
						ISimpleTask task = e.Power.DeathrattleTask;
						if (task == null) continue;
						game.TaskQueue.Enqueue(in task, e.Target.Controller, e.Target, e);
					}

				if (p.Controller.ControllerAuraEffects[GameTag.EXTRA_DEATHRATTLES_BASE] == 1)
				{
					p.ActivateTask(PowerActivation.DEATHRATTLE);
					if (p.AppliedEnchantments != null)
						foreach (Enchantment e in p.AppliedEnchantments)
						{
							ISimpleTask task = e.Power.DeathrattleTask;
							if (task == null) continue;
							game.TaskQueue.Enqueue(in task, e.Target.Controller, e.Target, e);
						}
				}
			}

			return TaskState.COMPLETE;
		}
	}
}
