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
namespace SabberStoneCore.Tasks.SimpleTasks
{
	public class FlagTask : SimpleTask
	{
		public FlagTask(bool checkFlag, ISimpleTask taskToDo)
		{
			CheckFlag = checkFlag;
			TaskToDo = taskToDo;
		}

		public bool CheckFlag { get; set; }
		public ISimpleTask TaskToDo { get; set; }

		public override TaskState Process()
		{
			if (Flag != CheckFlag)
			{
				return TaskState.COMPLETE;
			}

			if (TaskToDo is StateTaskList list)
				list.Stack = Game.TaskStack;
			else
			{
				TaskToDo.Game = Game;
				TaskToDo.Controller = Controller;
				TaskToDo.Source = Source;
				TaskToDo.Target = Target;
				TaskToDo.Flag = Flag;
			}

			return TaskToDo.Process();
		}

		public override ISimpleTask Clone()
		{
			var clone = new FlagTask(CheckFlag, TaskToDo.Clone());
			clone.Copy(this);
			return clone;
		}

		public override string ToString()
		{
			return $"[FlagTask][{CheckFlag}:{TaskToDo.GetType().Name}]";
		}
	}
}
