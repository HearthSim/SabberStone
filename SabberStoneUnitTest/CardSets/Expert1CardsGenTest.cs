using System.Collections.Generic;
using System.Diagnostics;
using HearthDb.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SabberStone.Config;
using SabberStone.Model;
using SabberStone.Tasks.PlayerTasks;
using Generic = SabberStone.Actions.Generic;

namespace SabberStoneUnitTest.CardSets
{
	[TestClass]
	public class HeroesExpert1Test
	{
		// ----------------------------------------- HERO - WARLOCK
		// [EX1_323h] Lord Jaraxxus (*) - COST:0 [ATK:0/HP:15] 
		// - Race: demon, Fac: neutral, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// GameTag:
		// - OVERKILL = 1178
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void LordJaraxxus_EX1_323h()
		{
			// TODO LordJaraxxus_EX1_323h test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Lord Jaraxxus"));
		}

	}

	[TestClass]
	public class HeroPowersExpert1Test
	{
		// ------------------------------------ HERO_POWER - PRIEST
		// [EX1_625t] Mind Spike (*) - COST:2 
		// - Set: expert1, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $2 damage. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod]
		public void MindSpike_EX1_625t()
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
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Shadowform"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
		    game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
            Assert.AreEqual(28, game.CurrentOpponent.Hero.Health);
		}

		// ------------------------------------ HERO_POWER - PRIEST
		// [EX1_625t2] Mind Shatter (*) - COST:2 
		// - Set: expert1, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $3 damage. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod]
		public void MindShatter_EX1_625t2()
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
            var testCard1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Shadowform"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard1));
            game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
            Assert.AreEqual(28, game.CurrentOpponent.Hero.Health);
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var testCard2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Shadowform"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard2));
            game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
            Assert.AreEqual(25, game.CurrentOpponent.Hero.Health);
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
		[TestMethod, Ignore]
		public void Inferno_EX1_tk33()
		{
			// TODO Inferno_EX1_tk33 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("INFERNO!"));
		}

	}

	[TestClass]
	public class DruidExpert1Test
	{
		// ------------------------------------------ SPELL - DRUID
		// [EX1_154] Wrath - COST:2 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Choose One -</b> Deal $3 damage to a minion; or $1 damage and draw a card. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Wrath_EX1_154()
		{
			// TODO Wrath_EX1_154 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Wrath"));
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
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void MarkOfNature_EX1_155()
		{
			// TODO MarkOfNature_EX1_155 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Mark of Nature"));
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
		[TestMethod]
		public void SoulOfTheForest_EX1_158()
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
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Soul of the Forest"));
            var minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(HeroPowerTask.Any(game.CurrentPlayer));
            game.Process(HeroAttackTask.Any(game.CurrentPlayer, minion1));
            Assert.AreEqual(1, game.CurrentOpponent.Board.Count);
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
		[TestMethod]
		public void PowerOfTheWild_EX1_160()
		{
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.DRUID,
                Player2HeroClass = CardClass.PRIEST,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stonetusk Boar"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

            Assert.AreEqual(1, game.CurrentPlayer.Board.Count);

            var spell1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Power of the Wild"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell1, 1));

            Assert.AreEqual(2, game.CurrentPlayer.Board.Count);

            var spell2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Power of the Wild"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell2, 2));

            Assert.AreEqual(2, game.CurrentPlayer.Board.Count);
            Assert.AreEqual(4, ((Minion)game.CurrentPlayer.Board[1]).AttackDamage);
            Assert.AreEqual(3, ((Minion)game.CurrentPlayer.Board[1]).Health);
            Assert.AreEqual(2, ((Minion)minion1).AttackDamage);
            Assert.AreEqual(2, ((Minion)minion1).Health);
        }

		// ------------------------------------------ SPELL - DRUID
		// [EX1_161] Naturalize - COST:1 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Destroy a minion.
		//       Your opponent draws 2_cards.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Naturalize_EX1_161()
		{
			// TODO Naturalize_EX1_161 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Naturalize"));
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
		[TestMethod, Ignore]
		public void Nourish_EX1_164()
		{
			// TODO Nourish_EX1_164 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Nourish"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [EX1_570] Bite - COST:4 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Give your hero +4_Attack this turn and 4 Armor.
		// --------------------------------------------------------
		[TestMethod]
		public void Bite_EX1_570()
		{
			// TODO Bite_EX1_570 test
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
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bite"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
            game.Process(HeroPowerTask.Any(game.CurrentPlayer));
            game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
            Assert.AreEqual(25, game.CurrentOpponent.Hero.Health);
            Assert.AreEqual(5, game.CurrentPlayer.Hero.Armor);
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
		[TestMethod]
		public void ForceOfNature_EX1_571()
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
            var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Force of Nature"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
            Assert.AreEqual(3, game.CurrentPlayer.Board.Count);
        }

		// ------------------------------------------ SPELL - DRUID
		// [EX1_578] Savagery - COST:1 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal damage equal to your hero's Attack to a minion. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - AFFECTED_BY_SPELL_POWER = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Savagery_EX1_578()
		{
			// TODO Savagery_EX1_578 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Savagery"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [NEW1_007] Starfall - COST:5 
		// - Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Choose One -</b> Deal $5 damage to a minion; or $2 damage to all enemy minions. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Starfall_NEW1_007()
		{
			// TODO Starfall_NEW1_007 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Starfall"));
		}

		// ----------------------------------------- MINION - DRUID
		// [EX1_165] Druid of the Claw - COST:5 [ATK:4/HP:4] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Choose One -</b> <b>Charge</b>; or +2 Health and <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// - CHARGE = 1
		// --------------------------------------------------------
		[TestMethod]
		public void DruidOfTheClaw_EX1_165()
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
			var testCard1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Druid of the Claw"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1, 1));
            Assert.AreEqual(1, game.CurrentPlayer.Board.Count);
            Assert.AreEqual(false, ((Minion)game.CurrentPlayer.Board[0]).HasTaunt);
            Assert.AreEqual(true, ((Minion)game.CurrentPlayer.Board[0]).HasCharge);
            game.Process(MinionAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.Board[0], game.CurrentOpponent.Hero));

            var testCard2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Druid of the Claw"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2, 2));
            Assert.AreEqual(2, game.CurrentPlayer.Board.Count);
            Assert.AreEqual(true, ((Minion)game.CurrentPlayer.Board[1]).HasTaunt);
            Assert.AreEqual(6, ((Minion)game.CurrentPlayer.Board[1]).Health);

            Assert.AreEqual(26, game.CurrentOpponent.Hero.Health);
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
		[TestMethod, Ignore]
		public void KeeperOfTheGrove_EX1_166()
		{
			// TODO KeeperOfTheGrove_EX1_166 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Keeper of the Grove"));
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
		[TestMethod]
		public void AncientOfWar_EX1_178()
		{
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.DRUID,
                Player2HeroClass = CardClass.PRIEST,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ancient of War"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1, 1));
            game.CurrentPlayer.UsedMana = 0;
            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ancient of War"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2, 2));
            game.CurrentPlayer.UsedMana = 0;

            Assert.AreEqual(2, game.CurrentPlayer.Board.Count);
            Assert.AreEqual(5, ((Minion)minion1).AttackDamage);
            Assert.AreEqual(10, ((Minion)minion1).Health);
            Assert.AreEqual(true, ((Minion)minion1).HasTaunt);

            Assert.AreEqual(10, ((Minion)minion2).AttackDamage);
            Assert.AreEqual(5, ((Minion)minion2).Health);
            Assert.AreEqual(false, ((Minion)minion2).HasTaunt);
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
		[TestMethod]
		public void Cenarius_EX1_573()
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
            var testCard1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Cenarius"));
            var testCard2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Cenarius"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1, 2));
            Assert.AreEqual(3, game.CurrentPlayer.Board.Count);
		    game.CurrentPlayer.UsedMana = 0;
            Assert.AreEqual(2, ((Minion)game.CurrentPlayer.Board[1]).Health);
            Assert.AreEqual(2, ((Minion)game.CurrentPlayer.Board[1]).AttackDamage);
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2, 1));
            Assert.AreEqual(4, game.CurrentPlayer.Board.Count);
            Assert.AreEqual(4, ((Minion)game.CurrentPlayer.Board[1]).Health);
            Assert.AreEqual(4, ((Minion)game.CurrentPlayer.Board[1]).AttackDamage);
            Assert.AreEqual(10, ((Minion)game.CurrentPlayer.Board[0]).Health);
            Assert.AreEqual(7, ((Minion)game.CurrentPlayer.Board[0]).AttackDamage);
            Assert.AreEqual(8, ((Minion)game.CurrentPlayer.Board[3]).Health);
            Assert.AreEqual(5, ((Minion)game.CurrentPlayer.Board[3]).AttackDamage);
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
		[TestMethod]
		public void AncientOfLore_NEW1_008()
		{
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.WARLOCK,
                Player2HeroClass = CardClass.PRIEST,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            game.Player1.Hero.Damage = 5;

            Assert.AreEqual(25, game.Player1.Hero.Health);

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ancient of Lore"));
            game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion1, game.Player1.Hero, 2));
            game.Player1.UsedMana = 0;
            Assert.AreEqual(30, game.Player1.Hero.Health);

            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ancient of Lore"));

            Assert.AreEqual(3, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);

            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2, 1));

            Assert.AreEqual(4, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);
        }

	}

	[TestClass]
	public class HunterExpert1Test
	{
		// ----------------------------------------- SPELL - HUNTER
		// [EX1_533] Misdirection - COST:2 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When an enemy attacks your hero, instead it attacks another random character.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Misdirection_EX1_533()
		{
			// TODO Misdirection_EX1_533 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Misdirection"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [EX1_537] Explosive Shot - COST:5 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $5 damage to a minion and $2 damage to adjacent ones. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod]
		public void ExplosiveShot_EX1_537()
		{
			// TODO ExplosiveShot_EX1_537 test
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
            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sen'jin Shieldmasta"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));
		    game.CurrentPlayer.UsedMana = 0;
            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sen'jin Shieldmasta"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));
            game.CurrentPlayer.UsedMana = 0;
            var minion3 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sen'jin Shieldmasta"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion3));
            game.CurrentPlayer.UsedMana = 0;
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Explosive Shot"));
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, minion2));
            Assert.AreEqual(3, ((Minion)minion1).Health);
            Assert.AreEqual(true, ((Minion)minion2).IsDead);
            Assert.AreEqual(3, ((Minion)minion3).Health);
        }

		// ----------------------------------------- SPELL - HUNTER
		// [EX1_538] Unleash the Hounds - COST:3 
		// - Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: For each enemy minion, summon a 1/1 Hound with <b>Charge</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// - REQ_MINIMUM_ENEMY_MINIONS = 1
		// --------------------------------------------------------
		// RefTag:
		// - CHARGE = 1
		// --------------------------------------------------------
		[TestMethod]
		public void UnleashTheHounds_EX1_538()
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
            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sen'jin Shieldmasta"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));
            game.CurrentPlayer.UsedMana = 0;
            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sen'jin Shieldmasta"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));
            game.CurrentPlayer.UsedMana = 0;
            var minion3 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sen'jin Shieldmasta"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion3));
            game.CurrentPlayer.UsedMana = 0;
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Unleash the Hounds"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
            Assert.AreEqual(3, game.CurrentOpponent.Board.Count);
            Assert.AreEqual(3, game.CurrentPlayer.Board.Count);
            Assert.AreEqual(true, ((Minion)game.CurrentPlayer.Board[0]).CanAttack);
            Assert.AreEqual(true, ((Minion)game.CurrentPlayer.Board[1]).CanAttack);
            Assert.AreEqual(true, ((Minion)game.CurrentPlayer.Board[2]).CanAttack);
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
		[TestMethod, Ignore]
		public void Flare_EX1_544()
		{
			// TODO Flare_EX1_544 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Flare"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [EX1_549] Bestial Wrath - COST:1 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Give a friendly Beast +2 Attack and <b>Immune</b> this turn.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_WITH_RACE = 20
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - IMMUNE = 1
		// --------------------------------------------------------
		[TestMethod]
		public void BestialWrath_EX1_549()
		{
			// TODO BestialWrath_EX1_549 test
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
			var testCard1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bestial Wrath"));
            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bloodfen Raptor"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Oasis Snapjaw"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
		    game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard1, minion1));
            game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion1, minion2));
            Assert.AreEqual(2, ((Minion)minion1).Health);
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion1, minion2));
            Assert.AreEqual(true, ((Minion)minion1).IsDead);
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
		[TestMethod]
		public void SnakeTrap_EX1_554()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.ROGUE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bloodfen Raptor"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
            var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Snake Trap"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
            Assert.AreEqual(1, game.CurrentPlayer.Secrets.Count);
            Assert.AreEqual(1, game.CurrentPlayer.Board.Triggers.Count);
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(HeroPowerTask.Any(game.CurrentPlayer));
            game.Process(HeroAttackTask.Any(game.CurrentPlayer, minion1));
            Assert.AreEqual(4, game.CurrentOpponent.Board.Count);
            Assert.AreEqual(0, game.CurrentOpponent.Secrets.Count);
            Assert.AreEqual(0, game.CurrentOpponent.Board.Triggers.Count);
        }

        // ----------------------------------------- SPELL - HUNTER
        // [EX1_609] Snipe - COST:2 
        // - Fac: neutral, Set: expert1, Rarity: common
        // --------------------------------------------------------
        // Text: <b>Secret:</b> After your opponent plays a minion, deal $4 damage to it. *spelldmg
        // --------------------------------------------------------
        // GameTag:
        // - SECRET = 1
        // --------------------------------------------------------
        [TestMethod]
		public void Snipe_EX1_609()
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
            var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Snipe"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
            Assert.AreEqual(1, game.CurrentPlayer.Secrets.Count);
            Assert.AreEqual(1, game.CurrentOpponent.Board.Triggers.Count);
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Boulderfist Ogre"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
            Assert.AreEqual(3, ((Minion)minion1).Health);
            Assert.AreEqual(0, game.CurrentOpponent.Secrets.Count);
            Assert.AreEqual(0, game.CurrentPlayer.Board.Triggers.Count);

        }

        // ----------------------------------------- SPELL - HUNTER
        // [EX1_610] Explosive Trap - COST:2 
        // - Fac: neutral, Set: expert1, Rarity: common
        // --------------------------------------------------------
        // Text: <b>Secret:</b> When your hero is attacked, deal $2 damage to all enemies. *spelldmg
        // --------------------------------------------------------
        // GameTag:
        // - SECRET = 1
        // --------------------------------------------------------
        [TestMethod]
		public void ExplosiveTrap_EX1_610()
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
            var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Explosive Trap"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
            Assert.AreEqual(1, game.CurrentPlayer.Secrets.Count);
            Assert.AreEqual(1, game.CurrentPlayer.Hero.Triggers.Count);
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Boulderfist Ogre"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stonetusk Boar"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
            game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion2, game.CurrentOpponent.Hero));
            Assert.AreEqual(5, ((Minion)minion1).Health);
            Assert.AreEqual(true, ((Minion)minion2).IsDead);
            Assert.AreEqual(0, game.CurrentOpponent.Secrets.Count);
            Assert.AreEqual(0, game.CurrentOpponent.Hero.Triggers.Count);
            Assert.AreEqual(28, game.CurrentPlayer.Hero.Health);
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
		[TestMethod, Ignore]
		public void FreezingTrap_EX1_611()
		{
			// TODO FreezingTrap_EX1_611 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Freezing Trap"));
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
		[TestMethod]
		public void DeadlyShot_EX1_617()
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
            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stonetusk Boar"));
            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stonetusk Boar"));
            var minion3 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stonetusk Boar"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Deadly Shot"));
            Assert.AreEqual(3, game.CurrentOpponent.Board.Count);
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
            Assert.AreEqual(2, game.CurrentOpponent.Board.Count);
        }

		// ---------------------------------------- MINION - HUNTER
		// [EX1_531] Scavenging Hyena - COST:2 [ATK:2/HP:2] 
		// - Race: beast, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever a friendly Beast dies, gain +2/+1.
		// --------------------------------------------------------
		[TestMethod]
		public void ScavengingHyena_EX1_531()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Scavenging Hyena"));
            var minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
            var minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Raider"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            Assert.AreEqual(2, ((Minion)testCard).AttackDamage);
            Assert.AreEqual(2, ((Minion)testCard).Health);
            game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));
            Assert.AreEqual(4, ((Minion)testCard).AttackDamage);
            Assert.AreEqual(3, ((Minion)testCard).Health);
            var spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Explosion"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));
            Assert.AreEqual(4, ((Minion)testCard).AttackDamage);
            Assert.AreEqual(2, ((Minion)testCard).Health);
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
		[TestMethod, Ignore]
		public void SavannahHighmane_EX1_534()
		{
			// TODO SavannahHighmane_EX1_534 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Savannah Highmane"));
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
		[TestMethod, Ignore]
		public void KingKrush_EX1_543()
		{
			// TODO KingKrush_EX1_543 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("King Krush"));
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
		[TestMethod, Ignore]
		public void GladiatorsLongbow_DS1_188()
		{
			// TODO GladiatorsLongbow_DS1_188 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Gladiator's Longbow"));
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
		[TestMethod]
		public void EaglehornBow_EX1_536()
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
            var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Eaglehorn Bow"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
            var spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bear Trap"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
            Assert.AreEqual(0, game.CurrentOpponent.Board.Count);
            Assert.AreEqual(2, game.CurrentOpponent.Hero.Weapon.Durability);
            game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion, game.CurrentOpponent.Hero));
            Assert.AreEqual(1, game.CurrentOpponent.Board.Count);
            Assert.AreEqual(true, ((Minion)game.CurrentOpponent.Board[0]).HasTaunt);
            Assert.AreEqual(3, game.CurrentOpponent.Hero.Weapon.Durability);

        }

	}

	[TestClass]
	public class MageExpert1Test
	{
		// ------------------------------------------- SPELL - MAGE
		// [CS2_028] Blizzard - COST:6 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $2 damage to all enemy minions and <b>Freeze</b> them. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[TestMethod]
		public void Blizzard_CS2_028()
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
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Blizzard"));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Boulderfist Ogre"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stonetusk Boar"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
            Assert.AreEqual(5, ((Minion)minion1).Health);
            Assert.AreEqual(true, ((Minion)minion1).IsFrozen);
            Assert.AreEqual(true, ((Minion)minion2).IsDead);
        }

		// ------------------------------------------- SPELL - MAGE
		// [CS2_031] Ice Lance - COST:1 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Freeze</b> a character. If it was already <b>Frozen</b>, deal $4 damage instead. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod]
		public void IceLance_CS2_031()
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
			var testCard1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ice Lance"));
            var testCard2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ice Lance"));
            Assert.AreEqual(false, game.CurrentOpponent.Hero.IsFrozen);
            Assert.AreEqual(30, game.CurrentOpponent.Hero.Health);
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard1, game.CurrentOpponent.Hero));
            Assert.AreEqual(true, game.CurrentOpponent.Hero.IsFrozen);
            Assert.AreEqual(30, game.CurrentOpponent.Hero.Health);
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard2, game.CurrentOpponent.Hero));
            Assert.AreEqual(26, game.CurrentOpponent.Hero.Health);
        }

		// ------------------------------------------- SPELL - MAGE
		// [EX1_275] Cone of Cold - COST:4 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Freeze</b> a minion and the minions next to it, and deal $1 damage to them. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void ConeOfCold_EX1_275()
		{
			// TODO ConeOfCold_EX1_275 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Cone of Cold"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [EX1_279] Pyroblast - COST:10 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Deal $10 damage. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Pyroblast_EX1_279()
		{
			// TODO Pyroblast_EX1_279 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Pyroblast"));
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
		[TestMethod, Ignore]
		public void Counterspell_EX1_287()
		{
			// TODO Counterspell_EX1_287 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Counterspell"));
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
		[TestMethod, Ignore]
		public void IceBarrier_EX1_289()
		{
			// TODO IceBarrier_EX1_289 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ice Barrier"));
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
		[TestMethod]
		public void MirrorEntity_EX1_294()
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
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Mirror Entity"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
            Assert.AreEqual(1, game.CurrentOpponent.Board.Count);
        }

		// ------------------------------------------- SPELL - MAGE
		// [EX1_295] Ice Block - COST:3 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When your hero takes fatal damage, prevent it and become <b>Immune</b> this turn.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		// RefTag:
		// - IMMUNE = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void IceBlock_EX1_295()
		{
			// TODO IceBlock_EX1_295 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ice Block"));
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
		[TestMethod, Ignore]
		public void Vaporize_EX1_594()
		{
			// TODO Vaporize_EX1_594 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Vaporize"));
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
		[TestMethod, Ignore]
		public void Spellbender_tt_010()
		{
			// TODO Spellbender_tt_010 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Spellbender"));
		}

		// ------------------------------------------ MINION - MAGE
		// [EX1_274] Ethereal Arcanist - COST:4 [ATK:3/HP:3] 
		// - Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: If you control a <b>Secret</b> at_the end of your turn, gain +2/+2.
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void EtherealArcanist_EX1_274()
		{
			// TODO EtherealArcanist_EX1_274 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ethereal Arcanist"));
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
		[TestMethod]
		public void ArchmageAntonidas_EX1_559()
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
            var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Archmage Antonidas"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            Assert.AreEqual(6, game.CurrentPlayer.Hand.Count);
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, game.CurrentPlayer.Hand[4]));
            Assert.AreEqual(6, game.CurrentPlayer.Hand.Count);
            Assert.AreEqual("CS2_029", game.CurrentPlayer.Hand[5].Card.Id);
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
		[TestMethod]
		public void SorcerersApprentice_EX1_608()
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
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sorcerer's Apprentice"));
            var spell1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Pyroblast"));
            var spell2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Fireball"));
            Assert.AreEqual(10, spell1.Cost);
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            Assert.AreEqual(9, spell1.Cost);
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, testCard));
            Assert.AreEqual(10, spell1.Cost);
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
		[TestMethod, Ignore]
		public void KirinTorMage_EX1_612()
		{
			// TODO KirinTorMage_EX1_612 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Kirin Tor Mage"));
		}

		// ------------------------------------------ MINION - MAGE
		// [NEW1_012] Mana Wyrm - COST:1 [ATK:1/HP:3] 
		// - Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, gain +1 Attack.
		// --------------------------------------------------------
		[TestMethod]
		public void ManaWyrm_NEW1_012()
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
            var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mana Wyrm"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            Assert.AreEqual(6, game.CurrentPlayer.Hand.Count);
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, game.CurrentPlayer.Hand[4]));
            Assert.AreEqual(5, game.CurrentPlayer.Hand.Count);
            Assert.AreEqual(2, ((Minion)testCard).AttackDamage);
        }

	}

	[TestClass]
	public class PaladinExpert1Test
	{
		// ---------------------------------------- SPELL - PALADIN
		// [EX1_130] Noble Sacrifice - COST:1 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When an enemy attacks, summon a 2/1 Defender as the new target.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void NobleSacrifice_EX1_130()
		{
			// TODO NobleSacrifice_EX1_130 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Noble Sacrifice"));
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
		[TestMethod, Ignore]
		public void EyeForAnEye_EX1_132()
		{
			// TODO EyeForAnEye_EX1_132 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Eye for an Eye"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [EX1_136] Redemption - COST:1 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When one of your minions dies, return it to life with 1 Health.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[TestMethod]
		public void Redemption_EX1_136()
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
            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Injured Blademaster"));
            var spell1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Redemption"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell1));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var spell2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Fireball"));
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, minion1));
            Assert.AreEqual(true, ((Minion)minion1).IsDead);
            Assert.AreEqual(1, ((Minion)game.CurrentOpponent.Board[0]).Health);
        }

		// ---------------------------------------- SPELL - PALADIN
		// [EX1_349] Divine Favor - COST:3 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Draw cards until you have as many in hand as your opponent.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void DivineFavor_EX1_349()
		{
			// TODO DivineFavor_EX1_349 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Divine Favor"));
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
		[TestMethod, Ignore]
		public void LayOnHands_EX1_354()
		{
			// TODO LayOnHands_EX1_354 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Lay on Hands"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [EX1_355] Blessed Champion - COST:5 
		// - Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Double a minion's Attack.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void BlessedChampion_EX1_355()
		{
			// TODO BlessedChampion_EX1_355 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Blessed Champion"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [EX1_363] Blessing of Wisdom - COST:1 
		// - Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Choose a minion. Whenever it attacks, draw a card.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void BlessingOfWisdom_EX1_363()
		{
			// TODO BlessingOfWisdom_EX1_363 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Blessing of Wisdom"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [EX1_365] Holy Wrath - COST:5 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Draw a card and deal_damage equal to_its Cost. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - AFFECTED_BY_SPELL_POWER = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod]
		public void HolyWrath_EX1_365()
		{
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.PALADIN,
                Player2HeroClass = CardClass.MAGE,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            var spell = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Holy Wrath"));

            Assert.AreEqual(2, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);

            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, game.CurrentOpponent.Hero));

            Assert.AreEqual(3, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);
            Assert.AreEqual(30 - game.CurrentPlayer.Hand[4].Card.Cost, game.CurrentOpponent.Hero.Health);
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
		[TestMethod]
		public void Repentance_EX1_379()
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
            var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Repentance"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
            Assert.AreEqual(1, ((Minion)minion).Health);
        }

		// ---------------------------------------- SPELL - PALADIN
		// [EX1_384] Avenging Wrath - COST:6 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Deal $8 damage randomly split among all enemies. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - ImmuneToSpellpower = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void AvengingWrath_EX1_384()
		{
			// TODO AvengingWrath_EX1_384 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Avenging Wrath"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [EX1_619] Equality - COST:2 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Change the Health of ALL minions to 1.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Equality_EX1_619()
		{
			// TODO Equality_EX1_619 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Equality"));
		}

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
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_NONSELF_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[TestMethod]
		public void ArgentProtector_EX1_362()
		{
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.PALADIN,
                Player2HeroClass = CardClass.MAGE,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Argent Protector"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Argent Protector"));
            game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion2, minion1));

            Assert.AreEqual(true, ((Minion)minion1).HasDivineShield);
            Assert.AreEqual(false, ((Minion)minion2).HasDivineShield);

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));

            Assert.AreEqual(false, ((Minion)minion1).HasDivineShield);
            Assert.AreEqual(((Minion)minion1).Card[GameTag.HEALTH], ((Minion)minion1).Health);
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
		// - REQ_MINION_TARGET = 0
		// - REQ_ENEMY_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void AldorPeacekeeper_EX1_382()
		{
			// TODO AldorPeacekeeper_EX1_382 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Aldor Peacekeeper"));
		}

		// --------------------------------------- MINION - PALADIN
		// [EX1_383] Tirion Fordring - COST:8 [ATK:6/HP:6] 
		// - Fac: neutral, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Divine Shield</b>. <b>Taunt</b>. <b>Deathrattle:</b> Equip a 5/3_Ashbringer.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - TAUNT = 1
		// - DIVINE_SHIELD = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void TirionFordring_EX1_383()
		{
			// TODO TirionFordring_EX1_383 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Tirion Fordring"));
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
		[TestMethod]
		public void SwordOfJustice_EX1_366()
		{
            var game =
                new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.PALADIN,
                    Player2HeroClass = CardClass.PALADIN,
                    FillDecks = true
                });
            game.StartGame();
            game.CurrentPlayer.BaseMana = 10;

            var weapon = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sword of Justice"));
            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Dragonling Mechanic"));
            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Dragonling Mechanic"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, weapon));

            Assert.AreEqual(5, game.CurrentPlayer.Hero.Weapon.Durability);

            game.CurrentPlayer.UsedMana = 0;

            game.Process(HeroPowerTask.Any(game.CurrentPlayer));
            Assert.AreEqual(2, ((Minion)game.CurrentPlayer.Board[0]).AttackDamage);
            Assert.AreEqual(2, ((Minion)game.CurrentPlayer.Board[0]).Health);
            Assert.AreEqual(4, game.CurrentPlayer.Hero.Weapon.Durability);
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
            Assert.AreEqual(3, ((Minion)minion1).AttackDamage);
            Assert.AreEqual(5, ((Minion)minion1).Health);
            Assert.AreEqual(3, ((Minion)game.CurrentPlayer.Board[2]).AttackDamage);
            Assert.AreEqual(2, ((Minion)game.CurrentPlayer.Board[2]).Health);
            Assert.AreEqual(2, game.CurrentPlayer.Hero.Weapon.Durability);
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
            Assert.AreEqual(3, ((Minion)minion2).AttackDamage);
            Assert.AreEqual(5, ((Minion)minion2).Health);
            Assert.AreEqual(3, ((Minion)game.CurrentPlayer.Board[4]).AttackDamage);
            Assert.AreEqual(2, ((Minion)game.CurrentPlayer.Board[4]).Health);
            Assert.AreEqual(null, game.CurrentPlayer.Hero.Weapon);
        }

	}

	[TestClass]
	public class PriestExpert1Test
	{
		// ----------------------------------------- SPELL - PRIEST
		// [CS1_129] Inner Fire - COST:1 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Change a minion's Attack to be equal to its Health.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void InnerFire_CS1_129()
		{
			// TODO InnerFire_CS1_129 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Inner Fire"));
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
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Silence_EX1_332()
		{
			// TODO Silence_EX1_332 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Silence"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [EX1_334] Shadow Madness - COST:4 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Gain control of an enemy minion with 3 or less Attack until end of turn.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_ENEMY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_NUM_MINION_SLOTS = 1
		// - REQ_TARGET_MAX_ATTACK = 3
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void ShadowMadness_EX1_334()
		{
			// TODO ShadowMadness_EX1_334 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Shadow Madness"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [EX1_339] Thoughtsteal - COST:3 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Copy 2 cards in your opponent's deck and add them to your hand.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Thoughtsteal_EX1_339()
		{
			// TODO Thoughtsteal_EX1_339 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Thoughtsteal"));
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
		[TestMethod, Ignore]
		public void Mindgames_EX1_345()
		{
			// TODO Mindgames_EX1_345 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Mindgames"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [EX1_621] Circle of Healing - COST:0 
		// - Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Restore #4 Health to ALL_minions.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void CircleOfHealing_EX1_621()
		{
			// TODO CircleOfHealing_EX1_621 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Circle of Healing"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [EX1_624] Holy Fire - COST:6 
		// - Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $5 damage. Restore #5 Health to your hero. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void HolyFire_EX1_624()
		{
			// TODO HolyFire_EX1_624 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Holy Fire"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [EX1_625] Shadowform - COST:3 
		// - Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Your Hero Power becomes 'Deal 2 damage'. If already in Shadowform: 3 damage.
		// --------------------------------------------------------
		[TestMethod]
		public void Shadowform_EX1_625()
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
            var testCard1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Shadowform"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard1));
            game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
            Assert.AreEqual(28, game.CurrentOpponent.Hero.Health);
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var testCard2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Shadowform"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard2));
            game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
            Assert.AreEqual(25, game.CurrentOpponent.Hero.Health);
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
		[TestMethod, Ignore]
		public void MassDispel_EX1_626()
		{
			// TODO MassDispel_EX1_626 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Mass Dispel"));
		}

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
		// - REQ_TARGET_MAX_ATTACK = 2
		// - REQ_MINION_TARGET = 0
		// - REQ_ENEMY_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void CabalShadowPriest_EX1_091()
		{
			// TODO CabalShadowPriest_EX1_091 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Cabal Shadow Priest"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [EX1_335] Lightspawn - COST:4 [ATK:0/HP:5] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: This minion's Attack is always equal to its Health.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Lightspawn_EX1_335()
		{
			// TODO Lightspawn_EX1_335 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Lightspawn"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [EX1_341] Lightwell - COST:2 [ATK:0/HP:5] 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: At the start of your turn, restore 3 Health to a damaged friendly character.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Lightwell_EX1_341()
		{
			// TODO Lightwell_EX1_341 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Lightwell"));
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
		[TestMethod, Ignore]
		public void ProphetVelen_EX1_350()
		{
			// TODO ProphetVelen_EX1_350 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Prophet Velen"));
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
		[TestMethod, Ignore]
		public void AuchenaiSoulpriest_EX1_591()
		{
			// TODO AuchenaiSoulpriest_EX1_591 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Auchenai Soulpriest"));
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
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void TempleEnforcer_EX1_623()
		{
			// TODO TempleEnforcer_EX1_623 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Temple Enforcer"));
		}

	}

	[TestClass]
	public class RogueExpert1Test
	{
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
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod]
		public void ColdBlood_CS2_073()
		{
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.ROGUE,
                Player2HeroClass = CardClass.PRIEST,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bloodfen Raptor"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var spell1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Cold Blood"));
            var spell2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Cold Blood"));

            Assert.AreEqual(3, ((ICharacter)minion1).AttackDamage);

            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, minion1));

            Assert.AreEqual(5, ((ICharacter)minion1).AttackDamage);

            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, minion1));

            Assert.AreEqual(9, ((ICharacter)minion1).AttackDamage);
        }

		// ------------------------------------------ SPELL - ROGUE
		// [CS2_233] Blade Flurry - COST:4 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Destroy your weapon and deal its damage to all enemy minions. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - AFFECTED_BY_SPELL_POWER = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_WEAPON_EQUIPPED = 0
		// --------------------------------------------------------
		[TestMethod]
		public void BladeFlurry_CS2_233()
		{
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.MAGE,
                Player2HeroClass = CardClass.ROGUE,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Leper Gnome"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(HeroPowerTask.Any(game.CurrentPlayer));

            var spell = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Blade Flurry"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));

            Assert.AreEqual(true, ((Minion)minion1).IsDead);
            Assert.AreEqual(null, game.CurrentPlayer.Hero.Weapon);
        }

		// ------------------------------------------ SPELL - ROGUE
		// [EX1_124] Eviscerate - COST:2 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $2 damage. <b>Combo:</b> Deal $4 damage instead. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod]
		public void Eviscerate_EX1_124()
		{
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.ROGUE,
                Player2HeroClass = CardClass.PRIEST,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            var spell1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Eviscerate"));
            var spell2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Eviscerate"));

            Assert.AreEqual(30, game.CurrentOpponent.Hero.Health);

            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, game.CurrentOpponent.Hero));

            Assert.AreEqual(28, game.CurrentOpponent.Hero.Health);

            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, game.CurrentOpponent.Hero));

            Assert.AreEqual(24, game.CurrentOpponent.Hero.Health);
        }

		// ------------------------------------------ SPELL - ROGUE
		// [EX1_126] Betrayal - COST:2 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Force an enemy minion to deal its damage to the minions next to it.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_ENEMY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod]
		public void Betrayal_EX1_126()
		{
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.ROGUE,
                Player2HeroClass = CardClass.PRIEST,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sen'jin Shieldmasta"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
            game.CurrentPlayer.UsedMana = 0;
            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Chillwind Yeti"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
            game.CurrentPlayer.UsedMana = 0;
            var minion3 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("War Golem"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
            game.CurrentPlayer.UsedMana = 0;

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var spell1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Betrayal"));
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, minion2));

            Assert.AreEqual(1, ((Minion)minion1).Health);
            Assert.AreEqual(5, ((Minion)minion2).Health);
            Assert.AreEqual(3, ((Minion)minion3).Health);
        }

		// ------------------------------------------ SPELL - ROGUE
		// [EX1_128] Conceal - COST:1 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Give your minions <b>Stealth</b> until your next_turn.
		// --------------------------------------------------------
		// RefTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Conceal_EX1_128()
		{
			// TODO Conceal_EX1_128 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Conceal"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [EX1_137] Headcrack - COST:3 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $2 damage to the enemy hero. <b>Combo:</b> Return this to your hand next turn. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Headcrack_EX1_137()
		{
			// TODO Headcrack_EX1_137 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Headcrack"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [EX1_144] Shadowstep - COST:0 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Return a friendly minion to your hand. It_costs (2) less.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod]
		public void Shadowstep_EX1_144()
		{
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.ROGUE,
                Player2HeroClass = CardClass.PRIEST,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stonetusk Boar"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));

            Assert.AreEqual(1, game.CurrentPlayer.Board.Count);
            Assert.AreEqual(4, game.CurrentPlayer.Hand.Count);
            Assert.AreEqual(1, minion2.Cost);

            var spell1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Shadowstep"));
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, minion2));

            Assert.AreEqual(0, game.CurrentPlayer.Board.Count);
            Assert.AreEqual(5, game.CurrentPlayer.Hand.Count);
            Assert.AreEqual(0, minion2.Cost);
        }

		// ------------------------------------------ SPELL - ROGUE
		// [EX1_145] Preparation - COST:0 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: The next spell you cast this turn costs (3) less.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Preparation_EX1_145()
		{
			// TODO Preparation_EX1_145 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Preparation"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [EX1_131] Defias Ringleader - COST:2 [ATK:2/HP:2] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Combo:</b> Summon a 2/1 Defias Bandit.
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		[TestMethod]
		public void DefiasRingleader_EX1_131()
		{
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.ROGUE,
                Player2HeroClass = CardClass.PRIEST,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            game.Player1.Hero.Damage = 5;

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Defias Ringleader"));
            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Defias Ringleader"));

            Assert.AreEqual(0, game.CurrentPlayer.Board.Count);

            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

            Assert.AreEqual(1, game.CurrentPlayer.Board.Count);

            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));

            Assert.AreEqual(3, game.CurrentPlayer.Board.Count);
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
		[TestMethod, Ignore]
		public void Si7Agent_EX1_134()
		{
			// TODO Si7Agent_EX1_134 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("SI:7 Agent"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [EX1_522] Patient Assassin - COST:2 [ATK:1/HP:1] 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Stealth</b>. Destroy any minion damaged by this_minion.
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// - POISONOUS = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void PatientAssassin_EX1_522()
		{
			// TODO PatientAssassin_EX1_522 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Patient Assassin"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [EX1_613] Edwin VanCleef - COST:3 [ATK:2/HP:2] 
		// - Fac: neutral, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Combo:</b> Gain +2/+2 for each card played earlier this turn.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - COMBO = 1
		// --------------------------------------------------------
		[TestMethod]
		public void EdwinVancleef_EX1_613()
		{
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.ROGUE,
                Player2HeroClass = CardClass.PRIEST,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Edwin VanCleef"));
            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Edwin VanCleef"));

            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

            Assert.AreEqual(2, ((ICharacter)minion1).Health);
            Assert.AreEqual(2, ((ICharacter)minion1).AttackDamage);

            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));

            Assert.AreEqual(4, ((ICharacter)minion2).Health);
            Assert.AreEqual(4, ((ICharacter)minion2).AttackDamage);
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
		[TestMethod, Ignore]
		public void Kidnapper_NEW1_005()
		{
			// TODO Kidnapper_NEW1_005 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Kidnapper"));
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
		// - REQ_NONSELF_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void MasterOfDisguise_NEW1_014()
		{
			// TODO MasterOfDisguise_NEW1_014 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Master of Disguise"));
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
		[TestMethod, Ignore]
		public void PerditionsBlade_EX1_133()
		{
			// TODO PerditionsBlade_EX1_133 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Perdition's Blade"));
		}

	}

	[TestClass]
	public class ShamanExpert1Test
	{
		// ----------------------------------------- SPELL - SHAMAN
		// [CS2_038] Ancestral Spirit - COST:2 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Give a minion "<b>Deathrattle:</b> Resummon this minion."
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void AncestralSpirit_CS2_038()
		{
			// TODO AncestralSpirit_CS2_038 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ancestral Spirit"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [CS2_053] Far Sight - COST:3 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Draw a card. That card costs (3) less.
		// --------------------------------------------------------
		[TestMethod]
		public void FarSight_CS2_053()
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
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Far Sight"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
		    var drawedCard = game.CurrentPlayer.Hand[game.CurrentPlayer.Hand.Count - 1];
		    var cost = drawedCard.Card.Cost - 3; 
            Assert.AreEqual(cost < 0 ? 0 : cost, drawedCard.Cost);
        }

		// ----------------------------------------- SPELL - SHAMAN
		// [EX1_238] Lightning Bolt - COST:1 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $3 damage. <b>Overload:</b> (1) *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 1
		// - OVERLOAD_OWED = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod]
		public void LightningBolt_EX1_238()
		{
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.SHAMAN,
                Player2HeroClass = CardClass.PRIEST,
                FillDecks = true
            });
            game.StartGame();

            Assert.AreEqual(30, game.CurrentOpponent.Hero.Health);

            var spell = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Lightning Bolt"));
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, game.CurrentOpponent.Hero));

            Assert.AreEqual(27, game.CurrentOpponent.Hero.Health);
            Assert.AreEqual(1, game.CurrentPlayer.OverloadOwed);

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            Assert.AreEqual(0, game.CurrentPlayer.OverloadOwed);
            Assert.AreEqual(1, game.CurrentPlayer.OverloadLocked);
            Assert.AreEqual(1, game.CurrentPlayer.RemainingMana);
        }

		// ----------------------------------------- SPELL - SHAMAN
		// [EX1_241] Lava Burst - COST:3 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $5 damage. <b>Overload:</b> (2) *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 2
		// - OVERLOAD_OWED = 2
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void LavaBurst_EX1_241()
		{
			// TODO LavaBurst_EX1_241 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Lava Burst"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [EX1_245] Earth Shock - COST:1 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Silence</b> a minion, then deal $1 damage to it. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - SILENCE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void EarthShock_EX1_245()
		{
			// TODO EarthShock_EX1_245 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Earth Shock"));
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
		[TestMethod]
		public void FeralSpirit_EX1_248()
		{
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.SHAMAN,
                Player2HeroClass = CardClass.PRIEST,
                FillDecks = true
            });
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;
            game.StartGame();

            var spell = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Feral Spirit"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));

            Assert.AreEqual(2, game.CurrentPlayer.Board.Count);
            Assert.AreEqual(true, ((Minion)game.CurrentPlayer.Board[0]).HasTaunt);
        }

		// ----------------------------------------- SPELL - SHAMAN
		// [EX1_251] Forked Lightning - COST:1 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $2 damage to 2_random enemy minions. <b>Overload:</b> (2) *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 2
		// - OVERLOAD_OWED = 2
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINIMUM_ENEMY_MINIONS = 2
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void ForkedLightning_EX1_251()
		{
			// TODO ForkedLightning_EX1_251 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Forked Lightning"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [EX1_259] Lightning Storm - COST:3 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $2-$3 damage to all_enemy minions. <b>Overload:</b> (2) *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 2
		// - OVERLOAD_OWED = 2
		// --------------------------------------------------------
		[TestMethod]
		public void LightningStorm_EX1_259()
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
            var minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chillwind Yeti"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
		    game.CurrentPlayer.UsedMana = 0;
            var minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chillwind Yeti"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
            game.CurrentPlayer.UsedMana = 0;
            var minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chillwind Yeti"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
            game.CurrentPlayer.UsedMana = 0;
            var minion4 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chillwind Yeti"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion4));
            game.CurrentPlayer.UsedMana = 0;
            var minion5 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chillwind Yeti"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion5));
            game.CurrentPlayer.UsedMana = 0;
            var minion6 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chillwind Yeti"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion6));
            game.CurrentPlayer.UsedMana = 0;
            var minion7 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chillwind Yeti"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion7));
            game.CurrentPlayer.UsedMana = 0;
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            Assert.AreEqual(35, ((Minion)minion1).Health + ((Minion)minion2).Health + ((Minion)minion3).Health 
                + ((Minion)minion4).Health + ((Minion)minion5).Health 
                + ((Minion)minion6).Health + ((Minion)minion7).Health);
            var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lightning Storm"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
            Assert.AreNotEqual(31, ((Minion)minion1).Health + ((Minion)minion2).Health + ((Minion)minion3).Health 
                + ((Minion)minion4).Health + ((Minion)minion5).Health
                + ((Minion)minion6).Health + ((Minion)minion7).Health);
            Assert.AreNotEqual(24, ((Minion)minion1).Health + ((Minion)minion2).Health + ((Minion)minion3).Health 
                + ((Minion)minion4).Health + ((Minion)minion5).Health 
                + ((Minion)minion6).Health + ((Minion)minion7).Health);
        }

		// ---------------------------------------- MINION - SHAMAN
		// [EX1_243] Dust Devil - COST:1 [ATK:3/HP:1] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Windfury</b>. <b>Overload:</b> (2)
		// --------------------------------------------------------
		// GameTag:
		// - WINDFURY = 1
		// - OVERLOAD = 2
		// - OVERLOAD_OWED = 2
		// --------------------------------------------------------
		[TestMethod]
		public void DustDevil_EX1_243()
		{
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.SHAMAN,
                Player2HeroClass = CardClass.SHAMAN,
                FillDecks = true
            });
            game.StartGame();

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var minion = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Dust Devil"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));

            Assert.AreEqual(2, game.CurrentPlayer.OverloadOwed);

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            Assert.AreEqual(0, game.CurrentPlayer.OverloadOwed);
            Assert.AreEqual(2, game.CurrentPlayer.OverloadLocked);
            Assert.AreEqual(0, game.CurrentPlayer.RemainingMana);

            game.Process(PlayCardTask.Spell(game.CurrentPlayer, game.CurrentPlayer.Hand[4]));

            Assert.AreEqual(0, game.CurrentPlayer.OverloadOwed);
            Assert.AreEqual(2, game.CurrentPlayer.OverloadLocked);
            Assert.AreEqual(1, game.CurrentPlayer.RemainingMana);
        }

		// ---------------------------------------- MINION - SHAMAN
		// [EX1_250] Earth Elemental - COST:5 [ATK:7/HP:8] 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Taunt</b>. <b>Overload:</b> (3)
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - OVERLOAD = 3
		// - OVERLOAD_OWED = 3
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void EarthElemental_EX1_250()
		{
			// TODO EarthElemental_EX1_250 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Earth Elemental"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [EX1_258] Unbound Elemental - COST:3 [ATK:2/HP:4] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever you play a card_with <b>Overload</b>, gain_+1/+1.
		// --------------------------------------------------------
		// RefTag:
		// - OVERLOAD = 1
		// --------------------------------------------------------
		[TestMethod]
		public void UnboundElemental_EX1_258()
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
            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Unbound Elemental"));
            var minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
            var spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ancestral Knowledge"));

            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));

            Assert.AreEqual(2, ((Minion)minion1).AttackDamage);
            Assert.AreEqual(4, ((Minion)minion1).Health);

            game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));

            Assert.AreEqual(3, ((Minion)minion1).AttackDamage);
            Assert.AreEqual(5, ((Minion)minion1).Health);
        }

		// ---------------------------------------- MINION - SHAMAN
		// [EX1_575] Mana Tide Totem - COST:3 [ATK:0/HP:3] 
		// - Race: totem, Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: At the end of your turn, draw a card.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void ManaTideTotem_EX1_575()
		{
			// TODO ManaTideTotem_EX1_575 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Mana Tide Totem"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [NEW1_010] Al'Akir the Windlord - COST:8 [ATK:3/HP:5] 
		// - Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Windfury, Charge, Divine Shield, Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - WINDFURY = 1
		// - TAUNT = 1
		// - DIVINE_SHIELD = 1
		// - CHARGE = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void AlakirTheWindlord_NEW1_010()
		{
			// TODO AlakirTheWindlord_NEW1_010 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Al'Akir the Windlord"));
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
		[TestMethod, Ignore]
		public void StormforgedAxe_EX1_247()
		{
			// TODO StormforgedAxe_EX1_247 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stormforged Axe"));
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
		[TestMethod, Ignore]
		public void Doomhammer_EX1_567()
		{
			// TODO Doomhammer_EX1_567 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Doomhammer"));
		}

	}

	[TestClass]
	public class WarlockExpert1Test
	{
		// ---------------------------------------- SPELL - WARLOCK
		// [EX1_303] Shadowflame - COST:4 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Destroy a friendly minion and deal its Attack damage to all enemy minions. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - AFFECTED_BY_SPELL_POWER = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Shadowflame_EX1_303()
		{
			// TODO Shadowflame_EX1_303 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Shadowflame"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [EX1_309] Siphon Soul - COST:6 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Destroy a minion. Restore #3 Health to_your hero.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void SiphonSoul_EX1_309()
		{
			// TODO SiphonSoul_EX1_309 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Siphon Soul"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [EX1_312] Twisting Nether - COST:8 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Destroy all minions.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void TwistingNether_EX1_312()
		{
			// TODO TwistingNether_EX1_312 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Twisting Nether"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [EX1_316] Power Overwhelming - COST:1 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Give a friendly minion +4/+4 until end of turn. Then, it dies. Horribly.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void PowerOverwhelming_EX1_316()
		{
			// TODO PowerOverwhelming_EX1_316 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Power Overwhelming"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [EX1_317] Sense Demons - COST:3 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Draw 2 Demons
		//       from your deck.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void SenseDemons_EX1_317()
		{
			// TODO SenseDemons_EX1_317 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sense Demons"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [EX1_320] Bane of Doom - COST:5 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Deal $2 damage to_a character. If that kills it, summon a random Demon. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void BaneOfDoom_EX1_320()
		{
			// TODO BaneOfDoom_EX1_320 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bane of Doom"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [EX1_596] Demonfire - COST:2 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $2 damage to a minion. If it’s a friendly Demon, give it +2/+2 instead. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Demonfire_EX1_596()
		{
			// TODO Demonfire_EX1_596 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Demonfire"));
		}

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
		[TestMethod]
		public void BloodImp_CS2_059()
		{
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.WARLOCK,
                Player2HeroClass = CardClass.PRIEST,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Blood Imp"));
            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stonetusk Boar"));

            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            Assert.AreEqual(2, ((ICharacter)minion2).Health);

            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            Assert.AreEqual(3, ((ICharacter)minion2).Health);
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
		[TestMethod, Ignore]
		public void Felguard_EX1_301()
		{
			// TODO Felguard_EX1_301 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Felguard"));
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
		[TestMethod, Ignore]
		public void VoidTerror_EX1_304()
		{
			// TODO VoidTerror_EX1_304 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Void Terror"));
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
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Doomguard_EX1_310()
		{
			// TODO Doomguard_EX1_310 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Doomguard"));
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
		[TestMethod, Ignore]
		public void PitLord_EX1_313()
		{
			// TODO PitLord_EX1_313 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Pit Lord"));
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
		[TestMethod, Ignore]
		public void SummoningPortal_EX1_315()
		{
			// TODO SummoningPortal_EX1_315 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Summoning Portal"));
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
		[TestMethod, Ignore]
		public void FlameImp_EX1_319()
		{
			// TODO FlameImp_EX1_319 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Flame Imp"));
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
		[TestMethod]
		public void LordJaraxxus_EX1_323()
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
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Lord Jaraxxus"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
		    game.CurrentPlayer.UsedMana = 0;
            Assert.AreEqual(0, game.CurrentPlayer.Board.Count);
            game.Process(HeroPowerTask.Any(game.CurrentPlayer));
            Assert.AreEqual(1, game.CurrentPlayer.Board.Count);
            Assert.AreEqual(15, game.CurrentPlayer.Hero.Health);
            Assert.AreEqual(3, game.CurrentPlayer.Hero.TotalAttackDamage);
        }

	}

	[TestClass]
	public class WarriorExpert1Test
	{
		// ---------------------------------------- SPELL - WARRIOR
		// [CS2_104] Rampage - COST:2 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Give a damaged minion +3/+3.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_DAMAGED_TARGET = 0
		// --------------------------------------------------------
		[TestMethod]
		public void Rampage_CS2_104()
		{
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.WARRIOR,
                Player2HeroClass = CardClass.MAGE,
                FillDecks = true
            });
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;
            game.StartGame();

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sen'jin Shieldmasta"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var spell = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Rampage"));
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, minion1));
            Assert.AreEqual(6, ((Minion)minion1).AttackDamage);
            Assert.AreEqual(7, ((Minion)minion1).Health);
        }

		// ---------------------------------------- SPELL - WARRIOR
		// [EX1_391] Slam - COST:2 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $2 damage to a minion. If it survives, draw a card. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Slam_EX1_391()
		{
			// TODO Slam_EX1_391 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Slam"));
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
		[TestMethod, Ignore]
		public void BattleRage_EX1_392()
		{
			// TODO BattleRage_EX1_392 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Battle Rage"));
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
		[TestMethod, Ignore]
		public void Brawl_EX1_407()
		{
			// TODO Brawl_EX1_407 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Brawl"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [EX1_408] Mortal Strike - COST:4 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $4 damage. If you have 12 or less Health, deal $6 instead. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void MortalStrike_EX1_408()
		{
			// TODO MortalStrike_EX1_408 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Mortal Strike"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [EX1_409] Upgrade! - COST:1 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: If you have a weapon, give it +1/+1. Otherwise equip a 1/3 weapon.
		// --------------------------------------------------------
		[TestMethod]
		public void Upgrade_EX1_409()
		{
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
            Assert.AreEqual(null, game.CurrentPlayer.Hero.Weapon);
			var spell1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Upgrade!"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell1));
		    Assert.AreEqual(1, game.CurrentPlayer.Hero.Weapon.AttackDamage);
            Assert.AreEqual(3, game.CurrentPlayer.Hero.Weapon.Durability);
            var spell2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Upgrade!"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell2));
            Assert.AreEqual(2, game.CurrentPlayer.Hero.Weapon.AttackDamage);
            Assert.AreEqual(4, game.CurrentPlayer.Hero.Weapon.Durability);
        }

		// ---------------------------------------- SPELL - WARRIOR
		// [EX1_410] Shield Slam - COST:1 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Deal 1 damage to a minion for each Armor you have. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - AFFECTED_BY_SPELL_POWER = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void ShieldSlam_EX1_410()
		{
			// TODO ShieldSlam_EX1_410 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Shield Slam"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [EX1_607] Inner Rage - COST:0 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $1 damage to a minion and give it +2_Attack. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void InnerRage_EX1_607()
		{
			// TODO InnerRage_EX1_607 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Inner Rage"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [NEW1_036] Commanding Shout - COST:2 
		// - Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Your minions can't be reduced below 1 Health this turn. Draw a card.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void CommandingShout_NEW1_036()
		{
			// TODO CommandingShout_NEW1_036 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Commanding Shout"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [EX1_398] Arathi Weaponsmith - COST:4 [ATK:3/HP:3] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Equip a 2/2_weapon.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void ArathiWeaponsmith_EX1_398()
		{
			// TODO ArathiWeaponsmith_EX1_398 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Arathi Weaponsmith"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [EX1_402] Armorsmith - COST:2 [ATK:1/HP:4] 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever a friendly minion_takes damage, gain 1 Armor.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Armorsmith_EX1_402()
		{
			// TODO Armorsmith_EX1_402 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Armorsmith"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [EX1_414] Grommash Hellscream - COST:8 [ATK:4/HP:9] 
		// - Fac: neutral, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Charge</b>
		//       <b>Enrage:</b> +6 Attack
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - CHARGE = 1
		// - ENRAGED = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void GrommashHellscream_EX1_414()
		{
			// TODO GrommashHellscream_EX1_414 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Grommash Hellscream"));
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
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_NONSELF_TARGET = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void CruelTaskmaster_EX1_603()
		{
			// TODO CruelTaskmaster_EX1_603 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Cruel Taskmaster"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [EX1_604] Frothing Berserker - COST:3 [ATK:2/HP:4] 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever a minion takes damage, gain +1 Attack.
		// --------------------------------------------------------
		[TestMethod]
		public void FrothingBerserker_EX1_604()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Frothing Berserker"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
            Assert.AreEqual(2, ((Minion)minion1).AttackDamage);
            Assert.AreEqual(4, ((Minion)minion1).Health);
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));
            Assert.AreEqual(3, ((Minion)minion1).AttackDamage);
            Assert.AreEqual(3, ((Minion)minion1).Health);
            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stonetusk Boar"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion2));

            Assert.AreEqual(4, ((Minion)minion1).AttackDamage);
            Assert.AreEqual(3, ((Minion)minion1).Health);

            var minion3 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stonetusk Boar"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));

            game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion3, minion1));
            Assert.AreEqual(6, ((Minion)minion1).AttackDamage);
            Assert.AreEqual(2, ((Minion)minion1).Health);
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
		[TestMethod, Ignore]
		public void Gorehowl_EX1_411()
		{
			// TODO Gorehowl_EX1_411 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Gorehowl"));
		}

	}

	[TestClass]
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
		[TestMethod, Ignore]
		public void FenCreeper_CS1_069()
		{
			// TODO FenCreeper_CS1_069 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Fen Creeper"));
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
		[TestMethod, Ignore]
		public void EarthenRingFarseer_CS2_117()
		{
			// TODO EarthenRingFarseer_CS2_117 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Earthen Ring Farseer"));
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
		[TestMethod]
		public void SouthseaDeckhand_CS2_146()
		{
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.ROGUE,
                Player2HeroClass = CardClass.PRIEST,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Southsea Deckhand"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

            Assert.AreEqual(false, ((Minion)minion1).HasCharge);

            game.Process(HeroPowerTask.Any(game.CurrentPlayer));

            Assert.AreEqual(true, ((Minion)minion1).HasCharge);
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
		[TestMethod, Ignore]
		public void SilverHandKnight_CS2_151()
		{
			// TODO SilverHandKnight_CS2_151 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Silver Hand Knight"));
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
		[TestMethod, Ignore]
		public void RavenholdtAssassin_CS2_161()
		{
			// TODO RavenholdtAssassin_CS2_161 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ravenholdt Assassin"));
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
		[TestMethod, Ignore]
		public void YoungDragonhawk_CS2_169()
		{
			// TODO YoungDragonhawk_CS2_169 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Young Dragonhawk"));
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
		[TestMethod]
		public void InjuredBlademaster_CS2_181()
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

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Injured Blademaster"));

            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

            Assert.AreEqual(3, ((ICharacter)minion1).Health);
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
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void AbusiveSergeant_CS2_188()
		{
			// TODO AbusiveSergeant_CS2_188 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Abusive Sergeant"));
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
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		// RefTag:
		// - SILENCE = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void IronbeakOwl_CS2_203()
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

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Leper Gnome"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

            Assert.AreEqual(true, ((Minion)minion1).HasDeathrattle);

            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ironbeak Owl"));
            game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion2, minion1));

            Assert.AreEqual(false, ((Minion)minion1).HasDeathrattle);
        }

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_221] Spiteful Smith - COST:5 [ATK:4/HP:6] 
		// - Fac: horde, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Enrage:</b> Your weapon has +2 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - ENRAGED = 1
		// --------------------------------------------------------
		[TestMethod]
		public void SpitefulSmith_CS2_221()
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

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Spiteful Smith"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

            game.Process(HeroPowerTask.Any(game.CurrentPlayer));

            Assert.AreEqual(1, game.CurrentPlayer.Hero.TotalAttackDamage);

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));

            Assert.AreEqual(3, game.CurrentOpponent.Hero.TotalAttackDamage);

            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ironbeak Owl"));
            game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion2, minion1));

            Assert.AreEqual(1, game.CurrentOpponent.Hero.TotalAttackDamage);
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
		[TestMethod]
		public void VentureCoMercenary_CS2_227()
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

            var costA = game.CurrentPlayer.Hand[0].Cost;

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Venture Co. Mercenary"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

            Assert.AreEqual(costA + 3, game.CurrentPlayer.Hand[0].Cost);

            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ironbeak Owl"));

            game.CurrentPlayer.UsedMana = 0;
            game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion2, minion1));

            Assert.AreEqual(true, ((ICharacter)minion1).IsSilenced);
            Assert.AreEqual(costA, game.CurrentPlayer.Hand[0].Cost);
        }

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_231] Wisp - COST:0 [ATK:1/HP:1] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Wisp_CS2_231()
		{
			// TODO Wisp_CS2_231 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Wisp"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_001] Lightwarden - COST:1 [ATK:1/HP:2] 
		// - Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever a character is healed, gain +2 Attack.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Lightwarden_EX1_001()
		{
			// TODO Lightwarden_EX1_001 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Lightwarden"));
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
		// - REQ_MINION_TARGET = 0
		// - REQ_ENEMY_TARGET = 0
		// - REQ_MUST_TARGET_TAUNTER = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[TestMethod]
		public void TheBlackKnight_EX1_002()
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

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sen'jin Shieldmasta"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

            var minion3 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bloodfen Raptor"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion3));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("The Black Knight"));
            game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion2, minion3));

            Assert.AreEqual(false, ((ICharacter)minion3).IsDead);

            game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion2, minion1));

            Assert.AreEqual(true, ((ICharacter)minion1).IsDead);
        }

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_004] Young Priestess - COST:1 [ATK:2/HP:1] 
		// - Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: At the end of your turn, give another random friendly minion +1 Health.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void YoungPriestess_EX1_004()
		{
			// TODO YoungPriestess_EX1_004 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Young Priestess"));
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
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_TARGET_MIN_ATTACK = 7
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void BigGameHunter_EX1_005()
		{
			// TODO BigGameHunter_EX1_005 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Big Game Hunter"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_006] Alarm-o-Bot - COST:3 [ATK:0/HP:3] 
		// - Race: mechanical, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]At the start of your turn,
		//       swap this minion with a
		//          random one in your hand.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void AlarmOBot_EX1_006()
		{
			// TODO AlarmOBot_EX1_006 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Alarm-o-Bot"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_007] Acolyte of Pain - COST:3 [ATK:1/HP:3] 
		// - Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever this minion takes damage, draw a_card.
		// --------------------------------------------------------
		[TestMethod]
		public void AcolyteOfPain_EX1_007()
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

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Acolyte of Pain"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

            Assert.AreEqual(2, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);

            game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));

            Assert.AreEqual(2, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);

            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));

            Assert.AreEqual(2, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);
            Assert.AreEqual(true, ((ICharacter)minion1).IsDead);
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
		[TestMethod, Ignore]
		public void ArgentSquire_EX1_008()
		{
			// TODO ArgentSquire_EX1_008 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Argent Squire"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_009] Angry Chicken - COST:1 [ATK:1/HP:1] 
		// - Race: beast, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Enrage:</b> +5 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - ENRAGED = 1
		// --------------------------------------------------------
		[TestMethod]
		public void AngryChicken_EX1_009()
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

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Angry Chicken"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Shattered Sun Cleric"));
            game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion2, minion1));

            Assert.AreEqual(2, ((ICharacter)minion1).Health);

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));

            Assert.AreEqual(7, ((ICharacter)minion1).AttackDamage);

            var minion3 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ironbeak Owl"));
            game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion3, minion1));

            Assert.AreEqual(1, ((ICharacter)minion1).Health);
            Assert.AreEqual(false, ((ICharacter)minion1).IsDead);
            Assert.AreEqual(Zone.PLAY, ((ICharacter)minion1).Zone.Type);
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
		[TestMethod, Ignore]
		public void WorgenInfiltrator_EX1_010()
		{
			// TODO WorgenInfiltrator_EX1_010 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Worgen Infiltrator"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_012] Bloodmage Thalnos - COST:2 [ATK:1/HP:1] 
		// - Fac: neutral, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Spell Damage +1</b>. <b>Deathrattle:</b> Draw a card.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - SPELLPOWER = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[TestMethod]
		public void BloodmageThalnos_EX1_012()
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

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bloodmage Thalnos"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

            Assert.AreEqual(1, game.CurrentPlayer.Hero.SpellPower);

            Assert.AreEqual(2, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);

            game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));

            Assert.AreEqual(3, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);
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
		[TestMethod]
		public void KingMukla_EX1_014()
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

            var handCount = game.CurrentOpponent.Hand.Count;

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("King Mukla"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

            Assert.AreEqual(handCount + 2, game.CurrentOpponent.Hand.Count);
        }

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_016] Sylvanas Windrunner - COST:6 [ATK:5/HP:5] 
		// - Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Take
		//       control of a random
		//       enemy minion.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[TestMethod]
		public void SylvanasWindrunner_EX1_016()
		{
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.WARLOCK,
                Player2HeroClass = CardClass.MAGE,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            var minion11 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bloodfen Raptor"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion11));

            var minion12 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Leper Gnome"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion12));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sylvanas Windrunner"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));

            var myBoardCount = game.CurrentPlayer.Board.Count;
            var opBoardCount = game.CurrentOpponent.Board.Count;

            var spell1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Fireball"));
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, minion2));

            Assert.AreEqual(myBoardCount, game.CurrentPlayer.Board.Count);
            Assert.AreEqual(opBoardCount - 1, game.CurrentOpponent.Board.Count);
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
		[TestMethod, Ignore]
		public void JunglePanther_EX1_017()
		{
			// TODO JunglePanther_EX1_017 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Jungle Panther"));
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
		[TestMethod, Ignore]
		public void ScarletCrusader_EX1_020()
		{
			// TODO ScarletCrusader_EX1_020 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Scarlet Crusader"));
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
		[TestMethod, Ignore]
		public void ThrallmarFarseer_EX1_021()
		{
			// TODO ThrallmarFarseer_EX1_021 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Thrallmar Farseer"));
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
		[TestMethod, Ignore]
		public void SilvermoonGuardian_EX1_023()
		{
			// TODO SilvermoonGuardian_EX1_023 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Silvermoon Guardian"));
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
		[TestMethod, Ignore]
		public void StranglethornTiger_EX1_028()
		{
			// TODO StranglethornTiger_EX1_028 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stranglethorn Tiger"));
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
		[TestMethod]
		public void LeperGnome_EX1_029()
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

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Leper Gnome"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

            game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));

            Assert.AreEqual(28, game.CurrentOpponent.Hero.Health);
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
		[TestMethod, Ignore]
		public void Sunwalker_EX1_032()
		{
			// TODO Sunwalker_EX1_032 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sunwalker"));
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
		[TestMethod, Ignore]
		public void WindfuryHarpy_EX1_033()
		{
			// TODO WindfuryHarpy_EX1_033 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Windfury Harpy"));
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
		[TestMethod]
		public void TwilightDrake_EX1_043()
		{
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.WARLOCK,
                Player2HeroClass = CardClass.MAGE,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            var minion11 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Twilight Drake"));
            var countHand = game.CurrentPlayer.Hand.Count;
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion11));

            Assert.AreEqual(countHand, ((Minion)minion11).Health);

            var minion3 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ironbeak Owl"));
            game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion3, minion11));

            Assert.AreEqual(1, ((Minion)minion11).Health);
        }

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_044] Questing Adventurer - COST:3 [ATK:2/HP:2] 
		// - Fac: alliance, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you play a card, gain +1/+1.
		// --------------------------------------------------------
		[TestMethod]
		public void QuestingAdventurer_EX1_044()
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
            var minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Questing Adventurer"));
            var minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
            var spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostbolt"));

            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));

            Assert.AreEqual(3, ((Minion)minion1).AttackDamage);
            Assert.AreEqual(3, ((Minion)minion1).Health);

            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, game.CurrentOpponent.Hero));

            Assert.AreEqual(4, ((Minion)minion1).AttackDamage);
            Assert.AreEqual(4, ((Minion)minion1).Health);
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
		[TestMethod, Ignore]
		public void AncientWatcher_EX1_045()
		{
			// TODO AncientWatcher_EX1_045 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ancient Watcher"));
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
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[TestMethod]
		public void DarkIronDwarf_EX1_046()
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

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bloodfen Raptor"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

            Assert.AreEqual(3, ((Minion)minion1).AttackDamage);

            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Dark Iron Dwarf"));
            game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion2, minion1));

            Assert.AreEqual(5, ((Minion)minion1).AttackDamage);

            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            Assert.AreEqual(3, ((Minion)minion1).AttackDamage);
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
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_NONSELF_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - SILENCE = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Spellbreaker_EX1_048()
		{
			// TODO Spellbreaker_EX1_048 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Spellbreaker"));
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
		// - REQ_NONSELF_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[TestMethod]
		public void YouthfulBrewmaster_EX1_049()
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

            var minion11 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bloodfen Raptor"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion11));

            game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion11));

            Assert.AreEqual(1, ((Minion)minion11).Health);

            var minion3 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Youthful Brewmaster"));
            game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion3, minion11));

            Assert.AreEqual(2, ((Minion)minion11).Health);
        }

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_050] Coldlight Oracle - COST:3 [ATK:2/HP:2] 
		// - Race: murloc, Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Each player draws 2 cards.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[TestMethod]
		public void ColdlightOracle_EX1_050()
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

            var handCount = game.CurrentPlayer.Hand.Count;
            var handOpCount = game.CurrentOpponent.Hand.Count;

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Coldlight Oracle"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

            Assert.AreEqual(handCount + 2, game.CurrentPlayer.Hand.Count);
            Assert.AreEqual(handOpCount + 2, game.CurrentOpponent.Hand.Count);
        }

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_055] Mana Addict - COST:2 [ATK:1/HP:3] 
		// - Fac: alliance, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, gain +2 Attack this turn.
		// --------------------------------------------------------
		[TestMethod]
		public void ManaAddict_EX1_055()
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
            var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mana Addict"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            Assert.AreEqual(6, game.CurrentPlayer.Hand.Count);
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, game.CurrentPlayer.Hand[4]));
            Assert.AreEqual(5, game.CurrentPlayer.Hand.Count);
            Assert.AreEqual(3, ((Minion)testCard).AttackDamage);
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            Assert.AreEqual(1, ((Minion)testCard).AttackDamage);
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
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_NONSELF_TARGET = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void AncientBrewmaster_EX1_057()
		{
			// TODO AncientBrewmaster_EX1_057 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ancient Brewmaster"));
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
		[TestMethod, Ignore]
		public void SunfuryProtector_EX1_058()
		{
			// TODO SunfuryProtector_EX1_058 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sunfury Protector"));
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
		[TestMethod, Ignore]
		public void CrazedAlchemist_EX1_059()
		{
			// TODO CrazedAlchemist_EX1_059 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Crazed Alchemist"));
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
		[TestMethod, Ignore]
		public void ArgentCommander_EX1_067()
		{
			// TODO ArgentCommander_EX1_067 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Argent Commander"));
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
		[TestMethod, Ignore]
		public void PintSizedSummoner_EX1_076()
		{
			// TODO PintSizedSummoner_EX1_076 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Pint-Sized Summoner"));
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
		[TestMethod]
		public void Secretkeeper_EX1_080()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
                DeckPlayer1 = new List<Card>()
                {
                    Cards.FromName("Mirror Entity"),
                    Cards.FromName("Arcane Explosion"),

                },
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
                Shuffle = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Secretkeeper"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            Assert.AreEqual(1, ((Minion)testCard).AttackDamage);
            Assert.AreEqual(2, ((Minion)testCard).Health);
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, game.CurrentPlayer.Hand[0]));
            Assert.AreEqual(2, ((Minion)testCard).AttackDamage);
            Assert.AreEqual(3, ((Minion)testCard).Health);
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, game.CurrentPlayer.Hand[0]));
            Assert.AreEqual(2, ((Minion)testCard).AttackDamage);
            Assert.AreEqual(3, ((Minion)testCard).Health);
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
		[TestMethod, Ignore]
		public void MadBomber_EX1_082()
		{
			// TODO MadBomber_EX1_082 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Mad Bomber"));
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
		[TestMethod, Ignore]
		public void TinkmasterOverspark_EX1_083()
		{
			// TODO TinkmasterOverspark_EX1_083 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Tinkmaster Overspark"));
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
		[TestMethod]
		public void MindControlTech_EX1_085()
		{
			// TODO MindControlTech_EX1_085 test
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

            var boar1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, boar1));
            var boar2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, boar2));
            var boar3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, boar3));
            Assert.AreEqual(3, game.CurrentPlayer.Board.Count);
            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Mind Control Tech"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
            var boar4 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, boar4));
            var boar5 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, boar5));
            var boar6 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, boar6));
            Assert.AreEqual(4, game.CurrentPlayer.Board.Count);
            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mind Control Tech"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
            Assert.AreEqual(5, game.CurrentPlayer.Board.Count);
            Assert.AreEqual(3, game.CurrentOpponent.Board.Count);
            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mind Control Tech"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));   
            Assert.AreEqual(5, game.CurrentPlayer.Board.Count);
            Assert.AreEqual(4, game.CurrentOpponent.Board.Count);
            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var minion7 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mind Control Tech"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion7));
            Assert.AreEqual(6, game.CurrentPlayer.Board.Count);
            Assert.AreEqual(4, game.CurrentOpponent.Board.Count);
            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var boar7 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, boar7));
            var boar8 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, boar8));
            Assert.AreEqual(6, game.CurrentPlayer.Board.Count);

            var minion8 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mind Control Tech"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion8));
            Assert.AreEqual(7, game.CurrentPlayer.Board.Count);
            Assert.AreEqual(5, game.CurrentOpponent.Board.Count);
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
		[TestMethod]
		public void ArcaneGolem_EX1_089()
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
			game.Player2.BaseMana = 1;
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Arcane Golem"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            Assert.AreEqual(2, game.CurrentOpponent.BaseMana);
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
		[TestMethod, Ignore]
		public void DefenderOfArgus_EX1_093()
		{
			// TODO DefenderOfArgus_EX1_093 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Defender of Argus"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_095] Gadgetzan Auctioneer - COST:6 [ATK:4/HP:4] 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, draw a card.
		// --------------------------------------------------------
		[TestMethod]
		public void GadgetzanAuctioneer_EX1_095()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 8;
			game.Player2.BaseMana = 8;
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Gadgetzan Auctioneer"));
            Assert.AreEqual(2, game.CurrentPlayer.NumCardsDrawnThisTurn);
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, game.CurrentPlayer.Hand[4]));
            Assert.AreEqual(6, game.CurrentPlayer.Hand.Count);
            Assert.AreEqual(4, game.CurrentPlayer.RemainingMana);
            Assert.AreEqual(3, game.CurrentPlayer.NumCardsDrawnThisTurn);
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
		[TestMethod, Ignore]
		public void LootHoarder_EX1_096()
		{
			// TODO LootHoarder_EX1_096 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Loot Hoarder"));
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
		[TestMethod, Ignore]
		public void Abomination_EX1_097()
		{
			// TODO Abomination_EX1_097 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Abomination"));
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
		[TestMethod, Ignore]
		public void LorewalkerCho_EX1_100()
		{
			// TODO LorewalkerCho_EX1_100 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Lorewalker Cho"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_102] Demolisher - COST:3 [ATK:1/HP:4] 
		// - Race: mechanical, Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: At the start of your turn, deal 2 damage to a random enemy.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Demolisher_EX1_102()
		{
			// TODO Demolisher_EX1_102 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Demolisher"));
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
		[TestMethod, Ignore]
		public void ColdlightSeer_EX1_103()
		{
			// TODO ColdlightSeer_EX1_103 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Coldlight Seer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_105] Mountain Giant - COST:12 [ATK:8/HP:8] 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Costs (1) less for each other card in your hand.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void MountainGiant_EX1_105()
		{
			// TODO MountainGiant_EX1_105 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Mountain Giant"));
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
		[TestMethod, Ignore]
		public void CairneBloodhoof_EX1_110()
		{
			// TODO CairneBloodhoof_EX1_110 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Cairne Bloodhoof"));
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
		[TestMethod, Ignore]
		public void LeeroyJenkins_EX1_116()
		{
			// TODO LeeroyJenkins_EX1_116 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Leeroy Jenkins"));
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
		[TestMethod, Ignore]
		public void DireWolfAlpha_EX1_162()
		{
			// TODO DireWolfAlpha_EX1_162 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Dire Wolf Alpha"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_170] Emperor Cobra - COST:3 [ATK:2/HP:3] 
		// - Race: beast, Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Destroy any minion damaged by this minion.
		// --------------------------------------------------------
		// GameTag:
		// - POISONOUS = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void EmperorCobra_EX1_170()
		{
			// TODO EmperorCobra_EX1_170 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Emperor Cobra"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_249] Baron Geddon - COST:7 [ATK:7/HP:5] 
		// - Fac: neutral, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: At the end of your turn, deal 2 damage to ALL other characters.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void BaronGeddon_EX1_249()
		{
			// TODO BaronGeddon_EX1_249 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Baron Geddon"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_283] Frost Elemental - COST:6 [ATK:5/HP:5] 
		// - Fac: neutral, Set: expert1, Rarity: common
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
		[TestMethod, Ignore]
		public void FrostElemental_EX1_283()
		{
			// TODO FrostElemental_EX1_283 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Frost Elemental"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_284] Azure Drake - COST:5 [ATK:4/HP:4] 
		// - Race: dragon, Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Spell Damage +1</b>. <b>Battlecry:</b> Draw a card.
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void AzureDrake_EX1_284()
		{
			// TODO AzureDrake_EX1_284 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Azure Drake"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_298] Ragnaros the Firelord - COST:8 [ATK:8/HP:8] 
		// - Fac: neutral, Set: expert1, Rarity: legendary
		// --------------------------------------------------------
		// Text: Can't attack. At the end of your turn, deal 8 damage to a random enemy.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - CANT_ATTACK = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void RagnarosTheFirelord_EX1_298()
		{
			// TODO RagnarosTheFirelord_EX1_298 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ragnaros the Firelord"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_390] Tauren Warrior - COST:3 [ATK:2/HP:3] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Enrage:</b> +3 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - ENRAGED = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void TaurenWarrior_EX1_390()
		{
			// TODO TaurenWarrior_EX1_390 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Tauren Warrior"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_393] Amani Berserker - COST:2 [ATK:2/HP:3] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Enrage:</b> +3 Attack
		// --------------------------------------------------------
		// GameTag:
		// - ENRAGED = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void AmaniBerserker_EX1_393()
		{
			// TODO AmaniBerserker_EX1_393 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Amani Berserker"));
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
		[TestMethod, Ignore]
		public void MogushanWarden_EX1_396()
		{
			// TODO MogushanWarden_EX1_396 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Mogu'shan Warden"));
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
		[TestMethod, Ignore]
		public void Shieldbearer_EX1_405()
		{
			// TODO Shieldbearer_EX1_405 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Shieldbearer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_412] Raging Worgen - COST:3 [ATK:3/HP:3] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Enrage:</b> <b>Windfury</b> and +1_Attack.
		// --------------------------------------------------------
		// GameTag:
		// - ENRAGED = 1
		// --------------------------------------------------------
		// RefTag:
		// - WINDFURY = 1
		// --------------------------------------------------------
		[TestMethod]
		public void RagingWorgen_EX1_412()
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

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Raging Worgen"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

            Assert.AreEqual(3, ((ICharacter)minion1).Health);
            Assert.AreEqual(3, ((ICharacter)minion1).AttackDamage);

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));

            Assert.AreEqual(2, ((ICharacter)minion1).Health);

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            Assert.AreEqual(4, ((ICharacter)minion1).AttackDamage);

            game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion1, game.CurrentOpponent.Hero));

            Assert.AreEqual(26, game.CurrentOpponent.Hero.Health);

            game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion1, game.CurrentOpponent.Hero));

            Assert.AreEqual(22, game.CurrentOpponent.Hero.Health);

            game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion1, game.CurrentOpponent.Hero));

            Assert.AreEqual(22, game.CurrentOpponent.Hero.Health);

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            Assert.AreEqual(true, ((ICharacter)minion1).HasWindfury);

            var minion3 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ironbeak Owl"));
            game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion3, minion1));

            Assert.AreEqual(2, ((ICharacter)minion1).Health);
            Assert.AreEqual(false, ((ICharacter)minion1).HasWindfury);
        }

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_507] Murloc Warleader - COST:3 [ATK:3/HP:3] 
		// - Race: murloc, Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Your other Murlocs have +2/+1.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void MurlocWarleader_EX1_507()
		{
			// TODO MurlocWarleader_EX1_507 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Murloc Warleader"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_509] Murloc Tidecaller - COST:1 [ATK:1/HP:2] 
		// - Race: murloc, Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you summon a Murloc, gain +1 Attack.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void MurlocTidecaller_EX1_509()
		{
			// TODO MurlocTidecaller_EX1_509 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Murloc Tidecaller"));
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
		[TestMethod, Ignore]
		public void HarvestGolem_EX1_556()
		{
			// TODO HarvestGolem_EX1_556 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Harvest Golem"));
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
		[TestMethod, Ignore]
		public void NatPagle_EX1_557()
		{
			// TODO NatPagle_EX1_557 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Nat Pagle"));
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
		[TestMethod, Ignore]
		public void HarrisonJones_EX1_558()
		{
			// TODO HarrisonJones_EX1_558 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Harrison Jones"));
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
		[TestMethod, Ignore]
		public void Nozdormu_EX1_560()
		{
			// TODO Nozdormu_EX1_560 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Nozdormu"));
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
		// - REQ_HERO_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[TestMethod]
		public void Alexstrasza_EX1_561()
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
            var testCard1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Alexstrasza"));
            game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard1, game.CurrentOpponent.Hero));
            Assert.AreEqual(15, game.CurrentOpponent.Hero.Health);
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var lordJaraxxus = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lord Jaraxxus"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, lordJaraxxus));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
            Assert.AreEqual(14, game.CurrentOpponent.Hero.Health);
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Alexstrasza"));
            game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard2, game.CurrentPlayer.Hero));
            Assert.AreEqual(15, game.CurrentPlayer.Hero.Health);
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
		[TestMethod, Ignore]
		public void Onyxia_EX1_562()
		{
			// TODO Onyxia_EX1_562 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Onyxia"));
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
		[TestMethod, Ignore]
		public void Malygos_EX1_563()
		{
			// TODO Malygos_EX1_563 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Malygos"));
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
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_NONSELF_TARGET = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void FacelessManipulator_EX1_564()
		{
			// TODO FacelessManipulator_EX1_564 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Faceless Manipulator"));
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
		[TestMethod, Ignore]
		public void Ysera_EX1_572()
		{
			// TODO Ysera_EX1_572 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ysera"));
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
		[TestMethod, Ignore]
		public void TheBeast_EX1_577()
		{
			// TODO TheBeast_EX1_577 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("The Beast"));
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
		[TestMethod, Ignore]
		public void PriestessOfElune_EX1_583()
		{
			// TODO PriestessOfElune_EX1_583 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Priestess of Elune"));
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
		[TestMethod, Ignore]
		public void AncientMage_EX1_584()
		{
			// TODO AncientMage_EX1_584 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ancient Mage"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_586] Sea Giant - COST:10 [ATK:8/HP:8] 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Costs (1) less for each other minion on the battlefield.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void SeaGiant_EX1_586()
		{
			// TODO SeaGiant_EX1_586 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sea Giant"));
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
		[TestMethod, Ignore]
		public void BloodKnight_EX1_590()
		{
			// TODO BloodKnight_EX1_590 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Blood Knight"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_595] Cult Master - COST:4 [ATK:4/HP:2] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever one of your other minions dies, draw a card.
		// --------------------------------------------------------
		[TestMethod]
		public void CultMaster_EX1_595()
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
            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Cult Master"));
            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Novice Engineer"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion2));
            Assert.AreEqual(1, game.CurrentOpponent.NumCardsDrawnThisTurn);
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var minion3 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Cult Master"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion3));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var spell1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Arcane Explosion"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell1));
            var spell2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Arcane Explosion"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell2));
            Assert.AreEqual(0, game.CurrentOpponent.NumCardsDrawnThisTurn);
        }

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_597] Imp Master - COST:3 [ATK:1/HP:5] 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]At the end of your turn, deal
		//       1 damage to this minion
		//        and summon a 1/1 Imp.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void ImpMaster_EX1_597()
		{
			// TODO ImpMaster_EX1_597 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Imp Master"));
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
		[TestMethod]
		public void IllidanStormrage_EX1_614()
		{
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.PALADIN,
                Player2HeroClass = CardClass.PRIEST,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Illidan Stormrage"));
            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bloodfen Raptor"));

            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));

            Assert.AreEqual(3, game.CurrentPlayer.Board.Count);
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
		[TestMethod, Ignore]
		public void ManaWraith_EX1_616()
		{
			// TODO ManaWraith_EX1_616 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Mana Wraith"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_620] Molten Giant - COST:25 [ATK:8/HP:8] 
		// - Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Costs (1) less for each damage your hero has taken.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void MoltenGiant_EX1_620()
		{
			// TODO MoltenGiant_EX1_620 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Molten Giant"));
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
		// - REQ_TARGET_WITH_RACE = 14
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void HungryCrab_NEW1_017()
		{
			// TODO HungryCrab_NEW1_017 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Hungry Crab"));
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
		[TestMethod]
		public void BloodsailRaider_NEW1_018()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bloodsail Raider"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));
            Assert.AreEqual(2, ((Minion)minion1).AttackDamage);
            Assert.AreEqual(3, ((Minion)minion1).Health);
            var weapon = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Arcanite Reaper"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, weapon));
            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bloodsail Raider"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));
            Assert.AreEqual(7, ((Minion)minion2).AttackDamage);
            Assert.AreEqual(3, ((Minion)minion2).Health);

        }

		// --------------------------------------- MINION - NEUTRAL
		// [NEW1_019] Knife Juggler - COST:2 [ATK:2/HP:2] 
		// - Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]After you summon a
		//       minion, deal 1 damage
		//       to a random enemy.
		// --------------------------------------------------------
		[TestMethod]
		public void KnifeJuggler_NEW1_019()
		{
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.PALADIN,
                Player2HeroClass = CardClass.PRIEST,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Knife Juggler"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

            game.Process(HeroPowerTask.Any(game.CurrentPlayer));

            Assert.AreEqual(29, game.CurrentOpponent.Hero.Health);
        }

		// --------------------------------------- MINION - NEUTRAL
		// [NEW1_020] Wild Pyromancer - COST:2 [ATK:3/HP:2] 
		// - Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: After you cast a spell, deal 1 damage to ALL minions.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void WildPyromancer_NEW1_020()
		{
			// TODO WildPyromancer_NEW1_020 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Wild Pyromancer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [NEW1_021] Doomsayer - COST:2 [ATK:0/HP:7] 
		// - Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: At the start of your turn, destroy ALL minions.
		// --------------------------------------------------------
		[TestMethod]
		public void Doomsayer_NEW1_021()
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
            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Doomsayer"));
            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Injured Blademaster"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, minion2));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var minion3 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Dread Corsair"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            Assert.AreEqual(true, ((Minion)minion1).IsDead);
            Assert.AreEqual(true, ((Minion)minion2).IsDead);
            Assert.AreEqual(true, ((Minion)minion3).IsDead);
            Assert.AreEqual(0, game.CurrentPlayer.Board.Count);
            Assert.AreEqual(0, game.CurrentOpponent.Board.Count);
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
		[TestMethod]
		public void DreadCorsair_NEW1_022()
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
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Dread Corsair"));
            Assert.AreEqual(4, testCard.Cost);
            game.Process(HeroPowerTask.Any(game.CurrentPlayer));
            Assert.AreEqual(1, game.CurrentPlayer.Hero.Weapon.AttackDamage);
            Assert.AreEqual(3, testCard.Cost);
            var weapon = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Assassin's Blade"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, weapon));
            Assert.AreEqual(3, game.CurrentPlayer.Hero.Weapon.AttackDamage);
            Assert.AreEqual(1, testCard.Cost);
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            Assert.AreEqual(1, game.CurrentPlayer.Board.Count);
            Assert.AreEqual(2, game.CurrentPlayer.RemainingMana);
        }

		// --------------------------------------- MINION - NEUTRAL
		// [NEW1_023] Faerie Dragon - COST:2 [ATK:3/HP:2] 
		// - Race: dragon, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Can't be targeted by spells or Hero Powers.
		// --------------------------------------------------------
		// GameTag:
		// - CANT_BE_TARGETED_BY_ABILITIES = 1
		// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void FaerieDragon_NEW1_023()
		{
			// TODO FaerieDragon_NEW1_023 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Faerie Dragon"));
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
		[TestMethod, Ignore]
		public void CaptainGreenskin_NEW1_024()
		{
			// TODO CaptainGreenskin_NEW1_024 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Captain Greenskin"));
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
		[TestMethod, Ignore]
		public void BloodsailCorsair_NEW1_025()
		{
			// TODO BloodsailCorsair_NEW1_025 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bloodsail Corsair"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [NEW1_026] Violet Teacher - COST:4 [ATK:3/HP:5] 
		// - Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, summon a 1/1 Violet Apprentice.
		// --------------------------------------------------------
		[TestMethod]
		public void VioletTeacher_NEW1_026()
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
            var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Violet Teacher"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, game.CurrentPlayer.Hand[4]));
            Assert.AreEqual(2, game.CurrentPlayer.Board.Count);
            Assert.AreEqual("NEW1_026t", game.CurrentPlayer.Board[1].Card.Id);
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
		[TestMethod]
		public void SouthseaCaptain_NEW1_027()
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

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bloodsail Raider"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));
            Assert.AreEqual(2, ((Minion)minion1).AttackDamage);
            Assert.AreEqual(3, ((Minion)minion1).Health);

            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Southsea Captain"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));

            Assert.AreEqual(3, ((Minion)minion1).AttackDamage);
            Assert.AreEqual(4, ((Minion)minion1).Health);
            Assert.AreEqual(3, ((Minion)minion2).AttackDamage);
            Assert.AreEqual(3, ((Minion)minion2).Health);

            var minion3 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Southsea Captain"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion3));

            Assert.AreEqual(4, ((Minion)minion1).AttackDamage);
            Assert.AreEqual(5, ((Minion)minion1).Health);
            Assert.AreEqual(4, ((Minion)minion2).AttackDamage);
            Assert.AreEqual(4, ((Minion)minion2).Health);
            Assert.AreEqual(4, ((Minion)minion3).AttackDamage);
            Assert.AreEqual(4, ((Minion)minion3).Health);
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
		[TestMethod, Ignore]
		public void MillhouseManastorm_NEW1_029()
		{
			// TODO MillhouseManastorm_NEW1_029 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Millhouse Manastorm"));
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
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void Deathwing_NEW1_030()
		{
			// TODO Deathwing_NEW1_030 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Deathwing"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [NEW1_037] Master Swordsmith - COST:2 [ATK:1/HP:3] 
		// - Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: At the end of your turn, give another random friendly minion +1 Attack.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void MasterSwordsmith_NEW1_037()
		{
			// TODO MasterSwordsmith_NEW1_037 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Master Swordsmith"));
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
		[TestMethod, Ignore]
		public void Gruul_NEW1_038()
		{
			// TODO Gruul_NEW1_038 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Gruul"));
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
		[TestMethod]
		public void Hogger_NEW1_040()
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
            var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Hogger"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            Assert.AreEqual(2, game.CurrentOpponent.Board.Count);
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
		[TestMethod, Ignore]
		public void StampedingKodo_NEW1_041()
		{
			// TODO StampedingKodo_NEW1_041 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stampeding Kodo"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [tt_004] Flesheating Ghoul - COST:3 [ATK:2/HP:3] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever a minion dies, gain +1 Attack.
		// --------------------------------------------------------
		[TestMethod, Ignore]
		public void FlesheatingGhoul_tt_004()
		{
			// TODO FlesheatingGhoul_tt_004 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Flesheating Ghoul"));
		}

	}

}
