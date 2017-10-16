using Xunit;
using SabberStoneCore.Enums;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Model.Entities;
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

	public class DruidLoeTest
	{
		// ----------------------------------------- MINION - DRUID
		// [LOE_050] Mounted Raptor - COST:3 [ATK:3/HP:2] 
		// - Race: beast, Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a random 1-Cost minion.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MountedRaptor_LOE_050()
		{
			// TODO MountedRaptor_LOE_050 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mounted Raptor"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mounted Raptor"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mounted Raptor"));
		}

		// ----------------------------------------- MINION - DRUID
		// [LOE_051] Jungle Moonkin - COST:4 [ATK:4/HP:4] 
		// - Race: beast, Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: Both players have
		//       <b>Spell Damage +2</b>.
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JungleMoonkin_LOE_051()
		{
			// TODO JungleMoonkin_LOE_051 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Jungle Moonkin"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jungle Moonkin"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Jungle Moonkin"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [LOE_115] Raven Idol - COST:1 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Choose One -</b>
		//       <b>Discover</b> a minion; or <b>Discover</b> a spell.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RavenIdol_LOE_115()
		{
			// TODO RavenIdol_LOE_115 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Raven Idol"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Raven Idol"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Raven Idol"));
		}

	}

	public class HunterLoeTest
	{
		// ---------------------------------------- MINION - HUNTER
		// [LOE_020] Desert Camel - COST:3 [ATK:2/HP:4] 
		// - Race: beast, Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Put a 1-Cost minion from each deck into the battlefield.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DesertCamel_LOE_020()
		{
			// TODO DesertCamel_LOE_020 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Desert Camel"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Desert Camel"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Desert Camel"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [LOE_021] Dart Trap - COST:2 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> After an opposing Hero Power is used, deal $5 damage to a random enemy. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DartTrap_LOE_021()
		{
			// TODO DartTrap_LOE_021 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dart Trap"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dart Trap"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dart Trap"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [LOE_105] Explorer's Hat - COST:2 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: Give a minion +1/+1 and "<b>Deathrattle:</b> Add an Explorer's Hat to your hand."
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ExplorersHat_LOE_105()
		{
			// TODO ExplorersHat_LOE_105 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Explorer's Hat"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Explorer's Hat"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Explorer's Hat"));
		}

	}

	public class MageLoeTest
	{
		// ------------------------------------------ MINION - MAGE
		// [LOE_003] Ethereal Conjurer - COST:5 [ATK:6/HP:3] 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry: Discover</b> a spell.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EtherealConjurer_LOE_003()
		{
			// TODO EtherealConjurer_LOE_003 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ethereal Conjurer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ethereal Conjurer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ethereal Conjurer"));
		}

		// ------------------------------------------ MINION - MAGE
		// [LOE_119] Animated Armor - COST:4 [ATK:4/HP:4] 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: Your hero can only take 1 damage at a time.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AnimatedArmor_LOE_119()
		{
			// TODO AnimatedArmor_LOE_119 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Animated Armor"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Animated Armor"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Animated Armor"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [LOE_002] Forgotten Torch - COST:3 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $3 damage. Shuffle a 'Roaring Torch' into your deck that deals 6 damage. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ForgottenTorch_LOE_002()
		{
			// TODO ForgottenTorch_LOE_002 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Forgotten Torch"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Forgotten Torch"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Forgotten Torch"));
		}

	}

	public class PaladinLoeTest
	{
		// --------------------------------------- MINION - PALADIN
		// [LOE_017] Keeper of Uldaman - COST:4 [ATK:3/HP:4] 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Set a minion's Attack and Health to 3.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KeeperOfUldaman_LOE_017()
		{
			// TODO KeeperOfUldaman_LOE_017 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Keeper of Uldaman"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Keeper of Uldaman"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Keeper of Uldaman"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [LOE_026] Anyfin Can Happen - COST:10 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: Summon 7 Murlocs that died this game.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AnyfinCanHappen_LOE_026()
		{
			// TODO AnyfinCanHappen_LOE_026 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Anyfin Can Happen"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Anyfin Can Happen"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Anyfin Can Happen"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [LOE_027] Sacred Trial - COST:1 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> After your opponent has at least 3 minions and plays another, destroy it.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SacredTrial_LOE_027()
		{
			// TODO SacredTrial_LOE_027 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sacred Trial"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sacred Trial"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sacred Trial"));
		}

	}

	public class PriestLoeTest
	{
		// ---------------------------------------- MINION - PRIEST
		// [LOE_006] Museum Curator - COST:2 [ATK:1/HP:2] 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry: Discover</b> a <b>Deathrattle</b> card.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MuseumCurator_LOE_006()
		{
			// TODO MuseumCurator_LOE_006 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Museum Curator"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Museum Curator"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Museum Curator"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [LOE_104] Entomb - COST:6 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: Choose an enemy minion.
		//       Shuffle it into your deck.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_ENEMY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Entomb_LOE_104()
		{
			// TODO Entomb_LOE_104 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Entomb"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Entomb"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Entomb"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [LOE_111] Excavated Evil - COST:5 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $3 damage to all minions.
		//       Shuffle this card into your opponent's deck. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ExcavatedEvil_LOE_111()
		{
			// TODO ExcavatedEvil_LOE_111 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Excavated Evil"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Excavated Evil"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Excavated Evil"));
		}

	}

	public class RogueLoeTest
	{
		// ----------------------------------------- MINION - ROGUE
		// [LOE_010] Pit Snake - COST:1 [ATK:2/HP:1] 
		// - Race: beast, Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Poisonous</b>
		// --------------------------------------------------------
		// GameTag:
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PitSnake_LOE_010()
		{
			// TODO PitSnake_LOE_010 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Pit Snake"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pit Snake"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Pit Snake"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [LOE_012] Tomb Pillager - COST:4 [ATK:5/HP:4] 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Add a Coin to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TombPillager_LOE_012()
		{
			// TODO TombPillager_LOE_012 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tomb Pillager"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tomb Pillager"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tomb Pillager"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [LOE_019] Unearthed Raptor - COST:3 [ATK:3/HP:4] 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Choose a friendly minion. Gain a copy of its_<b>Deathrattle</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_WITH_DEATHRATTLE = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnearthedRaptor_LOE_019()
		{
			// TODO UnearthedRaptor_LOE_019 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unearthed Raptor"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unearthed Raptor"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Unearthed Raptor"));
		}

	}

	public class ShamanLoeTest
	{
		// ---------------------------------------- MINION - SHAMAN
		// [LOE_016] Rumbling Elemental - COST:4 [ATK:2/HP:6] 
		// - Race: elemental, Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: After you play a <b>Battlecry</b> minion, deal 2 damage to a random enemy.
		// --------------------------------------------------------
		// RefTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RumblingElemental_LOE_016()
		{
			// TODO RumblingElemental_LOE_016 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rumbling Elemental"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rumbling Elemental"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rumbling Elemental"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [LOE_018] Tunnel Trogg - COST:1 [ATK:1/HP:3] 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever you <b>Overload</b>, gain +1 Attack per locked Mana Crystal.
		// --------------------------------------------------------
		// RefTag:
		// - OVERLOAD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TunnelTrogg_LOE_018()
		{
			// TODO TunnelTrogg_LOE_018 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tunnel Trogg"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tunnel Trogg"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tunnel Trogg"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [LOE_113] Everyfin is Awesome - COST:7 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: Give your minions +2/+2.
		//       Costs (1) less for each Murloc you control.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EveryfinIsAwesome_LOE_113()
		{
			// TODO EveryfinIsAwesome_LOE_113 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Everyfin is Awesome"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Everyfin is Awesome"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Everyfin is Awesome"));
		}

	}

	public class WarlockLoeTest
	{
		// --------------------------------------- MINION - WARLOCK
		// [LOE_023] Dark Peddler - COST:2 [ATK:2/HP:2] 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry: Discover</b> a
		//       1-Cost card.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DarkPeddler_LOE_023()
		{
			// TODO DarkPeddler_LOE_023 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dark Peddler"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dark Peddler"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dark Peddler"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [LOE_116] Reliquary Seeker - COST:1 [ATK:1/HP:1] 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you have 6 other minions, gain +4/+4.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ReliquarySeeker_LOE_116()
		{
			// TODO ReliquarySeeker_LOE_116 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Reliquary Seeker"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Reliquary Seeker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Reliquary Seeker"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [LOE_007] Curse of Rafaam - COST:2 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: Give your opponent a 'Cursed!' card.
		//       While they hold it, they take 2 damage on their turn.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CurseOfRafaam_LOE_007()
		{
			// TODO CurseOfRafaam_LOE_007 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Curse of Rafaam"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Curse of Rafaam"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Curse of Rafaam"));
		}

	}

	public class WarriorLoeTest
	{
		// --------------------------------------- MINION - WARRIOR
		// [LOE_009] Obsidian Destroyer - COST:7 [ATK:7/HP:7] 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: At the end of your turn, summon a 1/1 Scarab with <b>Taunt</b>.
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ObsidianDestroyer_LOE_009()
		{
			// TODO ObsidianDestroyer_LOE_009 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Obsidian Destroyer"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Obsidian Destroyer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Obsidian Destroyer"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [LOE_022] Fierce Monkey - COST:3 [ATK:3/HP:4] 
		// - Race: beast, Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FierceMonkey_LOE_022()
		{
			// TODO FierceMonkey_LOE_022 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fierce Monkey"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fierce Monkey"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fierce Monkey"));
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [LOE_118] Cursed Blade - COST:1 [ATK:2/HP:0] 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: Double all damage dealt to your hero.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 3
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CursedBlade_LOE_118()
		{
			// TODO CursedBlade_LOE_118 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cursed Blade"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cursed Blade"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cursed Blade"));
		}

	}

	public class NeutralLoeTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [LOE_011] Reno Jackson - COST:6 [ATK:4/HP:6] 
		// - Set: loe, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your deck has no duplicates, fully heal your hero.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RenoJackson_LOE_011()
		{
			// TODO RenoJackson_LOE_011 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Reno Jackson"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Reno Jackson"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Reno Jackson"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_029] Jeweled Scarab - COST:2 [ATK:1/HP:1] 
		// - Race: beast, Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry: Discover</b> a
		//       3-Cost card.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JeweledScarab_LOE_029()
		{
			// TODO JeweledScarab_LOE_029 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Jeweled Scarab"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jeweled Scarab"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Jeweled Scarab"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_038] Naga Sea Witch - COST:5 [ATK:5/HP:5] 
		// - Set: loe, Rarity: epic
		// --------------------------------------------------------
		// Text: Your cards cost (5).
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NagaSeaWitch_LOE_038()
		{
			// TODO NagaSeaWitch_LOE_038 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Naga Sea Witch"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Naga Sea Witch"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Naga Sea Witch"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_039] Gorillabot A-3 - COST:4 [ATK:3/HP:4] 
		// - Race: mechanical, Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you control another Mech, <b>Discover</b> a Mech.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GorillabotA3_LOE_039()
		{
			// TODO GorillabotA3_LOE_039 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gorillabot A-3"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gorillabot A-3"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gorillabot A-3"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_046] Huge Toad - COST:2 [ATK:3/HP:2] 
		// - Race: beast, Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Deal 1 damage to a random enemy.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HugeToad_LOE_046()
		{
			// TODO HugeToad_LOE_046 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Huge Toad"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Huge Toad"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Huge Toad"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_047] Tomb Spider - COST:4 [ATK:3/HP:3] 
		// - Race: beast, Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry: Discover</b> a Beast.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TombSpider_LOE_047()
		{
			// TODO TombSpider_LOE_047 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tomb Spider"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tomb Spider"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tomb Spider"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_053] Djinni of Zephyrs - COST:5 [ATK:4/HP:6] 
		// - Race: elemental, Set: loe, Rarity: epic
		// --------------------------------------------------------
		// Text: After you cast a spell on another friendly minion, cast a copy of it on this one.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DjinniOfZephyrs_LOE_053()
		{
			// TODO DjinniOfZephyrs_LOE_053 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Djinni of Zephyrs"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Djinni of Zephyrs"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Djinni of Zephyrs"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_061] Anubisath Sentinel - COST:5 [ATK:4/HP:4] 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Give a random friendly minion +3/+3.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AnubisathSentinel_LOE_061()
		{
			// TODO AnubisathSentinel_LOE_061 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Anubisath Sentinel"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Anubisath Sentinel"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Anubisath Sentinel"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_073] Fossilized Devilsaur - COST:8 [ATK:8/HP:8] 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you control a Beast, gain <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FossilizedDevilsaur_LOE_073()
		{
			// TODO FossilizedDevilsaur_LOE_073 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fossilized Devilsaur"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fossilized Devilsaur"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fossilized Devilsaur"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_076] Sir Finley Mrrgglton - COST:1 [ATK:1/HP:3] 
		// - Race: murloc, Set: loe, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry: Discover</b> a new basic Hero Power.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SirFinleyMrrgglton_LOE_076()
		{
			// TODO SirFinleyMrrgglton_LOE_076 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sir Finley Mrrgglton"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sir Finley Mrrgglton"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sir Finley Mrrgglton"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_077] Brann Bronzebeard - COST:3 [ATK:2/HP:4] 
		// - Set: loe, Rarity: legendary
		// --------------------------------------------------------
		// Text: Your <b>Battlecries</b> trigger twice.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - AURA = 1
		// --------------------------------------------------------
		// RefTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BrannBronzebeard_LOE_077()
		{
			// TODO BrannBronzebeard_LOE_077 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Brann Bronzebeard"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Brann Bronzebeard"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Brann Bronzebeard"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_079] Elise Starseeker - COST:4 [ATK:3/HP:5] 
		// - Set: loe, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Shuffle the 'Map to the Golden Monkey'   into your deck.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EliseStarseeker_LOE_079()
		{
			// TODO EliseStarseeker_LOE_079 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Elise Starseeker"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Elise Starseeker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Elise Starseeker"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_086] Summoning Stone - COST:5 [ATK:0/HP:6] 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, summon a random minion of the same Cost.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SummoningStone_LOE_086()
		{
			// TODO SummoningStone_LOE_086 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Summoning Stone"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Summoning Stone"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Summoning Stone"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_089] Wobbling Runts - COST:6 [ATK:2/HP:6] 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon three 2/2 Runts.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WobblingRunts_LOE_089()
		{
			// TODO WobblingRunts_LOE_089 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wobbling Runts"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wobbling Runts"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wobbling Runts"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_092] Arch-Thief Rafaam - COST:9 [ATK:7/HP:8] 
		// - Set: loe, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry: Discover</b> a powerful Artifact.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArchThiefRafaam_LOE_092()
		{
			// TODO ArchThiefRafaam_LOE_092 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arch-Thief Rafaam"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arch-Thief Rafaam"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Arch-Thief Rafaam"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_107] Eerie Statue - COST:4 [ATK:7/HP:7] 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: Can’t attack unless it’s the only minion in the battlefield.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EerieStatue_LOE_107()
		{
			// TODO EerieStatue_LOE_107 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Eerie Statue"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eerie Statue"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Eerie Statue"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_110] Ancient Shade - COST:4 [ATK:7/HP:4] 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Shuffle an 'Ancient Curse' into your deck that deals 7 damage to you when drawn.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AncientShade_LOE_110()
		{
			// TODO AncientShade_LOE_110 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ancient Shade"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ancient Shade"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ancient Shade"));
		}

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
