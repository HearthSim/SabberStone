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
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class EnqueueNumberTask : SimpleTask
	{
		public EnqueueNumberTask(ISimpleTask task, bool spellDmg = false)
		{
			Task = task;
			SpellDmg = spellDmg;
		}

		public int Amount { get; set; }
		public ISimpleTask Task { get; set; }
		public bool SpellDmg { get; set; }

		public override TaskState Process()
		{
			if (Number < 1)
			{
				return TaskState.STOP;
			}

			int times = SpellDmg ? Number + Controller.CurrentSpellPower : Number;

			for (int i = 0; i < times; i++)
			{
				// clone task here
				ISimpleTask clone = Task.Clone();
				clone.Game = Controller.Game;
				clone.Controller = Controller;
				clone.Source = Source as IPlayable;
				clone.Target = Target as IPlayable;

				Controller.Game.TaskQueue.Enqueue(clone);
				//Controller.Game.TaskQueue.EnqueueBase(
				//	new ClearStackTask
				//	{
				//		Game = Controller.Game,
				//		Controller = Controller,
				//		Source = Source as IPlayable,
				//		Target = Target as IPlayable
				//	});
			}
			return TaskState.COMPLETE;
		}

		public override ISimpleTask Clone()
		{
			var clone = new EnqueueNumberTask(Task.Clone(), SpellDmg);
			clone.Copy(this);
			return clone;
		}
	}
}
