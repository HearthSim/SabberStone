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
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks;

using TaskInstance = System.ValueTuple<SabberStoneCore.Tasks.ISimpleTask, SabberStoneCore.Model.Entities.Controller, SabberStoneCore.Model.Entities.IEntity, SabberStoneCore.Model.Entities.IEntity>;

namespace SabberStoneCore.Model
{
	public class TaskQueue
	{
		//private class TaskInstance
		//{
		//	public readonly ISimpleTask Task;
		//	public readonly Controller Controller;
		//	public readonly IEntity Source;
		//	public readonly IEntity Target;

		//	public TaskInstance(ISimpleTask task, Controller controller, IEntity source, IEntity target)
		//	{
		//		Task = task;
		//		Controller = controller;
		//		Source = source;
		//		Target = target;
		//	}

		//	public static implicit operator (ISimpleTask, Controller, IEntity, IEntity)(TaskInstance t)
		//	{
		//		return (t.Task, t.Controller, t.Source, t.Target);
		//	}

		//	public void Deconstruct(out ISimpleTask simpleTask, out Controller controller, out IEntity entity, out IEntity entity1)
		//	{
		//		simpleTask = Task;
		//		controller = Controller;
		//		entity = Source;
		//		entity1 = Target;
		//	}
		//}


		private readonly Game _game;
		private readonly Stack<Queue<TaskInstance>> _eventStack;
		private readonly Queue<TaskInstance> _baseQueue;
	
		//private int _stackHeight;
		// Flag == true : current event have not ended yet and no tasks queue in this event;
		private bool _eventFlag;
		
		public TaskQueue(Game game)
		{
			_game = game;
			_eventStack = new Stack<Queue<TaskInstance>>();
			_baseQueue = new Queue<TaskInstance>();
		}

		private Queue<TaskInstance> CurrentQueue => _eventStack.Count == 0 ? _baseQueue : _eventStack.Peek();

		// nothing left in current event
		public bool IsEmpty => _eventFlag || CurrentQueue.Count == 0;

		public ISimpleTask CurrentTask { get; private set; }

		public void StartEvent()
		{
			_eventFlag = true;

			//if (_game.Logging)
			//{
			//	_stackHeight++;
			//	var sb = new StringBuilder("Event Starts");
			//	for (int i = 0; i < 10 - _stackHeight; i++)
			//		sb.Append("----");
			//	_game.Log(LogLevel.DEBUG, BlockType.ACTION, "TaskQueue", sb.ToString());
			//}
		}

		public void EndEvent()
		{
			//if (_game.Logging)
			//{
			//	var sb = new StringBuilder("Event Ends--");
			//	for (int i = 0; i < 10 - _stackHeight; i++)
			//		sb.Append("----");
			//	_game.Log(LogLevel.DEBUG, BlockType.ACTION, "TaskQueue", sb.ToString());
			//	_stackHeight--;
			//}

			if (_eventFlag)
			{
				_eventFlag = false;
				return;
			}

			if (_eventStack.Count > 0)
				_eventStack.Pop();
		}

		public void Enqueue(in ISimpleTask task, in Controller controller, in IEntity source, in IEntity target)
		{
			if (_eventFlag)	// flag = true means Event starts and no tasks queue yet
			{
				if (CurrentQueue.Count != 0) // Check if an ongoing event exists
					_eventStack.Push(new Queue<TaskInstance>());

				_eventFlag = false;
			}

			CurrentQueue.Enqueue(new TaskInstance(task, controller, source, target));

			//_game.Log(LogLevel.DEBUG, BlockType.TRIGGER, "TaskQueue",
			//	!_game.Logging ? "" : $"{task.GetType().Name} is Enqueued in {_eventStack.Count}th stack");
		}

		public void EnqueueBase(in ISimpleTask task, in Controller controller, in IEntity source, in IEntity target)
		{
			_baseQueue.Enqueue((task, controller, source, target));

			_game.Log(LogLevel.DEBUG, BlockType.TRIGGER, "TaskQueue",
				!_game.Logging ? "" : $"{task.GetType().Name} is Enqueued in 0th stack");
		}

		public TaskState Process()
		{
			(ISimpleTask task, Controller controller, IEntity source, IEntity target) = CurrentQueue.Dequeue();
			CurrentTask = task;

			//if (currentTask is StateTaskList tasks)
			//	tasks.Stack = new TaskStack(_game);

			_game.Log(LogLevel.VERBOSE, BlockType.TRIGGER, "TaskQueue", !_game.Logging ? "" : $"LazyTask[{source}]: '{CurrentTask.GetType().Name}' is processed!" +
			                                                                                $"'{source.Card.Text?.Replace("\n", " ")}'");
			if (_game.History)
				_game.PowerHistory.Add(PowerHistoryBuilder.BlockStart(task.IsTrigger ? BlockType.TRIGGER : BlockType.POWER, source.Id, "", -1, target?.Id ?? 0));

			TaskState success = task.Process(in _game, in controller, in source, in target);

			if (_game.History)
				_game.PowerHistory.Add(PowerHistoryBuilder.BlockEnd());

			// reset between task execution
			//_game.TaskStack.Reset();

			CurrentTask = null;

			return success;
		}

		public void Execute(in ISimpleTask task, in Controller controller, in IPlayable source, in IPlayable target, int number = 0)
		{

			_game.Log(LogLevel.VERBOSE, BlockType.TRIGGER, "TaskQueue", !_game.Logging ? "" : $"PriorityTask[{source}]: '{task.GetType().Name}' is processed!" +
			                                                                                $"'{source.Card.Text?.Replace("\n", " ")}'");

			// power block
			if (controller.Game.History)
				controller.Game.PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.POWER, source.Id, "", -1, target?.Id ?? 0));

			task.Process(in _game, in controller, source, target);

			if (controller.Game.History)
				controller.Game.PowerHistory.Add(PowerHistoryBuilder.BlockEnd());

			//_game.TaskStack.Reset();
		}

		public void ClearCurrentEvent()
		{
			CurrentQueue.Clear();
		}

		public void Clone()
		{
			//return new TaskQueue();
		}
	}


	internal class EventMetaData
	{
		public IPlayable EventSource { get; set; }
		public IPlayable EventTarget { get; set; }
		public int EventNumber { get; set; }

		public EventMetaData(IPlayable source, IPlayable target, int number = 0)
		{
			EventSource = source;
			EventTarget = target;
			EventNumber = number;
		}
	}
}
