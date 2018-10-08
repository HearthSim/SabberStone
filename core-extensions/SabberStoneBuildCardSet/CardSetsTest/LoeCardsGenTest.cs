using Xunit;
using SabberStoneCore.Enums;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using System.Collections.Generic;

namespace SabberStoneCoreTest.CardSets.Undefined
{
	public class DruidLoeTest
	{
		// ----------------------------------------- MINION - DRUID
		// [LOE_050] Mounted Raptor - COST:3 [ATK:3/HP:2] 
		// - Race: beast, Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a random 1-Cost minion.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MountedRaptor_LOE_050()
		{
			// TODO MountedRaptor_LOE_050 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mounted Raptor"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mounted Raptor"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mounted Raptor"));
		}

		// ----------------------------------------- MINION - DRUID
		// [LOE_051] Jungle Moonkin - COST:4 [ATK:4/HP:4] 
		// - Race: beast, Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: Both players have
		//       <b>Spell Damage +2</b>.
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JungleMoonkin_LOE_051()
		{
			// TODO JungleMoonkin_LOE_051 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Jungle Moonkin"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jungle Moonkin"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Jungle Moonkin"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [LOE_115] Raven Idol - COST:1 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Choose One -</b>
		//       <b>Discover</b> a minion; or <b>Discover</b> a spell.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RavenIdol_LOE_115()
		{
			// TODO RavenIdol_LOE_115 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Raven Idol"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Raven Idol"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Raven Idol"));
		}

	}

	public class HunterLoeTest
	{
		// ---------------------------------------- MINION - HUNTER
		// [LOE_020] Desert Camel - COST:3 [ATK:2/HP:4] 
		// - Race: beast, Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Put a 1-Cost minion from each deck into the battlefield.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DesertCamel_LOE_020()
		{
			// TODO DesertCamel_LOE_020 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Desert Camel"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Desert Camel"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Desert Camel"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [LOE_021] Dart Trap - COST:2 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> After an opposing Hero Power is used, deal $5 damage to a random enemy. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DartTrap_LOE_021()
		{
			// TODO DartTrap_LOE_021 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dart Trap"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dart Trap"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dart Trap"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [LOE_105] Explorer's Hat - COST:2 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: Give a minion +1/+1 and "<b>Deathrattle:</b> Add an Explorer's Hat to your hand."
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ExplorersHat_LOE_105()
		{
			// TODO ExplorersHat_LOE_105 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Explorer's Hat"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Explorer's Hat"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Explorer's Hat"));
		}

	}

	public class MageLoeTest
	{
		// ------------------------------------------ MINION - MAGE
		// [LOE_003] Ethereal Conjurer - COST:5 [ATK:6/HP:3] 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry: Discover</b> a spell.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EtherealConjurer_LOE_003()
		{
			// TODO EtherealConjurer_LOE_003 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ethereal Conjurer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ethereal Conjurer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ethereal Conjurer"));
		}

		// ------------------------------------------ MINION - MAGE
		// [LOE_119] Animated Armor - COST:4 [ATK:4/HP:4] 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: Your hero can only take 1 damage at a time.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AnimatedArmor_LOE_119()
		{
			// TODO AnimatedArmor_LOE_119 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Animated Armor"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Animated Armor"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Animated Armor"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [LOE_002] Forgotten Torch - COST:3 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $3 damage. Shuffle a 'Roaring Torch' into your deck that deals 6 damage. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ForgottenTorch_LOE_002()
		{
			// TODO ForgottenTorch_LOE_002 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Forgotten Torch"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Forgotten Torch"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Forgotten Torch"));
		}

	}

	public class PaladinLoeTest
	{
		// --------------------------------------- MINION - PALADIN
		// [LOE_017] Keeper of Uldaman - COST:4 [ATK:3/HP:4] 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Set a minion's Attack and Health to 3.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KeeperOfUldaman_LOE_017()
		{
			// TODO KeeperOfUldaman_LOE_017 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Keeper of Uldaman"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Keeper of Uldaman"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Keeper of Uldaman"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [LOE_026] Anyfin Can Happen - COST:10 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: Summon 7 Murlocs that died this game.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AnyfinCanHappen_LOE_026()
		{
			// TODO AnyfinCanHappen_LOE_026 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Anyfin Can Happen"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Anyfin Can Happen"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Anyfin Can Happen"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [LOE_027] Sacred Trial - COST:1 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> After your opponent has at least 3 minions and plays another, destroy it.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SacredTrial_LOE_027()
		{
			// TODO SacredTrial_LOE_027 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sacred Trial"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sacred Trial"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sacred Trial"));
		}

	}

	public class PriestLoeTest
	{
		// ---------------------------------------- MINION - PRIEST
		// [LOE_006] Museum Curator - COST:2 [ATK:1/HP:2] 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry: Discover</b> a <b>Deathrattle</b> card.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MuseumCurator_LOE_006()
		{
			// TODO MuseumCurator_LOE_006 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Museum Curator"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Museum Curator"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Museum Curator"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [LOE_104] Entomb - COST:6 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: Choose an enemy minion.
		//       Shuffle it into your deck.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_ENEMY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Entomb_LOE_104()
		{
			// TODO Entomb_LOE_104 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Entomb"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Entomb"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Entomb"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [LOE_111] Excavated Evil - COST:5 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $3 damage to all minions.
		//       Shuffle this card into your opponent's deck. @spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ExcavatedEvil_LOE_111()
		{
			// TODO ExcavatedEvil_LOE_111 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Excavated Evil"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Excavated Evil"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Excavated Evil"));
		}

	}

	public class RogueLoeTest
	{
		// ----------------------------------------- MINION - ROGUE
		// [LOE_010] Pit Snake - COST:1 [ATK:2/HP:1] 
		// - Race: beast, Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Poisonous</b>
		// --------------------------------------------------------
		// GameTag:
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PitSnake_LOE_010()
		{
			// TODO PitSnake_LOE_010 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Pit Snake"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pit Snake"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Pit Snake"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [LOE_012] Tomb Pillager - COST:4 [ATK:5/HP:4] 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Add a Coin to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TombPillager_LOE_012()
		{
			// TODO TombPillager_LOE_012 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tomb Pillager"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tomb Pillager"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tomb Pillager"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [LOE_019] Unearthed Raptor - COST:3 [ATK:3/HP:4] 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Choose a friendly minion. Gain a copy of its_<b>Deathrattle</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_WITH_DEATHRATTLE = 0
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnearthedRaptor_LOE_019()
		{
			// TODO UnearthedRaptor_LOE_019 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unearthed Raptor"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unearthed Raptor"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Unearthed Raptor"));
		}

	}

	public class ShamanLoeTest
	{
		// ---------------------------------------- MINION - SHAMAN
		// [LOE_016] Rumbling Elemental - COST:4 [ATK:2/HP:6] 
		// - Race: elemental, Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: After you play a <b>Battlecry</b> minion, deal 2 damage to a random enemy.
		// --------------------------------------------------------
		// RefTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RumblingElemental_LOE_016()
		{
			// TODO RumblingElemental_LOE_016 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rumbling Elemental"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rumbling Elemental"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rumbling Elemental"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [LOE_018] Tunnel Trogg - COST:1 [ATK:1/HP:3] 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever you <b>Overload</b>, gain +1 Attack per locked Mana Crystal.
		// --------------------------------------------------------
		// RefTag:
		// - OVERLOAD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TunnelTrogg_LOE_018()
		{
			// TODO TunnelTrogg_LOE_018 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tunnel Trogg"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tunnel Trogg"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tunnel Trogg"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [LOE_113] Everyfin is Awesome - COST:7 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: Give your minions +2/+2.
		//       Costs (1) less for each Murloc you control.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EveryfinIsAwesome_LOE_113()
		{
			// TODO EveryfinIsAwesome_LOE_113 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Everyfin is Awesome"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Everyfin is Awesome"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Everyfin is Awesome"));
		}

	}

	public class WarlockLoeTest
	{
		// --------------------------------------- MINION - WARLOCK
		// [LOE_023] Dark Peddler - COST:2 [ATK:2/HP:2] 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry: Discover</b> a
		//       1-Cost card.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DarkPeddler_LOE_023()
		{
			// TODO DarkPeddler_LOE_023 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dark Peddler"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dark Peddler"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dark Peddler"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [LOE_116] Reliquary Seeker - COST:1 [ATK:1/HP:1] 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you have 6 other minions, gain +4/+4.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ReliquarySeeker_LOE_116()
		{
			// TODO ReliquarySeeker_LOE_116 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Reliquary Seeker"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Reliquary Seeker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Reliquary Seeker"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [LOE_007] Curse of Rafaam - COST:2 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: Give your opponent a 'Cursed!' card.
		//       While they hold it, they take 2 damage on their turn.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CurseOfRafaam_LOE_007()
		{
			// TODO CurseOfRafaam_LOE_007 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Curse of Rafaam"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Curse of Rafaam"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Curse of Rafaam"));
		}

	}

	public class WarriorLoeTest
	{
		// --------------------------------------- MINION - WARRIOR
		// [LOE_009] Obsidian Destroyer - COST:7 [ATK:7/HP:7] 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: At the end of your turn, summon a 1/1 Scarab with <b>Taunt</b>.
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ObsidianDestroyer_LOE_009()
		{
			// TODO ObsidianDestroyer_LOE_009 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Obsidian Destroyer"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Obsidian Destroyer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Obsidian Destroyer"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [LOE_022] Fierce Monkey - COST:3 [ATK:3/HP:4] 
		// - Race: beast, Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FierceMonkey_LOE_022()
		{
			// TODO FierceMonkey_LOE_022 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fierce Monkey"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fierce Monkey"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fierce Monkey"));
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [LOE_118] Cursed Blade - COST:1 [ATK:2/HP:0] 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: Double all damage dealt to your hero.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 3
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CursedBlade_LOE_118()
		{
			// TODO CursedBlade_LOE_118 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cursed Blade"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cursed Blade"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cursed Blade"));
		}

	}

	public class NeutralLoeTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [LOE_011] Reno Jackson - COST:6 [ATK:4/HP:6] 
		// - Set: loe, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your deck has no duplicates, fully heal your hero.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RenoJackson_LOE_011()
		{
			// TODO RenoJackson_LOE_011 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Reno Jackson"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Reno Jackson"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Reno Jackson"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_029] Jeweled Scarab - COST:2 [ATK:1/HP:1] 
		// - Race: beast, Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry: Discover</b> a
		//       3-Cost card.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JeweledScarab_LOE_029()
		{
			// TODO JeweledScarab_LOE_029 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Jeweled Scarab"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jeweled Scarab"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Jeweled Scarab"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_038] Naga Sea Witch - COST:5 [ATK:5/HP:5] 
		// - Set: loe, Rarity: epic
		// --------------------------------------------------------
		// Text: Your cards cost (5).
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NagaSeaWitch_LOE_038()
		{
			// TODO NagaSeaWitch_LOE_038 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Naga Sea Witch"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Naga Sea Witch"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Naga Sea Witch"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_039] Gorillabot A-3 - COST:4 [ATK:3/HP:4] 
		// - Race: mechanical, Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you control another Mech, <b>Discover</b> a Mech.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GorillabotA3_LOE_039()
		{
			// TODO GorillabotA3_LOE_039 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gorillabot A-3"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gorillabot A-3"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gorillabot A-3"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_046] Huge Toad - COST:2 [ATK:3/HP:2] 
		// - Race: beast, Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Deal 1 damage to a random enemy.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HugeToad_LOE_046()
		{
			// TODO HugeToad_LOE_046 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Huge Toad"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Huge Toad"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Huge Toad"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_047] Tomb Spider - COST:4 [ATK:3/HP:3] 
		// - Race: beast, Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry: Discover</b> a Beast.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TombSpider_LOE_047()
		{
			// TODO TombSpider_LOE_047 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tomb Spider"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tomb Spider"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tomb Spider"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_053] Djinni of Zephyrs - COST:5 [ATK:4/HP:6] 
		// - Race: elemental, Set: loe, Rarity: epic
		// --------------------------------------------------------
		// Text: After you cast a spell on another friendly minion, cast a copy of it on this one.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DjinniOfZephyrs_LOE_053()
		{
			// TODO DjinniOfZephyrs_LOE_053 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Djinni of Zephyrs"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Djinni of Zephyrs"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Djinni of Zephyrs"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_061] Anubisath Sentinel - COST:5 [ATK:4/HP:4] 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Give a random friendly minion +3/+3.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AnubisathSentinel_LOE_061()
		{
			// TODO AnubisathSentinel_LOE_061 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Anubisath Sentinel"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Anubisath Sentinel"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Anubisath Sentinel"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_073] Fossilized Devilsaur - COST:8 [ATK:8/HP:8] 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you control a Beast, gain <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FossilizedDevilsaur_LOE_073()
		{
			// TODO FossilizedDevilsaur_LOE_073 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fossilized Devilsaur"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fossilized Devilsaur"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fossilized Devilsaur"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_076] Sir Finley Mrrgglton - COST:1 [ATK:1/HP:3] 
		// - Race: murloc, Set: loe, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry: Discover</b> a new basic Hero Power.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SirFinleyMrrgglton_LOE_076()
		{
			// TODO SirFinleyMrrgglton_LOE_076 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sir Finley Mrrgglton"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sir Finley Mrrgglton"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sir Finley Mrrgglton"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_077] Brann Bronzebeard - COST:3 [ATK:2/HP:4] 
		// - Set: loe, Rarity: legendary
		// --------------------------------------------------------
		// Text: Your <b>Battlecries</b> trigger twice.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - AURA = 1
		// --------------------------------------------------------
		// RefTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BrannBronzebeard_LOE_077()
		{
			// TODO BrannBronzebeard_LOE_077 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Brann Bronzebeard"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Brann Bronzebeard"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Brann Bronzebeard"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_079] Elise Starseeker - COST:4 [ATK:3/HP:5] 
		// - Set: loe, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Shuffle the 'Map to the Golden Monkey'   into your deck.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EliseStarseeker_LOE_079()
		{
			// TODO EliseStarseeker_LOE_079 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Elise Starseeker"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Elise Starseeker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Elise Starseeker"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_086] Summoning Stone - COST:5 [ATK:0/HP:6] 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, summon a random minion of the same Cost.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SummoningStone_LOE_086()
		{
			// TODO SummoningStone_LOE_086 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Summoning Stone"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Summoning Stone"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Summoning Stone"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_089] Wobbling Runts - COST:6 [ATK:2/HP:6] 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon three 2/2 Runts.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WobblingRunts_LOE_089()
		{
			// TODO WobblingRunts_LOE_089 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wobbling Runts"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wobbling Runts"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wobbling Runts"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_092] Arch-Thief Rafaam - COST:9 [ATK:7/HP:8] 
		// - Set: loe, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry: Discover</b> a powerful Artifact.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArchThiefRafaam_LOE_092()
		{
			// TODO ArchThiefRafaam_LOE_092 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arch-Thief Rafaam"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arch-Thief Rafaam"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Arch-Thief Rafaam"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_107] Eerie Statue - COST:4 [ATK:7/HP:7] 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: Can’t attack unless it’s the only minion in the battlefield.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EerieStatue_LOE_107()
		{
			// TODO EerieStatue_LOE_107 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Eerie Statue"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eerie Statue"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Eerie Statue"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_110] Ancient Shade - COST:4 [ATK:7/HP:4] 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Shuffle an 'Ancient Curse' into your deck that deals 7 damage to you when drawn.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AncientShade_LOE_110()
		{
			// TODO AncientShade_LOE_110 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ancient Shade"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ancient Shade"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ancient Shade"));
		}

	}

}
