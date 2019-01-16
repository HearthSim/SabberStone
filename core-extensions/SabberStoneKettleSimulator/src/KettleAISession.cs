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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using SabberStoneCore.Enums;
using SabberStoneCore.Kettle;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.PlayerTasks;
using SabberStoneCoreAi.Nodes;
using SabberStoneCoreAi.Score;
using SabberStoneKettle;

namespace SabberStoneKettleSimulator
{
	class KettleAISession
	{
		private KettleStartClient StartClient;
		private KettleAdapter Adapter;
		private int PlayerId;
		private KettleSession Session;

		private static readonly Random Rand = new Random();

		public KettleAISession(KettleSession session, KettleStartClient startClient)
		{
			this.StartClient = startClient;
			this.Session = session;
		}

		public void Enter()
		{
			// first we connect to the gameserver
			var socket = new Socket(SocketType.Stream, ProtocolType.IP);
			socket.Connect(StartClient.IP, StartClient.Port);
			Adapter = new KettleAdapter(new NetworkStream(socket));
			Adapter.OnGameJoined += OnGameJoined;
			Adapter.OnEntityChoices += OnEntityChoices;
			Adapter.OnEntitiesChosen += OnEntitiesChosen;
			Adapter.OnOptionsBlock += OnOptionsBlock;
			Adapter.OnUserUI += OnUserUI;
			Adapter.OnHistory += OnHistory;

			Adapter.SendMessage(StartClient.JoinGame);

			// and then we keep listening on the socket
			while (true)
			{
				if (!Adapter.HandleNextPacket())
				{
					Console.WriteLine("Kettle session ended.");
					return;
				}
			}
		}

		public PlayerTask DoAI(List<PlayerTask> tasks)
		{
			IScore score = new AggroScore();
			Game currentGame = Session.Game;

			if (currentGame.CurrentPlayer.Choice == null)
			{
				List<OptionNode> solutions = OptionNode.GetSolutions(currentGame, currentGame.CurrentPlayer.Id, score, 10, 500);
				var solution = new List<PlayerTask>();
				solutions.OrderByDescending(p => p.Score).First().PlayerTasks(ref solution);
				return solution.First();
			}

			if (currentGame.CurrentPlayer.Choice.ChoiceType == ChoiceType.MULLIGAN)
			{
				return tasks[Rand.Next(0, tasks.Count)];
				//return ChooseTask.Mulligan(currentGame.CurrentPlayer,
				//    score.MulliganRule()
				//        .Invoke(
				//            currentGame.CurrentPlayer.Choice.Choices.Select(p => currentGame.IdEntityDic[p]).ToList()));
			}

			// random ai!!
			return tasks[Rand.Next(0, tasks.Count)];
		}

		public void OnGameJoined(KettleGameJoined gameJoined)
		{
			Console.WriteLine("AI OnGameJoined called.");
		}

		public void OnEntityChoices(KettleEntityChoices entityChoices)
		{
			Console.WriteLine("AI EntityChoices called.");
			if (entityChoices.PlayerId != PlayerId)
				return;

			SabberStoneCore.Model.Entities.Controller player = PlayerId == 1 ? Session.Game.Player1 : Session.Game.Player2;
			Choice Choice = player.Choice;
			List<PlayerTask> options = new List<PlayerTask>();
			switch (Choice.ChoiceType)
			{
				case ChoiceType.GENERAL:
					Choice.Choices.ToList().ForEach(p => options.Add(ChooseTask.Pick(player, p)));
					break;
				case ChoiceType.MULLIGAN:
					IEnumerable<IEnumerable<int>> choices = SabberStoneCore.Model.Util.GetPowerSet(Choice.Choices);
					choices.ToList().ForEach(p => options.Add(ChooseTask.Mulligan(player, p.ToList())));
					break;
				default:
					throw new NotImplementedException();
			}

			// Do AI shit
			PlayerTask option = DoAI(options);

			// Convert it to a kettle choices
			KettleChooseEntities chooseEntities = new KettleChooseEntities();
			chooseEntities.Id = entityChoices.Id;
			chooseEntities.Choices = ((ChooseTask)option).Choices;

			Adapter.SendMessage(chooseEntities);
		}

		public void OnEntitiesChosen(KettleEntitiesChosen entitiesChosen)
		{
			Console.WriteLine("AI OnEntitiesChosen called.");
		}

		public void OnOptionsBlock(KettleOptionsBlock optionsBlock)
		{
			// convert that option 
			Console.WriteLine("AI OnOptionsBlock called.");
			if (optionsBlock.PlayerId != PlayerId)
				return;

			List<PlayerTask> options = Session.Game.CurrentPlayer.Options();

			// Do AI shit
			PlayerTask option = DoAI(options);

			// Convert it to poweroptions
			PowerAllOptions poweroptions = PowerOptionsBuilder.AllOptions(Session.Game, new List<PlayerTask> { option });

			// And create a kettle block for it
			KettleOption chosenoption = new KettleOptionsBlock(poweroptions, Session.Game.CurrentPlayer.PlayerId).Options[0];

			int mainOptionIndex = 0;
			int subOptionIndex = 0;
			int target = 0;
			int position = 0;

			// Then we try and find the kettle option that matches
			foreach (KettleOption koption in optionsBlock.Options)
			{
				if (koption.Type != chosenoption.Type)
					continue;

				if (!OptionsMatch(chosenoption.MainOption, koption.MainOption))
					continue;

				if ((chosenoption.SubOptions == null || chosenoption.SubOptions.Count == 0) != (koption.SubOptions == null || koption.SubOptions.Count == 0))
					continue;

				if (chosenoption.SubOptions != null)
				{
					foreach (KettleSubOption suboption in chosenoption.SubOptions)
					{
						if (OptionsMatch(chosenoption.SubOptions[0], suboption))
						{
							subOptionIndex = koption.SubOptions.IndexOf(suboption);
							break;
						}
					}
				}

				mainOptionIndex = optionsBlock.Options.IndexOf(koption);

				if (chosenoption.MainOption != null && chosenoption.MainOption.Targets != null)
					target = chosenoption.MainOption.Targets[0];
				break;
			}

			if (option is PlayCardTask playCard)
			{
				position = playCard.ZonePosition;
			}

			KettleSendOption sendoption = new KettleSendOption();
			sendoption.Id = optionsBlock.Id;
			sendoption.MainOption = mainOptionIndex;
			sendoption.SubOption = subOptionIndex;
			sendoption.Target = target;
			sendoption.Position = position;

			Adapter.SendMessage(sendoption);
		}

		public void OnUserUI(KettleUserUI userUi)
		{
			Console.WriteLine("AI OnUserUI called.");
		}

		public void OnHistory(List<KettleHistoryEntry> history)
		{
			Console.WriteLine("AI OnHistory called.");
			if (history[0] is KettleHistoryCreateGame)
			{
				KettleHistoryCreateGame kcreate = (KettleHistoryCreateGame)history[0];
				KettlePlayer player = kcreate.Players.Where(p => p.AccountId == StartClient.JoinGame.AccountId).First();
				PlayerId = player.Entity.EntityId - 1;
			}
		}

		public bool OptionsMatch(KettleSubOption option1, KettleSubOption option2)
		{
			if ((option1 == null) != (option2 == null))
				return false;

			if (option1 != null)
			{
				if (option1.Id != option2.Id)
					return false;

				if ((option1.Targets == null || option1.Targets.Count == 0) != (option2.Targets == null || option2.Targets.Count == 0))
					return false;

				if (option1.Targets != null)
				{
					foreach (int target in option1.Targets)
					{
						if (!option2.Targets.Contains(target))
							return false;
					}
				}
			}

			return true;
		}
	}
}
