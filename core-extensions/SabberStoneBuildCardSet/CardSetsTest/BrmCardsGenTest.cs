using Xunit;
using SabberStoneCore.Enums;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using System.Collections.Generic;

namespace SabberStoneCoreTest.CardSets.Undefined
{
	public class HeroesBrmTest
	{
		// ----------------------------------------- HERO - NEUTRAL
		// [BRM_027h] Ragnaros the Firelord (*) - COST:0 [ATK:0/HP:8] 
		// - Set: brm, 
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 2319
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RagnarosTheFirelord_BRM_027h()
		{
			// TODO RagnarosTheFirelord_BRM_027h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ragnaros the Firelord"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ragnaros the Firelord"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ragnaros the Firelord"));
		}

	}

	public class HeroPowersBrmTest
	{
		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRM_027p] DIE, INSECT! (*) - COST:2 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $8 damage to a random enemy. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DieInsect_BRM_027p()
		{
			// TODO DieInsect_BRM_027p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("DIE, INSECT!"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("DIE, INSECT!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "DIE, INSECT!"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRM_027pH] DIE, INSECTS! (*) - COST:2 
		// - Set: brm, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $8 damage to a random enemy. TWICE. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DieInsects_BRM_027pH()
		{
			// TODO DieInsects_BRM_027pH test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("DIE, INSECTS!"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("DIE, INSECTS!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "DIE, INSECTS!"));
		}

	}

	public class DruidBrmTest
	{
		// ----------------------------------------- MINION - DRUID
		// [BRM_009] Volcanic Lumberer - COST:9 [ATK:7/HP:8] 
		// - Set: brm, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       Costs (1) less for each minion that died this turn.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VolcanicLumberer_BRM_009()
		{
			// TODO VolcanicLumberer_BRM_009 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Volcanic Lumberer"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Volcanic Lumberer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Volcanic Lumberer"));
		}

		// ----------------------------------------- MINION - DRUID
		// [BRM_010] Druid of the Flame - COST:3 [ATK:2/HP:2] 
		// - Set: brm, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Choose One -</b> Transform into a 5/2 minion; or a 2/5 minion.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DruidOfTheFlame_BRM_010()
		{
			// TODO DruidOfTheFlame_BRM_010 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Druid of the Flame"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Druid of the Flame"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Druid of the Flame"));
		}

	}

	public class HunterBrmTest
	{
		// ---------------------------------------- MINION - HUNTER
		// [BRM_014] Core Rager - COST:4 [ATK:4/HP:4] 
		// - Race: beast, Set: brm, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your hand is empty, gain +3/+3.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CoreRager_BRM_014()
		{
			// TODO CoreRager_BRM_014 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Core Rager"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Core Rager"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Core Rager"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [BRM_013] Quick Shot - COST:2 
		// - Set: brm, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $3 damage.
		//       If your hand is empty, draw a card. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - AFFECTED_BY_SPELL_POWER = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void QuickShot_BRM_013()
		{
			// TODO QuickShot_BRM_013 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Quick Shot"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Quick Shot"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Quick Shot"));
		}

	}

	public class MageBrmTest
	{
		// ------------------------------------------ MINION - MAGE
		// [BRM_002] Flamewaker - COST:3 [ATK:2/HP:4] 
		// - Set: brm, Rarity: rare
		// --------------------------------------------------------
		// Text: After you cast a spell, deal 2 damage randomly split among all enemies.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Flamewaker_BRM_002()
		{
			// TODO Flamewaker_BRM_002 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Flamewaker"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flamewaker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Flamewaker"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [BRM_003] Dragon's Breath - COST:5 
		// - Set: brm, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $4 damage. Costs (1) less for each minion that died this turn. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DragonsBreath_BRM_003()
		{
			// TODO DragonsBreath_BRM_003 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dragon's Breath"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragon's Breath"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dragon's Breath"));
		}

	}

	public class PaladinBrmTest
	{
		// --------------------------------------- MINION - PALADIN
		// [BRM_018] Dragon Consort - COST:5 [ATK:5/HP:5] 
		// - Race: dragon, Set: brm, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> The next Dragon you play costs (2) less.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DragonConsort_BRM_018()
		{
			// TODO DragonConsort_BRM_018 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dragon Consort"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragon Consort"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dragon Consort"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [BRM_001] Solemn Vigil - COST:5 
		// - Set: brm, Rarity: common
		// --------------------------------------------------------
		// Text: Draw 2 cards. Costs (1) less for each minion that died this turn.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SolemnVigil_BRM_001()
		{
			// TODO SolemnVigil_BRM_001 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Solemn Vigil"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Solemn Vigil"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Solemn Vigil"));
		}

	}

	public class PriestBrmTest
	{
		// ---------------------------------------- MINION - PRIEST
		// [BRM_004] Twilight Whelp - COST:1 [ATK:2/HP:1] 
		// - Race: dragon, Set: brm, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding a Dragon, gain +2 Health.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TwilightWhelp_BRM_004()
		{
			// TODO TwilightWhelp_BRM_004 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Twilight Whelp"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twilight Whelp"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Twilight Whelp"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [BRM_017] Resurrect - COST:2 
		// - Set: brm, Rarity: rare
		// --------------------------------------------------------
		// Text: Summon a random friendly minion that died this game.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// - REQ_FRIENDLY_MINION_DIED_THIS_GAME = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Resurrect_BRM_017()
		{
			// TODO Resurrect_BRM_017 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Resurrect"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Resurrect"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Resurrect"));
		}

	}

	public class RogueBrmTest
	{
		// ----------------------------------------- MINION - ROGUE
		// [BRM_008] Dark Iron Skulker - COST:5 [ATK:4/HP:3] 
		// - Set: brm, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 2 damage to all undamaged enemy minions.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DarkIronSkulker_BRM_008()
		{
			// TODO DarkIronSkulker_BRM_008 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dark Iron Skulker"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dark Iron Skulker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dark Iron Skulker"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [BRM_007] Gang Up - COST:2 
		// - Set: brm, Rarity: common
		// --------------------------------------------------------
		// Text: Choose a minion. Shuffle 3 copies of it into your deck.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GangUp_BRM_007()
		{
			// TODO GangUp_BRM_007 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gang Up"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gang Up"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gang Up"));
		}

	}

	public class ShamanBrmTest
	{
		// ---------------------------------------- MINION - SHAMAN
		// [BRM_012] Fireguard Destroyer - COST:4 [ATK:3/HP:6] 
		// - Race: elemental, Set: brm, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Gain 1-4 Attack. <b>Overload:</b> (1)
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 1
		// - BATTLECRY = 1
		// - OVERLOAD_OWED = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FireguardDestroyer_BRM_012()
		{
			// TODO FireguardDestroyer_BRM_012 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fireguard Destroyer"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireguard Destroyer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fireguard Destroyer"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [BRM_011] Lava Shock - COST:2 
		// - Set: brm, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $2 damage.
		//       Unlock your <b>Overloaded</b> Mana Crystals. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - OVERLOAD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LavaShock_BRM_011()
		{
			// TODO LavaShock_BRM_011 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lava Shock"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lava Shock"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lava Shock"));
		}

	}

	public class WarlockBrmTest
	{
		// --------------------------------------- MINION - WARLOCK
		// [BRM_006] Imp Gang Boss - COST:3 [ATK:2/HP:4] 
		// - Race: demon, Set: brm, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever this minion takes damage, summon a 1/1 Imp.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ImpGangBoss_BRM_006()
		{
			// TODO ImpGangBoss_BRM_006 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Imp Gang Boss"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Imp Gang Boss"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Imp Gang Boss"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [BRM_005] Demonwrath - COST:3 
		// - Set: brm, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]Deal $2 damage to all
		//       minions except Demons. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - AFFECTED_BY_SPELL_POWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Demonwrath_BRM_005()
		{
			// TODO Demonwrath_BRM_005 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Demonwrath"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Demonwrath"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Demonwrath"));
		}

	}

	public class WarriorBrmTest
	{
		// --------------------------------------- MINION - WARRIOR
		// [BRM_016] Axe Flinger - COST:4 [ATK:2/HP:5] 
		// - Set: brm, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever this minion takes damage, deal 2 damage to the enemy hero.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AxeFlinger_BRM_016()
		{
			// TODO AxeFlinger_BRM_016 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Axe Flinger"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Axe Flinger"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Axe Flinger"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [BRM_015] Revenge - COST:2 
		// - Set: brm, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $1 damage to all minions. If you have 12 or less Health, deal $3 damage instead. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Revenge_BRM_015()
		{
			// TODO Revenge_BRM_015 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Revenge"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Revenge"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Revenge"));
		}

	}

	public class NeutralBrmTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [BRM_019] Grim Patron - COST:5 [ATK:3/HP:3] 
		// - Set: brm, Rarity: rare
		// --------------------------------------------------------
		// Text: After this minion survives damage, summon another Grim Patron.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GrimPatron_BRM_019()
		{
			// TODO GrimPatron_BRM_019 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grim Patron"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grim Patron"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grim Patron"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BRM_020] Dragonkin Sorcerer - COST:4 [ATK:3/HP:5] 
		// - Race: dragon, Set: brm, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever <b>you</b> target this minion with a spell, gain +1/+1.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DragonkinSorcerer_BRM_020()
		{
			// TODO DragonkinSorcerer_BRM_020 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dragonkin Sorcerer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragonkin Sorcerer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dragonkin Sorcerer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BRM_022] Dragon Egg - COST:1 [ATK:0/HP:2] 
		// - Set: brm, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever this minion takes damage, summon a 2/1 Whelp.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DragonEgg_BRM_022()
		{
			// TODO DragonEgg_BRM_022 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dragon Egg"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragon Egg"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dragon Egg"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BRM_024] Drakonid Crusher - COST:6 [ATK:6/HP:6] 
		// - Race: dragon, Set: brm, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your opponent has 15 or less Health, gain +3/+3.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DrakonidCrusher_BRM_024()
		{
			// TODO DrakonidCrusher_BRM_024 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Drakonid Crusher"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Drakonid Crusher"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Drakonid Crusher"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BRM_025] Volcanic Drake - COST:6 [ATK:6/HP:4] 
		// - Race: dragon, Set: brm, Rarity: common
		// --------------------------------------------------------
		// Text: Costs (1) less for each minion that died this turn.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VolcanicDrake_BRM_025()
		{
			// TODO VolcanicDrake_BRM_025 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Volcanic Drake"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Volcanic Drake"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Volcanic Drake"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BRM_026] Hungry Dragon - COST:4 [ATK:5/HP:6] 
		// - Race: dragon, Set: brm, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a random 1-Cost minion for_your opponent.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HungryDragon_BRM_026()
		{
			// TODO HungryDragon_BRM_026 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hungry Dragon"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hungry Dragon"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hungry Dragon"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BRM_027] Majordomo Executus - COST:9 [ATK:9/HP:7] 
		// - Set: brm, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Replace your hero with Ragnaros, the Firelord.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MajordomoExecutus_BRM_027()
		{
			// TODO MajordomoExecutus_BRM_027 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Majordomo Executus"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Majordomo Executus"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Majordomo Executus"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BRM_028] Emperor Thaurissan - COST:6 [ATK:5/HP:5] 
		// - Set: brm, Rarity: legendary
		// --------------------------------------------------------
		// Text: At the end of your turn, reduce the Cost of cards in your hand by (1).
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EmperorThaurissan_BRM_028()
		{
			// TODO EmperorThaurissan_BRM_028 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Emperor Thaurissan"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Emperor Thaurissan"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Emperor Thaurissan"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BRM_029] Rend Blackhand - COST:7 [ATK:8/HP:4] 
		// - Set: brm, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding a Dragon, destroy a <b>Legendary</b> minion.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND = 0
		// - REQ_LEGENDARY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RendBlackhand_BRM_029()
		{
			// TODO RendBlackhand_BRM_029 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rend Blackhand"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rend Blackhand"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rend Blackhand"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BRM_030] Nefarian - COST:9 [ATK:8/HP:8] 
		// - Race: dragon, Set: brm, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add 2 random spells to your hand <i>(from your opponent's class)</i>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Nefarian_BRM_030()
		{
			// TODO Nefarian_BRM_030 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nefarian"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nefarian"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nefarian"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BRM_031] Chromaggus - COST:8 [ATK:6/HP:8] 
		// - Race: dragon, Set: brm, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever you draw a card, put another copy into your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Chromaggus_BRM_031()
		{
			// TODO Chromaggus_BRM_031 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Chromaggus"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chromaggus"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Chromaggus"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BRM_033] Blackwing Technician - COST:3 [ATK:2/HP:4] 
		// - Fac: neutral, Set: brm, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding a Dragon, gain +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BlackwingTechnician_BRM_033()
		{
			// TODO BlackwingTechnician_BRM_033 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blackwing Technician"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blackwing Technician"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blackwing Technician"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BRM_034] Blackwing Corruptor - COST:5 [ATK:5/HP:4] 
		// - Fac: neutral, Set: brm, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding a Dragon, deal 3 damage.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BlackwingCorruptor_BRM_034()
		{
			// TODO BlackwingCorruptor_BRM_034 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blackwing Corruptor"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blackwing Corruptor"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blackwing Corruptor"));
		}

	}

}
