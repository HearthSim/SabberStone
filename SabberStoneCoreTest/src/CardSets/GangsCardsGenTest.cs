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

namespace SabberStoneCoreTest.CardSets
{

	public class DruidGangsTest
	{
		// ------------------------------------------ SPELL - DRUID
		// [CFM_602] Jade Idol - COST:1 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Choose One -</b> Summon a{1} {0} <b>Jade Golem</b>; or Shuffle 3 copies of this card into your deck.@<b>Choose One -</b> Summon a <b>Jade Golem</b>; or Shuffle 3 copies of this card into your deck.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		// RefTag:
		// - JADE_GOLEM = 1
		// --------------------------------------------------------
		[Fact]
		public void JadeIdol_CFM_602()
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
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jade Idol"));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jade Idol"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard1, 1));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(26, game.CurrentPlayer.DeckZone.Count);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard2, 2));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(29, game.CurrentPlayer.DeckZone.Count);
		}

		// ------------------------------------------ SPELL - DRUID
		// [CFM_614] Mark of the Lotus - COST:1 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: Give your minions +1/+1.
		// --------------------------------------------------------
		[Fact]
		public void MarkOfTheLotus_CFM_614()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mark of the Lotus"));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(1, ((Minion)minion).AttackDamage);
			Assert.Equal(1, ((Minion)minion).Health);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(2, ((Minion)minion).AttackDamage);
			Assert.Equal(2, ((Minion)minion).Health);
		}

		// ------------------------------------------ SPELL - DRUID
		// [CFM_616] Pilfered Power - COST:3 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: Gain an empty Mana Crystal for each friendly minion.
		// --------------------------------------------------------
		[Fact]
		public void PilferedPower_CFM_616()
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
			game.Player1.BaseMana = 5;
			game.Player2.BaseMana = 5;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pilfered Power"));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(7, game.CurrentPlayer.BaseMana);
		}

		// ------------------------------------------ SPELL - DRUID
		// [CFM_713] Jade Blossom - COST:3 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: Summon a{1} {0} <b>Jade Golem</b>. Gain an empty Mana Crystal.@Summon a <b>Jade Golem</b>. Gain an empty Mana Crystal.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_SLOT_OR_MANA_CRYSTAL_SLOT = 0
		// --------------------------------------------------------
		// RefTag:
		// - JADE_GOLEM = 1
		// --------------------------------------------------------
		[Fact]
		public void JadeBlossom_CFM_713()
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
			game.Player1.BaseMana = 5;
			game.Player2.BaseMana = 5;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jade Blossom"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(6, game.CurrentPlayer.BaseMana);
		}

		// ------------------------------------------ SPELL - DRUID
		// [CFM_811] Lunar Visions - COST:5 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: Draw 2 cards. Minions drawn cost (2) less.
		// --------------------------------------------------------
		[Fact]
		public void LunarVisions_CFM_811()
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

			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lunar Visions"));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
			if (game.CurrentPlayer.HandZone[5] is Minion)
				Assert.Equal(game.CurrentPlayer.HandZone[5].Cost,
					game.CurrentPlayer.HandZone[5].Card.Cost > 1 ? game.CurrentPlayer.HandZone[5].Card.Cost - 2 : 0);
			if (game.CurrentPlayer.HandZone[4] is Minion)
				Assert.Equal(game.CurrentPlayer.HandZone[4].Cost,
					game.CurrentPlayer.HandZone[4].Card.Cost > 1 ? game.CurrentPlayer.HandZone[4].Card.Cost - 2 : 0);
		}

		// ----------------------------------------- MINION - DRUID
		// [CFM_308] Kun the Forgotten King - COST:10 [ATK:7/HP:7] 
		// - Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Choose One -</b> Gain 10 Armor; or Refresh your Mana Crystals.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		[Fact]
		public void KunTheForgottenKing_CFM_308()
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
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kun the Forgotten King"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard1, 1));
			Assert.Equal(10, game.CurrentPlayer.Hero.Armor);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kun the Forgotten King"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard2, 2));
			Assert.Equal(10, game.CurrentPlayer.RemainingMana);

			Game clone = game.Clone();
			Assert.Equal(10, clone.CurrentPlayer.RemainingMana);
		}

		// ----------------------------------------- MINION - DRUID
		// [CFM_343] Jade Behemoth - COST:6 [ATK:3/HP:6] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       <b>Battlecry:</b> Summon a{1}
		//       {0} <b>Jade Golem</b>.@[x]<b>Taunt</b>
		//       <b>Battlecry:</b> Summon a
		//       <b>Jade Golem</b>.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - JADE_GOLEM = 1
		// --------------------------------------------------------
		[Fact]
		public void JadeBehemoth_CFM_343()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jade Behemoth"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
		}

		// ----------------------------------------- MINION - DRUID
		// [CFM_617] Celestial Dreamer - COST:3 [ATK:3/HP:3] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If a friendly minion has 5 or more Attack, gain +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void CelestialDreamer_CFM_617()
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
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Celestial Dreamer"));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Celestial Dreamer"));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Booty Bay Bodyguard"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
			game.CurrentPlayer.UsedMana = 0;
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
			Assert.Equal(3, ((Minion)testCard1).AttackDamage);
			Assert.Equal(3, ((Minion)testCard1).Health);
			Assert.Equal(5, ((Minion)testCard2).AttackDamage);
			Assert.Equal(5, ((Minion)testCard2).Health);
		}

		// ----------------------------------------- MINION - DRUID
		// [CFM_816] Virmen Sensei - COST:5 [ATK:4/HP:5] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly Beast +2/+2.
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
		[Fact]
		public void VirmenSensei_CFM_816()
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
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Virmen Sensei"));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Virmen Sensei"));
			var minion1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			game.CurrentPlayer.UsedMana = 0;
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard2, minion1));
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(3, ((Minion)minion1).AttackDamage);
			Assert.Equal(3, ((Minion)minion1).Health);
		}
	}


	public class HunterGangsTest
	{
		// ----------------------------------------- SPELL - HUNTER
		// [CFM_026] Hidden Cache - COST:2 
		// - Fac: neutral, Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Secret:</b> After your opponent plays a minion, give a random minion in your hand +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		[Fact]
		public void HiddenCache_CFM_026()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Stonetusk Boar")
				},
				Player2HeroClass = CardClass.HUNTER,
				FillDecks = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hidden Cache"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, game.CurrentPlayer.HandZone[0]));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(3, game.CurrentPlayer.BoardZone[0].Health);
			Assert.Equal(3, game.CurrentPlayer.BoardZone[0].AttackDamage);
			Assert.Equal(1, game.CurrentOpponent.BoardZone[0].Health);
			Assert.Equal(1, game.CurrentOpponent.BoardZone[0].AttackDamage);
		}

		// ----------------------------------------- SPELL - HUNTER
		// [CFM_334] Smuggler's Crate - COST:1 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: Give a random Beast in your hand +2/+2.
		// --------------------------------------------------------
		[Fact]
		public void SmugglersCrate_CFM_334()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Stonetusk Boar")
				},
				Player2HeroClass = CardClass.HUNTER,
				FillDecks = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Smuggler's Crate"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, game.CurrentPlayer.HandZone[0]));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(3, game.CurrentPlayer.BoardZone[0].Health);
			Assert.Equal(3, game.CurrentPlayer.BoardZone[0].AttackDamage);
		}

		// ---------------------------------------- MINION - HUNTER
		// [CFM_315] Alleycat - COST:1 [ATK:1/HP:1] 
		// - Race: beast, Fac: neutral, Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 1/1_Cat.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void Alleycat_CFM_315()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Alleycat"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
		}

		// ---------------------------------------- MINION - HUNTER
		// [CFM_316] Rat Pack - COST:3 [ATK:2/HP:2] 
		// - Race: beast, Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Deathrattle:</b> Summon a
		//       number of 1/1 Rats equal
		//       _to this minion's Attack.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void RatPack_CFM_316()
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
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rat Pack"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, testCard));
			Assert.Equal(2, game.CurrentOpponent.BoardZone.Count);
		}

		// ---------------------------------------- MINION - HUNTER
		// [CFM_333] Knuckles - COST:5 [ATK:3/HP:7] 
		// - Race: beast, Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: After this attacks a
		//       minion, it also hits the enemy hero.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - FINISH_ATTACK_SPELL_ON_DAMAGE = 1
		// --------------------------------------------------------
		[Fact]
		public void Knuckles_CFM_333()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Knuckles"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, testCard, minion));
			Assert.True(((Minion)minion).IsDead);
			Assert.Equal(27, game.CurrentOpponent.Hero.Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, testCard, game.CurrentOpponent.Hero));
			Assert.Equal(24, game.CurrentOpponent.Hero.Health);
		}

		// ---------------------------------------- MINION - HUNTER
		// [CFM_335] Dispatch Kodo - COST:4 [ATK:2/HP:4] 
		// - Race: beast, Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal damage equal to this minion's Attack.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact]
		public void DispatchKodo_CFM_335()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dispatch Kodo"));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard, game.CurrentOpponent.Hero));
			Assert.Equal(28, game.CurrentOpponent.Hero.Health);
		}

		// ---------------------------------------- MINION - HUNTER
		// [CFM_336] Shaky Zipgunner - COST:3 [ATK:3/HP:3] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Deathrattle:</b> Give a random
		//       minion in your hand +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShakyZipgunner_CFM_336()
		{
			// TODO ShakyZipgunner_CFM_336 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Shaky Zipgunner"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [CFM_338] Trogg Beastrager - COST:2 [ATK:3/HP:2] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a random Beast in your hand +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TroggBeastrager_CFM_338()
		{
			// TODO TroggBeastrager_CFM_338 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Trogg Beastrager"));
		}

		// ---------------------------------------- WEAPON - HUNTER
		// [CFM_337] Piranha Launcher - COST:5 [ATK:2/HP:0] 
		// - Fac: neutral, Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]After your hero attacks,
		//       summon a 1/1 Piranha.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 4
		// --------------------------------------------------------
		[Fact]
		public void PiranhaLauncher_CFM_337()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Piranha Launcher"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
		}
	}


	public class MageGangsTest
	{
		// ------------------------------------------- SPELL - MAGE
		// [CFM_021] Freezing Potion - COST:0 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Freeze</b> an enemy.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_ENEMY_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FreezingPotion_CFM_021()
		{
			// TODO FreezingPotion_CFM_021 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Freezing Potion"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [CFM_065] Volcanic Potion - COST:3 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $2 damage to all_minions. *spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VolcanicPotion_CFM_065()
		{
			// TODO VolcanicPotion_CFM_065 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Volcanic Potion"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [CFM_620] Potion of Polymorph - COST:3 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Secret:</b> After your opponent plays a minion, transform it into a
		//       1/1 Sheep.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		[Fact]
		public void PotionOfPolymorph_CFM_620()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Potion of Polymorph"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			Assert.Equal(1, game.CurrentOpponent.SecretZone.Count);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(0, game.CurrentOpponent.SecretZone.Count);
			Assert.Equal("CFM_621_m5", game.CurrentPlayer.BoardZone[0].Card.Id);
		}

		// ------------------------------------------- SPELL - MAGE
		// [CFM_623] Greater Arcane Missiles - COST:7 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: Shoot three missiles at random enemies that deal $3 damage each. *spelldmg
		// --------------------------------------------------------
		[Fact]
		public void GreaterArcaneMissiles_CFM_623()
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
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ironfur Grizzly"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, (ICharacter)minion1));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ironfur Grizzly"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, (ICharacter)minion2));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			int totHealth = game.CurrentOpponent.Hero.Health;
			totHealth += ((ICharacter)minion1).Health;
			totHealth += ((ICharacter)minion2).Health;
			Assert.Equal(36, totHealth);
			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Greater Arcane Missiles"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell1));
			totHealth = game.CurrentOpponent.Hero.Health;
			totHealth += ((ICharacter)minion1).IsDead ? 0 : ((ICharacter)minion1).Health;
			totHealth += ((ICharacter)minion2).IsDead ? 0 : ((ICharacter)minion2).Health;
			Assert.Equal(27, totHealth);
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dalaran Mage"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, (ICharacter)minion3));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Greater Arcane Missiles"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell2));
			totHealth = game.CurrentOpponent.Hero.Health;
			totHealth += ((ICharacter)minion1).IsDead ? 0 : ((ICharacter)minion1).Health;
			totHealth += ((ICharacter)minion2).IsDead ? 0 : ((ICharacter)minion2).Health;
			// Spellpower check
			Assert.Equal(1, game.CurrentPlayer.CurrentSpellPower);
			Assert.Equal(15, totHealth);
		}

		// ------------------------------------------ MINION - MAGE
		// [CFM_066] Kabal Lackey - COST:1 [ATK:2/HP:1] 
		// - Set: gangs, Rarity: common
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
		public void KabalLackey_CFM_066()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kabal Lackey"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			IPlayable secret1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mirror Entity"));
			IPlayable secret2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mirror Entity"));
			game.AuraUpdate();
			Assert.Equal(0, secret1.Cost);
			Assert.Equal(0, secret2.Cost);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, secret1));
			Assert.Equal(3, secret2.Cost);
		}

		// ------------------------------------------ MINION - MAGE
		// [CFM_660] Manic Soulcaster - COST:3 [ATK:3/HP:4] 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Choose a friendly minion. Shuffle a copy into your deck.
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
		public void ManicSoulcaster_CFM_660()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Manic Soulcaster"));

			Assert.Equal(0, game.CurrentPlayer.DeckZone.Count);
			IPlayable minion = game.ProcessCard("Stonetusk Boar");
			game.ProcessCard(testCard, minion);
			Assert.Equal(1, game.CurrentPlayer.DeckZone.Count);
			Assert.Equal(game.CurrentPlayer.DeckZone[0].Card.Id, minion.Card.Id);
			Assert.NotEqual(game.CurrentPlayer.DeckZone[0].Id, minion.Id);
		}

		// ------------------------------------------ MINION - MAGE
		// [CFM_671] Cryomancer - COST:5 [ATK:5/HP:5] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Gain +2/+2
		//       if an enemy is <b>Frozen</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact]
		public void Cryomancer_CFM_671()
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

			game.ProcessCard("Freezing Potion", game.CurrentOpponent.Hero);
			Minion testCard = (Minion) game.ProcessCard("Cryomancer");
			Assert.Equal(7, testCard.AttackDamage);
			Assert.Equal(7, testCard.Health);

		}

		// ------------------------------------------ MINION - MAGE
		// [CFM_687] Inkmaster Solia - COST:7 [ATK:5/HP:5] 
		// - Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If your deck has
		//       no duplicates, the next
		//       spell you cast this turn
		//       costs (0).
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void InkmasterSolia_CFM_687()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Inkmaster Solia"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			IPlayable secret1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flamestrike"));
			IPlayable secret2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flamestrike"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, secret1));
		}

		// ------------------------------------------ MINION - MAGE
		// [CFM_760] Kabal Crystal Runner - COST:6 [ATK:5/HP:5] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: Costs (2) less for each <b>Secret</b> you've played this_game.
		// --------------------------------------------------------
		// RefTag:
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		[Fact]
		public void KabalCrystalRunner_CFM_760()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kabal Crystal Runner"));
			Assert.Equal(6, testCard.Cost);
			IPlayable secret = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mirror Entity"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, secret));
			Assert.Equal(4, testCard.Cost);
		}
	}


	public class PaladinGangsTest
	{
		// ---------------------------------------- SPELL - PALADIN
		// [CFM_305] Smuggler's Run - COST:1 
		// - Fac: neutral, Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: Give all minions in your hand +1/+1.
		// --------------------------------------------------------
		[Fact]
		public void SmugglersRun_CFM_305()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Smuggler's Run"));
			int totAtk = game.CurrentPlayer.HandZone.Where(p => p is Minion).Sum(p => ((Minion)p).AttackDamage);
			int totHp = game.CurrentPlayer.HandZone.Where(p => p is Minion).Sum(p => ((Minion)p).Health);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.NotEqual(totAtk,
				game.CurrentPlayer.HandZone.Where(p => p is Minion).Sum(p => ((Minion)p).AttackDamage));
			Assert.NotEqual(totHp,
				game.CurrentPlayer.HandZone.Where(p => p is Minion).Sum(p => ((Minion)p).Health));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [CFM_800] Getaway Kodo - COST:1 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When a friendly minion dies, return it to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		[Fact]
		public void GetawayKodo_CFM_800()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Getaway Kodo"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));

			Minion minion1 = game.ProcessCard<Minion>("Stonetusk Boar");
			Minion minion2 = game.ProcessCard<Minion>("Bloodfen Raptor");
			Minion minion3 = game.ProcessCard<Minion>("Dalaran Mage");
			game.EndTurn();

			int count = game.CurrentOpponent.HandZone.Count;
			game.ProcessCard("Flamestrike");
			Assert.Equal(0, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal(count + 1, game.CurrentOpponent.HandZone.Count);
			IPlayable returnedCard = game.CurrentOpponent.HandZone[count];
			Assert.Equal(returnedCard.Card.Id, minion1.Card.Id);
		}

		// ---------------------------------------- SPELL - PALADIN
		// [CFM_905] Small-Time Recruits - COST:3 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]Draw three 1-Cost
		//       minions from your deck.
		// --------------------------------------------------------
		[Fact]
		public void SmallTimeRecruits_CFM_905()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bloodfen Raptor"),
					Cards.FromName("Bloodfen Raptor"),
					Cards.FromName("Worgen Infiltrator"),
					Cards.FromName("Worgen Infiltrator"),
					Cards.FromName("Small-Time Recruits"),
					Cards.FromName("Grimestreet Protector"),
					Cards.FromName("Grimestreet Protector"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Grimscale Chum"),
				},
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = true,
				FillDecksPredictably = true,
				Shuffle = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Small-Time Recruits"));
			Assert.Equal(1, game.CurrentPlayer.NumCardsDrawnThisTurn);
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(4, game.CurrentPlayer.NumCardsDrawnThisTurn);
			Assert.Equal(7, game.CurrentPlayer.HandZone.Count);
		}

		// --------------------------------------- MINION - PALADIN
		// [CFM_062] Grimestreet Protector - COST:7 [ATK:6/HP:6] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       <b>Battlecry:</b> Give adjacent
		//       _minions <b>Divine Shield</b>.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact]
		public void GrimestreetProtector_CFM_062()
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
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grimestreet Protector"));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grimestreet Protector"));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
			game.CurrentPlayer.UsedMana = 0;
			Assert.False(((Minion)minion1).HasDivineShield);
			Assert.True(((Minion)minion2).HasDivineShield);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard2, null, 3, 0));
			Assert.True(((Minion)minion3).HasDivineShield);
			Assert.True(((Minion)testCard1).HasDivineShield);
		}

		// --------------------------------------- MINION - PALADIN
		// [CFM_639] Grimestreet Enforcer - COST:5 [ATK:4/HP:4] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: At the end of your turn, give all minions in your hand +1/+1.
		// --------------------------------------------------------
		[Fact]
		public void GrimestreetEnforcer_CFM_639()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grimestreet Enforcer"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			int totAtk = game.CurrentPlayer.HandZone.Where(p => p is Minion).Sum(p => ((Minion)p).AttackDamage);
			int totHp = game.CurrentPlayer.HandZone.Where(p => p is Minion).Sum(p => ((Minion)p).Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.NotEqual(totAtk,
				game.CurrentOpponent.HandZone.Where(p => p is Minion).Sum(p => ((Minion)p).AttackDamage));
			Assert.NotEqual(totHp,
				game.CurrentOpponent.HandZone.Where(p => p is Minion).Sum(p => ((Minion)p).Health));
		}

		// --------------------------------------- MINION - PALADIN
		// [CFM_650] Grimscale Chum - COST:1 [ATK:2/HP:1] 
		// - Race: murloc, Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Give a random
		//       Murloc in your hand +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void GrimscaleChum_CFM_650()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grimscale Chum"),
					Cards.FromName("Bloodfen Raptor")
				},
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = false,
				Shuffle = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grimscale Chum"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, game.CurrentPlayer.HandZone[0]));
			Assert.Equal(2, ((Minion)game.CurrentPlayer.HandZone[0]).Health);
			Assert.Equal(2, game.CurrentPlayer.BoardZone[1].Health);
			Assert.Equal(3, game.CurrentPlayer.BoardZone[1].AttackDamage);
		}

		// --------------------------------------- MINION - PALADIN
		// [CFM_753] Grimestreet Outfitter - COST:2 [ATK:1/HP:1] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give all minions in your hand +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void GrimestreetOutfitter_CFM_753()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grimestreet Outfitter"));
			int totAtk = game.CurrentPlayer.HandZone.Where(p => p is Minion).Sum(p => ((Minion)p).AttackDamage);
			int totHp = game.CurrentPlayer.HandZone.Where(p => p is Minion).Sum(p => ((Minion)p).Health);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.NotEqual(totAtk,
				game.CurrentPlayer.HandZone.Where(p => p is Minion).Sum(p => ((Minion)p).AttackDamage));
			Assert.NotEqual(totHp,
				game.CurrentPlayer.HandZone.Where(p => p is Minion).Sum(p => ((Minion)p).Health));
		}

		// --------------------------------------- MINION - PALADIN
		// [CFM_759] Meanstreet Marshal - COST:1 [ATK:1/HP:2] 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> If this minion has 2 or more Attack, draw a card.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MeanstreetMarshal_CFM_759()
		{
			// TODO MeanstreetMarshal_CFM_759 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Meanstreet Marshal"));
		}

		// --------------------------------------- MINION - PALADIN
		// [CFM_815] Wickerflame Burnbristle - COST:3 [ATK:2/HP:2]
		// - Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Divine Shield</b>, <b>Taunt</b>, <b>Lifesteal</b>
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - TAUNT = 1
		// - DIVINE_SHIELD = 1
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact]
		public void WickerflameBurnbristle_CFM_815()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wickerflame Burnbristle")
				},
				Player2HeroClass = CardClass.PALADIN,
				Player2Deck = new List<Card>()
				{
					Cards.FromName("Consecration")
				},
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Wickerflame Burnbristle"));
			Assert.True(game.CurrentPlayer.BoardZone[0].HasDivineShield);
			Assert.True(game.CurrentPlayer.BoardZone[0].HasLifeSteal);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, "Consecration"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(28, game.CurrentPlayer.Hero.Health);
			Assert.False(game.CurrentPlayer.BoardZone[0].HasDivineShield);
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.BoardZone[0], game.CurrentOpponent.Hero));
			Assert.Equal(30, game.CurrentPlayer.Hero.Health);
		}
	}


	public class PriestGangsTest
	{
		// ----------------------------------------- SPELL - PRIEST
		// [CFM_603] Potion of Madness - COST:1 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: Gain control of an enemy minion with 2 or less Attack until end of turn.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_ENEMY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_NUM_MINION_SLOTS = 1
		// - REQ_TARGET_MAX_ATTACK = 2
		// --------------------------------------------------------
		[Fact]
		public void PotionOfMadness_CFM_603()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Potion of Madness"));
			var minion1 = (Minion)Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wisp"));
			var minion2 = (Minion)Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wisp"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Potion of Madness"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard2, minion1));
			Assert.True(minion1.Controller == game.CurrentPlayer);
			Assert.True(minion1.HasCharge);
			Assert.True(minion1.Zone == game.CurrentPlayer.BoardZone);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.True(minion1.Controller == game.CurrentPlayer);
			Assert.True(minion1.Zone == game.CurrentPlayer.BoardZone);
			Assert.False(minion1.HasCharge);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable testCard3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Potion of Madness"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard3, minion1));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion1, minion2));
			Assert.Single(game.CurrentPlayer.GraveyardZone.Where(p => p.Card.Type == CardType.MINION));
			var minion3 = (Minion)Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wisp"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable silence = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Silence"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, minion3));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, silence, minion3));
			Assert.False(minion3.Controller == game.CurrentPlayer);

			IPlayable testCard4 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Potion of Madness"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard4, minion3));
			Assert.True(minion3.Controller == game.CurrentPlayer);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.True(minion3.Controller == game.CurrentPlayer);
		}

		// ----------------------------------------- SPELL - PRIEST
		// [CFM_604] Greater Healing Potion - COST:4 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: Restore 12 Health to a friendly character.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GreaterHealingPotion_CFM_604()
		{
			// TODO GreaterHealingPotion_CFM_604 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Greater Healing Potion"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [CFM_661] Pint-Size Potion - COST:1 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]Give all enemy minions
		//       -3 Attack this turn only.
		// --------------------------------------------------------
		[Fact]
		public void PintSizePotion_CFM_661()
		{
			// TODO PintSizePotion_CFM_661 test
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
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Magma Rager"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ironfur Grizzly"));
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("River Crocolisk"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(5, ((Minion)minion1).AttackDamage);
			Assert.Equal(3, ((Minion)minion2).AttackDamage);
			Assert.Equal(2, ((Minion)minion3).AttackDamage);
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pint-Size Potion"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(2, ((Minion)minion1).AttackDamage);
			Assert.Equal(0, ((Minion)minion2).AttackDamage);
			Assert.Equal(0, ((Minion)minion3).AttackDamage);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(5, ((Minion)minion1).AttackDamage);
			Assert.Equal(3, ((Minion)minion2).AttackDamage);
			Assert.Equal(2, ((Minion)minion3).AttackDamage);
		}

		// ----------------------------------------- SPELL - PRIEST
		// [CFM_662] Dragonfire Potion - COST:6 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]Deal $5 damage to all
		//       minions except Dragons. *spelldmg
		// --------------------------------------------------------
		[Fact]
		public void DragonfirePotion_CFM_662()
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
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Water Elemental"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ironfur Grizzly"));
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("River Crocolisk"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion4 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Faerie Dragon"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion4));
			Assert.Equal(6, ((Minion)minion1).Health);
			Assert.Equal(3, ((Minion)minion2).Health);
			Assert.Equal(3, ((Minion)minion3).Health);
			Assert.Equal(2, ((Minion)minion4).Health);
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragonfire Potion"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(1, ((Minion)minion1).Health);
			Assert.True(((Minion)minion2).IsDead);
			Assert.True(((Minion)minion3).IsDead);
			Assert.Equal(2, ((Minion)minion4).Health);
		}

		// ---------------------------------------- MINION - PRIEST
		// [CFM_020] Raza the Chained - COST:5 [ATK:5/HP:5] 
		// - Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]  <b>Battlecry:</b> If your deck has  
		//       no duplicates, your Hero
		//        Power costs (1) this game.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void RazaTheChained_CFM_020()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Raza the Chained"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentPlayer.Hero));
			Assert.Equal(4, game.CurrentPlayer.RemainingMana);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable death = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadow Word: Death"));
			IPlayable mindControl = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mind Control"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, mindControl, testCard));
			game.CurrentPlayer.UsedMana = 0;
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, death, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentPlayer.Hero));
			Assert.Equal(9, game.CurrentPlayer.RemainingMana);
			IPlayable shadowreaperAnduin = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadowreaper Anduin"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, shadowreaperAnduin));
			Assert.Equal(1, game.CurrentPlayer.RemainingMana);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(0, game.CurrentPlayer.RemainingMana);
			game.CurrentPlayer.UsedMana = 0;
			IPlayable shadowform = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadowform"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, shadowform));
			Assert.Equal(7, game.CurrentPlayer.RemainingMana);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(6, game.CurrentPlayer.RemainingMana);
		}

		// ---------------------------------------- MINION - PRIEST
		// [CFM_605] Drakonid Operative - COST:5 [ATK:5/HP:6] 
		// - Race: dragon, Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If you're holding a
		//       Dragon, <b>Discover</b> a card in
		//       _your opponent's deck.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TREASURE = 1
		// --------------------------------------------------------
		[Fact]
		public void DrakonidOperative_CFM_605()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Drakonid Operative"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			int choice = game.CurrentPlayer.Choice.Choices[0];
			game.Process(ChooseTask.Pick(game.CurrentPlayer, choice));
			Assert.True(game.CurrentOpponent.DeckZone.Any(p => p.Card.Id == game.IdEntityDic[choice].Card.Id));
		}

		// ---------------------------------------- MINION - PRIEST
		// [CFM_606] Mana Geode - COST:2 [ATK:2/HP:3] 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: Whenever this minion is_healed, summon a 2/2_Crystal.
		// --------------------------------------------------------
		[Fact]
		public void ManaGeode_CFM_606()
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
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mana Geode"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, testCard));
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
		}

		// ---------------------------------------- MINION - PRIEST
		// [CFM_626] Kabal Talonpriest - COST:3 [ATK:3/HP:4] 
		// - Set: gangs, Rarity: common
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
		[Fact]
		public void KabalTalonpriest_CFM_626()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kabal Talonpriest"));
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mana Geode"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard, minion));
			Assert.Equal(6, ((Minion)minion).Health);
		}

		// ---------------------------------------- MINION - PRIEST
		// [CFM_657] Kabal Songstealer - COST:5 [ATK:5/HP:5] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> <b>Silence</b> a minion.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NONSELF_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - SILENCE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KabalSongstealer_CFM_657()
		{
			// TODO KabalSongstealer_CFM_657 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Kabal Songstealer"));
		}
	}


	public class RogueGangsTest
	{
		// ------------------------------------------ SPELL - ROGUE
		// [CFM_630] Counterfeit Coin - COST:0 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: Gain 1 Mana Crystal this turn only.
		// --------------------------------------------------------
		[Fact]
		public void CounterfeitCoin_CFM_630()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Counterfeit Coin"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(2, game.CurrentPlayer.RemainingMana);
		}

		// ------------------------------------------ SPELL - ROGUE
		// [CFM_690] Jade Shuriken - COST:2 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $2 damage.
		//       <b>Combo:</b> Summon a{1} {0} <b>Jade Golem</b>.@Deal $2 damage.
		//       <b>Combo:</b> Summon a <b>Jade Golem</b>. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - JADE_GOLEM = 1
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JadeShuriken_CFM_690()
		{
			// TODO JadeShuriken_CFM_690 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Jade Shuriken"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [CFM_342] Luckydo Buccaneer - COST:6 [ATK:5/HP:5] 
		// - Race: pirate, Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your weapon has at least 3 Attack, gain +4/+4.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void LuckydoBuccaneer_CFM_342()
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
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Luckydo Buccaneer"));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Luckydo Buccaneer"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
			Assert.Equal(5, ((Minion)testCard1).AttackDamage);
			Assert.Equal(5, ((Minion)testCard1).Health);
			game.CurrentPlayer.UsedMana = 0;

			IPlayable weapon = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Assassin's Blade"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, weapon));
			game.CurrentPlayer.UsedMana = 0;
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
			Assert.Equal(9, ((Minion)testCard2).AttackDamage);
			Assert.Equal(9, ((Minion)testCard2).Health);
		}

		// ----------------------------------------- MINION - ROGUE
		// [CFM_634] Lotus Assassin - COST:5 [ATK:5/HP:5] 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Stealth</b>. Whenever this attacks and kills a minion, gain <b>Stealth</b>.
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact]
		public void LotusAssassin_CFM_634()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lotus Assassin"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			var minion2 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.True(((Minion)testCard).HasStealth);
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, testCard, minion2));
			Assert.True(((Minion)testCard).HasStealth);
		}

		// ----------------------------------------- MINION - ROGUE
		// [CFM_636] Shadow Rager - COST:3 [ATK:5/HP:1] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Stealth</b>
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShadowRager_CFM_636()
		{
			// TODO ShadowRager_CFM_636 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Shadow Rager"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [CFM_691] Jade Swarmer - COST:2 [ATK:1/HP:1] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Stealth</b>
		//       <b>Deathrattle:</b> Summon a{1} {0} <b>Jade Golem</b>.@<b>Stealth</b>
		//       <b>Deathrattle:</b> Summon a <b>Jade Golem</b>.
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		// RefTag:
		// - JADE_GOLEM = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JadeSwarmer_CFM_691()
		{
			// TODO JadeSwarmer_CFM_691 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Jade Swarmer"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [CFM_693] Gadgetzan Ferryman - COST:2 [ATK:2/HP:3] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Combo:</b> Return a friendly minion to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_FOR_COMBO = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void GadgetzanFerryman_CFM_693()
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
			var minion1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gadgetzan Ferryman"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard, minion1));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
		}

		// ----------------------------------------- MINION - ROGUE
		// [CFM_694] Shadow Sensei - COST:4 [ATK:4/HP:4] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a <b>Stealthed</b> minion +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_STEALTHED_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		// RefTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact]
		public void ShadowSensei_CFM_694()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadow Sensei"));
			var minion1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			var minion2 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Worgen Infiltrator"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard, minion1));
			Assert.Equal(1, ((Minion)minion1).AttackDamage);
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard, minion2));
			Assert.Equal(4, ((Minion)minion2).AttackDamage);
		}

		// ----------------------------------------- MINION - ROGUE
		// [CFM_781] Shaku, the Collector - COST:3 [ATK:2/HP:3] 
		// - Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Stealth</b>. Whenever this
		//       attacks, add a random card
		//       to your hand <i>(from your
		//       opponent's class).</i>
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact]
		public void ShakuTheCollector_CFM_781()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Shaku, the Collector"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, testCard, game.CurrentOpponent.Hero));
			Assert.Equal(CardClass.MAGE, game.CurrentPlayer.HandZone[0].Card.Class);
		}
	}


	public class ShamanGangsTest
	{
		// ----------------------------------------- SPELL - SHAMAN
		// [CFM_310] Call in the Finishers - COST:4 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: Summon four 1/1 Murlocs.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CallInTheFinishers_CFM_310()
		{
			// TODO CallInTheFinishers_CFM_310 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Call in the Finishers"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [CFM_313] Finders Keepers - COST:1 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Discover</b> a card with_<b>Overload</b>. <b>Overload:</b> (1)
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 1
		// - OVERLOAD_OWED = 1
		// --------------------------------------------------------
		// RefTag:
		// - TREASURE = 1
		// --------------------------------------------------------
		[Fact]
		public void FindersKeepers_CFM_313()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Finders Keepers"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.True(game.CurrentPlayer.Choice != null);
			Assert.True(game.IdEntityDic[game.CurrentPlayer.Choice.Choices[0]].Card.HasOverload);
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [CFM_696] Devolve - COST:2 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: Transform all enemy minions into random ones that cost (1) less.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_HERO_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void Devolve_CFM_696()
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

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Devolve"));
			Assert.Equal(6, game.CurrentOpponent.BoardZone.Sum(p => p.Card.Cost));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(3, game.CurrentOpponent.BoardZone.Sum(p => p.Card.Cost));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [CFM_707] Jade Lightning - COST:4 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $4 damage. Summon a{1} {0} <b>Jade Golem</b>.@Deal $4 damage. Summon a <b>Jade Golem</b>. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		// RefTag:
		// - JADE_GOLEM = 1
		// --------------------------------------------------------
		[Fact]
		public void JadeLightning_CFM_707()
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

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jade Lightning"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, game.CurrentOpponent.Hero));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal("CFM_712_t01", game.CurrentPlayer.BoardZone[0].Card.Id);
			Assert.Equal(1, game.CurrentPlayer.BoardZone[0].AttackDamage);
			Assert.Equal(1, game.CurrentPlayer.BoardZone[0].Health);
			Assert.Equal(26, game.CurrentOpponent.Hero.Health);

			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jade Lightning"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, game.CurrentOpponent.Hero));
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal("CFM_712_t02", game.CurrentPlayer.BoardZone[1].Card.Id);
			Assert.Equal(2, game.CurrentPlayer.BoardZone[1].AttackDamage);
			Assert.Equal(2, game.CurrentPlayer.BoardZone[1].Health);
			Assert.Equal(22, game.CurrentOpponent.Hero.Health);
		}

		// ---------------------------------------- MINION - SHAMAN
		// [CFM_061] Jinyu Waterspeaker - COST:4 [ATK:3/HP:6] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Restore 6 Health.
		//       <b>Overload:</b> (1)
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 1
		// - BATTLECRY = 1
		// - OVERLOAD_OWED = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JinyuWaterspeaker_CFM_061()
		{
			// TODO JinyuWaterspeaker_CFM_061 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Jinyu Waterspeaker"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [CFM_312] Jade Chieftain - COST:7 [ATK:5/HP:5] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a{1} {0} <b>Jade Golem</b>. Give it <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// - JADE_GOLEM = 1
		// --------------------------------------------------------
		[Fact]
		public void JadeChieftain_CFM_312()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jade Chieftain"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.True(game.CurrentPlayer.BoardZone[1].HasTaunt);
		}

		// ---------------------------------------- MINION - SHAMAN
		// [CFM_324] White Eyes - COST:5 [ATK:5/HP:5] 
		// - Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Deathrattle:</b> Shuffle
		//       'The Storm Guardian' into your deck.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - TAUNT = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void WhiteEyes_CFM_324()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>() { },
				Player2HeroClass = CardClass.MAGE,
				FillDecks = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("White Eyes"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, testCard));
			Assert.Equal(1, game.CurrentOpponent.DeckZone.Count);
			Assert.Equal("CFM_324t", game.CurrentOpponent.DeckZone.TopCard.Card.Id);
		}

		// ---------------------------------------- MINION - SHAMAN
		// [CFM_697] Lotus Illusionist - COST:4 [ATK:3/HP:5] 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]After this minion attacks
		//       a hero, transform it into a
		//       _random 6-Cost minion.
		// --------------------------------------------------------
		[Fact]
		public void LotusIllusionist_CFM_697()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lotus Illusionist"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, testCard, minion));
			Assert.Equal(testCard.Card.Id, game.CurrentPlayer.BoardZone[0].Card.Id);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, testCard, game.CurrentOpponent.Hero));
			Assert.NotEqual(testCard.Card.Id, game.CurrentPlayer.BoardZone[0].Card.Id);
			Assert.Equal(6, game.CurrentPlayer.BoardZone[0].Cost);
		}

		// ---------------------------------------- WEAPON - SHAMAN
		// [CFM_717] Jade Claws - COST:2 [ATK:2/HP:0] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a{1} {0} <b>Jade Golem</b>.
		//       <b><b>Overload</b>:</b> (1)@<b>Battlecry:</b> Summon a <b>Jade Golem</b>.
		//       <b><b>Overload</b>:</b> (1)
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// - OVERLOAD = 1
		// - BATTLECRY = 1
		// - OVERLOAD_OWED = 1
		// --------------------------------------------------------
		// RefTag:
		// - JADE_GOLEM = 1
		// --------------------------------------------------------
		[Fact]
		public void JadeClaws_CFM_717()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jade Claws"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal("CFM_712_t01", game.CurrentPlayer.BoardZone[0].Card.Id);
			Assert.Equal(1, game.CurrentPlayer.BoardZone[0].AttackDamage);
			Assert.Equal(1, game.CurrentPlayer.BoardZone[0].Health);
			Assert.Equal(2, game.CurrentPlayer.Hero.Weapon.AttackDamage);
		}
	}


	public class WarlockGangsTest
	{
		// ---------------------------------------- SPELL - WARLOCK
		// [CFM_094] Felfire Potion - COST:6 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $5 damage to all characters. *spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FelfirePotion_CFM_094()
		{
			// TODO FelfirePotion_CFM_094 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Felfire Potion"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [CFM_608] Blastcrystal Potion - COST:4 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: Destroy a minion and one of your Mana Crystals.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BlastcrystalPotion_CFM_608()
		{
			// TODO BlastcrystalPotion_CFM_608 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Blastcrystal Potion"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [CFM_611] Bloodfury Potion - COST:3 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]Give a minion +3 Attack.
		//       If it's a Demon, also
		//       give it +3 Health.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BloodfuryPotion_CFM_611()
		{
			// TODO BloodfuryPotion_CFM_611 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bloodfury Potion"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [CFM_610] Crystalweaver - COST:4 [ATK:5/HP:4] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give your Demons +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Crystalweaver_CFM_610()
		{
			// TODO Crystalweaver_CFM_610 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Crystalweaver"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [CFM_663] Kabal Trafficker - COST:6 [ATK:6/HP:6] 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]At the end of your turn,
		//       add a random Demon
		//       to your hand.
		// --------------------------------------------------------
		[Fact]
		public void KabalTrafficker_CFM_663()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kabal Trafficker"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(4, game.CurrentPlayer.HandZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(5, game.CurrentOpponent.HandZone.Count);
			Assert.Equal(Race.DEMON, game.CurrentOpponent.HandZone[4].Card.Race);
		}

		// --------------------------------------- MINION - WARLOCK
		// [CFM_699] Seadevil Stinger - COST:4 [ATK:4/HP:2] 
		// - Race: murloc, Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> The next Murloc
		//       you play this turn costs
		//       _Health instead of Mana.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void SeadevilStinger_CFM_699()
		{
			// TODO take care of cost health animation
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 4;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Seadevil Stinger"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Raider"));
			game.AuraUpdate();
			Assert.True(minion.IsPlayableByPlayer);
			//Assert.Equal(0, minion.Cost);
			int mana = game.CurrentPlayer.RemainingMana;
			int health = game.CurrentPlayer.Hero.Health;
			int cost = minion.Cost;
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(mana, game.CurrentPlayer.RemainingMana);
			Assert.Equal(health - cost, game.CurrentPlayer.Hero.Health);
		}

		// --------------------------------------- MINION - WARLOCK
		// [CFM_750] Krul the Unshackled - COST:9 [ATK:7/HP:9] 
		// - Race: demon, Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If your deck has
		//       no duplicates, summon all
		//       _Demons from your hand._
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void KrulTheUnshackled_CFM_750()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Voidwalker"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Flame Imp"),
					Cards.FromName("Bloodfen Raptor"),
					Cards.FromName("River Crocolisk"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = false,
				Shuffle = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Krul the Unshackled"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(30, game.CurrentPlayer.Hero.Health);
		}

		// --------------------------------------- MINION - WARLOCK
		// [CFM_751] Abyssal Enforcer - COST:7 [ATK:6/HP:6] 
		// - Race: demon, Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 3 damage to all other characters.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AbyssalEnforcer_CFM_751()
		{
			// TODO AbyssalEnforcer_CFM_751 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Abyssal Enforcer"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [CFM_900] Unlicensed Apothecary - COST:3 [ATK:5/HP:5] 
		// - Race: demon, Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: Whenever you summon a minion, deal 5 damage to_your Hero.
		// --------------------------------------------------------
		[Fact]
		public void UnlicensedApothecary_CFM_900()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unlicensed Apothecary"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(25, game.CurrentPlayer.Hero.Health);
		}
	}


	public class WarriorGangsTest
	{
		// ---------------------------------------- SPELL - WARRIOR
		// [CFM_716] Sleep with the Fishes - COST:2 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: Deal $3 damage to all damaged minions. *spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SleepWithTheFishes_CFM_716()
		{
			// TODO SleepWithTheFishes_CFM_716 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sleep with the Fishes"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [CFM_752] Stolen Goods - COST:2 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: Give a random <b>Taunt</b> minion in your hand +3/+3.
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StolenGoods_CFM_752()
		{
			// TODO StolenGoods_CFM_752 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stolen Goods"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [CFM_940] I Know a Guy - COST:1 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Discover</b> a <b>Taunt</b> minion.
		// --------------------------------------------------------
		// GameTag:
		// - TREASURE = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact]
		public void IKnowAGuy_CFM_940()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("I Know a Guy"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.True(game.CurrentPlayer.Choice != null);
			Assert.True(game.IdEntityDic[game.CurrentPlayer.Choice.Choices[0]][GameTag.TAUNT] == 1);
		}

		// --------------------------------------- MINION - WARRIOR
		// [CFM_300] Public Defender - COST:2 [ATK:0/HP:7] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PublicDefender_CFM_300()
		{
			// TODO PublicDefender_CFM_300 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Public Defender"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [CFM_643] Hobart Grapplehammer - COST:2 [ATK:2/HP:2] 
		// - Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give all weapons in your hand and deck +1 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void HobartGrapplehammer_CFM_643()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hobart Grapplehammer"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			var weaponsHand = game.CurrentPlayer.HandZone.Where(p => p is Weapon).ToList();
			if (weaponsHand.Any())
			{
				int count = weaponsHand.Count();
				int nAtk = weaponsHand.Sum(p => ((Weapon)p).AttackDamage);
				int oAtk = weaponsHand.Sum(p => ((Weapon)p).Card[GameTag.ATK]);
				Assert.Equal(oAtk + count, nAtk);
			}
			var weaponsDeck = game.CurrentPlayer.DeckZone.Where(p => p is Weapon).ToList();
			if (weaponsDeck.Any())
			{
				int count = weaponsDeck.Count();
				int nAtk = weaponsDeck.Sum(p => ((Weapon)p).AttackDamage);
				int oAtk = weaponsDeck.Sum(p => ((Weapon)p).Card[GameTag.ATK]);
				Assert.Equal(oAtk + count, nAtk);
			}
		}

		// --------------------------------------- MINION - WARRIOR
		// [CFM_754] Grimy Gadgeteer - COST:4 [ATK:4/HP:3] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: At the end of your turn, give a random minion in your hand +2/+2.
		// --------------------------------------------------------
		[Fact]
		public void GrimyGadgeteer_CFM_754()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grimy Gadgeteer"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			int totAtk = game.CurrentPlayer.HandZone.Where(p => p.Card.Type == CardType.MINION)
				.Sum(p => ((Minion)p).AttackDamage);
			int totHp = game.CurrentPlayer.HandZone.Where(p => p.Card.Type == CardType.MINION)
				.Sum(p => ((Minion)p).Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(totAtk != 0 ? totAtk + 2 : 0,
				game.CurrentOpponent.HandZone.Where(p => p.Card.Type == CardType.MINION)
					.Sum(p => ((Minion)p).AttackDamage));
			Assert.Equal(totHp != 0 ? totHp + 2 : 0,
				game.CurrentOpponent.HandZone.Where(p => p.Card.Type == CardType.MINION)
					.Sum(p => ((Minion)p).Health));
		}

		// --------------------------------------- MINION - WARRIOR
		// [CFM_755] Grimestreet Pawnbroker - COST:3 [ATK:3/HP:3] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a random weapon in your hand +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void GrimestreetPawnbroker_CFM_755()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Fiery War Axe"),
					Cards.FromName("Grimestreet Pawnbroker"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Bloodfen Raptor"),
					Cards.FromName("Bloodfen Raptor"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			Assert.Equal(3, ((Weapon)game.CurrentPlayer.HandZone[0]).AttackDamage);
			Assert.Equal(2, ((Weapon)game.CurrentPlayer.HandZone[0]).Durability);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Grimestreet Pawnbroker"));
			Assert.Equal(4, ((Weapon)game.CurrentPlayer.HandZone[0]).AttackDamage);
			Assert.Equal(3, ((Weapon)game.CurrentPlayer.HandZone[0]).Durability);
		}

		// --------------------------------------- MINION - WARRIOR
		// [CFM_756] Alley Armorsmith - COST:5 [ATK:2/HP:7] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       Whenever this minion
		//       deals damage, gain
		//       that much Armor.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact]
		public void AlleyArmorsmith_CFM_756()
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Alley Armorsmith"));

			Minion testCard = game.ProcessCard<Minion>("Alley Armorsmith");
			game.EndTurn();

			IPlayable minion = game.ProcessCard("Stonetusk Boar");
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion, testCard));

			Assert.Equal(2, game.CurrentOpponent.Hero.Armor);

			game.EndTurn();

			game.ProcessCard("Rampage", testCard);
			Assert.Equal(5, testCard.AttackDamage);

			game.Process(MinionAttackTask.Any(game.CurrentPlayer, testCard, game.CurrentOpponent.Hero));
			Assert.Equal(7, game.CurrentPlayer.Hero.Armor);
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [CFM_631] Brass Knuckles - COST:4 [ATK:2/HP:0] 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]After your hero attacks,
		//       give a random minion in
		//       your hand +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 3
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BrassKnuckles_CFM_631()
		{
			// TODO BrassKnuckles_CFM_631 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Brass Knuckles"));
		}
	}


	public class NeutralGangsTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [CFM_025] Wind-up Burglebot - COST:6 [ATK:5/HP:5] 
		// - Race: mechanical, Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: Whenever this attacks a minion and survives, draw_a card.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		[Fact]
		public void WindUpBurglebot_CFM_025()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wind-up Burglebot"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, testCard, minion));
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_039] Street Trickster - COST:3 [ATK:0/HP:7] 
		// - Race: demon, Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Spell Damage +1</b>
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StreetTrickster_CFM_039()
		{
			// TODO StreetTrickster_CFM_039 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Street Trickster"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_060] Red Mana Wyrm - COST:5 [ATK:2/HP:6] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever  you cast a spell, gain +2 Attack.
		// --------------------------------------------------------
		[Fact]
		public void RedManaWyrm_CFM_060()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Red Mana Wyrm"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, game.CurrentPlayer.HandZone[4]));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(4, ((Minion)testCard).AttackDamage);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(4, ((Minion)testCard).AttackDamage);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_063] Kooky Chemist - COST:4 [ATK:4/HP:4] 
		// - Set: gangs, Rarity: common
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
		public void KookyChemist_CFM_063()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kooky Chemist"));
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
		// [CFM_064] Blubber Baron - COST:3 [ATK:1/HP:1] 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: Whenever you summon a <b>Battlecry</b> minion while this_is in your hand, gain_+1/+1.
		// --------------------------------------------------------
		// RefTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void BlubberBaron_CFM_064()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blubber Baron"));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Novice Engineer"));
			Assert.Equal(1, ((Minion)testCard).AttackDamage);
			Assert.Equal(1, ((Minion)testCard).Health);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			Assert.Equal(1, ((Minion)testCard).AttackDamage);
			Assert.Equal(1, ((Minion)testCard).Health);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			Assert.Equal(2, ((Minion)testCard).AttackDamage);
			Assert.Equal(2, ((Minion)testCard).Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_067] Hozen Healer - COST:4 [ATK:2/HP:6] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry</b>: Restore a minion to full Health.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HozenHealer_CFM_067()
		{
			// TODO HozenHealer_CFM_067 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Hozen Healer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_095] Weasel Tunneler - COST:1 [ATK:1/HP:1] 
		// - Race: beast, Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Shuffle this minion into your opponent's deck.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WeaselTunneler_CFM_095()
		{
			// TODO WeaselTunneler_CFM_095 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Weasel Tunneler"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_120] Mistress of Mixtures - COST:1 [ATK:2/HP:2] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Restore 4 Health to both players.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void MistressOfMixtures_CFM_120()
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
			game.Player1.Hero.Damage = 10;
			game.Player2.Hero.Damage = 10;
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mistress of Mixtures"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadow Word: Pain"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, testCard));
			Assert.Equal(24, game.Player1.Hero.Health);
			Assert.Equal(24, game.Player2.Hero.Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_321] Grimestreet Informant - COST:2 [ATK:1/HP:1] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> <b>Discover</b> a
		//       Hunter, Paladin, or Warrior
		//       card.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - MULTIPLE_CLASSES = 532
		// - MULTI_CLASS_GROUP = 1
		// - GRIMY_GOONS = 1
		// --------------------------------------------------------
		// RefTag:
		// - TREASURE = 1
		// --------------------------------------------------------
		[Fact]
		public void GrimestreetInformant_CFM_321()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grimestreet Informant"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.True(game.CurrentPlayer.Choice != null);
			Card card1 = game.IdEntityDic[game.CurrentPlayer.Choice.Choices[0]].Card;
			Card card2 = game.IdEntityDic[game.CurrentPlayer.Choice.Choices[1]].Card;
			Card card3 = game.IdEntityDic[game.CurrentPlayer.Choice.Choices[2]].Card;
			Assert.True(card1.Class == CardClass.HUNTER || card1.MultiClassGroup > 0);
			Assert.True(card2.Class == CardClass.PALADIN || card2.MultiClassGroup > 0);
			Assert.True(card3.Class == CardClass.WARRIOR || card3.MultiClassGroup > 0);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_325] Small-Time Buccaneer - COST:1 [ATK:1/HP:2] 
		// - Race: pirate, Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: Has +2 Attack while you have a weapon equipped.
		// --------------------------------------------------------
		[Fact]
		public void SmallTimeBuccaneer_CFM_325()
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
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Small-Time Buccaneer"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			Assert.Equal(1, ((Minion)minion1).AttackDamage);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			Assert.Equal(1, game.CurrentPlayer.Hero.Weapon.AttackDamage);
			Assert.Equal(3, ((Minion)minion1).AttackDamage);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_328] Fight Promoter - COST:6 [ATK:4/HP:4] 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If you control
		//       a minion with 6 or more
		//       _Health, draw two cards.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FightPromoter_CFM_328()
		{
			// TODO FightPromoter_CFM_328 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Fight Promoter"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_341] Sergeant Sally - COST:3 [ATK:1/HP:1] 
		// - Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Deal damage equal to this minion's Attack to all enemy minions.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SergeantSally_CFM_341()
		{
			// TODO SergeantSally_CFM_341 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Sergeant Sally"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_344] Finja, the Flying Star - COST:5 [ATK:2/HP:4] 
		// - Race: murloc, Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Stealth</b>
		//          Whenever this attacks and   
		//       kills a minion, summon 2
		//       _Murlocs from your deck.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact]
		public void FinjaTheFlyingStar_CFM_344()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bloodfen Raptor"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Oasis Snapjaw"),
					Cards.FromName("Novice Engineer"),
					Cards.FromName("Bluegill Warrior"),
					Cards.FromName("Bluegill Warrior"),
					Cards.FromName("Murloc Warleader"),
					Cards.FromName("Murloc Warleader")
				},
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = true,
				FillDecksPredictably = true,
				Shuffle = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Finja, the Flying Star"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, testCard, game.CurrentOpponent.Hero));
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, testCard, game.CurrentOpponent.BoardZone[0]));
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_609] Fel Orc Soulfiend - COST:3 [ATK:3/HP:7] 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: At the start of your turn, deal 2 damage to this_minion.
		// --------------------------------------------------------
		[Fact]
		public void FelOrcSoulfiend_CFM_609()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fel Orc Soulfiend"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(7, ((Minion)testCard).Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(7, ((Minion)testCard).Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(5, ((Minion)testCard).Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_619] Kabal Chemist - COST:4 [ATK:3/HP:3] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add a random Potion to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - MULTIPLE_CLASSES = 296
		// - MULTI_CLASS_GROUP = 3
		// - KABAL = 1
		// --------------------------------------------------------
		[Fact]
		public void KabalChemist_CFM_619()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kabal Chemist"));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			Assert.Contains("Potion", game.CurrentPlayer.HandZone[4].Card.Name);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_621] Kazakus - COST:4 [ATK:3/HP:3] 
		// - Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If your deck
		//       has no duplicates,
		//       _create a custom spell.
		// --------------------------------------------------------
		// Entourage: CFM_621t11, CFM_621t12, CFM_621t13
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - MULTIPLE_CLASSES = 296
		// - MULTI_CLASS_GROUP = 3
		// - KABAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Kazakus_CFM_621()
		{
			// TODO Kazakus_CFM_621 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			// Polymorph > AoE         > Freeze    > Resurrect > Demon          > Damage           > Armor            > Health Buff > Draw Cards > Draw Demons
			//             Felbloom[2] > Icecap[8]               Netherbloom[2] > Heart of Fire[5] > Stonescale Oil[6]
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Kazakus"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_637] Patches the Pirate - COST:1 [ATK:1/HP:1] 
		// - Race: pirate, Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]After you play a Pirate,
		//       summon this minion
		//       from your deck.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact]
		public void PatchesThePirate_CFM_637()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card> { Cards.FromName("Patches the Pirate") },
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodsail Cultist"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			if (game.CurrentPlayer.HandZone.Any(p => p.Card.Name.Equals("Patches the Pirate")))
			{
				Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
				//Assert.Equal(0, game.CurrentPlayer.BoardZone.Triggers.Count);
			}
			else
			{
				Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
				game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
				Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
			}
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_646] Backstreet Leper - COST:3 [ATK:3/HP:1] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Deathrattle:</b> Deal 2 damage
		//       to the enemy hero.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BackstreetLeper_CFM_646()
		{
			// TODO BackstreetLeper_CFM_646 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Backstreet Leper"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_647] Blowgill Sniper - COST:2 [ATK:2/HP:1] 
		// - Race: murloc, Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 1 damage.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BlowgillSniper_CFM_647()
		{
			// TODO BlowgillSniper_CFM_647 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Blowgill Sniper"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_648] Big-Time Racketeer - COST:6 [ATK:1/HP:1] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 6/6_Ogre.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BigTimeRacketeer_CFM_648()
		{
			// TODO BigTimeRacketeer_CFM_648 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Big-Time Racketeer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_649] Kabal Courier - COST:3 [ATK:2/HP:2] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Discover</b> a Mage, Priest, or Warlock card.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - MULTIPLE_CLASSES = 296
		// - MULTI_CLASS_GROUP = 3
		// - KABAL = 1
		// --------------------------------------------------------
		// RefTag:
		// - TREASURE = 1
		// --------------------------------------------------------
		[Fact]
		public void KabalCourier_CFM_649()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kabal Courier"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.True(game.CurrentPlayer.Choice != null);
			Card card1 = game.IdEntityDic[game.CurrentPlayer.Choice.Choices[0]].Card;
			Card card2 = game.IdEntityDic[game.CurrentPlayer.Choice.Choices[1]].Card;
			Card card3 = game.IdEntityDic[game.CurrentPlayer.Choice.Choices[2]].Card;
			Assert.True(card1.Class == CardClass.MAGE || card1.MultiClassGroup > 0);
			Assert.True(card2.Class == CardClass.PRIEST || card2.MultiClassGroup > 0);
			Assert.True(card3.Class == CardClass.WARLOCK || card3.MultiClassGroup > 0);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_651] Naga Corsair - COST:4 [ATK:5/HP:4] 
		// - Race: pirate, Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give your weapon +1 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void NagaCorsair_CFM_651()
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

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Naga Corsair"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

			Assert.Null(game.CurrentPlayer.Hero.Weapon);

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));

			Assert.Equal(1, game.CurrentPlayer.Hero.TotalAttackDamage);

			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Naga Corsair"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));

			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));

			Assert.Equal(2, game.CurrentPlayer.Hero.Weapon.AttackDamage);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_652] Second-Rate Bruiser - COST:5 [ATK:4/HP:5] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       Costs (2) less if your
		//       opponent has at least
		//       three minions.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact]
		public void SecondRateBruiser_CFM_652()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Second-Rate Bruiser"));
			Assert.Equal(5, testCard.Cost);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			Assert.Equal(3, testCard.Cost);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_653] Hired Gun - COST:3 [ATK:4/HP:3] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HiredGun_CFM_653()
		{
			// TODO HiredGun_CFM_653 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Hired Gun"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_654] Friendly Bartender - COST:2 [ATK:2/HP:3] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: At the end of your turn, restore 1 Health to your_hero.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FriendlyBartender_CFM_654()
		{
			// TODO FriendlyBartender_CFM_654 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Friendly Bartender"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_655] Toxic Sewer Ooze - COST:3 [ATK:4/HP:3] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Remove 1 Durability from your opponent's weapon.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ToxicSewerOoze_CFM_655()
		{
			// TODO ToxicSewerOoze_CFM_655 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Toxic Sewer Ooze"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_656] Streetwise Investigator - COST:5 [ATK:4/HP:6] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Enemy minions lose <b>Stealth</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StreetwiseInvestigator_CFM_656()
		{
			// TODO StreetwiseInvestigator_CFM_656 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Streetwise Investigator"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_658] Backroom Bouncer - COST:4 [ATK:4/HP:4] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever a friendly minion dies, gain +1 Attack.
		// --------------------------------------------------------
		[Fact]
		public void BackroomBouncer_CFM_658()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Backroom Bouncer"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			var minion1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(4, ((Minion)testCard).AttackDamage);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, minion1));
			Assert.Equal(5, ((Minion)testCard).AttackDamage);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_659] Gadgetzan Socialite - COST:2 [ATK:2/HP:2] 
		// - Set: gangs, Rarity: common
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
		public void GadgetzanSocialite_CFM_659()
		{
			// TODO GadgetzanSocialite_CFM_659 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Gadgetzan Socialite"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_665] Worgen Greaser - COST:4 [ATK:6/HP:3] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WorgenGreaser_CFM_665()
		{
			// TODO WorgenGreaser_CFM_665 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Worgen Greaser"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_666] Grook Fu Master - COST:5 [ATK:3/HP:5] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Windfury</b>
		// --------------------------------------------------------
		// GameTag:
		// - WINDFURY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GrookFuMaster_CFM_666()
		{
			// TODO GrookFuMaster_CFM_666 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Grook Fu Master"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_667] Bomb Squad - COST:5 [ATK:2/HP:2] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Deal 5 damage
		//       to an enemy minion.
		//       <b>Deathrattle:</b> Deal 5 damage
		//       to your hero.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_ENEMY_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BombSquad_CFM_667()
		{
			// TODO BombSquad_CFM_667 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Bomb Squad"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_668] Doppelgangster - COST:5 [ATK:2/HP:2] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon 2 copies of this minion.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void Doppelgangster_CFM_668()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Doppelgangster"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Stonetusk Boar"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Doppelgangster", null, 1));

			Assert.Equal(5, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal("Stonetusk Boar", game.CurrentPlayer.BoardZone[0].Card.Name);
			Assert.Equal("Doppelgangster", game.CurrentPlayer.BoardZone[1].Card.Name);
			Assert.Equal("Doppelgangster", game.CurrentPlayer.BoardZone[2].Card.Name);
			Assert.Equal("Doppelgangster", game.CurrentPlayer.BoardZone[3].Card.Name);
			Assert.Equal("Stonetusk Boar", game.CurrentPlayer.BoardZone[4].Card.Name);

			Assert.Equal(9, game.CurrentPlayer.BoardZone[0].Id);
			Assert.Equal(69, game.CurrentPlayer.BoardZone[1].Id);
			Assert.Equal(10, game.CurrentPlayer.BoardZone[2].Id);
			Assert.Equal(70, game.CurrentPlayer.BoardZone[3].Id);
			Assert.Equal(8, game.CurrentPlayer.BoardZone[4].Id);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_669] Burgly Bully - COST:5 [ATK:4/HP:6] 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: Whenever your opponent casts a spell, add a Coin to your hand.
		// --------------------------------------------------------
		[Fact]
		public void BurglyBully_CFM_669()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Burgly Bully"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, game.CurrentPlayer.HandZone[4]));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			Assert.Equal("GAME_005", game.CurrentOpponent.HandZone[4].Card.Id);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_670] Mayor Noggenfogger - COST:9 [ATK:5/HP:4] 
		// - Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: All targets are chosen randomly.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MayorNoggenfogger_CFM_670()
		{
			// TODO MayorNoggenfogger_CFM_670 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Mayor Noggenfogger"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_672] Madam Goya - COST:6 [ATK:4/HP:3] 
		// - Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Choose a friendly minion. Swap it with a minion in your deck.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact]
		public void MadamGoya_CFM_672()
		{
			// TODO MadamGoya_CFM_672 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Arcane Missiles"),
					Cards.FromName("Arcane Missiles"),
					Cards.FromName("Arcane Missiles"),
					Cards.FromName("Arcane Missiles"),
					Cards.FromName("Wisp"),
				},
				Player2HeroClass = CardClass.MAGE,
				FillDecks = false,
				Shuffle = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;


			IPlayable target = game.ProcessCard("Stonetusk Boar");
			game.ProcessCard("Madam Goya", target);
			Assert.Equal("Wisp", game.CurrentPlayer.BoardZone[1].Card.Name);
			Assert.Equal(1, game.CurrentPlayer.DeckZone.Count);
			Assert.Equal("Stonetusk Boar", game.CurrentPlayer.DeckZone[0].Card.Name);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_685] Don Han'Cho - COST:7 [ATK:5/HP:6] 
		// - Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a random minion in your hand +5/+5.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - MULTIPLE_CLASSES = 532
		// - MULTI_CLASS_GROUP = 1
		// - GRIMY_GOONS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DonHancho_CFM_685()
		{
			// TODO DonHancho_CFM_685 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Don Han'Cho"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_688] Spiked Hogrider - COST:5 [ATK:5/HP:5] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If an enemy minion has <b>Taunt</b>, gain_<b>Charge</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact]
		public void SpikedHogrider_CFM_688()
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
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spiked Hogrider"));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spiked Hogrider"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
			Assert.False(((Minion)testCard1).HasCharge);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Goldshire Footman"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
			Assert.True(((Minion)testCard2).HasCharge);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_715] Jade Spirit - COST:4 [ATK:2/HP:3] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a{1} {0} <b>Jade_Golem</b>.@<b>Battlecry:</b> Summon a <b>Jade_Golem</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - JADE_GOLEM = 1
		// - MULTIPLE_CLASSES = 194
		// - MULTI_CLASS_GROUP = 2
		// - JADE_LOTUS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JadeSpirit_CFM_715()
		{
			// TODO JadeSpirit_CFM_715 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Jade Spirit"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_790] Dirty Rat - COST:2 [ATK:2/HP:6] 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       <b>Battlecry:</b> Your opponent
		//       summons a random minion
		//       from their hand.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void DirtyRat_CFM_790()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dirty Rat"));
			Assert.Equal(5, game.CurrentOpponent.HandZone.Count);
			bool hasMinion = game.CurrentOpponent.HandZone.Any(p => p is Minion);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(hasMinion ? 1 : 0, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal(hasMinion ? 4 : 5, game.CurrentOpponent.HandZone.Count);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_806] Wrathion - COST:6 [ATK:4/HP:5] 
		// - Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Taunt</b>. <b>Battlecry:</b> Draw cards until you draw one that isn't a Dragon.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void Wrathion_CFM_806()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Faerie Dragon"),
					Cards.FromName("Faerie Dragon"),
					Cards.FromName("Faerie Dragon"),
					Cards.FromName("Faerie Dragon"),
					Cards.FromName("Faerie Dragon"),
					Cards.FromName("Faerie Dragon"),
					Cards.FromName("Faerie Dragon"),
					Cards.FromName("Faerie Dragon"),
					Cards.FromName("Faerie Dragon"),
					Cards.FromName("Wisp")
				},
				Player2HeroClass = CardClass.MAGE,
				FillDecks = false,
				FillDecksPredictably = true,
				Shuffle = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.ProcessCard("Wrathion");
			Assert.Equal(10, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(0, game.CurrentPlayer.Hero.Damage);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_807] Auctionmaster Beardo - COST:3 [ATK:3/HP:4] 
		// - Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: After you cast a spell, refresh your Hero Power.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact]
		public void AuctionmasterBeardo_CFM_807()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Auctionmaster Beardo"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(29, game.CurrentOpponent.Hero.Health);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(29, game.CurrentOpponent.Hero.Health);
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostbolt"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, game.CurrentOpponent.Hero));
			Assert.Equal(26, game.CurrentOpponent.Hero.Health);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(25, game.CurrentOpponent.Hero.Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_808] Genzo, the Shark - COST:4 [ATK:5/HP:4] 
		// - Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever this attacks, both players draw until they have 3 cards.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact]
		public void GenzoTheShark_CFM_808()
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
			game.Player1.HandZone.ToList().ForEach(p => Generic.DiscardBlock(game.Player1, p));
			game.Player2.HandZone.ToList().ForEach(p => Generic.DiscardBlock(game.Player2, p));
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Genzo, the Shark"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(1, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(1, game.CurrentOpponent.HandZone.Count);
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, testCard, game.CurrentOpponent.Hero));
			Assert.Equal(3, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(3, game.CurrentOpponent.HandZone.Count);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_809] Tanaris Hogchopper - COST:4 [ATK:4/HP:4] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If your opponent's
		//       hand is empty, gain <b>Charge</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact]
		public void TanarisHogchopper_CFM_809()
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
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tanaris Hogchopper"));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tanaris Hogchopper"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
			Assert.False(((Minion)testCard1).HasCharge);
			game.Player2.HandZone.ToList().ForEach(p => Generic.DiscardBlock(game.Player2, p));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
			Assert.True(((Minion)testCard2).HasCharge);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_810] Leatherclad Hogleader - COST:6 [ATK:6/HP:6] 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your opponent has 6 or more cards in hand, gain <b>Charge</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact]
		public void LeathercladHogleader_CFM_810()
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
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Leatherclad Hogleader"));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Leatherclad Hogleader"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
			Assert.False(((Minion)testCard1).HasCharge);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
			Assert.True(((Minion)testCard2).HasCharge);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_851] Daring Reporter - COST:4 [ATK:3/HP:3] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever your opponent draws a card, gain +1/+1.
		// --------------------------------------------------------
		[Fact]
		public void DaringReporter_CFM_851()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Daring Reporter"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(3, ((Minion)testCard).AttackDamage);
			Assert.Equal(3, ((Minion)testCard).Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(4, ((Minion)testCard).AttackDamage);
			Assert.Equal(4, ((Minion)testCard).Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(4, ((Minion)testCard).AttackDamage);
			Assert.Equal(4, ((Minion)testCard).Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(5, ((Minion)testCard).AttackDamage);
			Assert.Equal(5, ((Minion)testCard).Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_852] Lotus Agents - COST:5 [ATK:5/HP:3] 
		// - Set: gangs, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Discover</b> a Druid, Rogue, or Shaman card.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - MULTIPLE_CLASSES = 194
		// - MULTI_CLASS_GROUP = 2
		// - JADE_LOTUS = 1
		// --------------------------------------------------------
		// RefTag:
		// - TREASURE = 1
		// --------------------------------------------------------
		[Fact]
		public void LotusAgents_CFM_852()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lotus Agents"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.True(game.CurrentPlayer.Choice != null);
			Card card1 = game.IdEntityDic[game.CurrentPlayer.Choice.Choices[0]].Card;
			Card card2 = game.IdEntityDic[game.CurrentPlayer.Choice.Choices[1]].Card;
			Card card3 = game.IdEntityDic[game.CurrentPlayer.Choice.Choices[2]].Card;
			Assert.True(card1.Class == CardClass.DRUID || card1.MultiClassGroup > 0);
			Assert.True(card2.Class == CardClass.ROGUE || card2.MultiClassGroup > 0);
			Assert.True(card3.Class == CardClass.SHAMAN || card3.MultiClassGroup > 0);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_853] Grimestreet Smuggler - COST:3 [ATK:2/HP:4] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a random minion in your hand +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - MULTIPLE_CLASSES = 532
		// - MULTI_CLASS_GROUP = 1
		// - GRIMY_GOONS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GrimestreetSmuggler_CFM_853()
		{
			// TODO GrimestreetSmuggler_CFM_853 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Grimestreet Smuggler"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_854] Ancient of Blossoms - COST:6 [ATK:3/HP:8] 
		// - Set: gangs, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AncientOfBlossoms_CFM_854()
		{
			// TODO AncientOfBlossoms_CFM_854 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ancient of Blossoms"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_855] Defias Cleaner - COST:6 [ATK:5/HP:7] 
		// - Set: gangs, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Silence</b> a minion with <b>Deathrattle</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NONSELF_TARGET = 0
		// - REQ_TARGET_WITH_DEATHRATTLE = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// - SILENCE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DefiasCleaner_CFM_855()
		{
			// TODO DefiasCleaner_CFM_855 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Defias Cleaner"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [CFM_902] Aya Blackpaw - COST:6 [ATK:5/HP:3] 
		// - Set: gangs, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry and Deathrattle:</b> Summon a{1} {0} <b>Jade Golem</b>. @ <b>Battlecry and Deathrattle:</b> Summon a <b>Jade Golem</b>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// - BATTLECRY = 1
		// - JADE_GOLEM = 1
		// - MULTIPLE_CLASSES = 194
		// - MULTI_CLASS_GROUP = 2
		// - JADE_LOTUS = 1
		// --------------------------------------------------------
		[Fact]
		public void AyaBlackpaw_CFM_902()
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
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Aya Blackpaw"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal("CFM_712_t01", game.CurrentPlayer.BoardZone[1].Card.Id);
			Assert.Equal(1, game.CurrentPlayer.BoardZone[1].AttackDamage);
			Assert.Equal(1, game.CurrentPlayer.BoardZone[1].Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadow Word: Death"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, testCard));
			Assert.Equal(2, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal("CFM_712_t02", game.CurrentOpponent.BoardZone[0].Card.Id);
			Assert.Equal(2, game.CurrentOpponent.BoardZone[0].AttackDamage);
			Assert.Equal(2, game.CurrentOpponent.BoardZone[0].Health);
		}
	}
}
