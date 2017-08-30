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
			var interpreter = new Interpreter(@"D:\git\SabberStone\core-extensions\SabberStonePowerLogTest\Logs\", "initialmulli.log");
			List<PowerGame> games = interpreter.Parse(true, true);
			Console.WriteLine($"Done parsing! Found {games.Count} game(s) in log.");
			Console.ReadKey();

			if (games.Any())
			{
				var game = games.Last();

				Console.WriteLine($"Starting a syncronized PowerGame!");

				while (game.PowerHistory.Count > 0)
				{
					var entry = game.PowerHistory.Dequeue();
					Console.WriteLine($"Dequeue {entry}.");
					//Console.ReadKey();
					entry.Process(game);
				}
				//var realGame = new SyncedGame(game);
				//realGame.Sync();
			}
			Console.ReadKey();
		}
	}
}
