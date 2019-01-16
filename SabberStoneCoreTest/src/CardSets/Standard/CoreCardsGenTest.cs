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
using SabberStoneCore.Config;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.PlayerTasks;
using SabberStoneCore.Model.Entities;

using Generic = SabberStoneCore.Actions.Generic;
using System.Collections.Generic;

namespace SabberStoneCoreTest.CardSets.Standard
{

	public class HeroesCoreTest
	{
		// ----------------------------------------- HERO - WARRIOR
		// [HERO_01] Garrosh Hellscream - COST:0 [ATK:0/HP:30] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 725
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GarroshHellscream_HERO_01()
		{
			// TODO GarroshHellscream_HERO_01 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Garrosh Hellscream"));
		}

		// ------------------------------------------ HERO - SHAMAN
		// [HERO_02] Thrall - COST:0 [ATK:0/HP:30] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 687
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Thrall_HERO_02()
		{
			// TODO Thrall_HERO_02 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Thrall"));
		}

		// ------------------------------------------- HERO - ROGUE
		// [HERO_03] Valeera Sanguinar - COST:0 [ATK:0/HP:30] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 730
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ValeeraSanguinar_HERO_03()
		{
			// TODO ValeeraSanguinar_HERO_03 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Valeera Sanguinar"));
		}

		// ----------------------------------------- HERO - PALADIN
		// [HERO_04] Uther Lightbringer - COST:0 [ATK:0/HP:30] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 472
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UtherLightbringer_HERO_04()
		{
			// TODO UtherLightbringer_HERO_04 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Uther Lightbringer"));
		}

		// ------------------------------------------ HERO - HUNTER
		// [HERO_05] Rexxar - COST:0 [ATK:0/HP:30] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 229
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Rexxar_HERO_05()
		{
			// TODO Rexxar_HERO_05 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Rexxar"));
		}

		// ------------------------------------------- HERO - DRUID
		// [HERO_06] Malfurion Stormrage - COST:0 [ATK:0/HP:30] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 1123
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MalfurionStormrage_HERO_06()
		{
			// TODO MalfurionStormrage_HERO_06 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Malfurion Stormrage"));
		}

		// ----------------------------------------- HERO - WARLOCK
		// [HERO_07] Gul'dan - COST:0 [ATK:0/HP:30] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 300
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Guldan_HERO_07()
		{
			// TODO Guldan_HERO_07 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Gul'dan"));
		}

		// -------------------------------------------- HERO - MAGE
		// [HERO_08] Jaina Proudmoore - COST:0 [ATK:0/HP:30] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 807
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JainaProudmoore_HERO_08()
		{
			// TODO JainaProudmoore_HERO_08 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Jaina Proudmoore"));
		}

		// ------------------------------------------ HERO - PRIEST
		// [HERO_09] Anduin Wrynn - COST:0 [ATK:0/HP:30] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// GameTag:
		// - HERO_POWER = 479
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AnduinWrynn_HERO_09()
		{
			// TODO AnduinWrynn_HERO_09 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Anduin Wrynn"));
		}
	}


	public class HeroPowersCoreTest
	{
		// ------------------------------------ HERO_POWER - PRIEST
		// [CS1h_001] Lesser Heal (*) - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Restore #2 Health.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void LesserHeal_CS1h_001()
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
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(29, game.CurrentOpponent.Hero.Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentPlayer.Hero));
			Assert.Equal(30, game.CurrentPlayer.Hero.Health);
		}

		// ------------------------------------- HERO_POWER - DRUID
		// [CS2_017] Shapeshift (*) - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       +1 Attack this turn.    +1 Armor.
		// --------------------------------------------------------
		[Fact]
		public void Shapeshift_CS2_017()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.DRUID,
					Player2HeroClass = CardClass.PRIEST,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.StartGame();

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Northshire Cleric"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(0, game.CurrentPlayer.Hero.Armor);
			Assert.Equal(0, game.CurrentPlayer.Hero.AttackDamage);
			Assert.Equal(3, game.CurrentOpponent.BoardZone[0].Health);

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));

			Assert.Equal(1, game.CurrentPlayer.Hero.Armor);
			Assert.Equal(1, game.CurrentPlayer.Hero.AttackDamage);

			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentOpponent.BoardZone[0]));

			Assert.Equal(0, game.CurrentPlayer.Hero.Armor);
			Assert.Equal(1, game.CurrentPlayer.Hero.AttackDamage);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(0, game.CurrentPlayer.Hero.AttackDamage);
		}

		// -------------------------------------- HERO_POWER - MAGE
		// [CS2_034] Fireblast (*) - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $1 damage. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void Fireblast_CS2_034()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.PRIEST,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.StartGame();

			var minion1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Northshire Cleric"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(3, game.Player1.BoardZone[0].Health);

			game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));

			Assert.Equal(2, game.Player1.BoardZone[0].Health);
		}

		// ------------------------------------ HERO_POWER - SHAMAN
		// [CS2_049] Totemic Call (*) - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a random Totem.
		// --------------------------------------------------------
		// Entourage: CS2_050, CS2_051, CS2_052, NEW1_009
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_ENTIRE_ENTOURAGE_NOT_IN_PLAY = 0
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact]
		public void TotemicCall_CS2_049()
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
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(4, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(4, game.CurrentOpponent.BoardZone.Count);
		}

		// ----------------------------------- HERO_POWER - WARLOCK
		// [CS2_056] Life Tap (*) - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Draw a card and take $2 damage. *spelldmg
		// --------------------------------------------------------
		[Fact]
		public void LifeTap_CS2_056()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.WARLOCK,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.StartGame();

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(1, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);

			Assert.Equal(30, game.CurrentPlayer.Hero.Health);

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));

			Assert.Equal(2, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);
			Assert.Equal(28, game.CurrentPlayer.Hero.Health);
		}

		// ------------------------------------- HERO_POWER - ROGUE
		// [CS2_083b] Dagger Mastery (*) - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Equip a 1/2 Dagger.
		// --------------------------------------------------------
		[Fact]
		public void DaggerMastery_CS2_083b()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.ROGUE,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.StartGame();

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.False(game.CurrentPlayer.Hero.Weapon != null);

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));

			Assert.True(game.CurrentPlayer.Hero.Weapon != null);
			Assert.Equal(1, game.CurrentPlayer.Hero.TotalAttackDamage);
			Assert.Equal(2, game.CurrentPlayer.Hero.Weapon.Durability);
			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(1, game.CurrentPlayer.Hero.Weapon.Durability);
		}

		// ----------------------------------- HERO_POWER - PALADIN
		// [CS2_101] Reinforce (*) - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 1/1 Silver Hand Recruit.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact]
		public void Reinforce_CS2_101()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.PALADIN,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.StartGame();

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));

			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
		}

		// ----------------------------------- HERO_POWER - WARRIOR
		// [CS2_102] Armor Up! (*) - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Gain 2 Armor.
		// --------------------------------------------------------
		[Fact]
		public void ArmorUp_CS2_102()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.WARRIOR,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.StartGame();

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(0, game.CurrentPlayer.Hero.Armor);

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));

			Assert.Equal(2, game.CurrentPlayer.Hero.Armor);
		}

		// ------------------------------------ HERO_POWER - HUNTER
		// [DS1h_292] Steady Shot (*) - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $2 damage to the enemy hero. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_STEADY_SHOT = 0
		// - REQ_MINION_OR_ENEMY_HERO = 0
		// --------------------------------------------------------
		[Fact]
		public void SteadyShot_DS1h_292()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.HUNTER,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.StartGame();

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));

			Assert.Equal(28, game.CurrentPlayer.Opponent.Hero.Health);
		}
	}


	public class DruidCoreTest
	{
		// ------------------------------------------ SPELL - DRUID
		// [CS2_005] Claw - COST:1 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Give your hero +2_Attack this turn. Gain 2 Armor.
		// --------------------------------------------------------
		[Fact]
		public void Claw_CS2_005()
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

			Assert.Equal(0, game.CurrentPlayer.Hero.Armor);

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Claw"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell1));

			Assert.Equal(2, game.CurrentPlayer.Hero.Armor);
			Assert.Equal(2, game.CurrentPlayer.Hero.AttackDamage);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(0, game.CurrentPlayer.Hero.AttackDamage);
		}

		// ------------------------------------------ SPELL - DRUID
		// [CS2_007] Healing Touch - COST:3 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Restore #8 Health.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HealingTouch_CS2_007()
		{
			// TODO HealingTouch_CS2_007 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Healing Touch"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [CS2_008] Moonfire - COST:0 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $1 damage. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Moonfire_CS2_008()
		{
			// TODO Moonfire_CS2_008 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Moonfire"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [CS2_009] Mark of the Wild - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Give a minion <b>Taunt</b> and +2/+2.<i>
		//       (+2 Attack/+2 Health)</i>
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact]
		public void MarkOfTheWild_CS2_009()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.DRUID,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.StartGame();

			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(1, ((ICharacter)minion).Health);
			Assert.Equal(1, ((ICharacter)minion).AttackDamage);
			Assert.False(((ICharacter)minion).HasTaunt);

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mark of the Wild"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, (ICharacter)minion));

			Assert.Equal(3, ((ICharacter)minion).Health);
			Assert.Equal(3, ((ICharacter)minion).AttackDamage);
			Assert.True(((ICharacter)minion).HasTaunt);
		}

		// ------------------------------------------ SPELL - DRUID
		// [CS2_011] Savage Roar - COST:3 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Give your characters +2_Attack this turn.
		// --------------------------------------------------------
		[Fact]
		public void SavageRoar_CS2_011()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.DRUID,
					Player2HeroClass = CardClass.PRIEST,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Raider"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Raider"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Raider"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion3));

			Assert.Equal(2, ((ICharacter)minion1).AttackDamage);
			Assert.Equal(2, ((ICharacter)minion2).AttackDamage);
			Assert.Equal(2, ((ICharacter)minion3).AttackDamage);
			Assert.Equal(0, game.CurrentPlayer.Hero.TotalAttackDamage);

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Savage Roar"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));

			Assert.Equal(4, ((ICharacter)minion1).AttackDamage);
			Assert.Equal(4, ((ICharacter)minion2).AttackDamage);
			Assert.Equal(4, ((ICharacter)minion3).AttackDamage);
			Assert.Equal(2, game.CurrentPlayer.Hero.TotalAttackDamage);

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));

			Assert.Equal(3, game.CurrentPlayer.Hero.TotalAttackDamage);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(2, ((ICharacter)minion1).AttackDamage);
			Assert.Equal(2, ((ICharacter)minion2).AttackDamage);
			Assert.Equal(2, ((ICharacter)minion3).AttackDamage);
			Assert.Equal(0, game.CurrentPlayer.Hero.TotalAttackDamage);
		}

		// ------------------------------------------ SPELL - DRUID
		// [CS2_012] Swipe - COST:4 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $4 damage to an enemy and $1 damage to all other enemies. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_ENEMY_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void Swipe_CS2_012()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.DRUID,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.StartGame();

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable m1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m1));

			var m2 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m2));

			IPlayable m3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m3));

			game.CurrentPlayer.UsedMana = 0;

			IPlayable m4 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ironbark Protector"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m4));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(30, game.CurrentOpponent.Hero.Health);
			Assert.Equal(5, m2.Health);
			Assert.Equal(2, ((ICharacter)m3).Health);
			Assert.Equal(1, ((ICharacter)m1).Health);

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Swipe"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, m2));

			Assert.Equal(29, game.CurrentOpponent.Hero.Health);
			Assert.Equal(1, m2.Health);
			Assert.Equal(1, ((ICharacter)m3).Health);
			Assert.Equal(7, ((ICharacter)m4).Health);
			Assert.True(((ICharacter)m1).IsDead);

			game.CurrentPlayer.UsedMana = 0;

			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dalaran Mage"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, (ICharacter)minion3));

			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Swipe"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, game.CurrentOpponent.Hero));

			Assert.Equal(24, game.CurrentOpponent.Hero.Health);
			Assert.True(m2.IsDead);
			Assert.True(((ICharacter)m3).IsDead);
			Assert.Equal(5, ((ICharacter)m4).Health);
			Assert.True(((ICharacter)m1).IsDead);
		}

		// ------------------------------------------ SPELL - DRUID
		// [CS2_013] Wild Growth - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Gain an empty Mana Crystal.
		// --------------------------------------------------------
		[Fact]
		public void WildGrowth_CS2_013()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.DRUID,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.StartGame();

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(2, game.CurrentPlayer.RemainingMana);

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wild Growth"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, spell1));

			Assert.Equal(0, game.CurrentPlayer.RemainingMana);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(4, game.CurrentPlayer.RemainingMana);
			game.CurrentPlayer.BaseMana = 10;
			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wild Growth"));

			Assert.Equal(7, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, spell2));
			Assert.Equal(7, game.CurrentPlayer.HandZone.Count);
			Assert.Equal("CS2_013t", game.CurrentPlayer.HandZone[6].Card.Id);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.CurrentPlayer.BaseMana = 9;
			IPlayable spell3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Innervate"));
			Assert.Equal(9, game.CurrentPlayer.HandZone.Count);
			IPlayable spell4 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wild Growth"));
			Assert.Equal(10, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, spell3));
			Assert.Equal(9, game.CurrentPlayer.HandZone.Count);
			spell4.Cost = 0;
			game.Process(PlayCardTask.Any(game.CurrentPlayer, spell4));
			Assert.Equal(10, game.CurrentPlayer.RemainingMana);
			Assert.Equal(9, game.CurrentPlayer.HandZone.Count);
		}

		// ------------------------------------------ SPELL - DRUID
		// [EX1_169] Innervate - COST:0 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Gain 1 Mana Crystals this turn only.
		// --------------------------------------------------------
		[Fact]
		public void Innervate_EX1_169()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.DRUID,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});

			game.StartGame();

			Assert.Equal(1, game.CurrentPlayer.RemainingMana);

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Innervate"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));

			Assert.Equal(2, game.CurrentPlayer.RemainingMana);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(2, game.CurrentPlayer.RemainingMana);
		}

		// ------------------------------------------ SPELL - DRUID
		// [EX1_173] Starfire - COST:6 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $5 damage.
		//       Draw a card. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Starfire_EX1_173()
		{
			// TODO Starfire_EX1_173 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Starfire"));
		}

		// ----------------------------------------- MINION - DRUID
		// [CS2_232] Ironbark Protector - COST:8 [ATK:8/HP:8] 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IronbarkProtector_CS2_232()
		{
			// TODO IronbarkProtector_CS2_232 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ironbark Protector"));
		}
	}


	public class HunterCoreTest
	{
		// ----------------------------------------- SPELL - HUNTER
		// [CS2_084] Hunter's Mark - COST:1 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Change a minion's Health to 1.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void HuntersMark_CS2_084()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.SHAMAN,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			var m1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("War Golem"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m1));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(7, m1.Health);

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hunter's Mark"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, m1));

			Assert.Equal(1, m1.Health);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ancestral Healing"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, m1));

			Assert.True(m1.HasTaunt);
			Assert.Equal(1, m1.Health);
		}

		// ----------------------------------------- SPELL - HUNTER
		// [DS1_183] Multi-Shot - COST:4 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $3 damage to two random enemy minions. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINIMUM_ENEMY_MINIONS = 2
		// --------------------------------------------------------
		[Fact]
		public void MultiShot_DS1_183()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.PRIEST,
					Player2HeroClass = CardClass.HUNTER,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostwolf Grunt"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, (ICharacter)minion1));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Multi-Shot"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));

			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostwolf Grunt"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, (ICharacter)minion2));

			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostwolf Grunt"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, (ICharacter)minion3));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(3, game.CurrentOpponent.BoardZone.Count);

			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));

			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
		}

		// ----------------------------------------- SPELL - HUNTER
		// [DS1_184] Tracking - COST:1 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Look at the top 3 cards of your deck. Draw one and discard the_others.
		// --------------------------------------------------------
		[Fact]
		public void Tracking_DS1_184()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tracking"));
			Assert.Equal(26, game.CurrentPlayer.DeckZone.Count);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(23, game.CurrentPlayer.DeckZone.Count);
			Assert.True(game.CurrentPlayer.Choice != null);
			Assert.Equal(3, game.CurrentPlayer.Choice?.Choices.Count);
			Assert.Equal(4, game.CurrentPlayer.HandZone.Count);
			if (game.CurrentPlayer.Choice != null)
			{
				game.Process(ChooseTask.Pick(game.CurrentPlayer, game.CurrentPlayer.Choice.Choices[0]));
			}
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
		}

		// ----------------------------------------- SPELL - HUNTER
		// [DS1_185] Arcane Shot - COST:1 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $2 damage. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArcaneShot_DS1_185()
		{
			// TODO ArcaneShot_DS1_185 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Arcane Shot"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [EX1_539] Kill Command - COST:3 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $3 damage. If you control a Beast, deal
		//       $5 damage instead. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void KillCommand_EX1_539()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.HUNTER,
					Player2HeroClass = CardClass.PALADIN,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.StartGame();

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kill Command"));
			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kill Command"));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.CurrentPlayer.BaseMana = 10;
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, game.CurrentOpponent.Hero));
			Assert.Equal(27, game.CurrentOpponent.Hero.Health);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, game.CurrentOpponent.Hero));
			Assert.Equal(22, game.CurrentOpponent.Hero.Health);
		}

		// ----------------------------------------- SPELL - HUNTER
		// [NEW1_031] Animal Companion - COST:3 
		// - Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Summon a random Beast Companion.
		// --------------------------------------------------------
		// Entourage: NEW1_032, NEW1_033, NEW1_034
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact]
		public void AnimalCompanion_NEW1_031()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.HUNTER,
					Player2HeroClass = CardClass.PALADIN,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.StartGame();
			game.CurrentPlayer.BaseMana = 10;

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Animal Companion"));
			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Animal Companion"));

			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell1));

			int atk1 = game.CurrentPlayer.BoardZone[0].AttackDamage;

			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell2));

			int atk2 = game.CurrentPlayer.BoardZone[1].AttackDamage;

			if (game.CurrentPlayer.BoardZone[1].Card.Name.Equals("Leokk"))
			{
				Assert.Equal(game.CurrentPlayer.BoardZone[0].Card[GameTag.ATK] + 1,
					game.CurrentPlayer.BoardZone[0].AttackDamage);
			}

			if (game.CurrentPlayer.BoardZone[0].Card.Name.Equals("Leokk"))
			{
				Assert.Equal(game.CurrentPlayer.BoardZone[1].Card[GameTag.ATK] + 1,
					game.CurrentPlayer.BoardZone[1].AttackDamage);
			}

			if (!game.CurrentPlayer.BoardZone[1].Card.Name.Equals("Leokk") &&
				!game.CurrentPlayer.BoardZone[0].Card.Name.Equals("Leokk"))
			{
				Assert.Equal(game.CurrentPlayer.BoardZone[0].Card[GameTag.ATK],
					game.CurrentPlayer.BoardZone[0].AttackDamage);
				Assert.Equal(game.CurrentPlayer.BoardZone[1].Card[GameTag.ATK],
					game.CurrentPlayer.BoardZone[1].AttackDamage);
			}
		}

		// ---------------------------------------- MINION - HUNTER
		// [CS2_237] Starving Buzzard - COST:5 [ATK:3/HP:2] 
		// - Race: beast, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever you summon a Beast, draw a card.
		// --------------------------------------------------------
		[Fact]
		public void StarvingBuzzard_CS2_237()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.HUNTER,
					Player2HeroClass = CardClass.PALADIN,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.StartGame();

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Starving Buzzard"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

			Assert.Equal(1, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);

			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Raider"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));

			Assert.Equal(1, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);

			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));

			Assert.Equal(2, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);
		}

		// ---------------------------------------- MINION - HUNTER
		// [DS1_070] Houndmaster - COST:4 [ATK:4/HP:3] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly Beast +2/+2 and <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_WITH_RACE = 20
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact]
		public void Houndmaster_DS1_070()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.HUNTER,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});

			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.StartGame();

			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(1, ((ICharacter)minion).Health);
			Assert.Equal(1, ((ICharacter)minion).AttackDamage);
			Assert.False(((ICharacter)minion).HasTaunt);

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Houndmaster"));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, spell, (ICharacter) minion));

			Assert.Equal(3, ((ICharacter)minion).Health);
			Assert.Equal(3, ((ICharacter)minion).AttackDamage);
			Assert.True(((ICharacter)minion).HasTaunt);
		}

		// ---------------------------------------- MINION - HUNTER
		// [DS1_175] Timber Wolf - COST:1 [ATK:1/HP:1] 
		// - Race: beast, Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Your other Beasts have +1_Attack.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact]
		public void TimberWolf_DS1_175()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.HUNTER,
					Player2HeroClass = CardClass.PALADIN,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.StartGame();

			var minion1 = (Minion)Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

			Assert.Equal(1, minion1.AttackDamage);

			var minion3 = (Minion)Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Timber Wolf"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));

			Assert.Equal(2, minion1.AttackDamage);

			var minion2 = (Minion)Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));

			Assert.Equal(2, minion2.AttackDamage);

			IPlayable silencer = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ironbeak Owl"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, silencer, minion3));

			Assert.Equal(1, minion1.AttackDamage);
			Assert.Equal(1, minion2.AttackDamage);
		}

		// ---------------------------------------- MINION - HUNTER
		// [DS1_178] Tundra Rhino - COST:5 [ATK:2/HP:5] 
		// - Race: beast, Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Your Beasts have <b>Charge</b>.
		// --------------------------------------------------------
		// RefTag:
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact]
		public void TundraRhino_DS1_178()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.HUNTER,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});

			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.StartGame();

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Raider"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));

			Assert.False(((Minion)minion1).HasCharge);
			Assert.False(((Minion)minion2).HasCharge);

			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tundra Rhino"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));

			Assert.True(((Minion)minion1).HasCharge);
			Assert.False(((Minion)minion2).HasCharge);
			Assert.True(((Minion)minion3).HasCharge);
		}
	}


	public class MageCoreTest
	{
		// ------------------------------------------- SPELL - MAGE
		// [CS2_022] Polymorph - COST:4 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Transform a minion
		//       into a 1/1 Sheep.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void Polymorph_CS2_022()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.MAGE,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.StartGame();

			IPlayable m1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m1));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			int zonePosition = m1.ZonePosition;
			Zone zone = m1.Zone.Type;

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Polymorph"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, (ICharacter) m1));

			Assert.Equal(zonePosition, game.CurrentOpponent.BoardZone[0].ZonePosition);
			Assert.Equal(zone, game.CurrentOpponent.BoardZone[0].Zone.Type);
			Assert.NotEqual(game.CurrentOpponent.BoardZone[0].Zone.Type, m1.Zone.Type);
			Assert.Equal(Zone.SETASIDE, m1.Zone.Type);
			Assert.Equal("CS2_tk1", game.CurrentOpponent.BoardZone[0].Card.Id);
		}

		// ------------------------------------------- SPELL - MAGE
		// [CS2_023] Arcane Intellect - COST:3 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Draw 2 cards.
		// --------------------------------------------------------
		[Fact]
		public void ArcaneIntellect_CS2_023()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;

			Assert.Equal(1, game.Player1[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);

			IPlayable spell = Generic.DrawCard(game.Player1, Cards.FromName("Arcane Intellect"));

			Assert.Equal(1, game.Player1[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);
			Assert.Equal(0, game.Player1[GameTag.NUM_CARDS_PLAYED_THIS_TURN]);

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, spell));

			Assert.Equal(3, game.Player1[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);
			Assert.Equal(1, game.Player1[GameTag.NUM_CARDS_PLAYED_THIS_TURN]);
		}

		// ------------------------------------------- SPELL - MAGE
		// [CS2_024] Frostbolt - COST:2 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $3 damage to a_character and <b>Freeze</b> it. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void Frostbolt_CS2_024()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.MAGE,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.StartGame();

			IPlayable m1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m1));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(5, ((ICharacter)m1).Health);
			Assert.False(((ICharacter)m1).IsFrozen);

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostbolt"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, (ICharacter) m1));

			Assert.Equal(2, ((ICharacter)m1).Health);
			Assert.True(((ICharacter)m1).IsFrozen);
		}

		// ------------------------------------------- SPELL - MAGE
		// [CS2_025] Arcane Explosion - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $1 damage to all enemy minions. *spelldmg
		// --------------------------------------------------------
		[Fact]
		public void ArcaneExplosion_CS2_025()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.MAGE,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.StartGame();

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable m1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m1));

			IPlayable m2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m2));

			IPlayable m3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m3));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(30, game.CurrentOpponent.Hero.Health);
			Assert.Equal(5, ((ICharacter)m2).Health);
			Assert.Equal(2, ((ICharacter)m3).Health);
			Assert.Equal(1, ((ICharacter)m1).Health);

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Explosion"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));

			Assert.Equal(30, game.CurrentOpponent.Hero.Health);
			Assert.Equal(4, ((ICharacter)m2).Health);
			Assert.Equal(1, ((ICharacter)m3).Health);
			Assert.True(((ICharacter)m1).IsDead);
		}

		// ------------------------------------------- SPELL - MAGE
		// [CS2_026] Frost Nova - COST:3 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Freeze</b> all enemy minions.
		// --------------------------------------------------------
		// GameTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact]
		public void FrostNova_CS2_026()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.MAGE,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.StartGame();

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable m1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m1));

			IPlayable m2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m2));

			IPlayable m3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m3));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.False(game.CurrentOpponent.Hero.IsFrozen);
			Assert.False(((ICharacter)m2).IsFrozen);
			Assert.False(((ICharacter)m3).IsFrozen);
			Assert.False(((ICharacter)m1).IsFrozen);

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frost Nova"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));

			Assert.False(game.CurrentOpponent.Hero.IsFrozen);
			Assert.True(((ICharacter)m2).IsFrozen);
			Assert.True(((ICharacter)m3).IsFrozen);
			Assert.True(((ICharacter)m1).IsFrozen);
		}

		// ------------------------------------------- SPELL - MAGE
		// [CS2_027] Mirror Image - COST:1 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Summon two 0/2 minions with <b>Taunt</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact]
		public void MirrorImage_CS2_027()
		{
			var game =
				new Game(new GameConfig
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

			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mirror Image"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell1));

			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);

			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mirror Image"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell2));

			Assert.Equal(4, game.CurrentPlayer.BoardZone.Count);

			IPlayable spell3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mirror Image"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell3));

			Assert.Equal(6, game.CurrentPlayer.BoardZone.Count);

			IPlayable spell4 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mirror Image"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell4));

			Assert.Equal(7, game.CurrentPlayer.BoardZone.Count);

			IPlayable spell5 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mirror Image"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell5));

			Assert.Equal(7, game.CurrentPlayer.BoardZone.Count);
		}

		// ------------------------------------------- SPELL - MAGE
		// [CS2_029] Fireball - COST:4 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $6 damage. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void Fireball_CS2_029()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.HUNTER,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, game.CurrentOpponent.Hero));

			Assert.Equal(24, game.CurrentOpponent.Hero.Health);

			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dalaran Mage"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, (ICharacter)minion3));

			game.CurrentPlayer.UsedMana = 0;

			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, game.CurrentOpponent.Hero));

			Assert.Equal(1, game.CurrentPlayer.CurrentSpellPower);
			Assert.Equal(17, game.CurrentOpponent.Hero.Health);
		}

		// ------------------------------------------- SPELL - MAGE
		// [CS2_032] Flamestrike - COST:7 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $4 damage to all enemy minions. *spelldmg
		// --------------------------------------------------------
		[Fact]
		public void Flamestrike_CS2_032()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.MAGE,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.StartGame();

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable m1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m1));

			IPlayable m2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m2));

			IPlayable m3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m3));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(30, game.CurrentOpponent.Hero.Health);
			Assert.Equal(5, ((ICharacter)m2).Health);
			Assert.Equal(2, ((ICharacter)m3).Health);
			Assert.Equal(1, ((ICharacter)m1).Health);

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flamestrike"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));

			Assert.Equal(30, game.CurrentOpponent.Hero.Health);
			Assert.Equal(1, ((ICharacter)m2).Health);
			Assert.True(((ICharacter)m3).IsDead);
			Assert.True(((ICharacter)m1).IsDead);
		}

		// ------------------------------------------- SPELL - MAGE
		// [EX1_277] Arcane Missiles - COST:1 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $3 damage randomly split among all enemies. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - ImmuneToSpellpower = 1
		// --------------------------------------------------------
		[Fact]
		public void ArcaneMissiles_EX1_277()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.HUNTER,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, (ICharacter)minion1));

			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, (ICharacter)minion2));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			int totHealth = game.CurrentOpponent.Hero.Health;
			totHealth += ((ICharacter)minion1).Health;
			totHealth += ((ICharacter)minion2).Health;

			Assert.Equal(40, totHealth);

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Missiles"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell1));

			totHealth = game.CurrentOpponent.Hero.Health;
			totHealth += ((ICharacter)minion1).Health;
			totHealth += ((ICharacter)minion2).Health;

			Assert.Equal(37, totHealth);

			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dalaran Mage"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, (ICharacter)minion3));

			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Missiles"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell2));

			totHealth = game.CurrentOpponent.Hero.Health;
			totHealth += ((ICharacter)minion1).IsDead ? 0 : ((ICharacter)minion1).Health;
			totHealth += ((ICharacter)minion2).IsDead ? 0 : ((ICharacter)minion2).Health;

			Assert.Equal(1, game.CurrentPlayer.CurrentSpellPower);
			Assert.Equal(33, totHealth);
		}

		// ------------------------------------------ MINION - MAGE
		// [CS2_033] Water Elemental - COST:4 [ATK:3/HP:6] 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Freeze</b> any character damaged by this minion.
		// --------------------------------------------------------
		// GameTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact]
		public void WaterElemental_CS2_033()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.DRUID,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			Minion water = game.ProcessCard<Minion>("Water Elemental");
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			game.Process(HeroAttackTask.Any(game.CurrentPlayer, water));
			Assert.True(game.Player2.Hero.IsFrozen);
			Minion minion2 = game.ProcessCard<Minion>("Sen'jin Shieldmasta");
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.True(game.Player2.Hero.IsFrozen);
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, water, minion2));
			Assert.True(minion2.IsFrozen);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.True(game.Player2.Hero.IsFrozen);
			Assert.True(minion2.IsFrozen);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.False(game.Player2.Hero.IsFrozen);
			Assert.False(minion2.IsFrozen);
		}
	}


	public class PaladinCoreTest
	{
		// ---------------------------------------- SPELL - PALADIN
		// [CS2_087] Blessing of Might - COST:1 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Give a minion +3_Attack.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void BlessingOfMight_CS2_087()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.PALADIN,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.StartGame();

			IPlayable m2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m2));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(3, ((ICharacter)m2).AttackDamage);

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blessing of Might"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, (ICharacter) m2));

			Assert.Equal(6, ((ICharacter)m2).AttackDamage);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(6, ((ICharacter)m2).AttackDamage);
		}

		// ---------------------------------------- SPELL - PALADIN
		// [CS2_089] Holy Light - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Restore #6 Health.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HolyLight_CS2_089()
		{
			// TODO HolyLight_CS2_089 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Holy Light"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [CS2_092] Blessing of Kings - COST:4 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Give a minion +4/+4. <i>(+4 Attack/+4 Health)</i>
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void BlessingOfKings_CS2_092()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.PALADIN,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.StartGame();

			IPlayable m2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m2));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(3, ((ICharacter)m2).AttackDamage);
			Assert.Equal(5, ((ICharacter)m2).Health);

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blessing of Kings"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, (ICharacter) m2));

			Assert.Equal(7, ((ICharacter)m2).AttackDamage);
			Assert.Equal(9, ((ICharacter)m2).Health);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(7, ((ICharacter)m2).AttackDamage);
			Assert.Equal(9, ((ICharacter)m2).Health);
		}

		// ---------------------------------------- SPELL - PALADIN
		// [CS2_093] Consecration - COST:4 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $2 damage to all_enemies. *spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Consecration_CS2_093()
		{
			// TODO Consecration_CS2_093 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Consecration"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [CS2_094] Hammer of Wrath - COST:4 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $3 damage.
		//       Draw a card. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void HammerOfWrath_CS2_094()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.PRIEST,
					Player2HeroClass = CardClass.PALADIN,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.StartGame();
			game.Player2.BaseMana = 3;

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Northshire Cleric"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(1, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hammer of Wrath"));

			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, (ICharacter) minion1));

			Assert.Equal(2, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);
			Assert.True(minion1.ToBeDestroyed);
		}

		// ---------------------------------------- SPELL - PALADIN
		// [EX1_360] Humility - COST:1 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Change a minion's Attack to 1.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void Humility_EX1_360()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.PALADIN,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.StartGame();

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable m2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m2));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(3, ((ICharacter)m2).AttackDamage);

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Humility"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, (ICharacter) m2));

			Assert.Equal(1, ((ICharacter)m2).AttackDamage);
		}

		// ---------------------------------------- SPELL - PALADIN
		// [EX1_371] Hand of Protection - COST:1 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Give a minion <b>Divine Shield</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HandOfProtection_EX1_371()
		{
			// TODO HandOfProtection_EX1_371 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Hand of Protection"));
		}

		// --------------------------------------- MINION - PALADIN
		// [CS2_088] Guardian of Kings - COST:7 [ATK:5/HP:6] 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Restore 6 Health to your hero.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GuardianOfKings_CS2_088()
		{
			// TODO GuardianOfKings_CS2_088 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Guardian of Kings"));
		}

		// --------------------------------------- WEAPON - PALADIN
		// [CS2_091] Light's Justice - COST:1 [ATK:1/HP:0] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 4
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LightsJustice_CS2_091()
		{
			// TODO LightsJustice_CS2_091 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Light's Justice"));
		}

		// --------------------------------------- WEAPON - PALADIN
		// [CS2_097] Truesilver Champion - COST:4 [ATK:4/HP:0] 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever your hero attacks, restore 2_Health to it.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// --------------------------------------------------------
		[Fact]
		public void TruesilverChampion_CS2_097()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.WARRIOR,
					Player2HeroClass = CardClass.PALADIN,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			IPlayable weapon1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fiery War Axe"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, weapon1));
			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.Opponent.Hero));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(27, game.CurrentPlayer.Hero.Health);

			IPlayable weapon2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Truesilver Champion"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, weapon2));
			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.Opponent.Hero));

			Assert.Equal(29, game.CurrentPlayer.Hero.Health);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.Opponent.Hero));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.Opponent.Hero));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable weapon3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fiery War Axe"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, weapon3));

			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.Opponent.Hero));
		}
	}


	public class PriestCoreTest
	{
		// ----------------------------------------- SPELL - PRIEST
		// [CS1_112] Holy Nova - COST:5 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $2 damage to all enemies. Restore #2_Health to all friendly characters. *spelldmg
		// --------------------------------------------------------
		[Fact]
		public void HolyNova_CS1_112()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.PRIEST,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.StartGame();

			//var minion11 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Northshire Cleric"));
			//game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion11));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			var minion12 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("River Crocolisk"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion12));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion12));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			var minion13 = (ICharacter)Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ironfur Grizzly"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion13));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable minion24 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Silverback Patriarch"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion24));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion13, (ICharacter)minion24));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion13));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable minion25 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stormwind Knight"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion25));

			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion25, minion13));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(1, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);
			Assert.Equal(30, game.CurrentOpponent.Hero.Health);
			Assert.Equal(1, minion13.Health);

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Holy Nova"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));

			Assert.Equal(1, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);
			Assert.Equal(28, game.CurrentOpponent.Hero.Health);
			Assert.Equal(3, minion13.Health);
			Assert.Equal(Zone.GRAVEYARD, minion24.Zone.Type);
			Assert.Equal(Zone.GRAVEYARD, minion25.Zone.Type);
		}

		// ----------------------------------------- SPELL - PRIEST
		// [CS1_113] Mind Control - COST:10 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Take control of an enemy minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_ENEMY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact]
		public void MindControl_CS1_113()
		{
			var game =
				new Game(new GameConfig
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

			IPlayable m2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m2));

			IPlayable m8 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Raider"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m8));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(2, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal(game.CurrentOpponent, game.CurrentOpponent.BoardZone[0].Controller);


			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mind Control"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, (ICharacter) m2));

			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal(game.CurrentPlayer, game.CurrentPlayer.BoardZone[0].Controller);

			// reset mana
			game.CurrentPlayer.UsedMana = 0;

			IPlayable m1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m1));

			IPlayable m7 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m7));

			IPlayable m3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m3));

			IPlayable m4 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m4));

			IPlayable m5 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m5));

			IPlayable m6 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m6));

			Assert.Equal(7, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);

			// reset mana
			game.CurrentPlayer.UsedMana = 0;

			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mind Control"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, (ICharacter) m2));

			// board is full can't use mind control ...
			Assert.Equal(7, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
		}

		// ----------------------------------------- SPELL - PRIEST
		// [CS1_130] Holy Smite - COST:1 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $2 damage. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HolySmite_CS1_130()
		{
			// TODO HolySmite_CS1_130 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Holy Smite"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [CS2_003] Mind Vision - COST:1 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Put a copy of a random card in your opponent's hand into your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MindVision_CS2_003()
		{
			// TODO MindVision_CS2_003 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Mind Vision"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [CS2_004] Power Word: Shield - COST:1 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Give a minion +2_Health.
		//       Draw a card.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void PowerWordShield_CS2_004()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;

			Assert.Equal(1, game.Player1[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);
			Assert.Equal(0, game.Player1[GameTag.NUM_CARDS_PLAYED_THIS_TURN]);

			IPlayable minion1 = Generic.DrawCard(game.Player1, Cards.FromName("Murloc Raider"));

			Assert.Equal(1, game.Player1[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

			Assert.Equal(1, game.Player1[GameTag.NUM_CARDS_PLAYED_THIS_TURN]);

			IPlayable spell = Generic.DrawCard(game.Player1, Cards.FromName("Power Word: Shield"));

			Assert.Equal(1, game.Player1[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);

			Assert.Equal(1, game.Player1.BoardZone[0][GameTag.HEALTH]);

			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, (ICharacter) minion1));

			Assert.Equal(2, game.Player1[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);
			Assert.Equal(2, game.Player1[GameTag.NUM_CARDS_PLAYED_THIS_TURN]);
			Assert.Equal(3, game.Player1.BoardZone[0].BaseHealth);
		}

		// ----------------------------------------- SPELL - PRIEST
		// [CS2_234] Shadow Word: Pain - COST:2 
		// - Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Destroy a minion with 3_or less Attack.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_MAX_ATTACK = 3
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void ShadowWordPain_CS2_234()
		{
			var game = new Game(new GameConfig { StartPlayer = 1, Player1HeroClass = CardClass.PRIEST, FillDecks = true, FillDecksPredictably = true });
			game.StartGame();

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(1, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Northshire Cleric"));

			Assert.Equal(1, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);

			Generic.PlayCardBlock(game.CurrentPlayer, minion1, null, -1, 0, false);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostwolf Grunt"));

			Assert.Equal(1, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);

			Generic.PlayCardBlock(game.CurrentPlayer, minion2, null, -1, 0, false);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadow Word: Pain"));

			Assert.Equal(0, game.CurrentPlayer[GameTag.NUM_MINIONS_PLAYER_KILLED_THIS_TURN]);

			game.Process(PlayCardTask.Any(game.CurrentPlayer, spell1, (ICharacter)minion2));

			Assert.Equal(1, game.CurrentPlayer[GameTag.NUM_MINIONS_PLAYER_KILLED_THIS_TURN]);
		}

		// ----------------------------------------- SPELL - PRIEST
		// [CS2_236] Divine Spirit - COST:2 
		// - Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Double a minion's Health.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void DivineSpirit_CS2_236()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.PRIEST,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();

			var minion12 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Injured Blademaster"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion12));

			Assert.Equal(3, minion12.Health);

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Divine Spirit"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, minion12));

			Assert.Equal(6, minion12.Health);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostbolt"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, minion12));

			Assert.Equal(3, minion12.Health);

			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ironbeak Owl"));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion3, minion12));

			Assert.Equal(3, minion12.Health);
		}

		// ----------------------------------------- SPELL - PRIEST
		// [DS1_233] Mind Blast - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $5 damage to the enemy hero. *spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MindBlast_DS1_233()
		{
			// TODO MindBlast_DS1_233 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Mind Blast"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [EX1_622] Shadow Word: Death - COST:3 
		// - Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Destroy a minion with 5_or more Attack.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_TARGET_MIN_ATTACK = 5
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShadowWordDeath_EX1_622()
		{
			// TODO ShadowWordDeath_EX1_622 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Shadow Word: Death"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [CS2_235] Northshire Cleric - COST:1 [ATK:1/HP:3] 
		// - Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Whenever a minion is healed, draw a card.
		// --------------------------------------------------------
		[Fact]
		public void NorthshireCleric_CS2_235()
		{
			var game = new Game(new GameConfig { StartPlayer = 1, Player1HeroClass = CardClass.PRIEST, FillDecks = true, FillDecksPredictably = true });
			game.StartGame();

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(1, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);

			var minion1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Northshire Cleric"));

			Assert.Equal(1, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);

			Generic.PlayCardBlock(game.CurrentPlayer, minion1, null, -1, 0, false);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			var minion2 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostwolf Grunt"));

			Assert.Equal(1, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);

			Generic.PlayCardBlock(game.CurrentPlayer, minion2, null, -1, 0, false);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(1, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);

			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion1, minion2));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));

			Assert.Equal(2, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);
		}
	}


	public class RogueCoreTest
	{
		// ------------------------------------------ SPELL - ROGUE
		// [CS2_072] Backstab - COST:0 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $2 damage to an undamaged minion. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_UNDAMAGED_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void Backstab_CS2_072()
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

			var minion1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Raider"));
			var minion3 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion3));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			game.Process(HeroAttackTask.Any(game.CurrentPlayer, minion3));

			Assert.Equal(4, minion3.Health);

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Backstab"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, minion3));

			Assert.Equal(4, minion3.Health);

			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, minion1));

			Assert.True(minion1.IsDead);
		}

		// ------------------------------------------ SPELL - ROGUE
		// [CS2_074] Deadly Poison - COST:1 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Give your weapon +2_Attack.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_WEAPON_EQUIPPED = 0
		// --------------------------------------------------------
		[Fact]
		public void DeadlyPoison_CS2_074()
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

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Deadly Poison"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell1));

			Assert.Null(game.CurrentPlayer.Hero.Weapon);

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));

			Assert.Equal(1, game.CurrentPlayer.Hero.TotalAttackDamage);

			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell1));
			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));

			Assert.Equal(3, game.CurrentPlayer.Hero.Weapon.AttackDamage);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(3, game.CurrentPlayer.Hero.Weapon.AttackDamage);

			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));

			Assert.Equal(0, game.CurrentPlayer.Hero.AttackDamage);
		}

		// ------------------------------------------ SPELL - ROGUE
		// [CS2_075] Sinister Strike - COST:1 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $3 damage to the_enemy hero. *spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SinisterStrike_CS2_075()
		{
			// TODO SinisterStrike_CS2_075 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sinister Strike"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [CS2_076] Assassinate - COST:5 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Destroy an enemy minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_ENEMY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void Assassinate_CS2_076()
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

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Raider"));
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion3));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(5, ((ICharacter)minion3).Health);

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Assassinate"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, (ICharacter) minion3));

			Assert.True(((ICharacter)minion3).IsDead);
		}

		// ------------------------------------------ SPELL - ROGUE
		// [CS2_077] Sprint - COST:7 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Draw 4 cards.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Sprint_CS2_077()
		{
			// TODO Sprint_CS2_077 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sprint"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [EX1_129] Fan of Knives - COST:3 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $1 damage to all enemy minions. Draw_a card. *spelldmg
		// --------------------------------------------------------
		[Fact]
		public void FanOfKnives_EX1_129()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.ROGUE,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.StartGame();

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable m1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m1));

			IPlayable m2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m2));

			IPlayable m3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m3));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(30, game.CurrentOpponent.Hero.Health);
			Assert.Equal(5, ((ICharacter)m2).Health);
			Assert.Equal(2, ((ICharacter)m3).Health);
			Assert.Equal(1, ((ICharacter)m1).Health);

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fan of Knives"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));

			Assert.Equal(30, game.CurrentOpponent.Hero.Health);
			Assert.Equal(4, ((ICharacter)m2).Health);
			Assert.Equal(1, ((ICharacter)m3).Health);
			Assert.True(((ICharacter)m1).IsDead);

			Assert.Equal(2, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);
		}

		// ------------------------------------------ SPELL - ROGUE
		// [EX1_278] Shiv - COST:2 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $1 damage.
		//       Draw a card. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Shiv_EX1_278()
		{
			// TODO Shiv_EX1_278 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Shiv"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [EX1_581] Sap - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Return an enemy minion to your opponent's hand.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_ENEMY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void Sap_EX1_581()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.PALADIN,
					Player2HeroClass = CardClass.ROGUE,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.StartGame();

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Razorfen Hunter"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sap"));
			Assert.Equal(3, ((ICharacter)minion1).Health);
			Assert.Equal(1, game.CurrentOpponent.BoardZone[1].Health);
			Assert.Equal(4, game.CurrentOpponent.HandZone.Count);
			Assert.Equal(0, game.CurrentOpponent[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);
			Assert.Equal(2, game.CurrentOpponent.BoardZone.Count);

			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, (ICharacter) minion1));

			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal(5, game.CurrentOpponent.HandZone.Count);
			Assert.Equal(0, game.CurrentOpponent[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);
		}

		// ------------------------------------------ SPELL - ROGUE
		// [NEW1_004] Vanish - COST:6 
		// - Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Return all minions to their owner's hand.
		// --------------------------------------------------------
		[Fact]
		public void Vanish_NEW1_004()
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

			int player1HandCount = game.CurrentPlayer.HandZone.Count;

			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);

			// player 1 plays 7 minions
			for (int i = 0; i < 7; i++)
			{
				IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wisp"));
				game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			}

			Assert.Equal(7, game.CurrentPlayer.BoardZone.Count);

			// end turn
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			// player 2 plays vanish
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vanish"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));

			Assert.Equal(0, game.CurrentPlayer.Opponent.BoardZone.Count);
			Assert.Equal(10, game.CurrentPlayer.Opponent.HandZone.Count);
		}

		// ----------------------------------------- WEAPON - ROGUE
		// [CS2_080] Assassin's Blade - COST:5 [ATK:3/HP:0] 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 4
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AssassinsBlade_CS2_080()
		{
			// TODO AssassinsBlade_CS2_080 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Assassin's Blade"));
		}
	}


	public class ShamanCoreTest
	{
		// ----------------------------------------- SPELL - SHAMAN
		// [CS2_037] Frost Shock - COST:1 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $1 damage to an enemy character and <b>Freeze</b> it. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_ENEMY_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void FrostShock_CS2_037()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.SHAMAN,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.StartGame();

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable m2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m2));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.False(((ICharacter)m2).IsFrozen);
			Assert.Equal(5, ((ICharacter)m2).Health);

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frost Shock"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, (ICharacter)m2));

			Assert.True(((ICharacter)m2).IsFrozen);
			Assert.Equal(4, ((ICharacter)m2).Health);
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [CS2_039] Windfury - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Give a minion <b>Windfury</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - WINDFURY = 1
		// --------------------------------------------------------
		[Fact]
		public void Windfury_CS2_039()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.SHAMAN,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.StartGame();

			IPlayable m2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m2));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Windfury"));

			Assert.Equal(30, game.CurrentOpponent.Hero.Health);

			game.Process(MinionAttackTask.Any(game.CurrentPlayer, m2, game.CurrentOpponent.Hero));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, (ICharacter) m2));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, m2, game.CurrentOpponent.Hero));

			Assert.Equal(2, ((ICharacter)m2)[GameTag.NUM_ATTACKS_THIS_TURN]);
			Assert.Equal(24, game.CurrentOpponent.Hero.Health);
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [CS2_041] Ancestral Healing - COST:0 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Restore a minion
		//       to full Health and
		//       give it <b>Taunt</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact]
		public void AncestralHealing_CS2_041()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.ROGUE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			var m1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("War Golem"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m1));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable m2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Reckless Rocketeer"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m2));

			game.Process(MinionAttackTask.Any(game.CurrentPlayer, m2, m1));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.False(m1.HasTaunt);
			Assert.Equal(2, m1.Health);

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ancestral Healing"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, m1));

			Assert.True(m1.HasTaunt);
			Assert.Equal(7, m1.Health);
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [CS2_045] Rockbiter Weapon - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Give a friendly character +3 Attack this turn.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void RockbiterWeapon_CS2_045()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.SHAMAN,
					Player2HeroClass = CardClass.PALADIN,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.StartGame();

			IPlayable minion12 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("River Crocolisk"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion12));

			Assert.Equal(2, ((ICharacter)minion12).AttackDamage);
			Assert.Equal(0, game.CurrentPlayer.Hero.TotalAttackDamage);

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rockbiter Weapon"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, (ICharacter) minion12));

			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rockbiter Weapon"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, game.CurrentPlayer.Hero));

			Assert.Equal(5, ((ICharacter)minion12).AttackDamage);
			Assert.Equal(3, game.CurrentPlayer.Hero.TotalAttackDamage);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(2, ((ICharacter)minion12).AttackDamage);
			Assert.Equal(0, game.CurrentPlayer.Hero.TotalAttackDamage);
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [CS2_046] Bloodlust - COST:5 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Give your minions +3_Attack this turn.
		// --------------------------------------------------------
		[Fact]
		public void Bloodlust_CS2_046()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.SHAMAN,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.StartGame();

			IPlayable m1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m1));

			IPlayable m2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m2));

			IPlayable m3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m3));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(1, ((ICharacter)m1).AttackDamage);
			Assert.Equal(3, ((ICharacter)m2).AttackDamage);
			Assert.Equal(3, ((ICharacter)m3).AttackDamage);

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodlust"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));

			Assert.Equal(4, ((ICharacter)m1).AttackDamage);
			Assert.Equal(6, ((ICharacter)m2).AttackDamage);
			Assert.Equal(6, ((ICharacter)m3).AttackDamage);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(1, ((ICharacter)m1).AttackDamage);
			Assert.Equal(3, ((ICharacter)m2).AttackDamage);
			Assert.Equal(3, ((ICharacter)m3).AttackDamage);
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [EX1_244] Totemic Might - COST:0 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Give your Totems +2_Health.
		// --------------------------------------------------------
		[Fact]
		public void TotemicMight_EX1_244()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.SHAMAN,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gurubashi Berserker"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, (ICharacter)minion1));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			int healthTot1 = game.CurrentPlayer.BoardZone[1].Health;
			int healthTot2 = game.CurrentPlayer.BoardZone[2].Health;

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Totemic Might"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));

			Assert.Equal(healthTot1 + 2, game.CurrentPlayer.BoardZone[1].Health);
			Assert.Equal(healthTot2 + 2, game.CurrentPlayer.BoardZone[2].Health);
			Assert.Equal(7, ((ICharacter)minion1).Health);

			IPlayable silencer = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Silence"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, silencer, game.CurrentPlayer.BoardZone[1]));

			Assert.Equal(healthTot1, game.CurrentPlayer.BoardZone[1].Health);
			Assert.Equal(healthTot2 + 2, game.CurrentPlayer.BoardZone[2].Health);
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [EX1_246] Hex - COST:4 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Transform a minion into a 0/1 Frog with <b>Taunt</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact]
		public void Hex_EX1_246()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.MAGE,
					Player2HeroClass = CardClass.SHAMAN,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.StartGame();

			IPlayable m1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m1));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			int zonePosition = m1.ZonePosition;
			Zone zone = m1.Zone.Type;

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hex"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, (ICharacter) m1));

			Assert.Equal(zonePosition, game.CurrentOpponent.BoardZone[0].ZonePosition);
			Assert.Equal(zone, game.CurrentOpponent.BoardZone[0].Zone.Type);
			Assert.NotEqual(game.CurrentOpponent.BoardZone[0].Zone.Type, m1.Zone.Type);
			Assert.Equal(Zone.SETASIDE, m1.Zone.Type);
			Assert.Equal("hexfrog", game.CurrentOpponent.BoardZone[0].Card.Id);
		}

		// ---------------------------------------- MINION - SHAMAN
		// [CS2_042] Fire Elemental - COST:6 [ATK:6/HP:5] 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 3 damage.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact]
		public void FireElemental_CS2_042()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.SHAMAN,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.StartGame();

			IPlayable m2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, m2));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(5, ((ICharacter)m2).Health);

			IPlayable m1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fire Elemental"));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, m1, (ICharacter) m2));

			Assert.Equal(2, ((ICharacter)m2).Health);
		}

		// ---------------------------------------- MINION - SHAMAN
		// [EX1_565] Flametongue Totem - COST:2 [ATK:0/HP:3] 
		// - Race: totem, Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Adjacent minions have +2_Attack.
		// --------------------------------------------------------
		// GameTag:
		// - ADJACENT_BUFF = 1
		// - AURA = 1
		// --------------------------------------------------------
		[Fact]
		public void FlametongueTotem_EX1_565()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.SHAMAN,
					Player2HeroClass = CardClass.PALADIN,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.StartGame();
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Player1.BaseMana = 10;

			Minion m1 = game.ProcessCard<Minion>("Stonetusk Boar");	 // (1)
			Minion m2 = game.ProcessCard<Minion>("Bloodfen Raptor"); // (1)(3)

			game.ProcessCard("Flametongue Totem", zonePosition: 1);  // (3)(T)(5)

			Assert.Equal(3, m1.AttackDamage);
			Assert.Equal(5, m2.AttackDamage);

			game.ProcessCard("Flametongue Totem");					 // (3)(T)(5)(T)
			Assert.Equal(3, m1.AttackDamage);
			Assert.Equal(7, m2.AttackDamage);

			game.ProcessCard("Flametongue Totem", zonePosition: 0);  // (T)(5)(T)(7)(T)
			Assert.Equal(5, m1.AttackDamage);
			Assert.Equal(7, m2.AttackDamage);
		}

		// ---------------------------------------- MINION - SHAMAN
		// [EX1_587] Windspeaker - COST:4 [ATK:3/HP:3] 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly minion <b>Windfury</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		// RefTag:
		// - WINDFURY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Windspeaker_EX1_587()
		{
			// TODO Windspeaker_EX1_587 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Windspeaker"));
		}
	}


	public class WarlockCoreTest
	{
		// ---------------------------------------- SPELL - WARLOCK
		// [CS2_057] Shadow Bolt - COST:3 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $4 damage
		//       to a minion. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void ShadowBolt_CS2_057()
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

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Booty Bay Bodyguard"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(30, game.CurrentOpponent.Hero.Health);

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadow Bolt"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, game.CurrentOpponent.Hero));

			Assert.Equal(30, game.CurrentOpponent.Hero.Health);

			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, (ICharacter) minion1));

			Assert.True(((ICharacter)minion1).IsDead);
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [CS2_061] Drain Life - COST:3 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $2 damage. Restore #2 Health to your hero. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void DrainLife_CS2_061()
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

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Raider"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion2, game.CurrentOpponent.Hero));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(29, game.CurrentPlayer.Hero.Health);
			Assert.Equal(30, game.CurrentOpponent.Hero.Health);

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Drain Life"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, game.CurrentOpponent.Hero));

			Assert.Equal(28, game.CurrentOpponent.Hero.Health);
			Assert.Equal(30, game.CurrentPlayer.Hero.Health);
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [CS2_062] Hellfire - COST:4 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Deal $3 damage to ALL_characters. *spelldmg
		// --------------------------------------------------------
		[Fact]
		public void Hellfire_CS2_062()
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

			IPlayable minion4 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));
			IPlayable minion5 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ironfur Grizzly"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion4));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion5));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Raider"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion3));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion2, game.CurrentOpponent.Hero));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(30, game.CurrentOpponent.Hero.Health);
			Assert.Equal(30, game.CurrentPlayer.Hero.Health);

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hellfire"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell1));

			Assert.Equal(27, game.CurrentOpponent.Hero.Health);
			Assert.Equal(27, game.CurrentPlayer.Hero.Health);

			Assert.True(((ICharacter)minion5).IsDead);
			Assert.True(((ICharacter)minion1).IsDead);
			Assert.True(((ICharacter)minion2).IsDead);
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [CS2_063] Corruption - COST:1 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Choose an enemy minion. At the start of your turn, destroy it.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_ENEMY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void Corruption_CS2_063()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.PRIEST,
					Player2HeroClass = CardClass.WARLOCK,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();

			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Northshire Cleric"));

			Generic.PlayCardBlock(game.Player1, minion, null, -1, 0, false);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Corruption"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, spell, (ICharacter) minion));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.False(((ICharacter)minion).IsDead);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.True(((ICharacter)minion).IsDead);
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [EX1_302] Mortal Coil - COST:1 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $1 damage to a minion. If that kills it, draw a card. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void MortalCoil_EX1_302()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.PALADIN,
					Player2HeroClass = CardClass.WARLOCK,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.StartGame();

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Razorfen Hunter"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mortal Coil"));
			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mortal Coil"));

			Assert.Equal(3, ((ICharacter)minion1).Health);
			Assert.Equal(1, game.CurrentOpponent.BoardZone[1].Health);

			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, (ICharacter) minion1));

			Assert.Equal(2, ((ICharacter)minion1).Health);

			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, game.CurrentOpponent.BoardZone[1]));

			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal(2, game.CurrentPlayer[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [EX1_308] Soulfire - COST:1 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: [x]Deal $4 damage.
		//       Discard a random card. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void Soulfire_EX1_308()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.PRIEST,
					Player2HeroClass = CardClass.WARLOCK,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.StartGame();

			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Northshire Cleric"));
			Generic.PlayCard(game.CurrentPlayer, minion);
			Assert.Equal(1, game.CurrentPlayer[GameTag.NUM_CARDS_PLAYED_THIS_TURN]);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Soulfire"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, spell, (ICharacter) minion));
			Assert.Equal(1, game.CurrentPlayer[GameTag.NUM_CARDS_PLAYED_THIS_TURN]);

			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(2, game.CurrentPlayer.GraveyardZone.Count);
			Assert.Equal(1, game.CurrentPlayer.Opponent.GraveyardZone.Count);
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [NEW1_003] Sacrificial Pact - COST:0 
		// - Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Destroy a Demon. Restore #5 Health to your hero.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_WITH_RACE = 15
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void SacrificialPact_NEW1_003()
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
			game.Player2.Hero.Damage = 10;

			// Player 1 plays Northshire Cleric (not demon) and Imp Gang Boss (demon)
			IPlayable cleric = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Northshire Cleric"));
			IPlayable impgangboss = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Imp Gang Boss"));
			Generic.PlayCard(game.CurrentPlayer, cleric);
			Generic.PlayCard(game.CurrentPlayer, impgangboss);
			Assert.Equal(2, game.CurrentPlayer[GameTag.NUM_CARDS_PLAYED_THIS_TURN]);

			// end turn
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sacrificial Pact"));
			// this should fail as target is not demon
			game.Process(PlayCardTask.Any(game.CurrentPlayer, spell, (ICharacter) cleric));
			Assert.Equal(0, game.CurrentPlayer[GameTag.NUM_CARDS_PLAYED_THIS_TURN]);

			// now kill the Imp Gang Boss
			game.Process(PlayCardTask.Any(game.CurrentPlayer, spell, (ICharacter) impgangboss));
			Assert.Equal(1, game.CurrentPlayer[GameTag.NUM_CARDS_PLAYED_THIS_TURN]);

			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(1, game.CurrentPlayer.GraveyardZone.Count);
			Assert.Equal(1, game.CurrentPlayer.Opponent.GraveyardZone.Count);
			Assert.Equal(25, game.CurrentPlayer.Hero.Health);

			// end turn
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			// player 1 plays Lord Jaraxxus
			IPlayable jaraxxus = Generic.DrawCard(game.CurrentPlayer, Cards.FromId("EX1_323"));
			Generic.PlayCard(game.CurrentPlayer, jaraxxus);
			Assert.Equal(1, game.CurrentPlayer[GameTag.NUM_CARDS_PLAYED_THIS_TURN]);

			// end turn
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			// player 2 kills opponent with Sacrificial Pact
			spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sacrificial Pact"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, game.CurrentPlayer.Opponent.Hero));

			Assert.Equal(1, game.CurrentPlayer[GameTag.NUM_CARDS_PLAYED_THIS_TURN]);
			Assert.Equal(State.COMPLETE, game.State);
		}

		// --------------------------------------- MINION - WARLOCK
		// [CS2_064] Dread Infernal - COST:6 [ATK:6/HP:6] 
		// - Race: demon, Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 1 damage to ALL other characters.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void DreadInfernal_CS2_064()
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

			IPlayable minion4 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));
			IPlayable minion5 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ironfur Grizzly"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion4));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion5));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Raider"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion3));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion2, game.CurrentOpponent.Hero));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(30, game.CurrentOpponent.Hero.Health);
			Assert.Equal(30, game.CurrentPlayer.Hero.Health);
			Assert.Equal(3, ((ICharacter)minion5).Health);

			IPlayable minion6 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dread Infernal"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion6));

			Assert.Equal(29, game.CurrentOpponent.Hero.Health);
			Assert.Equal(29, game.CurrentPlayer.Hero.Health);
			Assert.Equal(2, ((ICharacter)minion5).Health);
			Assert.True(((ICharacter)minion1).IsDead);
			Assert.True(((ICharacter)minion2).IsDead);
		}

		// --------------------------------------- MINION - WARLOCK
		// [CS2_065] Voidwalker - COST:1 [ATK:1/HP:3] 
		// - Race: demon, Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact]
		public void Voidwalker_CS2_065()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Voidwalker"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.True(((Minion)testCard).HasTaunt);
		}

		// --------------------------------------- MINION - WARLOCK
		// [EX1_306] Succubus - COST:2 [ATK:4/HP:3] 
		// - Race: demon, Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Discard a random card.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void Succubus_EX1_306()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.WARLOCK,
					Player2HeroClass = CardClass.PRIEST,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.StartGame();

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable minion1 = Generic.DrawCard(game.Player1, Cards.FromName("Succubus"));

			Assert.Equal(0, game.Player1[GameTag.NUM_CARDS_PLAYED_THIS_TURN]);

			Assert.Equal(6, game.Player1.HandZone.Count);

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

			Assert.Equal(1, game.Player1[GameTag.NUM_CARDS_PLAYED_THIS_TURN]);

			Assert.Equal(4, game.Player1.HandZone.Count);
			Assert.Equal(1, game.Player1.GraveyardZone.Count);
		}
	}


	public class WarriorCoreTest
	{
		// ---------------------------------------- SPELL - WARRIOR
		// [CS2_103] Charge - COST:1 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Give a friendly minion <b>Charge</b>. It can't attack heroes this turn.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact]
		public void Charge_CS2_103()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.WARRIOR,
					Player2HeroClass = CardClass.PALADIN,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.StartGame();

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));

			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion2, game.CurrentOpponent.BoardZone[0]));
			Assert.Equal(0, minion2[GameTag.NUM_ATTACKS_THIS_TURN]);

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Charge"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, (ICharacter) minion2));

			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion2, game.CurrentOpponent.Hero));
			Assert.Equal(0, minion2[GameTag.NUM_ATTACKS_THIS_TURN]);

			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion2, game.CurrentOpponent.BoardZone[0]));
			Assert.Equal(1, minion2[GameTag.NUM_ATTACKS_THIS_TURN]);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion2, game.CurrentOpponent.Hero));
			Assert.Equal(1, minion2[GameTag.NUM_ATTACKS_THIS_TURN]);
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [CS2_105] Heroic Strike - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Give your hero +4_Attack this turn.
		// --------------------------------------------------------
		[Fact]
		public void HeroicStrike_CS2_105()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.WARRIOR,
					Player2HeroClass = CardClass.PALADIN,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.StartGame();

			Assert.Equal(0, game.CurrentPlayer.Hero.TotalAttackDamage);

			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Heroic Strike"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell2));

			Assert.Equal(4, game.CurrentPlayer.Hero.TotalAttackDamage);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(0, game.CurrentPlayer.Hero.TotalAttackDamage);
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [CS2_108] Execute - COST:2 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Destroy a damaged enemy minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_ENEMY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_DAMAGED_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void Execute_CS2_108()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Raider"));
			var minion3 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sen'jin Shieldmasta"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion3));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable weapon = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fiery War Axe"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, weapon));
			game.Process(HeroAttackTask.Any(game.CurrentPlayer, minion3));

			Assert.Equal(2, minion3.Health);

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Execute"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, minion3));

			Assert.True(minion3.IsDead);
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [CS2_114] Cleave - COST:2 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: [x]Deal $2 damage to
		//       two random enemy
		//       minions. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINIMUM_ENEMY_MINIONS = 2
		// --------------------------------------------------------
		[Fact]
		public void Cleave_CS2_114()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.HUNTER,
					Player2HeroClass = CardClass.WARRIOR,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostwolf Grunt"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, (ICharacter)minion1));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cleave"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));

			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostwolf Grunt"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, (ICharacter)minion2));

			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostwolf Grunt"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, (ICharacter)minion3));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(3, game.CurrentOpponent.BoardZone.Count);

			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));

			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [EX1_400] Whirlwind - COST:1 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $1 damage to ALL_minions. *spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Whirlwind_EX1_400()
		{
			// TODO Whirlwind_EX1_400 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Whirlwind"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [EX1_606] Shield Block - COST:3 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Gain 5 Armor.
		//       Draw a card.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShieldBlock_EX1_606()
		{
			// TODO ShieldBlock_EX1_606 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Shield Block"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [EX1_084] Warsong Commander - COST:3 [ATK:2/HP:3] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Your <b>Charge</b> minions have +1 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		// RefTag:
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact]
		public void WarsongCommander_EX1_084()
		{
			var game =
				new Game(new GameConfig
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

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Raider"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));

			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wolfrider"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));

			Assert.Equal(2, ((Minion)minion1).AttackDamage);
			Assert.Equal(1, ((Minion)minion2).AttackDamage);
			Assert.Equal(3, ((Minion)minion3).AttackDamage);

			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Warsong Commander"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));

			Assert.Equal(2, ((Minion)minion).AttackDamage);
			Assert.Equal(2, ((Minion)minion1).AttackDamage);
			Assert.Equal(2, ((Minion)minion2).AttackDamage);
			Assert.Equal(4, ((Minion)minion3).AttackDamage);

			IPlayable silence = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Silence"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, silence, (ICharacter) minion2));

			Assert.Equal(2, ((Minion)minion).AttackDamage);
			Assert.Equal(2, ((Minion)minion1).AttackDamage);
			Assert.Equal(1, ((Minion)minion2).AttackDamage);
			Assert.Equal(4, ((Minion)minion3).AttackDamage);

			IPlayable silence2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Silence"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, silence2, (ICharacter) minion));

			Assert.Equal(2, ((Minion)minion1).AttackDamage);
			Assert.Equal(1, ((Minion)minion2).AttackDamage);
			Assert.Equal(3, ((Minion)minion3).AttackDamage);
		}

		// --------------------------------------- MINION - WARRIOR
		// [NEW1_011] Kor'kron Elite - COST:4 [ATK:4/HP:3] 
		// - Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Charge</b>
		// --------------------------------------------------------
		// GameTag:
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KorkronElite_NEW1_011()
		{
			// TODO KorkronElite_NEW1_011 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Kor'kron Elite"));
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [CS2_106] Fiery War Axe - COST:3 [ATK:3/HP:0] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// --------------------------------------------------------
		[Fact]
		public void FieryWarAxe_CS2_106()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.WARRIOR,
					Player1Deck = new List<Card>
					{
						Cards.FromName("Fiery War Axe")
					},
					Player2HeroClass = CardClass.MAGE,
					Shuffle = false,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.StartGame();

			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fiery War Axe"));

			Assert.False(game.CurrentPlayer.Hero.IsExhausted);
			Assert.Equal(2, game.CurrentPlayer.Hero.Weapon.Durability);

			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.Opponent.Hero));

			Assert.True(game.CurrentPlayer.Hero.IsExhausted);
			Assert.Equal(1, game.CurrentPlayer.Hero.Weapon.Durability);
			Assert.Equal(27, game.CurrentPlayer.Opponent.Hero.Health);
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [CS2_112] Arcanite Reaper - COST:5 [ATK:5/HP:0] 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArcaniteReaper_CS2_112()
		{
			// TODO ArcaniteReaper_CS2_112 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Arcanite Reaper"));
		}
	}


	public class NeutralCoreTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [CS1_042] Goldshire Footman - COST:1 [ATK:1/HP:2] 
		// - Fac: alliance, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GoldshireFootman_CS1_042()
		{
			// TODO GoldshireFootman_CS1_042 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Goldshire Footman"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_118] Magma Rager - COST:3 [ATK:5/HP:1] 
		// - Set: core, Rarity: free
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MagmaRager_CS2_118()
		{
			// TODO MagmaRager_CS2_118 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Magma Rager"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_119] Oasis Snapjaw - COST:4 [ATK:2/HP:7] 
		// - Race: beast, Set: core, Rarity: free
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OasisSnapjaw_CS2_119()
		{
			// TODO OasisSnapjaw_CS2_119 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Oasis Snapjaw"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_120] River Crocolisk - COST:2 [ATK:2/HP:3] 
		// - Race: beast, Set: core, Rarity: free
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RiverCrocolisk_CS2_120()
		{
			// TODO RiverCrocolisk_CS2_120 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("River Crocolisk"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_121] Frostwolf Grunt - COST:2 [ATK:2/HP:2] 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FrostwolfGrunt_CS2_121()
		{
			// TODO FrostwolfGrunt_CS2_121 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Frostwolf Grunt"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_122] Raid Leader - COST:3 [ATK:2/HP:2] 
		// - Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: Your other minions have +1 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact]
		public void RaidLeader_CS2_122()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;

			Assert.Equal(0, game.Player1[GameTag.NUM_CARDS_PLAYED_THIS_TURN]);

			Generic.DrawCard(game.Player1, Cards.FromName("Murloc Raider"));
			Generic.PlayCard(game.Player1, game.Player1.HandZone[4]);

			Assert.Equal(1, game.Player1[GameTag.NUM_CARDS_PLAYED_THIS_TURN]);
			Assert.Equal(2, game.Player1.BoardZone[0][GameTag.ATK]);

			Generic.DrawCard(game.Player1, Cards.FromName("Raid Leader"));
			Generic.PlayCard(game.Player1, game.Player1.HandZone[4]);

			Assert.Equal(2, game.Player1[GameTag.NUM_CARDS_PLAYED_THIS_TURN]);
			Assert.Equal(3, game.Player1.BoardZone[0][GameTag.ATK]);
			Assert.Equal(2, game.Player1.BoardZone[1][GameTag.ATK]);

			Generic.DrawCard(game.Player1, Cards.FromName("Raid Leader"));
			Generic.PlayCard(game.Player1, game.Player1.HandZone[4]);

			Assert.Equal(3, game.Player1[GameTag.NUM_CARDS_PLAYED_THIS_TURN]);
			Assert.Equal(4, game.Player1.BoardZone[0][GameTag.ATK]);
			Assert.Equal(3, game.Player1.BoardZone[1][GameTag.ATK]);
			Assert.Equal(3, game.Player1.BoardZone[1][GameTag.ATK]);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_124] Wolfrider - COST:3 [ATK:3/HP:1] 
		// - Fac: horde, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Charge</b>
		// --------------------------------------------------------
		// GameTag:
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Wolfrider_CS2_124()
		{
			// TODO Wolfrider_CS2_124 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Wolfrider"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_125] Ironfur Grizzly - COST:3 [ATK:3/HP:3] 
		// - Race: beast, Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IronfurGrizzly_CS2_125()
		{
			// TODO IronfurGrizzly_CS2_125 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ironfur Grizzly"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_127] Silverback Patriarch - COST:3 [ATK:1/HP:4] 
		// - Race: beast, Fac: horde, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SilverbackPatriarch_CS2_127()
		{
			// TODO SilverbackPatriarch_CS2_127 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Silverback Patriarch"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_131] Stormwind Knight - COST:4 [ATK:2/HP:5] 
		// - Fac: alliance, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Charge</b>
		// --------------------------------------------------------
		// GameTag:
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StormwindKnight_CS2_131()
		{
			// TODO StormwindKnight_CS2_131 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stormwind Knight"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_141] Ironforge Rifleman - COST:3 [ATK:2/HP:2] 
		// - Fac: alliance, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 1 damage.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NONSELF_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IronforgeRifleman_CS2_141()
		{
			// TODO IronforgeRifleman_CS2_141 test
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
			//var testCard = Generic.DrawCard(game.CurrentsPlayer,Cards.FromName("Ironforge Rifleman"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_142] Kobold Geomancer - COST:2 [ATK:2/HP:2] 
		// - Fac: horde, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Spell Damage +1</b>
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 1
		// --------------------------------------------------------
		[Fact]
		public void KoboldGeomancer_CS2_142()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Kobold Geomancer"));
			IPlayable testSpell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			IPlayable remover = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostbolt"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
			Assert.Equal(1, game.CurrentPlayer.CurrentSpellPower);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testSpell, game.CurrentOpponent.Hero));
			Assert.Equal(7, game.CurrentOpponent.Hero.Damage);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, remover, (ICharacter) testCard));
			Assert.Equal(0, game.CurrentPlayer.CurrentSpellPower);

			game.CurrentPlayer.UsedMana = 0;

			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kobold Geomancer"));
			IPlayable testSpell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			IPlayable silence = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Silence"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard2));
			Assert.Equal(1, game.CurrentPlayer.CurrentSpellPower);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, silence, (ICharacter) testCard2));
			Assert.Equal(0, game.CurrentPlayer.CurrentSpellPower);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testSpell2, game.CurrentOpponent.Hero));
			Assert.Equal(13, game.CurrentOpponent.Hero.Damage);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_147] Gnomish Inventor - COST:4 [ATK:2/HP:4] 
		// - Fac: alliance, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Draw a card.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GnomishInventor_CS2_147()
		{
			// TODO GnomishInventor_CS2_147 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Gnomish Inventor"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_150] Stormpike Commando - COST:5 [ATK:4/HP:2] 
		// - Fac: alliance, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 2 damage.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NONSELF_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StormpikeCommando_CS2_150()
		{
			// TODO StormpikeCommando_CS2_150 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stormpike Commando"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_155] Archmage - COST:6 [ATK:4/HP:7] 
		// - Fac: alliance, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Spell Damage +1</b>
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Archmage_CS2_155()
		{
			// TODO Archmage_CS2_155 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Archmage"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_162] Lord of the Arena - COST:6 [ATK:6/HP:5] 
		// - Fac: alliance, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LordOfTheArena_CS2_162()
		{
			// TODO LordOfTheArena_CS2_162 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Lord of the Arena"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_168] Murloc Raider - COST:1 [ATK:2/HP:1] 
		// - Race: murloc, Fac: alliance, Set: core, Rarity: free
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MurlocRaider_CS2_168()
		{
			// TODO MurlocRaider_CS2_168 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Murloc Raider"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_171] Stonetusk Boar - COST:1 [ATK:1/HP:1] 
		// - Race: beast, Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Charge</b>
		// --------------------------------------------------------
		// GameTag:
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StonetuskBoar_CS2_171()
		{
			// TODO StonetuskBoar_CS2_171 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stonetusk Boar"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_172] Bloodfen Raptor - COST:2 [ATK:3/HP:2] 
		// - Race: beast, Fac: horde, Set: core, Rarity: free
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BloodfenRaptor_CS2_172()
		{
			// TODO BloodfenRaptor_CS2_172 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bloodfen Raptor"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_173] Bluegill Warrior - COST:2 [ATK:2/HP:1] 
		// - Race: murloc, Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Charge</b>
		// --------------------------------------------------------
		// GameTag:
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BluegillWarrior_CS2_173()
		{
			// TODO BluegillWarrior_CS2_173 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bluegill Warrior"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_179] Sen'jin Shieldmasta - COST:4 [ATK:3/HP:5] 
		// - Fac: horde, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SenjinShieldmasta_CS2_179()
		{
			// TODO SenjinShieldmasta_CS2_179 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sen'jin Shieldmasta"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_182] Chillwind Yeti - COST:4 [ATK:4/HP:5] 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ChillwindYeti_CS2_182()
		{
			// TODO ChillwindYeti_CS2_182 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Chillwind Yeti"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_186] War Golem - COST:7 [ATK:7/HP:7] 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WarGolem_CS2_186()
		{
			// TODO WarGolem_CS2_186 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("War Golem"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_187] Booty Bay Bodyguard - COST:5 [ATK:5/HP:4] 
		// - Fac: horde, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BootyBayBodyguard_CS2_187()
		{
			// TODO BootyBayBodyguard_CS2_187 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Booty Bay Bodyguard"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_189] Elven Archer - COST:1 [ATK:1/HP:1] 
		// - Fac: horde, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 1 damage.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NONSELF_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ElvenArcher_CS2_189()
		{
			// TODO ElvenArcher_CS2_189 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Elven Archer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_196] Razorfen Hunter - COST:3 [ATK:2/HP:3] 
		// - Fac: horde, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 1/1_Boar.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void RazorfenHunter_CS2_196()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.HUNTER,
					Player2HeroClass = CardClass.PALADIN,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.StartGame();

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Razorfen Hunter"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal("CS2_boar", game.CurrentPlayer.BoardZone[1].Card.Id);

			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Razorfen Hunter"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			Assert.Equal(4, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal("CS2_boar", game.CurrentPlayer.BoardZone[3].Card.Id);

			game.Player1.UsedMana = 0;

			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Razorfen Hunter"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			Assert.Equal(6, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal("CS2_boar", game.CurrentPlayer.BoardZone[5].Card.Id);

			IPlayable minion4 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Razorfen Hunter"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion4));
			Assert.Equal(7, game.CurrentPlayer.BoardZone.Count);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_197] Ogre Magi - COST:4 [ATK:4/HP:4] 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Spell Damage +1</b>
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OgreMagi_CS2_197()
		{
			// TODO OgreMagi_CS2_197 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ogre Magi"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_200] Boulderfist Ogre - COST:6 [ATK:6/HP:7] 
		// - Set: core, Rarity: free
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BoulderfistOgre_CS2_200()
		{
			// TODO BoulderfistOgre_CS2_200 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Boulderfist Ogre"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_201] Core Hound - COST:7 [ATK:9/HP:5] 
		// - Race: beast, Set: core, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CoreHound_CS2_201()
		{
			// TODO CoreHound_CS2_201 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Core Hound"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_213] Reckless Rocketeer - COST:6 [ATK:5/HP:2] 
		// - Fac: horde, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Charge</b>
		// --------------------------------------------------------
		// GameTag:
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RecklessRocketeer_CS2_213()
		{
			// TODO RecklessRocketeer_CS2_213 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Reckless Rocketeer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_222] Stormwind Champion - COST:7 [ATK:6/HP:6] 
		// - Fac: alliance, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Your other minions have +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact]
		public void StormwindChampion_CS2_222()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;

			Assert.Equal(0, game.Player1[GameTag.NUM_CARDS_PLAYED_THIS_TURN]);

			Generic.DrawCard(game.Player1, Cards.FromName("Murloc Raider"));
			Generic.PlayCard(game.Player1, game.Player1.HandZone[4]);

			Assert.Equal(1, game.Player1[GameTag.NUM_CARDS_PLAYED_THIS_TURN]);
			Assert.Equal(2, game.Player1.BoardZone[0][GameTag.ATK]);

			Generic.DrawCard(game.Player1, Cards.FromName("Stormwind Champion"));
			Generic.PlayCard(game.Player1, game.Player1.HandZone[4]);

			Assert.Equal(2, game.Player1[GameTag.NUM_CARDS_PLAYED_THIS_TURN]);
			Assert.Equal(3, game.Player1.BoardZone[0][GameTag.ATK]);
			Assert.Equal(2, game.Player1.BoardZone[0][GameTag.HEALTH]);
			Assert.Equal(6, game.Player1.BoardZone[1][GameTag.ATK]);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CS2_226] Frostwolf Warlord - COST:5 [ATK:4/HP:4] 
		// - Fac: horde, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Gain +1/+1 for each other friendly minion on the battlefield.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void FrostwolfWarlord_CS2_226()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.PRIEST,
					Player2HeroClass = CardClass.PRIEST,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.StartGame();

			game.CurrentPlayer.BaseMana = 10;

			IPlayable minion4 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostwolf Warlord"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, (ICharacter)minion4));


			Assert.Equal(4, ((ICharacter)minion4).AttackDamage);
			Assert.Equal(4, ((ICharacter)minion4).Health);

			game.CurrentPlayer.UsedMana = 0;

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostwolf Grunt"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, (ICharacter)minion1));

			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostwolf Grunt"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, (ICharacter)minion2));

			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostwolf Grunt"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, (ICharacter)minion3));

			game.CurrentPlayer.UsedMana = 0;

			IPlayable minion5 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostwolf Warlord"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, (ICharacter)minion5));

			Assert.Equal(8, ((ICharacter)minion5).AttackDamage);
			Assert.Equal(8, ((ICharacter)minion5).Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DS1_055] Darkscale Healer - COST:5 [ATK:4/HP:5] 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Restore 2 Health to all friendly characters.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DarkscaleHealer_DS1_055()
		{
			// TODO DarkscaleHealer_DS1_055 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Darkscale Healer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_011] Voodoo Doctor - COST:1 [ATK:2/HP:1] 
		// - Fac: horde, Set: core, Rarity: free
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
		public void VoodooDoctor_EX1_011()
		{
			// TODO VoodooDoctor_EX1_011 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Voodoo Doctor"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_015] Novice Engineer - COST:2 [ATK:1/HP:1] 
		// - Fac: alliance, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Draw a card.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void NoviceEngineer_EX1_015()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;

			Assert.Equal(1, game.Player1[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);

			IPlayable minion = Generic.DrawCard(game.Player1, Cards.FromName("Novice Engineer"));

			Assert.Equal(1, game.Player1[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);
			Assert.Equal(0, game.Player1[GameTag.NUM_CARDS_PLAYED_THIS_TURN]);

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));

			Assert.Equal(2, game.Player1[GameTag.NUM_CARDS_DRAWN_THIS_TURN]);
			Assert.Equal(1, game.Player1[GameTag.NUM_CARDS_PLAYED_THIS_TURN]);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_019] Shattered Sun Cleric - COST:3 [ATK:3/HP:2] 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly minion +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact]
		public void ShatteredSunCleric_EX1_019()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.HUNTER,
					Player2HeroClass = CardClass.PALADIN,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.StartGame();

			var minion1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

			Assert.Equal(1, minion1.AttackDamage);
			Assert.Equal(1, minion1.Health);

			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shattered Sun Cleric"));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion3, minion1));

			Assert.Equal(2, minion1.AttackDamage);
			Assert.Equal(2, minion1.Health);

			IPlayable silence = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Silence"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, silence, minion1));

			Assert.Equal(1, minion1.AttackDamage);
			Assert.Equal(1, minion1.Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_025] Dragonling Mechanic - COST:4 [ATK:2/HP:4] 
		// - Fac: alliance, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 2/1 Mechanical Dragonling.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DragonlingMechanic_EX1_025()
		{
			// TODO DragonlingMechanic_EX1_025 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Dragonling Mechanic"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_066] Acidic Swamp Ooze - COST:2 [ATK:3/HP:2] 
		// - Fac: alliance, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy your opponent's weapon.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void AcidicSwampOoze_EX1_066()
		{
			var game =
				new Game(new GameConfig
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

			IPlayable weapon = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fiery War Axe"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, weapon));

			Assert.True(game.CurrentPlayer.Hero.Weapon != null);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.True(game.CurrentOpponent.Hero.Weapon != null);

			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Acidic Swamp Ooze"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));

			Assert.False(game.CurrentOpponent.Hero.Weapon != null);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_399] Gurubashi Berserker - COST:5 [ATK:2/HP:7] 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever this minion takes damage, gain +3_Attack.
		// --------------------------------------------------------
		[Fact]
		public void GurubashiBerserker_EX1_399()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.PRIEST,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();

			Minion minion1 = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gurubashi Berserker"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

			Assert.Equal(2, minion1.AttackDamage);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));

			Assert.Equal(5, minion1.AttackDamage);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));

			Assert.Equal(8, minion1.AttackDamage);

			minion1.Silence();

			Assert.Equal(2, minion1.AttackDamage);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_506] Murloc Tidehunter - COST:2 [ATK:2/HP:1] 
		// - Race: murloc, Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 1/1_Murloc Scout.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MurlocTidehunter_EX1_506()
		{
			// TODO MurlocTidehunter_EX1_506 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Murloc Tidehunter"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_508] Grimscale Oracle - COST:1 [ATK:1/HP:1] 
		// - Race: murloc, Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: Your other Murlocs have +1 Attack.
		// --------------------------------------------------------
		[Fact]
		public void GrimscaleOracle_EX1_508()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;

			Assert.Equal(0, game.Player1[GameTag.NUM_CARDS_PLAYED_THIS_TURN]);

			Generic.DrawCard(game.Player1, Cards.FromName("Murloc Raider"));
			Generic.PlayCard(game.Player1, game.Player1.HandZone[4]);

			Assert.Equal(1, game.Player1[GameTag.NUM_CARDS_PLAYED_THIS_TURN]);
			Assert.Equal(2, game.Player1.BoardZone[0][GameTag.ATK]);

			Generic.DrawCard(game.Player1, Cards.FromName("Grimscale Oracle"));
			Generic.PlayCard(game.Player1, game.Player1.HandZone[4]);

			Assert.Equal(2, game.Player1[GameTag.NUM_CARDS_PLAYED_THIS_TURN]);
			Assert.Equal(3, game.Player1.BoardZone[0][GameTag.ATK]);
			Assert.Equal(1, game.Player1.BoardZone[1][GameTag.ATK]);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_582] Dalaran Mage - COST:3 [ATK:1/HP:4] 
		// - Fac: neutral, Set: core, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Spell Damage +1</b>
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DalaranMage_EX1_582()
		{
			// TODO DalaranMage_EX1_582 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Dalaran Mage"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_593] Nightblade - COST:5 [ATK:4/HP:4] 
		// - Fac: neutral, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: <b>Battlecry: </b>Deal 3 damage to the enemy hero.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Nightblade_EX1_593()
		{
			// TODO Nightblade_EX1_593 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Nightblade"));
		}
	}


	public class NonCollectCoreTest
	{
		// ---------------------------------------- SPELL - NEUTRAL
		// [GAME_005] The Coin (*) - COST:0 
		// - Set: core, 
		// --------------------------------------------------------
		// Text: Gain 1 Mana Crystal this turn only.
		// --------------------------------------------------------
		[Fact]
		public void TheCoin_GAME_005()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.DRUID,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.StartGame();

			Assert.Equal(1, game.CurrentPlayer.RemainingMana);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(1, game.CurrentPlayer.RemainingMana);

			game.Process(PlayCardTask.Any(game.CurrentPlayer, game.CurrentPlayer.HandZone[4]));

			Assert.Equal(2, game.CurrentPlayer.RemainingMana);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(2, game.CurrentPlayer.RemainingMana);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(2, game.CurrentPlayer.RemainingMana);
		}

		// ---------------------------------------- MINION - SHAMAN
		// [NEW1_009] Healing Totem (*) - COST:1 [ATK:0/HP:2] 
		// - Race: totem, Set: core, Rarity: free
		// --------------------------------------------------------
		// Text: At the end of your turn, restore 1 Health to all friendly minions.
		// --------------------------------------------------------
		[Fact]
		public void HealingTotem_NEW1_009()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.SHAMAN,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Explosion"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			int totHealth = 0;
			game.CurrentPlayer.BoardZone.ForEach(p => totHealth += p.Health);

			Assert.Equal(3, totHealth);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			int nowHealth = 0;
			game.CurrentOpponent.BoardZone.ForEach(p => nowHealth += p.Health);

			Assert.Equal(totHealth + game.CurrentOpponent.BoardZone.Count, nowHealth);
		}
	}
}
