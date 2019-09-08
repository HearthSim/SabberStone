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

using System;
using Xunit;
using SabberStoneCore.Enums;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Actions;
using SabberStoneCore.Auras;

namespace SabberStoneCoreTest.CardSets.Standard
{
	public class DruidDalaranTest
	{
		// ----------------------------------------- MINION - DRUID
		// [DAL_354] Acornbearer - COST:1 [ATK:2/HP:1] 
		// - Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Add two 1/1 Squirrels to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Acornbearer_DAL_354()
		{
			// TODO Acornbearer_DAL_354 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Acornbearer"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Acornbearer"));
			//Minion testCard = game.ProcessCard<Minion>("Acornbearer");
		}

		// ----------------------------------------- MINION - DRUID
		// [DAL_355] Lifeweaver - COST:3 [ATK:2/HP:5] 
		// - Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you restore Health, add a random Druid spell to your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Lifeweaver_DAL_355()
		{
			// TODO Lifeweaver_DAL_355 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lifeweaver"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lifeweaver"));
			//Minion testCard = game.ProcessCard<Minion>("Lifeweaver");
		}

		// ----------------------------------------- MINION - DRUID
		// [DAL_357] Lucentbark - COST:8 [ATK:4/HP:8] 
		// - Set: dalaran, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Deathrattle:</b> Go dormant. Restore 5 Health to awaken this minion.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - TAUNT = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void Lucentbark_DAL_357()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lucentbark"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lucentbark"));
			Minion testCard = game.ProcessCard<Minion>("Lucentbark");
			testCard.Kill();
			Assert.Single(game.CurrentPlayer.BoardZone);
			Assert.True(game.CurrentPlayer.BoardZone[0].Untouchable);

			game.CurrentPlayer.Hero.Damage = 10;

			game.ProcessCard("Regenerate", game.CurrentPlayer.Hero);
			Assert.True(game.CurrentPlayer.BoardZone[0].Untouchable);
			game.ProcessCard("Regenerate", game.CurrentPlayer.Hero);
			Assert.False(game.CurrentPlayer.BoardZone[0].Untouchable);
		}

		// ----------------------------------------- MINION - DRUID
		// [DAL_732] Keeper Stalladris - COST:2 [ATK:2/HP:3] 
		// - Set: dalaran, Rarity: legendary
		// --------------------------------------------------------
		// Text: After you cast a <b>Choose One</b> spell, add copies of both choices_to_your_hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact]
		public void KeeperStalladris_DAL_732()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Keeper Stalladris"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Keeper Stalladris"));
			Minion testCard = game.ProcessCard<Minion>("Keeper Stalladris");
			game.ProcessCard("Power of the Wild", chooseOne: 1);
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);

			Assert.Equal(2, game.CurrentPlayer.HandZone.Last().Cost);
			game.ProcessCard(game.CurrentPlayer.HandZone.Last());

			Assert.True(game.CurrentPlayer.BoardZone.ToList()
				.TrueForAll(p => p.AttackDamage == p.Card.ATK + 1 && p.Health == p.Card.Health + 1));
		}

		// ----------------------------------------- MINION - DRUID
		// [DAL_799] Crystal Stag - COST:5 [ATK:4/HP:4] 
		// - Race: beast, Set: dalaran, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Rush</b>. <b>Battlecry:</b> If you've restored 5 Health this game, summon a copy of this.@ <i>({0} left!)</i>@ <i>(Ready!)</i>
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - RUSH = 1
		// - PLAYER_TAG_THRESHOLD_TAG_ID = 958
		// - PLAYER_TAG_THRESHOLD_VALUE = 5
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CrystalStag_DAL_799()
		{
			// TODO CrystalStag_DAL_799 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Crystal Stag"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Crystal Stag"));
			//Minion testCard = game.ProcessCard<Minion>("Crystal Stag");
		}

		// ------------------------------------------ SPELL - DRUID
		// [DAL_256] The Forest's Aid - COST:8 
		// - Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Twinspell</b>
		//       Summon five 2/2 Treants.
		// --------------------------------------------------------
		// GameTag:
		// - TWINSPELL_COPY = 52821
		// - TWINSPELL = 1h
		// --------------------------------------------------------
		[Fact]
		public void TheForestsAid_DAL_256()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Forest's Aid"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Forest's Aid"));
			Spell testCard = game.ProcessCard<Spell>("The Forest's Aid");
			Assert.Equal(5, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			Assert.False(game.CurrentPlayer.HandZone[4].Card.TwinSpell);

			game.EndTurn();
			game.ProcessCard("Twisting Nether");
			game.EndTurn();

			game.ProcessCard(game.CurrentPlayer.HandZone[4]);
			Assert.Equal(5, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
		}

		// ------------------------------------------ SPELL - DRUID
		// [DAL_350] Crystal Power - COST:1 
		// - Fac: neutral, Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Choose One -</b> Deal $2 damage to a minion; or_Restore #5 Health. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CrystalPower_DAL_350()
		{
			// TODO CrystalPower_DAL_350 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Crystal Power"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Crystal Power"));
			//Spell testCard = game.ProcessCard<Spell>("Crystal Power");
		}

		// ------------------------------------------ SPELL - DRUID
		// [DAL_351] Blessing of the Ancients - COST:3 
		// - Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Twinspell</b>
		//       Give your minions +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - TWINSPELL_COPY = 54128
		// - TWINSPELL = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BlessingOfTheAncients_DAL_351()
		{
			// TODO BlessingOfTheAncients_DAL_351 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blessing of the Ancients"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blessing of the Ancients"));
			//Spell testCard = game.ProcessCard<Spell>("Blessing of the Ancients");
		}

		// ------------------------------------------ SPELL - DRUID
		// [DAL_352] Crystalsong Portal - COST:2 
		// - Set: dalaran, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Discover</b> a Druid minion. If your hand has no minions, keep all 3.
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact]
		public void CrystalsongPortal_DAL_352()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wisp"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			Spell testCard = game.ProcessCard<Spell>("Crystalsong Portal");
			IPlayable chosen = game.ChooseNthChoice(1);
			Assert.Equal(CardType.MINION, chosen.Card.Type);
			Assert.Equal(CardClass.DRUID, chosen.Card.Class);
			Assert.Equal(2, game.Player1.HandZone.Count);
		}

		[Fact]
		public void CrystalsongPortal_DAL_352_keepall3()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			Spell testCard = game.ProcessCard<Spell>("Crystalsong Portal");
			Assert.Equal(3, game.Player1.HandZone.Count);
			Assert.All(game.Player1.HandZone, playable => playable.Card.Type.Equals(CardType.MINION));
			Assert.All(game.Player1.HandZone, playable => playable.Card.Class.Equals(CardClass.DRUID));
		}

		// ------------------------------------------ SPELL - DRUID
		// [DAL_733] Dreamway Guardians - COST:2 
		// - Fac: neutral, Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: Summon two 1/2 Dryads with <b>Lifesteal</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DreamwayGuardians_DAL_733()
		{
			// TODO DreamwayGuardians_DAL_733 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dreamway Guardians"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dreamway Guardians"));
			//Spell testCard = game.ProcessCard<Spell>("Dreamway Guardians");
		}

	}

	public class HunterDalaranTest
	{
		// ---------------------------------------- MINION - HUNTER
		// [DAL_372] Arcane Fletcher - COST:4 [ATK:3/HP:3] 
		// - Set: dalaran, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]Whenever you play a
		//       1-Cost minion, draw a
		//       spell from your deck.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArcaneFletcher_DAL_372()
		{
			// TODO ArcaneFletcher_DAL_372 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arcane Fletcher"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Fletcher"));
			//Minion testCard = game.ProcessCard<Minion>("Arcane Fletcher");
		}

		// ---------------------------------------- MINION - HUNTER
		// [DAL_376] Oblivitron - COST:6 [ATK:3/HP:4] 
		// - Race: mechanical, Set: dalaran, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Deathrattle:</b> Summon a
		//       Mech from your hand and
		//       trigger its <b>Deathrattle</b>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void Oblivitron_DAL_376()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mechanical Whelp"),
					Cards.FromName("Mechanical Whelp"),
					Cards.FromName("Mechanical Whelp"),
					Cards.FromName("Mechanical Whelp"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Oblivitron"));
			Minion testCard = game.ProcessCard<Minion>("Oblivitron");
			testCard.Kill();
			Assert.Equal(3, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
		}

		// ---------------------------------------- MINION - HUNTER
		// [DAL_379] Vereesa Windrunner - COST:7 [ATK:5/HP:6] 
		// - Set: dalaran, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Equip Thori'dal, the Stars' Fury.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void VereesaWindrunner_DAL_379()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Vereesa Windrunner"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vereesa Windrunner"));
			Minion testCard = game.ProcessCard<Minion>("Vereesa Windrunner");
			Assert.NotNull(game.CurrentPlayer.Hero.Weapon);

			game.CurrentPlayer.Hero.Attack(game.CurrentOpponent.Hero);
			Assert.Equal(2, game.CurrentPlayer.CurrentSpellPower);
			game.EndTurn();
			game.EndTurn();
			Assert.Equal(0, game.CurrentPlayer.CurrentSpellPower);
		}

		// ---------------------------------------- MINION - HUNTER
		// [DAL_587] Shimmerfly - COST:1 [ATK:1/HP:1] 
		// - Race: beast, Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Add a random Hunter spell to your hand.
		// --------------------------------------------------------
		// Entourage: NEW1_032, NEW1_033, NEW1_034
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Shimmerfly_DAL_587()
		{
			// TODO Shimmerfly_DAL_587 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shimmerfly"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shimmerfly"));
			//Minion testCard = game.ProcessCard<Minion>("Shimmerfly");
		}

		// ---------------------------------------- MINION - HUNTER
		// [DAL_604] Ursatron - COST:3 [ATK:3/HP:3] 
		// - Race: mechanical, Fac: neutral, Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Draw a Mech from your deck.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Ursatron_DAL_604()
		{
			// TODO Ursatron_DAL_604 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ursatron"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ursatron"));
			//Minion testCard = game.ProcessCard<Minion>("Ursatron");
		}

		// ----------------------------------------- SPELL - HUNTER
		// [DAL_371] Marked Shot - COST:4 
		// - Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $4 damage to_a_minion. <b>Discover</b>_a_spell. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MarkedShot_DAL_371()
		{
			// TODO MarkedShot_DAL_371 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Marked Shot"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Marked Shot"));
			//Spell testCard = game.ProcessCard<Spell>("Marked Shot");
		}

		// ----------------------------------------- SPELL - HUNTER
		// [DAL_373] Rapid Fire - COST:1 
		// - Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Twinspell</b>
		//       Deal $1 damage. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - TWINSPELL_COPY = 54143
		// - TWINSPELL = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RapidFire_DAL_373()
		{
			// TODO RapidFire_DAL_373 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rapid Fire"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rapid Fire"));
			//Spell testCard = game.ProcessCard<Spell>("Rapid Fire");
		}

		// ----------------------------------------- SPELL - HUNTER
		// [DAL_377] Nine Lives - COST:3 
		// - Set: dalaran, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Discover</b> a friendly <b>Deathrattle</b> minion that died this game. Also trigger its <b>Deathrattle</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_FRIENDLY_DEATHRATTLE_MINION_DIED_THIS_GAME = 0
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NineLives_DAL_377()
		{
			// TODO NineLives_DAL_377 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nine Lives"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nine Lives"));
			//Spell testCard = game.ProcessCard<Spell>("Nine Lives");
		}

		// ----------------------------------------- SPELL - HUNTER
		// [DAL_378] Unleash the Beast - COST:6 
		// - Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Twinspell</b>
		//       Summon a 5/5 Wyvern with <b>Rush</b>.
		// --------------------------------------------------------
		// GameTag:
		// - TWINSPELL_COPY = 54145
		// - TWINSPELL = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		// RefTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnleashTheBeast_DAL_378()
		{
			// TODO UnleashTheBeast_DAL_378 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unleash the Beast"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unleash the Beast"));
			//Spell testCard = game.ProcessCard<Spell>("Unleash the Beast");
		}

		// ----------------------------------------- SPELL - HUNTER
		// [DAL_589] Hunting Party - COST:5 
		// - Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: Copy all Beasts in your_hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HuntingParty_DAL_589()
		{
			// TODO HuntingParty_DAL_589 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hunting Party"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hunting Party"));
			//Spell testCard = game.ProcessCard<Spell>("Hunting Party");
		}

	}

	public class MageDalaranTest
	{
		// ------------------------------------------ MINION - MAGE
		// [DAL_163] Messenger Raven - COST:3 [ATK:3/HP:2] 
		// - Race: beast, Fac: neutral, Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Discover</b> a
		//       Mage minion.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact]
		public void MessengerRaven_DAL_163()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Messenger Raven"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Messenger Raven"));
			Minion testCard = game.ProcessCard<Minion>("Messenger Raven");
			Assert.NotNull(game.CurrentPlayer.Choice);
			Card[] cards = game.GetChoiceCards();
			Assert.True(Array.TrueForAll(cards, c => c.Type == CardType.MINION));
			Assert.True(Array.TrueForAll(cards, c => c.Class == CardClass.MAGE));
		}

		// ------------------------------------------ MINION - MAGE
		// [DAL_182] Magic Dart Frog - COST:2 [ATK:1/HP:3] 
		// - Race: beast, Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: After you cast a spell, deal 1 damage to a random enemy minion.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MagicDartFrog_DAL_182()
		{
			// TODO MagicDartFrog_DAL_182 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Magic Dart Frog"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Magic Dart Frog"));
			//Minion testCard = game.ProcessCard<Minion>("Magic Dart Frog");
		}

		// ------------------------------------------ MINION - MAGE
		// [DAL_575] Khadgar - COST:2 [ATK:2/HP:2] 
		// - Set: dalaran, Rarity: legendary
		// --------------------------------------------------------
		// Text: Your cards that summon minions summon twice_as_many.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact]
		public void Khadgar_DAL_575()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Khadgar"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Khadgar"));
			Minion testCard = game.ProcessCard<Minion>("Khadgar");

			game.ProcessCard("Wisp");
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);

			game.ProcessCard("Power of Creation", asZeroCost: true);
			game.ChooseNthChoice(1);
			Assert.Equal(6, game.CurrentPlayer.BoardZone.Count);

			for (int i = game.CurrentPlayer.BoardZone.Count - 1; i >= 1; i--)
				game.CurrentPlayer.BoardZone.Remove(i);

			game.ProcessCard("Flight Master", asZeroCost: true);
			Assert.Equal(4, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(2, game.CurrentOpponent.BoardZone.Count);

			Minion target = game.ProcessCard<Minion>("Safeguard", asZeroCost: true);
			target.Kill();
			Assert.Equal(6, game.CurrentPlayer.BoardZone.Count);
		}

		// ------------------------------------------ MINION - MAGE
		// [DAL_576] Kirin Tor Tricaster - COST:4 [ATK:3/HP:3] 
		// - Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Spell Damage +3</b>
		//       Your spells cost (1) more.
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 3
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KirinTorTricaster_DAL_576()
		{
			// TODO KirinTorTricaster_DAL_576 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kirin Tor Tricaster"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kirin Tor Tricaster"));
			//Minion testCard = game.ProcessCard<Minion>("Kirin Tor Tricaster");
		}

		// ------------------------------------------ MINION - MAGE
		// [DAL_603] Mana Cyclone - COST:2 [ATK:2/HP:2] 
		// - Race: elemental, Set: dalaran, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> For each spell
		//       you've cast this turn, add
		//       a random Mage spell
		//       to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ManaCyclone_DAL_603()
		{
			// TODO ManaCyclone_DAL_603 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mana Cyclone"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mana Cyclone"));
			//Minion testCard = game.ProcessCard<Minion>("Mana Cyclone");
		}

		// ------------------------------------------ MINION - MAGE
		// [DAL_609] Kalecgos - COST:10 [ATK:4/HP:12] 
		// - Race: dragon, Set: dalaran, Rarity: legendary
		// --------------------------------------------------------
		// Text: Your first spell each
		//       turn costs (0).
		//       <b>Battlecry:</b> <b>Discover</b>
		//       a spell.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - AURA = 1
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact]
		public void Kalecgos_DAL_609()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kalecgos"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testMinion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kalecgos"));
			Minion testCard = game.ProcessCard<Minion>("Kalecgos");
			Spell testSpell = (Spell) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));

			IPlayable chosen = game.ChooseNthChoice(1);
			Assert.Equal(CardType.SPELL, chosen.Card.Type);
			Assert.Equal(0, chosen.Cost);
			Assert.Equal(0, testSpell.Cost);
			Assert.NotEqual(0, testMinion.Cost);
			game.ProcessCard(testSpell, game.CurrentOpponent.Hero);
			Assert.Equal(chosen.Card.Cost, chosen.Cost);
			testCard.Kill();
			game.EndTurn();
			game.EndTurn();
			game.ProcessCard("Elemental Evocation");
			game.ProcessCard("Kalecgos");
			chosen = game.ChooseNthChoice(1);
			Assert.Equal(chosen.Card.Cost, chosen.Cost);
		}

		// ------------------------------------------- SPELL - MAGE
		// [DAL_177] Conjurer's Calling - COST:3 
		// - Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Twinspell</b>
		//       Destroy a minion. Summon 2 minions of the same Cost to replace it.
		// --------------------------------------------------------
		// GameTag:
		// - TWINSPELL_COPY = 52637
		// - TWINSPELL = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ConjurersCalling_DAL_177()
		{
			// TODO ConjurersCalling_DAL_177 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Conjurer's Calling"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Conjurer's Calling"));
			//Spell testCard = game.ProcessCard<Spell>("Conjurer's Calling");
		}

		// ------------------------------------------- SPELL - MAGE
		// [DAL_577] Ray of Frost - COST:1 
		// - Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Twinspell</b>
		//       <b>Freeze</b> a minion.
		//       If it's already <b>Frozen</b>,
		//       deal $2 damage to it. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - TWINSPELL_COPY = 54193
		// - TWINSPELL = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RayOfFrost_DAL_577()
		{
			// TODO RayOfFrost_DAL_577 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ray of Frost"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ray of Frost"));
			//Spell testCard = game.ProcessCard<Spell>("Ray of Frost");
		}

		// ------------------------------------------- SPELL - MAGE
		// [DAL_578] Power of Creation - COST:8 
		// - Set: dalaran, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Discover</b> a 6-Cost minion. Summon two copies of it.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PowerOfCreation_DAL_578()
		{
			// TODO PowerOfCreation_DAL_578 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Power of Creation"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Power of Creation"));
			//Spell testCard = game.ProcessCard<Spell>("Power of Creation");
		}

		// ------------------------------------------- SPELL - MAGE
		// [DAL_608] Magic Trick - COST:1 
		// - Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Discover</b> a spell that costs (3) or less.
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact]
		public void MagicTrick_DAL_608()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Magic Trick"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Magic Trick"));
			Spell testCard = game.ProcessCard<Spell>("Magic Trick");
			Card[] choices = game.GetChoiceCards();
			Assert.True(Array.TrueForAll(choices, c => c.Type == CardType.SPELL));
			Assert.True(Array.TrueForAll(choices, c => c.Cost <= 3));
		}
	}

	public class PaladinDalaranTest
	{
		// --------------------------------------- MINION - PALADIN
		// [DAL_146] Bronze Herald - COST:3 [ATK:3/HP:2] 
		// - Race: dragon, Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Add two 4/4 Dragons to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BronzeHerald_DAL_146()
		{
			// TODO BronzeHerald_DAL_146 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bronze Herald"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bronze Herald"));
			//Minion testCard = game.ProcessCard<Minion>("Bronze Herald");
		}

		// --------------------------------------- MINION - PALADIN
		// [DAL_147] Dragon Speaker - COST:5 [ATK:3/HP:5] 
		// - Set: dalaran, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give all Dragons in your hand +3/+3.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DragonSpeaker_DAL_147()
		{
			// TODO DragonSpeaker_DAL_147 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dragon Speaker"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragon Speaker"));
			//Minion testCard = game.ProcessCard<Minion>("Dragon Speaker");
		}

		// --------------------------------------- MINION - PALADIN
		// [DAL_573] Commander Rhyssa - COST:3 [ATK:4/HP:3] 
		// - Set: dalaran, Rarity: legendary
		// --------------------------------------------------------
		// Text: Your <b>Secrets</b> trigger twice.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - AURA = 1
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CommanderRhyssa_DAL_573()
		{
			// TODO CommanderRhyssa_DAL_573 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Commander Rhyssa"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Commander Rhyssa"));
			//Minion testCard = game.ProcessCard<Minion>("Commander Rhyssa");
		}

		// --------------------------------------- MINION - PALADIN
		// [DAL_581] Nozari - COST:10 [ATK:4/HP:12] 
		// - Race: dragon, Set: dalaran, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Restore both heroes to full Health.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - AFFECTED_BY_HEALING_DOES_DAMAGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Nozari_DAL_581()
		{
			// TODO Nozari_DAL_581 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nozari"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nozari"));
			//Minion testCard = game.ProcessCard<Minion>("Nozari");
		}

		// ---------------------------------------- SPELL - PALADIN
		// [DAL_141] Desperate Measures - COST:1 
		// - Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Twinspell</b>
		//       Cast a random Paladin <b>Secret</b>.
		// --------------------------------------------------------
		// GameTag:
		// - TWINSPELL_COPY = 54129
		// - TWINSPELL = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_SECRET_ZONE_CAP_FOR_NON_SECRET = 0
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact]
		public void DesperateMeasures_DAL_141()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Desperate Measures"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Desperate Measures"));
			game.ProcessCard<Spell>("Desperate Measures");
			Assert.Single(game.CurrentPlayer.SecretZone);
			game.ProcessCard<Spell>("Desperate Measures");
			game.ProcessCard<Spell>("Desperate Measures");
			game.ProcessCard<Spell>("Desperate Measures");
			game.ProcessCard<Spell>("Desperate Measures");
			Assert.Equal(5, game.CurrentPlayer.SecretZone.Count);
			Assert.Equal(5, game.CurrentPlayer.SecretZone.Distinct().Count());
		}

		// ---------------------------------------- SPELL - PALADIN
		// [DAL_568] Lightforged Blessing - COST:2 
		// - Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Twinspell</b>
		//       Give a friendly minion <b>Lifesteal</b>.
		// --------------------------------------------------------
		// GameTag:
		// - TWINSPELL_COPY = 54189
		// - TWINSPELL = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LightforgedBlessing_DAL_568()
		{
			// TODO LightforgedBlessing_DAL_568 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lightforged Blessing"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lightforged Blessing"));
			//Spell testCard = game.ProcessCard<Spell>("Lightforged Blessing");
		}

		// ---------------------------------------- SPELL - PALADIN
		// [DAL_570] Never Surrender! - COST:1 
		// - Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When your opponent casts a spell, give your minions +2_Health.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NeverSurrender_DAL_570()
		{
			// TODO NeverSurrender_DAL_570 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Never Surrender!"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Never Surrender!"));
			//Spell testCard = game.ProcessCard<Spell>("Never Surrender!");
		}

		// ---------------------------------------- SPELL - PALADIN
		// [DAL_727] Call to Adventure - COST:3 
		// - Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: Draw the lowest Cost minion from your deck. Give it +2/+2.
		// --------------------------------------------------------
		[Fact]
		public void CallToAdventure_DAL_727()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = true,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Call to Adventure"));
			Spell testCard = game.ProcessCard<Spell>("Call to Adventure");

			IPlayable drawnP = game.IdEntityDic[game.CurrentPlayer.LastCardDrawn];
			Minion drawn = Assert.IsType<Minion>(drawnP);

			Assert.Equal(0, drawn.Cost);
			Assert.Equal(drawn.Card.ATK + 2, drawn.AttackDamage);
			Assert.Equal(drawn.Card.Health + 2, drawn.Health);
		}

		// ---------------------------------------- SPELL - PALADIN
		// [DAL_731] Duel! - COST:5 
		// - Set: dalaran, Rarity: epic
		// --------------------------------------------------------
		// Text: Summon a minion from each player's deck.
		//       They fight!
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Duel_DAL_731()
		{
			// TODO Duel_DAL_731 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Duel!"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Duel!"));
			//Spell testCard = game.ProcessCard<Spell>("Duel!");
		}

		// --------------------------------------- WEAPON - PALADIN
		// [DAL_571] Mysterious Blade - COST:2 [ATK:2/HP:0] 
		// - Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you control a
		//       <b>Secret</b>, gain +1 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MysteriousBlade_DAL_571()
		{
			// TODO MysteriousBlade_DAL_571 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mysterious Blade"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mysterious Blade"));
			//Weapon testCard = game.ProcessCard<Weapon>("Mysterious Blade");
		}

	}

	public class PriestDalaranTest
	{
		// ---------------------------------------- MINION - PRIEST
		// [DAL_030] Shadowy Figure - COST:2 [ATK:2/HP:2] 
		// - Set: dalaran, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Transform into a_2/2 copy of a friendly <b>Deathrattle</b> minion.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_WITH_DEATHRATTLE = 0
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void ShadowyFigure_DAL_030()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shadowy Figure"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadowy Figure"));

			Minion target = game.ProcessCard<Minion>("Convincing Infiltrator");

			Minion testCard = game.ProcessCard<Minion>("Shadowy Figure", target);
			testCard = game.CurrentPlayer.BoardZone[1];
			Assert.Equal(2, testCard.AttackDamage);
			Assert.Equal(2, testCard.Health);
			Assert.Equal("Convincing Infiltrator", testCard.Card.Name);

		}

		// ---------------------------------------- MINION - PRIEST
		// [DAL_039] Convincing Infiltrator - COST:5 [ATK:2/HP:6] 
		// - Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b><b>Taunt</b></b>
		//       <b>Deathrattle:</b> Destroy a
		//        random enemy minion.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ConvincingInfiltrator_DAL_039()
		{
			// TODO ConvincingInfiltrator_DAL_039 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Convincing Infiltrator"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Convincing Infiltrator"));
			//Minion testCard = game.ProcessCard<Minion>("Convincing Infiltrator");
		}

		// ---------------------------------------- MINION - PRIEST
		// [DAL_040] Hench-Clan Shadequill - COST:4 [ATK:4/HP:7] 
		// - Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Restore 5 Health to the enemy hero.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// - AFFECTED_BY_HEALING_DOES_DAMAGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HenchClanShadequill_DAL_040()
		{
			// TODO HenchClanShadequill_DAL_040 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hench-Clan Shadequill"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hench-Clan Shadequill"));
			//Minion testCard = game.ProcessCard<Minion>("Hench-Clan Shadequill");
		}

		// ---------------------------------------- MINION - PRIEST
		// [DAL_413] EVIL Conscripter - COST:2 [ATK:2/HP:2] 
		// - Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Add a <b>Lackey</b> to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		// RefTag:
		// - MARK_OF_EVIL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EvilConscripter_DAL_413()
		{
			// TODO EvilConscripter_DAL_413 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("EVIL Conscripter"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("EVIL Conscripter"));
			//Minion testCard = game.ProcessCard<Minion>("EVIL Conscripter");
		}

		// ---------------------------------------- MINION - PRIEST
		// [DAL_721] Catrina Muerte - COST:8 [ATK:6/HP:8] 
		// - Set: dalaran, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]At the end of your turn,
		//       summon a friendly minion
		//       that died this game.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CatrinaMuerte_DAL_721()
		{
			// TODO CatrinaMuerte_DAL_721 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Catrina Muerte"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Catrina Muerte"));
			//Minion testCard = game.ProcessCard<Minion>("Catrina Muerte");
		}

		// ---------------------------------------- MINION - PRIEST
		// [DAL_729] Madame Lazul - COST:3 [ATK:3/HP:2] 
		// - Set: dalaran, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> <b>Discover</b> a
		//       copy of a card in your
		//       opponent's hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MadameLazul_DAL_729()
		{
			// TODO MadameLazul_DAL_729 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Madame Lazul"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Madame Lazul"));
			//Minion testCard = game.ProcessCard<Minion>("Madame Lazul");
		}

		// ----------------------------------------- SPELL - PRIEST
		// [DAL_011] Lazul's Scheme - COST:0 
		// - Set: dalaran, Rarity: epic
		// --------------------------------------------------------
		// Text: Reduce the Attack of an enemy minion by
		//       @ until your next turn. <i>(Upgrades each turn!)</i>
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_1 = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_ENEMY_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void LazulsScheme_DAL_011()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lazul's Scheme"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lazul's Scheme"));
			// 1
			game.EndTurn();
			Minion target = game.ProcessCard<Minion>("Core Hound");
			game.EndTurn();
			// 2
			game.EndTurn();
			game.EndTurn();
			// 3
			game.EndTurn();
			game.EndTurn();
			// 4
			game.EndTurn();
			game.EndTurn();
			// 5
			game.EndTurn();
			game.EndTurn();
			// 6
			game.EndTurn();
			game.EndTurn();
			// 7

			Game clone = game.Clone();

			game.ProcessCard(testCard, target);
			Assert.Equal(2, target.AttackDamage);
			game.EndTurn();
			Assert.Equal(2, target.AttackDamage);
			game.EndTurn();
			Assert.Equal(9, target.AttackDamage);

			// Test with History = false
			target = (Minion) clone.IdEntityDic[target.Id];
			clone.ProcessCard(clone.IdEntityDic[testCard.Id], target);
			Assert.Equal(2, target.AttackDamage);
			clone.EndTurn();
			Assert.Equal(2, target.AttackDamage);
			clone.EndTurn();
			Assert.Equal(9, target.AttackDamage);
		}

		// ----------------------------------------- SPELL - PRIEST
		// [DAL_065] Unsleeping Soul - COST:4 
		// - Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Silence</b> a friendly minion, then summon a copy of it.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - SILENCE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnsleepingSoul_DAL_065()
		{
			// TODO UnsleepingSoul_DAL_065 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unsleeping Soul"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unsleeping Soul"));
			//Spell testCard = game.ProcessCard<Spell>("Unsleeping Soul");
		}

		// ----------------------------------------- SPELL - PRIEST
		// [DAL_723] Forbidden Words - COST:0 
		// - Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]Spend all your Mana.
		//       Destroy a minion with that
		//       much Attack or less.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - 85 = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void ForbiddenWords_DAL_723()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Forbidden Words"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Forbidden Words"));

			Minion target = game.ProcessCard<Minion>("Core Hound", asZeroCost: true);
			game.ProcessCard<Spell>("Forbidden Words", target);
			Assert.Equal(0, game.CurrentPlayer.RemainingMana);
			Assert.True(target.IsDead);

			game.CurrentPlayer.UsedMana = 2;
			Minion target2 = game.ProcessCard<Minion>("Core Hound", asZeroCost: true);
			game.ProcessCard<Spell>("Forbidden Words", target2);
			Assert.Equal(0, game.CurrentPlayer.RemainingMana);
			Assert.False(target2.IsDead);
		}

		// ----------------------------------------- SPELL - PRIEST
		// [DAL_724] Mass Resurrection - COST:9 
		// - Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: Summon 3 friendly minions that died
		//       this game.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// - REQ_FRIENDLY_MINION_DIED_THIS_GAME = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MassResurrection_DAL_724()
		{
			// TODO MassResurrection_DAL_724 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mass Resurrection"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mass Resurrection"));
			//Spell testCard = game.ProcessCard<Spell>("Mass Resurrection");
		}

	}

	public class RogueDalaranTest
	{
		// ----------------------------------------- MINION - ROGUE
		// [DAL_415] EVIL Miscreant - COST:3 [ATK:1/HP:5] 
		// - Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Combo:</b> Add two random <b>Lackeys</b> to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		// RefTag:
		// - MARK_OF_EVIL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EvilMiscreant_DAL_415()
		{
			// TODO EvilMiscreant_DAL_415 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("EVIL Miscreant"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("EVIL Miscreant"));
			//Minion testCard = game.ProcessCard<Minion>("EVIL Miscreant");
		}

		// ----------------------------------------- MINION - ROGUE
		// [DAL_416] Hench-Clan Burglar - COST:4 [ATK:4/HP:3] 
		// - Race: pirate, Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Discover</b> a spell from another class.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact]
		public void HenchClanBurglar_DAL_416()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hench-Clan Burglar"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hench-Clan Burglar"));
			Minion testCard = game.ProcessCard<Minion>("Hench-Clan Burglar");
			Assert.NotNull(game.CurrentPlayer.Choice);
			Card[] choiceCards = game.GetChoiceCards();
			IEnumerable<Card> unexpectedChoices = choiceCards.Where(
										c => c.Class == CardClass.ROGUE || c.Type != CardType.SPELL);
			foreach (Card c in unexpectedChoices)
			{
				Assert.Equal("Unexpected Card", c.Name);
			}

			Assert.True(Array.TrueForAll(choiceCards, c => c.Class != CardClass.ROGUE));
			Assert.True(Array.TrueForAll(choiceCards, c => c.Type == CardType.SPELL));

			// turn the tables to verify we're not using bad cache
			game.EndTurn();
			testCard = game.ProcessCard<Minion>("Hench-Clan Burglar");
			Assert.NotNull(game.CurrentPlayer.Choice);
			choiceCards = game.GetChoiceCards();
			unexpectedChoices = choiceCards.Where(
										c => c.Class == CardClass.MAGE || c.Type != CardType.SPELL);
			foreach (Card c in unexpectedChoices)
			{
				Assert.Equal("Unexpected Card", c.Name);
			}

			Assert.True(Array.TrueForAll(choiceCards, c => c.Class != CardClass.MAGE));
			Assert.True(Array.TrueForAll(choiceCards, c => c.Type == CardType.SPELL));
		}

		// ----------------------------------------- MINION - ROGUE
		// [DAL_417] Heistbaron Togwaggle - COST:6 [ATK:5/HP:5] 
		// - Set: dalaran, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you control a_<b>Lackey</b>, choose a fantastic treasure.
		// --------------------------------------------------------
		// Entourage: LOOT_998h, LOOT_998j, LOOT_998l, LOOT_998k
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - MULTIPLY_BUFF_VALUE = 1
		// --------------------------------------------------------
		// RefTag:
		// - MARK_OF_EVIL = 1
		// --------------------------------------------------------
		[Fact]
		public void HeistbaronTogwaggle_DAL_417()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable lackey = Generic.DrawCard(game.CurrentPlayer, Cards.FromId("DAL_615"));  // Goblin Lackey
			game.ProcessCard(lackey);

			Minion testCard = game.ProcessCard<Minion>("Heistbaron Togwaggle");
			var expectTreasures = new HashSet<string> { "Tolin's Goblet", "Zarog's Crown", "Wondrous Wand", "Golden Kobold" };
			Card[] choiceCards = game.GetChoiceCards();
			var choiceNameSet = choiceCards.Select(card => card.Name).ToHashSet();
			Assert.Equal(expectTreasures, choiceNameSet);
			int choiceNum = Array.FindIndex(choiceCards, card => card.Name.Equals("Wondrous Wand"));
			game.ChooseNthChoice(choiceNum + 1);
			Assert.Single(game.Player1.HandZone);
			Assert.Equal("Wondrous Wand", game.Player1.HandZone[0].Card.Name);
		}

		[Fact]
		public void HeistbaronTogwaggle_DAL_417_failed_battlecry()
		{
			// TODO HeistbaronTogwaggle_DAL_417 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			Minion testCard = game.ProcessCard<Minion>("Heistbaron Togwaggle");
			Assert.Empty(game.CurrentPlayer.HandZone);
		}

		// ----------------------------------------- MINION - ROGUE
		// [DAL_714] Underbelly Fence - COST:2 [ATK:2/HP:3] 
		// - Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If you're holding
		//       a card from another class,
		//       _gain +1/+1 and <b><b>Rush</b>.</b>
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnderbellyFence_DAL_714()
		{
			// TODO UnderbellyFence_DAL_714 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Underbelly Fence"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Underbelly Fence"));
			//Minion testCard = game.ProcessCard<Minion>("Underbelly Fence");
		}

		// ----------------------------------------- MINION - ROGUE
		// [DAL_719] Tak Nozwhisker - COST:7 [ATK:6/HP:6] 
		// - Set: dalaran, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]Whenever you shuffle a
		//       card into your deck, add
		//       a copy to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact]
		public void TakNozwhisker_DAL_719()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tak Nozwhisker"));
			Minion testCard = game.ProcessCard<Minion>("Tak Nozwhisker");
			game.ProcessCard("Preparation");
			game.ProcessCard("Academic Espionage");
			Assert.Equal(10, game.CurrentPlayer.DeckZone.Count);
			Assert.Equal(10, game.CurrentPlayer.HandZone.Count);
			Assert.True(game.CurrentPlayer.HandZone.ToList().TrueForAll(p => p.Cost == 1));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [DAL_010] Togwaggle's Scheme - COST:1 
		// - Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: Choose a minion. Shuffle @ |4(copy, copies) of it into your deck.
		//       <i>(Upgrades each turn!)</i>
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_1 = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TogwagglesScheme_DAL_010()
		{
			// TODO TogwagglesScheme_DAL_010 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Togwaggle's Scheme"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Togwaggle's Scheme"));
			//Spell testCard = game.ProcessCard<Spell>("Togwaggle's Scheme");
		}

		// ------------------------------------------ SPELL - ROGUE
		// [DAL_366] Unidentified Contract - COST:6 
		// - Set: dalaran, Rarity: epic
		// --------------------------------------------------------
		// Text: Destroy a minion. Gains a bonus effect in_your hand.
		// --------------------------------------------------------
		// Entourage: DAL_366t1, DAL_366t2, DAL_366t3, DAL_366t4
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnidentifiedContract_DAL_366()
		{
			// TODO UnidentifiedContract_DAL_366 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unidentified Contract"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unidentified Contract"));
			//Spell testCard = game.ProcessCard<Spell>("Unidentified Contract");
		}

		// ------------------------------------------ SPELL - ROGUE
		// [DAL_716] Vendetta - COST:4 
		// - Fac: neutral, Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $4 damage to a minion. Costs (0) if you're holding a card from another class. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void Vendetta_DAL_716()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vendetta"));
			Assert.Equal(4, testCard.Cost);
			Minion blinkFox = game.ProcessCard<Minion>("Blink Fox", asZeroCost: true);
			Assert.True(game.Player1.HandZone.Last().Card.Class != CardClass.ROGUE);
			Assert.Equal(0, testCard.Cost);
			Assert.False(testCard.IsValidPlayTarget(game.Player2.Hero));
			Assert.Equal(10, game.Player1.RemainingMana);
			game.ProcessCard(testCard, blinkFox);
			Assert.Equal(10, game.Player1.RemainingMana);
			Assert.True(blinkFox.IsDead);

			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vendetta"));
			//Spell testCard = game.ProcessCard<Spell>("Vendetta");
		}

		// ------------------------------------------ SPELL - ROGUE
		// [DAL_728] Daring Escape - COST:1 
		// - Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: Return all friendly minions to your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DaringEscape_DAL_728()
		{
			// TODO DaringEscape_DAL_728 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Daring Escape"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Daring Escape"));
			//Spell testCard = game.ProcessCard<Spell>("Daring Escape");
		}

		// ----------------------------------------- WEAPON - ROGUE
		// [DAL_720] Waggle Pick - COST:4 [ATK:4/HP:0] 
		// - Set: dalaran, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Deathrattle:</b> Return
		//       a random friendly
		//       minion to your hand.
		//       It costs (2) less.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WagglePick_DAL_720()
		{
			// TODO WagglePick_DAL_720 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Waggle Pick"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Waggle Pick"));
			//Weapon testCard = game.ProcessCard<Weapon>("Waggle Pick");
		}

	}

	public class ShamanDalaranTest
	{
		// ---------------------------------------- MINION - SHAMAN
		// [DAL_047] Walking Fountain - COST:8 [ATK:4/HP:8] 
		// - Race: elemental, Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Lifesteal</b>, <b>Rush</b>, <b>Windfury</b>
		// --------------------------------------------------------
		// GameTag:
		// - WINDFURY = 1
		// - LIFESTEAL = 1
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WalkingFountain_DAL_047()
		{
			// TODO WalkingFountain_DAL_047 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Walking Fountain"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Walking Fountain"));
			//Minion testCard = game.ProcessCard<Minion>("Walking Fountain");
		}

		// ---------------------------------------- MINION - SHAMAN
		// [DAL_049] Underbelly Angler - COST:2 [ATK:2/HP:3] 
		// - Race: murloc, Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: After you play a Murloc, add a random Murloc to your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnderbellyAngler_DAL_049()
		{
			// TODO UnderbellyAngler_DAL_049 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Underbelly Angler"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Underbelly Angler"));
			//Minion testCard = game.ProcessCard<Minion>("Underbelly Angler");
		}

		// ---------------------------------------- MINION - SHAMAN
		// [DAL_052] Muckmorpher - COST:5 [ATK:4/HP:4] 
		// - Set: dalaran, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Transform into
		//       a 4/4 copy of a different
		//       minion in your deck.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void Muckmorpher_DAL_052()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Muckmorpher"),
					Cards.FromName("Muckmorpher"),
					Cards.FromName("Muckmorpher"),
					Cards.FromName("Muckmorpher"),
					Cards.FromName("Al'Akir the Windlord")
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Muckmorpher"));
			Minion testCard = game.ProcessCard<Minion>("Muckmorpher");
			Assert.Equal("Al'Akir the Windlord", testCard.Card.Name);
			Assert.Equal(4, testCard.AttackDamage);
			Assert.Equal(4, testCard.Health);
		}

		// ---------------------------------------- MINION - SHAMAN
		// [DAL_431] Swampqueen Hagatha - COST:7 [ATK:5/HP:5] 
		// - Set: dalaran, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Add a 5/5
		//       Horror to your hand. Teach
		//       it two Shaman spells.
		// --------------------------------------------------------
		// Entourage: DAL_431t
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SwampqueenHagatha_DAL_431()
		{
			// TODO SwampqueenHagatha_DAL_431 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Swampqueen Hagatha"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Swampqueen Hagatha"));
			//Minion testCard = game.ProcessCard<Minion>("Swampqueen Hagatha");
		}

		// ---------------------------------------- MINION - SHAMAN
		// [DAL_433] Sludge Slurper - COST:1 [ATK:2/HP:1] 
		// - Race: murloc, Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add a <b>Lackey</b> to your hand. <b>Overload:</b> (1)
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - MARK_OF_EVIL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SludgeSlurper_DAL_433()
		{
			// TODO SludgeSlurper_DAL_433 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sludge Slurper"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sludge Slurper"));
			//Minion testCard = game.ProcessCard<Minion>("Sludge Slurper");
		}

		// ---------------------------------------- MINION - SHAMAN
		// [DAL_726] Scargil - COST:4 [ATK:4/HP:4] 
		// - Race: murloc, Set: dalaran, Rarity: legendary
		// --------------------------------------------------------
		// Text: Your Murlocs cost (1).
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Scargil_DAL_726()
		{
			// TODO Scargil_DAL_726 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Scargil"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Scargil"));
			//Minion testCard = game.ProcessCard<Minion>("Scargil");
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [DAL_009] Hagatha's Scheme - COST:5 
		// - Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $@ damage
		//       to all minions.
		//       <i>(Upgrades each turn!)</i> @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_1 = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HagathasScheme_DAL_009()
		{
			// TODO HagathasScheme_DAL_009 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hagatha's Scheme"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hagatha's Scheme"));
			//Spell testCard = game.ProcessCard<Spell>("Hagatha's Scheme");
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [DAL_071] Mutate - COST:0 
		// - Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: Transform a friendly minion into a random one that costs (1) more.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Mutate_DAL_071()
		{
			// TODO Mutate_DAL_071 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mutate"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mutate"));
			//Spell testCard = game.ProcessCard<Spell>("Mutate");
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [DAL_432] Witch's Brew - COST:2 
		// - Set: dalaran, Rarity: epic
		// --------------------------------------------------------
		// Text: Restore #4 Health. Repeatable this turn.
		// --------------------------------------------------------
		// GameTag:
		// - NON_KEYWORD_ECHO = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void WitchsBrew_DAL_432()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Witch's Brew"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Witch's Brew"));
			Spell testCard = game.ProcessCard<Spell>("Witch's Brew", game.CurrentPlayer.Hero);
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			Assert.Equal("Witch's Brew", game.CurrentPlayer.HandZone[4].Card.Name);
			game.ProcessCard(game.CurrentPlayer.HandZone[4], game.CurrentPlayer.Hero);
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			Assert.Equal("Witch's Brew", game.CurrentPlayer.HandZone[4].Card.Name);
			game.EndTurn();

			Assert.Equal(4, game.CurrentOpponent.HandZone.Count);
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [DAL_710] Soul of the Murloc - COST:2 
		// - Fac: neutral, Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: Give your minions "<b>Deathrattle:</b> Summon a 1/1 Murloc."
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SoulOfTheMurloc_DAL_710()
		{
			// TODO SoulOfTheMurloc_DAL_710 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Soul of the Murloc"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Soul of the Murloc"));
			//Spell testCard = game.ProcessCard<Spell>("Soul of the Murloc");
		}

	}

	public class WarlockDalaranTest
	{
		// --------------------------------------- MINION - WARLOCK
		// [DAL_185] Aranasi Broodmother - COST:6 [ATK:4/HP:6] 
		// - Race: demon, Fac: neutral, Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       When you draw this, restore
		//       4 Health to your hero.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - TOPDECK = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AranasiBroodmother_DAL_185()
		{
			// TODO AranasiBroodmother_DAL_185 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Aranasi Broodmother"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Aranasi Broodmother"));
			//Minion testCard = game.ProcessCard<Minion>("Aranasi Broodmother");
		}

		// --------------------------------------- MINION - WARLOCK
		// [DAL_422] Arch-Villain Rafaam - COST:7 [ATK:7/HP:8] 
		// - Set: dalaran, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b><b>Taunt</b>
		//       Battlecry:</b> Replace your hand and deck with <b>Legendary</b> minions.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void ArchVillainRafaam_DAL_422()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.ProcessCard<Minion>("Arch-Villain Rafaam");
			ReadOnlySpan<IPlayable> span = game.CurrentPlayer.HandZone.GetSpan();
			for (int i = 0; i < span.Length; i++)
				Assert.True(span[i].Card.Rarity == Rarity.LEGENDARY && span[i].Card.Type == CardType.MINION,
					$"Hand card {span[i]} is not a legendary minion!");
			span = game.CurrentPlayer.DeckZone.GetSpan();
			for (int i = 0; i < span.Length; i++)
				Assert.True(span[i].Card.Rarity == Rarity.LEGENDARY && span[i].Card.Type == CardType.MINION,
					$"Deck card {span[i]} is not a legendary minion!");
		}

		// --------------------------------------- MINION - WARLOCK
		// [DAL_561] Jumbo Imp - COST:10 [ATK:8/HP:8] 
		// - Race: demon, Set: dalaran, Rarity: epic
		// --------------------------------------------------------
		// Text: Costs (1) less whenever a friendly Demon dies while this is in your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void JumboImp_DAL_561()
		{
			// TODO JumboImp_DAL_561 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Jumbo Imp"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jumbo Imp"));
			//Minion testCard = game.ProcessCard<Minion>("Jumbo Imp");
		}

		// --------------------------------------- MINION - WARLOCK
		// [DAL_563] Eager Underling - COST:4 [ATK:2/HP:2] 
		// - Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Give two random friendly minions +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EagerUnderling_DAL_563()
		{
			// TODO EagerUnderling_DAL_563 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Eager Underling"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eager Underling"));
			//Minion testCard = game.ProcessCard<Minion>("Eager Underling");
		}

		// --------------------------------------- MINION - WARLOCK
		// [DAL_606] EVIL Genius - COST:2 [ATK:2/HP:2] 
		// - Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy a friendly minion to add 2 random <b>Lackeys</b>_to_your_hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - MARK_OF_EVIL = 1
		// --------------------------------------------------------
		[Fact]
		public void EvilGenius_DAL_606()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("EVIL Genius"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("EVIL Genius"));
			Minion testCard = game.ProcessCard<Minion>("EVIL Genius");
			Assert.Equal(4, game.CurrentPlayer.HandZone.Count);
			game.ProcessCard("EVIL Genius", testCard);
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
			Assert.Single(game.CurrentPlayer.BoardZone);
		}

		// --------------------------------------- MINION - WARLOCK
		// [DAL_607] Fel Lord Betrug - COST:8 [ATK:5/HP:7] 
		// - Race: demon, Set: dalaran, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]Whenever you draw a
		//       minion, summon a copy
		//        with <b>Rush</b> that dies at
		//       end of turn.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		// RefTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FelLordBetrug_DAL_607()
		{
			// TODO FelLordBetrug_DAL_607 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fel Lord Betrug"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fel Lord Betrug"));
			//Minion testCard = game.ProcessCard<Minion>("Fel Lord Betrug");
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [DAL_007] Rafaam's Scheme - COST:3 
		// - Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: Summon @ 1/1 |4(Imp, Imps). <i>(Upgrades each turn!)</i>
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_1 = 1
		// --------------------------------------------------------
		[Fact]
		public void RafaamsScheme_DAL_007()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rafaam's Scheme"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rafaam's Scheme"));
			game.EndTurn();
			game.EndTurn();
			game.EndTurn();
			game.EndTurn();
			game.EndTurn();
			game.EndTurn();
			game.ProcessCard(testCard);
			Assert.Equal(4, game.CurrentPlayer.BoardZone.Count);
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [DAL_173] Darkest Hour - COST:6 
		// - Set: dalaran, Rarity: epic
		// --------------------------------------------------------
		// Text: Destroy all friendly minions. For each one, summon a random minion from your deck.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DarkestHour_DAL_173()
		{
			// TODO DarkestHour_DAL_173 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Darkest Hour"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Darkest Hour"));
			//Spell testCard = game.ProcessCard<Spell>("Darkest Hour");
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [DAL_602] Plot Twist - COST:2 
		// - Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: Shuffle your hand
		//       into your deck.
		//       Draw that many cards.
		// --------------------------------------------------------
		[Fact]
		public void PlotTwist_DAL_602()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dread Corsair"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Plot Twist"));

			game.ProcessCard("Mana Wraith");

			game.ProcessCard("Wisp");

			Spell testCard = game.ProcessCard<Spell>("Plot Twist");
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [DAL_605] Impferno - COST:3 
		// - Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: Give your Demons +1 Attack. Deal $1 damage to all enemy minions. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_WITH_RACE = 15
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Impferno_DAL_605()
		{
			// TODO Impferno_DAL_605 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Impferno"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Impferno"));
			//Spell testCard = game.ProcessCard<Spell>("Impferno");
		}

	}

	public class WarriorDalaranTest
	{
		// --------------------------------------- MINION - WARRIOR
		// [DAL_060] Clockwork Goblin - COST:3 [ATK:3/HP:3] 
		// - Race: mechanical, Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Shuffle a Bomb
		//       into your opponent's deck.
		//       When drawn, it explodes
		//       for 5 damage.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ClockworkGoblin_DAL_060()
		{
			// TODO ClockworkGoblin_DAL_060 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Clockwork Goblin"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Clockwork Goblin"));
			//Minion testCard = game.ProcessCard<Minion>("Clockwork Goblin");
		}

		// --------------------------------------- MINION - WARRIOR
		// [DAL_064] Blastmaster Boom - COST:7 [ATK:7/HP:7] 
		// - Set: dalaran, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Summon two 1/1
		//       Boom Bots for each Bomb
		//       in your opponent's deck.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BlastmasterBoom_DAL_064()
		{
			// TODO BlastmasterBoom_DAL_064 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blastmaster Boom"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blastmaster Boom"));
			//Minion testCard = game.ProcessCard<Minion>("Blastmaster Boom");
		}

		// --------------------------------------- MINION - WARRIOR
		// [DAL_070] The Boom Reaver - COST:10 [ATK:7/HP:9] 
		// - Race: mechanical, Set: dalaran, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a copy of a minion in your deck. Give it <b>Rush</b>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheBoomReaver_DAL_070()
		{
			// TODO TheBoomReaver_DAL_070 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Boom Reaver"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Boom Reaver"));
			//Minion testCard = game.ProcessCard<Minion>("The Boom Reaver");
		}

		// --------------------------------------- MINION - WARRIOR
		// [DAL_759] Vicious Scraphound - COST:2 [ATK:2/HP:2] 
		// - Race: mechanical, Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever this minion
		//       deals damage, gain that much Armor.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ViciousScraphound_DAL_759()
		{
			// TODO ViciousScraphound_DAL_759 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Vicious Scraphound"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vicious Scraphound"));
			//Minion testCard = game.ProcessCard<Minion>("Vicious Scraphound");
		}

		// --------------------------------------- MINION - WARRIOR
		// [DAL_770] Omega Devastator - COST:4 [ATK:4/HP:5] 
		// - Race: mechanical, Set: dalaran, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If you have 10
		//       Mana Crystals, deal 10
		//       damage to a minion.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - 84 = 10
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OmegaDevastator_DAL_770()
		{
			// TODO OmegaDevastator_DAL_770 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Omega Devastator"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Omega Devastator"));
			//Minion testCard = game.ProcessCard<Minion>("Omega Devastator");
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [DAL_008] Dr. Boom's Scheme - COST:4 
		// - Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: Gain @ Armor.
		//       <i>(Upgrades each turn!)</i>
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_1 = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DrBoomsScheme_DAL_008()
		{
			// TODO DrBoomsScheme_DAL_008 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dr. Boom's Scheme"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dr. Boom's Scheme"));
			//Spell testCard = game.ProcessCard<Spell>("Dr. Boom's Scheme");
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [DAL_059] Dimensional Ripper - COST:10 
		// - Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: Summon 2 copies of a minion in your deck.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DimensionalRipper_DAL_059()
		{
			// TODO DimensionalRipper_DAL_059 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dimensional Ripper"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dimensional Ripper"));
			//Spell testCard = game.ProcessCard<Spell>("Dimensional Ripper");
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [DAL_062] Sweeping Strikes - COST:2 
		// - Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: Give a minion "Also damages minions next to whomever this attacks."
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void SweepingStrikes_DAL_062()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sweeping Strikes"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sweeping Strikes"));

			Minion left = game.ProcessCard<Minion>("Wisp");
			Minion centre = game.ProcessCard<Minion>("Wisp");
			Minion right = game.ProcessCard<Minion>("Wisp");
			game.EndTurn();

			Minion attacker = game.ProcessCard<Minion>("Bloodfen Raptor");
			Spell testCard = game.ProcessCard<Spell>("Sweeping Strikes", attacker);
			attacker.IsExhausted = false;
			attacker.Attack(centre);
			Assert.Empty(game.CurrentOpponent.BoardZone);
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [DAL_769] Improve Morale - COST:1 
		// - Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: [x]Deal $1 damage
		//       to a minion.
		//       If it survives, add a
		//       <b>Lackey</b> to your hand. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - MARK_OF_EVIL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ImproveMorale_DAL_769()
		{
			// TODO ImproveMorale_DAL_769 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Improve Morale"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Improve Morale"));
			//Spell testCard = game.ProcessCard<Spell>("Improve Morale");
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [DAL_063] Wrenchcalibur - COST:4 [ATK:3/HP:0] 
		// - Set: dalaran, Rarity: epic
		// --------------------------------------------------------
		// Text: After your hero attacks, shuffle a Bomb into your [x]opponent's deck.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Wrenchcalibur_DAL_063()
		{
			// TODO Wrenchcalibur_DAL_063 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wrenchcalibur"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wrenchcalibur"));
			//Weapon testCard = game.ProcessCard<Weapon>("Wrenchcalibur");
		}

	}

	public class NeutralDalaranTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [DAL_058] Hecklebot - COST:4 [ATK:3/HP:8] 
		// - Race: mechanical, Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Battlecry:</b> Your opponent summons a minion from their deck.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Hecklebot_DAL_058()
		{
			// TODO Hecklebot_DAL_058 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hecklebot"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hecklebot"));
			//Minion testCard = game.ProcessCard<Minion>("Hecklebot");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_077] Toxfin - COST:1 [ATK:1/HP:2] 
		// - Race: murloc, Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly Murloc <b>Poisonous</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_WITH_RACE = 14
		// --------------------------------------------------------
		// RefTag:
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Toxfin_DAL_077()
		{
			// TODO Toxfin_DAL_077 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Toxfin"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Toxfin"));
			//Minion testCard = game.ProcessCard<Minion>("Toxfin");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_078] Travelling Healer - COST:4 [ATK:3/HP:2] 
		// - Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Divine Shield</b>
		//       <b>Battlecry:</b> Restore #3 Health.
		// --------------------------------------------------------
		// GameTag:
		// - DIVINE_SHIELD = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TravellingHealer_DAL_078()
		{
			// TODO TravellingHealer_DAL_078 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Travelling Healer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Travelling Healer"));
			//Minion testCard = game.ProcessCard<Minion>("Travelling Healer");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_081] Spellward Jeweler - COST:3 [ATK:3/HP:4] 
		// - Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Your hero can't
		//       be targeted by spells or
		//       Hero Powers until your
		//       next turn.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void SpellwardJeweler_DAL_081()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spellward Jeweler"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spellward Jeweler"));
			Minion testCard = game.ProcessCard<Minion>("Spellward Jeweler");
			Hero hero = game.CurrentPlayer.Hero;
			Assert.True(hero.CantBeTargetedBySpells);
			Assert.True(hero.CantBeTargetedByHeroPowers);
			game.EndTurn();
			Assert.True(hero.CantBeTargetedBySpells);
			Assert.True(hero.CantBeTargetedByHeroPowers);
			game.EndTurn();
			Assert.False(hero.CantBeTargetedBySpells);
			Assert.False(hero.CantBeTargetedByHeroPowers);

		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_085] Dalaran Crusader - COST:5 [ATK:5/HP:4] 
		// - Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Divine Shield</b>
		// --------------------------------------------------------
		// GameTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DalaranCrusader_DAL_085()
		{
			// TODO DalaranCrusader_DAL_085 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dalaran Crusader"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dalaran Crusader"));
			//Minion testCard = game.ProcessCard<Minion>("Dalaran Crusader");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_086] Sunreaver Spy - COST:2 [ATK:2/HP:3] 
		// - Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you control a <b>Secret</b>, gain +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SunreaverSpy_DAL_086()
		{
			// TODO SunreaverSpy_DAL_086 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sunreaver Spy"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sunreaver Spy"));
			//Minion testCard = game.ProcessCard<Minion>("Sunreaver Spy");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_087] Hench-Clan Hag - COST:4 [ATK:3/HP:3] 
		// - Set: dalaran, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon two 1/1 Amalgams with all minion types.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void HenchClanHag_DAL_087()
		{
			// TODO HenchClanHag_DAL_087 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hench-Clan Hag"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			Minion testCard = game.ProcessCard<Minion>("Hench-Clan Hag");
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal("Amalgam", game.CurrentPlayer.BoardZone[0].Card.Name);
			Assert.Equal("Hench-Clan Hag", game.CurrentPlayer.BoardZone[1].Card.Name);
			Assert.Equal("Amalgam", game.CurrentPlayer.BoardZone[2].Card.Name);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_088] Safeguard - COST:6 [ATK:4/HP:5] 
		// - Race: mechanical, Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       <b>Deathrattle:</b> Summon a 0/5
		//       Vault Safe with <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Safeguard_DAL_088()
		{
			// TODO Safeguard_DAL_088 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Safeguard"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Safeguard"));
			//Minion testCard = game.ProcessCard<Minion>("Safeguard");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_089] Spellbook Binder - COST:2 [ATK:3/HP:2] 
		// - Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you have <b>Spell Damage</b>, draw a card.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - SPELLPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SpellbookBinder_DAL_089()
		{
			// TODO SpellbookBinder_DAL_089 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spellbook Binder"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spellbook Binder"));
			//Minion testCard = game.ProcessCard<Minion>("Spellbook Binder");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_090] Hench-Clan Sneak - COST:3 [ATK:3/HP:3] 
		// - Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Stealth</b>
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HenchClanSneak_DAL_090()
		{
			// TODO HenchClanSneak_DAL_090 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hench-Clan Sneak"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hench-Clan Sneak"));
			//Minion testCard = game.ProcessCard<Minion>("Hench-Clan Sneak");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_092] Arcane Servant - COST:2 [ATK:2/HP:3] 
		// - Race: elemental, Set: dalaran, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArcaneServant_DAL_092()
		{
			// TODO ArcaneServant_DAL_092 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arcane Servant"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Servant"));
			//Minion testCard = game.ProcessCard<Minion>("Arcane Servant");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_095] Violet Spellsword - COST:4 [ATK:1/HP:6] 
		// - Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Gain +1 Attack
		//       for each spell in your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VioletSpellsword_DAL_095()
		{
			// TODO VioletSpellsword_DAL_095 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Violet Spellsword"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Violet Spellsword"));
			//Minion testCard = game.ProcessCard<Minion>("Violet Spellsword");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_096] Violet Warden - COST:6 [ATK:4/HP:7] 
		// - Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Spell Damage +1</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - SPELLPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VioletWarden_DAL_096()
		{
			// TODO VioletWarden_DAL_096 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Violet Warden"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Violet Warden"));
			//Minion testCard = game.ProcessCard<Minion>("Violet Warden");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_400] EVIL Cable Rat - COST:2 [ATK:1/HP:1] 
		// - Race: beast, Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add a <b>Lackey</b> to_your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - MARK_OF_EVIL = 1
		// --------------------------------------------------------
		[Fact]
		public void EvilCableRat_DAL_400()
		{
			// TODO EvilCableRat_DAL_400 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			Minion testCard = game.ProcessCard<Minion>("EVIL Cable Rat");

			List<string> lackeyList = new List<string>() {
				"Ethereal Lackey", "Faceless Lackey", "Goblin Lackey","Kobold Lackey","Witchy Lackey",};
			Assert.Single(game.Player1.HandZone);
			Assert.Contains(game.Player1.HandZone[0].Card.Name, lackeyList);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_434] Arcane Watcher - COST:3 [ATK:5/HP:6] 
		// - Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: Can't attack unless you have <b>Spell Damage</b>.
		// --------------------------------------------------------
		// RefTag:
		// - SPELLPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ArcaneWatcher_DAL_434()
		{
			// TODO ArcaneWatcher_DAL_434 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arcane Watcher"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Watcher"));
			//Minion testCard = game.ProcessCard<Minion>("Arcane Watcher");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_538] Unseen Saboteur - COST:6 [ATK:5/HP:6] 
		// - Set: dalaran, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Your opponent casts a random spell from their hand <i>(targets chosen randomly)</i>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void UnseenSaboteur_DAL_538()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Darkest Hour"),
					Cards.FromName("Darkest Hour"),
					Cards.FromName("Darkest Hour"),
					Cards.FromName("Darkest Hour"),
				},
				Player2Deck = new List<Card>
				{
					Cards.FromName("Unseen Saboteur"),
					Cards.FromName("Unseen Saboteur"),
					Cards.FromName("Unseen Saboteur"),
					Cards.FromName("Unseen Saboteur"),
					Cards.FromName("Unseen Saboteur"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unseen Saboteur"));
			//Minion testCard = game.ProcessCard<Minion>("Unseen Saboteur");

			game.ProcessCard("Wisp");
			game.ProcessCard("Wisp");
			game.ProcessCard("Wisp");
			game.ProcessCard("Wisp");
			game.ProcessCard("Wisp");
			Assert.Equal(5, game.CurrentPlayer.BoardZone.Count);
			game.EndTurn();

			game.ProcessCard<Minion>("Unseen Saboteur");
			Assert.Empty(game.CurrentOpponent.BoardZone);
			Assert.Equal(3, game.CurrentOpponent.HandZone.Count);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_539] Sunreaver Warmage - COST:5 [ATK:4/HP:4] 
		// - Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding a spell that costs (5) or more, deal 4 damage.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_DRAG_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SunreaverWarmage_DAL_539()
		{
			// TODO SunreaverWarmage_DAL_539 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sunreaver Warmage"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sunreaver Warmage"));
			//Minion testCard = game.ProcessCard<Minion>("Sunreaver Warmage");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_544] Potion Vendor - COST:1 [ATK:1/HP:1] 
		// - Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Restore #2 Health to all friendly characters.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PotionVendor_DAL_544()
		{
			// TODO PotionVendor_DAL_544 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Potion Vendor"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Potion Vendor"));
			//Minion testCard = game.ProcessCard<Minion>("Potion Vendor");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_546] Barista Lynchen - COST:5 [ATK:4/HP:5] 
		// - Set: dalaran, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add a copy of each of your other <b>Battlecry</b> minions_to_your_hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BaristaLynchen_DAL_546()
		{
			// TODO BaristaLynchen_DAL_546 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Barista Lynchen"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Barista Lynchen"));
			//Minion testCard = game.ProcessCard<Minion>("Barista Lynchen");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_548] Azerite Elemental - COST:5 [ATK:2/HP:7] 
		// - Race: elemental, Set: dalaran, Rarity: epic
		// --------------------------------------------------------
		// Text: At the start of your turn, gain <b>Spell Damage +2</b>.
		// --------------------------------------------------------
		// RefTag:
		// - SPELLPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AzeriteElemental_DAL_548()
		{
			// TODO AzeriteElemental_DAL_548 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Azerite Elemental"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Azerite Elemental"));
			//Minion testCard = game.ProcessCard<Minion>("Azerite Elemental");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_550] Underbelly Ooze - COST:7 [ATK:3/HP:5] 
		// - Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: After this minion survives damage, summon a copy_of it.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnderbellyOoze_DAL_550()
		{
			// TODO UnderbellyOoze_DAL_550 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Underbelly Ooze"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Underbelly Ooze"));
			//Minion testCard = game.ProcessCard<Minion>("Underbelly Ooze");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_551] Proud Defender - COST:4 [ATK:2/HP:6] 
		// - Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       Has +2 Attack while you [x]have no other minions.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ProudDefender_DAL_551()
		{
			// TODO ProudDefender_DAL_551 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Proud Defender"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Proud Defender"));
			//Minion testCard = game.ProcessCard<Minion>("Proud Defender");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_553] Big Bad Archmage - COST:10 [ATK:6/HP:6] 
		// - Set: dalaran, Rarity: epic
		// --------------------------------------------------------
		// Text: At the end of your turn, summon a random
		//       6-Cost minion.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BigBadArchmage_DAL_553()
		{
			// TODO BigBadArchmage_DAL_553 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Big Bad Archmage"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Big Bad Archmage"));
			//Minion testCard = game.ProcessCard<Minion>("Big Bad Archmage");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_554] Chef Nomi - COST:7 [ATK:6/HP:6] 
		// - Set: dalaran, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your deck is empty, summon six 6/6 Greasefire_Elementals.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ChefNomi_DAL_554()
		{
			// TODO ChefNomi_DAL_554 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Chef Nomi"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chef Nomi"));
			//Minion testCard = game.ProcessCard<Minion>("Chef Nomi");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_558] Archmage Vargoth - COST:4 [ATK:2/HP:6] 
		// - Set: dalaran, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]At the end of your turn, cast
		//       a spell you've cast this turn
		//       <i>(targets are random)</i>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact]
		public void ArchmageVargoth_DAL_558()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Archmage Vargoth"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Archmage Vargoth"));
			Minion testCard = game.ProcessCard<Minion>("Archmage Vargoth");
			game.ProcessCard("Fireball", game.CurrentOpponent.Hero);
			game.EndTurn();

			Assert.True(
				game.CurrentPlayer.Hero.Damage == 12 ||
				game.CurrentOpponent.Hero.Damage == 6 ||
				testCard.IsDead);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_560] Heroic Innkeeper - COST:8 [ATK:4/HP:4] 
		// - Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt.</b> <b>Battlecry:</b> Gain +2/+2 for each other friendly minion.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HeroicInnkeeper_DAL_560()
		{
			// TODO HeroicInnkeeper_DAL_560 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Heroic Innkeeper"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Heroic Innkeeper"));
			//Minion testCard = game.ProcessCard<Minion>("Heroic Innkeeper");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_565] Portal Overfiend - COST:6 [ATK:5/HP:6] 
		// - Race: demon, Set: dalaran, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Shuffle 3 Portals
		//       into your deck. When drawn,
		//       summon a 2/2 Demon
		//       with <b>Rush</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PortalOverfiend_DAL_565()
		{
			// TODO PortalOverfiend_DAL_565 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Portal Overfiend"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Portal Overfiend"));
			//Minion testCard = game.ProcessCard<Minion>("Portal Overfiend");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_566] Eccentric Scribe - COST:6 [ATK:6/HP:4] 
		// - Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon
		//       four 1/1 Vengeful Scrolls.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EccentricScribe_DAL_566()
		{
			// TODO EccentricScribe_DAL_566 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Eccentric Scribe"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eccentric Scribe"));
			//Minion testCard = game.ProcessCard<Minion>("Eccentric Scribe");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_582] Portal Keeper - COST:4 [ATK:5/HP:2] 
		// - Race: demon, Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Shuffle 3 Portals
		//       into your deck. When drawn,
		//       summon a 2/2 Demon
		//       with <b>Rush</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PortalKeeper_DAL_582()
		{
			// TODO PortalKeeper_DAL_582 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Portal Keeper"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Portal Keeper"));
			//Minion testCard = game.ProcessCard<Minion>("Portal Keeper");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_592] Batterhead - COST:8 [ATK:3/HP:12] 
		// - Set: dalaran, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Rush</b>. After this attacks and kills a minion, it may_attack again.
		// --------------------------------------------------------
		// GameTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Batterhead_DAL_592()
		{
			// TODO Batterhead_DAL_592 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Batterhead"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Batterhead"));
			//Minion testCard = game.ProcessCard<Minion>("Batterhead");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_735] Dalaran Librarian - COST:2 [ATK:2/HP:3] 
		// - Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Silence</b>
		//       adjacent minions.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - SILENCE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DalaranLibrarian_DAL_735()
		{
			// TODO DalaranLibrarian_DAL_735 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dalaran Librarian"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dalaran Librarian"));
			//Minion testCard = game.ProcessCard<Minion>("Dalaran Librarian");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_736] Archivist Elysiana - COST:8 [ATK:7/HP:7] 
		// - Set: dalaran, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Discover</b> 5 cards. Replace your deck with 2_copies of each.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact]
		public void ArchivistElysiana_DAL_736()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Archivist Elysiana"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			Minion testCard = game.ProcessCard<Minion>("Archivist Elysiana");
			int[] chosen = new int[5];
			for (int i = 0; i < 5; i++)
				chosen[i] = game.ChooseNthChoice(1).Card.AssetId;
			Array.Sort(chosen);
			Assert.Equal(10, game.CurrentPlayer.DeckZone.Count);
			int[] deckDistinct = game.CurrentPlayer.DeckZone.Select(p => p.Card.AssetId).Distinct().OrderBy(p => p)
				.ToArray();

			Assert.True(chosen.SequenceEqual(deckDistinct));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_742] Whirlwind Tempest - COST:8 [ATK:6/HP:6] 
		// - Race: elemental, Fac: neutral, Set: dalaran, Rarity: epic
		// --------------------------------------------------------
		// Text: Your minions with <b>Windfury</b> have <b>Mega-Windfury</b>.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		// RefTag:
		// - WINDFURY = 1
		// - MEGA_WINDFURY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WhirlwindTempest_DAL_742()
		{
			// TODO WhirlwindTempest_DAL_742 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Whirlwind Tempest"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Whirlwind Tempest"));
			//Minion testCard = game.ProcessCard<Minion>("Whirlwind Tempest");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_743] Hench-Clan Hogsteed - COST:2 [ATK:2/HP:1] 
		// - Race: beast, Fac: neutral, Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Rush</b>
		//       <b>Deathrattle:</b> Summon a 1/1 Murloc.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HenchClanHogsteed_DAL_743()
		{
			// TODO HenchClanHogsteed_DAL_743 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hench-Clan Hogsteed"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hench-Clan Hogsteed"));
			//Minion testCard = game.ProcessCard<Minion>("Hench-Clan Hogsteed");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_744] Faceless Rager - COST:3 [ATK:5/HP:1] 
		// - Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Copy a friendly minion's Health.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FacelessRager_DAL_744()
		{
			// TODO FacelessRager_DAL_744 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Faceless Rager"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Faceless Rager"));
			//Minion testCard = game.ProcessCard<Minion>("Faceless Rager");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_747] Flight Master - COST:3 [ATK:3/HP:4] 
		// - Fac: alliance, Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 2/2 Gryphon for each player.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FlightMaster_DAL_747()
		{
			// TODO FlightMaster_DAL_747 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Flight Master"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flight Master"));
			//Minion testCard = game.ProcessCard<Minion>("Flight Master");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_748] Mana Reservoir - COST:2 [ATK:0/HP:6] 
		// - Race: elemental, Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Spell Damage +1</b>
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ManaReservoir_DAL_748()
		{
			// TODO ManaReservoir_DAL_748 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mana Reservoir"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mana Reservoir"));
			//Minion testCard = game.ProcessCard<Minion>("Mana Reservoir");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_749] Recurring Villain - COST:5 [ATK:3/HP:6] 
		// - Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> If this minion has 4 or more Attack, resummon it.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RecurringVillain_DAL_749()
		{
			// TODO RecurringVillain_DAL_749 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Recurring Villain"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Recurring Villain"));
			//Minion testCard = game.ProcessCard<Minion>("Recurring Villain");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_751] Mad Summoner - COST:6 [ATK:4/HP:4] 
		// - Race: demon, Fac: alliance, Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Fill each player's
		//       board with 1/1 Imps.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void MadSummoner_DAL_751()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mad Summoner"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			Minion testCard = game.ProcessCard<Minion>("Mad Summoner");
			Assert.True(game.CurrentPlayer.BoardZone.IsFull);
			Assert.True(game.CurrentOpponent.BoardZone.IsFull);
			Assert.True(game.CurrentOpponent.BoardZone.ToList()
				.TrueForAll(p => p.Card.Name == "Imp"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_752] Jepetto Joybuzz - COST:8 [ATK:6/HP:6] 
		// - Set: dalaran, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Draw 2 minions from your deck. Set their Attack, Health, and Cost to 1.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void JepettoJoybuzz_DAL_752()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Jepetto Joybuzz"),
					Cards.FromName("Jepetto Joybuzz"),
					Cards.FromName("Jepetto Joybuzz"),
					Cards.FromName("Jepetto Joybuzz"),
					Cards.FromName("Jepetto Joybuzz"),
					Cards.FromName("Jepetto Joybuzz"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Jepetto Joybuzz"));
			Minion testCard = game.ProcessCard<Minion>("Jepetto Joybuzz");
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
			IPlayable[] drawnCards = game.CurrentPlayer.HandZone.Skip(4).ToArray();
			Assert.True(Array.TrueForAll(drawnCards, p => p.Card.Type == CardType.MINION));
			Minion[] drawnMinions = drawnCards.Cast<Minion>().ToArray();
			Assert.True(Array.TrueForAll(drawnMinions, p => p.AttackDamage == 1));
			Assert.True(Array.TrueForAll(drawnMinions, p => p.Health == 1));
			Assert.True(Array.TrueForAll(drawnMinions, p => p.Cost == 1 || p.OngoingEffect is AdaptiveCostEffect));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_760] Burly Shovelfist - COST:9 [ATK:9/HP:9] 
		// - Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Rush</b>
		// --------------------------------------------------------
		// GameTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BurlyShovelfist_DAL_760()
		{
			// TODO BurlyShovelfist_DAL_760 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Burly Shovelfist"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Burly Shovelfist"));
			//Minion testCard = game.ProcessCard<Minion>("Burly Shovelfist");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_771] Soldier of Fortune - COST:4 [ATK:5/HP:6] 
		// - Race: elemental, Set: dalaran, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever this minion attacks, give your opponent a Coin.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SoldierOfFortune_DAL_771()
		{
			// TODO SoldierOfFortune_DAL_771 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Soldier of Fortune"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Soldier of Fortune"));
			//Minion testCard = game.ProcessCard<Minion>("Soldier of Fortune");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_773] Magic Carpet - COST:3 [ATK:1/HP:6] 
		// - Set: dalaran, Rarity: epic
		// --------------------------------------------------------
		// Text: After you play a 1-Cost minion, give it +1 Attack and <b>Rush</b>.
		// --------------------------------------------------------
		// RefTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact]
		public void MagicCarpet_DAL_773()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Magic Carpet"),
					Cards.FromName("Magic Carpet"),
					Cards.FromName("Magic Carpet"),
					Cards.FromName("Magic Carpet"),
					Cards.FromName("Magic Carpet"),
					Cards.FromName("Magic Carpet"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Magic Carpet"));
			Minion testCard = game.ProcessCard<Minion>("Magic Carpet", asZeroCost: true);
			game.ProcessCard("Jepetto Joybuzz", asZeroCost: true);
			Minion target = game.ProcessCard<Minion>((Minion)game.CurrentPlayer.HandZone.Last());
			Assert.Equal(target.Card.ATK + 1, target.AttackDamage);
			Assert.True(target.AttackableByRush);

			Minion target2 = game.ProcessCard<Minion>((Minion) game.CurrentPlayer.HandZone[0]);
			Assert.Equal(target2.Card.ATK, target2.AttackDamage);
			Assert.False(target2.AttackableByRush);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_774] Exotic Mountseller - COST:7 [ATK:5/HP:8] 
		// - Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, summon a random
		//       3-Cost Beast.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ExoticMountseller_DAL_774()
		{
			// TODO ExoticMountseller_DAL_774 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Exotic Mountseller"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Exotic Mountseller"));
			//Minion testCard = game.ProcessCard<Minion>("Exotic Mountseller");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [DAL_775] Tunnel Blaster - COST:7 [ATK:3/HP:7] 
		// - Set: dalaran, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       <b>Deathrattle:</b> Deal 3 damage
		//       to all minions.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TunnelBlaster_DAL_775()
		{
			// TODO TunnelBlaster_DAL_775 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tunnel Blaster"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tunnel Blaster"));
			//Minion testCard = game.ProcessCard<Minion>("Tunnel Blaster");
		}

	}

}
