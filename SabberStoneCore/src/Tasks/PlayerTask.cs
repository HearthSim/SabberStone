using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SabberStoneCore.Tasks
{
	public enum PlayerTaskType
	{
		CHOOSE, CONCEDE, END_TURN, HERO_ATTACK, HERO_POWER, MINION_ATTACK, PLAY_CARD
	}

	public abstract class PlayerTask : ISimpleTask
	{
		public TaskState State { get; set; } = TaskState.READY;
		//public ISimpleTask CurrentTask => this;

		public PlayerTaskType PlayerTaskType { get; set; }
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
			get { return Game.EntityContainer[_sourceId]; }
			set { _sourceId = value.Id; }
		}
		private int _targetId;
		public IEntity Target
		{
			get { return _targetId > -1 ? Game.EntityContainer[_targetId] : null; }
			set { _targetId = value?.Id ?? -1; }
		}

		// TODO; Something must be done to have the following set of properties removed
		// from this class because they are unused!
		public List<IPlayable> Playables { get; set; }
		public List<string> CardIds { get; set; }
		public bool Flag { get; set; } = false;
		public int Number { get; set; } = 0;
		public int Number1 { get; set; } = 0;
		public int Number2 { get; set; } = 0;
		public int Number3 { get; set; } = 0;
		public int Number4 { get; set; } = 0;

		//public List<Game> Splits { get; set; } = new List<Game>();
		//public IEnumerable<IEnumerable<IPlayable>> Sets { get; set; }

		public int ZonePosition { get; set; } = -1;
		public int ChooseOne { get; set; }

		public virtual TaskState Process()
		{
			return TaskState.COMPLETE;
		}

		// TODO; Move into GUI projects. + overriden methods from implementers.
		public virtual string FullPrint()
		{
			return "PlayerTask";
		}

		public void ResetState()
		{
			State = TaskState.READY;
		}

		/// <summary>
		/// Forces implementing classes to clone themselves.
		/// </summary>
		/// <param name="newGame"></param>
		/// <returns></returns>
		protected abstract PlayerTask InternalClone(Game newGame);

		#region IMODEL_IMPLEMENTATION
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public ISimpleTask Clone(Game newGame)
		{
			PlayerTask deepClone = InternalClone(newGame) ?? throw new InvalidProgramException("The implementer returned null!");

			deepClone.State = State;

			// If no game was set, there is no need to copy stack + task runtime information.
			if (Game == null)
			{
				return deepClone;
			}

			deepClone.Game = newGame;
			deepClone.Controller = Controller.ClonedFrom(newGame);
			deepClone.Source = Source.ClonedFrom(newGame);
			deepClone.Target = Target.ClonedFrom(newGame);

			return deepClone;
		}

		public string ToHash(params GameTag[] ignore)
		{
			// TODO
			throw new NotImplementedException();
		}

		public void Stamp(IModel other)
		{
			// TODO
			throw new NotImplementedException();
		}

		IModel IModel.Clone(Game newGame)
		{
			return Clone(newGame);
		}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
		#endregion
	}
}
