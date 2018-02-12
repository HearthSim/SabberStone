using System;
using System.Collections.Generic;
using System.Text;
using SabberStoneCore.Enums;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks;

namespace SabberStoneCoreConsole
{
    public static class StabilityTest
    {
	    private const int TESTCOUNT = 100000;
	    private static Random rnd = new Random();

	    public static void CloneStabilityTest()
	    {
		    Console.WriteLine("Test started");
			for (int i = 0; i < TESTCOUNT; i++)
			{
				var config = new GameConfig
				{
					Player1HeroClass = (CardClass)rnd.Next(2, 11),
					Player2HeroClass = (CardClass)rnd.Next(2, 11),
					FillDecks = true,
					FillDecksPredictably = true,
					Shuffle = false,
					SkipMulligan = true,
					History = false,
					Logging = true,
				};
			    var game = new Game(config);
				game.StartGame();

				//try
				//{
					do
					{
						game = game.Clone(true);
						List<PlayerTask> options = game.CurrentPlayer.Options();
						PlayerTask lastOption = options[rnd.Next(options.Count)];
						game.Process(lastOption);
					} while (game.State != State.COMPLETE);
				//} catch (Exception e)
				//{
				//	Program.ShowLog(game, LogLevel.DEBUG);
				//	Console.WriteLine(e.Message);
				//	Console.WriteLine(e.Source);
				//	Console.WriteLine(e.TargetSite);
				//	Console.WriteLine(e.StackTrace);
				//	break;
				//}


			if (i % (TESTCOUNT / 10) == 0)
					Console.WriteLine($"{((double)i / TESTCOUNT) * 100}% done");
			}
	    }
    }
}
