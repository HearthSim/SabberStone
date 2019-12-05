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
using System.Linq;
using Xunit;
using Xunit.Abstractions;
using SabberStoneCore.Enums;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;
using SabberStoneCore.Actions;
using SabberStoneCore.Auras;
using SabberStoneCore.Tasks.PlayerTasks;

namespace SabberStoneCoreTest.CardSets.Standard
{
	public class HeroesBoomsdayTest
	{
		// ----------------------------------------- HERO - WARRIOR
		// [BOT_238] Dr. Boom, Mad Genius - COST:9 [ATK:0/HP:30] 
		// - Set: boomsday, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> For the rest of the game, your Mechs have <b>Rush</b>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 7
		// - HERO_POWER = 48145
		// --------------------------------------------------------
		// RefTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact]
		public void DrBoomMadGenius_BOT_238()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dr. Boom, Mad Genius"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dr. Boom, Mad Genius"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dr. Boom, Mad Genius"));

			string[] powers = Cards.FromId("BOT_238p").Entourage;

			Controller c = game.CurrentPlayer;

			Minion rushTestMinion = game.ProcessCard<Minion>("Upgradeable Framebot", asZeroCost: true);
			Assert.True(rushTestMinion.IsRush);

			string currentId = c.Hero.HeroPower.Card.Id;
			Assert.Contains(currentId, powers);

			for (int i = 0; i < 10; i++)
			{
				game.EndTurn();
				game.EndTurn();

				string next = c.Hero.HeroPower.Card.Id;
				Assert.NotEqual(next, currentId);
				Assert.Contains(next, powers);
				currentId = next;
			}
		}

		// ---------------------------------------- HERO - WHIZBANG
		// [BOT_914h] Whizbang the Wonderful (*) - COST:0 [ATK:0/HP:30] 
		// - Set: boomsday, Rarity: free
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WhizbangTheWonderful_BOT_914h()
		{
			// TODO WhizbangTheWonderful_BOT_914h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WHIZBANG,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Whizbang the Wonderful"),
				},
				Player2HeroClass = CardClass.WHIZBANG,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Whizbang the Wonderful"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Whizbang the Wonderful"));
		}

	}

	public class HeroPowersBoomsdayTest
	{
		// ----------------------------------- HERO_POWER - WARRIOR
		// [BOT_238p] Big Red Button (*) - COST:2 
		// - Fac: neutral, Set: boomsday, 
		// --------------------------------------------------------
		// Text: [x]<b>Hero Power</b>
		//       Activate this turn's
		//       Mech Suit power!
		// --------------------------------------------------------
		// Entourage: BOT_238p1, BOT_238p2, BOT_238p3, BOT_238p4, BOT_238p6
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BigRedButton_BOT_238p()
		{
			// TODO BigRedButton_BOT_238p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Big Red Button"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Big Red Button"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Big Red Button"));
		}

		// ----------------------------------- HERO_POWER - WARRIOR
		// [BOT_238p1] Zap Cannon (*) - COST:2 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $3 damage.
		//       Swaps each turn. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ZapCannon_BOT_238p1()
		{
			// TODO ZapCannon_BOT_238p1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Zap Cannon"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Zap Cannon"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Zap Cannon"));
		}

		// ----------------------------------- HERO_POWER - WARRIOR
		// [BOT_238p2] Blast Shield (*) - COST:2 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Gain 7 Armor.
		//       Swaps each turn.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BlastShield_BOT_238p2()
		{
			// TODO BlastShield_BOT_238p2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blast Shield"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blast Shield"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blast Shield"));
		}

		// ----------------------------------- HERO_POWER - WARRIOR
		// [BOT_238p3] KABOOM! (*) - COST:2 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $1 damage to all enemies. Swaps each turn. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Kaboom_BOT_238p3()
		{
			// TODO Kaboom_BOT_238p3 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("KABOOM!"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("KABOOM!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "KABOOM!"));
		}

		// ----------------------------------- HERO_POWER - WARRIOR
		// [BOT_238p4] Delivery Drone (*) - COST:2 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       <b>Discover</b> a Mech.
		//       Swaps_each_turn.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_HAND_NOT_FULL = 0
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// - GEARS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DeliveryDrone_BOT_238p4()
		{
			// TODO DeliveryDrone_BOT_238p4 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Delivery Drone"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Delivery Drone"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Delivery Drone"));
		}

		// ----------------------------------- HERO_POWER - WARRIOR
		// [BOT_238p6] Micro-Squad (*) - COST:2 
		// - Set: boomsday, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon three 1/1 Microbots.
		//       Swaps_each_turn.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MicroSquad_BOT_238p6()
		{
			// TODO MicroSquad_BOT_238p6 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Micro-Squad"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Micro-Squad"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Micro-Squad"));
		}

	}

	public class DruidBoomsdayTest
	{
		// ----------------------------------------- MINION - DRUID
		// [BOT_419] Dendrologist - COST:2 [ATK:2/HP:3] 
		// - Fac: neutral, Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you control a Treant, <b>Discover</b> a spell.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact]
		public void Dendrologist_BOT_419()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dendrologist"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dendrologist"));

			Assert.Null(game.CurrentPlayer.Choice);

			game.ProcessCard("Tending Tauren", chooseOne: 2);
			game.ProcessCard("Dendrologist");

			Assert.NotNull(game.CurrentPlayer.Choice);
			game.ChooseNthChoice(1);
			Assert.Equal(CardType.SPELL, game.CurrentPlayer.HandZone.Last().Card.Type);
		}

		// ----------------------------------------- MINION - DRUID
		// [BOT_422] Tending Tauren - COST:6 [ATK:3/HP:4] 
		// - Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Choose One -</b> Give your
		//       other minions +1/+1;
		//       or Summon two
		//       2/2 Treants.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		[Fact]
		public void TendingTauren_BOT_422()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tending Tauren"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tending Tauren"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tending Tauren", chooseOne: 2));

			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal("Treant", game.CurrentPlayer.BoardZone[0].Card.Name);

			game.ProcessCard("Tending Tauren", null, true, 1);

			Assert.Equal(game.CurrentPlayer.BoardZone[0].Card.ATK + 1, game.CurrentPlayer.BoardZone[0].AttackDamage);
			Assert.Equal(game.CurrentPlayer.BoardZone[0].Card.Health + 1, game.CurrentPlayer.BoardZone[0].Health);
			Assert.Equal(game.CurrentPlayer.BoardZone[3].Card.ATK, game.CurrentPlayer.BoardZone[3].AttackDamage);
			Assert.Equal(game.CurrentPlayer.BoardZone[3].Card.Health, game.CurrentPlayer.BoardZone[3].Health);

		}

		// ----------------------------------------- MINION - DRUID
		// [BOT_423] Dreampetal Florist - COST:7 [ATK:4/HP:4] 
		// - Set: boomsday, Rarity: epic
		// --------------------------------------------------------
		// Text: At the end of your turn, reduce the Cost of a random minion in your hand by (7).
		// --------------------------------------------------------
		[Fact]
		public void DreampetalFlorist_BOT_423()
		{
			start:
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.ProcessCard("Dreampetal Florist", null, true);
			game.EndTurn();

			foreach (IPlayable item in game.CurrentOpponent.HandZone)
			{
				if (item.Card.Type != CardType.MINION || (item.Card.Cost != 0 && item.Cost >= item.Card.Cost) ||
				    item.OngoingEffect is AdaptiveCostEffect) continue;

				int expected = item.Card.Cost - 7;
				if (expected < 0)
					expected = 0;

				Assert.Equal(expected, item.Cost);
				return;
			}
			goto start;
		}

		// ----------------------------------------- MINION - DRUID
		// [BOT_434] Flobbidinous Floop - COST:4 [ATK:3/HP:4] 
		// - Set: boomsday, Rarity: legendary
		// --------------------------------------------------------
		// Text: While in your hand, this is a 3/4 copy of the last minion you played.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact]
		public void FlobbidinousFloop_BOT_434()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Flobbidinous Floop"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			Minion testCard = game.CurrentPlayer.HandZone[0] as Minion;
			Assert.NotNull(testCard);
			Assert.Equal("Flobbidinous Floop", testCard.Card.Name);

			game.ProcessCard("Malygos", asZeroCost: true);
			Assert.Equal("Malygos", testCard.Card.Name);
			Assert.Equal(4, testCard.Health);
			Assert.Equal(3, testCard.AttackDamage);

			game.ProcessCard("Moonfire", game.CurrentOpponent.Hero);
			Assert.Equal("Malygos", testCard.Card.Name);
			Assert.Equal(4, testCard.Health);
			Assert.Equal(3, testCard.AttackDamage);

			game.ProcessCard("Alexstrasza", game.CurrentOpponent.Hero, asZeroCost: true);
			Assert.Equal("Alexstrasza", testCard.Card.Name);
			Assert.Equal(4, testCard.Health);
			Assert.Equal(3, testCard.AttackDamage);
		}

		// ----------------------------------------- MINION - DRUID
		// [BOT_507] Gloop Sprayer - COST:8 [ATK:4/HP:4] 
		// - Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a copy of each adjacent minion.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void GloopSprayer_BOT_507()
		{
			// TODO GloopSprayer_BOT_507 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gloop Sprayer"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gloop Sprayer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gloop Sprayer"));

			game.ProcessCard("Stonetusk Boar");
			game.ProcessCard("Wisp");

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gloop Sprayer", null, 1));

			Assert.True(
				game.CurrentPlayer.BoardZone.Select(p => p.Card.Name).SequenceEqual(new[]
				{
					"Stonetusk Boar",
					"Stonetusk Boar",
					"Gloop Sprayer",
					"Wisp",
					"Wisp"
				}));
		}

		// ----------------------------------------- MINION - DRUID
		// [BOT_523] Mulchmuncher - COST:10 [ATK:8/HP:8] 
		// - Race: mechanical, Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Rush</b>. Costs (1) less for each friendly Treant that died this game.
		// --------------------------------------------------------
		// GameTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Mulchmuncher_BOT_523()
		{
			// TODO Mulchmuncher_BOT_523 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mulchmuncher"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mulchmuncher"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mulchmuncher"));

			IPlayable testCard = game.CurrentPlayer.HandZone[0];


		}

		// ------------------------------------------ SPELL - DRUID
		// [BOT_054] Biology Project - COST:1 
		// - Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: Each player gains 2_Mana Crystals.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BiologyProject_BOT_054()
		{
			// TODO BiologyProject_BOT_054 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Biology Project"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Biology Project"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Biology Project"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [BOT_404] Juicy Psychmelon - COST:4 
		// - Set: boomsday, Rarity: epic
		// --------------------------------------------------------
		// Text: Draw a 7, 8, 9, and
		//       10-Cost minion
		//        from your deck.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JuicyPsychmelon_BOT_404()
		{
			// TODO JuicyPsychmelon_BOT_404 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Juicy Psychmelon"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Juicy Psychmelon"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Juicy Psychmelon"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [BOT_420] Landscaping - COST:3 
		// - Fac: neutral, Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: Summon two 2/2 Treants.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Landscaping_BOT_420()
		{
			// TODO Landscaping_BOT_420 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Landscaping"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Landscaping"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Landscaping"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [BOT_444] Floop's Glorious Gloop - COST:1 
		// - Set: boomsday, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever a minion dies this turn, gain 1 Mana Crystal this turn only.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact]
		public void FloopsGloriousGloop_BOT_444()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Floop's Glorious Gloop"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();


			game.ProcessCard("Wisp");
			game.ProcessCard("Wisp");
			game.ProcessCard("Wisp");
			game.ProcessCard("Wisp");

			game.EndTurn();

			game.ProcessCard("Wisp");
			game.ProcessCard("Wisp");
			game.ProcessCard("Wisp");
			game.ProcessCard("Wisp");

			game.EndTurn();

			int start = game.CurrentPlayer.RemainingMana;

			game.ProcessCard("Floop's Glorious Gloop", null, true); // cast as zero cost

			game.Process(MinionAttackTask.Any(game.Player1, game.Player1.BoardZone[0], game.Player2.BoardZone[0]));
			game.Process(MinionAttackTask.Any(game.Player1, game.Player1.BoardZone[0], game.Player2.BoardZone[0]));
			game.Process(MinionAttackTask.Any(game.Player1, game.Player1.BoardZone[0], game.Player2.BoardZone[0]));
			game.Process(MinionAttackTask.Any(game.Player1, game.Player1.BoardZone[0], game.Player2.BoardZone[0]));

			Assert.Equal(start + 8, game.CurrentPlayer.RemainingMana);
			game.EndTurn();
			game.ProcessCard("Wisp");
			game.EndTurn();
			Assert.Equal(start + 1, game.CurrentPlayer.RemainingMana);
			game.ProcessCard("Wisp");
			game.Process(MinionAttackTask.Any(game.Player1, game.Player1.BoardZone[0], game.Player2.BoardZone[0]));
			Assert.Equal(start + 1, game.CurrentPlayer.RemainingMana);
		}

	}

	public class HunterBoomsdayTest
	{
		// ---------------------------------------- MINION - HUNTER
		// [BOT_034] Boommaster Flark - COST:7 [ATK:5/HP:5] 
		// - Set: boomsday, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon four 0/2 Goblin Bombs.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void BoommasterFlark_BOT_034()
		{
			// TODO BoommasterFlark_BOT_034 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Boommaster Flark"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Boommaster Flark"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Boommaster Flark"));

			Assert.Equal(5, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal("Boommaster Flark", game.CurrentPlayer.BoardZone[2].Card.Name);
		}

		// ---------------------------------------- MINION - HUNTER
		// [BOT_035] Venomizer - COST:2 [ATK:2/HP:2] 
		// - Race: mechanical, Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Magnetic</b>
		//       <b>Poisonous</b>
		// --------------------------------------------------------
		// GameTag:
		// - POISONOUS = 1
		// - MODULAR = 1
		// --------------------------------------------------------
		[Fact]
		public void Venomizer_BOT_035()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Venomizer"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			Minion target = game.ProcessCard<Minion>("Upgradeable Framebot");

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Venomizer", null, 0));

			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(3, target.AttackDamage);
			Assert.Equal(7, target.Health);
			Assert.True(target.Poisonous);

			// summon right-side of the target
			game.ProcessCard("Venomizer");

			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(3, target.AttackDamage);
			Assert.Equal(7, target.Health);
		}

		// ---------------------------------------- MINION - HUNTER
		// [BOT_038] Fireworks Tech - COST:2 [ATK:2/HP:1] 
		// - Fac: neutral, Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Give a friendly
		//       Mech +1/+1. If it has
		//       <b>Deathrattle</b>, trigger it.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_WITH_RACE = 17
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void FireworksTech_BOT_038()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fireworks Tech"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			Minion target = game.ProcessCard<Minion>("Goblin Bomb");
			game.ProcessCard("Fireworks Tech", target);
			Assert.Equal(2, game.CurrentOpponent.Hero.Damage);
			Assert.Equal(target.Card.ATK + 1, target.AttackDamage);
			Assert.Equal(target.Card.Health + 1, target.Health);
		}

		// ---------------------------------------- MINION - HUNTER
		// [BOT_039] Necromechanic - COST:5 [ATK:3/HP:6] 
		// - Set: boomsday, Rarity: epic
		// --------------------------------------------------------
		// Text: Your <b>Deathrattles</b> trigger twice.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Necromechanic_BOT_039()
		{
			// TODO Necromechanic_BOT_039 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Necromechanic"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Necromechanic"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Necromechanic"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [BOT_251] Spider Bomb - COST:3 [ATK:2/HP:2] 
		// - Race: mechanical, Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Magnetic</b>
		//       <b>Deathrattle:</b> Destroy a random_enemy_minion.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// - MODULAR = 1
		// --------------------------------------------------------
		[Fact]
		public void SpiderBomb_BOT_251()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spider Bomb"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spider Bomb"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Spider Bomb"));

			game.ProcessCard("Spider Bomb", zonePosition: 0);

			game.EndTurn();

			game.ProcessCard("Stonetusk Boar");
			game.ProcessCard("Stonetusk Boar");
			game.EndTurn();

			game.CurrentPlayer.BoardZone[0].Kill();

			Assert.Empty(game.CurrentOpponent.BoardZone);
		}

		// ----------------------------------------- SPELL - HUNTER
		// [BOT_033] Bomb Toss - COST:2 
		// - Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $2 damage. Summon a 0/2 Goblin_Bomb. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - AFFECTED_BY_SPELL_POWER = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void BombToss_BOT_033()
		{
			// TODO BombToss_BOT_033 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bomb Toss"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bomb Toss"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bomb Toss"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [BOT_402] Secret Plan - COST:1 
		// - Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Discover</b> a <b>Secret</b>.
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SecretPlan_BOT_402()
		{
			// TODO SecretPlan_BOT_402 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Secret Plan"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Secret Plan"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Secret Plan"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [BOT_429] Flark's Boom-Zooka - COST:8 
		// - Set: boomsday, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]Summon 3 minions from
		//       your deck. They attack
		//       enemy minions, then die.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact]
		public void FlarksBoomZooka_BOT_429()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 2,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Flark's Boom-Zooka"),
					Cards.FromName("Flark's Boom-Zooka"),
					Cards.FromName("Flark's Boom-Zooka"),
					Cards.FromName("Flark's Boom-Zooka"),
					Cards.FromName("Flark's Boom-Zooka"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.ProcessCard("Dalaran Mage");
			game.EndTurn();

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Flark's Boom-Zooka"));

			Assert.Empty(game.CurrentPlayer.BoardZone);
			Assert.Empty(game.CurrentPlayer.DeckZone);
			Assert.Equal(1, game.CurrentOpponent.BoardZone[0].Health);
		}

		// ----------------------------------------- SPELL - HUNTER
		// [BOT_437] Goblin Prank - COST:2 
		// - Set: boomsday, Rarity: epic
		// --------------------------------------------------------
		// Text: Give a friendly minion +3/+3 and <b>Rush</b>. It_dies at end of turn.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact]
		public void GoblinPrank_BOT_437()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Goblin Prank"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Goblin Prank"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Goblin Prank"));

			Minion target = game.ProcessCard<Minion>("Stonetusk Boar");
			game.ProcessCard("Goblin Prank", target);

			Assert.Equal(3 + target.Card.ATK, target.AttackDamage);
			Assert.Equal(3 + target.Card.Health, target.Health);
			game.EndTurn();
			Assert.True(target.ToBeDestroyed);
		}

		// ----------------------------------------- SPELL - HUNTER
		// [BOT_438] Cybertech Chip - COST:2 
		// - Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: Give your minions "<b>Deathrattle:</b> Add a random Mech to your_hand."
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void CybertechChip_BOT_438()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cybertech Chip"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cybertech Chip"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cybertech Chip"));

			game.ProcessCard("Wisp");
			game.ProcessCard("Wisp");
			game.ProcessCard("Wisp");
			game.ProcessCard("Wisp");

			game.ProcessCard("Cybertech Chip");
			Assert.True(game.CurrentPlayer.BoardZone.ToList().TrueForAll(m => m.HasDeathrattle));

			game.ProcessCard("Whirlwind");
			Assert.Equal(8, game.CurrentPlayer.HandZone.Count);
			Assert.True(game.CurrentPlayer.HandZone.Skip(4).Take(4).ToList()
				.TrueForAll(p => p is Minion m && m.IsRace(Race.MECHANICAL)));
		}

	}

	public class MageBoomsdayTest
	{
		// ------------------------------------------ MINION - MAGE
		// [BOT_103] Stargazer Luna - COST:3 [ATK:2/HP:4] 
		// - Set: boomsday, Rarity: legendary
		// --------------------------------------------------------
		// Text: After you play the
		//       right-most card in your hand, draw a card.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact]
		public void StargazerLuna_BOT_103()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stargazer Luna"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),

					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),

				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stargazer Luna"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stargazer Luna"));

			Assert.Equal(3, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, game.CurrentPlayer.HandZone.Last()));
			Assert.Equal(3, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, game.CurrentPlayer.HandZone.Last()));
			Assert.Equal(3, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, game.CurrentPlayer.HandZone.Last()));
			Assert.Equal(3, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, game.CurrentPlayer.HandZone.Last()));
			Assert.Equal(3, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, game.CurrentPlayer.HandZone.Last()));
			Assert.Equal(3, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, game.CurrentPlayer.HandZone.First()));
			Assert.Equal(2, game.CurrentPlayer.HandZone.Count);
		}

		// ------------------------------------------ MINION - MAGE
		// [BOT_256] Astromancer - COST:7 [ATK:5/HP:5] 
		// - Set: boomsday, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Summon a
		//       random minion with Cost
		//       equal to your hand size.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void Astromancer_BOT_256()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Astromancer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Astromancer"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Astromancer"));

			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(game.CurrentPlayer.HandZone.Count, game.CurrentPlayer.BoardZone.Last().Cost);
		}

		// ------------------------------------------ MINION - MAGE
		// [BOT_531] Celestial Emissary - COST:2 [ATK:2/HP:1] 
		// - Race: elemental, Fac: neutral, Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Your next spell_this turn has <b>Spell_Damage +2</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - SPELLPOWER = 1
		// --------------------------------------------------------
		[Fact]
		public void CelestialEmissary_BOT_531()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Celestial Emissary"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Celestial Emissary"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Celestial Emissary"));

			Assert.Equal(2, game.CurrentPlayer.CurrentSpellPower);
			game.ProcessCard("Fireball", game.CurrentOpponent.Hero);
			Assert.Equal(8, game.CurrentOpponent.Hero.Damage);
			Assert.Equal(0, game.CurrentPlayer.CurrentSpellPower);
		}

		// ------------------------------------------ MINION - MAGE
		// [BOT_601] Meteorologist - COST:6 [ATK:3/HP:3] 
		// - Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> For each card in your hand, deal 1 damage to a random enemy.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Meteorologist_BOT_601()
		{
			// TODO Meteorologist_BOT_601 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Meteorologist"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Meteorologist"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Meteorologist"));
		}

		// ------------------------------------------ MINION - MAGE
		// [BOT_604] Cosmic Anomaly - COST:4 [ATK:4/HP:3] 
		// - Race: elemental, Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Spell Damage +2</b>
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CosmicAnomaly_BOT_604()
		{
			// TODO CosmicAnomaly_BOT_604 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cosmic Anomaly"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cosmic Anomaly"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cosmic Anomaly"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [BOT_101] Astral Rift - COST:2 
		// - Fac: neutral, Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: Add 2 random minions to your hand.
		// --------------------------------------------------------
		[Fact]
		public void AstralRift_BOT_101()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Astral Rift"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Astral Rift"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Astral Rift"));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(CardType.MINION, game.CurrentPlayer.HandZone[4].Card.Type);
			Assert.Equal(CardType.MINION, game.CurrentPlayer.HandZone[3].Card.Type);
		}

		// ------------------------------------------- SPELL - MAGE
		// [BOT_254] Unexpected Results - COST:4 
		// - Set: boomsday, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]Summon two random
		//       $2-Cost minions <i>(improved
		//       by <b>Spell Damage</b>)</i>. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact]
		public void UnexpectedResults_BOT_254()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unexpected Results"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Unexpected Results"));

			BoardZone board = game.CurrentPlayer.BoardZone;

			Assert.Equal(2, board.Count);
			Assert.True(board.ToList().TrueForAll(p => p is Minion m && m.Cost == 2));
		}

		[Fact]
		public void UnexpectedResults_BOT_254_withSpellPower()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unexpected Results"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.ProcessCard("Bloodmage Thalnos", asZeroCost: true);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Unexpected Results"));

			BoardZone board = game.CurrentPlayer.BoardZone;

			Assert.Equal(3, board.Count);
			Assert.Equal(3, board[1].Card.Cost);
			Assert.Equal(3, board[2].Card.Cost);
		}

		// ------------------------------------------- SPELL - MAGE
		// [BOT_257] Luna's Pocket Galaxy - COST:7 
		// - Set: boomsday, Rarity: legendary
		// --------------------------------------------------------
		// Text: Change the Cost of minions in your
		//       deck to (1).
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact]
		public void LunasPocketGalaxy_BOT_257()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Luna's Pocket Galaxy"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Luna's Pocket Galaxy"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Luna's Pocket Galaxy"));

			Assert.True(game.CurrentPlayer.DeckZone.Where(p => p.Card.Type == CardType.MINION).ToList()
				.TrueForAll(p => p.Cost == 1));
		}

		// ------------------------------------------- SPELL - MAGE
		// [BOT_453] Shooting Star - COST:1 
		// - Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $1 damage to a minion and the minions next to it. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShootingStar_BOT_453()
		{
			// TODO ShootingStar_BOT_453 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shooting Star"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shooting Star"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shooting Star"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [BOT_600] Research Project - COST:2 
		// - Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: Each player draws 2_cards.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ResearchProject_BOT_600()
		{
			// TODO ResearchProject_BOT_600 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Research Project"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Research Project"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Research Project"));
		}

	}

	public class PaladinBoomsdayTest
	{
		// --------------------------------------- MINION - PALADIN
		// [BOT_236] Crystalsmith Kangor - COST:2 [ATK:1/HP:2] 
		// - Set: boomsday, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Divine Shield</b>, <b>Lifesteal</b>
		//       Your healing is doubled.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DIVINE_SHIELD = 1
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact]
		public void CrystalsmithKangor_BOT_236()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Crystalsmith Kangor"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Crystalsmith Kangor"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Crystalsmith Kangor"));

			game.CurrentPlayer.Hero.Damage = 20;

			game.ProcessCard("Holy Light", game.CurrentPlayer.Hero);
			Assert.Equal(8, game.CurrentPlayer.Hero.Damage);

			game.CurrentPlayer.BoardZone[0].Kill();

			game.ProcessCard("Holy Light", game.CurrentPlayer.Hero);
			Assert.Equal(2, game.CurrentPlayer.Hero.Damage);
		}

		// --------------------------------------- MINION - PALADIN
		// [BOT_537] Mechano-Egg - COST:5 [ATK:0/HP:5] 
		// - Race: mechanical, Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon an 8/8 Robosaur.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MechanoEgg_BOT_537()
		{
			// TODO MechanoEgg_BOT_537 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mechano-Egg"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mechano-Egg"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mechano-Egg"));
		}

		// --------------------------------------- MINION - PALADIN
		// [BOT_906] Glow-Tron - COST:1 [ATK:1/HP:3] 
		// - Race: mechanical, Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Magnetic</b>
		// --------------------------------------------------------
		// GameTag:
		// - MODULAR = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GlowTron_BOT_906()
		{
			// TODO GlowTron_BOT_906 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Glow-Tron"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Glow-Tron"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Glow-Tron"));
		}

		// --------------------------------------- MINION - PALADIN
		// [BOT_910] Glowstone Technician - COST:6 [ATK:3/HP:4] 
		// - Set: boomsday, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give all minions in your hand +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GlowstoneTechnician_BOT_910()
		{
			// TODO GlowstoneTechnician_BOT_910 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Glowstone Technician"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Glowstone Technician"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Glowstone Technician"));
		}

		// --------------------------------------- MINION - PALADIN
		// [BOT_911] Annoy-o-Module - COST:4 [ATK:2/HP:4] 
		// - Race: mechanical, Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Magnetic</b>
		//       <b>Divine Shield</b>
		//       <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - DIVINE_SHIELD = 1
		// - MODULAR = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AnnoyOModule_BOT_911()
		{
			// TODO AnnoyOModule_BOT_911 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Annoy-o-Module"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Annoy-o-Module"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Annoy-o-Module"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [BOT_234] Shrink Ray - COST:5 
		// - Fac: neutral, Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: Set the Attack and Health of all minions
		//       to 1.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShrinkRay_BOT_234()
		{
			// TODO ShrinkRay_BOT_234 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shrink Ray"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shrink Ray"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shrink Ray"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [BOT_436] Prismatic Lens - COST:4 
		// - Set: boomsday, Rarity: epic
		// --------------------------------------------------------
		// Text: Draw a minion and a spell from your deck. Swap their Costs.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PrismaticLens_BOT_436()
		{
			// TODO PrismaticLens_BOT_436 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Prismatic Lens"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Prismatic Lens"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Prismatic Lens"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [BOT_908] Autodefense Matrix - COST:1 
		// - Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When one of your minions is attacked, give it <b>Divine Shield</b>.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		// RefTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact]
		public void AutodefenseMatrix_BOT_908()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Autodefense Matrix"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Autodefense Matrix"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Autodefense Matrix"));

			Minion target = game.ProcessCard<Minion>("Stonetusk Boar");
			game.EndTurn();

			game.PlayHeroPower();
			game.Process(HeroAttackTask.Any(game.CurrentPlayer, target));

			Assert.Equal(1, game.CurrentPlayer.Hero.Weapon.Durability);
			Assert.Equal(1, game.CurrentPlayer.Hero.Damage);
			Assert.False(target.ToBeDestroyed);
			Assert.False(target.HasDivineShield);
			Assert.Empty(game.CurrentOpponent.SecretZone);
		}

		// ---------------------------------------- SPELL - PALADIN
		// [BOT_909] Crystology - COST:2 
		// - Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]Draw two 1-Attack
		//       minions from your deck.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Crystology_BOT_909()
		{
			// TODO Crystology_BOT_909 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Crystology"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Crystology"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Crystology"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [BOT_912] Kangor's Endless Army - COST:7 
		// - Set: boomsday, Rarity: legendary
		// --------------------------------------------------------
		// Text: Resurrect 3 friendly Mechs. They keep any <b>Magnetic</b> upgrades.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// - REQ_FRIENDLY_MINIONS_OF_RACE_DIED_THIS_GAME = 17
		// --------------------------------------------------------
		// RefTag:
		// - MODULAR = 1
		// --------------------------------------------------------
		[Fact]
		public void KangorsEndlessArmy_BOT_912()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kangor's Endless Army"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kangor's Endless Army"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kangor's Endless Army"));

			Minion mech1 = game.ProcessCard<Minion>("Glow-Tron", asZeroCost: true);
			game.ProcessCard<Minion>("Glow-Tron", asZeroCost: true, zonePosition: 0);
			game.ProcessCard<Minion>("Glow-Tron", asZeroCost: true, zonePosition: 0);
			game.ProcessCard<Minion>("Glow-Tron", asZeroCost: true, zonePosition: 0);

			Assert.Single(game.CurrentPlayer.BoardZone);
			Assert.Equal(4 * mech1.Card.ATK, mech1.AttackDamage);
			Assert.Equal(4 * mech1.Card.Health, mech1.Health);
			Assert.Equal(3, mech1.AppliedEnchantments.Count);

			Minion mech2 = game.ProcessCard<Minion>("Wargear", asZeroCost: true);
			game.ProcessCard("Zilliax", asZeroCost: true, zonePosition: 1);

			Minion mech3 = game.ProcessCard<Minion>("Upgradeable Framebot");
			game.ProcessCard("Replicating Menace", asZeroCost: true, zonePosition: 2);

			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);

			mech1.Kill();
			mech2.Kill();
			mech3.Kill();

			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);

			game.ProcessCard("Kangor's Endless Army");
			Assert.Equal(6, game.CurrentPlayer.BoardZone.Count);
			for (int i = 3; i < 6; i++)
			{
				Minion mech = game.CurrentPlayer.BoardZone[i];

				switch (mech.Card.Name)
				{
					case "Glow-Tron":
						Assert.Equal(4 * mech.Card.ATK, mech.AttackDamage);
						Assert.Equal(4 * mech.Card.Health, mech.Health);
						break;
					case "Wargear":
						Assert.Equal(mech.Card.ATK + Cards.FromName("Zilliax").ATK, mech.AttackDamage);
						Assert.Equal(mech.Card.Health + Cards.FromName("Zilliax").Health, mech.Health);
						Assert.True(mech.HasDivineShield);
						Assert.True(mech.HasTaunt);
						Assert.True(mech.HasLifeSteal);
						Assert.True(mech.AttackableByRush);
						break;
					case "Upgradeable Framebot":
						Assert.Equal(mech.Card.ATK + Cards.FromName("Replicating Menace").ATK, mech.AttackDamage);
						Assert.Equal(mech.Card.Health + Cards.FromName("Replicating Menace").Health, mech.Health);
						Assert.True(mech.HasDeathrattle);
						break;
					default:
						throw new System.Exception();
				}
			}
		}

	}

	public class PriestBoomsdayTest
	{
		// ---------------------------------------- MINION - PRIEST
		// [BOT_216] Omega Medic - COST:3 [ATK:3/HP:4] 
		// - Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you have 10 Mana Crystals, restore #10 Health to your hero.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OmegaMedic_BOT_216()
		{
			// TODO OmegaMedic_BOT_216 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Omega Medic"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Omega Medic"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Omega Medic"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [BOT_258] Zerek, Master Cloner - COST:6 [ATK:5/HP:5] 
		// - Set: boomsday, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> If you've cast any spells on this minion, resummon it.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// - 537 = 1
		// - 542 = 1
		// --------------------------------------------------------
		[Fact]
		public void ZerekMasterCloner_BOT_258()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Zerek, Master Cloner"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Zerek, Master Cloner"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Zerek, Master Cloner"));

			BoardZone board = game.CurrentPlayer.BoardZone;
			Minion test = game.CurrentPlayer.BoardZone.First();
			test.Kill();
			Assert.Empty(board);

			Minion test2 = game.ProcessCard<Minion>("Zerek, Master Cloner", null, true);
			game.ProcessCard("Power Word: Shield", test2, true);
			test2.Kill();
			Assert.Single(board);
			Assert.Equal("Zerek, Master Cloner", board[0].Card.Name);
		}

		// ---------------------------------------- MINION - PRIEST
		// [BOT_509] Dead Ringer - COST:2 [ATK:2/HP:1] 
		// - Race: mechanical, Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Draw a <b>Deathrattle</b> minion from your deck.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DeadRinger_BOT_509()
		{
			// TODO DeadRinger_BOT_509 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dead Ringer"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dead Ringer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dead Ringer"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [BOT_558] Test Subject - COST:1 [ATK:0/HP:2] 
		// - Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Deathrattle:</b> Return any
		//       spells you cast on this
		//       minion to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// - 537 = 1
		// - 542 = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TestSubject_BOT_558()
		{
			// TODO TestSubject_BOT_558 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Test Subject"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Test Subject"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Test Subject"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [BOT_566] Reckless Experimenter - COST:5 [ATK:4/HP:6] 
		// - Set: boomsday, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Deathrattle</b> minions you
		//       play cost (3) less, but die
		//       at the end of the turn.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void RecklessExperimenter_BOT_566()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Reckless Experimenter"),
					Cards.FromName("Tortollan Shellraiser"),
					Cards.FromName("Zerek, Master Cloner"),
					Cards.FromName("Stonetusk Boar")
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Reckless Experimenter"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Reckless Experimenter"));

			foreach (IPlayable handCard in game.CurrentPlayer.HandZone)
			{
				if (handCard.HasDeathrattle && handCard.Card.Type == CardType.MINION)
				{
					int expected = handCard.Card.Cost - 3;
					expected = expected < 0 ? 0 : expected;
					Assert.Equal(expected, handCard.Cost);
				}
				else
					Assert.Equal(handCard.Card.Cost, handCard.Cost);
			}

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Zerek, Master Cloner"));

			game.EndTurn();

			Assert.Single(game.CurrentOpponent.BoardZone);
		}
	

		// ----------------------------------------- SPELL - PRIEST
		// [BOT_219] Extra Arms - COST:3 
		// - Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]Give a minion +2/+2.
		//       Add 'More Arms!' to your
		//       hand that gives +2/+2.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ExtraArms_BOT_219()
		{
			// TODO ExtraArms_BOT_219 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Extra Arms"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Extra Arms"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Extra Arms"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [BOT_435] Cloning Device - COST:2 
		// - Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Discover</b> a copy of a minion in your opponent's deck.
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact]
		public void CloningDevice_BOT_435()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cloning Device"),
				},
				Player2Deck = new List<Card>()
				{
					Cards.FromName("Dalaran Mage"),
					Cards.FromName("Dalaran Mage"),
					Cards.FromName("Dalaran Mage"),
					Cards.FromName("Dalaran Mage"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Bloodfen Raptor"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Bloodfen Raptor"),
					Cards.FromName("Wisp")
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cloning Device"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cloning Device"));

			Choice choice = game.CurrentPlayer.Choice;
			Assert.NotNull(choice);
			string[] names = choice.Choices
				.Select(i => game.IdEntityDic[i].Card.Name)
				.OrderBy(n => n)
				.ToArray();
			string[] expected =
			{
				"Bloodfen Raptor",
				"Stonetusk Boar",
				"Wisp"
			};
			Assert.True(expected.SequenceEqual(names), $"Actual: {string.Join(',', names)}");
		}

		// ----------------------------------------- SPELL - PRIEST
		// [BOT_517] Topsy Turvy - COST:0 
		// - Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: Swap a minion's Attack and Health.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TopsyTurvy_BOT_517()
		{
			// TODO TopsyTurvy_BOT_517 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Topsy Turvy"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Topsy Turvy"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Topsy Turvy"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [BOT_529] Power Word: Replicate - COST:5 
		// - Set: boomsday, Rarity: epic
		// --------------------------------------------------------
		// Text: Choose a friendly minion. Summon a 5/5 copy of it.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PowerWordReplicate_BOT_529()
		{
			// TODO PowerWordReplicate_BOT_529 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Power Word: Replicate"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Power Word: Replicate"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Power Word: Replicate"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [BOT_567] Zerek's Cloning Gallery - COST:9 
		// - Set: boomsday, Rarity: legendary
		// --------------------------------------------------------
		// Text: Summon a 1/1 copy of_each minion in your_deck.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact]
		public void ZereksCloningGallery_BOT_567()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Zerek's Cloning Gallery"),
					Cards.FromName("Zerek's Cloning Gallery"),
					Cards.FromName("Zerek's Cloning Gallery"),
					Cards.FromName("Zerek's Cloning Gallery"),
					Cards.FromName("Dalaran Mage"),
					Cards.FromName("Dalaran Mage"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Bloodfen Raptor"),
					Cards.FromName("Wisp")

				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Zerek's Cloning Gallery"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Zerek's Cloning Gallery"));

			string[] expected =
			{
				"Bloodfen Raptor",
				"Dalaran Mage",
				"Dalaran Mage",
				"Stonetusk Boar",
				"Wisp"
			};

			Minion[] board = game.CurrentPlayer.BoardZone.GetAll();

			string[] actual = board
				.Select(p => p.Card.Name)
				.OrderBy(p => p)
				.ToArray();

			Assert.True(expected.SequenceEqual(actual));

			Assert.True(board.ToList()
				.TrueForAll(m => m.AttackDamage == 1 && m.BaseHealth == 1));
		}

	}

	public class RogueBoomsdayTest
	{
		// ----------------------------------------- MINION - ROGUE
		// [BOT_243] Myra Rotspring - COST:5 [ATK:4/HP:2] 
		// - Set: boomsday, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> <b>Discover</b> a
		//       <b>Deathrattle</b> minion. Also
		//       gain its <b>Deathrattle</b>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact]
		public void MyraRotspring_BOT_243()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Myra Rotspring"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Myra Rotspring"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Myra Rotspring"));

			Choice choice = game.CurrentPlayer.Choice;
			Assert.NotNull(choice);

			// Fix first option 
			IPlayable firstChoice = game.IdEntityDic[choice.Choices.First()];
			Generic.ChangeEntityBlock.Invoke(game.CurrentPlayer, firstChoice, Cards.FromName("Blightnozzle Crawler"), false);

			game.ChooseNthChoice(1);

			Assert.Equal("Blightnozzle Crawler", game.CurrentPlayer.HandZone.Last().Card.Name);

			game.CurrentPlayer.BoardZone[0].Kill();
			Assert.Single(game.CurrentPlayer.BoardZone);
			Assert.Equal("BOT_565t", game.CurrentPlayer.BoardZone[0].Card.Id);
		}

		// ----------------------------------------- MINION - ROGUE
		// [BOT_283] Pogo-Hopper - COST:2 [ATK:1/HP:1] 
		// - Race: mechanical, Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Gain +2/+2 for
		//       each other Pogo-Hopper
		//       you played this game.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void PogoHopper_BOT_283()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Pogo-Hopper"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pogo-Hopper"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Pogo-Hopper"));

			Minion test1 = game.CurrentPlayer.BoardZone[0];
			Assert.Equal(1, test1.AttackDamage);
			Assert.Equal(1, test1.Health);

			Minion test2 = game.ProcessCard<Minion>("Pogo-Hopper");
			Assert.Equal(3, test2.AttackDamage);
			Assert.Equal(3, test2.Health);

			Minion test3 = game.ProcessCard<Minion>("Pogo-Hopper");
			Assert.Equal(5, test3.AttackDamage);
			Assert.Equal(5, test3.Health);
		}

		// ----------------------------------------- MINION - ROGUE
		// [BOT_288] Lab Recruiter - COST:2 [ATK:3/HP:2] 
		// - Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Shuffle 3 copies of a friendly minion into your deck.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void LabRecruiter_BOT_288()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lab Recruiter"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			Minion testTarget = game.ProcessCard<Minion>("Stonetusk Boar");

			game.ProcessCard("Cold Blood", testTarget);

			Assert.Equal(5, testTarget.AttackDamage);

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lab Recruiter", testTarget));

			Assert.Equal(3, game.CurrentPlayer.DeckZone.Count);

			// Should not maintain enchantments when copied into Deck
			for (int i = 0; i < 3; i++)
				Assert.Equal(1, game.CurrentPlayer.DeckZone[i].AsCharacter().AttackDamage);
		}

		// ----------------------------------------- MINION - ROGUE
		// [BOT_565] Blightnozzle Crawler - COST:4 [ATK:2/HP:4] 
		// - Race: mechanical, Fac: neutral, Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a 1/1 Ooze with <b>Poisonous</b> and <b>Rush</b>.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		// RefTag:
		// - POISONOUS = 1
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BlightnozzleCrawler_BOT_565()
		{
			// TODO BlightnozzleCrawler_BOT_565 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blightnozzle Crawler"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blightnozzle Crawler"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blightnozzle Crawler"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [BOT_576] Crazed Chemist - COST:5 [ATK:4/HP:4] 
		// - Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Combo:</b> Give a friendly minion +4 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_FOR_COMBO = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CrazedChemist_BOT_576()
		{
			// TODO CrazedChemist_BOT_576 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Crazed Chemist"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Crazed Chemist"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Crazed Chemist"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [BOT_084] Violet Haze - COST:3 
		// - Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: Add 2 random <b>Deathrattle</b> cards to_your hand.
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VioletHaze_BOT_084()
		{
			// TODO VioletHaze_BOT_084 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Violet Haze"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Violet Haze"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Violet Haze"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [BOT_087] Academic Espionage - COST:4 
		// - Fac: neutral, Set: boomsday, Rarity: epic
		// --------------------------------------------------------
		// Text: Shuffle 10 cards from your opponent's class into your deck. They_cost (1).
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void AcademicEspionage_BOT_087()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Academic Espionage"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.ProcessCard("Academic Espionage");

			Assert.Equal(10, game.CurrentPlayer.DeckZone.Count);
			IEnumerable<IPlayable> unexpectedCards = game.CurrentPlayer.DeckZone.Where(
										p => p.Cost != 1 || p.Card.Class != CardClass.PALADIN);
			foreach (Playable p in unexpectedCards)
			{
				Assert.Equal("Unexpected Card", p.Card.Name);
			}

			// now test it again from the opponents side, to verify we're not cacheing wrong
			game.EndTurn();
			game.ProcessCard("Academic Espionage");

			Assert.Equal(10, game.CurrentPlayer.DeckZone.Count);
			IEnumerable<IPlayable> unexpectedCards2 = game.CurrentPlayer.DeckZone.Where(
										p => p.Cost != 1 || p.Card.Class != CardClass.ROGUE);
			foreach (Playable p in unexpectedCards2)
			{
				Assert.Equal("Unexpected Card", p.Card.Name);
			}
		}

		// ------------------------------------------ SPELL - ROGUE
		// [BOT_242] Myra's Unstable Element - COST:5 
		// - Fac: neutral, Set: boomsday, Rarity: legendary
		// --------------------------------------------------------
		// Text: Draw the rest of
		//       your deck.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MyrasUnstableElement_BOT_242()
		{
			// TODO MyrasUnstableElement_BOT_242 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Myra's Unstable Element"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Myra's Unstable Element"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Myra's Unstable Element"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [BOT_508] Necrium Vial - COST:5 
		// - Set: boomsday, Rarity: epic
		// --------------------------------------------------------
		// Text: Trigger a friendly minion's <b>Deathrattle</b> twice.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_WITH_DEATHRATTLE = 0
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NecriumVial_BOT_508()
		{
			// TODO NecriumVial_BOT_508 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Necrium Vial"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Necrium Vial"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Necrium Vial"));
		}

		// ----------------------------------------- WEAPON - ROGUE
		// [BOT_286] Necrium Blade - COST:3 [ATK:3/HP:0] 
		// - Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Trigger the <b>Deathrattle</b> of a random friendly minion.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NecriumBlade_BOT_286()
		{
			// TODO NecriumBlade_BOT_286 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Necrium Blade"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Necrium Blade"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Necrium Blade"));
		}

	}

	public class ShamanBoomsdayTest
	{
		// ---------------------------------------- MINION - SHAMAN
		// [BOT_291] Storm Chaser - COST:4 [ATK:3/HP:4] 
		// - Race: elemental, Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Draw a spell from your deck that costs_(5) or more.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StormChaser_BOT_291()
		{
			// TODO StormChaser_BOT_291 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Storm Chaser"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Storm Chaser"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Storm Chaser"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [BOT_407] Thunderhead - COST:4 [ATK:3/HP:5] 
		// - Race: elemental, Fac: neutral, Set: boomsday, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]After you play a card with
		//       <b>Overload</b>, summon two
		//       1/1 Sparks with <b>Rush</b>.
		// --------------------------------------------------------
		// RefTag:
		// - OVERLOAD = 1
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact]
		public void Thunderhead_BOT_407()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Thunderhead"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Thunderhead"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Thunderhead"));

			game.ProcessCard("Feral Spirit");

			string[] expected =
			{
				"Spark",
				"Thunderhead",
				"Spark",
				"Spirit Wolf",
				"Spirit Wolf"
			};

			string[] actual = game.CurrentPlayer.BoardZone.Select(p => p.Card.Name).ToArray();

			Assert.True(expected.SequenceEqual(actual));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [BOT_411] Electra Stormsurge - COST:3 [ATK:3/HP:3] 
		// - Race: elemental, Set: boomsday, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Your next spell this turn casts twice.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void ElectraStormsurge_BOT_411()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Electra Stormsurge"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Electra Stormsurge"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Electra Stormsurge"));

			game.ProcessCard("Feral Spirit");

			Assert.Equal(5, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(4, game.CurrentPlayer.OverloadOwed);

			game.ProcessCard("Lightning Bolt", game.CurrentOpponent.Hero);

			Assert.Equal(3, game.CurrentOpponent.Hero.Damage);
			Assert.Equal(5, game.CurrentPlayer.OverloadOwed);

			//
		}

		// ---------------------------------------- MINION - SHAMAN
		// [BOT_533] Menacing Nimbus - COST:2 [ATK:2/HP:2] 
		// - Race: elemental, Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add a random Elemental to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MenacingNimbus_BOT_533()
		{
			// TODO MenacingNimbus_BOT_533 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Menacing Nimbus"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Menacing Nimbus"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Menacing Nimbus"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [BOT_543] Omega Mind - COST:2 [ATK:2/HP:3] 
		// - Fac: neutral, Set: boomsday, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If you have 10
		//       Mana Crystals, your spells
		//        have <b>Lifesteal</b> this turn.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OmegaMind_BOT_543()
		{
			// TODO OmegaMind_BOT_543 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Omega Mind"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Omega Mind"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Omega Mind"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [BOT_093] Elementary Reaction - COST:2 
		// - Fac: neutral, Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: Draw a card. Copy it if_you played an Elemental last turn.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_WITH_DEATHRATTLE = 0
		// --------------------------------------------------------
		[Fact]
		public void ElementaryReaction_BOT_093()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Elementary Reaction"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Elementary Reaction"));
			var hand = game.CurrentPlayer.HandZone;
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Elementary Reaction"));
			Assert.Equal(4, hand.Count);

			game.ProcessCard("Tar Creeper");
			game.EndTurn();
			game.EndTurn();
			game.ProcessCard("Elementary Reaction");
			Assert.Equal(7, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(hand.Last().Card.Id, hand[hand.Count - 2].Card.Id);
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [BOT_099] Eureka! - COST:6 
		// - Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: Summon a copy of_a_random minion from your hand.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact]
		public void Eureka_BOT_099()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stonetusk Boar")
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eureka!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Eureka!"));

			game.ProcessCard("Eureka!");
			Assert.Single(game.CurrentPlayer.BoardZone);
			Assert.Equal("Stonetusk Boar", game.CurrentPlayer.BoardZone[0].Card.Name);
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [BOT_245] The Storm Bringer - COST:7 
		// - Set: boomsday, Rarity: legendary
		// --------------------------------------------------------
		// Text: Transform your minions into random <b>Legendary</b> minions.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact]
		public void TheStormBringer_BOT_245()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Storm Bringer"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.ProcessCard("Stonetusk Boar");
			game.ProcessCard("Stonetusk Boar");
			game.ProcessCard("Stonetusk Boar");

			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Storm Bringer"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Storm Bringer"));

			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
			Assert.True(game.CurrentPlayer.BoardZone.ToList()
				.TrueForAll(p => p.Card.Rarity == Rarity.LEGENDARY));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [BOT_246] Beakered Lightning - COST:0 
		// - Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $1 damage to all minions. <b>Overload:</b> (2) @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 2
		// - OVERLOAD_OWED = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BeakeredLightning_BOT_246()
		{
			// TODO BeakeredLightning_BOT_246 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Beakered Lightning"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Beakered Lightning"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Beakered Lightning"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [BOT_451] Voltaic Burst - COST:1 
		// - Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: Summon two 1/1 Sparks with <b>Rush</b>. <b>Overload:</b> (1)
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 1
		// - OVERLOAD_OWED = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		// RefTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VoltaicBurst_BOT_451()
		{
			// TODO VoltaicBurst_BOT_451 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Voltaic Burst"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Voltaic Burst"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Voltaic Burst"));
		}

	}

	public class WarlockBoomsdayTest
	{
		// --------------------------------------- MINION - WARLOCK
		// [BOT_224] Doubling Imp - COST:3 [ATK:2/HP:2] 
		// - Race: demon, Fac: neutral, Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a copy of this minion.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DoublingImp_BOT_224()
		{
			// TODO DoublingImp_BOT_224 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Doubling Imp"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Doubling Imp"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Doubling Imp"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [BOT_226] Nethersoul Buster - COST:3 [ATK:1/HP:5] 
		// - Race: demon, Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Gain +1 Attack for each damage your hero has taken this turn.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void NethersoulBuster_BOT_226()
		{ 
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nethersoul Buster"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nethersoul Buster"));

			game.ProcessCard("Flame Imp");
			Minion test = game.ProcessCard<Minion>("Nethersoul Buster", null, true);
			Assert.Equal(test.Card.ATK + 3, test.AttackDamage);

			game.EndTurn();
			Minion test2 = game.ProcessCard<Minion>("Nethersoul Buster", null, true);
			Assert.Equal(test2.Card.ATK, test2.AttackDamage);
		}

		// --------------------------------------- MINION - WARLOCK
		// [BOT_433] Dr. Morrigan - COST:8 [ATK:5/HP:5] 
		// - Fac: neutral, Set: boomsday, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Swap this with a minion from your deck.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// - 542 = 1
		// --------------------------------------------------------
		[Fact]
		public void DrMorrigan_BOT_433()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dr. Morrigan"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Stonetusk Boar"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dr. Morrigan"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dr. Morrigan"));

			DeckZone deck = game.CurrentPlayer.DeckZone;
			BoardZone board = game.CurrentPlayer.BoardZone;
			Assert.Single(deck);

			board[0].Kill();
			Assert.Single(board);
			Assert.Single(deck);

			Assert.Equal("Stonetusk Boar", board[0].Card.Name);
			Assert.Equal("Dr. Morrigan", deck[0].Card.Name);
		}

		// --------------------------------------- MINION - WARLOCK
		// [BOT_443] Void Analyst - COST:2 [ATK:2/HP:2] 
		// - Race: demon, Fac: neutral, Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Give all Demons in your hand +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VoidAnalyst_BOT_443()
		{
			// TODO VoidAnalyst_BOT_443 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Void Analyst"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Void Analyst"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Void Analyst"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [BOT_536] Omega Agent - COST:5 [ATK:4/HP:5] 
		// - Set: boomsday, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If you have 10
		//       Mana Crystals, summon
		//       _2 copies of this minion.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OmegaAgent_BOT_536()
		{
			// TODO OmegaAgent_BOT_536 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Omega Agent"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Omega Agent"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Omega Agent"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [BOT_222] Spirit Bomb - COST:2 
		// - Fac: neutral, Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $4 damage to a minion and your hero. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SpiritBomb_BOT_222()
		{
			// TODO SpiritBomb_BOT_222 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spirit Bomb"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spirit Bomb"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Spirit Bomb"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [BOT_263] Soul Infusion - COST:1 
		// - Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: Give the
		//       left-most minion in your hand +2/+2.
		// --------------------------------------------------------
		[Fact]
		public void SoulInfusion_BOT_263()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Soul Infusion"),
					Cards.FromName("Wisp"),
					Cards.FromName("Ectomancy"),
					Cards.FromName("Wisp"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Soul Infusion"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Soul Infusion"));

			HandZone hand = game.CurrentPlayer.HandZone;

			Assert.Equal(3, hand[0].AsCharacter().AttackDamage);
			Assert.Equal(3, hand[0].AsCharacter().Health);
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [BOT_521] Ectomancy - COST:6 
		// - Set: boomsday, Rarity: epic
		// --------------------------------------------------------
		// Text: Summon copies of all Demons you control.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Ectomancy_BOT_521()
		{
			// TODO Ectomancy_BOT_521 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ectomancy"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ectomancy"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ectomancy"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [BOT_568] The Soularium - COST:1 
		// - Set: boomsday, Rarity: legendary
		// --------------------------------------------------------
		// Text: Draw 3 cards.
		//       At the end of your turn, discard them.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact]
		public void TheSoularium_BOT_568()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Soularium"),
					Cards.FromName("The Soularium"),
					Cards.FromName("The Soularium"),
					Cards.FromName("The Soularium"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Soularium"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Soularium"));
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wisp"));
			Assert.Single(game.CurrentPlayer.BoardZone);
			game.EndTurn();
			Assert.Equal(3, game.CurrentOpponent.HandZone.Count);
			Assert.Equal(2, game.CurrentOpponent.DiscardedEntities.Count);
			Assert.Single(game.CurrentOpponent.BoardZone);
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [BOT_913] Demonic Project - COST:2 
		// - Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: Each player transforms a random minion in their hand into a Demon.
		// --------------------------------------------------------
		[Fact]
		public void DemonicProject_BOT_913()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Demonic Project"),
					Cards.FromName("Demonic Project"),
					Cards.FromName("Demonic Project"),
					Cards.FromName("Wisp")
				},
				Player2HeroClass = CardClass.WARLOCK,
				Player2Deck = new List<Card>()
				{
					Cards.FromName("Wisp"),
					Cards.FromName("Demonic Project"),
					Cards.FromName("Demonic Project"),
					Cards.FromName("Demonic Project"),
				},
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Demonic Project"));


			Assert.IsType<Minion>(game.CurrentPlayer.HandZone.Last());
			Assert.IsType<Minion>(game.CurrentOpponent.HandZone.First());

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Demonic Project"));

			Assert.True(game.CurrentPlayer.HandZone.Last().Card.IsRace(Race.DEMON));
			Assert.True(game.CurrentOpponent.HandZone.First().Card.IsRace(Race.DEMON));
		}

	}

	public class WarriorBoomsdayTest
	{
		public WarriorBoomsdayTest(ITestOutputHelper output)
		{
			this.output = output;
		}

		// --------------------------------------- MINION - WARRIOR
		// [BOT_059] Eternium Rover - COST:1 [ATK:1/HP:3] 
		// - Race: mechanical, Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever this minion takes damage, gain 2_Armor.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EterniumRover_BOT_059()
		{
			// TODO EterniumRover_BOT_059 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Eternium Rover"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eternium Rover"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Eternium Rover"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [BOT_104] Dyn-o-matic - COST:5 [ATK:3/HP:4] 
		// - Race: mechanical, Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 5 damage randomly split among all minions_except_Mechs.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DynOMatic_BOT_104()
		{
			// TODO DynOMatic_BOT_104 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dyn-o-matic"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dyn-o-matic"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dyn-o-matic"));

			
		}

		// --------------------------------------- MINION - WARRIOR
		// [BOT_218] Security Rover - COST:6 [ATK:2/HP:5] 
		// - Race: mechanical, Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]Whenever this minion
		//       takes damage, summon a
		//       2/3 Mech with <b>Taunt</b>.
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SecurityRover_BOT_218()
		{
			// TODO SecurityRover_BOT_218 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Security Rover"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Security Rover"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Security Rover"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [BOT_237] Beryllium Nullifier - COST:7 [ATK:3/HP:8] 
		// - Race: mechanical, Set: boomsday, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Magnetic</b>
		//       Can't be targeted by spells or Hero Powers.
		// --------------------------------------------------------
		// GameTag:
		// - CANT_BE_TARGETED_BY_SPELLS = 1
		// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
		// - MODULAR = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BerylliumNullifier_BOT_237()
		{
			// TODO BerylliumNullifier_BOT_237 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Beryllium Nullifier"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Beryllium Nullifier"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Beryllium Nullifier"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [BOT_042] Weapons Project - COST:2 
		// - Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: Each player equips a 2/3 Weapon and
		//       gains 6 Armor.
		// --------------------------------------------------------
		[Fact]
		public void WeaponsProject_BOT_042()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Weapons Project"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Weapons Project"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Weapons Project"));

			Assert.Equal(6, game.Player1.Hero.Armor);
			Assert.Equal(6, game.Player2.Hero.Armor);
			Assert.NotNull(game.Player1.Hero.Weapon);
			Assert.NotNull(game.Player2.Hero.Weapon);
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [BOT_067] Rocket Boots - COST:2 
		// - Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: Give a minion <b>Rush</b>. Draw a card.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RocketBoots_BOT_067()
		{
			// TODO RocketBoots_BOT_067 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rocket Boots"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rocket Boots"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rocket Boots"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [BOT_069] The Boomship - COST:9 
		// - Set: boomsday, Rarity: legendary
		// --------------------------------------------------------
		// Text: Summon 3 random minions from your hand. Give them <b>Rush</b>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		// RefTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact]
		public void TheBoomship_BOT_069()
		{
			// TODO TheBoomship_BOT_069 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Boomship"),
					Cards.FromName("Bloodfen Raptor"),
					Cards.FromName("Dalaran Mage"),
					Cards.FromName("Boulderfist Ogre")
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Boomship"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Boomship"));

			Assert.Empty(game.CurrentPlayer.HandZone);
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
			Assert.True(game.CurrentPlayer.BoardZone.ToList().TrueForAll(m => m.IsRush));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [BOT_299] Omega Assembly - COST:1 
		// - Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Discover</b> a Mech. If you
		//       have 10 Mana Crystals,
		//       keep all 3 cards.
		// --------------------------------------------------------
		// GameTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		// RefTag:
		// - GEARS = 1
		// --------------------------------------------------------
		[Fact]
		public void OmegaAssembly_BOT_299()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Omega Assembly"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Omega Assembly"));

			Assert.NotNull(game.CurrentPlayer.Choice);
			Assert.True(game.CurrentPlayer.SetasideZone.All(p => p.Card.IsRace(Race.MECHANICAL)));
			game.ChooseNthChoice(1);

			game.CurrentPlayer.BaseMana = 10;
			game.CurrentPlayer.UsedMana = 0;

			game.ProcessCard("Omega Assembly");
			Assert.Null(game.CurrentPlayer.Choice);
			for (int i = 0; i < 3; i++)
				Assert.True(game.CurrentPlayer.HandZone
					[game.CurrentPlayer.HandZone.Count - 1 - i].Card.IsRace(Race.MECHANICAL));
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [BOT_406] Supercollider - COST:5 [ATK:1/HP:0] 
		// - Set: boomsday, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]After you attack a minion,
		//       force it to attack one
		//       of its neighbors.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 3
		// - FINISH_ATTACK_SPELL_ON_DAMAGE = 1
		// --------------------------------------------------------
		[Fact]
		public void Supercollider_BOT_406()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Supercollider"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Supercollider"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Supercollider"));
			game.EndTurn();

			Minion target = game.ProcessCard<Minion>("Chillwind Yeti");
			Minion target2 = game.ProcessCard<Minion>("Chillwind Yeti");
			game.EndTurn();

			game.CurrentPlayer.Hero.Attack(target);

			while (game.Logs.Count != 0)
			{
				output.WriteLine(game.Logs.Dequeue().ToString());
			}

			Assert.True(target.IsDead);
			Assert.Equal(1, target2.Health);

		}

		private readonly ITestOutputHelper output;
	}

	public class NeutralBoomsdayTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [BOT_020] Skaterbot - COST:1 [ATK:1/HP:1] 
		// - Race: mechanical, Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Magnetic</b>
		//       <b>Rush</b>
		// --------------------------------------------------------
		// GameTag:
		// - RUSH = 1
		// - MODULAR = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Skaterbot_BOT_020()
		{
			// TODO Skaterbot_BOT_020 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Skaterbot"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Skaterbot"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Skaterbot"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_021] Bronze Gatekeeper - COST:3 [ATK:1/HP:5] 
		// - Race: mechanical, Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Magnetic</b>
		//       <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - MODULAR = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BronzeGatekeeper_BOT_021()
		{
			// TODO BronzeGatekeeper_BOT_021 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bronze Gatekeeper"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bronze Gatekeeper"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bronze Gatekeeper"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_031] Goblin Bomb - COST:1 [ATK:0/HP:2] 
		// - Race: mechanical, Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Deathrattle:</b> Deal 2 damage
		//       to the enemy hero.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GoblinBomb_BOT_031()
		{
			// TODO GoblinBomb_BOT_031 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Goblin Bomb"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Goblin Bomb"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Goblin Bomb"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_050] Rusty Recycler - COST:5 [ATK:2/HP:6] 
		// - Race: mechanical, Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Lifesteal</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RustyRecycler_BOT_050()
		{
			// TODO RustyRecycler_BOT_050 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rusty Recycler"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rusty Recycler"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rusty Recycler"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_066] Mechanical Whelp - COST:6 [ATK:2/HP:2] 
		// - Race: mechanical, Fac: neutral, Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a 7/7 Mechanical Dragon.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MechanicalWhelp_BOT_066()
		{
			// TODO MechanicalWhelp_BOT_066 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mechanical Whelp"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mechanical Whelp"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mechanical Whelp"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_079] Faithful Lumi - COST:1 [ATK:1/HP:1] 
		// - Race: mechanical, Fac: neutral, Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly Mech +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_TARGET_WITH_RACE = 17
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FaithfulLumi_BOT_079()
		{
			// TODO FaithfulLumi_BOT_079 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Faithful Lumi"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Faithful Lumi"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Faithful Lumi"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_083] Toxicologist - COST:2 [ATK:2/HP:2] 
		// - Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give your weapon +1 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Toxicologist_BOT_083()
		{
			// TODO Toxicologist_BOT_083 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Toxicologist"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Toxicologist"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Toxicologist"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_098] Unpowered Mauler - COST:2 [ATK:2/HP:4] 
		// - Race: mechanical, Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: Can only attack if you cast a spell this turn.
		// --------------------------------------------------------
		[Fact]
		public void UnpoweredMauler_BOT_098()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unpowered Mauler"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unpowered Mauler"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Unpowered Mauler"));

			Minion test = game.CurrentPlayer.BoardZone[0];

			Assert.True(test.CantAttack);

			game.ProcessCard("Fireball", game.CurrentOpponent.Hero);

			Assert.False(test.CantAttack);

			game.EndTurn();
			game.EndTurn();

			Assert.True(test.CantAttack);

		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_102] Spark Drill - COST:6 [ATK:5/HP:1] 
		// - Race: mechanical, Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Rush</b>
		//       <b>Deathrattle:</b> Add two
		//       1/1 Sparks with <b>Rush</b> to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SparkDrill_BOT_102()
		{
			// TODO SparkDrill_BOT_102 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spark Drill"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spark Drill"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Spark Drill"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_107] Missile Launcher - COST:6 [ATK:4/HP:4] 
		// - Race: mechanical, Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Magnetic</b>
		//       At the end of your turn,
		//       deal 1 damage to all
		//       other characters.
		// --------------------------------------------------------
		// GameTag:
		// - MODULAR = 1
		// --------------------------------------------------------
		[Fact]
		public void MissileLauncher_BOT_107()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Missile Launcher"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Missile Launcher"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Missile Launcher"));


			game.ProcessCard("Upgradeable Framebot");
			game.ProcessCard("Missile Launcher", null, true, zonePosition: 0);

			Assert.Single(game.CurrentPlayer.BoardZone);
			Minion test = game.CurrentPlayer.BoardZone[0];
			Assert.Equal(5, test.AttackDamage);
			Assert.NotNull(test.ActivatedTrigger);

			game.EndTurn();
			Assert.Equal(1, game.CurrentPlayer.Hero.Damage);
			Assert.Equal(1, game.CurrentOpponent.Hero.Damage);
			Assert.Equal(0, test.Damage);

			game.EndTurn();

			game.ProcessCard("Missile Launcher", null, true, zonePosition: 0);
			Assert.Single(game.CurrentPlayer.BoardZone);
			Assert.NotNull(test.ActivatedTrigger);

			game.EndTurn();
			Assert.Equal(3, game.CurrentPlayer.Hero.Damage);
			Assert.Equal(3, game.CurrentOpponent.Hero.Damage);
			Assert.Equal(0, test.Damage);

			game.EndTurn();
			game.CurrentPlayer.BoardZone[0].Kill();

			game.EndTurn();
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_267] Piloted Reaper - COST:4 [ATK:4/HP:3] 
		// - Race: mechanical, Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a random minion from
		//       your hand that costs (2) or less.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void PilotedReaper_BOT_267()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Piloted Reaper"),
					Cards.FromName("Wisp"),
					Cards.FromName("Dalaran Mage"),
					Cards.FromName("Dalaran Mage")
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Piloted Reaper"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Piloted Reaper"));

			game.CurrentPlayer.BoardZone[0].Kill();
			Assert.Single(game.CurrentPlayer.BoardZone);
			Assert.Equal("Wisp", game.CurrentPlayer.BoardZone[0].Card.Name);

			Minion test = game.ProcessCard<Minion>("Piloted Reaper");
			test.Kill();
			Assert.Single(game.CurrentPlayer.BoardZone);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_270] Giggling Inventor - COST:5 [ATK:2/HP:1] 
		// - Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon two 1/2 Mechs with <b>Taunt</b> and_<b>Divine Shield</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GigglingInventor_BOT_270()
		{
			// TODO GigglingInventor_BOT_270 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Giggling Inventor"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Giggling Inventor"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Giggling Inventor"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_280] Holomancer - COST:5 [ATK:3/HP:3] 
		// - Set: boomsday, Rarity: epic
		// --------------------------------------------------------
		// Text: After your opponent plays a minion, summon a 1/1_copy of it.
		// --------------------------------------------------------
		[Fact]
		public void Holomancer_BOT_280()
		{
			// TODO Holomancer_BOT_280 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Holomancer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Holomancer"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Holomancer"));
			game.EndTurn();

			game.ProcessCard("Bloodfen Raptor");
			Assert.Equal(2, game.CurrentOpponent.BoardZone.Count);
			var test = game.CurrentOpponent.BoardZone[1];
			Assert.Equal("Bloodfen Raptor", test.Card.Name);
			Assert.Equal(1, test.AttackDamage);
			Assert.Equal(1, test.Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_296] Omega Defender - COST:4 [ATK:2/HP:6] 
		// - Set: boomsday, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       <b>Battlecry:</b> If you have
		//       10 Mana Crystals,
		//       gain +10 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OmegaDefender_BOT_296()
		{
			// TODO OmegaDefender_BOT_296 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Omega Defender"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Omega Defender"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Omega Defender"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_308] Spring Rocket - COST:3 [ATK:2/HP:1] 
		// - Race: mechanical, Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 2 damage.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SpringRocket_BOT_308()
		{
			// TODO SpringRocket_BOT_308 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spring Rocket"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spring Rocket"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Spring Rocket"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_309] Upgradeable Framebot - COST:2 [ATK:1/HP:5] 
		// - Race: mechanical, Set: boomsday, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UpgradeableFramebot_BOT_309()
		{
			// TODO UpgradeableFramebot_BOT_309 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Upgradeable Framebot"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Upgradeable Framebot"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Upgradeable Framebot"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_312] Replicating Menace - COST:4 [ATK:3/HP:1] 
		// - Race: mechanical, Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Magnetic</b>
		//       <b>Deathrattle:</b> Summon three 1/1 Microbots.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// - MODULAR = 1
		// - 853 = 48548
		// --------------------------------------------------------
		[Fact]
		public void ReplicatingMenace_BOT_312()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Replicating Menace"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});

			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			Minion testCard = game.ProcessCard<Minion>("Replicating Menace");
			game.ProcessCard<Minion>("Replicating Menace", zonePosition: 0);
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(2, testCard.BaseHealth);
			Assert.Equal(6, testCard.AttackDamage);

			// trigger deathrattle, should spawn 6 Microbots
			game.ProcessCard<Minion>("Fireworks Tech", testCard, asZeroCost: true, zonePosition: 0);
			Assert.Equal(7, game.CurrentPlayer.BoardZone.Count);
			Assert.All(game.CurrentPlayer.BoardZone.Skip(2), m => m.Card.Name.Equals("Microbot"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_401] Weaponized Piñata - COST:4 [ATK:4/HP:3] 
		// - Race: mechanical, Set: boomsday, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Add a random <b>Legendary</b> minion to your_hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WeaponizedPiata_BOT_401()
		{
			// TODO WeaponizedPiata_BOT_401 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Weaponized Piñata"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Weaponized Piñata"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Weaponized Piñata"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_413] Brainstormer - COST:3 [ATK:3/HP:1] 
		// - Fac: neutral, Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Gain +1 Health
		//       for each spell in your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Brainstormer_BOT_413()
		{
			// TODO Brainstormer_BOT_413 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Brainstormer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Brainstormer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Brainstormer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_414] Cloakscale Chemist - COST:2 [ATK:1/HP:2] 
		// - Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Stealth</b>
		//       <b>Divine Shield</b>
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CloakscaleChemist_BOT_414()
		{
			// TODO CloakscaleChemist_BOT_414 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cloakscale Chemist"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cloakscale Chemist"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cloakscale Chemist"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_424] Mecha'thun - COST:10 [ATK:10/HP:10] 
		// - Race: mechanical, Set: boomsday, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Deathrattle:</b> If you have no
		//       cards in your deck, hand,
		//       and battlefield, destroy
		//       the enemy hero.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void Mechathun_BOT_424()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mecha'thun"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mecha'thun"));
			game.ProcessCard("Mecha'thun", null, true);

			game.CurrentPlayer.BoardZone[0].Kill();
			Assert.NotEqual(PlayState.WON, game.CurrentPlayer.PlayState);
			game.CurrentPlayer.BoardZone[0].Kill();
			Assert.Equal(PlayState.WON, game.CurrentPlayer.PlayState);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_431] Whirliglider - COST:2 [ATK:2/HP:1] 
		// - Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 0/2_Goblin Bomb.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Whirliglider_BOT_431()
		{
			// TODO Whirliglider_BOT_431 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Whirliglider"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Whirliglider"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Whirliglider"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_445] Mecharoo - COST:1 [ATK:1/HP:1] 
		// - Race: mechanical, Fac: neutral, Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a 1/1 Jo-E Bot.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Mecharoo_BOT_445()
		{
			// TODO Mecharoo_BOT_445 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mecharoo"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mecharoo"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mecharoo"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_447] Crystallizer - COST:1 [ATK:1/HP:3] 
		// - Set: boomsday, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Deal 5 damage
		//       to your hero. Gain 5 Armor.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Crystallizer_BOT_447()
		{
			// TODO Crystallizer_BOT_447 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Crystallizer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Crystallizer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Crystallizer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_448] Damaged Stegotron - COST:6 [ATK:5/HP:12] 
		// - Race: mechanical, Fac: horde, Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Battlecry:</b> Deal 6 damage to this minion.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DamagedStegotron_BOT_448()
		{
			// TODO DamagedStegotron_BOT_448 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Damaged Stegotron"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Damaged Stegotron"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Damaged Stegotron"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_511] Seaforium Bomber - COST:5 [ATK:5/HP:5] 
		// - Set: boomsday, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Shuffle a Bomb
		//       into your opponent's deck.
		//       When drawn, it explodes
		//       for 5 damage.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SeaforiumBomber_BOT_511()
		{
			// TODO SeaforiumBomber_BOT_511 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Seaforium Bomber"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Seaforium Bomber"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Seaforium Bomber"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_532] Explodinator - COST:4 [ATK:3/HP:2] 
		// - Race: mechanical, Fac: horde, Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon two 0/2 Goblin Bombs.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Explodinator_BOT_532()
		{
			// TODO Explodinator_BOT_532 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Explodinator"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Explodinator"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Explodinator"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_534] Bull Dozer - COST:9 [ATK:9/HP:7] 
		// - Race: mechanical, Fac: alliance, Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Divine Shield</b>
		// --------------------------------------------------------
		// GameTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BullDozer_BOT_534()
		{
			// TODO BullDozer_BOT_534 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bull Dozer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bull Dozer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bull Dozer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_535] Microtech Controller - COST:3 [ATK:2/HP:1] 
		// - Fac: neutral, Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon two 1/1 Microbots.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MicrotechController_BOT_535()
		{
			// TODO MicrotechController_BOT_535 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Microtech Controller"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Microtech Controller"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Microtech Controller"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_538] Spark Engine - COST:2 [ATK:2/HP:1] 
		// - Race: mechanical, Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add a 
		//       1/1 Spark with <b>Rush</b> to_your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SparkEngine_BOT_538()
		{
			// TODO SparkEngine_BOT_538 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spark Engine"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spark Engine"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Spark Engine"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_539] Arcane Dynamo - COST:6 [ATK:3/HP:4] 
		// - Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Discover</b> a spell that costs (5) or more.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArcaneDynamo_BOT_539()
		{
			// TODO ArcaneDynamo_BOT_539 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arcane Dynamo"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Dynamo"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Arcane Dynamo"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_540] E.M.P. Operative - COST:5 [ATK:3/HP:3] 
		// - Set: boomsday, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy a Mech.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_TARGET_WITH_RACE = 17
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EmpOperative_BOT_540()
		{
			// TODO EmpOperative_BOT_540 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("E.M.P. Operative"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("E.M.P. Operative"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "E.M.P. Operative"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_544] Loose Specimen - COST:5 [ATK:6/HP:6] 
		// - Race: beast, Set: boomsday, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 6 damage randomly split among other friendly minions.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LooseSpecimen_BOT_544()
		{
			// TODO LooseSpecimen_BOT_544 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Loose Specimen"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loose Specimen"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Loose Specimen"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_548] Zilliax - COST:5 [ATK:3/HP:2] 
		// - Race: mechanical, Set: boomsday, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Magnetic</b>
		//       <b><b>Divine Shield</b>, <b>Taunt</b>, Lifesteal, Rush</b>
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - TAUNT = 1
		// - DIVINE_SHIELD = 1
		// - LIFESTEAL = 1
		// - RUSH = 1
		// - MODULAR = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Zilliax_BOT_548()
		{
			// TODO Zilliax_BOT_548 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Zilliax"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Zilliax"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Zilliax"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_550] Electrowright - COST:3 [ATK:3/HP:3] 
		// - Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding a spell that costs (5) or more, gain +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Electrowright_BOT_550()
		{
			// TODO Electrowright_BOT_550 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Electrowright"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Electrowright"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Electrowright"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_552] Star Aligner - COST:7 [ATK:7/HP:7] 
		// - Set: boomsday, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If you control 3
		//       minions with 7 Health, deal
		//       7 damage to all enemies.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StarAligner_BOT_552()
		{
			// TODO StarAligner_BOT_552 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Star Aligner"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Star Aligner"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Star Aligner"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_555] Harbinger Celestia - COST:4 [ATK:5/HP:6] 
		// - Fac: neutral, Set: boomsday, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Stealth</b>
		//       After your opponent plays
		//       a minion, become a
		//       copy of it.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact]
		public void HarbingerCelestia_BOT_555()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Harbinger Celestia"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Harbinger Celestia"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Harbinger Celestia"));
			game.EndTurn();

			game.ProcessCard("Stonetusk Boar");
			Assert.Equal("Stonetusk Boar", game.CurrentOpponent.BoardZone[0].Card.Name);

			game.ProcessCard("Bloodfen Raptor");
			Assert.Equal("Stonetusk Boar", game.CurrentOpponent.BoardZone[0].Card.Name);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_559] Augmented Elekk - COST:3 [ATK:3/HP:4] 
		// - Race: beast, Set: boomsday, Rarity: epic
		// --------------------------------------------------------
		// Text: Whenever you shuffle a card into a deck, shuffle in_an extra copy.
		// --------------------------------------------------------
		[Fact]
		public void AugmentedElekk_BOT_559()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Augmented Elekk"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Augmented Elekk"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Augmented Elekk"));

			int deckCount = game.CurrentPlayer.DeckZone.Count;

			game.ProcessCard("Fal'dorei Strider");

			Assert.Equal(deckCount + 6, game.CurrentPlayer.DeckZone.Count);

			game.ProcessCard("Augmented Elekk");
			game.ProcessCard("Fal'dorei Strider", asZeroCost: true);

			Assert.Equal(deckCount + 6 + 9, game.CurrentPlayer.DeckZone.Count);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_562] Coppertail Imposter - COST:4 [ATK:4/HP:4] 
		// - Race: mechanical, Fac: horde, Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Gain <b>Stealth</b> until your next turn.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CoppertailImposter_BOT_562()
		{
			// TODO CoppertailImposter_BOT_562 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Coppertail Imposter"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Coppertail Imposter"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Coppertail Imposter"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_563] Wargear - COST:5 [ATK:5/HP:5] 
		// - Race: mechanical, Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Magnetic</b>
		// --------------------------------------------------------
		// GameTag:
		// - MODULAR = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Wargear_BOT_563()
		{
			// TODO Wargear_BOT_563 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wargear"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wargear"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wargear"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_573] Subject 9 - COST:5 [ATK:4/HP:4] 
		// - Race: beast, Set: boomsday, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Draw 5 different <b>Secrets</b> from your deck.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact]
		public void Subject9_BOT_573()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Subject 9"),
					Cards.FromName("Subject 9"),
					Cards.FromName("Subject 9"),
					Cards.FromName("Subject 9"),
					Cards.FromName("Counterspell"),
					Cards.FromName("Counterspell"),
					Cards.FromName("Explosive Runes"),
					Cards.FromName("Frozen Clone"),
					Cards.FromName("Frozen Clone"),
					Cards.FromName("Ice Barrier"),
					Cards.FromName("Mana Bind"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Subject 9"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Subject 9"));

			Assert.Equal(8, game.CurrentPlayer.HandZone.Count);

			Assert.Equal(5, game.CurrentPlayer.HandZone
				.Where(p => p is Spell s && s.IsSecret)
				.Select(p => p.Card.Id)
				.Distinct()
				.Count());
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_603] Steel Rager - COST:4 [ATK:5/HP:1] 
		// - Race: mechanical, Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Rush</b>
		// --------------------------------------------------------
		// GameTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SteelRager_BOT_603()
		{
			// TODO SteelRager_BOT_603 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Steel Rager"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Steel Rager"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Steel Rager"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_606] Kaboom Bot - COST:3 [ATK:2/HP:2] 
		// - Race: mechanical, Set: boomsday, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Deal 4_damage to a random enemy minion.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KaboomBot_BOT_606()
		{
			// TODO KaboomBot_BOT_606 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kaboom Bot"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kaboom Bot"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kaboom Bot"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_700] SN1P-SN4P - COST:3 [ATK:2/HP:3] 
		// - Race: mechanical, Set: boomsday, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Magnetic</b>, <b>Echo</b>
		//       <b>Deathrattle:</b> Summon two 1/1 Microbots.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// - ECHO = 1
		// - MODULAR = 1
		// --------------------------------------------------------
		[Fact]
		public void Sn1pSn4p_BOT_700()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			Minion testCard = game.ProcessCard<Minion>("SN1P-SN4P");
			Minion test = game.CurrentPlayer.BoardZone[0];
			game.ProcessCard(game.CurrentPlayer.HandZone.Last(), null, zonePosition:0); // play echo copy
			game.ProcessCard(game.CurrentPlayer.HandZone.Last(), null, zonePosition: 0); // play echo copy

			Assert.Equal(9, test.BaseHealth);
			Assert.Equal(6, test.AttackDamage);

			game.ProcessCard<Minion>("E.M.P. Operative", test, asZeroCost:true, zonePosition: 0);

			Assert.Equal(7, game.CurrentPlayer.BoardZone.Count);
			int microbotCount = game.CurrentPlayer.BoardZone.Where(m => m.Card.Name.Equals("Microbot")).Count();
			Assert.Equal(6, microbotCount);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_907] Galvanizer - COST:2 [ATK:1/HP:2] 
		// - Race: mechanical, Set: boomsday, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Reduce the
		//       Cost of Mechs in your
		//       hand by (1).
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Galvanizer_BOT_907()
		{
			// TODO Galvanizer_BOT_907 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Galvanizer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Galvanizer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Galvanizer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BOT_914] Whizbang the Wonderful - COST:4 [ATK:4/HP:5] 
		// - Set: boomsday, Rarity: legendary
		// --------------------------------------------------------
		// Text: You start the game with one of Whizbang's Wonderful Decks!
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DECK_RULE_MOD_DECK_SIZE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WhizbangTheWonderful_BOT_914()
		{
			// TODO WhizbangTheWonderful_BOT_914 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Whizbang the Wonderful"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Whizbang the Wonderful"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Whizbang the Wonderful"));
		}

	}

}
