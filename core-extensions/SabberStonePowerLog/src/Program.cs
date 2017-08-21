using System;
using System.Linq;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStonePowerLog.Model;
using SabberStonePowerLog.src.Sync;
using System.Collections.Generic;

namespace SabberStonePowerLog
{
	class Program
	{
		static void Main(string[] args)
		{
			var interpreter = new Interpreter(@"C:\Users\admin\Source\Repos\SabberStone\core-extensions\SabberStonePowerLog\resources\", "initialmulli.log");
			List<PowerGame> games = interpreter.Parse(true, true);
			Console.WriteLine($"Done parsing! Found {games.Count} game(s) in log.");
			Console.ReadKey();

			if (games.Any())
			{
				PowerGame game = games.Last();
				

				Console.WriteLine($"Starting a syncronized PowerGame!");

				while (game.PowerHistory.Count > 0)
				{
					PowerHistoryEntry entry = game.PowerHistory.Dequeue();
					Console.WriteLine($"Dequeue {entry.ToString()}.");
					Console.ReadKey();
					//entry.Process(game);
				}
				//var realGame = new SyncedGame(game);
				//realGame.Sync();
			}
		}
	}
}
