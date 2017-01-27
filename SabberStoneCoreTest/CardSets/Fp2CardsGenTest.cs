using System.Collections.Generic;
using SabberStoneCore.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SabberStoneCore.Actions;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.PlayerTasks;

namespace SabberStoneCoreTest.CardSets
{
    [TestClass]
    public class HeroesFp2Test
    {

        [TestClass]
        public class HeroPowersFp2Test
        {
            // ----------------------------------- HERO_POWER - NEUTRAL
            // [BRM_027pH] DIE, INSECTS! (*) - COST:2 
            // - Set: fp2, 
            // --------------------------------------------------------
            // Text: <b>Hero Power</b>
            //       Deal $8 damage to a random enemy. TWICE. *spelldmg
            // --------------------------------------------------------
            [TestMethod]
            public void DieInsects_BRM_027pH()
            {
                var game = new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.MAGE,
                    Player2HeroClass = CardClass.PRIEST,
                    FillDecks = true
                });
                game.StartGame();
                game.Player1.BaseMana = 10;
                game.Player2.BaseMana = 10;
                var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Majordomo Executus"));
                game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
                game.Process(EndTurnTask.Any(game.CurrentPlayer));
                var spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadow Word: Death"));
                game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, testCard));
                Assert.AreEqual(8, game.CurrentOpponent.Hero.Health);
                game.Process(EndTurnTask.Any(game.CurrentPlayer));
                game.Process(HeroPowerTask.Any(game.CurrentPlayer));
                Assert.AreEqual(22, game.CurrentOpponent.Hero.Health);
            }
        }

        [TestClass]
        public class DruidFp2Test
        {
            // ----------------------------------------- MINION - DRUID
            // [BRM_009] Volcanic Lumberer - COST:9 [ATK:7/HP:8] 
            // - Set: fp2, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Taunt</b>
            //       Costs (1) less for each minion that died this turn.
            // --------------------------------------------------------
            // GameTag:
            // - TAUNT = 1
            // --------------------------------------------------------
            [TestMethod, Ignore]
            public void VolcanicLumberer_BRM_009()
            {
                // TODO VolcanicLumberer_BRM_009 test
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
                //var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Volcanic Lumberer"));
            }

            // ----------------------------------------- MINION - DRUID
            // [BRM_010] Druid of the Flame - COST:3 [ATK:2/HP:2] 
            // - Set: fp2, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Choose One -</b> Transform into a 5/2 minion; or a 2/5 minion.
            // --------------------------------------------------------
            // GameTag:
            // - CHOOSE_ONE = 1
            // --------------------------------------------------------
            [TestMethod]
            public void DruidOfTheFlame_BRM_010()
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
                var testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Druid of the Flame"));
                game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1, 1));
                var testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Druid of the Flame"));
                game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2, 2));
                Assert.AreEqual(2, game.CurrentPlayer.Board.Count);
                Assert.AreEqual(5, ((Minion)game.CurrentPlayer.Board[0]).AttackDamage);
                Assert.AreEqual(2, ((Minion)game.CurrentPlayer.Board[0]).Health);
                Assert.AreEqual(2, ((Minion)game.CurrentPlayer.Board[1]).AttackDamage);
                Assert.AreEqual(5, ((Minion)game.CurrentPlayer.Board[1]).Health);
            }
        }

        [TestClass]
        public class HunterFp2Test
        {
            // ----------------------------------------- SPELL - HUNTER
            // [BRM_013] Quick Shot - COST:2 
            // - Set: fp2, Rarity: common
            // --------------------------------------------------------
            // Text: Deal $3 damage.
            //       If your hand is empty, draw a card. *spelldmg
            // --------------------------------------------------------
            // GameTag:
            // - AFFECTED_BY_SPELL_POWER = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            [TestMethod]
            public void QuickShot_BRM_013()
            {
                var game = new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.HUNTER,
                    DeckPlayer1 = new List<Card>()
                    {
                    },
                    Player2HeroClass = CardClass.HUNTER,
                    DeckPlayer2 = new List<Card>()
                    {
                        Cards.FromName("Alleycat"),
                        Cards.FromName("Alleycat"),
                        Cards.FromName("Kill Command"),
                        Cards.FromName("Kill Command"),
                        Cards.FromName("Unleash the Hounds"),
                        Cards.FromName("Unleash the Hounds"),
                        Cards.FromName("Houndmaster"),
                        Cards.FromName("Houndmaster"),
                        Cards.FromName("Savannah Highmane"),
                        Cards.FromName("Savannah Highmane"),
                    },
                    FillDecks = false
                });
                game.StartGame();
                game.Player1.BaseMana = 10;
                game.Player2.BaseMana = 10;
                var testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Quick Shot"));
                var testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Quick Shot"));
                game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard1, game.CurrentOpponent.Hero));
                Assert.AreEqual(27, game.CurrentOpponent.Hero.Health);
                Assert.AreEqual(2, game.CurrentPlayer.NumCardsDrawnThisTurn);
                Assert.AreEqual(15, game.CurrentPlayer.Hero.Health);
                game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard2, game.CurrentOpponent.Hero));
                Assert.AreEqual(2, game.CurrentPlayer.NumCardsDrawnThisTurn);
                Assert.AreEqual(24, game.CurrentOpponent.Hero.Health);
                Assert.AreEqual(-1, game.CurrentPlayer.Hero.Health);
            }

            // ---------------------------------------- MINION - HUNTER
            // [BRM_014] Core Rager - COST:4 [ATK:4/HP:4] 
            // - Race: beast, Set: fp2, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> If your hand is empty, gain +3/+3.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            [TestMethod]
            public void CoreRager_BRM_014()
            {
                var game = new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.HUNTER,
                    DeckPlayer1 = new List<Card>() { },
                    Player2HeroClass = CardClass.HUNTER,
                    FillDecks = false
                });
                game.StartGame();
                game.Player1.BaseMana = 10;
                game.Player2.BaseMana = 10;
                var testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Core Rager"));
                var testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Core Rager"));
                game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
                Assert.AreEqual(4, ((Minion)testCard1).Health);
                Assert.AreEqual(4, ((Minion)testCard1).AttackDamage);
                game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
                Assert.AreEqual(7, ((Minion)testCard2).Health);
                Assert.AreEqual(7, ((Minion)testCard2).AttackDamage);
            }
        }

        [TestClass]
        public class MageFp2Test
        {
            // ------------------------------------------- SPELL - MAGE
            // [BRM_003] Dragon's Breath - COST:5 
            // - Set: fp2, Rarity: common
            // --------------------------------------------------------
            // Text: Deal $4 damage. Costs (1) less for each minion that died this turn. *spelldmg
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            [TestMethod, Ignore]
            public void DragonsBreath_BRM_003()
            {
                // TODO DragonsBreath_BRM_003 test
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
                //var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Dragon's Breath"));
            }

            // ------------------------------------------ MINION - MAGE
            // [BRM_002] Flamewaker - COST:3 [ATK:2/HP:4] 
            // - Set: fp2, Rarity: rare
            // --------------------------------------------------------
            // Text: After you cast a spell, deal 2 damage randomly split among all enemies.
            // --------------------------------------------------------
            [TestMethod]
            public void Flamewaker_BRM_002()
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
                var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Flamewaker"));
                game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
                game.Process(EndTurnTask.Any(game.CurrentPlayer));
                var minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
                game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
                var minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
                game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
                game.Process(EndTurnTask.Any(game.CurrentPlayer));
                Assert.AreEqual(33, ((Minion)minion1).Health + ((Minion)minion2).Health + game.CurrentOpponent.Hero.Health);
                var spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
                game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, game.CurrentOpponent.Hero));
                Assert.AreEqual(25, 
                    (((Minion)minion1).IsDead ? 0 : ((Minion)minion1).Health) +
                    (((Minion)minion2).IsDead ? 0 : ((Minion)minion2).Health) + 
                    game.CurrentOpponent.Hero.Health);

            }
        }

        [TestClass]
        public class PaladinFp2Test
        {
            // ---------------------------------------- SPELL - PALADIN
            // [BRM_001] Solemn Vigil - COST:5 
            // - Set: fp2, Rarity: common
            // --------------------------------------------------------
            // Text: Draw 2 cards. Costs (1) less for each minion that died this turn.
            // --------------------------------------------------------
            [TestMethod, Ignore]
            public void SolemnVigil_BRM_001()
            {
                // TODO SolemnVigil_BRM_001 test
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
                //var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Solemn Vigil"));
            }

            // --------------------------------------- MINION - PALADIN
            // [BRM_018] Dragon Consort - COST:5 [ATK:5/HP:5] 
            // - Race: dragon, Set: fp2, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> The next Dragon you play costs (2) less.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            [TestMethod, Ignore]
            public void DragonConsort_BRM_018()
            {
                // TODO DragonConsort_BRM_018 test
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
                //var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Dragon Consort"));
            }
        }

        [TestClass]
        public class PriestFp2Test
        {
            // ----------------------------------------- SPELL - PRIEST
            // [BRM_017] Resurrect - COST:2 
            // - Set: fp2, Rarity: rare
            // --------------------------------------------------------
            // Text: Summon a random friendly minion that died this game.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_NUM_MINION_SLOTS = 1
            // - REQ_FRIENDLY_MINION_DIED_THIS_GAME = 0
            // --------------------------------------------------------
            [TestMethod]
            public void Resurrect_BRM_017()
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
                var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Resurrect"));
                Assert.AreEqual(5, game.CurrentPlayer.Hand.Count);
                game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
                Assert.AreEqual(5, game.CurrentPlayer.Hand.Count);
                var minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Injured Blademaster"));
                game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
                game.Process(EndTurnTask.Any(game.CurrentPlayer));
                var spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
                Assert.AreEqual(1, game.CurrentOpponent.Board.Count);
                game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, minion));
                Assert.AreEqual(0, game.CurrentOpponent.Board.Count);
                game.Process(EndTurnTask.Any(game.CurrentPlayer));
                game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
                Assert.AreEqual(1, game.CurrentPlayer.Board.Count);
                Assert.AreEqual(minion.Card.Id, game.CurrentPlayer.Board[0].Card.Id);
                Assert.AreEqual(7, ((Minion)game.CurrentPlayer.Board[0]).Health);
            }

            // ---------------------------------------- MINION - PRIEST
            // [BRM_004] Twilight Whelp - COST:1 [ATK:2/HP:1] 
            // - Race: dragon, Set: fp2, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> If you're holding a Dragon, gain +2 Health.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            [TestMethod]
            public void TwilightWhelp_BRM_004()
            {
                var game = new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.PRIEST,
                    DeckPlayer1 = new List<Card>()
                    {
                       Cards.FromName("Azure Drake")
                    },
                    Player2HeroClass = CardClass.PRIEST,
                    DeckPlayer2 = new List<Card>(),
                    FillDecks = false
                });
                game.StartGame();
                game.Player1.BaseMana = 10;
                game.Player2.BaseMana = 10;
                var testCard1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Twilight Whelp"));
                game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
                game.Process(EndTurnTask.Any(game.CurrentPlayer));
                var testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twilight Whelp"));
                game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
                Assert.AreEqual(3, ((Minion)testCard1).Health);
                Assert.AreEqual(1, ((Minion)testCard2).Health);
            }
        }

        [TestClass]
        public class RogueFp2Test
        {
            // ------------------------------------------ SPELL - ROGUE
            // [BRM_007] Gang Up - COST:2 
            // - Set: fp2, Rarity: common
            // --------------------------------------------------------
            // Text: Choose a minion. Shuffle 3 copies of it into your deck.
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            [TestMethod]
            public void GangUp_BRM_007()
            {
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
                var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gang Up"));
                var minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
                game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
                Assert.AreEqual(26, game.CurrentPlayer.Deck.Count);
                game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, minion));
                Assert.AreEqual(29, game.CurrentPlayer.Deck.Count);
            }

            // ----------------------------------------- MINION - ROGUE
            // [BRM_008] Dark Iron Skulker - COST:5 [ATK:4/HP:3] 
            // - Set: fp2, Rarity: rare
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Deal 2 damage to all undamaged enemy minions.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            [TestMethod, Ignore]
            public void DarkIronSkulker_BRM_008()
            {
                // TODO DarkIronSkulker_BRM_008 test
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
                //var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Dark Iron Skulker"));
            }
        }

        [TestClass]
        public class ShamanFp2Test
        {
            // ----------------------------------------- SPELL - SHAMAN
            // [BRM_011] Lava Shock - COST:2 
            // - Set: fp2, Rarity: rare
            // --------------------------------------------------------
            // Text: Deal $2 damage.
            //       Unlock your <b>Overloaded</b> Mana Crystals. *spelldmg
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_TARGET_TO_PLAY = 0
            // --------------------------------------------------------
            // RefTag:
            // - OVERLOAD = 1
            // --------------------------------------------------------
            [TestMethod, Ignore]
            public void LavaShock_BRM_011()
            {
                // TODO LavaShock_BRM_011 test
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
                //var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Lava Shock"));
            }

            // ---------------------------------------- MINION - SHAMAN
            // [BRM_012] Fireguard Destroyer - COST:4 [ATK:3/HP:6] 
            // - Set: fp2, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Gain 1-4 Attack. <b>Overload:</b> (1)
            // --------------------------------------------------------
            // GameTag:
            // - OVERLOAD = 1
            // - BATTLECRY = 1
            // - OVERLOAD_OWED = 1
            // --------------------------------------------------------
            [TestMethod, Ignore]
            public void FireguardDestroyer_BRM_012()
            {
                // TODO FireguardDestroyer_BRM_012 test
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
                //var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Fireguard Destroyer"));
            }
        }

        [TestClass]
        public class WarlockFp2Test
        {
            // ---------------------------------------- SPELL - WARLOCK
            // [BRM_005] Demonwrath - COST:3 
            // - Set: fp2, Rarity: rare
            // --------------------------------------------------------
            // Text: Deal $2 damage to all non-Demon minions. *spelldmg
            // --------------------------------------------------------
            // GameTag:
            // - AFFECTED_BY_SPELL_POWER = 1
            // --------------------------------------------------------
            [TestMethod, Ignore]
            public void Demonwrath_BRM_005()
            {
                // TODO Demonwrath_BRM_005 test
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
                //var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Demonwrath"));
            }

            // --------------------------------------- MINION - WARLOCK
            // [BRM_006] Imp Gang Boss - COST:3 [ATK:2/HP:4] 
            // - Race: demon, Set: fp2, Rarity: common
            // --------------------------------------------------------
            // Text: Whenever this minion takes damage, summon a 1/1 Imp.
            // --------------------------------------------------------
            [TestMethod, Ignore]
            public void ImpGangBoss_BRM_006()
            {
                // TODO ImpGangBoss_BRM_006 test
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
                //var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Imp Gang Boss"));
            }
        }

        [TestClass]
        public class WarriorFp2Test
        {
            // ---------------------------------------- SPELL - WARRIOR
            // [BRM_015] Revenge - COST:2 
            // - Set: fp2, Rarity: rare
            // --------------------------------------------------------
            // Text: Deal $1 damage to all minions. If you have 12 or less Health, deal $3 damage instead. *spelldmg
            // --------------------------------------------------------
            [TestMethod, Ignore]
            public void Revenge_BRM_015()
            {
                // TODO Revenge_BRM_015 test
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
                //var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Revenge"));
            }

            // --------------------------------------- MINION - WARRIOR
            // [BRM_016] Axe Flinger - COST:4 [ATK:2/HP:5] 
            // - Set: fp2, Rarity: common
            // --------------------------------------------------------
            // Text: Whenever this minion takes damage, deal 2 damage to the enemy hero.
            // --------------------------------------------------------
            [TestMethod, Ignore]
            public void AxeFlinger_BRM_016()
            {
                // TODO AxeFlinger_BRM_016 test
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
                //var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Axe Flinger"));
            }
        }

        [TestClass]
        public class NeutralFp2Test
        {
            // --------------------------------------- MINION - NEUTRAL
            // [BRM_019] Grim Patron - COST:5 [ATK:3/HP:3] 
            // - Set: fp2, Rarity: rare
            // --------------------------------------------------------
            // Text: Whenever this minion survives damage, summon another Grim Patron.
            // --------------------------------------------------------
            [TestMethod, Ignore]
            public void GrimPatron_BRM_019()
            {
                // TODO GrimPatron_BRM_019 test
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
                //var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Grim Patron"));
            }

            // --------------------------------------- MINION - NEUTRAL
            // [BRM_020] Dragonkin Sorcerer - COST:4 [ATK:3/HP:5] 
            // - Race: dragon, Set: fp2, Rarity: common
            // --------------------------------------------------------
            // Text: Whenever <b>you</b> target this minion with a spell, gain +1/+1.
            // --------------------------------------------------------
            [TestMethod, Ignore]
            public void DragonkinSorcerer_BRM_020()
            {
                // TODO DragonkinSorcerer_BRM_020 test
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
                //var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Dragonkin Sorcerer"));
            }

            // --------------------------------------- MINION - NEUTRAL
            // [BRM_022] Dragon Egg - COST:1 [ATK:0/HP:2] 
            // - Set: fp2, Rarity: rare
            // --------------------------------------------------------
            // Text: Whenever this minion takes damage, summon a 2/1 Whelp.
            // --------------------------------------------------------
            [TestMethod, Ignore]
            public void DragonEgg_BRM_022()
            {
                // TODO DragonEgg_BRM_022 test
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
                //var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Dragon Egg"));
            }

            // --------------------------------------- MINION - NEUTRAL
            // [BRM_024] Drakonid Crusher - COST:6 [ATK:6/HP:6] 
            // - Race: dragon, Set: fp2, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> If your opponent has 15 or less Health, gain +3/+3.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            [TestMethod, Ignore]
            public void DrakonidCrusher_BRM_024()
            {
                // TODO DrakonidCrusher_BRM_024 test
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
                //var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Drakonid Crusher"));
            }

            // --------------------------------------- MINION - NEUTRAL
            // [BRM_025] Volcanic Drake - COST:6 [ATK:6/HP:4] 
            // - Race: dragon, Set: fp2, Rarity: common
            // --------------------------------------------------------
            // Text: Costs (1) less for each minion that died this turn.
            // --------------------------------------------------------
            [TestMethod, Ignore]
            public void VolcanicDrake_BRM_025()
            {
                // TODO VolcanicDrake_BRM_025 test
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
                //var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Volcanic Drake"));
            }

            // --------------------------------------- MINION - NEUTRAL
            // [BRM_026] Hungry Dragon - COST:4 [ATK:5/HP:6] 
            // - Race: dragon, Set: fp2, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Summon a random 1-Cost minion for your opponent.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            [TestMethod, Ignore]
            public void HungryDragon_BRM_026()
            {
                // TODO HungryDragon_BRM_026 test
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
                //var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Hungry Dragon"));
            }

            // --------------------------------------- MINION - NEUTRAL
            // [BRM_027] Majordomo Executus - COST:9 [ATK:9/HP:7] 
            // - Set: fp2, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Deathrattle:</b> Replace your hero with Ragnaros, the Firelord.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - DEATHRATTLE = 1
            // --------------------------------------------------------
            [TestMethod]
            public void MajordomoExecutus_BRM_027()
            {
                var game = new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.MAGE,
                    Player2HeroClass = CardClass.PRIEST,
                    FillDecks = true
                });
                game.StartGame();
                game.Player1.BaseMana = 10;
                game.Player2.BaseMana = 10;
                var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Majordomo Executus"));
                game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
                game.Process(EndTurnTask.Any(game.CurrentPlayer));
                var spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadow Word: Death"));
                game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, testCard));
                Assert.AreEqual(8, game.CurrentOpponent.Hero.Health);
                game.Process(EndTurnTask.Any(game.CurrentPlayer));
                game.Process(HeroPowerTask.Any(game.CurrentPlayer));
                Assert.AreEqual(22, game.CurrentOpponent.Hero.Health);
            }

            // --------------------------------------- MINION - NEUTRAL
            // [BRM_028] Emperor Thaurissan - COST:6 [ATK:5/HP:5] 
            // - Set: fp2, Rarity: legendary
            // --------------------------------------------------------
            // Text: At the end of your turn, reduce the Cost of cards in your hand by (1).
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // --------------------------------------------------------
            [TestMethod, Ignore]
            public void EmperorThaurissan_BRM_028()
            {
                // TODO EmperorThaurissan_BRM_028 test
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
                //var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Emperor Thaurissan"));
            }

            // --------------------------------------- MINION - NEUTRAL
            // [BRM_029] Rend Blackhand - COST:7 [ATK:8/HP:4] 
            // - Set: fp2, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> If you're holding a Dragon, destroy a <b>Legendary</b> minion.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_MINION_TARGET = 0
            // - REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND = 0
            // - REQ_LEGENDARY_TARGET = 0
            // --------------------------------------------------------
            [TestMethod, Ignore]
            public void RendBlackhand_BRM_029()
            {
                // TODO RendBlackhand_BRM_029 test
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
                //var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Rend Blackhand"));
            }

            // --------------------------------------- MINION - NEUTRAL
            // [BRM_030] Nefarian - COST:9 [ATK:8/HP:8] 
            // - Race: dragon, Set: fp2, Rarity: legendary
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> Add 2 random spells to your hand <i>(from your opponent's class)</i>.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // - BATTLECRY = 1
            // --------------------------------------------------------
            [TestMethod, Ignore]
            public void Nefarian_BRM_030()
            {
                // TODO Nefarian_BRM_030 test
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
                //var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Nefarian"));
            }

            // --------------------------------------- MINION - NEUTRAL
            // [BRM_031] Chromaggus - COST:8 [ATK:6/HP:8] 
            // - Race: dragon, Set: fp2, Rarity: legendary
            // --------------------------------------------------------
            // Text: Whenever you draw a card, put another copy into your hand.
            // --------------------------------------------------------
            // GameTag:
            // - ELITE = 1
            // --------------------------------------------------------
            [TestMethod, Ignore]
            public void Chromaggus_BRM_031()
            {
                // TODO Chromaggus_BRM_031 test
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
                //var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Chromaggus"));
            }

            // --------------------------------------- MINION - NEUTRAL
            // [BRM_033] Blackwing Technician - COST:3 [ATK:2/HP:4] 
            // - Fac: neutral, Set: fp2, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> If you're holding a Dragon, gain +1/+1.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            [TestMethod]
            public void BlackwingTechnician_BRM_033()
            {
                var game = new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.PRIEST,
                    DeckPlayer1 = new List<Card>()
                    {
                       Cards.FromName("Azure Drake")
                    },
                    Player2HeroClass = CardClass.PRIEST,
                    DeckPlayer2 = new List<Card>(),
                    FillDecks = false
                });
                game.StartGame();
                game.Player1.BaseMana = 10;
                game.Player2.BaseMana = 10;
                var testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blackwing Technician"));
                game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
                game.Process(EndTurnTask.Any(game.CurrentPlayer));
                var testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blackwing Technician"));
                game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
                Assert.AreEqual(3, ((Minion)testCard1).AttackDamage);
                Assert.AreEqual(5, ((Minion)testCard1).Health);
                Assert.AreEqual(2, ((Minion)testCard2).AttackDamage);
                Assert.AreEqual(4, ((Minion)testCard2).Health);
            }

            // --------------------------------------- MINION - NEUTRAL
            // [BRM_034] Blackwing Corruptor - COST:5 [ATK:5/HP:4] 
            // - Fac: neutral, Set: fp2, Rarity: common
            // --------------------------------------------------------
            // Text: <b>Battlecry:</b> If you're holding a Dragon, deal 3 damage.
            // --------------------------------------------------------
            // GameTag:
            // - BATTLECRY = 1
            // --------------------------------------------------------
            // PlayReq:
            // - REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND = 0
            // --------------------------------------------------------
            [TestMethod]
            public void BlackwingCorruptor_BRM_034()
            {
                var game = new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.PRIEST,
                    DeckPlayer1 = new List<Card>()
                    {
                       Cards.FromName("Azure Drake"),
                       Cards.FromName("Blackwing Corruptor"),
                       Cards.FromName("Stonetusk Boar"),
                       Cards.FromName("Stonetusk Boar"),
                       Cards.FromName("Bloodfen Raptor"),
                       Cards.FromName("Bloodfen Raptor")
                    },
                    Player2HeroClass = CardClass.PRIEST,
                    DeckPlayer2 = new List<Card>()
                    {
                        Cards.FromName("Blackwing Corruptor"),
                        Cards.FromName("Stonetusk Boar"),
                        Cards.FromName("Stonetusk Boar"),
                        Cards.FromName("Bloodfen Raptor"),
                        Cards.FromName("Bloodfen Raptor")
                    },
                    FillDecks = false,
                    Shuffle = false
                });
                game.StartGame();
                game.Player1.BaseMana = 10;
                game.Player2.BaseMana = 10;
                var testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blackwing Corruptor"));
                game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard1, game.CurrentOpponent.Hero));
                game.Process(EndTurnTask.Any(game.CurrentPlayer));
                var testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blackwing Corruptor"));
                game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
                Assert.AreEqual(1, game.Player1.Board.Count);
                Assert.AreEqual(1, game.Player2.Board.Count);
                Assert.AreEqual(30, game.Player1.Hero.Health);
                Assert.AreEqual(27, game.Player2.Hero.Health);
            }
        }
    }
}