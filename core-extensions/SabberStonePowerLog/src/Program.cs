﻿#region copyright
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
using System.Linq;
using SabberStonePowerLog.Model;
using System.Collections.Generic;

namespace SabberStonePowerLog
{
	class Program
	{
		static void Main(string[] args)
		{
			//var interpreter = new Interpreter(@"D:\Hearthstone\Logs\", "Power.log");
			var interpreter = new Interpreter(@"C:\Program Files (x86)\Hearthstone\Logs\", "Power.log");
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
