#region copyright
// SabberStone, Hearthstone Simulator in C# .NET Core
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
#endregion
using Xunit;

using System.Linq;
using System.Collections.Generic;
using SabberStoneCore.Config;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.PlayerTasks;
using SabberStoneCore.Model.Entities;

using Generic = SabberStoneCore.Actions.Generic;

namespace SabberStoneCoreTest.CardSets.Standard
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
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Lord Jaraxxus"));
		}
	}


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
		[Fact]
		public void MindSpike_EX1_625t()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadowform"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(28, game.CurrentOpponent.Hero.Health);
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
		[Fact]
		public void MindShatter_EX1_625t2()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadowform"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard1));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(28, game.CurrentOpponent.Hero.Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadowform"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard2));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(25, game.CurrentOpponent.Hero.Health);
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
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("INFERNO!"));
		}
	}


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
		[Fact]
		public void Wrath_EX1_154()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.DRUID,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			Minion player1Minon = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ultrasaur"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, player1Minon));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Wrath"));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wrath"));

			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, player1Minon, 1));
			Assert.Equal(11, player1Minon.Health);
			Assert.Equal(7, game.CurrentPlayer.HandZone.Count);

			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard2, player1Minon, 2));
			Assert.Equal(10, player1Minon.Health);
			Assert.Equal(7, game.CurrentPlayer.HandZone.Count);
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
		[Fact]
		public void MarkOfNature_EX1_155()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.DRUID,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Mark of Nature"));
			var minion = (Minion)Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, minion, 1));

			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mark of Nature"));
			var minion2 = (Minion)Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard2, minion2, 2));

			Assert.Equal(5, minion.AttackDamage);
			Assert.Equal(1, minion.Health);

			Assert.Equal(1, minion2.AttackDamage);
			Assert.Equal(5, minion2.Health);
			Assert.True(minion2.HasTaunt);
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
		[Fact]
		public void SoulOfTheForest_EX1_158()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.DRUID,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Soul of the Forest"));
			var minion1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			game.Process(HeroAttackTask.Any(game.CurrentPlayer, minion1));
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
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
		[Fact]
		public void PowerOfTheWild_EX1_160()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Power of the Wild"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell1, 1));

			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);

			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Power of the Wild"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell2, 2));

			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(4, game.CurrentPlayer.BoardZone[1].AttackDamage);
			Assert.Equal(3, game.CurrentPlayer.BoardZone[1].Health);
			Assert.Equal(2, ((Minion)minion1).AttackDamage);
			Assert.Equal(2, ((Minion)minion1).Health);
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
		[Fact(Skip = "ignore")]
		public void Naturalize_EX1_161()
		{
			// TODO Naturalize_EX1_161 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.DRUID,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact(Skip = "ignore")]
		public void Nourish_EX1_164()
		{
			// TODO Nourish_EX1_164 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.DRUID,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void Bite_EX1_570()
		{
			// TODO Bite_EX1_570 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.DRUID,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bite"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(25, game.CurrentOpponent.Hero.Health);
			Assert.Equal(5, game.CurrentPlayer.Hero.Armor);
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
		[Fact]
		public void ForceOfNature_EX1_571()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.DRUID,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Force of Nature"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
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
		[Fact]
		public void Savagery_EX1_578()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.DRUID,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);

			// player 1 draws and plays Enchanted Raven (1 mana)
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Enchanted Raven"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));

			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);

			// player 1 plays claw to get hero attack (1 mana, +2 attack)
			IPlayable clawSpell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Claw"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, clawSpell));

			Assert.Equal(2, game.CurrentPlayer.Hero.Armor);

			// casts Savagery on its own minion (1 mana)
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Savagery"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, (ICharacter)minion));

			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);
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
		[Fact(Skip = "ignore")]
		public void Starfall_NEW1_007()
		{
			// TODO Starfall_NEW1_007 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.DRUID,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void DruidOfTheClaw_EX1_165()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.DRUID,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Druid of the Claw"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1, 1));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.False(game.CurrentPlayer.BoardZone[0].HasTaunt);
			Assert.True(game.CurrentPlayer.BoardZone[0].HasCharge);
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.BoardZone[0], game.CurrentOpponent.Hero));

			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Druid of the Claw"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2, 2));
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			Assert.True(game.CurrentPlayer.BoardZone[1].HasTaunt);
			Assert.Equal(6, game.CurrentPlayer.BoardZone[1].Health);

			Assert.Equal(26, game.CurrentOpponent.Hero.Health);
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
		[Fact]
		public void KeeperOfTheGrove_EX1_166()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Keeper of the Grove"),
					Cards.FromName("Mark of the Wild"),
					Cards.FromName("Keeper of the Grove")
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, "Keeper of the Grove", game.CurrentOpponent.Hero, 1));
			Assert.Equal(28, game.CurrentOpponent.Hero.Health);
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, "Mark of the Wild", game.CurrentPlayer.BoardZone[0]));
			Assert.Equal(4, game.CurrentPlayer.BoardZone[0].Health);
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, "Keeper of the Grove", game.CurrentPlayer.BoardZone[0], 2));
			Assert.Equal(2, game.CurrentPlayer.BoardZone[0].Health);
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
		[Fact]
		public void AncientOfWar_EX1_178()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ancient of War"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1, 1));
			game.CurrentPlayer.UsedMana = 0;
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ancient of War"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2, 2));
			game.CurrentPlayer.UsedMana = 0;

			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(5, ((Minion)minion1).AttackDamage);
			Assert.Equal(10, ((Minion)minion1).Health);
			Assert.True(((Minion)minion1).HasTaunt);

			Assert.Equal(10, ((Minion)minion2).AttackDamage);
			Assert.Equal(5, ((Minion)minion2).Health);
			Assert.False(((Minion)minion2).HasTaunt);
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
		[Fact]
		public void Cenarius_EX1_573()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.DRUID,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cenarius"));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cenarius"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1, 2));
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
			game.CurrentPlayer.UsedMana = 0;
			Assert.Equal(2, game.CurrentPlayer.BoardZone[1].Health);
			Assert.Equal(2, game.CurrentPlayer.BoardZone[1].AttackDamage);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2, 1));
			Assert.Equal(4, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(4, game.CurrentPlayer.BoardZone[1].Health);
			Assert.Equal(4, game.CurrentPlayer.BoardZone[1].AttackDamage);
			Assert.Equal(10, game.CurrentPlayer.BoardZone[0].Health);
			Assert.Equal(7, game.CurrentPlayer.BoardZone[0].AttackDamage);
			Assert.Equal(8, game.CurrentPlayer.BoardZone[3].Health);
			Assert.Equal(5, game.CurrentPlayer.BoardZone[3].AttackDamage);
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
		[Fact]
		public void AncientOfLore_NEW1_008()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.Player1.Hero.Damage = 5;

			Assert.Equal(25, game.Player1.Hero.Health);

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ancient of Lore"));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion1, game.Player1.Hero, 2));
			game.Player1.UsedMana = 0;
			Assert.Equal(30, game.Player1.Hero.Health);

			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ancient of Lore"));

			Assert.Equal(1, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2, 1));

			Assert.Equal(2, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);
		}
	}


	public class HunterExpert1Test
	{
		// ----------------------------------------- SPELL - HUNTER
		// [EX1_533] Misdirection - COST:2 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When an enemy attacks your hero, instead it attacks another random character.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		[Fact]
		public void Misdirection_EX1_533()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.HUNTER,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Misdirection"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Worgen Infiltrator"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Raider"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion, game.CurrentOpponent.Hero));
			Assert.True(game.CurrentPlayer.Hero.Health == 29 || game.CurrentOpponent.BoardZone.Count == 1);
			//Assert.Equal(0, game.CurrentOpponent.BoardZone.Triggers.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Misdirection"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard2));;
			IPlayable cleaner = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twisting Nether"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, cleaner));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));


			IPlayable weapon = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eaglehorn Bow"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, weapon));
			IPlayable anotherMinion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, anotherMinion));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, anotherMinion, game.CurrentOpponent.Hero));
			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);
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
		[Fact]
		public void ExplosiveShot_EX1_537()
		{
			// TODO ExplosiveShot_EX1_537 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.HUNTER,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));
			game.CurrentPlayer.UsedMana = 0;
			var minion2 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));
			game.CurrentPlayer.UsedMana = 0;
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion3));
			game.CurrentPlayer.UsedMana = 0;
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Explosive Shot"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, minion2));
			Assert.Equal(3, ((Minion)minion1).Health);
			Assert.True(((Minion)minion2).IsDead);
			Assert.Equal(3, ((Minion)minion3).Health);
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
		[Fact]
		public void UnleashTheHounds_EX1_538()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.HUNTER,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));
			game.CurrentPlayer.UsedMana = 0;
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));
			game.CurrentPlayer.UsedMana = 0;
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion3));
			game.CurrentPlayer.UsedMana = 0;
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unleash the Hounds"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(3, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
			Assert.True(game.CurrentPlayer.BoardZone[0].CanAttack);
			Assert.True(game.CurrentPlayer.BoardZone[1].CanAttack);
			Assert.True(game.CurrentPlayer.BoardZone[2].CanAttack);
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
		[Fact]
		public void Flare_EX1_544()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.HUNTER,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			// player 1 draws and plays explosive Trap and Cat Trick
			IPlayable explosiveTrap = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Explosive Trap"));
			IPlayable catTrick = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cat Trick"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, explosiveTrap));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, catTrick));
			Assert.Equal(2, game.CurrentPlayer.SecretZone.Count);

			// player 1 draws and plays WorgenInfiltrator_EX1_010 (stealth)
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Worgen Infiltrator"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.True(((Minion)minion).HasStealth);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			// player 2 draws and plays Flare
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flare"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));

			Assert.False(((Minion)minion).HasStealth);
			Assert.Equal(0, game.CurrentPlayer.Opponent.SecretZone.Count);

			// play a charge minion to test deactivated Secret and check if Cat Trick was not activated
			IPlayable chargeMinion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, chargeMinion));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, chargeMinion, game.CurrentOpponent.Hero));
			Assert.Equal(29, game.CurrentPlayer.Opponent.Hero.Health);
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
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
		[Fact]
		public void BestialWrath_EX1_549()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.HUNTER,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bestial Wrath"));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Oasis Snapjaw"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard1, (ICharacter)minion1));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion1, (ICharacter)minion2));
			Assert.Equal(2, ((Minion)minion1).Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion1, (ICharacter)minion2));
			Assert.True(((Minion)minion1).IsDead);
		}

		// ----------------------------------------- SPELL - HUNTER
		// [EX1_554] Snake Trap - COST:2 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When one of your minions is attacked, summon three 1/1 Snakes.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		[Fact]
		public void SnakeTrap_EX1_554()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.ROGUE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var minion1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Snake Trap"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(1, game.CurrentPlayer.SecretZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			game.Process(HeroAttackTask.Any(game.CurrentPlayer, minion1));
			Assert.Equal(4, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal(0, game.CurrentOpponent.SecretZone.Count); 
		}

		// ----------------------------------------- SPELL - HUNTER
		// [EX1_609] Snipe - COST:2 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> After your opponent plays a minion, deal $4 damage to it. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		[Fact]
		public void Snipe_EX1_609()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.HUNTER,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Snipe"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(1, game.CurrentPlayer.SecretZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Boulderfist Ogre"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			Assert.Equal(3, ((Minion)minion1).Health);
			Assert.Equal(0, game.CurrentOpponent.SecretZone.Count);
		}

		// ----------------------------------------- SPELL - HUNTER
		// [EX1_610] Explosive Trap - COST:2 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When your hero is attacked, deal $2 damage to all enemies. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		[Fact]
		public void ExplosiveTrap_EX1_610()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.HUNTER,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Explosive Trap"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(1, game.CurrentPlayer.SecretZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Boulderfist Ogre"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion2, game.CurrentOpponent.Hero));
			Assert.Equal(5, ((Minion)minion1).Health);
			Assert.True(((Minion)minion2).IsDead);
			Assert.Equal(0, game.CurrentOpponent.SecretZone.Count);
			Assert.Equal(28, game.CurrentPlayer.Hero.Health);
		}

		// ----------------------------------------- SPELL - HUNTER
		// [EX1_611] Freezing Trap - COST:2 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When an enemy minion attacks, return it to its owner's hand. It costs (2) more.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		[Fact]
		public void FreezingTrap_EX1_611()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.HUNTER,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			IPlayable trap = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Freezing Trap"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, trap));
			Assert.Equal(1, game.CurrentPlayer.SecretZone.Count);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);

			int cardsInHand = game.CurrentPlayer.HandZone.Count;
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion, game.CurrentOpponent.Hero));
			Assert.Equal(cardsInHand + 1, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);
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
		[Fact]
		public void DeadlyShot_EX1_617()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.HUNTER,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Deadly Shot"));
			Assert.Equal(3, game.CurrentOpponent.BoardZone.Count);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(2, game.CurrentOpponent.BoardZone.Count);
		}

		// ---------------------------------------- MINION - HUNTER
		// [EX1_531] Scavenging Hyena - COST:2 [ATK:2/HP:2] 
		// - Race: beast, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever a friendly Beast dies, gain +2/+1.
		// --------------------------------------------------------
		[Fact]
		public void ScavengingHyena_EX1_531()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Scavenging Hyena"));
			var minion1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Raider"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(2, ((Minion)testCard).AttackDamage);
			Assert.Equal(2, ((Minion)testCard).Health);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));
			Assert.Equal(4, ((Minion)testCard).AttackDamage);
			Assert.Equal(3, ((Minion)testCard).Health);
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Explosion"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));
			Assert.Equal(4, ((Minion)testCard).AttackDamage);
			Assert.Equal(2, ((Minion)testCard).Health);
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
				Player2HeroClass = CardClass.HUNTER,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact(Skip = "ignore")]
		public void KingKrush_EX1_543()
		{
			// TODO KingKrush_EX1_543 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.HUNTER,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void GladiatorsLongbow_DS1_188()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.HUNTER,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gladiator's Longbow"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(5, game.CurrentPlayer.Hero.Weapon.AttackDamage);
			Assert.Equal(2, game.CurrentPlayer.Hero.Weapon.Durability);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroAttackTask.Any(game.CurrentPlayer, minion));
			Assert.Equal(30, game.CurrentPlayer.Hero.Health);
			Assert.False(game.CurrentPlayer.Hero.IsImmune);

			Game clone = game.Clone();
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
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		[Fact]
		public void EaglehornBow_EX1_536()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.HUNTER,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eaglehorn Bow"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Explosive Trap"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(0, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal(2, game.CurrentOpponent.Hero.Weapon.Durability);
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion, game.CurrentOpponent.Hero));
			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(3, game.CurrentOpponent.Hero.Weapon.Durability);
		}
	}


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
		[Fact]
		public void Blizzard_CS2_028()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blizzard"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Boulderfist Ogre"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(5, ((Minion)minion1).Health);
			Assert.True(((Minion)minion1).IsFrozen);
			Assert.True(((Minion)minion2).IsDead);
		}

		// ------------------------------------------- SPELL - MAGE
		// [EX1_179] Icicle - COST:2 
		// - Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Deal $2 damage to a minion. If it's <b>Frozen</b>, draw a card. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Icicle_EX1_179()
		{
			// TODO Icicle_EX1_179 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Icicle"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Icicle"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Icicle"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [EX1_180] Tome of Intellect - COST:1 
		// - Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Add a random Mage spell to your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TomeOfIntellect_EX1_180()
		{
			// TODO TomeOfIntellect_EX1_180 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tome of Intellect"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tome of Intellect"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tome of Intellect"));
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
		[Fact]
		public void ConeOfCold_EX1_275()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Boulderfist Ogre"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cone of Cold"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, (ICharacter) minion2));
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
			Assert.True(((Minion)minion1).IsFrozen);
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
		[Fact(Skip = "ignore")]
		public void Pyroblast_EX1_279()
		{
			// TODO Pyroblast_EX1_279 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		// RefTag:
		// - COUNTER = 1
		// --------------------------------------------------------
		[Fact]
		public void Counterspell_EX1_287()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Counterspell"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));
			Assert.Equal(1, game.CurrentPlayer.SecretZone.Count);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Animal Companion"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell2));
			Assert.Equal(0, game.CurrentOpponent.SecretZone.Count);
			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
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
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		[Fact]
		public void IceBarrier_EX1_289()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ice Barrier"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(1, game.CurrentOpponent.SecretZone.Count);
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion, game.CurrentOpponent.Hero));
			Assert.Equal(0, game.CurrentOpponent.SecretZone.Count);
			Assert.Equal(7, game.CurrentOpponent.Hero.Armor);
		}

		// ------------------------------------------- SPELL - MAGE
		// [EX1_294] Mirror Entity - COST:3 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> After your opponent plays a minion, summon a copy of it.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		[Fact]
		public void MirrorEntity_EX1_294()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mirror Entity"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
		}

		// ------------------------------------------- SPELL - MAGE
		// [EX1_594] Vaporize - COST:3 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When a minion attacks your hero, destroy it.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		[Fact]
		public void Vaporize_EX1_594()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vaporize"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));
			Assert.Equal(1, game.CurrentPlayer.SecretZone.Count);
			//Assert.Equal(1, game.CurrentOpponent.BoardZone.Triggers.Count);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, (Minion)minion, game.CurrentOpponent.Hero));
			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);
			//Assert.Equal(0, game.CurrentPlayer.BoardZone.Triggers.Count);
		}

		// ------------------------------------------- SPELL - MAGE
		// [tt_010] Spellbender - COST:3 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When an enemy casts a spell on a minion, summon a 1/3 as the new target.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		[Fact]
		public void Spellbender_tt_010()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spellbender"));
			game.ProcessCard("Knife Juggler");
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable buff = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blessing of Might"));
			var minion = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, buff, minion));


			Assert.Equal(3, minion.AttackDamage);
			Assert.Equal(2, game.CurrentOpponent.BoardZone.Count);

			Minion spellBender = game.CurrentOpponent.BoardZone[1];
			Assert.Equal(4, spellBender.AttackDamage);
			Assert.Equal(3, spellBender.Health);
		}

		// ------------------------------------------ MINION - MAGE
		// [EX1_274] Ethereal Arcanist - COST:4 [ATK:3/HP:3] 
		// - Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: If you control a <b>Secret</b> at_the end of your turn, gain +2/+2.
		// --------------------------------------------------------
		// RefTag:
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		[Fact]
		public void EtherealArcanist_EX1_274()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ethereal Arcanist"));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ethereal Arcanist"));
			IPlayable secret = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mirror Entity"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, secret));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(7, ((Minion)testCard1).AttackDamage);
			Assert.Equal(7, ((Minion)testCard1).Health);
			Assert.Equal(7, ((Minion)testCard2).AttackDamage);
			Assert.Equal(7, ((Minion)testCard2).Health);
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
		[Fact]
		public void ArchmageAntonidas_EX1_559()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Archmage Antonidas"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, game.CurrentPlayer.HandZone[4]));
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
			Assert.Equal("CS2_029", game.CurrentPlayer.HandZone[5].Card.Id);
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
		[Fact]
		public void SorcerersApprentice_EX1_608()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sorcerer's Apprentice"));
			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pyroblast"));
			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			Assert.Equal(10, spell1.Cost);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(9, spell1.Cost);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, (ICharacter) testCard));
			Assert.Equal(10, spell1.Cost);
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
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		[Fact]
		public void KirinTorMage_EX1_612()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Ice Barrier"),
					Cards.FromName("Ice Block")
				},
				Player2HeroClass = CardClass.MAGE,
				FillDecks = false
			});
			game.StartGame();
			game.Player1.BaseMana = 3;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Kirin Tor Mage"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ice Barrier"));
			Assert.Equal(1, game.CurrentPlayer.SecretZone.Count);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ice Block"));
			Assert.Equal(1, game.CurrentPlayer.SecretZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kirin Tor Mage"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard2));
			Assert.Single(game.Auras);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Empty(game.Auras);

			// History = false
			var game2 = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Ice Barrier"),
					Cards.FromName("Ice Block")
				},
				Player2HeroClass = CardClass.MAGE,
				FillDecks = false,
				History = false,
			});
			game2.StartGame();
			game2.Player1.BaseMana = 3;
			game2.Player2.BaseMana = 10;
			IPlayable testCard3 = Generic.DrawCard(game2.CurrentPlayer, Cards.FromName("Kirin Tor Mage"));
			game2.Process(PlayCardTask.Any(game2.CurrentPlayer, testCard3));
			game2.Process(PlayCardTask.Any(game2.CurrentPlayer, "Ice Barrier"));
			Assert.Equal(1, game2.CurrentPlayer.SecretZone.Count);
			game2.Process(PlayCardTask.Any(game2.CurrentPlayer, "Ice Block"));
			Assert.Equal(1, game2.CurrentPlayer.SecretZone.Count);
			game2.Process(EndTurnTask.Any(game2.CurrentPlayer));

			IPlayable testCard4 = Generic.DrawCard(game2.CurrentPlayer, Cards.FromName("Kirin Tor Mage"));
			game2.Process(PlayCardTask.Any(game2.CurrentPlayer, testCard4));
			Assert.Single(game2.Auras);
			game2.Process(EndTurnTask.Any(game2.CurrentPlayer));
			Assert.Empty(game2.Auras);
		}

		// ------------------------------------------ MINION - MAGE
		// [NEW1_012] Mana Wyrm - COST:1 [ATK:1/HP:3] 
		// - Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, gain +1 Attack.
		// --------------------------------------------------------
		[Fact]
		public void ManaWyrm_NEW1_012()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mana Wyrm"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, game.CurrentPlayer.HandZone[4]));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(2, ((Minion)testCard).AttackDamage);
		}
	}


	public class PaladinExpert1Test
	{
		// ---------------------------------------- SPELL - PALADIN
		// [EX1_130] Noble Sacrifice - COST:1 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When an enemy attacks, summon a 2/1 Defender as the new target.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NobleSacrifice_EX1_130()
		{
			// TODO NobleSacrifice_EX1_130 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = true,
				FillDecksPredictably = true
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
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		[Fact]
		public void EyeForAnEye_EX1_132()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eye for an Eye"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(1, game.CurrentOpponent.SecretZone.Count);
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion, game.CurrentOpponent.Hero));
			Assert.Equal(0, game.CurrentOpponent.SecretZone.Count);
			Assert.Equal(29, game.CurrentPlayer.Hero.Health);
		}

		// ---------------------------------------- SPELL - PALADIN
		// [EX1_136] Redemption - COST:1 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When one of your minions dies, return it to life with 1 Health.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		[Fact]
		public void Redemption_EX1_136()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			Minion minion1 = (Minion)Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Goldshire Footman"));
			Minion minion2 = (Minion)Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Acidic Swamp Ooze"));
			Minion minion3 = (Minion)Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			Minion minion4 = (Minion)Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostwolf Grunt"));
			Minion minion5 = (Minion)Generic.DrawCard(game.CurrentPlayer, Cards.FromName("River Crocolisk"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion3));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion5));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion4));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));

			Spell testCard = (Spell) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Redemption"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Spell flamestrike = (Spell)Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flamestrike"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, flamestrike));

			Assert.True(minion1.IsDead && minion2.IsDead && minion3.IsDead && minion4.IsDead);
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal("Bloodfen Raptor", game.CurrentOpponent.BoardZone[0].Card.Name);
			Assert.Equal(1, game.CurrentOpponent.BoardZone[0].Health);
		}

		// ---------------------------------------- SPELL - PALADIN
		// [EX1_349] Divine Favor - COST:3 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Draw cards until you have as many in hand as your opponent.
		// --------------------------------------------------------
		[Fact]
		public void DivineFavor_EX1_349()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Player1.HandZone.ToList().ForEach(p => Generic.DiscardBlock(game.Player1, p));
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Divine Favor"));
			Assert.Equal(1, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(5, game.CurrentPlayer.Opponent.HandZone.Count);
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
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact(Skip = "ignore")]
		public void BlessedChampion_EX1_355()
		{
			// TODO BlessedChampion_EX1_355 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void BlessingOfWisdom_EX1_363()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blessing of Wisdom"));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, (ICharacter) minion));
			Assert.Equal(4, game.CurrentPlayer.HandZone.Count);
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion, game.CurrentOpponent.Hero));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
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
		[Fact]
		public void HolyWrath_EX1_365()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Holy Wrath"));

			Assert.Equal(1, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);

			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, game.CurrentOpponent.Hero));

			Assert.Equal(2, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);
			Assert.Equal(30 - game.CurrentPlayer.HandZone[4].Card.Cost, game.CurrentOpponent.Hero.Health);
		}

		// ---------------------------------------- SPELL - PALADIN
		// [EX1_379] Repentance - COST:1 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> After your opponent plays a minion, reduce its Health to 1.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		[Fact]
		public void Repentance_EX1_379()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Repentance"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(1, ((Minion)minion).Health);
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
		[Fact(Skip = "ignore")]
		public void AvengingWrath_EX1_384()
		{
			// TODO AvengingWrath_EX1_384 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void Equality_EX1_619()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Equality"));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			IPlayable minion4 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion4));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			int totHealth = game.Minions.Sum(p => p.Health);
			Assert.Equal(4, totHealth);
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
		[Fact]
		public void ArgentProtector_EX1_362()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			var minion1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Argent Protector"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Argent Protector"));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion2, minion1));

			Assert.True(((Minion)minion1).HasDivineShield);
			Assert.False(((Minion)minion2).HasDivineShield);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));

			Assert.False(((Minion)minion1).HasDivineShield);
			Assert.Equal(((Minion)minion1).Card[GameTag.HEALTH], ((Minion)minion1).Health);
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
		[Fact]
		public void AldorPeacekeeper_EX1_382()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Aldor Peacekeeper"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tirion Fordring"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard, (ICharacter) minion));
			Assert.Equal(1, ((Minion)minion).AttackDamage);
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
		[Fact]
		public void TirionFordring_EX1_383()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tirion Fordring"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, testCard));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, testCard));
			Assert.True(testCard.ToBeDestroyed);
			Assert.True(game.CurrentOpponent.Hero.Weapon != null);
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
		[Fact]
		public void SwordOfJustice_EX1_366()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.PALADIN,
					Player2HeroClass = CardClass.PALADIN,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.StartGame();
			game.CurrentPlayer.BaseMana = 10;

			IPlayable weapon = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sword of Justice"));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragonling Mechanic"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragonling Mechanic"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, weapon));

			Assert.Equal(5, game.CurrentPlayer.Hero.Weapon.Durability);

			game.CurrentPlayer.UsedMana = 0;

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			Assert.Equal(2, game.CurrentPlayer.BoardZone[0].AttackDamage);
			Assert.Equal(2, game.CurrentPlayer.BoardZone[0].Health);
			Assert.Equal(4, game.CurrentPlayer.Hero.Weapon.Durability);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			Assert.Equal(3, ((Minion)minion1).AttackDamage);
			Assert.Equal(5, ((Minion)minion1).Health);
			Assert.Equal(3, game.CurrentPlayer.BoardZone[2].AttackDamage);
			Assert.Equal(2, game.CurrentPlayer.BoardZone[2].Health);
			Assert.Equal(2, game.CurrentPlayer.Hero.Weapon.Durability);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			Assert.Equal(3, ((Minion)minion2).AttackDamage);
			Assert.Equal(5, ((Minion)minion2).Health);
			Assert.Equal(3, game.CurrentPlayer.BoardZone[4].AttackDamage);
			Assert.Equal(2, game.CurrentPlayer.BoardZone[4].Health);
			Assert.Null(game.CurrentPlayer.Hero.Weapon);
		}
	}


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
		[Fact]
		public void InnerFire_CS1_129()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Inner Fire"));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, (ICharacter) minion));
			Assert.Equal(2, ((Minion)minion).AttackDamage);
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
		[Fact(Skip = "ignore")]
		public void Silence_EX1_332()
		{
			// TODO Silence_EX1_332 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void ShadowMadness_EX1_334()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Frostbolt")
				},
				Player2HeroClass = CardClass.PRIEST,
				Player2Deck = new List<Card>
				{
					Cards.FromName("Holy Smite")
				},
				FillDecks = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var apprentice = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sorcerer's Apprentice"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, apprentice));
			Assert.Equal(1, game.CurrentPlayer.HandZone[0].Cost);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Shadow Madness"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard, apprentice));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(0, game.CurrentPlayer.HandZone[0].Cost);
			Assert.Equal(2, game.CurrentOpponent.HandZone[0].Cost);
			IPlayable shield = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Power Word: Shield"));
			Assert.Equal(0, game.CurrentPlayer.HandZone[0].Cost);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, shield, apprentice));
			Assert.Equal(4, apprentice.Health);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(1, game.CurrentPlayer.HandZone[0].Cost);
			Assert.Equal(4, apprentice.Health);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable silence = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Silence"));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadow Madness"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard2, apprentice));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, silence, apprentice));
			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
		}

		// ----------------------------------------- SPELL - PRIEST
		// [EX1_339] Thoughtsteal - COST:3 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Copy 2 cards in your opponent's deck and add them to your hand.
		// --------------------------------------------------------
		[Fact]
		public void Thoughtsteal_EX1_339()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Thoughtsteal"));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
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
		[Fact]
		public void Mindgames_EX1_345()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mindgames"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
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
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact(Skip = "ignore")]
		public void HolyFire_EX1_624()
		{
			// TODO HolyFire_EX1_624 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void Shadowform_EX1_625()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadowform"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard1));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(28, game.CurrentOpponent.Hero.Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadowform"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard2));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(25, game.CurrentOpponent.Hero.Health);
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
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void CabalShadowPriest_EX1_091()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cabal Shadow Priest"));
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard, (ICharacter) minion));
			Assert.Equal(0, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
		}

		// ---------------------------------------- MINION - PRIEST
		// [EX1_335] Lightspawn - COST:4 [ATK:0/HP:5] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: This minion's Attack is always equal to its Health.
		// --------------------------------------------------------
		[Fact]
		public void Lightspawn_EX1_335()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lightspawn"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(5, ((Minion)testCard).Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, testCard));
			Assert.Equal(4, ((Minion)testCard).Health);
		}

		// ---------------------------------------- MINION - PRIEST
		// [EX1_341] Lightwell - COST:2 [ATK:0/HP:5] 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: At the start of your turn, restore 3 Health to a damaged friendly character.
		// --------------------------------------------------------
		[Fact]
		public void Lightwell_EX1_341()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lightwell"));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Injured Blademaster"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(6, ((Minion)minion).Health);
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
		[Fact]
		public void ProphetVelen_EX1_350()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Prophet Velen"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Holy Smite"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, spell, game.CurrentOpponent.Hero));
			Assert.Equal(4, game.CurrentOpponent.Hero.Damage);

			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(0, game.CurrentOpponent.Hero.Damage);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));


			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Raider"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Northshire Cleric"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			//	the effect shouldn't be applied to spells unaffected by spelldmg
			IPlayable betrayal = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Betrayal"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, betrayal, (ICharacter) minion1));
			Assert.Equal(1, ((Minion) minion2).Health);

			////	lifesteal interaction
			//IPlayable spiritLash = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spirit Lash"));
			//game.CurrentPlayer.Hero.Damage = 20;
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, spiritLash));
			//Assert.Equal(0, game.CurrentOpponent.BoardZone.Count);
			//Assert.Equal(8, game.CurrentPlayer.Hero.Damage);
			game.CurrentPlayer.Hero.Damage = 8;

			IPlayable thalnos = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodmage Thalnos"));
			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Holy Smite"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, thalnos));
			Assert.Equal(0, game.CurrentOpponent.Hero.Damage);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, spell2, game.CurrentOpponent.Hero));
			Assert.Equal(6, game.CurrentOpponent.Hero.Damage);

			game.CurrentPlayer.UsedMana = 0;

			IPlayable secondVelen = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Prophet Velen"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, secondVelen));
			IPlayable spell3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Holy Smite"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, spell3, game.CurrentOpponent.Hero));
			Assert.Equal(18, game.CurrentOpponent.Hero.Damage);	// 6 + ((2 + 1) * 2 * 2) = 18
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
		[Fact]
		public void AuchenaiSoulpriest_EX1_591()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Auchenai Soulpriest"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(28, game.CurrentOpponent.Hero.Health);
			IPlayable pain = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadow Word: Pain"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, pain, (ICharacter) testCard));
			game.CurrentPlayer.Hero.HeroPower.IsExhausted = false;
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(30, game.CurrentOpponent.Hero.Health);
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
		[Fact(Skip = "ignore")]
		public void TempleEnforcer_EX1_623()
		{
			// TODO TempleEnforcer_EX1_623 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Temple Enforcer"));
		}
	}


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
		[Fact]
		public void ColdBlood_CS2_073()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			var minion1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cold Blood"));
			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cold Blood"));

			Assert.Equal(3, minion1.AttackDamage);

			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, minion1));

			Assert.Equal(5, minion1.AttackDamage);

			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, minion1));

			Assert.Equal(9, minion1.AttackDamage);
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
		[Fact]
		public void BladeFlurry_CS2_233()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.ROGUE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Leper Gnome"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blade Flurry"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));

			Assert.True(((Minion)minion1).IsDead);
			Assert.Null(game.CurrentPlayer.Hero.Weapon);
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
		[Fact]
		public void Eviscerate_EX1_124()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eviscerate"));
			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eviscerate"));

			Assert.Equal(30, game.CurrentOpponent.Hero.Health);

			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, game.CurrentOpponent.Hero));

			Assert.Equal(28, game.CurrentOpponent.Hero.Health);

			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, game.CurrentOpponent.Hero));

			Assert.Equal(24, game.CurrentOpponent.Hero.Health);
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
		[Fact]
		public void Betrayal_EX1_126()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.CurrentPlayer.UsedMana = 0;
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chillwind Yeti"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.CurrentPlayer.UsedMana = 0;
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("War Golem"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			game.CurrentPlayer.UsedMana = 0;

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Betrayal"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, (ICharacter) minion2));

			Assert.Equal(1, ((Minion)minion1).Health);
			Assert.Equal(5, ((Minion)minion2).Health);
			Assert.Equal(3, ((Minion)minion3).Health);
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
		[Fact]
		public void Headcrack_EX1_137()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.ROGUE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Headcrack"));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Headcrack"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard1));
			Assert.Equal(28, game.CurrentOpponent.Hero.Health);
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(5, game.CurrentOpponent.HandZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard2));
			Assert.Equal(26, game.CurrentOpponent.Hero.Health);
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(6, game.CurrentOpponent.HandZone.Count);
			Assert.Equal(testCard1.Card.Id, game.CurrentOpponent.HandZone[5].Card.Id);
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
		[Fact]
		public void Shadowstep_EX1_144()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));

			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(4, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(1, minion2.Cost);

			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion2, game.CurrentOpponent.Hero));
			Assert.Equal(1, game.CurrentOpponent.Hero.Damage);

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadowstep"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, (ICharacter) minion2));

			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(0, minion2.Cost);

			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));

			Assert.True(((Minion)minion2).CanAttack);
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion2, game.CurrentOpponent.Hero));
			Assert.Equal(2, game.CurrentOpponent.Hero.Damage);


			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadowstep"));
			IPlayable agent = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("SI:7 Agent"));

			Assert.True(game.CurrentPlayer.IsComboActive);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, agent, game.CurrentOpponent.Hero));
			Assert.Equal(4, game.CurrentOpponent.Hero.Damage);

			game.Process(PlayCardTask.Any(game.CurrentPlayer, spell2, (ICharacter)agent));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(1, agent.Cost);

			game.Process(PlayCardTask.Any(game.CurrentPlayer, agent, game.CurrentOpponent.Hero));
			Assert.Equal(6, game.CurrentOpponent.Hero.Damage);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable agent2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("SI:7 Agent"));
			Assert.False(game.CurrentPlayer.IsComboActive);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, agent2));
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(6, game.CurrentOpponent.Hero.Damage);

			IPlayable spell3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadowstep"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, spell3, (ICharacter) agent2));
			Assert.True(game.CurrentPlayer.IsComboActive);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, agent2, game.CurrentOpponent.Hero));
			Assert.Equal(8, game.CurrentOpponent.Hero.Damage);

		}

		// ------------------------------------------ SPELL - ROGUE
		// [EX1_145] Preparation - COST:0 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: The next spell you cast this turn costs (3) less.
		// --------------------------------------------------------
		[Fact]
		public void Preparation_EX1_145()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.ROGUE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Preparation"));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Preparation"));
			IPlayable sprint = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sprint"));
			IPlayable eviscerate = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eviscerate"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
			Assert.Equal(4, sprint.Cost);
			Assert.Equal(0, eviscerate.Cost);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, sprint));
			Assert.Equal(2, eviscerate.Cost);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard2));
			Assert.Equal(0, eviscerate.Cost);
		}

		// ------------------------------------------ SPELL - ROGUE
		// [EX1_182] Pilfer - COST:1 
		// - Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Add a random card to your hand <i>(from your opponent's class)</i>.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Pilfer_EX1_182()
		{
			// TODO Pilfer_EX1_182 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Pilfer"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pilfer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Pilfer"));
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
		[Fact]
		public void DefiasRingleader_EX1_131()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.Player1.Hero.Damage = 5;

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Defias Ringleader"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Defias Ringleader"));

			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));

			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
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
				Player2HeroClass = CardClass.ROGUE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact(Skip = "ignore")]
		public void PatientAssassin_EX1_522()
		{
			// TODO PatientAssassin_EX1_522 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.ROGUE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void EdwinVancleef_EX1_613()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Edwin VanCleef"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Edwin VanCleef"));

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

			Assert.Equal(2, ((ICharacter)minion1).Health);
			Assert.Equal(2, ((ICharacter)minion1).AttackDamage);

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));

			Assert.Equal(4, ((ICharacter)minion2).Health);
			Assert.Equal(4, ((ICharacter)minion2).AttackDamage);
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
				Player2HeroClass = CardClass.ROGUE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact(Skip = "ignore")]
		public void MasterOfDisguise_NEW1_014()
		{
			// TODO MasterOfDisguise_NEW1_014 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.ROGUE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact(Skip = "ignore")]
		public void PerditionsBlade_EX1_133()
		{
			// TODO PerditionsBlade_EX1_133 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.ROGUE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Perdition's Blade"));
		}
	}


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
		[Fact]
		public void AncestralSpirit_CS2_038()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ancestral Spirit"));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, (ICharacter) minion));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, (ICharacter) minion));
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
			Assert.NotEqual(minion, game.CurrentOpponent.BoardZone[0]);
			Assert.Equal(minion.Card.Id, game.CurrentOpponent.BoardZone[0].Card.Id);
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [CS2_053] Far Sight - COST:3 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Draw a card. That card costs (3) less.
		// --------------------------------------------------------
		[Fact]
		public void FarSight_CS2_053()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.SHAMAN,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Far Sight"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			IPlayable drawedCard = game.CurrentPlayer.HandZone[game.CurrentPlayer.HandZone.Count - 1];
			int cost = drawedCard.Card.Cost - 3;
			Assert.Equal(cost < 0 ? 0 : cost, drawedCard.Cost);
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
		[Fact]
		public void LightningBolt_EX1_238()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();

			Assert.Equal(30, game.CurrentOpponent.Hero.Health);

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lightning Bolt"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, game.CurrentOpponent.Hero));

			Assert.Equal(27, game.CurrentOpponent.Hero.Health);
			Assert.Equal(1, game.CurrentPlayer.OverloadOwed);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(0, game.CurrentPlayer.OverloadOwed);
			Assert.Equal(1, game.CurrentPlayer.OverloadLocked);
			Assert.Equal(1, game.CurrentPlayer.RemainingMana);
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
		[Fact(Skip = "ignore")]
		public void LavaBurst_EX1_241()
		{
			// TODO LavaBurst_EX1_241 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.SHAMAN,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact(Skip = "ignore")]
		public void EarthShock_EX1_245()
		{
			// TODO EarthShock_EX1_245 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.SHAMAN,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void FeralSpirit_EX1_248()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Feral Spirit"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));

			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			Assert.True(game.CurrentPlayer.BoardZone[0].HasTaunt);
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
		[Fact(Skip = "ignore")]
		public void ForkedLightning_EX1_251()
		{
			// TODO ForkedLightning_EX1_251 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.SHAMAN,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void LightningStorm_EX1_259()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.SHAMAN,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chillwind Yeti"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.CurrentPlayer.UsedMana = 0;
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chillwind Yeti"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.CurrentPlayer.UsedMana = 0;
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chillwind Yeti"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			game.CurrentPlayer.UsedMana = 0;
			IPlayable minion4 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chillwind Yeti"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion4));
			game.CurrentPlayer.UsedMana = 0;
			IPlayable minion5 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chillwind Yeti"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion5));
			game.CurrentPlayer.UsedMana = 0;
			IPlayable minion6 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chillwind Yeti"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion6));
			game.CurrentPlayer.UsedMana = 0;
			IPlayable minion7 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chillwind Yeti"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion7));
			game.CurrentPlayer.UsedMana = 0;
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(35, ((Minion)minion1).Health + ((Minion)minion2).Health + ((Minion)minion3).Health
								+ ((Minion)minion4).Health + ((Minion)minion5).Health
								+ ((Minion)minion6).Health + ((Minion)minion7).Health);
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lightning Storm"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.NotEqual(31, ((Minion)minion1).Health + ((Minion)minion2).Health + ((Minion)minion3).Health
								   + ((Minion)minion4).Health + ((Minion)minion5).Health
								   + ((Minion)minion6).Health + ((Minion)minion7).Health);
			Assert.NotEqual(24, ((Minion)minion1).Health + ((Minion)minion2).Health + ((Minion)minion3).Health
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
		[Fact]
		public void DustDevil_EX1_243()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.SHAMAN,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dust Devil"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));

			Assert.Equal(2, game.CurrentPlayer.OverloadOwed);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(0, game.CurrentPlayer.OverloadOwed);
			Assert.Equal(2, game.CurrentPlayer.OverloadLocked);
			Assert.Equal(0, game.CurrentPlayer.RemainingMana);

			game.Process(PlayCardTask.Spell(game.CurrentPlayer, game.CurrentPlayer.HandZone[4]));

			Assert.Equal(0, game.CurrentPlayer.OverloadOwed);
			Assert.Equal(2, game.CurrentPlayer.OverloadLocked);
			Assert.Equal(1, game.CurrentPlayer.RemainingMana);
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
		[Fact(Skip = "ignore")]
		public void EarthElemental_EX1_250()
		{
			// TODO EarthElemental_EX1_250 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.SHAMAN,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void UnboundElemental_EX1_258()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.SHAMAN,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unbound Elemental"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Feral Spirit"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));

			Assert.Equal(2, ((Minion)minion1).AttackDamage);
			Assert.Equal(4, ((Minion)minion1).Health);

			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));

			Assert.Equal(3, ((Minion)minion1).AttackDamage);
			Assert.Equal(5, ((Minion)minion1).Health);
		}

		// ---------------------------------------- MINION - SHAMAN
		// [EX1_575] Mana Tide Totem - COST:3 [ATK:0/HP:3] 
		// - Race: totem, Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: At the end of your turn, draw a card.
		// --------------------------------------------------------
		[Fact]
		public void ManaTideTotem_EX1_575()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.SHAMAN,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mana Tide Totem"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(4, game.CurrentPlayer.HandZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(5, game.CurrentOpponent.HandZone.Count);
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
		[Fact(Skip = "ignore")]
		public void AlakirTheWindlord_NEW1_010()
		{
			// TODO AlakirTheWindlord_NEW1_010 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.SHAMAN,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact(Skip = "ignore")]
		public void StormforgedAxe_EX1_247()
		{
			// TODO StormforgedAxe_EX1_247 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.SHAMAN,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void Doomhammer_EX1_567()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.SHAMAN,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Doomhammer"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(28, game.CurrentOpponent.Hero.Health);
			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(26, game.CurrentOpponent.Hero.Health);
			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(26, game.CurrentOpponent.Hero.Health);
		}
	}


	public class WarlockExpert1Test
	{
		// ---------------------------------------- SPELL - WARLOCK
		// [EX1_181] Call of the Void - COST:1 
		// - Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Add a random Demon to your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CallOfTheVoid_EX1_181()
		{
			// TODO CallOfTheVoid_EX1_181 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Call of the Void"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Call of the Void"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Call of the Void"));
		}

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
		[Fact]
		public void Shadowflame_EX1_303()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadowflame"));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, (ICharacter) minion1));
			Assert.True(minion1.ToBeDestroyed);
			Assert.True(minion2.ToBeDestroyed);
			Assert.Equal(1, ((Minion)minion3).Health);
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
		[Fact(Skip = "ignore")]
		public void SiphonSoul_EX1_309()
		{
			// TODO SiphonSoul_EX1_309 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact(Skip = "ignore")]
		public void TwistingNether_EX1_312()
		{
			// TODO TwistingNether_EX1_312 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Twisting Nether"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [EX1_317] Sense Demons - COST:3 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Draw 2 Demons
		//       from your deck.
		// --------------------------------------------------------
		[Fact]
		public void SenseDemons_EX1_317()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Bloodfen Raptor"),
					Cards.FromName("Bloodfen Raptor"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Voidwalker"),
					Cards.FromName("Voidwalker")
				},
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true,
				FillDecksPredictably = true,
				Shuffle = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sense Demons"));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(Race.DEMON, game.CurrentPlayer.HandZone[5].Card.Race);
			Assert.Equal(Race.DEMON, game.CurrentPlayer.HandZone[4].Card.Race);
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
		[Fact]
		public void BaneOfDoom_EX1_320()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bane of Doom"));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, (ICharacter) minion));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.True(minion.ToBeDestroyed);
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
		[Fact]
		public void Demonfire_EX1_596()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Demonfire"));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Demonfire"));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Voidwalker"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Voidwalker"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard1, (ICharacter) minion1));
			Assert.Equal(3, ((Minion)minion1).AttackDamage);
			Assert.Equal(5, ((Minion)minion1).Health);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard2, (ICharacter) minion2));
			Assert.Equal(1, ((Minion)minion2).AttackDamage);
			Assert.Equal(1, ((Minion)minion2).Health);
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
		[Fact]
		public void BloodImp_CS2_059()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blood Imp"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(2, ((ICharacter)minion2).Health);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(3, ((ICharacter)minion2).Health);
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
		[Fact]
		public void Felguard_EX1_301()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 5;
			game.Player2.BaseMana = 5;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Felguard"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(4, game.CurrentPlayer.BaseMana);
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
		[Fact]
		public void VoidTerror_EX1_304()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Bloodfen Raptor"),
					Cards.FromName("Void Terror")
				},
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true,
				FillDecksPredictably = true,
				Shuffle = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Bloodfen Raptor"));
			Minion minionA = game.CurrentPlayer.BoardZone[0];
			Minion minionB = game.CurrentPlayer.BoardZone[1];
			Assert.Equal(1, minionA.AttackDamage);
			Assert.Equal(1, minionA.Health);
			Assert.Equal(3, minionB.AttackDamage);
			Assert.Equal(2, minionB.Health);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Void Terror", null, 1));
			Minion minion = game.CurrentPlayer.BoardZone[0];
			Assert.True(minionA.IsDead);
			Assert.True(minionB.IsDead);
			Assert.Equal(7, minion.AttackDamage);
			Assert.Equal(6, minion.Health);
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
		[Fact(Skip = "ignore")]
		public void Doomguard_EX1_310()
		{
			// TODO Doomguard_EX1_310 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact(Skip = "ignore")]
		public void PitLord_EX1_313()
		{
			// TODO PitLord_EX1_313 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void SummoningPortal_EX1_315()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Frostwolf Grunt"),
					Cards.FromName("Magma Rager"),
					Cards.FromName("Chillwind Yeti")
				},
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = false,
				Shuffle = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			Assert.Equal(1, game.CurrentPlayer.HandZone[0].Cost);
			Assert.Equal(2, game.CurrentPlayer.HandZone[1].Cost);
			Assert.Equal(3, game.CurrentPlayer.HandZone[2].Cost);
			Assert.Equal(4, game.CurrentPlayer.HandZone[3].Cost);

			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Summoning Portal"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));

			Assert.Equal(1, game.CurrentPlayer.HandZone[0].Cost);
			Assert.Equal(1, game.CurrentPlayer.HandZone[1].Cost);
			Assert.Equal(1, game.CurrentPlayer.HandZone[2].Cost);
			Assert.Equal(2, game.CurrentPlayer.HandZone[3].Cost);

			IPlayable silence = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Silence"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, silence, (ICharacter) testCard));

			Assert.Equal(1, game.CurrentPlayer.HandZone[0].Cost);
			Assert.Equal(2, game.CurrentPlayer.HandZone[1].Cost);
			Assert.Equal(3, game.CurrentPlayer.HandZone[2].Cost);
			Assert.Equal(4, game.CurrentPlayer.HandZone[3].Cost);
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
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void LordJaraxxus_EX1_323()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lord Jaraxxus"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
			game.CurrentPlayer.UsedMana = 0;
			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(15, game.CurrentPlayer.Hero.Health);
			Assert.Equal(3, game.CurrentPlayer.Hero.TotalAttackDamage);
		}
	}


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
		[Fact]
		public void Rampage_CS2_104()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();

			var minion1 = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rampage"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, minion1));
			Assert.Equal(6, minion1.AttackDamage);
			Assert.Equal(7, minion1.Health);
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
		[Fact]
		public void Slam_EX1_391()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.WARRIOR,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Slam"));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chillwind Yeti"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, (ICharacter) minion));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
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
		[Fact]
		public void BattleRage_EX1_392()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Battle Rage"));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Explosion"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(7, game.CurrentPlayer.HandZone.Count);
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
		[Fact]
		public void Brawl_EX1_407()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.WARRIOR,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Brawl"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count + game.CurrentOpponent.BoardZone.Count);
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
		[Fact(Skip = "ignore")]
		public void MortalStrike_EX1_408()
		{
			// TODO MortalStrike_EX1_408 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.WARRIOR,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void Upgrade_EX1_409()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.WARRIOR,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			Assert.Null(game.CurrentPlayer.Hero.Weapon);
			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Upgrade!"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell1));
			Assert.Equal(1, game.CurrentPlayer.Hero.Weapon.AttackDamage);
			Assert.Equal(3, game.CurrentPlayer.Hero.Weapon.Durability);
			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Upgrade!"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell2));
			Assert.Equal(2, game.CurrentPlayer.Hero.Weapon.AttackDamage);
			Assert.Equal(4, game.CurrentPlayer.Hero.Weapon.Durability);
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
		[Fact]
		public void ShieldSlam_EX1_410()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.WARRIOR,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			Assert.Equal(2, game.CurrentPlayer.Hero.Armor);
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shield Slam"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, (ICharacter) minion));
			Assert.True(minion.ToBeDestroyed);
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
		[Fact]
		public void InnerRage_EX1_607()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.WARRIOR,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Inner Rage"));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Aldor Peacekeeper"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(3, ((Minion)minion).AttackDamage);
			Assert.Equal(3, ((Minion)minion).Health);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, (ICharacter) minion));
			Assert.Equal(5, ((Minion)minion).AttackDamage);
			Assert.Equal(2, ((Minion)minion).Health);
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [NEW1_036] Commanding Shout - COST:2 
		// - Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Your minions can't be reduced below 1 Health this turn. Draw a card.
		// --------------------------------------------------------
		[Fact]
		public void CommandingShout_NEW1_036()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.WARRIOR,
				Player2Deck = new List<Card>
				{
					Cards.FromName("Stormwind Knight"),
					Cards.FromName("Stormwind Knight"),
				},
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			var opMinion1 = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Magma Rager"));
			var opMinion2 = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Magma Rager"));
			var opMinion3 = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, opMinion1));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, opMinion2));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, opMinion3));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			var minion1 = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stormwind Knight"));
			var minion2 = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stormwind Knight"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Commanding Shout"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));

			foreach (Minion m in game.CurrentPlayer.BoardZone)
				Assert.Equal(1, m[GameTag.HEALTH_MINIMUM]);

			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion1, opMinion1));
			Assert.True(opMinion1.IsDead);
			Assert.Equal(1, minion1.Health);

			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion2, opMinion3));
			Assert.True(opMinion3.IsDead);
			Assert.Equal(2, minion2.Health);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			foreach (Minion m in game.CurrentOpponent.BoardZone)
				Assert.Equal(0, m[GameTag.HEALTH_MINIMUM]);

			game.Process(MinionAttackTask.Any(game.CurrentPlayer, opMinion2, minion1));
			Assert.True(opMinion2.IsDead);
			Assert.True(minion1.IsDead);

			// Silence cannot remove the enchantment
			// applied before AfterSummonTrigger is triggered
			// A minion having Health 1 does not trigger DamageTrigger
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
		[Fact(Skip = "ignore")]
		public void ArathiWeaponsmith_EX1_398()
		{
			// TODO ArathiWeaponsmith_EX1_398 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.WARRIOR,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void Armorsmith_EX1_402()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.WARRIOR,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Armorsmith"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion, (ICharacter) testCard));
			Assert.Equal(1, game.CurrentOpponent.Hero.Armor);
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
		[Fact(Skip = "ignore")]
		public void GrommashHellscream_EX1_414()
		{
			// TODO GrommashHellscream_EX1_414 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.WARRIOR,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact(Skip = "ignore")]
		public void CruelTaskmaster_EX1_603()
		{
			// TODO CruelTaskmaster_EX1_603 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.WARRIOR,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void FrothingBerserker_EX1_604()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var minion1 = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frothing Berserker"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			Assert.Equal(2, minion1.AttackDamage);
			Assert.Equal(4, minion1.Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));
			Assert.Equal(3, minion1.AttackDamage);
			Assert.Equal(3, minion1.Health);
			var minion2 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion2));

			Assert.Equal(4, minion1.AttackDamage);
			Assert.Equal(3, minion1.Health);

			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));

			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion3, minion1));
			Assert.Equal(6, minion1.AttackDamage);
			Assert.Equal(2, minion1.Health);
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
		[Fact]
		public void Gorehowl_EX1_411()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.WARRIOR,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gorehowl"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard1));
			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(23, game.CurrentOpponent.Hero.Health);
			Assert.True(game.CurrentOpponent.Hero.Weapon == null);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			var minion1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gorehowl"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard2));
			game.Process(HeroAttackTask.Any(game.CurrentPlayer, minion1));

			Assert.Equal(23, game.CurrentOpponent.Hero.Health);
			Assert.Equal(29, game.CurrentPlayer.Hero.Health);
			Assert.Equal(1, game.CurrentPlayer.Hero.Weapon.Durability);
			Assert.Equal(6, game.CurrentPlayer.Hero.Weapon.AttackDamage);
		}
	}


	public class NeutralExpert1Test
	{
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void SouthseaDeckhand_CS2_146()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			Minion minion1 = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Southsea Deckhand"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

			Assert.False(minion1.HasCharge);

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));

			Assert.True(minion1.HasCharge);

			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion1, game.CurrentOpponent.Hero));
			Assert.Equal(1, minion1.NumAttacksThisTurn);

			game.ProcessCard("Shadowstep", minion1);

			Assert.Equal(Zone.HAND, minion1.Zone.Type);

			game.ProcessCard(minion1);

			Assert.True(minion1.HasCharge);
			Assert.False(minion1.IsExhausted);
			Assert.Equal(0, minion1.NumAttacksThisTurn);
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact(Skip = "ignore")]
		public void RavenholdtAssassin_CS2_161()
		{
			// TODO RavenholdtAssassin_CS2_161 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact(Skip = "ignore")]
		public void YoungDragonhawk_CS2_169()
		{
			// TODO YoungDragonhawk_CS2_169 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void InjuredBlademaster_CS2_181()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Injured Blademaster"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

			Assert.Equal(3, ((ICharacter)minion1).Health);
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
		[Fact(Skip = "ignore")]
		public void AbusiveSergeant_CS2_188()
		{
			// TODO AbusiveSergeant_CS2_188 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact(Skip = "ignore")]
		public void IronbeakOwl_CS2_203()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Leper Gnome"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

			Assert.True(((Minion)minion1).HasDeathrattle);

			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ironbeak Owl"));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion2, (ICharacter) minion1));

			Assert.False(((Minion)minion1).HasDeathrattle);
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
		[Fact]
		public void SpitefulSmith_CS2_221()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			var minion1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spiteful Smith"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));

			Assert.Equal(1, game.CurrentPlayer.Hero.TotalAttackDamage);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));

			Assert.Equal(3, game.CurrentOpponent.Hero.Weapon.AttackDamage);

			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ironbeak Owl"));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion2, minion1));

			Assert.Equal(1, game.CurrentOpponent.Hero.Weapon.AttackDamage);
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
		[Fact]
		public void VentureCoMercenary_CS2_227()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
				},
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			int costA = game.CurrentPlayer.HandZone[0].Cost;

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Venture Co. Mercenary"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

			Assert.Equal(costA + 3, game.CurrentPlayer.HandZone[0].Cost);

			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ironbeak Owl"));

			game.CurrentPlayer.UsedMana = 0;
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion2, (ICharacter) minion1));

			Assert.Equal(costA, game.CurrentPlayer.HandZone[0].Cost);
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void Lightwarden_EX1_001()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lightwarden"));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, testCard));
			Assert.Equal(3, ((Minion)testCard).AttackDamage);
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
		[Fact]
		public void TheBlackKnight_EX1_002()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			var minion1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

			var minion3 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion3));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Black Knight"));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion2, minion3));

			Assert.False(minion3.IsDead);

			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion2, minion1));

			Assert.True(minion1.IsDead);
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact(Skip = "ignore")]
		public void BigGameHunter_EX1_005()
		{
			// TODO BigGameHunter_EX1_005 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void AlarmOBot_EX1_006()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Alarm-o-Bot"),
					Cards.FromName("Loot Hoarder"),
					Cards.FromName("Acolyte of Pain")
				},
				Player2HeroClass = CardClass.WARRIOR,
				FillDecks = false,
				Shuffle = false

			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, game.CurrentPlayer.HandZone[0]));
			Assert.Equal("Alarm-o-Bot", game.CurrentPlayer.BoardZone[0].Card.Name);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, game.CurrentPlayer.HandZone[0]));
			Assert.Equal("Loot Hoarder", game.CurrentPlayer.BoardZone[1].Card.Name);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(1, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);

			// make sure that the cards are swapped into the same position 
			Assert.Equal("Acolyte of Pain", game.CurrentPlayer.BoardZone[0].Card.Name);
			Assert.Equal("Alarm-o-Bot", game.CurrentPlayer.HandZone[0].Card.Name);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_007] Acolyte of Pain - COST:3 [ATK:1/HP:3] 
		// - Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever this minion takes damage, draw a_card.
		// --------------------------------------------------------
		[Fact]
		public void AcolyteOfPain_EX1_007()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			var minion1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Acolyte of Pain"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

			Assert.Equal(1, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);

			game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));

			Assert.Equal(2, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));

			Assert.Equal(2, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);
			Assert.True(minion1.IsDead);
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void AngryChicken_EX1_009()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			var minion1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Angry Chicken"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shattered Sun Cleric"));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion2, minion1));

			Assert.Equal(2, minion1.Health);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));

			Assert.Equal(7, minion1.AttackDamage);

			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ironbeak Owl"));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion3, minion1));

			Assert.Equal(1, minion1.Health);
			Assert.False(minion1.IsDead);
			Assert.Equal(Zone.PLAY, minion1.Zone.Type);
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void BloodmageThalnos_EX1_012()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			var minion1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodmage Thalnos"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

			Assert.Equal(1, game.CurrentPlayer.CurrentSpellPower);

			Assert.Equal(1, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);

			game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));

			Assert.Equal(2, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);
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
		[Fact]
		public void KingMukla_EX1_014()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			int handCount = game.CurrentOpponent.HandZone.Count;

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("King Mukla"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

			Assert.Equal(handCount + 2, game.CurrentOpponent.HandZone.Count);
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact(Skip = "ignore")]
		public void ScarletCrusader_EX1_020()
		{
			// TODO ScarletCrusader_EX1_020 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact(Skip = "ignore")]
		public void ThrallmarFarseer_EX1_021()
		{
			// TODO ThrallmarFarseer_EX1_021 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact(Skip = "ignore")]
		public void SilvermoonGuardian_EX1_023()
		{
			// TODO SilvermoonGuardian_EX1_023 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact(Skip = "ignore")]
		public void StranglethornTiger_EX1_028()
		{
			// TODO StranglethornTiger_EX1_028 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void LeperGnome_EX1_029()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			var minion1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Leper Gnome"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));

			Assert.Equal(28, game.CurrentOpponent.Hero.Health);
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact(Skip = "ignore")]
		public void WindfuryHarpy_EX1_033()
		{
			// TODO WindfuryHarpy_EX1_033 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void TwilightDrake_EX1_043()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			IPlayable minion11 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twilight Drake"));
			int countHand = game.CurrentPlayer.HandZone.Count;
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion11));

			Assert.Equal(countHand, ((Minion)minion11).Health);

			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ironbeak Owl"));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion3, (ICharacter) minion11));

			Assert.Equal(1, ((Minion)minion11).Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_044] Questing Adventurer - COST:3 [ATK:2/HP:2] 
		// - Fac: alliance, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you play a card, gain +1/+1.
		// --------------------------------------------------------
		[Fact]
		public void QuestingAdventurer_EX1_044()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Questing Adventurer"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostbolt"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));

			Assert.Equal(3, ((Minion)minion1).AttackDamage);
			Assert.Equal(3, ((Minion)minion1).Health);

			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, game.CurrentOpponent.Hero));

			Assert.Equal(4, ((Minion)minion1).AttackDamage);
			Assert.Equal(4, ((Minion)minion1).Health);
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void DarkIronDwarf_EX1_046()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

			Assert.Equal(3, ((Minion)minion1).AttackDamage);

			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dark Iron Dwarf"));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion2, (ICharacter) minion1));

			Assert.Equal(5, ((Minion)minion1).AttackDamage);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(3, ((Minion)minion1).AttackDamage);
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
		[Fact(Skip = "ignore")]
		public void Spellbreaker_EX1_048()
		{
			// TODO Spellbreaker_EX1_048 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void YouthfulBrewmaster_EX1_049()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			var minion11 = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion11));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion11));

			Assert.Equal(1, minion11.Health);

			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Youthful Brewmaster"));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion3, minion11));

			Assert.Equal(2, minion11.Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_055] Mana Addict - COST:2 [ATK:1/HP:3] 
		// - Fac: alliance, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, gain +2 Attack this turn.
		// --------------------------------------------------------
		[Fact]
		public void ManaAddict_EX1_055()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2Deck = new List<Card>
				{
					Cards.FromId("GAME_005"),
					Cards.FromId("GAME_005"),
					Cards.FromId("GAME_005"),
					Cards.FromId("GAME_005"),
					Cards.FromId("GAME_005"),
					Cards.FromId("GAME_005"),
					Cards.FromId("GAME_005"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			var testCard = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mana Addict"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
			//int i = 1;
			//foreach (Spell coin in game.CurrentPlayer.HandZone)
			//{
			//	game.Process(PlayCardTask.Any(game.CurrentPlayer, coin));
			//	Assert.Equal(1 + 2 * i, testCard.AttackDamage);
			//	i++;
			//}
			for (int i = 5; i >= 0; i--)
			{
				game.Process(PlayCardTask.Any(game.CurrentPlayer, game.CurrentPlayer.HandZone[i]));
				Assert.Equal(1 + 2 * (6 - i), testCard.AttackDamage);
			}
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(1, (testCard).AttackDamage);
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
		[Fact(Skip = "ignore")]
		public void AncientBrewmaster_EX1_057()
		{
			// TODO AncientBrewmaster_EX1_057 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void SunfuryProtector_EX1_058()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sunfury Protector"));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard, null, 1));
			Assert.True(((Minion)minion1).HasTaunt);
			Assert.True(((Minion)minion2).HasTaunt);
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
		[Fact]
		public void CrazedAlchemist_EX1_059()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Crazed Alchemist"));
			var minion1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stormwind Champion"));
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shattered Sun Cleric"));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blessing of Might"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion3, minion1));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, minion1));
			Assert.Equal(5, ((Minion)minion1).AttackDamage);
			Assert.Equal(2, ((Minion)minion1).Health);
			game.CurrentPlayer.UsedMana = 0;
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard, minion1));
			Assert.Equal(3, ((Minion)minion1).AttackDamage);
			Assert.Equal(6, ((Minion)minion1).Health);
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void PintSizedSummoner_EX1_076()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pint-Sized Summoner"));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(2, minion1.Cost);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(1, minion1.Cost);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			Assert.Equal(2, minion2.Cost);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_080] Secretkeeper - COST:1 [ATK:1/HP:2] 
		// - Fac: alliance, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever a <b>Secret</b> is played, gain +1/+1.
		// --------------------------------------------------------
		// RefTag:
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		[Fact]
		public void Secretkeeper_EX1_080()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mirror Entity"),
					Cards.FromName("Arcane Explosion"),
				},
				Player2HeroClass = CardClass.MAGE,
				Player2Deck = new List<Card>()
				{
					Cards.FromName("Ice Block"),
					Cards.FromName("Mirror Image")
				},
				FillDecks = false,
				Shuffle = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			Minion testCard = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Secretkeeper"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(1, testCard.AttackDamage);
			Assert.Equal(2, testCard.Health);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, game.CurrentPlayer.HandZone[0]));
			Assert.Equal(2, testCard.AttackDamage);
			Assert.Equal(3, testCard.Health);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, game.CurrentPlayer.HandZone[0]));
			Assert.Equal(2, testCard.AttackDamage);
			Assert.Equal(3, testCard.Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, game.CurrentPlayer.HandZone[0]));
			Assert.Equal(3, testCard.AttackDamage);
			Assert.Equal(4, testCard.Health);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, game.CurrentPlayer.HandZone[0]));
			Assert.Equal(3, testCard.AttackDamage);
			Assert.Equal(4, testCard.Health);
			game.CurrentPlayer.BaseMana = 10;
			IPlayable frostbolt = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostbolt"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, frostbolt, testCard));
			Assert.Equal(3, testCard.AttackDamage);
			Assert.Equal(1, testCard.Health);
			IPlayable ironbeakowl = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ironbeak Owl"));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, ironbeakowl, testCard));
			Assert.Equal(1, testCard.AttackDamage);
			Assert.Equal(1, testCard.Health);
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void TinkmasterOverspark_EX1_083()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tinkmaster Overspark"));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.NotEqual(minion1.Card.Id, game.CurrentPlayer.BoardZone[0].Card.Id);
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
		[Fact]
		public void MindControlTech_EX1_085()
		{
			// TODO MindControlTech_EX1_085 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			IPlayable boar1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, boar1));
			IPlayable boar2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, boar2));
			IPlayable boar3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, boar3));
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mind Control Tech"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			IPlayable boar4 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, boar4));
			IPlayable boar5 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, boar5));
			IPlayable boar6 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, boar6));
			Assert.Equal(4, game.CurrentPlayer.BoardZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mind Control Tech"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			Assert.Equal(5, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(3, game.CurrentOpponent.BoardZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mind Control Tech"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			Assert.Equal(5, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(4, game.CurrentOpponent.BoardZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable minion7 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mind Control Tech"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion7));
			Assert.Equal(6, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(4, game.CurrentOpponent.BoardZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable boar7 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, boar7));
			IPlayable boar8 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, boar8));
			Assert.Equal(6, game.CurrentPlayer.BoardZone.Count);

			IPlayable minion8 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mind Control Tech"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion8));
			Assert.Equal(7, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(5, game.CurrentOpponent.BoardZone.Count);
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
		[Fact]
		public void ArcaneGolem_EX1_089()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 1;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Golem"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(2, game.CurrentOpponent.BaseMana);
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
		[Fact]
		public void DefenderOfArgus_EX1_093()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Defender of Argus"));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard, null, 1));
			Assert.Equal(2, ((Minion)minion1).AttackDamage);
			Assert.Equal(2, ((Minion)minion2).AttackDamage);
			Assert.Equal(2, ((Minion)minion1).Health);
			Assert.Equal(2, ((Minion)minion2).Health);
			Assert.True(((Minion)minion1).HasTaunt);
			Assert.True(((Minion)minion2).HasTaunt);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_095] Gadgetzan Auctioneer - COST:6 [ATK:4/HP:4] 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, draw a card.
		// --------------------------------------------------------
		[Fact]
		public void GadgetzanAuctioneer_EX1_095()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 8;
			game.Player2.BaseMana = 8;
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gadgetzan Auctioneer"));
			Assert.Equal(1, game.CurrentPlayer.NumCardsDrawnThisTurn);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, game.CurrentPlayer.HandZone[4]));
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(4, game.CurrentPlayer.RemainingMana);
			Assert.Equal(2, game.CurrentPlayer.NumCardsDrawnThisTurn);
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact(Skip = "ignore")]
		public void Abomination_EX1_097()
		{
			// TODO Abomination_EX1_097 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void LorewalkerCho_EX1_100()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lorewalker Cho"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			Assert.Equal(5, game.CurrentOpponent.HandZone.Count);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, game.CurrentOpponent.Hero));
			Assert.Equal(6, game.CurrentOpponent.HandZone.Count);
			Assert.Equal(spell1.Card.Id, game.CurrentOpponent.HandZone[5].Card.Id);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			Assert.Equal(4, game.CurrentOpponent.HandZone.Count);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, game.CurrentOpponent.Hero));
			Assert.Equal(5, game.CurrentOpponent.HandZone.Count);
			Assert.Equal(spell2.Card.Id, game.CurrentOpponent.HandZone[4].Card.Id);
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact(Skip = "ignore")]
		public void ColdlightSeer_EX1_103()
		{
			// TODO ColdlightSeer_EX1_103 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void MountainGiant_EX1_105()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mountain Giant"));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(8, testCard.Cost);
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void LeeroyJenkins_EX1_116()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Leeroy Jenkins"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.True(game.CurrentPlayer.BoardZone[0].HasCharge);
			Assert.Equal(2, game.CurrentOpponent.BoardZone.Count);
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact(Skip = "ignore")]
		public void EmperorCobra_EX1_170()
		{
			// TODO EmperorCobra_EX1_170 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact(Skip = "ignore")]
		public void BaronGeddon_EX1_249()
		{
			// TODO BaronGeddon_EX1_249 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact(Skip = "ignore")]
		public void FrostElemental_EX1_283()
		{
			// TODO FrostElemental_EX1_283 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Frost Elemental"));
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
		[Fact(Skip = "ignore")]
		public void TaurenWarrior_EX1_390()
		{
			// TODO TaurenWarrior_EX1_390 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact(Skip = "ignore")]
		public void AmaniBerserker_EX1_393()
		{
			// TODO AmaniBerserker_EX1_393 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact(Skip = "ignore")]
		public void MogushanWarden_EX1_396()
		{
			// TODO MogushanWarden_EX1_396 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact(Skip = "ignore")]
		public void Shieldbearer_EX1_405()
		{
			// TODO Shieldbearer_EX1_405 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void RagingWorgen_EX1_412()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			var minion1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Raging Worgen"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

			Assert.Equal(3, minion1.Health);
			Assert.Equal(3, minion1.AttackDamage);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));

			Assert.Equal(2, minion1.Health);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(4, minion1.AttackDamage);

			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion1, game.CurrentOpponent.Hero));

			Assert.Equal(26, game.CurrentOpponent.Hero.Health);

			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion1, game.CurrentOpponent.Hero));

			Assert.Equal(22, game.CurrentOpponent.Hero.Health);

			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion1, game.CurrentOpponent.Hero));

			Assert.Equal(22, game.CurrentOpponent.Hero.Health);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.True(minion1.HasWindfury);

			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ironbeak Owl"));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion3, minion1));

			Assert.Equal(2, minion1.Health);
			Assert.False(minion1.HasWindfury);
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void MurlocTidecaller_EX1_509()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Tidecaller"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Raider"));
			Assert.Equal(1, ((Minion)testCard).AttackDamage);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			Assert.Equal(2, ((Minion)testCard).AttackDamage);
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			Assert.Equal(2, ((Minion)testCard).AttackDamage);
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
		[Fact]
		public void HarvestGolem_EX1_556()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					 Cards.FromName("Harvest Golem"),
					 Cards.FromName("Stonetusk Boar"),
					 Cards.FromName("Stonetusk Boar"),
					 Cards.FromName("Fireball")
				},
				Player2HeroClass = CardClass.MAGE,
				Player2Deck = new List<Card>()
				{
					 Cards.FromName("Fireball")
				},
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Harvest Golem"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Stonetusk Boar"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, "Fireball", game.CurrentOpponent.BoardZone[1]));
			Assert.Equal(3, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal("Damaged Golem", game.CurrentOpponent.BoardZone[1].Card.Name);
			Assert.Equal("skele21", game.CurrentOpponent.BoardZone[1].Card.Id);
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
		[Fact]
		public void NatPagle_EX1_557()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void HarrisonJones_EX1_558()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable weapon = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fiery War Axe"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, weapon));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Harrison Jones"));
			Assert.Equal(7, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(8, game.CurrentPlayer.HandZone.Count);
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
		[Fact]
		public void Nozdormu_EX1_560()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nozdormu"));
			Assert.Equal(75, game.Player1.TimeOut);
			Assert.Equal(75, game.Player2.TimeOut);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(20, game.Player1.TimeOut);
			Assert.Equal(20, game.Player2.TimeOut);
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
		[Fact]
		public void Alexstrasza_EX1_561()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Alexstrasza"));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard1, game.CurrentOpponent.Hero));
			Assert.Equal(15, game.CurrentOpponent.Hero.Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable lordJaraxxus = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lord Jaraxxus"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, lordJaraxxus));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(14, game.CurrentOpponent.Hero.Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Alexstrasza"));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard2, game.CurrentPlayer.Hero));
			Assert.Equal(15, game.CurrentPlayer.Hero.Health);
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact(Skip = "ignore")]
		public void Malygos_EX1_563()
		{
			// TODO Malygos_EX1_563 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void FacelessManipulator_EX1_564()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Faceless Manipulator"));

			Minion target = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			Minion raidLeader = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Raid Leader"));
			Spell blessing = (Spell) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blessing of Kings"));
			Spell frostBolt = (Spell) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostbolt"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, target));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, raidLeader));
			Assert.Equal((2, 1), (target.AttackDamage, target.Health));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, blessing, target));
			Assert.Equal((6, 5), (target.AttackDamage, target.Health));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, frostBolt, target));
			Assert.Equal((6, 2), (target.AttackDamage, target.Health));
			Assert.True(target.IsFrozen);

			game.CurrentPlayer.UsedMana = 0;

			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard, target, 0));

			Minion test = game.CurrentPlayer.BoardZone[0];
			Assert.Equal(1, target.ZonePosition);

			Assert.Equal((6, 2), (test.AttackDamage, test.Health));
			Assert.True(test.IsFrozen);

			Spell frostBolt2 = (Spell)Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostbolt"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, frostBolt2, raidLeader));

			Assert.Equal(5, test.AttackDamage);


			game.EndTurn();
			game.ProcessCard("Faceless Manipulator", target);
			Minion test2 = game.CurrentPlayer.BoardZone.Last();
			Assert.False(test2.IsExhausted);
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
		[Fact]
		public void Ysera_EX1_572()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ysera"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(4, game.CurrentPlayer.HandZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(5, game.CurrentOpponent.HandZone.Count);
			Assert.StartsWith("DREAM", game.CurrentOpponent.HandZone[4].Card.Id);
			IPlayable dreamcard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromId("DREAM_05"));
			IPlayable dreamcard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromId("DREAM_04"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, dreamcard1, (ICharacter) testCard));
			Assert.Equal(9, ((Minion)testCard).AttackDamage);
			Assert.Equal(17, ((Minion)testCard).Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.False(testCard.ToBeDestroyed);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.True(testCard.ToBeDestroyed);
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(Zone.PLAY, minion.Zone.Type);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, dreamcard2, (ICharacter) minion));
			Assert.Equal(Zone.HAND, minion.Zone.Type);
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact(Skip = "ignore")]
		public void PriestessOfElune_EX1_583()
		{
			// TODO PriestessOfElune_EX1_583 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void AncientMage_EX1_584()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ancient Mage"));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard, null, 1));
			Assert.Equal(2, game.CurrentPlayer.CurrentSpellPower);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_586] Sea Giant - COST:10 [ATK:8/HP:8] 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Costs (1) less for each other minion on the battlefield.
		// --------------------------------------------------------
		[Fact]
		public void SeaGiant_EX1_586()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sea Giant"));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			Assert.Equal(10, testCard.Cost);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(9, testCard.Cost);
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
		[Fact]
		public void BloodKnight_EX1_590()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blood Knight"));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Argent Squire"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Argent Squire"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.False(((Minion)minion1).HasDivineShield);
			Assert.False(((Minion)minion2).HasDivineShield);
			Assert.Equal(9, ((Minion)testCard).AttackDamage);
			Assert.Equal(9, ((Minion)testCard).Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_595] Cult Master - COST:4 [ATK:4/HP:2] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever one of your other minions dies, draw a card.
		// --------------------------------------------------------
		[Fact]
		public void CultMaster_EX1_595()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cult Master"));
			var minion2 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Novice Engineer"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion2));
			Assert.Equal(1, game.CurrentOpponent.NumCardsDrawnThisTurn);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cult Master"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion3));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Explosion"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell1));
			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Explosion"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell2));
			Assert.Equal(0, game.CurrentOpponent.NumCardsDrawnThisTurn);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_597] Imp Master - COST:3 [ATK:1/HP:5] 
		// - Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]At the end of your turn, deal
		//       1 damage to this minion
		//        and summon a 1/1 Imp.
		// --------------------------------------------------------
		[Fact]
		public void ImpMaster_EX1_597()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Imp Master"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(5, ((Minion)testCard).Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(2, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal(4, ((Minion)testCard).Health);
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
		[Fact]
		public void IllidanStormrage_EX1_614()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Illidan Stormrage"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));

			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
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
		[Fact]
		public void ManaWraith_EX1_616()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Fireball"),
				},
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mana Wraith"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(2, game.CurrentPlayer.HandZone[0].Cost);
			Assert.Equal(4, game.CurrentPlayer.HandZone[1].Cost);
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
		[Fact]
		public void HungryCrab_NEW1_017()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hungry Crab"));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hungry Crab"));
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Warleader"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard1, minion));
			Assert.True(((Minion)minion).IsDead);
			Assert.Equal(3, ((Minion)testCard1).AttackDamage);
			Assert.Equal(4, ((Minion)testCard1).Health);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
			Assert.Equal(1, ((Minion)testCard2).AttackDamage);
			Assert.Equal(2, ((Minion)testCard2).Health);
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
		[Fact]
		public void BloodsailRaider_NEW1_018()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodsail Raider"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));
			Assert.Equal(2, ((Minion)minion1).AttackDamage);
			Assert.Equal(3, ((Minion)minion1).Health);
			IPlayable weapon = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcanite Reaper"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, weapon));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodsail Raider"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));
			Assert.Equal(7, ((Minion)minion2).AttackDamage);
			Assert.Equal(3, ((Minion)minion2).Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [NEW1_019] Knife Juggler - COST:2 [ATK:2/HP:2] 
		// - Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]After you summon a
		//       minion, deal 1 damage
		//       to a random enemy.
		// --------------------------------------------------------
		[Fact]
		public void KnifeJuggler_NEW1_019()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Knife Juggler"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));

			Assert.Equal(29, game.CurrentOpponent.Hero.Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [NEW1_020] Wild Pyromancer - COST:2 [ATK:3/HP:2] 
		// - Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: After you cast a spell, deal 1 damage to ALL minions.
		// --------------------------------------------------------
		[Fact]
		public void WildPyromancer_NEW1_020()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wild Pyromancer"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, game.CurrentOpponent.Hero));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			Assert.False(((Minion)minion1).IsDead);
			Assert.False(((Minion)minion2).IsDead);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, game.CurrentOpponent.Hero));
			Assert.True(((Minion)minion1).IsDead);
			Assert.True(((Minion)minion2).IsDead);
			Assert.Equal(1, ((Minion)testCard).Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [NEW1_021] Doomsayer - COST:2 [ATK:0/HP:7] 
		// - Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: At the start of your turn, destroy ALL minions.
		// --------------------------------------------------------
		[Fact]
		public void Doomsayer_NEW1_021()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Doomsayer"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Injured Blademaster"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, minion2));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dread Corsair"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.True(((Minion)minion1).IsDead);
			Assert.True(((Minion)minion2).IsDead);
			Assert.True(((Minion)minion3).IsDead);
			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(0, game.CurrentOpponent.BoardZone.Count);
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
		[Fact]
		public void DreadCorsair_NEW1_022()
		{
			var gameConfig = new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			};

			var game = new Game(gameConfig);
			
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dread Corsair"));
			Assert.Equal(4, testCard.Cost);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			Assert.Equal(1, game.CurrentPlayer.Hero.Weapon.AttackDamage);
			Assert.Equal(3, testCard.Cost);
			IPlayable weapon = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Assassin's Blade"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, weapon));
			Assert.Equal(3, game.CurrentPlayer.Hero.Weapon.AttackDamage);
			Assert.Equal(1, testCard.Cost);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(2, game.CurrentPlayer.RemainingMana);
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
		[Fact]
		public void FaerieDragon_NEW1_023()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Faerie Dragon"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, testCard));
			Assert.Equal(2, ((Minion)testCard).Health);
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostbolt"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, testCard));
			Assert.False(((Minion)testCard).IsDead);
			Assert.Equal(2, ((Minion)testCard).Health);
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
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
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
		[Fact]
		public void BloodsailCorsair_NEW1_025()
		{
			// TODO BloodsailCorsair_NEW1_025 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bloodsail Corsair"));
			Assert.Equal(2, game.CurrentOpponent.Hero.Weapon.Durability);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
			Assert.Equal(1, game.CurrentOpponent.Hero.Weapon.Durability);

			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodsail Corsair"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard2));
			Assert.Null(game.CurrentOpponent.Hero.Weapon);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [NEW1_026] Violet Teacher - COST:4 [ATK:3/HP:5] 
		// - Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, summon a 1/1 Violet Apprentice.
		// --------------------------------------------------------
		[Fact]
		public void VioletTeacher_NEW1_026()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Violet Teacher"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, game.CurrentPlayer.HandZone[4]));
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal("NEW1_026t", game.CurrentPlayer.BoardZone[1].Card.Id);
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
		[Fact]
		public void SouthseaCaptain_NEW1_027()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodsail Raider"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));
			Assert.Equal(2, ((Minion)minion1).AttackDamage);
			Assert.Equal(3, ((Minion)minion1).Health);

			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Southsea Captain"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));

			Assert.Equal(3, ((Minion)minion1).AttackDamage);
			Assert.Equal(4, ((Minion)minion1).Health);
			Assert.Equal(3, ((Minion)minion2).AttackDamage);
			Assert.Equal(3, ((Minion)minion2).Health);

			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Southsea Captain"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion3));

			Assert.Equal(4, ((Minion)minion1).AttackDamage);
			Assert.Equal(5, ((Minion)minion1).Health);
			Assert.Equal(4, ((Minion)minion2).AttackDamage);
			Assert.Equal(4, ((Minion)minion2).Health);
			Assert.Equal(4, ((Minion)minion3).AttackDamage);
			Assert.Equal(4, ((Minion)minion3).Health);
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
		[Fact]
		public void MillhouseManastorm_NEW1_029()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Millhouse Manastorm"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostbolt"));
			game.AuraUpdate();
			Assert.Equal(0, spell.Cost);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(2, spell.Cost);
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
		[Fact]
		public void Deathwing_NEW1_030()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Deathwing"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(0, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal(0, game.CurrentPlayer.HandZone.Count);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [NEW1_037] Master Swordsmith - COST:2 [ATK:1/HP:3] 
		// - Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: At the end of your turn, give another random friendly minion +1 Attack.
		// --------------------------------------------------------
		[Fact]
		public void MasterSwordsmith_NEW1_037()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Master Swordsmith"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Raider"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(3, ((Minion)testCard2).AttackDamage);
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
		[Fact]
		public void Gruul_NEW1_038()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gruul"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(8, ((Minion)testCard).AttackDamage);
			Assert.Equal(8, ((Minion)testCard).Health);
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
		[Fact]
		public void Hogger_NEW1_040()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hogger"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(2, game.CurrentOpponent.BoardZone.Count);
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
		[Fact]
		public void StampedingKodo_NEW1_041()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stampeding Kodo"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [tt_004] Flesheating Ghoul - COST:3 [ATK:2/HP:3] 
		// - Fac: neutral, Set: expert1, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever a minion dies, gain +1 Attack.
		// --------------------------------------------------------
		[Fact]
		public void FlesheatingGhoul_tt_004()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flesheating Ghoul"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			var minion1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(2, ((Minion)testCard).AttackDamage);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));
			Assert.Equal(3, ((Minion)testCard).AttackDamage);
		}
	}
}
