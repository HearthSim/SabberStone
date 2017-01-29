using System.Collections.Generic;
using SabberStoneCore.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SabberStoneCore.Actions;
using SabberStoneCore.Conditions;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.PlayerTasks;

namespace SabberStoneCoreTest.CardSets
{
	[TestClass]
	public class DruidLoeTest
	{
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
		// - TREASURE = 1
		// --------------------------------------------------------
		[TestMethod]
		public void RavenIdol_LOE_115()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.DRUID,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Raven Idol"));
            var testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Raven Idol"));
            Assert.AreEqual(6, game.CurrentPlayer.Hand.Count);
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard1, 1));
            Assert.AreEqual(CardType.MINION, game.CurrentPlayer.Choice.Choices[0].Type);
            game.Process(ChooseTask.Pick(game.CurrentPlayer, game.CurrentPlayer.Choice.Choices[0]));
            Assert.AreEqual(6, game.CurrentPlayer.Hand.Count);
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard2, 2));
            Assert.AreEqual(CardType.SPELL, game.CurrentPlayer.Choice.Choices[0].Type);
            game.Process(ChooseTask.Pick(game.CurrentPlayer, game.CurrentPlayer.Choice.Choices[0]));
            Assert.AreEqual(6, game.CurrentPlayer.Hand.Count);
        }

		// ----------------------------------------- MINION - DRUID
		// [LOE_050] Mounted Raptor - COST:3 [ATK:3/HP:2] 
		// - Race: beast, Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a random 1-Cost minion.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[TestMethod]
		public void MountedRaptor_LOE_050()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Mounted Raptor"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, testCard));
            Assert.AreEqual(1, game.CurrentOpponent.Board.Count);
            Assert.AreEqual(1, game.CurrentOpponent.Board[0].Cost);

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
		[TestMethod]
		public void JungleMoonkin_LOE_051()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.DRUID,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Jungle Moonkin"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            var spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
		    game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, game.CurrentOpponent.Hero));
		    Assert.AreEqual(22, game.CurrentOpponent.Hero.Health);
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, game.CurrentOpponent.Hero));
            Assert.AreEqual(22, game.CurrentOpponent.Hero.Health);
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
        }

    }

	[TestClass]
	public class HunterLoeTest
	{
		// ----------------------------------------- SPELL - HUNTER
		// [LOE_021] Dart Trap - COST:2 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> After an opposing <b>Hero Power</b> is used, deal $5 damage to a random enemy. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[TestMethod]
		public void DartTrap_LOE_021()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.HUNTER,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Dart Trap"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            Assert.AreEqual(30, game.CurrentPlayer.Hero.Health);
            game.Process(HeroPowerTask.Any(game.CurrentPlayer));
            Assert.AreEqual(25, game.CurrentPlayer.Hero.Health);
        }

		// ----------------------------------------- SPELL - HUNTER
		// [LOE_105] Explorer's Hat - COST:2 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: Give a minion +1/+1 and "<b>Deathrattle:</b> Add an Explorer's Hat to your hand."
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void ExplorersHat_LOE_105()
		{
			// TODO ExplorersHat_LOE_105 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.HUNTER,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Explorer's Hat"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [LOE_020] Desert Camel - COST:3 [ATK:2/HP:4] 
		// - Race: beast, Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Put a 1-Cost minion from each deck into the battlefield.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void DesertCamel_LOE_020()
		{
			// TODO DesertCamel_LOE_020 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.HUNTER,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Desert Camel"));
		}

	}

	[TestClass]
	public class MageLoeTest
	{
		// ------------------------------------------- SPELL - MAGE
		// [LOE_002] Forgotten Torch - COST:3 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $3 damage. Shuffle a 'Roaring Torch' into your deck that deals 6 damage. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod]
		public void ForgottenTorch_LOE_002()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Forgotten Torch"));
            Assert.AreEqual(26, game.CurrentPlayer.Deck.Count);
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, game.CurrentOpponent.Hero));
            Assert.AreEqual(27, game.CurrentOpponent.Hero.Health);
		    Assert.AreEqual(27, game.CurrentPlayer.Deck.Count);


		}

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
		// - TREASURE = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void EtherealConjurer_LOE_003()
		{
			// TODO EtherealConjurer_LOE_003 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ethereal Conjurer"));
		}

		// ------------------------------------------ MINION - MAGE
		// [LOE_119] Animated Armor - COST:4 [ATK:4/HP:4] 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: Your hero can only take 1 damage at a time.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void AnimatedArmor_LOE_119()
		{
			// TODO AnimatedArmor_LOE_119 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Animated Armor"));
		}

	}

	[TestClass]
	public class PaladinLoeTest
	{
		// ---------------------------------------- SPELL - PALADIN
		// [LOE_026] Anyfin Can Happen - COST:10 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: Summon 7 Murlocs that died this game.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void AnyfinCanHappen_LOE_026()
		{
			// TODO AnyfinCanHappen_LOE_026 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Anyfin Can Happen"));
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
		[TestMethod, Ignore]
		public void SacredTrial_LOE_027()
		{
			// TODO SacredTrial_LOE_027 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sacred Trial"));
		}

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
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void KeeperOfUldaman_LOE_017()
		{
			// TODO KeeperOfUldaman_LOE_017 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Keeper of Uldaman"));
		}

	}

	[TestClass]
	public class PriestLoeTest
	{
		// ----------------------------------------- SPELL - PRIEST
		// [LOE_104] Entomb - COST:6 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: Choose an enemy minion.
		//       Shuffle it into your deck.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_ENEMY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Entomb_LOE_104()
		{
			// TODO Entomb_LOE_104 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Entomb"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [LOE_111] Excavated Evil - COST:5 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $3 damage to all minions.
		//       Shuffle this card into your opponent's deck. *spelldmg
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void ExcavatedEvil_LOE_111()
		{
			// TODO ExcavatedEvil_LOE_111 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Excavated Evil"));
		}

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
		// - TREASURE = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void MuseumCurator_LOE_006()
		{
			// TODO MuseumCurator_LOE_006 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Museum Curator"));
		}

	}

	[TestClass]
	public class RogueLoeTest
	{
		// ----------------------------------------- MINION - ROGUE
		// [LOE_010] Pit Snake - COST:1 [ATK:2/HP:1] 
		// - Race: beast, Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: Destroy any minion damaged by this minion.
		// --------------------------------------------------------
		// GameTag:
		// - POISONOUS = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void PitSnake_LOE_010()
		{
			// TODO PitSnake_LOE_010 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.ROGUE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Pit Snake"));
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
		[TestMethod]
		public void TombPillager_LOE_012()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Tomb Pillager"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
            Assert.AreEqual(4, game.CurrentOpponent.Hand.Count);
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, testCard));
            Assert.AreEqual(5, game.CurrentOpponent.Hand.Count);
        }

		// ----------------------------------------- MINION - ROGUE
		// [LOE_019] Unearthed Raptor - COST:3 [ATK:3/HP:4] 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Choose a friendly minion. Gain a copy of its <b>Deathrattle</b> effect.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_WITH_DEATHRATTLE = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void UnearthedRaptor_LOE_019()
		{
			// TODO UnearthedRaptor_LOE_019 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.ROGUE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Unearthed Raptor"));
		}

	}

	[TestClass]
	public class ShamanLoeTest
	{
		// ----------------------------------------- SPELL - SHAMAN
		// [LOE_113] Everyfin is Awesome - COST:7 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: Give your minions +2/+2.
		//       Costs (1) less for each Murloc you control.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void EveryfinIsAwesome_LOE_113()
		{
			// TODO EveryfinIsAwesome_LOE_113 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.SHAMAN,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Everyfin is Awesome"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [LOE_016] Rumbling Elemental - COST:4 [ATK:2/HP:6] 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: After you play a <b>Battlecry</b> minion, deal 2 damage to a random enemy.
		// --------------------------------------------------------
		// RefTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void RumblingElemental_LOE_016()
		{
			// TODO RumblingElemental_LOE_016 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.SHAMAN,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Rumbling Elemental"));
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
		[TestMethod]
		public void TunnelTrogg_LOE_018()
		{
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.SHAMAN,
                Player2HeroClass = CardClass.PALADIN,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;
            var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tunnel Trogg"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            var minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Totem Golem"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
            Assert.AreEqual(2, ((Minion)testCard).AttackDamage);
            var minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dust Devil"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
            Assert.AreEqual(4, ((Minion)testCard).AttackDamage);
        }

	}

	[TestClass]
	public class WarlockLoeTest
	{
		// ---------------------------------------- SPELL - WARLOCK
		// [LOE_007] Curse of Rafaam - COST:2 
		// - Set: loe, Rarity: common
		// --------------------------------------------------------
		// Text: Give your opponent a 'Cursed!' card.
		//       While they hold it, they take 2 damage on their turn.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void CurseOfRafaam_LOE_007()
		{
			// TODO CurseOfRafaam_LOE_007 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Curse of Rafaam"));
		}

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
		// - TREASURE = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void DarkPeddler_LOE_023()
		{
			// TODO DarkPeddler_LOE_023 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Dark Peddler"));
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
		[TestMethod, Ignore]
		public void ReliquarySeeker_LOE_116()
		{
			// TODO ReliquarySeeker_LOE_116 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Reliquary Seeker"));
		}

	}

	[TestClass]
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
		[TestMethod, Ignore]
		public void ObsidianDestroyer_LOE_009()
		{
			// TODO ObsidianDestroyer_LOE_009 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.WARRIOR,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Obsidian Destroyer"));
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
		[TestMethod, Ignore]
		public void FierceMonkey_LOE_022()
		{
			// TODO FierceMonkey_LOE_022 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.WARRIOR,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Fierce Monkey"));
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
		[TestMethod, Ignore]
		public void CursedBlade_LOE_118()
		{
			// TODO CursedBlade_LOE_118 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.WARRIOR,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Cursed Blade"));
		}

	}

	[TestClass]
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
		[TestMethod]
		public void RenoJackson_LOE_011()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
                DeckPlayer1 = new List<Card>()
                {
                    Cards.FromName("Arcane Blast"),
                    Cards.FromName("Frostbolt"),
                    Cards.FromName("Arcane Intellect"),
                    Cards.FromName("Fireball"),
                    Cards.FromName("Polymorph"),
                    Cards.FromName("Blizzard"),
                    Cards.FromName("Flamestrike"),
                    Cards.FromName("Bloodmage Thalnos"),
                    Cards.FromName("Bloodmage Thalnos")
                },
				Player2HeroClass = CardClass.MAGE,
                DeckPlayer2 = new List<Card>()
                {
                    Cards.FromName("Arcane Blast"),
                    Cards.FromName("Frostbolt"),
                    Cards.FromName("Arcane Intellect"),
                    Cards.FromName("Fireball"),
                    Cards.FromName("Polymorph"),
                    Cards.FromName("Blizzard"),
                    Cards.FromName("Flamestrike"),
                    Cards.FromName("Bloodmage Thalnos"),
                    Cards.FromName("Acidic Swamp Ooze")
                },
                FillDecks = false,
                Shuffle = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
            var minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Alexstrasza"));
            game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion, game.CurrentOpponent.Hero));
            Assert.AreEqual(15, game.CurrentOpponent.Hero.Health);
            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var testCard1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Reno Jackson"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
            Assert.AreEqual(30, game.CurrentPlayer.Hero.Health);

            game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
            Assert.AreEqual(29, game.CurrentOpponent.Hero.Health);
            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Reno Jackson"));
            Assert.AreEqual(false, SelfCondition.IsNoDupeInDeck.Eval(testCard2));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
            Assert.AreEqual(29, game.CurrentPlayer.Hero.Health);

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
		// - TREASURE = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void JeweledScarab_LOE_029()
		{
			// TODO JeweledScarab_LOE_029 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Jeweled Scarab"));
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
		[TestMethod, Ignore]
		public void NagaSeaWitch_LOE_038()
		{
			// TODO NagaSeaWitch_LOE_038 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Naga Sea Witch"));
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
		// - TREASURE = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void GorillabotA3_LOE_039()
		{
			// TODO GorillabotA3_LOE_039 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Gorillabot A-3"));
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
		[TestMethod, Ignore]
		public void HugeToad_LOE_046()
		{
			// TODO HugeToad_LOE_046 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Huge Toad"));
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
		// - TREASURE = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void TombSpider_LOE_047()
		{
			// TODO TombSpider_LOE_047 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Tomb Spider"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_053] Djinni of Zephyrs - COST:5 [ATK:4/HP:6] 
		// - Set: loe, Rarity: epic
		// --------------------------------------------------------
		// Text: After you cast a spell on another friendly minion, cast a copy of it on this one.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void DjinniOfZephyrs_LOE_053()
		{
			// TODO DjinniOfZephyrs_LOE_053 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Djinni of Zephyrs"));
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
		[TestMethod, Ignore]
		public void AnubisathSentinel_LOE_061()
		{
			// TODO AnubisathSentinel_LOE_061 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Anubisath Sentinel"));
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
		[TestMethod, Ignore]
		public void FossilizedDevilsaur_LOE_073()
		{
			// TODO FossilizedDevilsaur_LOE_073 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Fossilized Devilsaur"));
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
		// - TREASURE = 1
		// --------------------------------------------------------
		[TestMethod]
		public void SirFinleyMrrgglton_LOE_076()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
            Assert.AreEqual(null, game.CurrentPlayer.Choice);
            var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sir Finley Mrrgglton"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            Assert.AreNotEqual(null, game.CurrentPlayer.Choice);
		    var choice = game.CurrentPlayer.Choice.Choices[0];
            game.Process(ChooseTask.Pick(game.CurrentPlayer, choice));
            Assert.AreEqual(choice, game.CurrentPlayer.Hero.Power.Card);

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
		[TestMethod, Ignore]
		public void BrannBronzebeard_LOE_077()
		{
			// TODO BrannBronzebeard_LOE_077 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Brann Bronzebeard"));
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
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void EliseStarseeker_LOE_079()
		{
			// TODO EliseStarseeker_LOE_079 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Elise Starseeker"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_086] Summoning Stone - COST:5 [ATK:0/HP:6] 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, summon a random minion of the same Cost.
		// --------------------------------------------------------
		[TestMethod]
		public void SummoningStone_LOE_086()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Summoning Stone"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            var spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostbolt"));
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, game.CurrentOpponent.Hero));
            Assert.AreEqual(2, game.CurrentPlayer.Board.Count);
            Assert.AreEqual(spell1.Card.Cost, game.CurrentPlayer.Board[1].Card.Cost);
            var minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sorcerer's Apprentice"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
            var spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Missiles"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell2));
            Assert.AreEqual(4, game.CurrentPlayer.Board.Count);
            Assert.AreEqual(0, game.CurrentPlayer.Board[3].Card.Cost);
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
		[TestMethod, Ignore]
		public void WobblingRunts_LOE_089()
		{
			// TODO WobblingRunts_LOE_089 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Wobbling Runts"));
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
		// - TREASURE = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void ArchThiefRafaam_LOE_092()
		{
			// TODO ArchThiefRafaam_LOE_092 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Arch-Thief Rafaam"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOE_107] Eerie Statue - COST:4 [ATK:7/HP:7] 
		// - Set: loe, Rarity: rare
		// --------------------------------------------------------
		// Text: Can’t attack unless it’s the only minion in the battlefield.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void EerieStatue_LOE_107()
		{
			// TODO EerieStatue_LOE_107 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Eerie Statue"));
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
		[TestMethod, Ignore]
		public void AncientShade_LOE_110()
		{
			// TODO AncientShade_LOE_110 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ancient Shade"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOEA10_3] Murloc Tinyfin - COST:0 [ATK:1/HP:1] 
		// - Race: murloc, Set: loe, Rarity: common
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void MurlocTinyfin_LOEA10_3()
		{
			// TODO MurlocTinyfin_LOEA10_3 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Murloc Tinyfin"));
		}

	}

}
