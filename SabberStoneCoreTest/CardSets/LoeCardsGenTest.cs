using System.Collections.Generic;
using SabberStoneCore.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SabberStoneCore.Actions;
using SabberStoneCore.Conditions;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.PlayerTasks;

namespace SabberStoneUnitTest.CardSets
{
	[TestClass]
	public class HeroesLoeTest
	{
		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA01_01] Sun Raider Phaerix (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 14019
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void SunRaiderPhaerix_LOEA01_01()
		{
			// TODO SunRaiderPhaerix_LOEA01_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sun Raider Phaerix"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA01_01h] Sun Raider Phaerix (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 38479
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void SunRaiderPhaerix_LOEA01_01h()
		{
			// TODO SunRaiderPhaerix_LOEA01_01h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sun Raider Phaerix"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA02_01] Zinaar (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 14203
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Zinaar_LOEA02_01()
		{
			// TODO Zinaar_LOEA02_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Zinaar"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA02_01h] Zinaar (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 38465
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Zinaar_LOEA02_01h()
		{
			// TODO Zinaar_LOEA02_01h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Zinaar"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA04_01] Temple Escape (*) - COST:0 [ATK:0/HP:100] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 16231
		// - APPEAR_FUNCTIONALLY_DEAD = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void TempleEscape_LOEA04_01()
		{
			// TODO TempleEscape_LOEA04_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Temple Escape"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA04_01h] Temple Escape (*) - COST:0 [ATK:0/HP:100] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 38510
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void TempleEscape_LOEA04_01h()
		{
			// TODO TempleEscape_LOEA04_01h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Temple Escape"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA05_01] Chieftain Scarvash (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 15353
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void ChieftainScarvash_LOEA05_01()
		{
			// TODO ChieftainScarvash_LOEA05_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Chieftain Scarvash"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA05_01h] Chieftain Scarvash (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 38555
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void ChieftainScarvash_LOEA05_01h()
		{
			// TODO ChieftainScarvash_LOEA05_01h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Chieftain Scarvash"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA07_01] Mine Cart (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void MineCart_LOEA07_01()
		{
			// TODO MineCart_LOEA07_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Mine Cart"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA07_02] Mine Shaft (*) - COST:0 [ATK:0/HP:80] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 16205
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void MineShaft_LOEA07_02()
		{
			// TODO MineShaft_LOEA07_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Mine Shaft"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA07_02h] Mine Shaft (*) - COST:0 [ATK:0/HP:80] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 38676
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void MineShaft_LOEA07_02h()
		{
			// TODO MineShaft_LOEA07_02h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Mine Shaft"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA08_01] Archaedas (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 17145
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Archaedas_LOEA08_01()
		{
			// TODO Archaedas_LOEA08_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Archaedas"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA08_01h] Archaedas (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 38588
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Archaedas_LOEA08_01h()
		{
			// TODO Archaedas_LOEA08_01h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Archaedas"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA09_1] Lord Slitherspear (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 24427
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void LordSlitherspear_LOEA09_1()
		{
			// TODO LordSlitherspear_LOEA09_1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Lord Slitherspear"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA09_1H] Lord Slitherspear (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 38609
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void LordSlitherspear_LOEA09_1H()
		{
			// TODO LordSlitherspear_LOEA09_1H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Lord Slitherspear"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA10_1] Giantfin (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 10045
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Giantfin_LOEA10_1()
		{
			// TODO Giantfin_LOEA10_1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Giantfin"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA10_1H] Giantfin (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 38617
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Giantfin_LOEA10_1H()
		{
			// TODO Giantfin_LOEA10_1H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Giantfin"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA12_1] Lady Naz'jar (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 17193
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void LadyNazjar_LOEA12_1()
		{
			// TODO LadyNazjar_LOEA12_1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Lady Naz'jar"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA12_1H] Lady Naz'jar (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 38620
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void LadyNazjar_LOEA12_1H()
		{
			// TODO LadyNazjar_LOEA12_1H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Lady Naz'jar"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA13_1] Skelesaurus Hex (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 19795
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void SkelesaurusHex_LOEA13_1()
		{
			// TODO SkelesaurusHex_LOEA13_1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Skelesaurus Hex"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA13_1h] Skelesaurus Hex (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 38705
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void SkelesaurusHex_LOEA13_1h()
		{
			// TODO SkelesaurusHex_LOEA13_1h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Skelesaurus Hex"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA14_1] The Steel Sentinel (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 19117
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void TheSteelSentinel_LOEA14_1()
		{
			// TODO TheSteelSentinel_LOEA14_1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("The Steel Sentinel"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA14_1H] The Steel Sentinel (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 38708
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void TheSteelSentinel_LOEA14_1H()
		{
			// TODO TheSteelSentinel_LOEA14_1H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("The Steel Sentinel"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA15_1] Rafaam (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 19292
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Rafaam_LOEA15_1()
		{
			// TODO Rafaam_LOEA15_1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Rafaam"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA15_1H] Rafaam (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 38710
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Rafaam_LOEA15_1H()
		{
			// TODO Rafaam_LOEA15_1H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Rafaam"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA16_1] Rafaam (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// Entourage: LOEA16_18, LOEA16_23, LOEA16_19, LOEA16_22, LOEA16_21, LOEA16_24, LOEA16_25, LOEA16_26, LOEA16_27
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 19613
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Rafaam_LOEA16_1()
		{
			// TODO Rafaam_LOEA16_1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Rafaam"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [LOEA16_1H] Rafaam (*) - COST:0 [ATK:0/HP:30] 
		// - Set: loe, 
		// --------------------------------------------------------
		// Entourage: LOEA16_18H, LOEA16_19H, LOEA16_21H, LOEA16_22H, LOEA16_23H, LOEA16_24H, LOEA16_25H, LOEA16_26H, LOEA16_27H
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 38712
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Rafaam_LOEA16_1H()
		{
			// TODO Rafaam_LOEA16_1H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Rafaam"));
		}

	}

	[TestClass]
	public class HeroPowersLoeTest
	{
		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA01_02] Blessings of the Sun (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Whoever controls the Rod of the Sun is <b>Immune.</b>
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void BlessingsOfTheSun_LOEA01_02()
		{
			// TODO BlessingsOfTheSun_LOEA01_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Blessings of the Sun"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA01_02h] Blessings of the Sun (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//        Phaerix is <b>Immune</b> while he controls the Rod of the Sun.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void BlessingsOfTheSun_LOEA01_02h()
		{
			// TODO BlessingsOfTheSun_LOEA01_02h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Blessings of the Sun"));
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
		[TestMethod, Ignore]
		public void DjinnsIntuition_LOEA02_02()
		{
			// TODO DjinnsIntuition_LOEA02_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Djinn’s Intuition"));
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
		[TestMethod, Ignore]
		public void DjinnsIntuition_LOEA02_02h()
		{
			// TODO DjinnsIntuition_LOEA02_02h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Djinn’s Intuition"));
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
		[TestMethod, Ignore]
		public void Escape_LOEA04_02()
		{
			// TODO Escape_LOEA04_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Escape!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA04_02h] Escape! (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: Encounter new obstacles!
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Escape_LOEA04_02h()
		{
			// TODO Escape_LOEA04_02h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Escape!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA05_02] Trogg Hate Minions! (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//        Enemy minions cost (2) more. Swap at the start of your turn.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void TroggHateMinions_LOEA05_02()
		{
			// TODO TroggHateMinions_LOEA05_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Trogg Hate Minions!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA05_02a] Trogg Hate Minions! (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//        Enemy minions cost (2) more. Swap at the start of your turn.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void TroggHateMinions_LOEA05_02a()
		{
			// TODO TroggHateMinions_LOEA05_02a test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Trogg Hate Minions!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA05_02h] Trogg Hate Minions! (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//        Enemy minions cost (11). Swap at the start of your turn.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void TroggHateMinions_LOEA05_02h()
		{
			// TODO TroggHateMinions_LOEA05_02h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Trogg Hate Minions!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA05_02ha] Trogg Hate Minions! (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//        Enemy minions cost (11). Swap at the start of your turn.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void TroggHateMinions_LOEA05_02ha()
		{
			// TODO TroggHateMinions_LOEA05_02ha test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Trogg Hate Minions!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA05_03] Trogg Hate Spells! (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//        Enemy spells cost (2) more. Swap at the start of your turn.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void TroggHateSpells_LOEA05_03()
		{
			// TODO TroggHateSpells_LOEA05_03 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Trogg Hate Spells!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA05_03h] Trogg Hate Spells! (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//        Enemy spells cost (11). Swap at the start of your turn.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void TroggHateSpells_LOEA05_03h()
		{
			// TODO TroggHateSpells_LOEA05_03h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Trogg Hate Spells!"));
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
		[TestMethod, Ignore]
		public void Stonesculpting_LOEA06_02()
		{
			// TODO Stonesculpting_LOEA06_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stonesculpting"));
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
		[TestMethod, Ignore]
		public void Stonesculpting_LOEA06_02h()
		{
			// TODO Stonesculpting_LOEA06_02h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stonesculpting"));
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
		[TestMethod, Ignore]
		public void FleeTheMine_LOEA07_03()
		{
			// TODO FleeTheMine_LOEA07_03 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Flee the Mine!"));
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
		[TestMethod, Ignore]
		public void FleeTheMine_LOEA07_03h()
		{
			// TODO FleeTheMine_LOEA07_03h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Flee the Mine!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA07_29] Throw Rocks (*) - COST:1 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//        Deal 3 damage to a random enemy minion.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void ThrowRocks_LOEA07_29()
		{
			// TODO ThrowRocks_LOEA07_29 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Throw Rocks"));
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
		[TestMethod, Ignore]
		public void Enraged_LOEA09_2()
		{
			// TODO Enraged_LOEA09_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Enraged!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA09_2H] Enraged! (*) - COST:2 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: Give your hero +5 attack this turn.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Enraged_LOEA09_2H()
		{
			// TODO Enraged_LOEA09_2H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Enraged!"));
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
		[TestMethod, Ignore]
		public void GettingHungry_LOEA09_3()
		{
			// TODO GettingHungry_LOEA09_3 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Getting Hungry"));
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
		[TestMethod, Ignore]
		public void GettingHungry_LOEA09_3b()
		{
			// TODO GettingHungry_LOEA09_3b test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Getting Hungry"));
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
		[TestMethod, Ignore]
		public void GettingHungry_LOEA09_3c()
		{
			// TODO GettingHungry_LOEA09_3c test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Getting Hungry"));
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
		[TestMethod, Ignore]
		public void GettingHungry_LOEA09_3d()
		{
			// TODO GettingHungry_LOEA09_3d test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Getting Hungry"));
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
		[TestMethod, Ignore]
		public void EndlessHunger_LOEA09_3H()
		{
			// TODO EndlessHunger_LOEA09_3H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Endless Hunger"));
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
		[TestMethod, Ignore]
		public void MrglmrglMrgl_LOEA10_2()
		{
			// TODO MrglmrglMrgl_LOEA10_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Mrglmrgl MRGL!"));
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
		[TestMethod, Ignore]
		public void MrglmrglMrgl_LOEA10_2H()
		{
			// TODO MrglmrglMrgl_LOEA10_2H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Mrglmrgl MRGL!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA12_2] Pearl of the Tides (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: At the end of your turn, replace all minions with new ones that cost (1) more.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void PearlOfTheTides_LOEA12_2()
		{
			// TODO PearlOfTheTides_LOEA12_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Pearl of the Tides"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA12_2H] Pearl of the Tides (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: At the end of your turn, replace all minions with new ones. Yours cost (1) more.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void PearlOfTheTides_LOEA12_2H()
		{
			// TODO PearlOfTheTides_LOEA12_2H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Pearl of the Tides"));
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
		[TestMethod, Ignore]
		public void AncientPower_LOEA13_2()
		{
			// TODO AncientPower_LOEA13_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ancient Power"));
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
		[TestMethod, Ignore]
		public void AncientPower_LOEA13_2H()
		{
			// TODO AncientPower_LOEA13_2H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ancient Power"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA14_2] Platemail Armor (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Your Hero can only take 1 damage at a time.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void PlatemailArmor_LOEA14_2()
		{
			// TODO PlatemailArmor_LOEA14_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Platemail Armor"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA14_2H] Platemail Armor (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Your Hero and your minions can only take 1 damage at a time.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void PlatemailArmor_LOEA14_2H()
		{
			// TODO PlatemailArmor_LOEA14_2H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Platemail Armor"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA15_2] Unstable Portal (*) - COST:2 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Add a random minion to your hand. It costs (3) less.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void UnstablePortal_LOEA15_2()
		{
			// TODO UnstablePortal_LOEA15_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Unstable Portal"));
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
		[TestMethod, Ignore]
		public void UnstablePortal_LOEA15_2H()
		{
			// TODO UnstablePortal_LOEA15_2H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Unstable Portal"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA16_16] Rummage (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: Find an artifact.
		// --------------------------------------------------------
		// Entourage: LOEA16_10, LOEA16_11, LOEA16_14, LOEA16_15, LOEA16_6, LOEA16_7, LOEA16_9, LOEA16_12, LOEA16_13, LOEA16_8
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Rummage_LOEA16_16()
		{
			// TODO Rummage_LOEA16_16 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Rummage"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA16_16H] Rummage (*) - COST:2 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: Find an artifact.
		// --------------------------------------------------------
		// Entourage: LOEA16_10, LOEA16_11, LOEA16_14, LOEA16_15, LOEA16_6, LOEA16_7, LOEA16_9, LOEA16_12, LOEA16_13, LOEA16_8
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Rummage_LOEA16_16H()
		{
			// TODO Rummage_LOEA16_16H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Rummage"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA16_2] Staff of Origination (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Your hero is <b>Immune</b> while the staff charges.
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_COST = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void StaffOfOrigination_LOEA16_2()
		{
			// TODO StaffOfOrigination_LOEA16_2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Staff of Origination"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [LOEA16_2H] Staff of Origination (*) - COST:0 
		// - Set: loe, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Your hero is <b>Immune</b>.
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_COST = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void StaffOfOrigination_LOEA16_2H()
		{
			// TODO StaffOfOrigination_LOEA16_2H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Staff of Origination"));
		}

	}

	[TestClass]
	public class DruidLoeTest
	{
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
		// - TREASURE = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void RavenIdol_LOE_115()
		{
			// TODO RavenIdol_LOE_115 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.DRUID,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Raven Idol"));
		}

		// ----------------------------------------- MINION - DRUID
		// [LOE_050] Mounted Raptor - COST:3 [ATK:3/HP:2] 
		// - Race: beast, Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a random 1-Cost minion.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void MountedRaptor_LOE_050()
		{
			// TODO MountedRaptor_LOE_050 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.DRUID,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Mounted Raptor"));
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
		[TestMethod]
		public void JungleMoonkin_LOE_051()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.DRUID,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Jungle Moonkin"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            var spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
		    game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, game.CurrentOpponent.Hero));
		    Assert.AreEqual(22, game.CurrentOpponent.Hero.Health);
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, game.CurrentOpponent.Hero));
            Assert.AreEqual(22, game.CurrentOpponent.Hero.Health);
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
        }

    }

	[TestClass]
	public class HunterLoeTest
	{
		// ----------------------------------------- SPELL - HUNTER
		// [LOE_021] Dart Trap - COST:2 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> After an opposing <b>Hero Power</b> is used, deal $5 damage to a random enemy. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void DartTrap_LOE_021()
		{
			// TODO DartTrap_LOE_021 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.HUNTER,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Dart Trap"));
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
		[TestMethod, Ignore]
		public void ExplorersHat_LOE_105()
		{
			// TODO ExplorersHat_LOE_105 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.HUNTER,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Explorer's Hat"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [LOE_020] Desert Camel - COST:3 [ATK:2/HP:4] 
		// - Race: beast, Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Put a 1-Cost minion from each deck into the battlefield.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void DesertCamel_LOE_020()
		{
			// TODO DesertCamel_LOE_020 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.HUNTER,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Desert Camel"));
		}

	}

	[TestClass]
	public class MageLoeTest
	{
		// ------------------------------------------- SPELL - MAGE
		// [LOE_002] Forgotten Torch - COST:3 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $3 damage. Shuffle a 'Roaring Torch' into your deck that deals 6 damage. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod]
		public void ForgottenTorch_LOE_002()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Forgotten Torch"));
            Assert.AreEqual(26, game.CurrentPlayer.Deck.Count);
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, game.CurrentOpponent.Hero));
            Assert.AreEqual(27, game.CurrentOpponent.Hero.Health);
		    Assert.AreEqual(27, game.CurrentPlayer.Deck.Count);


		}

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
		// - TREASURE = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void EtherealConjurer_LOE_003()
		{
			// TODO EtherealConjurer_LOE_003 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ethereal Conjurer"));
		}

		// ------------------------------------------ MINION - MAGE
		// [LOE_119] Animated Armor - COST:4 [ATK:4/HP:4] 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: Your hero can only take 1 damage at a time.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void AnimatedArmor_LOE_119()
		{
			// TODO AnimatedArmor_LOE_119 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Animated Armor"));
		}

	}

	[TestClass]
	public class PaladinLoeTest
	{
		// ---------------------------------------- SPELL - PALADIN
		// [LOE_026] Anyfin Can Happen - COST:10 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: Summon 7 Murlocs that died this game.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void AnyfinCanHappen_LOE_026()
		{
			// TODO AnyfinCanHappen_LOE_026 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Anyfin Can Happen"));
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
		[TestMethod, Ignore]
		public void SacredTrial_LOE_027()
		{
			// TODO SacredTrial_LOE_027 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sacred Trial"));
		}

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
		[TestMethod, Ignore]
		public void KeeperOfUldaman_LOE_017()
		{
			// TODO KeeperOfUldaman_LOE_017 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Keeper of Uldaman"));
		}

	}

	[TestClass]
	public class PriestLoeTest
	{
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
		[TestMethod, Ignore]
		public void Entomb_LOE_104()
		{
			// TODO Entomb_LOE_104 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Entomb"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [LOE_111] Excavated Evil - COST:5 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $3 damage to all minions.
		//       Shuffle this card into your opponent's deck. *spelldmg
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void ExcavatedEvil_LOE_111()
		{
			// TODO ExcavatedEvil_LOE_111 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Excavated Evil"));
		}

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
		// - TREASURE = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void MuseumCurator_LOE_006()
		{
			// TODO MuseumCurator_LOE_006 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Museum Curator"));
		}

	}

	[TestClass]
	public class RogueLoeTest
	{
		// ----------------------------------------- MINION - ROGUE
		// [LOE_010] Pit Snake - COST:1 [ATK:2/HP:1] 
		// - Race: beast, Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: Destroy any minion damaged by this minion.
		// --------------------------------------------------------
		// GameTag:
		// - POISONOUS = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void PitSnake_LOE_010()
		{
			// TODO PitSnake_LOE_010 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.ROGUE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Pit Snake"));
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
		[TestMethod]
		public void TombPillager_LOE_012()
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
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Tomb Pillager"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
            Assert.AreEqual(4, game.CurrentOpponent.Hand.Count);
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, testCard));
            Assert.AreEqual(5, game.CurrentOpponent.Hand.Count);
        }

		// ----------------------------------------- MINION - ROGUE
		// [LOE_019] Unearthed Raptor - COST:3 [ATK:3/HP:4] 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Choose a friendly minion. Gain a copy of its <b>Deathrattle</b> effect.
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
		[TestMethod, Ignore]
		public void UnearthedRaptor_LOE_019()
		{
			// TODO UnearthedRaptor_LOE_019 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.ROGUE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Unearthed Raptor"));
		}

	}

	[TestClass]
	public class ShamanLoeTest
	{
		// ----------------------------------------- SPELL - SHAMAN
		// [LOE_113] Everyfin is Awesome - COST:7 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: Give your minions +2/+2.
		//       Costs (1) less for each Murloc you control.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void EveryfinIsAwesome_LOE_113()
		{
			// TODO EveryfinIsAwesome_LOE_113 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.SHAMAN,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Everyfin is Awesome"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [LOE_016] Rumbling Elemental - COST:4 [ATK:2/HP:6] 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: After you play a <b>Battlecry</b> minion, deal 2 damage to a random enemy.
		// --------------------------------------------------------
		// RefTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void RumblingElemental_LOE_016()
		{
			// TODO RumblingElemental_LOE_016 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.SHAMAN,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Rumbling Elemental"));
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
		[TestMethod]
		public void TunnelTrogg_LOE_018()
		{
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.SHAMAN,
                Player2HeroClass = CardClass.PALADIN,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;
            var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tunnel Trogg"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            var minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Totem Golem"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
            Assert.AreEqual(2, ((Minion)testCard).AttackDamage);
            var minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dust Devil"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
            Assert.AreEqual(4, ((Minion)testCard).AttackDamage);
        }

	}

	[TestClass]
	public class WarlockLoeTest
	{
		// ---------------------------------------- SPELL - WARLOCK
		// [LOE_007] Curse of Rafaam - COST:2 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: Give your opponent a 'Cursed!' card.
		//       While they hold it, they take 2 damage on their turn.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void CurseOfRafaam_LOE_007()
		{
			// TODO CurseOfRafaam_LOE_007 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Curse of Rafaam"));
		}

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
		// - TREASURE = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void DarkPeddler_LOE_023()
		{
			// TODO DarkPeddler_LOE_023 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Dark Peddler"));
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
		[TestMethod, Ignore]
		public void ReliquarySeeker_LOE_116()
		{
			// TODO ReliquarySeeker_LOE_116 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Reliquary Seeker"));
		}

	}

	[TestClass]
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
		[TestMethod, Ignore]
		public void ObsidianDestroyer_LOE_009()
		{
			// TODO ObsidianDestroyer_LOE_009 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.WARRIOR,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Obsidian Destroyer"));
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
		[TestMethod, Ignore]
		public void FierceMonkey_LOE_022()
		{
			// TODO FierceMonkey_LOE_022 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.WARRIOR,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Fierce Monkey"));
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
		[TestMethod, Ignore]
		public void CursedBlade_LOE_118()
		{
			// TODO CursedBlade_LOE_118 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.WARRIOR,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Cursed Blade"));
		}

	}

	[TestClass]
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
		[TestMethod]
		public void RenoJackson_LOE_011()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
                DeckPlayer1 = new List<Card>()
                {
                    Cards.FromName("Arcane Blast"),
                    Cards.FromName("Frostbolt"),
                    Cards.FromName("Arcane Intellect"),
                    Cards.FromName("Fireball"),
                    Cards.FromName("Polymorph"),
                    Cards.FromName("Blizzard"),
                    Cards.FromName("Flamestrike"),
                    Cards.FromName("Bloodmage Thalnos"),
                    Cards.FromName("Bloodmage Thalnos")
                },
				Player2HeroClass = CardClass.MAGE,
                DeckPlayer2 = new List<Card>()
                {
                    Cards.FromName("Arcane Blast"),
                    Cards.FromName("Frostbolt"),
                    Cards.FromName("Arcane Intellect"),
                    Cards.FromName("Fireball"),
                    Cards.FromName("Polymorph"),
                    Cards.FromName("Blizzard"),
                    Cards.FromName("Flamestrike"),
                    Cards.FromName("Bloodmage Thalnos"),
                    Cards.FromName("Acidic Swamp Ooze")
                },
                FillDecks = false,
                Shuffle = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
            var minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Alexstrasza"));
            game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion, game.CurrentOpponent.Hero));
            Assert.AreEqual(15, game.CurrentOpponent.Hero.Health);
            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var testCard1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Reno Jackson"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
            Assert.AreEqual(30, game.CurrentPlayer.Hero.Health);

            game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
            Assert.AreEqual(29, game.CurrentOpponent.Hero.Health);
            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Reno Jackson"));
            Assert.AreEqual(false, SelfCondition.IsNoDupeInDeck.Eval(testCard2));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
            Assert.AreEqual(29, game.CurrentPlayer.Hero.Health);

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
		// - TREASURE = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void JeweledScarab_LOE_029()
		{
			// TODO JeweledScarab_LOE_029 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Jeweled Scarab"));
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
		[TestMethod, Ignore]
		public void NagaSeaWitch_LOE_038()
		{
			// TODO NagaSeaWitch_LOE_038 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Naga Sea Witch"));
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
		// - TREASURE = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void GorillabotA3_LOE_039()
		{
			// TODO GorillabotA3_LOE_039 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Gorillabot A-3"));
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
		[TestMethod, Ignore]
		public void HugeToad_LOE_046()
		{
			// TODO HugeToad_LOE_046 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Huge Toad"));
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
		// - TREASURE = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void TombSpider_LOE_047()
		{
			// TODO TombSpider_LOE_047 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Tomb Spider"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_053] Djinni of Zephyrs - COST:5 [ATK:4/HP:6] 
		// - Set: loe, Rarity: epic
		// --------------------------------------------------------
		// Text: After you cast a spell on another friendly minion, cast a copy of it on this one.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void DjinniOfZephyrs_LOE_053()
		{
			// TODO DjinniOfZephyrs_LOE_053 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Djinni of Zephyrs"));
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
		[TestMethod, Ignore]
		public void AnubisathSentinel_LOE_061()
		{
			// TODO AnubisathSentinel_LOE_061 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Anubisath Sentinel"));
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
		[TestMethod, Ignore]
		public void FossilizedDevilsaur_LOE_073()
		{
			// TODO FossilizedDevilsaur_LOE_073 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Fossilized Devilsaur"));
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
		// - TREASURE = 1
		// --------------------------------------------------------
		[TestMethod]
		public void SirFinleyMrrgglton_LOE_076()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
            Assert.AreEqual(null, game.CurrentPlayer.Choice);
            var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sir Finley Mrrgglton"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            Assert.AreNotEqual(null, game.CurrentPlayer.Choice);
		    var choice = game.CurrentPlayer.Choice.Choices[0];
            game.Process(ChooseTask.Pick(game.CurrentPlayer, choice));
            Assert.AreEqual(choice, game.CurrentPlayer.Hero.Power.Card);

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
		[TestMethod, Ignore]
		public void BrannBronzebeard_LOE_077()
		{
			// TODO BrannBronzebeard_LOE_077 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Brann Bronzebeard"));
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
		[TestMethod, Ignore]
		public void EliseStarseeker_LOE_079()
		{
			// TODO EliseStarseeker_LOE_079 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Elise Starseeker"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_086] Summoning Stone - COST:5 [ATK:0/HP:6] 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, summon a random minion of the same Cost.
		// --------------------------------------------------------
		[TestMethod]
		public void SummoningStone_LOE_086()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Summoning Stone"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            var spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostbolt"));
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, game.CurrentOpponent.Hero));
            Assert.AreEqual(2, game.CurrentPlayer.Board.Count);
            Assert.AreEqual(spell1.Card.Cost, game.CurrentPlayer.Board[1].Card.Cost);
            var minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sorcerer's Apprentice"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
            var spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Missiles"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell2));
            Assert.AreEqual(4, game.CurrentPlayer.Board.Count);
            Assert.AreEqual(0, game.CurrentPlayer.Board[3].Card.Cost);
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
		[TestMethod, Ignore]
		public void WobblingRunts_LOE_089()
		{
			// TODO WobblingRunts_LOE_089 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Wobbling Runts"));
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
		// - TREASURE = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void ArchThiefRafaam_LOE_092()
		{
			// TODO ArchThiefRafaam_LOE_092 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Arch-Thief Rafaam"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_107] Eerie Statue - COST:4 [ATK:7/HP:7] 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: Can’t attack unless it’s the only minion in the battlefield.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void EerieStatue_LOE_107()
		{
			// TODO EerieStatue_LOE_107 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Eerie Statue"));
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
		[TestMethod, Ignore]
		public void AncientShade_LOE_110()
		{
			// TODO AncientShade_LOE_110 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ancient Shade"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOEA10_3] Murloc Tinyfin - COST:0 [ATK:1/HP:1] 
		// - Race: murloc, Set: loe, Rarity: common
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void MurlocTinyfin_LOEA10_3()
		{
			// TODO MurlocTinyfin_LOEA10_3 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Murloc Tinyfin"));
		}

	}

}
