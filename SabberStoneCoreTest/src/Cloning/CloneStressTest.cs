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
using System;
using Xunit;
using SabberStoneCore.Config;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.PlayerTasks;

using Generic = SabberStoneCore.Actions.Generic;
using System.Collections.Generic;

namespace SabberStoneCoreTest.Cloning
{

	public class CloneStressTest
	{
		[Fact]
		public void CloneSameSame()
		{
			var rnd = new Random();
			CardClass[] classes = new[]
			{
				CardClass.DRUID, CardClass.HUNTER, CardClass.MAGE, CardClass.PALADIN, CardClass.PRIEST,
				CardClass.ROGUE, CardClass.SHAMAN, CardClass.WARLOCK, CardClass.WARRIOR
			};
			bool flag = true;
			for (int i = 0; i < 100; i++)
			{
				var game = new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = classes[rnd.Next(classes.Length)],
					Player2HeroClass = classes[rnd.Next(classes.Length)],
					FillDecks = true,
					Logging = false
				});
				game.StartGame();

				while (game.State != State.COMPLETE)
				{
					List<PlayerTask> options = game.CurrentPlayer.Options();
					PlayerTask option = options[rnd.Next(options.Count)];
					game.Process(option);
					Game cloneGame = game.Clone();
					string str1 = game.Hash();
					string str2 = cloneGame.Hash();

					flag &= str1.Equals(str2);

					if (!flag)
						break;
				}
			}

			Assert.True(flag);
		}

		[Fact]
		public void CloneSameState()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.SHAMAN,
				FillDecks = true,
				History = false,
				Logging = false
			});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();
			Game clone = game.Clone();
			Assert.Equal(game.Hash(), clone.Hash());

			SabberStoneCore.Model.Entities.IPlayable spell1 =
				Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lightning Bolt"));
			SabberStoneCore.Model.Entities.IPlayable minion1 =
				Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			SabberStoneCore.Model.Entities.IPlayable spell2 =
				Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lightning Bolt"));

			SabberStoneCore.Model.Entities.IPlayable cSpell1 =
				Generic.DrawCard(clone.CurrentPlayer, Cards.FromName("Lightning Bolt"));
			SabberStoneCore.Model.Entities.IPlayable cSpell2 =
				Generic.DrawCard(clone.CurrentPlayer, Cards.FromName("Lightning Bolt"));
			SabberStoneCore.Model.Entities.IPlayable cMinion1 =
				Generic.DrawCard(clone.CurrentPlayer, Cards.FromName("Stonetusk Boar"));

			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, game.CurrentOpponent.Hero));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, game.CurrentOpponent.Hero));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

			clone.Process(PlayCardTask.Any(clone.CurrentPlayer, cMinion1));
			clone.Process(PlayCardTask.SpellTarget(clone.CurrentPlayer, cSpell2, clone.CurrentOpponent.Hero));
			clone.Process(PlayCardTask.SpellTarget(clone.CurrentPlayer, cSpell1, clone.CurrentOpponent.Hero));

			GameTag[] ignored = new GameTag[] {GameTag.LAST_CARD_PLAYED, GameTag.ENTITY_ID};

			string gameHash = game.Hash(ignored);
			string cloneHash = clone.Hash(ignored);

			Assert.Equal(gameHash, cloneHash);
		}

		[Fact]
		public void CloneEndTurnTask()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.SHAMAN,
				FillDecks = true
			});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();
			Game clone = game.Clone();
			//Assert.Equal(game.Hash(), clone.Hash());

			clone.Process(EndTurnTask.Any(clone.CurrentPlayer));

			Assert.NotEqual(game.CurrentPlayer.Name, clone.CurrentPlayer.Name);

			clone.Process(EndTurnTask.Any(clone.CurrentPlayer));

			Assert.Equal(game.CurrentPlayer.Name, clone.CurrentPlayer.Name);
		}

		[Fact]
		public void CloneAura()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				Player2Deck = new List<Card>
				{
					Cards.FromName("Mana Wyrm"),
					Cards.FromName("Kirin Tor Mage"),
					Cards.FromName("Vaporize")
				},
				Shuffle = false,
				FillDecks = false,
				History = false,
			});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			PlayCardTask task1 = PlayCardTask.Any(game.CurrentPlayer, "Mana Wyrm");
			PlayCardTask task2 = PlayCardTask.Any(game.CurrentPlayer, "The Coin");

			game.Process(task1);
			Game clone = game.Clone();
			clone.Process(task1);
			game.Process(task2);
			clone.Process(task2);
			Game clone2 = clone.Clone();

			var minion = game.CurrentPlayer.BoardZone[0];
			var cloneMinion = clone.CurrentPlayer.BoardZone[0];
			var clone2Minion = clone2.CurrentPlayer.BoardZone[0];

			Assert.Equal(2, minion.AttackDamage);
			Assert.Equal(2, cloneMinion.AttackDamage);
			Assert.Equal(2, clone2Minion.AttackDamage);

			clone2.Process(PlayCardTask.Any(game.CurrentPlayer, "Kirin Tor Mage"));
			Assert.Equal(2, clone2.Auras.Count);
			Game clone3 = clone2.Clone();
			var task3 = PlayCardTask.Any(game.CurrentPlayer, "Vaporize");
			clone3.Process(task3);
			clone2.Process(task3);
			Assert.Single(clone2.Auras);
			Assert.Single(clone3.Auras);

			Assert.Equal(3, clone2Minion.AttackDamage);
		}

		[Fact]
		public void CloneAura2()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Sorcerer's Apprentice"),
					Cards.FromName("Counterspell")
				},
				Player2HeroClass = CardClass.MAGE,
				Player2Deck = new List<Card>
				{
					Cards.FromName("Sorcerer's Apprentice"),
					Cards.FromName("Counterspell"),
					Cards.FromName("Vaporize")
				},
				Shuffle = false,
				FillDecks = false,
				History = false,
			});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sorcerer's Apprentice"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sorcerer's Apprentice"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(2, game.Auras.Count);
			Assert.Equal(2, game.CurrentPlayer.HandZone[0].Cost);
			Assert.Equal(2, game.CurrentOpponent.HandZone[0].Cost);
			Assert.Equal(2, game.CurrentOpponent.HandZone[1].Cost);

			Game clone = game.Clone();

			Assert.Equal(2, clone.Auras.Count);
			Assert.Equal(2, clone.CurrentPlayer.HandZone[0].Cost);
			Assert.Equal(2, clone.CurrentOpponent.HandZone[0].Cost);
			Assert.Equal(2, clone.CurrentOpponent.HandZone[1].Cost);

			clone.Process(MinionAttackTask.Any(clone.CurrentPlayer, clone.CurrentPlayer.BoardZone[0],
				clone.CurrentOpponent.BoardZone[0]));

			Assert.Empty(clone.Auras);
			Assert.Equal(3, clone.CurrentPlayer.HandZone[0].Cost);
			Assert.Equal(3, clone.CurrentOpponent.HandZone[0].Cost);
			Assert.Equal(3, clone.CurrentOpponent.HandZone[1].Cost);
		}
	}
}
