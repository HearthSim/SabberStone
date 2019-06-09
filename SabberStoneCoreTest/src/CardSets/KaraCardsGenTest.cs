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
using System.Collections.Generic;
using SabberStoneCore.Config;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.PlayerTasks;
using SabberStoneCore.Model.Entities;

using Generic = SabberStoneCore.Actions.Generic;
using System.Linq;

namespace SabberStoneCoreTest.CardSets
{

	public class DruidKaraTest
	{
		// ------------------------------------------ SPELL - DRUID
		// [KAR_075] Moonglade Portal - COST:6 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: Restore #6 Health. Summon a random
		//       6-Cost minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void MoongladePortal_KAR_075()
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
			game.Player1.Hero.Damage = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Moonglade Portal"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, game.CurrentPlayer.Hero));
			Assert.Equal(26, game.CurrentPlayer.Hero.Health);
			Assert.Equal(6, game.CurrentPlayer.BoardZone[0].Card.Cost);
		}

		// ----------------------------------------- MINION - DRUID
		// [KAR_065] Menagerie Warden - COST:6 [ATK:5/HP:5] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Choose a friendly Beast. Summon a_copy of it.
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
		public void MenagerieWarden_KAR_065()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Menagerie Warden"));
			IPlayable beast = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, beast));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard, (ICharacter) beast));
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(beast.Card.Id, game.CurrentPlayer.BoardZone[0].Card.Id);
			Assert.Equal(beast.Card.Id, game.CurrentPlayer.BoardZone[2].Card.Id);
		}

		// ----------------------------------------- MINION - DRUID
		// [KAR_300] Enchanted Raven - COST:1 [ATK:2/HP:2] 
		// - Race: beast, Set: kara, Rarity: common
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EnchantedRaven_KAR_300()
		{
			// TODO EnchantedRaven_KAR_300 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Enchanted Raven"));
		}
	}


	public class HunterKaraTest
	{
		// ----------------------------------------- SPELL - HUNTER
		// [KAR_004] Cat Trick - COST:2 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Secret:</b> After your opponent casts a spell, summon a 4/2 Panther with <b>Stealth</b>.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		// RefTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact]
		public void CatTrick_KAR_004()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cat Trick"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(1, game.CurrentPlayer.SecretZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, game.CurrentPlayer.Hero));
			Assert.Equal(0, game.CurrentOpponent.SecretZone.Count);
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
		}

		// ---------------------------------------- MINION - HUNTER
		// [KAR_005] Kindly Grandmother - COST:2 [ATK:1/HP:1] 
		// - Race: beast, Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Summon a 3/2 Big Bad Wolf.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void KindlyGrandmother_KAR_005()
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
			var testCard = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kindly Grandmother"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, testCard));
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal("KAR_005a", game.CurrentOpponent.BoardZone[0].Card.Id);
		}

		// ---------------------------------------- MINION - HUNTER
		// [KAR_006] Cloaked Huntress - COST:3 [ATK:3/HP:4] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: Your <b>Secrets</b> cost (0).
		// --------------------------------------------------------
		// RefTag:
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		[Fact]
		public void CloakedHuntress_KAR_006()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Snake Trap")
				},
				Player2HeroClass = CardClass.PRIEST,
				FillDecks = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Cloaked Huntress"));
			Assert.Equal(2, game.CurrentPlayer.HandZone[0].Cost);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(0, game.CurrentPlayer.HandZone[0].Cost);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shadow Word: Pain"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, (ICharacter) testCard));
			Assert.Equal(2, game.CurrentOpponent.HandZone[0].Cost);
		}
	}


	public class MageKaraTest
	{
		// ------------------------------------------- SPELL - MAGE
		// [KAR_076] Firelands Portal - COST:7 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: Deal $5 damage. Summon a random
		//       5-Cost minion. *spelldmg
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void FirelandsPortal_KAR_076()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Firelands Portal"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, game.CurrentOpponent.Hero));
			Assert.Equal(25, game.CurrentOpponent.Hero.Health);
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(5, game.CurrentPlayer.BoardZone[0].Card.Cost);
		}

		// ------------------------------------------ MINION - MAGE
		// [KAR_009] Babbling Book - COST:1 [ATK:1/HP:1] 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add a random Mage spell to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void BabblingBook_KAR_009()
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
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Babbling Book"));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Babbling Book"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard1));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard2));
			Assert.Equal(CardClass.MAGE, game.CurrentPlayer.HandZone[4].Card.Class);
			Assert.Equal(CardClass.MAGE, game.CurrentPlayer.HandZone[5].Card.Class);
			Assert.Equal(CardType.SPELL, game.CurrentPlayer.HandZone[4].Card.Type);
			Assert.Equal(CardType.SPELL, game.CurrentPlayer.HandZone[5].Card.Type);
		}

		// ------------------------------------------ MINION - MAGE
		// [KAR_092] Medivh's Valet - COST:2 [ATK:2/HP:3] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you control a <b>Secret</b>, deal 3 damage.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_SECRETS = 1
		// --------------------------------------------------------
		// RefTag:
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		[Fact]
		public void MedivhsValet_KAR_092()
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
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Medivh's Valet"));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Medivh's Valet"));
			IPlayable secret = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mirror Entity"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, secret));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard2, game.CurrentOpponent.Hero));
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(27, game.CurrentOpponent.Hero.Health);
		}
	}


	public class PaladinKaraTest
	{
		// ---------------------------------------- SPELL - PALADIN
		// [KAR_077] Silvermoon Portal - COST:4 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: Give a minion +2/+2. Summon a random
		//       2-Cost minion.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void SilvermoonPortal_KAR_077()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Silvermoon Portal"));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, (ICharacter) minion));
			Assert.Equal(3, ((Minion)minion).AttackDamage - (minion.AuraEffects?.ATK ?? 0));
			Assert.Equal(3, ((Minion)minion).Health);
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);

			// This test rarely fails when the summoned minion has Aura, for example, Dire Wolf Alpha can interrupt this test.
		}

		// --------------------------------------- MINION - PALADIN
		// [KAR_010] Nightbane Templar - COST:3 [ATK:2/HP:3] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding a Dragon, summon two 1/1 Whelps.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void NightbaneTemplar_KAR_010()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Azure Drake"),
				},
				Player2HeroClass = CardClass.PALADIN,
				FillDecks = true,
				FillDecksPredictably = true,
				Shuffle = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Nightbane Templar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
		}

		// --------------------------------------- MINION - PALADIN
		// [KAR_057] Ivory Knight - COST:6 [ATK:4/HP:4] 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> <b>Discover</b> a spell.
		//       Restore Health to your hero
		//       equal to its Cost.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TREASURE = 1
		// --------------------------------------------------------
		[Fact]
		public void IvoryKnight_KAR_057()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ivory Knight"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			IPlayable spell = game.IdEntityDic[game.CurrentPlayer.Choice.Choices[0]];
			game.Process(ChooseTask.Pick(game.CurrentPlayer, game.CurrentPlayer.Choice.Choices[0]));
			Assert.Equal(spell, game.CurrentPlayer.HandZone[4]);
			Assert.Equal(20 + spell.Cost, game.CurrentPlayer.Hero.Health);
		}
	}


	public class PriestKaraTest
	{
		// ----------------------------------------- SPELL - PRIEST
		// [KAR_013] Purify - COST:2 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Silence</b> a friendly minion. Draw a card.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		// RefTag:
		// - SILENCE = 1
		// --------------------------------------------------------
		[Fact]
		public void Purify_KAR_013()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Purify"));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Loot Hoarder"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.True(((Minion)minion).HasDeathrattle);
			Assert.Equal(1, game.CurrentPlayer.NumCardsDrawnThisTurn);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, (ICharacter) minion));
			Assert.False(((Minion)minion).HasDeathrattle);
			Assert.Equal(2, game.CurrentPlayer.NumCardsDrawnThisTurn);
		}

		// ---------------------------------------- MINION - PRIEST
		// [KAR_035] Priest of the Feast - COST:4 [ATK:3/HP:6] 
		// - Fac: neutral, Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, restore 3 Health to
		//       your hero.
		// --------------------------------------------------------
		[Fact]
		public void PriestOfTheFeast_KAR_035()
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
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.CurrentPlayer.Hero.Damage = 3;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Priest of the Feast"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(27, game.CurrentPlayer.Hero.Health);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, game.CurrentPlayer.HandZone[4]));
			Assert.Equal(30, game.CurrentPlayer.Hero.Health);
		}

		// ---------------------------------------- MINION - PRIEST
		// [KAR_204] Onyx Bishop - COST:5 [ATK:3/HP:4] 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a friendly minion that died this game.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void OnyxBishop_KAR_204()
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
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Onyx Bishop"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Injured Blademaster"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			Assert.Equal(2, game.CurrentOpponent.BoardZone.Count);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, (ICharacter)minion));
			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Onyx Bishop"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard2));
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(minion.Card.Id, game.CurrentPlayer.BoardZone[2].Card.Id);
			Assert.Equal(7, game.CurrentPlayer.BoardZone[2].Health);
		}
	}


	public class RogueKaraTest
	{
		// ----------------------------------------- MINION - ROGUE
		// [KAR_069] Swashburglar - COST:1 [ATK:1/HP:1] 
		// - Race: pirate, Fac: neutral, Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Add a random class card to your hand <i>(from your opponent's class).</i>
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void Swashburglar_KAR_069()
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
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Swashburglar"));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Swashburglar"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard1));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard2));
			Assert.Equal(CardClass.MAGE, game.CurrentPlayer.HandZone[4].Card.Class);
			Assert.Equal(CardClass.MAGE, game.CurrentPlayer.HandZone[5].Card.Class);
		}

		// ----------------------------------------- MINION - ROGUE
		// [KAR_070] Ethereal Peddler - COST:5 [ATK:5/HP:6] 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: [x]<b>Battlecry:</b> If you're holding
		//       any non-Rogue class cards,
		//       _reduce their Cost by (2).
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void EtherealPeddler_KAR_070()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player2HeroClass = CardClass.ROGUE,

				Player1Deck = new List<Card>()
				{
					Cards.FromName("Mimic Pod"),	// Rogue - 3 cost
					Cards.FromName("Sprint"),		// Rogue - 7 cost
					Cards.FromName("Redemption"),   // Paladin - 1 cost
					Cards.FromName("Blizzard"),		// Mage - 6 cost
				},
				Shuffle = true,
				FillDecks = false,
				FillDecksPredictably = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ethereal Peddler"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			IPlayable card1 = game.CurrentPlayer.HandZone[0];
			Assert.Equal(
				card1.Card.Class == CardClass.ROGUE ? card1.Cost : (card1.Card.Cost > 1 ? card1.Card.Cost - 2 : 0),
				card1.Cost);
			IPlayable card2 = game.CurrentPlayer.HandZone[1];
			Assert.Equal(
				card2.Card.Class == CardClass.ROGUE ? card2.Cost : (card2.Card.Cost > 1 ? card2.Card.Cost - 2 : 0),
				card2.Cost);
			IPlayable card3 = game.CurrentPlayer.HandZone[2];
			Assert.Equal(
				card3.Card.Class == CardClass.ROGUE ? card3.Cost : (card3.Card.Cost > 1 ? card3.Card.Cost - 2 : 0),
				card3.Cost);
			IPlayable card4 = game.CurrentPlayer.HandZone[3];
			Assert.Equal(
				card4.Card.Class == CardClass.ROGUE ? card4.Cost : (card4.Card.Cost > 1 ? card4.Card.Cost - 2 : 0),
				card4.Cost);
		}

		// ----------------------------------------- MINION - ROGUE
		// [KAR_094] Deadly Fork - COST:3 [ATK:3/HP:2] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Add a 3/2 weapon to your hand.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void DeadlyFork_KAR_094()
		{
			// TODO DeadlyFork_KAR_094 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Deadly Fork"));
		}
	}


	public class ShamanKaraTest
	{
		// ----------------------------------------- SPELL - SHAMAN
		// [KAR_073] Maelstrom Portal - COST:2 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: Deal_$1_damage to_all_enemy_minions. Summon_a_random
		//       1-Cost minion. *spelldmg
		// --------------------------------------------------------
		[Fact]
		public void MaelstromPortal_KAR_073()
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
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Injured Blademaster"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Maelstrom Portal"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell1));

			Assert.Equal(1, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);

			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodmage Thalnos"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));

			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Maelstrom Portal"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell2));

			Assert.Equal(0, game.CurrentOpponent.BoardZone.Count);
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(1, game.CurrentPlayer.BoardZone[0].Cost);
			Assert.Equal(2, game.CurrentPlayer.BoardZone[1].Cost);
			Assert.Equal(1, game.CurrentPlayer.BoardZone[2].Cost);
		}

		// ---------------------------------------- MINION - SHAMAN
		// [KAR_021] Wicked Witchdoctor - COST:4 [ATK:3/HP:4] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, summon a random basic_Totem.
		// --------------------------------------------------------
		[Fact]
		public void WickedWitchdoctor_KAR_021()
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
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Wicked Witchdoctor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, game.CurrentPlayer.HandZone[4]));
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(Race.TOTEM, game.CurrentPlayer.BoardZone[1].Card.GetRawRace());
		}

		// ---------------------------------------- WEAPON - SHAMAN
		// [KAR_063] Spirit Claws - COST:1 [ATK:1/HP:0] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: [x]Has +2 Attack while you
		//       have <b>Spell Damage</b>.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 3
		// --------------------------------------------------------
		// RefTag:
		// - SPELLPOWER = 1
		// --------------------------------------------------------
		[Fact]
		public void SpiritClaws_KAR_063()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Spirit Claws"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(1, game.CurrentPlayer.Hero.AttackDamage);
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Dalaran Mage"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			Assert.Equal(3, game.CurrentPlayer.Hero.AttackDamage);
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lightning Bolt"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, (ICharacter) minion));
			Assert.Equal(1, game.CurrentPlayer.Hero.AttackDamage);

			game.CurrentPlayer.Hero.RemoveWeapon();

			Assert.Equal(0, game.CurrentPlayer.Hero.AttackDamage);

			game.ProcessCard("Dalaran Mage");
			Assert.Equal(1, game.CurrentPlayer.CurrentSpellPower);
			Assert.Equal(0, game.CurrentPlayer.Hero.AttackDamage);
		}
	}


	public class WarlockKaraTest
	{
		// ---------------------------------------- SPELL - WARLOCK
		// [KAR_025] Kara Kazham! - COST:5 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: Summon a 1/1 Candle, 2/2 Broom, and 3/3 Teapot.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// --------------------------------------------------------
		[Fact]
		public void KaraKazham_KAR_025()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Kara Kazham!"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);
		}

		// --------------------------------------- MINION - WARLOCK
		// [KAR_089] Malchezaar's Imp - COST:1 [ATK:1/HP:3] 
		// - Race: demon, Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever you discard a card, draw a card.
		// --------------------------------------------------------
		[Fact]
		public void MalchezaarsImp_KAR_089()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Malchezaar's Imp"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Soulfire"));
			Assert.Equal(5, game.CurrentPlayer.HandZone.Count);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, game.CurrentOpponent.Hero));
			Assert.Equal(4, game.CurrentPlayer.HandZone.Count);
		}

		// --------------------------------------- MINION - WARLOCK
		// [KAR_205] Silverware Golem - COST:3 [ATK:3/HP:3] 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: If you discard this minion, summon it.
		// --------------------------------------------------------
		// GameTag:
		// - InvisibleDeathrattle = 1
		// --------------------------------------------------------
		[Fact]
		public void SilverwareGolem_KAR_205()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.WARLOCK,
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = false,
				Shuffle = false,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Silverware Golem"));
			IPlayable soulFire = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Soulfire"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, soulFire, game.CurrentOpponent.Hero));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal("KAR_205", game.CurrentPlayer.BoardZone[0].Card.Id);
		}
	}


	public class WarriorKaraTest
	{
		// ---------------------------------------- SPELL - WARRIOR
		// [KAR_026] Protect the King! - COST:3 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: For each enemy minion, summon a 1/1 Pawn with <b>Taunt</b>.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_NUM_MINION_SLOTS = 1
		// - REQ_MINIMUM_ENEMY_MINIONS = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact]
		public void ProtectTheKing_KAR_026()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Protect the King!"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
		}

		// ---------------------------------------- SPELL - WARRIOR
		// [KAR_091] Ironforge Portal - COST:5 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: Gain 4 Armor.
		//       Summon a random
		//       4-Cost minion.
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void IronforgePortal_KAR_091()
		{
			// TODO IronforgePortal_KAR_091 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ironforge Portal"));
		}

		// --------------------------------------- WEAPON - WARRIOR
		// [KAR_028] Fool's Bane - COST:5 [ATK:3/HP:0] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: Unlimited attacks each turn. Can't attack heroes.
		// --------------------------------------------------------
		// GameTag:
		// - DURABILITY = 4
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void FoolsBane_KAR_028()
		{
			// TODO FoolsBane_KAR_028 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Fool's Bane"));
		}
	}


	public class NeutralKaraTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [KAR_011] Pompous Thespian - COST:2 [ATK:3/HP:2] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		// --------------------------------------------------------
		// GameTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PompousThespian_KAR_011()
		{
			// TODO PompousThespian_KAR_011 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Pompous Thespian"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_029] Runic Egg - COST:1 [ATK:0/HP:2] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Draw a card.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RunicEgg_KAR_029()
		{
			// TODO RunicEgg_KAR_029 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Runic Egg"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_030a] Pantry Spider - COST:3 [ATK:1/HP:3] 
		// - Race: beast, Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a
		//       1/3 Spider.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void PantrySpider_KAR_030a()
		{
			// TODO PantrySpider_KAR_030a test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Pantry Spider"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_033] Book Wyrm - COST:6 [ATK:3/HP:6] 
		// - Race: dragon, Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding a Dragon, destroy an enemy minion with 3 or less Attack.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_MAX_ATTACK = 3
		// - REQ_NONSELF_TARGET = 0
		// - REQ_ENEMY_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND = 0
		// - REQ_MINION_TARGET = 0
		// --------------------------------------------------------
		[Fact]
		public void BookWyrm_KAR_033()
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

			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Book Wyrm"));
			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard, (ICharacter)minion));

			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, testCard, (ICharacter) minion));
			Assert.True(minion.ToBeDestroyed);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_036] Arcane Anomaly - COST:1 [ATK:2/HP:1] 
		// - Fac: neutral, Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: Whenever you cast a spell, give this minion
		//       +1 Health.
		// --------------------------------------------------------
		[Fact]
		public void ArcaneAnomaly_KAR_036()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Anomaly"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, game.CurrentPlayer.HandZone[4]));
			Assert.Equal(2, ((Minion)testCard).Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_037] Avian Watcher - COST:5 [ATK:3/HP:6] 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you control a <b>Secret</b>, gain +1/+1
		//       and <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		[Fact]
		public void AvianWatcher_KAR_037()
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
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Avian Watcher"));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Avian Watcher"));
			IPlayable secret = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Mirror Entity"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard1));
			Assert.Equal(3, ((Minion)testCard1).AttackDamage);
			Assert.Equal(6, ((Minion)testCard1).Health);
			Assert.False(((Minion)testCard1).HasTaunt);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, secret));
			game.Player1.UsedMana = 0;
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard2));
			Assert.Equal(4, ((Minion)testCard2).AttackDamage);
			Assert.Equal(7, ((Minion)testCard2).Health);
			Assert.True(((Minion)testCard2).HasTaunt);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_041] Moat Lurker - COST:6 [ATK:3/HP:3] 
		// - Set: kara, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Destroy a minion. <b>Deathrattle:</b> Resummon it.
		// --------------------------------------------------------
		// GameTag:
		// - DEATHRATTLE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_TARGET_IF_AVAILABLE = 0
		// --------------------------------------------------------
		[Fact]
		public void MoatLurker_KAR_041()
		{
			// TODO MoatLurker_KAR_041 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Moat Lurker"));
			IPlayable minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Moat Lurker"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard, (ICharacter) minion));
			Assert.Equal(1, game.CurrentPlayer.BoardZone.Count);
			game.CurrentPlayer.UsedMana = 0;
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard2, (ICharacter) testCard));
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_044] Moroes - COST:3 [ATK:1/HP:1] 
		// - Set: kara, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Stealth</b>
		//       At the end of your turn, summon a 1/1 Steward.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Moroes_KAR_044()
		{
			// TODO Moroes_KAR_044 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Moroes"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_061] The Curator - COST:7 [ATK:4/HP:6] 
		// - Race: mechanical, Set: kara, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Taunt</b>
		//       <b>Battlecry:</b> Draw a Beast, Dragon, and Murloc from your deck.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - TAUNT = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void TheCurator_KAR_061()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Magma Rager"),
					Cards.FromName("Magma Rager"),
					Cards.FromName("Novice Engineer"),
					Cards.FromName("Novice Engineer"),
					Cards.FromName("Reckless Rocketeer"),
					Cards.FromName("Stampeding Kodo"),
					Cards.FromName("Twilight Drake"),
					Cards.FromName("Murloc Knight")
				},
				Player2HeroClass = CardClass.MAGE,
				FillDecks = false,
				Shuffle = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("The Curator"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.Equal(Race.BEAST, game.CurrentPlayer.HandZone[4].Card.GetRawRace());
			Assert.Equal(Race.DRAGON, game.CurrentPlayer.HandZone[5].Card.GetRawRace());
			Assert.Equal(Race.MURLOC, game.CurrentPlayer.HandZone[6].Card.GetRawRace());
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_062] Netherspite Historian - COST:2 [ATK:1/HP:3] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> If you're holding a Dragon, <b>Discover</b>
		//       a Dragon.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TREASURE = 1
		// --------------------------------------------------------
		[Fact]
		public void NetherspiteHistorian_KAR_062()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Azure Drake")
				},
				Player2HeroClass = CardClass.MAGE,
				FillDecks = false
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Netherspite Historian"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.True(game.IdEntityDic[game.CurrentPlayer.Choice.Choices[0]].Card.IsRace(Race.DRAGON));
			Assert.True(game.IdEntityDic[game.CurrentPlayer.Choice.Choices[1]].Card.IsRace(Race.DRAGON));
			Assert.True(game.IdEntityDic[game.CurrentPlayer.Choice.Choices[2]].Card.IsRace(Race.DRAGON));
			Assert.Equal(1, game.CurrentPlayer.HandZone.Count);
			game.Process(ChooseTask.Pick(game.CurrentPlayer, game.CurrentPlayer.Choice.Choices[0]));
			Assert.Equal(2, game.CurrentPlayer.HandZone.Count);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_095] Zoobot - COST:3 [ATK:3/HP:3] 
		// - Race: mechanical, Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a random friendly Beast, Dragon, and Murloc +1/+1.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Zoobot_KAR_095()
		{
			// TODO Zoobot_KAR_095 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Zoobot"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_096] Prince Malchezaar - COST:5 [ATK:5/HP:6] 
		// - Race: demon, Set: kara, Rarity: legendary
		// --------------------------------------------------------
		// Text: [x]When the game starts,
		//       add 5 extra <b>Legendary</b>
		//       minions to your deck.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// --------------------------------------------------------
		[Fact]
		public void PrinceMalchezaar_KAR_096()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Prince Malchezaar")
				},
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true,
				Shuffle = false,
				SkipMulligan = false
			});

			game.StartGame();

			// Malchezaar triggers AFTER MULLIGAN!
			//Assert.Equal(1, game.Triggers.Count); 
			// draws are done in this state fr mulligan
			Assert.Equal(27, game.CurrentPlayer.DeckZone.Count);

			// Mulligan Player 1
			game.Process(ChooseTask.Mulligan(game.CurrentPlayer, new List<int>()));
			// Mulligan Player 2
			game.Process(ChooseTask.Mulligan(game.CurrentOpponent, new List<int>()));
			game.NextStep = Step.MAIN_BEGIN; // End Mulligan phase.

			// Post MULLIGAN.
			Assert.Equal(31, game.CurrentPlayer.DeckZone.Count); // 30-4(hand)+5 legendaries

			// Malchezaar abides several rules; see https://hearthstone.gamepedia.com/Prince_Malchezaar#Notes
			// Multiple Malchezaars WILL add 5 legendaries per Malchezaar to the deck, but the 
			// none duplicate rule remains!
			// If there are more Malchezaars than 'unique legendaries'/5, Malchezaar will NOT add 
			// cards to the deck.
			var allPlayables = new List<IPlayable>();
			allPlayables.AddRange(game.CurrentPlayer.DeckZone);
			allPlayables.AddRange(game.CurrentPlayer.HandZone);
			var legendaries = allPlayables.Where(p => p.Card.Rarity == Rarity.LEGENDARY && p.Id > 68).ToList();
			// Added legendaries MUST belong to the CardClass of the deck or the MultiClassGroup.
			Assert.DoesNotContain(legendaries, p => p.Card.Class != CardClass.NEUTRAL &&
				p.Card.Class != CardClass.MAGE && p.Card.MultiClassGroup != (int)MultiClassGroup.KABAL);
			// No duplicate legendaries are allowed!
			Assert.Equal(legendaries.Count, legendaries.Distinct().Count());
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_097] Medivh, the Guardian - COST:8 [ATK:7/HP:7] 
		// - Set: kara, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Equip Atiesh, Greatstaff of the Guardian.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void MedivhTheGuardian_KAR_097()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Medivh, the Guardian"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.True(game.CurrentPlayer.Hero.Weapon != null);
			Assert.Equal(3, game.CurrentPlayer.Hero.Weapon.Durability);
			//Assert.Equal(1, game.CurrentPlayer.GraveyardZone.Triggers.Count);
			game.CurrentPlayer.UsedMana = 0;
			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell, game.CurrentOpponent.Hero));
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(4, game.CurrentPlayer.BoardZone.Last().Cost);
			Assert.Equal(2, game.CurrentPlayer.Hero.Weapon.Durability);
			IPlayable apprentice = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sorcerer's Apprentice"));
			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, apprentice));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, game.CurrentOpponent.Hero));
			Assert.Equal(4, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Last().Cost);
			Assert.Equal(1, game.CurrentPlayer.Hero.Weapon.Durability);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_114] Barnes - COST:4 [ATK:3/HP:4] 
		// - Set: kara, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 1/1 copy of a random minion in your deck.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void Barnes_KAR_114()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Barnes"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));
			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(1, game.CurrentPlayer.BoardZone[1].AttackDamage);
			Assert.Equal(1, game.CurrentPlayer.BoardZone[1].Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_702] Menagerie Magician - COST:5 [ATK:4/HP:4] 
		// - Fac: neutral, Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give a random friendly Beast, Dragon, and Murloc +2/+2.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void MenagerieMagician_KAR_702()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Menagerie Magician"));
			var beast = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			var dragon = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Faerie Dragon"));
			var murloc = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Murloc Raider"));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, beast));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, dragon));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, murloc));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, testCard));

			Assert.Equal(3, beast.AttackDamage);
			Assert.Equal(5, dragon.AttackDamage);
			Assert.Equal(4, murloc.AttackDamage);
			Assert.Equal(3, beast.Health);
			Assert.Equal(4, dragon.Health);
			Assert.Equal(3, murloc.Health);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_710] Arcanosmith - COST:4 [ATK:3/HP:2] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon a 0/5 minion with <b>Taunt</b>.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		// RefTag:
		// - TAUNT = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Arcanosmith_KAR_710()
		{
			// TODO Arcanosmith_KAR_710 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Arcanosmith"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_711] Arcane Giant - COST:12 [ATK:8/HP:8] 
		// - Set: kara, Rarity: epic
		// --------------------------------------------------------
		// Text: [x]Costs (1) less for each spell
		//       you've cast this game.
		// --------------------------------------------------------
		[Fact]
		public void ArcaneGiant_KAR_711()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Giant"));
			Assert.Equal(12, testCard.Cost);
			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, game.CurrentOpponent.Hero));
			Assert.Equal(11, testCard.Cost);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [KAR_712] Violet Illusionist - COST:3 [ATK:4/HP:3] 
		// - Set: kara, Rarity: common
		// --------------------------------------------------------
		// Text: During your turn, your hero is <b>Immune</b>.
		// --------------------------------------------------------
		// GameTag:
		// - AURA = 1
		// --------------------------------------------------------
		// RefTag:
		// - IMMUNE = 1
		// --------------------------------------------------------
		[Fact]
		public void VioletIllusionist_KAR_712()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Violet Illusionist"));
			Assert.False(game.CurrentPlayer.Hero.IsImmune);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, testCard));
			Assert.True(game.CurrentPlayer.Hero.IsImmune);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.False(game.CurrentOpponent.Hero.IsImmune);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.True(game.CurrentPlayer.Hero.IsImmune);
		}
	}
}
