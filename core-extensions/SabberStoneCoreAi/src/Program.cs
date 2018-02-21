using System;
using SabberStoneCore.Config;
using SabberStoneCore.Enums;
using SabberStoneCoreAi.POGame;
using SabberStoneCoreAi.src.Agent.ExampleAgents;
using SabberStoneCoreAi.src.POGame;

namespace SabberStoneCoreAi
{
	internal class Program
	{

		private static void Main(string[] args)
		{
			
			Console.WriteLine("Setup gameConfig");

			//todo: rename to Main
			GameConfig gameConfig = new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				Logging = false
			};

			Console.WriteLine("Setup POGameHandler");
			RandomAgent player1 = new RandomAgent();
			RandomAgent player2 = new RandomAgent();
			var gameHandler = new POGameHandler(gameConfig, player1, player2, debug:true);

			Console.WriteLine("PlayGame");
			gameHandler.PlayGame();
			GameStats gameStats = gameHandler.getGameStats();

			gameStats.printResults();


			Console.WriteLine("Test successful");
			Console.ReadLine();
		}
	}
}
