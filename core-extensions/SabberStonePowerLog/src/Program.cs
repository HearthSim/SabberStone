using System;
using System.Linq;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStonePowerLog.Model;
using SabberStonePowerLog.src.Sync;

namespace SabberStonePowerLog
{
	class Program
	{
		static void Main(string[] args)
		{
			var interpreter = new Interpreter(@"C:\Program Files (x86)\Hearthstone\Logs\", "Power.log");
			System.Collections.Generic.List<PowerGame> games = interpreter.Parse(true, true);
			Console.WriteLine($"Done parsing! Found {games.Count} game(s) in log.");
			//Console.ReadKey();

			if (games.Any())
			{
				PowerGame game = games.Last();
				

				Console.WriteLine($"Starting a syncronized PowerGame!");

				while (game.PowerHistory.Count > 0)
				{
					PowerHistoryEntry entry = game.PowerHistory.Dequeue();
					entry.Process(game);
				}
				var realGame = new SyncedGame(game);
				realGame.Sync();
			}
		}
	}
}
