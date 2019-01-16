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
using SabberStoneCore.Tasks;
using SabberStoneCore.Model.Zones;
using Generic = SabberStoneCore.Actions.Generic;

namespace SabberStoneCoreTest.CardSets
{

	public class HeroPowersOgTest
	{
		// ----------------------------------- HERO_POWER - PALADIN
		// [OG_006b] The Tidal Hand (*) - COST:2 
		// - Set: og, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Summon a 1/1 Silver Hand Murloc.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheTidalHand_OG_006b()
		{
			// TODO TheTidalHand_OG_006b test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("The Tidal Hand"));
		}
	}


	public class DruidOgTest
	{
		// ------------------------------------------ SPELL - DRUID
		// [OG_047] Feral Rage - COST:3 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Choose One -</b> Give your hero +4 Attack this turn; or Gain 8 Armor.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		[Fact]
		public void FeralRage_OG_047()
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
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Feral Rage"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard1, 1));
			Assert.Equal(4, game.CurrentPlayer.Hero.AttackDamage);
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Feral Rage"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard2, 2));
			Assert.Equal(8, game.CurrentPlayer.Hero.Armor);
		}

		// ------------------------------------------ SPELL - DRUID
		// [OG_048] Mark of Y'Shaarj - COST:2 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: Give a minion +2/+2.
		//       If it's a Beast, draw
		//       a card.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void MarkOfYshaarj_OG_048()
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
			var minion1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			var minion2 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Raider"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			Assert.Equal(3, ((Minion)minion1).AttackDamage);
			Assert.Equal(2, ((Minion)minion1).Health);
			Assert.Equal(2, ((Minion)minion2).AttackDamage);
			Assert.Equal(1, ((Minion)minion2).Health);
			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mark of Y'Shaarj"));
			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mark of Y'Shaarj"));
			Assert.Equal(1, game.CurrentPlayer.NumCardsDrawnThisTurn);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, minion2));
			Assert.Equal(4, ((Minion)minion2).AttackDamage);
			Assert.Equal(3, ((Minion)minion2).Health);
			Assert.Equal(1, game.CurrentPlayer.NumCardsDrawnThisTurn);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, minion1));
			Assert.Equal(5, ((Minion)minion1).AttackDamage);
			Assert.Equal(4, ((Minion)minion1).Health);
			Assert.Equal(2, game.CurrentPlayer.NumCardsDrawnThisTurn);
		}

		// ------------------------------------------ SPELL - DRUID
		// [OG_195] Wisps of the Old Gods - COST:7 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Choose One -</b> Summon seven 1/1 Wisps; or Give your minions +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		[Fact]
		public void WispsOfTheOldGods_OG_195()
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
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wisps of the Old Gods"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard1, 1));
			Assert.Equal(7, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(1, game.CurrentPlayer.BoardZone[0].AttackDamage);
			Assert.Equal(1, game.CurrentPlayer.BoardZone[0].Health);
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wisps of the Old Gods"));
			game.CurrentPlayer.UsedMana = 0;
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard2, 2));
			Assert.Equal(3, game.CurrentPlayer.BoardZone[0].AttackDamage);
			Assert.Equal(3, game.CurrentPlayer.BoardZone[0].Health);
		}

		// ----------------------------------------- MINION - DRUID
		// [OG_044] Fandral Staghelm - COST:4 [ATK:3/HP:5] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: Your <b>Choose One</b> cards have both effects combined.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - AURA = 1
		// --------------------------------------------------------
		[Fact]
		public void FandralStaghelm_OG_044()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fandral Staghelm"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.True(game.CurrentPlayer.ChooseBoth);
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Druid of the Claw"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, minion1));
			Assert.Equal("OG_044a", game.CurrentPlayer.BoardZone[1].Card.Id);
			game.Player1.UsedMana = 0;
			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wrath"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, game.CurrentPlayer.BoardZone[1]));
			Assert.Equal(2, game.CurrentPlayer.BoardZone[1].Health);
		}

		// ----------------------------------------- MINION - DRUID
		// [OG_051] Forbidden Ancient - COST:1 [ATK:1/HP:1] 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Spend all your Mana. Gain +1/+1 for each mana spent.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void ForbiddenAncient_OG_051()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Forbidden Ancient"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(10, ((Minion)testCard).AttackDamage);
			Assert.Equal(10, ((Minion)testCard).Health);
		}

		// ----------------------------------------- MINION - DRUID
		// [OG_188] Klaxxi Amber-Weaver - COST:4 [ATK:4/HP:5] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your C'Thun has at least 10 Attack, gain +5 Health.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - RITUAL = 1
		// --------------------------------------------------------
		[Fact]
		public void KlaxxiAmberWeaver_OG_188()
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
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Klaxxi Amber-Weaver"));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Klaxxi Amber-Weaver"));
			IPlayable buffer1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dark Arakkoa"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, buffer1));
			IPlayable proxyCthun1 = game.IdEntityDic[buffer1.Controller.ProxyCthun];
			Assert.Equal(9, ((Minion)proxyCthun1).Health);
			Assert.Equal(9, ((Minion)proxyCthun1).AttackDamage);
			game.CurrentPlayer.UsedMana = 0;
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
			Assert.Equal(5, ((Minion)testCard1).Health);
			game.CurrentPlayer.UsedMana = 0;
			IPlayable buffer2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dark Arakkoa"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, buffer2));
			IPlayable proxyCthun2 = game.IdEntityDic[buffer2.Controller.ProxyCthun];
			Assert.Equal(12, ((Minion)proxyCthun2).Health);
			Assert.Equal(12, ((Minion)proxyCthun2).AttackDamage);
			game.CurrentPlayer.UsedMana = 0;
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
			Assert.Equal(10, ((Minion)testCard2).Health);
		}

		// ----------------------------------------- MINION - DRUID
		// [OG_202] Mire Keeper - COST:4 [ATK:3/HP:3] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Choose One -</b> Summon a
		//       2/2 Slime; or Gain an
		//       empty Mana Crystal.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MireKeeper_OG_202()
		{
			// TODO MireKeeper_OG_202 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Mire Keeper"));
		}

		// ----------------------------------------- MINION - DRUID
		// [OG_293] Dark Arakkoa - COST:6 [ATK:5/HP:7] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       <b>Battlecry:</b> Give your C'Thun
		//       +3/+3 <i>(wherever it is).</i>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// - RITUAL = 1
		// --------------------------------------------------------
		[Fact]
		public void DarkArakkoa_OG_293()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dark Arakkoa"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			IPlayable proxyCthun = game.IdEntityDic[testCard.Controller.ProxyCthun];
			Assert.Equal(9, ((Minion)proxyCthun).Health);
			Assert.Equal(9, ((Minion)proxyCthun).AttackDamage);
		}

		// ----------------------------------------- MINION - DRUID
		// [OG_313] Addled Grizzly - COST:3 [ATK:2/HP:2] 
		// - Race: beast, Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: After you summon a minion, give it +1/+1.
		// --------------------------------------------------------
		[Fact]
		public void AddledGrizzly_OG_313()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Addled Grizzly"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			Assert.Equal(1, ((Minion)minion).AttackDamage);
			Assert.Equal(1, ((Minion)minion).Health);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(2, ((Minion)minion).AttackDamage);
			Assert.Equal(2, ((Minion)minion).Health);
		}
	}


	public class HunterOgTest
	{
		// ----------------------------------------- SPELL - HUNTER
		// [OG_045] Infest - COST:3 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: Give your minions "<b>Deathrattle:</b> Add a random Beast to your hand."
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void Infest_OG_045()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Infest"));
			var minion1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(4, game.CurrentOpponent.HandZone.Count);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));
			Assert.Equal(5, game.CurrentOpponent.HandZone.Count);
			Assert.Equal(Race.BEAST, game.CurrentOpponent.HandZone[4].Card.Race);
		}

		// ----------------------------------------- SPELL - HUNTER
		// [OG_061] On the Hunt - COST:1 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $1 damage.
		//       Summon a 1/1 Mastiff. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void OnTheHunt_OG_061()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("On the Hunt"));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard, game.CurrentOpponent.Hero));
			Assert.Equal(29, game.CurrentOpponent.Hero.Health);
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
		}

		// ----------------------------------------- SPELL - HUNTER
		// [OG_211] Call of the Wild - COST:9 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: Summon all three Animal Companions.
		// --------------------------------------------------------
		[Fact]
		public void CallOfTheWild_OG_211()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Call of the Wild"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal("Huffer", game.CurrentPlayer.BoardZone[0].Card.Name);
			Assert.Equal("Leokk", game.CurrentPlayer.BoardZone[1].Card.Name);
			Assert.Equal("Misha", game.CurrentPlayer.BoardZone[2].Card.Name);
		}

		// ---------------------------------------- MINION - HUNTER
		// [OG_179] Fiery Bat - COST:1 [ATK:2/HP:1] 
		// - Race: beast, Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Deal 1 damage to a random enemy.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void FieryBat_OG_179()
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
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fiery Bat"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, testCard));
			Assert.Equal(29, game.CurrentPlayer.Hero.Health);
		}

		// ---------------------------------------- MINION - HUNTER
		// [OG_216] Infested Wolf - COST:4 [ATK:3/HP:3] 
		// - Race: beast, Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon two 1/1 Spiders.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void InfestedWolf_OG_216()
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
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Infested Wolf"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostbolt"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, testCard));
			Assert.Equal(2, game.CurrentOpponent.BoardZone.Count);
		}

		// ---------------------------------------- MINION - HUNTER
		// [OG_292] Forlorn Stalker - COST:3 [ATK:4/HP:2] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give all <b>Deathrattle</b> minions in your hand +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void ForlornStalker_OG_292()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Forlorn Stalker"));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Infested Wolf"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			Assert.Equal(3, ((Minion)minion1).AttackDamage);
			Assert.Equal(3, ((Minion)minion1).Health);
			Assert.Equal(1, ((Minion)minion2).AttackDamage);
			Assert.Equal(1, ((Minion)minion2).Health);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(4, ((Minion)minion1).AttackDamage);
			Assert.Equal(4, ((Minion)minion1).Health);
			Assert.Equal(1, ((Minion)minion2).AttackDamage);
			Assert.Equal(1, ((Minion)minion2).Health);
		}

		// ---------------------------------------- MINION - HUNTER
		// [OG_308] Giant Sand Worm - COST:8 [ATK:8/HP:8] 
		// - Race: beast, Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: Whenever this attacks and kills a minion, it may attack again.
		// --------------------------------------------------------
		[Fact]
		public void GiantSandWorm_OG_308()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Giant Sand Worm"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			var minion1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			var minion2 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			var minion3 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			var minion4 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion4));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, testCard, minion1));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, testCard, minion2));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, testCard, minion3));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, testCard, minion4));
			Assert.Equal(0, game.CurrentOpponent.BoardZone.Count);
		}

		// ---------------------------------------- MINION - HUNTER
		// [OG_309] Princess Huhuran - COST:5 [ATK:6/HP:5] 
		// - Race: beast, Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Trigger a friendly minion's <b>Deathrattle</b> effect.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_WITH_DEATHRATTLE = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void PrincessHuhuran_OG_309()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Princess Huhuran"));
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard, minion));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
		}
	}


	public class MageOgTest
	{
		// ------------------------------------------- SPELL - MAGE
		// [OG_081] Shatter - COST:2 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: Destroy a <b>Frozen</b> minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_FROZEN_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact]
		public void Shatter_OG_081()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shatter"));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostbolt"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Boulderfist Ogre"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, minion));
			Assert.Equal(7, ((Minion)minion).Health);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, minion));
			Assert.Equal(4, ((Minion)minion).Health);
			Assert.True(((Minion)minion).IsFrozen);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, minion));
			Assert.True(((Minion)minion).IsDead);
		}

		// ------------------------------------------- SPELL - MAGE
		// [OG_086] Forbidden Flame - COST:0 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: Spend all your Mana. Deal that much damage to a minion. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - AFFECTED_BY_SPELL_POWER = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void ForbiddenFlame_OG_086()
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
			game.Player2.BaseMana = 3;
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Boulderfist Ogre"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Forbidden Flame"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard1, minion));
			Assert.Equal(3, ((Minion)minion).Health);
			Assert.Equal(0, game.CurrentPlayer.RemainingMana);
		}

		// ------------------------------------------- SPELL - MAGE
		// [OG_090] Cabalist's Tome - COST:5 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: Add 3 random Mage spells to your hand.
		// --------------------------------------------------------
		[Fact]
		public void CabalistsTome_OG_090()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cabalist's Tome"));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(7, game.CurrentPlayer.HandZone.Count);
		}

		// ------------------------------------------ MINION - MAGE
		// [OG_083] Twilight Flamecaller - COST:3 [ATK:2/HP:2] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 1 damage to all enemy minions.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TwilightFlamecaller_OG_083()
		{
			// TODO TwilightFlamecaller_OG_083 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Twilight Flamecaller"));
		}

		// ------------------------------------------ MINION - MAGE
		// [OG_085] Demented Frostcaller - COST:4 [ATK:2/HP:4] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: After you cast a spell, <b>Freeze</b> a random enemy.
		// --------------------------------------------------------
		// RefTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact]
		public void DementedFrostcaller_OG_085()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Demented Frostcaller"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			Assert.False(((Minion)minion2).IsFrozen || game.CurrentOpponent.Hero.IsFrozen);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, game.CurrentOpponent.Hero));
			Assert.True(((Minion)minion2).IsFrozen || game.CurrentOpponent.Hero.IsFrozen);
		}

		// ------------------------------------------ MINION - MAGE
		// [OG_087] Servant of Yogg-Saron - COST:5 [ATK:5/HP:4] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Cast a random spell that costs (5) or less <i>(targets chosen randomly)</i>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ServantOfYoggSaron_OG_087()
		{
			// TODO ServantOfYoggSaron_OG_087 test
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
			//IPlayable testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Servant of Yogg-Saron"));
		}

		// ------------------------------------------ MINION - MAGE
		// [OG_120] Anomalus - COST:8 [ATK:8/HP:6] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Deal 8 damage to all minions.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void Anomalus_OG_120()
		{
			// TODO Anomalus_OG_120 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Anomalus"));

			game.ProcessCard("Boulderfist Ogre");
			game.ProcessCard("Wisp");
			game.ProcessCard("Wisp");
			game.ProcessCard("Wisp");
			game.ProcessCard("Wisp");
			game.EndTurn();

			game.ProcessCard("Anomalus");
			game.EndTurn();

			Game clone = game.Clone();

			game.Process(MinionAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.BoardZone[0],
				game.CurrentOpponent.BoardZone[0]));
			Assert.Empty(game.Minions);

			clone.Process(MinionAttackTask.Any(clone.CurrentPlayer, clone.CurrentPlayer.BoardZone[0],
				clone.CurrentOpponent.BoardZone[0]));

			Assert.Empty(clone.Minions);
		}

		// ------------------------------------------ MINION - MAGE
		// [OG_207] Faceless Summoner - COST:6 [ATK:5/HP:5] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a random 3-Cost minion.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void FacelessSummoner_OG_207()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Faceless Summoner"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(3, game.CurrentPlayer.BoardZone[1].Card.Cost);
		}

		// ------------------------------------------ MINION - MAGE
		// [OG_303] Cult Sorcerer - COST:2 [ATK:3/HP:2] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b><b>Spell Damage</b> +1</b>
		//       After you cast a spell,
		//       give your C'Thun +1/+1
		//       <i>(wherever it is).</i>
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 1
		// - RITUAL = 1
		// --------------------------------------------------------
		[Fact]
		public void CultSorcerer_OG_303()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cult Sorcerer"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, game.CurrentPlayer.Hero));
			Assert.Equal(23, game.CurrentPlayer.Hero.Health);
			Assert.Equal(7, ((Minion)game.CurrentPlayer.SetasideZone[0]).Health);
			Assert.Equal(7, ((Minion)game.CurrentPlayer.SetasideZone[0]).AttackDamage);
		}
	}


	public class PaladinOgTest
	{
		// ---------------------------------------- SPELL - PALADIN
		// [OG_198] Forbidden Healing - COST:0 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: Spend all your Mana. Restore twice that much Health.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void ForbiddenHealing_OG_198()
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
			game.CurrentPlayer.Hero.Damage = 20;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Forbidden Healing"));
			Assert.Equal(10, game.CurrentPlayer.Hero.Health);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, game.CurrentPlayer.Hero));
			Assert.Equal(30, game.CurrentPlayer.Hero.Health);
		}

		// ---------------------------------------- SPELL - PALADIN
		// [OG_223] Divine Strength - COST:1 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: Give a minion +1/+2.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DivineStrength_OG_223()
		{
			// TODO DivineStrength_OG_223 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Divine Strength"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [OG_273] Stand Against Darkness - COST:5 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: Summon five 1/1 Silver Hand Recruits.
		// --------------------------------------------------------
		[Fact]
		public void StandAgainstDarkness_OG_273()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stand Against Darkness"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(5, game.CurrentPlayer.BoardZone.Count);
		}

		// ---------------------------------------- SPELL - PALADIN
		// [OG_311] A Light in the Darkness - COST:2 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Discover</b> a minion.
		//       Give it +1/+1.
		// --------------------------------------------------------
		// RefTag:
		// - TREASURE = 1
		// --------------------------------------------------------
		[Fact]
		public void ALightInTheDarkness_OG_311()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("A Light in the Darkness"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			IPlayable minion = game.IdEntityDic[game.CurrentPlayer.Choice.Choices[0]];
			game.Process(ChooseTask.Pick(game.CurrentPlayer, game.CurrentPlayer.Choice.Choices[0]));
			Assert.Equal(minion, game.CurrentPlayer.HandZone[4]);
			Assert.Equal(game.CurrentPlayer.HandZone[4].Card[GameTag.ATK] + 1, ((Minion)minion).AttackDamage);
		}

		// --------------------------------------- MINION - PALADIN
		// [OG_006] Vilefin Inquisitor - COST:1 [ATK:1/HP:3] 
		// - Race: murloc, Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Your Hero Power becomes 'Summon a   1/1 Murloc.'
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void VilefinInquisitor_OG_006()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vilefin Inquisitor"));
			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			Assert.Equal("CS2_101t", game.CurrentPlayer.BoardZone.Last().Card.Id);
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			Assert.Equal("OG_006a", game.CurrentPlayer.BoardZone.Last().Card.Id);
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
		}

		// --------------------------------------- MINION - PALADIN
		// [OG_221] Selfless Hero - COST:1 [ATK:2/HP:1] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Give a random friendly minion <b>Divine Shield</b>.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		// RefTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact]
		public void SelflessHero_OG_221()
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
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Selfless Hero"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, testCard));
			Assert.True(((Minion)minion).HasDivineShield);
		}

		// --------------------------------------- MINION - PALADIN
		// [OG_229] Ragnaros, Lightlord - COST:8 [ATK:8/HP:8] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: At the end of your turn, restore 8 Health to a damaged friendly character.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact]
		public void RagnarosLightlord_OG_229()
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
			game.Player1.Hero.Damage = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ragnaros, Lightlord"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(28, game.CurrentOpponent.Hero.Health);
		}

		// --------------------------------------- MINION - PALADIN
		// [OG_310] Steward of Darkshire - COST:3 [ATK:3/HP:3] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you summon a 1-Health minion, give it <b>Divine Shield</b>.
		// --------------------------------------------------------
		// RefTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact]
		public void StewardOfDarkshire_OG_310()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Steward of Darkshire"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Novice Engineer"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			Assert.True(((Minion)minion1).HasDivineShield);
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Acidic Swamp Ooze"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			Assert.False(((Minion)minion2).HasDivineShield);
		}

		// --------------------------------------- WEAPON - PALADIN
		// [OG_222] Rallying Blade - COST:3 [ATK:3/HP:0] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give +1/+1 to your minions with <b>Divine Shield</b>.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact]
		public void RallyingBlade_OG_222()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rallying Blade"));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Argent Squire"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Raider"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(2, ((Minion)minion1).AttackDamage);
			Assert.Equal(2, ((Minion)minion1).Health);
			Assert.Equal(2, ((Minion)minion2).AttackDamage);
			Assert.Equal(1, ((Minion)minion2).Health);
		}
	}


	public class PriestOgTest
	{
		// ----------------------------------------- SPELL - PRIEST
		// [OG_094] Power Word: Tentacles - COST:5 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: Give a minion +2/+6.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PowerWordTentacles_OG_094()
		{
			// TODO PowerWordTentacles_OG_094 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Power Word: Tentacles"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [OG_100] Shadow Word: Horror - COST:4 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: Destroy all minions with 2 or less Attack.
		// --------------------------------------------------------
		[Fact]
		public void ShadowWordHorror_OG_100()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadow Word: Horror"));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Goldshire Footman"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion4 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Goldshire Footman"));
			IPlayable minion5 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable minion6 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion4));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion5));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion6));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(6, game.Minions.Count);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(2, game.Minions.Count);
		}

		// ----------------------------------------- SPELL - PRIEST
		// [OG_101] Forbidden Shaping - COST:0 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: Spend all your Mana. Summon a random minion that costs that much.
		// --------------------------------------------------------
		[Fact]
		public void ForbiddenShaping_OG_101()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Forbidden Shaping"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(10, game.CurrentPlayer.BoardZone[0].Cost);
		}

		// ----------------------------------------- SPELL - PRIEST
		// [OG_104] Embrace the Shadow - COST:2 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: This turn, your healing effects deal damage instead.
		// --------------------------------------------------------
		[Fact]
		public void EmbraceTheShadow_OG_104()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Embrace the Shadow"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(28, game.CurrentOpponent.Hero.Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(30, game.CurrentOpponent.Hero.Health);
		}

		// ---------------------------------------- MINION - PRIEST
		// [OG_096] Twilight Darkmender - COST:5 [ATK:6/HP:5] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your C'Thun  has at least 10 Attack, restore 10 Health to your hero.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - RITUAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TwilightDarkmender_OG_096()
		{
			// TODO TwilightDarkmender_OG_096 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Twilight Darkmender"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [OG_234] Darkshire Alchemist - COST:5 [ATK:4/HP:5] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Restore 5 Health.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NONSELF_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DarkshireAlchemist_OG_234()
		{
			// TODO DarkshireAlchemist_OG_234 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Darkshire Alchemist"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [OG_316] Herald Volazj - COST:6 [ATK:5/HP:5] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 1/1 copy of each of your other minions.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void HeraldVolazj_OG_316()
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

			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Herald Volazj"));
			Minion minion1 = game.ProcessCard<Minion>("Bloodfen Raptor", null, true);
			Minion minion2 = game.ProcessCard<Minion>("Soggoth the Slitherer", null, true);
			game.ProcessCard("Herald Volazj");

			Assert.Equal(5, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(game.CurrentPlayer.BoardZone[0].Card.Id, game.CurrentPlayer.BoardZone[3].Card.Id);
			Assert.Equal(1, game.CurrentPlayer.BoardZone[3].AttackDamage);
			Assert.Equal(1, game.CurrentPlayer.BoardZone[3].Health);
			Assert.Equal(game.CurrentPlayer.BoardZone[1].Card.Id, game.CurrentPlayer.BoardZone[4].Card.Id);
			Assert.Equal(1, game.CurrentPlayer.BoardZone[4].AttackDamage);
			Assert.Equal(1, game.CurrentPlayer.BoardZone[4].Health);
		}

		// ---------------------------------------- MINION - PRIEST
		// [OG_334] Hooded Acolyte - COST:4 [ATK:3/HP:6] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever a character is healed, give your
		//       C'Thun +1/+1 <i>(wherever it is).</i>
		// --------------------------------------------------------
		// GameTag:
		// - RITUAL = 1
		// --------------------------------------------------------
		[Fact]
		public void HoodedAcolyte_OG_334()
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
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hooded Acolyte"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, testCard));
			Assert.Equal(7, ((Minion)game.CurrentPlayer.SetasideZone[0]).AttackDamage);
			Assert.Equal(7, ((Minion)game.CurrentPlayer.SetasideZone[0]).Health);
		}

		// ---------------------------------------- MINION - PRIEST
		// [OG_335] Shifting Shade - COST:4 [ATK:4/HP:3] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Copy a card from your opponent's deck and add it to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShiftingShade_OG_335()
		{
			// TODO ShiftingShade_OG_335 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Shifting Shade"));
		}
	}


	public class RogueOgTest
	{
		// ------------------------------------------ SPELL - ROGUE
		// [OG_072] Journey Below - COST:1 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Discover</b> a <b>Deathrattle</b> card.
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// - TREASURE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JourneyBelow_OG_072()
		{
			// TODO JourneyBelow_OG_072 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Journey Below"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [OG_073] Thistle Tea - COST:6 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: Draw a card. Add 2 extra copies of it to your hand.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void ThistleTea_OG_073()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Thistle Tea"));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(7, game.CurrentPlayer.HandZone.Count);
		}

		// ------------------------------------------ SPELL - ROGUE
		// [OG_176] Shadow Strike - COST:3 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $5 damage to an undamaged character. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_UNDAMAGED_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShadowStrike_OG_176()
		{
			// TODO ShadowStrike_OG_176 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Shadow Strike"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [OG_070] Bladed Cultist - COST:1 [ATK:1/HP:2] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Combo:</b> Gain +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BladedCultist_OG_070()
		{
			// TODO BladedCultist_OG_070 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bladed Cultist"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [OG_080] Xaril, Poisoned Mind - COST:4 [ATK:3/HP:2] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry and Deathrattle:</b> Add a random Toxin card to your hand.
		// --------------------------------------------------------
		// Entourage: OG_080d, OG_080e, OG_080f, OG_080c, OG_080b
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void XarilPoisonedMind_OG_080()
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
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Xaril, Poisoned Mind"));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Assassinate"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, testCard));
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			IPlayable testSpell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromId("OG_080e"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testSpell1, minion));
			Assert.True(((Minion)minion).HasStealth);
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion, game.CurrentOpponent.Hero));
			Assert.False(((Minion)minion).HasStealth);
		}

		// ----------------------------------------- MINION - ROGUE
		// [OG_267] Southsea Squidface - COST:4 [ATK:4/HP:4] 
		// - Race: pirate, Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Give your weapon +2 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SouthseaSquidface_OG_267()
		{
			// TODO SouthseaSquidface_OG_267 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Southsea Squidface"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [OG_282] Blade of C'Thun - COST:9 [ATK:4/HP:4] 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy a minion. Add its Attack and Health to_your C'Thun's <i>(wherever it is).</i>
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - RITUAL = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact]
		public void BladeOfCthun_OG_282()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blade of C'Thun"));
			var minion = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Injured Blademaster"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(4, minion.AttackDamage);
			Assert.Equal(3, minion.Health);
			game.CurrentPlayer.UsedMana = 0;
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard, minion));

			IPlayable proxyCthun = game.IdEntityDic[testCard.Controller.ProxyCthun];
			Assert.Equal(9, ((Minion)proxyCthun).Health);
			Assert.Equal(10, ((Minion)proxyCthun).AttackDamage);
		}

		// ----------------------------------------- MINION - ROGUE
		// [OG_291] Shadowcaster - COST:5 [ATK:4/HP:4] 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Choose a friendly minion. Add a 1/1 copy to_your hand that costs_(1).
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
		public void Shadowcaster_OG_291()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadowcaster"));
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chillwind Yeti"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, minion));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(minion.Card.Id, game.CurrentPlayer.HandZone[4].Card.Id);
			Assert.Equal(1, game.CurrentPlayer.HandZone[4].Cost);
		}

		// ----------------------------------------- MINION - ROGUE
		// [OG_330] Undercity Huckster - COST:2 [ATK:2/HP:2] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Add a random class card to your hand <i>(from your opponent's class)</i>.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void UndercityHuckster_OG_330()
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
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Undercity Huckster"));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			Assert.Equal(4, game.CurrentOpponent.HandZone.Count);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, testCard));
			Assert.Equal(CardClass.MAGE, game.CurrentOpponent.HandZone[4].Card.Class);
		}
	}


	public class ShamanOgTest
	{
		// ----------------------------------------- SPELL - SHAMAN
		// [OG_023] Primal Fusion - COST:1 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: Give a minion +1/+1 for each of your Totems.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void PrimalFusion_OG_023()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Primal Fusion"));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, minion));
			Assert.Equal(2, ((Minion)minion).AttackDamage);
			Assert.Equal(2, ((Minion)minion).Health);
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [OG_027] Evolve - COST:1 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: Transform your minions into random minions that cost (1) more.
		// --------------------------------------------------------
		[Fact]
		public void Evolve_OG_027()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Evolve"));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Sum(p => p.Card.Cost));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(6, game.CurrentPlayer.BoardZone.Sum(p => p.Card.Cost));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [OG_206] Stormcrack - COST:2 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $4 damage to a minion. <b>Overload:</b> (1) *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 1
		// - OVERLOAD_OWED = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Stormcrack_OG_206()
		{
			// TODO Stormcrack_OG_206 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stormcrack"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [OG_024] Flamewreathed Faceless - COST:4 [ATK:7/HP:7] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Overload:</b> (2)
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 2
		// - OVERLOAD_OWED = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FlamewreathedFaceless_OG_024()
		{
			// TODO FlamewreathedFaceless_OG_024 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Flamewreathed Faceless"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [OG_026] Eternal Sentinel - COST:2 [ATK:3/HP:2] 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Unlock your <b>Overloaded</b> Mana Crystals.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - OVERLOAD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EternalSentinel_OG_026()
		{
			// TODO EternalSentinel_OG_026 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Eternal Sentinel"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [OG_028] Thing from Below - COST:6 [ATK:5/HP:5] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       Costs (1) less for each
		//       Totem you've summoned
		//       this game.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact]
		public void ThingFromBelow_OG_028()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Thing from Below"));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Totem Golem"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Totem Golem"));
			Assert.Equal(6, testCard.Cost);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			Assert.Equal(5, testCard.Cost);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			Assert.Equal(4, testCard.Cost);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			Assert.Equal(3, testCard.Cost);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(6, testCard.Cost);
		}

		// ---------------------------------------- MINION - SHAMAN
		// [OG_209] Hallazeal the Ascended - COST:5 [ATK:4/HP:6] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever your spells deal damage, restore that much Health to your hero.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact]
		public void HallazealTheAscended_OG_209()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Lightning Bolt"),
					Cards.FromName("Flamestrike")
				},
				Player2HeroClass = CardClass.SHAMAN,
				Player2Deck = new List<Card>
				{
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp")
				},
				FillDecks = true,
				Shuffle = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hallazeal the Ascended"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
			game.CurrentPlayer.Hero.Damage = 20;
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lightning Bolt", game.CurrentOpponent.Hero));
			Assert.Equal(17, game.CurrentPlayer.Hero.Damage);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wisp"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wisp"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wisp"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Flamestrike"));
			Assert.Equal(5, game.CurrentPlayer.Hero.Damage);

			// TODO: Hallazeal - Kalimos interaction
			//game.CurrentPlayer.NumElementalsPlayedLastTurn++;
			//game.ProcessCard("Kalimos, Primal Lord", null, true);
			//Assert.NotNull(game.CurrentPlayer.Choice);
			//game.ChooseNthChoice(3);
			//Assert.Equal(5, game.CurrentPlayer.Hero.Damage);

			// check infinite-loop error
			game.ProcessCard("Embrace the Shadow", null, true);
			game.ProcessCard("Drain Soul", testCard, true);
		}

		// ---------------------------------------- MINION - SHAMAN
		// [OG_328] Master of Evolution - COST:4 [ATK:4/HP:5] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Transform a friendly minion into a random one that costs (1) more.
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
		public void MasterOfEvolution_OG_328()
		{
			// TODO MasterOfEvolution_OG_328 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Master of Evolution"));
		}

		// ---------------------------------------- WEAPON - SHAMAN
		// [OG_031] Hammer of Twilight - COST:5 [ATK:4/HP:0] 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a 4/2 Elemental.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void HammerOfTwilight_OG_031()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hammer of Twilight"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Acidic Swamp Ooze"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, minion));
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
			//game.Process(EndTurnTask.Any(game.CurrentPlayer));

			//game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			//Assert.Equal(22, game.CurrentOpponent.Hero.Health);
			//Assert.Equal(1, game.CurrentPlayer.Board.Count);
		}
	}


	public class WarlockOgTest
	{
		// ---------------------------------------- SPELL - WARLOCK
		// [OG_114] Forbidden Ritual - COST:0 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: Spend all your Mana. Summon that many 1/1 Tentacles.
		// --------------------------------------------------------
		[Fact]
		public void ForbiddenRitual_OG_114()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Forbidden Ritual"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.True(game.CurrentPlayer.BoardZone.IsFull);
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [OG_116] Spreading Madness - COST:3 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $9 damage randomly split among ALL characters. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - ImmuneToSpellpower = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SpreadingMadness_OG_116()
		{
			// TODO SpreadingMadness_OG_116 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Spreading Madness"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [OG_118] Renounce Darkness - COST:2 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: Replace your Hero Power and Warlock cards with another class's. The cards cost (1) less.
		// --------------------------------------------------------
		[Fact]
		public void RenounceDarkness_OG_118()
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


			int handCount = game.CurrentPlayer.HandZone.Count(p => p.Card.Class == CardClass.WARLOCK);
			int deckCount = game.CurrentPlayer.DeckZone.Count(p => p.Card.Class == CardClass.WARLOCK);
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Renounce Darkness"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));

			CardClass result = game.CurrentPlayer.Hero.HeroPower.Card.Class;

			Assert.NotEqual(CardClass.WARLOCK, result);

			int count = 0;
			foreach (IPlayable entity in game.CurrentPlayer.HandZone)
			{
				if (entity.Card.Class != result) continue;
				int c = entity.Card.Cost;
				if (c > 0)
					Assert.Equal(c - 1, entity.Cost);
				++count;
			}

			Assert.Equal(handCount, count);

			count = 0;
			foreach (IPlayable entity in game.CurrentPlayer.DeckZone)
			{
				if (entity.Card.Class != result) continue;
				int c = entity.Card.Cost;
				if (c > 0)
					Assert.Equal(c - 1, entity.Cost);
				++count;
			}

			Assert.Equal(deckCount, count);
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [OG_239] DOOM! - COST:10 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: Destroy all minions. Draw a card for each.
		// --------------------------------------------------------
		[Fact]
		public void Doom_OG_239()
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
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("DOOM!"));
			game.CurrentPlayer.UsedMana = 0;
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Empty(game.Minions);
			Assert.Equal(7, game.CurrentPlayer.HandZone.Count);
		}

		// --------------------------------------- MINION - WARLOCK
		// [OG_109] Darkshire Librarian - COST:2 [ATK:3/HP:2] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b>
		//       Discard a random card. <b>Deathrattle:</b>
		//       Draw a card.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DarkshireLibrarian_OG_109()
		{
			// TODO DarkshireLibrarian_OG_109 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Darkshire Librarian"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [OG_113] Darkshire Councilman - COST:3 [ATK:1/HP:5] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: After you summon a minion, gain +1 Attack.
		// --------------------------------------------------------
		[Fact]
		public void DarkshireCouncilman_OG_113()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Darkshire Councilman"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(1, ((Minion)testCard).AttackDamage);
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(2, ((Minion)testCard).AttackDamage);
		}

		// --------------------------------------- MINION - WARLOCK
		// [OG_121] Cho'gall - COST:7 [ATK:7/HP:7] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> The next spell you cast this turn costs Health instead of Mana.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void Chogall_OG_121()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Cho'gall"));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twisting Nether"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
			Assert.Equal(1, game.CurrentPlayer[GameTag.SPELLS_COST_HEALTH]);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, spell));

			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(8, game.CurrentPlayer.Hero.Damage);
			Assert.Equal(0, game.CurrentPlayer[GameTag.SPELLS_COST_HEALTH]);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cho'gall"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard2));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(0, game.CurrentOpponent[GameTag.SPELLS_COST_HEALTH]);
		}

		// --------------------------------------- MINION - WARLOCK
		// [OG_241] Possessed Villager - COST:1 [ATK:1/HP:1] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a 1/1 Shadowbeast.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PossessedVillager_OG_241()
		{
			// TODO PossessedVillager_OG_241 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Possessed Villager"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [OG_302] Usher of Souls - COST:5 [ATK:5/HP:6] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever a friendly minion dies, give your C'Thun +1/+1
		//       <i>(wherever it is).</i>
		// --------------------------------------------------------
		// GameTag:
		// - RITUAL = 1
		// --------------------------------------------------------
		[Fact]
		public void UsherOfSouls_OG_302()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Usher of Souls"));
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion));
			Assert.Equal(7, ((Minion)game.CurrentOpponent.SetasideZone[0]).Health);
			Assert.Equal(7, ((Minion)game.CurrentOpponent.SetasideZone[0]).AttackDamage);
		}
	}


	public class WarriorOgTest
	{
		// ---------------------------------------- SPELL - WARRIOR
		// [OG_276] Blood Warriors - COST:3 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: Add a copy of each damaged friendly minion to your hand.
		// --------------------------------------------------------
		[Fact]
		public void BloodWarriors_OG_276()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blood Warriors"));
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [OG_314] Blood To Ichor - COST:1 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $1 damage to a minion. If it survives, summon a 2/2 Slime. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void BloodToIchor_OG_314()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blood To Ichor"));
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, minion));
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
		}

		// --------------------------------------- MINION - WARRIOR
		// [OG_149] Ravaging Ghoul - COST:3 [ATK:3/HP:3] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 1 damage to all other minions.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RavagingGhoul_OG_149()
		{
			// TODO RavagingGhoul_OG_149 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ravaging Ghoul"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [OG_218] Bloodhoof Brave - COST:4 [ATK:2/HP:6] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Enrage:</b> +3 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - ENRAGED = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BloodhoofBrave_OG_218()
		{
			// TODO BloodhoofBrave_OG_218 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bloodhoof Brave"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [OG_220] Malkorok - COST:7 [ATK:6/HP:5] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Equip a random weapon.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void Malkorok_OG_220()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Malkorok"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.True(game.CurrentPlayer.Hero.Weapon != null);
		}

		// --------------------------------------- MINION - WARRIOR
		// [OG_301] Ancient Shieldbearer - COST:7 [ATK:6/HP:6] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your C'Thun has at least 10 Attack, gain 10 Armor.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - RITUAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AncientShieldbearer_OG_301()
		{
			// TODO AncientShieldbearer_OG_301 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ancient Shieldbearer"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [OG_312] N'Zoth's First Mate - COST:1 [ATK:1/HP:1] 
		// - Race: pirate, Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Equip a 1/3 Rusty Hook.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void NzothsFirstMate_OG_312()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("N'Zoth's First Mate"));
			Assert.Null(game.CurrentPlayer.Hero.Weapon);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
			Assert.Equal(1, game.CurrentPlayer.Hero.Weapon.AttackDamage);
			Assert.Equal(3, game.CurrentPlayer.Hero.Weapon.Durability);
		}

		// --------------------------------------- MINION - WARRIOR
		// [OG_315] Bloodsail Cultist - COST:3 [ATK:3/HP:4] 
		// - Race: pirate, Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you control another Pirate, give your weapon +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void BloodsailCultist_OG_315()
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
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodsail Cultist"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodsail Cultist"));
			Assert.Null(game.CurrentPlayer.Hero.Weapon);
			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Upgrade!"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell1));
			Assert.Equal(1, game.CurrentPlayer.Hero.Weapon.AttackDamage);
			Assert.Equal(3, game.CurrentPlayer.Hero.Weapon.Durability);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			Assert.Equal(2, game.CurrentPlayer.Hero.Weapon.AttackDamage);
			Assert.Equal(4, game.CurrentPlayer.Hero.Weapon.Durability);
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [OG_033] Tentacles for Arms - COST:5 [ATK:2/HP:0] 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Return this to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TentaclesForArms_OG_033()
		{
			// TODO TentaclesForArms_OG_033 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Tentacles for Arms"));
		}
	}


	public class NeutralOgTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [OG_034] Silithid Swarmer - COST:3 [ATK:3/HP:5] 
		// - Race: beast, Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: Can only attack if your hero attacked this turn.
		// --------------------------------------------------------
		[Fact]
		public void SilithidSwarmer_OG_034()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Silithid Swarmer"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, testCard, game.CurrentOpponent.Hero));
			Assert.Equal(30, game.CurrentOpponent.Hero.Health);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(29, game.CurrentOpponent.Hero.Health);
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, testCard, game.CurrentOpponent.Hero));
			Assert.Equal(26, game.CurrentOpponent.Hero.Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_042] Y'Shaarj, Rage Unbound - COST:10 [ATK:10/HP:10] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: At the end of your turn, put a minion from your deck into the battlefield.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact]
		public void YshaarjRageUnbound_OG_042()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Y'Shaarj, Rage Unbound"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(2, game.CurrentOpponent.BoardZone.Count);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_082] Evolved Kobold - COST:4 [ATK:2/HP:2] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Spell Damage +2</b>
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EvolvedKobold_OG_082()
		{
			// TODO EvolvedKobold_OG_082 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Evolved Kobold"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_102] Darkspeaker - COST:5 [ATK:3/HP:6] 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Swap stats with a friendly minion.
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
		public void Darkspeaker_OG_102()
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
			var testCard = (Minion) Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Darkspeaker"));
			var minion = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard, minion));
			Assert.Equal(3, minion.AttackDamage);
			Assert.Equal(6, minion.Health);
			Assert.Equal(1, testCard.AttackDamage);
			Assert.Equal(1, testCard.Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_122] Mukla, Tyrant of the Vale - COST:6 [ATK:5/HP:5] 
		// - Race: beast, Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add 2 Bananas to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MuklaTyrantOfTheVale_OG_122()
		{
			// TODO MuklaTyrantOfTheVale_OG_122 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Mukla, Tyrant of the Vale"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_123] Shifter Zerus - COST:1 [ATK:1/HP:1] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: Each turn this is in your hand, transform it into a random minion.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShifterZerus_OG_123()
		{
			// TODO ShifterZerus_OG_123 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Shifter Zerus"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_131] Twin Emperor Vek'lor - COST:7 [ATK:4/HP:6] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b><b>Taunt</b>
		//       Battlecry:</b> If your C'Thun has
		//       at least 10 Attack, summon
		//       another Emperor.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - TAUNT = 1
		// - BATTLECRY = 1
		// - RITUAL = 1
		// --------------------------------------------------------
		[Fact]
		public void TwinEmperorVeklor_OG_131()
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
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twin Emperor Vek'lor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			game.CurrentPlayer.UsedMana = 0;
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Disciple of C'Thun"));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion1, game.CurrentOpponent.Hero));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Disciple of C'Thun"));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion2, game.CurrentOpponent.Hero));
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
			game.CurrentPlayer.UsedMana = 0;
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twin Emperor Vek'lor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
			Assert.Equal(5, game.CurrentPlayer.BoardZone.Count);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_133] N'Zoth, the Corruptor - COST:10 [ATK:5/HP:7] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon your <b>Deathrattle</b> minions that died this game.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void NzothTheCorruptor_OG_133()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("N'Zoth, the Corruptor"));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Leper Gnome"));
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flamestrike"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_134] Yogg-Saron, Hope's End - COST:10 [ATK:7/HP:5] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Cast a random spell for each spell you've cast this game <i>(targets chosen randomly)</i>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void YoggSaronHopesEnd_OG_134()
		{
			// TODO YoggSaronHopesEnd_OG_134 test
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
			Card overriddenYoggCard = Cards.FromId("OG_134").Clone();

			var testTask = new YoggTestTask(new List<Card>
			{
				Cards.FromName("Arcane Missiles"),
				Cards.FromName("Polymorph"),
				Cards.FromName("Counterspell"),
				Cards.FromName("Sprint")
			});

			overriddenYoggCard.Power = new SabberStoneCore.Enchants.Power
			{
				PowerTask = testTask
			};
			overriddenYoggCard.Tags.Remove(GameTag.COST);

			IPlayable testCard = Entity.FromCard(game.CurrentPlayer, overriddenYoggCard, null, game.CurrentPlayer.HandZone);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));

			Assert.Equal(2, YoggTestTask.NumSpellCasted);
			Assert.Equal(3, game.CurrentOpponent.Hero.Damage);
			Assert.Equal(0, game.CurrentPlayer.SecretZone.Count);
			Assert.Equal(4, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(0, game.CurrentPlayer.NumSpellsPlayedThisGame);

			YoggTestTask.NumSpellCasted = 0;

			//testTask = new YoggTestTask(new List<Card>
			//{
			//	Cards.FromName("Counterspell"),
			//	Cards.FromName("Spellbender"),
			//	Cards.FromName("Treachery"),
			//	Cards.FromName("")
			//})
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_138] Nerubian Prophet - COST:6 [ATK:4/HP:4] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: At the start of your turn, reduce this card's
		//       Cost by (1).
		// --------------------------------------------------------
		[Fact]
		public void NerubianProphet_OG_138()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true,
				Shuffle = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nerubian Prophet"));
			Assert.Equal(testCard.Card.Name, game.CurrentPlayer.HandZone[4].Card.Name);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nerubian Prophet"));
			Assert.Equal(testCard2.Cost - 1, game.CurrentPlayer.HandZone[4].Cost);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_141] Faceless Behemoth - COST:10 [ATK:10/HP:10] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FacelessBehemoth_OG_141()
		{
			// TODO FacelessBehemoth_OG_141 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Faceless Behemoth"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_142] Eldritch Horror - COST:8 [ATK:6/HP:10] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EldritchHorror_OG_142()
		{
			// TODO EldritchHorror_OG_142 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Eldritch Horror"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_145] Psych-o-Tron - COST:5 [ATK:3/HP:4] 
		// - Race: mechanical, Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Divine Shield</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PsychOTron_OG_145()
		{
			// TODO PsychOTron_OG_145 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Psych-o-Tron"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_147] Corrupted Healbot - COST:5 [ATK:6/HP:6] 
		// - Race: mechanical, Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Restore 8 Health to the enemy hero.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CorruptedHealbot_OG_147()
		{
			// TODO CorruptedHealbot_OG_147 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Corrupted Healbot"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_150] Aberrant Berserker - COST:4 [ATK:3/HP:5] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Enrage:</b> +2 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - ENRAGED = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AberrantBerserker_OG_150()
		{
			// TODO AberrantBerserker_OG_150 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Aberrant Berserker"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_151] Tentacle of N'Zoth - COST:1 [ATK:1/HP:1] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Deal 1 damage to all minions.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TentacleOfNzoth_OG_151()
		{
			// TODO TentacleOfNzoth_OG_151 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Tentacle of N'Zoth"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_152] Grotesque Dragonhawk - COST:7 [ATK:5/HP:5] 
		// - Race: beast, Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Windfury</b>
		// --------------------------------------------------------
		// GameTag:
		// - WINDFURY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GrotesqueDragonhawk_OG_152()
		{
			// TODO GrotesqueDragonhawk_OG_152 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Grotesque Dragonhawk"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_153] Bog Creeper - COST:7 [ATK:6/HP:8] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BogCreeper_OG_153()
		{
			// TODO BogCreeper_OG_153 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bog Creeper"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_156] Bilefin Tidehunter - COST:2 [ATK:2/HP:1] 
		// - Race: murloc, Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 1/1 Ooze with <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BilefinTidehunter_OG_156()
		{
			// TODO BilefinTidehunter_OG_156 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bilefin Tidehunter"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_158] Zealous Initiate - COST:1 [ATK:1/HP:1] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Give a random friendly minion +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ZealousInitiate_OG_158()
		{
			// TODO ZealousInitiate_OG_158 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Zealous Initiate"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_161] Corrupted Seer - COST:6 [ATK:2/HP:3] 
		// - Race: murloc, Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 2 damage to all non-Murloc minions.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CorruptedSeer_OG_161()
		{
			// TODO CorruptedSeer_OG_161 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Corrupted Seer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_162] Disciple of C'Thun - COST:3 [ATK:2/HP:1] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 2 damage. Give your C'Thun +2/+2 <i>(wherever it is)</i>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - RITUAL = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NONSELF_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact]
		public void DiscipleOfCthun_OG_162()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Disciple of C'Thun"));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard, game.CurrentOpponent.Hero));
			Assert.Equal(28, game.CurrentOpponent.Hero.Health);
			Assert.Equal(8, ((Minion)game.CurrentPlayer.SetasideZone[0]).Health);
			Assert.Equal(8, ((Minion)game.CurrentPlayer.SetasideZone[0]).AttackDamage);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_173] Blood of The Ancient One - COST:9 [ATK:9/HP:9] 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: If you control two of these
		//       at the end of your turn, merge them into 'The Ancient One'.
		// --------------------------------------------------------
		[Fact]
		public void BloodOfTheAncientOne_OG_173()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Blood of The Ancient One"));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blood of The Ancient One"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
			game.CurrentPlayer.UsedMana = 0;
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard2));

			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal("OG_173a", game.CurrentOpponent.BoardZone[0].Card.Id);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_174] Faceless Shambler - COST:4 [ATK:1/HP:1] 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Battlecry:</b> Copy a friendly minion's Attack and Health.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact]
		public void FacelessShambler_OG_174()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Faceless Shambler"));
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard, minion));
			Assert.Equal(3, ((Minion)testCard).AttackDamage);
			Assert.Equal(2, ((Minion)testCard).Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_200] Validated Doomsayer - COST:5 [ATK:0/HP:7] 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: At the start of your turn, set this minion's Attack to 7.
		// --------------------------------------------------------
		[Fact]
		public void ValidatedDoomsayer_OG_200()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Validated Doomsayer"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(0, ((Minion)testCard).AttackDamage);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(7, ((Minion)testCard).AttackDamage);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_247] Twisted Worgen - COST:2 [ATK:3/HP:1] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Stealth</b>
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TwistedWorgen_OG_247()
		{
			// TODO TwistedWorgen_OG_247 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Twisted Worgen"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_248] Am'gam Rager - COST:3 [ATK:1/HP:5] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AmgamRager_OG_248()
		{
			// TODO AmgamRager_OG_248 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Am'gam Rager"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_249] Infested Tauren - COST:4 [ATK:2/HP:3] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Deathrattle:</b> Summon a 2/2 Slime.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void InfestedTauren_OG_249()
		{
			// TODO InfestedTauren_OG_249 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Infested Tauren"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_254] Eater of Secrets - COST:4 [ATK:2/HP:4] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy all enemy <b>Secrets</b>. Gain +1/+1 for each.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EaterOfSecrets_OG_254()
		{
			// TODO EaterOfSecrets_OG_254 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Eater of Secrets"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_255] Doomcaller - COST:8 [ATK:7/HP:9] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give your C'Thun +2/+2 <i>(wherever it is).</i> If it's dead, shuffle it into your deck.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - RITUAL = 1
		// --------------------------------------------------------
		[Fact]
		public void Doomcaller_OG_255()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Doomcaller"));
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("C'Thun"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, minion));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(25, game.CurrentPlayer.DeckZone.Count);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(26, game.CurrentPlayer.DeckZone.Count);
			Assert.Equal(8, ((Minion)game.CurrentPlayer.SetasideZone[0]).AttackDamage);
			Assert.Equal(8, ((Minion)game.CurrentPlayer.SetasideZone[0]).Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_256] Spawn of N'Zoth - COST:3 [ATK:2/HP:2] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Give your minions +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SpawnOfNzoth_OG_256()
		{
			// TODO SpawnOfNzoth_OG_256 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Spawn of N'Zoth"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_271] Scaled Nightmare - COST:6 [ATK:2/HP:8] 
		// - Race: dragon, Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: At the start of your turn, double this minion's Attack.
		// --------------------------------------------------------
		[Fact]
		public void ScaledNightmare_OG_271()
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
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Scaled Nightmare"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(4, ((Minion)testCard).AttackDamage);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Aldor Peacekeeper"));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion1, testCard));
			Assert.Equal(1, ((Minion)testCard).AttackDamage);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(2, ((Minion)testCard).AttackDamage);
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stormwind Champion"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			Assert.Equal(3, ((Minion)testCard).AttackDamage);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(5, ((Minion)testCard).AttackDamage);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_272] Twilight Summoner - COST:4 [ATK:1/HP:1] 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a 5/5 Faceless Destroyer.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TwilightSummoner_OG_272()
		{
			// TODO TwilightSummoner_OG_272 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Twilight Summoner"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_280] C'Thun - COST:10 [ATK:6/HP:6] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal damage equal to this minion's Attack randomly split among all enemies.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void Cthun_OG_280()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("C'Thun"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(24, game.CurrentOpponent.Hero.Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_281] Beckoner of Evil - COST:2 [ATK:2/HP:3] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give your C'Thun +2/+2 <i>(wherever it is).</i>
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - RITUAL = 1
		// --------------------------------------------------------
		[Fact]
		public void BeckonerOfEvil_OG_281()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Beckoner of Evil"));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("C'Thun"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(6, ((Minion)minion).AttackDamage);
			Assert.Equal(6, ((Minion)minion).Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(8, ((Minion)minion).AttackDamage);
			Assert.Equal(8, ((Minion)minion).Health);
			Assert.Equal(8, ((Minion)game.CurrentPlayer.SetasideZone[0]).AttackDamage);
			Assert.Equal(8, ((Minion)game.CurrentPlayer.SetasideZone[0]).Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_283] C'Thun's Chosen - COST:4 [ATK:4/HP:2] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Divine Shield</b>
		//       <b>Battlecry:</b> Give your C'Thun
		//       +2/+2 <i>(wherever it is).</i>
		// --------------------------------------------------------
		// GameTag:
		// - DIVINE_SHIELD = 1
		// - BATTLECRY = 1
		// - RITUAL = 1
		// --------------------------------------------------------
		[Fact]
		public void CthunsChosen_OG_283()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("C'Thun's Chosen"));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("C'Thun"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(6, ((Minion)minion).AttackDamage);
			Assert.Equal(6, ((Minion)minion).Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(8, ((Minion)minion).AttackDamage);
			Assert.Equal(8, ((Minion)minion).Health);
			Assert.True(((Minion)testCard).HasDivineShield);
			Assert.Equal(8, ((Minion)game.CurrentPlayer.SetasideZone[0]).AttackDamage);
			Assert.Equal(8, ((Minion)game.CurrentPlayer.SetasideZone[0]).Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_284] Twilight Geomancer - COST:2 [ATK:1/HP:4] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       <b>Battlecry:</b> Give your C'Thun
		//       <b>Taunt</b> <i>(wherever it is).</i>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// - RITUAL = 1
		// --------------------------------------------------------
		[Fact]
		public void TwilightGeomancer_OG_284()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twilight Geomancer"));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("C'Thun"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(6, ((Minion)minion).AttackDamage);
			Assert.Equal(6, ((Minion)minion).Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(6, ((Minion)minion).AttackDamage);
			Assert.Equal(6, ((Minion)minion).Health);
			Assert.True(((Minion)minion).HasTaunt);
			Assert.True(((Minion)testCard).HasTaunt);
			Assert.Equal(6, ((Minion)game.CurrentPlayer.SetasideZone[0]).AttackDamage);
			Assert.Equal(6, ((Minion)game.CurrentPlayer.SetasideZone[0]).Health);
			Assert.True(((Minion)game.CurrentPlayer.SetasideZone[0]).HasTaunt);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_286] Twilight Elder - COST:3 [ATK:3/HP:4] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: At the end of your turn, give your C'Thun +1/+1 <i>(wherever it is).</i>
		// --------------------------------------------------------
		// GameTag:
		// - RITUAL = 1
		// --------------------------------------------------------
		[Fact]
		public void TwilightElder_OG_286()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twilight Elder"));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("C'Thun"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(6, ((Minion)minion).AttackDamage);
			Assert.Equal(6, ((Minion)minion).Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(7, ((Minion)minion).AttackDamage);
			Assert.Equal(7, ((Minion)minion).Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(7, ((Minion)minion).AttackDamage);
			Assert.Equal(7, ((Minion)minion).Health);
			Assert.Equal(7, ((Minion)game.CurrentPlayer.SetasideZone[0]).AttackDamage);
			Assert.Equal(7, ((Minion)game.CurrentPlayer.SetasideZone[0]).Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_290] Ancient Harbinger - COST:6 [ATK:4/HP:6] 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: At the start of your turn, put a 10-Cost minion from your deck into your hand.
		// --------------------------------------------------------
		[Fact]
		public void AncientHarbinger_OG_290()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Bloodfen Raptor"),
					Cards.FromName("Bloodfen Raptor"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Goldshire Footman"),
					Cards.FromName("Goldshire Footman"),
					Cards.FromName("Deathwing"), // 10-cost
				},
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true,
				Shuffle = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ancient Harbinger"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count); // 3 (starting) + Ancient Harbinger + 2x draw + draw DeathWing
			Assert.Equal(DeckZone.StartingCards - 6, game.CurrentPlayer.DeckZone.Count); // 30 (starting) - 6
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_295] Cult Apothecary - COST:5 [ATK:4/HP:4] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> For each enemy minion, restore 2 Health to your hero.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void CultApothecary_OG_295()
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
			game.CurrentPlayer.Hero.Damage = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cult Apothecary"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(22, game.CurrentPlayer.Hero.Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_300] The Boogeymonster - COST:8 [ATK:6/HP:7] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever this attacks and kills a minion, gain +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact]
		public void TheBoogeymonster_OG_300()
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
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Boogeymonster"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			var minion2 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion1, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(6, ((Minion)testCard).AttackDamage);
			Assert.Equal(6, ((Minion)testCard).Health);
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, testCard, minion2));
			Assert.Equal(8, ((Minion)testCard).AttackDamage);
			Assert.Equal(7, ((Minion)testCard).Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_317] Deathwing, Dragonlord - COST:10 [ATK:12/HP:12] 
		// - Race: dragon, Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Put all Dragons from your hand into the battlefield.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void DeathwingDragonlord_OG_317()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Faerie Dragon"),
					Cards.FromName("Twilight Drake"),
					Cards.FromName("Twilight Whelp")
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Deathwing, Dragonlord"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Assassinate"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, testCard));
			Assert.True(game.CurrentOpponent.BoardZone.Count >= 3);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_318] Hogger, Doom of Elwynn - COST:7 [ATK:6/HP:6] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever this minion takes damage, summon a 2/2 Gnoll with <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HoggerDoomOfElwynn_OG_318()
		{
			// TODO HoggerDoomOfElwynn_OG_318 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Hogger, Doom of Elwynn"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_320] Midnight Drake - COST:4 [ATK:1/HP:4] 
		// - Race: dragon, Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Gain +1 Attack for each other card
		//       in your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void MidnightDrake_OG_320()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Midnight Drake"));
			Assert.Equal(1, ((Minion)testCard).AttackDamage);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(5, ((Minion)testCard).AttackDamage);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_321] Crazed Worshipper - COST:5 [ATK:3/HP:6] 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Taunt.</b> Whenever this minion takes damage, give your C'Thun +1/+1 <i>(wherever it is).</i>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - RITUAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CrazedWorshipper_OG_321()
		{
			// TODO CrazedWorshipper_OG_321 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Crazed Worshipper"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_322] Blackwater Pirate - COST:4 [ATK:2/HP:5] 
		// - Race: pirate, Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: Your weapons cost (2) less.
		// --------------------------------------------------------
		[Fact]
		public void BlackwaterPirate_OG_322()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blackwater Pirate"));
			IPlayable weapon = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fiery War Axe"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(1, weapon.Cost);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_323] Polluted Hoarder - COST:4 [ATK:4/HP:2] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Draw a card.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PollutedHoarder_OG_323()
		{
			// TODO PollutedHoarder_OG_323 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Polluted Hoarder"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_326] Duskboar - COST:2 [ATK:4/HP:1] 
		// - Race: beast, Set: og, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Duskboar_OG_326()
		{
			// TODO Duskboar_OG_326 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Duskboar"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_327] Squirming Tentacle - COST:3 [ATK:2/HP:4] 
		// - Set: og, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SquirmingTentacle_OG_327()
		{
			// TODO SquirmingTentacle_OG_327 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Squirming Tentacle"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_337] Cyclopian Horror - COST:4 [ATK:3/HP:3] 
		// - Set: og, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Taunt</b>. <b>Battlecry:</b> Gain      +1 Health for each enemy minion.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void CyclopianHorror_OG_337()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cyclopian Horror"));
			game.Process(EndTurnTask.Any((game.CurrentPlayer)));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(EndTurnTask.Any((game.CurrentPlayer)));
			Assert.Equal(3, ((Minion)testCard).Health);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(5, ((Minion)testCard).Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_338] Nat, the Darkfisher - COST:2 [ATK:2/HP:4] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: At the start of your opponent's turn, they have a 50% chance to draw an extra card.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NatTheDarkfisher_OG_338()
		{
			// TODO NatTheDarkfisher_OG_338 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Nat, the Darkfisher"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_339] Skeram Cultist - COST:6 [ATK:7/HP:6] 
		// - Set: og, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give your C'Thun +2/+2 <i>(wherever it is).</i>
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - RITUAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SkeramCultist_OG_339()
		{
			// TODO SkeramCultist_OG_339 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Skeram Cultist"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [OG_340] Soggoth the Slitherer - COST:9 [ATK:5/HP:9] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       Can't be targeted by spells or Hero Powers.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - TAUNT = 1
		// - CANT_BE_TARGETED_BY_ABILITIES = 1
		// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SoggothTheSlitherer_OG_340()
		{
			// TODO SoggothTheSlitherer_OG_340 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Soggoth the Slitherer"));
		}

		private class YoggTestTask : SimpleTask
		{
			public static int NumSpellCasted { get; set; }

			private class CastSingleSpell : SimpleTask
			{
				private readonly Card _spellCard;

				public CastSingleSpell(Card spellCard)
				{
					_spellCard = spellCard;
				}

				public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
					in TaskStack stack = null)
				{
					if (!(source.Zone is BoardZone) || source[GameTag.SILENCED] == 1)
						return TaskState.STOP;

					var spellToCast = (Spell) Entity.FromCard(source.Controller, _spellCard);

					spellToCast.CardTarget = source.Id;

					Generic.CastSpell.Invoke(source.Controller, spellToCast, (ICharacter)source, 0, true);
					game.DeathProcessingAndAuraUpdate();

					NumSpellCasted++;

					return TaskState.COMPLETE;
				}
			}

			private readonly IReadOnlyList<Card> _spells;

			public YoggTestTask(List<Card> spellCardList)
			{
				_spells = spellCardList.AsReadOnly();
			}

			public override TaskState Process(in Game game, in Controller controller, in IEntity source, in IEntity target,
				in TaskStack stack = null)
			{
				if (source.Card.Id != "OG_134") return TaskState.STOP;

				var task = StateTaskList.Chain(
					_spells
						.Select(s => new CastSingleSpell(s))
						.Cast<ISimpleTask>()
						.ToArray());

				game.TaskQueue.Enqueue(task, in controller, in source, in target);

				return TaskState.COMPLETE;
			}
		}
	}


	public class NeutralNonCollectOgTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [OG_279] C'Thun (*) - COST:10 [ATK:6/HP:6] 
		// - Set: og, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal damage equal to this minion's Attack randomly split among all enemies.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact]
		public void Cthun_OG_279()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Disciple of C'Thun"));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard, game.CurrentOpponent.Hero));
			Assert.Equal(28, game.CurrentOpponent.Hero.Health);
			Assert.Equal(8, ((Minion)game.CurrentPlayer.SetasideZone[0]).Health);
			Assert.Equal(8, ((Minion)game.CurrentPlayer.SetasideZone[0]).AttackDamage);
			game.Player1.UsedMana = 0;
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("C'Thun"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(20, game.CurrentOpponent.Hero.Health);
		}
	}
}
