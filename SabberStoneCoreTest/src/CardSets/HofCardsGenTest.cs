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
using SabberStoneCore.Actions;
using SabberStoneCore.Config;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.PlayerTasks;
using SabberStoneCore.Model.Entities;

namespace SabberStoneCoreTest.CardSets
{

	public class MageHofTest
	{
		// ------------------------------------------- SPELL - MAGE
		// [CS2_031] Ice Lance - COST:1 
		// - Fac: neutral, Set: hof, Rarity: common
		// --------------------------------------------------------
		// Text: <b>Freeze</b> a character. If it was already <b>Frozen</b>, deal $4 damage instead. *spelldmg
		// --------------------------------------------------------
		// GameTag:
		// - FREEZE = 1
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void IceLance_CS2_031()
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
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ice Lance"));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ice Lance"));
			Assert.False(game.CurrentOpponent.Hero.IsFrozen);
			Assert.Equal(30, game.CurrentOpponent.Hero.Health);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard1, game.CurrentOpponent.Hero));
			Assert.True(game.CurrentOpponent.Hero.IsFrozen);
			Assert.Equal(30, game.CurrentOpponent.Hero.Health);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard2, game.CurrentOpponent.Hero));
			Assert.Equal(26, game.CurrentOpponent.Hero.Health);
		}

		// ------------------------------------------- SPELL - MAGE
		// [EX1_295] Ice Block - COST:3 
		// - Fac: neutral, Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Secret:</b> When your hero takes fatal damage, prevent it and become <b>Immune</b> this turn.
		// --------------------------------------------------------
		// GameTag:
		// - SECRET_OR_QUEST = 1
		// --------------------------------------------------------
		// RefTag:
		// - IMMUNE = 1
		// --------------------------------------------------------
		[Fact]
		public void IceBlock_EX1_295()
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
			game.Player1.Hero.Health = 2;
			game.Player2.BaseMana = 10;

			IPlayable spell = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Ice Block"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell));
			Assert.Equal(1, game.CurrentPlayer.SecretZone.Count);
			//Assert.Equal(1, game.CurrentOpponent.Board.Triggers.Count);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			// play 2 charge minions
			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			IPlayable minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bluegill Warrior"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			Assert.Equal(3, game.CurrentPlayer.BoardZone.Count);

			// minion 1 attacks hero that should NOT proc the secret
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, (Minion)minion1, game.CurrentOpponent.Hero));
			Assert.Equal(1, game.CurrentOpponent.Hero.Health);
			Assert.Equal(1, game.CurrentOpponent.SecretZone.Count);

			// adding one armor for next attack
			game.Player1.Hero.Armor = 1;
			Assert.Equal(1, game.CurrentOpponent.Hero.Armor);

			// minion 2 attacks hero that should proc the secret
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, (Minion)minion2, game.CurrentOpponent.Hero));
			Assert.Equal(0, game.CurrentOpponent.Hero.Armor);
			Assert.Equal(1, game.CurrentOpponent.Hero.Health);
			Assert.Equal(1, game.CurrentOpponent.SecretZone.Count);

			// adding one armor for next attack
			game.Player1.Hero.Armor = 1;
			Assert.Equal(1, game.CurrentOpponent.Hero.Armor);

			// minion 3 attacks hero that should proc the secret
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, (Minion)minion3, game.CurrentOpponent.Hero));
			Assert.Equal(1, game.CurrentOpponent.Hero.Armor);
			Assert.Equal(0, game.CurrentOpponent.SecretZone.Count);
			Assert.Equal(1, game.CurrentOpponent.Hero.Health);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			// minion 2 now kills opponent
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, (Minion)minion3, game.CurrentOpponent.Hero));
			Assert.True(game.CurrentOpponent.Hero.IsDead);
		}
	}


	public class RogueHofTest
	{
		// ------------------------------------------ SPELL - ROGUE
		// [EX1_128] Conceal - COST:1 
		// - Fac: neutral, Set: hof, Rarity: common
		// --------------------------------------------------------
		// Text: Give your minions <b>Stealth</b> until your next_turn.
		// --------------------------------------------------------
		// RefTag:
		// - STEALTH = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void Conceal_EX1_128()
		{
			// TODO Conceal_EX1_128 test
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
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Conceal"));
		}

	}


	public class WarlockHofTest
	{
		// ---------------------------------------- SPELL - WARLOCK
		// [EX1_316] Power Overwhelming - COST:1 
		// - Fac: neutral, Set: hof, Rarity: common
		// --------------------------------------------------------
		// Text: Give a friendly minion +4/+4 until end of turn. Then, it dies. Horribly.
		// --------------------------------------------------------
		// PlayReq:
		// - REQ_MINION_TARGET = 0
		// - REQ_FRIENDLY_TARGET = 0
		// - REQ_TARGET_TO_PLAY = 0
		// --------------------------------------------------------
		[Fact]
		public void PowerOverwhelming_EX1_316()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Power Overwhelming"));
			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, testCard, minion));
			Assert.Equal(5, ((Minion)minion).AttackDamage);
			Assert.Equal(5, ((Minion)minion).Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			Assert.True(minion.ToBeDestroyed);
		}
	}


	public class NeutralHofTest
	{
		// --------------------------------------- MINION - NEUTRAL
		// [EX1_016] Sylvanas Windrunner - COST:6 [ATK:5/HP:5] 
		// - Set: hof, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Deathrattle:</b> Take
		//       control of a random
		//       enemy minion.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - DEATHRATTLE = 1
		// --------------------------------------------------------
		[Fact]
		public void SylvanasWindrunner_EX1_016()
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

			IPlayable minion11 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion11));

			IPlayable minion12 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Leper Gnome"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion12));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			var minion2 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Sylvanas Windrunner"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));

			int myBoardCount = game.CurrentPlayer.BoardZone.Count;
			int opBoardCount = game.CurrentOpponent.BoardZone.Count;

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, minion2));

			Assert.Equal(myBoardCount, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(opBoardCount - 1, game.CurrentOpponent.BoardZone.Count);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_050] Coldlight Oracle - COST:3 [ATK:2/HP:2] 
		// - Race: murloc, Fac: neutral, Set: expert1, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Each player draws 2 cards.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact]
		public void ColdlightOracle_EX1_050()
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

			int handCount = game.CurrentPlayer.HandZone.Count;
			int handOpCount = game.CurrentOpponent.HandZone.Count;

			IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Coldlight Oracle"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

			Assert.Equal(handCount + 2, game.CurrentPlayer.HandZone.Count);
			Assert.Equal(handOpCount + 2, game.CurrentOpponent.HandZone.Count);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_062] Old Murk-Eye - COST:4 [ATK:2/HP:4] 
		// - Race: murloc, Fac: neutral, Set: hof, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Charge</b>. Has +1 Attack for each other Murloc on the battlefield.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - CHARGE = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void OldMurkEye_EX1_062()
		{
			// TODO OldMurkEye_EX1_062 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Old Murk-Eye"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_112] Gelbin Mekkatorque - COST:6 [ATK:6/HP:6] 
		// - Fac: alliance, Set: hof, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Summon an AWESOME invention.
		// --------------------------------------------------------
		// Entourage: Mekka1, Mekka2, Mekka3, Mekka4
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void GelbinMekkatorque_EX1_112()
		{
			// TODO GelbinMekkatorque_EX1_112 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Gelbin Mekkatorque"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_284] Azure Drake - COST:5 [ATK:4/HP:4] 
		// - Race: dragon, Fac: neutral, Set: hof, Rarity: rare
		// --------------------------------------------------------
		// Text: <b>Spell Damage +1</b>. <b>Battlecry:</b> Draw a card.
		// --------------------------------------------------------
		// GameTag:
		// - SPELLPOWER = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void AzureDrake_EX1_284()
		{
			// TODO AzureDrake_EX1_284 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = game.CurrentPlayer.Draw(game.CurrentPlayer,Cards.FromName("Azure Drake"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_298] Ragnaros the Firelord - COST:8 [ATK:8/HP:8] 
		// - Race: elemental, Fac: neutral, Set: hof, Rarity: legendary
		// --------------------------------------------------------
		// Text: Can't attack. At the end of your turn, deal 8 damage to a random enemy.
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - CANT_ATTACK = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void RagnarosTheFirelord_EX1_298()
		{
			// TODO RagnarosTheFirelord_EX1_298 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Ragnaros the Firelord"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [EX1_620] Molten Giant - COST:20 [ATK:8/HP:8] 
		// - Set: expert1, Rarity: epic
		// --------------------------------------------------------
		// Text: Costs (1) less for each damage your hero has taken.
		// --------------------------------------------------------
		[Fact]
		public void MoltenGiant_EX1_620()
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
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Molten Giant"));
			Assert.Equal(30, game.CurrentPlayer.Hero.Health);
			Assert.Equal(20, testCard.Cost);
			game.Process(HeroPowerTask.Any(game.CurrentPlayer, game.CurrentPlayer.Hero));
			Assert.Equal(29, game.CurrentPlayer.Hero.Health);
			Assert.Equal(19, testCard.Cost);

			Game clone = game.Clone();
			Assert.Equal(19, clone.CurrentPlayer.HandZone.Last().Cost);
		}

		// --------------------------------------- MINION - NEUTRAL
		// [NEW1_016] Captain's Parrot - COST:2 [ATK:1/HP:1] 
		// - Race: beast, Set: hof, Rarity: epic
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Draw a Pirate from your deck.
		// --------------------------------------------------------
		// GameTag:
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void CaptainsParrot_NEW1_016()
		{
			// TODO CaptainsParrot_NEW1_016 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Captain's Parrot"));
		}

		// --------------------------------------- MINION - NEUTRAL
		// [PRO_001] Elite Tauren Chieftain - COST:5 [ATK:5/HP:5] 
		// - Set: hof, Rarity: legendary
		// --------------------------------------------------------
		// Text: <b>Battlecry:</b> Give both players the power to ROCK! (with a Power Chord card)
		// --------------------------------------------------------
		// Entourage: PRO_001a, PRO_001b, PRO_001c
		// --------------------------------------------------------
		// GameTag:
		// - ELITE = 1
		// - BATTLECRY = 1
		// --------------------------------------------------------
		[Fact(Skip = "ignore")]
		public void EliteTaurenChieftain_PRO_001()
		{
			// TODO EliteTaurenChieftain_PRO_001 test
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player2HeroClass = CardClass.MAGE,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			//var testCard = game.CurrentPlayer.Draw(Cards.FromName("Elite Tauren Chieftain"));
		}

	}

}
