using System;
using System.Collections.Generic;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks
{
	public enum TaskState
	{
		READY, RUNNING, COMPLETE, STOP
	}

	public class StateTaskList<T> : List<T>, ISimpleTask where T : ISimpleTask
	{
		public TaskState State { get; set; } = TaskState.READY;

		private int _position = 0;
		//public ISimpleTask CurrentTask => this[_position].CurrentTask;

		public Game Game { get; set; }
		private int _controllerId;

		public Controller Controller
		{
			get { return Game.ControllerById(_controllerId); }
			set { _controllerId = value.Id; }
		}

		private int _sourceId;
		public IEntity Source
		{
			get { return Game.IdEntityDic[_sourceId]; }
			set { _sourceId = value.Id; }
		}

		private int _targetId;
		public IEntity Target
		{
			get { return _targetId > -1 ? Game.IdEntityDic[_targetId] : null; }
			set { _targetId = value?.Id ?? -1; }
		}

		public List<IPlayable> Playables
		{
			get { return Game.TaskStack.Playables; }
			set { Game.TaskStack.Playables = value; }
		}

		public List<string> CardIds
		{
			get { return Game.TaskStack.CardIds; }
			set { Game.TaskStack.CardIds = value; }
		}

		public bool Flag
		{
			get { return Game.TaskStack.Flag; }
			set { Game.TaskStack.Flag = value; }
		}

		public int Number
		{
			get { return Game.TaskStack.Numbers[0]; }
			set { Game.TaskStack.Numbers[0] = value; }
		}

		public int Number1
		{
			get { return Game.TaskStack.Numbers[1]; }
			set { Game.TaskStack.Numbers[1] = value; }
		}

		public int Number2
		{
			get { return Game.TaskStack.Numbers[2]; }
			set { Game.TaskStack.Numbers[2] = value; }
		}

		public int Number3
		{
			get { return Game.TaskStack.Numbers[3]; }
			set { Game.TaskStack.Numbers[3] = value; }
		}

		public int Number4
		{
			get { return Game.TaskStack.Numbers[4]; }
			set { Game.TaskStack.Numbers[4] = value; }
		}

		public StateTaskList() : base() { }
		public StateTaskList(int initialCapacity) : base(initialCapacity) { }

		public TaskState Process()
		{
			// at the start move over initial parameters ...
			if (State == TaskState.READY)
			{
				Playables = Playables ?? new List<IPlayable>();
				CardIds = CardIds ?? new List<string>();
			}

			State = TaskState.RUNNING;
			for (_position = 0; _position < Count && State == TaskState.RUNNING; _position++)
			{
				ISimpleTask task = this[_position];
				if (task.State == TaskState.COMPLETE)
					continue;

				task.Game = Game;
				task.Controller = Controller;
				task.Source = Source;
				task.Target = Target;
				//task.Playables = Playables;
				//task.Flag = Flag;
				//task.Number = Number;

				// execution
				if (task.Process() != TaskState.COMPLETE)
					break;

				// move over in queue
				Game = task.Game;
				Controller = task.Controller;
				Source = task.Source;
				Target = task.Target;
				//Playables = task.Playables;
				//Flag = task.Flag;
				//Number = task.Number;
			}

			return TaskState.COMPLETE;
		}

		public void ResetState()
		{
			State = TaskState.READY;
		}

		public static StateTaskList<ISimpleTask> Chain(params ISimpleTask[] list)
		{
			var newList = new StateTaskList<ISimpleTask>();
			newList.AddRange(list);
			return newList;
		}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public ISimpleTask Clone()
		{
			var deepClone = new StateTaskList<ISimpleTask>(Capacity);
			// Copy each task over.
			ForEach(p => deepClone.Add(p.Clone()));

			deepClone.State = State;
			// If no game was set, there is no need to copy activation specific information.
			if (Game == null)
			{
				return deepClone;
			}

			deepClone.Game = Game;
			deepClone.Controller = Controller;
			deepClone.Source = Source;
			deepClone.Target = Target;

			deepClone.Playables = Playables;
			deepClone.CardIds = CardIds;
			deepClone.Flag = Flag;
			deepClone.Number = Number;
			deepClone.Number1 = Number1;
			deepClone.Number2 = Number2;
			deepClone.Number3 = Number3;
			deepClone.Number4 = Number4;

			return deepClone;
		}

		public string ToHash(params GameTag[] ignore)
		{
			throw new NotImplementedException();
		}

		public void Stamp(IModel other)
		{
			throw new NotImplementedException();
		}

		IModel IModel.Clone()
		{
			return Clone();
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}