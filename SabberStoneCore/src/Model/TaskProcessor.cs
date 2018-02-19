using System;
using System.Collections.Generic;
using System.Text;
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

		private Lazy<Queue<ISimpleTask>> _standbyEvent;
		private bool _eventCreated;
		private int _stackHeight;

		public TaskQueue(Game game)
		{
			_game = game;
			_eventStack = new Stack<Queue<ISimpleTask>>();
			_baseQueue = new Queue<ISimpleTask>();
		}

		private Queue<ISimpleTask> CurrentQueue => _eventStack.Count == 0 ? _baseQueue : _eventStack.Peek();

		public bool IsEmpty => _standbyEvent != null || CurrentQueue.Count == 0;

		public ISimpleTask CurrentTask { get; private set; }

		public void StartEvent()
		{
			_stackHeight++;
			if (CurrentQueue.Count != 0 && _standbyEvent == null)
				_standbyEvent = new Lazy<Queue<ISimpleTask>>(() => new Queue<ISimpleTask>());
		}

		public void EndEvent()
		{
			_stackHeight--;
			if (!_eventCreated)
			{
				if (_stackHeight != 0) return;
				_standbyEvent = null;
				return;
			}
			_eventStack.Pop();
			if (_stackHeight > 0 && _eventStack.Count == 0)
				_standbyEvent = new Lazy<Queue<ISimpleTask>>(() => new Queue<ISimpleTask>());
			_eventCreated = false;
		}

		public void Enqueue(ISimpleTask task)
		{
			if (_standbyEvent != null)
			{
				_eventStack.Push(_standbyEvent.Value);
				_standbyEvent = null;
				_eventCreated = true;
			}

			CurrentQueue.Enqueue(task);

			_game.Log(LogLevel.DEBUG, BlockType.TRIGGER, "TaskQueue",
				!_game.Logging ? "" : $"{task.GetType().Name} is Enqueued in {_eventStack.Count}th stack");
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
