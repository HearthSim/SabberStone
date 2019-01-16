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
using System.Diagnostics;
using System.Text;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks
{
	public enum TaskState
	{
		READY, RUNNING, COMPLETE, STOP
	}


	[DebuggerDisplay("{DebuggerDisplay, nq}")]
	public class StateTaskList : ISimpleTask
	{
		private readonly ISimpleTask[] _tasks;

		private StateTaskList(ISimpleTask[] list)
		{
			_tasks = list;
		}

		public TaskState State { get; set; } = TaskState.READY;

		public bool IsTrigger { get; set; }

		public TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target, in TaskStack stack = null)
		{
			TaskStack currentStack = stack ?? new TaskStack();

			State = TaskState.RUNNING;
			//TaskStack temp = Game.TaskStack;
			//Game.TaskStack = Stack;
			for (int i = 0; i < _tasks.Length; ++i)
			{
				//ISimpleTask current = _tasks[i];
				//if (current is StateTaskList stacklist)
				//	stacklist.Stack = Stack;
				//else
				//{
				//	current.Game = Game;    
				//	current.Controller = Controller;
				//	current.Source = Source;
				//	current.Target = Target;
				//}


				if (_tasks[i].Process(in game, in controller, in source, in target, in currentStack) != TaskState.COMPLETE)
					break;
			}

			State = TaskState.COMPLETE;

			//Game.TaskStack = temp;
			return TaskState.COMPLETE;
		}


		public static StateTaskList Chain(params ISimpleTask[] list)
		{
			return new StateTaskList(list);
		}

		private string DebuggerDisplay
		{
			get
			{
				var sb = new StringBuilder();
				foreach (var task in _tasks)
				{
					sb.Append($"[{task.GetType().Name}]");
				}

				return sb.ToString();
			}
		}
	}
}
