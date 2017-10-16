using Xunit;
using SabberStoneCore.Enums;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCoreTest.CardSets.Adventure
{
	public class HeroesKaraTest
	{
		// ----------------------------------------- HERO - NEUTRAL
		// [KAR_A01_01] Magic Mirror (*) - COST:0 [ATK:0/HP:30] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39632
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MagicMirror_KAR_A01_01()
		{
			// TODO MagicMirror_KAR_A01_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Magic Mirror"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Magic Mirror"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Magic Mirror"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KAR_A01_01H] Magic Mirror (*) - COST:0 [ATK:0/HP:30] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 40085
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MagicMirror_KAR_A01_01H()
		{
			// TODO MagicMirror_KAR_A01_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Magic Mirror"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Magic Mirror"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Magic Mirror"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KAR_A02_12] Silverware Golem (*) - COST:0 [ATK:0/HP:30] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39725
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SilverwareGolem_KAR_A02_12()
		{
			// TODO SilverwareGolem_KAR_A02_12 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Silverware Golem"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Silverware Golem"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Silverware Golem"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KAR_A02_12H] Silverware Golem (*) - COST:0 [ATK:0/HP:30] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 40083
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SilverwareGolem_KAR_A02_12H()
		{
			// TODO SilverwareGolem_KAR_A02_12H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Silverware Golem"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Silverware Golem"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Silverware Golem"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KAR_a10_Boss1] White King (*) - COST:0 [ATK:0/HP:20] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39544
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WhiteKing_KAR_a10_Boss1()
		{
			// TODO WhiteKing_KAR_a10_Boss1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("White King"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("White King"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "White King"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KAR_a10_Boss1H] White King (*) - COST:0 [ATK:0/HP:20] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 40086
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WhiteKing_KAR_a10_Boss1H()
		{
			// TODO WhiteKing_KAR_a10_Boss1H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("White King"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("White King"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "White King"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KAR_a10_Boss2] Black King (*) - COST:0 [ATK:0/HP:20] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39801
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BlackKing_KAR_a10_Boss2()
		{
			// TODO BlackKing_KAR_a10_Boss2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Black King"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Black King"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Black King"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KAR_a10_Boss2H] Black King (*) - COST:0 [ATK:0/HP:20] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39801
		// - CANT_BE_FATIGUED = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BlackKing_KAR_a10_Boss2H()
		{
			// TODO BlackKing_KAR_a10_Boss2H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Black King"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Black King"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Black King"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_00_01] Prince Malchezaar (*) - COST:0 [ATK:0/HP:30] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39753
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PrinceMalchezaar_KARA_00_01()
		{
			// TODO PrinceMalchezaar_KARA_00_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Prince Malchezaar"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Prince Malchezaar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Prince Malchezaar"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_00_01H] Prince Malchezaar (*) - COST:0 [ATK:0/HP:60] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 40080
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PrinceMalchezaar_KARA_00_01H()
		{
			// TODO PrinceMalchezaar_KARA_00_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Prince Malchezaar"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Prince Malchezaar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Prince Malchezaar"));
		}

		// -------------------------------------------- HERO - MAGE
		// [KARA_00_03] Medivh (*) - COST:0 [ATK:0/HP:30] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 40081
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Medivh_KARA_00_03()
		{
			// TODO Medivh_KARA_00_03 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Medivh"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Medivh"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Medivh"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_00_03c] Medivh (*) - COST:0 
		// - Set: kara, 
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Medivh_KARA_00_03c()
		{
			// TODO Medivh_KARA_00_03c test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Medivh"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Medivh"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Medivh"));
		}

		// -------------------------------------------- HERO - MAGE
		// [KARA_00_03H] Medivh (*) - COST:0 [ATK:0/HP:30] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39756
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Medivh_KARA_00_03H()
		{
			// TODO Medivh_KARA_00_03H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Medivh"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Medivh"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Medivh"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_04_01h] The Crone (*) - COST:0 [ATK:0/HP:30] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39281
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheCrone_KARA_04_01h()
		{
			// TODO TheCrone_KARA_04_01h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Crone"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Crone"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Crone"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_04_01heroic] The Crone (*) - COST:0 [ATK:0/HP:50] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39281
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheCrone_KARA_04_01heroic()
		{
			// TODO TheCrone_KARA_04_01heroic test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Crone"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Crone"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Crone"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_05_01b] Kindly Grandmother (*) - COST:0 [ATK:0/HP:20] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39298
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KindlyGrandmother_KARA_05_01b()
		{
			// TODO KindlyGrandmother_KARA_05_01b test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kindly Grandmother"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kindly Grandmother"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kindly Grandmother"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_05_01h] Big Bad Wolf (*) - COST:0 [ATK:0/HP:20] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39298
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BigBadWolf_KARA_05_01h()
		{
			// TODO BigBadWolf_KARA_05_01h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Big Bad Wolf"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Big Bad Wolf"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Big Bad Wolf"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_05_01hheroic] Big Bad Wolf (*) - COST:0 [ATK:0/HP:20] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 40266
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BigBadWolf_KARA_05_01hheroic()
		{
			// TODO BigBadWolf_KARA_05_01hheroic test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Big Bad Wolf"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Big Bad Wolf"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Big Bad Wolf"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_06_02] Julianne (*) - COST:0 [ATK:0/HP:15] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39563
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Julianne_KARA_06_02()
		{
			// TODO Julianne_KARA_06_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Julianne"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Julianne"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Julianne"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_06_02heroic] Julianne (*) - COST:0 [ATK:0/HP:15] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 40276
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Julianne_KARA_06_02heroic()
		{
			// TODO Julianne_KARA_06_02heroic test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Julianne"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Julianne"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Julianne"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_07_01] Curator (*) - COST:0 [ATK:0/HP:30] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39641
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Curator_KARA_07_01()
		{
			// TODO Curator_KARA_07_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Curator"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Curator"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Curator"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_07_01heroic] Curator (*) - COST:0 [ATK:0/HP:40] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39641
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Curator_KARA_07_01heroic()
		{
			// TODO Curator_KARA_07_01heroic test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Curator"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Curator"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Curator"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_08_01] Netherspite (*) - COST:0 [ATK:0/HP:30] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39680
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Netherspite_KARA_08_01()
		{
			// TODO Netherspite_KARA_08_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Netherspite"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Netherspite"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Netherspite"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_08_01H] Netherspite (*) - COST:0 [ATK:0/HP:30] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 40062
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Netherspite_KARA_08_01H()
		{
			// TODO Netherspite_KARA_08_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Netherspite"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Netherspite"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Netherspite"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_09_01] Terestian Illhoof (*) - COST:0 [ATK:0/HP:30] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39645
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TerestianIllhoof_KARA_09_01()
		{
			// TODO TerestianIllhoof_KARA_09_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Terestian Illhoof"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Terestian Illhoof"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Terestian Illhoof"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_09_01heroic] Terestian Illhoof (*) - COST:0 [ATK:0/HP:40] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39645
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TerestianIllhoof_KARA_09_01heroic()
		{
			// TODO TerestianIllhoof_KARA_09_01heroic test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Terestian Illhoof"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Terestian Illhoof"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Terestian Illhoof"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_09_02] Curator (*) - COST:0 [ATK:0/HP:30] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39645
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Curator_KARA_09_02()
		{
			// TODO Curator_KARA_09_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Curator"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Curator"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Curator"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_11_01] Nightbane (*) - COST:0 [ATK:0/HP:30] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39667
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Nightbane_KARA_11_01()
		{
			// TODO Nightbane_KARA_11_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nightbane"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nightbane"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nightbane"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_11_01heroic] Nightbane (*) - COST:0 [ATK:0/HP:30] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39667
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Nightbane_KARA_11_01heroic()
		{
			// TODO Nightbane_KARA_11_01heroic test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nightbane"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nightbane"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nightbane"));
		}

		// -------------------------------------------- HERO - MAGE
		// [KARA_12_01] Shade of Aran (*) - COST:0 [ATK:0/HP:30] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39669
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShadeOfAran_KARA_12_01()
		{
			// TODO ShadeOfAran_KARA_12_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shade of Aran"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shade of Aran"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shade of Aran"));
		}

		// -------------------------------------------- HERO - MAGE
		// [KARA_12_01H] Shade of Aran (*) - COST:0 [ATK:0/HP:30] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 40107
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShadeOfAran_KARA_12_01H()
		{
			// TODO ShadeOfAran_KARA_12_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shade of Aran"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shade of Aran"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shade of Aran"));
		}

		// ----------------------------------------- HERO - WARRIOR
		// [KARA_13_01] Nazra Wildaxe (*) - COST:0 [ATK:0/HP:15] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39771
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NazraWildaxe_KARA_13_01()
		{
			// TODO NazraWildaxe_KARA_13_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nazra Wildaxe"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nazra Wildaxe"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nazra Wildaxe"));
		}

		// ----------------------------------------- HERO - WARRIOR
		// [KARA_13_01H] Nazra Wildaxe (*) - COST:0 [ATK:0/HP:15] 
		// - Set: kara, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 40733
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NazraWildaxe_KARA_13_01H()
		{
			// TODO NazraWildaxe_KARA_13_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nazra Wildaxe"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nazra Wildaxe"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nazra Wildaxe"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_13_06] Prince Malchezaar (*) - COST:0 [ATK:0/HP:30] 
		// - Race: demon, Set: kara, 
		// --------------------------------------------------------
		// Entourage: KAR_073, KAR_075, KAR_076, KAR_077, KAR_091
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 40563
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PrinceMalchezaar_KARA_13_06()
		{
			// TODO PrinceMalchezaar_KARA_13_06 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Prince Malchezaar"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Prince Malchezaar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Prince Malchezaar"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [KARA_13_06H] Prince Malchezaar (*) - COST:0 [ATK:0/HP:30] 
		// - Race: demon, Set: kara, 
		// --------------------------------------------------------
		// Entourage: KAR_073, KAR_075, KAR_076, KAR_077, KAR_091
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 40763
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PrinceMalchezaar_KARA_13_06H()
		{
			// TODO PrinceMalchezaar_KARA_13_06H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Prince Malchezaar"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Prince Malchezaar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Prince Malchezaar"));
		}

	}

	public class HeroPowersKaraTest
	{
		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KAR_A01_02] Reflections (*) - COST:0 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Whenever a minion is played, summon a 1/1 copy of it.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Reflections_KAR_A01_02()
		{
			// TODO Reflections_KAR_A01_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Reflections"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Reflections"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Reflections"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KAR_A01_02H] Reflections (*) - COST:0 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Whenever a minion is played, Magic Mirror summons a 1/1 copy of it.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Reflections_KAR_A01_02H()
		{
			// TODO Reflections_KAR_A01_02H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Reflections"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Reflections"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Reflections"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KAR_A02_13] Be Our Guest (*) - COST:0 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 1/1 Plate.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BeOurGuest_KAR_A02_13()
		{
			// TODO BeOurGuest_KAR_A02_13 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Be Our Guest"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Be Our Guest"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Be Our Guest"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KAR_A02_13H] Be Our Guest (*) - COST:0 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon two 1/1 Plates.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BeOurGuest_KAR_A02_13H()
		{
			// TODO BeOurGuest_KAR_A02_13H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Be Our Guest"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Be Our Guest"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Be Our Guest"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KAR_A10_22] Castle (*) - COST:2 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       <b>Discover</b> a chess piece.
		// --------------------------------------------------------
		// Entourage: KAR_A10_09, KAR_A10_02, KAR_A10_08, KAR_A10_04, KAR_A10_05
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Castle_KAR_A10_22()
		{
			// TODO Castle_KAR_A10_22 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Castle"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Castle"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Castle"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KAR_A10_22H] Castle (*) - COST:1 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Move a friendly minion left. Repeatable.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Castle_KAR_A10_22H()
		{
			// TODO Castle_KAR_A10_22H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Castle"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Castle"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Castle"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KAR_A10_33] Cheat (*) - COST:2 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Destroy the left-most enemy minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINIMUM_ENEMY_MINIONS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Cheat_KAR_A10_33()
		{
			// TODO Cheat_KAR_A10_33 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cheat"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cheat"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cheat"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_00_02] Legion (*) - COST:2 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 6/6 Abyssal.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Legion_KARA_00_02()
		{
			// TODO Legion_KARA_00_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Legion"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Legion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Legion"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_00_02H] Legion (*) - COST:2 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 6/6 Abyssal.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Legion_KARA_00_02H()
		{
			// TODO Legion_KARA_00_02H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Legion"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Legion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Legion"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_00_04] Brilliance (*) - COST:2 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Draw 3 cards.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Brilliance_KARA_00_04()
		{
			// TODO Brilliance_KARA_00_04 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Brilliance"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Brilliance"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Brilliance"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_00_04H] Brilliance (*) - COST:2 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Draw 3 cards.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Brilliance_KARA_00_04H()
		{
			// TODO Brilliance_KARA_00_04H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Brilliance"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Brilliance"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Brilliance"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_04_02hp] Twister (*) - COST:0 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 100 damage. Can't be used if Dorothee is alive.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Twister_KARA_04_02hp()
		{
			// TODO Twister_KARA_04_02hp test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Twister"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twister"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Twister"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_05_01hp] Trembling (*) - COST:0 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b> Enemy minions are 1/1 and cost (1).
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Trembling_KARA_05_01hp()
		{
			// TODO Trembling_KARA_05_01hp test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Trembling"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Trembling"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Trembling"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_05_01hpheroic] Trembling (*) - COST:0 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b> Minions cost (1). Enemy minions are 1/1.
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Trembling_KARA_05_01hpheroic()
		{
			// TODO Trembling_KARA_05_01hpheroic test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Trembling"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Trembling"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Trembling"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_06_03hp] True Love (*) - COST:4 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       If you don't have Romulo, summon him.
		// --------------------------------------------------------
		// Entourage: KARA_06_01
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// - REQ_ENTIRE_ENTOURAGE_NOT_IN_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TrueLove_KARA_06_03hp()
		{
			// TODO TrueLove_KARA_06_03hp test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("True Love"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("True Love"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "True Love"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_06_03hpheroic] True Love (*) - COST:0 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       If you don't have Romulo, summon him.
		// --------------------------------------------------------
		// Entourage: KARA_06_01
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// - REQ_ENTIRE_ENTOURAGE_NOT_IN_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TrueLove_KARA_06_03hpheroic()
		{
			// TODO TrueLove_KARA_06_03hpheroic test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("True Love"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("True Love"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "True Love"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_07_02] Gallery Protection (*) - COST:0 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Your hero has <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GalleryProtection_KARA_07_02()
		{
			// TODO GalleryProtection_KARA_07_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gallery Protection"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gallery Protection"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gallery Protection"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_08_02] Nether Rage (*) - COST:2 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Give your hero +3 Attack this turn.
		// --------------------------------------------------------
		// Entourage: KARA_08_06, KARA_08_08
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NetherRage_KARA_08_02()
		{
			// TODO NetherRage_KARA_08_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nether Rage"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nether Rage"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nether Rage"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_08_02H] Nether Rage (*) - COST:1 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Give your hero +8 Attack this turn.
		// --------------------------------------------------------
		// Entourage: KARA_08_06, KARA_08_08
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NetherRage_KARA_08_02H()
		{
			// TODO NetherRage_KARA_08_02H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nether Rage"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nether Rage"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nether Rage"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_09_04] Dark Pact (*) - COST:0 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Only Icky Imps can damage Illhoof!
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DarkPact_KARA_09_04()
		{
			// TODO DarkPact_KARA_09_04 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dark Pact"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dark Pact"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dark Pact"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_11_02] Manastorm (*) - COST:0 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Players start with 10 Mana Crystals.
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Manastorm_KARA_11_02()
		{
			// TODO Manastorm_KARA_11_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Manastorm"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Manastorm"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Manastorm"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_12_02] Ley Lines (*) - COST:0 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: [x]<b>Passive Hero Power</b>
		//       Both players have
		//       <b>Spell Damage +3</b>.
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LeyLines_KARA_12_02()
		{
			// TODO LeyLines_KARA_12_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ley Lines"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ley Lines"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ley Lines"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_12_02H] Ley Lines (*) - COST:0 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: [x]<b>Passive Hero Power</b>
		//       Both players have
		//       <b>Spell Damage +5</b>.
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LeyLines_KARA_12_02H()
		{
			// TODO LeyLines_KARA_12_02H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ley Lines"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ley Lines"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ley Lines"));
		}

		// ----------------------------------- HERO_POWER - WARRIOR
		// [KARA_13_02] The Horde (*) - COST:2 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: [x]<b>Hero Power</b>
		//       Summon a 3/2 Orc.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheHorde_KARA_13_02()
		{
			// TODO TheHorde_KARA_13_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Horde"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Horde"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Horde"));
		}

		// ----------------------------------- HERO_POWER - WARRIOR
		// [KARA_13_02H] The Horde (*) - COST:2 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: [x]<b>Hero Power</b>
		//       Summon a 3/3 Orc
		//       with <b>Charge</b>.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheHorde_KARA_13_02H()
		{
			// TODO TheHorde_KARA_13_02H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Horde"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Horde"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Horde"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_13_13] Legion (*) - COST:2 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 6/6 Abyssal.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Legion_KARA_13_13()
		{
			// TODO Legion_KARA_13_13 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Legion"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Legion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Legion"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [KARA_13_13H] Legion (*) - COST:2 
		// - Set: kara, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon two 6/6 Abyssals.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Legion_KARA_13_13H()
		{
			// TODO Legion_KARA_13_13H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Legion"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Legion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Legion"));
		}

	}

	public class DruidKaraTest
	{
		// ----------------------------------------- MINION - DRUID
		// [KAR_065] Menagerie Warden - COST:6 [ATK:5/HP:5] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Choose a friendly Beast. Summon a_copy of it.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_WITH_RACE = 20
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MenagerieWarden_KAR_065()
		{
			// TODO MenagerieWarden_KAR_065 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Menagerie Warden"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Menagerie Warden"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Menagerie Warden"));
		}

		// ----------------------------------------- MINION - DRUID
		// [KAR_300] Enchanted Raven - COST:1 [ATK:2/HP:2] 
		// - Race: beast, Set: kara, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EnchantedRaven_KAR_300()
		{
			// TODO EnchantedRaven_KAR_300 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Enchanted Raven"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Enchanted Raven"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Enchanted Raven"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [KAR_075] Moonglade Portal - COST:6 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: Restore #6 Health. Summon a random
		//       6-Cost minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MoongladePortal_KAR_075()
		{
			// TODO MoongladePortal_KAR_075 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Moonglade Portal"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Moonglade Portal"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Moonglade Portal"));
		}

	}

	public class HunterKaraTest
	{
		// ---------------------------------------- MINION - HUNTER
		// [KAR_005] Kindly Grandmother - COST:2 [ATK:1/HP:1] 
		// - Race: beast, Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a 3/2 Big Bad Wolf.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KindlyGrandmother_KAR_005()
		{
			// TODO KindlyGrandmother_KAR_005 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kindly Grandmother"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kindly Grandmother"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kindly Grandmother"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [KAR_006] Cloaked Huntress - COST:3 [ATK:3/HP:4] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: Your <b>Secrets</b> cost (0).
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CloakedHuntress_KAR_006()
		{
			// TODO CloakedHuntress_KAR_006 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cloaked Huntress"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cloaked Huntress"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cloaked Huntress"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [KAR_004] Cat Trick - COST:2 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Secret:</b> After your opponent casts a spell, summon a 4/2 Panther with <b>Stealth</b>.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		// RefTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CatTrick_KAR_004()
		{
			// TODO CatTrick_KAR_004 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cat Trick"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cat Trick"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cat Trick"));
		}

	}

	public class MageKaraTest
	{
		// ------------------------------------------ MINION - MAGE
		// [KAR_009] Babbling Book - COST:1 [ATK:1/HP:1] 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add a random Mage spell to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BabblingBook_KAR_009()
		{
			// TODO BabblingBook_KAR_009 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Babbling Book"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Babbling Book"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Babbling Book"));
		}

		// ------------------------------------------ MINION - MAGE
		// [KAR_092] Medivh's Valet - COST:2 [ATK:2/HP:3] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you control a <b>Secret</b>, deal 3 damage.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_SECRETS = 1
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MedivhsValet_KAR_092()
		{
			// TODO MedivhsValet_KAR_092 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Medivh's Valet"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Medivh's Valet"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Medivh's Valet"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [KAR_076] Firelands Portal - COST:7 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $5 damage. Summon a random
		//       5-Cost minion. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FirelandsPortal_KAR_076()
		{
			// TODO FirelandsPortal_KAR_076 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Firelands Portal"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Firelands Portal"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Firelands Portal"));
		}

	}

	public class PaladinKaraTest
	{
		// --------------------------------------- MINION - PALADIN
		// [KAR_010] Nightbane Templar - COST:3 [ATK:2/HP:3] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding a Dragon, summon two 1/1 Whelps.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NightbaneTemplar_KAR_010()
		{
			// TODO NightbaneTemplar_KAR_010 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nightbane Templar"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nightbane Templar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nightbane Templar"));
		}

		// --------------------------------------- MINION - PALADIN
		// [KAR_057] Ivory Knight - COST:6 [ATK:4/HP:4] 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> <b>Discover</b> a spell.
		//       Restore Health to your hero
		//       equal to its Cost.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IvoryKnight_KAR_057()
		{
			// TODO IvoryKnight_KAR_057 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ivory Knight"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ivory Knight"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ivory Knight"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [KAR_077] Silvermoon Portal - COST:4 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: Give a minion +2/+2. Summon a random
		//       2-Cost minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SilvermoonPortal_KAR_077()
		{
			// TODO SilvermoonPortal_KAR_077 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Silvermoon Portal"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Silvermoon Portal"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Silvermoon Portal"));
		}

	}

	public class PriestKaraTest
	{
		// ---------------------------------------- MINION - PRIEST
		// [KAR_035] Priest of the Feast - COST:4 [ATK:3/HP:6] 
		// - Fac: neutral, Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, restore 3 Health to
		//       your hero.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PriestOfTheFeast_KAR_035()
		{
			// TODO PriestOfTheFeast_KAR_035 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Priest of the Feast"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Priest of the Feast"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Priest of the Feast"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [KAR_204] Onyx Bishop - COST:5 [ATK:3/HP:4] 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a friendly minion that died this game.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OnyxBishop_KAR_204()
		{
			// TODO OnyxBishop_KAR_204 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Onyx Bishop"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Onyx Bishop"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Onyx Bishop"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [KAR_013] Purify - COST:2 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Silence</b> a friendly minion. Draw a card.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - SILENCE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Purify_KAR_013()
		{
			// TODO Purify_KAR_013 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Purify"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Purify"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Purify"));
		}

	}

	public class RogueKaraTest
	{
		// ----------------------------------------- MINION - ROGUE
		// [KAR_069] Swashburglar - COST:1 [ATK:1/HP:1] 
		// - Race: pirate, Fac: neutral, Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add a random class card to your hand <i>(from your opponent's class).</i>
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Swashburglar_KAR_069()
		{
			// TODO Swashburglar_KAR_069 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Swashburglar"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Swashburglar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Swashburglar"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [KAR_070] Ethereal Peddler - COST:5 [ATK:5/HP:6] 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If you're holding
		//       any non-Rogue class cards,
		//       _reduce their Cost by (2).
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EtherealPeddler_KAR_070()
		{
			// TODO EtherealPeddler_KAR_070 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ethereal Peddler"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ethereal Peddler"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ethereal Peddler"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [KAR_094] Deadly Fork - COST:3 [ATK:3/HP:2] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Add a 3/2 weapon to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DeadlyFork_KAR_094()
		{
			// TODO DeadlyFork_KAR_094 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Deadly Fork"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Deadly Fork"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Deadly Fork"));
		}

	}

	public class ShamanKaraTest
	{
		// ---------------------------------------- MINION - SHAMAN
		// [KAR_021] Wicked Witchdoctor - COST:4 [ATK:3/HP:4] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, summon a random basic_Totem.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WickedWitchdoctor_KAR_021()
		{
			// TODO WickedWitchdoctor_KAR_021 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wicked Witchdoctor"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wicked Witchdoctor"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wicked Witchdoctor"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [KAR_073] Maelstrom Portal - COST:2 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal_$1_damage to_all_enemy_minions. Summon_a_random
		//       1-Cost minion. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MaelstromPortal_KAR_073()
		{
			// TODO MaelstromPortal_KAR_073 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Maelstrom Portal"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Maelstrom Portal"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Maelstrom Portal"));
		}

		// ---------------------------------------- WEAPON - SHAMAN
		// [KAR_063] Spirit Claws - COST:2 [ATK:1/HP:0] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: [x]Has +2 Attack while you
		//       have <b>Spell Damage</b>.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 3
		// --------------------------------------------------------
		// RefTag:
		// - SPELLPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SpiritClaws_KAR_063()
		{
			// TODO SpiritClaws_KAR_063 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spirit Claws"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spirit Claws"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Spirit Claws"));
		}

	}

	public class WarlockKaraTest
	{
		// --------------------------------------- MINION - WARLOCK
		// [KAR_089] Malchezaar's Imp - COST:1 [ATK:1/HP:3] 
		// - Race: demon, Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever you discard a card, draw a card.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MalchezaarsImp_KAR_089()
		{
			// TODO MalchezaarsImp_KAR_089 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Malchezaar's Imp"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Malchezaar's Imp"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Malchezaar's Imp"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [KAR_205] Silverware Golem - COST:3 [ATK:3/HP:3] 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: If you discard this minion, summon it.
		// --------------------------------------------------------
		// GameTag:
		// - InvisibleDeathrattle = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SilverwareGolem_KAR_205()
		{
			// TODO SilverwareGolem_KAR_205 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Silverware Golem"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Silverware Golem"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Silverware Golem"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [KAR_025] Kara Kazham! - COST:5 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: Summon a 1/1 Candle, 2/2 Broom, and 3/3 Teapot.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KaraKazham_KAR_025()
		{
			// TODO KaraKazham_KAR_025 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kara Kazham!"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kara Kazham!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kara Kazham!"));
		}

	}

	public class WarriorKaraTest
	{
		// ---------------------------------------- SPELL - WARRIOR
		// [KAR_026] Protect the King! - COST:3 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: For each enemy minion, summon a 1/1 Pawn with <b>Taunt</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// - REQ_MINIMUM_ENEMY_MINIONS = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ProtectTheKing_KAR_026()
		{
			// TODO ProtectTheKing_KAR_026 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Protect the King!"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Protect the King!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Protect the King!"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [KAR_091] Ironforge Portal - COST:5 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: Gain 4 Armor.
		//       Summon a random
		//       4-Cost minion.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IronforgePortal_KAR_091()
		{
			// TODO IronforgePortal_KAR_091 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ironforge Portal"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ironforge Portal"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ironforge Portal"));
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [KAR_028] Fool's Bane - COST:5 [ATK:3/HP:0] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: Unlimited attacks each turn. Can't attack heroes.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 4
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FoolsBane_KAR_028()
		{
			// TODO FoolsBane_KAR_028 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fool's Bane"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fool's Bane"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fool's Bane"));
		}

	}

	public class NeutralKaraTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [KAR_011] Pompous Thespian - COST:2 [ATK:3/HP:2] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PompousThespian_KAR_011()
		{
			// TODO PompousThespian_KAR_011 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Pompous Thespian"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pompous Thespian"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Pompous Thespian"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_029] Runic Egg - COST:1 [ATK:0/HP:2] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Draw a card.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RunicEgg_KAR_029()
		{
			// TODO RunicEgg_KAR_029 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Runic Egg"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Runic Egg"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Runic Egg"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_030a] Pantry Spider - COST:3 [ATK:1/HP:3] 
		// - Race: beast, Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a
		//       1/3 Spider.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PantrySpider_KAR_030a()
		{
			// TODO PantrySpider_KAR_030a test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Pantry Spider"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pantry Spider"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Pantry Spider"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_033] Book Wyrm - COST:6 [ATK:3/HP:6] 
		// - Race: dragon, Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding a Dragon, destroy an enemy minion with 3 or less Attack.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_MAX_ATTACK = 3
		// - REQ_NONSELF_TARGET = 0
		// - REQ_ENEMY_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BookWyrm_KAR_033()
		{
			// TODO BookWyrm_KAR_033 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Book Wyrm"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Book Wyrm"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Book Wyrm"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_036] Arcane Anomaly - COST:1 [ATK:2/HP:1] 
		// - Race: elemental, Fac: neutral, Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, give this minion
		//       +1 Health.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArcaneAnomaly_KAR_036()
		{
			// TODO ArcaneAnomaly_KAR_036 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arcane Anomaly"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Anomaly"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Arcane Anomaly"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_037] Avian Watcher - COST:5 [ATK:3/HP:6] 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you control a <b>Secret</b>, gain +1/+1
		//       and <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AvianWatcher_KAR_037()
		{
			// TODO AvianWatcher_KAR_037 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Avian Watcher"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Avian Watcher"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Avian Watcher"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_041] Moat Lurker - COST:6 [ATK:3/HP:3] 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy a minion. <b>Deathrattle:</b> Resummon it.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MoatLurker_KAR_041()
		{
			// TODO MoatLurker_KAR_041 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Moat Lurker"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Moat Lurker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Moat Lurker"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_044] Moroes - COST:3 [ATK:1/HP:1] 
		// - Set: kara, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Stealth</b>
		//       At the end of your turn, summon a 1/1 Steward.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Moroes_KAR_044()
		{
			// TODO Moroes_KAR_044 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Moroes"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Moroes"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Moroes"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_061] The Curator - COST:7 [ATK:4/HP:6] 
		// - Race: mechanical, Set: kara, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Battlecry:</b> Draw a Beast, Dragon, and Murloc from your deck.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheCurator_KAR_061()
		{
			// TODO TheCurator_KAR_061 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Curator"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Curator"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Curator"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_062] Netherspite Historian - COST:2 [ATK:1/HP:3] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding a Dragon, <b>Discover</b>
		//       a Dragon.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NetherspiteHistorian_KAR_062()
		{
			// TODO NetherspiteHistorian_KAR_062 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Netherspite Historian"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Netherspite Historian"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Netherspite Historian"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_095] Zoobot - COST:3 [ATK:3/HP:3] 
		// - Race: mechanical, Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a random friendly Beast, Dragon, and Murloc +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Zoobot_KAR_095()
		{
			// TODO Zoobot_KAR_095 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Zoobot"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Zoobot"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Zoobot"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_096] Prince Malchezaar - COST:5 [ATK:5/HP:6] 
		// - Race: demon, Set: kara, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]When the game starts,
		//       add 5 extra <b>Legendary</b>
		//       minions to your deck.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PrinceMalchezaar_KAR_096()
		{
			// TODO PrinceMalchezaar_KAR_096 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Prince Malchezaar"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Prince Malchezaar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Prince Malchezaar"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_097] Medivh, the Guardian - COST:8 [ATK:7/HP:7] 
		// - Set: kara, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Equip Atiesh, Greatstaff of the Guardian.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MedivhTheGuardian_KAR_097()
		{
			// TODO MedivhTheGuardian_KAR_097 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Medivh, the Guardian"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Medivh, the Guardian"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Medivh, the Guardian"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_114] Barnes - COST:4 [ATK:3/HP:4] 
		// - Set: kara, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 1/1 copy of a random minion in your deck.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Barnes_KAR_114()
		{
			// TODO Barnes_KAR_114 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Barnes"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Barnes"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Barnes"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_702] Menagerie Magician - COST:5 [ATK:4/HP:4] 
		// - Fac: neutral, Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a random friendly Beast, Dragon, and Murloc +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MenagerieMagician_KAR_702()
		{
			// TODO MenagerieMagician_KAR_702 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Menagerie Magician"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Menagerie Magician"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Menagerie Magician"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_710] Arcanosmith - COST:4 [ATK:3/HP:2] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 0/5 minion with <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Arcanosmith_KAR_710()
		{
			// TODO Arcanosmith_KAR_710 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arcanosmith"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcanosmith"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Arcanosmith"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_711] Arcane Giant - COST:12 [ATK:8/HP:8] 
		// - Set: kara, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]Costs (1) less for each spell
		//       you've cast this game.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArcaneGiant_KAR_711()
		{
			// TODO ArcaneGiant_KAR_711 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arcane Giant"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Giant"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Arcane Giant"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_712] Violet Illusionist - COST:3 [ATK:4/HP:3] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: During your turn, your hero is <b>Immune</b>.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		// RefTag:
		// - IMMUNE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VioletIllusionist_KAR_712()
		{
			// TODO VioletIllusionist_KAR_712 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Violet Illusionist"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Violet Illusionist"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Violet Illusionist"));
		}

	}

}
