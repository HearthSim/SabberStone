using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCoreAi.POGame
{
	class GameStats
	{
		private int turns = 0;
		private int nr_games = 0;
		private int[] wins = new[] { 0, 0 };
		private long[] time_per_player = new[] {0L, 0L};

		//Todo add getter for each private variable

		public GameStats()
		{
		}
		

		public void addGame(Game game, Stopwatch[] playerWatches)
		{
			nr_games++;
			turns += game.Turn;

			if (game.Player1.PlayState == PlayState.WON)
				wins[0]++;
			if (game.Player2.PlayState == PlayState.WON)
				wins[1]++;

			time_per_player[0] += playerWatches[0].ElapsedMilliseconds;
			time_per_player[1] += playerWatches[1].ElapsedMilliseconds;
		}

		public void printResults()
		{
			if (nr_games > 0)
			{
				Console.WriteLine($"{nr_games} games with {turns} turns took {time_per_player[0] + time_per_player[1]} ms => " +
							  $"Avg. {(time_per_player[0] + time_per_player[1]) / nr_games} per game " +
							  $"and {(time_per_player[0] + time_per_player[1]) / (nr_games * turns)} per turn!");
				Console.WriteLine($"playerA {wins[0] * 100 / nr_games}% vs. playerB {wins[1] * 100 / nr_games}%!");
			} else
			{
				Console.WriteLine("No games played yet. Use Gamehandler.PlayGame() to add games.");
			}
			
		}
		
	}
}
