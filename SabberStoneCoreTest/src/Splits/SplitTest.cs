﻿using System.Linq;
using Xunit;
using SabberStoneCore.Actions;
using SabberStoneCore.Config;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.PlayerTasks;

namespace SabberStoneCoreTest.Splits
{

	public class SplitTest
	{
		[Fact]
		public void MadBomberBasic1()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.PRIEST,
					Player2HeroClass = CardClass.HUNTER,
					FillDecks = true,
					Splitting = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();
			var bomber1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mad Bomber"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, bomber1));
			Assert.Equal(4, game.FinalSplits.Count);
			Assert.Equal(8, game.FinalSplits.Sum(p => p.SameState));
			Assert.Equal(0.125, game.FinalSplits[0].Probability);
			Assert.Equal(0.375, game.FinalSplits[1].Probability);
			Assert.Equal(0.375, game.FinalSplits[2].Probability);
			Assert.Equal(0.125, game.FinalSplits[3].Probability);
		}

		[Fact]
		public void MadBomberBasic2()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.PRIEST,
					Player2HeroClass = CardClass.HUNTER,
					FillDecks = true,
					Splitting = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();
			var hoarder1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, hoarder1));
			//var hoarder2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
			//game.Process(PlayCardTask.Minion(game.CurrentPlayer, hoarder2));
			//game.Process(EndTurnTask.Any(game.CurrentPlayer));
			//var hoarder3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
			//game.Process(PlayCardTask.Minion(game.CurrentPlayer, hoarder3));
			//var toad1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Huge Toad"));
			//game.Process(PlayCardTask.Minion(game.CurrentPlayer, toad1));
			var bomber1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mad Bomber"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, bomber1));
			Assert.Equal(7, game.FinalSplits.Count);
			Assert.Equal(20, game.FinalSplits.Sum(p => p.SameState));
		}

		[Fact]
		public void MadBomberBasic3()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.PRIEST,
					Player2HeroClass = CardClass.HUNTER,
					FillDecks = true,
					Splitting = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();
			var hoarder1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, hoarder1));
			var hoarder2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, hoarder2));
			//game.Process(EndTurnTask.Any(game.CurrentPlayer));
			//var hoarder3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
			//game.Process(PlayCardTask.Minion(game.CurrentPlayer, hoarder3));
			//var toad1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Huge Toad"));
			//game.Process(PlayCardTask.Minion(game.CurrentPlayer, toad1));
			var bomber1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mad Bomber"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, bomber1));
			Assert.Equal(12, game.FinalSplits.Count);
			Assert.Equal(44, game.FinalSplits.Sum(p => p.SameState));
		}

		[Fact]
		public void MadBomberBasic4()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.PRIEST,
					Player2HeroClass = CardClass.HUNTER,
					FillDecks = true,
					Splitting = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();
			var hoarder1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, hoarder1));
			var hoarder2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, hoarder2));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			var hoarder3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, hoarder3));
			//var toad1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Huge Toad"));
			//game.Process(PlayCardTask.Minion(game.CurrentPlayer, toad1));
			var bomber1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mad Bomber"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, bomber1));
			Assert.Equal(20, game.FinalSplits.Count);
			Assert.Equal(86, game.FinalSplits.Sum(p => p.SameState));
		}

		[Fact]
		public void MadBomberBasic5()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.PRIEST,
					Player2HeroClass = CardClass.HUNTER,
					FillDecks = true,
					Splitting = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();
			var hoarder1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, hoarder1));
			var hoarder2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, hoarder2));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			var hoarder3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, hoarder3));
			var toad1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Huge Toad"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, toad1));
			var bomber1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mad Bomber"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, bomber1));
			Assert.Equal(42, game.FinalSplits.Count);
			Assert.Equal(191, game.FinalSplits.Sum(p => p.SameState));
		}
	}
}
