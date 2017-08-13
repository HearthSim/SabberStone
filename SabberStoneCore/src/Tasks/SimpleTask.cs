using System;
using System.Collections.Generic;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks
{
	public interface ISimpleTask : IModel<ISimpleTask>
	{
		TaskState State { get; set; }
		//ISimpleTask CurrentTask { get; }

		Game Game { get; set; }
		Controller Controller { get; set; }
		IEntity Source { get; set; }
		IEntity Target { get; set; }

		List<IPlayable> Playables { get; set; }
		List<string> CardIds { get; set; }
		bool Flag { get; set; }
		int Number { get; set; }
		int Number1 { get; set; }
		int Number2 { get; set; }
		int Number3 { get; set; }
		int Number4 { get; set; }

		TaskState Process();

		void ResetState();
	}

	public abstract class SimpleTask : ISimpleTask
	{
		// TODO; Move this to Game to have unique random source limited to one game.
		internal static Random Random = new Random();

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public TaskState State { get; set; } = TaskState.READY;

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

		public void ResetState()
		{
			State = TaskState.READY;
		}

		public abstract TaskState Process();

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

		/// <summary>
		/// Forces the implementing class to clone itself.
		/// </summary>
		/// <returns></returns>
		public abstract ISimpleTask InternalClone();

		#region IMODEL_IMPLEMENTATION
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public ISimpleTask Clone()
		{
			ISimpleTask deepClone = InternalClone() ?? throw new InvalidProgramException("Implementing object returned null!");

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

		// TODO; Make this abstract and for implementing class to define ToHash().
		public string ToHash(params GameTag[] ignore)
		{
			throw new NotImplementedException();
		}

		public void Stamp(IModel other)
		{
			// Perform a shallow stamp of the other object.
			SimpleTask task = other as SimpleTask ?? throw new InvalidOperationException("other's type is not valid!");

			State = task.State;

			// If no game was set, there is no need to copy activation specific information.
			if (task.Game == null)
			{
				return;
			}

			Game = task.Game;
			Controller = task.Controller;
			Source = task.Source;
			Target = task.Target;

			//Playables = task.Playables;
			//CardIds = task.CardIds;
			//Flag = task.Flag;
			//Number = task.Number;
			//Number1 = task.Number1;
			//Number2 = task.Number2;
			//Number3 = task.Number3;
			//Number4 = task.Number4;

			//Splits = task.Splits;
			//Sets = task.Sets;
		}

		IModel IModel.Clone()
		{
			return Clone();
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
		#endregion
	}
}