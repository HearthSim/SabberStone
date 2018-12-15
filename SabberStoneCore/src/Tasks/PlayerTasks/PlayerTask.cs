#region copyright
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License,
// or any later version.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
#endregion
using System;
using System.Collections.Generic;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCore.Tasks
{
	public enum PlayerTaskType
	{
		CHOOSE, CONCEDE, END_TURN, HERO_ATTACK, HERO_POWER, MINION_ATTACK, PLAY_CARD
	}

	public class PlayerTask
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
		public virtual IEntity Source
		{
			get { return Game.IdEntityDic[_sourceId]; }
			set { _sourceId = value.Id; }
		}
		private int _targetId;
		public IEntity Target
		{
			get { return _targetId > 0 ? Game.IdEntityDic[_targetId] : null; }
			set { _targetId = value?.Id ?? -1; }
		}

		public int ZonePosition { get; set; } = -1;
		public int ChooseOne { get; set; }
		public bool SkipPrePhase { get; set; }

		//public List<Game> Splits { get; set; } = new List<Game>();
		//public IEnumerable<IEnumerable<IPlayable>> Sets { get; set; }

		public bool HasSource => _sourceId > 0;
		public bool HasTarget => _targetId > 0;

		public virtual List<PlayerTask> Build(Game game, Controller controller, IPlayable source, IPlayable target)
		{
			Game = game;
			Controller = controller;
			Source = source;
			Target = target;
			return new List<PlayerTask> { this };
		}

		public virtual TaskState Process()
		{
			return TaskState.COMPLETE;
		}

		public ISimpleTask Clone()
		{
			throw new NotImplementedException();
		}

		public virtual string FullPrint()
		{
			return "PlayerTask";
		}

		public void ResetState()
		{
			State = TaskState.READY;
		}
	}
}
