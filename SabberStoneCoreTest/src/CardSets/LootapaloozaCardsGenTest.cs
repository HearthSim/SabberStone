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
using SabberStoneCore.Enums;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;

using Generic = SabberStoneCore.Actions.Generic;
using System.Linq;
using SabberStoneCore.Tasks.PlayerTasks;

namespace SabberStoneCoreTest.CardSets
{
	public class DruidLootapaloozaTest
	{
		// ----------------------------------------- MINION - DRUID
		// [LOOT_048] Ironwood Golem - COST:4 [ATK:3/HP:6] 
		// - Fac: neutral, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       Can only attack if you have 3 or more Armor.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IronwoodGolem_LOOT_048()
		{
			// TODO IronwoodGolem_LOOT_048 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ironwood Golem"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ironwood Golem"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ironwood Golem"));
		}

		// ----------------------------------------- MINION - DRUID
		// [LOOT_056] Astral Tiger - COST:4 [ATK:3/HP:5] 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Shuffle a
		//        copy of this minion into_your_deck.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AstralTiger_LOOT_056()
		{
			// TODO AstralTiger_LOOT_056 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Astral Tiger"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Astral Tiger"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Astral Tiger"));
		}

		// ----------------------------------------- MINION - DRUID
		// [LOOT_314] Grizzled Guardian - COST:8 [ATK:3/HP:5] 
		// - Race: beast, Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Deathrattle:</b> <b>Recruit</b> 2_minions that cost (4)_or_less.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		// RefTag:
		// - RECRUIT = 1
		// --------------------------------------------------------
		[Fact]
		public void GrizzledGuardian_LOOT_314()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grizzled Guardian"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grizzled Guardian"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grizzled Guardian"));

			game.CurrentPlayer.BoardZone[0].Kill();

			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			Assert.True(game.CurrentPlayer.BoardZone.Sum(p => p.Cost) < 9);
		}

		// ----------------------------------------- MINION - DRUID
		// [LOOT_329] Ixlid, Fungal Lord - COST:5 [ATK:2/HP:4] 
		// - Race: elemental, Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: After you play a minion, summon a copy of it.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - 717 = 1
		// --------------------------------------------------------
		[Fact]
		public void IxlidFungalLord_LOOT_329()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ixlid, Fungal Lord"),
					Cards.FromName("Murloc Raider")
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ixlid, Fungal Lord"));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Murloc Raider"));
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
		}

		// ----------------------------------------- MINION - DRUID
		// [LOOT_351] Greedy Sprite - COST:3 [ATK:3/HP:1] 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Gain an empty Mana Crystal.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GreedySprite_LOOT_351()
		{
			// TODO GreedySprite_LOOT_351 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Greedy Sprite"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Greedy Sprite"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Greedy Sprite"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [LOOT_047] Barkskin - COST:1 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: Give a minion +3 Health. Gain 3 Armor.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Barkskin_LOOT_047()
		{
			// TODO Barkskin_LOOT_047 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Barkskin"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Barkskin"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Barkskin"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [LOOT_051] Lesser Jasper Spellstone - COST:1 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $2 damage to a minion. @<i>(Gain 3 Armor to upgrade.)</i> @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_2 = 3
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - ARMOR = 1
		// --------------------------------------------------------
		[Fact]
		public void LesserJasperSpellstone_LOOT_051()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lesser Jasper Spellstone"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lesser Jasper Spellstone"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lesser Jasper Spellstone"));

			game.PlayHeroPower(asZeroCost: true);
			game.CurrentPlayer.Hero.HeroPower.IsExhausted = false;
			Assert.NotEqual("Jasper Spellstone", testCard.Card.Name);
			game.PlayHeroPower(asZeroCost: true);
			game.CurrentPlayer.Hero.HeroPower.IsExhausted = false;
			Assert.NotEqual("Jasper Spellstone", testCard.Card.Name);
			game.PlayHeroPower(asZeroCost: true);
			game.CurrentPlayer.Hero.HeroPower.IsExhausted = false;
			Assert.Equal("Jasper Spellstone", testCard.Card.Name);

			game.PlayHeroPower(asZeroCost: true);
			game.CurrentPlayer.Hero.HeroPower.IsExhausted = false;
			Assert.NotEqual("Greater Jasper Spellstone", testCard.Card.Name);
			game.PlayHeroPower(asZeroCost: true);
			game.CurrentPlayer.Hero.HeroPower.IsExhausted = false;
			Assert.NotEqual("Greater Jasper Spellstone", testCard.Card.Name);
			game.PlayHeroPower(asZeroCost: true);
			game.CurrentPlayer.Hero.HeroPower.IsExhausted = false;
			Assert.Equal("Greater Jasper Spellstone", testCard.Card.Name);
		}

		// ------------------------------------------ SPELL - DRUID
		// [LOOT_054] Branching Paths - COST:4 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Choose Twice -</b> Draw a
		//       card; Give your minions 
		//       +1 Attack; Gain 6 Armor.
		// --------------------------------------------------------
		// Entourage: LOOT_054d, LOOT_054b, LOOT_054c
		// --------------------------------------------------------
		[Fact]
		public void BranchingPaths_LOOT_054()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Branching Paths"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Branching Paths"));

			game.ProcessCard("Stonetusk Boar");
			game.ProcessCard("Stonetusk Boar");

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Branching Paths"));

			Assert.Equal(3, game.CurrentPlayer.Choice.Choices.Count);
			//Assert.True(game.CurrentPlayer.Choice.ChoiceQueue.Count == 1);
			Assert.NotNull(game.CurrentPlayer.Choice.NextChoice);

			game.ChooseNthChoice(1);

			Assert.Equal(4, game.CurrentPlayer.BoardZone.Sum(p => p.AttackDamage));

			game.ChooseNthChoice(2);

			Assert.Equal(6, game.CurrentPlayer.Hero.Armor);
		}

		// ------------------------------------------ SPELL - DRUID
		// [LOOT_309] Oaken Summons - COST:4 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: Gain 6 Armor.
		//       <b>Recruit</b> a minion that costs (4) or less.
		// --------------------------------------------------------
		// RefTag:
		// - RECRUIT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OakenSummons_LOOT_309()
		{
			// TODO OakenSummons_LOOT_309 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Oaken Summons"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Oaken Summons"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Oaken Summons"));
		}

		// ----------------------------------------- WEAPON - DRUID
		// [LOOT_392] Twig of the World Tree - COST:4 [ATK:1/HP:0] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Gain 10 Mana Crystals.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DURABILITY = 5
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void TwigOfTheWorldTree_LOOT_392()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Twig of the World Tree"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twig of the World Tree"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Twig of the World Tree"));

			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.Opponent.Hero));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.Opponent.Hero));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.Opponent.Hero));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.Opponent.Hero));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Player1.BaseMana = 0;
			game.Player2.BaseMana = 0;

			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.Opponent.Hero));
			Assert.Equal(25, game.CurrentPlayer.Opponent.Hero.Health);

			Assert.Equal(10, game.CurrentPlayer.RemainingMana);
		}

	}

	public class HunterLootapaloozaTest
	{
		// ---------------------------------------- MINION - HUNTER
		// [LOOT_078] Cave Hydra - COST:3 [ATK:2/HP:4] 
		// - Race: beast, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: Also damages the minions next to whomever
		//       this attacks.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CaveHydra_LOOT_078()
		{
			// TODO CaveHydra_LOOT_078 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cave Hydra"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cave Hydra"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cave Hydra"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [LOOT_511] Kathrena Winterwisp - COST:8 [ATK:6/HP:6] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry and Deathrattle:</b> <b>Recruit</b> a Beast.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - RECRUIT = 1
		// --------------------------------------------------------
		[Fact]
		public void KathrenaWinterwisp_LOOT_511()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kathrena Winterwisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Nightmare Amalgam"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kathrena Winterwisp"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kathrena Winterwisp"));

			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			Assert.True(game.CurrentPlayer.BoardZone.Last().Card.IsRace(Race.BEAST));

			game.CurrentPlayer.BoardZone[0].Kill();

			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			Assert.True(game.CurrentPlayer.BoardZone.Last().Card.IsRace(Race.BEAST));
		}

		// ---------------------------------------- MINION - HUNTER
		// [LOOT_520] Seeping Oozeling - COST:6 [ATK:5/HP:4] 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Gain the <b>Deathrattle</b> of a random minion in your deck.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void SeepingOozeling_LOOT_520()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Seeping Oozeling"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Kindly Grandmother"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			Assert.Single(game.CurrentPlayer.DeckZone);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Seeping Oozeling"));

			Minion testCard = game.CurrentPlayer.BoardZone[0];

			Assert.Single(testCard.AppliedEnchantments);
			Assert.Single(game.CurrentPlayer.SetasideZone);

			Assert.Equal(testCard.AppliedEnchantments[0][GameTag.TAG_SCRIPT_DATA_NUM_1],
				game.CurrentPlayer.SetasideZone[0].Id);

			game.ProcessCard("Fireball", testCard, true);

			Assert.Single(game.CurrentPlayer.BoardZone);

			Assert.Equal("KAR_005a", game.CurrentPlayer.BoardZone[0].Card.Id);
		}

		// ----------------------------------------- SPELL - HUNTER
		// [LOOT_077] Flanking Strike - COST:4 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $3 damage to a minion. Summon a 3/3 Wolf. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FlankingStrike_LOOT_077()
		{
			// TODO FlankingStrike_LOOT_077 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Flanking Strike"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flanking Strike"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Flanking Strike"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [LOOT_079] Wandering Monster - COST:2 
		// - Fac: neutral, Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When an enemy attacks your hero, summon a 3-Cost minion as the new target.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact]
		public void WanderingMonster_LOOT_079()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wandering Monster"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wandering Monster"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wandering Monster"));

			game.EndTurn();

			var attacker = game.ProcessCard<Minion>("Stonetusk Boar");
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, attacker, game.CurrentOpponent.Hero));

			Assert.Empty(game.CurrentOpponent.SecretZone);
			Assert.True((game.CurrentOpponent.BoardZone.Count == 1 && game.CurrentOpponent.BoardZone[0].Cost == 3) ||
			            (game.CurrentOpponent.BoardZone.Count == 0 && game.CurrentOpponent.GraveyardZone.Last().Cost == 3));

			Assert.Equal(0, game.CurrentOpponent.Hero.Damage);
		}

		// ----------------------------------------- SPELL - HUNTER
		// [LOOT_080] Lesser Emerald Spellstone - COST:5 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: Summon two 3/3_Wolves. <i>(Play a <b>Secret</b> to upgrade.)</i>
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void LesserEmeraldSpellstone_LOOT_080()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lesser Emerald Spellstone"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lesser Emerald Spellstone"));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lesser Emerald Spellstone"));
			IPlayable testCard3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lesser Emerald Spellstone"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard, skipPrePhase: true));
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);

			game.ProcessCard("Twisting Nether", null, true);
			game.ProcessCard("Freezing Trap", null, true);
			Assert.Equal("Emerald Spellstone", testCard2.Card.Name);
			Assert.Equal("Emerald Spellstone", testCard3.Card.Name);

			game.CurrentPlayer.UsedMana = 0;
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard2, skipPrePhase: true));
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);

			game.ProcessCard("Twisting Nether", null, true);
			game.ProcessCard("Explosive Trap", null, true);
			Assert.Equal("Greater Emerald Spellstone", testCard3.Card.Name);

			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard3, skipPrePhase: true));
			Assert.Equal(4, game.CurrentPlayer.BoardZone.Count);
		}

		// ----------------------------------------- SPELL - HUNTER
		// [LOOT_217] To My Side! - COST:6 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]Summon an Animal
		//       Companion, or 2 if your
		//       deck has no minions.
		// --------------------------------------------------------
		// Entourage: NEW1_032, NEW1_033, NEW1_034
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact]
		public void ToMySide_LOOT_217()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.ProcessCard("To My Side!", null, true);
			Assert.Single(game.CurrentPlayer.BoardZone);

			Generic.Draw(game.CurrentPlayer);
			game.ProcessCard("To My Side!", null, true);
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
			Assert.NotEqual(game.CurrentPlayer.BoardZone[1].Card.Id, game.CurrentPlayer.BoardZone[2].Card.Id);
		}

		// ----------------------------------------- SPELL - HUNTER
		// [LOOT_522] Crushing Walls - COST:7 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: Destroy your opponent's left and right-most minions.
		// --------------------------------------------------------
		[Fact]
		public void CrushingWalls_LOOT_522()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.ProcessCard("Bloodfen Raptor");
			game.ProcessCard("Stonetusk Boar");
			game.ProcessCard("Bloodfen Raptor");
			game.EndTurn();

			game.ProcessCard("Crushing Walls");
			Assert.Single(game.CurrentOpponent.BoardZone);
			Assert.Equal("Stonetusk Boar", game.CurrentOpponent.BoardZone[0].Card.Name);
		}

		// ---------------------------------------- WEAPON - HUNTER
		// [LOOT_085] Rhok'delar - COST:7 [ATK:4/HP:0] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your deck has no minions, fill your_hand with Hunter_spells.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DURABILITY = 2
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void Rhokdelar_LOOT_085()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rhok'delar"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rhok'delar"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rhok'delar"));

			Assert.True(game.CurrentPlayer.HandZone.IsFull);

			foreach (var handCard in game.CurrentPlayer.HandZone)
			{
				Assert.True(handCard is Spell);
				Assert.True(handCard.Card.Class == CardClass.HUNTER);
			}
		}

		// ---------------------------------------- WEAPON - HUNTER
		// [LOOT_222] Candleshot - COST:1 [ATK:1/HP:0] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Immune</b> while attacking.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 3
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Candleshot_LOOT_222()
		{
			// TODO Candleshot_LOOT_222 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Candleshot"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Candleshot"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Candleshot"));
		}

	}

	public class MageLootapaloozaTest
	{
		// ------------------------------------------ MINION - MAGE
		// [LOOT_170] Raven Familiar - COST:2 [ATK:2/HP:2] 
		// - Race: beast, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Reveal a spell in each deck. If yours costs more, draw it.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void RavenFamiliar_LOOT_170()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Raven Familiar"),
					Cards.FromName("Raven Familiar"),
					Cards.FromName("Raven Familiar"),
					Cards.FromName("Raven Familiar"),
					Cards.FromName("Raven Familiar"),
					Cards.FromName("Raven Familiar"),
					Cards.FromName("Pyroblast"),
					Cards.FromName("Pyroblast"),
				},
				Player2HeroClass = CardClass.MAGE,
				Player2Deck = new List<Card>
				{
					Cards.FromName("Raven Familiar"),
					Cards.FromName("Raven Familiar"),
					Cards.FromName("Raven Familiar"),
					Cards.FromName("Raven Familiar"),
					Cards.FromName("Raven Familiar"),
					Cards.FromName("Raven Familiar"),
					Cards.FromName("Raven Familiar"),
					Cards.FromName("Fireball"),
				},
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Raven Familiar"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Raven Familiar"));

			Assert.Equal(4, game.CurrentPlayer.HandZone.Count);
			Assert.Equal("Pyroblast", game.CurrentPlayer.HandZone.Last().Card.Name);

			game.EndTurn();
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Raven Familiar"));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			Assert.Equal("Raven Familiar", game.CurrentPlayer.HandZone.Last().Card.Name);
		}

		// ------------------------------------------ MINION - MAGE
		// [LOOT_231] Arcane Artificer - COST:1 [ATK:1/HP:2] 
		// - Race: elemental, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, gain Armor equal to its_Cost.
		// --------------------------------------------------------
		[Fact]
		public void ArcaneArtificer_LOOT_231()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arcane Artificer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Artificer"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Arcane Artificer"));

			game.ProcessCard("Fireball", game.CurrentOpponent.Hero);
			Assert.Equal(4, game.CurrentPlayer.Hero.Armor);

			game.ProcessCard("Sorcerer's Apprentice");
			game.ProcessCard("Fireball", game.CurrentOpponent.Hero);
			Assert.Equal(7, game.CurrentPlayer.Hero.Armor);
		}

		// ------------------------------------------ MINION - MAGE
		// [LOOT_535] Dragoncaller Alanna - COST:9 [ATK:3/HP:3] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 5/5 Dragon for each spell you cast this game that costs (5) or more.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void DragoncallerAlanna_LOOT_535()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dragoncaller Alanna"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.ProcessCard("Twisting Nether", null, true);

			IPlayable testCard1 = game.ProcessCard("Dragoncaller Alanna", null, true);

			Assert.Equal(1, testCard1.ZonePosition);

			game.ProcessCard("Twisting Nether", null, true);
			game.ProcessCard("Twisting Nether", null, true);
			game.ProcessCard("Twisting Nether", null, true);

			IPlayable testCard2 = game.ProcessCard("Dragoncaller Alanna", null, true);
			Assert.Equal(5, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(2, testCard2.ZonePosition);

			game.ProcessCard("Twisting Nether", null, true);
			game.ProcessCard("Twisting Nether", null, true);

			IPlayable testCard3 = game.ProcessCard("Dragoncaller Alanna", null, true);
			Assert.Equal(7, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(3, testCard3.ZonePosition);
		}

		// ------------------------------------------ MINION - MAGE
		// [LOOT_537] Leyline Manipulator - COST:4 [ATK:4/HP:5] 
		// - Race: elemental, Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding any cards that didn't start in your deck, reduce their Cost by (2).
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void LeylineManipulator_LOOT_537()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Leyline Manipulator"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Leyline Manipulator"));

			Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));

			game.ProcessCard("Leyline Manipulator");
			for (int i = 0; i < 4; i++)
				Assert.Equal(1, game.CurrentPlayer.HandZone[i].Cost);
			for (int i = 4; i < 9; i++)
				Assert.Equal(0, game.CurrentPlayer.HandZone[i].Cost);

		}

		// ------------------------------------------- SPELL - MAGE
		// [LOOT_101] Explosive Runes - COST:3 
		// - Fac: neutral, Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Secret:</b> After your opponent plays a minion, deal $6 damage to it and any excess to their hero. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// - ImmuneToSpellpower = 1
		// --------------------------------------------------------
		[Fact]
		public void ExplosiveRunes_LOOT_101()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Explosive Runes"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Explosive Runes"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Explosive Runes"));
			game.EndTurn();

			game.ProcessCard("Stonetusk Boar");
			Assert.Empty(game.CurrentOpponent.SecretZone);
			Assert.Equal(5, game.CurrentPlayer.Hero.Damage);
			Assert.Empty(game.CurrentPlayer.BoardZone);

			game.EndTurn();

			game.ProcessCard("Explosive Runes");
			game.EndTurn();

			Minion target = game.ProcessCard<Minion>("Archmage Antonidas");
			Assert.Empty(game.CurrentOpponent.SecretZone);
			Assert.Equal(6, target.Damage);
			Assert.Equal(5, game.CurrentPlayer.Hero.Damage);

			game.EndTurn();

			game.ProcessCard("Explosive Runes");
			game.EndTurn();

			Minion target2 = game.ProcessCard<Minion>("Argent Squire");
			Assert.Empty(game.CurrentOpponent.SecretZone);
			Assert.Equal(10, game.CurrentPlayer.Hero.Damage);
			Assert.False(target2.IsDead);
			Assert.False(target2.HasDivineShield);
		}

		// ------------------------------------------- SPELL - MAGE
		// [LOOT_103] Lesser Ruby Spellstone - COST:2 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: Add 1 random Mage spell to your hand. @<i>(Play 2 Elementals to_upgrade.)</i>
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_2 = 2
		// --------------------------------------------------------
		[Fact]
		public void LesserRubySpellstone_LOOT_103()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lesser Ruby Spellstone"));

			game.ProcessCard("Arcane Artificer");
			Assert.Equal("Lesser Ruby Spellstone", testCard.Card.Name);
			game.ProcessCard("Arcane Artificer");
			Assert.Equal("Ruby Spellstone", testCard.Card.Name);

			game.ProcessCard("Arcane Artificer");
			Assert.Equal("Ruby Spellstone", testCard.Card.Name);
			game.ProcessCard("Arcane Artificer");
			Assert.Equal("Greater Ruby Spellstone", testCard.Card.Name);
		}

		// ------------------------------------------- SPELL - MAGE
		// [LOOT_104] Shifting Scroll - COST:0 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: Each turn this is in your hand, transform it into a random Mage spell.
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		// PlayReq:
		// - 73 = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShiftingScroll_LOOT_104()
		{
			// TODO ShiftingScroll_LOOT_104 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shifting Scroll"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shifting Scroll"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shifting Scroll"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [LOOT_106] Deck of Wonders - COST:5 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: Shuffle 5 Scrolls into your deck. When drawn, cast a random spell.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DeckOfWonders_LOOT_106()
		{
			// TODO DeckOfWonders_LOOT_106 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Deck of Wonders"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Deck of Wonders"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Deck of Wonders"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [LOOT_172] Dragon's Fury - COST:5 
		// - Fac: neutral, Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: Reveal a spell from your deck. Deal damage equal to its Cost to all_minions. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - AFFECTED_BY_SPELL_POWER = 1
		// --------------------------------------------------------
		[Fact]
		public void DragonsFury_LOOT_172()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Arcane Missiles"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragon's Fury"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dragon's Fury"));

			Minion target = game.ProcessCard<Minion>("Bloodfen Raptor");
			game.ProcessCard("Stonetusk Boar");
			game.ProcessCard("Stonetusk Boar");
			game.ProcessCard("Stonetusk Boar");
			game.ProcessCard("Dragon's Fury");

			Assert.Equal(1, target.Damage);
			Assert.Single(target.Controller.BoardZone);
		}

		// ------------------------------------------ WEAPON - MAGE
		// [LOOT_108] Aluneth - COST:6 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: At the end of your turn, draw 3 cards.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DURABILITY = 3
		// - InvisibleDeathrattle = 1
		// --------------------------------------------------------
		[Fact]
		public void Aluneth_LOOT_108()
		{
			// TODO Aluneth_LOOT_108 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Aluneth"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Aluneth"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(6, game.CurrentOpponent.HandZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(10, game.CurrentOpponent.HandZone.Count);
		}
	}

	public class PaladinLootapaloozaTest
	{
		// --------------------------------------- MINION - PALADIN
		// [LOOT_216] Lynessa Sunsorrow - COST:7 [ATK:1/HP:1] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Cast each spell
		//       you cast on your minions
		//        this game on this one.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void LynessaSunsorrow_LOOT_216()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lynessa Sunsorrow"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lynessa Sunsorrow"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lynessa Sunsorrow"));

			Minion target = game.ProcessCard<Minion>("Lynessa Sunsorrow", null, true);
			game.ProcessCard("Blessing of Might", target, true);
			game.ProcessCard("Blessing of Kings", target, true);
			game.ProcessCard("Blessing of Kings", target, true);
			game.ProcessCard("Hand of Protection", target, true);
			game.ProcessCard("Spikeridged Steed", target, true);

			Minion testCard = game.ProcessCard<Minion>("Lynessa Sunsorrow", null, true);

			Assert.Equal(target.AttackDamage, testCard.AttackDamage);
			Assert.Equal(target.Health, testCard.Health);
			Assert.Equal(target.HasDivineShield, testCard.HasDivineShield);
			Assert.Equal(target.HasDeathrattle, testCard.HasDeathrattle);
		}

		// --------------------------------------- MINION - PALADIN
		// [LOOT_313] Crystal Lion - COST:6 [ATK:5/HP:5] 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Divine Shield</b>
		//       Costs (1) less for each Silver
		//       Hand Recruit you control.
		// --------------------------------------------------------
		// GameTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CrystalLion_LOOT_313()
		{
			// TODO CrystalLion_LOOT_313 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Crystal Lion"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Crystal Lion"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Crystal Lion"));
		}

		// --------------------------------------- MINION - PALADIN
		// [LOOT_363] Drygulch Jailor - COST:2 [ATK:1/HP:1] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Add 3 Silver_Hand Recruits to_your_hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DrygulchJailor_LOOT_363()
		{
			// TODO DrygulchJailor_LOOT_363 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Drygulch Jailor"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Drygulch Jailor"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Drygulch Jailor"));
		}

		// --------------------------------------- MINION - PALADIN
		// [LOOT_398] Benevolent Djinn - COST:3 [ATK:2/HP:4] 
		// - Race: elemental, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: At the end of your turn, restore 3 Health to your_hero.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BenevolentDjinn_LOOT_398()
		{
			// TODO BenevolentDjinn_LOOT_398 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Benevolent Djinn"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Benevolent Djinn"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Benevolent Djinn"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [LOOT_088] Potion of Heroism - COST:2 
		// - Fac: neutral, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: Give a minion <b>Divine_Shield</b>.
		//       Draw a card.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PotionOfHeroism_LOOT_088()
		{
			// TODO PotionOfHeroism_LOOT_088 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Potion of Heroism"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Potion of Heroism"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Potion of Heroism"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [LOOT_091] Lesser Pearl Spellstone - COST:2 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: Summon a 2/2 Spirit with <b>Taunt</b>. @<i>(Restore 3 Health to upgrade.)</i>
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_2 = 3
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - HEALTH = 1
		// --------------------------------------------------------
		[Fact]
		public void LesserPearlSpellstone_LOOT_091()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lesser Pearl Spellstone"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lesser Pearl Spellstone"));

			game.CurrentPlayer.Hero.Damage = 10;
			game.ProcessCard("Benevolent Djinn");
			game.EndTurn();
			Assert.Equal("Pearl Spellstone", testCard.Card.Name);
			game.EndTurn();
			game.EndTurn();
			Assert.Equal("Greater Pearl Spellstone", testCard.Card.Name);
		}

		// ---------------------------------------- SPELL - PALADIN
		// [LOOT_093] Call to Arms - COST:5 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Recruit</b> 3 minions that
		//        cost (2) or less.
		// --------------------------------------------------------
		// RefTag:
		// - RECRUIT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CallToArms_LOOT_093()
		{
			// TODO CallToArms_LOOT_093 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Call to Arms"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Call to Arms"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Call to Arms"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [LOOT_333] Level Up! - COST:5 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: Give your Silver Hand Recruits +2/+2 and_<b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - 717 = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LevelUp_LOOT_333()
		{
			// TODO LevelUp_LOOT_333 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Level Up!"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Level Up!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Level Up!"));
		}

		// --------------------------------------- WEAPON - PALADIN
		// [LOOT_286] Unidentified Maul - COST:3 [ATK:2/HP:0] 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: Gains a bonus effect in_your hand.
		// --------------------------------------------------------
		// Entourage: LOOT_286t2, LOOT_286t3, LOOT_286t1, LOOT_286t4
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnidentifiedMaul_LOOT_286()
		{
			// TODO UnidentifiedMaul_LOOT_286 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unidentified Maul"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unidentified Maul"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Unidentified Maul"));
		}

		// --------------------------------------- WEAPON - PALADIN
		// [LOOT_500] Val'anyr - COST:6 [ATK:4/HP:0] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Give a minion in your hand +4/+2. When it dies, reequip this.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DURABILITY = 2
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void Valanyr_LOOT_500()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Val'anyr"),
					Cards.FromName("Wisp"),
					Cards.FromName("Blessing of Might"),
					Cards.FromName("Blessing of Might"),
					Cards.FromName("Blessing of Might"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Val'anyr"));
			Assert.NotNull(game.CurrentPlayer.Hero.Weapon);
			game.EndTurn();

			game.ProcessCard("Acidic Swamp Ooze");
			Assert.Null(game.CurrentPlayer.Hero.Weapon);

			Minion wisp = game.CurrentOpponent.HandZone[0] as Minion;
			Assert.NotNull(wisp);

			Assert.Equal("Wisp", wisp.Card.Name);
			Assert.Equal(5, wisp.AttackDamage);
			Assert.Equal(3, wisp.Health);
			Assert.True(wisp.HasDeathrattle);

			game.EndTurn();

			game.ProcessCard(wisp);

			wisp.Kill();

			Weapon valanyr = game.CurrentPlayer.Hero.Weapon;
			Assert.NotNull(valanyr);
			Assert.Equal("Val'anyr", valanyr.Card.Name);
		}

	}

	public class PriestLootapaloozaTest
	{
		// ---------------------------------------- MINION - PRIEST
		// [LOOT_410] Duskbreaker - COST:4 [ATK:3/HP:3] 
		// - Race: dragon, Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding
		//       a Dragon, deal 3 damage to all other minions.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_ENEMY_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void Duskbreaker_LOOT_410()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Duskbreaker"),
					Cards.FromName("Drakonid Operative")
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("River Crocolisk"));
			var minion2 = (Minion)Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lorewalker Cho"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Duskbreaker"));
			Assert.True(minion1.ToBeDestroyed);
			Assert.Equal(1, minion2.Health);

			game.CurrentPlayer.UsedMana = 0;
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Drakonid Operative"));
			var testCard2 = (Minion)Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Duskbreaker"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Duskbreaker"));
			Assert.Equal(1, minion2.Health);
		}

		// ---------------------------------------- MINION - PRIEST
		// [LOOT_528] Twilight Acolyte - COST:3 [ATK:2/HP:4] 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding
		//       a Dragon, swap this minion's Attack with another minion's.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND = 0
		// --------------------------------------------------------
		[Fact]
		public void TwilightAcolyte_LOOT_528()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Twilight Drake")
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			var testCard = (Minion)Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twilight Acolyte"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			var testTarget = (Minion)Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ysera"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testTarget));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard, testTarget));
			Assert.Equal(2, testTarget.AttackDamage);
			Assert.Equal(4, testCard.AttackDamage);
		}

		// ---------------------------------------- MINION - PRIEST
		// [LOOT_534] Gilded Gargoyle - COST:3 [ATK:2/HP:2] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Add a Coin to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GildedGargoyle_LOOT_534()
		{
			// TODO GildedGargoyle_LOOT_534 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gilded Gargoyle"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gilded Gargoyle"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gilded Gargoyle"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [LOOT_538] Temporus - COST:7 [ATK:6/HP:6] 
		// - Race: dragon, Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Your opponent takes two turns. Then you take two turns.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void Temporus_LOOT_538()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Temporus"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Temporus"));
			game.EndTurn();
			Assert.Equal(game.Player2, game.CurrentPlayer);
			game.EndTurn();
			Assert.Equal(game.Player2, game.CurrentPlayer);
			game.EndTurn();
			Assert.Equal(game.Player1, game.CurrentPlayer);
			game.EndTurn();
			Assert.Equal(game.Player1, game.CurrentPlayer);
			game.EndTurn();
			Assert.Equal(game.Player2, game.CurrentPlayer);
		}

		// ----------------------------------------- SPELL - PRIEST
		// [LOOT_008] Psychic Scream - COST:7 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: Shuffle all minions into your opponent's deck.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_ENEMY_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void PsychicScream_LOOT_008()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Psychic Scream"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.ProcessCard("Stonetusk Boar");
			game.ProcessCard("Stonetusk Boar");
			game.ProcessCard("Stonetusk Boar");
			game.EndTurn();
			game.ProcessCard("Bloodfen Raptor");
			game.ProcessCard("Bloodfen Raptor");
			game.ProcessCard("Bloodfen Raptor");
			game.EndTurn();

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Psychic Scream"));

			Assert.Equal(6, game.CurrentPlayer.DeckZone.Count);
			Assert.Empty(game.CurrentPlayer.BoardZone);
			Assert.Empty(game.CurrentOpponent.BoardZone);

			Assert.All(game.CurrentPlayer.DeckZone, p => Assert.Equal(p.Controller, game.CurrentPlayer));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [LOOT_187] Twilight's Call - COST:3 
		// - Fac: neutral, Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: Summon 1/1 copies of 2 friendly <b>Deathrattle</b> minions
		//       that died this game.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_FRIENDLY_MINION_DIED_THIS_GAME = 0
		// --------------------------------------------------------
		[Fact]
		public void TwilightsCall_LOOT_187()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Twilight's Call"),
					Cards.FromName("Bloodmage Thalnos"),
					Cards.FromName("Spirit Lash"),
					Cards.FromName("Spirit Lash")
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twilight's Call"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bloodmage Thalnos"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Spirit Lash"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Twilight's Call"));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Spirit Lash"));
			game.CurrentPlayer.UsedMana = 0;
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Twilight's Call"));
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
		}

		// ----------------------------------------- SPELL - PRIEST
		// [LOOT_278] Unidentified Elixir - COST:3 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: Give a minion +2/+2. Gains a bonus effect in_your hand.
		// --------------------------------------------------------
		// Entourage: LOOT_278t1, LOOT_278t2, LOOT_278t3, LOOT_278t4
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void UnidentifiedElixir_LOOT_278()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unidentified Elixir"),
					Cards.FromName("Unidentified Elixir"),
					Cards.FromName("Unidentified Elixir"),
					Cards.FromName("Unidentified Elixir"),
					Cards.FromName("Unidentified Elixir"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			foreach (IPlayable p in game.CurrentPlayer.HandZone)
			{
				Assert.NotEqual("LOOT_278", p.Card.Id);
				Assert.Contains(p.Card.Id, Cards.FromId("LOOT_278").Entourage);
			}

			Assert.Single(game.CurrentPlayer.DeckZone);
			Assert.Equal("LOOT_278", game.CurrentPlayer.DeckZone[0].Card.Id);

			Minion target = game.ProcessCard<Minion>("Bloodfen Raptor");
			IPlayable shadows = Generic.DrawCard(game.CurrentPlayer, Cards.FromId("LOOT_278t3"));
			game.ProcessCard(shadows, target);

			Assert.Equal(5, target.AttackDamage);
			Assert.Equal(4, target.Health);
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(1, game.CurrentPlayer.BoardZone[1].Health);
			Assert.Equal(1, game.CurrentPlayer.BoardZone[1].AttackDamage);
			Assert.Equal("Bloodfen Raptor", game.CurrentPlayer.BoardZone[1].Card.Name);
		}

		// ----------------------------------------- SPELL - PRIEST
		// [LOOT_353] Psionic Probe - COST:1 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: Copy a spell in your opponent's deck and add it to your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PsionicProbe_LOOT_353()
		{
			// TODO PsionicProbe_LOOT_353 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Psionic Probe"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Psionic Probe"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Psionic Probe"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [LOOT_507] Lesser Diamond Spellstone - COST:7 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: Resurrect 2 different friendly minions. @<i>(Cast 4 spells to upgrade.)</i>
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_2 = 4
		// --------------------------------------------------------
		[Fact]
		public void LesserDiamondSpellstone_LOOT_507()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lesser Diamond Spellstone"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			int i = 0;
			do
			{
				if (game.CurrentPlayer.DeckZone[i] is Minion m)
				{
					game.CurrentPlayer.DeckZone.Remove(m);
					game.CurrentPlayer.BoardZone.Add(m);
				}

				i++;
			} while (!game.CurrentPlayer.BoardZone.IsFull && i < 26);

			game.ProcessCard("Twisting Nether", null, true);
			game.ProcessCard("Twisting Nether", null, true);

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lesser Diamond Spellstone"));

			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			Assert.NotEqual(game.CurrentPlayer.BoardZone[0].Card.Id, game.CurrentPlayer.BoardZone[1].Card.Id);
		}

		// ---------------------------------------- WEAPON - PRIEST
		// [LOOT_209] Dragon Soul - COST:3 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: After you cast 3 spells in a turn, summon a 5/5 Dragon.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DURABILITY = 3
		// --------------------------------------------------------
		[Fact]
		public void DragonSoul_LOOT_209()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dragon Soul"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragon Soul"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dragon Soul"));

			game.ProcessCard("Holy Smite", game.CurrentOpponent.Hero);
			game.ProcessCard("Holy Smite", game.CurrentOpponent.Hero);
			game.ProcessCard("Holy Smite", game.CurrentOpponent.Hero);

			Assert.Single(game.CurrentPlayer.BoardZone);
			Assert.Equal("Dragon Spirit", game.CurrentPlayer.BoardZone[0].Card.Name);
			Assert.Equal(0, game.CurrentPlayer.Hero.Weapon[GameTag.TAG_SCRIPT_DATA_NUM_1]);

			game.ProcessCard("Holy Smite", game.CurrentOpponent.Hero);

			game.EndTurn();
			Assert.Equal(0, game.CurrentOpponent.Hero.Weapon[GameTag.TAG_SCRIPT_DATA_NUM_1]);
		}

	}

	public class RogueLootapaloozaTest
	{
		// ----------------------------------------- MINION - ROGUE
		// [LOOT_026] Fal'dorei Strider - COST:4 [ATK:4/HP:4] 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Shuffle 3
		//       Ambushes into your deck.
		//       When drawn, summon
		//       a 4/4 Spider.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void FaldoreiStrider_LOOT_026()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fal'dorei Strider"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fal'dorei Strider"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fal'dorei Strider"));

			game.EndTurn();

			game.EndTurn();

			Assert.Equal(4, game.CurrentPlayer.BoardZone.Count);
		}

		// ----------------------------------------- MINION - ROGUE
		// [LOOT_033] Cavern Shinyfinder - COST:2 [ATK:3/HP:1] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Draw a weapon from your deck.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CavernShinyfinder_LOOT_033()
		{
			// TODO CavernShinyfinder_LOOT_033 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cavern Shinyfinder"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cavern Shinyfinder"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cavern Shinyfinder"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [LOOT_165] Sonya Shadowdancer - COST:3 [ATK:2/HP:2] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: After a friendly minion dies, add a 1/1 copy of it to your hand. It costs (1).
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact]
		public void SonyaShadowdancer_LOOT_165()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sonya Shadowdancer"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.ProcessCard("Sonya Shadowdancer");

			IPlayable target = game.ProcessCard("Bloodfen Raptor");
			game.ProcessCard("Backstab", target);

			var newEntity = game.CurrentPlayer.HandZone.Last() as Minion;

			Assert.NotNull(newEntity);
			Assert.Equal("Bloodfen Raptor", newEntity.Card.Name);
			Assert.Equal(1, newEntity.Cost);
			Assert.Equal(1, newEntity.AttackDamage);
			Assert.Equal(1, newEntity.BaseHealth);

		}

		// ----------------------------------------- MINION - ROGUE
		// [LOOT_211] Elven Minstrel - COST:4 [ATK:3/HP:2] 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Combo:</b> Draw 2 minions from your deck.
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ElvenMinstrel_LOOT_211()
		{
			// TODO ElvenMinstrel_LOOT_211 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Elven Minstrel"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Elven Minstrel"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Elven Minstrel"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [LOOT_412] Kobold Illusionist - COST:4 [ATK:3/HP:3] 
		// - Fac: alliance, Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a 1/1 copy of a minion from your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void KoboldIllusionist_LOOT_412()
		{
			// TODO KoboldIllusionist_LOOT_412 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bloodfen Raptor"),
					Cards.FromName("Bloodfen Raptor"),
					Cards.FromName("Bloodfen Raptor"),
					Cards.FromName("Bloodfen Raptor")
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			IPlayable testCard = game.ProcessCard("Kobold Illusionist");
			game.ProcessCard("Eviscerate", testCard);

			Assert.Single(game.CurrentPlayer.BoardZone);
			Minion target = game.CurrentPlayer.BoardZone[0];
			Assert.Equal("Bloodfen Raptor", target.Card.Name);
			Assert.Equal(1, target.AttackDamage);
			Assert.Equal(1, target.Health);
		}

		// ------------------------------------------ SPELL - ROGUE
		// [LOOT_204] Cheat Death - COST:2 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When a friendly minion dies, return it to your hand.
		//       It costs (2) less.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact]
		public void CheatDeath_LOOT_204()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cheat Death"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cheat Death"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cheat Death"));

			IPlayable target = game.ProcessCard("Stonetusk Boar");
			game.EndTurn();

			game.ProcessCard("Backstab", target);
			Assert.Empty(game.CurrentOpponent.BoardZone);
			Assert.Equal(4, game.CurrentOpponent.HandZone.Count);
			Assert.Equal(target.Id, game.CurrentOpponent.HandZone[3].Id);
			Assert.Equal(0, target.Cost);
		}

		// ------------------------------------------ SPELL - ROGUE
		// [LOOT_210] Sudden Betrayal - COST:2 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When a minion attacks your hero, instead it attacks one of_its neighbors.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact]
		public void SuddenBetrayal_LOOT_210()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sudden Betrayal"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sudden Betrayal"));
			game.EndTurn();

			IPlayable attacker = game.ProcessCard("Patient Assassin");
			attacker.IsExhausted = false;
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, attacker, game.CurrentOpponent.Hero));
			Assert.Single(game.CurrentOpponent.SecretZone);

			IPlayable attacker2 = game.ProcessCard("Boulderfist Ogre");
			attacker2.IsExhausted = false;
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, attacker2, game.CurrentOpponent.Hero));
			Assert.Empty(game.CurrentOpponent.SecretZone);
			Assert.Empty(game.CurrentPlayer.BoardZone);
		}

		// ------------------------------------------ SPELL - ROGUE
		// [LOOT_214] Evasion - COST:2 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Secret:</b> After your hero takes damage, become <b>Immune</b> this turn.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact]
		public void Evasion_LOOT_214()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Evasion"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Evasion"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Evasion"));
			game.EndTurn();

			game.ProcessCard("Arcane Missiles");
			Assert.True(game.CurrentOpponent.Hero.IsImmune);
			Assert.Equal(1, game.CurrentOpponent.Hero.Damage);
			game.EndTurn();

			Assert.False(game.CurrentPlayer.Hero.IsImmune);
		}

		// ------------------------------------------ SPELL - ROGUE
		// [LOOT_503] Lesser Onyx Spellstone - COST:5 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: Destroy 1 random enemy minion.
		//       @<i>(Play 3 <b>Deathrattle</b> cards to upgrade.)</i>
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_2 = 3
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINIMUM_ENEMY_MINIONS = 1
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LesserOnyxSpellstone_LOOT_503()
		{
			// TODO LesserOnyxSpellstone_LOOT_503 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lesser Onyx Spellstone"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lesser Onyx Spellstone"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lesser Onyx Spellstone"));
		}

		// ----------------------------------------- WEAPON - ROGUE
		// [LOOT_542] Kingsbane - COST:1 [ATK:1/HP:3] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Deathrattle:</b> Shuffle
		//       this into your deck.
		//       It keeps any
		//       enchantments.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DURABILITY = 3
		// - DEATHRATTLE = 1
		// - 851 = 1
		// --------------------------------------------------------
		[Fact]
		public void Kingsbane_LOOT_542()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kingsbane"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kingsbane"));
			game.ProcessCard("Deadly Poison");
			game.ProcessCard("Deadly Poison");
			game.ProcessCard("Leeching Poison");
			var weapon = game.CurrentPlayer.Hero.Weapon;
			Assert.True(weapon.AttackDamage == 5 && weapon.HasLifeSteal);
			game.EndTurn();

			IPlayable target = game.ProcessCard("Acidic Swamp Ooze");
			Assert.Null(game.CurrentOpponent.Hero.Weapon);
			Assert.Single(game.CurrentOpponent.DeckZone);
			game.EndTurn();

			Assert.Equal("Kingsbane", game.CurrentPlayer.HandZone[0].Card.Name);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kingsbane"));
			weapon = game.CurrentPlayer.Hero.Weapon;
			Assert.True(weapon.AttackDamage == 5 && weapon.HasLifeSteal);

			int damage = game.CurrentPlayer.Hero.Damage;

			game.ProcessCard("Doomerang", target);

			Assert.Equal(damage - 5, game.CurrentPlayer.Hero.Damage);
			Assert.Single(game.CurrentPlayer.HandZone);
			Assert.Equal(Zone.HAND, weapon.Zone.Type);
			Assert.True(weapon.AttackDamage == 5 && weapon.HasLifeSteal);
		}

	}

	public class ShamanLootapaloozaTest
	{
		// ---------------------------------------- MINION - SHAMAN
		// [LOOT_062] Kobold Hermit - COST:2 [ATK:1/HP:1] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Choose a basic Totem. Summon it.
		// --------------------------------------------------------
		// Entourage: CS2_052, CS2_050, NEW1_009, CS2_051
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void KoboldHermit_LOOT_062()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kobold Hermit"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kobold Hermit"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kobold Hermit"));
			Assert.Equal(4, game.CurrentPlayer.Choice.Choices.Count);
		}

		// ---------------------------------------- MINION - SHAMAN
		// [LOOT_358] Grumble, Worldshaker - COST:6 [ATK:7/HP:7] 
		// - Race: elemental, Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Return your other minions to your hand. They cost (1).
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void GrumbleWorldshaker_LOOT_358()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grumble, Worldshaker"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grumble, Worldshaker"));
			//

			game.ProcessCard("Bloodfen Raptor", null, true);
			game.ProcessCard("Bloodfen Raptor", null, true);
			game.ProcessCard("Bloodfen Raptor", null, true);
			game.ProcessCard("Bloodfen Raptor", null, true);
			game.ProcessCard("Bloodfen Raptor", null, true);
			game.ProcessCard("Bloodfen Raptor", null, true);

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grumble, Worldshaker"));

			Assert.Equal(9, game.CurrentPlayer.HandZone.Count);

			for (int i = 3; i < 9; i++)
			{
				Assert.Equal(1, game.CurrentPlayer.HandZone[i].Cost);
				Assert.Equal("Bloodfen Raptor", game.CurrentPlayer.HandZone[i].Card.Name);
			}
		}

		// ---------------------------------------- MINION - SHAMAN
		// [LOOT_517] Murmuring Elemental - COST:2 [ATK:1/HP:1] 
		// - Race: elemental, Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Your next <b>Battlecry</b> this turn triggers_twice.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void MurmuringElemental_LOOT_517()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Murmuring Elemental"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.ProcessCard("Murmuring Elemental");

			Assert.True(game.CurrentPlayer.ExtraBattlecry);

			Game clone = game.Clone();

			game.EndTurn();
			clone.EndTurn();

			Assert.False(game.CurrentOpponent.ExtraBattlecry);
			Assert.False(clone.CurrentOpponent.ExtraBattlecry);

			game.ProcessCard("Murmuring Elemental");

			clone = game.Clone();

			game.ProcessCard("Elven Archer", game.CurrentOpponent.Hero);
			clone.ProcessCard("Elven Archer", clone.CurrentOpponent.Hero);

			Assert.Equal(2, game.CurrentOpponent.Hero.Damage);
			Assert.Equal(2, clone.CurrentOpponent.Hero.Damage);

			Assert.False(game.CurrentPlayer.ExtraBattlecry);
			Assert.False(clone.CurrentPlayer.ExtraBattlecry);
		}

		// ---------------------------------------- MINION - SHAMAN
		// [LOOT_518] Windshear Stormcaller - COST:5 [ATK:5/HP:5] 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you control all 4 basic Totems, summon Al'Akir_the_Windlord.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void WindshearStormcaller_LOOT_518()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Windshear Stormcaller"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.PlayHeroPower();
			game.CurrentPlayer.Hero.HeroPower.IsExhausted = false;
			game.PlayHeroPower();
			game.CurrentPlayer.Hero.HeroPower.IsExhausted = false;
			game.PlayHeroPower();
			game.CurrentPlayer.Hero.HeroPower.IsExhausted = false;
			game.ProcessCard("Windshear Stormcaller", null, true);
			Assert.Equal(4, game.CurrentPlayer.BoardZone.Count);
			game.PlayHeroPower();
			game.ProcessCard("Windshear Stormcaller", null, true);
			Assert.Equal(7, game.CurrentPlayer.BoardZone.Count);
			Assert.Contains("NEW1_010", game.CurrentPlayer.BoardZone.Select(p => p.Card.Id));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [LOOT_060] Crushing Hand - COST:2 
		// - Fac: neutral, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $8 damage to a minion. <b><b>Overload</b>:</b> (3) @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 3
		// - OVERLOAD_OWED = 3
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CrushingHand_LOOT_060()
		{
			// TODO CrushingHand_LOOT_060 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Crushing Hand"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Crushing Hand"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Crushing Hand"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [LOOT_064] Lesser Sapphire Spellstone - COST:7 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: Summon 1 copy of a friendly minion. @<i>(<b>Overload</b> 3 Mana Crystals to upgrade.)</i>
		// --------------------------------------------------------
		// GameTag:
		// - TAG_SCRIPT_DATA_NUM_2 = 3
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - OVERLOAD = 1
		// --------------------------------------------------------
		[Fact]
		public void LesserSapphireSpellstone_LOOT_064()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lesser Sapphire Spellstone"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lesser Sapphire Spellstone"));

			game.ProcessCard("Lightning Storm", null, true);
			Assert.NotEqual("Sapphire Spellstone", testCard.Card.Name);
			game.ProcessCard("Lightning Storm", null, true);
			Assert.Equal("Sapphire Spellstone", testCard.Card.Name);

			Minion target = game.ProcessCard<Minion>("Injured Blademaster", null, true);

			game.ProcessCard("Primal Talismans", null, true);

			game.ProcessCard(testCard, target, true);

			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);

			Assert.Equal(9, game.CurrentPlayer.BoardZone.Sum(p => p.Health));

			game.ProcessCard("Twisting Nether", null, true);

			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);

			Assert.True(game.CurrentPlayer.BoardZone.ToList().TrueForAll(p => p.Card.IsRace(Race.TOTEM)));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [LOOT_344] Primal Talismans - COST:3 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: Give your minions "<b>Deathrattle:</b> Summon a random basic Totem."
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PrimalTalismans_LOOT_344()
		{
			// TODO PrimalTalismans_LOOT_344 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Primal Talismans"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Primal Talismans"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Primal Talismans"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [LOOT_373] Healing Rain - COST:3 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: Restore #12 Health randomly split among all friendly characters.
		// --------------------------------------------------------
		// GameTag:
		// - ImmuneToSpellpower = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HealingRain_LOOT_373()
		{
			// TODO HealingRain_LOOT_373 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Healing Rain"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Healing Rain"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Healing Rain"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [LOOT_504] Unstable Evolution - COST:1 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: Transform a friendly minion into
		//       one that costs (1) more. Repeatable this turn.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void UnstableEvolution_LOOT_504()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.ProcessCard("Stonetusk Boar");
			game.ProcessCard("Unstable Evolution", game.CurrentPlayer.BoardZone[0]);
			Assert.Equal(2, game.CurrentPlayer.BoardZone[0].Cost);
			Assert.Equal(1, game.CurrentPlayer.HandZone.Count);

			int i = 0;
			while (i != 8)
			{
				game.ProcessCard(game.CurrentPlayer.HandZone.Last(), game.CurrentPlayer.BoardZone[0]);
				i++;
			}

			Assert.Equal(2 + i, game.CurrentPlayer.BoardZone[0].Cost);

			game.EndTurn();

			// random scenarios will add cards to hand (Archmage Antonidas), hand count is not a good test
			//Assert.Equal(4, game.CurrentOpponent.HandZone.Count);
			Assert.All(game.CurrentOpponent.HandZone, c =>
				Assert.NotEqual("Unstable Evolution", c.Card.Name));
		}

		// ---------------------------------------- WEAPON - SHAMAN
		// [LOOT_506] The Runespear - COST:8 [ATK:3/HP:0] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: After your hero attacks, <b>Discover</b> a spell
		//       and cast it with random targets.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DURABILITY = 3
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheRunespear_LOOT_506()
		{
			// TODO TheRunespear_LOOT_506 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Runespear"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Runespear"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Runespear"));
		}

	}

	public class WarlockLootapaloozaTest
	{
		// --------------------------------------- MINION - WARLOCK
		// [LOOT_013] Vulgar Homunculus - COST:2 [ATK:2/HP:4] 
		// - Race: demon, Fac: neutral, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Battlecry:</b> Deal 2 damage to your hero.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void VulgarHomunculus_LOOT_013()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Vulgar Homunculus"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vulgar Homunculus"));
			int previousHealth = game.CurrentPlayer.Hero.Health;
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Vulgar Homunculus"));
			Assert.Equal(previousHealth - 2, game.CurrentPlayer.Hero.Health);
		}

		// --------------------------------------- MINION - WARLOCK
		// [LOOT_014] Kobold Librarian - COST:1 [ATK:2/HP:1] 
		// - Fac: neutral, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Draw a card. Deal 2 damage to your_hero.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void KoboldLibrarian_LOOT_014()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kobold Librarian"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kobold Librarian"));
			int previousHealth = game.CurrentPlayer.Hero.Health;
			int previousCardsInHand = game.CurrentPlayer.HandZone.Count;
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kobold Librarian"));
			Assert.Equal(previousCardsInHand, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(previousHealth - 2, game.CurrentPlayer.Hero.Health);
		}

		// --------------------------------------- MINION - WARLOCK
		// [LOOT_018] Hooked Reaver - COST:4 [ATK:4/HP:4] 
		// - Race: demon, Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you have 15 or_less Health, gain +3/+3_and <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact]
		public void HookedReaver_LOOT_018()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hooked Reaver"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hooked Reaver"));
			var testCard2 = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hooked Reaver"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
			Assert.Equal(testCard.AttackDamage, testCard.Card.ATK);
			Assert.Equal(testCard.Health, testCard.Card.Health);
			Assert.False(testCard.HasTaunt, "Has Taunt with Hero at 30 Health");

			game.CurrentPlayer.Hero.Health = 15;
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard2));
			Assert.Equal(testCard2.AttackDamage, testCard2.Card.ATK + 3);
			Assert.Equal(testCard2.Health, testCard2.Card.Health + 3);
			Assert.True(testCard2.HasTaunt, "Doesn't have Taunt with Hero at 15 Health");
		}

		// --------------------------------------- MINION - WARLOCK
		// [LOOT_306] Possessed Lackey - COST:6 [ATK:2/HP:2] 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> <b>Recruit</b> a_Demon.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		// RefTag:
		// - RECRUIT = 1
		// --------------------------------------------------------
		[Fact]
		public void PossessedLackey_LOOT_306()
		{
			List<Card> demonsInDeck = new List<Card>()
			{
					Cards.FromName("Dread Infernal"),
					Cards.FromName("Voidwalker"),
					Cards.FromName("Felstalker"),
					Cards.FromName("Blood Imp"),
					Cards.FromName("Doomguard"),
					Cards.FromName("Pit Lord"),
					Cards.FromName("Flame Imp"),
					Cards.FromName("Void Terror")
			};
			List<Card> minionsInDeck = new List<Card>()
			{
					Cards.FromName("Elven Archer"),
					Cards.FromName("Ironfur Grizzly"),
					Cards.FromName("Silverback Patriarch"),
					Cards.FromName("Magma Rager"),
					Cards.FromName("Goldshire Footman"),
					Cards.FromName("Kobold Geomancer"),
					Cards.FromName("Lord of the Arena"),
					Cards.FromName("Boulderfist Ogre")
			};
			List<Card> player1Deck = new List<Card>();
			player1Deck.AddRange(minionsInDeck);
			player1Deck.AddRange(demonsInDeck);
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = player1Deck,
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = false
			});

			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			if (game.CurrentPlayer == game.Player2)
			{
				game.Process(EndTurnTask.Any(game.CurrentPlayer));
			}

			foreach (var card in game.CurrentPlayer.HandZone)
			{
				if (minionsInDeck.Contains(card.Card))
				{
					minionsInDeck.Remove(card.Card);
				}
				if (demonsInDeck.Contains(card.Card))
				{
					demonsInDeck.Remove(card.Card);
				}
			}
			int notRecruitedDemons = 0;
			for (int i = 0; i < demonsInDeck.Count; i++)
			{
				game.CurrentPlayer.TemporaryMana = 10;
				var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Possessed Lackey"));
				var darkPact = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dark Pact"));
				int previousBoardAmount = game.CurrentPlayer.BoardZone.Count;
				game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
				game.Process(PlayCardTask.Any(game.CurrentPlayer, darkPact, testCard));
				if (previousBoardAmount < 7)
				{
					Assert.Equal(demonsInDeck.Count + minionsInDeck.Count - i - 1, game.CurrentPlayer.DeckZone.Count);
				}
				else
				{
					Assert.Equal(demonsInDeck.Count + minionsInDeck.Count - i + notRecruitedDemons, game.CurrentPlayer.DeckZone.Count);
					notRecruitedDemons++;
				}
			}

			foreach (var card in game.CurrentPlayer.BoardZone)
			{
				if (minionsInDeck.Contains(card.Card))
				{
					minionsInDeck.Remove(card.Card);
					Assert.True(true, "A Non Demon got Recruited");
				}
				if (demonsInDeck.Contains(card.Card))
				{
					demonsInDeck.Remove(card.Card);
				}
			}
			Assert.True(demonsInDeck.Count == notRecruitedDemons, "Not Every Demon Got Recruited");
		}

		// --------------------------------------- MINION - WARLOCK
		// [LOOT_368] Voidlord - COST:9 [ATK:3/HP:9] 
		// - Race: demon, Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//        <b>Deathrattle:</b> Summon three
		//       1/3 Demons with <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void Voidlord_LOOT_368()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Voidlord"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Voidlord"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Voidlord"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			var twistingNether = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twisting Nether"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, twistingNether));

			Assert.Equal(3, game.CurrentPlayer.Opponent.BoardZone.Count);
			var voidwalker = Cards.FromName("Voidwalker");
			for (int i = 0; i < game.CurrentPlayer.Opponent.BoardZone.Count; i++)
			{
				Assert.Equal(voidwalker, game.CurrentPlayer.Opponent.BoardZone[i].Card);
			}
		}

		// --------------------------------------- MINION - WARLOCK
		// [LOOT_415] Rin, the First Disciple - COST:6 [ATK:3/HP:6] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Deathrattle:</b> Add 'The First Seal' to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - TAUNT = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void RinTheFirstDisciple_LOOT_415()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rin, the First Disciple"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rin, the First Disciple"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));

			game.ProcessCard("Twisting Nether", null, true);
			Assert.Equal("The First Seal", game.CurrentPlayer.HandZone.Last().Card.Name);
			game.ProcessCard(game.CurrentPlayer.HandZone.Last(), asZeroCost:true); // The First Seal
			game.ProcessCard(game.CurrentPlayer.HandZone.Last(), asZeroCost: true); // The Second Seal
			game.ProcessCard(game.CurrentPlayer.HandZone.Last(), asZeroCost: true); // The Third Seal
			game.ProcessCard(game.CurrentPlayer.HandZone.Last(), asZeroCost: true); // The Fourth Seal
			game.ProcessCard(game.CurrentPlayer.HandZone.Last(), asZeroCost: true); // The Final Seal
			game.ProcessCard(game.CurrentPlayer.HandZone.Last(), asZeroCost: true); // Azari, the Devourer

			Assert.Equal("Felhunter", game.CurrentPlayer.BoardZone[0].Card.Name);
			Assert.Equal(2, game.CurrentPlayer.BoardZone[0].AttackDamage);
			Assert.Equal(3, game.CurrentPlayer.BoardZone[1].AttackDamage);
			Assert.Equal(4, game.CurrentPlayer.BoardZone[2].AttackDamage);
			Assert.Equal(5, game.CurrentPlayer.BoardZone[3].AttackDamage);
			Assert.Equal(6, game.CurrentPlayer.BoardZone[4].AttackDamage);
			Assert.Equal(10, game.CurrentPlayer.BoardZone[5].AttackDamage);
			Assert.Empty(game.CurrentOpponent.DeckZone);

		}

		// ---------------------------------------- SPELL - WARLOCK
		// [LOOT_017] Dark Pact - COST:1 
		// - Fac: alliance, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: Destroy a friendly minion. Restore #4 Health to your hero.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact]
		public void DarkPact_LOOT_017()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dark Pact"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			int previousHealth = game.CurrentPlayer.Hero.Health;
			var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dark Pact"));
			var testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dark Pact"));
			var silverback = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Silverback Patriarch"));
			var silverback2 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Silverback Patriarch"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, silverback));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard, silverback));
			Assert.Equal(previousHealth, game.CurrentPlayer.Hero.Health);
			Assert.True(silverback.ToBeDestroyed, "Friendly Minion wasn't Destroyed");

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			var pyroblast = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pyroblast"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, pyroblast, game.CurrentOpponent.Hero));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			previousHealth = game.CurrentPlayer.Hero.Health;
			game.Process(PlayCardTask.Any(game.CurrentPlayer, silverback2));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard2, silverback2));
			Assert.Equal(previousHealth+4, game.CurrentPlayer.Hero.Health);
			Assert.True(silverback2.ToBeDestroyed, "Friendly Minion wasn't Destroyed");
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [LOOT_043] Lesser Amethyst Spellstone - COST:4 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Lifesteal.</b> Deal $3 damage to a minion. <i>(Take damage from your cards to upgrade.)</i> @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void LesserAmethystSpellstone_LOOT_043()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lesser Amethyst Spellstone"));

			game.PlayHeroPower();

			// should not react to the HeroPower
			Assert.NotEqual("Amethyst Spellstone", testCard.Card.Name);

			game.ProcessCard("Vulgar Homunculus");
			Assert.Equal("Amethyst Spellstone", testCard.Card.Name);
			game.EndTurn();

			// should not react to opponent's damaging cards
			game.ProcessCard("Soulfire", game.CurrentOpponent.Hero);
			Assert.NotEqual("Greater Amethyst Spellstone", testCard.Card.Name);
			game.EndTurn();

			game.ProcessCard("Vulgar Homunculus");
			Assert.Equal("Greater Amethyst Spellstone", testCard.Card.Name);
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [LOOT_417] Cataclysm - COST:4 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: Destroy all minions. Discard your hand.
		// --------------------------------------------------------
		// GameTag:
		// - 890 = 10
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Cataclysm_LOOT_417()
		{
			// TODO Cataclysm_LOOT_417 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cataclysm"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cataclysm"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cataclysm"));
		}

		// --------------------------------------- WEAPON - WARLOCK
		// [LOOT_420] Skull of the Man'ari - COST:5 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: At the start of your turn, summon a Demon from your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DURABILITY = 3
		// - InvisibleDeathrattle = 1
		// --------------------------------------------------------
		[Fact]
		public void SkullOfTheManari_LOOT_420()
		{
			// TODO SkullOfTheManari_LOOT_420 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Skull of the Man'ari"),
					Cards.FromName("Voidlord"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Skull of the Man'ari"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Skull of the Man'ari"));
			game.EndTurn();
			game.EndTurn();
			Assert.Single(game.CurrentPlayer.BoardZone);
			Assert.Equal("Voidlord", game.CurrentPlayer.BoardZone[0].Card.Name);
		}

	}

	public class WarriorLootapaloozaTest
	{
		// --------------------------------------- MINION - WARRIOR
		// [LOOT_041] Kobold Barbarian - COST:3 [ATK:4/HP:4] 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: At the start of your turn, attack a random enemy.
		// --------------------------------------------------------
		[Fact]
		public void KoboldBarbarian_LOOT_041()
		{
			// TODO KoboldBarbarian_LOOT_041 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kobold Barbarian"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			Minion testCard = game.ProcessCard<Minion>("Kobold Barbarian");
			game.EndTurn();

			Minion target1 = game.ProcessCard<Minion>("Bloodfen Raptor");
			Minion target2 = game.ProcessCard<Minion>("Stonetusk Boar");
			game.EndTurn();

			Assert.True(testCard.Health == 3 && target2.IsDead || testCard.Health == 1 && target1.IsDead);
		}

		// --------------------------------------- MINION - WARRIOR
		// [LOOT_365] Gemstudded Golem - COST:6 [ATK:5/HP:9] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       Can only attack if you have 5 or more Armor.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact]
		public void GemstuddedGolem_LOOT_365()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gemstudded Golem"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			Minion testCard = game.ProcessCard<Minion>("Gemstudded Golem");
			testCard.IsExhausted = false;
			Assert.False(testCard.CanAttack);

			game.ProcessCard("Shield Block");
			Assert.True(testCard.CanAttack);
		}

		// --------------------------------------- MINION - WARRIOR
		// [LOOT_367] Drywhisker Armorer - COST:2 [ATK:2/HP:2] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> For each enemy minion, gain 2 Armor.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DrywhiskerArmorer_LOOT_367()
		{
			// TODO DrywhiskerArmorer_LOOT_367 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Drywhisker Armorer"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Drywhisker Armorer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Drywhisker Armorer"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [LOOT_519] Geosculptor Yip - COST:8 [ATK:4/HP:8] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: At the end of your turn, summon a random minion with_Cost_equal_to_your Armor <i>(up to 10)</i>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact]
		public void GeosculptorYip_LOOT_519()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Geosculptor Yip"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Geosculptor Yip"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Geosculptor Yip"));

			game.CurrentPlayer.Hero.Armor = 7;

			game.EndTurn();

			Assert.Equal(2, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal(7, game.CurrentOpponent.BoardZone[1].Cost);
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [LOOT_203] Lesser Mithril Spellstone - COST:7 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: Summon one 5/5 Mithril Golem. <i>(Equip a weapon to upgrade.)</i>
		// --------------------------------------------------------
		[Fact]
		public void LesserMithrilSpellstone_LOOT_203()
		{
			// TODO LesserMithrilSpellstone_LOOT_203 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lesser Mithril Spellstone"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lesser Mithril Spellstone"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lesser Mithril Spellstone"));

			game.ProcessCard("Fiery War Axe");
			Assert.Equal("Mithril Spellstone", game.CurrentPlayer.HandZone[0].Card.Name);

			game.ProcessCard("Fiery War Axe");
			Assert.Equal("Greater Mithril Spellstone", game.CurrentPlayer.HandZone[0].Card.Name);
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [LOOT_285] Unidentified Shield - COST:6 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: Gain 5 Armor.
		//       Gains a bonus effect in_your hand.
		// --------------------------------------------------------
		// Entourage: LOOT_285t, LOOT_285t2, LOOT_285t3, LOOT_285t4
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnidentifiedShield_LOOT_285()
		{
			// TODO UnidentifiedShield_LOOT_285 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unidentified Shield"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unidentified Shield"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Unidentified Shield"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [LOOT_364] Reckless Flurry - COST:3 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: Spend all your Armor. Deal that much damage to all minions.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RecklessFlurry_LOOT_364()
		{
			// TODO RecklessFlurry_LOOT_364 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Reckless Flurry"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Reckless Flurry"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Reckless Flurry"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [LOOT_370] Gather Your Party - COST:6 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Recruit</b> a minion.
		// --------------------------------------------------------
		// RefTag:
		// - RECRUIT = 1
		// --------------------------------------------------------
		[Fact]
		public void GatherYourParty_LOOT_370()
		{
			List<Card> minionsInDeck = new List<Card>()
			{
					Cards.FromName("Elven Archer"),
					Cards.FromName("Ironfur Grizzly"),
					Cards.FromName("Silverback Patriarch"),
					Cards.FromName("Magma Rager"),
					Cards.FromName("Goldshire Footman"),
					Cards.FromName("Kobold Geomancer"),
					Cards.FromName("Lord of the Arena"),
					Cards.FromName("Boulderfist Ogre")
			};
			List<Card> player1Deck = new List<Card>();
			player1Deck.AddRange(minionsInDeck);
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = player1Deck,
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = false
			});

			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			if (game.CurrentPlayer == game.Player2)
			{
				game.Process(EndTurnTask.Any(game.CurrentPlayer));
			}

			foreach (var card in game.CurrentPlayer.HandZone)
			{
				if (minionsInDeck.Contains(card.Card))
				{
					minionsInDeck.Remove(card.Card);
				}
			}

			for (int i = 0; i < minionsInDeck.Count; i++)
			{
				game.CurrentPlayer.TemporaryMana = 10;
				var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gather Your Party"));
				game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
				Assert.Equal(minionsInDeck.Count - i - 1, game.CurrentPlayer.DeckZone.Count);
			}

			foreach (var card in game.CurrentPlayer.BoardZone)
			{
				if (minionsInDeck.Contains(card.Card))
				{
					minionsInDeck.Remove(card.Card);
				}
			}
			Assert.True(minionsInDeck.Count == 0, "Not Every Card Got Recruited");
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [LOOT_044] Bladed Gauntlet - COST:2 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: Has Attack equal to your Armor. Can't attack heroes.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// --------------------------------------------------------
		[Fact]
		public void BladedGauntlet_LOOT_044()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bladed Gauntlet"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bladed Gauntlet"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bladed Gauntlet"));

			Assert.Equal(0, game.CurrentPlayer.Hero.AttackDamage);

			game.PlayHeroPower();

			Assert.Equal(2, game.CurrentPlayer.Hero.AttackDamage);

			Assert.False(game.CurrentPlayer.Hero.IsValidAttackTarget(game.CurrentOpponent.Hero));

			Game clone = game.Clone();

			Assert.Equal(clone.CurrentPlayer.Hash(), game.CurrentPlayer.Hash());
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [LOOT_380] Woecleaver - COST:8 [ATK:3/HP:0] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: After your hero attacks, <b>Recruit</b> a minion.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DURABILITY = 3
		// --------------------------------------------------------
		// RefTag:
		// - RECRUIT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Woecleaver_LOOT_380()
		{
			// TODO Woecleaver_LOOT_380 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Woecleaver"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Woecleaver"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Woecleaver"));
		}

	}

	public class NeutralLootapaloozaTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_069] Sewer Crawler - COST:3 [ATK:1/HP:1] 
		// - Fac: neutral, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 2/3_Giant Rat.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void SewerCrawler_LOOT_069()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sewer Crawler"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sewer Crawler"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sewer Crawler"));
			Assert.Equal(game.CurrentPlayer.BoardZone[0].Card, testCard.Card);
			Assert.Equal(game.CurrentPlayer.BoardZone[1].Card, Cards.FromId("LOOT_069t"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_111] Scorp-o-matic - COST:2 [ATK:1/HP:2] 
		// - Race: mechanical, Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy a minion with 1 or less Attack.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_MAX_ATTACK = 1
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact]
		public void ScorpOMatic_LOOT_111()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Scorp-o-matic"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Scorp-o-matic"));
			var testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Scorp-o-matic"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			var elvenArcher = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Elven Archer"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, elvenArcher, game.CurrentPlayer.Opponent.Hero));

			var frostwolfGrunt = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostwolf Grunt"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, frostwolfGrunt, game.CurrentPlayer.Opponent.Hero));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard1, frostwolfGrunt));
			Assert.False(frostwolfGrunt.ToBeDestroyed, "Minion with more than 1 attack got destoryed");
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard2, elvenArcher));
			Assert.True(elvenArcher.ToBeDestroyed, "Minion with less than 1 attack didn't get destoryed");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_117] Wax Elemental - COST:1 [ATK:0/HP:2] 
		// - Race: elemental, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Divine Shield</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WaxElemental_LOOT_117()
		{
			// TODO WaxElemental_LOOT_117 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wax Elemental"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wax Elemental"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wax Elemental"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_118] Ebon Dragonsmith - COST:4 [ATK:3/HP:4] 
		// - Race: dragon, Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Reduce the Cost of a random weapon in your hand by (2).
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void EbonDragonsmith_LOOT_118()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ebon Dragonsmith"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ebon Dragonsmith"));
			var warAxe = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fiery War Axe"));
			var reaper = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcanite Reaper"));
			var yeti = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chillwind Yeti"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ebon Dragonsmith"));
			Assert.Equal(yeti.Cost, yeti.Card.Cost);
			Assert.True(warAxe.Cost == warAxe.Card.Cost - 2 || reaper.Cost == reaper.Card.Cost - 2, "Weapon Discount Failed. Fiery War Axe Cost:" + warAxe.Cost.ToString() + ". Arcanite Reaper Cost: " + reaper.Cost.ToString());
			Assert.False(warAxe.Cost == warAxe.Card.Cost - 2 && reaper.Cost == reaper.Card.Cost - 2, "Both Weapons were Discounted");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_122] Corrosive Sludge - COST:5 [ATK:5/HP:5] 
		// - Fac: alliance, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy your opponent's weapon.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void CorrosiveSludge_LOOT_122()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Corrosive Sludge"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Corrosive Sludge"));
			var yourWeapon = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fiery War Axe"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, yourWeapon));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			var theirWeapon = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fiery War Axe"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, theirWeapon));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));

			Assert.False(game.CurrentPlayer.Hero.Weapon.ToBeDestroyed, "Your Weapon was destroyed");
			Assert.True(game.CurrentPlayer.Opponent.Hero.Weapon == null, "Opponent's Weapon wasn't destroyed");
			if (game.CurrentPlayer.Opponent.Hero.Weapon != null)
			{
				Assert.True(game.CurrentPlayer.Opponent.Hero.Weapon.ToBeDestroyed, "Opponent's Weapon wasn't destroyed");
			}
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_124] Lone Champion - COST:3 [ATK:2/HP:4] 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you control no other minions, gain <b>Taunt</b> and <b>Divine Shield</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact]
		public void LoneChampion_LOOT_124()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lone Champion"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lone Champion"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
			Assert.True(testCard[GameTag.TAUNT] == 1, "Doesn't have Taunt with a open board");
			Assert.True(testCard[GameTag.DIVINE_SHIELD] == 1, "Doesn't have Divine Shield with a open board");
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			var testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lone Champion"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard2));
			Assert.True(testCard2[GameTag.TAUNT] == 1, "Doesn't have Taunt with no friendly minions");
			Assert.True(testCard2[GameTag.DIVINE_SHIELD] == 1, "Doesn't have Divine Shield with no friendly minions");

			var testCard3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lone Champion"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard3));
			Assert.False(testCard3[GameTag.TAUNT] == 1, "Has Taunt with friendly minions");
			Assert.False(testCard3[GameTag.DIVINE_SHIELD] == 1, "Has Divine Shield with friendly minions");

		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_125] Stoneskin Basilisk - COST:3 [ATK:1/HP:1] 
		// - Race: beast, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Divine Shield</b>
		//        <b>Poisonous</b>
		// --------------------------------------------------------
		// GameTag:
		// - DIVINE_SHIELD = 1
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void StoneskinBasilisk_LOOT_125()
		{
			// TODO StoneskinBasilisk_LOOT_125 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stoneskin Basilisk"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stoneskin Basilisk"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stoneskin Basilisk"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_130] Arcane Tyrant - COST:5 [ATK:4/HP:4] 
		// - Race: elemental, Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: Costs (0) if you've cast a spell that costs (5) or more this turn.
		// --------------------------------------------------------
		[Fact]
		public void ArcaneTyrant_LOOT_130()
		{
			// TODO ArcaneTyrant_LOOT_130 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arcane Tyrant"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Tyrant"));

			Assert.Equal(testCard.Cost, testCard.Card.Cost);

			game.ProcessCard("Pyroblast", game.CurrentOpponent.Hero);

			Assert.Equal(0, testCard.Cost);

			Game clone = game.Clone();
			IPlayable cloneTestCard = clone.CurrentPlayer.HandZone[0];
			Assert.Equal(0, cloneTestCard.Cost);

			game.EndTurn();

			Assert.Equal(testCard.Cost, testCard.Card.Cost);

			game.ProcessCard("Pyroblast", game.CurrentOpponent.Hero);

			Assert.Equal(testCard.Cost, testCard.Card.Cost);

			game.EndTurn();

			game.ProcessCard("Pyroblast", game.CurrentOpponent.Hero);

			Assert.Equal(0, testCard.Cost);

			game.ProcessCard(testCard);

			Assert.Equal(testCard.Cost, testCard.Card.Cost);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_131] Green Jelly - COST:5 [ATK:3/HP:3] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: At the end of your turn, summon a 1/2 Ooze with_<b>Taunt</b>.
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GreenJelly_LOOT_131()
		{
			// TODO GreenJelly_LOOT_131 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Green Jelly"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Green Jelly"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Green Jelly"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_132] Dragonslayer - COST:3 [ATK:4/HP:3] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 6 damage to a Dragon.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_TARGET_WITH_RACE = 24
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Dragonslayer_LOOT_132()
		{
			// TODO Dragonslayer_LOOT_132 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dragonslayer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragonslayer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dragonslayer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_134] Toothy Chest - COST:3 [ATK:0/HP:4] 
		// - Fac: neutral, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: At the start of your turn, set this minion's Attack to 4.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ToothyChest_LOOT_134()
		{
			// TODO ToothyChest_LOOT_134 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Toothy Chest"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Toothy Chest"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Toothy Chest"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_136] Sneaky Devil - COST:4 [ATK:2/HP:2] 
		// - Race: demon, Fac: alliance, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Stealth</b>
		//       Your other minions have +1 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SneakyDevil_LOOT_136()
		{
			// TODO SneakyDevil_LOOT_136 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sneaky Devil"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sneaky Devil"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sneaky Devil"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_137] Sleepy Dragon - COST:9 [ATK:4/HP:12] 
		// - Race: dragon, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SleepyDragon_LOOT_137()
		{
			// TODO SleepyDragon_LOOT_137 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sleepy Dragon"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sleepy Dragon"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sleepy Dragon"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_144] Hoarding Dragon - COST:4 [ATK:5/HP:6] 
		// - Race: dragon, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Give your opponent two Coins.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HoardingDragon_LOOT_144()
		{
			// TODO HoardingDragon_LOOT_144 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hoarding Dragon"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hoarding Dragon"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hoarding Dragon"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_149] Corridor Creeper - COST:7 [ATK:2/HP:5] 
		// - Race: beast, Fac: neutral, Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: Costs (1) less whenever a minion dies while this is_in_your hand.
		// --------------------------------------------------------
		[Fact]
		public void CorridorCreeper_LOOT_149()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Corridor Creeper"),
					Cards.FromName("Stonetusk Boar"),
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Corridor Creeper"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stonetusk Boar"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stonetusk Boar"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stonetusk Boar"));
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
			IPlayable aoe = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spirit Lash"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, aoe));
			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(3, testCard.Card.Cost - testCard.Cost);


			Game clone = game.Clone();
			Assert.NotNull(clone.CurrentPlayer.HandZone.Last().ActivatedTrigger);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_150] Furbolg Mossbinder - COST:5 [ATK:1/HP:1] 
		// - Fac: alliance, Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Transform a friendly minion into a 6/6_Elemental.
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
		public void FurbolgMossbinder_LOOT_150()
		{
			// TODO FurbolgMossbinder_LOOT_150 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Furbolg Mossbinder"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Furbolg Mossbinder"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Furbolg Mossbinder"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_152] Boisterous Bard - COST:3 [ATK:3/HP:2] 
		// - Fac: alliance, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give your other minions +1 Health.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BoisterousBard_LOOT_152()
		{
			// TODO BoisterousBard_LOOT_152 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Boisterous Bard"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Boisterous Bard"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Boisterous Bard"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_153] Violet Wurm - COST:8 [ATK:7/HP:7] 
		// - Race: beast, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon seven 1/1 Grubs.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VioletWurm_LOOT_153()
		{
			// TODO VioletWurm_LOOT_153 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Violet Wurm"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Violet Wurm"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Violet Wurm"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_154] Gravelsnout Knight - COST:1 [ATK:2/HP:3] 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a random 1-Cost minion for_your opponent.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void GravelsnoutKnight_LOOT_154()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gravelsnout Knight"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gravelsnout Knight"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gravelsnout Knight"));

			Assert.Single(game.CurrentOpponent.BoardZone);
			Assert.Equal(1, game.CurrentOpponent.BoardZone[0].Cost);

		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_161] Carnivorous Cube - COST:5 [ATK:4/HP:6] 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy
		//       a friendly minion.
		//       <b>Deathrattle:</b> Summon 2 copies of it.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void CarnivorousCube_LOOT_161()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Carnivorous Cube"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Carnivorous Cube"));

			Minion target = game.ProcessCard<Minion>("Voidlord", null, true);

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Carnivorous Cube", target));

			Assert.Equal(4, game.CurrentPlayer.BoardZone.Count);

			game.ProcessCard("Dark Pact", game.CurrentPlayer.BoardZone[0]);

			Assert.Equal(5, game.CurrentPlayer.BoardZone.Count);

			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count(p => p.Card.Name == "Voidlord"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_167] Fungalmancer - COST:5 [ATK:2/HP:2] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give adjacent minions +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Fungalmancer_LOOT_167()
		{
			// TODO Fungalmancer_LOOT_167 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fungalmancer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fungalmancer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fungalmancer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_184] Silver Vanguard - COST:7 [ATK:3/HP:3] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> <b>Recruit</b> an
		//       8-Cost minion.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		// RefTag:
		// - RECRUIT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SilverVanguard_LOOT_184()
		{
			// TODO SilverVanguard_LOOT_184 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Silver Vanguard"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Silver Vanguard"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Silver Vanguard"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_193] Shimmering Courser - COST:4 [ATK:3/HP:3] 
		// - Race: beast, Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: Only you can target
		//       this with spells and
		//       Hero Powers.
		// --------------------------------------------------------
		[Fact]
		public void ShimmeringCourser_LOOT_193()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = (Minion)Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shimmering Courser"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shimmering Courser"));

			Assert.False(testCard.CantBeTargetedBySpells);
			game.EndTurn();
			Assert.True(testCard.CantBeTargetedBySpells);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_218] Feral Gibberer - COST:1 [ATK:1/HP:1] 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: After this minion attacks a hero, add a copy of it to_your hand.
		// --------------------------------------------------------
		[Fact]
		public void FeralGibberer_LOOT_218()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Feral Gibberer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Feral Gibberer"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Feral Gibberer"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Feral Gibberer"));

			game.EndTurn();
			Minion target = game.ProcessCard<Minion>("Stonetusk Boar");
			game.EndTurn();

			int count = game.CurrentPlayer.HandZone.Count;

			game.Process(MinionAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.BoardZone[0], target));
			Assert.Equal(count, game.CurrentPlayer.HandZone.Count);

			game.Process(MinionAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.BoardZone[0], game.CurrentOpponent.Hero));
			Assert.Equal(count + 1, game.CurrentPlayer.HandZone.Count);
			Assert.Equal("Feral Gibberer", game.CurrentPlayer.HandZone.Last().Card.Name);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_233] Cursed Disciple - COST:4 [ATK:5/HP:1] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a 5/1 Revenant.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CursedDisciple_LOOT_233()
		{
			// TODO CursedDisciple_LOOT_233 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cursed Disciple"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cursed Disciple"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cursed Disciple"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_258] Dire Mole - COST:1 [ATK:1/HP:3] 
		// - Race: beast, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DireMole_LOOT_258()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dire Mole"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dire Mole"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dire Mole"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_291] Shroom Brewer - COST:4 [ATK:4/HP:4] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Restore 4_Health.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShroomBrewer_LOOT_291()
		{
			// TODO ShroomBrewer_LOOT_291 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shroom Brewer"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shroom Brewer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shroom Brewer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_315] Trogg Gloomeater - COST:5 [ATK:1/HP:5] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Poisonous</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TroggGloomeater_LOOT_315()
		{
			// TODO TroggGloomeater_LOOT_315 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Trogg Gloomeater"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Trogg Gloomeater"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Trogg Gloomeater"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_347] Kobold Apprentice - COST:3 [ATK:2/HP:1] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 3 damage randomly split among all_enemies.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void KoboldApprentice_LOOT_347()
		{
			// TODO KoboldApprentice_LOOT_347 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kobold Apprentice"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kobold Apprentice"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kobold Apprentice"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_357] Marin the Fox - COST:8 [ATK:6/HP:6] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 0/8 Treasure Chest for your opponent. <i>(Break it for awesome loot!)</i>
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void MarinTheFox_LOOT_357()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Marin the Fox"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Marin the Fox"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Marin the Fox"));

			Assert.Single(game.CurrentOpponent.BoardZone);
			for (int i = 0; i < 10; i++)
			{
				Game clone = game.Clone();
				Minion chest = clone.CurrentOpponent.BoardZone[0];
				chest.Kill();

				Assert.Equal(4, clone.CurrentPlayer.HandZone.Count);

				IPlayable gift = clone.CurrentPlayer.HandZone.Last();

				clone.ProcessCard(gift, null, true);

				HandZone hand = clone.CurrentPlayer.HandZone;

				switch (gift.Card.Id)
				{
					case "LOOT_998k":
						Assert.Equal(2, clone.CurrentPlayer.BoardZone.Count);
						foreach (IPlayable card in hand)
						{
							Assert.IsType<Minion>(card);
							Assert.Equal(Rarity.LEGENDARY, card.Card.Rarity);
						}
						break;
					case "LOOT_998h":
						Assert.True(hand.IsFull);
						bool check = true;
						int id = hand[3].Card.AssetId;
						for (int j = 4; j < 10; j++)
							check &= hand[j].Card.AssetId == id;
						Assert.True(check);
						break;
					case "LOOT_998j":
						Assert.NotNull(clone.CurrentPlayer.Choice);
						if (clone.IdEntityDic[clone.CurrentPlayer.Choice.Choices[0]].Card.Name == "Khadgar")
							clone.ChooseNthChoice(2);	// Don't Choose Khadgar as it would create 3 copies rather than 2.
						else
							clone.ChooseNthChoice(1);
						Assert.Equal(3, clone.CurrentPlayer.BoardZone.Count);
						Assert.Equal(Rarity.LEGENDARY, clone.CurrentPlayer.BoardZone[1].Card.Rarity);
						Assert.Equal(Rarity.LEGENDARY, clone.CurrentPlayer.BoardZone[2].Card.Rarity);
						Assert.Equal(3, hand.Count);
						break;
					case "LOOT_998l":
						Assert.Equal(6, hand.Count);
						Assert.Equal(0, hand[5].Cost);
						Assert.Equal(0, hand[4].Cost);
						Assert.Equal(0, hand[3].Cost);
						break;
				}
			}
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_375] Guild Recruiter - COST:5 [ATK:2/HP:4] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Recruit</b> a minion that costs (4) or less.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - RECRUIT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GuildRecruiter_LOOT_375()
		{
			// TODO GuildRecruiter_LOOT_375 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Guild Recruiter"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Guild Recruiter"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Guild Recruiter"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_382] Kobold Monk - COST:4 [ATK:3/HP:6] 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: Your hero can't be targeted by spells or Hero_Powers.
		// --------------------------------------------------------
		[Fact]
		public void KoboldMonk_LOOT_382()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Kobold Monk"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kobold Monk"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Kobold Monk"));
			game.EndTurn();

			Assert.False(game.CurrentPlayer.Hero.HeroPower.IsValidPlayTarget(game.CurrentOpponent.Hero));

			Spell spell = (Spell) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));

			Assert.False(spell.IsValidPlayTarget(game.CurrentOpponent.Hero));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_383] Hungry Ettin - COST:6 [ATK:4/HP:10] 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Battlecry:</b> Summon a random 2-Cost minion for your opponent.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HungryEttin_LOOT_383()
		{
			// TODO HungryEttin_LOOT_383 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hungry Ettin"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hungry Ettin"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hungry Ettin"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_388] Fungal Enchanter - COST:3 [ATK:3/HP:3] 
		// - Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Restore 2 Health to all friendly characters.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FungalEnchanter_LOOT_388()
		{
			// TODO FungalEnchanter_LOOT_388 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fungal Enchanter"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fungal Enchanter"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fungal Enchanter"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_389] Rummaging Kobold - COST:3 [ATK:1/HP:3] 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Return one of your destroyed weapons to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RummagingKobold_LOOT_389()
		{
			// TODO RummagingKobold_LOOT_389 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rummaging Kobold"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rummaging Kobold"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rummaging Kobold"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_394] Shrieking Shroom - COST:3 [ATK:1/HP:2] 
		// - Set: lootapalooza, Rarity: rare
		// --------------------------------------------------------
		// Text: At the end of your turn, summon a random
		//       1-Cost minion.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShriekingShroom_LOOT_394()
		{
			// TODO ShriekingShroom_LOOT_394 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shrieking Shroom"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shrieking Shroom"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shrieking Shroom"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_413] Plated Beetle - COST:2 [ATK:2/HP:3] 
		// - Race: beast, Set: lootapalooza, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Gain 3 Armor.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PlatedBeetle_LOOT_413()
		{
			// TODO PlatedBeetle_LOOT_413 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Plated Beetle"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Plated Beetle"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Plated Beetle"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_414] Grand Archivist - COST:8 [ATK:4/HP:7] 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: At the end of your turn, cast a spell from your deck <i>(targets chosen randomly)</i>.
		// --------------------------------------------------------
		[Fact]
		public void GrandArchivist_LOOT_414()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Grand Archivist"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Mind Control"),
					Cards.FromName("Mind Control"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grand Archivist"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grand Archivist"));

			game.EndTurn();

			game.ProcessCard("Stonetusk Boar");
			game.EndTurn();

			Assert.Equal(4, game.CurrentPlayer.DeckZone.Count);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Grand Archivist"));
			game.EndTurn();

			Assert.Empty(game.CurrentPlayer.BoardZone);
			Assert.Single(game.CurrentOpponent.GraveyardZone);
			Assert.Equal("Mind Control", game.CurrentOpponent.GraveyardZone[0].Card.Name);
			game.EndTurn();

			Assert.Equal(2, game.CurrentPlayer.DeckZone.Count);
			game.EndTurn();
			Assert.Single(game.CurrentOpponent.GraveyardZone);
			Assert.Equal("Mind Control", game.CurrentOpponent.GraveyardZone[0].Card.Name);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_516] Zola the Gorgon - COST:3 [ATK:2/HP:2] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Choose a friendly minion. Add a Golden copy of it to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ZolaTheGorgon_LOOT_516()
		{
			// TODO ZolaTheGorgon_LOOT_516 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Zola the Gorgon"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Zola the Gorgon"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Zola the Gorgon"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_521] Master Oakheart - COST:9 [ATK:5/HP:5] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Recruit</b> a 1, 2, and 3-Attack minion.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - RECRUIT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MasterOakheart_LOOT_521()
		{
			// TODO MasterOakheart_LOOT_521 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Master Oakheart"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Master Oakheart"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Master Oakheart"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_526] The Darkness - COST:4 [ATK:20/HP:20] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]Starts dormant.
		//       <b>Battlecry:</b> Shuffle 3 Candles
		//       into the enemy deck. When
		//       drawn, this awakens.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void TheDarkness_LOOT_526()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>
				{
					Cards.FromName("The Darkness"),
				},
				Player2HeroClass = CardClass.MAGE,
				Player2Deck = new List<Card>
				{
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
				},
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Darkness"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Darkness"));

			Assert.Equal(3, game.CurrentOpponent.DeckZone.Count);		// three candles
			Assert.True(game.CurrentPlayer.BoardZone.HasUntouchables);	// start dormant
			Assert.Equal(0, game.CurrentPlayer.BoardZone.CountExceptUntouchables);

			game.EndTurn();

			Assert.Equal(1, game.CurrentPlayer.Hero.Damage);			// take 1 fatigue damage
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);

			Assert.Equal(1, game.CurrentOpponent.BoardZone.CountExceptUntouchables);
			Assert.False(game.CurrentOpponent.BoardZone[0].Untouchable);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_529] Void Ripper - COST:3 [ATK:3/HP:3] 
		// - Race: demon, Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Swap the
		//       Attack and Health of all_other_minions.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VoidRipper_LOOT_529()
		{
			// TODO VoidRipper_LOOT_529 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Void Ripper"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Void Ripper"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Void Ripper"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_539] Spiteful Summoner - COST:7 [ATK:4/HP:4] 
		// - Fac: neutral, Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Reveal a spell
		//       from your deck. Summon
		//        a random minion with
		//       the same Cost.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SpitefulSummoner_LOOT_539()
		{
			// TODO SpitefulSummoner_LOOT_539 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spiteful Summoner"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spiteful Summoner"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Spiteful Summoner"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_540] Dragonhatcher - COST:9 [ATK:2/HP:4] 
		// - Set: lootapalooza, Rarity: epic
		// --------------------------------------------------------
		// Text: At the end of your turn, <b>Recruit</b> a Dragon.
		// --------------------------------------------------------
		// RefTag:
		// - RECRUIT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Dragonhatcher_LOOT_540()
		{
			// TODO Dragonhatcher_LOOT_540 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dragonhatcher"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dragonhatcher"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dragonhatcher"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [LOOT_541] King Togwaggle - COST:8 [ATK:5/HP:5] 
		// - Set: lootapalooza, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Swap decks
		//       with your opponent.
		//       Give them a Ransom
		//       spell to swap back.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void KingTogwaggle_LOOT_541()
		{
			var p1Deck = new List<Card>(24);
			Card wisp = Cards.FromName("Wisp");
			for (int i = 0; i < 24; i++)
				p1Deck.Add(wisp);
			var p2Deck = new List<Card>(24);
			Card penguin = Cards.FromName("Snowflipper Penguin");
			for (int i = 0; i < 24; i++)
				p2Deck.Add(penguin);

			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = p1Deck,
				Player2Deck = p2Deck,
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			Assert.Equal(20, game.CurrentPlayer.DeckZone.Count);
			Assert.Equal(20, game.CurrentOpponent.DeckZone.Count);

			game.ProcessCard("King Togwaggle");
			Assert.Equal(21, game.CurrentOpponent.DeckZone.Count);
			Assert.Equal(20, game.CurrentPlayer.DeckZone.Count);

			foreach (IPlayable entity in game.CurrentPlayer.DeckZone)
			{
				Assert.Equal(penguin, entity.Card);
				Assert.Equal(game.CurrentPlayer, entity.Controller);
				Assert.Equal(game.CurrentPlayer.PlayerId, entity[GameTag.CONTROLLER]);
			}

			game.EndTurn();
			if (game.CurrentPlayer.HandZone.Last().Card.Id != "LOOT_541t")
				Generic.Draw(game.CurrentPlayer, game.CurrentPlayer.DeckZone.First(p => p.Card.Id == "LOOT_541t"));

			game.ProcessCard(game.CurrentPlayer.HandZone.Last());

			foreach (IPlayable entity in game.CurrentPlayer.DeckZone)
			{
				Assert.Equal(penguin, entity.Card);
				Assert.Equal(game.CurrentPlayer, entity.Controller);
				Assert.Equal(game.CurrentPlayer.PlayerId, entity[GameTag.CONTROLLER]);
			}
		}

	}

}
