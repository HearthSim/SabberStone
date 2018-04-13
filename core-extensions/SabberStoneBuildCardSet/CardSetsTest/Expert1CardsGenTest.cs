using Xunit;
using SabberStoneCore.Enums;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCoreTest.CardSets.Undefined
{
	public class HeroesExpert1Test
	{
		// ----------------------------------------- HERO - WARLOCK
		// [EX1_323h] Lord Jaraxxus (*) - COST:0 [ATK:0/HP:15] 
		// - Race: demon, Fac: neutral, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1178
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LordJaraxxus_EX1_323h()
		{
			// TODO LordJaraxxus_EX1_323h test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lord Jaraxxus"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lord Jaraxxus"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lord Jaraxxus"));
		}

	}

	public class HeroPowersExpert1Test
	{
		// ------------------------------------ HERO_POWER - PRIEST
		// [EX1_625t] Mind Spike (*) - COST:2 
		// - Set: expert1, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $2 damage. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MindSpike_EX1_625t()
		{
			// TODO MindSpike_EX1_625t test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mind Spike"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mind Spike"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mind Spike"));
		}

		// ------------------------------------ HERO_POWER - PRIEST
		// [EX1_625t2] Mind Shatter (*) - COST:2 
		// - Set: expert1, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $3 damage. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MindShatter_EX1_625t2()
		{
			// TODO MindShatter_EX1_625t2 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mind Shatter"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mind Shatter"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mind Shatter"));
		}

		// ----------------------------------- HERO_POWER - WARLOCK
		// [EX1_tk33] INFERNO! (*) - COST:2 
		// - Fac: neutral, Set: expert1, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 6/6 Infernal.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Inferno_EX1_tk33()
		{
			// TODO Inferno_EX1_tk33 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("INFERNO!"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("INFERNO!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "INFERNO!"));
		}

	}

	public class DruidExpert1Test
	{
		// ----------------------------------------- MINION - DRUID
		// [EX1_165] Druid of the Claw - COST:5 [ATK:4/HP:4] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Choose One -</b> Transform
		//       into a 4/4 with <b>Charge</b>;
		//       or a 4/6 with <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DruidOfTheClaw_EX1_165()
		{
			// TODO DruidOfTheClaw_EX1_165 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Druid of the Claw"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Druid of the Claw"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Druid of the Claw"));
		}

		// ----------------------------------------- MINION - DRUID
		// [EX1_166] Keeper of the Grove - COST:4 [ATK:2/HP:2] 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Choose One -</b> Deal_2_damage; or <b>Silence</b> a minion.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		// RefTag:
		// - SILENCE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KeeperOfTheGrove_EX1_166()
		{
			// TODO KeeperOfTheGrove_EX1_166 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Keeper of the Grove"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Keeper of the Grove"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Keeper of the Grove"));
		}

		// ----------------------------------------- MINION - DRUID
		// [EX1_178] Ancient of War - COST:7 [ATK:5/HP:5] 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Choose One -</b>
		//       +5 Attack; or +5 Health and <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AncientOfWar_EX1_178()
		{
			// TODO AncientOfWar_EX1_178 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ancient of War"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ancient of War"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ancient of War"));
		}

		// ----------------------------------------- MINION - DRUID
		// [EX1_573] Cenarius - COST:9 [ATK:5/HP:8] 
		// - Fac: neutral, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Choose One -</b> Give your other minions +2/+2; or Summon two 2/2 Treants with <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Cenarius_EX1_573()
		{
			// TODO Cenarius_EX1_573 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cenarius"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cenarius"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cenarius"));
		}

		// ----------------------------------------- MINION - DRUID
		// [NEW1_008] Ancient of Lore - COST:7 [ATK:5/HP:5] 
		// - Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Choose One -</b> Draw a card; or Restore 5 Health.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AncientOfLore_NEW1_008()
		{
			// TODO AncientOfLore_NEW1_008 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ancient of Lore"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ancient of Lore"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ancient of Lore"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [EX1_154] Wrath - COST:2 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Choose One -</b>
		//       Deal $3 damage to a minion; or $1 damage
		//       and draw a card. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Wrath_EX1_154()
		{
			// TODO Wrath_EX1_154 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wrath"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wrath"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wrath"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [EX1_155] Mark of Nature - COST:3 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Choose One -</b> Give a minion +4 Attack; or +4 Health and <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MarkOfNature_EX1_155()
		{
			// TODO MarkOfNature_EX1_155 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mark of Nature"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mark of Nature"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mark of Nature"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [EX1_158] Soul of the Forest - COST:4 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Give your minions "<b>Deathrattle:</b> Summon a 2/2 Treant."
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SoulOfTheForest_EX1_158()
		{
			// TODO SoulOfTheForest_EX1_158 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Soul of the Forest"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Soul of the Forest"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Soul of the Forest"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [EX1_160] Power of the Wild - COST:2 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Choose One -</b> Give your minions +1/+1; or Summon a 3/2 Panther.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PowerOfTheWild_EX1_160()
		{
			// TODO PowerOfTheWild_EX1_160 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Power of the Wild"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Power of the Wild"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Power of the Wild"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [EX1_161] Naturalize - COST:1 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Destroy a minion.
		//       Your opponent draws 2_cards.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Naturalize_EX1_161()
		{
			// TODO Naturalize_EX1_161 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Naturalize"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Naturalize"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Naturalize"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [EX1_164] Nourish - COST:5 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Choose One -</b> Gain 2_Mana Crystals; or Draw 3 cards.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Nourish_EX1_164()
		{
			// TODO Nourish_EX1_164 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nourish"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nourish"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nourish"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [EX1_570] Bite - COST:4 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Give your hero +4_Attack this turn. Gain 4 Armor.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Bite_EX1_570()
		{
			// TODO Bite_EX1_570 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bite"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bite"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bite"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [EX1_571] Force of Nature - COST:5 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Summon three 2/2 Treants.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ForceOfNature_EX1_571()
		{
			// TODO ForceOfNature_EX1_571 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Force of Nature"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Force of Nature"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Force of Nature"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [EX1_578] Savagery - COST:1 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal damage equal to your hero's Attack to a minion. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - AFFECTED_BY_SPELL_POWER = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Savagery_EX1_578()
		{
			// TODO Savagery_EX1_578 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Savagery"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Savagery"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Savagery"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [NEW1_007] Starfall - COST:5 
		// - Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Choose One -</b>
		//       Deal $5 damage to a minion; or $2 damage to all enemy minions. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Starfall_NEW1_007()
		{
			// TODO Starfall_NEW1_007 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Starfall"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Starfall"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Starfall"));
		}

	}

	public class HunterExpert1Test
	{
		// ---------------------------------------- MINION - HUNTER
		// [EX1_531] Scavenging Hyena - COST:2 [ATK:2/HP:2] 
		// - Race: beast, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever a friendly Beast dies, gain +2/+1.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ScavengingHyena_EX1_531()
		{
			// TODO ScavengingHyena_EX1_531 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Scavenging Hyena"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Scavenging Hyena"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Scavenging Hyena"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [EX1_534] Savannah Highmane - COST:6 [ATK:6/HP:5] 
		// - Race: beast, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon two 2/2 Hyenas.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SavannahHighmane_EX1_534()
		{
			// TODO SavannahHighmane_EX1_534 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Savannah Highmane"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Savannah Highmane"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Savannah Highmane"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [EX1_543] King Krush - COST:9 [ATK:8/HP:8] 
		// - Race: beast, Fac: neutral, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Charge</b>
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KingKrush_EX1_543()
		{
			// TODO KingKrush_EX1_543 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("King Krush"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("King Krush"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "King Krush"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [EX1_533] Misdirection - COST:2 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When an enemy attacks your hero, instead it attacks another random character.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Misdirection_EX1_533()
		{
			// TODO Misdirection_EX1_533 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Misdirection"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Misdirection"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Misdirection"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [EX1_537] Explosive Shot - COST:5 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $5 damage to a minion and $2 damage to adjacent ones. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ExplosiveShot_EX1_537()
		{
			// TODO ExplosiveShot_EX1_537 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Explosive Shot"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Explosive Shot"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Explosive Shot"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [EX1_538] Unleash the Hounds - COST:3 
		// - Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: For each enemy minion, summon a 1/1 Hound with <b>Charge</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINIMUM_ENEMY_MINIONS = 1
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		// RefTag:
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnleashTheHounds_EX1_538()
		{
			// TODO UnleashTheHounds_EX1_538 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unleash the Hounds"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unleash the Hounds"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Unleash the Hounds"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [EX1_544] Flare - COST:2 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: All minions lose <b>Stealth</b>. Destroy all enemy <b>Secrets</b>. Draw a card.
		// --------------------------------------------------------
		// RefTag:
		// - STEALTH = 1
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Flare_EX1_544()
		{
			// TODO Flare_EX1_544 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Flare"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flare"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Flare"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [EX1_549] Bestial Wrath - COST:1 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Give a friendly Beast +2 Attack and <b>Immune</b> this turn.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_TARGET_WITH_RACE = 20
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - IMMUNE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BestialWrath_EX1_549()
		{
			// TODO BestialWrath_EX1_549 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bestial Wrath"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bestial Wrath"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bestial Wrath"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [EX1_554] Snake Trap - COST:2 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When one of your minions is attacked, summon three 1/1 Snakes.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SnakeTrap_EX1_554()
		{
			// TODO SnakeTrap_EX1_554 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Snake Trap"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Snake Trap"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Snake Trap"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [EX1_609] Snipe - COST:2 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> After your opponent plays a minion, deal $4 damage to it. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Snipe_EX1_609()
		{
			// TODO Snipe_EX1_609 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Snipe"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Snipe"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Snipe"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [EX1_610] Explosive Trap - COST:2 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When your hero is attacked, deal $2 damage to all enemies. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ExplosiveTrap_EX1_610()
		{
			// TODO ExplosiveTrap_EX1_610 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Explosive Trap"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Explosive Trap"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Explosive Trap"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [EX1_611] Freezing Trap - COST:2 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When an enemy minion attacks, return it to its owner's hand. It costs (2) more.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FreezingTrap_EX1_611()
		{
			// TODO FreezingTrap_EX1_611 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Freezing Trap"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Freezing Trap"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Freezing Trap"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [EX1_617] Deadly Shot - COST:3 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Destroy a random enemy minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINIMUM_ENEMY_MINIONS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DeadlyShot_EX1_617()
		{
			// TODO DeadlyShot_EX1_617 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Deadly Shot"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Deadly Shot"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Deadly Shot"));
		}

		// ---------------------------------------- WEAPON - HUNTER
		// [DS1_188] Gladiator's Longbow - COST:7 [ATK:5/HP:0] 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Your hero is <b>Immune</b> while attacking.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// --------------------------------------------------------
		// RefTag:
		// - IMMUNE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GladiatorsLongbow_DS1_188()
		{
			// TODO GladiatorsLongbow_DS1_188 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gladiator's Longbow"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gladiator's Longbow"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gladiator's Longbow"));
		}

		// ---------------------------------------- WEAPON - HUNTER
		// [EX1_536] Eaglehorn Bow - COST:3 [ATK:3/HP:0] 
		// - Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]Whenever a friendly
		//       <b>Secret</b> is revealed,
		//       gain +1 Durability.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EaglehornBow_EX1_536()
		{
			// TODO EaglehornBow_EX1_536 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Eaglehorn Bow"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eaglehorn Bow"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Eaglehorn Bow"));
		}

	}

	public class MageExpert1Test
	{
		// ------------------------------------------ MINION - MAGE
		// [EX1_274] Ethereal Arcanist - COST:4 [ATK:3/HP:3] 
		// - Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: If you control a <b>Secret</b> at_the end of your turn, gain +2/+2.
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EtherealArcanist_EX1_274()
		{
			// TODO EtherealArcanist_EX1_274 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ethereal Arcanist"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ethereal Arcanist"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ethereal Arcanist"));
		}

		// ------------------------------------------ MINION - MAGE
		// [EX1_559] Archmage Antonidas - COST:7 [ATK:5/HP:7] 
		// - Fac: neutral, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, add a 'Fireball' spell to_your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArchmageAntonidas_EX1_559()
		{
			// TODO ArchmageAntonidas_EX1_559 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Archmage Antonidas"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Archmage Antonidas"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Archmage Antonidas"));
		}

		// ------------------------------------------ MINION - MAGE
		// [EX1_608] Sorcerer's Apprentice - COST:2 [ATK:3/HP:2] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Your spells cost (1) less.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SorcerersApprentice_EX1_608()
		{
			// TODO SorcerersApprentice_EX1_608 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sorcerer's Apprentice"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sorcerer's Apprentice"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sorcerer's Apprentice"));
		}

		// ------------------------------------------ MINION - MAGE
		// [EX1_612] Kirin Tor Mage - COST:3 [ATK:4/HP:3] 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> The next <b>Secret</b>
		//       you play this turn costs (0).
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KirinTorMage_EX1_612()
		{
			// TODO KirinTorMage_EX1_612 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kirin Tor Mage"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kirin Tor Mage"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kirin Tor Mage"));
		}

		// ------------------------------------------ MINION - MAGE
		// [NEW1_012] Mana Wyrm - COST:1 [ATK:1/HP:3] 
		// - Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, gain +1 Attack.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ManaWyrm_NEW1_012()
		{
			// TODO ManaWyrm_NEW1_012 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mana Wyrm"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mana Wyrm"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mana Wyrm"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [CS2_028] Blizzard - COST:6 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $2 damage to all enemy minions and <b>Freeze</b> them. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Blizzard_CS2_028()
		{
			// TODO Blizzard_CS2_028 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blizzard"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blizzard"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blizzard"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [EX1_275] Cone of Cold - COST:4 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Freeze</b> a minion and the minions next to it, and deal $1 damage to them. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ConeOfCold_EX1_275()
		{
			// TODO ConeOfCold_EX1_275 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cone of Cold"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cone of Cold"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cone of Cold"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [EX1_279] Pyroblast - COST:10 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Deal $10 damage. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Pyroblast_EX1_279()
		{
			// TODO Pyroblast_EX1_279 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Pyroblast"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pyroblast"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Pyroblast"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [EX1_287] Counterspell - COST:3 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When your opponent casts a spell, <b>Counter</b> it.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		// RefTag:
		// - COUNTER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Counterspell_EX1_287()
		{
			// TODO Counterspell_EX1_287 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Counterspell"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Counterspell"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Counterspell"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [EX1_289] Ice Barrier - COST:3 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When your
		//       hero is attacked,
		//       gain 8 Armor.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IceBarrier_EX1_289()
		{
			// TODO IceBarrier_EX1_289 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ice Barrier"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ice Barrier"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ice Barrier"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [EX1_294] Mirror Entity - COST:3 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> After your opponent plays a minion, summon a copy of it.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MirrorEntity_EX1_294()
		{
			// TODO MirrorEntity_EX1_294 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mirror Entity"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mirror Entity"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mirror Entity"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [EX1_594] Vaporize - COST:3 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When a minion attacks your hero, destroy it.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Vaporize_EX1_594()
		{
			// TODO Vaporize_EX1_594 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Vaporize"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vaporize"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Vaporize"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [tt_010] Spellbender - COST:3 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When an enemy casts a spell on a minion, summon a 1/3 as the new target.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Spellbender_tt_010()
		{
			// TODO Spellbender_tt_010 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spellbender"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spellbender"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Spellbender"));
		}

	}

	public class PaladinExpert1Test
	{
		// --------------------------------------- MINION - PALADIN
		// [EX1_362] Argent Protector - COST:2 [ATK:2/HP:2] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly minion <b>Divine Shield</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_NONSELF_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArgentProtector_EX1_362()
		{
			// TODO ArgentProtector_EX1_362 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Argent Protector"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Argent Protector"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Argent Protector"));
		}

		// --------------------------------------- MINION - PALADIN
		// [EX1_382] Aldor Peacekeeper - COST:3 [ATK:3/HP:3] 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Change an_enemy minion's Attack to 1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_ENEMY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AldorPeacekeeper_EX1_382()
		{
			// TODO AldorPeacekeeper_EX1_382 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Aldor Peacekeeper"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Aldor Peacekeeper"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Aldor Peacekeeper"));
		}

		// --------------------------------------- MINION - PALADIN
		// [EX1_383] Tirion Fordring - COST:8 [ATK:6/HP:6] 
		// - Fac: neutral, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b><b>Divine Shield</b>,</b> <b>Taunt</b> <b>Deathrattle:</b> Equip a 5/3_Ashbringer.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - TAUNT = 1
		// - DIVINE_SHIELD = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TirionFordring_EX1_383()
		{
			// TODO TirionFordring_EX1_383 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tirion Fordring"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tirion Fordring"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tirion Fordring"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [EX1_130] Noble Sacrifice - COST:1 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When an enemy attacks, summon a 2/1 Defender as the new target.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NobleSacrifice_EX1_130()
		{
			// TODO NobleSacrifice_EX1_130 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Noble Sacrifice"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Noble Sacrifice"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Noble Sacrifice"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [EX1_132] Eye for an Eye - COST:1 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When your hero takes damage, deal_that much damage to the enemy hero.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EyeForAnEye_EX1_132()
		{
			// TODO EyeForAnEye_EX1_132 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Eye for an Eye"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eye for an Eye"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Eye for an Eye"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [EX1_136] Redemption - COST:1 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When a friendly minion dies, return it to life with 1 Health.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Redemption_EX1_136()
		{
			// TODO Redemption_EX1_136 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Redemption"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Redemption"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Redemption"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [EX1_349] Divine Favor - COST:3 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Draw cards until you have as many in hand as your opponent.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DivineFavor_EX1_349()
		{
			// TODO DivineFavor_EX1_349 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Divine Favor"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Divine Favor"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Divine Favor"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [EX1_354] Lay on Hands - COST:8 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Restore #8 Health. Draw_3 cards.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LayOnHands_EX1_354()
		{
			// TODO LayOnHands_EX1_354 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lay on Hands"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lay on Hands"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lay on Hands"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [EX1_355] Blessed Champion - COST:5 
		// - Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Double a minion's Attack.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BlessedChampion_EX1_355()
		{
			// TODO BlessedChampion_EX1_355 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blessed Champion"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blessed Champion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blessed Champion"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [EX1_363] Blessing of Wisdom - COST:1 
		// - Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Choose a minion. Whenever it attacks, draw a card.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BlessingOfWisdom_EX1_363()
		{
			// TODO BlessingOfWisdom_EX1_363 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blessing of Wisdom"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blessing of Wisdom"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blessing of Wisdom"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [EX1_365] Holy Wrath - COST:5 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Draw a card and deal_damage equal to_its Cost. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - AFFECTED_BY_SPELL_POWER = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HolyWrath_EX1_365()
		{
			// TODO HolyWrath_EX1_365 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Holy Wrath"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Holy Wrath"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Holy Wrath"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [EX1_379] Repentance - COST:1 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> After your opponent plays a minion, reduce its Health to 1.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Repentance_EX1_379()
		{
			// TODO Repentance_EX1_379 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Repentance"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Repentance"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Repentance"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [EX1_384] Avenging Wrath - COST:6 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Deal $8 damage randomly split among all enemies. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - ImmuneToSpellpower = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AvengingWrath_EX1_384()
		{
			// TODO AvengingWrath_EX1_384 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Avenging Wrath"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Avenging Wrath"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Avenging Wrath"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [EX1_619] Equality - COST:2 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Change the Health of ALL minions to 1.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Equality_EX1_619()
		{
			// TODO Equality_EX1_619 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Equality"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Equality"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Equality"));
		}

		// --------------------------------------- WEAPON - PALADIN
		// [EX1_366] Sword of Justice - COST:3 [ATK:1/HP:0] 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: After you summon a minion, give it +1/+1 and this loses 1_Durability.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 5
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SwordOfJustice_EX1_366()
		{
			// TODO SwordOfJustice_EX1_366 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sword of Justice"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sword of Justice"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sword of Justice"));
		}

	}

	public class PriestExpert1Test
	{
		// ---------------------------------------- MINION - PRIEST
		// [EX1_091] Cabal Shadow Priest - COST:6 [ATK:4/HP:5] 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Take control of an enemy minion that has 2 or less Attack.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_TARGET_MAX_ATTACK = 2
		// - REQ_MINION_TARGET = 0
		// - REQ_ENEMY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CabalShadowPriest_EX1_091()
		{
			// TODO CabalShadowPriest_EX1_091 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cabal Shadow Priest"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cabal Shadow Priest"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cabal Shadow Priest"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [EX1_335] Lightspawn - COST:4 [ATK:0/HP:5] 
		// - Race: elemental, Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: This minion's Attack is always equal to its Health.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Lightspawn_EX1_335()
		{
			// TODO Lightspawn_EX1_335 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lightspawn"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lightspawn"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lightspawn"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [EX1_341] Lightwell - COST:2 [ATK:0/HP:5] 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: At the start of your turn, restore 3 Health to a damaged friendly character.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Lightwell_EX1_341()
		{
			// TODO Lightwell_EX1_341 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lightwell"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lightwell"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lightwell"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [EX1_350] Prophet Velen - COST:7 [ATK:7/HP:7] 
		// - Fac: neutral, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: Double the damage and healing of your spells and Hero Power.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ProphetVelen_EX1_350()
		{
			// TODO ProphetVelen_EX1_350 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Prophet Velen"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Prophet Velen"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Prophet Velen"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [EX1_591] Auchenai Soulpriest - COST:4 [ATK:3/HP:5] 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Your cards and powers that restore Health now deal damage instead.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AuchenaiSoulpriest_EX1_591()
		{
			// TODO AuchenaiSoulpriest_EX1_591 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Auchenai Soulpriest"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Auchenai Soulpriest"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Auchenai Soulpriest"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [EX1_623] Temple Enforcer - COST:6 [ATK:6/HP:6] 
		// - Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly minion +3 Health.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TempleEnforcer_EX1_623()
		{
			// TODO TempleEnforcer_EX1_623 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Temple Enforcer"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Temple Enforcer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Temple Enforcer"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [CS1_129] Inner Fire - COST:1 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Change a minion's Attack to be equal to its Health.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void InnerFire_CS1_129()
		{
			// TODO InnerFire_CS1_129 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Inner Fire"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Inner Fire"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Inner Fire"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [EX1_332] Silence - COST:0 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Silence</b> a minion.
		// --------------------------------------------------------
		// GameTag:
		// - SILENCE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Silence_EX1_332()
		{
			// TODO Silence_EX1_332 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Silence"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Silence"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Silence"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [EX1_334] Shadow Madness - COST:4 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Gain control of an enemy minion with 3 or less Attack until end of turn.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_ENEMY_TARGET = 0
		// - REQ_NUM_MINION_SLOTS = 1
		// - REQ_TARGET_MAX_ATTACK = 3
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShadowMadness_EX1_334()
		{
			// TODO ShadowMadness_EX1_334 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shadow Madness"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadow Madness"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shadow Madness"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [EX1_339] Thoughtsteal - COST:3 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Copy 2 cards in your opponent's deck and add them to your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Thoughtsteal_EX1_339()
		{
			// TODO Thoughtsteal_EX1_339 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Thoughtsteal"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Thoughtsteal"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Thoughtsteal"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [EX1_345] Mindgames - COST:4 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Put a copy of
		//       a random minion from
		//       your opponent's deck into the battlefield.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Mindgames_EX1_345()
		{
			// TODO Mindgames_EX1_345 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mindgames"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mindgames"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mindgames"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [EX1_621] Circle of Healing - COST:0 
		// - Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Restore #4 Health to ALL_minions.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CircleOfHealing_EX1_621()
		{
			// TODO CircleOfHealing_EX1_621 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Circle of Healing"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Circle of Healing"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Circle of Healing"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [EX1_624] Holy Fire - COST:6 
		// - Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $5 damage. Restore #5 Health to your hero. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HolyFire_EX1_624()
		{
			// TODO HolyFire_EX1_624 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Holy Fire"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Holy Fire"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Holy Fire"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [EX1_625] Shadowform - COST:3 
		// - Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Your Hero Power becomes 'Deal 2 damage'. If already in Shadowform: 3 damage.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Shadowform_EX1_625()
		{
			// TODO Shadowform_EX1_625 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shadowform"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadowform"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shadowform"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [EX1_626] Mass Dispel - COST:4 
		// - Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Silence</b> all enemy minions. Draw a card.
		// --------------------------------------------------------
		// GameTag:
		// - SILENCE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MassDispel_EX1_626()
		{
			// TODO MassDispel_EX1_626 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mass Dispel"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mass Dispel"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mass Dispel"));
		}

	}

	public class RogueExpert1Test
	{
		// ----------------------------------------- MINION - ROGUE
		// [EX1_131] Defias Ringleader - COST:2 [ATK:2/HP:2] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Combo:</b> Summon a 2/1 Defias Bandit.
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DefiasRingleader_EX1_131()
		{
			// TODO DefiasRingleader_EX1_131 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Defias Ringleader"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Defias Ringleader"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Defias Ringleader"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [EX1_134] SI:7 Agent - COST:3 [ATK:3/HP:3] 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Combo:</b> Deal 2 damage.
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_FOR_COMBO = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Si7Agent_EX1_134()
		{
			// TODO Si7Agent_EX1_134 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("SI:7 Agent"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("SI:7 Agent"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "SI:7 Agent"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [EX1_522] Patient Assassin - COST:2 [ATK:1/HP:1] 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Stealth</b>
		//        <b>Poisonous</b>
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PatientAssassin_EX1_522()
		{
			// TODO PatientAssassin_EX1_522 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Patient Assassin"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Patient Assassin"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Patient Assassin"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [EX1_613] Edwin VanCleef - COST:3 [ATK:2/HP:2] 
		// - Fac: neutral, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Combo:</b> Gain +2/+2 for each other card you've played this turn.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - COMBO = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EdwinVancleef_EX1_613()
		{
			// TODO EdwinVancleef_EX1_613 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Edwin VanCleef"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Edwin VanCleef"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Edwin VanCleef"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [NEW1_005] Kidnapper - COST:6 [ATK:5/HP:3] 
		// - Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Combo:</b> Return a minion to_its owner's hand.
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_FOR_COMBO = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Kidnapper_NEW1_005()
		{
			// TODO Kidnapper_NEW1_005 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kidnapper"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kidnapper"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kidnapper"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [NEW1_014] Master of Disguise - COST:4 [ATK:4/HP:4] 
		// - Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly minion <b>Stealth</b> until your next turn.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_NONSELF_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MasterOfDisguise_NEW1_014()
		{
			// TODO MasterOfDisguise_NEW1_014 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Master of Disguise"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Master of Disguise"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Master of Disguise"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [CS2_073] Cold Blood - COST:1 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Give a minion +2 Attack. <b>Combo:</b> +4 Attack instead.
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ColdBlood_CS2_073()
		{
			// TODO ColdBlood_CS2_073 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cold Blood"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cold Blood"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cold Blood"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [CS2_233] Blade Flurry - COST:4 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Destroy your weapon and deal its damage to all enemy minions. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - AFFECTED_BY_SPELL_POWER = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_WEAPON_EQUIPPED = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BladeFlurry_CS2_233()
		{
			// TODO BladeFlurry_CS2_233 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blade Flurry"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blade Flurry"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blade Flurry"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [EX1_124] Eviscerate - COST:2 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $2 damage. <b>Combo:</b> Deal $4 damage instead. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Eviscerate_EX1_124()
		{
			// TODO Eviscerate_EX1_124 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Eviscerate"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eviscerate"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Eviscerate"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [EX1_126] Betrayal - COST:2 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Force an enemy minion to deal its damage to the minions next to it.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_ENEMY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Betrayal_EX1_126()
		{
			// TODO Betrayal_EX1_126 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Betrayal"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Betrayal"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Betrayal"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [EX1_137] Headcrack - COST:3 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $2 damage to the enemy hero. <b>Combo:</b> Return this to your hand next turn. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Headcrack_EX1_137()
		{
			// TODO Headcrack_EX1_137 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Headcrack"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Headcrack"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Headcrack"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [EX1_144] Shadowstep - COST:0 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Return a friendly minion to your hand. It_costs (2) less.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Shadowstep_EX1_144()
		{
			// TODO Shadowstep_EX1_144 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shadowstep"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadowstep"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shadowstep"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [EX1_145] Preparation - COST:0 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: The next spell you cast this turn costs (3) less.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Preparation_EX1_145()
		{
			// TODO Preparation_EX1_145 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Preparation"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Preparation"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Preparation"));
		}

		// ----------------------------------------- WEAPON - ROGUE
		// [EX1_133] Perdition's Blade - COST:3 [ATK:2/HP:0] 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 1 damage. <b>Combo:</b> Deal 2 instead.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// - BATTLECRY = 1
		// - COMBO = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PerditionsBlade_EX1_133()
		{
			// TODO PerditionsBlade_EX1_133 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Perdition's Blade"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Perdition's Blade"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Perdition's Blade"));
		}

	}

	public class ShamanExpert1Test
	{
		// ---------------------------------------- MINION - SHAMAN
		// [EX1_243] Dust Devil - COST:1 [ATK:3/HP:1] 
		// - Race: elemental, Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Windfury</b>. <b>Overload:</b> (2)
		// --------------------------------------------------------
		// GameTag:
		// - WINDFURY = 1
		// - OVERLOAD = 2
		// - OVERLOAD_OWED = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DustDevil_EX1_243()
		{
			// TODO DustDevil_EX1_243 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dust Devil"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dust Devil"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dust Devil"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [EX1_250] Earth Elemental - COST:5 [ATK:7/HP:8] 
		// - Race: elemental, Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b><b>Overload</b>:</b> (3)
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - OVERLOAD = 3
		// - OVERLOAD_OWED = 3
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EarthElemental_EX1_250()
		{
			// TODO EarthElemental_EX1_250 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Earth Elemental"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Earth Elemental"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Earth Elemental"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [EX1_258] Unbound Elemental - COST:3 [ATK:2/HP:4] 
		// - Race: elemental, Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever you play a card_with <b>Overload</b>, gain_+1/+1.
		// --------------------------------------------------------
		// RefTag:
		// - OVERLOAD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnboundElemental_EX1_258()
		{
			// TODO UnboundElemental_EX1_258 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unbound Elemental"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unbound Elemental"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Unbound Elemental"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [EX1_575] Mana Tide Totem - COST:3 [ATK:0/HP:3] 
		// - Race: totem, Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: At the end of your turn, draw a card.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ManaTideTotem_EX1_575()
		{
			// TODO ManaTideTotem_EX1_575 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mana Tide Totem"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mana Tide Totem"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mana Tide Totem"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [NEW1_010] Al'Akir the Windlord - COST:8 [ATK:3/HP:5] 
		// - Race: elemental, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Charge, Divine Shield, Taunt, Windfury</b>
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - WINDFURY = 1
		// - TAUNT = 1
		// - DIVINE_SHIELD = 1
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AlakirTheWindlord_NEW1_010()
		{
			// TODO AlakirTheWindlord_NEW1_010 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Al'Akir the Windlord"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Al'Akir the Windlord"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Al'Akir the Windlord"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [CS2_038] Ancestral Spirit - COST:2 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Give a minion "<b>Deathrattle:</b> Resummon this minion."
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AncestralSpirit_CS2_038()
		{
			// TODO AncestralSpirit_CS2_038 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ancestral Spirit"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ancestral Spirit"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ancestral Spirit"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [CS2_053] Far Sight - COST:3 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Draw a card. That card costs (3) less.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FarSight_CS2_053()
		{
			// TODO FarSight_CS2_053 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Far Sight"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Far Sight"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Far Sight"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [EX1_238] Lightning Bolt - COST:1 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $3 damage. <b>Overload:</b> (1) @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 1
		// - OVERLOAD_OWED = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LightningBolt_EX1_238()
		{
			// TODO LightningBolt_EX1_238 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lightning Bolt"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lightning Bolt"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lightning Bolt"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [EX1_241] Lava Burst - COST:3 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $5 damage. <b>Overload:</b> (2) @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 2
		// - OVERLOAD_OWED = 2
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LavaBurst_EX1_241()
		{
			// TODO LavaBurst_EX1_241 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lava Burst"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lava Burst"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lava Burst"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [EX1_245] Earth Shock - COST:1 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Silence</b> a minion, then deal $1 damage to it. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - SILENCE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EarthShock_EX1_245()
		{
			// TODO EarthShock_EX1_245 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Earth Shock"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Earth Shock"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Earth Shock"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [EX1_248] Feral Spirit - COST:3 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Summon two 2/3 Spirit Wolves with <b>Taunt</b>. <b>Overload:</b> (2)
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 2
		// - OVERLOAD_OWED = 2
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FeralSpirit_EX1_248()
		{
			// TODO FeralSpirit_EX1_248 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Feral Spirit"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Feral Spirit"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Feral Spirit"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [EX1_251] Forked Lightning - COST:1 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $2 damage to 2_random enemy minions. <b>Overload:</b> (2) @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 2
		// - OVERLOAD_OWED = 2
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINIMUM_ENEMY_MINIONS = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ForkedLightning_EX1_251()
		{
			// TODO ForkedLightning_EX1_251 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Forked Lightning"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Forked Lightning"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Forked Lightning"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [EX1_259] Lightning Storm - COST:3 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $2-$3 damage to all_enemy minions. <b>Overload:</b> (2) @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 2
		// - OVERLOAD_OWED = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LightningStorm_EX1_259()
		{
			// TODO LightningStorm_EX1_259 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lightning Storm"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lightning Storm"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lightning Storm"));
		}

		// ---------------------------------------- WEAPON - SHAMAN
		// [EX1_247] Stormforged Axe - COST:2 [ATK:2/HP:0] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Overload:</b> (1)
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 3
		// - OVERLOAD = 1
		// - OVERLOAD_OWED = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StormforgedAxe_EX1_247()
		{
			// TODO StormforgedAxe_EX1_247 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stormforged Axe"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stormforged Axe"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stormforged Axe"));
		}

		// ---------------------------------------- WEAPON - SHAMAN
		// [EX1_567] Doomhammer - COST:5 [ATK:2/HP:0] 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Windfury, Overload:</b> (2)
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 8
		// - WINDFURY = 1
		// - OVERLOAD = 2
		// - OVERLOAD_OWED = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Doomhammer_EX1_567()
		{
			// TODO Doomhammer_EX1_567 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Doomhammer"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Doomhammer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Doomhammer"));
		}

	}

	public class WarlockExpert1Test
	{
		// --------------------------------------- MINION - WARLOCK
		// [CS2_059] Blood Imp - COST:1 [ATK:0/HP:1] 
		// - Race: demon, Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: [x]  <b>Stealth</b>. At the end of your  
		//       turn, give another random
		//        friendly minion +1 Health.
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BloodImp_CS2_059()
		{
			// TODO BloodImp_CS2_059 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blood Imp"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blood Imp"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blood Imp"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [EX1_301] Felguard - COST:3 [ATK:3/HP:5] 
		// - Race: demon, Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Battlecry:</b> Destroy one of your Mana Crystals.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Felguard_EX1_301()
		{
			// TODO Felguard_EX1_301 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Felguard"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Felguard"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Felguard"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [EX1_304] Void Terror - COST:3 [ATK:3/HP:3] 
		// - Race: demon, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Destroy both
		//       adjacent minions and gain
		//        their Attack and Health.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VoidTerror_EX1_304()
		{
			// TODO VoidTerror_EX1_304 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Void Terror"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Void Terror"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Void Terror"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [EX1_310] Doomguard - COST:5 [ATK:5/HP:7] 
		// - Race: demon, Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Charge</b>. <b>Battlecry:</b> Discard two random cards.
		// --------------------------------------------------------
		// GameTag:
		// - CHARGE = 1
		// - BATTLECRY = 1
		// - 890 = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Doomguard_EX1_310()
		{
			// TODO Doomguard_EX1_310 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Doomguard"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Doomguard"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Doomguard"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [EX1_313] Pit Lord - COST:4 [ATK:5/HP:6] 
		// - Race: demon, Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 5 damage to your hero.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PitLord_EX1_313()
		{
			// TODO PitLord_EX1_313 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Pit Lord"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pit Lord"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Pit Lord"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [EX1_315] Summoning Portal - COST:4 [ATK:0/HP:4] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Your minions cost (2) less, but not less than (1).
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SummoningPortal_EX1_315()
		{
			// TODO SummoningPortal_EX1_315 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Summoning Portal"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Summoning Portal"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Summoning Portal"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [EX1_319] Flame Imp - COST:1 [ATK:3/HP:2] 
		// - Race: demon, Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 3 damage to your hero.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FlameImp_EX1_319()
		{
			// TODO FlameImp_EX1_319 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Flame Imp"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flame Imp"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Flame Imp"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [EX1_323] Lord Jaraxxus - COST:9 [ATK:3/HP:15] 
		// - Race: demon, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy your hero and replace it with Lord Jaraxxus.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LordJaraxxus_EX1_323()
		{
			// TODO LordJaraxxus_EX1_323 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lord Jaraxxus"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lord Jaraxxus"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lord Jaraxxus"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [EX1_303] Shadowflame - COST:4 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Destroy a friendly minion and deal its Attack damage to all enemy minions. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - AFFECTED_BY_SPELL_POWER = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Shadowflame_EX1_303()
		{
			// TODO Shadowflame_EX1_303 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shadowflame"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadowflame"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shadowflame"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [EX1_309] Siphon Soul - COST:6 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Destroy a minion. Restore #3 Health to_your hero.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SiphonSoul_EX1_309()
		{
			// TODO SiphonSoul_EX1_309 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Siphon Soul"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Siphon Soul"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Siphon Soul"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [EX1_312] Twisting Nether - COST:8 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Destroy all minions.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TwistingNether_EX1_312()
		{
			// TODO TwistingNether_EX1_312 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Twisting Nether"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twisting Nether"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Twisting Nether"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [EX1_317] Sense Demons - COST:3 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Draw 2 Demons
		//       from your deck.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SenseDemons_EX1_317()
		{
			// TODO SenseDemons_EX1_317 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sense Demons"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sense Demons"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sense Demons"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [EX1_320] Bane of Doom - COST:5 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Deal $2 damage to_a character. If that kills it, summon a random Demon. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BaneOfDoom_EX1_320()
		{
			// TODO BaneOfDoom_EX1_320 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bane of Doom"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bane of Doom"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bane of Doom"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [EX1_596] Demonfire - COST:2 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $2 damage to a minion. If it’s a friendly Demon, give it +2/+2 instead. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Demonfire_EX1_596()
		{
			// TODO Demonfire_EX1_596 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Demonfire"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Demonfire"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Demonfire"));
		}

	}

	public class WarriorExpert1Test
	{
		// --------------------------------------- MINION - WARRIOR
		// [EX1_398] Arathi Weaponsmith - COST:4 [ATK:3/HP:3] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Equip a 2/2_weapon.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArathiWeaponsmith_EX1_398()
		{
			// TODO ArathiWeaponsmith_EX1_398 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arathi Weaponsmith"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arathi Weaponsmith"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Arathi Weaponsmith"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [EX1_402] Armorsmith - COST:2 [ATK:1/HP:4] 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever a friendly minion_takes damage, gain 1 Armor.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Armorsmith_EX1_402()
		{
			// TODO Armorsmith_EX1_402 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Armorsmith"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Armorsmith"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Armorsmith"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [EX1_414] Grommash Hellscream - COST:8 [ATK:4/HP:9] 
		// - Fac: neutral, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Charge</b>
		//       Has +6 Attack while damaged.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - CHARGE = 1
		// - ENRAGED = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GrommashHellscream_EX1_414()
		{
			// TODO GrommashHellscream_EX1_414 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grommash Hellscream"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grommash Hellscream"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grommash Hellscream"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [EX1_603] Cruel Taskmaster - COST:2 [ATK:2/HP:2] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 1 damage to a minion and give it +2_Attack.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_NONSELF_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CruelTaskmaster_EX1_603()
		{
			// TODO CruelTaskmaster_EX1_603 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cruel Taskmaster"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cruel Taskmaster"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cruel Taskmaster"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [EX1_604] Frothing Berserker - COST:3 [ATK:2/HP:4] 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever a minion takes damage, gain +1 Attack.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FrothingBerserker_EX1_604()
		{
			// TODO FrothingBerserker_EX1_604 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Frothing Berserker"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frothing Berserker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Frothing Berserker"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [CS2_104] Rampage - COST:2 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Give a damaged minion +3/+3.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_DAMAGED_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Rampage_CS2_104()
		{
			// TODO Rampage_CS2_104 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rampage"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rampage"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rampage"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [EX1_391] Slam - COST:2 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $2 damage to a minion. If it survives, draw a card. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Slam_EX1_391()
		{
			// TODO Slam_EX1_391 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Slam"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Slam"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Slam"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [EX1_392] Battle Rage - COST:2 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Draw a card for each damaged friendly character.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BattleRage_EX1_392()
		{
			// TODO BattleRage_EX1_392 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Battle Rage"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Battle Rage"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Battle Rage"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [EX1_407] Brawl - COST:5 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Destroy all minions except one. <i>(chosen randomly)</i>
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINIMUM_TOTAL_MINIONS = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Brawl_EX1_407()
		{
			// TODO Brawl_EX1_407 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Brawl"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Brawl"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Brawl"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [EX1_408] Mortal Strike - COST:4 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $4 damage. If you have 12 or less Health, deal $6 instead. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MortalStrike_EX1_408()
		{
			// TODO MortalStrike_EX1_408 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mortal Strike"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mortal Strike"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mortal Strike"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [EX1_409] Upgrade! - COST:1 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: If you have a weapon, give it +1/+1. Otherwise equip a 1/3 weapon.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Upgrade_EX1_409()
		{
			// TODO Upgrade_EX1_409 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Upgrade!"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Upgrade!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Upgrade!"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [EX1_410] Shield Slam - COST:1 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Deal 1 damage to a minion for each Armor you have. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - AFFECTED_BY_SPELL_POWER = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShieldSlam_EX1_410()
		{
			// TODO ShieldSlam_EX1_410 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shield Slam"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shield Slam"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shield Slam"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [EX1_607] Inner Rage - COST:0 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $1 damage to a minion and give it +2_Attack. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void InnerRage_EX1_607()
		{
			// TODO InnerRage_EX1_607 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Inner Rage"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Inner Rage"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Inner Rage"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [NEW1_036] Commanding Shout - COST:2 
		// - Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Your minions can't be reduced below 1 Health this turn. Draw a card.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CommandingShout_NEW1_036()
		{
			// TODO CommandingShout_NEW1_036 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Commanding Shout"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Commanding Shout"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Commanding Shout"));
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [EX1_411] Gorehowl - COST:7 [ATK:7/HP:0] 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Attacking a minion costs 1 Attack instead of 1 Durability.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Gorehowl_EX1_411()
		{
			// TODO Gorehowl_EX1_411 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gorehowl"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gorehowl"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gorehowl"));
		}

	}

	public class NeutralExpert1Test
	{
		// --------------------------------------- MINION - NEUTRAL
		// [CS1_069] Fen Creeper - COST:5 [ATK:3/HP:6] 
		// - Fac: alliance, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FenCreeper_CS1_069()
		{
			// TODO FenCreeper_CS1_069 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fen Creeper"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fen Creeper"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fen Creeper"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_117] Earthen Ring Farseer - COST:3 [ATK:3/HP:3] 
		// - Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Restore 3_Health.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EarthenRingFarseer_CS2_117()
		{
			// TODO EarthenRingFarseer_CS2_117 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Earthen Ring Farseer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Earthen Ring Farseer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Earthen Ring Farseer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_146] Southsea Deckhand - COST:1 [ATK:2/HP:1] 
		// - Race: pirate, Fac: alliance, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Has <b>Charge</b> while you have a weapon equipped.
		// --------------------------------------------------------
		// RefTag:
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SouthseaDeckhand_CS2_146()
		{
			// TODO SouthseaDeckhand_CS2_146 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Southsea Deckhand"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Southsea Deckhand"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Southsea Deckhand"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_151] Silver Hand Knight - COST:5 [ATK:4/HP:4] 
		// - Fac: alliance, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 2/2_Squire.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SilverHandKnight_CS2_151()
		{
			// TODO SilverHandKnight_CS2_151 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Silver Hand Knight"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Silver Hand Knight"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Silver Hand Knight"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_161] Ravenholdt Assassin - COST:7 [ATK:7/HP:5] 
		// - Fac: alliance, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Stealth</b>
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RavenholdtAssassin_CS2_161()
		{
			// TODO RavenholdtAssassin_CS2_161 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ravenholdt Assassin"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ravenholdt Assassin"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ravenholdt Assassin"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_169] Young Dragonhawk - COST:1 [ATK:1/HP:1] 
		// - Race: beast, Fac: horde, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Windfury</b>
		// --------------------------------------------------------
		// GameTag:
		// - WINDFURY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void YoungDragonhawk_CS2_169()
		{
			// TODO YoungDragonhawk_CS2_169 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Young Dragonhawk"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Young Dragonhawk"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Young Dragonhawk"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_181] Injured Blademaster - COST:3 [ATK:4/HP:7] 
		// - Fac: horde, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 4 damage to HIMSELF.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void InjuredBlademaster_CS2_181()
		{
			// TODO InjuredBlademaster_CS2_181 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Injured Blademaster"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Injured Blademaster"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Injured Blademaster"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_188] Abusive Sergeant - COST:1 [ATK:1/HP:1] 
		// - Fac: alliance, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a minion +2_Attack this turn.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AbusiveSergeant_CS2_188()
		{
			// TODO AbusiveSergeant_CS2_188 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Abusive Sergeant"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Abusive Sergeant"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Abusive Sergeant"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_203] Ironbeak Owl - COST:3 [ATK:2/HP:1] 
		// - Race: beast, Fac: horde, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Silence</b> a_minion.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - SILENCE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IronbeakOwl_CS2_203()
		{
			// TODO IronbeakOwl_CS2_203 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ironbeak Owl"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ironbeak Owl"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ironbeak Owl"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_221] Spiteful Smith - COST:5 [ATK:4/HP:6] 
		// - Fac: horde, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Your weapon has +2 Attack while this is damaged.
		// --------------------------------------------------------
		// GameTag:
		// - ENRAGED = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SpitefulSmith_CS2_221()
		{
			// TODO SpitefulSmith_CS2_221 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spiteful Smith"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spiteful Smith"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Spiteful Smith"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_227] Venture Co. Mercenary - COST:5 [ATK:7/HP:6] 
		// - Fac: horde, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Your minions cost (3) more.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VentureCoMercenary_CS2_227()
		{
			// TODO VentureCoMercenary_CS2_227 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Venture Co. Mercenary"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Venture Co. Mercenary"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Venture Co. Mercenary"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_231] Wisp - COST:0 [ATK:1/HP:1] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Wisp_CS2_231()
		{
			// TODO Wisp_CS2_231 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wisp"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wisp"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wisp"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_001] Lightwarden - COST:1 [ATK:1/HP:2] 
		// - Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever a character is healed, gain +2 Attack.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Lightwarden_EX1_001()
		{
			// TODO Lightwarden_EX1_001 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lightwarden"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lightwarden"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lightwarden"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_002] The Black Knight - COST:6 [ATK:4/HP:5] 
		// - Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy an enemy minion with <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_MUST_TARGET_TAUNTER = 0
		// - REQ_ENEMY_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheBlackKnight_EX1_002()
		{
			// TODO TheBlackKnight_EX1_002 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Black Knight"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Black Knight"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Black Knight"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_004] Young Priestess - COST:1 [ATK:2/HP:1] 
		// - Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: At the end of your turn, give another random friendly minion +1 Health.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void YoungPriestess_EX1_004()
		{
			// TODO YoungPriestess_EX1_004 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Young Priestess"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Young Priestess"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Young Priestess"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_005] Big Game Hunter - COST:5 [ATK:4/HP:2] 
		// - Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy a minion with 7 or more Attack.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_MIN_ATTACK = 7
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BigGameHunter_EX1_005()
		{
			// TODO BigGameHunter_EX1_005 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Big Game Hunter"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Big Game Hunter"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Big Game Hunter"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_006] Alarm-o-Bot - COST:3 [ATK:0/HP:3] 
		// - Race: mechanical, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]At the start of your turn,
		//       swap this minion with a
		//          random one in your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AlarmOBot_EX1_006()
		{
			// TODO AlarmOBot_EX1_006 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Alarm-o-Bot"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Alarm-o-Bot"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Alarm-o-Bot"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_007] Acolyte of Pain - COST:3 [ATK:1/HP:3] 
		// - Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever this minion takes damage, draw a_card.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AcolyteOfPain_EX1_007()
		{
			// TODO AcolyteOfPain_EX1_007 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Acolyte of Pain"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Acolyte of Pain"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Acolyte of Pain"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_008] Argent Squire - COST:1 [ATK:1/HP:1] 
		// - Fac: alliance, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Divine Shield</b>
		// --------------------------------------------------------
		// GameTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArgentSquire_EX1_008()
		{
			// TODO ArgentSquire_EX1_008 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Argent Squire"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Argent Squire"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Argent Squire"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_009] Angry Chicken - COST:1 [ATK:1/HP:1] 
		// - Race: beast, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Has +5 Attack while damaged.
		// --------------------------------------------------------
		// GameTag:
		// - ENRAGED = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AngryChicken_EX1_009()
		{
			// TODO AngryChicken_EX1_009 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Angry Chicken"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Angry Chicken"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Angry Chicken"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_010] Worgen Infiltrator - COST:1 [ATK:2/HP:1] 
		// - Fac: alliance, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Stealth</b>
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WorgenInfiltrator_EX1_010()
		{
			// TODO WorgenInfiltrator_EX1_010 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Worgen Infiltrator"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Worgen Infiltrator"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Worgen Infiltrator"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_012] Bloodmage Thalnos - COST:2 [ATK:1/HP:1] 
		// - Fac: neutral, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Spell Damage +1</b>
		//       <b>Deathrattle:</b> Draw a card.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - SPELLPOWER = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BloodmageThalnos_EX1_012()
		{
			// TODO BloodmageThalnos_EX1_012 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bloodmage Thalnos"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodmage Thalnos"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bloodmage Thalnos"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_014] King Mukla - COST:3 [ATK:5/HP:5] 
		// - Race: beast, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give your opponent 2 Bananas.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KingMukla_EX1_014()
		{
			// TODO KingMukla_EX1_014 test
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

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_017] Jungle Panther - COST:3 [ATK:4/HP:2] 
		// - Race: beast, Fac: horde, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Stealth</b>
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JunglePanther_EX1_017()
		{
			// TODO JunglePanther_EX1_017 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Jungle Panther"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jungle Panther"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Jungle Panther"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_020] Scarlet Crusader - COST:3 [ATK:3/HP:1] 
		// - Fac: alliance, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Divine Shield</b>
		// --------------------------------------------------------
		// GameTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ScarletCrusader_EX1_020()
		{
			// TODO ScarletCrusader_EX1_020 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Scarlet Crusader"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Scarlet Crusader"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Scarlet Crusader"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_021] Thrallmar Farseer - COST:3 [ATK:2/HP:3] 
		// - Fac: horde, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Windfury</b>
		// --------------------------------------------------------
		// GameTag:
		// - WINDFURY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ThrallmarFarseer_EX1_021()
		{
			// TODO ThrallmarFarseer_EX1_021 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Thrallmar Farseer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Thrallmar Farseer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Thrallmar Farseer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_023] Silvermoon Guardian - COST:4 [ATK:3/HP:3] 
		// - Fac: horde, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Divine Shield</b>
		// --------------------------------------------------------
		// GameTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SilvermoonGuardian_EX1_023()
		{
			// TODO SilvermoonGuardian_EX1_023 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Silvermoon Guardian"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Silvermoon Guardian"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Silvermoon Guardian"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_028] Stranglethorn Tiger - COST:5 [ATK:5/HP:5] 
		// - Race: beast, Fac: alliance, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Stealth</b>
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StranglethornTiger_EX1_028()
		{
			// TODO StranglethornTiger_EX1_028 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stranglethorn Tiger"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stranglethorn Tiger"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stranglethorn Tiger"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_029] Leper Gnome - COST:1 [ATK:1/HP:1] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Deal 2 damage to the enemy_hero.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LeperGnome_EX1_029()
		{
			// TODO LeperGnome_EX1_029 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Leper Gnome"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Leper Gnome"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Leper Gnome"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_032] Sunwalker - COST:6 [ATK:4/HP:5] 
		// - Fac: alliance, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Divine Shield</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Sunwalker_EX1_032()
		{
			// TODO Sunwalker_EX1_032 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sunwalker"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sunwalker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sunwalker"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_033] Windfury Harpy - COST:6 [ATK:4/HP:5] 
		// - Fac: alliance, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Windfury</b>
		// --------------------------------------------------------
		// GameTag:
		// - WINDFURY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WindfuryHarpy_EX1_033()
		{
			// TODO WindfuryHarpy_EX1_033 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Windfury Harpy"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Windfury Harpy"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Windfury Harpy"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_043] Twilight Drake - COST:4 [ATK:4/HP:1] 
		// - Race: dragon, Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Gain +1 Health for each card in your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TwilightDrake_EX1_043()
		{
			// TODO TwilightDrake_EX1_043 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Twilight Drake"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twilight Drake"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Twilight Drake"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_044] Questing Adventurer - COST:3 [ATK:2/HP:2] 
		// - Fac: alliance, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you play a card, gain +1/+1.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void QuestingAdventurer_EX1_044()
		{
			// TODO QuestingAdventurer_EX1_044 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Questing Adventurer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Questing Adventurer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Questing Adventurer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_045] Ancient Watcher - COST:2 [ATK:4/HP:5] 
		// - Fac: alliance, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Can't attack.
		// --------------------------------------------------------
		// GameTag:
		// - CANT_ATTACK = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AncientWatcher_EX1_045()
		{
			// TODO AncientWatcher_EX1_045 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ancient Watcher"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ancient Watcher"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ancient Watcher"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_046] Dark Iron Dwarf - COST:4 [ATK:4/HP:4] 
		// - Fac: alliance, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a minion +2_Attack this turn.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DarkIronDwarf_EX1_046()
		{
			// TODO DarkIronDwarf_EX1_046 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dark Iron Dwarf"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dark Iron Dwarf"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dark Iron Dwarf"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_048] Spellbreaker - COST:4 [ATK:4/HP:3] 
		// - Fac: horde, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Silence</b> a_minion.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_NONSELF_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - SILENCE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Spellbreaker_EX1_048()
		{
			// TODO Spellbreaker_EX1_048 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spellbreaker"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spellbreaker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Spellbreaker"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_049] Youthful Brewmaster - COST:2 [ATK:3/HP:2] 
		// - Fac: alliance, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Return a friendly minion from the battlefield to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_NONSELF_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void YouthfulBrewmaster_EX1_049()
		{
			// TODO YouthfulBrewmaster_EX1_049 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Youthful Brewmaster"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Youthful Brewmaster"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Youthful Brewmaster"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_055] Mana Addict - COST:2 [ATK:1/HP:3] 
		// - Fac: alliance, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, gain +2 Attack this turn.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ManaAddict_EX1_055()
		{
			// TODO ManaAddict_EX1_055 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mana Addict"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mana Addict"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mana Addict"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_057] Ancient Brewmaster - COST:4 [ATK:5/HP:4] 
		// - Fac: alliance, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Return a friendly minion from the battlefield to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_NONSELF_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AncientBrewmaster_EX1_057()
		{
			// TODO AncientBrewmaster_EX1_057 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ancient Brewmaster"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ancient Brewmaster"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ancient Brewmaster"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_058] Sunfury Protector - COST:2 [ATK:2/HP:3] 
		// - Fac: alliance, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give adjacent minions <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SunfuryProtector_EX1_058()
		{
			// TODO SunfuryProtector_EX1_058 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sunfury Protector"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sunfury Protector"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sunfury Protector"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_059] Crazed Alchemist - COST:2 [ATK:2/HP:2] 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Swap the Attack and Health of a minion.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CrazedAlchemist_EX1_059()
		{
			// TODO CrazedAlchemist_EX1_059 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Crazed Alchemist"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Crazed Alchemist"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Crazed Alchemist"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_067] Argent Commander - COST:6 [ATK:4/HP:2] 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Charge</b>
		//       <b>Divine Shield</b>
		// --------------------------------------------------------
		// GameTag:
		// - DIVINE_SHIELD = 1
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArgentCommander_EX1_067()
		{
			// TODO ArgentCommander_EX1_067 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Argent Commander"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Argent Commander"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Argent Commander"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_076] Pint-Sized Summoner - COST:2 [ATK:2/HP:2] 
		// - Fac: alliance, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: The first minion you play each turn costs (1) less.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PintSizedSummoner_EX1_076()
		{
			// TODO PintSizedSummoner_EX1_076 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Pint-Sized Summoner"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pint-Sized Summoner"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Pint-Sized Summoner"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_080] Secretkeeper - COST:1 [ATK:1/HP:2] 
		// - Fac: alliance, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever a <b>Secret</b> is played, gain +1/+1.
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Secretkeeper_EX1_080()
		{
			// TODO Secretkeeper_EX1_080 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Secretkeeper"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Secretkeeper"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Secretkeeper"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_082] Mad Bomber - COST:2 [ATK:3/HP:2] 
		// - Fac: alliance, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 3 damage randomly split between all other characters.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MadBomber_EX1_082()
		{
			// TODO MadBomber_EX1_082 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mad Bomber"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mad Bomber"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mad Bomber"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_083] Tinkmaster Overspark - COST:3 [ATK:3/HP:3] 
		// - Fac: alliance, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Transform
		//       another random minion
		//       into a 5/5 Devilsaur
		//        or a 1/1 Squirrel.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TinkmasterOverspark_EX1_083()
		{
			// TODO TinkmasterOverspark_EX1_083 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tinkmaster Overspark"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tinkmaster Overspark"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tinkmaster Overspark"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_085] Mind Control Tech - COST:3 [ATK:3/HP:3] 
		// - Fac: alliance, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If your opponent
		//       has 4 or more minions, take
		//        control of one at random.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MindControlTech_EX1_085()
		{
			// TODO MindControlTech_EX1_085 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mind Control Tech"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mind Control Tech"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mind Control Tech"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_089] Arcane Golem - COST:3 [ATK:4/HP:4] 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give your opponent a Mana Crystal.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArcaneGolem_EX1_089()
		{
			// TODO ArcaneGolem_EX1_089 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arcane Golem"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Golem"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Arcane Golem"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_093] Defender of Argus - COST:4 [ATK:2/HP:3] 
		// - Fac: alliance, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give adjacent minions +1/+1 and <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DefenderOfArgus_EX1_093()
		{
			// TODO DefenderOfArgus_EX1_093 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Defender of Argus"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Defender of Argus"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Defender of Argus"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_095] Gadgetzan Auctioneer - COST:6 [ATK:4/HP:4] 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, draw a card.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GadgetzanAuctioneer_EX1_095()
		{
			// TODO GadgetzanAuctioneer_EX1_095 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gadgetzan Auctioneer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gadgetzan Auctioneer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gadgetzan Auctioneer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_096] Loot Hoarder - COST:2 [ATK:2/HP:1] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Draw a card.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LootHoarder_EX1_096()
		{
			// TODO LootHoarder_EX1_096 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Loot Hoarder"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Loot Hoarder"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_097] Abomination - COST:5 [ATK:4/HP:4] 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Taunt</b>. <b>Deathrattle:</b> Deal 2
		//       damage to ALL characters.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Abomination_EX1_097()
		{
			// TODO Abomination_EX1_097 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Abomination"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Abomination"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Abomination"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_100] Lorewalker Cho - COST:2 [ATK:0/HP:4] 
		// - Fac: neutral, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever a player casts a spell, put a copy into the other player’s hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LorewalkerCho_EX1_100()
		{
			// TODO LorewalkerCho_EX1_100 test
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

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_102] Demolisher - COST:3 [ATK:1/HP:4] 
		// - Race: mechanical, Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: At the start of your turn, deal 2 damage to a random enemy.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Demolisher_EX1_102()
		{
			// TODO Demolisher_EX1_102 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Demolisher"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Demolisher"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Demolisher"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_103] Coldlight Seer - COST:3 [ATK:2/HP:3] 
		// - Race: murloc, Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give your other Murlocs +2 Health.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ColdlightSeer_EX1_103()
		{
			// TODO ColdlightSeer_EX1_103 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Coldlight Seer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Coldlight Seer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Coldlight Seer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_105] Mountain Giant - COST:12 [ATK:8/HP:8] 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Costs (1) less for each other card in your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MountainGiant_EX1_105()
		{
			// TODO MountainGiant_EX1_105 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mountain Giant"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mountain Giant"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mountain Giant"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_110] Cairne Bloodhoof - COST:6 [ATK:4/HP:5] 
		// - Fac: alliance, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a 4/5 Baine Bloodhoof.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CairneBloodhoof_EX1_110()
		{
			// TODO CairneBloodhoof_EX1_110 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cairne Bloodhoof"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cairne Bloodhoof"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cairne Bloodhoof"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_116] Leeroy Jenkins - COST:5 [ATK:6/HP:2] 
		// - Fac: alliance, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Charge</b>. <b>Battlecry:</b> Summon two 1/1 Whelps for your opponent.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - CHARGE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LeeroyJenkins_EX1_116()
		{
			// TODO LeeroyJenkins_EX1_116 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Leeroy Jenkins"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Leeroy Jenkins"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Leeroy Jenkins"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_162] Dire Wolf Alpha - COST:2 [ATK:2/HP:2] 
		// - Race: beast, Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Adjacent minions have +1_Attack.
		// --------------------------------------------------------
		// GameTag:
		// - ADJACENT_BUFF = 1
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DireWolfAlpha_EX1_162()
		{
			// TODO DireWolfAlpha_EX1_162 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dire Wolf Alpha"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dire Wolf Alpha"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dire Wolf Alpha"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_170] Emperor Cobra - COST:3 [ATK:2/HP:3] 
		// - Race: beast, Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Poisonous</b>
		// --------------------------------------------------------
		// GameTag:
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EmperorCobra_EX1_170()
		{
			// TODO EmperorCobra_EX1_170 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Emperor Cobra"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Emperor Cobra"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Emperor Cobra"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_249] Baron Geddon - COST:7 [ATK:7/HP:5] 
		// - Race: elemental, Fac: neutral, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: At the end of your turn, deal 2 damage to ALL other characters.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BaronGeddon_EX1_249()
		{
			// TODO BaronGeddon_EX1_249 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Baron Geddon"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Baron Geddon"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Baron Geddon"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_283] Frost Elemental - COST:6 [ATK:5/HP:5] 
		// - Race: elemental, Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Freeze</b> a_character.
		// --------------------------------------------------------
		// GameTag:
		// - FREEZE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FrostElemental_EX1_283()
		{
			// TODO FrostElemental_EX1_283 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Frost Elemental"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frost Elemental"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Frost Elemental"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_390] Tauren Warrior - COST:3 [ATK:2/HP:3] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       Has +3 Attack while damaged.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - ENRAGED = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TaurenWarrior_EX1_390()
		{
			// TODO TaurenWarrior_EX1_390 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tauren Warrior"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tauren Warrior"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tauren Warrior"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_393] Amani Berserker - COST:2 [ATK:2/HP:3] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Has +3 Attack while damaged.
		// --------------------------------------------------------
		// GameTag:
		// - ENRAGED = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AmaniBerserker_EX1_393()
		{
			// TODO AmaniBerserker_EX1_393 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Amani Berserker"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Amani Berserker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Amani Berserker"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_396] Mogu'shan Warden - COST:4 [ATK:1/HP:7] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MogushanWarden_EX1_396()
		{
			// TODO MogushanWarden_EX1_396 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mogu'shan Warden"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mogu'shan Warden"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mogu'shan Warden"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_405] Shieldbearer - COST:1 [ATK:0/HP:4] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Shieldbearer_EX1_405()
		{
			// TODO Shieldbearer_EX1_405 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shieldbearer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shieldbearer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shieldbearer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_412] Raging Worgen - COST:3 [ATK:3/HP:3] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Has +1 Attack and <b>Windfury</b> while damaged.
		// --------------------------------------------------------
		// GameTag:
		// - ENRAGED = 1
		// --------------------------------------------------------
		// RefTag:
		// - WINDFURY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RagingWorgen_EX1_412()
		{
			// TODO RagingWorgen_EX1_412 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Raging Worgen"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Raging Worgen"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Raging Worgen"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_507] Murloc Warleader - COST:3 [ATK:3/HP:3] 
		// - Race: murloc, Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Your other Murlocs have +2 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MurlocWarleader_EX1_507()
		{
			// TODO MurlocWarleader_EX1_507 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Murloc Warleader"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Warleader"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Murloc Warleader"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_509] Murloc Tidecaller - COST:1 [ATK:1/HP:2] 
		// - Race: murloc, Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you summon a Murloc, gain +1 Attack.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MurlocTidecaller_EX1_509()
		{
			// TODO MurlocTidecaller_EX1_509 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Murloc Tidecaller"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Tidecaller"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Murloc Tidecaller"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_556] Harvest Golem - COST:3 [ATK:2/HP:3] 
		// - Race: mechanical, Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a 2/1 Damaged Golem.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HarvestGolem_EX1_556()
		{
			// TODO HarvestGolem_EX1_556 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Harvest Golem"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Harvest Golem"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Harvest Golem"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_557] Nat Pagle - COST:2 [ATK:0/HP:4] 
		// - Fac: neutral, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: At the start of your turn, you have a 50% chance to draw an extra card.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NatPagle_EX1_557()
		{
			// TODO NatPagle_EX1_557 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nat Pagle"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nat Pagle"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nat Pagle"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_558] Harrison Jones - COST:5 [ATK:5/HP:4] 
		// - Fac: neutral, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy your opponent's weapon and draw cards equal to its Durability.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HarrisonJones_EX1_558()
		{
			// TODO HarrisonJones_EX1_558 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Harrison Jones"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Harrison Jones"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Harrison Jones"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_560] Nozdormu - COST:9 [ATK:8/HP:8] 
		// - Race: dragon, Fac: neutral, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: Players only have 15 seconds to take their_turns.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Nozdormu_EX1_560()
		{
			// TODO Nozdormu_EX1_560 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nozdormu"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nozdormu"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nozdormu"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_561] Alexstrasza - COST:9 [ATK:8/HP:8] 
		// - Race: dragon, Fac: neutral, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Set a hero's remaining Health to 15.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_HERO_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Alexstrasza_EX1_561()
		{
			// TODO Alexstrasza_EX1_561 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Alexstrasza"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Alexstrasza"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Alexstrasza"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_562] Onyxia - COST:9 [ATK:8/HP:8] 
		// - Race: dragon, Fac: neutral, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon 1/1 Whelps until your side of the battlefield is full.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Onyxia_EX1_562()
		{
			// TODO Onyxia_EX1_562 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Onyxia"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Onyxia"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Onyxia"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_563] Malygos - COST:9 [ATK:4/HP:12] 
		// - Race: dragon, Fac: neutral, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Spell Damage +5</b>
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - SPELLPOWER = 5
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Malygos_EX1_563()
		{
			// TODO Malygos_EX1_563 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Malygos"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Malygos"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Malygos"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_564] Faceless Manipulator - COST:5 [ATK:3/HP:3] 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Choose a minion and become a copy of it.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_NONSELF_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FacelessManipulator_EX1_564()
		{
			// TODO FacelessManipulator_EX1_564 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Faceless Manipulator"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Faceless Manipulator"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Faceless Manipulator"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_572] Ysera - COST:9 [ATK:4/HP:12] 
		// - Race: dragon, Fac: neutral, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: At the end of your turn, add_a Dream Card to_your hand.
		// --------------------------------------------------------
		// Entourage: DREAM_01, DREAM_02, DREAM_03, DREAM_04, DREAM_05
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Ysera_EX1_572()
		{
			// TODO Ysera_EX1_572 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ysera"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ysera"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ysera"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_577] The Beast - COST:6 [ATK:9/HP:7] 
		// - Race: beast, Fac: neutral, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a 3/3 Finkle Einhorn for your opponent.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheBeast_EX1_577()
		{
			// TODO TheBeast_EX1_577 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Beast"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Beast"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Beast"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_583] Priestess of Elune - COST:6 [ATK:5/HP:4] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Restore 4 Health to your hero.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PriestessOfElune_EX1_583()
		{
			// TODO PriestessOfElune_EX1_583 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Priestess of Elune"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Priestess of Elune"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Priestess of Elune"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_584] Ancient Mage - COST:4 [ATK:2/HP:5] 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give adjacent_minions <b>Spell_Damage +1</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - SPELLPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AncientMage_EX1_584()
		{
			// TODO AncientMage_EX1_584 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ancient Mage"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ancient Mage"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ancient Mage"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_586] Sea Giant - COST:10 [ATK:8/HP:8] 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Costs (1) less for each other minion on the battlefield.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SeaGiant_EX1_586()
		{
			// TODO SeaGiant_EX1_586 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sea Giant"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sea Giant"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sea Giant"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_590] Blood Knight - COST:3 [ATK:3/HP:3] 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> All minions lose <b>Divine Shield</b>. Gain +3/+3 for each Shield lost.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BloodKnight_EX1_590()
		{
			// TODO BloodKnight_EX1_590 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blood Knight"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blood Knight"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blood Knight"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_595] Cult Master - COST:4 [ATK:4/HP:2] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: After a friendly minion dies, draw a card.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CultMaster_EX1_595()
		{
			// TODO CultMaster_EX1_595 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cult Master"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cult Master"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cult Master"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_597] Imp Master - COST:3 [ATK:1/HP:5] 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]At the end of your turn, deal
		//       1 damage to this minion
		//        and summon a 1/1 Imp.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ImpMaster_EX1_597()
		{
			// TODO ImpMaster_EX1_597 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Imp Master"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Imp Master"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Imp Master"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_614] Illidan Stormrage - COST:6 [ATK:7/HP:5] 
		// - Race: demon, Fac: neutral, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever you play a card, summon a 2/1 Flame of_Azzinoth.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IllidanStormrage_EX1_614()
		{
			// TODO IllidanStormrage_EX1_614 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Illidan Stormrage"),
				},
				Player2HeroClass = CardClass.MAGE,
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

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_616] Mana Wraith - COST:2 [ATK:2/HP:2] 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: ALL minions cost (1) more.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ManaWraith_EX1_616()
		{
			// TODO ManaWraith_EX1_616 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mana Wraith"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mana Wraith"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mana Wraith"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [NEW1_017] Hungry Crab - COST:1 [ATK:1/HP:2] 
		// - Race: beast, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy a Murloc and gain +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_TARGET_WITH_RACE = 14
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HungryCrab_NEW1_017()
		{
			// TODO HungryCrab_NEW1_017 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hungry Crab"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hungry Crab"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hungry Crab"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [NEW1_018] Bloodsail Raider - COST:2 [ATK:2/HP:3] 
		// - Race: pirate, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Gain Attack equal to the Attack
		//       of your weapon.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BloodsailRaider_NEW1_018()
		{
			// TODO BloodsailRaider_NEW1_018 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bloodsail Raider"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodsail Raider"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bloodsail Raider"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [NEW1_019] Knife Juggler - COST:2 [ATK:2/HP:2] 
		// - Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]After you summon a
		//       minion, deal 1 damage
		//       to a random enemy.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KnifeJuggler_NEW1_019()
		{
			// TODO KnifeJuggler_NEW1_019 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Knife Juggler"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Knife Juggler"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Knife Juggler"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [NEW1_020] Wild Pyromancer - COST:2 [ATK:3/HP:2] 
		// - Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: After you cast a spell, deal 1 damage to ALL minions.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WildPyromancer_NEW1_020()
		{
			// TODO WildPyromancer_NEW1_020 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wild Pyromancer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wild Pyromancer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wild Pyromancer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [NEW1_021] Doomsayer - COST:2 [ATK:0/HP:7] 
		// - Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: At the start of your turn, destroy ALL minions.
		// --------------------------------------------------------
		// GameTag:
		// - 886 = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Doomsayer_NEW1_021()
		{
			// TODO Doomsayer_NEW1_021 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Doomsayer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Doomsayer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Doomsayer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [NEW1_022] Dread Corsair - COST:4 [ATK:3/HP:3] 
		// - Race: pirate, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       Costs (1) less per Attack of_your weapon.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DreadCorsair_NEW1_022()
		{
			// TODO DreadCorsair_NEW1_022 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dread Corsair"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dread Corsair"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dread Corsair"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [NEW1_023] Faerie Dragon - COST:2 [ATK:3/HP:2] 
		// - Race: dragon, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Can't be targeted by spells or Hero Powers.
		// --------------------------------------------------------
		// GameTag:
		// - CANT_BE_TARGETED_BY_SPELLS = 1
		// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FaerieDragon_NEW1_023()
		{
			// TODO FaerieDragon_NEW1_023 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Faerie Dragon"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Faerie Dragon"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Faerie Dragon"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [NEW1_024] Captain Greenskin - COST:5 [ATK:5/HP:4] 
		// - Race: pirate, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give your weapon +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CaptainGreenskin_NEW1_024()
		{
			// TODO CaptainGreenskin_NEW1_024 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Captain Greenskin"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Captain Greenskin"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Captain Greenskin"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [NEW1_025] Bloodsail Corsair - COST:1 [ATK:1/HP:2] 
		// - Race: pirate, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Remove
		//       1 Durability from your
		//       opponent's weapon.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BloodsailCorsair_NEW1_025()
		{
			// TODO BloodsailCorsair_NEW1_025 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bloodsail Corsair"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodsail Corsair"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bloodsail Corsair"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [NEW1_026] Violet Teacher - COST:4 [ATK:3/HP:5] 
		// - Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, summon a 1/1 Violet Apprentice.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VioletTeacher_NEW1_026()
		{
			// TODO VioletTeacher_NEW1_026 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Violet Teacher"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Violet Teacher"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Violet Teacher"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [NEW1_027] Southsea Captain - COST:3 [ATK:3/HP:3] 
		// - Race: pirate, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Your other Pirates have +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SouthseaCaptain_NEW1_027()
		{
			// TODO SouthseaCaptain_NEW1_027 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Southsea Captain"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Southsea Captain"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Southsea Captain"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [NEW1_029] Millhouse Manastorm - COST:2 [ATK:4/HP:4] 
		// - Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Enemy spells cost (0) next turn.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MillhouseManastorm_NEW1_029()
		{
			// TODO MillhouseManastorm_NEW1_029 test
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

		// --------------------------------------- MINION - NEUTRAL
		// [NEW1_030] Deathwing - COST:10 [ATK:12/HP:12] 
		// - Race: dragon, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy all other minions and discard your_hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - 890 = 10
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Deathwing_NEW1_030()
		{
			// TODO Deathwing_NEW1_030 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Deathwing"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Deathwing"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Deathwing"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [NEW1_037] Master Swordsmith - COST:2 [ATK:1/HP:3] 
		// - Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: At the end of your turn, give another random friendly minion +1 Attack.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MasterSwordsmith_NEW1_037()
		{
			// TODO MasterSwordsmith_NEW1_037 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Master Swordsmith"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Master Swordsmith"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Master Swordsmith"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [NEW1_038] Gruul - COST:8 [ATK:7/HP:7] 
		// - Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: At the end of each turn, gain +1/+1 .
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Gruul_NEW1_038()
		{
			// TODO Gruul_NEW1_038 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gruul"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gruul"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gruul"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [NEW1_040] Hogger - COST:6 [ATK:4/HP:4] 
		// - Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: At the end of your turn, summon a 2/2 Gnoll with_<b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Hogger_NEW1_040()
		{
			// TODO Hogger_NEW1_040 test
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

		// --------------------------------------- MINION - NEUTRAL
		// [NEW1_041] Stampeding Kodo - COST:5 [ATK:3/HP:5] 
		// - Race: beast, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy a random enemy minion with 2 or less Attack.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StampedingKodo_NEW1_041()
		{
			// TODO StampedingKodo_NEW1_041 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stampeding Kodo"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stampeding Kodo"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stampeding Kodo"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [tt_004] Flesheating Ghoul - COST:3 [ATK:2/HP:3] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever a minion dies, gain +1 Attack.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FlesheatingGhoul_tt_004()
		{
			// TODO FlesheatingGhoul_tt_004 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Flesheating Ghoul"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flesheating Ghoul"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Flesheating Ghoul"));
		}

	}

}
