using Xunit;
using SabberStoneCore.Enums;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using System.Collections.Generic;

namespace SabberStoneCoreTest.CardSets.Undefined
{
	public class MageHofTest
	{
		// ------------------------------------------- SPELL - MAGE
		// [CS2_031] Ice Lance - COST:1 
		// - Fac: neutral, Set: hof, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Freeze</b> a character. If it was already <b>Frozen</b>, deal $4 damage instead. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IceLance_CS2_031()
		{
			// TODO IceLance_CS2_031 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ice Lance"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ice Lance"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ice Lance"));
		}

	}

	public class RogueHofTest
	{
		// ------------------------------------------ SPELL - ROGUE
		// [EX1_128] Conceal - COST:1 
		// - Fac: neutral, Set: hof, Rarity: common
		// --------------------------------------------------------
		// Text: Give your minions <b>Stealth</b> until your next_turn.
		// --------------------------------------------------------
		// RefTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Conceal_EX1_128()
		{
			// TODO Conceal_EX1_128 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Conceal"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Conceal"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Conceal"));
		}

	}

	public class WarlockHofTest
	{
		// ---------------------------------------- SPELL - WARLOCK
		// [EX1_316] Power Overwhelming - COST:1 
		// - Fac: neutral, Set: hof, Rarity: common
		// --------------------------------------------------------
		// Text: Give a friendly minion +4/+4 until end of turn. Then, it dies. Horribly.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PowerOverwhelming_EX1_316()
		{
			// TODO PowerOverwhelming_EX1_316 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Power Overwhelming"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Power Overwhelming"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Power Overwhelming"));
		}

	}

	public class NeutralHofTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [EX1_016] Sylvanas Windrunner - COST:6 [ATK:5/HP:5] 
		// - Set: hof, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Take
		//       control of a random
		//       enemy minion.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SylvanasWindrunner_EX1_016()
		{
			// TODO SylvanasWindrunner_EX1_016 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sylvanas Windrunner"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sylvanas Windrunner"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sylvanas Windrunner"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_062] Old Murk-Eye - COST:4 [ATK:2/HP:4] 
		// - Race: murloc, Fac: neutral, Set: hof, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Charge</b>. Has +1 Attack for each other Murloc on the battlefield.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OldMurkEye_EX1_062()
		{
			// TODO OldMurkEye_EX1_062 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Old Murk-Eye"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Old Murk-Eye"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Old Murk-Eye"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_112] Gelbin Mekkatorque - COST:6 [ATK:6/HP:6] 
		// - Fac: alliance, Set: hof, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon an AWESOME invention.
		// --------------------------------------------------------
		// Entourage: Mekka1, Mekka2, Mekka3, Mekka4
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GelbinMekkatorque_EX1_112()
		{
			// TODO GelbinMekkatorque_EX1_112 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gelbin Mekkatorque"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gelbin Mekkatorque"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gelbin Mekkatorque"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_284] Azure Drake - COST:5 [ATK:4/HP:4] 
		// - Race: dragon, Fac: neutral, Set: hof, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Spell Damage +1</b>
		//       <b>Battlecry:</b> Draw a card.
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AzureDrake_EX1_284()
		{
			// TODO AzureDrake_EX1_284 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Azure Drake"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Azure Drake"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Azure Drake"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_298] Ragnaros the Firelord - COST:8 [ATK:8/HP:8] 
		// - Race: elemental, Fac: neutral, Set: hof, Rarity: legendary
		// --------------------------------------------------------
		// Text: Can't attack. At the end of your turn, deal 8 damage to a random enemy.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - CANT_ATTACK = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RagnarosTheFirelord_EX1_298()
		{
			// TODO RagnarosTheFirelord_EX1_298 test
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

		// --------------------------------------- MINION - NEUTRAL
		// [NEW1_016] Captain's Parrot - COST:2 [ATK:1/HP:1] 
		// - Race: beast, Set: hof, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Draw a Pirate from your deck.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CaptainsParrot_NEW1_016()
		{
			// TODO CaptainsParrot_NEW1_016 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Captain's Parrot"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Captain's Parrot"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Captain's Parrot"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [PRO_001] Elite Tauren Chieftain - COST:5 [ATK:5/HP:5] 
		// - Set: hof, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give both players the power to ROCK! (with a Power Chord card)
		// --------------------------------------------------------
		// Entourage: PRO_001a, PRO_001b, PRO_001c
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EliteTaurenChieftain_PRO_001()
		{
			// TODO EliteTaurenChieftain_PRO_001 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Elite Tauren Chieftain"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Elite Tauren Chieftain"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Elite Tauren Chieftain"));
		}

	}

}
