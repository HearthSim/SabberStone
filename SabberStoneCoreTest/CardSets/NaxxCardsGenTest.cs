using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Linq;
using System.Collections.Generic;
using SabberStoneCore.Config;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.PlayerTasks;

using Generic = SabberStoneCore.Actions.Generic;

namespace SabberStoneCoreTest.CardSets
{
    [TestClass]
    public class DruidNaxxTest
    {
        // ------------------------------------------ SPELL - DRUID
        // [FP1_019] Poison Seeds - COST:4 
        // - Set: naxx, Rarity: common
        // --------------------------------------------------------
        // Text: Destroy all minions and summon 2/2 Treants to replace them.
        // --------------------------------------------------------
        [TestMethod, Ignore]
        public void PoisonSeeds_FP1_019()
        {
            // TODO PoisonSeeds_FP1_019 test
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
            //var testCard = game.CurrentPlayer.Draw(Cards.FromName("Poison Seeds"));
        }
    }

    [TestClass]
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
        [TestMethod, Ignore]
        public void Webspinner_FP1_011()
        {
            // TODO Webspinner_FP1_011 test
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
            //var testCard = game.CurrentPlayer.Draw(Cards.FromName("Webspinner"));
        }
    }

    [TestClass]
    public class MageNaxxTest
    {
        // ------------------------------------------- SPELL - MAGE
        // [FP1_018] Duplicate - COST:3 
        // - Set: naxx, Rarity: common
        // --------------------------------------------------------
        // Text: <b>Secret:</b> When a friendly minion dies, put 2 copies of it into your hand.
        // --------------------------------------------------------
        // GameTag:
        // - SECRET_OR_QUEST = 1
        // --------------------------------------------------------
        [TestMethod, Ignore]
        public void Duplicate_FP1_018()
        {
            // TODO Duplicate_FP1_018 test
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
            //var testCard = game.CurrentPlayer.Draw(Cards.FromName("Duplicate"));
        }
    }

    [TestClass]
    public class PaladinNaxxTest
    {
        // ---------------------------------------- SPELL - PALADIN
        // [FP1_020] Avenge - COST:1 
        // - Set: naxx, Rarity: common
        // --------------------------------------------------------
        // Text: <b>Secret:</b> When one of your minions dies, give a random friendly minion +3/+2.
        // --------------------------------------------------------
        // GameTag:
        // - SECRET_OR_QUEST = 1
        // --------------------------------------------------------
        [TestMethod, Ignore]
        public void Avenge_FP1_020()
        {
            // TODO Avenge_FP1_020 test
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
            //var testCard = game.CurrentPlayer.Draw(Cards.FromName("Avenge"));
        }
    }

    [TestClass]
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
        [TestMethod, Ignore]
        public void DarkCultist_FP1_023()
        {
            // TODO DarkCultist_FP1_023 test
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
            //var testCard = game.CurrentPlayer.Draw(Cards.FromName("Dark Cultist"));
        }
    }

    [TestClass]
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
        // RefTag:
        // - POISONOUS = 1
        // --------------------------------------------------------
        [TestMethod, Ignore]
        public void AnubarAmbusher_FP1_026()
        {
            // TODO AnubarAmbusher_FP1_026 test
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
            //var testCard = game.CurrentPlayer.Draw(Cards.FromName("Anub'ar Ambusher"));
        }
    }

    [TestClass]
    public class ShamanNaxxTest
    {
        // ----------------------------------------- SPELL - SHAMAN
        // [FP1_025] Reincarnate - COST:2 
        // - Set: naxx, Rarity: common
        // --------------------------------------------------------
        // Text: Destroy a minion, then return it to life with full Health.
        // --------------------------------------------------------
        // PlayReq:
        // - REQ_MINION_TARGET = 0
        // - REQ_TARGET_TO_PLAY = 0
        // --------------------------------------------------------
        [TestMethod, Ignore]
        public void Reincarnate_FP1_025()
        {
            // TODO Reincarnate_FP1_025 test
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
            //var testCard = game.CurrentPlayer.Draw(Cards.FromName("Reincarnate"));
        }
    }

    [TestClass]
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
        [TestMethod, Ignore]
        public void Voidcaller_FP1_022()
        {
            // TODO Voidcaller_FP1_022 test
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
            //var testCard = game.CurrentPlayer.Draw(Cards.FromName("Voidcaller"));
        }
    }

    [TestClass]
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
        [TestMethod, Ignore]
        public void DeathsBite_FP1_021()
        {
            // TODO DeathsBite_FP1_021 test
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
            //var testCard = game.CurrentPlayer.Draw(Cards.FromName("Death's Bite"));
        }
    }

    [TestClass]
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
        [TestMethod, Ignore]
        public void ZombieChow_FP1_001()
        {
            // TODO ZombieChow_FP1_001 test
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
            //var testCard = game.CurrentPlayer.Draw(Cards.FromName("Zombie Chow"));
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
        [TestMethod, Ignore]
        public void HauntedCreeper_FP1_002()
        {
            // TODO HauntedCreeper_FP1_002 test
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
            //var testCard = game.CurrentPlayer.Draw(Cards.FromName("Haunted Creeper"));
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
        [TestMethod, Ignore]
        public void EchoingOoze_FP1_003()
        {
            // TODO EchoingOoze_FP1_003 test
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
            //var testCard = game.CurrentPlayer.Draw(Cards.FromName("Echoing Ooze"));
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
        // - SECRET_OR_QUEST = 1
        // --------------------------------------------------------
        [TestMethod, Ignore]
        public void MadScientist_FP1_004()
        {
            // TODO MadScientist_FP1_004 test
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
            //var testCard = game.CurrentPlayer.Draw(Cards.FromName("Mad Scientist"));
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
        [TestMethod, Ignore]
        public void ShadeOfNaxxramas_FP1_005()
        {
            // TODO ShadeOfNaxxramas_FP1_005 test
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
            //var testCard = game.CurrentPlayer.Draw(Cards.FromName("Shade of Naxxramas"));
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
        [TestMethod]
        public void NerubianEgg_FP1_007()
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
            var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nerubian Egg"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, testCard));
            Assert.AreEqual(1, game.CurrentOpponent.Board.Count);
            Assert.AreEqual("FP1_007t", game.CurrentOpponent.Board[0].Card.Id);
        }

        // --------------------------------------- MINION - NEUTRAL
        // [FP1_008] Spectral Knight - COST:5 [ATK:4/HP:6] 
        // - Set: naxx, Rarity: common
        // --------------------------------------------------------
        // Text: Can't be targeted by spells or Hero Powers.
        // --------------------------------------------------------
        // GameTag:
        // - CANT_BE_TARGETED_BY_ABILITIES = 1
        // - CANT_BE_TARGETED_BY_HERO_POWERS = 1
        // --------------------------------------------------------
        [TestMethod, Ignore]
        public void SpectralKnight_FP1_008()
        {
            // TODO SpectralKnight_FP1_008 test
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
            //var testCard = game.CurrentPlayer.Draw(Cards.FromName("Spectral Knight"));
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
        [TestMethod, Ignore]
        public void Deathlord_FP1_009()
        {
            // TODO Deathlord_FP1_009 test
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
            //var testCard = game.CurrentPlayer.Draw(Cards.FromName("Deathlord"));
        }

        // --------------------------------------- MINION - NEUTRAL
        // [FP1_010] Maexxna - COST:6 [ATK:2/HP:8] 
        // - Race: beast, Set: naxx, Rarity: legendary
        // --------------------------------------------------------
        // Text: Destroy any minion damaged by this minion.
        // --------------------------------------------------------
        // GameTag:
        // - ELITE = 1
        // - POISONOUS = 1
        // --------------------------------------------------------
        [TestMethod, Ignore]
        public void Maexxna_FP1_010()
        {
            // TODO Maexxna_FP1_010 test
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
            //var testCard = game.CurrentPlayer.Draw(Cards.FromName("Maexxna"));
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
        [TestMethod, Ignore]
        public void SludgeBelcher_FP1_012()
        {
            // TODO SludgeBelcher_FP1_012 test
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
            //var testCard = game.CurrentPlayer.Draw(Cards.FromName("Sludge Belcher"));
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
        [TestMethod, Ignore]
        public void Kelthuzad_FP1_013()
        {
            // TODO Kelthuzad_FP1_013 test
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
            //var testCard = game.CurrentPlayer.Draw(Cards.FromName("Kel'Thuzad"));
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
        [TestMethod, Ignore]
        public void Stalagg_FP1_014()
        {
            // TODO Stalagg_FP1_014 test
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
            //var testCard = game.CurrentPlayer.Draw(Cards.FromName("Stalagg"));
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
        [TestMethod, Ignore]
        public void Feugen_FP1_015()
        {
            // TODO Feugen_FP1_015 test
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
            //var testCard = game.CurrentPlayer.Draw(Cards.FromName("Feugen"));
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
        [TestMethod, Ignore]
        public void WailingSoul_FP1_016()
        {
            // TODO WailingSoul_FP1_016 test
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
            //var testCard = game.CurrentPlayer.Draw(Cards.FromName("Wailing Soul"));
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
        [TestMethod, Ignore]
        public void NerubarWeblord_FP1_017()
        {
            // TODO NerubarWeblord_FP1_017 test
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
            //var testCard = game.CurrentPlayer.Draw(Cards.FromName("Nerub'ar Weblord"));
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
        [TestMethod, Ignore]
        public void UnstableGhoul_FP1_024()
        {
            // TODO UnstableGhoul_FP1_024 test
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
            //var testCard = game.CurrentPlayer.Draw(Cards.FromName("Unstable Ghoul"));
        }

        // --------------------------------------- MINION - NEUTRAL
        // [FP1_027] Stoneskin Gargoyle - COST:3 [ATK:1/HP:4] 
        // - Set: naxx, Rarity: common
        // --------------------------------------------------------
        // Text: At the start of your turn, restore this minion to full Health.
        // --------------------------------------------------------
        [TestMethod, Ignore]
        public void StoneskinGargoyle_FP1_027()
        {
            // TODO StoneskinGargoyle_FP1_027 test
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
            //var testCard = game.CurrentPlayer.Draw(Cards.FromName("Stoneskin Gargoyle"));
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
        [TestMethod, Ignore]
        public void Undertaker_FP1_028()
        {
            // TODO Undertaker_FP1_028 test
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
            //var testCard = game.CurrentPlayer.Draw(Cards.FromName("Undertaker"));
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
        [TestMethod, Ignore]
        public void DancingSwords_FP1_029()
        {
            // TODO DancingSwords_FP1_029 test
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
            //var testCard = game.CurrentPlayer.Draw(Cards.FromName("Dancing Swords"));
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
        [TestMethod, Ignore]
        public void Loatheb_FP1_030()
        {
            // TODO Loatheb_FP1_030 test
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
            //var testCard = game.CurrentPlayer.Draw(Cards.FromName("Loatheb"));
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
        [TestMethod, Ignore]
        public void BaronRivendare_FP1_031()
        {
            // TODO BaronRivendare_FP1_031 test
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
            //var testCard = game.CurrentPlayer.Draw(Cards.FromName("Baron Rivendare"));
        }
    }
}