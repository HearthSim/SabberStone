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
//#define LOGEVENT
using System;
using System.Collections;
using System.Collections.Generic;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks;
using SabberStoneCore.Exceptions;

//using TaskInstance = System.ValueTuple<SabberStoneCore.Tasks.ISimpleTask, SabberStoneCore.Model.Entities.Controller, SabberStoneCore.Model.Entities.IEntity, SabberStoneCore.Model.Entities.IEntity>;

namespace SabberStoneCore.Model
{
	public class TaskQueue
	{
		private class TaskInstance
		{
			public readonly ISimpleTask Task;
			public readonly Controller Controller;
			public readonly IEntity Source;
			public readonly IPlayable Target;

			public TaskInstance(in ISimpleTask task, in Controller controller, in IEntity source, in IPlayable target)
			{
				Task = task;
				Controller = controller;
				Source = source;
				Target = target;
			}

			public static implicit operator (ISimpleTask, Controller, IEntity, IPlayable) (TaskInstance t)
			{
				return (t.Task, t.Controller, t.Source, t.Target);
			}

			public void Deconstruct(out ISimpleTask simpleTask, out Controller controller, out IEntity entity, out IPlayable target)
			{
				simpleTask = Task;
				controller = Controller;
				entity = Source;
				target = Target;
			}
		}

		//private readonly struct Event
		//{
		//	public readonly Queue<TaskInstance> Queue;

		//	public Event(Queue<TaskInstance> newQueue)
		//	{
		//		Queue = newQueue;
		//	}
		//}

		private readonly Game _game;
		private readonly Stack<Queue<TaskInstance>> _eventStack;
		//private readonly Stack<Event> _eventStack;
		private readonly Queue<TaskInstance> _baseQueue;
		private readonly Queue<TaskInstance> _pendingTasks;
#if LOGEVENT
		private int _stackHeight;
#endif

		public TaskQueue(Game game)
		{
			_game = game;
			_eventStack = new Stack<Queue<TaskInstance>>();
			//_eventStack = new Stack<Event>();
			_baseQueue = new Queue<TaskInstance>();
			CurrentQueue = _baseQueue;
			_pendingTasks = new Queue<TaskInstance>();
		}

		//private Queue<TaskInstance> CurrentQueue => _eventStack.Count == 0 ? _baseQueue : _eventStack.Peek();
		private Queue<TaskInstance> CurrentQueue { get; set; }

		// nothing left in current event
		//public bool IsEmpty => _eventFlag || CurrentQueue.Count == 0;
		public bool IsEmpty => CurrentQueue == null || CurrentQueue.Count == 0;

		public ISimpleTask CurrentTask { get; private set; }

		public void StartEvent()
		{
			//_eventFlag = true;
			//_numEventsStarted++;
			//_eventStack.Push(null);

			_eventStack.Push(CurrentQueue);
			CurrentQueue = null;

#if LOGEVENT
			if (_game.Logging)
			{
				//var sb = new System.Text.StringBuilder("Event Starts");
				//for (int i = 0; i < 10 - _stackHeight; i++)
				//	sb.Append("----");
				_game.Log(LogLevel.DEBUG, BlockType.ACTION, "TaskQueue",
					//sb.ToString()
					$"Event ({_stackHeight}) Starts"
				);
				_stackHeight++;
			}
#endif
		}

		public void EndEvent()
		{
#if LOGEVENT
			if (_game.Logging)
			{
				//var sb = new System.Text.StringBuilder("Event Ends--");
				//for (int i = 0; i < 10 - _stackHeight; i++)
				//	sb.Append("----");
				//_stackHeight--;
				_stackHeight--;
				_game.Log(LogLevel.DEBUG, BlockType.ACTION, "TaskQueue",
					//sb.ToString()
					$"Event ({_stackHeight}) Ends"
				);
			}
#endif



			//if (!_eventFlag)
			//{
			//	if (_eventStack.Count > 0)
			//		_eventStack.Pop();
			//}
			//else
			//{
			//	_eventFlag = false;
			//	_numEventsStarted--;
			//}

			//if (_numEventsStarted > 0)
			//	_eventFlag = true;

			CurrentQueue = _eventStack.Pop();
		}

		public void Enqueue(in ISimpleTask task, in Controller controller, in IEntity source, in IPlayable target)
		{
			//if (_eventFlag)	// flag = true means Event starts and no tasks queue yet
			//{
			//	if (CurrentQueue.Count != 0) // Check if an ongoing event exists
			//		_eventStack.Push(new Queue<TaskInstance>());

			//	_eventFlag = false;
			//	_numEventsStarted--;
			//}

			//Stack<Queue<TaskInstance>> stack = _eventStack;
			Queue<TaskInstance> queue = CurrentQueue;
			if (queue == null)
			{
				queue = new Queue<TaskInstance>();
				CurrentQueue = queue;
			}

			queue.Enqueue(new TaskInstance(task, controller, source, target));

#if LOGEVENT
			_game.Log(LogLevel.DEBUG, BlockType.TRIGGER, "TaskQueue",
				!_game.Logging ? "" : $"{task.GetType().Name} is Enqueued in {_eventStack.Count}th stack");
#endif
		}

		public void EnqueueBase(in ISimpleTask task, in Controller controller, in IEntity source, in IPlayable target)
		{
			//_baseQueue.Enqueue((task, controller, source, target));
			//if (!_eventFlag && _eventStack.Count == 0)
			//{
			//	_eventStack.Push(new Queue<TaskInstance>(_baseQueue));
			//	_baseQueue.Clear();
			//}

			_baseQueue.Enqueue(new TaskInstance(in task, in controller, in source, in target));

			_game.Log(LogLevel.DEBUG, BlockType.TRIGGER, "TaskQueue",
				!_game.Logging ? "" : $"{task.GetType().Name} is Enqueued in 0th stack");
		}

		/// <summary>
		/// Queue a task that will be processed after a task is queued and processed.
		/// </summary>
		/// <param name="task"></param>
		public void EnqueuePendingTask(in ISimpleTask task, in Controller controller, in IEntity source, in IPlayable target)
		{
			_pendingTasks.Enqueue(new TaskInstance(in task, in controller, in source, in target));
			_hasPendingTask = true;
		}

		private bool _hasPendingTask;

		public void ResumePendingTasks()
		{
			if (!_hasPendingTask) return;
			_hasPendingTask = false;

			do CurrentQueue.Enqueue(_pendingTasks.Dequeue());
			while (_pendingTasks.Count != 0);
		}

		public TaskState Process()
		{
			(ISimpleTask task, Controller controller, IEntity source, IPlayable target) = CurrentQueue.Peek();
			ISimpleTask temp = CurrentTask;
			CurrentTask = task;

			//if (currentTask is StateTaskList tasks)
			//	tasks.Stack = new TaskStack(_game);

			_game.Log(LogLevel.VERBOSE, BlockType.TRIGGER, "TaskQueue", !_game.Logging ? "" : $"LazyTask[{source}]: '{CurrentTask.GetType().Name}' is processed!" +
			                                                                                $"'{source.Card.Text?.Replace("\n", " ")}'");
			if (_game.History)
				_game.PowerHistory.Add(PowerHistoryBuilder.BlockStart(task.IsTrigger ? BlockType.TRIGGER : BlockType.POWER, source.Id, "", -1, target?.Id ?? 0));

			TaskState success;
#if DEBUG
			try
			{
#endif
				success = task.Process(in _game, in controller, in source, in target);
#if DEBUG
			}
			catch (Exception e)
			{
				throw new TaskException(
					$"Exception occurs during processing a task.\nTask:{task}, Source:{source}, Target:{target}", e);
			}
#endif

			if (_game.History)
				_game.PowerHistory.Add(PowerHistoryBuilder.BlockEnd());

			// reset between task execution
			//_game.TaskStack.Reset();

			CurrentQueue.Dequeue();
			CurrentTask = temp;

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
