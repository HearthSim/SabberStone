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

	public class PlayerTask : ISimpleTask
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
			get { return Game.IdEntityDic[_sourceId]; }
			set { _sourceId = value.Id; }
		}
		private int _targetId;
		public IEntity Target
		{
			get { return _targetId > -1 ? Game.IdEntityDic[_targetId] : null; }
			set { _targetId = value?.Id ?? -1; }
		}
		public List<IPlayable> Playables { get; set; }
		public List<string> CardIds { get; set; }
		public bool Flag { get; set; } = false;
		public int Number { get; set; } = 0;
		public int Number1 { get; set; } = 0;
		public int Number2 { get; set; } = 0;
		public int Number3 { get; set; } = 0;
		public int Number4 { get; set; } = 0;

		public int ZonePosition { get; set; } = -1;
		public int ChooseOne { get; set; }

		public List<Game> Splits { get; set; } = new List<Game>();
		public IEnumerable<IEnumerable<IPlayable>> Sets { get; set; }

		public virtual List<ISimpleTask> Build(Game game, Controller controller, IPlayable source, IPlayable target)
		{
			Game = game;
			Controller = controller;
			Source = source;
			Target = target;
			return new List<ISimpleTask> { this };
		}

		public virtual TaskState Process()
		{
			return TaskState.COMPLETE;
		}

		// TODO; Move into GUI projects.
		public virtual string FullPrint()
		{
			return "PlayerTask";
		}

		public void ResetState()
		{
			State = TaskState.READY;
		}

		#region IMODEL_IMPLEMENTATION
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

		public ISimpleTask Clone()
		{
			throw new NotImplementedException();
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
		#endregion
	}
}
