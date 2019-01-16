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
using SabberStoneCore.Model.Entities;

using Generic = SabberStoneCore.Actions.Generic;

namespace SabberStoneCoreTest.CardSets
{

	public class HeroPowersBrmTest
	{
		// ----------------------------------- HERO_POWER - NEUTRAL
		// [BRM_027pH] DIE, INSECTS! (*) - COST:2 
		// - Set: fp2, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $8 damage to a random enemy. TWICE. *spelldmg
		// --------------------------------------------------------
		[Fact]
		public void DieInsects_BRM_027pH()
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
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Majordomo Executus"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadow Word: Death"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, testCard));
			Assert.Equal(8, game.CurrentOpponent.Hero.Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			Assert.Equal(22, game.CurrentOpponent.Hero.Health);
		}
	}


	public class DruidBrmTest
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
		[Fact]
		public void VolcanicLumberer_BRM_009()
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
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Volcanic Lumberer"));
			//IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			//game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			//Assert.Equal(1, testCard.OldEnchants.Count);
			//Assert.Equal(9, testCard.Cost);
			//game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion));
			//Assert.Equal(8, testCard.Cost);
			//game.Process(EndTurnTask.Any(game.CurrentPlayer));
			//game.Process(EndTurnTask.Any(game.CurrentPlayer));
			//Assert.Equal(9, testCard.Cost);
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
		[Fact]
		public void DruidOfTheFlame_BRM_010()
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
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Druid of the Flame"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1, 1));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Druid of the Flame"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2, 2));
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(5, game.CurrentPlayer.BoardZone[0].AttackDamage);
			Assert.Equal(2, game.CurrentPlayer.BoardZone[0].Health);
			Assert.Equal(2, game.CurrentPlayer.BoardZone[1].AttackDamage);
			Assert.Equal(5, game.CurrentPlayer.BoardZone[1].Health);
		}
	}


	public class HunterBrmTest
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
		[Fact]
		public void QuickShot_BRM_013()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
				},
				Player2HeroClass = CardClass.HUNTER,
				Player2Deck = new List<Card>()
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
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Quick Shot"));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Quick Shot"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard1, game.CurrentOpponent.Hero));
			Assert.Equal(27, game.CurrentOpponent.Hero.Health);
			Assert.Equal(0, game.CurrentPlayer.NumCardsDrawnThisTurn);
			Assert.Equal(20, game.CurrentPlayer.Hero.Health);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard2, game.CurrentOpponent.Hero));
			Assert.Equal(0, game.CurrentPlayer.NumCardsDrawnThisTurn);
			Assert.Equal(24, game.CurrentOpponent.Hero.Health);
			Assert.Equal(15, game.CurrentPlayer.Hero.Health);
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
		[Fact]
		public void CoreRager_BRM_014()
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
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Core Rager"));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Core Rager"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
			Assert.Equal(4, ((Minion)testCard1).Health);
			Assert.Equal(4, ((Minion)testCard1).AttackDamage);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
			Assert.Equal(7, ((Minion)testCard2).Health);
			Assert.Equal(7, ((Minion)testCard2).AttackDamage);
		}
	}


	public class MageBrmTest
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
		[Fact]
		public void DragonsBreath_BRM_003()
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
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragon's Breath"));
			//IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			//game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			//Assert.Equal(1, testCard.OldEnchants.Count);
			//Assert.Equal(5, testCard.Cost);
			//game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion));
			//Assert.Equal(4, testCard.Cost);
			//game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, game.CurrentOpponent.Hero));
			//Assert.Equal(26, game.CurrentOpponent.Hero.Health);
		}

		// ------------------------------------------ MINION - MAGE
		// [BRM_002] Flamewaker - COST:3 [ATK:2/HP:4] 
		// - Set: fp2, Rarity: rare
		// --------------------------------------------------------
		// Text: After you cast a spell, deal 2 damage randomly split among all enemies.
		// --------------------------------------------------------
		[Fact]
		public void Flamewaker_BRM_002()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flamewaker"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(33, ((Minion)minion1).Health + ((Minion)minion2).Health + game.CurrentOpponent.Hero.Health);
			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, game.CurrentOpponent.Hero));
			Assert.Equal(25,
				(((Minion)minion1).IsDead ? 0 : ((Minion)minion1).Health) +
				(((Minion)minion2).IsDead ? 0 : ((Minion)minion2).Health) +
				game.CurrentOpponent.Hero.Health);
		}
	}


	public class PaladinBrmTest
	{
		// ---------------------------------------- SPELL - PALADIN
		// [BRM_001] Solemn Vigil - COST:5 
		// - Set: fp2, Rarity: common
		// --------------------------------------------------------
		// Text: Draw 2 cards. Costs (1) less for each minion that died this turn.
		// --------------------------------------------------------
		[Fact]
		public void SolemnVigil_BRM_001()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Solemn Vigil"));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			//Assert.Equal(1, testCard.OldEnchants.Count);
			//Assert.Equal(5, testCard.Cost);
			//game.Process(EndTurnTask.Any(game.CurrentPlayer));
			//IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			//game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			//game.Process(EndTurnTask.Any(game.CurrentPlayer));
			//Assert.Equal(5, testCard.Cost);
			//Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
			//game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion1, minion2));
			//Assert.Equal(3, testCard.Cost);
			//game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			//Assert.Equal(7, game.CurrentPlayer.HandZone.Count);
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
		[Fact(Skip = "ignore")]
		public void DragonConsort_BRM_018()
		{
			// TODO DragonConsort_BRM_018 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Dragon Consort"));
		}
	}


	public class PriestBrmTest
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
		[Fact]
		public void Resurrect_BRM_017()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Resurrect"));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			var minion = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Injured Blademaster"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, minion));
			Assert.Equal(0, game.CurrentOpponent.BoardZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(minion.Card.Id, game.CurrentPlayer.BoardZone[0].Card.Id);
			Assert.Equal(7, game.CurrentPlayer.BoardZone[0].Health);
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
		[Fact]
		public void TwilightWhelp_BRM_004()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Azure Drake")
				},
				Player2HeroClass = CardClass.PRIEST,
				Player2Deck = new List<Card>(),
				FillDecks = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twilight Whelp"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twilight Whelp"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
			Assert.Equal(3, ((Minion)testCard1).Health);
			Assert.Equal(1, ((Minion)testCard2).Health);
		}
	}


	public class RogueBrmTest
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
		[Fact]
		public void GangUp_BRM_007()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gang Up"));
			var minion = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(26, game.CurrentPlayer.DeckZone.Count);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, minion));
			Assert.Equal(29, game.CurrentPlayer.DeckZone.Count);
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
		[Fact(Skip = "ignore")]
		public void DarkIronSkulker_BRM_008()
		{
			// TODO DarkIronSkulker_BRM_008 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Dark Iron Skulker"));
		}
	}


	public class ShamanBrmTest
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
		[Fact]
		public void LavaShock_BRM_011()
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
			game.Player1.BaseMana = 5;
			game.Player2.BaseMana = 5;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lava Shock"));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ancestral Knowledge"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(4, game.CurrentPlayer.RemainingMana);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, game.CurrentOpponent.Hero));
			Assert.Equal(4, game.CurrentPlayer.RemainingMana);
			Assert.Equal(28, game.CurrentOpponent.Hero.Health);
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
		[Fact]
		public void FireguardDestroyer_BRM_012()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireguard Destroyer"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.True(((Minion)testCard).AttackDamage >= 4);
			Assert.True(((Minion)testCard).AttackDamage < 8);
		}
	}


	public class WarlockBrmTest
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
		[Fact(Skip = "ignore")]
		public void Demonwrath_BRM_005()
		{
			// TODO Demonwrath_BRM_005 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Demonwrath"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [BRM_006] Imp Gang Boss - COST:3 [ATK:2/HP:4] 
		// - Race: demon, Set: fp2, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever this minion takes damage, summon a 1/1 Imp.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ImpGangBoss_BRM_006()
		{
			// TODO ImpGangBoss_BRM_006 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Imp Gang Boss"));
		}
	}


	public class WarriorBrmTest
	{
		// ---------------------------------------- SPELL - WARRIOR
		// [BRM_015] Revenge - COST:2 
		// - Set: fp2, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $1 damage to all minions. If you have 12 or less Health, deal $3 damage instead. *spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Revenge_BRM_015()
		{
			// TODO Revenge_BRM_015 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Revenge"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [BRM_016] Axe Flinger - COST:4 [ATK:2/HP:5] 
		// - Set: fp2, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever this minion takes damage, deal 2 damage to the enemy hero.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AxeFlinger_BRM_016()
		{
			// TODO AxeFlinger_BRM_016 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Axe Flinger"));
		}
	}


	public class NeutralBrmTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [BRM_019] Grim Patron - COST:5 [ATK:3/HP:3] 
		// - Set: fp2, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever this minion survives damage, summon another Grim Patron.
		// --------------------------------------------------------
		[Fact]
		public void GrimPatron_BRM_019()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grim Patron")
				},
				Player2HeroClass = CardClass.MAGE,
				Player2Deck = new List<Card>()
				{
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Reckless Rocketeer"),
				},
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Grim Patron"));
			Minion grim = game.CurrentPlayer.BoardZone[0];
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Stonetusk Boar"));
			IPlayable boar = game.CurrentPlayer.BoardZone[0] as Minion;
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Reckless Rocketeer"));
			IPlayable rocke = game.CurrentPlayer.BoardZone[1] as Minion;
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, boar, grim));
			Assert.Equal(2, game.CurrentOpponent.BoardZone.Count);
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, rocke, grim));
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BRM_020] Dragonkin Sorcerer - COST:4 [ATK:3/HP:5] 
		// - Race: dragon, Set: fp2, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever <b>you</b> target this minion with a spell, gain +1/+1.
		// --------------------------------------------------------
		[Fact]
		public void DragonkinSorcerer_BRM_020()
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
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragonkin Sorcerer"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Power Word: Shield"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, testCard));
			//Assert.Equal(1, game.CurrentPlayer.HandZone.Triggers.Count);
			Assert.Equal(4, ((Minion)testCard).AttackDamage);
			Assert.Equal(8, ((Minion)testCard).Health);

			Minion target = game.ProcessCard<Minion>("Stonetusk Boar");
			game.ProcessCard("Power Word: Shield", target);
			Assert.Equal(4, ((Minion)testCard).AttackDamage);
			Assert.Equal(8, ((Minion)testCard).Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BRM_022] Dragon Egg - COST:1 [ATK:0/HP:2] 
		// - Set: fp2, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever this minion takes damage, summon a 2/1 Whelp.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DragonEgg_BRM_022()
		{
			// TODO DragonEgg_BRM_022 test
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
		[Fact(Skip = "ignore")]
		public void DrakonidCrusher_BRM_024()
		{
			// TODO DrakonidCrusher_BRM_024 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Drakonid Crusher"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [BRM_025] Volcanic Drake - COST:6 [ATK:6/HP:4] 
		// - Race: dragon, Set: fp2, Rarity: common
		// --------------------------------------------------------
		// Text: Costs (1) less for each minion that died this turn.
		// --------------------------------------------------------
		[Fact]
		public void VolcanicDrake_BRM_025()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Volcanic Drake"));
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(6, testCard.Cost);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion));
			Assert.Equal(5, testCard.Cost);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(6, testCard.Cost);
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
		[Fact]
		public void HungryDragon_BRM_026()
		{
			// TODO HungryDragon_BRM_026 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Hungry Dragon"));

			game.ProcessCard("Hungry Dragon");

			Assert.Single(game.CurrentOpponent.BoardZone);
			Assert.Equal(1, game.CurrentOpponent.BoardZone[0].Cost);
			Assert.Equal(game.CurrentOpponent, game.CurrentOpponent.BoardZone[0].Controller);
			Assert.Equal(game.CurrentOpponent.PlayerId, game.CurrentOpponent.BoardZone[0][GameTag.CONTROLLER]);
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
		[Fact]
		public void MajordomoExecutus_BRM_027()
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
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Majordomo Executus"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadow Word: Death"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, testCard));
			Assert.Equal(8, game.CurrentOpponent.Hero.Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			Assert.Equal(22, game.CurrentOpponent.Hero.Health);
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
		[Fact]
		public void EmperorThaurissan_BRM_028()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Emperor Thaurissan"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			int totCost = game.CurrentPlayer.HandZone.Sum(p => p.Cost);
			int neg =
				(game.CurrentPlayer.HandZone[0].Cost == 0 ? 0 : 1) +
				(game.CurrentPlayer.HandZone[1].Cost == 0 ? 0 : 1) +
				(game.CurrentPlayer.HandZone[2].Cost == 0 ? 0 : 1) +
				(game.CurrentPlayer.HandZone[3].Cost == 0 ? 0 : 1);
			
			Assert.Equal(4, game.CurrentPlayer.HandZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(totCost - neg, game.CurrentOpponent.HandZone.Sum(p => p.Cost));
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
		[Fact(Skip = "ignore")]
		public void RendBlackhand_BRM_029()
		{
			// TODO RendBlackhand_BRM_029 test
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
		[Fact]
		public void Nefarian_BRM_030()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nefarian"));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(CardClass.DRUID, game.CurrentPlayer.HandZone[5].Card.Class);
			Assert.Equal(CardClass.DRUID, game.CurrentPlayer.HandZone[4].Card.Class);
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
		[Fact]
		public void Chromaggus_BRM_031()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chromaggus"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Novice Engineer"));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(game.CurrentPlayer.HandZone[4].Card.Id, game.CurrentPlayer.HandZone[5].Card.Id);
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
		[Fact]
		public void BlackwingTechnician_BRM_033()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Azure Drake")
				},
				Player2HeroClass = CardClass.PRIEST,
				Player2Deck = new List<Card>(),
				FillDecks = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blackwing Technician"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blackwing Technician"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
			Assert.Equal(3, ((Minion)testCard1).AttackDamage);
			Assert.Equal(5, ((Minion)testCard1).Health);
			Assert.Equal(2, ((Minion)testCard2).AttackDamage);
			Assert.Equal(4, ((Minion)testCard2).Health);
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
		[Fact]
		public void BlackwingCorruptor_BRM_034()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Azure Drake"),
					Cards.FromName("Blackwing Corruptor"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Bloodfen Raptor"),
					Cards.FromName("Bloodfen Raptor")
				},
				Player2HeroClass = CardClass.PRIEST,
				Player2Deck = new List<Card>()
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
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, "Blackwing Corruptor", game.CurrentOpponent.Hero));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Blackwing Corruptor"));
			Assert.Equal(1, game.Player1.BoardZone.Count);
			Assert.Equal(1, game.Player2.BoardZone.Count);
			Assert.Equal(30, game.Player1.Hero.Health);
			Assert.Equal(27, game.Player2.Hero.Health);
		}
	}
}
