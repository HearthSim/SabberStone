using Xunit;
using SabberStoneCore.Enums;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCoreTest.CardSets.Adventure
{
	public class HeroesNaxxTest
	{
		// ----------------------------------------- HERO - NEUTRAL
		// [NAX10_01] Patchwerk (*) - COST:0 [ATK:0/HP:30] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// - HERO_POWER = 1886
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Patchwerk_NAX10_01()
		{
			// TODO Patchwerk_NAX10_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Patchwerk"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Patchwerk"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Patchwerk"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX10_01H] Patchwerk (*) - COST:0 [ATK:0/HP:45] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// - HERO_POWER = 2133
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Patchwerk_NAX10_01H()
		{
			// TODO Patchwerk_NAX10_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Patchwerk"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Patchwerk"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Patchwerk"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX11_01] Grobbulus (*) - COST:0 [ATK:0/HP:30] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1888
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Grobbulus_NAX11_01()
		{
			// TODO Grobbulus_NAX11_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grobbulus"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grobbulus"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grobbulus"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX11_01H] Grobbulus (*) - COST:0 [ATK:0/HP:45] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2135
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Grobbulus_NAX11_01H()
		{
			// TODO Grobbulus_NAX11_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grobbulus"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grobbulus"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grobbulus"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX12_01] Gluth (*) - COST:0 [ATK:0/HP:30] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1891
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Gluth_NAX12_01()
		{
			// TODO Gluth_NAX12_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gluth"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gluth"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gluth"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX12_01H] Gluth (*) - COST:0 [ATK:0/HP:45] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2141
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Gluth_NAX12_01H()
		{
			// TODO Gluth_NAX12_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gluth"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gluth"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gluth"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX13_01] Thaddius (*) - COST:0 [ATK:0/HP:30] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1897
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Thaddius_NAX13_01()
		{
			// TODO Thaddius_NAX13_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Thaddius"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Thaddius"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Thaddius"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX13_01H] Thaddius (*) - COST:0 [ATK:0/HP:45] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1897
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Thaddius_NAX13_01H()
		{
			// TODO Thaddius_NAX13_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Thaddius"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Thaddius"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Thaddius"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX14_01] Sapphiron (*) - COST:0 [ATK:0/HP:30] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1905
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Sapphiron_NAX14_01()
		{
			// TODO Sapphiron_NAX14_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sapphiron"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sapphiron"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sapphiron"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX14_01H] Sapphiron (*) - COST:0 [ATK:0/HP:45] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1905
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Sapphiron_NAX14_01H()
		{
			// TODO Sapphiron_NAX14_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sapphiron"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sapphiron"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sapphiron"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX15_01] Kel'Thuzad (*) - COST:0 [ATK:0/HP:30] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1901
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Kelthuzad_NAX15_01()
		{
			// TODO Kelthuzad_NAX15_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kel'Thuzad"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kel'Thuzad"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kel'Thuzad"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX15_01H] Kel'Thuzad (*) - COST:0 [ATK:0/HP:45] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2148
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Kelthuzad_NAX15_01H()
		{
			// TODO Kelthuzad_NAX15_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kel'Thuzad"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kel'Thuzad"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kel'Thuzad"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX1_01] Anub'Rekhan (*) - COST:0 [ATK:0/HP:30] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1831
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Anubrekhan_NAX1_01()
		{
			// TODO Anubrekhan_NAX1_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Anub'Rekhan"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Anub'Rekhan"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Anub'Rekhan"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX1h_01] Anub'Rekhan (*) - COST:0 [ATK:0/HP:45] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2103
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Anubrekhan_NAX1h_01()
		{
			// TODO Anubrekhan_NAX1h_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Anub'Rekhan"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Anub'Rekhan"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Anub'Rekhan"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX2_01] Grand Widow Faerlina (*) - COST:0 [ATK:0/HP:30] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1840
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GrandWidowFaerlina_NAX2_01()
		{
			// TODO GrandWidowFaerlina_NAX2_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grand Widow Faerlina"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grand Widow Faerlina"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grand Widow Faerlina"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX2_01H] Grand Widow Faerlina (*) - COST:0 [ATK:0/HP:45] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2105
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GrandWidowFaerlina_NAX2_01H()
		{
			// TODO GrandWidowFaerlina_NAX2_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grand Widow Faerlina"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grand Widow Faerlina"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grand Widow Faerlina"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX3_01] Maexxna (*) - COST:0 [ATK:0/HP:30] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1867
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Maexxna_NAX3_01()
		{
			// TODO Maexxna_NAX3_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Maexxna"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Maexxna"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Maexxna"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX3_01H] Maexxna (*) - COST:0 [ATK:0/HP:45] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2107
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Maexxna_NAX3_01H()
		{
			// TODO Maexxna_NAX3_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Maexxna"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Maexxna"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Maexxna"));
		}

		// -------------------------------------------- HERO - MAGE
		// [NAX4_01] Noth the Plaguebringer (*) - COST:0 [ATK:0/HP:30] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1849
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NothThePlaguebringer_NAX4_01()
		{
			// TODO NothThePlaguebringer_NAX4_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Noth the Plaguebringer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Noth the Plaguebringer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Noth the Plaguebringer"));
		}

		// -------------------------------------------- HERO - MAGE
		// [NAX4_01H] Noth the Plaguebringer (*) - COST:0 [ATK:0/HP:45] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2115
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NothThePlaguebringer_NAX4_01H()
		{
			// TODO NothThePlaguebringer_NAX4_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Noth the Plaguebringer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Noth the Plaguebringer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Noth the Plaguebringer"));
		}

		// ----------------------------------------- HERO - WARLOCK
		// [NAX5_01] Heigan the Unclean (*) - COST:0 [ATK:0/HP:30] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1854
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HeiganTheUnclean_NAX5_01()
		{
			// TODO HeiganTheUnclean_NAX5_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Heigan the Unclean"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Heigan the Unclean"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Heigan the Unclean"));
		}

		// ----------------------------------------- HERO - WARLOCK
		// [NAX5_01H] Heigan the Unclean (*) - COST:0 [ATK:0/HP:45] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2117
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HeiganTheUnclean_NAX5_01H()
		{
			// TODO HeiganTheUnclean_NAX5_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Heigan the Unclean"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Heigan the Unclean"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Heigan the Unclean"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX6_01] Loatheb (*) - COST:0 [ATK:0/HP:75] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1862
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Loatheb_NAX6_01()
		{
			// TODO Loatheb_NAX6_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Loatheb"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loatheb"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Loatheb"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX6_01H] Loatheb (*) - COST:0 [ATK:0/HP:99] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2119
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Loatheb_NAX6_01H()
		{
			// TODO Loatheb_NAX6_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Loatheb"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loatheb"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Loatheb"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX7_01] Instructor Razuvious (*) - COST:0 [ATK:0/HP:40] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1870
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void InstructorRazuvious_NAX7_01()
		{
			// TODO InstructorRazuvious_NAX7_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Instructor Razuvious"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Instructor Razuvious"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Instructor Razuvious"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX7_01H] Instructor Razuvious (*) - COST:0 [ATK:0/HP:55] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2129
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void InstructorRazuvious_NAX7_01H()
		{
			// TODO InstructorRazuvious_NAX7_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Instructor Razuvious"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Instructor Razuvious"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Instructor Razuvious"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX8_01] Gothik the Harvester (*) - COST:0 [ATK:0/HP:30] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1872
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GothikTheHarvester_NAX8_01()
		{
			// TODO GothikTheHarvester_NAX8_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gothik the Harvester"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gothik the Harvester"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gothik the Harvester"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX8_01H] Gothik the Harvester (*) - COST:0 [ATK:0/HP:45] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2121
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GothikTheHarvester_NAX8_01H()
		{
			// TODO GothikTheHarvester_NAX8_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gothik the Harvester"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gothik the Harvester"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gothik the Harvester"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX9_01] Baron Rivendare (*) - COST:0 [ATK:0/HP:7] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1883
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BaronRivendare_NAX9_01()
		{
			// TODO BaronRivendare_NAX9_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Baron Rivendare"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Baron Rivendare"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Baron Rivendare"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [NAX9_01H] Baron Rivendare (*) - COST:0 [ATK:0/HP:14] 
		// - Set: naxx, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1883
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BaronRivendare_NAX9_01H()
		{
			// TODO BaronRivendare_NAX9_01H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Baron Rivendare"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Baron Rivendare"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Baron Rivendare"));
		}

	}

	public class HeroPowersNaxxTest
	{
		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX10_03] Hateful Strike (*) - COST:4 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Destroy a minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HatefulStrike_NAX10_03()
		{
			// TODO HatefulStrike_NAX10_03 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hateful Strike"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hateful Strike"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hateful Strike"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX10_03H] Hateful Strike (*) - COST:4 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Destroy a minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HatefulStrike_NAX10_03H()
		{
			// TODO HatefulStrike_NAX10_03H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hateful Strike"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hateful Strike"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hateful Strike"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX11_02] Poison Cloud (*) - COST:2 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 1 damage to all minions. If any die, summon a slime.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PoisonCloud_NAX11_02()
		{
			// TODO PoisonCloud_NAX11_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Poison Cloud"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Poison Cloud"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Poison Cloud"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX11_02H] Poison Cloud (*) - COST:0 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 2 damage to all enemies. If any die, summon a slime.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PoisonCloud_NAX11_02H()
		{
			// TODO PoisonCloud_NAX11_02H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Poison Cloud"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Poison Cloud"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Poison Cloud"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX12_02] Decimate (*) - COST:2 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Change the Health of all minions to 1.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINIMUM_ENEMY_MINIONS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Decimate_NAX12_02()
		{
			// TODO Decimate_NAX12_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Decimate"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Decimate"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Decimate"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX12_02H] Decimate (*) - COST:0 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Change the Health of enemy minions to 1.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINIMUM_ENEMY_MINIONS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Decimate_NAX12_02H()
		{
			// TODO Decimate_NAX12_02H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Decimate"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Decimate"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Decimate"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX13_02] Polarity Shift (*) - COST:0 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Swap the Attack and Health of all minions.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PolarityShift_NAX13_02()
		{
			// TODO PolarityShift_NAX13_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Polarity Shift"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Polarity Shift"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Polarity Shift"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX14_02] Frost Breath (*) - COST:0 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Destroy all enemy minions that aren't <b>Frozen</b>.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FrostBreath_NAX14_02()
		{
			// TODO FrostBreath_NAX14_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Frost Breath"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frost Breath"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Frost Breath"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX15_02] Frost Blast (*) - COST:0 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 2 damage to the enemy hero and <b>Freeze</b> it.
		// --------------------------------------------------------
		// GameTag:
		// - FREEZE = 1
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FrostBlast_NAX15_02()
		{
			// TODO FrostBlast_NAX15_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Frost Blast"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frost Blast"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Frost Blast"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX15_02H] Frost Blast (*) - COST:0 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 3 damage to the enemy hero and <b>Freeze</b> it.
		// --------------------------------------------------------
		// GameTag:
		// - FREEZE = 1
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FrostBlast_NAX15_02H()
		{
			// TODO FrostBlast_NAX15_02H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Frost Blast"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frost Blast"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Frost Blast"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX15_04] Chains (*) - COST:8 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Take control of a random enemy minion until end of turn.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Chains_NAX15_04()
		{
			// TODO Chains_NAX15_04 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Chains"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chains"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Chains"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX15_04H] Chains (*) - COST:8 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Take control of a random enemy minion.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Chains_NAX15_04H()
		{
			// TODO Chains_NAX15_04H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Chains"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chains"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Chains"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX1_04] Skitter (*) - COST:2 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 3/1 Nerubian.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Skitter_NAX1_04()
		{
			// TODO Skitter_NAX1_04 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Skitter"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Skitter"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Skitter"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX1h_04] Skitter (*) - COST:2 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 4/4 Nerubian.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Skitter_NAX1h_04()
		{
			// TODO Skitter_NAX1h_04 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Skitter"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Skitter"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Skitter"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX2_03] Rain of Fire (*) - COST:2 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Fire a missile for each card in your opponent's hand.
		// --------------------------------------------------------
		// GameTag:
		// - ImmuneToSpellpower = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RainOfFire_NAX2_03()
		{
			// TODO RainOfFire_NAX2_03 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rain of Fire"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rain of Fire"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rain of Fire"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX2_03H] Rain of Fire (*) - COST:1 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Fire a missile for each card in your opponent's hand.
		// --------------------------------------------------------
		// GameTag:
		// - ImmuneToSpellpower = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RainOfFire_NAX2_03H()
		{
			// TODO RainOfFire_NAX2_03H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rain of Fire"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rain of Fire"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rain of Fire"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX3_02] Web Wrap (*) - COST:3 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Return a random enemy minion to your opponent's hand.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINIMUM_ENEMY_MINIONS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WebWrap_NAX3_02()
		{
			// TODO WebWrap_NAX3_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Web Wrap"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Web Wrap"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Web Wrap"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX3_02H] Web Wrap (*) - COST:0 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Return 2 random enemy minions to your opponent's hand.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WebWrap_NAX3_02H()
		{
			// TODO WebWrap_NAX3_02H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Web Wrap"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Web Wrap"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Web Wrap"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX4_04] Raise Dead (*) - COST:0 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Whenever an enemy dies, raise a 1/1 Skeleton.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RaiseDead_NAX4_04()
		{
			// TODO RaiseDead_NAX4_04 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Raise Dead"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Raise Dead"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Raise Dead"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX4_04H] Raise Dead (*) - COST:0 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       Whenever an enemy dies, raise a 5/5 Skeleton.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RaiseDead_NAX4_04H()
		{
			// TODO RaiseDead_NAX4_04H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Raise Dead"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Raise Dead"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Raise Dead"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX5_02] Eruption (*) - COST:1 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 2 damage to the left-most enemy minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINIMUM_ENEMY_MINIONS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Eruption_NAX5_02()
		{
			// TODO Eruption_NAX5_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Eruption"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eruption"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Eruption"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX5_02H] Eruption (*) - COST:0 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 3 damage to the left-most enemy minion.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINIMUM_ENEMY_MINIONS = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Eruption_NAX5_02H()
		{
			// TODO Eruption_NAX5_02H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Eruption"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eruption"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Eruption"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX6_02] Necrotic Aura (*) - COST:2 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 3 damage to the enemy hero.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NecroticAura_NAX6_02()
		{
			// TODO NecroticAura_NAX6_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Necrotic Aura"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Necrotic Aura"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Necrotic Aura"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX6_02H] Necrotic Aura (*) - COST:0 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 3 damage to the enemy hero.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NecroticAura_NAX6_02H()
		{
			// TODO NecroticAura_NAX6_02H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Necrotic Aura"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Necrotic Aura"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Necrotic Aura"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX7_03] Unbalancing Strike (*) - COST:2 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 3 damage.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnbalancingStrike_NAX7_03()
		{
			// TODO UnbalancingStrike_NAX7_03 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unbalancing Strike"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unbalancing Strike"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Unbalancing Strike"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX7_03H] Unbalancing Strike (*) - COST:1 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 4 damage.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnbalancingStrike_NAX7_03H()
		{
			// TODO UnbalancingStrike_NAX7_03H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unbalancing Strike"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unbalancing Strike"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Unbalancing Strike"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX8_02] Harvest (*) - COST:2 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Draw a card.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Harvest_NAX8_02()
		{
			// TODO Harvest_NAX8_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Harvest"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Harvest"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Harvest"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX8_02H] Harvest (*) - COST:1 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Draw a card. Gain a Mana Crystal.
		// --------------------------------------------------------
		// GameTag:
		// - AI_MUST_PLAY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Harvest_NAX8_02H()
		{
			// TODO Harvest_NAX8_02H test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Harvest"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Harvest"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Harvest"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [NAX9_06] Unholy Shadow (*) - COST:5 
		// - Set: naxx, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Draw 2 cards.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnholyShadow_NAX9_06()
		{
			// TODO UnholyShadow_NAX9_06 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unholy Shadow"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unholy Shadow"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Unholy Shadow"));
		}

	}

	public class DruidNaxxTest
	{
		// ------------------------------------------ SPELL - DRUID
		// [FP1_019] Poison Seeds - COST:4 
		// - Set: naxx, Rarity: common
		// --------------------------------------------------------
		// Text: Destroy all minions and summon 2/2 Treants to replace them.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PoisonSeeds_FP1_019()
		{
			// TODO PoisonSeeds_FP1_019 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Poison Seeds"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Poison Seeds"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Poison Seeds"));
		}

	}

	public class HunterNaxxTest
	{
		// ---------------------------------------- MINION - HUNTER
		// [FP1_011] Webspinner - COST:1 [ATK:1/HP:1] 
		// - Race: beast, Set: naxx, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Add a random Beast card to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Webspinner_FP1_011()
		{
			// TODO Webspinner_FP1_011 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Webspinner"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Webspinner"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Webspinner"));
		}

	}

	public class MageNaxxTest
	{
		// ------------------------------------------- SPELL - MAGE
		// [FP1_018] Duplicate - COST:3 
		// - Set: naxx, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When a friendly minion dies, put 2 copies of it into your hand.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Duplicate_FP1_018()
		{
			// TODO Duplicate_FP1_018 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Duplicate"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Duplicate"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Duplicate"));
		}

	}

	public class PaladinNaxxTest
	{
		// ---------------------------------------- SPELL - PALADIN
		// [FP1_020] Avenge - COST:1 
		// - Set: naxx, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When one of your minions dies, give a random friendly minion +3/+2.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Avenge_FP1_020()
		{
			// TODO Avenge_FP1_020 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Avenge"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Avenge"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Avenge"));
		}

	}

	public class PriestNaxxTest
	{
		// ---------------------------------------- MINION - PRIEST
		// [FP1_023] Dark Cultist - COST:3 [ATK:3/HP:4] 
		// - Set: naxx, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Give a random friendly minion +3 Health.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DarkCultist_FP1_023()
		{
			// TODO DarkCultist_FP1_023 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dark Cultist"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dark Cultist"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dark Cultist"));
		}

	}

	public class RogueNaxxTest
	{
		// ----------------------------------------- MINION - ROGUE
		// [FP1_026] Anub'ar Ambusher - COST:4 [ATK:5/HP:5] 
		// - Set: naxx, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Return a random friendly minion to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AnubarAmbusher_FP1_026()
		{
			// TODO AnubarAmbusher_FP1_026 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Anub'ar Ambusher"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Anub'ar Ambusher"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Anub'ar Ambusher"));
		}

	}

	public class ShamanNaxxTest
	{
		// ----------------------------------------- SPELL - SHAMAN
		// [FP1_025] Reincarnate - COST:2 
		// - Set: naxx, Rarity: common
		// --------------------------------------------------------
		// Text: Destroy a minion, then return it to life with full Health.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Reincarnate_FP1_025()
		{
			// TODO Reincarnate_FP1_025 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Reincarnate"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Reincarnate"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Reincarnate"));
		}

	}

	public class WarlockNaxxTest
	{
		// --------------------------------------- MINION - WARLOCK
		// [FP1_022] Voidcaller - COST:4 [ATK:3/HP:4] 
		// - Race: demon, Set: naxx, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Put a random Demon from your hand into the battlefield.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Voidcaller_FP1_022()
		{
			// TODO Voidcaller_FP1_022 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Voidcaller"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Voidcaller"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Voidcaller"));
		}

	}

	public class WarriorNaxxTest
	{
		// --------------------------------------- WEAPON - WARRIOR
		// [FP1_021] Death's Bite - COST:4 [ATK:4/HP:0] 
		// - Set: naxx, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Deal 1 damage to all minions.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DeathsBite_FP1_021()
		{
			// TODO DeathsBite_FP1_021 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Death's Bite"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Death's Bite"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Death's Bite"));
		}

	}

	public class NeutralNaxxTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [FP1_001] Zombie Chow - COST:1 [ATK:2/HP:3] 
		// - Set: naxx, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Restore 5 Health to the enemy hero.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ZombieChow_FP1_001()
		{
			// TODO ZombieChow_FP1_001 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Zombie Chow"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Zombie Chow"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Zombie Chow"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [FP1_002] Haunted Creeper - COST:2 [ATK:1/HP:2] 
		// - Race: beast, Set: naxx, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon two 1/1 Spectral Spiders.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HauntedCreeper_FP1_002()
		{
			// TODO HauntedCreeper_FP1_002 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Haunted Creeper"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Haunted Creeper"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Haunted Creeper"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [FP1_003] Echoing Ooze - COST:2 [ATK:1/HP:2] 
		// - Set: naxx, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon an exact copy of this minion at the end of the turn.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EchoingOoze_FP1_003()
		{
			// TODO EchoingOoze_FP1_003 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Echoing Ooze"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Echoing Ooze"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Echoing Ooze"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [FP1_004] Mad Scientist - COST:2 [ATK:2/HP:2] 
		// - Set: naxx, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Put a <b>Secret</b> from your deck into the battlefield.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MadScientist_FP1_004()
		{
			// TODO MadScientist_FP1_004 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mad Scientist"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mad Scientist"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mad Scientist"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [FP1_005] Shade of Naxxramas - COST:3 [ATK:2/HP:2] 
		// - Set: naxx, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Stealth.</b> At the start of your turn, gain +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShadeOfNaxxramas_FP1_005()
		{
			// TODO ShadeOfNaxxramas_FP1_005 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shade of Naxxramas"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shade of Naxxramas"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shade of Naxxramas"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [FP1_007] Nerubian Egg - COST:2 [ATK:0/HP:2] 
		// - Set: naxx, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a 4/4 Nerubian.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NerubianEgg_FP1_007()
		{
			// TODO NerubianEgg_FP1_007 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nerubian Egg"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nerubian Egg"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nerubian Egg"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [FP1_008] Spectral Knight - COST:5 [ATK:4/HP:6] 
		// - Set: naxx, Rarity: common
		// --------------------------------------------------------
		// Text: Can't be targeted by spells or Hero Powers.
		// --------------------------------------------------------
		// GameTag:
		// - CANT_BE_TARGETED_BY_SPELLS = 1
		// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SpectralKnight_FP1_008()
		{
			// TODO SpectralKnight_FP1_008 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spectral Knight"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spectral Knight"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Spectral Knight"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [FP1_009] Deathlord - COST:3 [ATK:2/HP:8] 
		// - Set: naxx, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Taunt. Deathrattle:</b> Your opponent puts a minion from their deck into the battlefield.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Deathlord_FP1_009()
		{
			// TODO Deathlord_FP1_009 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Deathlord"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Deathlord"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Deathlord"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [FP1_010] Maexxna - COST:6 [ATK:2/HP:8] 
		// - Race: beast, Set: naxx, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Poisonous</b>
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Maexxna_FP1_010()
		{
			// TODO Maexxna_FP1_010 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Maexxna"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Maexxna"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Maexxna"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [FP1_012] Sludge Belcher - COST:5 [ATK:3/HP:5] 
		// - Set: naxx, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Taunt
		//       Deathrattle:</b> Summon a 1/2 Slime with <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SludgeBelcher_FP1_012()
		{
			// TODO SludgeBelcher_FP1_012 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sludge Belcher"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sludge Belcher"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sludge Belcher"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [FP1_013] Kel'Thuzad - COST:8 [ATK:6/HP:8] 
		// - Set: naxx, Rarity: legendary
		// --------------------------------------------------------
		// Text: At the end of each turn, summon all friendly minions that died this turn.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Kelthuzad_FP1_013()
		{
			// TODO Kelthuzad_FP1_013 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kel'Thuzad"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kel'Thuzad"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kel'Thuzad"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [FP1_014] Stalagg - COST:5 [ATK:7/HP:4] 
		// - Set: naxx, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> If Feugen also died this game, summon Thaddius.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Stalagg_FP1_014()
		{
			// TODO Stalagg_FP1_014 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stalagg"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stalagg"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stalagg"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [FP1_015] Feugen - COST:5 [ATK:4/HP:7] 
		// - Set: naxx, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> If Stalagg also died this game, summon Thaddius.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Feugen_FP1_015()
		{
			// TODO Feugen_FP1_015 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Feugen"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Feugen"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Feugen"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [FP1_016] Wailing Soul - COST:4 [ATK:3/HP:5] 
		// - Set: naxx, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry: Silence</b> your other minions.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - SILENCE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WailingSoul_FP1_016()
		{
			// TODO WailingSoul_FP1_016 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wailing Soul"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wailing Soul"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wailing Soul"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [FP1_017] Nerub'ar Weblord - COST:2 [ATK:1/HP:4] 
		// - Set: naxx, Rarity: common
		// --------------------------------------------------------
		// Text: Minions with <b>Battlecry</b> cost (2) more.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		// RefTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NerubarWeblord_FP1_017()
		{
			// TODO NerubarWeblord_FP1_017 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nerub'ar Weblord"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nerub'ar Weblord"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nerub'ar Weblord"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [FP1_024] Unstable Ghoul - COST:2 [ATK:1/HP:3] 
		// - Set: naxx, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>. <b>Deathrattle:</b> Deal 1 damage to all minions.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnstableGhoul_FP1_024()
		{
			// TODO UnstableGhoul_FP1_024 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unstable Ghoul"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unstable Ghoul"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Unstable Ghoul"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [FP1_027] Stoneskin Gargoyle - COST:3 [ATK:1/HP:4] 
		// - Set: naxx, Rarity: common
		// --------------------------------------------------------
		// Text: At the start of your turn, restore this minion to full Health.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StoneskinGargoyle_FP1_027()
		{
			// TODO StoneskinGargoyle_FP1_027 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stoneskin Gargoyle"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stoneskin Gargoyle"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stoneskin Gargoyle"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [FP1_028] Undertaker - COST:1 [ATK:1/HP:2] 
		// - Set: naxx, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever you summon a minion with <b>Deathrattle</b>, gain +1 Attack.
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Undertaker_FP1_028()
		{
			// TODO Undertaker_FP1_028 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Undertaker"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Undertaker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Undertaker"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [FP1_029] Dancing Swords - COST:3 [ATK:4/HP:4] 
		// - Set: naxx, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Your opponent draws a card.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DancingSwords_FP1_029()
		{
			// TODO DancingSwords_FP1_029 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dancing Swords"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dancing Swords"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dancing Swords"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [FP1_030] Loatheb - COST:5 [ATK:5/HP:5] 
		// - Set: naxx, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Enemy spells cost (5) more next turn.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Loatheb_FP1_030()
		{
			// TODO Loatheb_FP1_030 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Loatheb"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loatheb"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Loatheb"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [FP1_031] Baron Rivendare - COST:4 [ATK:1/HP:7] 
		// - Set: naxx, Rarity: legendary
		// --------------------------------------------------------
		// Text: Your minions trigger their <b>Deathrattles</b> twice.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - AURA = 1
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BaronRivendare_FP1_031()
		{
			// TODO BaronRivendare_FP1_031 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Baron Rivendare"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Baron Rivendare"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Baron Rivendare"));
		}

	}

}
