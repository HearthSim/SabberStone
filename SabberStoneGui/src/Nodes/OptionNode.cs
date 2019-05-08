﻿#region copyright
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
using System.Collections.Concurrent;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.PlayerTasks;
using SabberStoneCoreGui.Score;

namespace SabberStoneCoreGui.Nodes
{
	public class OptionNode
	{
		private readonly OptionNode _parent;

		private readonly Game _game;

		private int _playerId;

		public PlayerTask PlayerTask { get; }

		public string Hash;

		private int _gameState;
		public bool IsWon => _gameState > 0;

		public bool IsLost => _gameState < 0;

		public bool IsRunning => _gameState == 0;

		private int _endTurn;
		public bool IsEndTurn => _endTurn > 0;

		public bool IsRoot => PlayerTask == null;

		public int Score { get; private set; }

		public IScore Scoring { get; private set; }

		private bool _isOpponentTurn;

		public OptionNode(OptionNode parent, Game game, int playerId, PlayerTask playerTask, IScore scoring)
		{
			_parent = parent;
			_game = game.Clone(); // create clone
			_playerId = playerId;
			PlayerTask = playerTask;
			Scoring = scoring;

			if (!IsRoot)
				Execute();
		}

		public void Switch()
		{
			_isOpponentTurn = !_isOpponentTurn;
			_playerId = _game.ControllerById(_playerId).Opponent.Id;
		}

		public void Execute()
		{
			_game.Process(PlayerTask);

			SabberStoneCore.Model.Entities.Controller controller = _game.ControllerById(_playerId);

			_gameState = _game.State == State.RUNNING ? 0
				: (controller.PlayState == PlayState.WON ? 1 : -1);

			_endTurn = _game.CurrentPlayer.Id != _playerId ? 1 : 0;

			Hash = _game.Hash(GameTag.LAST_CARD_PLAYED, GameTag.ENTITY_ID);

			if (IsEndTurn || !IsRunning)
			{
				Scoring.Controller = controller;
				Score = Scoring.Rate();
			}
		}

		public void PlayerTasks(ref List<PlayerTask> list)
		{
			if (_parent == null)
				return;

			_parent.PlayerTasks(ref list);
			list.Add(PlayerTask);
		}

		//public void Options(ref Dictionary<string, OptionNode> optionNodes)
		//{
		//	var options = _game.ControllerById(_playerId).Options(!_isOpponentTurn);

		//	foreach (var option in options)
		//	{
		//		var optionNode = new OptionNode(this, _game, _playerId, option, Scoring);
		//		if (!optionNodes.ContainsKey(optionNode.Hash))
		//			optionNodes.Add(optionNode.Hash, optionNode);
		//	}
		//}
		public void Options(ref ConcurrentDictionary<string, OptionNode> optionNodes)
		{
			List<PlayerTask> options = _game.ControllerById(_playerId).Options(/*!_isOpponentTurn*/);

			foreach (PlayerTask option in options)
			{
				var optionNode = new OptionNode(this, _game, _playerId, option, Scoring);
				optionNodes.TryAdd(optionNode.Hash, optionNode);
			}
		}
	}
}
