using SabberStoneCore.Model;
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

using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class EnqueueNumberTask : SimpleTask
	{
		private readonly bool _spellDmg;
		private readonly ISimpleTask _task;

		public EnqueueNumberTask(ISimpleTask task, bool spellDmg = false)
		{
			_task = task;
			_spellDmg = spellDmg;
		}

		public override TaskState Process(in Game game, in Controller controller, in IEntity source,
			in IPlayable target,
			in TaskStack stack = null)
		{
			if (stack.Number < 1) return TaskState.STOP;

			int times = _spellDmg ? stack.Number + controller.CurrentSpellPower : stack.Number;

			for (int i = 0; i < times; i++)
				game.TaskQueue.Enqueue(in _task, in controller, in source, in target);
			//Controller.game.TaskQueue.EnqueueBase(
			//	new ClearStackTask
			//	{
			//		Game = controller.Game,
			//		Controller = in controller,
			//		source = source as IPlayable,
			//		target = target as IPlayable
			//	});

			return TaskState.COMPLETE;
		}
	}
}
