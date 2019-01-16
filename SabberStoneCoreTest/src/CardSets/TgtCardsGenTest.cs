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
using System.Collections.Generic;
using System.Linq;
using Xunit;
using SabberStoneCore.Config;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.PlayerTasks;
using Generic = SabberStoneCore.Actions.Generic;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model.Zones;

// ReSharper disable RedundantEmptyObjectOrCollectionInitializer

namespace SabberStoneCoreTest.CardSets
{

	public class HeroPowersTgtTest
	{
		// ------------------------------------ HERO_POWER - SHAMAN
		// [AT_050t] Lightning Jolt (*) - COST:2 
		// - Set: tgt, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $2 damage. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LightningJolt_AT_050t()
		{
			// TODO LightningJolt_AT_050t test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Lightning Jolt"));
		}

		// ------------------------------------- HERO_POWER - DRUID
		// [AT_132_DRUID] Dire Shapeshift (*) - COST:2 
		// - Set: tgt, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Gain 2 Armor and +2 Attack this turn.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DireShapeshift_AT_132_DRUID()
		{
			// TODO DireShapeshift_AT_132_DRUID test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Dire Shapeshift"));
		}

		// ------------------------------------ HERO_POWER - HUNTER
		// [AT_132_HUNTER] Ballista Shot (*) - COST:2 
		// - Set: tgt, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $3 damage to the enemy hero. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_STEADY_SHOT = 0
		// - REQ_MINION_OR_ENEMY_HERO = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BallistaShot_AT_132_HUNTER()
		{
			// TODO BallistaShot_AT_132_HUNTER test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ballista Shot"));
		}

		// -------------------------------------- HERO_POWER - MAGE
		// [AT_132_MAGE] Fireblast Rank 2 (*) - COST:2 
		// - Set: tgt, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $2 damage. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FireblastRank2_AT_132_MAGE()
		{
			// TODO FireblastRank2_AT_132_MAGE test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Fireblast Rank 2"));
		}

		// ----------------------------------- HERO_POWER - PALADIN
		// [AT_132_PALADIN] The Silver Hand (*) - COST:2 
		// - Set: tgt, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon two 1/1 Recruits.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheSilverHand_AT_132_PALADIN()
		{
			// TODO TheSilverHand_AT_132_PALADIN test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("The Silver Hand"));
		}

		// ------------------------------------ HERO_POWER - PRIEST
		// [AT_132_PRIEST] Heal (*) - COST:2 
		// - Set: tgt, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Restore #4 Health.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Heal_AT_132_PRIEST()
		{
			// TODO Heal_AT_132_PRIEST test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Heal"));
		}

		// ------------------------------------- HERO_POWER - ROGUE
		// [AT_132_ROGUE] Poisoned Daggers (*) - COST:2 
		// - Set: tgt, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Equip a 2/2 Weapon.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PoisonedDaggers_AT_132_ROGUE()
		{
			// TODO PoisonedDaggers_AT_132_ROGUE test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Poisoned Daggers"));
		}

		// ------------------------------------ HERO_POWER - SHAMAN
		// [AT_132_SHAMAN] Totemic Slam (*) - COST:2 
		// - Set: tgt, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a Totem of your choice.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TotemicSlam_AT_132_SHAMAN()
		{
			// TODO TotemicSlam_AT_132_SHAMAN test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Totemic Slam"));
		}

		// ----------------------------------- HERO_POWER - WARLOCK
		// [AT_132_WARLOCK] Soul Tap (*) - COST:2 
		// - Set: tgt, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Draw a card.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SoulTap_AT_132_WARLOCK()
		{
			// TODO SoulTap_AT_132_WARLOCK test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Soul Tap"));
		}

		// ----------------------------------- HERO_POWER - WARRIOR
		// [AT_132_WARRIOR] Tank Up! (*) - COST:2 
		// - Set: tgt, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Gain 4 Armor.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TankUp_AT_132_WARRIOR()
		{
			// TODO TankUp_AT_132_WARRIOR test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Tank Up!"));
		}
	}


	public class DruidTgtTest
	{
		// ------------------------------------------ SPELL - DRUID
		// [AT_037] Living Roots - COST:1 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Choose One -</b> Deal $2 damage; or Summon two 1/1 Saplings. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void LivingRoots_AT_037()
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
			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Living Roots"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell1, 2));
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Living Roots"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, game.CurrentOpponent.Hero, 1));
			Assert.Equal(28, game.CurrentOpponent.Hero.Health);
		}

		// ------------------------------------------ SPELL - DRUID
		// [AT_043] Astral Communion - COST:4 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: Gain 10 Mana Crystals. Discard your hand.
		// --------------------------------------------------------
		[Fact]
		public void AstralCommunion_AT_043()
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
			game.Player1.BaseMana = 9;
			game.Player2.BaseMana = 9;
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Astral Communion"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard1));
			Assert.Equal(10, game.CurrentPlayer.BaseMana);
			Assert.Equal(10, game.CurrentPlayer.RemainingMana);
			Assert.Equal(0, game.CurrentPlayer.HandZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Astral Communion"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard2));
			Assert.Equal(10, game.CurrentPlayer.BaseMana);
			Assert.Equal(10, game.CurrentPlayer.RemainingMana);
			Assert.Equal(1, game.CurrentPlayer.HandZone.Count);
		}

		// ------------------------------------------ SPELL - DRUID
		// [AT_044] Mulch - COST:3 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: Destroy a minion.
		//       Add a random minion to your opponent's hand.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void Mulch_AT_044()
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
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mulch"));
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal(4, game.CurrentOpponent.HandZone.Count);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, minion));
			Assert.True(minion.ToBeDestroyed);
			Assert.Equal(5, game.CurrentOpponent.HandZone.Count);
			Assert.Equal(CardType.MINION, game.CurrentOpponent.HandZone[4].Card.Type);
		}

		// ----------------------------------------- MINION - DRUID
		// [AT_038] Darnassus Aspirant - COST:2 [ATK:2/HP:3] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Gain an empty Mana Crystal.
		//       <b>Deathrattle:</b> Lose a Mana Crystal.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void DarnassusAspirant_AT_038()
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
			game.Player1.BaseMana = 2;
			game.Player2.BaseMana = 10;
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Darnassus Aspirant"));
			Assert.Equal(2, game.CurrentPlayer.BaseMana);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(3, game.CurrentPlayer.BaseMana);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Swipe"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, testCard));
			Assert.Equal(2, game.CurrentOpponent.BaseMana);
		}

		// ----------------------------------------- MINION - DRUID
		// [AT_039] Savage Combatant - COST:4 [ATK:5/HP:4] 
		// - Race: beast, Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Give your hero
		//       +2 Attack this turn.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact]
		public void SavageCombatant_AT_039()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Savage Combatant"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(0, game.CurrentPlayer.Hero.TotalAttackDamage);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			Assert.Equal(3, game.CurrentPlayer.Hero.TotalAttackDamage);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(0, game.CurrentOpponent.Hero.TotalAttackDamage);
		}

		// ----------------------------------------- MINION - DRUID
		// [AT_040] Wildwalker - COST:4 [ATK:4/HP:4] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly Beast +3 Health.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_WITH_RACE = 20
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact]
		public void Wildwalker_AT_040()
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
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wildwalker"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, minion));
			Assert.Equal(4, ((Minion)minion).Health);
		}

		// ----------------------------------------- MINION - DRUID
		// [AT_041] Knight of the Wild - COST:7 [ATK:6/HP:6] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you summon a Beast, reduce the Cost of this card by (1).
		// --------------------------------------------------------
		[Fact]
		public void KnightOfTheWild_AT_041()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Knight of the Wild"));
			Assert.Equal(7, testCard.Cost);
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Raider"));
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			Assert.Equal(6, testCard.Cost);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			Assert.Equal(6, testCard.Cost);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			Assert.Equal(5, testCard.Cost);
		}

		// ----------------------------------------- MINION - DRUID
		// [AT_042] Druid of the Saber - COST:2 [ATK:2/HP:1] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Choose One -</b> Transform to gain <b>Charge</b>; or +1/+1 and <b>Stealth</b>.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		// RefTag:
		// - STEALTH = 1
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact]
		public void DruidOfTheSaber_AT_042()
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

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Druid of the Saber"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1, 1));
			Assert.Equal(2, game.CurrentPlayer.BoardZone[0].AttackDamage);
			Assert.Equal(1, game.CurrentPlayer.BoardZone[0].Health);
			Assert.True(game.CurrentPlayer.BoardZone[0].HasCharge);
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Druid of the Saber"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2, 2));
			Assert.Equal(3, game.CurrentPlayer.BoardZone[1].AttackDamage);
			Assert.Equal(2, game.CurrentPlayer.BoardZone[1].Health);
			Assert.True(game.CurrentPlayer.BoardZone[1].HasStealth);
		}

		// ----------------------------------------- MINION - DRUID
		// [AT_045] Aviana - COST:9 [ATK:5/HP:5] 
		// - Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: Your minions cost (1).
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - AURA = 1
		// --------------------------------------------------------
		[Fact]
		public void Aviana_AT_045()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Aviana"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Aviana"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flamestrike"));
			game.AuraUpdate();
			Assert.Equal(1, minion1.Cost);
			Assert.Equal(1, minion2.Cost);
			Assert.Equal(7, spell.Cost);
		}
	}


	public class HunterTgtTest
	{
		// ----------------------------------------- SPELL - HUNTER
		// [AT_056] Powershot - COST:3 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $2 damage to a minion and the minions next to it. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void Powershot_AT_056()
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

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Boulderfist Ogre"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			var minion2 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Powershot"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, minion2));
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
		}

		// ----------------------------------------- SPELL - HUNTER
		// [AT_060] Bear Trap - COST:2 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> After your hero is attacked, summon a 3/3 Bear with <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact]
		public void BearTrap_AT_060()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bear Trap"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(0, game.CurrentOpponent.BoardZone.Count);
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion, game.CurrentOpponent.Hero));
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
			Assert.True(game.CurrentOpponent.BoardZone[0].HasTaunt);
		}

		// ----------------------------------------- SPELL - HUNTER
		// [AT_061] Lock and Load - COST:2 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: Each time you cast a spell this turn, add a random Hunter card to your hand.
		// --------------------------------------------------------
		[Fact]
		public void LockAndLoad_AT_061()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lock and Load"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Quick Shot"));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, game.CurrentOpponent.Hero));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
		}

		// ----------------------------------------- SPELL - HUNTER
		// [AT_062] Ball of Spiders - COST:6 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: Summon three 1/1 Webspinners.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact]
		public void BallOfSpiders_AT_062()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ball of Spiders"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(4, game.CurrentOpponent.HandZone.Count);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.BoardZone[0]));
			Assert.Equal(2, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal(5, game.CurrentOpponent.HandZone.Count);
		}

		// ---------------------------------------- MINION - HUNTER
		// [AT_010] Ram Wrangler - COST:5 [ATK:3/HP:3] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you have a Beast, summon a
		//       random Beast.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void RamWrangler_AT_010()
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
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ram Wrangler"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ram Wrangler"));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			game.CurrentPlayer.UsedMana = 0;
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
			Assert.Equal(4, game.CurrentPlayer.BoardZone.Count);
		}

		// ---------------------------------------- MINION - HUNTER
		// [AT_057] Stablemaster - COST:3 [ATK:4/HP:2] 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly Beast <b>Immune</b> this turn.
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
		// - IMMUNE = 1
		// --------------------------------------------------------
		[Fact]
		public void Stablemaster_AT_057()
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
			var minion1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			var minion2 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stablemaster"));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard, minion2));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion2, minion1));
			Assert.True(((Minion)minion1).IsDead);
			Assert.False(((Minion)minion2).IsDead);
		}

		// ---------------------------------------- MINION - HUNTER
		// [AT_058] King's Elekk - COST:2 [ATK:3/HP:2] 
		// - Race: beast, Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Reveal a minion in each deck. If yours costs more, draw it.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void KingsElekk_AT_058()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
				},
				Player2HeroClass = CardClass.MAGE,
				Player2Deck = new List<Card>
				{
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
				},
				FillDecks = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("King's Elekk"));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
			Assert.Equal(4, game.CurrentPlayer.HandZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("King's Elekk"));
			Assert.Equal(7, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
			Assert.Equal(7, game.CurrentPlayer.HandZone.Count);
		}

		// ---------------------------------------- MINION - HUNTER
		// [AT_059] Brave Archer - COST:1 [ATK:2/HP:1] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> If your hand is empty, deal 2 damage to the enemy hero.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact]
		public void BraveArcher_AT_059()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>() { },
				Player2HeroClass = CardClass.HUNTER,
				FillDecks = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Brave Archer"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(20, game.CurrentOpponent.Hero.Health);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			Assert.Equal(16, game.CurrentOpponent.Hero.Health);
		}

		// ---------------------------------------- MINION - HUNTER
		// [AT_063] Acidmaw - COST:7 [ATK:4/HP:2] 
		// - Race: beast, Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever another minion takes damage, destroy it.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact]
		public void Acidmaw_AT_063()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Acidmaw"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion));
			Assert.True(minion.ToBeDestroyed);
		}

		// ---------------------------------------- MINION - HUNTER
		// [AT_063t] Dreadscale - COST:3 [ATK:4/HP:2] 
		// - Race: beast, Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: At the end of your turn, deal 1 damage to all other minions.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Dreadscale_AT_063t()
		{
			// TODO Dreadscale_AT_063t test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Dreadscale"));
		}
	}


	public class MageTgtTest
	{
		// ------------------------------------------- SPELL - MAGE
		// [AT_001] Flame Lance - COST:5 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $8 damage to a minion. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FlameLance_AT_001()
		{
			// TODO FlameLance_AT_001 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Flame Lance"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [AT_002] Effigy - COST:3 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When a friendly minion dies, summon a random minion with the same Cost.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		[Fact]
		public void Effigy_AT_002()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Effigy"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, minion));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(1, game.CurrentOpponent.SecretZone.Count);
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, minion));
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
			Assert.True(minion.ToBeDestroyed);
			Assert.Equal(minion.Cost, game.CurrentOpponent.BoardZone[0].Cost);
			Assert.Equal(0, game.CurrentOpponent.SecretZone.Count);
		}

		// ------------------------------------------- SPELL - MAGE
		// [AT_004] Arcane Blast - COST:1 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: Deal $2 damage to a minion. This spell gets double bonus from <b>Spell Damage</b>. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - RECEIVES_DOUBLE_SPELLDAMAGE_BONUS = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - SPELLPOWER = 1
		// --------------------------------------------------------
		[Fact]
		public void ArcaneBlast_AT_004()
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
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Blast"));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Blast"));
			var minion2 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ironbark Protector"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, minion2));
			game.CurrentPlayer.UsedMana = 0;
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard1, minion2));
			Assert.Equal(6, ((Minion)minion2).Health);
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dalaran Mage"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, minion1));
			game.CurrentPlayer.UsedMana = 0;
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard2, minion2));
			Assert.Equal(2, ((Minion)minion2).Health);
		}

		// ------------------------------------------- SPELL - MAGE
		// [AT_005] Polymorph: Boar - COST:3 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: Transform a minion into a 4/2 Boar with <b>Charge</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PolymorphBoar_AT_005()
		{
			// TODO PolymorphBoar_AT_005 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Polymorph: Boar"));
		}

		// ------------------------------------------ MINION - MAGE
		// [AT_003] Fallen Hero - COST:2 [ATK:3/HP:2] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: Your Hero Power deals 1 extra damage.
		// --------------------------------------------------------
		// GameTag:
		// - HEROPOWER_DAMAGE = 1
		// --------------------------------------------------------
		[Fact]
		public void FallenHero_AT_003()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fallen Hero"));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(29, game.CurrentOpponent.Hero.Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(27, game.CurrentOpponent.Hero.Health);
		}

		// ------------------------------------------ MINION - MAGE
		// [AT_006] Dalaran Aspirant - COST:4 [ATK:3/HP:5] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Gain <b>Spell Damage +1</b>.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact]
		public void DalaranAspirant_AT_006()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dalaran Aspirant"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(0, game.CurrentPlayer.CurrentSpellPower);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(1, game.CurrentPlayer.CurrentSpellPower);
		}

		// ------------------------------------------ MINION - MAGE
		// [AT_007] Spellslinger - COST:3 [ATK:3/HP:4] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add a random spell to each player's hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void Spellslinger_AT_007()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spellslinger"));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(5, game.CurrentOpponent.HandZone.Count);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(6, game.CurrentOpponent.HandZone.Count);
		}

		// ------------------------------------------ MINION - MAGE
		// [AT_008] Coldarra Drake - COST:6 [ATK:6/HP:6] 
		// - Race: dragon, Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: You can use your Hero Power any number of times.
		// --------------------------------------------------------
		[Fact]
		public void ColdarraDrake_AT_008()
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

			game.ProcessCard("Coldarra Drake", asZeroCost: true);
			game.ProcessCard("Maiden of the Lake", asZeroCost: true);

			Assert.Equal(1, game.CurrentPlayer.Hero.HeroPower.Cost);

			for (int i = 0; i < 10; i++)
				game.PlayHeroPower(game.CurrentOpponent.Hero);

			Assert.Equal(10, game.CurrentOpponent.Hero.Damage);
		}

		// ------------------------------------------ MINION - MAGE
		// [AT_009] Rhonin - COST:8 [ATK:7/HP:7] 
		// - Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Add 3 copies of Arcane Missiles to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void Rhonin_AT_009()
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Rhonin"));

			HandZone hand = game.CurrentPlayer.HandZone;

			Assert.Equal(4, hand.Count);

			Minion r1 = game.ProcessCard<Minion>("Rhonin", asZeroCost: true);
			r1.Kill();

			Assert.Equal(7, hand.Count);
			Assert.True(hand.Skip(4).Take(3).ToList().TrueForAll(p => p.Card.Name == "Arcane Missiles"));
		}
	}


	public class PaladinTgtTest
	{
		// ---------------------------------------- SPELL - PALADIN
		// [AT_073] Competitive Spirit - COST:1 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When your turn starts, give your minions +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		[Fact]
		public void CompetitiveSpirit_AT_073()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Competitive Spirit"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(1, game.CurrentPlayer.SecretZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(0, game.CurrentPlayer.SecretZone.Count);
			Assert.Equal(2, ((Minion)minion).AttackDamage);
			Assert.Equal(2, ((Minion)minion).Health);

			minion.ToBeDestroyed = true;
			game.ProcessCard("Competitive Spirit");
			game.EndTurn();
			game.EndTurn();
			Assert.Equal(1, game.CurrentPlayer.SecretZone.Count);
		}

		// ---------------------------------------- SPELL - PALADIN
		// [AT_074] Seal of Champions - COST:3 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: Give a minion
		//       +3 Attack and <b>Divine Shield</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SealOfChampions_AT_074()
		{
			// TODO SealOfChampions_AT_074 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Seal of Champions"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [AT_078] Enter the Coliseum - COST:6 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: Destroy all minions except each player's highest Attack minion.
		// --------------------------------------------------------
		[Fact]
		public void EnterTheColiseum_AT_078()
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
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Enter the Coliseum"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
		}

		// --------------------------------------- MINION - PALADIN
		// [AT_075] Warhorse Trainer - COST:3 [ATK:2/HP:4] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: Your Silver Hand Recruits have +1 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact]
		public void WarhorseTrainer_AT_075()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Warhorse Trainer"));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			Assert.Equal(1, game.CurrentPlayer.BoardZone[0].AttackDamage);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(2, game.CurrentPlayer.BoardZone[0].AttackDamage);
		}

		// --------------------------------------- MINION - PALADIN
		// [AT_076] Murloc Knight - COST:4 [ATK:3/HP:4] 
		// - Race: murloc, Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Summon a random Murloc.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact]
		public void MurlocKnight_AT_076()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Knight"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(Race.MURLOC, game.CurrentPlayer.BoardZone[2].Card.Race);
		}

		// --------------------------------------- MINION - PALADIN
		// [AT_079] Mysterious Challenger - COST:6 [ATK:6/HP:6] 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Put one of each <b>Secret</b> from your deck into the battlefield.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MysteriousChallenger_AT_079()
		{
			// TODO MysteriousChallenger_AT_079 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Mysterious Challenger"));
		}

		// --------------------------------------- MINION - PALADIN
		// [AT_081] Eadric the Pure - COST:7 [ATK:3/HP:7] 
		// - Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Change all enemy minions'
		//       Attack to 1.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EadricThePure_AT_081()
		{
			// TODO EadricThePure_AT_081 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Eadric the Pure"));
		}

		// --------------------------------------- MINION - PALADIN
		// [AT_104] Tuskarr Jouster - COST:5 [ATK:5/HP:5] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Reveal a minion in each deck. If yours costs more, restore 7 Health to your hero.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void TuskarrJouster_AT_104()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
				},
				Player2HeroClass = CardClass.MAGE,
				Player2Deck = new List<Card>
				{
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
				},
				FillDecks = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Player1.Hero.Damage = 10;
			game.Player2.Hero.Damage = 10;
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tuskarr Jouster"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
			Assert.Equal(20, game.CurrentPlayer.Hero.Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tuskarr Jouster"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
			Assert.Equal(27, game.CurrentPlayer.Hero.Health);
		}

		// --------------------------------------- WEAPON - PALADIN
		// [AT_077] Argent Lance - COST:2 [ATK:2/HP:0] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Reveal a minion in each deck. If yours costs more, +1 Durability.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void ArgentLance_AT_077()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Sen'jin Shieldmasta"), // 4-cost
					Cards.FromName("Sen'jin Shieldmasta"),
					Cards.FromName("Grimestreet Enforcer"), // 5-cost
					Cards.FromName("Grimestreet Enforcer"),
					Cards.FromName("Tirion Fordring"), // 8-cost
					Cards.FromName("Argent Commander"), // 6-cost
					Cards.FromName("Argent Commander"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Player2Deck = new List<Card>
				{
					Cards.FromName("Sir Finley Mrrgglton"), // 1-cost
					Cards.FromName("Worgen Infiltrator"), // 2-cost
					Cards.FromName("Worgen Infiltrator"),
					Cards.FromName("Acolyte of Pain"), // 3-cost
					Cards.FromName("Acolyte of Pain"),
					Cards.FromName("Argent Horserider"), // 3-cost
					Cards.FromName("Argent Horserider"),
				},
				FillDecks = false,
				Shuffle = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Argent Lance"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.NotNull(game.CurrentPlayer.Hero.Weapon);
			Assert.Equal(3, game.CurrentPlayer.Hero.Weapon.Durability);
		}
	}


	public class PriestTgtTest
	{
		// ----------------------------------------- SPELL - PRIEST
		// [AT_013] Power Word: Glory - COST:1 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: Choose a minion. Whenever it attacks, restore 4 Health to
		//       your hero.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void PowerWordGlory_AT_013()
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
			game.Player1.Hero.Damage = 10;
			game.Player2.Hero.Damage = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Power Word: Glory"));
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, minion));
			Assert.Equal(20, game.CurrentPlayer.Hero.Health);
			Assert.Equal(20, game.CurrentOpponent.Hero.Health);
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion, game.CurrentOpponent.Hero));
			Assert.Equal(24, game.CurrentPlayer.Hero.Health);
		}

		// ----------------------------------------- SPELL - PRIEST
		// [AT_015] Convert - COST:2 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: Put a copy of an enemy minion into your hand.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_ENEMY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void Convert_AT_015()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.HUNTER,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Convert"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, minion));
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(minion.Card.Id, game.CurrentPlayer.HandZone[5].Card.Id);
		}

		// ----------------------------------------- SPELL - PRIEST
		// [AT_016] Confuse - COST:2 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: Swap the Attack and Health of all minions.
		// --------------------------------------------------------
		[Fact]
		public void Confuse_AT_016()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Confuse"));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shieldbearer"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.True(minion.ToBeDestroyed);
		}

		// ----------------------------------------- SPELL - PRIEST
		// [AT_055] Flash Heal - COST:1 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: Restore #5 Health.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FlashHeal_AT_055()
		{
			// TODO FlashHeal_AT_055 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Flash Heal"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [AT_011] Holy Champion - COST:4 [ATK:3/HP:5] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever a character is healed, gain +2 Attack.
		// --------------------------------------------------------
		[Fact]
		public void HolyChampion_AT_011()
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
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Holy Champion"));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, testCard));
			Assert.Equal(5, ((Minion)testCard).AttackDamage);
		}

		// ---------------------------------------- MINION - PRIEST
		// [AT_012] Spawn of Shadows - COST:4 [ATK:5/HP:4] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Deal 4 damage to each hero.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SpawnOfShadows_AT_012()
		{
			// TODO SpawnOfShadows_AT_012 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Spawn of Shadows"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [AT_014] Shadowfiend - COST:3 [ATK:3/HP:3] 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: Whenever you draw a card, reduce its Cost by (1).
		// --------------------------------------------------------
		[Fact]
		public void Shadowfiend_AT_014()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadowfiend"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Novice Engineer"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			IPlayable lastCardDrawn = game.CurrentPlayer.HandZone[4];
			Assert.Equal(lastCardDrawn.Card.Cost > 0 ? lastCardDrawn.Card.Cost - 1 : 0, lastCardDrawn.Cost);
		}

		// ---------------------------------------- MINION - PRIEST
		// [AT_018] Confessor Paletress - COST:7 [ATK:5/HP:4] 
		// - Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Summon a random <b>Legendary</b> minion.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact]
		public void ConfessorPaletress_AT_018()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Confessor Paletress"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentPlayer.Hero));
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(Rarity.LEGENDARY, game.CurrentPlayer.BoardZone[1].Card.Rarity);
		}

		// ---------------------------------------- MINION - PRIEST
		// [AT_116] Wyrmrest Agent - COST:2 [ATK:1/HP:4] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding a Dragon, gain +1 Attack and <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact]
		public void WyrmrestAgent_AT_116()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Twilight Guardian")
				},
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true,
				Shuffle = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wyrmrest Agent"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.True(((Minion)testCard).HasTaunt);
			Assert.Equal(2, ((Minion)testCard).AttackDamage);
		}
	}


	public class RogueTgtTest
	{
		// ------------------------------------------ SPELL - ROGUE
		// [AT_033] Burgle - COST:3 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: Add 2 random class cards to your hand <i>(from your opponent's class)</i>.
		// --------------------------------------------------------
		[Fact]
		public void Burgle_AT_033()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Burgle"));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(CardClass.PRIEST, game.CurrentPlayer.HandZone[5].Card.Class);
			Assert.Equal(CardClass.PRIEST, game.CurrentPlayer.HandZone[4].Card.Class);
		}

		// ------------------------------------------ SPELL - ROGUE
		// [AT_035] Beneath the Grounds - COST:3 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: Shuffle 3 Ambushes into your opponent's deck. When drawn, you summon a 4/4 Nerubian.
		// --------------------------------------------------------
		[Fact]
		public void BeneathTheGrounds_AT_035()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.ROGUE,
				Player2Deck = new List<Card>
				{
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
				},
				FillDecks = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Beneath the Grounds"));

			game.ProcessCard("Beneath the Grounds");

			Assert.Equal(3, game.CurrentOpponent.DeckZone.Count);

			game.EndTurn();

			Assert.Equal(3, game.CurrentOpponent.BoardZone.Count);
			for (int i = 0; i < 3; i++)
				Assert.Equal("Nerubian", game.CurrentOpponent.BoardZone[i].Card.Name);

			Assert.Equal(1, game.CurrentPlayer.Hero.Fatigue);
		}

		// ----------------------------------------- MINION - ROGUE
		// [AT_028] Shado-Pan Rider - COST:5 [ATK:3/HP:7] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Combo:</b> Gain +3 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		[Fact]
		public void ShadoPanRider_AT_028()
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
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shado-Pan Rider"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shado-Pan Rider"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
			Assert.Equal(3, ((Minion)testCard1).AttackDamage);
			Assert.Equal(6, ((Minion)testCard2).AttackDamage);
		}

		// ----------------------------------------- MINION - ROGUE
		// [AT_029] Buccaneer - COST:1 [ATK:2/HP:1] 
		// - Race: pirate, Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever you equip a weapon, give it +1 Attack.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Buccaneer_AT_029()
		{
			// TODO Buccaneer_AT_029 test
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Buccaneer"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
			IPlayable weapon = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Assassin's Blade"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, weapon));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			//Assert.Equal(1, game.CurrentPlayer.HandZone.Triggers.Count);
			Assert.Equal(game.CurrentPlayer.Hero.Weapon.Card[GameTag.ATK] + 1,
				game.CurrentPlayer.Hero.Weapon.AttackDamage);
		}

		// ----------------------------------------- MINION - ROGUE
		// [AT_030] Undercity Valiant - COST:2 [ATK:3/HP:2] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Combo:</b> Deal 1 damage.
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_FOR_COMBO = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UndercityValiant_AT_030()
		{
			// TODO UndercityValiant_AT_030 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Undercity Valiant"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [AT_031] Cutpurse - COST:2 [ATK:2/HP:2] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever this minion attacks a hero, add the Coin to your hand.
		// --------------------------------------------------------
		[Fact]
		public void Cutpurse_AT_031()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cutpurse"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, testCard, game.CurrentOpponent.Hero));
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
		}

		// ----------------------------------------- MINION - ROGUE
		// [AT_032] Shady Dealer - COST:3 [ATK:4/HP:3] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you have a Pirate, gain +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void ShadyDealer_AT_032()
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
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shady Dealer"));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shady Dealer"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Southsea Deckhand"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
			Assert.Equal(4, ((Minion)testCard1).AttackDamage);
			Assert.Equal(3, ((Minion)testCard1).Health);
			Assert.Equal(5, ((Minion)testCard2).AttackDamage);
			Assert.Equal(4, ((Minion)testCard2).Health);
		}

		// ----------------------------------------- MINION - ROGUE
		// [AT_036] Anub'arak - COST:9 [ATK:8/HP:4] 
		// - Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Return this to your hand and summon a 4/4 Nerubian.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void Anubarak_AT_036()
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
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Anub'arak"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Assassinate"));
			Assert.Equal(4, game.CurrentOpponent.HandZone.Count);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, testCard));
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal(5, game.CurrentOpponent.HandZone.Count);
		}

		// ----------------------------------------- WEAPON - ROGUE
		// [AT_034] Poisoned Blade - COST:4 [ATK:1/HP:0] 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: Your Hero Power gives this weapon +1 Attack instead of replacing it.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 3
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PoisonedBlade_AT_034()
		{
			// TODO PoisonedBlade_AT_034 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Poisoned Blade"));
		}
	}


	public class ShamanTgtTest
	{
		// ----------------------------------------- SPELL - SHAMAN
		// [AT_048] Healing Wave - COST:3 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: Restore #7 Health. Reveal a minion in each deck. If yours costs more, Restore #14 instead.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void HealingWave_AT_048()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
				},
				Player2HeroClass = CardClass.MAGE,
				Player2Deck = new List<Card>
				{
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
				},
				FillDecks = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Player1.Hero.Damage = 14;
			game.Player2.Hero.Damage = 14;
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Healing Wave"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard1, game.CurrentPlayer.Hero));
			Assert.Equal(23, game.CurrentPlayer.Hero.Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Healing Wave"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard2, game.CurrentPlayer.Hero));
			Assert.Equal(30, game.CurrentPlayer.Hero.Health);
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [AT_051] Elemental Destruction - COST:3 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: Deal $4-$5 damage to all minions. <b>Overload:</b> (5). *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 5
		// - OVERLOAD_OWED = 5
		// --------------------------------------------------------
		[Fact]
		public void ElementalDestruction_AT_051()
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
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Oasis Snapjaw"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.CurrentPlayer.UsedMana = 0;
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Oasis Snapjaw"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.CurrentPlayer.UsedMana = 0;
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Oasis Snapjaw"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			game.CurrentPlayer.UsedMana = 0;
			IPlayable minion4 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Oasis Snapjaw"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion4));
			game.CurrentPlayer.UsedMana = 0;
			IPlayable minion5 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Oasis Snapjaw"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion5));
			game.CurrentPlayer.UsedMana = 0;
			IPlayable minion6 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Oasis Snapjaw"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion6));
			game.CurrentPlayer.UsedMana = 0;
			IPlayable minion7 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Oasis Snapjaw"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion7));
			game.CurrentPlayer.UsedMana = 0;
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion8 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Oasis Snapjaw"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion8));
			game.CurrentPlayer.UsedMana = 0;
			IPlayable minion9 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Oasis Snapjaw"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion9));
			game.CurrentPlayer.UsedMana = 0;
			IPlayable minion10 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Oasis Snapjaw"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion10));
			game.CurrentPlayer.UsedMana = 0;
			IPlayable minion11 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Oasis Snapjaw"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion11));
			game.CurrentPlayer.UsedMana = 0;
			IPlayable minion12 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Oasis Snapjaw"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion12));
			game.CurrentPlayer.UsedMana = 0;
			IPlayable minion13 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Oasis Snapjaw"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion13));
			game.CurrentPlayer.UsedMana = 0;
			IPlayable minion14 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Oasis Snapjaw"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion14));
			game.CurrentPlayer.UsedMana = 0;

			Assert.Equal(98, ((Minion)minion1).Health + ((Minion)minion2).Health + ((Minion)minion3).Health
								+ ((Minion)minion4).Health + ((Minion)minion5).Health + ((Minion)minion6).Health
								+ ((Minion)minion7).Health + ((Minion)minion8).Health + ((Minion)minion9).Health
								+ ((Minion)minion10).Health + ((Minion)minion11).Health + ((Minion)minion12).Health
								+ ((Minion)minion13).Health + ((Minion)minion14).Health);
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Elemental Destruction"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.NotEqual(52, ((Minion)minion1).Health + ((Minion)minion2).Health + ((Minion)minion3).Health
								   + ((Minion)minion4).Health + ((Minion)minion5).Health + ((Minion)minion6).Health
								   + ((Minion)minion7).Health + ((Minion)minion8).Health + ((Minion)minion9).Health
								   + ((Minion)minion10).Health + ((Minion)minion11).Health +
								   ((Minion)minion12).Health
								   + ((Minion)minion13).Health + ((Minion)minion14).Health);
			Assert.NotEqual(38, ((Minion)minion1).Health + ((Minion)minion2).Health + ((Minion)minion3).Health
								   + ((Minion)minion4).Health + ((Minion)minion5).Health + ((Minion)minion6).Health
								   + ((Minion)minion7).Health + ((Minion)minion8).Health + ((Minion)minion9).Health
								   + ((Minion)minion10).Health + ((Minion)minion11).Health +
								   ((Minion)minion12).Health
								   + ((Minion)minion13).Health + ((Minion)minion14).Health);
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [AT_053] Ancestral Knowledge - COST:2 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: Draw 2 cards. <b>Overload:</b> (2)
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 2
		// - OVERLOAD_OWED = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AncestralKnowledge_AT_053()
		{
			// TODO AncestralKnowledge_AT_053 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ancestral Knowledge"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [AT_046] Tuskarr Totemic - COST:3 [ATK:3/HP:2] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a random basic Totem.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TuskarrTotemic_AT_046()
		{
			// TODO TuskarrTotemic_AT_046 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Tuskarr Totemic"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [AT_047] Draenei Totemcarver - COST:4 [ATK:4/HP:4] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Gain +1/+1 for each friendly Totem.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void DraeneiTotemcarver_AT_047()
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
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Draenei Totemcarver"));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Draenei Totemcarver"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
			Assert.Equal(4, ((Minion)testCard1).AttackDamage);
			Assert.Equal(4, ((Minion)testCard1).Health);
			Assert.Equal(5, ((Minion)testCard2).AttackDamage);
			Assert.Equal(5, ((Minion)testCard2).Health);
		}

		// ---------------------------------------- MINION - SHAMAN
		// [AT_049] Thunder Bluff Valiant - COST:5 [ATK:3/HP:6] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Give your Totems +2 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact]
		public void ThunderBluffValiant_AT_049()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Thunder Bluff Valiant"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			Assert.Equal(game.CurrentPlayer.BoardZone[1].Card[GameTag.ATK] + 2,
				game.CurrentPlayer.BoardZone[1].AttackDamage);
		}

		// ---------------------------------------- MINION - SHAMAN
		// [AT_052] Totem Golem - COST:2 [ATK:3/HP:4] 
		// - Race: totem, Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Overload:</b> (1)
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 1
		// - OVERLOAD_OWED = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TotemGolem_AT_052()
		{
			// TODO TotemGolem_AT_052 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Totem Golem"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [AT_054] The Mistcaller - COST:6 [ATK:4/HP:4] 
		// - Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give all minions in your hand and deck +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void TheMistcaller_AT_054()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Mistcaller"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			var minionsHand = game.CurrentPlayer.HandZone.Where(p => p is Minion).ToList();
			if (minionsHand.Any())
			{
				int count = minionsHand.Count();
				int nAtk = minionsHand.Sum(p => ((Minion)p).AttackDamage);
				int oAtk = minionsHand.Sum(p => ((Minion)p).Card[GameTag.ATK]);
				Assert.Equal(oAtk + count, nAtk);
				int nHp = minionsHand.Sum(p => ((Minion)p).Health);
				int oHp = minionsHand.Sum(p => ((Minion)p).Card[GameTag.HEALTH]);
				Assert.Equal(oHp + count, nHp);
			}
			var minionsDeck = game.CurrentPlayer.DeckZone.Where(p => p is Minion).ToList();
			if (minionsDeck.Any())
			{
				int count = minionsDeck.Count();
				int nAtk = minionsDeck.Sum(p => ((Minion)p).AttackDamage);
				int oAtk = minionsDeck.Sum(p => ((Minion)p).Card[GameTag.ATK]);
				Assert.Equal(oAtk + count, nAtk);
				int nHp = minionsDeck.Sum(p => ((Minion)p).Health);
				int oHp = minionsDeck.Sum(p => ((Minion)p).Card[GameTag.HEALTH]);
				Assert.Equal(oHp + count, nHp);
			}
		}

		// ---------------------------------------- WEAPON - SHAMAN
		// [AT_050] Charged Hammer - COST:4 [ATK:2/HP:0] 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Your Hero Power becomes 'Deal 2 damage.'
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 4
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ChargedHammer_AT_050()
		{
			// TODO ChargedHammer_AT_050 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Charged Hammer"));
		}
	}


	public class WarlockTgtTest
	{
		// ---------------------------------------- SPELL - WARLOCK
		// [AT_022] Fist of Jaraxxus - COST:4 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: When you play or discard this, deal $4 damage to a random enemy. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - InvisibleDeathrattle = 1
		// --------------------------------------------------------
		[Fact]
		public void FistOfJaraxxus_AT_022()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player2HeroClass = CardClass.WARLOCK,
				Player2Deck = new List<Card>
				{
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
				}
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Fist of Jaraxxus"));

			game.ProcessCard("Succubus");

			Assert.Empty(game.CurrentPlayer.HandZone);

			Assert.Equal(4, game.CurrentOpponent.Hero.Damage);
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [AT_024] Demonfuse - COST:2 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: Give a Demon +3/+3. Give your opponent a Mana Crystal.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_WITH_RACE = 15
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void Demonfuse_AT_024()
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
			game.Player1.BaseMana = 8;
			game.Player2.BaseMana = 8;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Demonfuse"));
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Voidwalker"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(8, game.CurrentOpponent.BaseMana);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, minion));
			Assert.Equal(4, ((Minion)minion).AttackDamage);
			Assert.Equal(6, ((Minion)minion).Health);
			Assert.Equal(9, game.CurrentOpponent.BaseMana);
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [AT_025] Dark Bargain - COST:6 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: Destroy 2 random enemy minions. Discard 2 random cards.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINIMUM_ENEMY_MINIONS = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DarkBargain_AT_025()
		{
			// TODO DarkBargain_AT_025 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Dark Bargain"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [AT_019] Dreadsteed - COST:4 [ATK:1/HP:1] 
		// - Race: demon, Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a Dreadsteed.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void Dreadsteed_AT_019()
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

			Minion test = game.ProcessCard<Minion>("Dreadsteed");
			test.Kill();

			Assert.Empty(game.CurrentPlayer.BoardZone);

			game.EndTurn();

			Assert.Single(game.CurrentOpponent.BoardZone);

			game.EndTurn();

			Assert.Single(game.CurrentPlayer.BoardZone);

			game.EndTurn();

			Assert.Single(game.CurrentOpponent.BoardZone);
		}

		// --------------------------------------- MINION - WARLOCK
		// [AT_020] Fearsome Doomguard - COST:7 [ATK:6/HP:8] 
		// - Race: demon, Set: tgt, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FearsomeDoomguard_AT_020()
		{
			// TODO FearsomeDoomguard_AT_020 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Fearsome Doomguard"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [AT_021] Tiny Knight of Evil - COST:2 [ATK:3/HP:2] 
		// - Race: demon, Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you discard a card, gain +1/+1.
		// --------------------------------------------------------
		[Fact]
		public void TinyKnightOfEvil_AT_021()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tiny Knight of Evil"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Soulfire"));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(3, ((Minion)testCard).AttackDamage);
			Assert.Equal(2, ((Minion)testCard).Health);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, game.CurrentOpponent.Hero));
			Assert.Equal(3, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(4, ((Minion)testCard).AttackDamage);
			Assert.Equal(3, ((Minion)testCard).Health);
		}

		// --------------------------------------- MINION - WARLOCK
		// [AT_023] Void Crusher - COST:6 [ATK:5/HP:4] 
		// - Race: demon, Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Destroy a random minion for each player.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact]
		public void VoidCrusher_AT_023()
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
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Oasis Snapjaw"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.CurrentPlayer.UsedMana = 0;
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Oasis Snapjaw"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.CurrentPlayer.UsedMana = 0;
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Oasis Snapjaw"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion4 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Oasis Snapjaw"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion4));
			game.CurrentPlayer.UsedMana = 0;
			IPlayable minion5 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Oasis Snapjaw"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion5));
			game.CurrentPlayer.UsedMana = 0;
			IPlayable minion6 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Oasis Snapjaw"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion6));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Void Crusher"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(4, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(3, game.CurrentOpponent.BoardZone.Count);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(2, game.CurrentOpponent.BoardZone.Count);
		}

		// --------------------------------------- MINION - WARLOCK
		// [AT_026] Wrathguard - COST:2 [ATK:4/HP:3] 
		// - Race: demon, Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever this minion takes damage, also deal that amount to your hero.
		// --------------------------------------------------------
		[Fact]
		public void Wrathguard_AT_026()
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
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wrathguard"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion, testCard));
			Assert.Equal(2, ((Minion)testCard).Health);
			Assert.Equal(29, game.CurrentOpponent.Hero.Health);
		}

		// --------------------------------------- MINION - WARLOCK
		// [AT_027] Wilfred Fizzlebang - COST:6 [ATK:4/HP:4] 
		// - Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: Cards you draw from your Hero Power cost (0).
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WilfredFizzlebang_AT_027()
		{
			// TODO WilfredFizzlebang_AT_027 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Wilfred Fizzlebang"));
		}
	}


	public class WarriorTgtTest
	{
		// ---------------------------------------- SPELL - WARRIOR
		// [AT_064] Bash - COST:3 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $3 damage.
		//       Gain 3 Armor. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Bash_AT_064()
		{
			// TODO Bash_AT_064 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bash"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [AT_068] Bolster - COST:2 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: Give your <b>Taunt</b> minions +2/+2.
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Bolster_AT_068()
		{
			// TODO Bolster_AT_068 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bolster"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [AT_066] Orgrimmar Aspirant - COST:3 [ATK:3/HP:3] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Give your weapon +1 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact]
		public void OrgrimmarAspirant_AT_066()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Orgrimmar Aspirant"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			Assert.Equal(0, game.CurrentPlayer.Hero.TotalAttackDamage);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable weapon = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fiery War Axe"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, weapon));
			Assert.Equal(3, game.CurrentPlayer.Hero.TotalAttackDamage);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			Assert.Equal(4, game.CurrentPlayer.Hero.TotalAttackDamage);
		}

		// --------------------------------------- MINION - WARRIOR
		// [AT_067] Magnataur Alpha - COST:4 [ATK:5/HP:3] 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: Also damages the minions next to whomever
		//       he attacks.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MagnataurAlpha_AT_067()
		{
			// TODO MagnataurAlpha_AT_067 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Magnataur Alpha"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [AT_069] Sparring Partner - COST:2 [ATK:3/HP:2] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Battlecry:</b> Give a
		//       minion <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SparringPartner_AT_069()
		{
			// TODO SparringPartner_AT_069 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sparring Partner"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [AT_071] Alexstrasza's Champion - COST:2 [ATK:2/HP:3] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding a Dragon, gain +1 Attack and <b>Charge</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AlexstraszasChampion_AT_071()
		{
			// TODO AlexstraszasChampion_AT_071 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Alexstrasza's Champion"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [AT_072] Varian Wrynn - COST:10 [ATK:7/HP:7] 
		// - Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Draw 3 cards.
		//       Put any minions you drew directly into the battlefield.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void VarianWrynn_AT_072()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Varian Wrynn"));
			int count = game.CurrentPlayer.HandZone.Count + game.CurrentPlayer.BoardZone.Count;
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(count + 3, game.CurrentPlayer.HandZone.Count + game.CurrentPlayer.BoardZone.Count);
		}

		// --------------------------------------- MINION - WARRIOR
		// [AT_130] Sea Reaver - COST:6 [ATK:6/HP:7] 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: When you draw this, deal 1 damage to your minions.
		// --------------------------------------------------------
		// GameTag:
		// - TOPDECK = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SeaReaver_AT_130()
		{
			// TODO SeaReaver_AT_130 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sea Reaver"));
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [AT_065] King's Defender - COST:3 [ATK:3/HP:0] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you have a minion with <b>Taunt</b>,  gain +1 Durability.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact]
		public void KingsDefender_AT_065()
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("King's Defender"));

			game.ProcessCard("King's Defender");
			Assert.Equal(2, game.CurrentPlayer.Hero.Weapon.Durability);
			game.ProcessCard("Sen'jin Shieldmasta");
			game.ProcessCard("King's Defender");
			Assert.Equal(3, game.CurrentPlayer.Hero.Weapon.Durability);
		}
	}


	public class NeutralTgtTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [AT_017] Twilight Guardian - COST:4 [ATK:2/HP:6] 
		// - Race: dragon, Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding a Dragon, gain +1 Attack and <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact]
		public void TwilightGuardian_AT_017()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Twilight Guardian")
				},
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true,
				Shuffle = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twilight Guardian"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.True(((Minion)testCard).HasTaunt);
			Assert.Equal(3, ((Minion)testCard).AttackDamage);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_070] Skycap'n Kragg - COST:7 [ATK:4/HP:6] 
		// - Race: pirate, Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Charrrrrge</b>
		//       Costs (1) less for each friendly Pirate.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact]
		public void SkycapnKragg_AT_070()
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
			var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Skycap'n Kragg"));
			int cardCost = testCard.Card.Cost;
			Assert.Equal(cardCost, testCard.Cost);
			game.ProcessCard("Southsea Deckhand");
			game.ProcessCard("Southsea Deckhand");
			game.ProcessCard("Southsea Deckhand");
			Assert.Equal(cardCost - 3, testCard.Cost);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_080] Garrison Commander - COST:2 [ATK:2/HP:3] 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: You can use your Hero Power twice a turn.
		// --------------------------------------------------------
		[Fact]
		public void GarrisonCommander_AT_080()
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Garrison Commander"));

			game.ProcessCard("Garrison Commander");

			HeroPower power = game.CurrentPlayer.Hero.HeroPower;

			game.PlayHeroPower(game.CurrentOpponent.Hero);

			Assert.False(power.IsExhausted);

			game.PlayHeroPower(game.CurrentOpponent.Hero);

			Assert.True(power.IsExhausted);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_082] Lowly Squire - COST:1 [ATK:1/HP:2] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Gain +1 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact]
		public void LowlySquire_AT_082()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lowly Squire"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(1, ((Minion)testCard).AttackDamage);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			Assert.Equal(2, ((Minion)testCard).AttackDamage);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_083] Dragonhawk Rider - COST:3 [ATK:3/HP:3] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Gain <b>Windfury</b>
		//       this turn.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		// RefTag:
		// - WINDFURY = 1
		// --------------------------------------------------------
		[Fact]
		public void DragonhawkRider_AT_083()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragonhawk Rider"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.False(((Minion)testCard).HasWindfury);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			Assert.True(((Minion)testCard).HasWindfury);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.False(((Minion)testCard).HasWindfury);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_084] Lance Carrier - COST:2 [ATK:1/HP:2] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly minion +2 Attack.
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
		public void LanceCarrier_AT_084()
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
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lance Carrier"));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard, minion));
			Assert.Equal(3, ((Minion)minion).AttackDamage);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_085] Maiden of the Lake - COST:4 [ATK:2/HP:6] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: Your Hero Power costs (1).
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact]
		public void MaidenOfTheLake_AT_085()
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
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Maiden of the Lake"));
			Assert.Equal(2, game.CurrentPlayer.Hero.HeroPower.Cost);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(1, game.CurrentPlayer.Hero.HeroPower.Cost);
			IPlayable fireball = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, fireball, testCard));
			Assert.Equal(2, game.CurrentPlayer.Hero.HeroPower.Cost);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_086] Saboteur - COST:3 [ATK:4/HP:3] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Your opponent's Hero Power costs (5) more next turn.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void Saboteur_AT_086()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Saboteur"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(7, game.CurrentPlayer.Hero.HeroPower.Cost);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(2, game.CurrentPlayer.Hero.HeroPower.Cost);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_087] Argent Horserider - COST:3 [ATK:2/HP:1] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Charge</b>
		//       <b>Divine Shield</b>
		// --------------------------------------------------------
		// GameTag:
		// - DIVINE_SHIELD = 1
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArgentHorserider_AT_087()
		{
			// TODO ArgentHorserider_AT_087 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Argent Horserider"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_088] Mogor's Champion - COST:6 [ATK:8/HP:5] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: 50% chance to attack the wrong enemy.
		// --------------------------------------------------------
		// GameTag:
		// - FORGETFUL = 1
		// --------------------------------------------------------
		[Fact]
		public void MogorsChampion_AT_088()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mogor's Champion"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Minion ttMin = game.CurrentOpponent.BoardZone[0];
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, testCard, ttMin));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			ttMin = game.CurrentOpponent.BoardZone[0];
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, testCard, ttMin));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			ttMin = game.CurrentOpponent.BoardZone[0];
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, testCard, ttMin));

			Assert.True(game.CurrentOpponent.Hero.Health  < 30 || (minion1 as Minion).IsDead && (minion2 as Minion).IsDead && (minion3 as Minion).IsDead);
			Assert.True(game.CurrentOpponent.Hero.Health == 30 || !((minion1 as Minion).IsDead && (minion2 as Minion).IsDead && (minion3 as Minion).IsDead));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_089] Boneguard Lieutenant - COST:2 [ATK:3/HP:2] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Gain +1 Health.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact]
		public void BoneguardLieutenant_AT_089()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Boneguard Lieutenant"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			Assert.Equal(3, ((Minion)testCard).Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_090] Mukla's Champion - COST:5 [ATK:4/HP:3] 
		// - Race: beast, Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Give your other minions +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MuklasChampion_AT_090()
		{
			// TODO MuklasChampion_AT_090 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Mukla's Champion"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_091] Tournament Medic - COST:4 [ATK:1/HP:8] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Restore 2 Health to your hero.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TournamentMedic_AT_091()
		{
			// TODO TournamentMedic_AT_091 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Tournament Medic"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_092] Ice Rager - COST:3 [ATK:5/HP:2] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IceRager_AT_092()
		{
			// TODO IceRager_AT_092 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ice Rager"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_093] Frigid Snobold - COST:4 [ATK:2/HP:6] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Spell Damage +1</b>
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FrigidSnobold_AT_093()
		{
			// TODO FrigidSnobold_AT_093 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Frigid Snobold"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_094] Flame Juggler - COST:2 [ATK:2/HP:3] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 1 damage to a random enemy.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FlameJuggler_AT_094()
		{
			// TODO FlameJuggler_AT_094 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Flame Juggler"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_095] Silent Knight - COST:3 [ATK:2/HP:2] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Stealth</b>
		//       <b>Divine Shield</b>
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SilentKnight_AT_095()
		{
			// TODO SilentKnight_AT_095 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Silent Knight"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_096] Clockwork Knight - COST:5 [ATK:5/HP:5] 
		// - Race: mechanical, Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly Mech +1/+1.
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
		[Fact]
		public void ClockworkKnight_AT_096()
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
			var testCard1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Clockwork Knight"));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Clockwork Knight"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard2, testCard1));
			Assert.Equal(6, ((Minion)testCard1).AttackDamage);
			Assert.Equal(6, ((Minion)testCard1).Health);
			Assert.Equal(5, ((Minion)testCard2).AttackDamage);
			Assert.Equal(5, ((Minion)testCard2).Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_097] Tournament Attendee - COST:1 [ATK:2/HP:1] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TournamentAttendee_AT_097()
		{
			// TODO TournamentAttendee_AT_097 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Tournament Attendee"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_098] Sideshow Spelleater - COST:6 [ATK:6/HP:5] 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Copy your opponent's Hero Power.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void SideshowSpelleater_AT_098()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sideshow Spelleater"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(game.CurrentOpponent.Hero.HeroPower.Card.Id, game.CurrentPlayer.Hero.HeroPower.Card.Id);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_099] Kodorider - COST:6 [ATK:3/HP:5] 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Summon a 3/5 War Kodo.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Kodorider_AT_099()
		{
			// TODO Kodorider_AT_099 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Kodorider"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_100] Silver Hand Regent - COST:3 [ATK:3/HP:3] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Summon a 1/1 Silver Hand Recruit.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SilverHandRegent_AT_100()
		{
			// TODO SilverHandRegent_AT_100 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Silver Hand Regent"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_101] Pit Fighter - COST:5 [ATK:5/HP:6] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PitFighter_AT_101()
		{
			// TODO PitFighter_AT_101 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Pit Fighter"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_102] Captured Jormungar - COST:7 [ATK:5/HP:9] 
		// - Race: beast, Set: tgt, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CapturedJormungar_AT_102()
		{
			// TODO CapturedJormungar_AT_102 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Captured Jormungar"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_103] North Sea Kraken - COST:9 [ATK:9/HP:7] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 4 damage.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NorthSeaKraken_AT_103()
		{
			// TODO NorthSeaKraken_AT_103 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("North Sea Kraken"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_105] Injured Kvaldir - COST:1 [ATK:2/HP:4] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 3 damage to this minion.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void InjuredKvaldir_AT_105()
		{
			// TODO InjuredKvaldir_AT_105 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Injured Kvaldir"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_106] Light's Champion - COST:3 [ATK:4/HP:3] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Silence</b> a Demon.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_WITH_RACE = 15
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		// RefTag:
		// - SILENCE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LightsChampion_AT_106()
		{
			// TODO LightsChampion_AT_106 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Light's Champion"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_108] Armored Warhorse - COST:4 [ATK:5/HP:3] 
		// - Race: beast, Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Reveal a minion in each deck. If yours costs more, gain <b>Charge</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArmoredWarhorse_AT_108()
		{
			// TODO ArmoredWarhorse_AT_108 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Armored Warhorse"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_109] Argent Watchman - COST:2 [ATK:2/HP:4] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: Can't attack.
		//       <b>Inspire:</b> Can attack as normal this turn.
		// --------------------------------------------------------
		// GameTag:
		// - CANT_ATTACK = 1
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact]
		public void ArgentWatchman_AT_109()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Argent Watchman"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, testCard, game.CurrentOpponent.Hero));
			Assert.Equal(30, game.CurrentOpponent.Hero.Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, testCard, game.CurrentOpponent.Hero));
			Assert.Equal(27, game.CurrentOpponent.Hero.Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_110] Coliseum Manager - COST:3 [ATK:2/HP:5] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Return this minion to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ColiseumManager_AT_110()
		{
			// TODO ColiseumManager_AT_110 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Coliseum Manager"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_111] Refreshment Vendor - COST:4 [ATK:3/HP:5] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Restore 4 Health to each hero.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RefreshmentVendor_AT_111()
		{
			// TODO RefreshmentVendor_AT_111 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Refreshment Vendor"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_112] Master Jouster - COST:6 [ATK:5/HP:6] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Reveal a minion in each deck. If yours costs more, gain <b>Taunt</b> and <b>Divine Shield</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact]
		public void MasterJouster_AT_112()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
				},
				Player2HeroClass = CardClass.MAGE,
				Player2Deck = new List<Card>
				{
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
				},
				FillDecks = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Master Jouster"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
			Assert.False(((Minion)testCard1).HasTaunt);
			Assert.False(((Minion)testCard1).HasDivineShield);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Master Jouster"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
			Assert.True(((Minion)testCard2).HasTaunt);
			Assert.True(((Minion)testCard2).HasDivineShield);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_113] Recruiter - COST:5 [ATK:5/HP:4] 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Add a 2/2 Squire to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Recruiter_AT_113()
		{
			// TODO Recruiter_AT_113 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Recruiter"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_114] Evil Heckler - COST:4 [ATK:5/HP:4] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EvilHeckler_AT_114()
		{
			// TODO EvilHeckler_AT_114 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Evil Heckler"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_115] Fencing Coach - COST:3 [ATK:2/HP:2] 
		// - Set: tgt, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> The next time you use your Hero Power, it costs (2) less.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FencingCoach_AT_115()
		{
			// TODO FencingCoach_AT_115 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Fencing Coach"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_117] Master of Ceremonies - COST:3 [ATK:4/HP:2] 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you have a minion with <b>Spell Damage</b>, gain +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MasterOfCeremonies_AT_117()
		{
			// TODO MasterOfCeremonies_AT_117 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Master of Ceremonies"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_118] Grand Crusader - COST:6 [ATK:5/HP:5] 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add a random Paladin card to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void GrandCrusader_AT_118()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grand Crusader"));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(CardClass.PALADIN, game.CurrentPlayer.HandZone[4].Card.Class);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_119] Kvaldir Raider - COST:5 [ATK:4/HP:4] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Gain +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KvaldirRaider_AT_119()
		{
			// TODO KvaldirRaider_AT_119 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Kvaldir Raider"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_120] Frost Giant - COST:10 [ATK:8/HP:8] 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: Costs (1) less for each time you used your Hero Power this game.
		// --------------------------------------------------------
		[Fact]
		public void FrostGiant_AT_120()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frost Giant"));
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(10, testCard.Cost);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion));
			Assert.Equal(9, testCard.Cost);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_121] Crowd Favorite - COST:4 [ATK:4/HP:4] 
		// - Set: tgt, Rarity: epic
		// --------------------------------------------------------
		// Text: Whenever you play a card with <b>Battlecry</b>, gain +1/+1.
		// --------------------------------------------------------
		// RefTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void CrowdFavorite_AT_121()
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

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Crowd Favorite"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Novice Engineer"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));

			Assert.Equal(4, ((Minion)minion1).AttackDamage);
			Assert.Equal(4, ((Minion)minion1).Health);

			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion3));

			Assert.Equal(5, ((Minion)minion1).AttackDamage);
			Assert.Equal(5, ((Minion)minion1).Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_122] Gormok the Impaler - COST:4 [ATK:4/HP:4] 
		// - Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you have at least 4 other minions, deal 4 damage.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_MINIONS = 4
		// --------------------------------------------------------
		[Fact]
		public void GormokTheImpaler_AT_122()
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

			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));

			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));

			game.CurrentPlayer.UsedMana = 0;

			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gormok the Impaler"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));

			Assert.Equal(4, game.CurrentPlayer.BoardZone.Count);

			game.CurrentPlayer.UsedMana = 0;

			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gormok the Impaler"));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard2, game.CurrentOpponent.Hero));

			Assert.Equal(5, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(26, game.CurrentOpponent.Hero.Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_123] Chillmaw - COST:7 [ATK:6/HP:6] 
		// - Race: dragon, Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       <b>Deathrattle:</b> If you're holding
		//       a Dragon, deal 3 damage
		//       to all minions.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - TAUNT = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void Chillmaw_AT_123()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				Player2Deck = new List<Card>()
				{
					Cards.FromName("Azure Drake")
				},
				FillDecks = true,
				FillDecksPredictably = true,
				Shuffle = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chillmaw"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, testCard));
			Assert.True(minion.ToBeDestroyed);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_124] Bolf Ramshield - COST:6 [ATK:3/HP:9] 
		// - Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever your hero takes damage, this minion takes it instead.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact]
		public void BolfRamshield_AT_124()
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bolf Ramshield"));

			IPlayable test = game.ProcessCard("Bolf Ramshield");

			game.ProcessCard("Pyroblast", game.CurrentPlayer.Hero, asZeroCost: true);

			Assert.True(test.ToBeDestroyed);
			Assert.Equal(0, game.CurrentPlayer.Hero.Damage);

			// TODO: test with Animated Armor and Ice Block, and Lifesteal or Freeze
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_125] Icehowl - COST:9 [ATK:10/HP:10] 
		// - Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Charge</b>
		//       Can't attack heroes.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact]
		public void Icehowl_AT_125()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Icehowl"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, testCard, game.CurrentOpponent.Hero));
			Assert.Equal(30, game.CurrentOpponent.Hero.Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_127] Nexus-Champion Saraad - COST:5 [ATK:4/HP:5] 
		// - Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Inspire:</b> Add a random spell to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - INSPIRE = 1
		// --------------------------------------------------------
		[Fact]
		public void NexusChampionSaraad_AT_127()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nexus-Champion Saraad"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(4, game.CurrentPlayer.HandZone.Count);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_128] The Skeleton Knight - COST:6 [ATK:7/HP:4] 
		// - Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Reveal a minion in each deck. If yours costs more, return this to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void TheSkeletonKnight_AT_128()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
				},
				Player2HeroClass = CardClass.MAGE,
				Player2Deck = new List<Card>
				{
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
				},
				FillDecks = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Skeleton Knight"));
			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			var testCard2 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Skeleton Knight"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			Assert.Equal(5, game.CurrentOpponent.HandZone.Count);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, testCard1));
			Assert.Equal(5, game.CurrentOpponent.HandZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(6, game.CurrentOpponent.HandZone.Count);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, testCard2));
			Assert.Equal(7, game.CurrentOpponent.HandZone.Count);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_129] Fjola Lightbane - COST:3 [ATK:3/HP:4] 
		// - Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever <b>you</b> target this minion with a spell, gain <b>Divine Shield.</b>
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		// RefTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact]
		public void FjolaLightbane_AT_129()
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
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fjola Lightbane"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Power Word: Shield"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, testCard));
			//Assert.Equal(1, game.CurrentPlayer.HandZone.Triggers.Count);
			Assert.True(((Minion)testCard).HasDivineShield);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_131] Eydis Darkbane - COST:3 [ATK:3/HP:4] 
		// - Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever <b>you</b> target this minion with a spell, deal 3 damage to a random enemy.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact]
		public void EydisDarkbane_AT_131()
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
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eydis Darkbane"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Power Word: Shield"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, testCard));
			//Assert.Equal(1, game.CurrentPlayer.HandZone.Triggers.Count);
			Assert.Equal(27, game.CurrentOpponent.Hero.Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_132] Justicar Trueheart - COST:6 [ATK:6/HP:3] 
		// - Set: tgt, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Replace your starting Hero Power with a better one.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void JusticarTrueheart_AT_132()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Justicar Trueheart"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.StartsWith("AT_132", game.CurrentPlayer.Hero.HeroPower.Card.Id);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [AT_133] Gadgetzan Jouster - COST:1 [ATK:1/HP:2] 
		// - Set: tgt, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Reveal a minion in each deck. If yours costs more, gain +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void GadgetzanJouster_AT_133()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
				},
				Player2HeroClass = CardClass.MAGE,
				Player2Deck = new List<Card>
				{
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
					Cards.FromName("Ironbark Protector"),
				},
				FillDecks = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gadgetzan Jouster"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
			Assert.Equal(1, ((Minion)testCard1).AttackDamage);
			Assert.Equal(2, ((Minion)testCard1).Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gadgetzan Jouster"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
			Assert.Equal(2, ((Minion)testCard2).AttackDamage);
			Assert.Equal(3, ((Minion)testCard2).Health);
		}
	}
}
