using Xunit;
using SabberStoneCore.Enums;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCoreTest.CardSets.Undefined
{
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
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
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
