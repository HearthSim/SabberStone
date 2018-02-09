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
					Logging = false,
				};
			    var game = new Game(config);
				game.StartGame();

				do
				{
					List<PlayerTask> options = game.CurrentPlayer.Options();
					game.Process(options[rnd.Next(options.Count)]);
					game = game.Clone();
				} while (game.State != State.COMPLETE);

				if (i % (TESTCOUNT / 10) == 0)
					Console.WriteLine($"{((double)i / TESTCOUNT) * 100}% done");
			}
	    }
    }
}
