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

namespace SabberStoneCore.Model
{
	public class TaskQueue
	{	
		private readonly Game _game;
		private readonly Stack<Queue<ISimpleTask>> _eventStack;
		private readonly Queue<ISimpleTask> _baseQueue;
	
		//private int _stackHeight;
		// Flag == true : current event have not ended yet and no tasks queue in this event;
		private bool _eventFlag;
		
		public TaskQueue(Game game)
		{
			_game = game;
			_eventStack = new Stack<Queue<ISimpleTask>>();
			_baseQueue = new Queue<ISimpleTask>();
		}

		private Queue<ISimpleTask> CurrentQueue => _eventStack.Count == 0 ? _baseQueue : _eventStack.Peek();

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

		public void Enqueue(ISimpleTask task)
		{
			if (_eventFlag)	// flag = true means Event starts and no tasks queue yet
			{
				if (CurrentQueue.Count != 0) // Check if an ongoing event exists
					_eventStack.Push(new Queue<ISimpleTask>());

				_eventFlag = false;
			}

			CurrentQueue.Enqueue(task);

			//_game.Log(LogLevel.DEBUG, BlockType.TRIGGER, "TaskQueue",
			//	!_game.Logging ? "" : $"{task.GetType().Name} is Enqueued in {_eventStack.Count}th stack");
		}

		public void EnqueueBase(ISimpleTask task)
		{
			_baseQueue.Enqueue(task);

			_game.Log(LogLevel.DEBUG, BlockType.TRIGGER, "TaskQueue",
				!_game.Logging ? "" : $"{task.GetType().Name} is Enqueued in 0th stack");
		}

		public TaskState Process()
		{
			ISimpleTask currentTask = CurrentQueue.Dequeue();
			CurrentTask = currentTask;

			//if (currentTask is StateTaskList tasks)
			//	tasks.Stack = new TaskStack(_game);

			_game.Log(LogLevel.VERBOSE, BlockType.TRIGGER, "TaskQueue", !_game.Logging ? "" : $"LazyTask[{currentTask.Source}]: '{currentTask.GetType().Name}' is processed!" +
			                                                                                $"'{currentTask.Source.Card.Text?.Replace("\n", " ")}'");
			if (_game.History)
				_game.PowerHistory.Add(PowerHistoryBuilder.BlockStart(currentTask.IsTrigger ? BlockType.TRIGGER : BlockType.POWER, currentTask.Source.Id, "", -1, currentTask.Target?.Id ?? 0));

			TaskState success = currentTask.Process();

			if (_game.History)
				_game.PowerHistory.Add(PowerHistoryBuilder.BlockEnd());

			// reset between task execution
			//_game.TaskStack.Reset();

			CurrentTask = null;

			return success;
		}

		public void Execute(ISimpleTask task, Controller controller, IPlayable source, IPlayable target, int number = 0)
		{
			ISimpleTask clone = task.Clone();
			clone.Game = controller.Game;
			clone.Controller = controller;
			clone.Source = source;
			clone.Target = target;
			clone.Number = number;
			_game.Log(LogLevel.VERBOSE, BlockType.TRIGGER, "TaskQueue", !_game.Logging ? "" : $"PriorityTask[{clone.Source}]: '{clone.GetType().Name}' is processed!" +
			                                                                                $"'{clone.Source.Card.Text?.Replace("\n", " ")}'");

			// power block
			if (controller.Game.History)
				controller.Game.PowerHistory.Add(PowerHistoryBuilder.BlockStart(BlockType.POWER, source.Id, "", -1, target?.Id ?? 0));

			clone.Process();

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
		public IPlayable EventSource;
		public IPlayable EventTarget;
		public int EventNumber;

		public EventMetaData(IPlayable source, IPlayable target, int number = 0)
		{
			EventSource = source;
			EventTarget = target;
			EventNumber = number;
		}
	}
}
