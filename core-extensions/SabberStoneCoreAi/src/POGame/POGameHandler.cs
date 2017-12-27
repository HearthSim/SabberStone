using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using SabberStoneCore.Config;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks;
using SabberStoneCoreAi.Agent;
using SabberStoneCoreAi.src.Agent;
using SabberStoneCoreAi.src.Agent.ExampleAgents;
using SabberStoneCoreAi.src.POGame;

namespace SabberStoneCoreAi.POGame
{
	class POGameHandler
	{
		private AbstractAgent player1;
		private AbstractAgent player2;

		private GameConfig gameConfig;
		private bool setupHeroes = true;

		private GameStats gameStats;
		private static readonly Random Rnd = new Random();


		public POGameHandler(GameConfig gameConfig, bool setupHeroes = true)
		{
			this.gameConfig = gameConfig;
			this.setupHeroes = setupHeroes;
			player1 = new RandomAgent();
			player2 = new RandomAgent();
		}

		public POGameHandler(GameConfig gameConfig, AbstractAgent player1, AbstractAgent player2, bool setupHeroes = true)
		{
			this.gameConfig = gameConfig;
			this.setupHeroes = setupHeroes;
			this.player1 = player1;
			this.player2 = player2;
			gameStats = new GameStats();
		}


		public void PlayGame(bool addToGameStats=true)
		{
			Game game = new Game(gameConfig, setupHeroes);
			AbstractAgent currentAgent;
			Stopwatch currentStopwatch;
			PartialObservationGame poGame;
			Stopwatch[] watches = new[] {new Stopwatch(), new Stopwatch()};
			

			game.StartGame();
			while (game.State != State.COMPLETE)
			{
				currentAgent = game.CurrentPlayer == game.Player1 ? player1 : player2;
				currentStopwatch = game.CurrentPlayer == game.Player1 ? watches[0] : watches[1];
				poGame = new PartialObservationGame(game);

				currentStopwatch.Start();
				List<PlayerTask> playertasks = currentAgent.GetMove(poGame);
				currentStopwatch.Stop();

				while (playertasks.Count > 0 && game.CurrentPlayer == game.Player1)
				{
					game.Process(playertasks[0]);
					playertasks.RemoveAt(0);
				}
			}

			if (addToGameStats)
				gameStats.addGame(game, watches);
		}

		public void PlayGames(int nr_of_games, bool addToGameStats=true)
		{
			for (int i = 0; i < 0; i++)
			{
				PlayGame(addToGameStats);
			}
		}

		public GameStats getGameStats()
		{
			return gameStats;
		}
	}

}
