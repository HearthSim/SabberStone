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
using SabberStoneCore.Model.Entities;
using System.Collections.Generic;
using System.Linq;
using SabberStoneCore.Actions;
using SabberStoneCore.Tasks.PlayerTasks;

namespace SabberStoneCoreTest.CardSets.Standard
{
	public class HeroesGilneasTest
	{
		// ------------------------------------------ HERO - SHAMAN
		// [GIL_504] Hagatha the Witch - COST:8 [ATK:0/HP:30] 
		// - Set: gilneas, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Deal 3 damage to all minions.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 47631
		// --------------------------------------------------------
		[Fact]
		public void HagathaTheWitch_GIL_504()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hagatha the Witch"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hagatha the Witch"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hagatha the Witch"));
			Assert.Equal(5, game.CurrentPlayer.Hero.Armor);
			Assert.Equal("GIL_504h", game.CurrentPlayer.Hero.HeroPower.Card.Id);

			game.ProcessCard("Stonetusk Boar");

			Assert.Single(game.CurrentPlayer.HandZone);
			IPlayable card = game.CurrentPlayer.HandZone[0];
			Assert.Equal(CardClass.SHAMAN, card.Card.Class);
			Assert.Equal(CardType.SPELL, card.Card.Type);
		}

	}

	public class HeroPowersGilneasTest
	{
		// ----------------------------------- HERO_POWER - NEUTRAL
		// [GIL_504h] Bewitch (*) - COST:0 
		// - Set: gilneas, 
		// --------------------------------------------------------
		// Text: [x]<b>Passive Hero Power</b>
		//       After you play a minion,
		//       add a random Shaman
		//       spell to your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Bewitch_GIL_504h()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bewitch"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bewitch"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bewitch"));
		}

	}

	public class DruidGilneasTest
	{
		// ----------------------------------------- MINION - DRUID
		// [GIL_130] Gloom Stag - COST:5 [ATK:2/HP:6] 
		// - Race: beast, Set: gilneas, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Battlecry:</b> If your deck has only odd-Cost cards, gain +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void GloomStag_GIL_130()
		{
			// TODO GloomStag_GIL_130 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gloom Stag"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Core Hound"),
					Cards.FromName("Nightblade"),
					Cards.FromName("Dalaran Mage"),
					Cards.FromName("Stonetusk Boar"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gloom Stag"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gloom Stag"));

			Assert.Single(game.CurrentPlayer.BoardZone);
			Minion stag1 = game.CurrentPlayer.BoardZone[0];
			Assert.Equal(4, stag1.AttackDamage);
			Assert.Equal(8, stag1.Health);

			game.ProcessCard("Fal'dorei Strider", null, true);
			Minion stag2 = game.ProcessCard<Minion>("Gloom Stag", null, true);
			Assert.Equal(2, stag2.AttackDamage);
			Assert.Equal(6, stag2.Health);
		}

		// ----------------------------------------- MINION - DRUID
		// [GIL_188] Druid of the Scythe - COST:3 [ATK:2/HP:2] 
		// - Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Choose One -</b> Transform
		//       into a 4/2 with <b>Rush</b>;
		//       or a 2/4 with <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact]
		public void DruidOfTheScythe_GIL_188()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Druid of the Scythe"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Druid of the Scythe"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Druid of the Scythe"));

			game.ProcessCard<Minion>("Druid of the Scythe", null, true, 1);
			Minion a = game.CurrentPlayer.BoardZone[0];
			game.ProcessCard<Minion>("Druid of the Scythe", null, true, 2);
			Minion b = game.CurrentPlayer.BoardZone[1];

			Assert.True(a.IsRush);
			Assert.False(a.HasTaunt);

			Assert.False(b.IsRush);
			Assert.True(b.HasTaunt);
		}

		// ----------------------------------------- MINION - DRUID
		// [GIL_507] Bewitched Guardian - COST:5 [ATK:4/HP:1] 
		// - Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       <b>Battlecry:</b> Gain +1 Health
		//       _for each card in your hand._
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void BewitchedGuardian_GIL_507()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bewitched Guardian"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bewitched Guardian"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bewitched Guardian"));
			Assert.Equal(game.CurrentPlayer.BoardZone[0].Health,
				game.CurrentPlayer.BoardZone[0].Card[GameTag.HEALTH] + game.CurrentPlayer.HandZone.Count);
		}

		// ----------------------------------------- MINION - DRUID
		// [GIL_658] Splintergraft - COST:8 [ATK:8/HP:8] 
		// - Set: gilneas, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Choose a friendly
		//       minion. Add a 10/10 copy to
		//       your hand that costs (10).
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
		[Fact]
		public void Splintergraft_GIL_658()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Splintergraft"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Splintergraft"));
			//

			Minion target = game.ProcessCard<Minion>("Stonetusk Boar");
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Splintergraft", target));

			Assert.Single(game.CurrentPlayer.HandZone);
			Minion copied = (Minion)game.CurrentPlayer.HandZone[0];
			Assert.Equal(10, copied.AttackDamage);
			Assert.Equal(10, copied.Health);
			Assert.Equal(10, copied.Cost);
		}

		// ----------------------------------------- MINION - DRUID
		// [GIL_800] Duskfallen Aviana - COST:5 [ATK:3/HP:7] 
		// - Set: gilneas, Rarity: legendary
		// --------------------------------------------------------
		// Text: On each player's turn, the first card played costs (0).
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - AURA = 1
		// --------------------------------------------------------
		[Fact]
		public void DuskfallenAviana_GIL_800()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Duskfallen Aviana"),
					Cards.FromName("Snowfury Giant"),
					Cards.FromName("Snowfury Giant"),
				},
				Player2Deck = new List<Card>
				{
					Cards.FromName("Snowfury Giant"),
					Cards.FromName("Snowfury Giant"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Duskfallen Aviana"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Duskfallen Aviana"));
			game.EndTurn();

			Assert.Equal(0, game.CurrentPlayer.HandZone[0].Cost);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, game.CurrentPlayer.HandZone[0]));
			Assert.Equal(11, game.CurrentPlayer.HandZone[0].Cost);
			game.EndTurn();

			Assert.Equal(0, game.CurrentPlayer.HandZone[0].Cost);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, game.CurrentPlayer.HandZone[0]));
			Assert.Equal(11, game.CurrentPlayer.HandZone[0].Cost);
		}

		// ----------------------------------------- MINION - DRUID
		// [GIL_833] Forest Guide - COST:4 [ATK:1/HP:6] 
		// - Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: At the end of your turn, both players draw a card.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ForestGuide_GIL_833()
		{
			// TODO ForestGuide_GIL_833 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Forest Guide"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Forest Guide"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Forest Guide"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [GIL_553] Wispering Woods - COST:4 
		// - Set: gilneas, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]Summon a 1/1 Wisp for
		//       each card in your hand.
		// --------------------------------------------------------
		[Fact]
		public void WisperingWoods_GIL_553()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wispering Woods"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wispering Woods"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wispering Woods"));

			Assert.Equal(game.CurrentPlayer.BoardZone.Count, game.CurrentPlayer.HandZone.Count);
			Assert.True(game.CurrentPlayer.BoardZone.ToList().TrueForAll(m => m.Card.Id == "GIL_553t"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [GIL_571] Witching Hour - COST:3 
		// - Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: Summon a random friendly Beast that died this game.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// - REQ_FRIENDLY_MINIONS_OF_RACE_DIED_THIS_GAME = 20
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WitchingHour_GIL_571()
		{
			// TODO WitchingHour_GIL_571 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Witching Hour"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Witching Hour"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Witching Hour"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [GIL_637] Ferocious Howl - COST:3 
		// - Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: Draw a card.
		//       Gain 1 Armor for each card in your hand.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FerociousHowl_GIL_637()
		{
			// TODO FerociousHowl_GIL_637 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ferocious Howl"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ferocious Howl"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ferocious Howl"));
		}

		// ------------------------------------------ SPELL - DRUID
		// [GIL_663] Witchwood Apple - COST:2 
		// - Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: Add three 2/2 Treants to your hand.
		// --------------------------------------------------------
		[Fact]
		public void WitchwoodApple_GIL_663()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Witchwood Apple"),
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Witchwood Apple"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Witchwood Apple"));

			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
			Assert.True(game.CurrentPlayer.HandZone.TakeLast(3).ToList().TrueForAll(p => p.Card.Id == "GIL_663t"));
		}

	}

	public class HunterGilneasTest
	{
		// ---------------------------------------- MINION - HUNTER
		// [GIL_128] Emeriss - COST:10 [ATK:8/HP:8] 
		// - Race: dragon, Set: gilneas, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Double the Attack and Health of all minions in_your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void Emeriss_GIL_128()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Emeriss"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Emeriss"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Emeriss"));

			foreach (Minion m in game.CurrentPlayer.HandZone.Where(p => p is Minion))
			{
				Assert.Equal(m.AttackDamage, m.Card[GameTag.ATK] * 2);
				Assert.Equal(m.Health, m.Card[GameTag.HEALTH] * 2);
			}
		}

		// ---------------------------------------- MINION - HUNTER
		// [GIL_200] Duskhaven Hunter - COST:3 [ATK:2/HP:5] 
		// - Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Stealth</b>
		//       Each turn this is in your hand,
		//       swap its Attack and Health.
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact]
		public void DuskhavenHunter_GIL_200()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Duskhaven Hunter"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Duskhaven Hunter"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Duskhaven Hunter"));

			Assert.Equal("GIL_200", game.CurrentPlayer.HandZone[0].Card.Id);
			Assert.Equal(2, game.CurrentPlayer.HandZone[0][GameTag.ATK]);
			Assert.Equal(5, game.CurrentPlayer.HandZone[0][GameTag.HEALTH]);
			game.EndTurn();
			game.EndTurn();

			Assert.Equal("GIL_200t", game.CurrentPlayer.HandZone[0].Card.Id);
			Assert.Equal(5, game.CurrentPlayer.HandZone[0][GameTag.ATK]);
			Assert.Equal(2, game.CurrentPlayer.HandZone[0][GameTag.HEALTH]);
			game.EndTurn();
			game.EndTurn();

			Assert.Equal("GIL_200", game.CurrentPlayer.HandZone[0].Card.Id);
			Assert.Equal(2, game.CurrentPlayer.HandZone[0][GameTag.ATK]);
			Assert.Equal(5, game.CurrentPlayer.HandZone[0][GameTag.HEALTH]);
		}

		// ---------------------------------------- MINION - HUNTER
		// [GIL_562] Vilebrood Skitterer - COST:5 [ATK:1/HP:3] 
		// - Race: beast, Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Poisonous</b>
		//       <b>Rush</b>
		// --------------------------------------------------------
		// GameTag:
		// - POISONOUS = 1
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VilebroodSkitterer_GIL_562()
		{
			// TODO VilebroodSkitterer_GIL_562 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Vilebrood Skitterer"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vilebrood Skitterer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Vilebrood Skitterer"));
		}

		// ---------------------------------------- MINION - HUNTER
		// [GIL_607] Toxmonger - COST:4 [ATK:2/HP:4] 
		// - Set: gilneas, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]Whenever you play a 1-Cost
		//       minion, give it <b>Poisonous</b>.
		// --------------------------------------------------------
		// RefTag:
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact]
		public void Toxmonger_GIL_607()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Toxmonger"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Toxmonger"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Toxmonger"));

			Minion target1 = game.ProcessCard<Minion>("Stonetusk Boar");
			Assert.True(target1.Poisonous);

			Minion target2 = game.ProcessCard<Minion>("Bloodfen Raptor");
			Assert.False(target2.Poisonous);
		}

		// ---------------------------------------- MINION - HUNTER
		// [GIL_607t] Hunting Mastiff - COST:2 [ATK:2/HP:1] 
		// - Race: beast, Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Echo</b>
		//       <b>Rush</b>
		// --------------------------------------------------------
		// GameTag:
		// - RUSH = 1
		// - ECHO = 1
		// --------------------------------------------------------
		[Fact]
		public void HuntingMastiff_GIL_607t()
		{
			// TODO HuntingMastiff_GIL_607t test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hunting Mastiff"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.EndTurn();
			IPlayable target = game.ProcessCard("Stonetusk Boar");
			game.EndTurn();
			
			// Echo Test
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hunting Mastiff"));

			IPlayable echo = game.CurrentPlayer.HandZone.Last();
			Assert.Equal("GIL_607t", echo.Card.Id);
			Assert.Equal(1, echo[GameTag.GHOSTLY]);

			game.Process(PlayCardTask.Any(game.CurrentPlayer, echo));
			IPlayable echo2 = game.CurrentPlayer.HandZone.Last();
			Assert.Equal("GIL_607t", echo2.Card.Id);
			Assert.Equal(1, echo2[GameTag.GHOSTLY]);

			// Rush Test
			var rush = echo as Minion;
			Assert.NotNull(rush);
			Assert.False(rush.IsExhausted);
			Assert.True(rush.AttackableByRush);
			Assert.Single(rush.ValidAttackTargets);
			Assert.False(rush.IsValidAttackTarget(game.CurrentPlayer.Opponent.Hero));

			game.EndTurn();

			Assert.Equal(game.CurrentOpponent.SetasideZone, echo2.Zone);
			Assert.False(rush.AttackableByRush);
		}

		// ---------------------------------------- MINION - HUNTER
		// [GIL_650] Houndmaster Shaw - COST:4 [ATK:3/HP:6] 
		// - Set: gilneas, Rarity: legendary
		// --------------------------------------------------------
		// Text: Your other minions have
		//       <b>Rush</b>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - AURA = 1
		// --------------------------------------------------------
		// RefTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact]
		public void HoundmasterShaw_GIL_650()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Houndmaster Shaw"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Houndmaster Shaw"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Houndmaster Shaw"));

			Minion test1 = game.ProcessCard<Minion>("Bloodfen Raptor");

			Assert.True(test1.IsRush);
			Assert.False(test1.IsExhausted);

			Game clone = game.Clone();

			Minion cube = game.ProcessCard<Minion>("Carnivorous Cube", game.CurrentPlayer.BoardZone[0], true);
			Minion cloneCube = clone.ProcessCard<Minion>("Carnivorous Cube", clone.CurrentPlayer.BoardZone[0], true);

			Assert.False(cube.IsRush);
			Assert.False(test1.IsRush);
			Assert.False(cloneCube.IsRush);

			cube.Kill();
			cloneCube.Kill();
			
		}

		// ---------------------------------------- MINION - HUNTER
		// [GIL_905] Carrion Drake - COST:5 [ATK:3/HP:7] 
		// - Race: dragon, Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If a minion died this turn, gain <b>Poisonous</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CarrionDrake_GIL_905()
		{
			// TODO CarrionDrake_GIL_905 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Carrion Drake"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Carrion Drake"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Carrion Drake"));
		}

		// ----------------------------------------- SPELL - HUNTER
		// [GIL_518] Wing Blast - COST:4 
		// - Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $4 damage to a minion. If a minion died this turn, this costs (1). @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void WingBlast_GIL_518()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wing Blast"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wing Blast"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wing Blast"));

			Assert.Equal(testCard.Card.Cost, testCard.Cost);

			Minion test = game.ProcessCard<Minion>("Stonetusk Boar");
			test.Kill();

			Assert.Equal(1, testCard.Cost);
		}

		// ----------------------------------------- SPELL - HUNTER
		// [GIL_577] Rat Trap - COST:2 
		// - Set: gilneas, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Secret:</b> After your
		//       opponent plays three
		//       cards in a turn, summon
		//       a 6/6 Rat.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact]
		public void RatTrap_GIL_577()
		{ 
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rat Trap"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rat Trap"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rat Trap"));
			game.EndTurn();

			game.ProcessCard("Stonetusk Boar");
			Assert.Empty(game.CurrentOpponent.BoardZone);
			game.EndTurn();
			game.EndTurn();

			game.ProcessCard("Stonetusk Boar");
			game.ProcessCard("Stonetusk Boar");
			Assert.Empty(game.CurrentOpponent.BoardZone);
			game.EndTurn();
			game.EndTurn();

			game.ProcessCard("Stonetusk Boar");
			game.ProcessCard("Stonetusk Boar");
			game.ProcessCard("Stonetusk Boar");
			Assert.Single(game.CurrentOpponent.BoardZone);
			Assert.Empty(game.CurrentOpponent.SecretZone);
		}

		// ----------------------------------------- SPELL - HUNTER
		// [GIL_828] Dire Frenzy - COST:4 
		// - Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: Give a Beast +3/+3. Shuffle 3 copies into your deck with +3/+3.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_WITH_RACE = 20
		// --------------------------------------------------------
		[Fact]
		public void DireFrenzy_GIL_828()
		{
			// TODO DireFrenzy_GIL_828 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dire Frenzy"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,

			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dire Frenzy"));
			

			Minion target = game.ProcessCard<Minion>("Stonetusk Boar");
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dire Frenzy", target));

			Assert.Equal(4, target.AttackDamage);
			Assert.Equal(4, target.Health);

			Assert.Equal(3, game.CurrentPlayer.DeckZone.Count);
			foreach (IPlayable card in game.CurrentPlayer.DeckZone)
			{
				var m = card as Minion;
				Assert.NotNull(m);
				Assert.Equal("Stonetusk Boar", m.Card.Name);
				Assert.Equal(4, m.AttackDamage);
				Assert.Equal(4, m.Health);
			}
		}

	}

	public class MageGilneasTest
	{
		// ------------------------------------------ MINION - MAGE
		// [GIL_116] Arcane Keysmith - COST:4 [ATK:2/HP:2] 
		// - Set: gilneas, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Discover</b> a <b>Secret</b>. Put it into the battlefield.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact]
		public void ArcaneKeysmith_GIL_116()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arcane Keysmith"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Keysmith"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Arcane Keysmith"));

			Assert.NotNull(game.CurrentPlayer.Choice);
			Assert.True(game.CurrentPlayer.Choice.Choices.Select(p => game.IdEntityDic[p]).ToList()
				.TrueForAll(p => p.Card.IsSecret && p.Card.Class == CardClass.MAGE));

			IPlayable pick = game.IdEntityDic[game.CurrentPlayer.Choice.Choices[0]];
			game.ChooseNthChoice(1);
			Assert.Single(game.CurrentPlayer.SecretZone);
			Assert.Equal(pick.Card.Name, game.CurrentPlayer.SecretZone[0].Card.Name);
		}

		// ------------------------------------------ MINION - MAGE
		// [GIL_549] Toki, Time-Tinker - COST:6 [ATK:5/HP:5] 
		// - Set: gilneas, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Add a random
		//       <b>Legendary</b> minion from
		//       the past to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void TokiTimeTinker_GIL_549()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Toki, Time-Tinker"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Toki, Time-Tinker"));

			IPlayable test = game.CurrentPlayer.HandZone.Last();
			Assert.Equal(Rarity.LEGENDARY, test.Card.Rarity);
			Assert.DoesNotContain(test.Card.Set, Cards.StandardSets);
			Assert.Equal(CardType.MINION, test.Card.Type);
		}

		// ------------------------------------------ MINION - MAGE
		// [GIL_640] Curio Collector - COST:5 [ATK:4/HP:4] 
		// - Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you draw a card, gain +1/+1.
		// --------------------------------------------------------
		[Fact]
		public void CurioCollector_GIL_640()
		{
			// TODO CurioCollector_GIL_640 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Curio Collector"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Curio Collector"));

			Minion test = game.ProcessCard<Minion>("Curio Collector");

			game.ProcessCard("Arcane Intellect");
			Assert.Equal(6, test.AttackDamage);
			Assert.Equal(6, test.Health);
		}

		// ------------------------------------------ MINION - MAGE
		// [GIL_645] Bonfire Elemental - COST:5 [ATK:5/HP:5] 
		// - Race: elemental, Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you played an_Elemental last turn, draw a card.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void BonfireElemental_GIL_645()
		{
			// TODO BonfireElemental_GIL_645 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bonfire Elemental"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bonfire Elemental"));
			Assert.Equal(3, game.CurrentPlayer.HandZone.Count);
			game.EndTurn();
			game.EndTurn();
			Assert.Equal(4, game.CurrentPlayer.HandZone.Count);
			game.ProcessCard("Bonfire Elemental");
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
		}

		// ------------------------------------------ MINION - MAGE
		// [GIL_664] Vex Crow - COST:4 [ATK:3/HP:3] 
		// - Race: beast, Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, summon a random
		//       2-Cost minion.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VexCrow_GIL_664()
		{
			// TODO VexCrow_GIL_664 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Vex Crow"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vex Crow"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Vex Crow"));
		}

		// ------------------------------------------ MINION - MAGE
		// [GIL_691] Archmage Arugal - COST:2 [ATK:2/HP:2] 
		// - Set: gilneas, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever you draw a minion, add a copy of it to_your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact]
		public void ArchmageArugal_GIL_691()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Archmage Arugal"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),

					Cards.FromName("Bloodfen Raptor"),
					Cards.FromName("Arcane Missiles")
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Archmage Arugal"));
			game.ProcessCard("Arcane Intellect");
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(2, game.CurrentPlayer.HandZone.Count(p => p.Card.Name == "Bloodfen Raptor"));
		}

		// ------------------------------------------ MINION - MAGE
		// [GIL_838] Black Cat - COST:3 [ATK:3/HP:3] 
		// - Race: beast, Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Spell Damage +1</b>
		//        <b>Battlecry:</b> If your deck has only odd-Cost cards, draw a card.
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BlackCat_GIL_838()
		{
			// TODO BlackCat_GIL_838 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Black Cat"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Black Cat"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Black Cat"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [GIL_147] Cinderstorm - COST:3 
		// - Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $5 damage randomly split among all enemies. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - ImmuneToSpellpower = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Cinderstorm_GIL_147()
		{
			// TODO Cinderstorm_GIL_147 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cinderstorm"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cinderstorm"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cinderstorm"));
		}

		// ------------------------------------------- SPELL - MAGE
		// [GIL_548] Book of Specters - COST:2 
		// - Set: gilneas, Rarity: epic
		// --------------------------------------------------------
		// Text: Draw 3 cards. Discard any spells drawn.
		// --------------------------------------------------------
		[Fact]
		public void BookOfSpecters_GIL_548()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Book of Specters"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),

					Cards.FromName("Bloodfen Raptor"),
					Cards.FromName("Arcane Missiles"),
					Cards.FromName("Arcane Missiles")
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Book of Specters"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Book of Specters"));

			Assert.Empty(game.CurrentPlayer.DeckZone);
			Assert.Equal(4, game.CurrentPlayer.HandZone.Count);
			Assert.Equal("Bloodfen Raptor", game.CurrentPlayer.HandZone.Last().Card.Name);
		}

		// ------------------------------------------- SPELL - MAGE
		// [GIL_801] Snap Freeze - COST:2 
		// - Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Freeze</b> a minion.
		//       If it's already <b>Frozen</b>, destroy it.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact]
		public void SnapFreeze_GIL_801()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Snap Freeze"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Snap Freeze"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Snap Freeze"));

			IPlayable target = game.ProcessCard("Stonetusk Boar");
			game.ProcessCard("Snap Freeze", target);
			Assert.Equal(1, target[GameTag.FROZEN]);

			game.ProcessCard("Snap Freeze", target);
			Assert.True(target.ToBeDestroyed);
		}

	}

	public class PaladinGilneasTest
	{
		// --------------------------------------- MINION - PALADIN
		// [GIL_545] Ghostly Charger - COST:5 [ATK:3/HP:4] 
		// - Race: beast, Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Divine Shield</b>
		//       <b>Rush</b>
		// --------------------------------------------------------
		// GameTag:
		// - DIVINE_SHIELD = 1
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GhostlyCharger_GIL_545()
		{
			// TODO GhostlyCharger_GIL_545 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ghostly Charger"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ghostly Charger"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ghostly Charger"));
		}

		// --------------------------------------- MINION - PALADIN
		// [GIL_634] Bellringer Sentry - COST:4 [ATK:3/HP:4] 
		// - Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry and Deathrattle:</b> Put a <b>Secret</b> from your deck into the battlefield.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BellringerSentry_GIL_634()
		{
			// TODO BellringerSentry_GIL_634 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bellringer Sentry"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bellringer Sentry"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bellringer Sentry"));
		}

		// --------------------------------------- MINION - PALADIN
		// [GIL_635] Cathedral Gargoyle - COST:2 [ATK:2/HP:2] 
		// - Set: gilneas, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding a Dragon, gain <b>Taunt</b> and <b>Divine Shield</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact]
		public void CathedralGargoyle_GIL_635()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cathedral Gargoyle"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			Minion test1 = game.ProcessCard<Minion>("Cathedral Gargoyle");
			Assert.False(test1.HasDivineShield);
			Assert.False(test1.HasTaunt);

			Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Malygos"));
			Minion test2 = game.ProcessCard<Minion>("Cathedral Gargoyle");
			Assert.True(test2.HasDivineShield);
			Assert.True(test2.HasTaunt);
		}

		// --------------------------------------- MINION - PALADIN
		// [GIL_685] Paragon of Light - COST:3 [ATK:2/HP:5] 
		// - Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: While this minion has 3 or more Attack, it has <b>Taunt</b> and <b>Lifesteal</b>.
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact]
		public void ParagonOfLight_GIL_685()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Paragon of Light"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Paragon of Light"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Paragon of Light"));

			Minion testCard = game.CurrentPlayer.BoardZone[0];

			Assert.False(testCard.HasTaunt);
			Assert.False(testCard.HasLifeSteal);

			game.ProcessCard("Blessing of Might", testCard);

			Assert.True(testCard.HasTaunt);
			Assert.True(testCard.HasLifeSteal);

			var clone = game.Clone();
		}

		// --------------------------------------- MINION - PALADIN
		// [GIL_694] Prince Liam - COST:5 [ATK:5/HP:5] 
		// - Set: gilneas, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Transform all
		//       1-Cost cards in your deck
		//       _into <b>Legendary</b> minions.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void PrinceLiam_GIL_694()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Prince Liam"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),

					Cards.FromName("Wisp"),
					Cards.FromName("Bloodfen Raptor"),
					Cards.FromName("Dalaran Mage"),

					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Prince Liam"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Prince Liam"));

			Assert.Empty(game.CurrentPlayer.DeckZone.Where(p => p.Card.Name == "Stonetusk Boar"));
			Assert.Equal(5, game.CurrentPlayer.DeckZone.Count(p => p.Card.Rarity == Rarity.LEGENDARY));
		}

		// --------------------------------------- MINION - PALADIN
		// [GIL_817] The Glass Knight - COST:4 [ATK:4/HP:3] 
		// - Set: gilneas, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Divine Shield</b>
		//       Whenever you restore Health,
		//       gain <b>Divine Shield</b>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact]
		public void TheGlassKnight_GIL_817()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("The Glass Knight"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Glass Knight"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "The Glass Knight"));

			Minion test = game.ProcessCard<Minion>("The Glass Knight");
			test.HasDivineShield = false;
			game.CurrentPlayer.Hero.Damage = 10;
			game.ProcessCard("Holy Light", game.CurrentPlayer.Hero);
			Assert.True(test.HasDivineShield);
			game.EndTurn();

			test.HasDivineShield = false;
			game.ProcessCard("Holy Light", game.CurrentOpponent.Hero);
			Assert.False(test.HasDivineShield);
		}

		// ---------------------------------------- SPELL - PALADIN
		// [GIL_145] Sound the Bells! - COST:2 
		// - Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Echo</b>
		//       Give a minion +1/+2.
		// --------------------------------------------------------
		// GameTag:
		// - ECHO = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SoundTheBells_GIL_145()
		{
			// TODO SoundTheBells_GIL_145 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sound the Bells!"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sound the Bells!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sound the Bells!"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [GIL_203] Rebuke - COST:2 
		// - Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: Enemy spells cost (5) more next turn.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Rebuke_GIL_203()
		{
			// TODO Rebuke_GIL_203 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rebuke"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rebuke"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rebuke"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [GIL_903] Hidden Wisdom - COST:1 
		// - Set: gilneas, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Secret:</b> After your
		//       opponent plays three
		//       cards in a turn, draw
		//       2 cards.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HiddenWisdom_GIL_903()
		{
			// TODO HiddenWisdom_GIL_903 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hidden Wisdom"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hidden Wisdom"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hidden Wisdom"));
		}

		// --------------------------------------- WEAPON - PALADIN
		// [GIL_596] Silver Sword - COST:8 [ATK:3/HP:0] 
		// - Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: After your hero attacks, give your minions +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 4
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SilverSword_GIL_596()
		{
			// TODO SilverSword_GIL_596 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Silver Sword"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Silver Sword"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Silver Sword"));
		}

	}

	public class PriestGilneasTest
	{
		// ---------------------------------------- MINION - PRIEST
		// [GIL_142] Chameleos - COST:1 [ATK:1/HP:1] 
		// - Race: beast, Set: gilneas, Rarity: legendary
		// --------------------------------------------------------
		// Text: Each turn this is in your hand, transform it into a card your opponent is holding.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact]
		public void Chameleos_GIL_142()
		{
			Game game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			IPlayable test = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chameleos"));
			Assert.Equal("GIL_142", test.Card.Id);

			int testId = test.Id;

			for (int i = 0; i < 10; i++)
			{
				game.EndTurn();
				game.EndTurn();
				test = game.IdEntityDic[testId];
				Assert.Contains(test.Card.Id, game.CurrentOpponent.HandZone.Select(p => p.Card.Id));
				Assert.NotNull(test.AppliedEnchantments);
				Assert.Single(test.AppliedEnchantments);
			}

			for (int i = game.CurrentOpponent.HandZone.Count - 1; i >= 0; i--)
			{
				IPlayable handCard = game.CurrentOpponent.HandZone[i];
				Generic.DiscardBlock(game.CurrentOpponent, handCard);
			}

			for (int i = 0; i < 10; i++)
				Generic.DrawCard(game.CurrentOpponent, Cards.FromName("Wisp"));

			game.EndTurn();
			game.EndTurn();

			test = game.IdEntityDic[testId];
			Assert.Equal("Wisp", test.Card.Name);
			game.ProcessCard(test);

			Assert.Single(game.CurrentPlayer.BoardZone);
			Assert.Empty(test.AppliedEnchantments);

			foreach (IPlayable handCard in game.CurrentOpponent.HandZone)
				Generic.DiscardBlock(game.CurrentOpponent, handCard);

			for (int i = 0; i < 10; i++)
				Generic.DrawCard(game.CurrentOpponent, Cards.FromName("Silence"));

			game.EndTurn();
			game.EndTurn();

			test = game.IdEntityDic[testId];
			Assert.Equal("Wisp", test.Card.Name);
		}

		// ---------------------------------------- MINION - PRIEST
		// [GIL_156] Quartz Elemental - COST:5 [ATK:5/HP:8] 
		// - Race: elemental, Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: Can't attack while damaged.
		// --------------------------------------------------------
		[Fact]
		public void QuartzElemental_GIL_156()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Quartz Elemental"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			Minion test = game.ProcessCard<Minion>("Quartz Elemental");

			Assert.False(test.CantAttack);
			test.Damage++;
			game.AuraUpdate();
			Assert.True(test.CantAttack);
			test.Damage--;
			game.AuraUpdate();
			Assert.False(test.CantAttack);
		}

		// ---------------------------------------- MINION - PRIEST
		// [GIL_190] Nightscale Matriarch - COST:7 [ATK:4/HP:9] 
		// - Race: dragon, Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever a friendly minion is healed, summon a 3/3_Whelp.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NightscaleMatriarch_GIL_190()
		{
			// TODO NightscaleMatriarch_GIL_190 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nightscale Matriarch"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nightscale Matriarch"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nightscale Matriarch"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [GIL_805] Coffin Crasher - COST:6 [ATK:6/HP:5] 
		// - Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a <b>Deathrattle</b> minion from your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CoffinCrasher_GIL_805()
		{
			// TODO CoffinCrasher_GIL_805 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Coffin Crasher"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Coffin Crasher"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Coffin Crasher"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [GIL_835] Squashling - COST:2 [ATK:2/HP:1] 
		// - Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Echo</b>
		//       <b>Battlecry:</b> Restore 2 Health.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - ECHO = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Squashling_GIL_835()
		{
			// TODO Squashling_GIL_835 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Squashling"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Squashling"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Squashling"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [GIL_837] Glitter Moth - COST:5 [ATK:4/HP:4] 
		// - Race: beast, Set: gilneas, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your deck has only odd-Cost cards, double the Health of your other minions.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GlitterMoth_GIL_837()
		{
			// TODO GlitterMoth_GIL_837 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Glitter Moth"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Glitter Moth"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Glitter Moth"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [GIL_840] Lady in White - COST:6 [ATK:5/HP:5] 
		// - Set: gilneas, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Cast 'Inner Fire'
		//       _on every minion in your deck_
		//       <i>(set Attack equal to Health).</i>
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void LadyInWhite_GIL_840()
		{
			// TODO LadyInWhite_GIL_840 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lady in White"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lady in White"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lady in White"));

			foreach (Minion m in game.CurrentPlayer.DeckZone.Where(p => p is Minion).Cast<Minion>())
			{
				Assert.Equal(m.AttackDamage, m.Health);
			}
		}

		// ----------------------------------------- SPELL - PRIEST
		// [GIL_134] Holy Water - COST:5 
		// - Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $4 damage to a minion. If that kills it, add a copy of it to your_hand. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void HolyWater_GIL_134()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Holy Water"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Holy Water"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Holy Water"));

			IPlayable target = game.ProcessCard("Stonetusk Boar");
			game.ProcessCard("Holy Water", target);
			Assert.Equal("Stonetusk Boar", game.CurrentPlayer.HandZone.Last().Card.Name);

			IPlayable target2 = game.ProcessCard("Ysera", null, true);
			game.ProcessCard("Holy Water", target2, true);
			Assert.Equal("Stonetusk Boar", game.CurrentPlayer.HandZone.Last().Card.Name);
		}

		// ----------------------------------------- SPELL - PRIEST
		// [GIL_661] Divine Hymn - COST:2 
		// - Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: Restore #6 Health to all friendly characters.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DivineHymn_GIL_661()
		{
			// TODO DivineHymn_GIL_661 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Divine Hymn"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Divine Hymn"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Divine Hymn"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [GIL_813] Vivid Nightmare - COST:3 
		// - Set: gilneas, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]Choose a friendly minion.
		//       Summon a copy of it with
		//       1 Health remaining.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_NUM_MINION_SLOTS = 1
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void VividNightmare_GIL_813()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Vivid Nightmare"),
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vivid Nightmare"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Vivid Nightmare"));

			IPlayable target = game.ProcessCard("Ysera", null, true);
			game.ProcessCard("Vivid Nightmare", target, true);

			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			Minion test = game.CurrentPlayer.BoardZone[1];
			Assert.Equal(1, test.Health);
		}

	}

	public class RogueGilneasTest
	{
		// ----------------------------------------- MINION - ROGUE
		// [GIL_510] Mistwraith - COST:4 [ATK:3/HP:5] 
		// - Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you play an <b>Echo</b>_card, gain +1/+1.
		// --------------------------------------------------------
		// RefTag:
		// - ECHO = 1
		// --------------------------------------------------------
		[Fact]
		public void Mistwraith_GIL_510()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mistwraith"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mistwraith"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mistwraith"));

			Minion test = game.ProcessCard<Minion>("Mistwraith");
			game.ProcessCard("Pick Pocket", null, true);
			Assert.Equal(4, test.AttackDamage);
			Assert.Equal(6, test.Health);
			game.ProcessCard(game.CurrentPlayer.HandZone.Last(), null, true);
			Assert.Equal(5, test.AttackDamage);
			Assert.Equal(7, test.Health);
			game.ProcessCard("Stonetusk Boar");
			Assert.Equal(5, test.AttackDamage);
			Assert.Equal(7, test.Health);
		}

		// ----------------------------------------- MINION - ROGUE
		// [GIL_557] Cursed Castaway - COST:6 [ATK:5/HP:3] 
		// - Race: pirate, Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Rush</b>
		//       <b>Deathrattle:</b> Draw a <b>Combo</b> card from your deck.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// - RUSH = 1
		// --------------------------------------------------------
		// RefTag:
		// - COMBO = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CursedCastaway_GIL_557()
		{
			// TODO CursedCastaway_GIL_557 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cursed Castaway"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cursed Castaway"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cursed Castaway"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [GIL_598] Tess Greymane - COST:8 [ATK:6/HP:6] 
		// - Set: gilneas, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Replay every card
		//       from another class you've
		//       played this game <i>(targets
		//       chosen randomly)</i>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TessGreymane_GIL_598()
		{
			// TODO TessGreymane_GIL_598 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tess Greymane"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tess Greymane"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tess Greymane"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [GIL_677] Face Collector - COST:3 [ATK:2/HP:2] 
		// - Set: gilneas, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Echo</b>
		//       <b>Battlecry:</b> Add a random <b>Legendary</b> minion to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ECHO = 1
		// --------------------------------------------------------
		[Fact]
		public void FaceCollector_GIL_677()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Face Collector"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Face Collector"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Face Collector"));
			Assert.Equal(Rarity.LEGENDARY, game.CurrentPlayer.HandZone[3].Card.Rarity);
			game.ProcessCard(game.CurrentPlayer.HandZone[4]);
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(Rarity.LEGENDARY, game.CurrentPlayer.HandZone[4].Card.Rarity);
		}

		// ----------------------------------------- MINION - ROGUE
		// [GIL_827] Blink Fox - COST:3 [ATK:3/HP:3] 
		// - Race: beast, Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add a random card to your hand <i>(from your opponent's class).</i>
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BlinkFox_GIL_827()
		{
			// TODO BlinkFox_GIL_827 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blink Fox"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blink Fox"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blink Fox"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [GIL_902] Cutthroat Buccaneer - COST:3 [ATK:2/HP:4] 
		// - Race: pirate, Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Combo:</b> Give your weapon +1 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CutthroatBuccaneer_GIL_902()
		{
			// TODO CutthroatBuccaneer_GIL_902 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cutthroat Buccaneer"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cutthroat Buccaneer"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cutthroat Buccaneer"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [GIL_506] Cheap Shot - COST:2 
		// - Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Echo</b>
		//        Deal $2 damage to a_minion. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - ECHO = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CheapShot_GIL_506()
		{
			// TODO CheapShot_GIL_506 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cheap Shot"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cheap Shot"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cheap Shot"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [GIL_687] WANTED! - COST:4 
		// - Set: gilneas, Rarity: epic
		// --------------------------------------------------------
		// Text: Deal $3 damage to a minion. If that kills it, add a Coin to your hand. @spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Wanted_GIL_687()
		{
			// TODO Wanted_GIL_687 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("WANTED!"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("WANTED!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "WANTED!"));
		}

		// ------------------------------------------ SPELL - ROGUE
		// [GIL_696] Pick Pocket - COST:2 
		// - Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Echo</b>
		//       Add a random card to your hand <i>(from your opponent's class).</i>
		// --------------------------------------------------------
		// GameTag:
		// - ECHO = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PickPocket_GIL_696()
		{
			// TODO PickPocket_GIL_696 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Pick Pocket"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pick Pocket"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Pick Pocket"));
		}

		// ----------------------------------------- WEAPON - ROGUE
		// [GIL_672] Spectral Cutlass - COST:4 [ATK:2/HP:0] 
		// - Set: gilneas, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Lifesteal</b>
		//       Whenever you play a card
		//       from another class,
		//       gain +1 Durability.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact]
		public void SpectralCutlass_GIL_672()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spectral Cutlass"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spectral Cutlass"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Spectral Cutlass"));

			game.ProcessCard("Frostbolt", game.CurrentOpponent.Hero);
			Assert.Equal(3, game.CurrentPlayer.Hero.Weapon.Durability);

			game.ProcessCard("Eviscerate", game.CurrentOpponent.Hero);
			Assert.Equal(3, game.CurrentPlayer.Hero.Weapon.Durability);
		}

	}

	public class ShamanGilneasTest
	{
		// ---------------------------------------- MINION - SHAMAN
		// [GIL_530] Murkspark Eel - COST:2 [ATK:2/HP:3] 
		// - Race: beast, Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your deck has only even-Cost cards, deal_2 damage.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_DRAG_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MurksparkEel_GIL_530()
		{
			// TODO MurksparkEel_GIL_530 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Murkspark Eel"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murkspark Eel"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Murkspark Eel"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [GIL_531] Witch's Apprentice - COST:1 [ATK:0/HP:1] 
		// - Race: beast, Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Battlecry:</b> Add a random Shaman spell to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WitchsApprentice_GIL_531()
		{
			// TODO WitchsApprentice_GIL_531 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Witch's Apprentice"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Witch's Apprentice"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Witch's Apprentice"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [GIL_583] Totem Cruncher - COST:4 [ATK:2/HP:3] 
		// - Race: beast, Set: gilneas, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Battlecry:</b> Destroy your Totems. Gain +2/+2 for each destroyed.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void TotemCruncher_GIL_583()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Totem Cruncher"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.PlayHeroPower(autoRefresh: true);
			game.PlayHeroPower(autoRefresh: true);
			game.PlayHeroPower(autoRefresh: true);
			game.PlayHeroPower(autoRefresh: true);

			Minion test = game.ProcessCard<Minion>("Totem Cruncher", null, true);
			Assert.Equal(10, test.AttackDamage);
			Assert.Equal(11, test.Health);

			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Totem Cruncher"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Totem Cruncher"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [GIL_678] Ghost Light Angler - COST:2 [ATK:2/HP:2] 
		// - Race: murloc, Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Echo</b>
		// --------------------------------------------------------
		// GameTag:
		// - ECHO = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GhostLightAngler_GIL_678()
		{
			// TODO GhostLightAngler_GIL_678 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ghost Light Angler"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ghost Light Angler"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ghost Light Angler"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [GIL_807] Bogshaper - COST:7 [ATK:4/HP:8] 
		// - Race: elemental, Set: gilneas, Rarity: epic
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, draw a minion from your_deck.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Bogshaper_GIL_807()
		{
			// TODO Bogshaper_GIL_807 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bogshaper"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bogshaper"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bogshaper"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [GIL_820] Shudderwock - COST:9 [ATK:6/HP:6] 
		// - Set: gilneas, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Repeat all other
		//       <b>Battlecries</b> from cards you
		//       played this game <i>(targets
		//       chosen randomly)</i>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - 960 = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Shudderwock_GIL_820()
		{
			// TODO Shudderwock_GIL_820 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shudderwock"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shudderwock"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shudderwock"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [GIL_586] Earthen Might - COST:2 
		// - Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]Give a minion +2/+2.
		//       If it's an Elemental, add
		//       a random Elemental
		//       to your hand.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EarthenMight_GIL_586()
		{
			// TODO EarthenMight_GIL_586 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Earthen Might"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Earthen Might"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Earthen Might"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [GIL_600] Zap! - COST:0 
		// - Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $2 damage to a minion. <b>Overload:</b> (1) @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - OVERLOAD = 1
		// - OVERLOAD_OWED = 1
		// - AFFECTED_BY_SPELL_POWER = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Zap_GIL_600()
		{
			// TODO Zap_GIL_600 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Zap!"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Zap!"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Zap!"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [GIL_836] Blazing Invocation - COST:1 
		// - Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Discover</b> a <b>Battlecry</b> minion.
		// --------------------------------------------------------
		// RefTag:
		// - BATTLECRY = 1
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BlazingInvocation_GIL_836()
		{
			// TODO BlazingInvocation_GIL_836 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blazing Invocation"),
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blazing Invocation"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blazing Invocation"));
		}

	}

	public class WarlockGilneasTest
	{
		// --------------------------------------- MINION - WARLOCK
		// [GIL_508] Duskbat - COST:3 [ATK:2/HP:4] 
		// - Race: beast, Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your hero took damage this turn, summon two 1/1 Bats.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void Duskbat_GIL_508()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Duskbat"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Duskbat"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Duskbat"));
			Assert.Single(game.CurrentPlayer.BoardZone);

			game.PlayHeroPower();
			game.ProcessCard("Duskbat");
			Assert.Equal(4, game.CurrentPlayer.BoardZone.Count);

			game.EndTurn();
			game.EndTurn();
			game.ProcessCard("Duskbat");
			Assert.Equal(5, game.CurrentPlayer.BoardZone.Count);
		}

		// --------------------------------------- MINION - WARLOCK
		// [GIL_515] Ratcatcher - COST:3 [ATK:2/HP:2] 
		// - Set: gilneas, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Rush</b>
		//       <b>Battlecry:</b> Destroy a friendly minion and gain its Attack and Health.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - RUSH = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact]
		public void Ratcatcher_GIL_515()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ratcatcher"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ratcatcher"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ratcatcher"));

			IPlayable target = game.ProcessCard("Chillwind Yeti");
			Minion test = game.ProcessCard<Minion>("Ratcatcher", target);

			Assert.Equal(6, test.AttackDamage);
			Assert.Equal(7, test.Health);
			Assert.True(target.ToBeDestroyed);
		}

		// --------------------------------------- MINION - WARLOCK
		// [GIL_565] Deathweb Spider - COST:5 [ATK:4/HP:6] 
		// - Race: beast, Set: gilneas, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your hero
		//       took damage this turn, gain <b>Lifesteal</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DeathwebSpider_GIL_565()
		{
			// TODO DeathwebSpider_GIL_565 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Deathweb Spider"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Deathweb Spider"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Deathweb Spider"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [GIL_608] Witchwood Imp - COST:1 [ATK:1/HP:1] 
		// - Race: demon, Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Stealth</b>
		//       <b>Deathrattle:</b> Give a random
		//         friendly minion +2 Health.
		// --------------------------------------------------------
		// GameTag:
		// - STEALTH = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WitchwoodImp_GIL_608()
		{
			// TODO WitchwoodImp_GIL_608 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Witchwood Imp"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Witchwood Imp"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Witchwood Imp"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [GIL_618] Glinda Crowskin - COST:6 [ATK:3/HP:7] 
		// - Set: gilneas, Rarity: legendary
		// --------------------------------------------------------
		// Text: Minions in your hand have_<b>Echo</b>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - AURA = 1
		// --------------------------------------------------------
		// RefTag:
		// - ECHO = 1
		// --------------------------------------------------------
		[Fact]
		public void GlindaCrowskin_GIL_618()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Glinda Crowskin"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Glinda Crowskin"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Glinda Crowskin"));
			IPlayable wisp = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wisp"));
			game.AuraUpdate();
			Assert.True(wisp.IsEcho);

			game.ProcessCard(wisp);
			IPlayable ghost = game.CurrentPlayer.HandZone.Last();
			Assert.Equal("Wisp", ghost.Card.Name);
			Assert.Equal(1, ghost[GameTag.GHOSTLY]);
			Assert.True(ghost.IsEcho);
		}

		// --------------------------------------- MINION - WARLOCK
		// [GIL_693] Blood Witch - COST:4 [ATK:3/HP:6] 
		// - Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: At the start of your turn, deal 1 damage to your_hero.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BloodWitch_GIL_693()
		{
			// TODO BloodWitch_GIL_693 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blood Witch"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blood Witch"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blood Witch"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [GIL_825] Lord Godfrey - COST:7 [ATK:4/HP:4] 
		// - Set: gilneas, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Deal 2 damage to
		//       all other minions. If any die,
		//       repeat this <b>Battlecry</b>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LordGodfrey_GIL_825()
		{
			// TODO LordGodfrey_GIL_825 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lord Godfrey"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lord Godfrey"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lord Godfrey"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [GIL_191] Fiendish Circle - COST:4 
		// - Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: [x]Summon four 1/1 Imps.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FiendishCircle_GIL_191()
		{
			// TODO FiendishCircle_GIL_191 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Fiendish Circle"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fiendish Circle"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fiendish Circle"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [GIL_543] Dark Possession - COST:1 
		// - Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $2 damage to a friendly character. <b>Discover</b> a Demon. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - AFFECTED_BY_SPELL_POWER = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DarkPossession_GIL_543()
		{
			// TODO DarkPossession_GIL_543 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dark Possession"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dark Possession"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dark Possession"));
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [GIL_665] Curse of Weakness - COST:2 
		// - Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Echo</b>
		//       Give all enemy minions -2_Attack until your next_turn.
		// --------------------------------------------------------
		// GameTag:
		// - ECHO = 1
		// --------------------------------------------------------
		[Fact]
		public void CurseOfWeakness_GIL_665()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Curse of Weakness"),
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Curse of Weakness"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Curse of Weakness"));

			Minion t1 = game.ProcessCard<Minion>("Stonetusk Boar");
			Minion t2 = game.ProcessCard<Minion>("Murloc Raider");
			Minion t3 = game.ProcessCard<Minion>("Bloodfen Raptor");
			Minion t4 = game.ProcessCard<Minion>("Ancient Watcher");
			Minion t5 = game.ProcessCard<Minion>("Magma Rager");
			game.EndTurn();

			game.ProcessCard("Curse of Weakness");
			Assert.Equal(0, t1.AttackDamage);
			Assert.Equal(0, t2.AttackDamage);
			Assert.Equal(1, t3.AttackDamage);
			Assert.Equal(2, t4.AttackDamage);
			Assert.Equal(3, t5.AttackDamage);

			game.ProcessCard(game.CurrentPlayer.HandZone.Last());
			Assert.Equal(0, t1.AttackDamage);
			Assert.Equal(0, t2.AttackDamage);
			Assert.Equal(0, t3.AttackDamage);
			Assert.Equal(0, t4.AttackDamage);
			Assert.Equal(1, t5.AttackDamage);
		}

	}

	public class WarriorGilneasTest
	{
		// --------------------------------------- MINION - WARRIOR
		// [GIL_113] Rabid Worgen - COST:3 [ATK:3/HP:3] 
		// - Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Rush</b>
		// --------------------------------------------------------
		// GameTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RabidWorgen_GIL_113()
		{
			// TODO RabidWorgen_GIL_113 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rabid Worgen"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rabid Worgen"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rabid Worgen"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [GIL_152] Blackhowl Gunspire - COST:7 [ATK:3/HP:8] 
		// - Set: gilneas, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]Can't attack. Whenever
		//       this minion takes damage,
		//       deal 3 damage to a
		//       random enemy.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - CANT_ATTACK = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BlackhowlGunspire_GIL_152()
		{
			// TODO BlackhowlGunspire_GIL_152 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blackhowl Gunspire"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blackhowl Gunspire"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blackhowl Gunspire"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [GIL_155] Redband Wasp - COST:2 [ATK:1/HP:3] 
		// - Race: beast, Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Rush</b>
		//       Has +3 Attack while damaged.
		// --------------------------------------------------------
		// GameTag:
		// - ENRAGED = 1
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RedbandWasp_GIL_155()
		{
			// TODO RedbandWasp_GIL_155 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Redband Wasp"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Redband Wasp"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Redband Wasp"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [GIL_547] Darius Crowley - COST:5 [ATK:4/HP:4] 
		// - Set: gilneas, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Rush</b>
		//       After this attacks and kills
		//       a minion, gain +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact]
		public void DariusCrowley_GIL_547()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Darius Crowley"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Darius Crowley"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Darius Crowley"));

			Minion target = game.ProcessCard<Minion>("Stonetusk Boar");
			game.EndTurn();

			Minion test = game.ProcessCard<Minion>("Darius Crowley");
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, test, target));

			Assert.True(target.ToBeDestroyed);
			Assert.Equal(6, test.AttackDamage);
			Assert.Equal(5, test.Health);
		}

		// --------------------------------------- MINION - WARRIOR
		// [GIL_580] Town Crier - COST:1 [ATK:1/HP:2] 
		// - Set: gilneas, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Draw a <b>Rush</b> minion from your deck.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TownCrier_GIL_580()
		{
			// TODO TownCrier_GIL_580 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Town Crier"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Town Crier"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Town Crier"));
		}

		// --------------------------------------- MINION - WARRIOR
		// [GIL_655] Festeroot Hulk - COST:5 [ATK:2/HP:7] 
		// - Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: After a friendly minion attacks, gain +1 Attack.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FesterootHulk_GIL_655()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Festeroot Hulk"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			Minion test = game.ProcessCard<Minion>("Festeroot Hulk");
			IPlayable m1 = game.ProcessCard("Stonetusk Boar");
			IPlayable m2 = game.ProcessCard("Stonetusk Boar");

			game.Process(MinionAttackTask.Any(game.CurrentPlayer, m1, game.CurrentOpponent.Hero));
			Assert.Equal(3, test.AttackDamage);
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, m2, game.CurrentOpponent.Hero));
			Assert.Equal(4, test.AttackDamage);
		}

		// --------------------------------------- MINION - WARRIOR
		// [GIL_803] Militia Commander - COST:4 [ATK:2/HP:5] 
		// - Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Rush</b>
		//       <b>Battlecry:</b> Gain +3_Attack this turn.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact]
		public void MilitiaCommander_GIL_803()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Militia Commander"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			Minion test = game.ProcessCard<Minion>("Militia Commander");
			Assert.Equal(5, test.AttackDamage);
			game.EndTurn();
			Assert.Equal(2, test.AttackDamage);
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [GIL_537] Deadly Arsenal - COST:6 
		// - Set: gilneas, Rarity: epic
		// --------------------------------------------------------
		// Text: Reveal a weapon from your deck. Deal its Attack to all minions. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - AFFECTED_BY_SPELL_POWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DeadlyArsenal_GIL_537()
		{
			// TODO DeadlyArsenal_GIL_537 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Deadly Arsenal"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Deadly Arsenal"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Deadly Arsenal"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [GIL_654] Warpath - COST:2 
		// - Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Echo</b>
		//       Deal $1 damage to all_minions. @spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - ECHO = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Warpath_GIL_654()
		{
			// TODO Warpath_GIL_654 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Warpath"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Warpath"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Warpath"));
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [GIL_653] Woodcutter's Axe - COST:2 [ATK:2/HP:0] 
		// - Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Give +2/+1 to a random friendly <b>Rush</b> minion.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		// RefTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WoodcuttersAxe_GIL_653()
		{
			// TODO WoodcuttersAxe_GIL_653 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Woodcutter's Axe"),
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Woodcutter's Axe"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Woodcutter's Axe"));
		}

	}

	public class NeutralGilneasTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [GIL_117] Worgen Abomination - COST:7 [ATK:6/HP:6] 
		// - Set: gilneas, Rarity: epic
		// --------------------------------------------------------
		// Text: At the end of your turn, deal 2 damage to all other damaged minions.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WorgenAbomination_GIL_117()
		{
			// TODO WorgenAbomination_GIL_117 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Worgen Abomination"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Worgen Abomination"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Worgen Abomination"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_118] Deranged Doctor - COST:8 [ATK:8/HP:8] 
		// - Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Restore 8 Health to your hero.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DerangedDoctor_GIL_118()
		{
			// TODO DerangedDoctor_GIL_118 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Deranged Doctor"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Deranged Doctor"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Deranged Doctor"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_119] Cauldron Elemental - COST:8 [ATK:7/HP:7] 
		// - Race: elemental, Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: Your other Elementals have +2 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CauldronElemental_GIL_119()
		{
			// TODO CauldronElemental_GIL_119 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Cauldron Elemental"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cauldron Elemental"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Cauldron Elemental"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_120] Furious Ettin - COST:7 [ATK:5/HP:9] 
		// - Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FuriousEttin_GIL_120()
		{
			// TODO FuriousEttin_GIL_120 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Furious Ettin"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Furious Ettin"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Furious Ettin"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_121] Darkmire Moonkin - COST:7 [ATK:2/HP:8] 
		// - Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Spell Damage +2</b>
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 2
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DarkmireMoonkin_GIL_121()
		{
			// TODO DarkmireMoonkin_GIL_121 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Darkmire Moonkin"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Darkmire Moonkin"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Darkmire Moonkin"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_124] Mossy Horror - COST:6 [ATK:2/HP:7] 
		// - Set: gilneas, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy all other_minions with 2_or_less_Attack.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void MossyHorror_GIL_124()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mossy Horror"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mossy Horror"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mossy Horror"));

			game.ProcessCard("Stonetusk Boar");
			game.ProcessCard("Murloc Raider");
			game.ProcessCard("Bloodfen Raptor");
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);

			game.ProcessCard("Mossy Horror", null, true);
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal("Bloodfen Raptor", game.CurrentPlayer.BoardZone[0].Card.Name);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_125] Mad Hatter - COST:4 [ATK:3/HP:2] 
		// - Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Randomly toss
		//       3 hats to other minions.
		//       Each hat gives +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_WITH_RACE = 11
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MadHatter_GIL_125()
		{
			// TODO MadHatter_GIL_125 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mad Hatter"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mad Hatter"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mad Hatter"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_143] Vicious Scalehide - COST:2 [ATK:1/HP:3] 
		// - Race: beast, Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Lifesteal</b>
		//       <b>Rush</b>
		// --------------------------------------------------------
		// GameTag:
		// - LIFESTEAL = 1
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ViciousScalehide_GIL_143()
		{
			// TODO ViciousScalehide_GIL_143 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Vicious Scalehide"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Vicious Scalehide"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Vicious Scalehide"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_198] Azalina Soulthief - COST:7 [ATK:3/HP:3] 
		// - Set: gilneas, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Replace your hand with a copy of your_opponent's.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AzalinaSoulthief_GIL_198()
		{
			// TODO AzalinaSoulthief_GIL_198 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Azalina Soulthief"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Azalina Soulthief"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Azalina Soulthief"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_201] Pumpkin Peasant - COST:3 [ATK:2/HP:4] 
		// - Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Lifesteal</b>
		//       Each turn this is in your hand,
		//       swap its Attack and Health.
		// --------------------------------------------------------
		// GameTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact]
		public void PumpkinPeasant_GIL_201()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Pumpkin Peasant"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			// Drakkari Enchanter + Worgen test
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pumpkin Peasant"));
			game.ProcessCard("Drakkari Enchanter");
			game.EndTurn();
			Assert.Equal("GIL_201t", testCard.Card.Id);
			Assert.Equal(2, testCard[GameTag.HEALTH]);
			Assert.Equal(4, testCard[GameTag.ATK]);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_202] Gilnean Royal Guard - COST:8 [ATK:3/HP:8] 
		// - Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Divine Shield</b>, <b>Rush</b>
		//       Each turn this is in your hand,
		//       swap its Attack and Health.
		// --------------------------------------------------------
		// GameTag:
		// - DIVINE_SHIELD = 1
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GilneanRoyalGuard_GIL_202()
		{
			// TODO GilneanRoyalGuard_GIL_202 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Gilnean Royal Guard"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gilnean Royal Guard"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Gilnean Royal Guard"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_207] Phantom Militia - COST:3 [ATK:2/HP:4] 
		// - Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Echo</b>
		//       <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - ECHO = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PhantomMilitia_GIL_207()
		{
			// TODO PhantomMilitia_GIL_207 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Phantom Militia"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Phantom Militia"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Phantom Militia"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_212] Ravencaller - COST:3 [ATK:2/HP:1] 
		// - Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Add two
		//       random 1-Cost minions
		//       to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void Ravencaller_GIL_212()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Ravencaller"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Ravencaller"));

			Assert.True(game.CurrentPlayer.HandZone.TakeLast(2).ToList().TrueForAll(p => p.Card.Cost == 1));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_213] Tanglefur Mystic - COST:3 [ATK:3/HP:4] 
		// - Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add a random
		//       2-Cost minion to each player's hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TanglefurMystic_GIL_213()
		{
			// TODO TanglefurMystic_GIL_213 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Tanglefur Mystic"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tanglefur Mystic"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Tanglefur Mystic"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_513] Lost Spirit - COST:2 [ATK:1/HP:1] 
		// - Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Give your minions +1 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LostSpirit_GIL_513()
		{
			// TODO LostSpirit_GIL_513 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lost Spirit"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lost Spirit"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lost Spirit"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_526] Wyrmguard - COST:7 [ATK:3/HP:11] 
		// - Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding a Dragon, gain +1 Attack and <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Wyrmguard_GIL_526()
		{
			// TODO Wyrmguard_GIL_526 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wyrmguard"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wyrmguard"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wyrmguard"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_527] Felsoul Inquisitor - COST:4 [ATK:1/HP:6] 
		// - Race: demon, Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Lifesteal</b>
		//       <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FelsoulInquisitor_GIL_527()
		{
			// TODO FelsoulInquisitor_GIL_527 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Felsoul Inquisitor"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Felsoul Inquisitor"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Felsoul Inquisitor"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_528] Swift Messenger - COST:4 [ATK:2/HP:6] 
		// - Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Rush</b>
		//       Each turn this is in your hand,
		//       swap its Attack and Health.
		// --------------------------------------------------------
		// GameTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SwiftMessenger_GIL_528()
		{
			// TODO SwiftMessenger_GIL_528 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Swift Messenger"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Swift Messenger"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Swift Messenger"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_529] Spellshifter - COST:2 [ATK:1/HP:4] 
		// - Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Spell Damage +1</b>
		//       Each turn this is in your hand,
		//       swap its Attack and Health.
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Spellshifter_GIL_529()
		{
			// TODO Spellshifter_GIL_529 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Spellshifter"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spellshifter"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Spellshifter"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_534] Hench-Clan Thug - COST:3 [ATK:3/HP:3] 
		// - Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: After your hero attacks, give this minion +1/+1.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void HenchClanThug_GIL_534()
		{
			// TODO HenchClanThug_GIL_534 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Hench-Clan Thug"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hench-Clan Thug"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Hench-Clan Thug"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_558] Swamp Leech - COST:1 [ATK:2/HP:1] 
		// - Race: beast, Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Lifesteal</b>
		// --------------------------------------------------------
		// GameTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SwampLeech_GIL_558()
		{
			// TODO SwampLeech_GIL_558 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Swamp Leech"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Swamp Leech"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Swamp Leech"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_561] Blackwald Pixie - COST:3 [ATK:3/HP:4] 
		// - Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Refresh your Hero Power.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BlackwaldPixie_GIL_561()
		{
			// TODO BlackwaldPixie_GIL_561 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Blackwald Pixie"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blackwald Pixie"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Blackwald Pixie"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_578] Countess Ashmore - COST:7 [ATK:6/HP:6] 
		// - Set: gilneas, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Draw a <b>Rush</b>,
		//       <b>Lifesteal</b>, and <b>Deathrattle</b>
		//       card from your deck.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// - LIFESTEAL = 1
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CountessAshmore_GIL_578()
		{
			// TODO CountessAshmore_GIL_578 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Countess Ashmore"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Countess Ashmore"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Countess Ashmore"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_581] Sandbinder - COST:4 [ATK:2/HP:4] 
		// - Set: gilneas, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Draw an Elemental from your deck.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Sandbinder_GIL_581()
		{
			// TODO Sandbinder_GIL_581 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sandbinder"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sandbinder"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sandbinder"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_584] Witchwood Piper - COST:4 [ATK:3/HP:3] 
		// - Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Draw the lowest
		//       Cost minion from your deck.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void WitchwoodPiper_GIL_584()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Witchwood Piper"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Snowflipper Penguin"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Witchwood Piper"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Witchwood Piper"));

			Assert.Equal(0, game.CurrentPlayer.HandZone.Last().Cost);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_601] Scaleworm - COST:4 [ATK:4/HP:4] 
		// - Race: beast, Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding a Dragon, gain +1 Attack and <b>Rush</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Scaleworm_GIL_601()
		{
			// TODO Scaleworm_GIL_601 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Scaleworm"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Scaleworm"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Scaleworm"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_614] Voodoo Doll - COST:3 [ATK:1/HP:1] 
		// - Set: gilneas, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Choose a minion. <b>Deathrattle:</b> Destroy the chosen minion.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void VoodooDoll_GIL_614()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Voodoo Doll"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Voodoo Doll"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Voodoo Doll"));

			Minion target = game.ProcessCard<Minion>("Stonetusk Boar");
			Minion test = game.ProcessCard<Minion>("Voodoo Doll", target);

			test.Kill();

			Assert.True(target.ToBeDestroyed);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_616] Splitting Festeroot - COST:8 [ATK:4/HP:4] 
		// - Set: gilneas, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon two 2/2 Splitting Saplings.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SplittingFesteroot_GIL_616()
		{
			// TODO SplittingFesteroot_GIL_616 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Splitting Festeroot"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Splitting Festeroot"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Splitting Festeroot"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_620] Dollmaster Dorian - COST:5 [ATK:2/HP:6] 
		// - Set: gilneas, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever you draw a minion, summon a 1/1 copy of it.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DollmasterDorian_GIL_620()
		{
			// TODO DollmasterDorian_GIL_620 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dollmaster Dorian"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dollmaster Dorian"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Dollmaster Dorian"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_622] Lifedrinker - COST:4 [ATK:3/HP:3] 
		// - Race: beast, Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Deal 3 damage to
		//       the enemy hero. Restore
		//       3 Health to your hero.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Lifedrinker_GIL_622()
		{
			// TODO Lifedrinker_GIL_622 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Lifedrinker"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lifedrinker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Lifedrinker"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_623] Witchwood Grizzly - COST:5 [ATK:3/HP:12] 
		// - Race: beast, Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       <b>Battlecry:</b> Lose 1 Health
		//       for each card in your
		//       opponent's hand.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void WitchwoodGrizzly_GIL_623()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Witchwood Grizzly"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Witchwood Grizzly"));

			Assert.Equal(5, game.CurrentOpponent.HandZone.Count);
			Assert.Equal(7, game.CurrentPlayer.BoardZone[0].Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_624] Night Prowler - COST:4 [ATK:3/HP:3] 
		// - Race: beast, Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If this is the only minion in the battlefield, gain +3/+3.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NightProwler_GIL_624()
		{
			// TODO NightProwler_GIL_624 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Night Prowler"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Night Prowler"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Night Prowler"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_646] Clockwork Automaton - COST:5 [ATK:4/HP:4] 
		// - Race: mechanical, Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: Double the damage and_healing of your Hero_Power.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ClockworkAutomaton_GIL_646()
		{
			// TODO ClockworkAutomaton_GIL_646 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Clockwork Automaton"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Clockwork Automaton"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Clockwork Automaton"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_648] Chief Inspector - COST:5 [ATK:4/HP:6] 
		// - Set: gilneas, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy all enemy <b>Secrets</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ChiefInspector_GIL_648()
		{
			// TODO ChiefInspector_GIL_648 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Chief Inspector"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chief Inspector"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Chief Inspector"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_667] Rotten Applebaum - COST:5 [ATK:4/HP:5] 
		// - Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Deathrattle:</b> Restore 4 Health to your hero.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RottenApplebaum_GIL_667()
		{
			// TODO RottenApplebaum_GIL_667 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rotten Applebaum"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rotten Applebaum"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Rotten Applebaum"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_680] Walnut Sprite - COST:3 [ATK:3/HP:3] 
		// - Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Echo</b>
		// --------------------------------------------------------
		// GameTag:
		// - ECHO = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WalnutSprite_GIL_680()
		{
			// TODO WalnutSprite_GIL_680 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Walnut Sprite"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Walnut Sprite"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Walnut Sprite"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_681] Nightmare Amalgam - COST:3 [ATK:3/HP:4] 
		// - Race: all, Set: gilneas, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<i>This is an Elemental, Mech,
		//       Demon, Murloc, Dragon,
		//       Beast, Pirate and Totem.</i>
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NightmareAmalgam_GIL_681()
		{
			// TODO NightmareAmalgam_GIL_681 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Nightmare Amalgam"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nightmare Amalgam"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Nightmare Amalgam"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_682] Muck Hunter - COST:5 [ATK:5/HP:8] 
		// - Set: gilneas, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Rush</b>
		//       <b>Battlecry:</b> Summon two 2/1_Mucklings for your opponent.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - RUSH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MuckHunter_GIL_682()
		{
			// TODO MuckHunter_GIL_682 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Muck Hunter"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Muck Hunter"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Muck Hunter"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_683] Marsh Drake - COST:3 [ATK:5/HP:4] 
		// - Race: dragon, Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 2/1 <b>Poisonous</b> Drakeslayer for your opponent.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void MarshDrake_GIL_683()
		{
			// TODO MarshDrake_GIL_683 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Marsh Drake"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Marsh Drake"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Marsh Drake"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_692] Genn Greymane - COST:6 [ATK:6/HP:5] 
		// - Set: gilneas, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Start of Game:</b>
		//       If your deck has only even-
		//       Cost cards, your starting
		//       Hero Power costs (1).
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - COLLECTIONMANAGER_FILTER_MANA_EVEN = 1
		// - START_OF_GAME = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GennGreymane_GIL_692()
		{
			// TODO GennGreymane_GIL_692 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Genn Greymane"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Genn Greymane"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Genn Greymane"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_809] Unpowered Steambot - COST:4 [ATK:0/HP:9] 
		// - Race: mechanical, Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnpoweredSteambot_GIL_809()
		{
			// TODO UnpoweredSteambot_GIL_809 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Unpowered Steambot"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unpowered Steambot"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Unpowered Steambot"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_815] Baleful Banker - COST:2 [ATK:2/HP:2] 
		// - Set: gilneas, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Choose a friendly minion. Shuffle a copy of it into your deck.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BalefulBanker_GIL_815()
		{
			// TODO BalefulBanker_GIL_815 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Baleful Banker"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Baleful Banker"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Baleful Banker"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_816] Swamp Dragon Egg - COST:1 [ATK:0/HP:3] 
		// - Set: gilneas, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Add a random Dragon to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SwampDragonEgg_GIL_816()
		{
			// TODO SwampDragonEgg_GIL_816 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Swamp Dragon Egg"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Swamp Dragon Egg"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Swamp Dragon Egg"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_819] Witch's Cauldron - COST:3 [ATK:0/HP:4] 
		// - Set: gilneas, Rarity: epic
		// --------------------------------------------------------
		// Text: After a friendly minion dies, add a random Shaman spell to your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void WitchsCauldron_GIL_819()
		{
			// TODO WitchsCauldron_GIL_819 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Witch's Cauldron"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Witch's Cauldron"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Witch's Cauldron"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [GIL_826] Baku the Mooneater - COST:9 [ATK:7/HP:8] 
		// - Race: beast, Set: gilneas, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Start of Game:</b>
		//       If your deck has only odd-
		//       Cost cards, upgrade
		//       your Hero Power.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - COLLECTIONMANAGER_FILTER_MANA_ODD = 1
		// - START_OF_GAME = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BakuTheMooneater_GIL_826()
		{
			// TODO BakuTheMooneater_GIL_826 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Baku the Mooneater"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Baku the Mooneater"));
			//game.Process(PlayCardTask.Any(game.CurrentPlayer, "Baku the Mooneater"));
		}

	}

}
