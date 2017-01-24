using System.Collections.Generic;
using SabberStoneCore.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.PlayerTasks;
using Generic = SabberStoneCore.Actions.Generic;

namespace SabberStoneUnitTest.CardSets
{
	[TestClass]
	public class HeroesKaraTest
	{
	}

	[TestClass]
	public class HeroPowersKaraTest
	{
	}

	[TestClass]
	public class DruidKaraTest
	{
		// ------------------------------------------ SPELL - DRUID
		// [KAR_075] Moonglade Portal - COST:6 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: Restore #6 Health. Summon a random
		//       6-Cost minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod]
		public void MoongladePortal_KAR_075()
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
		    game.Player1.Hero.Damage = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Moonglade Portal"));
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, game.CurrentPlayer.Hero));
            Assert.AreEqual(26, game.CurrentPlayer.Hero.Health);
            Assert.AreEqual(6, game.CurrentPlayer.Board[0].Card.Cost);
        }

		// ----------------------------------------- MINION - DRUID
		// [KAR_065] Menagerie Warden - COST:6 [ATK:5/HP:5] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Choose a friendly Beast. Summon a_copy of it.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_WITH_RACE = 20
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[TestMethod]
		public void MenagerieWarden_KAR_065()
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
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Menagerie Warden"));
            var minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
            game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard, minion));
            Assert.AreEqual(3, game.CurrentPlayer.Board.Count);
            Assert.AreEqual(minion.Card.Id, game.CurrentPlayer.Board[0].Card.Id);
            Assert.AreEqual(minion.Card.Id, game.CurrentPlayer.Board[2].Card.Id);
        }

		// ----------------------------------------- MINION - DRUID
		// [KAR_300] Enchanted Raven - COST:1 [ATK:2/HP:2] 
		// - Race: beast, Set: kara, Rarity: common
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void EnchantedRaven_KAR_300()
		{
			// TODO EnchantedRaven_KAR_300 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Enchanted Raven"));
		}

	}

	[TestClass]
	public class HunterKaraTest
	{
		// ----------------------------------------- SPELL - HUNTER
		// [KAR_004] Cat Trick - COST:2 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Secret:</b> After your opponent casts a spell, summon a 4/2 Panther with <b>Stealth</b>.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		// RefTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void CatTrick_KAR_004()
		{
			// TODO CatTrick_KAR_004 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Cat Trick"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [KAR_005] Kindly Grandmother - COST:2 [ATK:1/HP:1] 
		// - Race: beast, Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a 3/2 Big Bad Wolf.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[TestMethod]
		public void KindlyGrandmother_KAR_005()
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
            var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kindly Grandmother"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, testCard));
            Assert.AreEqual(1, game.CurrentOpponent.Board.Count);
            Assert.AreEqual("KAR_005a", game.CurrentOpponent.Board[0].Card.Id);
        }

		// ---------------------------------------- MINION - HUNTER
		// [KAR_006] Cloaked Huntress - COST:3 [ATK:3/HP:4] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: Your <b>Secrets</b> cost (0).
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[TestMethod]
		public void CloakedHuntress_KAR_006()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
                DeckPlayer1 = new List<Card>()
                {
                    Cards.FromName("Snake Trap")
                },
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Cloaked Huntress"));
            Assert.AreEqual(2, game.CurrentPlayer.Hand[0].Cost);
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            Assert.AreEqual(0, game.CurrentPlayer.Hand[0].Cost);
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadow Word: Pain"));
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, testCard));
            Assert.AreEqual(2, game.CurrentOpponent.Hand[0].Cost);
        }

	}

	[TestClass]
	public class MageKaraTest
	{
		// ------------------------------------------- SPELL - MAGE
		// [KAR_076] Firelands Portal - COST:7 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $5 damage. Summon a random
		//       5-Cost minion. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod]
		public void FirelandsPortal_KAR_076()
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
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Firelands Portal"));
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, game.CurrentOpponent.Hero));
            Assert.AreEqual(25, game.CurrentOpponent.Hero.Health);
            Assert.AreEqual(1, game.CurrentPlayer.Board.Count);
            Assert.AreEqual(5, game.CurrentPlayer.Board[0].Card.Cost);
        }

		// ------------------------------------------ MINION - MAGE
		// [KAR_009] Babbling Book - COST:1 [ATK:1/HP:1] 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add a random Mage spell to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[TestMethod]
		public void BabblingBook_KAR_009()
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
			var testCard1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Babbling Book"));
            var testCard2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Babbling Book"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard1));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard2));
            Assert.AreEqual(CardClass.MAGE, game.CurrentPlayer.Hand[4].Card.Class);
            Assert.AreEqual(CardClass.MAGE, game.CurrentPlayer.Hand[5].Card.Class);
            Assert.AreEqual(CardType.SPELL, game.CurrentPlayer.Hand[4].Card.Type);
            Assert.AreEqual(CardType.SPELL, game.CurrentPlayer.Hand[5].Card.Type);
        }

		// ------------------------------------------ MINION - MAGE
		// [KAR_092] Medivh's Valet - COST:2 [ATK:2/HP:3] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you control a <b>Secret</b>, deal 3 damage.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_SECRETS = 1
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void MedivhsValet_KAR_092()
		{
			// TODO MedivhsValet_KAR_092 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Medivh's Valet"));
		}

	}

	[TestClass]
	public class PaladinKaraTest
	{
		// ---------------------------------------- SPELL - PALADIN
		// [KAR_077] Silvermoon Portal - COST:4 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: Give a minion +2/+2. Summon a random
		//       2-Cost minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod]
		public void SilvermoonPortal_KAR_077()
		{
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
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Silvermoon Portal"));
            var minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, minion));
            Assert.AreEqual(3, ((Minion)minion).AttackDamage);
            Assert.AreEqual(3, ((Minion)minion).Health);
            Assert.AreEqual(2, game.CurrentPlayer.Board.Count);
        }

		// --------------------------------------- MINION - PALADIN
		// [KAR_010] Nightbane Templar - COST:3 [ATK:2/HP:3] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding a Dragon, summon two 1/1 Whelps.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[TestMethod]
		public void NightbaneTemplar_KAR_010()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
                DeckPlayer1 = new List<Card>()
                {
                    Cards.FromName("Azure Drake"),
                },
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = true,
                Shuffle = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Nightbane Templar"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            Assert.AreEqual(3, game.CurrentPlayer.Board.Count);
		}

		// --------------------------------------- MINION - PALADIN
		// [KAR_057] Ivory Knight - COST:6 [ATK:4/HP:4] 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> <b>Discover</b> a spell.
		//       Restore Health to your hero
		//       equal to its Cost.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TREASURE = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void IvoryKnight_KAR_057()
		{
			// TODO IvoryKnight_KAR_057 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ivory Knight"));
		}

	}

	[TestClass]
	public class PriestKaraTest
	{
		// ----------------------------------------- SPELL - PRIEST
		// [KAR_013] Purify - COST:2 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Silence</b> a friendly minion. Draw a card.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - SILENCE = 1
		// --------------------------------------------------------
		[TestMethod]
		public void Purify_KAR_013()
		{
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
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Purify"));
            var minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
            Assert.AreEqual(true, ((Minion)minion).HasDeathrattle);
            Assert.AreEqual(3, game.CurrentPlayer.NumCardsDrawnThisTurn);
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, minion));
            Assert.AreEqual(false, ((Minion)minion).HasDeathrattle);
            Assert.AreEqual(4, game.CurrentPlayer.NumCardsDrawnThisTurn);
        }

		// ---------------------------------------- MINION - PRIEST
		// [KAR_035] Priest of the Feast - COST:4 [ATK:3/HP:6] 
		// - Fac: neutral, Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, restore 3 Health to
		//       your hero.
		// --------------------------------------------------------
		[TestMethod]
		public void PriestOfTheFeast_KAR_035()
		{
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
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
		    game.CurrentPlayer.Hero.Damage = 3;
            var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Priest of the Feast"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            Assert.AreEqual(27, game.CurrentPlayer.Hero.Health);
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, game.CurrentPlayer.Hand[4]));
            Assert.AreEqual(30, game.CurrentPlayer.Hero.Health);
        }

		// ---------------------------------------- MINION - PRIEST
		// [KAR_204] Onyx Bishop - COST:5 [ATK:3/HP:4] 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a friendly minion that died this game.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[TestMethod]
		public void OnyxBishop_KAR_204()
		{
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.PRIEST,
                Player2HeroClass = CardClass.MAGE,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;
            var testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Onyx Bishop"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
            var minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Injured Blademaster"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
            Assert.AreEqual(2, game.CurrentOpponent.Board.Count);
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, minion));
            Assert.AreEqual(1, game.CurrentOpponent.Board.Count);
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Onyx Bishop"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard2));
            Assert.AreEqual(3, game.CurrentPlayer.Board.Count);
            Assert.AreEqual(minion.Card.Id, game.CurrentPlayer.Board[2].Card.Id);
            Assert.AreEqual(7, ((Minion)game.CurrentPlayer.Board[2]).Health);
        }

	}

	[TestClass]
	public class RogueKaraTest
	{
		// ----------------------------------------- MINION - ROGUE
		// [KAR_069] Swashburglar - COST:1 [ATK:1/HP:1] 
		// - Race: pirate, Fac: neutral, Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add a random class card to your hand <i>(from your opponent's class).</i>
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[TestMethod]
		public void Swashburglar_KAR_069()
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
            var testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Swashburglar"));
            var testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Swashburglar"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard1));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard2));
            Assert.AreEqual(CardClass.MAGE, game.CurrentPlayer.Hand[4].Card.Class);
            Assert.AreEqual(CardClass.MAGE, game.CurrentPlayer.Hand[5].Card.Class);
        }

		// ----------------------------------------- MINION - ROGUE
		// [KAR_070] Ethereal Peddler - COST:5 [ATK:5/HP:6] 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If you're holding
		//       any non-Rogue class cards,
		//       _reduce their Cost by (2).
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void EtherealPeddler_KAR_070()
		{
			// TODO EtherealPeddler_KAR_070 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ethereal Peddler"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [KAR_094] Deadly Fork - COST:3 [ATK:3/HP:2] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Add a 3/2 weapon to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void DeadlyFork_KAR_094()
		{
			// TODO DeadlyFork_KAR_094 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Deadly Fork"));
		}

	}

	[TestClass]
	public class ShamanKaraTest
	{
		// ----------------------------------------- SPELL - SHAMAN
		// [KAR_073] Maelstrom Portal - COST:2 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal_$1_damage to_all_enemy_minions. Summon_a_random
		//       1-Cost minion. *spelldmg
		// --------------------------------------------------------
		[TestMethod]
		public void MaelstromPortal_KAR_073()
		{
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
            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Injured Blademaster"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stonetusk Boar"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var spell1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Maelstrom Portal"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell1));

            Assert.AreEqual(1, game.CurrentOpponent.Board.Count);
            Assert.AreEqual(1, game.CurrentPlayer.Board.Count);

            var minion3 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bloodmage Thalnos"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));

            var spell2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Maelstrom Portal"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell2));

            Assert.AreEqual(0, game.CurrentOpponent.Board.Count);
            Assert.AreEqual(3, game.CurrentPlayer.Board.Count);
		    Assert.AreEqual(1, ((Minion)game.CurrentPlayer.Board[0]).Cost);
            Assert.AreEqual(2, ((Minion)game.CurrentPlayer.Board[1]).Cost);
            Assert.AreEqual(1, ((Minion)game.CurrentPlayer.Board[2]).Cost);
        }

		// ---------------------------------------- MINION - SHAMAN
		// [KAR_021] Wicked Witchdoctor - COST:4 [ATK:3/HP:4] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, summon a random basic_Totem.
		// --------------------------------------------------------
		[TestMethod]
		public void WickedWitchdoctor_KAR_021()
		{
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
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wicked Witchdoctor"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, game.CurrentPlayer.Hand[4]));
		    Assert.AreEqual(2, game.CurrentPlayer.Board.Count);
            Assert.AreEqual(Race.TOTEM, game.CurrentPlayer.Board[1].Card.Race);
        }

		// ---------------------------------------- WEAPON - SHAMAN
		// [KAR_063] Spirit Claws - COST:1 [ATK:1/HP:0] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: [x]Has +2 Attack while you
		//       have <b>Spell Damage</b>.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 3
		// --------------------------------------------------------
		// RefTag:
		// - SPELLPOWER = 1
		// --------------------------------------------------------
		[TestMethod]
		public void SpiritClaws_KAR_063()
		{
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
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Spirit Claws"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
            Assert.AreEqual(1, game.CurrentPlayer.Hero.Weapon.AttackDamage);
            var minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dalaran Mage"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
            Assert.AreEqual(3, game.CurrentPlayer.Hero.Weapon.AttackDamage);
            var spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lightning Bolt"));
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, minion));
            Assert.AreEqual(1, game.CurrentPlayer.Hero.Weapon.AttackDamage);
        }

	}

	[TestClass]
	public class WarlockKaraTest
	{
		// ---------------------------------------- SPELL - WARLOCK
		// [KAR_025] Kara Kazham! - COST:5 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: Summon a 1/1 Candle, 2/2 Broom, and 3/3 Teapot.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[TestMethod]
		public void KaraKazham_KAR_025()
		{
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
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Kara Kazham!"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
            Assert.AreEqual(3, game.CurrentPlayer.Board.Count);
		}

		// --------------------------------------- MINION - WARLOCK
		// [KAR_089] Malchezaar's Imp - COST:1 [ATK:1/HP:3] 
		// - Race: demon, Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever you discard a card, draw a card.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void MalchezaarsImp_KAR_089()
		{
			// TODO MalchezaarsImp_KAR_089 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Malchezaar's Imp"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [KAR_205] Silverware Golem - COST:3 [ATK:3/HP:3] 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: If you discard this minion, summon it.
		// --------------------------------------------------------
		// GameTag:
		// - InvisibleDeathrattle = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void SilverwareGolem_KAR_205()
		{
			// TODO SilverwareGolem_KAR_205 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Silverware Golem"));
		}

	}

	[TestClass]
	public class WarriorKaraTest
	{
		// ---------------------------------------- SPELL - WARRIOR
		// [KAR_026] Protect the King! - COST:3 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: For each enemy minion, summon a 1/1 Pawn with <b>Taunt</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// - REQ_MINIMUM_ENEMY_MINIONS = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void ProtectTheKing_KAR_026()
		{
			// TODO ProtectTheKing_KAR_026 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Protect the King!"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [KAR_091] Ironforge Portal - COST:5 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: Gain 4 Armor.
		//       Summon a random
		//       4-Cost minion.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void IronforgePortal_KAR_091()
		{
			// TODO IronforgePortal_KAR_091 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ironforge Portal"));
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [KAR_028] Fool's Bane - COST:5 [ATK:3/HP:0] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: Unlimited attacks each turn. Can't attack heroes.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 4
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void FoolsBane_KAR_028()
		{
			// TODO FoolsBane_KAR_028 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Fool's Bane"));
		}

	}

	[TestClass]
	public class NeutralKaraTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [KAR_011] Pompous Thespian - COST:2 [ATK:3/HP:2] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void PompousThespian_KAR_011()
		{
			// TODO PompousThespian_KAR_011 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Pompous Thespian"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_029] Runic Egg - COST:1 [ATK:0/HP:2] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Draw a card.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void RunicEgg_KAR_029()
		{
			// TODO RunicEgg_KAR_029 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Runic Egg"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_030a] Pantry Spider - COST:3 [ATK:1/HP:3] 
		// - Race: beast, Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a
		//       1/3 Spider.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void PantrySpider_KAR_030a()
		{
			// TODO PantrySpider_KAR_030a test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Pantry Spider"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_033] Book Wyrm - COST:6 [ATK:3/HP:6] 
		// - Race: dragon, Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding a Dragon, destroy an enemy minion with 3 or less Attack.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_MAX_ATTACK = 3
		// - REQ_NONSELF_TARGET = 0
		// - REQ_ENEMY_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[TestMethod]
		public void BookWyrm_KAR_033()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
                DeckPlayer2 = new List<Card>()
                {
                    Cards.FromName("Azure Drake")
                },
                FillDecks = true,
                Shuffle = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Book Wyrm"));
            game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard, minion));

            game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard, minion));
            Assert.AreEqual(true, minion.ToBeDestroyed);
        }

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_036] Arcane Anomaly - COST:1 [ATK:2/HP:1] 
		// - Fac: neutral, Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, give this minion
		//       +1 Health.
		// --------------------------------------------------------
		[TestMethod]
		public void ArcaneAnomaly_KAR_036()
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
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Anomaly"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, game.CurrentPlayer.Hand[4]));
            Assert.AreEqual(2, ((Minion)testCard).Health);
        }

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_037] Avian Watcher - COST:5 [ATK:3/HP:6] 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you control a <b>Secret</b>, gain +1/+1
		//       and <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// - SECRET = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void AvianWatcher_KAR_037()
		{
			// TODO AvianWatcher_KAR_037 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Avian Watcher"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_041] Moat Lurker - COST:6 [ATK:3/HP:3] 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy a minion. <b>Deathrattle:</b> Resummon it.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void MoatLurker_KAR_041()
		{
			// TODO MoatLurker_KAR_041 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Moat Lurker"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_044] Moroes - COST:3 [ATK:1/HP:1] 
		// - Set: kara, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Stealth</b>
		//       At the end of your turn, summon a 1/1 Steward.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - STEALTH = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Moroes_KAR_044()
		{
			// TODO Moroes_KAR_044 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Moroes"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_061] The Curator - COST:7 [ATK:4/HP:6] 
		// - Race: mechanical, Set: kara, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Battlecry:</b> Draw a Beast, Dragon, and Murloc from your deck.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[TestMethod]
		public void TheCurator_KAR_061()
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
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("The Curator"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_062] Netherspite Historian - COST:2 [ATK:1/HP:3] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding a Dragon, <b>Discover</b>
		//       a Dragon.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TREASURE = 1
		// --------------------------------------------------------
		[TestMethod]
		public void NetherspiteHistorian_KAR_062()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
                DeckPlayer1 = new List<Card>()
                {
                    Cards.FromName("Azure Drake")
                },
				Player2HeroClass = CardClass.MAGE,
				FillDecks = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Netherspite Historian"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            Assert.AreEqual(Race.DRAGON, game.CurrentPlayer.Choice.Choices[0].Race);
            Assert.AreEqual(Race.DRAGON, game.CurrentPlayer.Choice.Choices[1].Race);
            Assert.AreEqual(Race.DRAGON, game.CurrentPlayer.Choice.Choices[2].Race);
            Assert.AreEqual(1, game.CurrentPlayer.Hand.Count);
            game.Process(ChooseTask.Pick(game.CurrentPlayer, game.CurrentPlayer.Choice.Choices[0]));
            Assert.AreEqual(2, game.CurrentPlayer.Hand.Count);
        }

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_095] Zoobot - COST:3 [ATK:3/HP:3] 
		// - Race: mechanical, Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a random friendly Beast, Dragon, and Murloc +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Zoobot_KAR_095()
		{
			// TODO Zoobot_KAR_095 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Zoobot"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_096] Prince Malchezaar - COST:5 [ATK:5/HP:6] 
		// - Race: demon, Set: kara, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]When the game starts,
		//       add 5 extra <b>Legendary</b>
		//       minions to your deck.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void PrinceMalchezaar_KAR_096()
		{
			// TODO PrinceMalchezaar_KAR_096 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Prince Malchezaar"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_097] Medivh, the Guardian - COST:8 [ATK:7/HP:7] 
		// - Set: kara, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Equip Atiesh, Greatstaff of the Guardian.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void MedivhTheGuardian_KAR_097()
		{
			// TODO MedivhTheGuardian_KAR_097 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Medivh, the Guardian"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_114] Barnes - COST:4 [ATK:3/HP:4] 
		// - Set: kara, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 1/1 copy of a random minion in your deck.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[TestMethod]
		public void Barnes_KAR_114()
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
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Barnes"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
            Assert.AreEqual(2, game.CurrentPlayer.Board.Count);
            Assert.AreEqual(1, ((Minion)game.CurrentPlayer.Board[1]).AttackDamage);
            Assert.AreEqual(1, ((Minion)game.CurrentPlayer.Board[1]).Health);
        }

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_702] Menagerie Magician - COST:5 [ATK:4/HP:4] 
		// - Fac: neutral, Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a random friendly Beast, Dragon, and Murloc +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void MenagerieMagician_KAR_702()
		{
			// TODO MenagerieMagician_KAR_702 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Menagerie Magician"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_710] Arcanosmith - COST:4 [ATK:3/HP:2] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 0/5 minion with <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Arcanosmith_KAR_710()
		{
			// TODO Arcanosmith_KAR_710 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Arcanosmith"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_711] Arcane Giant - COST:12 [ATK:8/HP:8] 
		// - Set: kara, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]Costs (1) less for each spell
		//       you've cast this game.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void ArcaneGiant_KAR_711()
		{
			// TODO ArcaneGiant_KAR_711 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Arcane Giant"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_712] Violet Illusionist - COST:3 [ATK:4/HP:3] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: During your turn, your hero is <b>Immune</b>.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		// RefTag:
		// - IMMUNE = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void VioletIllusionist_KAR_712()
		{
			// TODO VioletIllusionist_KAR_712 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Violet Illusionist"));
		}

	}

}
