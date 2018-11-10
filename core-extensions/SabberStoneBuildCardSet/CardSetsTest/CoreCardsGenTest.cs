using Xunit;
using SabberStoneCore.Enums;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCoreTest.CardSets.Undefined
{
	public class HeroesCoreTest
	{
		// ----------------------------------------- HERO - WARRIOR
		// [HERO_01] Garrosh Hellscream - COST:0 [ATK:0/HP:30] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 725
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GarroshHellscream_HERO_01()
		{
			// TODO GarroshHellscream_HERO_01 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Garrosh Hellscream"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Garrosh Hellscream"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Garrosh Hellscream"));
		}

		// ------------------------------------------ HERO - SHAMAN
		// [HERO_02] Thrall - COST:0 [ATK:0/HP:30] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 687
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Thrall_HERO_02()
		{
			// TODO Thrall_HERO_02 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Thrall"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Thrall"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Thrall"));
		}

		// ------------------------------------------- HERO - ROGUE
		// [HERO_03] Valeera Sanguinar - COST:0 [ATK:0/HP:30] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 730
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ValeeraSanguinar_HERO_03()
		{
			// TODO ValeeraSanguinar_HERO_03 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Valeera Sanguinar"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Valeera Sanguinar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Valeera Sanguinar"));
		}

		// ----------------------------------------- HERO - PALADIN
		// [HERO_04] Uther Lightbringer - COST:0 [ATK:0/HP:30] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 472
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UtherLightbringer_HERO_04()
		{
			// TODO UtherLightbringer_HERO_04 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Uther Lightbringer"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Uther Lightbringer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Uther Lightbringer"));
		}

		// ------------------------------------------ HERO - HUNTER
		// [HERO_05] Rexxar - COST:0 [ATK:0/HP:30] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 229
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Rexxar_HERO_05()
		{
			// TODO Rexxar_HERO_05 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rexxar"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rexxar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rexxar"));
		}

		// ------------------------------------------- HERO - DRUID
		// [HERO_06] Malfurion Stormrage - COST:0 [ATK:0/HP:30] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1123
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MalfurionStormrage_HERO_06()
		{
			// TODO MalfurionStormrage_HERO_06 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Malfurion Stormrage"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Malfurion Stormrage"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Malfurion Stormrage"));
		}

		// ----------------------------------------- HERO - WARLOCK
		// [HERO_07] Gul'dan - COST:0 [ATK:0/HP:30] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 300
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Guldan_HERO_07()
		{
			// TODO Guldan_HERO_07 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gul'dan"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gul'dan"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gul'dan"));
		}

		// -------------------------------------------- HERO - MAGE
		// [HERO_08] Jaina Proudmoore - COST:0 [ATK:0/HP:30] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 807
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JainaProudmoore_HERO_08()
		{
			// TODO JainaProudmoore_HERO_08 test
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

		// ------------------------------------------ HERO - PRIEST
		// [HERO_09] Anduin Wrynn - COST:0 [ATK:0/HP:30] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 479
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AnduinWrynn_HERO_09()
		{
			// TODO AnduinWrynn_HERO_09 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Anduin Wrynn"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Anduin Wrynn"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Anduin Wrynn"));
		}

	}

	public class HeroPowersCoreTest
	{
		// ------------------------------------ HERO_POWER - PRIEST
		// [CS1h_001] Lesser Heal (*) - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Restore #2 Health.
		// --------------------------------------------------------
		// GameTag:
		// - 1086 = 2741
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LesserHeal_CS1h_001()
		{
			// TODO LesserHeal_CS1h_001 test
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

		// ------------------------------------- HERO_POWER - DRUID
		// [CS2_017] Shapeshift (*) - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       +1 Attack this turn.
		//       +1 Armor.
		// --------------------------------------------------------
		// GameTag:
		// - 1086 = 2737
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Shapeshift_CS2_017()
		{
			// TODO Shapeshift_CS2_017 test
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
		// [CS2_034] Fireblast (*) - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $1 damage. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - 1086 = 2739
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Fireblast_CS2_034()
		{
			// TODO Fireblast_CS2_034 test
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

		// ------------------------------------ HERO_POWER - SHAMAN
		// [CS2_049] Totemic Call (*) - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a random Totem.
		// --------------------------------------------------------
		// Entourage: CS2_050, CS2_051, CS2_052, NEW1_009
		// --------------------------------------------------------
		// GameTag:
		// - 1086 = 2742
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// - REQ_ENTIRE_ENTOURAGE_NOT_IN_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TotemicCall_CS2_049()
		{
			// TODO TotemicCall_CS2_049 test
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

		// ----------------------------------- HERO_POWER - WARLOCK
		// [CS2_056] Life Tap (*) - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Draw a card and take $2_damage. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - 1086 = 2744
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LifeTap_CS2_056()
		{
			// TODO LifeTap_CS2_056 test
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
		// [CS2_083b] Dagger Mastery (*) - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Equip a 1/2 Dagger.
		// --------------------------------------------------------
		// GameTag:
		// - 1086 = 2743
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DaggerMastery_CS2_083b()
		{
			// TODO DaggerMastery_CS2_083b test
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
		// [CS2_101] Reinforce (*) - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 1/1 Silver Hand Recruit.
		// --------------------------------------------------------
		// GameTag:
		// - 1086 = 2740
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Reinforce_CS2_101()
		{
			// TODO Reinforce_CS2_101 test
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

		// ----------------------------------- HERO_POWER - WARRIOR
		// [CS2_102] Armor Up! (*) - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Gain 2 Armor.
		// --------------------------------------------------------
		// GameTag:
		// - 1086 = 2745
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArmorUp_CS2_102()
		{
			// TODO ArmorUp_CS2_102 test
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

		// ------------------------------------ HERO_POWER - HUNTER
		// [DS1h_292] Steady Shot (*) - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $2 damage to the enemy hero.@<b>Hero Power</b>
		//       Deal $2 damage. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - 1086 = 2738
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_STEADY_SHOT = 0
		// - REQ_MINION_OR_ENEMY_HERO = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SteadyShot_DS1h_292()
		{
			// TODO SteadyShot_DS1h_292 test
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

	}

	public class DruidCoreTest
	{
		// ----------------------------------------- MINION - DRUID
		// [CS2_232] Ironbark Protector - COST:8 [ATK:8/HP:8] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IronbarkProtector_CS2_232()
		{
			// TODO IronbarkProtector_CS2_232 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ironbark Protector"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ironbark Protector"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ironbark Protector"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [CS2_005] Claw - COST:1 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Give your hero +2_Attack this turn. Gain 2 Armor.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Claw_CS2_005()
		{
			// TODO Claw_CS2_005 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Claw"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Claw"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Claw"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [CS2_007] Healing Touch - COST:3 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Restore #8 Health.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HealingTouch_CS2_007()
		{
			// TODO HealingTouch_CS2_007 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Healing Touch"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Healing Touch"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Healing Touch"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [CS2_008] Moonfire - COST:0 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $1 damage. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Moonfire_CS2_008()
		{
			// TODO Moonfire_CS2_008 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Moonfire"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Moonfire"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Moonfire"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [CS2_009] Mark of the Wild - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Give a minion <b>Taunt</b> and +2/+2.<i>
		//       (+2 Attack/+2 Health)</i>
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MarkOfTheWild_CS2_009()
		{
			// TODO MarkOfTheWild_CS2_009 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mark of the Wild"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mark of the Wild"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mark of the Wild"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [CS2_011] Savage Roar - COST:3 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Give your characters +2_Attack this turn.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SavageRoar_CS2_011()
		{
			// TODO SavageRoar_CS2_011 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Savage Roar"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Savage Roar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Savage Roar"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [CS2_012] Swipe - COST:4 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $4 damage to an enemy and $1 damage to all other enemies. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_ENEMY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Swipe_CS2_012()
		{
			// TODO Swipe_CS2_012 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Swipe"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Swipe"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Swipe"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [CS2_013] Wild Growth - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Gain an empty Mana Crystal.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WildGrowth_CS2_013()
		{
			// TODO WildGrowth_CS2_013 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wild Growth"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wild Growth"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wild Growth"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [EX1_169] Innervate - COST:0 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Gain 1 Mana Crystal this turn only.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Innervate_EX1_169()
		{
			// TODO Innervate_EX1_169 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Innervate"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Innervate"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Innervate"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [EX1_173] Starfire - COST:6 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $5 damage.
		//       Draw a card. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Starfire_EX1_173()
		{
			// TODO Starfire_EX1_173 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Starfire"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Starfire"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Starfire"));
		}

	}

	public class HunterCoreTest
	{
		// ---------------------------------------- MINION - HUNTER
		// [CS2_237] Starving Buzzard - COST:5 [ATK:3/HP:2] 
		// - Race: beast, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Whenever you summon a Beast, draw a card.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StarvingBuzzard_CS2_237()
		{
			// TODO StarvingBuzzard_CS2_237 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Starving Buzzard"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Starving Buzzard"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Starving Buzzard"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [DS1_070] Houndmaster - COST:4 [ATK:4/HP:3] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly Beast +2/+2 and <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_WITH_RACE = 20
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Houndmaster_DS1_070()
		{
			// TODO Houndmaster_DS1_070 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Houndmaster"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Houndmaster"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Houndmaster"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [DS1_175] Timber Wolf - COST:1 [ATK:1/HP:1] 
		// - Race: beast, Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Your other Beasts have +1_Attack.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TimberWolf_DS1_175()
		{
			// TODO TimberWolf_DS1_175 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Timber Wolf"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Timber Wolf"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Timber Wolf"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [DS1_178] Tundra Rhino - COST:5 [ATK:2/HP:5] 
		// - Race: beast, Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Your Beasts have <b>Charge</b>.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		// RefTag:
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TundraRhino_DS1_178()
		{
			// TODO TundraRhino_DS1_178 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tundra Rhino"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tundra Rhino"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tundra Rhino"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [CS2_084] Hunter's Mark - COST:1 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Change a minion's Health to 1.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HuntersMark_CS2_084()
		{
			// TODO HuntersMark_CS2_084 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hunter's Mark"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hunter's Mark"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hunter's Mark"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [DS1_183] Multi-Shot - COST:4 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $3 damage to two random enemy minions. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINIMUM_ENEMY_MINIONS = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MultiShot_DS1_183()
		{
			// TODO MultiShot_DS1_183 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Multi-Shot"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Multi-Shot"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Multi-Shot"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [DS1_184] Tracking - COST:1 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Look at the top 3 cards of your deck. Draw one and discard the_others.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Tracking_DS1_184()
		{
			// TODO Tracking_DS1_184 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tracking"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tracking"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tracking"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [DS1_185] Arcane Shot - COST:1 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $2 damage. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArcaneShot_DS1_185()
		{
			// TODO ArcaneShot_DS1_185 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arcane Shot"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Shot"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Arcane Shot"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [EX1_539] Kill Command - COST:3 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $3 damage. If you control a Beast, deal
		//       $5 damage instead. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KillCommand_EX1_539()
		{
			// TODO KillCommand_EX1_539 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kill Command"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kill Command"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kill Command"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [NEW1_031] Animal Companion - COST:3 
		// - Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Summon a random Beast Companion.
		// --------------------------------------------------------
		// Entourage: NEW1_032, NEW1_033, NEW1_034
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AnimalCompanion_NEW1_031()
		{
			// TODO AnimalCompanion_NEW1_031 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Animal Companion"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Animal Companion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Animal Companion"));
		}

	}

	public class MageCoreTest
	{
		// ------------------------------------------ MINION - MAGE
		// [CS2_033] Water Elemental - COST:4 [ATK:3/HP:6] 
		// - Race: elemental, Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Freeze</b> any character damaged by this minion.
		// --------------------------------------------------------
		// GameTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WaterElemental_CS2_033()
		{
			// TODO WaterElemental_CS2_033 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Water Elemental"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Water Elemental"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Water Elemental"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [CS2_022] Polymorph - COST:4 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Transform a minion
		//       into a 1/1 Sheep.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Polymorph_CS2_022()
		{
			// TODO Polymorph_CS2_022 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Polymorph"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Polymorph"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Polymorph"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [CS2_023] Arcane Intellect - COST:3 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Draw 2 cards.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArcaneIntellect_CS2_023()
		{
			// TODO ArcaneIntellect_CS2_023 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arcane Intellect"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Intellect"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Arcane Intellect"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [CS2_024] Frostbolt - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $3 damage to a_character and <b>Freeze</b> it. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Frostbolt_CS2_024()
		{
			// TODO Frostbolt_CS2_024 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Frostbolt"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostbolt"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Frostbolt"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [CS2_025] Arcane Explosion - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $1 damage to all enemy minions. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArcaneExplosion_CS2_025()
		{
			// TODO ArcaneExplosion_CS2_025 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arcane Explosion"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Explosion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Arcane Explosion"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [CS2_026] Frost Nova - COST:3 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Freeze</b> all enemy minions.
		// --------------------------------------------------------
		// GameTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FrostNova_CS2_026()
		{
			// TODO FrostNova_CS2_026 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Frost Nova"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frost Nova"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Frost Nova"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [CS2_027] Mirror Image - COST:1 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Summon two 0/2 minions with <b>Taunt</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MirrorImage_CS2_027()
		{
			// TODO MirrorImage_CS2_027 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mirror Image"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mirror Image"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mirror Image"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [CS2_029] Fireball - COST:4 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $6 damage. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Fireball_CS2_029()
		{
			// TODO Fireball_CS2_029 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fireball"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fireball"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [CS2_032] Flamestrike - COST:7 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $4 damage to all enemy minions. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Flamestrike_CS2_032()
		{
			// TODO Flamestrike_CS2_032 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Flamestrike"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flamestrike"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Flamestrike"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [EX1_277] Arcane Missiles - COST:1 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $3 damage randomly split among all enemies. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - ImmuneToSpellpower = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArcaneMissiles_EX1_277()
		{
			// TODO ArcaneMissiles_EX1_277 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arcane Missiles"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Missiles"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Arcane Missiles"));
		}

	}

	public class PaladinCoreTest
	{
		// --------------------------------------- MINION - PALADIN
		// [CS2_088] Guardian of Kings - COST:7 [ATK:5/HP:6] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Restore #6 Health to your hero.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GuardianOfKings_CS2_088()
		{
			// TODO GuardianOfKings_CS2_088 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Guardian of Kings"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Guardian of Kings"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Guardian of Kings"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [CS2_087] Blessing of Might - COST:1 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Give a minion +3_Attack.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BlessingOfMight_CS2_087()
		{
			// TODO BlessingOfMight_CS2_087 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blessing of Might"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blessing of Might"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blessing of Might"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [CS2_089] Holy Light - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Restore #6 Health.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HolyLight_CS2_089()
		{
			// TODO HolyLight_CS2_089 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Holy Light"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Holy Light"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Holy Light"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [CS2_092] Blessing of Kings - COST:4 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Give a minion +4/+4. <i>(+4 Attack/+4 Health)</i>
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BlessingOfKings_CS2_092()
		{
			// TODO BlessingOfKings_CS2_092 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blessing of Kings"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blessing of Kings"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blessing of Kings"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [CS2_093] Consecration - COST:4 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $2 damage to all_enemies. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Consecration_CS2_093()
		{
			// TODO Consecration_CS2_093 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Consecration"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Consecration"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Consecration"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [CS2_094] Hammer of Wrath - COST:4 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $3 damage.
		//       Draw a card. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HammerOfWrath_CS2_094()
		{
			// TODO HammerOfWrath_CS2_094 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hammer of Wrath"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hammer of Wrath"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hammer of Wrath"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [EX1_360] Humility - COST:1 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Change a minion's Attack to 1.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Humility_EX1_360()
		{
			// TODO Humility_EX1_360 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Humility"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Humility"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Humility"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [EX1_371] Hand of Protection - COST:1 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Give a minion <b>Divine Shield</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HandOfProtection_EX1_371()
		{
			// TODO HandOfProtection_EX1_371 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hand of Protection"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hand of Protection"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hand of Protection"));
		}

		// --------------------------------------- WEAPON - PALADIN
		// [CS2_091] Light's Justice - COST:1 [ATK:1/HP:0] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 4
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LightsJustice_CS2_091()
		{
			// TODO LightsJustice_CS2_091 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Light's Justice"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Light's Justice"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Light's Justice"));
		}

		// --------------------------------------- WEAPON - PALADIN
		// [CS2_097] Truesilver Champion - COST:4 [ATK:4/HP:0] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Whenever your hero attacks, restore #2_Health to it.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TruesilverChampion_CS2_097()
		{
			// TODO TruesilverChampion_CS2_097 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Truesilver Champion"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Truesilver Champion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Truesilver Champion"));
		}

	}

	public class PriestCoreTest
	{
		// ---------------------------------------- MINION - PRIEST
		// [CS2_235] Northshire Cleric - COST:1 [ATK:1/HP:3] 
		// - Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Whenever a minion is healed, draw a card.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NorthshireCleric_CS2_235()
		{
			// TODO NorthshireCleric_CS2_235 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Northshire Cleric"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Northshire Cleric"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Northshire Cleric"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [CS1_112] Holy Nova - COST:5 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $2 damage to all enemies. Restore #2_Health to all friendly characters. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HolyNova_CS1_112()
		{
			// TODO HolyNova_CS1_112 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Holy Nova"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Holy Nova"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Holy Nova"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [CS1_113] Mind Control - COST:10 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Take control of an enemy minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_ENEMY_TARGET = 0
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MindControl_CS1_113()
		{
			// TODO MindControl_CS1_113 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mind Control"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mind Control"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mind Control"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [CS1_130] Holy Smite - COST:1 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $2 damage. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HolySmite_CS1_130()
		{
			// TODO HolySmite_CS1_130 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Holy Smite"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Holy Smite"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Holy Smite"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [CS2_003] Mind Vision - COST:1 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Put a copy of a random card in your opponent's hand into your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MindVision_CS2_003()
		{
			// TODO MindVision_CS2_003 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mind Vision"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mind Vision"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mind Vision"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [CS2_004] Power Word: Shield - COST:1 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Give a minion +2_Health.
		//       Draw a card.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PowerWordShield_CS2_004()
		{
			// TODO PowerWordShield_CS2_004 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Power Word: Shield"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Power Word: Shield"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Power Word: Shield"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [CS2_234] Shadow Word: Pain - COST:2 
		// - Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Destroy a minion with 3_or less Attack.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_TARGET_MAX_ATTACK = 3
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShadowWordPain_CS2_234()
		{
			// TODO ShadowWordPain_CS2_234 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shadow Word: Pain"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadow Word: Pain"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shadow Word: Pain"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [CS2_236] Divine Spirit - COST:2 
		// - Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Double a minion's Health.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DivineSpirit_CS2_236()
		{
			// TODO DivineSpirit_CS2_236 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Divine Spirit"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Divine Spirit"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Divine Spirit"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [DS1_233] Mind Blast - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $5 damage to the enemy hero. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MindBlast_DS1_233()
		{
			// TODO MindBlast_DS1_233 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mind Blast"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mind Blast"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mind Blast"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [EX1_622] Shadow Word: Death - COST:3 
		// - Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Destroy a minion with 5_or more Attack.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_MIN_ATTACK = 5
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShadowWordDeath_EX1_622()
		{
			// TODO ShadowWordDeath_EX1_622 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shadow Word: Death"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadow Word: Death"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shadow Word: Death"));
		}

	}

	public class RogueCoreTest
	{
		// ------------------------------------------ SPELL - ROGUE
		// [CS2_072] Backstab - COST:0 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $2 damage to an undamaged minion. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_UNDAMAGED_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Backstab_CS2_072()
		{
			// TODO Backstab_CS2_072 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Backstab"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Backstab"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Backstab"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [CS2_074] Deadly Poison - COST:1 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Give your weapon +2_Attack.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_WEAPON_EQUIPPED = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DeadlyPoison_CS2_074()
		{
			// TODO DeadlyPoison_CS2_074 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Deadly Poison"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Deadly Poison"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Deadly Poison"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [CS2_075] Sinister Strike - COST:1 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $3 damage to the_enemy hero. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SinisterStrike_CS2_075()
		{
			// TODO SinisterStrike_CS2_075 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sinister Strike"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sinister Strike"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sinister Strike"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [CS2_076] Assassinate - COST:5 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Destroy an enemy minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_ENEMY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Assassinate_CS2_076()
		{
			// TODO Assassinate_CS2_076 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Assassinate"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Assassinate"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Assassinate"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [CS2_077] Sprint - COST:7 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Draw 4 cards.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Sprint_CS2_077()
		{
			// TODO Sprint_CS2_077 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sprint"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sprint"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sprint"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [EX1_129] Fan of Knives - COST:3 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $1 damage to all enemy minions. Draw_a card. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FanOfKnives_EX1_129()
		{
			// TODO FanOfKnives_EX1_129 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fan of Knives"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fan of Knives"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fan of Knives"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [EX1_278] Shiv - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $1 damage.
		//       Draw a card. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Shiv_EX1_278()
		{
			// TODO Shiv_EX1_278 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shiv"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shiv"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shiv"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [EX1_581] Sap - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Return an enemy minion to your opponent's hand.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_ENEMY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Sap_EX1_581()
		{
			// TODO Sap_EX1_581 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sap"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sap"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sap"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [NEW1_004] Vanish - COST:6 
		// - Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Return all minions to their owner's hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Vanish_NEW1_004()
		{
			// TODO Vanish_NEW1_004 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Vanish"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vanish"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Vanish"));
		}

		// ----------------------------------------- WEAPON - ROGUE
		// [CS2_080] Assassin's Blade - COST:5 [ATK:3/HP:0] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 4
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AssassinsBlade_CS2_080()
		{
			// TODO AssassinsBlade_CS2_080 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Assassin's Blade"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Assassin's Blade"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Assassin's Blade"));
		}

	}

	public class ShamanCoreTest
	{
		// ---------------------------------------- MINION - SHAMAN
		// [CS2_042] Fire Elemental - COST:6 [ATK:6/HP:5] 
		// - Race: elemental, Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 3 damage.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FireElemental_CS2_042()
		{
			// TODO FireElemental_CS2_042 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fire Elemental"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fire Elemental"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fire Elemental"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [EX1_565] Flametongue Totem - COST:2 [ATK:0/HP:3] 
		// - Race: totem, Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Adjacent minions have +2_Attack.
		// --------------------------------------------------------
		// GameTag:
		// - ADJACENT_BUFF = 1
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FlametongueTotem_EX1_565()
		{
			// TODO FlametongueTotem_EX1_565 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Flametongue Totem"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flametongue Totem"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Flametongue Totem"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [EX1_587] Windspeaker - COST:4 [ATK:3/HP:3] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly minion <b>Windfury</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - WINDFURY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Windspeaker_EX1_587()
		{
			// TODO Windspeaker_EX1_587 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Windspeaker"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Windspeaker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Windspeaker"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [CS2_037] Frost Shock - COST:1 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $1 damage to an enemy character and <b>Freeze</b> it. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_ENEMY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FrostShock_CS2_037()
		{
			// TODO FrostShock_CS2_037 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Frost Shock"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frost Shock"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Frost Shock"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [CS2_039] Windfury - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Give a minion <b>Windfury</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - WINDFURY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Windfury_CS2_039()
		{
			// TODO Windfury_CS2_039 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Windfury"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Windfury"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Windfury"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [CS2_041] Ancestral Healing - COST:0 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Restore a minion
		//       to full Health and
		//       give it <b>Taunt</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AncestralHealing_CS2_041()
		{
			// TODO AncestralHealing_CS2_041 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ancestral Healing"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ancestral Healing"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ancestral Healing"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [CS2_045] Rockbiter Weapon - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Give a friendly character +3 Attack this turn.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RockbiterWeapon_CS2_045()
		{
			// TODO RockbiterWeapon_CS2_045 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rockbiter Weapon"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rockbiter Weapon"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rockbiter Weapon"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [CS2_046] Bloodlust - COST:5 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Give your minions +3_Attack this turn.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Bloodlust_CS2_046()
		{
			// TODO Bloodlust_CS2_046 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bloodlust"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodlust"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bloodlust"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [EX1_244] Totemic Might - COST:0 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Give your Totems +2_Health.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TotemicMight_EX1_244()
		{
			// TODO TotemicMight_EX1_244 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Totemic Might"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Totemic Might"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Totemic Might"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [EX1_246] Hex - COST:4 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Transform a minion into a 0/1 Frog with <b>Taunt</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Hex_EX1_246()
		{
			// TODO Hex_EX1_246 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hex"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hex"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hex"));
		}

	}

	public class WarlockCoreTest
	{
		// --------------------------------------- MINION - WARLOCK
		// [CS2_064] Dread Infernal - COST:6 [ATK:6/HP:6] 
		// - Race: demon, Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 1 damage to ALL other characters.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DreadInfernal_CS2_064()
		{
			// TODO DreadInfernal_CS2_064 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dread Infernal"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dread Infernal"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dread Infernal"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [CS2_065] Voidwalker - COST:1 [ATK:1/HP:3] 
		// - Race: demon, Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Voidwalker_CS2_065()
		{
			// TODO Voidwalker_CS2_065 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Voidwalker"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Voidwalker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Voidwalker"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [EX1_306] Succubus - COST:2 [ATK:4/HP:3] 
		// - Race: demon, Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Discard a random card.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - DISCARD_CARDS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Succubus_EX1_306()
		{
			// TODO Succubus_EX1_306 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Succubus"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Succubus"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Succubus"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [CS2_057] Shadow Bolt - COST:3 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $4 damage
		//       to a minion. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShadowBolt_CS2_057()
		{
			// TODO ShadowBolt_CS2_057 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shadow Bolt"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadow Bolt"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shadow Bolt"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [CS2_061] Drain Life - COST:3 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $2 damage. Restore #2 Health to your hero. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DrainLife_CS2_061()
		{
			// TODO DrainLife_CS2_061 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Drain Life"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Drain Life"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Drain Life"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [CS2_062] Hellfire - COST:4 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $3 damage to ALL_characters. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Hellfire_CS2_062()
		{
			// TODO Hellfire_CS2_062 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hellfire"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hellfire"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hellfire"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [CS2_063] Corruption - COST:1 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Choose an enemy minion. At the start of your turn, destroy it.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_ENEMY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Corruption_CS2_063()
		{
			// TODO Corruption_CS2_063 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Corruption"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Corruption"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Corruption"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [EX1_302] Mortal Coil - COST:1 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $1 damage to a minion. If that kills it, draw a card. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MortalCoil_EX1_302()
		{
			// TODO MortalCoil_EX1_302 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mortal Coil"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mortal Coil"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mortal Coil"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [EX1_308] Soulfire - COST:1 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: [x]Deal $4 damage.
		//       Discard a random card. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - DISCARD_CARDS = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Soulfire_EX1_308()
		{
			// TODO Soulfire_EX1_308 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Soulfire"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Soulfire"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Soulfire"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [NEW1_003] Sacrificial Pact - COST:0 
		// - Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Destroy a Demon. Restore #5 Health to your hero.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_TARGET_WITH_RACE = 15
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SacrificialPact_NEW1_003()
		{
			// TODO SacrificialPact_NEW1_003 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sacrificial Pact"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sacrificial Pact"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sacrificial Pact"));
		}

	}

	public class WarriorCoreTest
	{
		// --------------------------------------- MINION - WARRIOR
		// [EX1_084] Warsong Commander - COST:3 [ATK:2/HP:3] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Your <b>Charge</b> minions have +1 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		// RefTag:
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WarsongCommander_EX1_084()
		{
			// TODO WarsongCommander_EX1_084 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Warsong Commander"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Warsong Commander"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Warsong Commander"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [NEW1_011] Kor'kron Elite - COST:4 [ATK:4/HP:3] 
		// - Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Charge</b>
		// --------------------------------------------------------
		// GameTag:
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KorkronElite_NEW1_011()
		{
			// TODO KorkronElite_NEW1_011 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kor'kron Elite"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kor'kron Elite"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kor'kron Elite"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [CS2_103] Charge - COST:1 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Give a friendly minion <b>Charge</b>. It can't attack heroes this turn.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Charge_CS2_103()
		{
			// TODO Charge_CS2_103 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Charge"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Charge"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Charge"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [CS2_105] Heroic Strike - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Give your hero +4_Attack this turn.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HeroicStrike_CS2_105()
		{
			// TODO HeroicStrike_CS2_105 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Heroic Strike"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Heroic Strike"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Heroic Strike"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [CS2_108] Execute - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Destroy a damaged enemy minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_ENEMY_TARGET = 0
		// - REQ_DAMAGED_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Execute_CS2_108()
		{
			// TODO Execute_CS2_108 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Execute"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Execute"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Execute"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [CS2_114] Cleave - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: [x]Deal $2 damage to
		//       two random enemy
		//       minions. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINIMUM_ENEMY_MINIONS = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Cleave_CS2_114()
		{
			// TODO Cleave_CS2_114 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cleave"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cleave"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cleave"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [EX1_400] Whirlwind - COST:1 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $1 damage to ALL_minions. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Whirlwind_EX1_400()
		{
			// TODO Whirlwind_EX1_400 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Whirlwind"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Whirlwind"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Whirlwind"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [EX1_606] Shield Block - COST:3 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Gain 5 Armor.
		//       Draw a card.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShieldBlock_EX1_606()
		{
			// TODO ShieldBlock_EX1_606 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shield Block"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shield Block"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shield Block"));
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [CS2_106] Fiery War Axe - COST:3 [ATK:3/HP:0] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FieryWarAxe_CS2_106()
		{
			// TODO FieryWarAxe_CS2_106 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fiery War Axe"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fiery War Axe"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fiery War Axe"));
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [CS2_112] Arcanite Reaper - COST:5 [ATK:5/HP:0] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArcaniteReaper_CS2_112()
		{
			// TODO ArcaniteReaper_CS2_112 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arcanite Reaper"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcanite Reaper"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Arcanite Reaper"));
		}

	}

	public class NeutralCoreTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [CS1_042] Goldshire Footman - COST:1 [ATK:1/HP:2] 
		// - Fac: alliance, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GoldshireFootman_CS1_042()
		{
			// TODO GoldshireFootman_CS1_042 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Goldshire Footman"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Goldshire Footman"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Goldshire Footman"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_118] Magma Rager - COST:3 [ATK:5/HP:1] 
		// - Race: elemental, Set: core, Rarity: free
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MagmaRager_CS2_118()
		{
			// TODO MagmaRager_CS2_118 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Magma Rager"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Magma Rager"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Magma Rager"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_119] Oasis Snapjaw - COST:4 [ATK:2/HP:7] 
		// - Race: beast, Set: core, Rarity: free
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OasisSnapjaw_CS2_119()
		{
			// TODO OasisSnapjaw_CS2_119 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Oasis Snapjaw"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Oasis Snapjaw"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Oasis Snapjaw"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_120] River Crocolisk - COST:2 [ATK:2/HP:3] 
		// - Race: beast, Set: core, Rarity: free
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RiverCrocolisk_CS2_120()
		{
			// TODO RiverCrocolisk_CS2_120 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("River Crocolisk"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("River Crocolisk"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "River Crocolisk"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_121] Frostwolf Grunt - COST:2 [ATK:2/HP:2] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FrostwolfGrunt_CS2_121()
		{
			// TODO FrostwolfGrunt_CS2_121 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Frostwolf Grunt"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostwolf Grunt"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Frostwolf Grunt"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_122] Raid Leader - COST:3 [ATK:2/HP:2] 
		// - Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Your other minions have +1 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RaidLeader_CS2_122()
		{
			// TODO RaidLeader_CS2_122 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Raid Leader"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Raid Leader"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Raid Leader"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_124] Wolfrider - COST:3 [ATK:3/HP:1] 
		// - Fac: horde, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Charge</b>
		// --------------------------------------------------------
		// GameTag:
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Wolfrider_CS2_124()
		{
			// TODO Wolfrider_CS2_124 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wolfrider"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wolfrider"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wolfrider"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_125] Ironfur Grizzly - COST:3 [ATK:3/HP:3] 
		// - Race: beast, Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IronfurGrizzly_CS2_125()
		{
			// TODO IronfurGrizzly_CS2_125 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ironfur Grizzly"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ironfur Grizzly"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ironfur Grizzly"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_127] Silverback Patriarch - COST:3 [ATK:1/HP:4] 
		// - Race: beast, Fac: horde, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SilverbackPatriarch_CS2_127()
		{
			// TODO SilverbackPatriarch_CS2_127 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Silverback Patriarch"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Silverback Patriarch"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Silverback Patriarch"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_131] Stormwind Knight - COST:4 [ATK:2/HP:5] 
		// - Fac: alliance, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Charge</b>
		// --------------------------------------------------------
		// GameTag:
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StormwindKnight_CS2_131()
		{
			// TODO StormwindKnight_CS2_131 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stormwind Knight"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stormwind Knight"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stormwind Knight"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_141] Ironforge Rifleman - COST:3 [ATK:2/HP:2] 
		// - Fac: alliance, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 1 damage.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_NONSELF_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IronforgeRifleman_CS2_141()
		{
			// TODO IronforgeRifleman_CS2_141 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ironforge Rifleman"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ironforge Rifleman"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ironforge Rifleman"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_142] Kobold Geomancer - COST:2 [ATK:2/HP:2] 
		// - Fac: horde, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Spell Damage +1</b>
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KoboldGeomancer_CS2_142()
		{
			// TODO KoboldGeomancer_CS2_142 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kobold Geomancer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kobold Geomancer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kobold Geomancer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_147] Gnomish Inventor - COST:4 [ATK:2/HP:4] 
		// - Fac: alliance, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Draw a card.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GnomishInventor_CS2_147()
		{
			// TODO GnomishInventor_CS2_147 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gnomish Inventor"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gnomish Inventor"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gnomish Inventor"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_150] Stormpike Commando - COST:5 [ATK:4/HP:2] 
		// - Fac: alliance, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 2 damage.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_NONSELF_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StormpikeCommando_CS2_150()
		{
			// TODO StormpikeCommando_CS2_150 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stormpike Commando"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stormpike Commando"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stormpike Commando"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_155] Archmage - COST:6 [ATK:4/HP:7] 
		// - Fac: alliance, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Spell Damage +1</b>
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Archmage_CS2_155()
		{
			// TODO Archmage_CS2_155 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Archmage"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Archmage"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Archmage"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_162] Lord of the Arena - COST:6 [ATK:6/HP:5] 
		// - Fac: alliance, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LordOfTheArena_CS2_162()
		{
			// TODO LordOfTheArena_CS2_162 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lord of the Arena"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lord of the Arena"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lord of the Arena"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_168] Murloc Raider - COST:1 [ATK:2/HP:1] 
		// - Race: murloc, Fac: alliance, Set: core, Rarity: free
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MurlocRaider_CS2_168()
		{
			// TODO MurlocRaider_CS2_168 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Murloc Raider"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Raider"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Murloc Raider"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_171] Stonetusk Boar - COST:1 [ATK:1/HP:1] 
		// - Race: beast, Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Charge</b>
		// --------------------------------------------------------
		// GameTag:
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StonetuskBoar_CS2_171()
		{
			// TODO StonetuskBoar_CS2_171 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stonetusk Boar"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stonetusk Boar"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_172] Bloodfen Raptor - COST:2 [ATK:3/HP:2] 
		// - Race: beast, Fac: horde, Set: core, Rarity: free
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BloodfenRaptor_CS2_172()
		{
			// TODO BloodfenRaptor_CS2_172 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bloodfen Raptor"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bloodfen Raptor"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_173] Bluegill Warrior - COST:2 [ATK:2/HP:1] 
		// - Race: murloc, Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Charge</b>
		// --------------------------------------------------------
		// GameTag:
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BluegillWarrior_CS2_173()
		{
			// TODO BluegillWarrior_CS2_173 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bluegill Warrior"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bluegill Warrior"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bluegill Warrior"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_179] Sen'jin Shieldmasta - COST:4 [ATK:3/HP:5] 
		// - Fac: horde, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SenjinShieldmasta_CS2_179()
		{
			// TODO SenjinShieldmasta_CS2_179 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sen'jin Shieldmasta"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sen'jin Shieldmasta"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_182] Chillwind Yeti - COST:4 [ATK:4/HP:5] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ChillwindYeti_CS2_182()
		{
			// TODO ChillwindYeti_CS2_182 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Chillwind Yeti"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chillwind Yeti"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Chillwind Yeti"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_186] War Golem - COST:7 [ATK:7/HP:7] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WarGolem_CS2_186()
		{
			// TODO WarGolem_CS2_186 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("War Golem"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("War Golem"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "War Golem"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_187] Booty Bay Bodyguard - COST:5 [ATK:5/HP:4] 
		// - Fac: horde, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BootyBayBodyguard_CS2_187()
		{
			// TODO BootyBayBodyguard_CS2_187 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Booty Bay Bodyguard"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Booty Bay Bodyguard"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Booty Bay Bodyguard"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_189] Elven Archer - COST:1 [ATK:1/HP:1] 
		// - Fac: horde, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 1 damage.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_NONSELF_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ElvenArcher_CS2_189()
		{
			// TODO ElvenArcher_CS2_189 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Elven Archer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Elven Archer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Elven Archer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_196] Razorfen Hunter - COST:3 [ATK:2/HP:3] 
		// - Fac: horde, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 1/1_Boar.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RazorfenHunter_CS2_196()
		{
			// TODO RazorfenHunter_CS2_196 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Razorfen Hunter"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Razorfen Hunter"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Razorfen Hunter"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_197] Ogre Magi - COST:4 [ATK:4/HP:4] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Spell Damage +1</b>
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OgreMagi_CS2_197()
		{
			// TODO OgreMagi_CS2_197 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ogre Magi"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ogre Magi"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ogre Magi"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_200] Boulderfist Ogre - COST:6 [ATK:6/HP:7] 
		// - Set: core, Rarity: free
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BoulderfistOgre_CS2_200()
		{
			// TODO BoulderfistOgre_CS2_200 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Boulderfist Ogre"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Boulderfist Ogre"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Boulderfist Ogre"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_201] Core Hound - COST:7 [ATK:9/HP:5] 
		// - Race: beast, Set: core, Rarity: free
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CoreHound_CS2_201()
		{
			// TODO CoreHound_CS2_201 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Core Hound"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Core Hound"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Core Hound"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_213] Reckless Rocketeer - COST:6 [ATK:5/HP:2] 
		// - Fac: horde, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Charge</b>
		// --------------------------------------------------------
		// GameTag:
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RecklessRocketeer_CS2_213()
		{
			// TODO RecklessRocketeer_CS2_213 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Reckless Rocketeer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Reckless Rocketeer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Reckless Rocketeer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_222] Stormwind Champion - COST:7 [ATK:6/HP:6] 
		// - Fac: alliance, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Your other minions have +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StormwindChampion_CS2_222()
		{
			// TODO StormwindChampion_CS2_222 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stormwind Champion"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stormwind Champion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stormwind Champion"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_226] Frostwolf Warlord - COST:5 [ATK:4/HP:4] 
		// - Fac: horde, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Gain +1/+1 for each other friendly minion on the battlefield.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FrostwolfWarlord_CS2_226()
		{
			// TODO FrostwolfWarlord_CS2_226 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Frostwolf Warlord"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostwolf Warlord"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Frostwolf Warlord"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DS1_055] Darkscale Healer - COST:5 [ATK:4/HP:5] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Restore #2 Health to all friendly characters.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DarkscaleHealer_DS1_055()
		{
			// TODO DarkscaleHealer_DS1_055 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Darkscale Healer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Darkscale Healer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Darkscale Healer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_011] Voodoo Doctor - COST:1 [ATK:2/HP:1] 
		// - Fac: horde, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Restore #2_Health.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VoodooDoctor_EX1_011()
		{
			// TODO VoodooDoctor_EX1_011 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Voodoo Doctor"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Voodoo Doctor"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Voodoo Doctor"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_015] Novice Engineer - COST:2 [ATK:1/HP:1] 
		// - Fac: alliance, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Draw a card.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NoviceEngineer_EX1_015()
		{
			// TODO NoviceEngineer_EX1_015 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Novice Engineer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Novice Engineer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Novice Engineer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_019] Shattered Sun Cleric - COST:3 [ATK:3/HP:2] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly minion +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShatteredSunCleric_EX1_019()
		{
			// TODO ShatteredSunCleric_EX1_019 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shattered Sun Cleric"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shattered Sun Cleric"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shattered Sun Cleric"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_025] Dragonling Mechanic - COST:4 [ATK:2/HP:4] 
		// - Fac: alliance, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 2/1 Mechanical Dragonling.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DragonlingMechanic_EX1_025()
		{
			// TODO DragonlingMechanic_EX1_025 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dragonling Mechanic"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragonling Mechanic"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dragonling Mechanic"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_066] Acidic Swamp Ooze - COST:2 [ATK:3/HP:2] 
		// - Fac: alliance, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy your opponent's weapon.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AcidicSwampOoze_EX1_066()
		{
			// TODO AcidicSwampOoze_EX1_066 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Acidic Swamp Ooze"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Acidic Swamp Ooze"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Acidic Swamp Ooze"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_399] Gurubashi Berserker - COST:5 [ATK:2/HP:7] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Whenever this minion takes damage, gain +3_Attack.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GurubashiBerserker_EX1_399()
		{
			// TODO GurubashiBerserker_EX1_399 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gurubashi Berserker"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gurubashi Berserker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gurubashi Berserker"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_506] Murloc Tidehunter - COST:2 [ATK:2/HP:1] 
		// - Race: murloc, Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 1/1_Murloc Scout.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MurlocTidehunter_EX1_506()
		{
			// TODO MurlocTidehunter_EX1_506 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Murloc Tidehunter"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Tidehunter"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Murloc Tidehunter"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_508] Grimscale Oracle - COST:1 [ATK:1/HP:1] 
		// - Race: murloc, Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Your other Murlocs have +1 Attack.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GrimscaleOracle_EX1_508()
		{
			// TODO GrimscaleOracle_EX1_508 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grimscale Oracle"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grimscale Oracle"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grimscale Oracle"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_582] Dalaran Mage - COST:3 [ATK:1/HP:4] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Spell Damage +1</b>
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DalaranMage_EX1_582()
		{
			// TODO DalaranMage_EX1_582 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dalaran Mage"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dalaran Mage"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dalaran Mage"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_593] Nightblade - COST:5 [ATK:4/HP:4] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Battlecry: </b>Deal 3 damage to the enemy hero.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Nightblade_EX1_593()
		{
			// TODO Nightblade_EX1_593 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nightblade"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nightblade"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nightblade"));
		}

	}

}
