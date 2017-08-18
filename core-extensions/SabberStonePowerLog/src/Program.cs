using System;
using System.Linq;
using SabberStonePowerLog.Model;

namespace SabberStonePowerLog
{
	class Program
	{
		static void Main(string[] args)
		{
			var interpreter = new Interpreter(@"C:\Users\admin\Source\Repos\SabberStone\SabberStonePowerLog\Files\", "Power.log");
			System.Collections.Generic.List<PowerGame> games = interpreter.Parse(true, true);
			Console.WriteLine($"Done parsing! Found {games.Count} game(s) in log.");
			Console.ReadKey();

			if (games.Any())
			{
				PowerGame game = games.Last();

				Console.WriteLine($"Starting a syncronized PowerGame!");

				while (game.PowerHistory.Count > 0)
				{
					PowerHistoryEntry entry = game.PowerHistory.Dequeue();

					Console.WriteLine($"Dequeue {entry}.");

					Console.ReadKey();
				}
			}
		}
	}
}
