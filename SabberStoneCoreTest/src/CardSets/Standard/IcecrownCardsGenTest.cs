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
using SabberStoneCore.Actions;
using SabberStoneCore.Tasks.PlayerTasks;
using System.Collections.Generic;
using System.Linq;

namespace SabberStoneCoreTest.CardSets.Standard
{
	public class HeroesIcecrownTest
	{
		// ------------------------------------------ HERO - SHAMAN
		// [ICC_481] Thrall, Deathseer - COST:5 [ATK:0/HP:30] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Transform your minions into random ones that cost (2) more.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 42982
		// --------------------------------------------------------
		[Fact]
		public void ThrallDeathseer_ICC_481()
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

			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Thrall, Deathseer"));

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));

			Assert.Equal(3, game.CurrentPlayer.BoardZone.Sum(p => p.Card.Cost));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
			Assert.Equal(9, game.CurrentPlayer.BoardZone.Sum(p => p.Card.Cost));

			Assert.Equal("ICC_481", game.CurrentPlayer.Hero.Card.Id);
			Assert.Equal("ICC_481p", game.CurrentPlayer.Hero.HeroPower.Card.Id);
			Assert.Equal(5, game.CurrentPlayer.Hero.Armor);
		}

		// ------------------------------------------- HERO - ROGUE
		// [ICC_827] Valeera the Hollow - COST:9 [ATK:0/HP:30] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Gain <b>Stealth</b> until your next turn.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 43188
		// --------------------------------------------------------
		// RefTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact]
		public void ValeeraTheHollow_ICC_827()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Valeera the Hollow"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
			Assert.Equal("ICC_827", game.CurrentPlayer.Hero.Card.Id);
			Assert.Equal("ICC_827p", game.CurrentPlayer.Hero.HeroPower.Card.Id);
			Assert.Equal(5, game.CurrentPlayer.Hero.Armor);
			Assert.True(game.CurrentPlayer.Hero[GameTag.STEALTH] == 1);

			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.True(game.CurrentOpponent.Hero[GameTag.STEALTH] == 1);
			Assert.Equal(4, game.CurrentOpponent.HandZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.True(game.CurrentPlayer.Hero[GameTag.STEALTH] == 0);
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
			Assert.Equal("Shadow Reflection", game.CurrentPlayer.HandZone[4].Card.Name);
			game.ProcessCard("Bloodfen Raptor");
			Assert.Equal("Bloodfen Raptor", game.CurrentPlayer.HandZone[4].Card.Name);
			game.ProcessCard("Stonetusk Boar");
			Assert.Equal("Stonetusk Boar", game.CurrentPlayer.HandZone[4].Card.Name);

			game.Process(PlayCardTask.Any(game.CurrentPlayer, game.CurrentPlayer.HandZone[4]));
			Assert.Equal("Stonetusk Boar", game.CurrentPlayer.BoardZone.Last().Card.Name);
			Assert.Empty(game.CurrentPlayer.BoardZone.Last().AppliedEnchantments);
		}

		// ------------------------------------------ HERO - HUNTER
		// [ICC_828] Deathstalker Rexxar - COST:6 [ATK:0/HP:30] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Deal 2 damage
		//       to all enemy minions.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 43183
		// --------------------------------------------------------
		[Fact]
		public void DeathstalkerRexxar_ICC_828()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bloodfen Raptor"),
					Cards.FromName("River Crocolisk"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Player2Deck = new List<Card>()
				{
					Cards.FromName("Deathstalker Rexxar"),
				},
				Shuffle = false,
				FillDecks = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "River Crocolisk"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(2, game.CurrentOpponent.BoardZone.Count);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Deathstalker Rexxar"));
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));

			// First choice;
			Assert.NotNull(game.CurrentPlayer.Choice);
			Card firstCard = game.IdEntityDic[game.CurrentPlayer.Choice.Choices[0]].Card;
			Assert.NotNull(firstCard.Power);
			game.Process(ChooseTask.Pick(game.CurrentPlayer, game.CurrentPlayer.Choice.Choices[0]));

			// Second choice;
			Assert.NotNull(game.CurrentPlayer.Choice);
			Card secondCard = game.IdEntityDic[game.CurrentPlayer.Choice.Choices[0]].Card;
			Assert.Null(secondCard.Power);
			game.Process(ChooseTask.Pick(game.CurrentPlayer, game.CurrentPlayer.Choice.Choices[0]));

			// Zombeast
			Assert.Equal(2, game.CurrentPlayer.HandZone.Count); //	The Coin and created Zombeast
			Minion zomBeast = (Minion)game.CurrentPlayer.HandZone[1];
			Assert.Equal(Race.BEAST, zomBeast.Race);
			Assert.Equal(firstCard.Cost + secondCard.Cost, zomBeast.Cost);
			Assert.Equal(secondCard.Taunt, zomBeast.HasTaunt);
			Assert.Equal(secondCard.LifeSteal, zomBeast.HasLifeSteal);
			Assert.Equal(secondCard.Rush, zomBeast.IsRush);
		}

		// ----------------------------------------- HERO - PALADIN
		// [ICC_829] Uther of the Ebon Blade - COST:9 [ATK:0/HP:30] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Equip a 5/3 <b>Lifesteal</b> weapon.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 43013
		// --------------------------------------------------------
		// RefTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact]
		public void UtherOfTheEbonBlade_ICC_829()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Uther of the Ebon Blade")
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			Assert.Null(game.CurrentPlayer.Hero.Weapon);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Uther of the Ebon Blade"));
			Assert.NotNull(game.CurrentPlayer.Hero.Weapon);
			Assert.Equal("ICC_829t", game.CurrentPlayer.Hero.Weapon.Card.Id);

			game.CurrentPlayer.UsedMana = 0;
			game.PlayHeroPower();
			Assert.Equal(State.RUNNING, game.State);
			game.CurrentPlayer.Hero.HeroPower.IsExhausted = false;
			game.PlayHeroPower();
			Assert.Equal(State.RUNNING, game.State);
			game.CurrentPlayer.Hero.HeroPower.IsExhausted = false;
			game.PlayHeroPower();
			Assert.Equal(State.RUNNING, game.State);
			game.CurrentPlayer.Hero.HeroPower.IsExhausted = false;
			game.PlayHeroPower();

			Assert.Equal(PlayState.WON, game.CurrentPlayer.PlayState);
		}

		// ------------------------------------------ HERO - PRIEST
		// [ICC_830] Shadowreaper Anduin - COST:8 [ATK:0/HP:30] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy all minions with 5 or more_Attack.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 45397
		// --------------------------------------------------------
		[Fact]
		public void ShadowreaperAnduin_ICC_830()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shadowreaper Anduin"),
					Cards.FromName("Bloodfen Raptor"),
					Cards.FromName("Stranglethorn Tiger"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp")
				},
				Player2HeroClass = CardClass.HUNTER,
				Player2Deck = new List<Card>()
				{
					Cards.FromName("Stranglethorn Tiger"),
					Cards.FromName("Duskboar"),
				},
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Stranglethorn Tiger"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Bloodfen Raptor"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Stranglethorn Tiger"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Duskboar"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(2, game.CurrentOpponent.BoardZone.Count);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Shadowreaper Anduin"));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(4, game.CurrentPlayer.HandZone.Count);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(2, game.CurrentOpponent.Hero.Damage);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Wisp"));
			Assert.False(game.CurrentPlayer.Hero.HeroPower.IsExhausted);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Wisp"));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Wisp"));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Generic.Draw(game.CurrentPlayer);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Wisp"));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(10, game.CurrentOpponent.Hero.Damage);
		}

		// ----------------------------------------- HERO - WARLOCK
		// [ICC_831] Bloodreaver Gul'dan - COST:10 [ATK:0/HP:30] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon all friendly Demons that_died_this_game.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 43181
		// --------------------------------------------------------
		[Fact]
		public void BloodreaverGuldan_ICC_831()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bloodreaver Gul'dan")
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
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Generic.SummonBlock.Invoke(game,
				(Minion) Entity.FromCard(game.CurrentPlayer, Cards.FromName("Doomguard")), -1);
			Assert.Single(game.CurrentPlayer.BoardZone);
			game.CurrentPlayer.BoardZone[0].Kill();
			Assert.Empty(game.CurrentPlayer.BoardZone);
			Assert.Equal(29, game.CurrentPlayer.Hero.Health);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bloodreaver Gul'dan"));
			Assert.Equal(29, game.CurrentPlayer.Hero.Health);
			Assert.Equal("ICC_831", game.CurrentPlayer.Hero.Card.Id);
			Assert.Equal("ICC_831p", game.CurrentPlayer.Hero.HeroPower.Card.Id);
			Assert.Equal(5, game.CurrentPlayer.Hero.Armor);
			Assert.Single(game.CurrentPlayer.BoardZone);
			Assert.False(game.CurrentPlayer.BoardZone[0].IsExhausted);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(29, game.CurrentOpponent.Hero.Health);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(4, game.CurrentPlayer.Hero.Armor);
			Assert.Equal(29, game.CurrentPlayer.Hero.Health);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(27, game.CurrentOpponent.Hero.Health);
			Assert.Equal(30, game.CurrentPlayer.Hero.Health);
		}

		// ------------------------------------------- HERO - DRUID
		// [ICC_832] Malfurion the Pestilent - COST:7 [ATK:0/HP:30] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Choose One -</b>
		//       Summon 2 <b>Poisonous</b>
		//       Spiders; or 2 Scarabs
		//       with <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - ARMOR = 5
		// - HERO_POWER = 43182
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact]
		public void MalfurionThePestilent_ICC_832()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.DRUID,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Malfurion the Pestilent")
				},
				Player2HeroClass = CardClass.DRUID,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Malfurion the Pestilent", null, -1, 2));
			Assert.Equal("ICC_832", game.CurrentPlayer.Hero.Card.Id);
			Assert.Equal("ICC_832p", game.CurrentPlayer.Hero.HeroPower.Card.Id);
			Assert.Equal(5, game.CurrentPlayer.Hero.Armor);
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);

			game.PlayHeroPower(null, 1, true);
			Assert.Equal(8, game.CurrentPlayer.Hero.Armor);
			game.CurrentPlayer.Hero.HeroPower.IsExhausted = false;
			game.PlayHeroPower(null, 2, true);
			Assert.Equal(3, game.CurrentPlayer.Hero.AttackDamage);
		}

		// -------------------------------------------- HERO - MAGE
		// [ICC_833] Frost Lich Jaina - COST:9 [ATK:0/HP:30] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Summon a
		//       3/6 Water Elemental.
		//       Your Elementals have
		//       <b>Lifesteal</b> this game.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 42944
		// --------------------------------------------------------
		// RefTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact]
		public void FrostLichJaina_ICC_833()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frost Lich Jaina"));
			var tarCreeper = (Minion)Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tar Creeper"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.True(game.CurrentPlayer.BoardZone.First().HasLifeSteal);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			var opponentWisp = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wisp"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, opponentWisp));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, tarCreeper));
			Assert.True(tarCreeper.HasLifeSteal);

			game.Process(HeroPowerTask.Any(game.CurrentPlayer, opponentWisp));
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);

			var playerWisp = (Minion)Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wisp"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, playerWisp));
			Assert.False(playerWisp.HasLifeSteal);
		}

		// ----------------------------------------- HERO - WARRIOR
		// [ICC_834] Scourgelord Garrosh - COST:8 [ATK:0/HP:30] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry</b>: Equip a 4/3_Shadowmourne that also damages adjacent minions.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// - ARMOR = 5
		// - HERO_POWER = 45585
		// --------------------------------------------------------
		[Fact]
		public void ScourgelordGarrosh_ICC_834()
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Scourgelord Garrosh"));

			game.ProcessCard("Scourgelord Garrosh");
			Assert.Equal(5, game.CurrentPlayer.Hero.Armor);
			Assert.Equal("ICC_834h", game.CurrentPlayer.Hero.HeroPower.Card.Id);
			Assert.Equal("ICC_834w", game.CurrentPlayer.Hero.Weapon.Card.Id);
			game.EndTurn();

			game.ProcessCard("Am'gam Rager");
			game.ProcessCard("Am'gam Rager");
			game.ProcessCard("Am'gam Rager");
			game.EndTurn();

			Assert.Equal(3, game.CurrentOpponent.BoardZone.Count);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentOpponent.BoardZone[1]));
			Assert.Equal(0, game.CurrentOpponent.BoardZone.Count);
		}

	}

	public class HeroPowersIcecrownTest
	{
		// ----------------------------------- HERO_POWER - NEUTRAL
		// [ICC_481p] Transmute Spirit (*) - COST:2 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Hero Power:</b> Transform a friendly minion into a random one that costs (1) more.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void TransmuteSpirit_ICC_481p()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Thrall, Deathseer"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

			Assert.Equal(1, game.CurrentPlayer.BoardZone[0].Cost);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentPlayer.BoardZone[0]));
			Assert.Equal(2, game.CurrentPlayer.BoardZone[0].Cost);
		}

		// ------------------------------------- HERO_POWER - ROGUE
		// [ICC_827p] Death's Shadow (*) - COST:0 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Passive Hero Power</b>
		//       During your turn, add a 'Shadow Reflection' to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - HIDE_STATS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DeathsShadow_ICC_827p()
		{
			// TODO DeathsShadow_ICC_827p test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Death's Shadow"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [ICC_828p] Build-A-Beast (*) - COST:2 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Craft a custom Zombeast.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_HAND_NOT_FULL = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BuildABeast_ICC_828p()
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Build-A-Beast"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [ICC_829p] The Four Horsemen (*) - COST:2 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: [x]<b>Hero Power</b>
		//       Summon a 2/2 Horseman.
		//       If you have all 4, destroy
		//       the enemy hero.
		// --------------------------------------------------------
		// Entourage: ICC_829t2, ICC_829t3, ICC_829t4, ICC_829t5
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TheFourHorsemen_ICC_829p()
		{
			// TODO TheFourHorsemen_ICC_829p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Four Horsemen"));
		}

		// ------------------------------------ HERO_POWER - PRIEST
		// [ICC_830p] Voidform (*) - COST:2 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       Deal $2 damage.
		//       After you play a card,
		//       refresh this. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Voidform_ICC_830p()
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Voidform"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [ICC_831p] Siphon Life (*) - COST:2 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//       <b>Lifesteal</b>
		//       Deal $3 damage. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SiphonLife_ICC_831p()
		{
			// TODO SiphonLife_ICC_831p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Siphon Life"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [ICC_832p] Plague Lord (*) - COST:2 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: [x]<b>Hero Power</b>
		//       <b>Choose One -</b> +3 Attack
		//       this turn; or Gain 3 Armor.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PlagueLord_ICC_832p()
		{
			// TODO PlagueLord_ICC_832p test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Plague Lord"));
		}

		// ----------------------------------- HERO_POWER - NEUTRAL
		// [ICC_833h] Icy Touch (*) - COST:2 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//        Deal $1 damage. If this kills a minion, summon a Water Elemental. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IcyTouch_ICC_833h()
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Icy Touch"));
		}

		// ----------------------------------- HERO_POWER - WARRIOR
		// [ICC_834h] Bladestorm (*) - COST:2 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Hero Power</b>
		//        Deal $1 damage to all_minions. *spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Bladestorm_ICC_834h()
		{
			// TODO Bladestorm_ICC_834h test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bladestorm"));
		}

	}

	public class DruidIcecrownTest
	{
		// ----------------------------------------- MINION - DRUID
		// [ICC_047] Fatespinner - COST:5 [ATK:5/HP:3] 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Choose a Deathrattle (Secretly) -</b> Deal 3 damage to all minions; or Give them +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// - 818 = 1
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void Fatespinner_ICC_047()
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

			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fatespinner"));

			Minion type1 = game.ProcessCard((Minion)testCard, null, true, 1);

			game.ProcessCard("River Crocolisk");
			game.ProcessCard("River Crocolisk");
			game.ProcessCard("River Crocolisk");
			game.ProcessCard("River Crocolisk");
			game.EndTurn();
			game.ProcessCard("River Crocolisk");
			game.ProcessCard("River Crocolisk");
			game.ProcessCard("River Crocolisk");

			type1.Kill();

			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(0, game.CurrentOpponent.BoardZone.Count);

			game.EndTurn();

			Minion type2 = game.ProcessCard<Minion>("Fatespinner", null, true, 2);

			Minion t1 = game.ProcessCard<Minion>("River Crocolisk");
			game.EndTurn();
			Minion t2 = game.ProcessCard<Minion>("River Crocolisk");

			type2.Kill();

			Assert.Equal(4, t1.AttackDamage);
			Assert.Equal(5, t1.Health);
			Assert.Equal(4, t2.AttackDamage);
			Assert.Equal(5, t2.Health);

			game.EndTurn();

			game.ProcessCard("Fandral Staghelm", null, true);
			Minion type3 = game.ProcessCard<Minion>("Fatespinner", null, true);
			Minion t3 = game.ProcessCard<Minion>("Chillwind Yeti", null, true);
			type3.Kill();
			Assert.Equal(6, t3.AttackDamage);
			Assert.Equal(4, t3.Health);
		}

		// ----------------------------------------- MINION - DRUID
		// [ICC_051] Druid of the Swarm - COST:2 [ATK:1/HP:2] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Choose One -</b> Transform into a 1/2 with <b>Poisonous</b>; or a 1/5 with <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - CHOOSE_ONE = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact]
		public void DruidOfTheSwarm_ICC_051()
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

			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Druid of the Swarm"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1, 1));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.True(game.CurrentPlayer.BoardZone[0].Poisonous);
			Assert.Equal(1, game.CurrentPlayer.BoardZone[0].AttackDamage);
			Assert.Equal(2, game.CurrentPlayer.BoardZone[0].Health);

			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Druid of the Swarm"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2, 2));
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			Assert.True(game.CurrentPlayer.BoardZone[1].HasTaunt);
			Assert.Equal(1, game.CurrentPlayer.BoardZone[1].AttackDamage);
			Assert.Equal(5, game.CurrentPlayer.BoardZone[1].Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable chooseBoth = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fandral Staghelm"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, chooseBoth));
			Assert.True(game.CurrentPlayer.ChooseBoth);

			IPlayable testCard3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Druid of the Swarm"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard3, 2));
			Assert.Equal(4, game.CurrentPlayer.BoardZone.Count);
			Assert.True(game.CurrentPlayer.BoardZone[3].HasTaunt);
			Assert.True(game.CurrentPlayer.BoardZone[3].Poisonous);
			Assert.Equal(1, game.CurrentPlayer.BoardZone[3].AttackDamage);
			Assert.Equal(5, game.CurrentPlayer.BoardZone[3].Health);
		}

		// ----------------------------------------- MINION - DRUID
		// [ICC_807] Strongshell Scavenger - COST:4 [ATK:2/HP:3] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give your <b>Taunt</b> minions +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact]
		public void StrongshellScavenger_ICC_807()
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

			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Strongshell Scavenger"));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Target Dummy"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Target Dummy"));

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));

			Assert.Equal(2, ((Minion)minion1).AttackDamage);
			Assert.Equal(4, ((Minion)minion1).Health);

			Assert.Equal(2, ((Minion)minion2).AttackDamage);
			Assert.Equal(4, ((Minion)minion2).Health);

			Assert.Equal(2, ((Minion)testCard).AttackDamage);
			Assert.Equal(3, ((Minion)testCard).Health);
		}

		// ----------------------------------------- MINION - DRUID
		// [ICC_808] Crypt Lord - COST:3 [ATK:1/HP:6] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       After you summon a minion,
		//        gain +1 Health.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact]
		public void CryptLord_ICC_808()
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

			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Crypt Lord"));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));

			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Crypt Lord"));
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Angry Chicken"));
			IPlayable minion4 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Angry Chicken"));

			Assert.Equal(6, ((Minion)testCard).Health);

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));

			Assert.Equal(6, ((Minion)testCard).Health);

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

			Assert.Equal(7, ((Minion)testCard).Health);

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));

			Assert.Equal(8, ((Minion)testCard).Health);

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion4));

			Assert.Equal(11, ((Minion)testCard).Health);
			Assert.Equal(8, ((Minion)testCard2).Health);
		}

		// ----------------------------------------- MINION - DRUID
		// [ICC_835] Hadronox - COST:9 [ATK:3/HP:7] 
		// - Race: beast, Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon your <b>Taunt</b> minions that
		//       died this game.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact]
		public void Hadronox_ICC_835()
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

			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hadronox"));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pompous Thespian"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostwolf Grunt"));
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stubborn Gastropod"));

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(3, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flamestrike"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell1));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Twisting Nether"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell2));
			Assert.Equal(3, game.CurrentOpponent.BoardZone.Count);
		}

		// ------------------------------------------ SPELL - DRUID
		// [ICC_050] Webweave - COST:5 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: Summon two 1/2 <b>Poisonous</b> Spiders.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		// RefTag:
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact]
		public void Webweave_ICC_050()
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

			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Webweave"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));

			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);

			Assert.True(game.CurrentPlayer.BoardZone[0].Poisonous);
			Assert.Equal(2, game.CurrentPlayer.BoardZone[0].Health);
			Assert.Equal(1, game.CurrentPlayer.BoardZone[0].AttackDamage);

			Assert.True(game.CurrentPlayer.BoardZone[1].Poisonous);
			Assert.Equal(2, game.CurrentPlayer.BoardZone[1].Health);
			Assert.Equal(1, game.CurrentPlayer.BoardZone[1].AttackDamage);

		}

		// ------------------------------------------ SPELL - DRUID
		// [ICC_054] Spreading Plague - COST:6 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: Summon a 1/5 Scarab with <b>Taunt</b>. If your_opponent has more minions, cast this again.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact]
		public void SpreadingPlague_ICC_054()
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

			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spreading Plague"));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostwolf Grunt"));
			IPlayable minion4 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostwolf Grunt"));

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion4));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));

			Assert.Equal(game.CurrentPlayer.BoardZone.Count, game.CurrentOpponent.BoardZone.Count);
		}

		// ------------------------------------------ SPELL - DRUID
		// [ICC_079] Gnash - COST:3 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: Give your hero +3_Attack this turn. Gain 3 Armor.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void Gnash_ICC_079()
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

			Assert.Equal(0, game.CurrentPlayer.Hero.Armor);

			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gnash"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));

			Assert.Equal(3, game.CurrentPlayer.Hero.Armor);
			Assert.Equal(3, game.CurrentPlayer.Hero.AttackDamage);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(0, game.CurrentOpponent.Hero.AttackDamage);
			Assert.Equal(3, game.CurrentOpponent.Hero.Armor);
		}

		// ------------------------------------------ SPELL - DRUID
		// [ICC_085] Ultimate Infestation - COST:10 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]Deal $5 damage. Draw
		//       5 cards. Gain 5 Armor.
		//       Summon a 5/5 Ghoul. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void UltimateInfestation_ICC_085()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ultimate Infestation"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, game.CurrentOpponent.Hero));
			Assert.Equal(5, game.CurrentOpponent.Hero.Damage);
			Assert.Equal(9, game.CurrentPlayer.HandZone.Count);  //4 from starting hand and 5 from the spell
			Assert.Equal(5, game.CurrentPlayer.Hero.Armor);
			Assert.Equal("ICC_085t", game.CurrentPlayer.BoardZone[0].Card.Id);
		}

	}

	public class HunterIcecrownTest
	{
		// ---------------------------------------- MINION - HUNTER
		// [ICC_021] Exploding Bloatbat - COST:4 [ATK:2/HP:1] 
		// - Race: beast, Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b>
		//       Deal 2 damage to all enemy minions.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void ExplodingBloatbat_ICC_021()
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
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Exploding Bloatbat"));
			IPlayable alarm = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Alarm-o-Bot"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, alarm));
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable aberrant = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Aberrant Berserker"));
			IPlayable shot1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Shot"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, aberrant));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, shot1, testCard));
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(3, ((Minion)aberrant).Health);
			Assert.Equal(3, ((Minion)alarm).Health);
			Assert.Equal(30, game.CurrentOpponent.Hero.Health);
			Assert.Equal(30, game.CurrentPlayer.Hero.Health);
		}

		// ---------------------------------------- MINION - HUNTER
		// [ICC_204] Professor Putricide - COST:4 [ATK:5/HP:4] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: After you play a <b>Secret</b>,
		//       put a random Hunter <b>Secret</b> into the battlefield.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact]
		public void ProfessorPutricide_ICC_204()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Professor Putricide"),
					Cards.FromName("Explosive Trap"),
					Cards.FromName("Freezing Trap"),
					Cards.FromName("Snipe"),
					Cards.FromName("Cat Trick"),
					Cards.FromName("Hidden Cache"),
					Cards.FromName("Misdirection"),
					Cards.FromName("Venomstrike Trap"),
					Cards.FromName("Snake Trap"),
				},
				Player2HeroClass = CardClass.HUNTER,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();

			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.CurrentPlayer.Hero.HeroPower.IsExhausted = true;
			for (int i = 0; i < 5; i++)
				Generic.Draw(game.CurrentPlayer);
			
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Professor Putricide"));
			ProcessAvailableSecret();
			Assert.Equal(2, game.CurrentPlayer.SecretZone.Count);
			ProcessAvailableSecret();
			Assert.Equal(4, game.CurrentPlayer.SecretZone.Count);
			ProcessAvailableSecret();
			Assert.Equal(5, game.CurrentPlayer.SecretZone.Count);

			void ProcessAvailableSecret()
			{
				IPlayable pick = game.CurrentPlayer.HandZone.First(p => !p.Controller.SecretZone.Select(q => q.Card.Id).Contains(p.Card.Id));
				game.ProcessCard(pick);
			}
		}

		// ---------------------------------------- MINION - HUNTER
		// [ICC_243] Corpse Widow - COST:5 [ATK:4/HP:6] 
		// - Race: beast, Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: Your <b>Deathrattle</b> cards cost_(2) less.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void CorpseWidow_ICC_243()
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

			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Corpse Widow"));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Abominable Bowman"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));

			Assert.Equal(minion1.Card.Cost-2, minion1.Cost);
			Assert.Equal(minion2.Card.Cost-2, minion2.Cost);

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));

			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, testCard));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);

			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Anomalus"));
			IPlayable minion4 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Backstreet Leper"));

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion4));

			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
		}

		// ---------------------------------------- MINION - HUNTER
		// [ICC_415] Stitched Tracker - COST:3 [ATK:2/HP:2] 
		// - Fac: neutral, Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Discover</b> a copy of a minion in your deck.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact]
		public void StitchedTracker_ICC_415()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arcane Shot"), Cards.FromName("Arcane Shot"),
					Cards.FromName("Hunter's Mark"), Cards.FromName("Hunter's Mark"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Kill Command"), Cards.FromName("Kill Command"),
					Cards.FromName("Multi-Shot"), Cards.FromName("Multi-Shot"),
					Cards.FromName("Play Dead"), Cards.FromName("Play Dead"),
					Cards.FromName("Deadly Shot"), Cards.FromName("Deadly Shot"),
					Cards.FromName("Explosive Trap"), Cards.FromName("Explosive Trap")
				},
				Player2HeroClass = CardClass.HUNTER,
				FillDecks = false,
				Shuffle = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stitched Tracker"));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
			int choice = game.CurrentPlayer.Choice.Choices[0];
			game.Process(ChooseTask.Pick(game.CurrentPlayer, choice));
			Assert.Equal(CardType.MINION, game.CurrentPlayer.HandZone[4].Card.Type);
			Assert.Equal("Murloc Raider", game.CurrentPlayer.HandZone[4].Card.Name);
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Null(game.CurrentPlayer.Choice);
			Assert.Equal("Murloc Raider", game.CurrentPlayer.HandZone[5].Card.Name);
			Assert.False(game.CurrentPlayer.DeckZone.Any(p => p is Minion));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stitched Tracker"));
			Assert.Equal(7, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
			Assert.Null(game.CurrentPlayer.Choice);
		}

		// ---------------------------------------- MINION - HUNTER
		// [ICC_419] Bearshark - COST:3 [ATK:4/HP:3] 
		// - Race: beast, Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: Can't be targeted by spells or Hero Powers.
		// --------------------------------------------------------
		// GameTag:
		// - CANT_BE_TARGETED_BY_SPELLS = 1
		// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
		// --------------------------------------------------------
		[Fact]
		public void Bearshark_ICC_419()
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
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bearshark"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, testCard));
			Assert.Equal(3, ((Minion)testCard).Health);
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostbolt"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, testCard));
			Assert.False(((Minion)testCard).IsDead);
			Assert.Equal(3, ((Minion)testCard).Health);
		}

		// ---------------------------------------- MINION - HUNTER
		// [ICC_825] Abominable Bowman - COST:7 [ATK:6/HP:7] 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Deathrattle:</b> Summon
		//       a random friendly Beast
		//       that died this game.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void AbominableBowman_ICC_825()
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
			var testCard1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Abominable Bowman"));
			var testCard2 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Abominable Bowman"));
			var beast = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			var murloc = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Raider"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, beast));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, murloc));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable mark1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hunter's Mark"));
			IPlayable shot1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Shot"));
			IPlayable shot2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Shot"));
			IPlayable shot3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Shot"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, shot3, murloc));
			Assert.Equal(2, game.CurrentOpponent.BoardZone.Count);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, mark1, testCard1));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, shot1, testCard1));
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, shot2, beast));
			Assert.Equal(0, game.CurrentOpponent.BoardZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable mark2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hunter's Mark"));
			IPlayable shot4 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Shot"));
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, mark2, testCard2));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, shot4, testCard2));
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal("Stonetusk Boar", game.CurrentOpponent.BoardZone[0].Card.Name);
		}

		// ----------------------------------------- SPELL - HUNTER
		// [ICC_049] Toxic Arrow - COST:2 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: Deal $2 damage to a minion. If it survives, give it <b>Poisonous</b>. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact]
		public void ToxicArrow_ICC_049()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Toxic Arrow"));
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Aberrant Berserker"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, minion));
			Assert.Equal(4, game.CurrentPlayer.HandZone.Count);
			Assert.True(((Minion)minion).Poisonous);
			Assert.True(((Minion)minion).IsEnraged);
			Assert.Equal(3, ((Minion)minion).Health);
		}

		// ----------------------------------------- SPELL - HUNTER
		// [ICC_052] Play Dead - COST:1 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: Trigger a friendly minion's <b>Deathrattle</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_TARGET_WITH_DEATHRATTLE = 0
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void PlayDead_ICC_052()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Play Dead"));
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodmage Thalnos"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard, minion));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
		}

		// ----------------------------------------- SPELL - HUNTER
		// [ICC_200] Venomstrike Trap - COST:2 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When one of your minions is attacked, summon a 2/3_<b>Poisonous</b> Cobra.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		// RefTag:
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact]
		public void VenomstrikeTrap_ICC_200()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Venomstrike Trap"));
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Acidic Swamp Ooze"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(1, game.CurrentPlayer.SecretZone.Count);
			//Assert.Equal(1, game.CurrentPlayer.BoardZone.Triggers.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			game.Process(HeroAttackTask.Any(game.CurrentPlayer, minion));
			Assert.Equal(0, game.CurrentOpponent.SecretZone.Count);
			//Assert.Equal(0, game.CurrentOpponent.BoardZone.Triggers.Count);
			Assert.Equal(2, game.CurrentOpponent.BoardZone.Count);
		}

	}

	public class MageIcecrownTest
	{
		// ------------------------------------------ MINION - MAGE
		// [ICC_068] Ice Walker - COST:2 [ATK:1/HP:3] 
		// - Race: elemental, Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: Your Hero Power also <b><b>Freeze</b>s</b> the target.
		// --------------------------------------------------------
		// RefTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact]
		public void IceWalker_ICC_068()
		{
			// TODO IceWalker_ICC_068 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.ProcessCard("Ice Walker");
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.True(game.CurrentOpponent.Hero.IsFrozen);

			game.EndTurn();
			game.EndTurn();

			Assert.False(game.CurrentOpponent.Hero.IsFrozen);

			game.CurrentPlayer.Hero.HeroPower = (HeroPower) Entity.FromCard(game.CurrentPlayer,
				Cards.FromAssetId(Cards.HeroCard(CardClass.HUNTER)[GameTag.HERO_POWER]));
			game.PlayHeroPower();
			Assert.False(game.CurrentOpponent.Hero.IsFrozen);

		}

		// ------------------------------------------ MINION - MAGE
		// [ICC_069] Ghastly Conjurer - COST:4 [ATK:2/HP:6] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add a 'Mirror Image' spell to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void GhastlyConjurer_ICC_069()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ghastly Conjurer"));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			Assert.Equal("CS2_027", game.CurrentPlayer.HandZone[4].Card.Id);
		}

		// ------------------------------------------ MINION - MAGE
		// [ICC_083] Doomed Apprentice - COST:3 [ATK:3/HP:2] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: Your opponent's spells cost (1) more.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact]
		public void DoomedApprentice_ICC_083()
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

			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Doomed Apprentice"));

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pyroblast"));
			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			game.AuraUpdate();

			Assert.Equal(11, spell1.Cost);
			Assert.Equal(5, spell2.Cost);
		}

		// ------------------------------------------ MINION - MAGE
		// [ICC_252] Coldwraith - COST:3 [ATK:3/HP:4] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If an enemy is <b>Frozen</b>, draw a card.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FROZEN_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact]
		public void Coldwraith_ICC_252()
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

			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Coldwraith"));
			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frost Nova"));

			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostwolf Grunt"));

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(7, game.CurrentPlayer.HandZone.Count);

			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell1));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));

			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);
		}

		// ------------------------------------------ MINION - MAGE
		// [ICC_838] Sindragosa - COST:8 [ATK:8/HP:8] 
		// - Race: dragon, Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon two 0/1 Frozen Champions.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void Sindragosa_ICC_838()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Sindragosa"),
					Cards.FromName("Frostbolt")
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();

			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			Assert.Equal(4, game.CurrentPlayer.HandZone.Count);

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Sindragosa"));

			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);

			Assert.Equal("ICC_838t", game.CurrentPlayer.BoardZone[0].Card.Id);
			Assert.Equal("ICC_838", game.CurrentPlayer.BoardZone[1].Card.Id);
			Assert.Equal("ICC_838t", game.CurrentPlayer.BoardZone[2].Card.Id);

			Assert.Equal(3, game.CurrentPlayer.HandZone.Count);

			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, "Frostbolt", game.CurrentPlayer.BoardZone[0]));

			Assert.Equal(3, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(Rarity.LEGENDARY, game.CurrentPlayer.HandZone.Last().Card.Rarity);
		}

		// ------------------------------------------- SPELL - MAGE
		// [ICC_082] Frozen Clone - COST:3 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Secret:</b> After your opponent plays a minion, add two copies of it to_your hand.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact]
		public void FrozenClone_ICC_082()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frozen Clone"));
			IPlayable mirrorEntity = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mirror Entity"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, mirrorEntity));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion));

			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal(2, game.CurrentOpponent.HandZone.Count);
			Assert.True(game.CurrentOpponent.HandZone.ToList().TrueForAll(p => p.Card.Name == "Stonetusk Boar" && p.Id != minion.Id && p.Id != game.CurrentOpponent.BoardZone[0].Id));
		}

		// ------------------------------------------- SPELL - MAGE
		// [ICC_086] Glacial Mysteries - COST:8 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: Put one of each <b>Secret</b> from your deck into
		//       the battlefield.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_SECRET_ZONE_CAP_FOR_NON_SECRET = 0
		// --------------------------------------------------------
		// RefTag:
		// - SECRET = 1
		// --------------------------------------------------------
		[Fact]
		public void GlacialMysteries_ICC_086()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Frozen Clone"),
					Cards.FromName("Ice Barrier"),
					Cards.FromName("Ice Barrier"),
					Cards.FromName("Mirror Entity"),
					Cards.FromName("Counterspell"),
					Cards.FromName("Explosive Runes"),
					Cards.FromName("Mana Bind"),
					Cards.FromName("Mana Bind"),
					Cards.FromName("Potion of Polymorph"),
					Cards.FromName("Potion of Polymorph"),
					Cards.FromName("Vaporize"),
					Cards.FromName("Vaporize")
				},
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.ProcessCard("Glacial Mysteries");

			Assert.Equal(5, game.CurrentPlayer.SecretZone.Count);
			Assert.Equal(5, game.CurrentPlayer.SecretZone.Select(p => p.Card.Id).Distinct().Count());
		}

		// ------------------------------------------- SPELL - MAGE
		// [ICC_823] Simulacrum - COST:3 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: Copy the lowest Cost minion in your hand.
		// --------------------------------------------------------
		[Fact]
		public void Simulacrum_ICC_823()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Simulacrum"),
					Cards.FromName("Simulacrum"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Alexstrasza"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			if (game.CurrentPlayer.HandZone[0][GameTag.QUEST] == 1)
				Generic.Draw(game.CurrentPlayer);
			Assert.Equal(4, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Simulacrum"));
			Assert.Equal(4, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(2, game.CurrentPlayer.HandZone.Where(p => p.Card.Name == "Stonetusk Boar").Count());
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stonetusk Boar"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stonetusk Boar"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Simulacrum"));
			Assert.Equal(2, game.CurrentPlayer.HandZone.Where(p => p.Card.Name == "Alexstrasza").Count());
			Assert.Equal(2, game.CurrentPlayer.HandZone.Count);
		}

		// ------------------------------------------- SPELL - MAGE
		// [ICC_836] Breath of Sindragosa - COST:1 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $2 damage to a random enemy minion and <b>Freeze</b> it. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINIMUM_ENEMY_MINIONS = 1
		// --------------------------------------------------------
		// RefTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BreathOfSindragosa_ICC_836()
		{
			// TODO BreathOfSindragosa_ICC_836 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Breath of Sindragosa"));
		}

	}

	public class PaladinIcecrownTest
	{
		// --------------------------------------- MINION - PALADIN
		// [ICC_034] Arrogant Crusader - COST:4 [ATK:5/HP:2] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> If it's your opponent's turn, summon a 2/2 Ghoul.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void ArrogantCrusader_ICC_034()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Arrogant Crusader"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Player2Deck = new List<Card>()
				{
					Cards.FromName("Arrogant Crusader"),
				},
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Arrogant Crusader"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Arrogant Crusader"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.BoardZone[0], game.CurrentOpponent.BoardZone[0]));
			Assert.Empty(game.CurrentPlayer.BoardZone);
			Assert.Single(game.CurrentOpponent.BoardZone);
			Assert.Equal("ICC_900t", game.CurrentOpponent.BoardZone[0].Card.Id);
		}

		// --------------------------------------- MINION - PALADIN
		// [ICC_038] Righteous Protector - COST:1 [ATK:1/HP:1] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Divine Shield</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RighteousProtector_ICC_038()
		{
			// TODO RighteousProtector_ICC_038 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Righteous Protector"));
		}

		// --------------------------------------- MINION - PALADIN
		// [ICC_245] Blackguard - COST:6 [ATK:3/HP:9] 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: Whenever your hero is healed, deal that much damage to a random enemy minion.
		// --------------------------------------------------------
		[Fact]
		public void Blackguard_ICC_245()
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
			
			game.ProcessCard("Blackguard");
			game.CurrentPlayer.Hero.Damage = 6;
			game.EndTurn();
			Minion target = game.ProcessCard<Minion>("War Golem");
			game.EndTurn();
			game.ProcessCard("Holy Light", game.CurrentPlayer.Hero);
			Assert.Equal(1, target.Health);
		}

		// --------------------------------------- MINION - PALADIN
		// [ICC_801] Howling Commander - COST:3 [ATK:2/HP:2] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Draw a <b>Divine_Shield</b> minion from your deck.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact]
		public void HowlingCommander_ICC_801()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Howling Commander"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Razorfen Hunter"),
					Cards.FromName("Razorfen Hunter"),
					Cards.FromName("Argent Squire"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			Assert.Equal(4, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Howling Commander"));
			Assert.Equal(4, game.CurrentPlayer.HandZone.Count);
			Assert.True(((Minion)game.CurrentPlayer.HandZone.Last()).HasDivineShield);
		}

		// --------------------------------------- MINION - PALADIN
		// [ICC_820] Chillblade Champion - COST:4 [ATK:3/HP:2] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Charge</b>
		//       <b>Lifesteal</b>
		// --------------------------------------------------------
		// GameTag:
		// - CHARGE = 1
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ChillbladeChampion_ICC_820()
		{
			// TODO ChillbladeChampion_ICC_820 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Chillblade Champion"));
		}

		// --------------------------------------- MINION - PALADIN
		// [ICC_858] Bolvar, Fireblood - COST:5 [ATK:1/HP:7] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Divine Shield</b>
		//       After a friendly minion loses_<b>Divine Shield</b>, gain +2 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact]
		public void BolvarFireblood_ICC_858()
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

			game.ProcessCard("Argent Squire");
			game.ProcessCard("Argent Squire");
			game.ProcessCard("Argent Squire");
			game.ProcessCard("Argent Squire");
			game.ProcessCard("Argent Squire");
			game.ProcessCard("Bolvar, Fireblood");
			game.EndTurn();
			game.ProcessCard("Whirlwind");
			Assert.Equal(13, game.CurrentOpponent.BoardZone[5].AttackDamage);

		}

		// ---------------------------------------- SPELL - PALADIN
		// [ICC_039] Dark Conviction - COST:2 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: Set a minion's Attack and Health to 3.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DarkConviction_ICC_039()
		{
			// TODO DarkConviction_ICC_039 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dark Conviction"));
		}

		// ---------------------------------------- SPELL - PALADIN
		// [ICC_244] Desperate Stand - COST:2 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: Give a minion "<b>Deathrattle:</b> Return this to life with 1 Health."
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void DesperateStand_ICC_244()
		{
			// TODO DesperateStand_ICC_244 test
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

			game.ProcessCard("Bloodfen Raptor");
			var target = game.ProcessCard("Bloodfen Raptor");
			game.ProcessCard("Bloodfen Raptor");

			game.ProcessCard("Desperate Stand", target);
			game.ProcessCard("Hammer of Wrath", target, true);

			Assert.True(target.ToBeDestroyed);
			Assert.Equal(1, game.CurrentPlayer.BoardZone[1].Health);
		}

		// --------------------------------------- WEAPON - PALADIN
		// [ICC_071] Light's Sorrow - COST:4 [ATK:1/HP:0] 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: After a friendly minion loses <b>Divine Shield</b>, gain +1 Attack.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 4
		// --------------------------------------------------------
		// RefTag:
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void LightsSorrow_ICC_071()
		{
			// TODO LightsSorrow_ICC_071 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Light's Sorrow"));
		}

	}

	public class PriestIcecrownTest
	{
		// ---------------------------------------- MINION - PRIEST
		// [ICC_210] Shadow Ascendant - COST:2 [ATK:2/HP:2] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: [x]At the end of your turn,
		//       give another random
		//       friendly minion +1/+1.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ShadowAscendant_ICC_210()
		{
			// TODO ShadowAscendant_ICC_210 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadow Ascendant"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [ICC_212] Acolyte of Agony - COST:3 [ATK:3/HP:3] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Lifesteal</b>
		// --------------------------------------------------------
		// GameTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AcolyteOfAgony_ICC_212()
		{
			// TODO AcolyteOfAgony_ICC_212 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Acolyte of Agony"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [ICC_214] Obsidian Statue - COST:9 [ATK:4/HP:8] 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>. <b>Lifesteal</b>.
		//        <b>Deathrattle:</b> Destroy a
		//        random enemy minion.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - DEATHRATTLE = 1
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ObsidianStatue_ICC_214()
		{
			// TODO ObsidianStatue_ICC_214 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Obsidian Statue"));
		}

		// ---------------------------------------- MINION - PRIEST
		// [ICC_215] Archbishop Benedictus - COST:7 [ATK:4/HP:6] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Shuffle a copy of_your opponent's deck into your deck.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void ArchbishopBenedictus_ICC_215()
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

			Assert.Equal(26, game.CurrentPlayer.DeckZone.Count);
			int opDeckCount = game.CurrentOpponent.DeckZone.Count;

			game.ProcessCard("Archbishop Benedictus");
			Assert.Equal(26 + opDeckCount, game.CurrentPlayer.DeckZone.Count);
		}

		// ----------------------------------------- SPELL - PRIEST
		// [ICC_207] Devour Mind - COST:5 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: Copy 3 cards in your opponent's deck and add them to your hand.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DevourMind_ICC_207()
		{
			// TODO DevourMind_ICC_207 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Devour Mind"));
		}

		// ----------------------------------------- SPELL - PRIEST
		// [ICC_213] Eternal Servitude - COST:4 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Discover</b> a friendly minion that died this game. Summon it.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// - REQ_FRIENDLY_MINION_DIED_THIS_GAME = 0
		// --------------------------------------------------------
		// RefTag:
		// - DISCOVER = 1
		// --------------------------------------------------------
		[Fact]
		public void EternalServitude_ICC_213()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eternal Servitude"));
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Obsidian Statue"));
			for (int i = 0; i < 10; i++)
				Generic.Draw(game.CurrentPlayer);
			Assert.Equal(6, game.CurrentPlayer.GraveyardZone.Count);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable pyroblast = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Pyroblast"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, pyroblast, minion));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Single(game.CurrentPlayer.Choice.Choices);
			Assert.Equal(8, game.CurrentPlayer.GraveyardZone.Count);
			game.Process(ChooseTask.Pick(game.CurrentPlayer, game.CurrentPlayer.Choice.Choices[0]));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(8, game.CurrentPlayer.GraveyardZone.Count);
			Assert.Equal("Obsidian Statue", game.CurrentPlayer.BoardZone[0].Card.Name);
		}

		// ----------------------------------------- SPELL - PRIEST
		// [ICC_235] Shadow Essence - COST:6 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: Summon a 5/5 copy of_a random minion in_your deck.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact]
		public void ShadowEssence_ICC_235()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar")
				}
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadow Essence"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			var minion = game.CurrentPlayer.BoardZone[0];
			Assert.Equal(5, minion.Health);
			Assert.Equal(5, minion.AttackDamage);
			Assert.Equal(1, game.CurrentPlayer.DeckZone.Count);

		}

		// ----------------------------------------- SPELL - PRIEST
		// [ICC_802] Spirit Lash - COST:2 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Lifesteal</b>
		//       Deal $1 damage to_all_minions. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact]
		public void SpiritLash_ICC_802()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spirit Lash"));
			game.CurrentPlayer.Hero.Damage = 10;
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable minion4 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion4));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion5 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable minion6 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable minion7 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable minion8 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion5));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion6));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion7));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion8));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(10, game.Characters.Count);
			Assert.Equal(20, game.CurrentPlayer.Hero.Health);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(2, game.Characters.Count);
			Assert.Equal(28, game.CurrentPlayer.Hero.Health);
		}

		// ----------------------------------------- SPELL - PRIEST
		// [ICC_849] Embrace Darkness - COST:6 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]Choose an enemy minion.
		//       At the start of your turn,
		//       gain control of it.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_ENEMY_TARGET = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void EmbraceDarkness_ICC_849()
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
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Embrace Darkness"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, minion));
			Assert.False(minion.Controller == game.CurrentPlayer);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.True(minion.Controller == game.CurrentPlayer);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.True(minion.Controller == game.CurrentPlayer);
		}

	}

	public class RogueIcecrownTest
	{
		// ----------------------------------------- MINION - ROGUE
		// [ICC_065] Bone Baron - COST:5 [ATK:5/HP:5] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Add two 1/1 Skeletons to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BoneBaron_ICC_065()
		{
			// TODO BoneBaron_ICC_065 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bone Baron"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [ICC_240] Runeforge Haunter - COST:4 [ATK:5/HP:3] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: During your turn, your weapon doesn't lose Durability.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact]
		public void RuneforgeHaunter_ICC_240()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Runeforge Haunter"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));

			Assert.Equal(2, game.CurrentPlayer.Hero.Weapon.Durability);

			game.EndTurn();

			game.ProcessCard("Bloodsail Corsair");
			Assert.Equal(1, game.CurrentOpponent.Hero.Weapon.Durability);
		}

		// ----------------------------------------- MINION - ROGUE
		// [ICC_809] Plague Scientist - COST:3 [ATK:2/HP:3] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Combo:</b> Give a friendly minion <b>Poisonous</b>.
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_FOR_COMBO = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact]
		public void PlagueScientist_ICC_809()
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
			var testCard = (Minion)Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Plague Scientist"));
			var testCard2 = (Minion)Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Plague Scientist"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.False(testCard.Poisonous);
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard2, testCard));
			Assert.True(testCard.Poisonous);
		}

		// ----------------------------------------- MINION - ROGUE
		// [ICC_811] Lilian Voss - COST:4 [ATK:4/HP:5] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Replace spells in your hand with random spells <i>(from your opponent's class).</i>
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void LilianVoss_ICC_811()
		{
			// TODO LilianVoss_ICC_811 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			for (int i = 0; i < 9; i++)
				Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Preparation"));

			game.ProcessCard("Lilian Voss");

			for (int i = 0; i < 9; i++)
			{
				Assert.Equal(CardClass.PRIEST, game.CurrentPlayer.HandZone[i].Card.Class);
				Assert.Equal(CardType.SPELL, game.CurrentPlayer.HandZone[i].Card.Type);
			}


			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lilian Voss"));
		}

		// ----------------------------------------- MINION - ROGUE
		// [ICC_910] Spectral Pillager - COST:6 [ATK:5/HP:5] 
		// - Fac: neutral, Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Combo:</b> Deal damage equal
		//       to the number of other cards
		//       you've played this turn.
		// --------------------------------------------------------
		// GameTag:
		// - COMBO = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_FOR_COMBO = 0
		// --------------------------------------------------------
		[Fact]
		public void SpectralPillager_ICC_910()
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
				Player2HeroClass = CardClass.ROGUE,
				Player2Deck = new List<Card>
				{
					Cards.FromName("Wisp"),
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spectral Pillager"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wisp"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wisp"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wisp"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wisp"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard, game.CurrentOpponent.Hero));
			Assert.Equal(4, game.CurrentOpponent.Hero.Damage);

		}

		// ------------------------------------------ SPELL - ROGUE
		// [ICC_201] Roll the Bones - COST:2 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: Draw a card.
		//       If it has <b>Deathrattle</b>, cast this again.
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void RollTheBones_ICC_201()
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
					Cards.FromName("Undercity Huckster"),
					Cards.FromName("Undercity Huckster"),
					Cards.FromName("Undercity Huckster"),
					Cards.FromName("Undercity Huckster"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Roll the Bones"));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
			Assert.Equal(9, game.CurrentPlayer.HandZone.Count);
		}

		// ------------------------------------------ SPELL - ROGUE
		// [ICC_221] Leeching Poison - COST:2 
		// - Fac: neutral, Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: Give your weapon <b>Lifesteal</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_WEAPON_EQUIPPED = 0
		// --------------------------------------------------------
		// RefTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact]
		public void LeechingPoison_ICC_221()
		{
			// TODO LeechingPoison_ICC_221 test
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

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			game.ProcessCard("Deadly Poison");
			game.ProcessCard("Deadly Poison");
			game.ProcessCard("Leeching Poison");
			Assert.True(game.CurrentPlayer.Hero.Weapon.HasLifeSteal);
			game.CurrentPlayer.Hero.Damage = 10;
			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(5, game.CurrentPlayer.Hero.Damage);
		}

		// ------------------------------------------ SPELL - ROGUE
		// [ICC_233] Doomerang - COST:1 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: Throw your weapon at a minion. It deals its damage, then returns to_your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ImmuneToSpellpower = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// - REQ_WEAPON_EQUIPPED = 0
		// --------------------------------------------------------
		[Fact]
		public void Doomerang_ICC_233()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Doomerang"),
					Cards.FromName("N'Zoth's First Mate")
				},
				Player2HeroClass = CardClass.ROGUE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "N'Zoth's First Mate"));
			Assert.Equal(1, game.CurrentPlayer.Hero.Weapon.AttackDamage);
			Assert.Equal(3, game.CurrentPlayer.Hero.Weapon.Durability);
			Assert.Single(game.CurrentPlayer.BoardZone);
			Assert.Equal(3, game.CurrentPlayer.HandZone.Count());
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, "Doomerang", game.CurrentPlayer.BoardZone[0]));
			Assert.Null(game.CurrentPlayer.Hero.Weapon);
			Assert.Empty(game.CurrentPlayer.BoardZone);
			Assert.Equal(3, game.CurrentPlayer.HandZone.Count());
			Assert.Equal("OG_058", game.CurrentPlayer.HandZone[2].Card.Id);
		}

		// ----------------------------------------- WEAPON - ROGUE
		// [ICC_850] Shadowblade - COST:3 [ATK:3/HP:0] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Your hero is <b>Immune</b> this turn.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - IMMUNE = 1
		// --------------------------------------------------------
		[Fact]
		public void Shadowblade_ICC_850()
		{
			// TODO Shadowblade_ICC_850 test
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

			game.ProcessCard("Magma Rager");
			game.ProcessCard("Magma Rager");
			game.EndTurn();
			game.ProcessCard("Shadowblade");
			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentOpponent.BoardZone[0]));
			Assert.Equal(0, game.CurrentPlayer.Hero.Damage);
			game.EndTurn();
			game.EndTurn();
			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentOpponent.BoardZone[0]));
			Assert.Equal(5, game.CurrentPlayer.Hero.Damage);
		}

	}

	public class ShamanIcecrownTest
	{
		// ---------------------------------------- MINION - SHAMAN
		// [ICC_058] Brrrloc - COST:2 [ATK:2/HP:2] 
		// - Race: murloc, Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Freeze</b> an_enemy.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_ENEMY_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		// RefTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact]
		public void Brrrloc_ICC_058()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Brrrloc")
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, "Brrrloc", game.CurrentOpponent.Hero));
			Assert.True(game.CurrentOpponent.Hero.IsFrozen);
		}

		// ---------------------------------------- MINION - SHAMAN
		// [ICC_081] Drakkari Defender - COST:3 [ATK:2/HP:8] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Overload</b>: (3)
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - OVERLOAD = 3
		// - OVERLOAD_OWED = 3
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DrakkariDefender_ICC_081()
		{
			// TODO DrakkariDefender_ICC_081 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Drakkari Defender"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [ICC_088] Voodoo Hexxer - COST:5 [ATK:2/HP:7] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Freeze</b> any character damaged by this minion.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void VoodooHexxer_ICC_088()
		{
			// TODO VoodooHexxer_ICC_088 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Voodoo Hexxer"));
		}

		// ---------------------------------------- MINION - SHAMAN
		// [ICC_090] Snowfury Giant - COST:11 [ATK:8/HP:8] 
		// - Race: elemental, Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: Costs (1) less for each Mana Crystal you've <b><b>Overload</b>ed</b> this game.
		// --------------------------------------------------------
		// RefTag:
		// - OVERLOAD = 1
		// --------------------------------------------------------
		[Fact]
		public void SnowfuryGiant_ICC_090()
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
			var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Snowfury Giant"));

			game.ProcessCard("Feral Spirit");
			Assert.Equal(9, testCard.Cost);
			game.ProcessCard("Lava Burst", game.CurrentOpponent.Hero);
			Assert.Equal(7, testCard.Cost);
		}

		// ---------------------------------------- MINION - SHAMAN
		// [ICC_289] Moorabi - COST:6 [ATK:4/HP:4] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: Whenever another minion is <b>Frozen</b>, add a copy of it to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		// RefTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact]
		public void Moorabi_ICC_289()
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
			IPlayable testCard = game.ProcessCard("Moorabi", null, true);
			IPlayable raptor = game.ProcessCard("Bloodfen Raptor", null, true);
			game.ProcessCard("Ice Lance", testCard);
			Assert.Equal(4, game.CurrentPlayer.HandZone.Count);
			game.ProcessCard("Ice Lance", raptor);
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(raptor.Card.Id, game.CurrentPlayer.HandZone.Last().Card.Id);
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [ICC_056] Cryostasis - COST:2 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: Give a minion +3/+3 and <b>Freeze</b> it.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact]
		public void Cryostasis_ICC_056()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Cryostasis")
				},
				Player2HeroClass = CardClass.SHAMAN,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Murloc Raider"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, "Cryostasis", game.CurrentPlayer.BoardZone[0]));
			Assert.Equal(5, game.CurrentPlayer.BoardZone[0].AttackDamage);
			Assert.Equal(4, game.CurrentPlayer.BoardZone[0].Health);
			Assert.True(game.CurrentPlayer.BoardZone[0].IsFrozen);
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [ICC_078] Avalanche - COST:4 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Freeze</b> a minion and deal $3 damage to adjacent ones. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Avalanche_ICC_078()
		{
			// TODO Avalanche_ICC_078 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Avalanche"));
		}

		// ----------------------------------------- SPELL - SHAMAN
		// [ICC_089] Ice Fishing - COST:2 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: Draw 2 Murlocs from your deck.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IceFishing_ICC_089()
		{
			// TODO IceFishing_ICC_089 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ice Fishing"));
		}

		// ---------------------------------------- WEAPON - SHAMAN
		// [ICC_236] Ice Breaker - COST:3 [ATK:1/HP:0] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: Destroy any <b>Frozen</b> minion damaged by_this.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 3
		// --------------------------------------------------------
		// RefTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact]
		public void IceBreaker_ICC_236()
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ice Breaker"));

			game.ProcessCard("Ice Breaker");
			game.EndTurn();
			Minion minion1 = game.ProcessCard<Minion>("Bloodfen Raptor");
			Minion minion2 = game.ProcessCard<Minion>("Bloodfen Raptor");
			game.EndTurn();

			game.Process(HeroAttackTask.Any(game.CurrentPlayer, minion1));
			Assert.False(minion1.IsDead);

			game.ProcessCard("Ice Lance", minion2);
			Assert.True(minion2.IsFrozen);
			game.CurrentPlayer.Hero.IsExhausted = false;
			game.Process(HeroAttackTask.Any(game.CurrentPlayer, minion2));
			Assert.True(minion2.IsDead);
		}

	}

	public class WarlockIcecrownTest
	{
		// --------------------------------------- MINION - WARLOCK
		// [ICC_075] Despicable Dreadlord - COST:5 [ATK:4/HP:5] 
		// - Race: demon, Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: At the end of your turn, deal 1 damage to all enemy minions.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DespicableDreadlord_ICC_075()
		{
			// TODO DespicableDreadlord_ICC_075 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Despicable Dreadlord"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [ICC_218] Howlfiend - COST:3 [ATK:3/HP:6] 
		// - Race: demon, Fac: neutral, Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever this minion takes damage, discard a_random card.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Howlfiend_ICC_218()
		{
			// TODO Howlfiend_ICC_218 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Howlfiend"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [ICC_407] Gnomeferatu - COST:2 [ATK:2/HP:3] 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Remove
		//       the top card of your opponent's deck.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Gnomeferatu_ICC_407()
		{
			// TODO Gnomeferatu_ICC_407 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Gnomeferatu"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [ICC_841] Blood-Queen Lana'thel - COST:5 [ATK:1/HP:6] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Lifesteal</b>
		//       Has +1 Attack for each
		//       card you've discarded
		//       this game.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "Ignore")]
		public void BloodQueenLanathel_ICC_841()
		{
			// TODO BloodQueenLanathel_ICC_841 test
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blood-Queen Lana'thel"));
		}

		// --------------------------------------- MINION - WARLOCK
		// [ICC_903] Sanguine Reveler - COST:1 [ATK:1/HP:1] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy a friendly minion and gain_+2/+2.
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
		public void SanguineReveler_ICC_903()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Sanguine Reveler")
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Murloc Raider"));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, "Sanguine Reveler", game.CurrentPlayer.BoardZone[0]));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal("Sanguine Reveler", game.CurrentPlayer.BoardZone[0].Card.Name);
			Assert.Equal(3, game.CurrentPlayer.BoardZone[0].AttackDamage);
			Assert.Equal(3, game.CurrentPlayer.BoardZone[0].AttackDamage);
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [ICC_041] Defile - COST:2 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal $1 damage to all minions. If any die, cast this again. *spelldmg
		// --------------------------------------------------------
		[Fact]
		public void Defile_ICC_041()
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

			game.ProcessCard("Bloodfen Raptor", null, true);
			game.ProcessCard("Bloodfen Raptor", null, true);
			game.ProcessCard("Defile", null, true);
			Assert.Equal(1, game.CurrentPlayer.BoardZone[0].Health);
			Assert.Equal(1, game.CurrentPlayer.BoardZone[1].Health);

			game.ProcessCard("Bloodfen Raptor", null, true);	// 2
			game.ProcessCard("Ironfur Grizzly", null, true);	// 3
			game.ProcessCard("Dalaran Mage", null, true);		// 4
			game.ProcessCard("Defile", null, true);
			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);

			game.ProcessCard("Eggnapper", null, true);
			game.ProcessCard("Defile", null, true);
			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [ICC_055] Drain Soul - COST:2 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Lifesteal</b>
		//       Deal $2 damage
		//       to a minion. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void DrainSoul_ICC_055()
		{
			// TODO DrainSoul_ICC_055 test
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

			var target = game.ProcessCard("Stonetusk Boar");
			game.EndTurn();

			game.CurrentPlayer.Hero.Damage = 10;
			game.ProcessCard("Drain Soul", target);

			Assert.Equal(8, game.CurrentPlayer.Hero.Damage);
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [ICC_206] Treachery - COST:3 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: Choose a friendly minion and give it to_your opponent.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void Treachery_ICC_206()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Treachery")
				},
				Player2HeroClass = CardClass.WARLOCK,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Murloc Raider"));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, "Treachery", game.CurrentPlayer.BoardZone[0]));
			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
			Assert.True(game.CurrentOpponent.BoardZone[0].Controller == game.CurrentOpponent);
		}

		// ---------------------------------------- SPELL - WARLOCK
		// [ICC_469] Unwilling Sacrifice - COST:3 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: Choose a friendly minion. Destroy it and a random enemy minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void UnwillingSacrifice_ICC_469()
		{
			// TODO UnwillingSacrifice_ICC_469 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Unwilling Sacrifice"));
		}

	}

	public class WarriorIcecrownTest
	{
		// --------------------------------------- MINION - WARRIOR
		// [ICC_062] Mountainfire Armor - COST:3 [ATK:4/HP:3] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> If it's your opponent's turn,
		//       gain 6 Armor.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void MountainfireArmor_ICC_062()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mountainfire Armor")
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
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Mountainfire Armor"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, "Fireball", game.CurrentOpponent.BoardZone[0]));
			Assert.Equal(6, game.CurrentOpponent.Hero.Armor);
		}

		// --------------------------------------- MINION - WARRIOR
		// [ICC_238] Animated Berserker - COST:1 [ATK:1/HP:3] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: After you play a minion, deal 1 damage to it.
		// --------------------------------------------------------
		[Fact]
		public void AnimatedBerserker_ICC_238()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Animated Berserker"),
					Cards.FromName("Public Defender")
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Animated Berserker"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Public Defender"));
			Assert.Equal(6, game.CurrentPlayer.BoardZone[1].Health);
		}

		// --------------------------------------- MINION - WARRIOR
		// [ICC_405] Rotface - COST:8 [ATK:4/HP:6] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]Whenever this minion
		//       survives damage,
		//       summon a random
		//       <b>Legendary</b> minion.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact]
		public void Rotface_ICC_405()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Rotface")
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
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Rotface"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.BoardZone[0]));
			Assert.Equal(2, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal(Rarity.LEGENDARY, game.CurrentOpponent.BoardZone[1].Card.Rarity);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, "Fireball", game.CurrentOpponent.BoardZone[0]));
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
		}

		// --------------------------------------- MINION - WARRIOR
		// [ICC_408] Val'kyr Soulclaimer - COST:3 [ATK:1/HP:4] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]Whenever this minion
		//       survives damage,
		//       summon a 2/2 Ghoul.
		// --------------------------------------------------------
		[Fact]
		public void ValkyrSoulclaimer_ICC_408()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Val'kyr Soulclaimer")
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
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Val'kyr Soulclaimer"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.BoardZone[0]));
			Assert.Equal(2, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal("Ghoul", game.CurrentOpponent.BoardZone[1].Card.Name);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, "Fireball", game.CurrentOpponent.BoardZone[0]));
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
		}

		// --------------------------------------- MINION - WARRIOR
		// [ICC_450] Death Revenant - COST:5 [ATK:3/HP:3] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Gain +1/+1 for each damaged minion.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void DeathRevenant_ICC_450()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.WARRIOR,
				Player2Deck = new List<Card>()
				{
					Cards.FromName("Death Revenant")
				},
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Death Revenant"));
			Assert.Equal(4, game.CurrentPlayer.BoardZone[0].AttackDamage);
			Assert.Equal(4, game.CurrentPlayer.BoardZone[0].Health);
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [ICC_091] Dead Man's Hand - COST:2 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: Shuffle a copy of your hand into your deck.
		// --------------------------------------------------------
		[Fact]
		public void DeadMansHand_ICC_091()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Dead Man's Hand")
				},
				Player2HeroClass = CardClass.WARRIOR,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			Assert.Equal(26, game.CurrentPlayer.DeckZone.Count);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Dead Man's Hand"));
			Assert.Equal(3, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(29, game.CurrentPlayer.DeckZone.Count);
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [ICC_281] Forge of Souls - COST:2 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: Draw 2 weapons from your deck.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void ForgeOfSouls_ICC_281()
		{
			// TODO ForgeOfSouls_ICC_281 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Forge of Souls"));
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [ICC_837] Bring It On! - COST:2 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: Gain 10 Armor. Reduce the Cost of minions in your opponent's hand by (2).
		// --------------------------------------------------------
		[Fact]
		public void BringItOn_ICC_837()
		{
			// TODO BringItOn_ICC_837 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARRIOR,
				Player2HeroClass = CardClass.WARRIOR,
				Player2Deck = new List<Card>
				{
					Cards.FromName("Shield Block"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Bloodfen Raptor"),
					Cards.FromName("Dalaran Mage")
				},
				FillDecks = false,
				Shuffle = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bring It On!"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));

			Assert.Equal(10, game.CurrentPlayer.Hero.Armor);
			Assert.Equal(3, game.CurrentOpponent.HandZone[0].Cost);
			Assert.Equal(0, game.CurrentOpponent.HandZone[1].Cost);
			Assert.Equal(0, game.CurrentOpponent.HandZone[2].Cost);
			Assert.Equal(1, game.CurrentOpponent.HandZone[3].Cost);
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [ICC_064] Blood Razor - COST:4 [ATK:2/HP:0] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry and Deathrattle:</b>
		//       Deal 1 damage to all minions.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 2
		// - DEATHRATTLE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void BloodRazor_ICC_064()
		{
			// TODO BloodRazor_ICC_064 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Blood Razor"));
		}

	}

	public class NeutralIcecrownTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [ICC_018] Phantom Freebooter - COST:4 [ATK:3/HP:3] 
		// - Race: pirate, Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Gain stats equal to your weapon's.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void PhantomFreebooter_ICC_018()
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
			Minion testCard = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Phantom Freebooter"));
			game.ProcessCard("Assassin's Blade");												// 3/4
			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));	// 3/3
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
			Assert.Equal(6, testCard.AttackDamage);
			Assert.Equal(6, testCard.Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_019] Skelemancer - COST:5 [ATK:2/HP:2] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> If it's your opponent's turn, summon an 8/8 Skeleton.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Skelemancer_ICC_019()
		{
			// TODO Skelemancer_ICC_019 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Skelemancer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_023] Snowflipper Penguin - COST:0 [ATK:1/HP:1] 
		// - Race: beast, Set: icecrown, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SnowflipperPenguin_ICC_023()
		{
			// TODO SnowflipperPenguin_ICC_023 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Snowflipper Penguin"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_025] Rattling Rascal - COST:4 [ATK:2/HP:2] 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Summon a
		//       5/5 Skeleton.
		//       <b>Deathrattle:</b> Summon one
		//       for your opponent.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RattlingRascal_ICC_025()
		{
			// TODO RattlingRascal_ICC_025 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Rattling Rascal"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_026] Grim Necromancer - COST:4 [ATK:2/HP:4] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon two 1/1 Skeletons.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GrimNecromancer_ICC_026()
		{
			// TODO GrimNecromancer_ICC_026 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Grim Necromancer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_027] Bone Drake - COST:6 [ATK:6/HP:5] 
		// - Race: dragon, Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Add a random Dragon to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void BoneDrake_ICC_027()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Bone Drake")
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
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Bone Drake"));
			Assert.Equal(3, game.CurrentPlayer.HandZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fireball", game.CurrentOpponent.BoardZone[0]));
			Assert.Equal(4, game.CurrentOpponent.HandZone.Count);
			Assert.True(((Minion)game.CurrentOpponent.HandZone[3]).Race == Race.DRAGON);

		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_028] Sunborne Val'kyr - COST:5 [ATK:5/HP:4] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give adjacent minions +2 Health.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void SunborneValkyr_ICC_028()
		{
			// TODO SunborneValkyr_ICC_028 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sunborne Val'kyr"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_029] Cobalt Scalebane - COST:5 [ATK:5/HP:5] 
		// - Race: dragon, Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: At the end of your turn, give another random friendly minion +3 Attack.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CobaltScalebane_ICC_029()
		{
			// TODO CobaltScalebane_ICC_029 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cobalt Scalebane"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_031] Night Howler - COST:4 [ATK:3/HP:4] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever this minion takes
		//       damage, gain +2 Attack.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NightHowler_ICC_031()
		{
			// TODO NightHowler_ICC_031 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Night Howler"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_032] Venomancer - COST:5 [ATK:2/HP:5] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Poisonous</b>
		// --------------------------------------------------------
		// GameTag:
		// - POISONOUS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Venomancer_ICC_032()
		{
			// TODO Venomancer_ICC_032 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Venomancer"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_067] Vryghoul - COST:3 [ATK:3/HP:1] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: [x]<b>Deathrattle:</b> If it's your
		//       opponent's turn,
		//       summon a 2/2 Ghoul.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void Vryghoul_ICC_067()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Vryghoul")
				},
				Player2HeroClass = CardClass.MAGE,
				Player2Deck = new List<Card>()
				{
					Cards.FromName("Vryghoul")
				},
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Vryghoul"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Vryghoul"));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.BoardZone[0]));
			Assert.Single(game.CurrentOpponent.BoardZone);
			Assert.Equal("ICC_900t", game.CurrentOpponent.BoardZone[0].Card.Id);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentPlayer.BoardZone[0]));
			Assert.Empty(game.CurrentPlayer.BoardZone);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_092] Acherus Veteran - COST:1 [ATK:2/HP:1] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly minion +1 Attack.
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
		public void AcherusVeteran_ICC_092()
		{
			// TODO AcherusVeteran_ICC_092 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Acherus Veteran"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_093] Tuskarr Fisherman - COST:2 [ATK:2/HP:3] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly minion <b>Spell Damage +1</b>.
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
		// - SPELLPOWER = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TuskarrFisherman_ICC_093()
		{
			// TODO TuskarrFisherman_ICC_093 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tuskarr Fisherman"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_094] Fallen Sun Cleric - COST:2 [ATK:2/HP:1] 
		// - Set: icecrown, Rarity: common
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
		public void FallenSunCleric_ICC_094()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.WARRIOR,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fallen Sun Cleric"));
			IPlayable silenceSpell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Silence"));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wisp"));

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));

			Assert.Equal(1, game.CurrentPlayer.BoardZone[0].AttackDamage);
			Assert.Equal(1, game.CurrentPlayer.BoardZone[0].Health);

			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard, game.CurrentPlayer.BoardZone[0]));

			Assert.Equal(2, game.CurrentPlayer.BoardZone[0].AttackDamage);
			Assert.Equal(2, game.CurrentPlayer.BoardZone[0].Health);

			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, silenceSpell, game.CurrentPlayer.BoardZone[0]));

			Assert.Equal(1, game.CurrentPlayer.BoardZone[0].AttackDamage);
			Assert.Equal(1, game.CurrentPlayer.BoardZone[0].Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_096] Furnacefire Colossus - COST:6 [ATK:6/HP:6] 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Discard all weapons from your hand and gain their stats.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void FurnacefireColossus_ICC_096()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Shadowblade"),		// 3/2
					Cards.FromName("Shadowblade"),		// 3/2
					Cards.FromName("Shadowblade"),		// 3/2
					Cards.FromName("Assassin's Blade")	// 3/4
				},
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true,
				Shuffle = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			Minion testCard = game.ProcessCard<Minion>("Furnacefire Colossus");

			Assert.Equal(0, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(18, testCard.AttackDamage);
			Assert.Equal(16, testCard.Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_097] Grave Shambler - COST:4 [ATK:4/HP:4] 
		// - Race: elemental, Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever your weapon is destroyed, gain +1/+1.
		// --------------------------------------------------------
		[Fact]
		public void GraveShambler_ICC_097()
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

			Minion testCard = game.ProcessCard<Minion>("Grave Shambler");
			game.ProcessCard("Assassin's Blade", null, true);
			game.ProcessCard("Assassin's Blade", null, true);
			Assert.Equal(5, testCard.AttackDamage);
			game.ProcessCard("Malkorok", null, true);
			Assert.Equal(6, testCard.AttackDamage);
			game.ProcessCard("Assassin's Blade", null, true);
			Assert.Equal(7, testCard.AttackDamage);
			game.ProcessCard("Assassin's Blade", null, true);
			Assert.Equal(8, testCard.AttackDamage);
			game.PlayHeroPower();
			Assert.Equal(9, testCard.AttackDamage);

			Assert.Equal(9, testCard.Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_098] Tomb Lurker - COST:5 [ATK:5/HP:3] 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Add a random
		//       <b>Deathrattle</b> minion that died
		//       this game to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TombLurker_ICC_098()
		{
			// TODO TombLurker_ICC_098 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tomb Lurker"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_099] Ticking Abomination - COST:4 [ATK:5/HP:6] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Deal 5 damage to your minions.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void TickingAbomination_ICC_099()
		{
			// TODO TickingAbomination_ICC_099 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ticking Abomination"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_220] Deadscale Knight - COST:1 [ATK:1/HP:1] 
		// - Race: murloc, Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Lifesteal</b>
		// --------------------------------------------------------
		// GameTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DeadscaleKnight_ICC_220()
		{
			// TODO DeadscaleKnight_ICC_220 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Deadscale Knight"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_257] Corpse Raiser - COST:5 [ATK:3/HP:3] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Give a friendly
		//       minion "<b>Deathrattle:</b>
		//         Resummon this minion."
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// - DEATH_KNIGHT = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		// RefTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CorpseRaiser_ICC_257()
		{
			// TODO CorpseRaiser_ICC_257 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Corpse Raiser"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_314] The Lich King - COST:8 [ATK:8/HP:8] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]<b>Taunt</b>
		//       At the end of your turn,
		//       add a random <b>Death Knight</b>
		//       card to your hand.
		// --------------------------------------------------------
		// Entourage: ICC_314t3, ICC_314t2, ICC_314t7, ICC_314t4, ICC_314t5, ICC_314t6, ICC_314t8, ICC_314t1
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact]
		public void TheLichKing_ICC_314()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),

					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Frostbolt"),
					Cards.FromName("Frostbolt"),

					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
				},
				Player2Deck = new List<Card>
				{
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Sylvanas Windrunner"),
					Cards.FromName("Archmage Antonidas"),
					Cards.FromName("Frostbolt"),
					Cards.FromName("Stonetusk Boar")
				},
				FillDecks = false,
				Shuffle = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			IPlayable armyOfTheDead = Generic.DrawCard(game.CurrentPlayer, Cards.FromId("ICC_314t2"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, armyOfTheDead));
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(3, game.CurrentPlayer.GraveyardZone.Count);
			Assert.Equal(3, game.CurrentPlayer.DeckZone.Count);
			game.CurrentPlayer.UsedMana = 0;
			IPlayable doomPact = Generic.DrawCard(game.CurrentPlayer, Cards.FromId("ICC_314t3"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, doomPact));
			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(10, game.CurrentPlayer.GraveyardZone.Count);
			IPlayable deathGrip = Generic.DrawCard(game.CurrentPlayer, Cards.FromId("ICC_314t4"));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, deathGrip));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(0, game.CurrentOpponent.DeckZone.Count);
			game.CurrentPlayer.UsedMana = 0;
			IPlayable fireBall = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, fireBall, game.CurrentPlayer.Hero));
			Assert.Equal(24, game.CurrentPlayer.Hero.Health);
			IPlayable deathCoil = Generic.DrawCard(game.CurrentPlayer, Cards.FromId("ICC_314t5"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, deathCoil, game.CurrentPlayer.Hero));
			Assert.Equal(29, game.CurrentPlayer.Hero.Health);
			IPlayable deathCoil2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromId("ICC_314t5"));
			Assert.Equal(30, game.CurrentOpponent.Hero.Health);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, deathCoil2, game.CurrentOpponent.Hero));
			Assert.Equal(25, game.CurrentOpponent.Hero.Health);
			game.CurrentPlayer.UsedMana = 0;
			var injuredBlademaster = (Minion)Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Injured Blademaster"));
			IPlayable obliterate = Generic.DrawCard(game.CurrentPlayer, Cards.FromId("ICC_314t6"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, injuredBlademaster));
			Assert.Equal(3, injuredBlademaster.Health);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, obliterate, injuredBlademaster));
			Assert.Equal(0, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal(26, game.CurrentPlayer.Hero.Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, game.CurrentPlayer.HandZone[0]));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, game.CurrentPlayer.HandZone[0]));
			game.CurrentPlayer.UsedMana = 0;
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, game.CurrentPlayer.HandZone[0]));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, game.CurrentPlayer.HandZone[0], game.CurrentPlayer.BoardZone[2]));
			var testMinion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testMinion));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable frostmourne = Generic.DrawCard(game.CurrentPlayer, Cards.FromId("ICC_314t1"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, frostmourne));
			IPlayable testSpell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostbolt"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testSpell, testMinion));
			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentOpponent.BoardZone[0]));
			game.CurrentPlayer.Hero.IsExhausted = false;
			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentOpponent.BoardZone[0]));
			game.CurrentPlayer.Hero.IsExhausted = false;
			game.Process(HeroAttackTask.Any(game.CurrentPlayer, game.CurrentOpponent.BoardZone[0]));
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
			game.CurrentPlayer.UsedMana = 0;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Lich King"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal(6, game.CurrentOpponent.HandZone.Count);
			Assert.StartsWith("ICC_314t", game.CurrentOpponent.HandZone[5].Card.Id);
		}

		// ------------------------------------ SPELL - DEATHKNIGHT
		// [ICC_314t3] Doom Pact (*) - COST:5 
		// - Fac: neutral, Set: icecrown, 
		// --------------------------------------------------------
		// Text: [x]Destroy all minions. 
		//       Remove the top card 
		//       from your deck for each
		//       minion destroyed.
		// --------------------------------------------------------
		[Fact]
		public void DoomPact_ICC_314t3()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Stonetusk Boar")
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stonetusk Boar"));
			Assert.Single(game.CurrentPlayer.BoardZone);
			Assert.Equal(26, game.CurrentPlayer.DeckZone.Count());
			IPlayable doomPact = Generic.DrawCard(game.CurrentPlayer, Cards.FromId("ICC_314t3"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, doomPact));
			Assert.Empty(game.CurrentPlayer.BoardZone);
			Assert.Equal(25, game.CurrentPlayer.DeckZone.Count());
		}

		// ------------------------------------ SPELL - DEATHKNIGHT
		// [ICC_314t4] Death Grip (*) - COST:2 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: Steal a minion from your opponent's deck and add it to your hand.
		// --------------------------------------------------------
		[Fact]
		public void DeathGrip_ICC_314t4()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				Player2Deck = new List<Card>()
				{
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Bloodfen Raptor"),
					//Cards.FromName("Bloodfen Raptor"),
				},
				Shuffle = true,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			Assert.Equal(0, game.CurrentPlayer.HandZone.Count);
			IPlayable deathGrip1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromId("ICC_314t4"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, deathGrip1));
			Assert.Equal(1, game.CurrentPlayer.HandZone.Count);
			IPlayable deathGrip2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromId("ICC_314t4"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, deathGrip2));
			Assert.Equal(1, game.CurrentPlayer.HandZone.Count);

		}

		// ------------------------------------ SPELL - DEATHKNIGHT
		// [ICC_314t5] Death Coil (*) - COST:2 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: Deal $5 damage to an enemy, or restore #5 Health to a friendly character. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DeathCoil_ICC_314t5()
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Lich King"));
		}

		// ------------------------------------ SPELL - DEATHKNIGHT
		// [ICC_314t6] Obliterate (*) - COST:2 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: Destroy a minion. Your hero takes damage equal to its Health.
		// --------------------------------------------------------
		// GameTag:
		// - ImmuneToSpellpower = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Obliterate_ICC_314t6()
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Lich King"));
		}

		// ------------------------------------ SPELL - DEATHKNIGHT
		// [ICC_314t7] Anti-Magic Shell (*) - COST:4 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: Give your minions +2/+2 and "Can't be targeted by spells or Hero Powers."
		// --------------------------------------------------------
		// GameTag:
		// - CANT_BE_TARGETED_BY_SPELLS = 1
		// - CANT_BE_TARGETED_BY_HERO_POWERS = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AntiMagicShell_ICC_314t7()
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Lich King"));
		}

		// ------------------------------------ SPELL - DEATHKNIGHT
		// [ICC_314t8] Death and Decay (*) - COST:3 
		// - Fac: neutral, Set: icecrown, 
		// --------------------------------------------------------
		// Text: Deal $3 damage to all enemies. *spelldmg
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DeathandDecay_ICC_314t8()
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Lich King"));
		}

		// ----------------------------------- WEAPON - DEATHKNIGHT
		// [ICC_314t1] Frostmourne (*) - COST:7 [ATK:5/HP:0] 
		// - Set: icecrown, 
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon every minion killed by this weapon.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 3
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Frostmourne_ICC_314t1()
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Lich King"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_466] Saronite Chain Gang - COST:4 [ATK:2/HP:3] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Battlecry:</b> Summon a copy of this minion.
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void SaroniteChainGang_ICC_466()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Saronite Chain Gang"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(2, game.Player1.BoardZone.Count);
			Assert.Equal("ICC_466", game.Player1.BoardZone[0].Card.Id);
			Assert.Equal("ICC_466", game.Player1.BoardZone[1].Card.Id);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_467] Deathspeaker - COST:3 [ATK:2/HP:4] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly minion <b>Immune</b> this turn.
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
		// - IMMUNE = 1
		// --------------------------------------------------------
		[Fact]
		public void Deathspeaker_ICC_467()
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

			Minion target = game.ProcessCard<Minion>("Stonetusk Boar");
			game.ProcessCard("Deathspeaker", target);

			Assert.True(target.IsImmune);
			game.ProcessCard("Whirlwind");
			game.ProcessCard("Whirlwind");
			game.ProcessCard("Whirlwind");
			game.ProcessCard("Whirlwind");
			game.ProcessCard("Whirlwind");
			game.ProcessCard("Whirlwind");

			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);

			game.EndTurn();

			Assert.False(target.IsImmune);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_468] Wretched Tiller - COST:1 [ATK:1/HP:1] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever this minion attacks, deal 2 damage to_the enemy hero.
		// --------------------------------------------------------
		[Fact]
		public void WretchedTiller_ICC_468()
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

			Minion target = game.ProcessCard<Minion>("Stonetusk Boar");
			game.EndTurn();
			Minion testCard = game.ProcessCard<Minion>("Wretched Tiller");
			testCard.HasCharge = true;
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, testCard, target));

			Assert.Equal(2, game.CurrentOpponent.Hero.Damage);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_700] Happy Ghoul - COST:3 [ATK:3/HP:3] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: Costs (0) if your hero was healed this turn.
		// --------------------------------------------------------
		[Fact]
		public void HappyGhoul_ICC_700()
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
			IPlayable fireball = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, fireball, game.CurrentOpponent.Hero));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(6, game.CurrentPlayer.Hero.Damage);
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Happy Ghoul"));
			game.AuraUpdate();
			Assert.Equal(3, testCard.Cost);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentPlayer.Hero));
			Assert.Equal(4, game.CurrentPlayer.Hero.Damage);
			Assert.Equal(0, testCard.Cost);

			game.EndTurn();
			game.EndTurn();

			Assert.Equal(3, testCard.Cost);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_701] Skulking Geist - COST:6 [ATK:4/HP:6] 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy all
		//       1-Cost spells in both hands and decks.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void SkulkingGeist_ICC_701()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Arcane Missiles"),
					Cards.FromName("Arcane Missiles"),
					Cards.FromName("Arcane Missiles"),
					Cards.FromName("Arcane Missiles"),
					Cards.FromName("Arcane Missiles"),
					Cards.FromName("Arcane Missiles"),
					Cards.FromName("Arcane Missiles"),
					Cards.FromName("Arcane Missiles"),
					Cards.FromName("Arcane Missiles"),
					Cards.FromName("Arcane Missiles")
				},
				Player2Deck = new List<Card>
				{
					Cards.FromName("Mirror Image"),
					Cards.FromName("Mirror Image"),
					Cards.FromName("Mirror Image"),
					Cards.FromName("Mirror Image"),
					Cards.FromName("Mirror Image"),
					Cards.FromName("Mirror Image"),
					Cards.FromName("Mirror Image"),
					Cards.FromName("Mirror Image"),
					Cards.FromName("Mirror Image"),
					Cards.FromName("Mirror Image")
				},
				FillDecks = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Skulking Geist"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(0, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(0, game.CurrentPlayer.DeckZone.Count);
			Assert.Equal(1, game.CurrentOpponent.HandZone.Count);	//	The Coin
			Assert.Equal(0, game.CurrentOpponent.DeckZone.Count);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_702] Shallow Gravedigger - COST:3 [ATK:3/HP:1] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Add a random <b>Deathrattle</b> minion to your_hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void ShallowGravedigger_ICC_702()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Shallow Gravedigger")
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Shallow Gravedigger"));
			Assert.Equal(3, game.CurrentPlayer.HandZone.Count);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentPlayer.BoardZone[0]));
			Assert.Equal(4, game.CurrentPlayer.HandZone.Count);
			Assert.True(game.CurrentPlayer.HandZone[3].HasDeathrattle);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_705] Bonemare - COST:8 [ATK:5/HP:5] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a friendly minion +4/+4 and <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE = 0
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact]
		public void Bonemare_ICC_705()
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
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(1, minion.Health);
			Assert.Equal(1, minion.AttackDamage);
			Assert.False(minion.HasTaunt);

			IPlayable bonemare = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bonemare"));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, bonemare, minion));

			Assert.Equal(5, minion.Health);
			Assert.Equal(5, minion.AttackDamage);
			Assert.True(minion.HasTaunt);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_706] Nerubian Unraveler - COST:6 [ATK:5/HP:5] 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: Spells cost (2) more.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NerubianUnraveler_ICC_706()
		{
			// TODO NerubianUnraveler_ICC_706 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nerubian Unraveler"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_810] Deathaxe Punisher - COST:4 [ATK:3/HP:3] 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a random <b>Lifesteal</b> minion in your hand +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact]
		public void DeathaxePunisher_ICC_810()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Deathaxe Punisher"),
					Cards.FromName("Deathaxe Punisher"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Bloodworm"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Deathaxe Punisher"));
			Assert.Equal(3, game.CurrentPlayer.HandZone.Count());
			Assert.Equal(2, ((Minion)game.CurrentPlayer.HandZone[2]).AttackDamage);
			Assert.Equal(1, ((Minion)game.CurrentPlayer.HandZone[2]).Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.Equal("Bloodworm", game.CurrentPlayer.HandZone[3].Card.Name);
			Assert.Equal(4, ((Minion)game.CurrentPlayer.HandZone[3]).AttackDamage);
			Assert.Equal(4, ((Minion)game.CurrentPlayer.HandZone[3]).Health);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Deathaxe Punisher"));
			Assert.Equal(6, ((Minion)game.CurrentPlayer.HandZone[2]).AttackDamage);
			Assert.Equal(6, ((Minion)game.CurrentPlayer.HandZone[2]).Health);
			
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Deathaxe Punisher"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_812] Meat Wagon - COST:4 [ATK:1/HP:4] 
		// - Race: mechanical, Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Deathrattle:</b> Summon a
		//       minion from your deck
		//       with less Attack than
		//       this minion.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void MeatWagon_ICC_812()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Bloodfen Raptor"),
					Cards.FromName("Bloodfen Raptor"),
					Cards.FromName("Bloodfen Raptor"),
					Cards.FromName("Bloodfen Raptor"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Bloodfen Raptor"),
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			IPlayable testCard = game.ProcessCard("Meat Wagon", null, true);
			game.ProcessCard("Raid Leader", null, true);

			game.ProcessCard("Fireball", testCard);

			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal("Stonetusk Boar", game.CurrentPlayer.BoardZone.Last().Card.Name);


		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_851] Prince Keleseth - COST:2 [ATK:2/HP:2] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your deck has_no 2-Cost cards, give_all minions in your deck +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void PrinceKeleseth_ICC_851()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Arcane Intellect"),
					Cards.FromName("Arcane Intellect"),
					Cards.FromName("Arcane Intellect"),
					Cards.FromName("Arcane Intellect"),
					Cards.FromName("Dalaran Mage"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
				},
				Player2HeroClass = CardClass.MAGE,
				FillDecks = false,
				Shuffle = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Prince Keleseth"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, game.CurrentPlayer.HandZone[3]));
			Assert.Equal(2, ((ICharacter)game.CurrentPlayer.HandZone[3]).AttackDamage);
			Assert.Equal(5, ((ICharacter)game.CurrentPlayer.HandZone[3]).Health);
			Assert.Equal(2, ((ICharacter)game.CurrentPlayer.HandZone[4]).AttackDamage);
			Assert.Equal(2, ((ICharacter)game.CurrentPlayer.HandZone[4]).Health);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, game.CurrentPlayer.HandZone[4]));
			Assert.Equal(2, game.CurrentPlayer.BoardZone[1].AttackDamage);
			Assert.Equal(2, game.CurrentPlayer.BoardZone[1].Health);

		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_852] Prince Taldaram - COST:3 [ATK:3/HP:3] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your deck has_no 3-Cost cards, transform into a 3/3 copy of a minion.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_DRAG_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void PrinceTaldaram_ICC_852()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			Minion target = game.ProcessCard<Minion>("Stonetusk Boar");
			game.ProcessCard("Blessing of Kings", target, asZeroCost: true);
			game.ProcessCard("Blessing of Might", target);

			Assert.Equal(8, target.AttackDamage);

			game.ProcessCard("Prince Taldaram", target);

			Minion transformed = game.CurrentPlayer.BoardZone[1];
			Assert.Equal(target.Card.Id, transformed.Card.Id);
			Assert.Equal(3, transformed.AttackDamage);
			Assert.Equal(3, transformed.Health);
			Assert.True(transformed.HasCharge);

		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_853] Prince Valanar - COST:4 [ATK:4/HP:4] 
		// - Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If your deck has no 4-Cost cards, gain <b>Lifesteal</b> and <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact]
		public void PrinceValanar_ICC_853()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Arcane Intellect"),
					Cards.FromName("Arcane Intellect"),
					Cards.FromName("Arcane Intellect"),
					Cards.FromName("Arcane Intellect"),
					Cards.FromName("Polymorph"),
				},
				Player2HeroClass = CardClass.MAGE,
				FillDecks = false,
				Shuffle = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			var testCard = (Minion)Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Prince Valanar"));
			var testCard2 = (Minion)Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Prince Valanar"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
			Assert.False(testCard.HasTaunt);
			Assert.False(testCard.HasLifeSteal);
			game.Player1.UsedMana = 0;
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Arcane Intellect"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard2));
			Assert.True(testCard2.HasTaunt);
			Assert.True(testCard2.HasLifeSteal);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_854] Arfus - COST:4 [ATK:2/HP:2] 
		// - Race: beast, Set: icecrown, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Add a random <b>Death Knight</b> card to your_hand.
		// --------------------------------------------------------
		// Entourage: ICC_314t2, ICC_314t3, ICC_314t4, ICC_314t5, ICC_314t7, ICC_314t8, ICC_314t6, ICC_314t1
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void Arfus_ICC_854()
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
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arfus"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			IPlayable frostBolt = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostbolt"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, frostBolt, testCard));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			Assert.StartsWith("ICC_314t", game.CurrentPlayer.HandZone[4].Card.Id);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_855] Hyldnir Frostrider - COST:3 [ATK:4/HP:4] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> <b>Freeze</b> your other minions.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		[Fact]
		public void HyldnirFrostrider_ICC_855()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>() {
					Cards.FromName("Hyldnir Frostrider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider")
				},
				Player2HeroClass = CardClass.MAGE,
				Player2Deck = new List<Card>() {
					Cards.FromName("Hyldnir Frostrider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider")
				},
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Murloc Raider"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Murloc Raider"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Murloc Raider"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Murloc Raider"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Hyldnir Frostrider"));
			Assert.False(game.CurrentOpponent.BoardZone[0].IsFrozen);
			Assert.False(game.CurrentOpponent.BoardZone[1].IsFrozen);
			Assert.True(game.CurrentPlayer.BoardZone[0].IsFrozen);
			Assert.True(game.CurrentPlayer.BoardZone[1].IsFrozen);
			Assert.False(game.CurrentPlayer.BoardZone[2].IsFrozen);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_856] Spellweaver - COST:6 [ATK:4/HP:4] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Spell Damage +2</b>
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 2
		// --------------------------------------------------------
		[Fact]
		public void Spellweaver_ICC_856()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spellweaver"));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, game.CurrentOpponent.Hero));
			Assert.Equal(8, game.CurrentOpponent.Hero.Damage);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_900] Necrotic Geist - COST:6 [ATK:5/HP:3] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever one of your other minions dies, summon a 2/2 Ghoul.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void NecroticGeist_ICC_900()
		{
			// TODO NecroticGeist_ICC_900 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Necrotic Geist"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_901] Drakkari Enchanter - COST:3 [ATK:1/HP:5] 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: Your end of turn effects trigger twice.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		[Fact]
		public void DrakkariEnchanter_ICC_901()
		{
			// TODO DrakkariEnchanter_ICC_901 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.ProcessCard("Drakkari Enchanter");
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_902] Mindbreaker - COST:3 [ATK:2/HP:5] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: Hero Powers are disabled.
		// --------------------------------------------------------
		[Fact]
		public void Mindbreaker_ICC_902()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mindbreaker")
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Mindbreaker"));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(30, game.CurrentOpponent.Hero.Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentOpponent.Hero));
			Assert.Equal(30, game.CurrentOpponent.Hero.Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_904] Wicked Skeleton - COST:4 [ATK:1/HP:1] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Gain +1/+1 for_each minion that died_this turn.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void WickedSkeleton_ICC_904()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Wicked Skeleton"),
					Cards.FromName("Wicked Skeleton")
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wicked Skeleton"));
			Assert.Equal(1, game.CurrentPlayer.BoardZone[0].AttackDamage);
			Assert.Equal(1, game.CurrentPlayer.BoardZone[0].Health);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentPlayer.BoardZone[0]));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wicked Skeleton"));
			Assert.Equal(2, game.CurrentPlayer.BoardZone[0].AttackDamage);
			Assert.Equal(2, game.CurrentPlayer.BoardZone[0].Health);
			
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_905] Bloodworm - COST:5 [ATK:4/HP:4] 
		// - Race: beast, Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Lifesteal</b>
		// --------------------------------------------------------
		// GameTag:
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Bloodworm_ICC_905()
		{
			// TODO Bloodworm_ICC_905 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodworm"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_911] Keening Banshee - COST:4 [ATK:5/HP:5] 
		// - Set: icecrown, Rarity: rare
		// --------------------------------------------------------
		// Text: Whenever you play a card, remove the top 3 cards of_your deck.
		// --------------------------------------------------------
		[Fact]
		public void KeeningBanshee_ICC_911()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Keening Banshee"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Murloc Raider"),
					Cards.FromName("Fireball"),
					Cards.FromName("Fireball"),
					Cards.FromName("Ice Barrier"),
					Cards.FromName("Ice Barrier")
				},
				Player2HeroClass = CardClass.MAGE,
				Shuffle = false,
				FillDecks = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Keening Banshee"));
			Assert.Equal(5, game.CurrentPlayer.DeckZone.Count());
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stonetusk Boar"));
			Assert.Equal(2, game.CurrentPlayer.DeckZone.Count());
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stonetusk Boar"));
			Assert.Empty(game.CurrentPlayer.DeckZone);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_912] Corpsetaker - COST:4 [ATK:3/HP:3] 
		// - Set: icecrown, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> Gain <b>Taunt</b> if your
		//       deck has a <b>Taunt</b> minion.
		//       Repeat for <b>Divine Shield</b>,
		//       <b>Lifesteal</b>, <b>Windfury</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - WINDFURY = 1
		// - TAUNT = 1
		// - DIVINE_SHIELD = 1
		// - LIFESTEAL = 1
		// --------------------------------------------------------
		[Fact]
		public void Corpsetaker_ICC_912()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Corpsetaker")
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
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Corpsetaker"));
			Assert.Equal(game.CurrentPlayer.DeckZone.Any(p => p is Minion && ((Minion)p).HasTaunt), game.CurrentPlayer.BoardZone[0].HasTaunt);
			Assert.Equal(game.CurrentPlayer.DeckZone.Any(p => p is Minion && ((Minion)p).HasDivineShield), game.CurrentPlayer.BoardZone[0].HasDivineShield);
			Assert.Equal(game.CurrentPlayer.DeckZone.Any(p => p is Minion && ((Minion)p).HasLifeSteal), game.CurrentPlayer.BoardZone[0].HasLifeSteal);
			Assert.Equal(game.CurrentPlayer.DeckZone.Any(p => p is Minion && ((Minion)p).HasWindfury), game.CurrentPlayer.BoardZone[0].HasWindfury);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [ICC_913] Tainted Zealot - COST:2 [ATK:1/HP:1] 
		// - Set: icecrown, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Divine Shield</b>
		//       <b>Spell Damage +1</b>
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 1
		// - DIVINE_SHIELD = 1
		// --------------------------------------------------------
		[Fact]
		public void TaintedZealot_ICC_913()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Tainted Zealot"));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Frostbolt"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.True(game.CurrentPlayer.BoardZone[0].HasDivineShield);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, game.CurrentOpponent.Hero));
			Assert.Equal(4, game.CurrentOpponent.Hero.Damage);
		}

	}

}
