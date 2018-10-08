using Xunit;
using SabberStoneCore.Enums;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using System.Collections.Generic;

namespace SabberStoneCoreTest.CardSets.Undefined
{
	public class HeroesMissionsTest
	{
		// ----------------------------------------- HERO - NEUTRAL
		// [TU4a_001] Hogger (*) - COST:0 [ATK:0/HP:10] 
		// - Set: missions, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Hogger_TU4a_001()
		{
			// TODO Hogger_TU4a_001 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hogger"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hogger"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hogger"));
		}

		// -------------------------------------------- HERO - MAGE
		// [TU4a_006] Jaina Proudmoore (*) - COST:0 [ATK:0/HP:30] 
		// - Set: missions, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JainaProudmoore_TU4a_006()
		{
			// TODO JainaProudmoore_TU4a_006 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Jaina Proudmoore"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jaina Proudmoore"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Jaina Proudmoore"));
		}

		// -------------------------------------------- HERO - MAGE
		// [TU4b_001] Millhouse Manastorm (*) - COST:0 [ATK:0/HP:20] 
		// - Set: missions, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MillhouseManastorm_TU4b_001()
		{
			// TODO MillhouseManastorm_TU4b_001 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Millhouse Manastorm"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Millhouse Manastorm"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Millhouse Manastorm"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [TU4c_001] King Mukla (*) - COST:0 [ATK:0/HP:26] 
		// - Set: missions, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KingMukla_TU4c_001()
		{
			// TODO KingMukla_TU4c_001 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("King Mukla"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("King Mukla"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "King Mukla"));
		}

		// ------------------------------------------ HERO - HUNTER
		// [TU4d_001] Hemet Nesingwary (*) - COST:0 [ATK:0/HP:20] 
		// - Set: missions, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HemetNesingwary_TU4d_001()
		{
			// TODO HemetNesingwary_TU4d_001 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hemet Nesingwary"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hemet Nesingwary"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hemet Nesingwary"));
		}

		// ------------------------------------------ HERO - HUNTER
		// [TU4e_001] Illidan Stormrage (*) - COST:0 [ATK:0/HP:30] 
		// - Set: missions, 
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IllidanStormrage_TU4e_001()
		{
			// TODO IllidanStormrage_TU4e_001 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Illidan Stormrage"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Illidan Stormrage"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Illidan Stormrage"));
		}

		// ----------------------------------------- HERO - NEUTRAL
		// [TU4f_001] Lorewalker Cho (*) - COST:0 [ATK:0/HP:25] 
		// - Set: missions, 
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LorewalkerCho_TU4f_001()
		{
			// TODO LorewalkerCho_TU4f_001 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lorewalker Cho"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lorewalker Cho"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lorewalker Cho"));
		}

	}

	public class HeroPowersMissionsTest
	{
		// ------------------------------------ HERO_POWER - HUNTER
		// [TU4d_003] Shotgun Blast (*) - COST:2 
		// - Set: missions, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal 1 damage.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_ENEMY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShotgunBlast_TU4d_003()
		{
			// TODO ShotgunBlast_TU4d_003 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shotgun Blast"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shotgun Blast"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shotgun Blast"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [TU4e_002] Flames of Azzinoth (*) - COST:2 
		// - Set: missions, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon two 2/1 minions.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FlamesOfAzzinoth_TU4e_002()
		{
			// TODO FlamesOfAzzinoth_TU4e_002 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Flames of Azzinoth"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flames of Azzinoth"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Flames of Azzinoth"));
		}

	}

}
