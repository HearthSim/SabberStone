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
using SabberStoneCore.Model.Entities;
using Generic = SabberStoneCore.Actions.Generic;
using SabberStoneCore.Tasks.PlayerTasks;

namespace SabberStoneCoreTest.CardSets
{

	public class DruidGvgTest
	{
		// ------------------------------------------ SPELL - DRUID
		// [GVG_031] Recycle - COST:6 
		// - Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: Shuffle an enemy minion into your opponent's deck.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_ENEMY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Recycle_GVG_031()
		{
			// TODO Recycle_GVG_031 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Recycle"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [GVG_033] Tree of Life - COST:9 
		// - Set: pe1, Rarity: epic
		// --------------------------------------------------------
		// Text: Restore all characters to full Health.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TreeOfLife_GVG_033()
		{
			// TODO TreeOfLife_GVG_033 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Tree of Life"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [GVG_041] Dark Wispers - COST:6 
		// - Set: pe1, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Choose One -</b> Summon 5 Wisps; or Give_a minion +5/+5 and <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DarkWispers_GVG_041()
		{
			// TODO DarkWispers_GVG_041 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Dark Wispers"));
		}

		// ----------------------------------------- MINION - DRUID
		// [GVG_030] Anodized Robo Cub - COST:2 [ATK:2/HP:2] 
		// - Race: mechanical, Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>. <b>Choose One -</b>
		//       +1 Attack; or +1 Health.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AnodizedRoboCub_GVG_030()
		{
			// TODO AnodizedRoboCub_GVG_030 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Anodized Robo Cub"));
		}

		// ----------------------------------------- MINION - DRUID
		// [GVG_032] Grove Tender - COST:3 [ATK:2/HP:4] 
		// - Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Choose One -</b> Give each player a Mana Crystal; or Each player draws a card.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GroveTender_GVG_032()
		{
			// TODO GroveTender_GVG_032 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Grove Tender"));
		}

		// ----------------------------------------- MINION - DRUID
		// [GVG_034] Mech-Bear-Cat - COST:6 [ATK:7/HP:6] 
		// - Race: mechanical, Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever this minion takes damage, add a <b>Spare Part</b> card to your hand.
		// --------------------------------------------------------
		// Entourage: PART_007, PART_006, PART_005, PART_001, PART_003, PART_002, PART_004
		// --------------------------------------------------------
		// RefTag:
		// - SPARE_PART = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MechBearCat_GVG_034()
		{
			// TODO MechBearCat_GVG_034 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Mech-Bear-Cat"));
		}

		// ----------------------------------------- MINION - DRUID
		// [GVG_035] Malorne - COST:7 [ATK:9/HP:7] 
		// - Race: beast, Set: pe1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Shuffle this minion into your deck.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Malorne_GVG_035()
		{
			// TODO Malorne_GVG_035 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Malorne"));
		}

		// ----------------------------------------- MINION - DRUID
		// [GVG_080] Druid of the Fang - COST:5 [ATK:4/HP:4] 
		// - Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you have a Beast, transform this minion into a 7/7.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DruidOfTheFang_GVG_080()
		{
			// TODO DruidOfTheFang_GVG_080 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Druid of the Fang"));
		}
	}


	public class HunterGvgTest
	{
		// ----------------------------------------- SPELL - HUNTER
		// [GVG_017] Call Pet - COST:2 
		// - Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: Draw a card.
		//       If it's a Beast, it costs (4) less.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CallPet_GVG_017()
		{
			// TODO CallPet_GVG_017 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Call Pet"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [GVG_026] Feign Death - COST:2 
		// - Set: pe1, Rarity: epic
		// --------------------------------------------------------
		// Text: Trigger all <b>Deathrattles</b> on your minions.
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FeignDeath_GVG_026()
		{
			// TODO FeignDeath_GVG_026 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Feign Death"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [GVG_073] Cobra Shot - COST:5 
		// - Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $3 damage to a minion and the enemy hero. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CobraShot_GVG_073()
		{
			// TODO CobraShot_GVG_073 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Cobra Shot"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [GVG_046] King of Beasts - COST:5 [ATK:2/HP:6] 
		// - Race: beast, Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Taunt</b>. <b>Battlecry:</b> Gain +1 Attack for each other Beast you have.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KingOfBeasts_GVG_046()
		{
			// TODO KingOfBeasts_GVG_046 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("King of Beasts"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [GVG_048] Metaltooth Leaper - COST:3 [ATK:3/HP:3] 
		// - Race: mechanical, Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give your other Mechs +2 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MetaltoothLeaper_GVG_048()
		{
			// TODO MetaltoothLeaper_GVG_048 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Metaltooth Leaper"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [GVG_049] Gahz'rilla - COST:7 [ATK:6/HP:9] 
		// - Race: beast, Set: pe1, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever this minion takes damage, double its Attack.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Gahzrilla_GVG_049()
		{
			// TODO Gahzrilla_GVG_049 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Gahz'rilla"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [GVG_087] Steamwheedle Sniper - COST:2 [ATK:2/HP:3] 
		// - Set: pe1, Rarity: epic
		// --------------------------------------------------------
		// Text: Your Hero Power can target minions.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SteamwheedleSniper_GVG_087()
		{
			// TODO SteamwheedleSniper_GVG_087 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Steamwheedle Sniper"));
		}

		// ---------------------------------------- WEAPON - HUNTER
		// [GVG_043] Glaivezooka - COST:2 [ATK:2/HP:0] 
		// - Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a random friendly minion +1 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Glaivezooka_GVG_043()
		{
			// TODO Glaivezooka_GVG_043 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Glaivezooka"));
		}
	}


	public class MageGvgTest
	{
		// ------------------------------------------- SPELL - MAGE
		// [GVG_001] Flamecannon - COST:2 
		// - Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $4 damage to a random enemy minion. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINIMUM_ENEMY_MINIONS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Flamecannon_GVG_001()
		{
			// TODO Flamecannon_GVG_001 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Flamecannon"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [GVG_003] Unstable Portal - COST:2 
		// - Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: Add a random minion to your hand. It costs (3) less.
		// --------------------------------------------------------
		[Fact]
		public void UnstablePortal_GVG_003()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unstable Portal"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			IPlayable lastCardDrawn = game.CurrentPlayer.HandZone[4];
			Assert.Equal(lastCardDrawn.Card.Cost > 2 ? lastCardDrawn.Card.Cost - 3 : 0, lastCardDrawn.Cost);
		}

		// ------------------------------------------- SPELL - MAGE
		// [GVG_005] Echo of Medivh - COST:4 
		// - Set: pe1, Rarity: epic
		// --------------------------------------------------------
		// Text: Put a copy of each friendly minion into your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EchoOfMedivh_GVG_005()
		{
			// TODO EchoOfMedivh_GVG_005 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Echo of Medivh"));
		}

		// ------------------------------------------ MINION - MAGE
		// [GVG_002] Snowchugger - COST:2 [ATK:2/HP:3] 
		// - Race: mechanical, Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Freeze</b> any character damaged by this minion.
		// --------------------------------------------------------
		// GameTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Snowchugger_GVG_002()
		{
			// TODO Snowchugger_GVG_002 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Snowchugger"));
		}

		// ------------------------------------------ MINION - MAGE
		// [GVG_004] Goblin Blastmage - COST:4 [ATK:5/HP:4] 
		// - Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you have a Mech, deal 4 damage randomly split among all enemies.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GoblinBlastmage_GVG_004()
		{
			// TODO GoblinBlastmage_GVG_004 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Goblin Blastmage"));
		}

		// ------------------------------------------ MINION - MAGE
		// [GVG_007] Flame Leviathan - COST:7 [ATK:7/HP:7] 
		// - Race: mechanical, Set: pe1, Rarity: legendary
		// --------------------------------------------------------
		// Text: When you draw this, deal 2 damage to all characters.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - TOPDECK = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FlameLeviathan_GVG_007()
		{
			// TODO FlameLeviathan_GVG_007 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Flame Leviathan"));
		}

		// ------------------------------------------ MINION - MAGE
		// [GVG_122] Wee Spellstopper - COST:4 [ATK:2/HP:5] 
		// - Set: pe1, Rarity: epic
		// --------------------------------------------------------
		// Text: Adjacent minions can't be targeted by spells or Hero Powers.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WeeSpellstopper_GVG_122()
		{
			// TODO WeeSpellstopper_GVG_122 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Wee Spellstopper"));
		}

		// ------------------------------------------ MINION - MAGE
		// [GVG_123] Soot Spewer - COST:3 [ATK:3/HP:3] 
		// - Race: mechanical, Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Spell Damage +1</b>
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SootSpewer_GVG_123()
		{
			// TODO SootSpewer_GVG_123 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Soot Spewer"));
		}
	}


	public class PaladinGvgTest
	{
		// ---------------------------------------- SPELL - PALADIN
		// [GVG_057] Seal of Light - COST:2 
		// - Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: Restore #4 Health to your hero and gain +2 Attack this turn.
		// --------------------------------------------------------
		[Fact]
		public void SealOfLight_GVG_057()
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

			game.CurrentPlayer.Hero.Damage = 10;
			game.ProcessCard("Seal of Light");

			Assert.Equal(6, game.CurrentPlayer.Hero.Damage);
			Assert.Equal(2, game.CurrentPlayer.Hero.AttackDamage);
			game.EndTurn();
			game.EndTurn();
			Assert.Equal(0, game.CurrentPlayer.Hero.AttackDamage);
		}

		// ---------------------------------------- SPELL - PALADIN
		// [GVG_061] Muster for Battle - COST:3 
		// - Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: Summon three 1/1 Silver Hand Recruits. Equip a 1/4 Weapon.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MusterForBattle_GVG_061()
		{
			// TODO MusterForBattle_GVG_061 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Muster for Battle"));
		}

		// --------------------------------------- MINION - PALADIN
		// [GVG_058] Shielded Minibot - COST:2 [ATK:2/HP:2] 
		// - Race: mechanical, Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Divine Shield</b>
		// --------------------------------------------------------
		// GameTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShieldedMinibot_GVG_058()
		{
			// TODO ShieldedMinibot_GVG_058 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Shielded Minibot"));
		}

		// --------------------------------------- MINION - PALADIN
		// [GVG_060] Quartermaster - COST:5 [ATK:2/HP:5] 
		// - Set: pe1, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give your Silver Hand Recruits +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Quartermaster_GVG_060()
		{
			// TODO Quartermaster_GVG_060 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Quartermaster"));
		}

		// --------------------------------------- MINION - PALADIN
		// [GVG_062] Cobalt Guardian - COST:5 [ATK:6/HP:3] 
		// - Race: mechanical, Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you summon a Mech, gain <b>Divine Shield</b>.
		// --------------------------------------------------------
		// RefTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CobaltGuardian_GVG_062()
		{
			// TODO CobaltGuardian_GVG_062 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Cobalt Guardian"));
		}

		// --------------------------------------- MINION - PALADIN
		// [GVG_063] Bolvar Fordragon - COST:5 [ATK:1/HP:7] 
		// - Set: pe1, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever a friendly minion dies while this is in your hand, gain +1 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact]
		public void BolvarFordragon_GVG_063()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bolvar Fordragon"));

			game.PlayHeroPower(null, 0, true);
			game.PlayHeroPower(null, 0, true);
			game.PlayHeroPower(null, 0, true);
			game.PlayHeroPower(null, 0, true);
			game.PlayHeroPower(null, 0, true);

			game.EndTurn();

			Assert.Equal(5, game.CurrentOpponent.BoardZone.Count);
			game.ProcessCard("Consecration");
			Assert.Equal(0, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal(testCard[GameTag.ATK], testCard.Card[GameTag.ATK] + 5);
		}

		// --------------------------------------- MINION - PALADIN
		// [GVG_101] Scarlet Purifier - COST:3 [ATK:4/HP:3] 
		// - Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 2 damage to all minions with <b>Deathrattle</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ScarletPurifier_GVG_101()
		{
			// TODO ScarletPurifier_GVG_101 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Scarlet Purifier"));
		}

		// --------------------------------------- WEAPON - PALADIN
		// [GVG_059] Coghammer - COST:3 [ATK:2/HP:0] 
		// - Set: pe1, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a random friendly minion <b>Divine Shield</b> and <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 3
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Coghammer_GVG_059()
		{
			// TODO Coghammer_GVG_059 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Coghammer"));
		}
	}


	public class PriestGvgTest
	{
		// ----------------------------------------- SPELL - PRIEST
		// [GVG_008] Lightbomb - COST:6 
		// - Set: pe1, Rarity: epic
		// --------------------------------------------------------
		// Text: Deal damage to each minion equal to its Attack. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - AFFECTED_BY_SPELL_POWER = 1
		// --------------------------------------------------------
		[Fact]
		public void Lightbomb_GVG_008()
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

			Minion target1 = game.ProcessCard<Minion>("River Crocolisk");
			Minion target2 = game.ProcessCard<Minion>("Bloodfen Raptor");
			game.EndTurn();

			Minion target3 = game.ProcessCard<Minion>("River Crocolisk");
			Minion target4 = game.ProcessCard<Minion>("Bloodfen Raptor");
			game.ProcessCard("Lightbomb");
			Assert.Equal(1, target1.Health);
			Assert.True(target2.ToBeDestroyed);
			Assert.Equal(1, target3.Health);
			Assert.True(target4.ToBeDestroyed);
		}

		// ----------------------------------------- SPELL - PRIEST
		// [GVG_010] Velen's Chosen - COST:3 
		// - Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: Give a minion +2/+4 and <b>Spell Damage +1</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - SPELLPOWER = 1
		// --------------------------------------------------------
		[Fact]
		public void VelensChosen_GVG_010()
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

			Minion target = game.ProcessCard<Minion>("Stonetusk Boar");
			game.ProcessCard("Velen's Chosen", target);

			Assert.Equal(3, target.AttackDamage);
			Assert.Equal(5, target.Health);
			Assert.Equal(1, game.CurrentPlayer.CurrentSpellPower);

			target.Kill();

			Assert.Equal(0, game.CurrentPlayer.CurrentSpellPower);
		}

		// ----------------------------------------- SPELL - PRIEST
		// [GVG_012] Light of the Naaru - COST:1 
		// - Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: Restore #3 Health. If the target is still damaged, summon a Lightwarden.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void LightOfTheNaaru_GVG_012()
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

			game.CurrentPlayer.Hero.Damage = 4;
			game.ProcessCard("Light of the Naaru", game.CurrentPlayer.Hero);
			Assert.Equal(1, game.CurrentPlayer.Hero.Damage);
			Assert.Single(game.CurrentPlayer.BoardZone);
			Assert.Equal("Lightwarden", game.CurrentPlayer.BoardZone[0].Card.Name);
		}

		// ---------------------------------------- MINION - PRIEST
		// [GVG_009] Shadowbomber - COST:1 [ATK:2/HP:1] 
		// - Set: pe1, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 3 damage to each hero.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Shadowbomber_GVG_009()
		{
			// TODO Shadowbomber_GVG_009 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Shadowbomber"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [GVG_011] Shrinkmeister - COST:2 [ATK:3/HP:2] 
		// - Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a minion -2 Attack this turn.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Shrinkmeister_GVG_011()
		{
			// TODO Shrinkmeister_GVG_011 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Shrinkmeister"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [GVG_014] Vol'jin - COST:5 [ATK:6/HP:2] 
		// - Set: pe1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Swap Health with another minion.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Voljin_GVG_014()
		{
			// TODO Voljin_GVG_014 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Vol'jin"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [GVG_072] Shadowboxer - COST:2 [ATK:2/HP:3] 
		// - Race: mechanical, Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever a character is healed, deal 1 damage to a random enemy.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Shadowboxer_GVG_072()
		{
			// TODO Shadowboxer_GVG_072 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Shadowboxer"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [GVG_083] Upgraded Repair Bot - COST:5 [ATK:5/HP:5] 
		// - Race: mechanical, Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly Mech +4 Health.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_WITH_RACE = 17
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UpgradedRepairBot_GVG_083()
		{
			// TODO UpgradedRepairBot_GVG_083 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Upgraded Repair Bot"));
		}
	}


	public class RogueGvgTest
	{
		// ------------------------------------------ SPELL - ROGUE
		// [GVG_022] Tinker's Sharpsword Oil - COST:4 
		// - Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: Give your weapon +3 Attack. <b>Combo:</b> Give a random friendly minion +3 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void TinkersSharpswordOil_GVG_022()
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Tinker's Sharpsword Oil"));

			game.PlayHeroPower();

			game.ProcessCard("Tinker's Sharpsword Oil");
			Assert.Equal(4, game.CurrentPlayer.Hero.Weapon.AttackDamage);

			Minion target = game.ProcessCard<Minion>("Stonetusk Boar", null, true);
			game.ProcessCard("Tinker's Sharpsword Oil");
			Assert.Equal(7, game.CurrentPlayer.Hero.Weapon.AttackDamage);
			Assert.Equal(4, target.AttackDamage);
		}

		// ------------------------------------------ SPELL - ROGUE
		// [GVG_047] Sabotage - COST:4 
		// - Set: pe1, Rarity: epic
		// --------------------------------------------------------
		// Text: Destroy a random enemy minion. <b>Combo:</b> And your opponent's weapon.
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_ENEMY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Sabotage_GVG_047()
		{
			// TODO Sabotage_GVG_047 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Sabotage"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [GVG_023] Goblin Auto-Barber - COST:2 [ATK:3/HP:2] 
		// - Race: mechanical, Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give your weapon +1 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GoblinAutoBarber_GVG_023()
		{
			// TODO GoblinAutoBarber_GVG_023 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Goblin Auto-Barber"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [GVG_025] One-eyed Cheat - COST:2 [ATK:4/HP:1] 
		// - Race: pirate, Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you summon a Pirate, gain <b>Stealth</b>.
		// --------------------------------------------------------
		// RefTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OneEyedCheat_GVG_025()
		{
			// TODO OneEyedCheat_GVG_025 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("One-eyed Cheat"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [GVG_027] Iron Sensei - COST:3 [ATK:2/HP:2] 
		// - Race: mechanical, Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: At the end of your turn, give another friendly Mech +2/+2.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IronSensei_GVG_027()
		{
			// TODO IronSensei_GVG_027 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Iron Sensei"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [GVG_028] Trade Prince Gallywix - COST:6 [ATK:5/HP:8] 
		// - Set: pe1, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever your opponent casts a spell, gain a copy of it and give them a Coin.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact]
		public void TradePrinceGallywix_GVG_028()
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

			game.ProcessCard("Trade Prince Gallywix");
			game.EndTurn();

			game.ProcessCard("Sinister Strike");
			Assert.Equal("Sinister Strike", game.CurrentOpponent.HandZone[game.CurrentOpponent.HandZone.Count - 1].Card.Name);
			Assert.Equal(7, game.CurrentPlayer.HandZone.Count);
			Assert.Equal("Gallywix's Coin", game.CurrentPlayer.HandZone[6].Card.Name);

			game.CurrentPlayer.UsedMana = 10;

			game.ProcessCard(game.CurrentPlayer.HandZone[6]);

			Assert.Equal(1, game.CurrentPlayer.RemainingMana);
		}

		// ----------------------------------------- MINION - ROGUE
		// [GVG_088] Ogre Ninja - COST:5 [ATK:6/HP:6] 
		// - Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Stealth</b>
		//       50% chance to attack the wrong enemy.
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// - FORGETFUL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OgreNinja_GVG_088()
		{
			// TODO OgreNinja_GVG_088 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Ogre Ninja"));
		}

		// ----------------------------------------- WEAPON - ROGUE
		// [GVG_024] Cogmaster's Wrench - COST:3 [ATK:1/HP:0] 
		// - Set: pe1, Rarity: epic
		// --------------------------------------------------------
		// Text: Has +2 Attack while you have a Mech.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 3
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CogmastersWrench_GVG_024()
		{
			// TODO CogmastersWrench_GVG_024 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Cogmaster's Wrench"));
		}
	}


	public class ShamanGvgTest
	{
		// ----------------------------------------- SPELL - SHAMAN
		// [GVG_029] Ancestor's Call - COST:4 
		// - Set: pe1, Rarity: epic
		// --------------------------------------------------------
		// Text: Put a random minion from each player's hand into the battlefield.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AncestorsCall_GVG_029()
		{
			// TODO AncestorsCall_GVG_029 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Ancestor's Call"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [GVG_038] Crackle - COST:2 
		// - Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $3-$6 damage. <b>Overload:</b> (1) *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 1
		// - OVERLOAD_OWED = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Crackle_GVG_038()
		{
			// TODO Crackle_GVG_038 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Crackle"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [GVG_037] Whirling Zap-o-matic - COST:2 [ATK:3/HP:2] 
		// - Race: mechanical, Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Windfury</b>
		// --------------------------------------------------------
		// GameTag:
		// - WINDFURY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WhirlingZapOMatic_GVG_037()
		{
			// TODO WhirlingZapOMatic_GVG_037 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Whirling Zap-o-matic"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [GVG_039] Vitality Totem - COST:2 [ATK:0/HP:3] 
		// - Race: totem, Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: At the end of your turn, restore 4 Health to your hero.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VitalityTotem_GVG_039()
		{
			// TODO VitalityTotem_GVG_039 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Vitality Totem"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [GVG_040] Siltfin Spiritwalker - COST:4 [ATK:2/HP:5] 
		// - Race: murloc, Set: pe1, Rarity: epic
		// --------------------------------------------------------
		// Text: Whenever another friendly Murloc dies, draw a card. <b><b>Overload</b>:</b> (1)
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 1
		// - OVERLOAD_OWED = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SiltfinSpiritwalker_GVG_040()
		{
			// TODO SiltfinSpiritwalker_GVG_040 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Siltfin Spiritwalker"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [GVG_042] Neptulon - COST:7 [ATK:7/HP:7] 
		// - Set: pe1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add 4 random Murlocs to your hand. <b>Overload:</b> (3)
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - OVERLOAD = 3
		// - BATTLECRY = 1
		// - OVERLOAD_OWED = 3
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Neptulon_GVG_042()
		{
			// TODO Neptulon_GVG_042 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Neptulon"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [GVG_066] Dunemaul Shaman - COST:4 [ATK:5/HP:4] 
		// - Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Windfury, Overload:</b> (1)
		//       50% chance to attack the wrong enemy.
		// --------------------------------------------------------
		// GameTag:
		// - WINDFURY = 1
		// - OVERLOAD = 1
		// - OVERLOAD_OWED = 1
		// - FORGETFUL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DunemaulShaman_GVG_066()
		{
			// TODO DunemaulShaman_GVG_066 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Dunemaul Shaman"));
		}

		// ---------------------------------------- WEAPON - SHAMAN
		// [GVG_036] Powermace - COST:3 [ATK:3/HP:0] 
		// - Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Give a random friendly Mech +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Powermace_GVG_036()
		{
			// TODO Powermace_GVG_036 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Powermace"));
		}
	}


	public class WarlockGvgTest
	{
		// ---------------------------------------- SPELL - WARLOCK
		// [GVG_015] Darkbomb - COST:2 
		// - Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $3 damage. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Darkbomb_GVG_015()
		{
			// TODO Darkbomb_GVG_015 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Darkbomb"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [GVG_019] Demonheart - COST:5 
		// - Set: pe1, Rarity: epic
		// --------------------------------------------------------
		// Text: Deal $5 damage to a minion.  If it's a friendly Demon, give it +5/+5 instead. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Demonheart_GVG_019()
		{
			// TODO Demonheart_GVG_019 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Demonheart"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [GVG_045] Imp-losion - COST:4 
		// - Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $2-$4 damage to a minion. Summon a 1/1 Imp for each damage dealt. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ImpLosion_GVG_045()
		{
			// TODO ImpLosion_GVG_045 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Imp-losion"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [GVG_018] Queen of Pain - COST:2 [ATK:1/HP:4] 
		// - Race: demon, Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever this minion deals damage, restore that much Health to your hero.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void QueenOfPain_GVG_018()
		{
			// TODO MistressOfPain_GVG_018 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Queen of Pain"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [GVG_020] Fel Cannon - COST:4 [ATK:3/HP:5] 
		// - Race: mechanical, Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: At the end of your turn, deal 2 damage to a non-Mech minion.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FelCannon_GVG_020()
		{
			// TODO FelCannon_GVG_020 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Fel Cannon"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [GVG_021] Mal'Ganis - COST:9 [ATK:9/HP:7] 
		// - Race: demon, Set: pe1, Rarity: legendary
		// --------------------------------------------------------
		// Text: Your other Demons have +2/+2.
		//       Your hero is <b>Immune</b>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - AURA = 1
		// --------------------------------------------------------
		// RefTag:
		// - IMMUNE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Malganis_GVG_021()
		{
			// TODO Malganis_GVG_021 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Mal'Ganis"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [GVG_077] Anima Golem - COST:6 [ATK:9/HP:9] 
		// - Race: mechanical, Set: pe1, Rarity: epic
		// --------------------------------------------------------
		// Text: At the end of each turn, destroy this minion if it's your only one.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AnimaGolem_GVG_077()
		{
			// TODO AnimaGolem_GVG_077 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Anima Golem"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [GVG_100] Floating Watcher - COST:5 [ATK:4/HP:4] 
		// - Race: demon, Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever your hero takes damage on your turn, gain +2/+2.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FloatingWatcher_GVG_100()
		{
			// TODO FloatingWatcher_GVG_100 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Floating Watcher"));
		}
	}


	public class WarriorGvgTest
	{
		// ---------------------------------------- SPELL - WARRIOR
		// [GVG_050] Bouncing Blade - COST:3 
		// - Set: pe1, Rarity: epic
		// --------------------------------------------------------
		// Text: Deal $1 damage to a random minion. Repeat until a minion dies. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINIMUM_TOTAL_MINIONS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BouncingBlade_GVG_050()
		{
			// TODO BouncingBlade_GVG_050 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Bouncing Blade"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [GVG_052] Crush - COST:7 
		// - Set: pe1, Rarity: epic
		// --------------------------------------------------------
		// Text: Destroy a minion. If you have a damaged minion, this costs (4) less.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Crush_GVG_052()
		{
			// TODO Crush_GVG_052 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Crush"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [GVG_051] Warbot - COST:1 [ATK:1/HP:3] 
		// - Race: mechanical, Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Enrage:</b> +1 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - ENRAGED = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Warbot_GVG_051()
		{
			// TODO Warbot_GVG_051 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Warbot"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [GVG_053] Shieldmaiden - COST:6 [ATK:5/HP:5] 
		// - Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Gain 5 Armor.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Shieldmaiden_GVG_053()
		{
			// TODO Shieldmaiden_GVG_053 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Shieldmaiden"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [GVG_055] Screwjank Clunker - COST:4 [ATK:2/HP:5] 
		// - Race: mechanical, Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly Mech +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_WITH_RACE = 17
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ScrewjankClunker_GVG_055()
		{
			// TODO ScrewjankClunker_GVG_055 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Screwjank Clunker"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [GVG_056] Iron Juggernaut - COST:6 [ATK:6/HP:5] 
		// - Race: mechanical, Set: pe1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Shuffle a Mine into your opponent's deck. When drawn, it explodes for 10 damage.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IronJuggernaut_GVG_056()
		{
			// TODO IronJuggernaut_GVG_056 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Iron Juggernaut"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [GVG_086] Siege Engine - COST:5 [ATK:5/HP:5] 
		// - Race: mechanical, Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you gain Armor, give this minion +1 Attack.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SiegeEngine_GVG_086()
		{
			// TODO SiegeEngine_GVG_086 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Siege Engine"));
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [GVG_054] Ogre Warmaul - COST:3 [ATK:4/HP:0] 
		// - Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: 50% chance to attack the wrong enemy.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OgreWarmaul_GVG_054()
		{
			// TODO OgreWarmaul_GVG_054 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Ogre Warmaul"));
		}
	}


	public class NeutralGvgTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [GVG_006] Mechwarper - COST:2 [ATK:2/HP:3] 
		// - Race: mechanical, Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: Your Mechs cost (1) less.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Mechwarper_GVG_006()
		{
			// TODO Mechwarper_GVG_006 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Mechwarper"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_013] Cogmaster - COST:1 [ATK:1/HP:2] 
		// - Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: Has +2 Attack while you have a Mech.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Cogmaster_GVG_013()
		{
			// TODO Cogmaster_GVG_013 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Cogmaster"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_016] Fel Reaver - COST:5 [ATK:8/HP:8] 
		// - Race: mechanical, Set: pe1, Rarity: epic
		// --------------------------------------------------------
		// Text: Whenever your opponent plays a card, remove the top 3 cards of your deck.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FelReaver_GVG_016()
		{
			// TODO FelReaver_GVG_016 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Fel Reaver"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_044] Spider Tank - COST:3 [ATK:3/HP:4] 
		// - Race: mechanical, Set: pe1, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SpiderTank_GVG_044()
		{
			// TODO SpiderTank_GVG_044 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Spider Tank"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_064] Puddlestomper - COST:2 [ATK:3/HP:2] 
		// - Race: murloc, Set: pe1, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Puddlestomper_GVG_064()
		{
			// TODO Puddlestomper_GVG_064 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Puddlestomper"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_065] Ogre Brute - COST:3 [ATK:4/HP:4] 
		// - Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: 50% chance to attack the wrong enemy.
		// --------------------------------------------------------
		// GameTag:
		// - FORGETFUL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OgreBrute_GVG_065()
		{
			// TODO OgreBrute_GVG_065 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Ogre Brute"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_067] Stonesplinter Trogg - COST:2 [ATK:2/HP:3] 
		// - Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever your opponent casts a spell, gain +1 Attack.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StonesplinterTrogg_GVG_067()
		{
			// TODO StonesplinterTrogg_GVG_067 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Stonesplinter Trogg"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_068] Burly Rockjaw Trogg - COST:4 [ATK:3/HP:5] 
		// - Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever your opponent casts a spell, gain +2 Attack.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BurlyRockjawTrogg_GVG_068()
		{
			// TODO BurlyRockjawTrogg_GVG_068 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Burly Rockjaw Trogg"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_069] Antique Healbot - COST:5 [ATK:3/HP:3] 
		// - Race: mechanical, Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Restore 8 Health to your hero.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AntiqueHealbot_GVG_069()
		{
			// TODO AntiqueHealbot_GVG_069 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Antique Healbot"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_070] Salty Dog - COST:5 [ATK:7/HP:4] 
		// - Race: pirate, Set: pe1, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SaltyDog_GVG_070()
		{
			// TODO SaltyDog_GVG_070 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Salty Dog"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_071] Lost Tallstrider - COST:4 [ATK:5/HP:4] 
		// - Race: beast, Set: pe1, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LostTallstrider_GVG_071()
		{
			// TODO LostTallstrider_GVG_071 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Lost Tallstrider"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_074] Kezan Mystic - COST:4 [ATK:4/HP:3] 
		// - Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Take control of a random enemy <b>Secret</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KezanMystic_GVG_074()
		{
			// TODO KezanMystic_GVG_074 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Kezan Mystic"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_075] Ship's Cannon - COST:2 [ATK:2/HP:3] 
		// - Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: After you summon a Pirate, deal 2 damage to a random enemy.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShipsCannon_GVG_075()
		{
			// TODO ShipsCannon_GVG_075 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Ship's Cannon"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_076] Explosive Sheep - COST:2 [ATK:1/HP:1] 
		// - Race: mechanical, Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Deal 2 damage to all minions.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ExplosiveSheep_GVG_076()
		{
			// TODO ExplosiveSheep_GVG_076 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Explosive Sheep"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_078] Mechanical Yeti - COST:4 [ATK:4/HP:5] 
		// - Race: mechanical, Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Give each player a <b>Spare Part.</b>
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		// RefTag:
		// - SPARE_PART = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MechanicalYeti_GVG_078()
		{
			// TODO MechanicalYeti_GVG_078 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Mechanical Yeti"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_079] Force-Tank MAX - COST:8 [ATK:7/HP:7] 
		// - Race: mechanical, Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Divine Shield</b>
		// --------------------------------------------------------
		// GameTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ForceTankMax_GVG_079()
		{
			// TODO ForceTankMax_GVG_079 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Force-Tank MAX"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_081] Gilblin Stalker - COST:2 [ATK:2/HP:3] 
		// - Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Stealth</b>
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GilblinStalker_GVG_081()
		{
			// TODO GilblinStalker_GVG_081 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Gilblin Stalker"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_082] Clockwork Gnome - COST:1 [ATK:2/HP:1] 
		// - Race: mechanical, Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Add a <b>Spare Part</b> card to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		// RefTag:
		// - SPARE_PART = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ClockworkGnome_GVG_082()
		{
			// TODO ClockworkGnome_GVG_082 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Clockwork Gnome"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_084] Flying Machine - COST:3 [ATK:1/HP:4] 
		// - Race: mechanical, Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Windfury</b>
		// --------------------------------------------------------
		// GameTag:
		// - WINDFURY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FlyingMachine_GVG_084()
		{
			// TODO FlyingMachine_GVG_084 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Flying Machine"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_085] Annoy-o-Tron - COST:2 [ATK:1/HP:2] 
		// - Race: mechanical, Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Divine Shield</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AnnoyOTron_GVG_085()
		{
			// TODO AnnoyOTron_GVG_085 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Annoy-o-Tron"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_089] Illuminator - COST:3 [ATK:2/HP:4] 
		// - Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: If you control a <b>Secret</b> at the end of your turn, restore 4 Health to your hero.
		// --------------------------------------------------------
		// RefTag:
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Illuminator_GVG_089()
		{
			// TODO Illuminator_GVG_089 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Illuminator"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_090] Madder Bomber - COST:5 [ATK:5/HP:4] 
		// - Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 6 damage randomly split between all other characters.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MadderBomber_GVG_090()
		{
			// TODO MadderBomber_GVG_090 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Madder Bomber"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_091] Arcane Nullifier X-21 - COST:4 [ATK:2/HP:5] 
		// - Race: mechanical, Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       Can't be targeted by spells or Hero Powers.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - CANT_BE_TARGETED_BY_ABILITIES = 1
		// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArcaneNullifierX21_GVG_091()
		{
			// TODO ArcaneNullifierX21_GVG_091 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Arcane Nullifier X-21"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_092] Gnomish Experimenter - COST:3 [ATK:3/HP:2] 
		// - Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Draw a card. If it's a minion, transform it into a Chicken.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GnomishExperimenter_GVG_092()
		{
			// TODO GnomishExperimenter_GVG_092 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Gnomish Experimenter"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_093] Target Dummy - COST:0 [ATK:0/HP:2] 
		// - Race: mechanical, Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TargetDummy_GVG_093()
		{
			// TODO TargetDummy_GVG_093 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Target Dummy"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_094] Jeeves - COST:4 [ATK:1/HP:4] 
		// - Race: mechanical, Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: At the end of each player's turn, that player draws until they have 3 cards.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Jeeves_GVG_094()
		{
			// TODO Jeeves_GVG_094 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Jeeves"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_095] Goblin Sapper - COST:3 [ATK:2/HP:4] 
		// - Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: Has +4 Attack while your opponent has 6 or more cards in hand.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GoblinSapper_GVG_095()
		{
			// TODO GoblinSapper_GVG_095 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Goblin Sapper"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_096] Piloted Shredder - COST:4 [ATK:4/HP:3] 
		// - Race: mechanical, Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a random 2-Cost minion.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PilotedShredder_GVG_096()
		{
			// TODO PilotedShredder_GVG_096 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Piloted Shredder"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_097] Lil' Exorcist - COST:3 [ATK:2/HP:3] 
		// - Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Battlecry:</b> Gain +1/+1 for each enemy <b>Deathrattle</b> minion.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LilExorcist_GVG_097()
		{
			// TODO LilExorcist_GVG_097 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Lil' Exorcist"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_098] Gnomeregan Infantry - COST:3 [ATK:1/HP:4] 
		// - Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Charge</b>
		//       <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GnomereganInfantry_GVG_098()
		{
			// TODO GnomereganInfantry_GVG_098 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Gnomeregan Infantry"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_099] Bomb Lobber - COST:5 [ATK:3/HP:3] 
		// - Set: pe1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 4 damage to a random enemy minion.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BombLobber_GVG_099()
		{
			// TODO BombLobber_GVG_099 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Bomb Lobber"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_102] Tinkertown Technician - COST:3 [ATK:3/HP:3] 
		// - Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you have a Mech, gain +1/+1 and add a <b>Spare Part</b> to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - SPARE_PART = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TinkertownTechnician_GVG_102()
		{
			// TODO TinkertownTechnician_GVG_102 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Tinkertown Technician"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_103] Micro Machine - COST:2 [ATK:1/HP:2] 
		// - Race: mechanical, Set: pe1, Rarity: common
		// --------------------------------------------------------
		// Text: At the start of each turn, gain +1 Attack.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MicroMachine_GVG_103()
		{
			// TODO MicroMachine_GVG_103 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Micro Machine"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_104] Hobgoblin - COST:3 [ATK:2/HP:3] 
		// - Set: pe1, Rarity: epic
		// --------------------------------------------------------
		// Text: Whenever you play a 1-Attack minion, give it +2/+2.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Hobgoblin_GVG_104()
		{
			// TODO Hobgoblin_GVG_104 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Hobgoblin"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_105] Piloted Sky Golem - COST:6 [ATK:6/HP:4] 
		// - Race: mechanical, Set: pe1, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a random 4-Cost minion.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PilotedSkyGolem_GVG_105()
		{
			// TODO PilotedSkyGolem_GVG_105 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Piloted Sky Golem"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_106] Junkbot - COST:5 [ATK:1/HP:5] 
		// - Race: mechanical, Set: pe1, Rarity: epic
		// --------------------------------------------------------
		// Text: Whenever a friendly Mech dies, gain +2/+2.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Junkbot_GVG_106()
		{
			// TODO Junkbot_GVG_106 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Junkbot"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_107] Enhance-o Mechano - COST:4 [ATK:3/HP:2] 
		// - Race: mechanical, Set: pe1, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give your other minions <b>Windfury</b>, <b>Taunt</b>, or <b>Divine Shield</b>
		//       <i>(at random)</i>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - WINDFURY = 1
		// - TAUNT = 1
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EnhanceOMechano_GVG_107()
		{
			// TODO EnhanceOMechano_GVG_107 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Enhance-o Mechano"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_108] Recombobulator - COST:2 [ATK:3/HP:2] 
		// - Set: pe1, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Transform a friendly minion into a random minion with the same Cost.
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
		public void Recombobulator_GVG_108()
		{
			// TODO Recombobulator_GVG_108 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Recombobulator"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_109] Mini-Mage - COST:4 [ATK:4/HP:1] 
		// - Set: pe1, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Stealth</b>
		//       <b>Spell Damage +1</b>
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// - SPELLPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MiniMage_GVG_109()
		{
			// TODO MiniMage_GVG_109 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Mini-Mage"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_110] Dr. Boom - COST:7 [ATK:7/HP:7] 
		// - Set: pe1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon two 1/1 Boom Bots. <i>WARNING: Bots may explode.</i>
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DrBoom_GVG_110()
		{
			// TODO DrBoom_GVG_110 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Dr. Boom"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_111] Mimiron's Head - COST:5 [ATK:4/HP:5] 
		// - Race: mechanical, Set: pe1, Rarity: legendary
		// --------------------------------------------------------
		// Text: At the start of your turn, if you have at least 3 Mechs, destroy them all and form V-07-TR-0N.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MimironsHead_GVG_111()
		{
			// TODO MimironsHead_GVG_111 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Mimiron's Head"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_112] Mogor the Ogre - COST:6 [ATK:7/HP:6] 
		// - Set: pe1, Rarity: legendary
		// --------------------------------------------------------
		// Text: All minions have a 50% chance to attack the wrong enemy.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MogorTheOgre_GVG_112()
		{
			// TODO MogorTheOgre_GVG_112 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Mogor the Ogre"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_113] Foe Reaper 4000 - COST:8 [ATK:6/HP:9] 
		// - Race: mechanical, Set: pe1, Rarity: legendary
		// --------------------------------------------------------
		// Text: Also damages the minions next to whomever it attacks.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FoeReaper4000_GVG_113()
		{
			// TODO FoeReaper4000_GVG_113 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Foe Reaper 4000"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_114] Sneed's Old Shredder - COST:8 [ATK:5/HP:7] 
		// - Race: mechanical, Set: pe1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a random <b>Legendary</b> minion.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SneedsOldShredder_GVG_114()
		{
			// TODO SneedsOldShredder_GVG_114 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Sneed's Old Shredder"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_115] Toshley - COST:6 [ATK:5/HP:7] 
		// - Set: pe1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry and Deathrattle:</b> Add a <b>Spare Part</b> card to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - SPARE_PART = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Toshley_GVG_115()
		{
			// TODO Toshley_GVG_115 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Toshley"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_116] Mekgineer Thermaplugg - COST:9 [ATK:9/HP:7] 
		// - Race: mechanical, Set: pe1, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever an enemy minion dies, summon a Leper Gnome.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MekgineerThermaplugg_GVG_116()
		{
			// TODO MekgineerThermaplugg_GVG_116 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Mekgineer Thermaplugg"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_117] Gazlowe - COST:6 [ATK:3/HP:6] 
		// - Set: pe1, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever you cast a 1-mana spell, add a random Mech to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Gazlowe_GVG_117()
		{
			// TODO Gazlowe_GVG_117 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Gazlowe"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_118] Troggzor the Earthinator - COST:7 [ATK:6/HP:6] 
		// - Set: pe1, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever your opponent casts a spell, summon a Burly Rockjaw Trogg.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TroggzorTheEarthinator_GVG_118()
		{
			// TODO TroggzorTheEarthinator_GVG_118 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Troggzor the Earthinator"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_119] Blingtron 3000 - COST:5 [ATK:3/HP:4] 
		// - Race: mechanical, Set: pe1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Equip a random weapon for each player.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Blingtron3000_GVG_119()
		{
			// TODO Blingtron3000_GVG_119 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Blingtron 3000"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_120] Hemet Nesingwary - COST:5 [ATK:6/HP:3] 
		// - Set: pe1, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy a Beast.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_WITH_RACE = 20
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HemetNesingwary_GVG_120()
		{
			// TODO HemetNesingwary_GVG_120 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Hemet Nesingwary"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GVG_121] Clockwork Giant - COST:12 [ATK:8/HP:8] 
		// - Race: mechanical, Set: pe1, Rarity: epic
		// --------------------------------------------------------
		// Text: Costs (1) less for each card in your opponent's hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ClockworkGiant_GVG_121()
		{
			// TODO ClockworkGiant_GVG_121 test
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
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Clockwork Giant"));
		}
	}
}
