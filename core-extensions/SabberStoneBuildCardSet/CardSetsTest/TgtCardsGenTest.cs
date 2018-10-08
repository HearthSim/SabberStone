using Xunit;
using SabberStoneCore.Enums;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using System.Collections.Generic;

namespace SabberStoneCoreTest.CardSets.Undefined
{
	public class HeroPowersTgtTest
	{
		// ------------------------------------ HERO_POWER - SHAMAN
		// [AT_050t] Lightning Jolt (*) - COST:2 
		// - Set: tgt, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $2 damage. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LightningJolt_AT_050t()
		{
			// TODO LightningJolt_AT_050t test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lightning Jolt"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lightning Jolt"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lightning Jolt"));
		}

		// ------------------------------------- HERO_POWER - DRUID
		// [AT_132_DRUID] Dire Shapeshift (*) - COST:2 
		// - Set: tgt, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Gain 2 Armor and +2 Attack this turn.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DireShapeshift_AT_132_DRUID()
		{
			// TODO DireShapeshift_AT_132_DRUID test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dire Shapeshift"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dire Shapeshift"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dire Shapeshift"));
		}

		// ------------------------------------ HERO_POWER - HUNTER
		// [AT_132_HUNTER] Ballista Shot (*) - COST:2 
		// - Set: tgt, 
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
		public void BallistaShot_AT_132_HUNTER()
		{
			// TODO BallistaShot_AT_132_HUNTER test
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

		// -------------------------------------- HERO_POWER - MAGE
		// [AT_132_MAGE] Fireblast Rank 2 (*) - COST:2 
		// - Set: tgt, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $2 damage. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FireblastRank2_AT_132_MAGE()
		{
			// TODO FireblastRank2_AT_132_MAGE test
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

		// ----------------------------------- HERO_POWER - PALADIN
		// [AT_132_PALADIN] The Silver Hand (*) - COST:2 
		// - Set: tgt, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon two 1/1 Recruits.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheSilverHand_AT_132_PALADIN()
		{
			// TODO TheSilverHand_AT_132_PALADIN test
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

		// ------------------------------------ HERO_POWER - PRIEST
		// [AT_132_PRIEST] Heal (*) - COST:2 
		// - Set: tgt, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Restore #4 Health.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Heal_AT_132_PRIEST()
		{
			// TODO Heal_AT_132_PRIEST test
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

		// ------------------------------------- HERO_POWER - ROGUE
		// [AT_132_ROGUE] Poisoned Daggers (*) - COST:2 
		// - Set: tgt, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Equip a 2/2 Weapon.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PoisonedDaggers_AT_132_ROGUE()
		{
			// TODO PoisonedDaggers_AT_132_ROGUE test
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

		// ------------------------------------ HERO_POWER - SHAMAN
		// [AT_132_SHAMAN] Totemic Slam (*) - COST:2 
		// - Set: tgt, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a Totem of your choice.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TotemicSlam_AT_132_SHAMAN()
		{
			// TODO TotemicSlam_AT_132_SHAMAN test
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
		// [AT_132_WARLOCK] Soul Tap (*) - COST:2 
		// - Set: tgt, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Draw a card.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SoulTap_AT_132_WARLOCK()
		{
			// TODO SoulTap_AT_132_WARLOCK test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Soul Tap"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Soul Tap"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Soul Tap"));
		}

		// ----------------------------------- HERO_POWER - WARRIOR
		// [AT_132_WARRIOR] Tank Up! (*) - COST:2 
		// - Set: tgt, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Gain 4 Armor.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TankUp_AT_132_WARRIOR()
		{
			// TODO TankUp_AT_132_WARRIOR test
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

	}

	public class DruidTgtTest
	{
		// ----------------------------------------- MINION - DRUID
		// [AT_038] Darnassus Aspirant - COST:2 [ATK:2/HP:3] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Gain an empty Mana Crystal.
		//       <b>Deathrattle:</b> Lose a Mana Crystal.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DarnassusAspirant_AT_038()
		{
			// TODO DarnassusAspirant_AT_038 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Darnassus Aspirant"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Darnassus Aspirant"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Darnassus Aspirant"));
		}

		// ----------------------------------------- MINION - DRUID
		// [AT_039] Savage Combatant - COST:4 [ATK:5/HP:4] 
		// - Race: beast, Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Give your hero
		//       +2 Attack this turn.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SavageCombatant_AT_039()
		{
			// TODO SavageCombatant_AT_039 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Savage Combatant"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Savage Combatant"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Savage Combatant"));
		}

		// ----------------------------------------- MINION - DRUID
		// [AT_040] Wildwalker - COST:4 [ATK:4/HP:4] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly Beast +3 Health.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_WITH_RACE = 20
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Wildwalker_AT_040()
		{
			// TODO Wildwalker_AT_040 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wildwalker"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wildwalker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wildwalker"));
		}

		// ----------------------------------------- MINION - DRUID
		// [AT_041] Knight of the Wild - COST:7 [ATK:6/HP:6] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you summon a Beast, reduce the Cost of this card by (1).
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KnightOfTheWild_AT_041()
		{
			// TODO KnightOfTheWild_AT_041 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Knight of the Wild"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Knight of the Wild"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Knight of the Wild"));
		}

		// ----------------------------------------- MINION - DRUID
		// [AT_042] Druid of the Saber - COST:2 [ATK:2/HP:1] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Choose One -</b> Transform
		//       into a 2/1 with <b>Charge</b>;
		//       or a 3/2 with <b>Stealth</b>.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		// RefTag:
		// - STEALTH = 1
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DruidOfTheSaber_AT_042()
		{
			// TODO DruidOfTheSaber_AT_042 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Druid of the Saber"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Druid of the Saber"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Druid of the Saber"));
		}

		// ----------------------------------------- MINION - DRUID
		// [AT_045] Aviana - COST:9 [ATK:5/HP:5] 
		// - Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: Your minions cost (1).
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Aviana_AT_045()
		{
			// TODO Aviana_AT_045 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Aviana"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Aviana"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Aviana"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [AT_037] Living Roots - COST:1 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Choose One -</b> Deal $2 damage; or Summon two 1/1 Saplings. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LivingRoots_AT_037()
		{
			// TODO LivingRoots_AT_037 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Living Roots"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Living Roots"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Living Roots"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [AT_043] Astral Communion - COST:4 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: Gain 10 Mana Crystals. Discard your hand.
		// --------------------------------------------------------
		// GameTag:
		// - 890 = 10
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AstralCommunion_AT_043()
		{
			// TODO AstralCommunion_AT_043 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Astral Communion"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Astral Communion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Astral Communion"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [AT_044] Mulch - COST:3 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: Destroy a minion.
		//       Add a random minion to your opponent's hand.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Mulch_AT_044()
		{
			// TODO Mulch_AT_044 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mulch"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mulch"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mulch"));
		}

	}

	public class HunterTgtTest
	{
		// ---------------------------------------- MINION - HUNTER
		// [AT_010] Ram Wrangler - COST:5 [ATK:3/HP:3] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you have a Beast, summon a
		//       random Beast.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RamWrangler_AT_010()
		{
			// TODO RamWrangler_AT_010 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ram Wrangler"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ram Wrangler"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ram Wrangler"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [AT_057] Stablemaster - COST:3 [ATK:4/HP:2] 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly Beast <b>Immune</b> this turn.
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
		// - IMMUNE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Stablemaster_AT_057()
		{
			// TODO Stablemaster_AT_057 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stablemaster"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stablemaster"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stablemaster"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [AT_058] King's Elekk - COST:2 [ATK:3/HP:2] 
		// - Race: beast, Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Reveal a minion in each deck. If yours costs more, draw it.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KingsElekk_AT_058()
		{
			// TODO KingsElekk_AT_058 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("King's Elekk"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("King's Elekk"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "King's Elekk"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [AT_059] Brave Archer - COST:1 [ATK:2/HP:1] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> If your hand is empty, deal 2 damage to the enemy hero.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BraveArcher_AT_059()
		{
			// TODO BraveArcher_AT_059 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Brave Archer"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Brave Archer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Brave Archer"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [AT_063] Acidmaw - COST:7 [ATK:4/HP:2] 
		// - Race: beast, Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever another minion takes damage, destroy it.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Acidmaw_AT_063()
		{
			// TODO Acidmaw_AT_063 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Acidmaw"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Acidmaw"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Acidmaw"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [AT_063t] Dreadscale - COST:3 [ATK:4/HP:2] 
		// - Race: beast, Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: At the end of your turn, deal 1 damage to all other minions.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Dreadscale_AT_063t()
		{
			// TODO Dreadscale_AT_063t test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dreadscale"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dreadscale"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dreadscale"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [AT_056] Powershot - COST:3 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $2 damage to a minion and the minions next to it. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Powershot_AT_056()
		{
			// TODO Powershot_AT_056 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Powershot"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Powershot"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Powershot"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [AT_060] Bear Trap - COST:2 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> After your hero is attacked, summon a 3/3 Bear with <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BearTrap_AT_060()
		{
			// TODO BearTrap_AT_060 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bear Trap"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bear Trap"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bear Trap"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [AT_061] Lock and Load - COST:2 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: Each time you cast a spell this turn, add a random Hunter card to your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LockAndLoad_AT_061()
		{
			// TODO LockAndLoad_AT_061 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lock and Load"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lock and Load"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lock and Load"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [AT_062] Ball of Spiders - COST:6 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: Summon three 1/1 Webspinners.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BallOfSpiders_AT_062()
		{
			// TODO BallOfSpiders_AT_062 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ball of Spiders"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ball of Spiders"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ball of Spiders"));
		}

	}

	public class MageTgtTest
	{
		// ------------------------------------------ MINION - MAGE
		// [AT_003] Fallen Hero - COST:2 [ATK:3/HP:2] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: Your Hero Power deals 1 extra damage.
		// --------------------------------------------------------
		// GameTag:
		// - HEROPOWER_DAMAGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FallenHero_AT_003()
		{
			// TODO FallenHero_AT_003 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fallen Hero"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fallen Hero"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fallen Hero"));
		}

		// ------------------------------------------ MINION - MAGE
		// [AT_006] Dalaran Aspirant - COST:4 [ATK:3/HP:5] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Gain <b>Spell Damage +1</b>.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		// RefTag:
		// - SPELLPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DalaranAspirant_AT_006()
		{
			// TODO DalaranAspirant_AT_006 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dalaran Aspirant"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dalaran Aspirant"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dalaran Aspirant"));
		}

		// ------------------------------------------ MINION - MAGE
		// [AT_007] Spellslinger - COST:3 [ATK:3/HP:4] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add a random spell to each player's hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Spellslinger_AT_007()
		{
			// TODO Spellslinger_AT_007 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spellslinger"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spellslinger"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Spellslinger"));
		}

		// ------------------------------------------ MINION - MAGE
		// [AT_008] Coldarra Drake - COST:6 [ATK:6/HP:6] 
		// - Race: dragon, Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: You can use your Hero Power any number of times.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ColdarraDrake_AT_008()
		{
			// TODO ColdarraDrake_AT_008 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Coldarra Drake"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Coldarra Drake"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Coldarra Drake"));
		}

		// ------------------------------------------ MINION - MAGE
		// [AT_009] Rhonin - COST:8 [ATK:7/HP:7] 
		// - Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Add 3 copies of Arcane Missiles to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Rhonin_AT_009()
		{
			// TODO Rhonin_AT_009 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rhonin"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rhonin"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rhonin"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [AT_001] Flame Lance - COST:5 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $8 damage to a minion. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FlameLance_AT_001()
		{
			// TODO FlameLance_AT_001 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Flame Lance"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flame Lance"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Flame Lance"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [AT_002] Effigy - COST:3 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When a friendly minion dies, summon a random minion with the same Cost.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Effigy_AT_002()
		{
			// TODO Effigy_AT_002 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Effigy"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Effigy"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Effigy"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [AT_004] Arcane Blast - COST:1 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: Deal $2 damage to a minion. This spell gets double bonus from <b>Spell Damage</b>. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - RECEIVES_DOUBLE_SPELLDAMAGE_BONUS = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - SPELLPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArcaneBlast_AT_004()
		{
			// TODO ArcaneBlast_AT_004 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arcane Blast"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Blast"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Arcane Blast"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [AT_005] Polymorph: Boar - COST:3 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: Transform a minion into a 4/2 Boar with <b>Charge</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PolymorphBoar_AT_005()
		{
			// TODO PolymorphBoar_AT_005 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Polymorph: Boar"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Polymorph: Boar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Polymorph: Boar"));
		}

	}

	public class PaladinTgtTest
	{
		// --------------------------------------- MINION - PALADIN
		// [AT_075] Warhorse Trainer - COST:3 [ATK:2/HP:4] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: Your Silver Hand Recruits have +1 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WarhorseTrainer_AT_075()
		{
			// TODO WarhorseTrainer_AT_075 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Warhorse Trainer"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Warhorse Trainer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Warhorse Trainer"));
		}

		// --------------------------------------- MINION - PALADIN
		// [AT_076] Murloc Knight - COST:4 [ATK:3/HP:4] 
		// - Race: murloc, Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Summon a random Murloc.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MurlocKnight_AT_076()
		{
			// TODO MurlocKnight_AT_076 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Murloc Knight"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Knight"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Murloc Knight"));
		}

		// --------------------------------------- MINION - PALADIN
		// [AT_079] Mysterious Challenger - COST:6 [ATK:6/HP:6] 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Put one of each <b>Secret</b> from your deck into the battlefield.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MysteriousChallenger_AT_079()
		{
			// TODO MysteriousChallenger_AT_079 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mysterious Challenger"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mysterious Challenger"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mysterious Challenger"));
		}

		// --------------------------------------- MINION - PALADIN
		// [AT_081] Eadric the Pure - COST:7 [ATK:3/HP:7] 
		// - Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Change all enemy minions'
		//       Attack to 1.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EadricThePure_AT_081()
		{
			// TODO EadricThePure_AT_081 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Eadric the Pure"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eadric the Pure"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Eadric the Pure"));
		}

		// --------------------------------------- MINION - PALADIN
		// [AT_104] Tuskarr Jouster - COST:5 [ATK:5/HP:5] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Reveal a minion in each deck. If yours costs more, restore 7 Health to your hero.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TuskarrJouster_AT_104()
		{
			// TODO TuskarrJouster_AT_104 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tuskarr Jouster"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tuskarr Jouster"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tuskarr Jouster"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [AT_073] Competitive Spirit - COST:1 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When your turn starts, give your minions +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CompetitiveSpirit_AT_073()
		{
			// TODO CompetitiveSpirit_AT_073 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Competitive Spirit"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Competitive Spirit"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Competitive Spirit"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [AT_074] Seal of Champions - COST:3 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: Give a minion
		//       +3 Attack and <b>Divine Shield</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SealOfChampions_AT_074()
		{
			// TODO SealOfChampions_AT_074 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Seal of Champions"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Seal of Champions"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Seal of Champions"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [AT_078] Enter the Coliseum - COST:6 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: Destroy all minions except each player's highest Attack minion.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EnterTheColiseum_AT_078()
		{
			// TODO EnterTheColiseum_AT_078 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Enter the Coliseum"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Enter the Coliseum"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Enter the Coliseum"));
		}

		// --------------------------------------- WEAPON - PALADIN
		// [AT_077] Argent Lance - COST:2 [ATK:2/HP:0] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Reveal a minion in each deck. If yours costs more, +1 Durability.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArgentLance_AT_077()
		{
			// TODO ArgentLance_AT_077 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Argent Lance"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Argent Lance"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Argent Lance"));
		}

	}

	public class PriestTgtTest
	{
		// ---------------------------------------- MINION - PRIEST
		// [AT_011] Holy Champion - COST:4 [ATK:3/HP:5] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever a character is healed, gain +2 Attack.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HolyChampion_AT_011()
		{
			// TODO HolyChampion_AT_011 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Holy Champion"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Holy Champion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Holy Champion"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [AT_012] Spawn of Shadows - COST:4 [ATK:5/HP:4] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Deal 4 damage to each hero.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SpawnOfShadows_AT_012()
		{
			// TODO SpawnOfShadows_AT_012 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spawn of Shadows"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spawn of Shadows"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Spawn of Shadows"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [AT_014] Shadowfiend - COST:3 [ATK:3/HP:3] 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: Whenever you draw a card, reduce its Cost by (1).
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Shadowfiend_AT_014()
		{
			// TODO Shadowfiend_AT_014 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shadowfiend"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadowfiend"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shadowfiend"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [AT_018] Confessor Paletress - COST:7 [ATK:5/HP:4] 
		// - Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Summon a random <b>Legendary</b> minion.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ConfessorPaletress_AT_018()
		{
			// TODO ConfessorPaletress_AT_018 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Confessor Paletress"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Confessor Paletress"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Confessor Paletress"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [AT_116] Wyrmrest Agent - COST:2 [ATK:1/HP:4] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding a Dragon, gain +1 Attack and <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WyrmrestAgent_AT_116()
		{
			// TODO WyrmrestAgent_AT_116 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wyrmrest Agent"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wyrmrest Agent"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wyrmrest Agent"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [AT_013] Power Word: Glory - COST:1 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: Choose a minion. Whenever it attacks, restore 4 Health to
		//       your hero.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PowerWordGlory_AT_013()
		{
			// TODO PowerWordGlory_AT_013 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Power Word: Glory"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Power Word: Glory"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Power Word: Glory"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [AT_015] Convert - COST:2 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: Put a copy of an enemy minion into your hand.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_ENEMY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Convert_AT_015()
		{
			// TODO Convert_AT_015 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Convert"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Convert"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Convert"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [AT_016] Confuse - COST:2 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: Swap the Attack and Health of all minions.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Confuse_AT_016()
		{
			// TODO Confuse_AT_016 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Confuse"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Confuse"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Confuse"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [AT_055] Flash Heal - COST:1 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: Restore #5 Health.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FlashHeal_AT_055()
		{
			// TODO FlashHeal_AT_055 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Flash Heal"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flash Heal"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Flash Heal"));
		}

	}

	public class RogueTgtTest
	{
		// ----------------------------------------- MINION - ROGUE
		// [AT_028] Shado-Pan Rider - COST:5 [ATK:3/HP:7] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Combo:</b> Gain +3 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShadoPanRider_AT_028()
		{
			// TODO ShadoPanRider_AT_028 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shado-Pan Rider"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shado-Pan Rider"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shado-Pan Rider"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [AT_029] Buccaneer - COST:1 [ATK:2/HP:1] 
		// - Race: pirate, Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever you equip a weapon, give it +1 Attack.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Buccaneer_AT_029()
		{
			// TODO Buccaneer_AT_029 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Buccaneer"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Buccaneer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Buccaneer"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [AT_030] Undercity Valiant - COST:2 [ATK:3/HP:2] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Combo:</b> Deal 1 damage.
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_FOR_COMBO = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UndercityValiant_AT_030()
		{
			// TODO UndercityValiant_AT_030 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Undercity Valiant"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Undercity Valiant"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Undercity Valiant"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [AT_031] Cutpurse - COST:2 [ATK:2/HP:2] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever this minion attacks a hero, add the Coin to your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Cutpurse_AT_031()
		{
			// TODO Cutpurse_AT_031 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cutpurse"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cutpurse"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cutpurse"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [AT_032] Shady Dealer - COST:3 [ATK:4/HP:3] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you have a Pirate, gain +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShadyDealer_AT_032()
		{
			// TODO ShadyDealer_AT_032 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shady Dealer"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shady Dealer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shady Dealer"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [AT_036] Anub'arak - COST:9 [ATK:8/HP:4] 
		// - Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Return this to your hand and summon a 4/4 Nerubian.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// - 542 = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Anubarak_AT_036()
		{
			// TODO Anubarak_AT_036 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Anub'arak"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Anub'arak"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Anub'arak"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [AT_033] Burgle - COST:3 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: Add 2 random cards to your hand <i>(from your opponent's class)</i>.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Burgle_AT_033()
		{
			// TODO Burgle_AT_033 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Burgle"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Burgle"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Burgle"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [AT_035] Beneath the Grounds - COST:3 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: Shuffle 3 Ambushes into your opponent's deck. When drawn, you summon a 4/4 Nerubian.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BeneathTheGrounds_AT_035()
		{
			// TODO BeneathTheGrounds_AT_035 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Beneath the Grounds"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Beneath the Grounds"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Beneath the Grounds"));
		}

		// ----------------------------------------- WEAPON - ROGUE
		// [AT_034] Poisoned Blade - COST:4 [ATK:1/HP:0] 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: Your Hero Power gives this weapon +1 Attack instead of replacing it.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 3
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PoisonedBlade_AT_034()
		{
			// TODO PoisonedBlade_AT_034 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Poisoned Blade"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Poisoned Blade"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Poisoned Blade"));
		}

	}

	public class ShamanTgtTest
	{
		// ---------------------------------------- MINION - SHAMAN
		// [AT_046] Tuskarr Totemic - COST:3 [ATK:3/HP:2] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a random basic Totem.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TuskarrTotemic_AT_046()
		{
			// TODO TuskarrTotemic_AT_046 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tuskarr Totemic"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tuskarr Totemic"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tuskarr Totemic"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [AT_047] Draenei Totemcarver - COST:4 [ATK:4/HP:4] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Gain +1/+1 for each friendly Totem.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DraeneiTotemcarver_AT_047()
		{
			// TODO DraeneiTotemcarver_AT_047 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Draenei Totemcarver"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Draenei Totemcarver"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Draenei Totemcarver"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [AT_049] Thunder Bluff Valiant - COST:5 [ATK:3/HP:6] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Give your Totems +2 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ThunderBluffValiant_AT_049()
		{
			// TODO ThunderBluffValiant_AT_049 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Thunder Bluff Valiant"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Thunder Bluff Valiant"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Thunder Bluff Valiant"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [AT_052] Totem Golem - COST:2 [ATK:3/HP:4] 
		// - Race: totem, Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Overload:</b> (1)
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 1
		// - OVERLOAD_OWED = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TotemGolem_AT_052()
		{
			// TODO TotemGolem_AT_052 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Totem Golem"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Totem Golem"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Totem Golem"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [AT_054] The Mistcaller - COST:6 [ATK:4/HP:4] 
		// - Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give all minions in your hand and deck +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheMistcaller_AT_054()
		{
			// TODO TheMistcaller_AT_054 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Mistcaller"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Mistcaller"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Mistcaller"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [AT_048] Healing Wave - COST:3 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: Restore #7 Health. Reveal a minion in each deck. If yours costs more, Restore #14 instead.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HealingWave_AT_048()
		{
			// TODO HealingWave_AT_048 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Healing Wave"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Healing Wave"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Healing Wave"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [AT_051] Elemental Destruction - COST:3 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: Deal $4-$5 damage to all minions. <b>Overload:</b> (5) @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 5
		// - OVERLOAD_OWED = 5
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ElementalDestruction_AT_051()
		{
			// TODO ElementalDestruction_AT_051 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Elemental Destruction"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Elemental Destruction"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Elemental Destruction"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [AT_053] Ancestral Knowledge - COST:2 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: Draw 2 cards. <b>Overload:</b> (2)
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 2
		// - OVERLOAD_OWED = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AncestralKnowledge_AT_053()
		{
			// TODO AncestralKnowledge_AT_053 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ancestral Knowledge"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ancestral Knowledge"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ancestral Knowledge"));
		}

		// ---------------------------------------- WEAPON - SHAMAN
		// [AT_050] Charged Hammer - COST:4 [ATK:2/HP:0] 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Your Hero Power becomes 'Deal 2 damage.'
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 4
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ChargedHammer_AT_050()
		{
			// TODO ChargedHammer_AT_050 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Charged Hammer"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Charged Hammer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Charged Hammer"));
		}

	}

	public class WarlockTgtTest
	{
		// --------------------------------------- MINION - WARLOCK
		// [AT_019] Dreadsteed - COST:4 [ATK:1/HP:1] 
		// - Race: demon, Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> At the end
		//        of the turn, summon a Dreadsteed.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Dreadsteed_AT_019()
		{
			// TODO Dreadsteed_AT_019 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dreadsteed"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dreadsteed"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dreadsteed"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [AT_020] Fearsome Doomguard - COST:7 [ATK:6/HP:8] 
		// - Race: demon, Set: tgt, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FearsomeDoomguard_AT_020()
		{
			// TODO FearsomeDoomguard_AT_020 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fearsome Doomguard"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fearsome Doomguard"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fearsome Doomguard"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [AT_021] Tiny Knight of Evil - COST:2 [ATK:3/HP:2] 
		// - Race: demon, Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you discard a card, gain +1/+1.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TinyKnightOfEvil_AT_021()
		{
			// TODO TinyKnightOfEvil_AT_021 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tiny Knight of Evil"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tiny Knight of Evil"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tiny Knight of Evil"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [AT_023] Void Crusher - COST:6 [ATK:5/HP:4] 
		// - Race: demon, Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Destroy a random minion for each player.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VoidCrusher_AT_023()
		{
			// TODO VoidCrusher_AT_023 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Void Crusher"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Void Crusher"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Void Crusher"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [AT_026] Wrathguard - COST:2 [ATK:4/HP:3] 
		// - Race: demon, Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever this minion takes damage, also deal that amount to your hero.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Wrathguard_AT_026()
		{
			// TODO Wrathguard_AT_026 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wrathguard"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wrathguard"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wrathguard"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [AT_027] Wilfred Fizzlebang - COST:6 [ATK:4/HP:4] 
		// - Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: Cards you draw from your Hero Power cost (0).
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WilfredFizzlebang_AT_027()
		{
			// TODO WilfredFizzlebang_AT_027 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wilfred Fizzlebang"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wilfred Fizzlebang"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wilfred Fizzlebang"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [AT_022] Fist of Jaraxxus - COST:4 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: When you play or discard this, deal $4 damage to a random enemy. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - InvisibleDeathrattle = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FistOfJaraxxus_AT_022()
		{
			// TODO FistOfJaraxxus_AT_022 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fist of Jaraxxus"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fist of Jaraxxus"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fist of Jaraxxus"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [AT_024] Demonfuse - COST:2 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: Give a Demon +3/+3. Give your opponent a Mana Crystal.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_WITH_RACE = 15
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Demonfuse_AT_024()
		{
			// TODO Demonfuse_AT_024 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Demonfuse"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Demonfuse"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Demonfuse"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [AT_025] Dark Bargain - COST:6 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: Destroy 2 random enemy minions. Discard 2 random cards.
		// --------------------------------------------------------
		// GameTag:
		// - 890 = 2
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINIMUM_ENEMY_MINIONS = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DarkBargain_AT_025()
		{
			// TODO DarkBargain_AT_025 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dark Bargain"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dark Bargain"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dark Bargain"));
		}

	}

	public class WarriorTgtTest
	{
		// --------------------------------------- MINION - WARRIOR
		// [AT_066] Orgrimmar Aspirant - COST:3 [ATK:3/HP:3] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Give your weapon +1 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OrgrimmarAspirant_AT_066()
		{
			// TODO OrgrimmarAspirant_AT_066 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Orgrimmar Aspirant"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Orgrimmar Aspirant"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Orgrimmar Aspirant"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [AT_067] Magnataur Alpha - COST:4 [ATK:5/HP:3] 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: Also damages the minions next to whomever
		//       he attacks.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MagnataurAlpha_AT_067()
		{
			// TODO MagnataurAlpha_AT_067 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Magnataur Alpha"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Magnataur Alpha"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Magnataur Alpha"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [AT_069] Sparring Partner - COST:2 [ATK:3/HP:2] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Battlecry:</b> Give a
		//       minion <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SparringPartner_AT_069()
		{
			// TODO SparringPartner_AT_069 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sparring Partner"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sparring Partner"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sparring Partner"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [AT_071] Alexstrasza's Champion - COST:2 [ATK:2/HP:3] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding a Dragon, gain +1 Attack and <b>Charge</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AlexstraszasChampion_AT_071()
		{
			// TODO AlexstraszasChampion_AT_071 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Alexstrasza's Champion"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Alexstrasza's Champion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Alexstrasza's Champion"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [AT_072] Varian Wrynn - COST:10 [ATK:7/HP:7] 
		// - Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Draw 3 cards.
		//       Put any minions you drew directly into the battlefield.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VarianWrynn_AT_072()
		{
			// TODO VarianWrynn_AT_072 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Varian Wrynn"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Varian Wrynn"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Varian Wrynn"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [AT_130] Sea Reaver - COST:6 [ATK:6/HP:7] 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: When you draw this, deal 1 damage to your minions.
		// --------------------------------------------------------
		// GameTag:
		// - TOPDECK = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SeaReaver_AT_130()
		{
			// TODO SeaReaver_AT_130 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sea Reaver"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sea Reaver"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sea Reaver"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [AT_064] Bash - COST:3 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $3 damage.
		//       Gain 3 Armor. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Bash_AT_064()
		{
			// TODO Bash_AT_064 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bash"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bash"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bash"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [AT_068] Bolster - COST:2 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: Give your <b>Taunt</b> minions +2/+2.
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Bolster_AT_068()
		{
			// TODO Bolster_AT_068 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bolster"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bolster"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bolster"));
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [AT_065] King's Defender - COST:3 [ATK:3/HP:0] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you have a minion with <b>Taunt</b>, gain +1 Durability.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KingsDefender_AT_065()
		{
			// TODO KingsDefender_AT_065 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("King's Defender"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("King's Defender"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "King's Defender"));
		}

	}

	public class NeutralTgtTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [AT_017] Twilight Guardian - COST:4 [ATK:2/HP:6] 
		// - Race: dragon, Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding a Dragon, gain +1 Attack and <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TwilightGuardian_AT_017()
		{
			// TODO TwilightGuardian_AT_017 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Twilight Guardian"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twilight Guardian"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Twilight Guardian"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_070] Skycap'n Kragg - COST:7 [ATK:4/HP:6] 
		// - Race: pirate, Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Charrrrrge</b>
		//       Costs (1) less for each friendly Pirate.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SkycapnKragg_AT_070()
		{
			// TODO SkycapnKragg_AT_070 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Skycap'n Kragg"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Skycap'n Kragg"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Skycap'n Kragg"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_080] Garrison Commander - COST:2 [ATK:2/HP:3] 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: You can use your Hero Power twice a turn.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GarrisonCommander_AT_080()
		{
			// TODO GarrisonCommander_AT_080 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Garrison Commander"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Garrison Commander"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Garrison Commander"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_082] Lowly Squire - COST:1 [ATK:1/HP:2] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Gain +1 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LowlySquire_AT_082()
		{
			// TODO LowlySquire_AT_082 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lowly Squire"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lowly Squire"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lowly Squire"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_083] Dragonhawk Rider - COST:3 [ATK:3/HP:3] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Gain <b>Windfury</b>
		//       this turn.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		// RefTag:
		// - WINDFURY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DragonhawkRider_AT_083()
		{
			// TODO DragonhawkRider_AT_083 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dragonhawk Rider"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragonhawk Rider"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dragonhawk Rider"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_084] Lance Carrier - COST:2 [ATK:1/HP:2] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly minion +2 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LanceCarrier_AT_084()
		{
			// TODO LanceCarrier_AT_084 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lance Carrier"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lance Carrier"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lance Carrier"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_085] Maiden of the Lake - COST:4 [ATK:2/HP:6] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: Your Hero Power costs (1).
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MaidenOfTheLake_AT_085()
		{
			// TODO MaidenOfTheLake_AT_085 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Maiden of the Lake"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Maiden of the Lake"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Maiden of the Lake"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_086] Saboteur - COST:3 [ATK:4/HP:3] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Your opponent's Hero Power costs (5) more next turn.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Saboteur_AT_086()
		{
			// TODO Saboteur_AT_086 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Saboteur"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Saboteur"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Saboteur"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_087] Argent Horserider - COST:3 [ATK:2/HP:1] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Charge</b>
		//       <b>Divine Shield</b>
		// --------------------------------------------------------
		// GameTag:
		// - DIVINE_SHIELD = 1
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArgentHorserider_AT_087()
		{
			// TODO ArgentHorserider_AT_087 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Argent Horserider"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Argent Horserider"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Argent Horserider"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_088] Mogor's Champion - COST:6 [ATK:8/HP:5] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: 50% chance to attack the wrong enemy.
		// --------------------------------------------------------
		// GameTag:
		// - FORGETFUL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MogorsChampion_AT_088()
		{
			// TODO MogorsChampion_AT_088 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mogor's Champion"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mogor's Champion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mogor's Champion"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_089] Boneguard Lieutenant - COST:2 [ATK:3/HP:2] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Gain +1 Health.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BoneguardLieutenant_AT_089()
		{
			// TODO BoneguardLieutenant_AT_089 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Boneguard Lieutenant"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Boneguard Lieutenant"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Boneguard Lieutenant"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_090] Mukla's Champion - COST:5 [ATK:4/HP:3] 
		// - Race: beast, Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Give your other minions +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MuklasChampion_AT_090()
		{
			// TODO MuklasChampion_AT_090 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mukla's Champion"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mukla's Champion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mukla's Champion"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_091] Tournament Medic - COST:4 [ATK:1/HP:8] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Restore 2 Health to your hero.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TournamentMedic_AT_091()
		{
			// TODO TournamentMedic_AT_091 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tournament Medic"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tournament Medic"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tournament Medic"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_092] Ice Rager - COST:3 [ATK:5/HP:2] 
		// - Race: elemental, Set: tgt, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IceRager_AT_092()
		{
			// TODO IceRager_AT_092 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ice Rager"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ice Rager"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ice Rager"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_093] Frigid Snobold - COST:4 [ATK:2/HP:6] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Spell Damage +1</b>
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FrigidSnobold_AT_093()
		{
			// TODO FrigidSnobold_AT_093 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Frigid Snobold"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frigid Snobold"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Frigid Snobold"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_094] Flame Juggler - COST:2 [ATK:2/HP:3] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 1 damage to a random enemy.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FlameJuggler_AT_094()
		{
			// TODO FlameJuggler_AT_094 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Flame Juggler"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flame Juggler"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Flame Juggler"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_095] Silent Knight - COST:3 [ATK:2/HP:2] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Stealth</b>
		//       <b>Divine Shield</b>
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SilentKnight_AT_095()
		{
			// TODO SilentKnight_AT_095 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Silent Knight"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Silent Knight"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Silent Knight"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_096] Clockwork Knight - COST:5 [ATK:5/HP:5] 
		// - Race: mechanical, Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly Mech +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_WITH_RACE = 17
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ClockworkKnight_AT_096()
		{
			// TODO ClockworkKnight_AT_096 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Clockwork Knight"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Clockwork Knight"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Clockwork Knight"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_097] Tournament Attendee - COST:1 [ATK:2/HP:1] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TournamentAttendee_AT_097()
		{
			// TODO TournamentAttendee_AT_097 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tournament Attendee"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tournament Attendee"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tournament Attendee"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_098] Sideshow Spelleater - COST:6 [ATK:6/HP:5] 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Copy your opponent's Hero Power.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SideshowSpelleater_AT_098()
		{
			// TODO SideshowSpelleater_AT_098 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sideshow Spelleater"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sideshow Spelleater"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sideshow Spelleater"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_099] Kodorider - COST:6 [ATK:3/HP:5] 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Summon a 3/5 War Kodo.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Kodorider_AT_099()
		{
			// TODO Kodorider_AT_099 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kodorider"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kodorider"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kodorider"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_100] Silver Hand Regent - COST:3 [ATK:3/HP:3] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Summon a 1/1 Silver Hand Recruit.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SilverHandRegent_AT_100()
		{
			// TODO SilverHandRegent_AT_100 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Silver Hand Regent"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Silver Hand Regent"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Silver Hand Regent"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_101] Pit Fighter - COST:5 [ATK:5/HP:6] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PitFighter_AT_101()
		{
			// TODO PitFighter_AT_101 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Pit Fighter"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pit Fighter"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Pit Fighter"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_102] Captured Jormungar - COST:7 [ATK:5/HP:9] 
		// - Race: beast, Set: tgt, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CapturedJormungar_AT_102()
		{
			// TODO CapturedJormungar_AT_102 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Captured Jormungar"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Captured Jormungar"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Captured Jormungar"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_103] North Sea Kraken - COST:9 [ATK:9/HP:7] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 4 damage.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NorthSeaKraken_AT_103()
		{
			// TODO NorthSeaKraken_AT_103 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("North Sea Kraken"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("North Sea Kraken"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "North Sea Kraken"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_105] Injured Kvaldir - COST:1 [ATK:2/HP:4] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 3 damage to this minion.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void InjuredKvaldir_AT_105()
		{
			// TODO InjuredKvaldir_AT_105 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Injured Kvaldir"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Injured Kvaldir"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Injured Kvaldir"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_106] Light's Champion - COST:3 [ATK:4/HP:3] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Silence</b> a Demon.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_TARGET_WITH_RACE = 15
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - SILENCE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LightsChampion_AT_106()
		{
			// TODO LightsChampion_AT_106 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Light's Champion"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Light's Champion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Light's Champion"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_108] Armored Warhorse - COST:4 [ATK:5/HP:3] 
		// - Race: beast, Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Reveal a minion in each deck. If yours costs more, gain <b>Charge</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArmoredWarhorse_AT_108()
		{
			// TODO ArmoredWarhorse_AT_108 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Armored Warhorse"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Armored Warhorse"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Armored Warhorse"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_109] Argent Watchman - COST:2 [ATK:2/HP:4] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: Can't attack.
		//       <b>Inspire:</b> Can attack as normal this turn.
		// --------------------------------------------------------
		// GameTag:
		// - CANT_ATTACK = 1
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArgentWatchman_AT_109()
		{
			// TODO ArgentWatchman_AT_109 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Argent Watchman"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Argent Watchman"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Argent Watchman"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_110] Coliseum Manager - COST:3 [ATK:2/HP:5] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Return this minion to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ColiseumManager_AT_110()
		{
			// TODO ColiseumManager_AT_110 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Coliseum Manager"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Coliseum Manager"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Coliseum Manager"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_111] Refreshment Vendor - COST:4 [ATK:3/HP:5] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Restore 4 Health to each hero.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RefreshmentVendor_AT_111()
		{
			// TODO RefreshmentVendor_AT_111 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Refreshment Vendor"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Refreshment Vendor"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Refreshment Vendor"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_112] Master Jouster - COST:6 [ATK:5/HP:6] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Reveal a minion in each deck. If yours costs more, gain <b>Taunt</b> and <b>Divine Shield</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MasterJouster_AT_112()
		{
			// TODO MasterJouster_AT_112 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Master Jouster"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Master Jouster"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Master Jouster"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_113] Recruiter - COST:5 [ATK:5/HP:4] 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Add a 2/2 Squire to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Recruiter_AT_113()
		{
			// TODO Recruiter_AT_113 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Recruiter"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Recruiter"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Recruiter"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_114] Evil Heckler - COST:4 [ATK:5/HP:4] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EvilHeckler_AT_114()
		{
			// TODO EvilHeckler_AT_114 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Evil Heckler"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Evil Heckler"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Evil Heckler"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_115] Fencing Coach - COST:3 [ATK:2/HP:2] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> The next time you use your Hero Power, it costs (2) less.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FencingCoach_AT_115()
		{
			// TODO FencingCoach_AT_115 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fencing Coach"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fencing Coach"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fencing Coach"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_117] Master of Ceremonies - COST:3 [ATK:4/HP:2] 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you have a minion with <b>Spell Damage</b>, gain +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MasterOfCeremonies_AT_117()
		{
			// TODO MasterOfCeremonies_AT_117 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Master of Ceremonies"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Master of Ceremonies"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Master of Ceremonies"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_118] Grand Crusader - COST:6 [ATK:5/HP:5] 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add a random Paladin card to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GrandCrusader_AT_118()
		{
			// TODO GrandCrusader_AT_118 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grand Crusader"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grand Crusader"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grand Crusader"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_119] Kvaldir Raider - COST:5 [ATK:4/HP:4] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Gain +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KvaldirRaider_AT_119()
		{
			// TODO KvaldirRaider_AT_119 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kvaldir Raider"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kvaldir Raider"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kvaldir Raider"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_120] Frost Giant - COST:10 [ATK:8/HP:8] 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: Costs (1) less for each time you used your Hero Power this game.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FrostGiant_AT_120()
		{
			// TODO FrostGiant_AT_120 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Frost Giant"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frost Giant"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Frost Giant"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_121] Crowd Favorite - COST:4 [ATK:4/HP:4] 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: Whenever you play a card with <b>Battlecry</b>, gain +1/+1.
		// --------------------------------------------------------
		// RefTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CrowdFavorite_AT_121()
		{
			// TODO CrowdFavorite_AT_121 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Crowd Favorite"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Crowd Favorite"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Crowd Favorite"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_122] Gormok the Impaler - COST:4 [ATK:4/HP:4] 
		// - Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you have at least 4 other minions, deal 4 damage.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_MINIONS = 4
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GormokTheImpaler_AT_122()
		{
			// TODO GormokTheImpaler_AT_122 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gormok the Impaler"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gormok the Impaler"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gormok the Impaler"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_123] Chillmaw - COST:7 [ATK:6/HP:6] 
		// - Race: dragon, Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       <b>Deathrattle:</b> If you're holding
		//       a Dragon, deal 3 damage
		//       to all minions.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - TAUNT = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Chillmaw_AT_123()
		{
			// TODO Chillmaw_AT_123 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Chillmaw"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chillmaw"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Chillmaw"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_124] Bolf Ramshield - COST:6 [ATK:3/HP:9] 
		// - Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever your hero takes damage, this minion takes it instead.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BolfRamshield_AT_124()
		{
			// TODO BolfRamshield_AT_124 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bolf Ramshield"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bolf Ramshield"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bolf Ramshield"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_125] Icehowl - COST:9 [ATK:10/HP:10] 
		// - Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Charge</b>
		//       Can't attack heroes.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Icehowl_AT_125()
		{
			// TODO Icehowl_AT_125 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Icehowl"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Icehowl"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Icehowl"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_127] Nexus-Champion Saraad - COST:5 [ATK:4/HP:5] 
		// - Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Add a random spell to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NexusChampionSaraad_AT_127()
		{
			// TODO NexusChampionSaraad_AT_127 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nexus-Champion Saraad"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nexus-Champion Saraad"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nexus-Champion Saraad"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_128] The Skeleton Knight - COST:6 [ATK:7/HP:4] 
		// - Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Reveal a minion in each deck. If yours costs more, return this to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheSkeletonKnight_AT_128()
		{
			// TODO TheSkeletonKnight_AT_128 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Skeleton Knight"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Skeleton Knight"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Skeleton Knight"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_129] Fjola Lightbane - COST:3 [ATK:3/HP:4] 
		// - Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever <b>you</b> target this minion with a spell, gain <b>Divine Shield.</b>
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		// RefTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FjolaLightbane_AT_129()
		{
			// TODO FjolaLightbane_AT_129 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fjola Lightbane"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fjola Lightbane"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fjola Lightbane"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_131] Eydis Darkbane - COST:3 [ATK:3/HP:4] 
		// - Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever <b>you</b> target this minion with a spell, deal 3 damage to a random enemy.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EydisDarkbane_AT_131()
		{
			// TODO EydisDarkbane_AT_131 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Eydis Darkbane"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eydis Darkbane"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Eydis Darkbane"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_132] Justicar Trueheart - COST:6 [ATK:6/HP:3] 
		// - Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Replace your starting Hero Power with a better one.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JusticarTrueheart_AT_132()
		{
			// TODO JusticarTrueheart_AT_132 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Justicar Trueheart"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Justicar Trueheart"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Justicar Trueheart"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_133] Gadgetzan Jouster - COST:1 [ATK:1/HP:2] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Reveal a minion in each deck. If yours costs more, gain +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GadgetzanJouster_AT_133()
		{
			// TODO GadgetzanJouster_AT_133 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gadgetzan Jouster"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gadgetzan Jouster"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gadgetzan Jouster"));
		}

	}

}
