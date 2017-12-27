using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using SabberStoneCore.Config;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.PlayerTasks;
using SabberStoneCoreAi.Meta;
using SabberStoneCoreAi.Nodes;
using SabberStoneCoreAi.Score;
using SabberStoneCoreAi.POGame;
using SabberStoneCoreAi.src.POGame;

namespace SabberStoneCoreAi
{
	internal class ProgramTest
	{
		private static readonly Random Rnd = new Random();

		private static void MainTest(string[] args)
		{
			//todo: rename to Main
			GameConfig gameConfig = new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				Logging = false
			};

			var gameHandler = new POGameHandler(gameConfig);

			gameHandler.PlayGame();
			GameStats gameStats = gameHandler.getGameStats();

			gameStats.printResults();
			
			//FullGame();

			Console.ReadLine();
		}


		public static void OneTurn()
		{
			var game = new Game(
				new GameConfig()
				{
					StartPlayer = 1,
					Player1Name = "FitzVonGerald",
					Player1HeroClass = CardClass.WARRIOR,
					Player1Deck = Decks.AggroPirateWarrior,
					Player2Name = "RehHausZuckFuchs",
					Player2HeroClass = CardClass.SHAMAN,
					Player2Deck = Decks.MidrangeJadeShaman,
					FillDecks = false,
					Shuffle = false,
					SkipMulligan = false
				});
			game.Player1.BaseMana = 10;
			game.StartGame();

			var aiPlayer1 = new AggroScore();
			var aiPlayer2 = new AggroScore();

			game.Process(ChooseTask.Mulligan(game.Player1, aiPlayer1.MulliganRule().Invoke(game.Player1.Choice.Choices.Select(p => game.IdEntityDic[p]).ToList())));
			game.Process(ChooseTask.Mulligan(game.Player2, aiPlayer2.MulliganRule().Invoke(game.Player2.Choice.Choices.Select(p => game.IdEntityDic[p]).ToList())));

			game.MainReady();

			while (game.CurrentPlayer == game.Player1)
			{
				Console.WriteLine($"* Calculating solutions *** Player 1 ***");

				List<OptionNode> solutions = OptionNode.GetSolutions(game, game.Player1.Id, aiPlayer1, 10, 500);

				var solution = new List<PlayerTask>();
				solutions.OrderByDescending(p => p.Score).First().PlayerTasks(ref solution);
				Console.WriteLine($"- Player 1 - <{game.CurrentPlayer.Name}> ---------------------------");

				foreach (PlayerTask task in solution)
				{
					Console.WriteLine(task.FullPrint());
					game.Process(task);
					if (game.CurrentPlayer.Choice != null)
						break;
				}
			}

			Console.WriteLine(game.Player1.HandZone.FullPrint());
			Console.WriteLine(game.Player1.BoardZone.FullPrint());
		}

		public static void FullGame()
		{
			var game = new Game(
				new GameConfig()
				{
					StartPlayer = 1,
					Player1Name = "FitzVonGerald",
					Player1HeroClass = CardClass.WARRIOR,
					Player1Deck = Decks.AggroPirateWarrior,
					Player2Name = "RehHausZuckFuchs",
					Player2HeroClass = CardClass.SHAMAN,
					Player2Deck = Decks.MidrangeJadeShaman,
					FillDecks = false,
					Shuffle = true,
					SkipMulligan = false
				});
			game.StartGame();

			var aiPlayer1 = new AggroScore();
			var aiPlayer2 = new MidRangeScore();

			List<int> mulligan1 = aiPlayer1.MulliganRule().Invoke(game.Player1.Choice.Choices.Select(p => game.IdEntityDic[p]).ToList());
			List<int> mulligan2 = aiPlayer2.MulliganRule().Invoke(game.Player2.Choice.Choices.Select(p => game.IdEntityDic[p]).ToList());

			Console.WriteLine($"Player1: Mulligan {String.Join(",", mulligan1)}");
			Console.WriteLine($"Player2: Mulligan {String.Join(",", mulligan2)}");

			game.Process(ChooseTask.Mulligan(game.Player1, mulligan1));
			game.Process(ChooseTask.Mulligan(game.Player2, mulligan2));

			game.MainReady();

			while (game.State != State.COMPLETE)
			{
				Console.WriteLine("");
				Console.WriteLine($"Player1: {game.Player1.PlayState} / Player2: {game.Player2.PlayState} - " +
								  $"ROUND {(game.Turn + 1) / 2} - {game.CurrentPlayer.Name}");
				Console.WriteLine($"Hero[P1]: {game.Player1.Hero.Health} / Hero[P2]: {game.Player2.Hero.Health}");
				Console.WriteLine("");
				while (game.State == State.RUNNING && game.CurrentPlayer == game.Player1)
				{
					Console.WriteLine($"* Calculating solutions *** Player 1 ***");
					List<OptionNode> solutions = OptionNode.GetSolutions(game, game.Player1.Id, aiPlayer1, 10, 500);
					var solution = new List<PlayerTask>();
					solutions.OrderByDescending(p => p.Score).First().PlayerTasks(ref solution);
					Console.WriteLine($"- Player 1 - <{game.CurrentPlayer.Name}> ---------------------------");
					foreach (PlayerTask task in solution)
					{
						Console.WriteLine(task.FullPrint());
						game.Process(task);
						if (game.CurrentPlayer.Choice != null)
						{
							Console.WriteLine($"* Recaclulating due to a final solution ...");
							break;
						}
					}
				}

				// Random mode for Player 2
				Console.WriteLine($"- Player 2 - <{game.CurrentPlayer.Name}> ---------------------------");
				while (game.State == State.RUNNING && game.CurrentPlayer == game.Player2)
				{
					//var options = game.Options(game.CurrentPlayer);
					//var option = options[Rnd.Next(options.Count)];
					//Log.Info($"[{option.FullPrint()}]");
					//game.Process(option);
					Console.WriteLine($"* Calculating solutions *** Player 2 ***");
					List<OptionNode> solutions = OptionNode.GetSolutions(game, game.Player2.Id, aiPlayer2, 10, 500);
					var solution = new List<PlayerTask>();
					solutions.OrderByDescending(p => p.Score).First().PlayerTasks(ref solution);
					Console.WriteLine($"- Player 2 - <{game.CurrentPlayer.Name}> ---------------------------");
					foreach (PlayerTask task in solution)
					{
						Console.WriteLine(task.FullPrint());
						game.Process(task);
						if (game.CurrentPlayer.Choice != null)
						{
							Console.WriteLine($"* Recaclulating due to a final solution ...");
							break;
						}
					}
				}
			}
			Console.WriteLine($"Game: {game.State}, Player1: {game.Player1.PlayState} / Player2: {game.Player2.PlayState}");
		}
	}
}
