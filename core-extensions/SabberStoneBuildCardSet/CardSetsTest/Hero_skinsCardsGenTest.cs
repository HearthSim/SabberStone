using Xunit;
using SabberStoneCore.Enums;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using System.Collections.Generic;

namespace SabberStoneCoreTest.CardSets.Undefined
{
	public class HeroesHero_skinsTest
	{
		// ----------------------------------------- HERO - WARRIOR
		// [HERO_01a] Magni Bronzebeard - COST:0 [ATK:0/HP:30] 
		// - Set: hero_skins, Rarity: epic
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2830
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MagniBronzebeard_HERO_01a()
		{
			// TODO MagniBronzebeard_HERO_01a test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Magni Bronzebeard"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Magni Bronzebeard"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Magni Bronzebeard"));
		}

		// ------------------------------------------ HERO - SHAMAN
		// [HERO_02a] Morgl the Oracle - COST:0 [ATK:0/HP:30] 
		// - Set: hero_skins, Rarity: epic
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 40247
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MorglTheOracle_HERO_02a()
		{
			// TODO MorglTheOracle_HERO_02a test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Morgl the Oracle"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Morgl the Oracle"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Morgl the Oracle"));
		}

		// ------------------------------------------- HERO - ROGUE
		// [HERO_03a] Maiev Shadowsong - COST:0 [ATK:0/HP:30] 
		// - Fac: neutral, Set: hero_skins, Rarity: epic
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 730
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MaievShadowsong_HERO_03a()
		{
			// TODO MaievShadowsong_HERO_03a test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Maiev Shadowsong"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Maiev Shadowsong"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Maiev Shadowsong"));
		}

		// ----------------------------------------- HERO - PALADIN
		// [HERO_04a] Lady Liadrin - COST:0 [ATK:0/HP:30] 
		// - Set: hero_skins, Rarity: epic
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2832
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LadyLiadrin_HERO_04a()
		{
			// TODO LadyLiadrin_HERO_04a test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lady Liadrin"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lady Liadrin"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lady Liadrin"));
		}

		// ----------------------------------------- HERO - PALADIN
		// [HERO_04b] Prince Arthas - COST:0 [ATK:0/HP:30] 
		// - Set: hero_skins, Rarity: epic
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 46115
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PrinceArthas_HERO_04b()
		{
			// TODO PrinceArthas_HERO_04b test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Prince Arthas"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Prince Arthas"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Prince Arthas"));
		}

		// ------------------------------------------ HERO - HUNTER
		// [HERO_05a] Alleria Windrunner - COST:0 [ATK:0/HP:30] 
		// - Set: hero_skins, Rarity: epic
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2833
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AlleriaWindrunner_HERO_05a()
		{
			// TODO AlleriaWindrunner_HERO_05a test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Alleria Windrunner"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Alleria Windrunner"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Alleria Windrunner"));
		}

		// ------------------------------------------- HERO - DRUID
		// [HERO_06a] Lunara - COST:0 [ATK:0/HP:30] 
		// - Fac: neutral, Set: hero_skins, Rarity: epic
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 50485
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Lunara_HERO_06a()
		{
			// TODO Lunara_HERO_06a test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lunara"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lunara"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lunara"));
		}

		// ----------------------------------------- HERO - WARLOCK
		// [HERO_07a] Nemsy Necrofizzle - COST:0 [ATK:0/HP:30] 
		// - Set: hero_skins, Rarity: epic
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 47788
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NemsyNecrofizzle_HERO_07a()
		{
			// TODO NemsyNecrofizzle_HERO_07a test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nemsy Necrofizzle"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nemsy Necrofizzle"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nemsy Necrofizzle"));
		}

		// -------------------------------------------- HERO - MAGE
		// [HERO_08a] Medivh - COST:0 [ATK:0/HP:30] 
		// - Set: hero_skins, Rarity: epic
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2831
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Medivh_HERO_08a()
		{
			// TODO Medivh_HERO_08a test
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
		// [HERO_08b] Khadgar - COST:0 [ATK:0/HP:30] 
		// - Set: hero_skins, Rarity: epic
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 39791
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Khadgar_HERO_08b()
		{
			// TODO Khadgar_HERO_08b test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Khadgar"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Khadgar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Khadgar"));
		}

		// ------------------------------------------ HERO - PRIEST
		// [HERO_09a] Tyrande Whisperwind - COST:0 [ATK:0/HP:30] 
		// - Fac: neutral, Set: hero_skins, Rarity: epic
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 41886
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TyrandeWhisperwind_HERO_09a()
		{
			// TODO TyrandeWhisperwind_HERO_09a test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tyrande Whisperwind"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tyrande Whisperwind"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tyrande Whisperwind"));
		}

	}

	public class HeroPowersHero_skinsTest
	{
		// ------------------------------------- HERO_POWER - ROGUE
		// [AT_132_ROGUE_H1] Poisoned Daggers (*) - COST:2 
		// - Set: hero_skins, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Equip a 2/2 Weapon.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PoisonedDaggers_AT_132_ROGUE_H1()
		{
			// TODO PoisonedDaggers_AT_132_ROGUE_H1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Poisoned Daggers"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Poisoned Daggers"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Poisoned Daggers"));
		}

		// ------------------------------------ HERO_POWER - PRIEST
		// [CS1h_001_H1] Lesser Heal (*) - COST:2 
		// - Fac: neutral, Set: hero_skins, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Restore #2 Health.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LesserHeal_CS1h_001_H1()
		{
			// TODO LesserHeal_CS1h_001_H1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lesser Heal"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lesser Heal"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lesser Heal"));
		}

		// ------------------------------------ HERO_POWER - PRIEST
		// [CS1h_001_H1_AT_132] Heal (*) - COST:2 
		// - Set: hero_skins, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Restore #4 Health.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Heal_CS1h_001_H1_AT_132()
		{
			// TODO Heal_CS1h_001_H1_AT_132 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Heal"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Heal"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Heal"));
		}

		// ------------------------------------- HERO_POWER - DRUID
		// [CS2_017_HS1] Shapeshift (*) - COST:2 
		// - Fac: neutral, Set: hero_skins, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       +1 Attack this turn.    +1 Armor.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Shapeshift_CS2_017_HS1()
		{
			// TODO Shapeshift_CS2_017_HS1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shapeshift"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shapeshift"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shapeshift"));
		}

		// -------------------------------------- HERO_POWER - MAGE
		// [CS2_034_H1] Fireblast (*) - COST:2 
		// - Set: hero_skins, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $1 damage. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Fireblast_CS2_034_H1()
		{
			// TODO Fireblast_CS2_034_H1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fireblast"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireblast"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fireblast"));
		}

		// -------------------------------------- HERO_POWER - MAGE
		// [CS2_034_H1_AT_132] Fireblast Rank 2 (*) - COST:2 
		// - Set: hero_skins, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $2 damage. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FireblastRank2_CS2_034_H1_AT_132()
		{
			// TODO FireblastRank2_CS2_034_H1_AT_132 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fireblast Rank 2"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireblast Rank 2"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fireblast Rank 2"));
		}

		// -------------------------------------- HERO_POWER - MAGE
		// [CS2_034_H2] Fireblast (*) - COST:2 
		// - Set: hero_skins, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $1 damage. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Fireblast_CS2_034_H2()
		{
			// TODO Fireblast_CS2_034_H2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fireblast"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireblast"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fireblast"));
		}

		// -------------------------------------- HERO_POWER - MAGE
		// [CS2_034_H2_AT_132] Fireblast Rank 2 (*) - COST:2 
		// - Set: hero_skins, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $2 damage. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FireblastRank2_CS2_034_H2_AT_132()
		{
			// TODO FireblastRank2_CS2_034_H2_AT_132 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fireblast Rank 2"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireblast Rank 2"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fireblast Rank 2"));
		}

		// ------------------------------------ HERO_POWER - SHAMAN
		// [CS2_049_H1] Totemic Call (*) - COST:2 
		// - Set: hero_skins, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a random Totem.
		// --------------------------------------------------------
		// Entourage: CS2_050, CS2_051, CS2_052, NEW1_009
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_ENTIRE_ENTOURAGE_NOT_IN_PLAY = 0
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TotemicCall_CS2_049_H1()
		{
			// TODO TotemicCall_CS2_049_H1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Totemic Call"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Totemic Call"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Totemic Call"));
		}

		// ------------------------------------ HERO_POWER - SHAMAN
		// [CS2_049_H1_AT_132] Totemic Slam (*) - COST:2 
		// - Set: hero_skins, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a Totem of your choice.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TotemicSlam_CS2_049_H1_AT_132()
		{
			// TODO TotemicSlam_CS2_049_H1_AT_132 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Totemic Slam"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Totemic Slam"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Totemic Slam"));
		}

		// ----------------------------------- HERO_POWER - WARLOCK
		// [CS2_056_H1] Life Tap (*) - COST:2 
		// - Fac: neutral, Set: hero_skins, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Draw a card and take $2_damage. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LifeTap_CS2_056_H1()
		{
			// TODO LifeTap_CS2_056_H1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Life Tap"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Life Tap"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Life Tap"));
		}

		// ------------------------------------- HERO_POWER - ROGUE
		// [CS2_083b_H1] Dagger Mastery (*) - COST:2 
		// - Fac: neutral, Set: hero_skins, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Equip a 1/2 Dagger.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DaggerMastery_CS2_083b_H1()
		{
			// TODO DaggerMastery_CS2_083b_H1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dagger Mastery"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dagger Mastery"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dagger Mastery"));
		}

		// ----------------------------------- HERO_POWER - PALADIN
		// [CS2_101_H1] Reinforce (*) - COST:2 
		// - Set: hero_skins, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 1/1 Silver Hand Recruit.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Reinforce_CS2_101_H1()
		{
			// TODO Reinforce_CS2_101_H1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Reinforce"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Reinforce"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Reinforce"));
		}

		// ----------------------------------- HERO_POWER - PALADIN
		// [CS2_101_H1_AT_132] The Silver Hand (*) - COST:2 
		// - Set: hero_skins, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon two 1/1 Recruits.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheSilverHand_CS2_101_H1_AT_132()
		{
			// TODO TheSilverHand_CS2_101_H1_AT_132 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Silver Hand"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Silver Hand"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Silver Hand"));
		}

		// ----------------------------------- HERO_POWER - PALADIN
		// [CS2_101_H2] Reinforce (*) - COST:2 
		// - Set: hero_skins, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 1/1 Silver Hand Recruit.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Reinforce_CS2_101_H2()
		{
			// TODO Reinforce_CS2_101_H2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Reinforce"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Reinforce"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Reinforce"));
		}

		// ----------------------------------- HERO_POWER - PALADIN
		// [CS2_101_H2_AT_132] The Silver Hand (*) - COST:2 
		// - Set: hero_skins, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon two 1/1 Recruits.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheSilverHand_CS2_101_H2_AT_132()
		{
			// TODO TheSilverHand_CS2_101_H2_AT_132 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Silver Hand"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Silver Hand"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Silver Hand"));
		}

		// ----------------------------------- HERO_POWER - WARRIOR
		// [CS2_102_H1] Armor Up! (*) - COST:2 
		// - Set: hero_skins, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Gain 2 Armor.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArmorUp_CS2_102_H1()
		{
			// TODO ArmorUp_CS2_102_H1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Armor Up!"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Armor Up!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Armor Up!"));
		}

		// ----------------------------------- HERO_POWER - WARRIOR
		// [CS2_102_H1_AT_132] Tank Up! (*) - COST:2 
		// - Set: hero_skins, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Gain 4 Armor.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TankUp_CS2_102_H1_AT_132()
		{
			// TODO TankUp_CS2_102_H1_AT_132 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tank Up!"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tank Up!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tank Up!"));
		}

		// ------------------------------------ HERO_POWER - HUNTER
		// [DS1h_292_H1] Steady Shot (*) - COST:2 
		// - Set: hero_skins, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $2 damage to the enemy hero.@<b>Hero Power</b>
		//       Deal $2 damage. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_STEADY_SHOT = 0
		// - REQ_MINION_OR_ENEMY_HERO = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SteadyShot_DS1h_292_H1()
		{
			// TODO SteadyShot_DS1h_292_H1 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Steady Shot"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Steady Shot"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Steady Shot"));
		}

		// ------------------------------------ HERO_POWER - HUNTER
		// [DS1h_292_H1_AT_132] Ballista Shot (*) - COST:2 
		// - Set: hero_skins, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $3 damage to the enemy hero.@<b>Hero Power</b>
		//       Deal $3 damage. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_STEADY_SHOT = 0
		// - REQ_MINION_OR_ENEMY_HERO = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BallistaShot_DS1h_292_H1_AT_132()
		{
			// TODO BallistaShot_DS1h_292_H1_AT_132 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ballista Shot"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ballista Shot"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ballista Shot"));
		}

	}

}
