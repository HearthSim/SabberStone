using Xunit;
using SabberStoneCore.Enums;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

namespace SabberStoneCoreTest.CardSets.Undefined
{
	public class DruidGangsTest
	{
		// ----------------------------------------- MINION - DRUID
		// [CFM_308] Kun the Forgotten King - COST:10 [ATK:7/HP:7] 
		// - Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Choose One -</b> Gain 10 Armor; or Refresh your Mana Crystals.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KunTheForgottenKing_CFM_308()
		{
			// TODO KunTheForgottenKing_CFM_308 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kun the Forgotten King"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kun the Forgotten King"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kun the Forgotten King"));
		}

		// ----------------------------------------- MINION - DRUID
		// [CFM_343] Jade Behemoth - COST:6 [ATK:3/HP:6] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       <b>Battlecry:</b> Summon a{1}
		//       {0} <b>Jade Golem</b>.@[x]<b>Taunt</b>
		//       <b>Battlecry:</b> Summon a
		//       <b>Jade Golem</b>.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - JADE_GOLEM = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JadeBehemoth_CFM_343()
		{
			// TODO JadeBehemoth_CFM_343 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Jade Behemoth"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jade Behemoth"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Jade Behemoth"));
		}

		// ----------------------------------------- MINION - DRUID
		// [CFM_617] Celestial Dreamer - COST:3 [ATK:3/HP:3] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If you control a
		//       minion with 5 or more
		//       Attack, gain +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CelestialDreamer_CFM_617()
		{
			// TODO CelestialDreamer_CFM_617 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Celestial Dreamer"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Celestial Dreamer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Celestial Dreamer"));
		}

		// ----------------------------------------- MINION - DRUID
		// [CFM_816] Virmen Sensei - COST:5 [ATK:4/HP:5] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly Beast +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_WITH_RACE = 20
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VirmenSensei_CFM_816()
		{
			// TODO VirmenSensei_CFM_816 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Virmen Sensei"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Virmen Sensei"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Virmen Sensei"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [CFM_602] Jade Idol - COST:1 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Choose One -</b> Summon a{1} {0} <b>Jade Golem</b>; or Shuffle 3 copies of this card into your deck.@<b>Choose One -</b> Summon a <b>Jade Golem</b>; or Shuffle 3 copies of this card into your deck.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		// RefTag:
		// - JADE_GOLEM = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JadeIdol_CFM_602()
		{
			// TODO JadeIdol_CFM_602 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Jade Idol"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jade Idol"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Jade Idol"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [CFM_614] Mark of the Lotus - COST:1 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: Give your minions +1/+1.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MarkOfTheLotus_CFM_614()
		{
			// TODO MarkOfTheLotus_CFM_614 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mark of the Lotus"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mark of the Lotus"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mark of the Lotus"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [CFM_616] Pilfered Power - COST:3 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: Gain an empty Mana Crystal for each friendly minion.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PilferedPower_CFM_616()
		{
			// TODO PilferedPower_CFM_616 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Pilfered Power"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pilfered Power"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Pilfered Power"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [CFM_713] Jade Blossom - COST:3 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: Summon a{1} {0} <b>Jade Golem</b>. Gain an empty Mana Crystal.@Summon a <b>Jade Golem</b>. Gain an empty Mana Crystal.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_SLOT_OR_MANA_CRYSTAL_SLOT = 0
		// --------------------------------------------------------
		// RefTag:
		// - JADE_GOLEM = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JadeBlossom_CFM_713()
		{
			// TODO JadeBlossom_CFM_713 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Jade Blossom"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jade Blossom"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Jade Blossom"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [CFM_811] Lunar Visions - COST:5 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: Draw 2 cards. Minions drawn cost (2) less.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LunarVisions_CFM_811()
		{
			// TODO LunarVisions_CFM_811 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lunar Visions"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lunar Visions"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lunar Visions"));
		}

	}

	public class HunterGangsTest
	{
		// ---------------------------------------- MINION - HUNTER
		// [CFM_315] Alleycat - COST:1 [ATK:1/HP:1] 
		// - Race: beast, Fac: neutral, Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 1/1_Cat.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Alleycat_CFM_315()
		{
			// TODO Alleycat_CFM_315 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Alleycat"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Alleycat"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Alleycat"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [CFM_316] Rat Pack - COST:3 [ATK:2/HP:2] 
		// - Race: beast, Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Deathrattle:</b> Summon a
		//       number of 1/1 Rats equal
		//       _to this minion's Attack.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RatPack_CFM_316()
		{
			// TODO RatPack_CFM_316 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rat Pack"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rat Pack"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rat Pack"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [CFM_333] Knuckles - COST:5 [ATK:3/HP:7] 
		// - Race: beast, Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: After this attacks a
		//       minion, it also hits the enemy hero.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - FINISH_ATTACK_SPELL_ON_DAMAGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Knuckles_CFM_333()
		{
			// TODO Knuckles_CFM_333 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Knuckles"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Knuckles"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Knuckles"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [CFM_335] Dispatch Kodo - COST:4 [ATK:2/HP:4] 
		// - Race: beast, Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal damage equal to this minion's Attack.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DispatchKodo_CFM_335()
		{
			// TODO DispatchKodo_CFM_335 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dispatch Kodo"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dispatch Kodo"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dispatch Kodo"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [CFM_336] Shaky Zipgunner - COST:3 [ATK:3/HP:3] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Deathrattle:</b> Give a random
		//       minion in your hand +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShakyZipgunner_CFM_336()
		{
			// TODO ShakyZipgunner_CFM_336 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shaky Zipgunner"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shaky Zipgunner"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shaky Zipgunner"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [CFM_338] Trogg Beastrager - COST:2 [ATK:3/HP:2] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a random Beast in your hand +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TroggBeastrager_CFM_338()
		{
			// TODO TroggBeastrager_CFM_338 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Trogg Beastrager"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Trogg Beastrager"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Trogg Beastrager"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [CFM_026] Hidden Cache - COST:2 
		// - Fac: neutral, Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Secret:</b> After your opponent plays a minion, give a random minion in your hand +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HiddenCache_CFM_026()
		{
			// TODO HiddenCache_CFM_026 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hidden Cache"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hidden Cache"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hidden Cache"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [CFM_334] Smuggler's Crate - COST:1 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: Give a random Beast in your hand +2/+2.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SmugglersCrate_CFM_334()
		{
			// TODO SmugglersCrate_CFM_334 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Smuggler's Crate"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Smuggler's Crate"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Smuggler's Crate"));
		}

		// ---------------------------------------- WEAPON - HUNTER
		// [CFM_337] Piranha Launcher - COST:5 [ATK:2/HP:0] 
		// - Fac: neutral, Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]After your hero attacks,
		//       summon a 1/1 Piranha.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 4
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PiranhaLauncher_CFM_337()
		{
			// TODO PiranhaLauncher_CFM_337 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Piranha Launcher"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Piranha Launcher"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Piranha Launcher"));
		}

	}

	public class MageGangsTest
	{
		// ------------------------------------------ MINION - MAGE
		// [CFM_066] Kabal Lackey - COST:1 [ATK:2/HP:1] 
		// - Set: gangs, Rarity: common
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
		public void KabalLackey_CFM_066()
		{
			// TODO KabalLackey_CFM_066 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kabal Lackey"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kabal Lackey"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kabal Lackey"));
		}

		// ------------------------------------------ MINION - MAGE
		// [CFM_660] Manic Soulcaster - COST:3 [ATK:3/HP:4] 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Choose a friendly minion. Shuffle a copy into your deck.
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
		public void ManicSoulcaster_CFM_660()
		{
			// TODO ManicSoulcaster_CFM_660 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Manic Soulcaster"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Manic Soulcaster"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Manic Soulcaster"));
		}

		// ------------------------------------------ MINION - MAGE
		// [CFM_671] Cryomancer - COST:5 [ATK:5/HP:5] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If an enemy is <b>Frozen</b>, gain +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Cryomancer_CFM_671()
		{
			// TODO Cryomancer_CFM_671 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cryomancer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cryomancer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cryomancer"));
		}

		// ------------------------------------------ MINION - MAGE
		// [CFM_687] Inkmaster Solia - COST:7 [ATK:5/HP:5] 
		// - Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If your deck has
		//       no duplicates, the next
		//       spell you cast this turn
		//       costs (0).
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void InkmasterSolia_CFM_687()
		{
			// TODO InkmasterSolia_CFM_687 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Inkmaster Solia"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Inkmaster Solia"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Inkmaster Solia"));
		}

		// ------------------------------------------ MINION - MAGE
		// [CFM_760] Kabal Crystal Runner - COST:6 [ATK:5/HP:5] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: Costs (2) less for each <b>Secret</b> you've played this_game.
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KabalCrystalRunner_CFM_760()
		{
			// TODO KabalCrystalRunner_CFM_760 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kabal Crystal Runner"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kabal Crystal Runner"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kabal Crystal Runner"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [CFM_021] Freezing Potion - COST:0 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Freeze</b> an enemy.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_ENEMY_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FreezingPotion_CFM_021()
		{
			// TODO FreezingPotion_CFM_021 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Freezing Potion"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Freezing Potion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Freezing Potion"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [CFM_065] Volcanic Potion - COST:3 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $2 damage to all_minions. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VolcanicPotion_CFM_065()
		{
			// TODO VolcanicPotion_CFM_065 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Volcanic Potion"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Volcanic Potion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Volcanic Potion"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [CFM_620] Potion of Polymorph - COST:3 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Secret:</b> After your opponent plays a minion, transform it into a
		//       1/1 Sheep.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PotionOfPolymorph_CFM_620()
		{
			// TODO PotionOfPolymorph_CFM_620 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Potion of Polymorph"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Potion of Polymorph"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Potion of Polymorph"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [CFM_623] Greater Arcane Missiles - COST:7 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: Shoot three missiles at random enemies that deal $3 damage each. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GreaterArcaneMissiles_CFM_623()
		{
			// TODO GreaterArcaneMissiles_CFM_623 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Greater Arcane Missiles"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Greater Arcane Missiles"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Greater Arcane Missiles"));
		}

	}

	public class PaladinGangsTest
	{
		// --------------------------------------- MINION - PALADIN
		// [CFM_062] Grimestreet Protector - COST:7 [ATK:6/HP:6] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       <b>Battlecry:</b> Give adjacent
		//       _minions <b>Divine Shield</b>.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GrimestreetProtector_CFM_062()
		{
			// TODO GrimestreetProtector_CFM_062 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grimestreet Protector"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grimestreet Protector"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grimestreet Protector"));
		}

		// --------------------------------------- MINION - PALADIN
		// [CFM_639] Grimestreet Enforcer - COST:5 [ATK:4/HP:4] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: At the end of your turn, give all minions in your hand +1/+1.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GrimestreetEnforcer_CFM_639()
		{
			// TODO GrimestreetEnforcer_CFM_639 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grimestreet Enforcer"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grimestreet Enforcer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grimestreet Enforcer"));
		}

		// --------------------------------------- MINION - PALADIN
		// [CFM_650] Grimscale Chum - COST:1 [ATK:2/HP:1] 
		// - Race: murloc, Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Give a random
		//       Murloc in your hand +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GrimscaleChum_CFM_650()
		{
			// TODO GrimscaleChum_CFM_650 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grimscale Chum"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grimscale Chum"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grimscale Chum"));
		}

		// --------------------------------------- MINION - PALADIN
		// [CFM_753] Grimestreet Outfitter - COST:2 [ATK:1/HP:1] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give all minions in your hand +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GrimestreetOutfitter_CFM_753()
		{
			// TODO GrimestreetOutfitter_CFM_753 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grimestreet Outfitter"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grimestreet Outfitter"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grimestreet Outfitter"));
		}

		// --------------------------------------- MINION - PALADIN
		// [CFM_759] Meanstreet Marshal - COST:1 [ATK:1/HP:2] 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> If this minion has 2 or more Attack, draw a card.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MeanstreetMarshal_CFM_759()
		{
			// TODO MeanstreetMarshal_CFM_759 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Meanstreet Marshal"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Meanstreet Marshal"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Meanstreet Marshal"));
		}

		// --------------------------------------- MINION - PALADIN
		// [CFM_815] Wickerflame Burnbristle - COST:3 [ATK:2/HP:2] 
		// - Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Divine Shield, Taunt, Lifesteal</b>
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - TAUNT = 1
		// - DIVINE_SHIELD = 1
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WickerflameBurnbristle_CFM_815()
		{
			// TODO WickerflameBurnbristle_CFM_815 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wickerflame Burnbristle"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wickerflame Burnbristle"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wickerflame Burnbristle"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [CFM_305] Smuggler's Run - COST:1 
		// - Fac: neutral, Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: Give all minions in your hand +1/+1.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SmugglersRun_CFM_305()
		{
			// TODO SmugglersRun_CFM_305 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Smuggler's Run"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Smuggler's Run"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Smuggler's Run"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [CFM_800] Getaway Kodo - COST:1 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When a friendly minion dies, return it to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GetawayKodo_CFM_800()
		{
			// TODO GetawayKodo_CFM_800 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Getaway Kodo"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Getaway Kodo"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Getaway Kodo"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [CFM_905] Small-Time Recruits - COST:3 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]Draw three 1-Cost
		//       minions from your deck.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SmallTimeRecruits_CFM_905()
		{
			// TODO SmallTimeRecruits_CFM_905 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Small-Time Recruits"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Small-Time Recruits"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Small-Time Recruits"));
		}

	}

	public class PriestGangsTest
	{
		// ---------------------------------------- MINION - PRIEST
		// [CFM_020] Raza the Chained - COST:5 [ATK:5/HP:5] 
		// - Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]  <b>Battlecry:</b> If your deck has  
		//       no duplicates, your Hero
		//        Power costs (1) this game.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RazaTheChained_CFM_020()
		{
			// TODO RazaTheChained_CFM_020 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Raza the Chained"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Raza the Chained"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Raza the Chained"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [CFM_605] Drakonid Operative - COST:5 [ATK:5/HP:6] 
		// - Race: dragon, Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If you're holding a
		//       Dragon, <b>Discover</b> a card in
		//       _your opponent's deck.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DrakonidOperative_CFM_605()
		{
			// TODO DrakonidOperative_CFM_605 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Drakonid Operative"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Drakonid Operative"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Drakonid Operative"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [CFM_606] Mana Geode - COST:2 [ATK:2/HP:3] 
		// - Race: elemental, Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: Whenever this minion is_healed, summon a 2/2_Crystal.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ManaGeode_CFM_606()
		{
			// TODO ManaGeode_CFM_606 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mana Geode"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mana Geode"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mana Geode"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [CFM_626] Kabal Talonpriest - COST:3 [ATK:3/HP:4] 
		// - Set: gangs, Rarity: common
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
		public void KabalTalonpriest_CFM_626()
		{
			// TODO KabalTalonpriest_CFM_626 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kabal Talonpriest"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kabal Talonpriest"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kabal Talonpriest"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [CFM_657] Kabal Songstealer - COST:5 [ATK:5/HP:5] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> <b>Silence</b> a minion.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_NONSELF_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - SILENCE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KabalSongstealer_CFM_657()
		{
			// TODO KabalSongstealer_CFM_657 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kabal Songstealer"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kabal Songstealer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kabal Songstealer"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [CFM_603] Potion of Madness - COST:1 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: Gain control of an enemy minion with 2 or less Attack until end of turn.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_ENEMY_TARGET = 0
		// - REQ_NUM_MINION_SLOTS = 1
		// - REQ_TARGET_MAX_ATTACK = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PotionOfMadness_CFM_603()
		{
			// TODO PotionOfMadness_CFM_603 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Potion of Madness"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Potion of Madness"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Potion of Madness"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [CFM_604] Greater Healing Potion - COST:4 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: Restore #12 Health to a friendly character.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GreaterHealingPotion_CFM_604()
		{
			// TODO GreaterHealingPotion_CFM_604 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Greater Healing Potion"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Greater Healing Potion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Greater Healing Potion"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [CFM_661] Pint-Size Potion - COST:1 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]Give all enemy minions
		//       -3 Attack this turn only.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PintSizePotion_CFM_661()
		{
			// TODO PintSizePotion_CFM_661 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Pint-Size Potion"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pint-Size Potion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Pint-Size Potion"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [CFM_662] Dragonfire Potion - COST:6 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]Deal $5 damage to all
		//       minions except Dragons. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DragonfirePotion_CFM_662()
		{
			// TODO DragonfirePotion_CFM_662 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dragonfire Potion"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragonfire Potion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dragonfire Potion"));
		}

	}

	public class RogueGangsTest
	{
		// ----------------------------------------- MINION - ROGUE
		// [CFM_342] Luckydo Buccaneer - COST:6 [ATK:5/HP:5] 
		// - Race: pirate, Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your weapon has at least 3 Attack, gain +4/+4.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LuckydoBuccaneer_CFM_342()
		{
			// TODO LuckydoBuccaneer_CFM_342 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Luckydo Buccaneer"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Luckydo Buccaneer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Luckydo Buccaneer"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [CFM_634] Lotus Assassin - COST:5 [ATK:5/HP:5] 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Stealth</b>. Whenever this attacks and kills a minion, gain <b>Stealth</b>.
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LotusAssassin_CFM_634()
		{
			// TODO LotusAssassin_CFM_634 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lotus Assassin"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lotus Assassin"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lotus Assassin"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [CFM_636] Shadow Rager - COST:3 [ATK:5/HP:1] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Stealth</b>
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShadowRager_CFM_636()
		{
			// TODO ShadowRager_CFM_636 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shadow Rager"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadow Rager"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shadow Rager"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [CFM_691] Jade Swarmer - COST:2 [ATK:1/HP:1] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Stealth</b>
		//       <b>Deathrattle:</b> Summon a{1} {0} <b>Jade Golem</b>.@<b>Stealth</b>
		//       <b>Deathrattle:</b> Summon a <b>Jade Golem</b>.
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		// RefTag:
		// - JADE_GOLEM = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JadeSwarmer_CFM_691()
		{
			// TODO JadeSwarmer_CFM_691 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Jade Swarmer"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jade Swarmer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Jade Swarmer"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [CFM_693] Gadgetzan Ferryman - COST:2 [ATK:2/HP:3] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Combo:</b> Return a friendly minion to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_FOR_COMBO = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GadgetzanFerryman_CFM_693()
		{
			// TODO GadgetzanFerryman_CFM_693 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gadgetzan Ferryman"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gadgetzan Ferryman"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gadgetzan Ferryman"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [CFM_694] Shadow Sensei - COST:4 [ATK:4/HP:4] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a <b>Stealthed</b> minion +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_STEALTHED_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShadowSensei_CFM_694()
		{
			// TODO ShadowSensei_CFM_694 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shadow Sensei"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadow Sensei"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shadow Sensei"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [CFM_781] Shaku, the Collector - COST:3 [ATK:2/HP:3] 
		// - Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Stealth</b>. Whenever this
		//       attacks, add a random card
		//       to your hand <i>(from your
		//       opponent's class).</i>
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShakuTheCollector_CFM_781()
		{
			// TODO ShakuTheCollector_CFM_781 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shaku, the Collector"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shaku, the Collector"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shaku, the Collector"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [CFM_630] Counterfeit Coin - COST:0 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: Gain 1 Mana Crystal this turn only.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CounterfeitCoin_CFM_630()
		{
			// TODO CounterfeitCoin_CFM_630 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Counterfeit Coin"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Counterfeit Coin"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Counterfeit Coin"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [CFM_690] Jade Shuriken - COST:2 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $2 damage.
		//       <b>Combo:</b> Summon a{1} {0} <b>Jade Golem</b>.@Deal $2 damage.
		//       <b>Combo:</b> Summon a <b>Jade Golem</b>. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - JADE_GOLEM = 1
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JadeShuriken_CFM_690()
		{
			// TODO JadeShuriken_CFM_690 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Jade Shuriken"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jade Shuriken"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Jade Shuriken"));
		}

	}

	public class ShamanGangsTest
	{
		// ---------------------------------------- MINION - SHAMAN
		// [CFM_061] Jinyu Waterspeaker - COST:4 [ATK:3/HP:6] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Restore 6 Health.
		//       <b>Overload:</b> (1)
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 1
		// - BATTLECRY = 1
		// - OVERLOAD_OWED = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JinyuWaterspeaker_CFM_061()
		{
			// TODO JinyuWaterspeaker_CFM_061 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Jinyu Waterspeaker"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jinyu Waterspeaker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Jinyu Waterspeaker"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [CFM_312] Jade Chieftain - COST:7 [ATK:5/HP:5] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a{1} {0} <b>Jade Golem</b>. Give it <b>Taunt</b>. @<b>Battlecry:</b> Summon a <b>Jade Golem</b>. Give it <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// - JADE_GOLEM = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JadeChieftain_CFM_312()
		{
			// TODO JadeChieftain_CFM_312 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Jade Chieftain"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jade Chieftain"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Jade Chieftain"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [CFM_324] White Eyes - COST:5 [ATK:5/HP:5] 
		// - Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Deathrattle:</b> Shuffle
		//       'The Storm Guardian' into your deck.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - TAUNT = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WhiteEyes_CFM_324()
		{
			// TODO WhiteEyes_CFM_324 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("White Eyes"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("White Eyes"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "White Eyes"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [CFM_697] Lotus Illusionist - COST:4 [ATK:3/HP:5] 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]After this minion attacks
		//       a hero, transform it into a
		//       _random 6-Cost minion.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LotusIllusionist_CFM_697()
		{
			// TODO LotusIllusionist_CFM_697 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lotus Illusionist"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lotus Illusionist"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lotus Illusionist"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [CFM_310] Call in the Finishers - COST:4 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: Summon four 1/1 Murlocs.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CallInTheFinishers_CFM_310()
		{
			// TODO CallInTheFinishers_CFM_310 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Call in the Finishers"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Call in the Finishers"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Call in the Finishers"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [CFM_313] Finders Keepers - COST:1 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Discover</b> a card with_<b>Overload</b>. <b>Overload:</b> (1)
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 1
		// - OVERLOAD_OWED = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FindersKeepers_CFM_313()
		{
			// TODO FindersKeepers_CFM_313 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Finders Keepers"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Finders Keepers"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Finders Keepers"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [CFM_696] Devolve - COST:2 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: Transform all enemy minions into random ones that cost (1) less.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_HERO_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Devolve_CFM_696()
		{
			// TODO Devolve_CFM_696 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Devolve"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Devolve"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Devolve"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [CFM_707] Jade Lightning - COST:4 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $4 damage. Summon a{1} {0} <b>Jade Golem</b>.@Deal $4 damage. Summon a <b>Jade Golem</b>. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		// RefTag:
		// - JADE_GOLEM = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JadeLightning_CFM_707()
		{
			// TODO JadeLightning_CFM_707 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Jade Lightning"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jade Lightning"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Jade Lightning"));
		}

		// ---------------------------------------- WEAPON - SHAMAN
		// [CFM_717] Jade Claws - COST:2 [ATK:2/HP:0] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a{1} {0} <b>Jade Golem</b>.
		//       <b><b>Overload</b>:</b> (1)@<b>Battlecry:</b> Summon a <b>Jade Golem</b>.
		//       <b><b>Overload</b>:</b> (1)
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// - OVERLOAD = 1
		// - BATTLECRY = 1
		// - OVERLOAD_OWED = 1
		// --------------------------------------------------------
		// RefTag:
		// - JADE_GOLEM = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JadeClaws_CFM_717()
		{
			// TODO JadeClaws_CFM_717 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Jade Claws"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jade Claws"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Jade Claws"));
		}

	}

	public class WarlockGangsTest
	{
		// --------------------------------------- MINION - WARLOCK
		// [CFM_610] Crystalweaver - COST:4 [ATK:5/HP:4] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give your Demons +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Crystalweaver_CFM_610()
		{
			// TODO Crystalweaver_CFM_610 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Crystalweaver"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Crystalweaver"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Crystalweaver"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [CFM_663] Kabal Trafficker - COST:6 [ATK:6/HP:6] 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]At the end of your turn,
		//       add a random Demon
		//       to your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KabalTrafficker_CFM_663()
		{
			// TODO KabalTrafficker_CFM_663 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kabal Trafficker"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kabal Trafficker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kabal Trafficker"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [CFM_699] Seadevil Stinger - COST:4 [ATK:4/HP:2] 
		// - Race: murloc, Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> The next Murloc
		//       you play this turn costs
		//       _Health instead of Mana.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SeadevilStinger_CFM_699()
		{
			// TODO SeadevilStinger_CFM_699 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Seadevil Stinger"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Seadevil Stinger"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Seadevil Stinger"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [CFM_750] Krul the Unshackled - COST:9 [ATK:7/HP:9] 
		// - Race: demon, Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If your deck has
		//       no duplicates, summon all
		//       _Demons from your hand._
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KrulTheUnshackled_CFM_750()
		{
			// TODO KrulTheUnshackled_CFM_750 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Krul the Unshackled"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Krul the Unshackled"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Krul the Unshackled"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [CFM_751] Abyssal Enforcer - COST:7 [ATK:6/HP:6] 
		// - Race: demon, Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 3 damage to all other characters.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AbyssalEnforcer_CFM_751()
		{
			// TODO AbyssalEnforcer_CFM_751 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Abyssal Enforcer"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Abyssal Enforcer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Abyssal Enforcer"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [CFM_900] Unlicensed Apothecary - COST:3 [ATK:5/HP:5] 
		// - Race: demon, Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: After you summon a minion, deal 5 damage to_your hero.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnlicensedApothecary_CFM_900()
		{
			// TODO UnlicensedApothecary_CFM_900 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unlicensed Apothecary"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unlicensed Apothecary"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Unlicensed Apothecary"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [CFM_094] Felfire Potion - COST:6 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $5 damage to all characters. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FelfirePotion_CFM_094()
		{
			// TODO FelfirePotion_CFM_094 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Felfire Potion"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Felfire Potion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Felfire Potion"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [CFM_608] Blastcrystal Potion - COST:4 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: Destroy a minion and one of your Mana Crystals.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BlastcrystalPotion_CFM_608()
		{
			// TODO BlastcrystalPotion_CFM_608 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blastcrystal Potion"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blastcrystal Potion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blastcrystal Potion"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [CFM_611] Bloodfury Potion - COST:3 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]Give a minion +3 Attack.
		//       If it's a Demon, also
		//       give it +3 Health.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BloodfuryPotion_CFM_611()
		{
			// TODO BloodfuryPotion_CFM_611 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bloodfury Potion"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfury Potion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bloodfury Potion"));
		}

	}

	public class WarriorGangsTest
	{
		// --------------------------------------- MINION - WARRIOR
		// [CFM_300] Public Defender - COST:2 [ATK:0/HP:7] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PublicDefender_CFM_300()
		{
			// TODO PublicDefender_CFM_300 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Public Defender"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Public Defender"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Public Defender"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [CFM_643] Hobart Grapplehammer - COST:2 [ATK:2/HP:2] 
		// - Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give all weapons in your hand and deck +1 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HobartGrapplehammer_CFM_643()
		{
			// TODO HobartGrapplehammer_CFM_643 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hobart Grapplehammer"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hobart Grapplehammer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hobart Grapplehammer"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [CFM_754] Grimy Gadgeteer - COST:4 [ATK:4/HP:3] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: At the end of your turn, give a random minion in your hand +2/+2.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GrimyGadgeteer_CFM_754()
		{
			// TODO GrimyGadgeteer_CFM_754 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grimy Gadgeteer"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grimy Gadgeteer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grimy Gadgeteer"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [CFM_755] Grimestreet Pawnbroker - COST:3 [ATK:3/HP:3] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a random weapon in your hand +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GrimestreetPawnbroker_CFM_755()
		{
			// TODO GrimestreetPawnbroker_CFM_755 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grimestreet Pawnbroker"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grimestreet Pawnbroker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grimestreet Pawnbroker"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [CFM_756] Alley Armorsmith - COST:5 [ATK:2/HP:7] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       Whenever this minion
		//       deals damage, gain
		//       that much Armor.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AlleyArmorsmith_CFM_756()
		{
			// TODO AlleyArmorsmith_CFM_756 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Alley Armorsmith"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Alley Armorsmith"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Alley Armorsmith"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [CFM_716] Sleep with the Fishes - COST:2 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: Deal $3 damage to all damaged minions. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SleepWithTheFishes_CFM_716()
		{
			// TODO SleepWithTheFishes_CFM_716 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sleep with the Fishes"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sleep with the Fishes"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sleep with the Fishes"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [CFM_752] Stolen Goods - COST:2 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: Give a random <b>Taunt</b> minion in your hand +3/+3.
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StolenGoods_CFM_752()
		{
			// TODO StolenGoods_CFM_752 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stolen Goods"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stolen Goods"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stolen Goods"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [CFM_940] I Know a Guy - COST:1 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Discover</b> a <b>Taunt</b> minion.
		// --------------------------------------------------------
		// GameTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IKnowAGuy_CFM_940()
		{
			// TODO IKnowAGuy_CFM_940 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("I Know a Guy"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("I Know a Guy"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "I Know a Guy"));
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [CFM_631] Brass Knuckles - COST:4 [ATK:2/HP:0] 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]After your hero attacks,
		//       give a random minion in
		//       your hand +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 3
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BrassKnuckles_CFM_631()
		{
			// TODO BrassKnuckles_CFM_631 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Brass Knuckles"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Brass Knuckles"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Brass Knuckles"));
		}

	}

	public class NeutralGangsTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [CFM_025] Wind-up Burglebot - COST:6 [ATK:5/HP:5] 
		// - Race: mechanical, Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: Whenever this attacks a minion and survives, draw_a card.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WindUpBurglebot_CFM_025()
		{
			// TODO WindUpBurglebot_CFM_025 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wind-up Burglebot"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wind-up Burglebot"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wind-up Burglebot"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_039] Street Trickster - COST:3 [ATK:0/HP:7] 
		// - Race: demon, Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Spell Damage +1</b>
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StreetTrickster_CFM_039()
		{
			// TODO StreetTrickster_CFM_039 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Street Trickster"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Street Trickster"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Street Trickster"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_060] Red Mana Wyrm - COST:5 [ATK:2/HP:6] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever  you cast a spell, gain +2 Attack.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RedManaWyrm_CFM_060()
		{
			// TODO RedManaWyrm_CFM_060 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Red Mana Wyrm"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Red Mana Wyrm"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Red Mana Wyrm"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_063] Kooky Chemist - COST:4 [ATK:4/HP:4] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Swap the Attack and Health of a minion.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KookyChemist_CFM_063()
		{
			// TODO KookyChemist_CFM_063 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kooky Chemist"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kooky Chemist"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kooky Chemist"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_064] Blubber Baron - COST:3 [ATK:1/HP:1] 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: Whenever you summon a <b>Battlecry</b> minion while this_is in your hand, gain_+1/+1.
		// --------------------------------------------------------
		// RefTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BlubberBaron_CFM_064()
		{
			// TODO BlubberBaron_CFM_064 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blubber Baron"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blubber Baron"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blubber Baron"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_067] Hozen Healer - COST:4 [ATK:2/HP:6] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry</b>: Restore a minion to full Health.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HozenHealer_CFM_067()
		{
			// TODO HozenHealer_CFM_067 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hozen Healer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hozen Healer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hozen Healer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_095] Weasel Tunneler - COST:1 [ATK:1/HP:1] 
		// - Race: beast, Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Shuffle this minion into your opponent's deck.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// - 542 = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WeaselTunneler_CFM_095()
		{
			// TODO WeaselTunneler_CFM_095 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Weasel Tunneler"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Weasel Tunneler"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Weasel Tunneler"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_120] Mistress of Mixtures - COST:1 [ATK:2/HP:2] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Restore 4 Health to each hero.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MistressOfMixtures_CFM_120()
		{
			// TODO MistressOfMixtures_CFM_120 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mistress of Mixtures"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mistress of Mixtures"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mistress of Mixtures"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_321] Grimestreet Informant - COST:2 [ATK:1/HP:1] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> <b>Discover</b> a
		//       Hunter, Paladin, or Warrior
		//       card.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - MULTIPLE_CLASSES = 532
		// - MULTI_CLASS_GROUP = 1
		// - GRIMY_GOONS = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GrimestreetInformant_CFM_321()
		{
			// TODO GrimestreetInformant_CFM_321 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grimestreet Informant"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grimestreet Informant"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grimestreet Informant"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_325] Small-Time Buccaneer - COST:1 [ATK:1/HP:1] 
		// - Race: pirate, Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: Has +2 Attack while you have a weapon equipped.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SmallTimeBuccaneer_CFM_325()
		{
			// TODO SmallTimeBuccaneer_CFM_325 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Small-Time Buccaneer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Small-Time Buccaneer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Small-Time Buccaneer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_328] Fight Promoter - COST:6 [ATK:4/HP:4] 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If you control
		//       a minion with 6 or more
		//       _Health, draw two cards.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FightPromoter_CFM_328()
		{
			// TODO FightPromoter_CFM_328 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fight Promoter"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fight Promoter"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fight Promoter"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_341] Sergeant Sally - COST:3 [ATK:1/HP:1] 
		// - Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Deal damage equal to this minion's Attack to all enemy minions.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SergeantSally_CFM_341()
		{
			// TODO SergeantSally_CFM_341 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sergeant Sally"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sergeant Sally"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sergeant Sally"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_344] Finja, the Flying Star - COST:5 [ATK:2/HP:4] 
		// - Race: murloc, Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Stealth</b>
		//          Whenever this attacks and   
		//       kills a minion, summon 2
		//       _Murlocs from your deck.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FinjaTheFlyingStar_CFM_344()
		{
			// TODO FinjaTheFlyingStar_CFM_344 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Finja, the Flying Star"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Finja, the Flying Star"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Finja, the Flying Star"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_609] Fel Orc Soulfiend - COST:3 [ATK:3/HP:7] 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: At the start of your turn, deal 2 damage to this_minion.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FelOrcSoulfiend_CFM_609()
		{
			// TODO FelOrcSoulfiend_CFM_609 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fel Orc Soulfiend"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fel Orc Soulfiend"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fel Orc Soulfiend"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_619] Kabal Chemist - COST:4 [ATK:3/HP:3] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add a random Potion to your hand.
		// --------------------------------------------------------
		// Entourage: CFM_065, CFM_021, CFM_603, CFM_604, CFM_611, CFM_620, CFM_094, CFM_661, CFM_662, CFM_608
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - MULTIPLE_CLASSES = 296
		// - MULTI_CLASS_GROUP = 3
		// - KABAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KabalChemist_CFM_619()
		{
			// TODO KabalChemist_CFM_619 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kabal Chemist"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kabal Chemist"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kabal Chemist"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_621] Kazakus - COST:4 [ATK:3/HP:3] 
		// - Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If your deck
		//       has no duplicates,
		//       _create a custom spell.
		// --------------------------------------------------------
		// Entourage: CFM_621t11, CFM_621t12, CFM_621t13
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - MULTIPLE_CLASSES = 296
		// - MULTI_CLASS_GROUP = 3
		// - KABAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Kazakus_CFM_621()
		{
			// TODO Kazakus_CFM_621 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kazakus"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kazakus"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kazakus"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_637] Patches the Pirate - COST:1 [ATK:1/HP:1] 
		// - Race: pirate, Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]After you play a Pirate,
		//       summon this minion
		//       from your deck.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PatchesThePirate_CFM_637()
		{
			// TODO PatchesThePirate_CFM_637 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Patches the Pirate"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Patches the Pirate"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Patches the Pirate"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_646] Backstreet Leper - COST:3 [ATK:3/HP:1] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Deathrattle:</b> Deal 2 damage
		//       to the enemy hero.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BackstreetLeper_CFM_646()
		{
			// TODO BackstreetLeper_CFM_646 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Backstreet Leper"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Backstreet Leper"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Backstreet Leper"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_647] Blowgill Sniper - COST:2 [ATK:2/HP:1] 
		// - Race: murloc, Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 1 damage.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BlowgillSniper_CFM_647()
		{
			// TODO BlowgillSniper_CFM_647 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blowgill Sniper"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blowgill Sniper"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blowgill Sniper"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_648] Big-Time Racketeer - COST:6 [ATK:1/HP:1] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 6/6_Ogre.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BigTimeRacketeer_CFM_648()
		{
			// TODO BigTimeRacketeer_CFM_648 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Big-Time Racketeer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Big-Time Racketeer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Big-Time Racketeer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_649] Kabal Courier - COST:3 [ATK:2/HP:2] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Discover</b> a Mage, Priest, or Warlock card.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - MULTIPLE_CLASSES = 296
		// - MULTI_CLASS_GROUP = 3
		// - KABAL = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KabalCourier_CFM_649()
		{
			// TODO KabalCourier_CFM_649 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kabal Courier"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kabal Courier"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kabal Courier"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_651] Naga Corsair - COST:4 [ATK:5/HP:4] 
		// - Race: pirate, Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give your weapon +1 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NagaCorsair_CFM_651()
		{
			// TODO NagaCorsair_CFM_651 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Naga Corsair"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Naga Corsair"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Naga Corsair"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_652] Second-Rate Bruiser - COST:5 [ATK:4/HP:5] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       Costs (2) less if your
		//       opponent has at least
		//       three minions.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SecondRateBruiser_CFM_652()
		{
			// TODO SecondRateBruiser_CFM_652 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Second-Rate Bruiser"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Second-Rate Bruiser"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Second-Rate Bruiser"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_653] Hired Gun - COST:3 [ATK:4/HP:3] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HiredGun_CFM_653()
		{
			// TODO HiredGun_CFM_653 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hired Gun"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hired Gun"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hired Gun"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_654] Friendly Bartender - COST:2 [ATK:2/HP:3] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: At the end of your turn, restore 1 Health to your_hero.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FriendlyBartender_CFM_654()
		{
			// TODO FriendlyBartender_CFM_654 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Friendly Bartender"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Friendly Bartender"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Friendly Bartender"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_655] Toxic Sewer Ooze - COST:3 [ATK:4/HP:3] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Remove 1 Durability from your opponent's weapon.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ToxicSewerOoze_CFM_655()
		{
			// TODO ToxicSewerOoze_CFM_655 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Toxic Sewer Ooze"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Toxic Sewer Ooze"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Toxic Sewer Ooze"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_656] Streetwise Investigator - COST:5 [ATK:4/HP:6] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Enemy minions lose <b>Stealth</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StreetwiseInvestigator_CFM_656()
		{
			// TODO StreetwiseInvestigator_CFM_656 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Streetwise Investigator"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Streetwise Investigator"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Streetwise Investigator"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_658] Backroom Bouncer - COST:4 [ATK:4/HP:4] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever a friendly minion dies, gain +1 Attack.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BackroomBouncer_CFM_658()
		{
			// TODO BackroomBouncer_CFM_658 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Backroom Bouncer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Backroom Bouncer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Backroom Bouncer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_659] Gadgetzan Socialite - COST:2 [ATK:2/HP:2] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Restore 2_Health.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GadgetzanSocialite_CFM_659()
		{
			// TODO GadgetzanSocialite_CFM_659 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gadgetzan Socialite"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gadgetzan Socialite"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gadgetzan Socialite"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_665] Worgen Greaser - COST:4 [ATK:6/HP:3] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WorgenGreaser_CFM_665()
		{
			// TODO WorgenGreaser_CFM_665 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Worgen Greaser"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Worgen Greaser"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Worgen Greaser"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_666] Grook Fu Master - COST:5 [ATK:3/HP:5] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Windfury</b>
		// --------------------------------------------------------
		// GameTag:
		// - WINDFURY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GrookFuMaster_CFM_666()
		{
			// TODO GrookFuMaster_CFM_666 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grook Fu Master"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grook Fu Master"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grook Fu Master"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_667] Bomb Squad - COST:5 [ATK:2/HP:2] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Deal 5 damage
		//       to an enemy minion.
		//       <b>Deathrattle:</b> Deal 5 damage
		//       to your hero.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_ENEMY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BombSquad_CFM_667()
		{
			// TODO BombSquad_CFM_667 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bomb Squad"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bomb Squad"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bomb Squad"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_668] Doppelgangster - COST:5 [ATK:2/HP:2] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon 2 copies of this minion.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Doppelgangster_CFM_668()
		{
			// TODO Doppelgangster_CFM_668 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Doppelgangster"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Doppelgangster"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Doppelgangster"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_669] Burgly Bully - COST:5 [ATK:4/HP:6] 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: Whenever your opponent casts a spell, add a Coin to your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BurglyBully_CFM_669()
		{
			// TODO BurglyBully_CFM_669 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Burgly Bully"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Burgly Bully"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Burgly Bully"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_670] Mayor Noggenfogger - COST:9 [ATK:5/HP:4] 
		// - Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: All targets are chosen randomly.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MayorNoggenfogger_CFM_670()
		{
			// TODO MayorNoggenfogger_CFM_670 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mayor Noggenfogger"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mayor Noggenfogger"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mayor Noggenfogger"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_672] Madam Goya - COST:6 [ATK:4/HP:3] 
		// - Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Choose a friendly minion. Swap it with a minion in your deck.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MadamGoya_CFM_672()
		{
			// TODO MadamGoya_CFM_672 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Madam Goya"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Madam Goya"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Madam Goya"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_685] Don Han'Cho - COST:7 [ATK:5/HP:6] 
		// - Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a random minion in your hand +5/+5.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - MULTIPLE_CLASSES = 532
		// - MULTI_CLASS_GROUP = 1
		// - GRIMY_GOONS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DonHancho_CFM_685()
		{
			// TODO DonHancho_CFM_685 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Don Han'Cho"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Don Han'Cho"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Don Han'Cho"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_688] Spiked Hogrider - COST:5 [ATK:5/HP:5] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If an enemy minion has <b>Taunt</b>, gain_<b>Charge</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SpikedHogrider_CFM_688()
		{
			// TODO SpikedHogrider_CFM_688 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spiked Hogrider"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spiked Hogrider"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Spiked Hogrider"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_715] Jade Spirit - COST:4 [ATK:2/HP:3] 
		// - Race: elemental, Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a{1} {0} <b>Jade_Golem</b>.@<b>Battlecry:</b> Summon a <b>Jade_Golem</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - JADE_GOLEM = 1
		// - MULTIPLE_CLASSES = 194
		// - MULTI_CLASS_GROUP = 2
		// - JADE_LOTUS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JadeSpirit_CFM_715()
		{
			// TODO JadeSpirit_CFM_715 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Jade Spirit"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jade Spirit"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Jade Spirit"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_790] Dirty Rat - COST:2 [ATK:2/HP:6] 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       <b>Battlecry:</b> Your opponent
		//       summons a random minion
		//       from their hand.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DirtyRat_CFM_790()
		{
			// TODO DirtyRat_CFM_790 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dirty Rat"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dirty Rat"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dirty Rat"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_806] Wrathion - COST:6 [ATK:4/HP:5] 
		// - Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Taunt</b>. <b>Battlecry:</b> Draw cards until you draw one that isn't a Dragon.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Wrathion_CFM_806()
		{
			// TODO Wrathion_CFM_806 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wrathion"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wrathion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wrathion"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_807] Auctionmaster Beardo - COST:3 [ATK:3/HP:4] 
		// - Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: After you cast a spell, refresh your Hero Power.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AuctionmasterBeardo_CFM_807()
		{
			// TODO AuctionmasterBeardo_CFM_807 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Auctionmaster Beardo"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Auctionmaster Beardo"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Auctionmaster Beardo"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_808] Genzo, the Shark - COST:4 [ATK:5/HP:4] 
		// - Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever this attacks, both players draw until they have 3 cards.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GenzoTheShark_CFM_808()
		{
			// TODO GenzoTheShark_CFM_808 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Genzo, the Shark"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Genzo, the Shark"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Genzo, the Shark"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_809] Tanaris Hogchopper - COST:4 [ATK:4/HP:4] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If your opponent's
		//       hand is empty, gain <b>Charge</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TanarisHogchopper_CFM_809()
		{
			// TODO TanarisHogchopper_CFM_809 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tanaris Hogchopper"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tanaris Hogchopper"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tanaris Hogchopper"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_810] Leatherclad Hogleader - COST:6 [ATK:6/HP:6] 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your opponent has 6 or more cards in hand, gain <b>Charge</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LeathercladHogleader_CFM_810()
		{
			// TODO LeathercladHogleader_CFM_810 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Leatherclad Hogleader"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Leatherclad Hogleader"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Leatherclad Hogleader"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_851] Daring Reporter - COST:4 [ATK:3/HP:3] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever your opponent draws a card, gain +1/+1.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DaringReporter_CFM_851()
		{
			// TODO DaringReporter_CFM_851 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Daring Reporter"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Daring Reporter"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Daring Reporter"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_852] Lotus Agents - COST:5 [ATK:5/HP:3] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Discover</b> a Druid, Rogue, or Shaman card.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - MULTIPLE_CLASSES = 194
		// - MULTI_CLASS_GROUP = 2
		// - JADE_LOTUS = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LotusAgents_CFM_852()
		{
			// TODO LotusAgents_CFM_852 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lotus Agents"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lotus Agents"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lotus Agents"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_853] Grimestreet Smuggler - COST:3 [ATK:2/HP:4] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a random minion in your hand +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - MULTIPLE_CLASSES = 532
		// - MULTI_CLASS_GROUP = 1
		// - GRIMY_GOONS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GrimestreetSmuggler_CFM_853()
		{
			// TODO GrimestreetSmuggler_CFM_853 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grimestreet Smuggler"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grimestreet Smuggler"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grimestreet Smuggler"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_854] Ancient of Blossoms - COST:6 [ATK:3/HP:8] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AncientOfBlossoms_CFM_854()
		{
			// TODO AncientOfBlossoms_CFM_854 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ancient of Blossoms"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ancient of Blossoms"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ancient of Blossoms"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_855] Defias Cleaner - COST:6 [ATK:5/HP:7] 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Silence</b> a minion with <b>Deathrattle</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_NONSELF_TARGET = 0
		// - REQ_TARGET_WITH_DEATHRATTLE = 0
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// - SILENCE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DefiasCleaner_CFM_855()
		{
			// TODO DefiasCleaner_CFM_855 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Defias Cleaner"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Defias Cleaner"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Defias Cleaner"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_902] Aya Blackpaw - COST:6 [ATK:5/HP:3] 
		// - Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry and Deathrattle:</b> Summon a{1} {0} <b>Jade Golem</b>. @ <b>Battlecry and Deathrattle:</b> Summon a <b>Jade Golem</b>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// - BATTLECRY = 1
		// - JADE_GOLEM = 1
		// - MULTIPLE_CLASSES = 194
		// - MULTI_CLASS_GROUP = 2
		// - JADE_LOTUS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AyaBlackpaw_CFM_902()
		{
			// TODO AyaBlackpaw_CFM_902 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Aya Blackpaw"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Aya Blackpaw"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Aya Blackpaw"));
		}

	}

}
