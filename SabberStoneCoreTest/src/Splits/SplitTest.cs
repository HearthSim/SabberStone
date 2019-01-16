#region copyright
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
//using System.Linq;
//using Xunit;
//using SabberStoneCore.Actions;
//using SabberStoneCore.Config;
//using SabberStoneCore.Enums;
//using SabberStoneCore.Model;
//using SabberStoneCore.Tasks.PlayerTasks;
//using SabberStoneCore.Model.Entities;

//namespace SabberStoneCoreTest.Splits
//{

//	public class SplitTest
//	{
//		[Fact(Skip ="Need to be re-implemented")]
//		public void MadBomberBasic1()
//		{
//			var game =
//				new Game(new GameConfig
//				{
//					StartPlayer = 1,
//					Player1HeroClass = CardClass.PRIEST,
//					Player2HeroClass = CardClass.HUNTER,
//					FillDecks = true,
//					Splitting = true
//				});
//			game.Player1.BaseMana = 10;
//			game.Player2.BaseMana = 10;
//			game.StartGame();
//			IPlayable bomber1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mad Bomber"));
//			game.Process(PlayCardTask.Minion(game.CurrentPlayer, bomber1));
//			Assert.Equal(4, game.FinalSplits.Count);
//			Assert.Equal(8, game.FinalSplits.Sum(p => p.SameState));
//		}

//		[Fact(Skip = "Need to be re-implemented")]
//		public void MadBomberBasic2()
//		{
//			var game =
//				new Game(new GameConfig
//				{
//					StartPlayer = 1,
//					Player1HeroClass = CardClass.PRIEST,
//					Player2HeroClass = CardClass.HUNTER,
//					FillDecks = true,
//					Splitting = true
//				});
//			game.Player1.BaseMana = 10;
//			game.Player2.BaseMana = 10;
//			game.StartGame();
//			IPlayable hoarder1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
//			game.Process(PlayCardTask.Minion(game.CurrentPlayer, hoarder1));
//			//var hoarder2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
//			//game.Process(PlayCardTask.Minion(game.CurrentPlayer, hoarder2));
//			//game.Process(EndTurnTask.Any(game.CurrentPlayer));
//			//var hoarder3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
//			//game.Process(PlayCardTask.Minion(game.CurrentPlayer, hoarder3));
//			//var toad1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Huge Toad"));
//			//game.Process(PlayCardTask.Minion(game.CurrentPlayer, toad1));
//			IPlayable bomber1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mad Bomber"));
//			game.Process(PlayCardTask.Minion(game.CurrentPlayer, bomber1));
//			Assert.Equal(7, game.FinalSplits.Count);
//			Assert.Equal(20, game.FinalSplits.Sum(p => p.SameState));
//		}

//		[Fact(Skip = "Need to be re-implemented")]
//		public void MadBomberBasic3()
//		{
//			var game =
//				new Game(new GameConfig
//				{
//					StartPlayer = 1,
//					Player1HeroClass = CardClass.PRIEST,
//					Player2HeroClass = CardClass.HUNTER,
//					FillDecks = true,
//					Splitting = true
//				});
//			game.Player1.BaseMana = 10;
//			game.Player2.BaseMana = 10;
//			game.StartGame();
//			IPlayable hoarder1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
//			game.Process(PlayCardTask.Minion(game.CurrentPlayer, hoarder1));
//			IPlayable hoarder2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
//			game.Process(PlayCardTask.Minion(game.CurrentPlayer, hoarder2));
//			//game.Process(EndTurnTask.Any(game.CurrentPlayer));
//			//var hoarder3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
//			//game.Process(PlayCardTask.Minion(game.CurrentPlayer, hoarder3));
//			//var toad1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Huge Toad"));
//			//game.Process(PlayCardTask.Minion(game.CurrentPlayer, toad1));
//			IPlayable bomber1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mad Bomber"));
//			game.Process(PlayCardTask.Minion(game.CurrentPlayer, bomber1));
//			Assert.Equal(12, game.FinalSplits.Count);
//			Assert.Equal(44, game.FinalSplits.Sum(p => p.SameState));
//		}

//		[Fact(Skip = "Need to be re-implemented")]
//		public void MadBomberBasic4()
//		{
//			var game =
//				new Game(new GameConfig
//				{
//					StartPlayer = 1,
//					Player1HeroClass = CardClass.PRIEST,
//					Player2HeroClass = CardClass.HUNTER,
//					FillDecks = true,
//					Splitting = true
//				});
//			game.Player1.BaseMana = 10;
//			game.Player2.BaseMana = 10;
//			game.StartGame();
//			IPlayable hoarder1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
//			game.Process(PlayCardTask.Minion(game.CurrentPlayer, hoarder1));
//			IPlayable hoarder2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
//			game.Process(PlayCardTask.Minion(game.CurrentPlayer, hoarder2));
//			game.Process(EndTurnTask.Any(game.CurrentPlayer));
//			IPlayable hoarder3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
//			game.Process(PlayCardTask.Minion(game.CurrentPlayer, hoarder3));
//			//var toad1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Huge Toad"));
//			//game.Process(PlayCardTask.Minion(game.CurrentPlayer, toad1));
//			IPlayable bomber1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mad Bomber"));
//			game.Process(PlayCardTask.Minion(game.CurrentPlayer, bomber1));
//			Assert.Equal(20, game.FinalSplits.Count);
//			Assert.Equal(86, game.FinalSplits.Sum(p => p.SameState));
//		}

//		[Fact(Skip = "Need to be re-implemented")]
//		public void MadBomberBasic5()
//		{
//			var game =
//				new Game(new GameConfig
//				{
//					StartPlayer = 1,
//					Player1HeroClass = CardClass.PRIEST,
//					Player2HeroClass = CardClass.HUNTER,
//					FillDecks = true,
//					Splitting = true
//				});
//			game.Player1.BaseMana = 10;
//			game.Player2.BaseMana = 10;
//			game.StartGame();
//			IPlayable hoarder1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
//			game.Process(PlayCardTask.Minion(game.CurrentPlayer, hoarder1));
//			IPlayable hoarder2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
//			game.Process(PlayCardTask.Minion(game.CurrentPlayer, hoarder2));
//			game.Process(EndTurnTask.Any(game.CurrentPlayer));
//			IPlayable hoarder3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
//			game.Process(PlayCardTask.Minion(game.CurrentPlayer, hoarder3));
//			IPlayable toad1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Huge Toad"));
//			game.Process(PlayCardTask.Minion(game.CurrentPlayer, toad1));
//			IPlayable bomber1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mad Bomber"));
//			game.Process(PlayCardTask.Minion(game.CurrentPlayer, bomber1));
//			Assert.Equal(42, game.FinalSplits.Count);
//			Assert.Equal(191, game.FinalSplits.Sum(p => p.SameState));
//		}
//	}
//}
