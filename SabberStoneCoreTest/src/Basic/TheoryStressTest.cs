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
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Actions;
using SabberStoneCore.Config;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks.PlayerTasks;
using Xunit;

namespace SabberStoneCoreTest.Basic
{
	public class TheoryStressTest
	{
		// TODO TheoryStressTest Patashu - Heute um 14:00 Uhr
		// order of play, auras and on-death triggers are what really stresses your implementation
		// of sequences and phases and steps there's a couple of order of play based tests in the
		// brimstone tests class, added by me. they currently fail, see if you can make them pass :wink:
		// besides those, test things like battlecries that summon minions vs sword of justice,
		// violet teacher vs wild pyromancer, etc

		[Fact]
		public void PhaseTest()
		{

		}

		[Fact]
		public static void IllidanKnifeJugglerTwilightDrakeResolveTest()
		{
			Game game;
			do
			{
				game = new Game(new GameConfig
				{
					FillDecks = true,
					History = false,
				});
				game.StartGame();
				game.ProcessCard("Knife Juggler", null, true);
				game.ProcessCard("Knife Juggler", null, true);

				game.ProcessCard("Illidan Stormrage", null, true);

				game.EndTurn();

				game.ProcessCard("Val'kyr Soulclaimer", null, true);
				game.ProcessCard("Val'kyr Soulclaimer", null, true);
				game.ProcessCard("Val'kyr Soulclaimer", null, true);
				game.ProcessCard("Val'kyr Soulclaimer", null, true);
				game.ProcessCard("Knife Juggler", null, true);
				game.ProcessCard("Knife Juggler", null, true);
			} while (game.CurrentOpponent.BoardZone.Count(p => p.Card.Name == "Knife Juggler") < 2);


			game.EndTurn();

			Generic.Draw(game.CurrentPlayer);
			Generic.Draw(game.CurrentPlayer);
			Generic.Draw(game.CurrentPlayer);

			bool flag = false;
			for (int i = 0; i < 12; i++)
			{
				Game clone = game.Clone(true);
				Minion target = clone.ProcessCard<Minion>("Twilight Drake", null, true);
				flag = flag || target.IsDead;
			}


			Assert.True(flag);
		}

		[Fact]
		public static void EnchantAuraTest()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Preparation"),
					Cards.FromName("Preparation"),
					Cards.FromName("SI:7 Agent"),
					Cards.FromName("Sorcerer's Apprentice"),
					Cards.FromName("Sorcerer's Apprentice"),
					Cards.FromName("Backstab")
				},
				FillDecks = false,
				Shuffle = false
			});
			game.Player1.BaseMana = 10;
			game.StartGame();

			Generic.Draw(game.CurrentPlayer);
			Generic.Draw(game.CurrentPlayer);

			IPlayable eviscerate1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eviscerate"));
			IPlayable eviscerate2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eviscerate"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sorcerer's Apprentice"));
			Assert.Equal(1, eviscerate1.Cost);
			Assert.Equal(1, eviscerate2.Cost);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Preparation"));
			Assert.Equal(0, eviscerate1.Cost);
			Assert.Equal(0, eviscerate2.Cost);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, eviscerate1, game.CurrentPlayer.BoardZone[0]));
			Assert.Equal(2, eviscerate2.Cost);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sorcerer's Apprentice"));
			Assert.Equal(1, eviscerate2.Cost);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Preparation"));
			Assert.Equal(0, eviscerate2.Cost);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "SI:7 Agent", game.CurrentPlayer.BoardZone[0]));
			Assert.Equal(0, eviscerate2.Cost);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Backstab", game.CurrentPlayer.BoardZone[0]));
			Assert.Equal(2, eviscerate2.Cost);
		}

		[Fact]
		public static void AuraTimingTest()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Stormwind Champion")
				},
				Player2Deck = new List<Card>
				{
					Cards.FromName("Fiery Bat")
				},
				FillDecks = false,
				Shuffle = false
			});
			game.Player1.BaseMana = 10;
			game.StartGame();

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stormwind Champion"));
			game.CurrentPlayer.BoardZone[0].Damage = 4;
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			Assert.Equal(2, game.CurrentPlayer.BoardZone[1].Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fiery Bat"));
			game.CurrentPlayer.BoardZone[0].IsExhausted = false;

			while (true)
			{
				Game clone = game.Clone();
				Assert.Equal(2, clone.CurrentOpponent.BoardZone[1].Health);

				clone.Process(MinionAttackTask.Any(clone.CurrentPlayer, clone.CurrentPlayer.BoardZone[0],
					clone.CurrentOpponent.BoardZone[0]));

				if (clone.CurrentOpponent.Hero.Damage == 7)
					continue;

				Assert.Equal(1, clone.CurrentOpponent.BoardZone.Count);
				Assert.Equal(1, clone.CurrentOpponent.BoardZone[0].AttackDamage);
				Assert.Equal(1, clone.CurrentOpponent.BoardZone[0].Health);
				break;
			}
		}

		//[Fact]
		//public static void AuraTimingTest2()
		//{
		//	var game = new Game(new GameConfig
		//	{
		//		StartPlayer = 1,
		//		Player1HeroClass = CardClass.PALADIN,
		//		Player2HeroClass = CardClass.HUNTER,
		//		FillDecks = true,
		//		Shuffle = false
		//	});
		//	game.Player1.BaseMana = 10;
		//	game.StartGame();

		//	Minion minion = game.ProcessCard<Minion>("Stonetusk Boar");
		//	Minion auraSource = game.ProcessCard<Minion>("Dire Wolf Alpha", null, true);
		//	Minion minion2 = game.ProcessCard<Minion>("Stonetusk Boar");
		//	Minion lurker = game.ProcessCard<Minion>("Moat Lurker", auraSource, true);
		//	Game clone = game.Clone();

		//	game.ProcessCard("Assassinate", lurker);
		//	clone.ProcessCard("Assassinate", clone.CurrentPlayer.BoardZone[3]);
		//}

		[Fact]
		public static void MultipleAuraRemove()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.SHAMAN,
				FillDecks = false,
				Shuffle = false
			});
			game.Player1.BaseMana = 10;
			game.StartGame();

			Minion testTarget = game.ProcessCard<Minion>("Murloc Raider");
			Minion aura1 = game.ProcessCard<Minion>("Murloc Warleader");
			Minion aura2 = game.ProcessCard<Minion>("Grimscale Oracle");

			Assert.Equal(5, testTarget.AttackDamage);
			aura1.Kill();
			Assert.Equal(3, testTarget.AttackDamage);
		}

		[Fact]
		public static void JaraxxusRepentance()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true,
				Shuffle = false
			});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();

			game.ProcessCard("Repentance");
			game.EndTurn();

			game.ProcessCard("Lord Jaraxxus");
			Assert.NotEqual(1, game.CurrentPlayer.Hero.Health);
		}

		[Fact]
		public static void SummonResolutionTest()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Murloc Tidecaller"),
					Cards.FromName("Murloc Tidecaller"),
					Cards.FromName("Murloc Tidecaller"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = false,
				Shuffle = false
			});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();

			game.ProcessCard("Call to Arms");
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
			Assert.True(game.CurrentPlayer.BoardZone.ToList().TrueForAll(p => p.AttackDamage == 3));
		}

		[Fact]
		public static void SummonResolutionTest2()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = false,
				Shuffle = false
			});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();

			game.ProcessCard("Sword of Justice");
			game.ProcessCard("Steward of Darkshire");

			Minion target1 = game.ProcessCard<Minion>("Stonetusk Boar");

			Assert.Equal(2, target1.AttackDamage);
			Assert.Equal(2, target1.Health);
			Assert.True(target1.HasDivineShield);

			game.ProcessCard("Lost in the Jungle");

			Assert.Equal(4, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(2, game.CurrentPlayer.BoardZone[2].AttackDamage);
			Assert.Equal(2, game.CurrentPlayer.BoardZone[2].Health);
			Assert.False(game.CurrentPlayer.BoardZone[2].HasDivineShield);
			Assert.Equal(2, game.CurrentPlayer.BoardZone[3].AttackDamage);
			Assert.Equal(2, game.CurrentPlayer.BoardZone[3].Health);
			Assert.False(game.CurrentPlayer.BoardZone[3].HasDivineShield);
		}

		[Fact]
		public static void UmbraTaldaramVoidlord()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				FillDecks = false,
				Shuffle = false
			});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();

			game.ProcessCard("Spiritsinger Umbra", null, true);
			game.ProcessCard("Voidlord", null, true);
			Assert.Equal(5, game.CurrentPlayer.BoardZone.Count);
			game.CurrentPlayer.BoardZone[4].Kill();
			game.CurrentPlayer.BoardZone[3].Kill();
			game.CurrentPlayer.BoardZone[2].Kill();
			game.ProcessCard("Prince Taldaram", game.CurrentPlayer.BoardZone[1], true);
			Assert.Equal(6, game.CurrentPlayer.BoardZone.Count);
		}

		[Fact]
		public static void TransformationInHand()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				FillDecks = true,
				FillDecksPredictably = true,
				Shuffle = false,
			});
			game.StartGame();

			IPlayable blade = Generic.DrawCard(game.Player1, Cards.FromName("Molten Blade"));
			IPlayable scroll = Generic.DrawCard(game.Player1, Cards.FromName("Shifting Scroll"));
			IPlayable zerus = Generic.DrawCard(game.Player1, Cards.FromName("Shifter Zerus"));

			game.EndTurn();
			game.EndTurn();

			// Next Turn
			Assert.Equal(blade.Cost, blade.Card.Cost);
			Assert.Equal(scroll.Cost, scroll.Card.Cost);
			Assert.Equal(zerus.Cost, zerus.Card.Cost);

			game.EndTurn();
			game.EndTurn();

			// Next Turn
			Assert.Equal(blade.Cost, blade.Card.Cost);
			Assert.Equal(scroll.Cost, scroll.Card.Cost);
			Assert.Equal(zerus.Cost, zerus.Card.Cost);
		}

		[Fact]
		public static void MurmuringKazakus()
		{
			var game = new Game(new GameConfig());
			game.StartGame();

			game.ProcessCard("Murmuring Elemental", null, true);
			game.ProcessCard("Kazakus", null, true);
			do
			{
				game.ChooseNthChoice(1);
			} while (game.CurrentPlayer.Choice != null);

		}

		// Umbra + Doppelgangster + Val'anyr test

		// AuraUpdate(others) test

		[Fact]
		public static void UmbraMorriganLoop()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Dr. Morrigan"),
				},
				Shuffle = false,
				FillDecks = false,
			});
			game.StartGame();

			Assert.Single(game.CurrentPlayer.DeckZone);

			game.ProcessCard("Spiritsinger Umbra", asZeroCost: true);
			game.ProcessCard("Dr. Morrigan", asZeroCost: true);
		}

		[Fact]
		public static void DrawMechanicsTest()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Chillwind Yeti"),
					Cards.FromId("BOT_511t"), // Bomb
					Cards.FromName("River Crocolisk"),
					Cards.FromId("BOT_511t"), // Bomb
					Cards.FromId("BOT_511t"), // Bomb
					Cards.FromId("BOT_511t"), // Bomb
					Cards.FromId("BOT_511t"), // Bomb
				},
				Shuffle = false,
				FillDecks = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			// draw up to 8 wisps in hand
			game.ProcessCard("Arcane Intellect", asZeroCost: true);
			game.ProcessCard("Arcane Intellect", asZeroCost: true);
			Assert.Equal(8, game.Player1.HandZone.Count);
			Assert.All(game.Player1.HandZone, hz => hz.Card.Name.Equals("Wisp"));

			IPlayable wondrousWand = Generic.DrawCard(game.CurrentPlayer, Cards.FromId("LOOT_998l"));
			// expect:
			//   draw Chillwind Yeti for cost 0
			//   draw Bomb and take 5 damage
			//      draw River Crocolisk from bomb (no cost reduction)
			//   overdraw bomb
			game.ProcessCard(wondrousWand);
			Assert.True(game.Player1.HandZone.IsFull);
			Assert.Equal("Chillwind Yeti", game.Player1.HandZone[8].Card.Name);
			Assert.Equal("River Crocolisk", game.Player1.HandZone[9].Card.Name);
			int mana = game.Player1.RemainingMana;
			game.ProcessCard(game.Player1.HandZone[8]); // 0 cost Chillwind Yeta
			Assert.Equal(mana, game.Player1.RemainingMana);
			game.ProcessCard(game.Player1.HandZone[8]); // 2 cost River Crocolisk
			Assert.Equal(mana - 2, game.Player1.RemainingMana);

			Assert.Equal(25, game.Player1.Hero.Health);

			// The bomb after the River Crocolisk was discarded, leaving 3 bombs let in deck
			Assert.Equal(3, game.Player1.DeckZone.Count);
		}

		[Fact(Skip="Outdated")]
		public static void ChangeEntityCostEnchantment()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});

			game.StartGame();
			game.Player1.BaseMana = 10;

			Assert.Equal(4, game.CurrentPlayer.HandZone.Count);
			game.ProcessCard("Swashburglar");
			game.ProcessCard("Swashburglar");
			game.ProcessCard("Swashburglar");
			game.ProcessCard("Swashburglar");
			game.ProcessCard("Swashburglar");

			int[] costs = game.CurrentPlayer.HandZone.Skip(4).Select(p => p.Cost).ToArray();

			game.ProcessCard("Ethereal Peddler", asZeroCost: true);
			for (int i = 0; i < costs.Length; i++)
			{
				if (costs[i] > 2)
					costs[i] -= 2;
				else
					costs[i] = 0;
			}

			// Cost -2 enchantments are applied to all the opponent-class cards in the hand.
			Assert.Equal(costs, game.CurrentPlayer.HandZone.Skip(4).Select(p => p.Cost));

			// Play Golden Kobold to ChangeEntity the whole hand.
			//game.ProcessCard("Golden Kobold", asZeroCost: true);
			IPlayable kobold = Generic.DrawCard(game.CurrentPlayer, Cards.FromId("LOOT_998k"));
			kobold.Cost = 0;
			game.Process(PlayCardTask.Any(game.CurrentPlayer, kobold));
			Assert.True(game.CurrentPlayer.HandZone.ToList()
				.TrueForAll(p => p.Card.Rarity == Rarity.LEGENDARY && p.Card.Type == CardType.MINION));

			// Test if the cost enchantment remains as it is.
			Assert.True(game.CurrentPlayer.HandZone.Skip(4).ToList()
				.TrueForAll(p => p.Cost == (p.Card.Cost - 2 > 0 ? p.Card.Cost - 2 : 0)));
		}

		[Fact]
		public static void ChangeEntityCostAura()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				Logging = true
			});

			game.StartGame();
			game.Player1.BaseMana = 10;

			Minion worgen = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Swift Messenger"));

			// Cost+3 Aura
			Minion auraGenerator = game.ProcessCard<Minion>("Venture Co. Mercenary");
			Assert.Equal(worgen.Card.Cost + 3, worgen.Cost);

			game.EndTurn();
			game.EndTurn();

			Assert.Equal(worgen.Card.ATK, worgen.AttackDamage);
			Assert.Equal(worgen.Card.Health, worgen.Health);

			Assert.Equal(worgen.Card.Cost + 3, worgen.Cost);
			auraGenerator.Kill();
			Assert.Equal(worgen.Card.Cost, worgen.Cost);
		}
	}
}
