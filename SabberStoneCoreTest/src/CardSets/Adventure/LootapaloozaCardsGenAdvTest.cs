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
using Xunit;
using SabberStoneCore.Enums;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using System.Collections.Generic;

namespace SabberStoneCoreTest.CardSets.Adventure
{
	public class HeroesLootapaloozaTest
	{
		// ------------------------------------------ HERO - HUNTER
		// [LOOTA_BOSS_04h] Waxmancer Sturmi (*) - COST:0 [ATK:0/HP:30] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>This kobold can
		//       candle-craft
		//       minions at will.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 46149
		// - 793 = 946
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WaxmancerSturmi_LOOTA_BOSS_04h()
		{
			// TODO WaxmancerSturmi_LOOTA_BOSS_04h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Waxmancer Sturmi"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Waxmancer Sturmi"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Waxmancer Sturmi"));
		}

		// ----------------------------------------- HERO - WARRIOR
		// [LOOTA_BOSS_05h] Pathmaker Hamm (*) - COST:0 [ATK:0/HP:20] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>There's more than
		//       one way for a kobold
		//       to_dig_a_tunnel.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 46151
		// - 793 = 1465
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PathmakerHamm_LOOTA_BOSS_05h()
		{
			// TODO PathmakerHamm_LOOTA_BOSS_05h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Pathmaker Hamm"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pathmaker Hamm"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Pathmaker Hamm"));
		}

		// ------------------------------------------- HERO - DRUID
		// [LOOTA_BOSS_06h] Blackseed (*) - COST:0 [ATK:0/HP:40] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>This furbolg’s dark magic twists the other dungeonfolk.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 46153
		// - 793 = 1466
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Blackseed_LOOTA_BOSS_06h()
		{
			// TODO Blackseed_LOOTA_BOSS_06h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blackseed"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blackseed"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blackseed"));
		}

		// -------------------------------------------- HERO - MAGE
		// [LOOTA_BOSS_09h] Frostfur (*) - COST:0 [ATK:0/HP:20] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>These furbolg warrens feel unnaturally cold...</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 46159
		// - 793 = 27
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Frostfur_LOOTA_BOSS_09h()
		{
			// TODO Frostfur_LOOTA_BOSS_09h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Frostfur"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostfur"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Frostfur"));
		}

		// ------------------------------------------ HERO - PRIEST
		// [LOOTA_BOSS_10h] Graves the Cleric (*) - COST:0 [ATK:0/HP:20] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>This healing adventurer was separated from his old party.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 46161
		// - 793 = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GravesTheCleric_LOOTA_BOSS_10h()
		{
			// TODO GravesTheCleric_LOOTA_BOSS_10h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Graves the Cleric"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Graves the Cleric"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Graves the Cleric"));
		}

		// ----------------------------------------- HERO - WARRIOR
		// [LOOTA_BOSS_11h] Overseer Mogark (*) - COST:0 [ATK:0/HP:20] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>This trogg commander is extra "motivational" to underlings.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 46163
		// - 793 = 1473
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OverseerMogark_LOOTA_BOSS_11h()
		{
			// TODO OverseerMogark_LOOTA_BOSS_11h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Overseer Mogark"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Overseer Mogark"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Overseer Mogark"));
		}

		// ------------------------------------------- HERO - ROGUE
		// [LOOTA_BOSS_12h] Candlebeard (*) - COST:0 [ATK:0/HP:20] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>This kobold pirate's favorite move is chaaaarrrge!</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 46165
		// - 793 = 1467
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Candlebeard_LOOTA_BOSS_12h()
		{
			// TODO Candlebeard_LOOTA_BOSS_12h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Candlebeard"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Candlebeard"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Candlebeard"));
		}

		// ------------------------------------------- HERO - ROGUE
		// [LOOTA_BOSS_13h] Thaddock the Thief (*) - COST:0 [ATK:0/HP:40] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>One moment her minions are there... the next... gone!</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 46167
		// - 793 = 1259
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ThaddockTheThief_LOOTA_BOSS_13h()
		{
			// TODO ThaddockTheThief_LOOTA_BOSS_13h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Thaddock the Thief"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Thaddock the Thief"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Thaddock the Thief"));
		}

		// ----------------------------------------- HERO - PALADIN
		// [LOOTA_BOSS_15h] George and Karl (*) - COST:0 [ATK:0/HP:30] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>These tag-team paladins went missing in Un'goro.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 46170
		// - 793 = 1475
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GeorgeAndKarl_LOOTA_BOSS_15h()
		{
			// TODO GeorgeAndKarl_LOOTA_BOSS_15h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("George and Karl"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("George and Karl"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "George and Karl"));
		}

		// ------------------------------------------ HERO - PRIEST
		// [LOOTA_BOSS_16h] Spiritspeaker Azun (*) - COST:0 [ATK:0/HP:40] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>This troll priest speaks with the dead... twice.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 46172
		// - 793 = 1261
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SpiritspeakerAzun_LOOTA_BOSS_16h()
		{
			// TODO SpiritspeakerAzun_LOOTA_BOSS_16h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spiritspeaker Azun"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spiritspeaker Azun"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Spiritspeaker Azun"));
		}

		// ----------------------------------------- HERO - WARRIOR
		// [LOOTA_BOSS_17h] Battlecrier Jin'zo (*) - COST:0 [ATK:0/HP:40] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>When he calls in the troops, they listen. Twice.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 46174
		// - 793 = 1567
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BattlecrierJinzo_LOOTA_BOSS_17h()
		{
			// TODO BattlecrierJinzo_LOOTA_BOSS_17h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Battlecrier Jin'zo"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Battlecrier Jin'zo"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Battlecrier Jin'zo"));
		}

		// ------------------------------------------ HERO - HUNTER
		// [LOOTA_BOSS_18h] Giant Rat (*) - COST:0 [ATK:0/HP:10] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>The bane of every young adventurer.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 45894
		// - 793 = 1557
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GiantRat_LOOTA_BOSS_18h()
		{
			// TODO GiantRat_LOOTA_BOSS_18h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Giant Rat"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Giant Rat"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Giant Rat"));
		}

		// ------------------------------------------ HERO - SHAMAN
		// [LOOTA_BOSS_19h] Gutmook (*) - COST:0 [ATK:0/HP:30] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>This trogg elder and his minions flock toward sources of magic.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 46205
		// - 793 = 1455
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Gutmook_LOOTA_BOSS_19h()
		{
			// TODO Gutmook_LOOTA_BOSS_19h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gutmook"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gutmook"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gutmook"));
		}

		// ----------------------------------------- HERO - WARRIOR
		// [LOOTA_BOSS_20h] Brimstone Warden (*) - COST:0 [ATK:0/HP:30] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>At all costs, stop him from waking the
		//       ancient_guardians...</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 46208
		// - 793 = 1456
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BrimstoneWarden_LOOTA_BOSS_20h()
		{
			// TODO BrimstoneWarden_LOOTA_BOSS_20h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Brimstone Warden"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Brimstone Warden"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Brimstone Warden"));
		}

		// ----------------------------------------- HERO - WARRIOR
		// [LOOTA_BOSS_21h] Gnosh the Greatworm (*) - COST:0 [ATK:0/HP:40] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>Always looking to devour the largest, tastiest minions.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 46242
		// - 793 = 1458
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GnoshTheGreatworm_LOOTA_BOSS_21h()
		{
			// TODO GnoshTheGreatworm_LOOTA_BOSS_21h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gnosh the Greatworm"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gnosh the Greatworm"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gnosh the Greatworm"));
		}

		// ------------------------------------------ HERO - HUNTER
		// [LOOTA_BOSS_22h] Tad (*) - COST:0 [ATK:0/HP:20] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>Look, this murloc just wants to fish, okay?</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 46250
		// - 793 = 1462
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Tad_LOOTA_BOSS_22h()
		{
			// TODO Tad_LOOTA_BOSS_22h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tad"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tad"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tad"));
		}

		// ------------------------------------------ HERO - HUNTER
		// [LOOTA_BOSS_23h] Bristlesnarl (*) - COST:0 [ATK:0/HP:50] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>This legendary furbolg hunter can quickly call on big friends.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 46342
		// - 793 = 1577
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Bristlesnarl_LOOTA_BOSS_23h()
		{
			// TODO Bristlesnarl_LOOTA_BOSS_23h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bristlesnarl"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bristlesnarl"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bristlesnarl"));
		}

		// ----------------------------------------- HERO - PALADIN
		// [LOOTA_BOSS_24h] The Mothergloop (*) - COST:0 [ATK:0/HP:50] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>Don't let its growing, gooey friends get
		//       out of hand.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 46346
		// - 793 = 1468
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheMothergloop_LOOTA_BOSS_24h()
		{
			// TODO TheMothergloop_LOOTA_BOSS_24h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Mothergloop"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Mothergloop"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Mothergloop"));
		}

		// ------------------------------------------ HERO - PRIEST
		// [LOOTA_BOSS_25h] Vustrasz the Ancient (*) - COST:0 [ATK:0/HP:70] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>His vast treasure stores are for the taking... if you dare!</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 46350
		// - 793 = 1469
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VustraszTheAncient_LOOTA_BOSS_25h()
		{
			// TODO VustraszTheAncient_LOOTA_BOSS_25h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Vustrasz the Ancient"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vustrasz the Ancient"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Vustrasz the Ancient"));
		}

		// ----------------------------------------- HERO - WARLOCK
		// [LOOTA_BOSS_26h] Xol the Unscathed (*) - COST:0 [ATK:0/HP:70] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>She's got her eyes on you. ALL of her eyes.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 47428
		// - 793 = 1568
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void XolTheUnscathed_LOOTA_BOSS_26h()
		{
			// TODO XolTheUnscathed_LOOTA_BOSS_26h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Xol the Unscathed"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Xol the Unscathed"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Xol the Unscathed"));
		}

		// ------------------------------------------ HERO - HUNTER
		// [LOOTA_BOSS_27h] Waxmancer Sturmi (*) - COST:0 [ATK:0/HP:50] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>This kobold can
		//       candle-craft
		//       minions at will.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 46267
		// - 793 = 946
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WaxmancerSturmi_LOOTA_BOSS_27h()
		{
			// TODO WaxmancerSturmi_LOOTA_BOSS_27h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Waxmancer Sturmi"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Waxmancer Sturmi"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Waxmancer Sturmi"));
		}

		// ----------------------------------------- HERO - WARRIOR
		// [LOOTA_BOSS_28h] Pathmaker Hamm (*) - COST:0 [ATK:0/HP:60] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>There's more than
		//       one way for a kobold
		//       to_dig_a_tunnel.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 46271
		// - 793 = 1465
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PathmakerHamm_LOOTA_BOSS_28h()
		{
			// TODO PathmakerHamm_LOOTA_BOSS_28h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Pathmaker Hamm"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pathmaker Hamm"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Pathmaker Hamm"));
		}

		// ------------------------------------------- HERO - DRUID
		// [LOOTA_BOSS_29h] Blackseed (*) - COST:0 [ATK:0/HP:60] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>This furbolg’s dark magic twists the other dungeonfolk.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 46282
		// - 793 = 1466
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Blackseed_LOOTA_BOSS_29h()
		{
			// TODO Blackseed_LOOTA_BOSS_29h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blackseed"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blackseed"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blackseed"));
		}

		// ----------------------------------------- HERO - WARRIOR
		// [LOOTA_BOSS_30h] Overseer Mogark (*) - COST:0 [ATK:0/HP:60] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>This trogg commander is extra "motivational" to underlings.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 46314
		// - 793 = 1473
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OverseerMogark_LOOTA_BOSS_30h()
		{
			// TODO OverseerMogark_LOOTA_BOSS_30h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Overseer Mogark"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Overseer Mogark"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Overseer Mogark"));
		}

		// ------------------------------------------- HERO - ROGUE
		// [LOOTA_BOSS_31h] Candlebeard (*) - COST:0 [ATK:0/HP:60] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>This kobold pirate's favorite move is chaaaarrrge!</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 46319
		// - 793 = 1467
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Candlebeard_LOOTA_BOSS_31h()
		{
			// TODO Candlebeard_LOOTA_BOSS_31h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Candlebeard"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Candlebeard"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Candlebeard"));
		}

		// ----------------------------------------- HERO - PALADIN
		// [LOOTA_BOSS_32h] Karl and George (*) - COST:0 [ATK:0/HP:30] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>These tag-team paladins went missing in Un'goro.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2740
		// - 793 = 1475
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KarlAndGeorge_LOOTA_BOSS_32h()
		{
			// TODO KarlAndGeorge_LOOTA_BOSS_32h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Karl and George"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Karl and George"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Karl and George"));
		}

		// ------------------------------------------ HERO - SHAMAN
		// [LOOTA_BOSS_33h] Gutmook (*) - COST:0 [ATK:0/HP:50] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>This trogg elder and his minions flock toward sources of magic.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 46331
		// - 793 = 1455
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Gutmook_LOOTA_BOSS_33h()
		{
			// TODO Gutmook_LOOTA_BOSS_33h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gutmook"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gutmook"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gutmook"));
		}

		// ----------------------------------------- HERO - WARLOCK
		// [LOOTA_BOSS_34h] Azari, the Devourer (*) - COST:0 [ATK:0/HP:70] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>The most terrible of demons is loose!
		//       And VERY hungry.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 46353
		// - 793 = 1560
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AzariTheDevourer_LOOTA_BOSS_34h()
		{
			// TODO AzariTheDevourer_LOOTA_BOSS_34h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Azari, the Devourer"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Azari, the Devourer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Azari, the Devourer"));
		}

		// ------------------------------------------ HERO - SHAMAN
		// [LOOTA_BOSS_35h] Elder Brandlemar (*) - COST:0 [ATK:0/HP:20] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>The bane of magic users, this furbolg can counter any spell.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 46358
		// - 793 = 13
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ElderBrandlemar_LOOTA_BOSS_35h()
		{
			// TODO ElderBrandlemar_LOOTA_BOSS_35h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Elder Brandlemar"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Elder Brandlemar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Elder Brandlemar"));
		}

		// ------------------------------------------- HERO - DRUID
		// [LOOTA_BOSS_36h] Ixlid (*) - COST:0 [ATK:0/HP:20] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>Its deadly spores can kill an adventurer instantly!</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 46363
		// - 793 = 1471
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Ixlid_LOOTA_BOSS_36h()
		{
			// TODO Ixlid_LOOTA_BOSS_36h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ixlid"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ixlid"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ixlid"));
		}

		// -------------------------------------------- HERO - MAGE
		// [LOOTA_BOSS_37h] Lyris the Wild Mage (*) - COST:0 [ATK:0/HP:40] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>She loves fire. Her minions love that she loves fire.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 46368
		// - 793 = 1472
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LyrisTheWildMage_LOOTA_BOSS_37h()
		{
			// TODO LyrisTheWildMage_LOOTA_BOSS_37h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lyris the Wild Mage"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lyris the Wild Mage"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lyris the Wild Mage"));
		}

		// ------------------------------------------- HERO - ROGUE
		// [LOOTA_BOSS_38h] Voodoomaster Vex (*) - COST:0 [ATK:0/HP:50] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>He wants to be a troll. He cries for battle and rattles for death.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 47000
		// - 793 = 1531
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VoodoomasterVex_LOOTA_BOSS_38h()
		{
			// TODO VoodoomasterVex_LOOTA_BOSS_38h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Voodoomaster Vex"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Voodoomaster Vex"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Voodoomaster Vex"));
		}

		// ----------------------------------------- HERO - WARRIOR
		// [LOOTA_BOSS_39h] Kraxx (*) - COST:0 [ATK:0/HP:30] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>This ancient stone guardian prefers the loot to stay here.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 47257
		// - 793 = 1543
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Kraxx_LOOTA_BOSS_39h()
		{
			// TODO Kraxx_LOOTA_BOSS_39h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kraxx"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kraxx"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kraxx"));
		}

		// ------------------------------------------ HERO - PRIEST
		// [LOOTA_BOSS_40h] Seriona (*) - COST:0 [ATK:0/HP:20] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>A twilight dragon
		//       bent on draining
		//       your minions.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 47260
		// - 793 = 1544
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Seriona_LOOTA_BOSS_40h()
		{
			// TODO Seriona_LOOTA_BOSS_40h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Seriona"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Seriona"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Seriona"));
		}

		// ----------------------------------------- HERO - WARRIOR
		// [LOOTA_BOSS_41h] Whompwhisker (*) - COST:0 [ATK:0/HP:40] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>A kobold berserker who never fights alone.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 47302
		// - 793 = 1545
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Whompwhisker_LOOTA_BOSS_41h()
		{
			// TODO Whompwhisker_LOOTA_BOSS_41h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Whompwhisker"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Whompwhisker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Whompwhisker"));
		}

		// ------------------------------------------- HERO - DRUID
		// [LOOTA_BOSS_42h] Elder Jari (*) - COST:0 [ATK:0/HP:30] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>This furbolg elder
		//       calls arcane energies to her defense.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 47304
		// - 793 = 1546
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ElderJari_LOOTA_BOSS_42h()
		{
			// TODO ElderJari_LOOTA_BOSS_42h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Elder Jari"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Elder Jari"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Elder Jari"));
		}

		// ------------------------------------------- HERO - DRUID
		// [LOOTA_BOSS_43h] Jeeru (*) - COST:0 [ATK:0/HP:40] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>Don't rub the lamp! You rubbed the lamp, didn't you?</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 47306
		// - 793 = 1547
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Jeeru_LOOTA_BOSS_43h()
		{
			// TODO Jeeru_LOOTA_BOSS_43h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Jeeru"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jeeru"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Jeeru"));
		}

		// ------------------------------------------ HERO - HUNTER
		// [LOOTA_BOSS_44h] Wee Whelp (*) - COST:0 [ATK:0/HP:10] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>It's just a baby dragon. But it's still a dragon.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 47308
		// - 793 = 1548
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WeeWhelp_LOOTA_BOSS_44h()
		{
			// TODO WeeWhelp_LOOTA_BOSS_44h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wee Whelp"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wee Whelp"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wee Whelp"));
		}

		// ------------------------------------------- HERO - ROGUE
		// [LOOTA_BOSS_45h] Bink the Burglar (*) - COST:0 [ATK:0/HP:10] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>This low-down thief preys on starting adventurers.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 47315
		// - 793 = 1549
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BinkTheBurglar_LOOTA_BOSS_45h()
		{
			// TODO BinkTheBurglar_LOOTA_BOSS_45h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bink the Burglar"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bink the Burglar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bink the Burglar"));
		}

		// ------------------------------------------ HERO - SHAMAN
		// [LOOTA_BOSS_46h] Fungalmancer Flurgl (*) - COST:0 [ATK:0/HP:30] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>The fungalmancer empowers his friends. With fungus.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 47319
		// - 793 = 1550
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FungalmancerFlurgl_LOOTA_BOSS_46h()
		{
			// TODO FungalmancerFlurgl_LOOTA_BOSS_46h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fungalmancer Flurgl"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fungalmancer Flurgl"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fungalmancer Flurgl"));
		}

		// ------------------------------------------ HERO - SHAMAN
		// [LOOTA_BOSS_47h] Lava-Filled Chamber (*) - COST:0 [ATK:0/HP:50] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>The kobolds attempted to board up this lava-filled chamber!</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 47321
		// - 793 = 1551
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LavaFilledChamber_LOOTA_BOSS_47h()
		{
			// TODO LavaFilledChamber_LOOTA_BOSS_47h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lava-Filled Chamber"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lava-Filled Chamber"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lava-Filled Chamber"));
		}

		// ------------------------------------------ HERO - HUNTER
		// [LOOTA_BOSS_48h] Trapped Room (*) - COST:0 [ATK:0/HP:40] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>Tread carefully. Don't... touch... anything!</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 47327
		// - 793 = 1553
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TrappedRoom_LOOTA_BOSS_48h()
		{
			// TODO TrappedRoom_LOOTA_BOSS_48h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Trapped Room"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Trapped Room"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Trapped Room"));
		}

		// ------------------------------------------ HERO - PRIEST
		// [LOOTA_BOSS_49h] The Darkness (*) - COST:0 [ATK:0/HP:70] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>There's a reason to always keep a light on down here.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 47332
		// - 793 = 1552
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheDarkness_LOOTA_BOSS_49h()
		{
			// TODO TheDarkness_LOOTA_BOSS_49h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Darkness"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Darkness"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Darkness"));
		}

		// ------------------------------------------ HERO - PRIEST
		// [LOOTA_BOSS_50h] Mushhuckster Max (*) - COST:0 [ATK:0/HP:40] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>You probably don't want the potions
		//       he's hocking.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 47360
		// - 793 = 1555
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MushhucksterMax_LOOTA_BOSS_50h()
		{
			// TODO MushhucksterMax_LOOTA_BOSS_50h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mushhuckster Max"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mushhuckster Max"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mushhuckster Max"));
		}

		// ------------------------------------------- HERO - ROGUE
		// [LOOTA_BOSS_51h] Russell the Bard (*) - COST:0 [ATK:0/HP:30] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>His tunes are catchy. Just ask your minions.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 47363
		// - 793 = 1556
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RussellTheBard_LOOTA_BOSS_51h()
		{
			// TODO RussellTheBard_LOOTA_BOSS_51h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Russell the Bard"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Russell the Bard"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Russell the Bard"));
		}

		// ------------------------------------------- HERO - ROGUE
		// [LOOTA_BOSS_52h] Treasure Vault (*) - COST:0 [ATK:0/HP:60] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>Grab all you can, as fast as you can!</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 47464
		// - HIDE_STATS = 1
		// - APPEAR_FUNCTIONALLY_DEAD = 1
		// - 793 = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TreasureVault_LOOTA_BOSS_52h()
		{
			// TODO TreasureVault_LOOTA_BOSS_52h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Treasure Vault"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Treasure Vault"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Treasure Vault"));
		}

		// -------------------------------------------- HERO - MAGE
		// [LOOTA_BOSS_53h] Chronomancer Inara (*) - COST:0 [ATK:0/HP:50] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>Once she powers
		//       up, beware of her
		//       mastery of time!</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 47474
		// - 793 = 1470
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ChronomancerInara_LOOTA_BOSS_53h()
		{
			// TODO ChronomancerInara_LOOTA_BOSS_53h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Chronomancer Inara"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chronomancer Inara"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Chronomancer Inara"));
		}

		// -------------------------------------------- HERO - MAGE
		// [LOOTA_BOSS_53h2] Inara the Mage (*) - COST:0 [ATK:0/HP:50] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 47474
		// - 793 = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void InaraTheMage_LOOTA_BOSS_53h2()
		{
			// TODO InaraTheMage_LOOTA_BOSS_53h2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Inara the Mage"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Inara the Mage"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Inara the Mage"));
		}

		// ----------------------------------------- HERO - PALADIN
		// [LOOTA_BOSS_54h] A. F. Kay (*) - COST:0 [ATK:0/HP:40] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>Waylay this adventurer while she isn't
		//       paying attention!</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 47494
		// - 793 = 1572
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AFKay_LOOTA_BOSS_54h()
		{
			// TODO AFKay_LOOTA_BOSS_54h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("A. F. Kay"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("A. F. Kay"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "A. F. Kay"));
		}

		// ------------------------------------------- HERO - ROGUE
		// [LOOTA_BOSS_99h] King Togwaggle (*) - COST:0 [ATK:0/HP:70] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <i>Look out! He's loaded with loot from failed adventurers.</i>
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 47209
		// - 793 = 1569
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KingTogwaggle_LOOTA_BOSS_99h()
		{
			// TODO KingTogwaggle_LOOTA_BOSS_99h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("King Togwaggle"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("King Togwaggle"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "King Togwaggle"));
		}

	}

	public class HeroPowersLootapaloozaTest
	{
		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_04p] Sculpt Wax (*) - COST:1 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 1/1 copy of a minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SculptWax_LOOTA_BOSS_04p()
		{
			// TODO SculptWax_LOOTA_BOSS_04p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sculpt Wax"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sculpt Wax"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sculpt Wax"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_05p] Unstable Explosion (*) - COST:1 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 1 damage to two random enemies.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnstableExplosion_LOOTA_BOSS_05p()
		{
			// TODO UnstableExplosion_LOOTA_BOSS_05p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unstable Explosion"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unstable Explosion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Unstable Explosion"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_06p] Evolvomancy (*) - COST:0 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Transform a minion into a random one that costs (1) more.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Evolvomancy_LOOTA_BOSS_06p()
		{
			// TODO Evolvomancy_LOOTA_BOSS_06p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Evolvomancy"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Evolvomancy"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Evolvomancy"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_09p] Freeze (*) - COST:2 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       <b>Freeze</b> a minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_ENEMY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Freeze_LOOTA_BOSS_09p()
		{
			// TODO Freeze_LOOTA_BOSS_09p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Freeze"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Freeze"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Freeze"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_10p] Light's Will (*) - COST:0 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Restore 2 Health to all minions.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LightsWill_LOOTA_BOSS_10p()
		{
			// TODO LightsWill_LOOTA_BOSS_10p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Light's Will"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Light's Will"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Light's Will"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_11p] Cruel Words (*) - COST:1 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 1 damage to a friendly minion and give it +2 Attack.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CruelWords_LOOTA_BOSS_11p()
		{
			// TODO CruelWords_LOOTA_BOSS_11p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cruel Words"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cruel Words"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cruel Words"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_12p] Charge! (*) - COST:1 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Give a minion <b>Charge</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Charge_LOOTA_BOSS_12p()
		{
			// TODO Charge_LOOTA_BOSS_12p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Charge!"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Charge!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Charge!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_13p] Tactical Retreat (*) - COST:1 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Return a friendly minion to your hand.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TacticalRetreat_LOOTA_BOSS_13p()
		{
			// TODO TacticalRetreat_LOOTA_BOSS_13p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tactical Retreat"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tactical Retreat"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tactical Retreat"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_15p] Divinity (*) - COST:2 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Give all your minions <b>Divine Shield</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Divinity_LOOTA_BOSS_15p()
		{
			// TODO Divinity_LOOTA_BOSS_15p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Divinity"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Divinity"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Divinity"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_16p] Totem of the Dead (*) - COST:0 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       All <b>Deathrattles</b> trigger twice.
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TotemOfTheDead_LOOTA_BOSS_16p()
		{
			// TODO TotemOfTheDead_LOOTA_BOSS_16p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Totem of the Dead"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Totem of the Dead"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Totem of the Dead"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_17p] Battle Totem (*) - COST:0 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       All <b>Battlecries</b> trigger twice.
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BattleTotem_LOOTA_BOSS_17p()
		{
			// TODO BattleTotem_LOOTA_BOSS_17p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Battle Totem"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Battle Totem"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Battle Totem"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_18p] Rat Race (*) - COST:2 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon two 1/1 Rats.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RatRace_LOOTA_BOSS_18p()
		{
			// TODO RatRace_LOOTA_BOSS_18p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rat Race"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rat Race"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rat Race"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_19p] Digest Magic (*) - COST:0 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: [x]<b>Passive Hero Power</b>
		//       Whenever your
		//        opponent casts a spell,
		//       summon a Tunnel Trogg.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DigestMagic_LOOTA_BOSS_19p()
		{
			// TODO DigestMagic_LOOTA_BOSS_19p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Digest Magic"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Digest Magic"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Digest Magic"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_20p] Dispel Ward (*) - COST:5 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       <b>Silence</b> your minions.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DispelWard_LOOTA_BOSS_20p()
		{
			// TODO DispelWard_LOOTA_BOSS_20p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dispel Ward"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dispel Ward"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dispel Ward"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_21p] Swallow Whole (*) - COST:2 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Destroy the minion with the highest Attack.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SwallowWhole_LOOTA_BOSS_21p()
		{
			// TODO SwallowWhole_LOOTA_BOSS_21p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Swallow Whole"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Swallow Whole"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Swallow Whole"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_22p] Catch and Release (*) - COST:0 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a random minion from your deck.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CatchAndRelease_LOOTA_BOSS_22p()
		{
			// TODO CatchAndRelease_LOOTA_BOSS_22p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Catch and Release"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Catch and Release"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Catch and Release"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_23p] Hunter's Call (*) - COST:3 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Reduce the Cost of cards in your hand by (1).
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HuntersCall_LOOTA_BOSS_23p()
		{
			// TODO HuntersCall_LOOTA_BOSS_23p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hunter's Call"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hunter's Call"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hunter's Call"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_24p] Gloop (*) - COST:2 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Give minions in your hand +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Gloop_LOOTA_BOSS_24p()
		{
			// TODO Gloop_LOOTA_BOSS_24p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gloop"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gloop"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gloop"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_25p] Vindictive Breath (*) - COST:0 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 1 damage to all enemies for each missing Master Chest.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VindictiveBreath_LOOTA_BOSS_25p()
		{
			// TODO VindictiveBreath_LOOTA_BOSS_25p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Vindictive Breath"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vindictive Breath"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Vindictive Breath"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_26p8] Beam Me Up! (*) - COST:0 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//        At the end of your turn, add a <b>Beam</b> to your_hand.
		// --------------------------------------------------------
		// Entourage: LOOTA_BOSS_26p2, LOOTA_BOSS_26p3, LOOTA_BOSS_26p4, LOOTA_BOSS_26p5, LOOTA_BOSS_26p6, LOOTA_BOSS_26p7
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BeamMeUp_LOOTA_BOSS_26p8()
		{
			// TODO BeamMeUp_LOOTA_BOSS_26p8 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Beam Me Up!"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Beam Me Up!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Beam Me Up!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_27p] Harden Sculpture (*) - COST:3 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a copy of a minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HardenSculpture_LOOTA_BOSS_27p()
		{
			// TODO HardenSculpture_LOOTA_BOSS_27p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Harden Sculpture"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Harden Sculpture"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Harden Sculpture"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_28p] Unstable Demolition (*) - COST:2 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 2 damage to three random enemies.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnstableDemolition_LOOTA_BOSS_28p()
		{
			// TODO UnstableDemolition_LOOTA_BOSS_28p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unstable Demolition"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unstable Demolition"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Unstable Demolition"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_29p] Greater Evolution (*) - COST:1 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Transform a minion into a random one that costs (3) more.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GreaterEvolution_LOOTA_BOSS_29p()
		{
			// TODO GreaterEvolution_LOOTA_BOSS_29p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Greater Evolution"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Greater Evolution"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Greater Evolution"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_30p] Searing Lash (*) - COST:1 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 1 damage to a friendly minion and give it +5 Attack.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SearingLash_LOOTA_BOSS_30p()
		{
			// TODO SearingLash_LOOTA_BOSS_30p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Searing Lash"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Searing Lash"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Searing Lash"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_31p] Charrrrrge! (*) - COST:0 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       After you play a minion, give it <b>Charge</b>.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Charrrrrge_LOOTA_BOSS_31p()
		{
			// TODO Charrrrrge_LOOTA_BOSS_31p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Charrrrrge!"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Charrrrrge!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Charrrrrge!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_33p] Metabolized Magic (*) - COST:0 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Whenever your opponent casts a spell, draw a card. It costs (1).
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MetabolizedMagic_LOOTA_BOSS_33p()
		{
			// TODO MetabolizedMagic_LOOTA_BOSS_33p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Metabolized Magic"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Metabolized Magic"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Metabolized Magic"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_34p] Devour (*) - COST:0 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Remove the top
		//       2 cards of your opponent's_deck.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Devour_LOOTA_BOSS_34p()
		{
			// TODO Devour_LOOTA_BOSS_34p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Devour"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Devour"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Devour"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_35p] Dampen Magic (*) - COST:2 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Put a 'Counterspell' <b>Secret</b> into the battlefield.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DampenMagic_LOOTA_BOSS_35p()
		{
			// TODO DampenMagic_LOOTA_BOSS_35p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dampen Magic"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dampen Magic"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dampen Magic"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_36p] Sprouting Spore (*) - COST:2 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon an <b><i>extremely</i></b>
		//       Deadly_Spore.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SproutingSpore_LOOTA_BOSS_36p()
		{
			// TODO SproutingSpore_LOOTA_BOSS_36p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sprouting Spore"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sprouting Spore"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sprouting Spore"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_37p] Arcane Infusion (*) - COST:1 [ATK:1/HP:0] 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Add 'Arcane Missiles' to your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArcaneInfusion_LOOTA_BOSS_37p()
		{
			// TODO ArcaneInfusion_LOOTA_BOSS_37p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arcane Infusion"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Infusion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Arcane Infusion"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_38p] Totem of Chaos (*) - COST:0 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       All <b>Battlecries</b> and <b>Deathrattles</b> trigger twice.
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TotemOfChaos_LOOTA_BOSS_38p()
		{
			// TODO TotemOfChaos_LOOTA_BOSS_38p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Totem of Chaos"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Totem of Chaos"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Totem of Chaos"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_39p] Giant Stomp (*) - COST:2 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 1 damage to all enemy minions.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GiantStomp_LOOTA_BOSS_39p()
		{
			// TODO GiantStomp_LOOTA_BOSS_39p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Giant Stomp"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Giant Stomp"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Giant Stomp"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_40p] Fading Light (*) - COST:2 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Give a minion -1_Attack.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_ENEMY_TARGET = 0
		// - REQ_TARGET_MIN_ATTACK = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FadingLight_LOOTA_BOSS_40p()
		{
			// TODO FadingLight_LOOTA_BOSS_40p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fading Light"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fading Light"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fading Light"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_41p] Join the Fray (*) - COST:2 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Both players <b>Recruit</b> a_minion.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		// RefTag:
		// - RECRUIT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JoinTheFray_LOOTA_BOSS_41p()
		{
			// TODO JoinTheFray_LOOTA_BOSS_41p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Join the Fray"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Join the Fray"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Join the Fray"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_42p] Mystic Barrier (*) - COST:1 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Gain 3 Armor.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MysticBarrier_LOOTA_BOSS_42p()
		{
			// TODO MysticBarrier_LOOTA_BOSS_42p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mystic Barrier"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mystic Barrier"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mystic Barrier"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_43p] Three Wee Wishes (*) - COST:1 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Each player draws 3 cards.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ThreeWeeWishes_LOOTA_BOSS_43p()
		{
			// TODO ThreeWeeWishes_LOOTA_BOSS_43p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Three Wee Wishes"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Three Wee Wishes"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Three Wee Wishes"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_44p] Baby Breath (*) - COST:2 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 2 damage.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BabyBreath_LOOTA_BOSS_44p()
		{
			// TODO BabyBreath_LOOTA_BOSS_44p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Baby Breath"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Baby Breath"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Baby Breath"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_45p] Coin (*) - COST:0 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Gain 1 Mana Crystal this turn only.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Coin_LOOTA_BOSS_45p()
		{
			// TODO Coin_LOOTA_BOSS_45p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Coin"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Coin"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Coin"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_46p] Fungal Infection (*) - COST:2 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Give your minions +1/+1.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FungalInfection_LOOTA_BOSS_46p()
		{
			// TODO FungalInfection_LOOTA_BOSS_46p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fungal Infection"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fungal Infection"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fungal Infection"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_47p] The Floor is Lava (*) - COST:0 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       After a minion is played, deal 2 damage to_it.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheFloorIsLava_LOOTA_BOSS_47p()
		{
			// TODO TheFloorIsLava_LOOTA_BOSS_47p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Floor is Lava"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Floor is Lava"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Floor is Lava"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_48p] Alarm (*) - COST:0 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Whenever you reveal a <b>Secret</b>, summon a 3/3 Sawblade.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Alarm_LOOTA_BOSS_48p()
		{
			// TODO Alarm_LOOTA_BOSS_48p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Alarm"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Alarm"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Alarm"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_49p] Encroaching Darkness (*) - COST:0 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 5/5 Darkspawn.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EncroachingDarkness_LOOTA_BOSS_49p()
		{
			// TODO EncroachingDarkness_LOOTA_BOSS_49p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Encroaching Darkness"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Encroaching Darkness"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Encroaching Darkness"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_50p] Mushroom, Mushroom (*) - COST:2 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Craft a custom Mushroom Potion.
		// --------------------------------------------------------
		// Entourage: CFM_621t11
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MushroomMushroom_LOOTA_BOSS_50p()
		{
			// TODO MushroomMushroom_LOOTA_BOSS_50p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mushroom, Mushroom"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mushroom, Mushroom"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mushroom, Mushroom"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_51p] Alluring Tune (*) - COST:2 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Gain control of an enemy_minion with 2 or less Attack.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_ENEMY_TARGET = 0
		// - REQ_TARGET_MAX_ATTACK = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AlluringTune_LOOTA_BOSS_51p()
		{
			// TODO AlluringTune_LOOTA_BOSS_51p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Alluring Tune"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Alluring Tune"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Alluring Tune"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_52p] Doors Are Closing (*) - COST:5 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       End the game.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DoorsAreClosing_LOOTA_BOSS_52p()
		{
			// TODO DoorsAreClosing_LOOTA_BOSS_52p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Doors Are Closing"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Doors Are Closing"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Doors Are Closing"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_53p] Stolen Time (*) - COST:10 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Destroy 3 of your Mana_Crystals.
		//       Take an extra turn.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StolenTime_LOOTA_BOSS_53p()
		{
			// TODO StolenTime_LOOTA_BOSS_53p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stolen Time"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stolen Time"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stolen Time"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_54p] Idle (*) - COST:2 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Do nothing.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Idle_LOOTA_BOSS_54p()
		{
			// TODO Idle_LOOTA_BOSS_54p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Idle"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Idle"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Idle"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOOTA_BOSS_99p] Magic Candle (*) - COST:3 
		// - Set: lootapalooza, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Find a Treasure!
		// --------------------------------------------------------
		// Entourage: LOOTA_819, LOOTA_821, LOOTA_835, LOOTA_842b, LOOTA_806, LOOTA_812, LOOTA_823, LOOTA_847, LOOTA_836, LOOTA_839, LOOTA_816, LOOTA_827, LOOTA_843, LOOTA_826, LOOT_998k, LOOTA_838
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MagicCandle_LOOTA_BOSS_99p()
		{
			// TODO MagicCandle_LOOTA_BOSS_99p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Magic Candle"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Magic Candle"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Magic Candle"));
		}

	}

}
