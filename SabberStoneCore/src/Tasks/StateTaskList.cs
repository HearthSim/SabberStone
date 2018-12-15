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
using System.Collections.Generic;
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

	//public class StateTaskList : List<ISimpleTask>, ISimpleTask
	//{
	//	public TaskState State { get; set; } = TaskState.READY;

	//	private int _position = 0;
	//	//public ISimpleTask CurrentTask => this[_position].CurrentTask;

	//	private StateTaskList(int capacity) : base(capacity)
	//	{
			
	//	}

	//	public Game Game { get; set; }
	//	private int _controllerId;
	//	public Controller Controller
	//	{
	//		get { return Game.ControllerById(_controllerId); }
	//		set { _controllerId = value.Id; }
	//	}

	//	private int _sourceId;
	//	public IEntity Source
	//	{
	//		get { return Game.IdEntityDic[_sourceId]; }
	//		set { _sourceId = value.Id; }
	//	}

	//	private int _targetId = -1;
	//	public IEntity Target
	//	{
	//		get { return _targetId > -1 ? Game.IdEntityDic[_targetId] : null; }
	//		set { _targetId = value?.Id ?? -1; }
	//	}

	//	public List<IPlayable> Playables
	//	{
	//		get { return Game.TaskStack.Playables; }
	//		set { Game.TaskStack.Playables = value; }
	//	}
	//	public List<string> CardIds
	//	{
	//		get { return Game.TaskStack.CardIds; }
	//		set { Game.TaskStack.CardIds = value; }
	//	}
	//	public bool Flag
	//	{
	//		get { return Game.TaskStack.Flag; }
	//		set { Game.TaskStack.Flag = value; }
	//	}
	//	public int Number
	//	{
	//		get { return Game.TaskStack.Numbers[0]; }
	//		set { Game.TaskStack.Numbers[0] = value; }
	//	}
	//	public int Number1
	//	{
	//		get { return Game.TaskStack.Numbers[1]; }
	//		set { Game.TaskStack.Numbers[1] = value; }
	//	}
	//	public int Number2
	//	{
	//		get { return Game.TaskStack.Numbers[2]; }
	//		set { Game.TaskStack.Numbers[2] = value; }
	//	}
	//	public int Number3
	//	{
	//		get { return Game.TaskStack.Numbers[3]; }
	//		set { Game.TaskStack.Numbers[3] = value; }
	//	}
	//	public int Number4
	//	{
	//		get { return Game.TaskStack.Numbers[4]; }
	//		set { Game.TaskStack.Numbers[4] = value; }
	//	}
	//	public TaskState Process()
	//	{
	//		// at the start move over initial parameters ...
	//		if (State == TaskState.READY)
	//		{
	//			Playables = Playables ?? new List<IPlayable>();
	//			CardIds = CardIds ?? new List<string>();
	//		}

	//		State = TaskState.RUNNING;
	//		for (_position = 0; _position < Count && State == TaskState.RUNNING; _position++)
	//		{
	//			ISimpleTask task = this[_position];
	//			if (task.State == TaskState.COMPLETE)
	//				continue;

	//			task.Game = Game;
	//			task.Controller = Controller;
	//			task.Source = Source;
	//			task.Target = Target;
	//			//task.Playables = Playables;
	//			//task.Flag = Flag;
	//			//task.Number = Number;

	//			// execution
	//			if (task.Process() != TaskState.COMPLETE)
	//				break;
				

	//			// move over in queue
	//			Game = task.Game;
	//			Controller = task.Controller;
	//			Source = task.Source;
	//			Target = task.Target;
	//			//Playables = task.Playables;
	//			//Flag = task.Flag;
	//			//Number = task.Number;
	//		}

	//		return TaskState.COMPLETE;
	//	}

	//	public ISimpleTask Clone()
	//	{
	//		var cloneList = new StateTaskList(Count);
	//		cloneList.Copy(this);
	//		ForEach(p => cloneList.Add(p.Clone()));
	//		return cloneList;
	//	}

	//	public void ResetState()
	//	{
	//		State = TaskState.READY;
	//	}

	//	public bool IsTrigger { get; set; }

	//	public static StateTaskList Chain(params ISimpleTask[] list)
	//	{
	//		var newList = new StateTaskList(list.Length);
	//		newList.AddRange(list);
	//		return newList;
	//	}

	//	public void Copy(ISimpleTask task)
	//	{
	//		State = task.State;

	//		if (task.Game == null)
	//			return;

	//		Game = task.Game;
	//		Controller = task.Controller;
	//		Source = task.Source;
	//		Target = task.Target;

	//		Playables = task.Playables;
	//		//CardIds = task.CardIds;
	//		Flag = task.Flag;
	//		Number = task.Number;
	//		Number1 = task.Number1;
	//		Number2 = task.Number2;
	//		Number3 = task.Number3;
	//		Number4 = task.Number4;

	//		//Splits = task.Splits;
	//		//Sets = task.Sets;
	//	}

	//}

	[DebuggerDisplay("{DebuggerDisplay, nq}")]
	public class StateTaskList : ISimpleTask
	{
		public TaskStack Stack { private get; set; }
		private readonly IReadOnlyList<ISimpleTask> _tasks;

		private StateTaskList(ISimpleTask[] list)
		{
			var tasks = new ISimpleTask[list.Length];

			for (int i = 0; i < list.Length; ++i)
				tasks[i] = list[i].Clone();

			_tasks = tasks;
		}

		public TaskState State { get; set; } = TaskState.READY;

		public Game Game
		{
			get => Stack.Game;
			set
			{
				if (Stack == null)
				{
					Stack = new TaskStack(value);
					return;
				}

				Stack.Game = value;
			} 
		}
		public Controller Controller
		{
			get => Stack.Controller;
			set => Stack.Controller = value;
		}
		public IEntity Source
		{
			get => Stack.Source;
			set => Stack.Source = value;
		}
		public IEntity Target
		{
			get => Stack.Target;
			set => Stack.Target = value;
		}
		public List<IPlayable> Playables
		{
			get => Stack.Playables;
			set => Stack.Playables = value;
		}
		public bool Flag
		{
			get => Stack.Flag;
			set => Stack.Flag = value;
		}
		public int Number
		{
			get => Stack.Numbers[0];
			set => Stack.Numbers[0] = value;
		}
		public int Number1
		{
			get => Stack.Numbers[1];
			set => Stack.Numbers[1] = value;
		}
		public int Number2
		{
			get => Stack.Numbers[2];
			set => Stack.Numbers[2] = value;
		}
		public int Number3
		{
			get => Stack.Numbers[3];
			set => Stack.Numbers[3] = value;
		}
		public int Number4
		{
			get => Stack.Numbers[4];
			set => Stack.Numbers[4] = value;
		}
		public bool IsTrigger { get; set; }

		public TaskState Process()
		{
			if (Stack == null)
				throw new NullReferenceException("Stack can't be null.");

			State = TaskState.RUNNING;
			TaskStack temp = Game.TaskStack;
			Game.TaskStack = Stack;
			for (int i = 0; i < _tasks.Count; ++i)
			{
				ISimpleTask current = _tasks[i];
				if (current is StateTaskList stacklist)
					stacklist.Stack = Stack;
				else
				{
					current.Game = Game;    
					current.Controller = Controller;
					current.Source = Source;
					current.Target = Target;
				}


				if (current.Process() != TaskState.COMPLETE)
					break;
			}

			State = TaskState.COMPLETE;

			Game.TaskStack = temp;
			return TaskState.COMPLETE;
		}


		public static StateTaskList Chain(params ISimpleTask[] list)
		{
			return new StateTaskList(list);
		}

		//	public void Copy(ISimpleTask task)
		//	{
		//		State = task.State;

		//		if (task.Game == null)
		//			return;

		//		Game = task.Game;
		//		Controller = task.Controller;
		//		Source = task.Source;
		//		Target = task.Target;

		//		Playables = task.Playables;
		//		//CardIds = task.CardIds;
		//		Flag = task.Flag;
		//		Number = task.Number;
		//		Number1 = task.Number1;
		//		Number2 = task.Number2;
		//		Number3 = task.Number3;
		//		Number4 = task.Number4;

		//		//Splits = task.Splits;
		//		//Sets = task.Sets;
		//	}

		public ISimpleTask Clone()
		{
			return new StateTaskList((ISimpleTask[])_tasks)
			{
				Game = Stack?.Game
			};
		}

		private string DebuggerDisplay
		{
			get
			{
				var sb = new StringBuilder($"[{Source}]");
				foreach (var task in _tasks)
				{
					sb.Append($"[{task.GetType().Name}]");
				}

				return sb.ToString();
			}
		}
	}
}
