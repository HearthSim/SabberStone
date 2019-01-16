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
	public class HeroesLoeTest
	{
		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA01_01] Sun Raider Phaerix (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 14019
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SunRaiderPhaerix_LOEA01_01()
		{
			// TODO SunRaiderPhaerix_LOEA01_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sun Raider Phaerix"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sun Raider Phaerix"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sun Raider Phaerix"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA01_01h] Sun Raider Phaerix (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 38479
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SunRaiderPhaerix_LOEA01_01h()
		{
			// TODO SunRaiderPhaerix_LOEA01_01h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sun Raider Phaerix"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sun Raider Phaerix"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sun Raider Phaerix"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA02_01] Zinaar (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 14203
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Zinaar_LOEA02_01()
		{
			// TODO Zinaar_LOEA02_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Zinaar"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Zinaar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Zinaar"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA02_01h] Zinaar (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 38465
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Zinaar_LOEA02_01h()
		{
			// TODO Zinaar_LOEA02_01h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Zinaar"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Zinaar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Zinaar"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA04_01] Temple Escape (*) - COST:0 [ATK:0/HP:100] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 16231
		// - APPEAR_FUNCTIONALLY_DEAD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TempleEscape_LOEA04_01()
		{
			// TODO TempleEscape_LOEA04_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Temple Escape"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Temple Escape"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Temple Escape"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA04_01h] Temple Escape (*) - COST:0 [ATK:0/HP:100] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 38510
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TempleEscape_LOEA04_01h()
		{
			// TODO TempleEscape_LOEA04_01h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Temple Escape"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Temple Escape"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Temple Escape"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA05_01] Chieftain Scarvash (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 15353
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ChieftainScarvash_LOEA05_01()
		{
			// TODO ChieftainScarvash_LOEA05_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Chieftain Scarvash"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chieftain Scarvash"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Chieftain Scarvash"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA05_01h] Chieftain Scarvash (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 38555
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ChieftainScarvash_LOEA05_01h()
		{
			// TODO ChieftainScarvash_LOEA05_01h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Chieftain Scarvash"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chieftain Scarvash"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Chieftain Scarvash"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA07_01] Mine Cart (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MineCart_LOEA07_01()
		{
			// TODO MineCart_LOEA07_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mine Cart"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mine Cart"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mine Cart"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA07_02] Mine Shaft (*) - COST:0 [ATK:0/HP:80] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 16205
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MineShaft_LOEA07_02()
		{
			// TODO MineShaft_LOEA07_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mine Shaft"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mine Shaft"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mine Shaft"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA07_02h] Mine Shaft (*) - COST:0 [ATK:0/HP:80] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 38676
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MineShaft_LOEA07_02h()
		{
			// TODO MineShaft_LOEA07_02h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mine Shaft"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mine Shaft"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mine Shaft"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA08_01] Archaedas (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 17145
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Archaedas_LOEA08_01()
		{
			// TODO Archaedas_LOEA08_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Archaedas"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Archaedas"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Archaedas"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA08_01h] Archaedas (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 38588
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Archaedas_LOEA08_01h()
		{
			// TODO Archaedas_LOEA08_01h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Archaedas"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Archaedas"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Archaedas"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA09_1] Lord Slitherspear (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 24427
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LordSlitherspear_LOEA09_1()
		{
			// TODO LordSlitherspear_LOEA09_1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lord Slitherspear"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lord Slitherspear"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lord Slitherspear"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA09_1H] Lord Slitherspear (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 38609
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LordSlitherspear_LOEA09_1H()
		{
			// TODO LordSlitherspear_LOEA09_1H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lord Slitherspear"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lord Slitherspear"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lord Slitherspear"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA10_1] Giantfin (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 10045
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Giantfin_LOEA10_1()
		{
			// TODO Giantfin_LOEA10_1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Giantfin"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Giantfin"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Giantfin"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA10_1H] Giantfin (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 38617
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Giantfin_LOEA10_1H()
		{
			// TODO Giantfin_LOEA10_1H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Giantfin"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Giantfin"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Giantfin"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA12_1] Lady Naz'jar (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 17193
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LadyNazjar_LOEA12_1()
		{
			// TODO LadyNazjar_LOEA12_1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lady Naz'jar"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lady Naz'jar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lady Naz'jar"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA12_1H] Lady Naz'jar (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 38620
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LadyNazjar_LOEA12_1H()
		{
			// TODO LadyNazjar_LOEA12_1H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lady Naz'jar"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lady Naz'jar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lady Naz'jar"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA13_1] Skelesaurus Hex (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 19795
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SkelesaurusHex_LOEA13_1()
		{
			// TODO SkelesaurusHex_LOEA13_1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Skelesaurus Hex"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Skelesaurus Hex"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Skelesaurus Hex"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA13_1h] Skelesaurus Hex (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 38705
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SkelesaurusHex_LOEA13_1h()
		{
			// TODO SkelesaurusHex_LOEA13_1h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Skelesaurus Hex"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Skelesaurus Hex"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Skelesaurus Hex"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA14_1] The Steel Sentinel (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 19117
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheSteelSentinel_LOEA14_1()
		{
			// TODO TheSteelSentinel_LOEA14_1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Steel Sentinel"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Steel Sentinel"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Steel Sentinel"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA14_1H] The Steel Sentinel (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 38708
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheSteelSentinel_LOEA14_1H()
		{
			// TODO TheSteelSentinel_LOEA14_1H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Steel Sentinel"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Steel Sentinel"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Steel Sentinel"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA15_1] Rafaam (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 19292
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Rafaam_LOEA15_1()
		{
			// TODO Rafaam_LOEA15_1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rafaam"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rafaam"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rafaam"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA15_1H] Rafaam (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 38710
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Rafaam_LOEA15_1H()
		{
			// TODO Rafaam_LOEA15_1H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rafaam"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rafaam"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rafaam"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA16_1] Rafaam (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// Entourage: LOEA16_18, LOEA16_23, LOEA16_19, LOEA16_22, LOEA16_21, LOEA16_24, LOEA16_25, LOEA16_26, LOEA16_27
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 19613
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Rafaam_LOEA16_1()
		{
			// TODO Rafaam_LOEA16_1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rafaam"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rafaam"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rafaam"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA16_1H] Rafaam (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// Entourage: LOEA16_18H, LOEA16_19H, LOEA16_21H, LOEA16_22H, LOEA16_23H, LOEA16_24H, LOEA16_25H, LOEA16_26H, LOEA16_27H
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 38712
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Rafaam_LOEA16_1H()
		{
			// TODO Rafaam_LOEA16_1H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rafaam"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rafaam"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rafaam"));
		}

	}

	public class HeroPowersLoeTest
	{
		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA01_02] Blessings of the Sun (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Whoever controls the Rod of the Sun is <b>Immune.</b>
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BlessingsOfTheSun_LOEA01_02()
		{
			// TODO BlessingsOfTheSun_LOEA01_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blessings of the Sun"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blessings of the Sun"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blessings of the Sun"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA01_02h] Blessings of the Sun (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//        Phaerix is <b>Immune</b> while he controls the Rod of the Sun.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BlessingsOfTheSun_LOEA01_02h()
		{
			// TODO BlessingsOfTheSun_LOEA01_02h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blessings of the Sun"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blessings of the Sun"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blessings of the Sun"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA02_02] Djinn’s Intuition (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: Draw a card.
		//       Give your opponent a Wish.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DjinnsIntuition_LOEA02_02()
		{
			// TODO DjinnsIntuition_LOEA02_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Djinn’s Intuition"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Djinn’s Intuition"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Djinn’s Intuition"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA02_02h] Djinn’s Intuition (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: Draw a card. Gain a Mana Crystal. Give your opponent a Wish.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DjinnsIntuition_LOEA02_02h()
		{
			// TODO DjinnsIntuition_LOEA02_02h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Djinn’s Intuition"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Djinn’s Intuition"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Djinn’s Intuition"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA04_02] Escape! (*) - COST:0 
		// - Set: loe, Rarity: free
		// --------------------------------------------------------
		// Text: Encounter new obstacles!
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Escape_LOEA04_02()
		{
			// TODO Escape_LOEA04_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Escape!"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Escape!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Escape!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA04_02h] Escape! (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: Encounter new obstacles!
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Escape_LOEA04_02h()
		{
			// TODO Escape_LOEA04_02h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Escape!"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Escape!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Escape!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA05_02] Trogg Hate Minions! (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//        Enemy minions cost (2) more. Swap at the start of your turn.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TroggHateMinions_LOEA05_02()
		{
			// TODO TroggHateMinions_LOEA05_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Trogg Hate Minions!"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Trogg Hate Minions!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Trogg Hate Minions!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA05_02a] Trogg Hate Minions! (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//        Enemy minions cost (2) more. Swap at the start of your turn.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TroggHateMinions_LOEA05_02a()
		{
			// TODO TroggHateMinions_LOEA05_02a test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Trogg Hate Minions!"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Trogg Hate Minions!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Trogg Hate Minions!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA05_02h] Trogg Hate Minions! (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//        Enemy minions cost (11). Swap at the start of your turn.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TroggHateMinions_LOEA05_02h()
		{
			// TODO TroggHateMinions_LOEA05_02h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Trogg Hate Minions!"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Trogg Hate Minions!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Trogg Hate Minions!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA05_02ha] Trogg Hate Minions! (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//        Enemy minions cost (11). Swap at the start of your turn.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TroggHateMinions_LOEA05_02ha()
		{
			// TODO TroggHateMinions_LOEA05_02ha test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Trogg Hate Minions!"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Trogg Hate Minions!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Trogg Hate Minions!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA05_03] Trogg Hate Spells! (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//        Enemy spells cost (2) more. Swap at the start of your turn.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TroggHateSpells_LOEA05_03()
		{
			// TODO TroggHateSpells_LOEA05_03 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Trogg Hate Spells!"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Trogg Hate Spells!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Trogg Hate Spells!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA05_03h] Trogg Hate Spells! (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//        Enemy spells cost (11). Swap at the start of your turn.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TroggHateSpells_LOEA05_03h()
		{
			// TODO TroggHateSpells_LOEA05_03h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Trogg Hate Spells!"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Trogg Hate Spells!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Trogg Hate Spells!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA06_02] Stonesculpting (*) - COST:1 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//        Summon a 0/2 Statue for both players.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Stonesculpting_LOEA06_02()
		{
			// TODO Stonesculpting_LOEA06_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stonesculpting"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonesculpting"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stonesculpting"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA06_02h] Stonesculpting (*) - COST:1 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//        Summon a Statue for both players.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Stonesculpting_LOEA06_02h()
		{
			// TODO Stonesculpting_LOEA06_02h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stonesculpting"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonesculpting"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stonesculpting"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA07_03] Flee the Mine! (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: Escape the Troggs!
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FleeTheMine_LOEA07_03()
		{
			// TODO FleeTheMine_LOEA07_03 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Flee the Mine!"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flee the Mine!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Flee the Mine!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA07_03h] Flee the Mine! (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: Escape the Troggs!
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FleeTheMine_LOEA07_03h()
		{
			// TODO FleeTheMine_LOEA07_03h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Flee the Mine!"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flee the Mine!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Flee the Mine!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA07_29] Throw Rocks (*) - COST:1 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//        Deal 3 damage to a random enemy minion.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ThrowRocks_LOEA07_29()
		{
			// TODO ThrowRocks_LOEA07_29 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Throw Rocks"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Throw Rocks"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Throw Rocks"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA09_2] Enraged! (*) - COST:2 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: Give your hero +2 attack this turn.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Enraged_LOEA09_2()
		{
			// TODO Enraged_LOEA09_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Enraged!"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Enraged!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Enraged!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA09_2H] Enraged! (*) - COST:2 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: Give your hero +5 attack this turn.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Enraged_LOEA09_2H()
		{
			// TODO Enraged_LOEA09_2H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Enraged!"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Enraged!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Enraged!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA09_3] Getting Hungry (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a Hungry Naga.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GettingHungry_LOEA09_3()
		{
			// TODO GettingHungry_LOEA09_3 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Getting Hungry"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Getting Hungry"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Getting Hungry"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA09_3b] Getting Hungry (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 1/1 Hungry Naga.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GettingHungry_LOEA09_3b()
		{
			// TODO GettingHungry_LOEA09_3b test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Getting Hungry"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Getting Hungry"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Getting Hungry"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA09_3c] Getting Hungry (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 2/1 Hungry Naga.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GettingHungry_LOEA09_3c()
		{
			// TODO GettingHungry_LOEA09_3c test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Getting Hungry"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Getting Hungry"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Getting Hungry"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA09_3d] Getting Hungry (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 5/1 Hungry Naga.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GettingHungry_LOEA09_3d()
		{
			// TODO GettingHungry_LOEA09_3d test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Getting Hungry"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Getting Hungry"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Getting Hungry"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA09_3H] Endless Hunger (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a Hungry Naga.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EndlessHunger_LOEA09_3H()
		{
			// TODO EndlessHunger_LOEA09_3H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Endless Hunger"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Endless Hunger"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Endless Hunger"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA10_2] Mrglmrgl MRGL! (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Draw cards until you have as many in hand as your opponent.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MrglmrglMrgl_LOEA10_2()
		{
			// TODO MrglmrglMrgl_LOEA10_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mrglmrgl MRGL!"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mrglmrgl MRGL!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mrglmrgl MRGL!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA10_2H] Mrglmrgl MRGL! (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Draw 2 cards.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MrglmrglMrgl_LOEA10_2H()
		{
			// TODO MrglmrglMrgl_LOEA10_2H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mrglmrgl MRGL!"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mrglmrgl MRGL!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mrglmrgl MRGL!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA12_2] Pearl of the Tides (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: At the end of your turn, replace all minions with new ones that cost (1) more.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PearlOfTheTides_LOEA12_2()
		{
			// TODO PearlOfTheTides_LOEA12_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Pearl of the Tides"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pearl of the Tides"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Pearl of the Tides"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA12_2H] Pearl of the Tides (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: At the end of your turn, replace all minions with new ones. Yours cost (1) more.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PearlOfTheTides_LOEA12_2H()
		{
			// TODO PearlOfTheTides_LOEA12_2H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Pearl of the Tides"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pearl of the Tides"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Pearl of the Tides"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA13_2] Ancient Power (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Give each player a random card. It costs (0).
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AncientPower_LOEA13_2()
		{
			// TODO AncientPower_LOEA13_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ancient Power"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ancient Power"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ancient Power"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA13_2H] Ancient Power (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Add a random card to your hand. It costs (0).
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AncientPower_LOEA13_2H()
		{
			// TODO AncientPower_LOEA13_2H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ancient Power"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ancient Power"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ancient Power"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA14_2] Platemail Armor (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Your Hero can only take 1 damage at a time.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PlatemailArmor_LOEA14_2()
		{
			// TODO PlatemailArmor_LOEA14_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Platemail Armor"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Platemail Armor"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Platemail Armor"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA14_2H] Platemail Armor (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Your Hero and your minions can only take 1 damage at a time.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PlatemailArmor_LOEA14_2H()
		{
			// TODO PlatemailArmor_LOEA14_2H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Platemail Armor"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Platemail Armor"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Platemail Armor"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA15_2] Unstable Portal (*) - COST:2 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Add a random minion to your hand. It costs (3) less.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnstablePortal_LOEA15_2()
		{
			// TODO UnstablePortal_LOEA15_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unstable Portal"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unstable Portal"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Unstable Portal"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA15_2H] Unstable Portal (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Add a random minion to your hand. It costs (3) less.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnstablePortal_LOEA15_2H()
		{
			// TODO UnstablePortal_LOEA15_2H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unstable Portal"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unstable Portal"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Unstable Portal"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA16_16] Rummage (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: Find an artifact.
		// --------------------------------------------------------
		// Entourage: LOEA16_10, LOEA16_11, LOEA16_14, LOEA16_15, LOEA16_6, LOEA16_7, LOEA16_9, LOEA16_12, LOEA16_13, LOEA16_8
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Rummage_LOEA16_16()
		{
			// TODO Rummage_LOEA16_16 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rummage"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rummage"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rummage"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA16_16H] Rummage (*) - COST:2 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: Find an artifact.
		// --------------------------------------------------------
		// Entourage: LOEA16_10, LOEA16_11, LOEA16_14, LOEA16_15, LOEA16_6, LOEA16_7, LOEA16_9, LOEA16_12, LOEA16_13, LOEA16_8
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Rummage_LOEA16_16H()
		{
			// TODO Rummage_LOEA16_16H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rummage"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rummage"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rummage"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA16_2] Staff of Origination (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Your hero is <b>Immune</b> while the staff charges.
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StaffOfOrigination_LOEA16_2()
		{
			// TODO StaffOfOrigination_LOEA16_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Staff of Origination"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Staff of Origination"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Staff of Origination"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA16_2H] Staff of Origination (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Your hero is <b>Immune</b>.
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StaffOfOrigination_LOEA16_2H()
		{
			// TODO StaffOfOrigination_LOEA16_2H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Staff of Origination"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Staff of Origination"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Staff of Origination"));
		}

	}

	public class NeutralLoeTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [LOEA10_3] Murloc Tinyfin - COST:0 [ATK:1/HP:1] 
		// - Race: murloc, Set: loe, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MurlocTinyfin_LOEA10_3()
		{
			// TODO MurlocTinyfin_LOEA10_3 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Murloc Tinyfin"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Tinyfin"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Murloc Tinyfin"));
		}

	}

}
