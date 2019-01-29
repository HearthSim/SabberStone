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
using Xunit;
using SabberStoneCore.Conditions;
using SabberStoneCore.Config;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.PlayerTasks;
using Generic = SabberStoneCore.Actions.Generic;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Model.Zones;

namespace SabberStoneCoreTest.Basic
{

	public class BasicTest
	{
		[Fact]
		public void UtilTest()
		{
			var enumarable = new List<string>() { "A", "B", "C" };
			var dict = new Dictionary<string, int>();
			for (int i = 0; i < 1000; i++)
			{
				string str = Util.RandomElement(enumarable);
				if (dict.ContainsKey(str))
				{
					dict[str] = dict[str] + 1;
				}
				else
				{
					dict[str] = 1;
				}
			}
			Assert.True(dict["A"] > 300);
			Assert.True(dict["B"] > 300);
			Assert.True(dict["C"] > 300);
		}

		[Fact]
		public void GameTest()
		{
			var game = new Game(new GameConfig());
			game.StartGame();

			if (game.CurrentPlayer == game.Player1)
			{
				game.MainEnd();
				Assert.Equal(game.CurrentPlayer, game.Player2); // Current Player not working in the end turn function
			}
			else if (game.CurrentPlayer == game.Player2)
			{
				game.MainEnd();
				Assert.Equal(game.CurrentPlayer, game.Player1); // Current Player not working in the end turn function
			}
		}

		[Fact]
		public void ControllerTest()
		{
			var game = new Game(new GameConfig());
			game.StartGame();

			Assert.Equal(CardClass.HUNTER, game.Player1.HeroClass); // Hero class isn't matching
			Assert.Equal(10, game.Player1.MaxHandSize); // Max size isn't set correctly
			Assert.Equal(10, game.Player1.MaxResources); // Max ressources aren't set correctly
		}

		[Fact]
		public void ConditionTest()
		{
			var game = new Game(new GameConfig());
			game.StartGame();

			IPlayable entity1 = Entity.FromCard(game.Player1, Cards.FromId("EX1_011"));
			IPlayable entity2 = Entity.FromCard(game.Player1, Cards.FromId("EX1_012"));
			IPlayable entity3 = Entity.FromCard(game.Player1, Cards.FromId("EX1_014"));
			IPlayable entity4 = Entity.FromCard(game.Player1, Cards.FromId("EX1_015"));
			IPlayable entity5 = Entity.FromCard(game.Player1, Cards.FromId("EX1_277"));

			Assert.True(RelaCondition.IsSelf.Eval((ICharacter)entity1, (ICharacter)entity1)); // RelaCondition IsSelf is not correct for same entity
			Assert.False(RelaCondition.IsSelf.Eval((ICharacter)entity1, (ICharacter)entity2)); // RelaCondition IsSelf is not correct for diffrent entity

			game.Player1.BoardZone.Add((Minion)entity1);
			game.Player1.BoardZone.Add((Minion)entity2);
			game.Player1.BoardZone.Add((Minion)entity3);

			Assert.False(RelaCondition.IsSideBySide.Eval((ICharacter)entity1, (ICharacter)entity1)); // RelaCondition IsSideBySide for same entity shouldn't be true
			Assert.True(RelaCondition.IsSideBySide.Eval((ICharacter)entity1, (ICharacter)entity2)); // RelaCondition IsSideBySide for entitys side by side (1,2) shouldn't be false
			Assert.True(RelaCondition.IsSideBySide.Eval((ICharacter)entity3, (ICharacter)entity2)); // RelaCondition IsSideBySide for entitys side by side (3,2) shouldn't be false
			Assert.False(RelaCondition.IsSideBySide.Eval((ICharacter)entity3, (ICharacter)entity1)); // RelaCondition IsSideBySide for entitys not side by side shouldn't be true

		}

		[Fact]
		public void ZoneSwapTest()
		{
			var game = new Game(new GameConfig());
			game.StartGame();

			IPlayable entity1 = Entity.FromCard(game.Player1, Cards.FromId("EX1_011"));
			IPlayable entity2 = Entity.FromCard(game.Player1, Cards.FromId("EX1_012"));
			IPlayable entity3 = Entity.FromCard(game.Player1, Cards.FromId("EX1_014"));

			game.Player1.BoardZone.Add((Minion)entity1);
			game.Player1.BoardZone.Add((Minion)entity2);
			game.Player1.BoardZone.Add((Minion)entity3);

			int pos1 = entity1.ZonePosition;
			int pos2 = entity2.ZonePosition;

			Assert.Equal(entity1, game.Player1.BoardZone[entity1.ZonePosition]);
			Assert.Equal(entity2, game.Player1.BoardZone[entity2.ZonePosition]);

			game.Player1.BoardZone.Swap((Minion)entity1, (Minion)entity2);

			Assert.Equal(entity1, game.Player1.BoardZone[entity1.ZonePosition]);
			Assert.Equal(entity2, game.Player1.BoardZone[entity2.ZonePosition]);

			Assert.True(pos1 == entity2.ZonePosition && pos2 == entity1.ZonePosition); // Swap wasn't correctly executed
		}

		[Fact]
		public void DeckFillTest()
		{
			var game = new Game(new GameConfig());
			game.StartGame();

			Assert.Equal(0, game.Player1.DeckZone.Count);

			game.Player1.DeckZone.Fill();

			Assert.Equal(game.Player1.DeckZone.Count, DeckZone.StartingCards); // Filling didn't matched max card size for deck
		}

		[Fact]
		public void DeckShuffleTest()
		{
			var game = new Game(new GameConfig());
			game.StartGame();

			Assert.Equal(0, game.Player1.DeckZone.Count);

			game.Player1.DeckZone.Fill();

			string deckString1 = game.Player1.DeckZone.FullPrint();

			//game.Player1.DeckZone.Shuffle(0);

			//string deckString2 = game.Player1.DeckZone.FullPrint();

			game.Player1.DeckZone.Shuffle(/*10*/);

			string deckString3 = game.Player1.DeckZone.FullPrint();

			//Assert.Equal(deckString1, deckString2);
			Assert.NotEqual(deckString1, deckString3); // Shuffling didn't changed the positions in deck
		}

		[Fact]
		public void SummonFailTest()
		{
			var game = new Game(new GameConfig { StartPlayer = 1, Player1HeroClass = CardClass.PALADIN, Player2HeroClass = CardClass.MAGE, FillDecks = true, FillDecksPredictably = true });
			game.StartGame();

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(6, game.CurrentPlayer.BoardZone.Count);

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(7, game.CurrentPlayer.BoardZone.Count);

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));

			Assert.Equal(7, game.CurrentPlayer.BoardZone.Count);
		}

		[Fact]
		public void CompleteGameNoPlayTest()
		{
			var game = new Game(new GameConfig { StartPlayer = 1, FillDecks = true, FillDecksPredictably = true });

			game.StartGame();

			Assert.Equal(26, game.CurrentPlayer.DeckZone.Count);
			Assert.Equal(4, game.CurrentPlayer.HandZone.Count);

			Assert.Equal(26, game.CurrentPlayer.Opponent.DeckZone.Count);
			Assert.Equal(5, game.CurrentPlayer.Opponent.HandZone.Count);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(25, game.CurrentPlayer.DeckZone.Count);
			Assert.Equal(6, game.CurrentPlayer.HandZone.Count);

			Assert.Equal(26, game.CurrentPlayer.Opponent.DeckZone.Count);
			Assert.Equal(4, game.CurrentPlayer.Opponent.HandZone.Count);

			for (int i = 0; i < 8; i++)
			{
				game.Process(EndTurnTask.Any(game.CurrentPlayer));
			}

			Assert.Equal(21, game.CurrentPlayer.DeckZone.Count);
			Assert.Equal(10, game.CurrentPlayer.HandZone.Count);

			Assert.Equal(22, game.CurrentPlayer.Opponent.DeckZone.Count);
			Assert.Equal(8, game.CurrentPlayer.Opponent.HandZone.Count);

			for (int i = 0; i < 4; i++)
			{
				game.Process(EndTurnTask.Any(game.CurrentPlayer));
			}

			Assert.Equal(19, game.CurrentPlayer.DeckZone.Count);
			Assert.Equal(10, game.CurrentPlayer.HandZone.Count);

			Assert.Equal(20, game.CurrentPlayer.Opponent.DeckZone.Count);
			Assert.Equal(10, game.CurrentPlayer.Opponent.HandZone.Count);

			for (int i = 0; i < 20; i++)
			{
				game.Process(EndTurnTask.Any(game.CurrentPlayer));
			}

			Assert.Equal(9, game.CurrentPlayer.DeckZone.Count);
			Assert.Equal(10, game.CurrentPlayer.HandZone.Count);

			Assert.Equal(10, game.CurrentPlayer.Opponent.DeckZone.Count);
			Assert.Equal(10, game.CurrentPlayer.Opponent.HandZone.Count);

			for (int i = 0; i < 18; i++)
			{
				game.Process(EndTurnTask.Any(game.CurrentPlayer));
			}

			Assert.Equal(0, game.CurrentPlayer.DeckZone.Count);
			Assert.Equal(10, game.CurrentPlayer.HandZone.Count);

			Assert.Equal(1, game.CurrentPlayer.Opponent.DeckZone.Count);
			Assert.Equal(10, game.CurrentPlayer.Opponent.HandZone.Count);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(0, game.CurrentPlayer.DeckZone.Count);
			Assert.Equal(10, game.CurrentPlayer.HandZone.Count);

			Assert.Equal(0, game.CurrentPlayer.Opponent.DeckZone.Count);
			Assert.Equal(10, game.CurrentPlayer.Opponent.HandZone.Count);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(0, game.CurrentPlayer.DeckZone.Count);
			Assert.Equal(10, game.CurrentPlayer.HandZone.Count);

			Assert.Equal(0, game.CurrentPlayer.Opponent.DeckZone.Count);
			Assert.Equal(10, game.CurrentPlayer.Opponent.HandZone.Count);

			Assert.Equal(29, game.CurrentPlayer.Hero.Health);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(29, game.CurrentPlayer.Hero.Health);
			Assert.Equal(29, game.CurrentPlayer.Opponent.Hero.Health);

			for (int i = 0; i < 12; i++)
			{
				game.Process(EndTurnTask.Any(game.CurrentPlayer));
			}

			Assert.Equal(2, game.CurrentPlayer.Hero.Health);
			Assert.Equal(2, game.CurrentPlayer.Opponent.Hero.Health);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(-6, game.CurrentPlayer.Hero.Health);
			Assert.Equal(2, game.CurrentPlayer.Opponent.Hero.Health);

			Assert.Equal(State.COMPLETE, game.State);
			Assert.Equal(PlayState.LOST, game.CurrentPlayer.PlayState);
			Assert.Equal(PlayState.WON, game.CurrentPlayer.Opponent.PlayState);
		}

		[Fact]
		public void DrawGameTest()
		{
			var game = new Game(new GameConfig
			{
				FillDecks = true
			});
			game.StartGame();

			game.Player1.Hero.Health = 1;
			game.Player2.Hero.Health = 1;
			game.ProcessCard("Hellfire", asZeroCost: true);

			Assert.Equal(PlayState.LOST, game.Player1.PlayState);
			Assert.Equal(PlayState.LOST, game.Player2.PlayState);
		}

		[Fact]
		public void TauntTest()
		{
			var game = new Game(new GameConfig { StartPlayer = 1, Player1HeroClass = CardClass.ROGUE, Player2HeroClass = CardClass.WARLOCK, FillDecks = true, FillDecksPredictably = true });
			game.StartGame();

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));

			Assert.True(game.CurrentPlayer.Hero.IsValidAttackTarget(game.CurrentOpponent.Hero));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable taunt = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Voidwalker"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, taunt));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.True(((ICharacter)taunt).HasTaunt);
			Assert.False(game.CurrentPlayer.Hero.IsValidAttackTarget(game.CurrentOpponent.Hero));
			Assert.True(game.CurrentPlayer.Hero.IsValidAttackTarget(taunt as ICharacter));
		}

		[Fact]
		public void FatigueTest()
		{
			var game = new Game(new GameConfig { StartPlayer = 1, FillDecks = true, FillDecksPredictably = true });
			game.StartGame();

			while (game.State != State.COMPLETE)
			{
				game.Process(EndTurnTask.Any(game.CurrentPlayer));
			}

			Assert.Equal(PlayState.WON, game.Player1.PlayState); // Fatigue test didn't worked as it should for player 1
			Assert.Equal(PlayState.LOST, game.Player2.PlayState); // Fatigue test didn't worked as it should for player 2
		}

		[Fact]
		public void BasicAttackBuffTest1()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.PRIEST,
					Player2HeroClass = CardClass.HUNTER,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();

			var minion1 = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Inner Rage"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, minion1));
			Assert.Equal(5, ((Minion)minion1).AttackDamage);
			Assert.Equal(1, ((Minion)minion1).Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Aldor Peacekeeper"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, minion2, minion1));
			Assert.Equal(1, ((Minion)minion1).AttackDamage);
			Assert.Equal(1, ((Minion)minion1).Health);
		}

		[Fact]
		public void BasicHealthBuffTest1()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.PRIEST,
					Player2HeroClass = CardClass.HUNTER,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();

			var minion = (ICharacter) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Power Word: Shield"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, minion));
			Assert.Equal(4, ((Minion)minion).Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hunter's Mark"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, minion));
			Assert.Equal(1, ((Minion)minion).Health);
		}

		[Fact]
		public void BasicHealthAuraTest1()
		{
			var game =
				new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = CardClass.PALADIN,
					Player2HeroClass = CardClass.MAGE,
					FillDecks = true,
					FillDecksPredictably = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.StartGame();

			var minion1 = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stormwind Champion"));
			var minion2 = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stormwind Champion"));
			var minion3 = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shattered Sun Cleric"));

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));	// 6/6
			game.CurrentPlayer.UsedMana = 0;

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));	// 7/7
			game.CurrentPlayer.UsedMana = 0;

			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion3, minion2));
			game.CurrentPlayer.UsedMana = 0;
			Assert.Equal(7, minion1.AttackDamage);
			Assert.Equal(7, minion1.Health);
			Assert.Equal(8, minion2.AttackDamage);
			Assert.Equal(8, minion2.Health);
			Assert.Equal(5, minion3.AttackDamage);
			Assert.Equal(4, minion3.Health);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));	// (7/7), (8/8), (5/4)

			IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flamestrike"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell1));	// (7/3), (8/4)
			game.CurrentPlayer.UsedMana = 0;

			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Explosion"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell2));


			IPlayable spell3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Explosion"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell3));

			Assert.Equal(2, ((ICharacter)minion2).Health);	// (7/1), (8/2)

			IPlayable spell4 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Explosion"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell4));

			Assert.Equal(1, ((ICharacter)minion2).Health);	// (7/1)
			Assert.Equal(Zone.PLAY, ((ICharacter)minion2).Zone.Type);
		}

		[Fact]
		public void BasicHealthAuraTest2()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;

			var minion1 = (ICharacter) Generic.DrawCard(game.Player1, Cards.FromName("Murloc Raider"));
			IPlayable minion2 = Generic.DrawCard(game.Player1, Cards.FromName("Ironbeak Owl"));
			IPlayable spell1 = Generic.DrawCard(game.Player1, Cards.FromName("Power Word: Shield"));

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, minion1));

			Assert.Equal(3, minion1.Health);

			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion2, minion1));

			Assert.Equal(1, minion1.Health);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			var minion3 = (ICharacter) Generic.DrawCard(game.Player1, Cards.FromName("Bloodfen Raptor"));
			IPlayable minion4 = Generic.DrawCard(game.Player1, Cards.FromName("Ironbeak Owl"));
			IPlayable spell2 = Generic.DrawCard(game.Player1, Cards.FromName("Power Word: Shield"));

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, minion3));

			Assert.Equal(4, minion3.Health);

			((Minion)minion3).Damage = 3;

			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion4, minion3));

			Assert.Equal(1, minion3.Health);

		}

		[Fact]
		public void BasicHealthAuraTest3()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player2HeroClass = CardClass.WARLOCK,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			var minion1 = (ICharacter) Generic.DrawCard(game.Player1, Cards.FromName("Murloc Raider"));
			var minion2 = (ICharacter) Generic.DrawCard(game.Player1, Cards.FromName("Murloc Warleader"));
			IPlayable minion3 = Generic.DrawCard(game.Player1, Cards.FromName("Stormwind Champion"));
			IPlayable minion4 = Generic.DrawCard(game.Player1, Cards.FromName("Ironbeak Owl"));
			IPlayable spell1 = Generic.DrawCard(game.Player1, Cards.FromName("Power Word: Shield"));

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			game.Player1.UsedMana = 0;
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Player1.UsedMana = 0;
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
			game.Player1.UsedMana = 0;
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, minion1));

			Assert.Equal(4, minion1.Health);
			Assert.Equal(4, minion2.Health);
			Assert.Equal(6, ((ICharacter)minion3).Health);

			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion4, minion2));

			Assert.Equal(4, minion1.Health);
			Assert.Equal(4, minion2.Health);
			Assert.Equal(6, ((ICharacter)minion3).Health);
			Assert.Equal(2, ((ICharacter)minion4).Health);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hellfire"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell2));

			Assert.Equal(1, minion1.Health);
			Assert.Equal(1, minion2.Health);
			Assert.Equal(3, ((ICharacter)minion3).Health);
			Assert.True(((ICharacter)minion4).IsDead);

		}

		[Fact]
		public void AdaptiveEffectTest()
		{
			var game = new Game(new GameConfig());
			game.StartGame();
			Minion target = game.ProcessCard<Minion>("Lightspawn", null, true);
			Assert.Equal(5, target.AttackDamage);
			game.ProcessCard("Power Word: Shield", target, true);
			Assert.Equal(7, target.AttackDamage);
			game.ProcessCard("Abusive Sergeant", target, true);
			Assert.Equal(7, target.AttackDamage);
			game.ProcessCard("Raid Leader", null, true);
			Assert.Equal(7, target.AttackDamage);
			game.ProcessCard("Silence", target);
			Assert.Equal(1, target.AttackDamage);
		}

		[Fact]
		public void SecretActivation()
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

			var minion1 = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Knife Juggler"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			IPlayable testCard = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Snake Trap")); // Spawns 3
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			IPlayable minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion2, minion1));

			Assert.Equal(4, game.CurrentOpponent.BoardZone.Count);
			if (minion1.Damage == 0)
			{
				// Minion was destroyed by Knife Juggler, so it's moved to graveyard with tags reset.
				Assert.Equal(1, game.CurrentPlayer.GraveyardZone.Count);
				Assert.Equal(game.CurrentPlayer.Hero.BaseHealth - 2, game.CurrentPlayer.Hero.Health);
			}
			else
			{
				// Minion was NOT destroyed by Knife Juggler, so it continued it's attack.
				Assert.Equal(1, game.CurrentPlayer.GraveyardZone.Count);
				Assert.Equal(minion1.BaseHealth - 1, minion1.Health);
				Assert.Equal(game.CurrentPlayer.Hero.BaseHealth - 3, game.CurrentPlayer.Hero.Health);
			}
		}

		[Fact]
		public void SecretOnlyOnce()
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
			IPlayable testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Snake Trap"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard1));
			IPlayable testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Snake Trap"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard2));
			Assert.Equal(1, game.CurrentPlayer.SecretZone.Count);
		}

		[Fact]
		public void SecretOrderOfPlay()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Vaporize"),
					Cards.FromName("Ice Barrier"),
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Stonetusk Boar")
				},
				Player2HeroClass = CardClass.HUNTER,
				Player2Deck = new List<Card>()
				{
					Cards.FromName("Stonetusk Boar"),
					Cards.FromName("Freezing Trap"),
					Cards.FromName("Explosive Trap"),
					Cards.FromName("Freezing Trap"),
					Cards.FromName("Explosive Trap"),
					Cards.FromName("Misdirection"),
					Cards.FromName("Explosive Trap"),
					Cards.FromName("Misdirection")
				},
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, "Vaporize"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, "Ice Barrier"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Stonetusk Boar"));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.BoardZone[0], game.CurrentOpponent.Hero));
			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(8, game.CurrentOpponent.Hero.Armor);
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, "Freezing Trap"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, "Explosive Trap"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Stonetusk Boar"));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.BoardZone[0], game.CurrentOpponent.Hero));
			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(0, game.CurrentOpponent.SecretZone.Count);
			Assert.Equal(6, game.CurrentPlayer.Hero.Armor);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(PlayCardTask.Spell(game.CurrentPlayer, "Explosive Trap"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, "Freezing Trap"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Stonetusk Boar"));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.BoardZone[0], game.CurrentOpponent.Hero));
			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(1, game.CurrentOpponent.SecretZone.Count);
			Assert.Equal(4, game.CurrentPlayer.Hero.Armor);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(PlayCardTask.Spell(game.CurrentPlayer, "Misdirection"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Stonetusk Boar"));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.BoardZone[0], game.CurrentOpponent.Hero));
			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(1, game.CurrentOpponent.SecretZone.Count);
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, "Stonetusk Boar"));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.BoardZone[0], game.CurrentOpponent.Hero));
			Assert.Equal(3, game.CurrentPlayer.Hero.Armor);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, "Explosive Trap"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, "Misdirection"));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(MinionAttackTask.Any(game.CurrentPlayer, game.CurrentPlayer.BoardZone[0], game.CurrentOpponent.Hero));
			Assert.Equal(0, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(1, game.CurrentOpponent.SecretZone.Count);
			Assert.Equal(1, game.CurrentPlayer.Hero.Armor);
		}

		[Fact]
		public void SecretOrderOfPlay2()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				FillDecks = true,
				History = false,
				Logging = false

			});
			game.StartGame();

			game.ProcessCard("Explosive Runes", null, true);
			game.ProcessCard("Potion of Polymorph", null, true);
			Assert.Equal(2, game.CurrentPlayer.SecretZone.Count);
			game.EndTurn();

			Minion target = game.ProcessCard<Minion>("Doomsayer", null, true);
			Assert.False(target.IsDead);
			Assert.Equal(Zone.SETASIDE, target.Zone.Type);
			Assert.Equal(1, target.Health);
			Assert.Single(game.CurrentPlayer.BoardZone);
			Assert.Equal("Sheep", game.CurrentPlayer.BoardZone[0].Card.Name);
			game.EndTurn();

			game.ProcessCard("Potion of Polymorph", null, true);
			game.ProcessCard("Explosive Runes", null, true);
			game.EndTurn();

			Minion target2 = game.ProcessCard<Minion>("Doomsayer");
			Assert.False(target2.IsDead);
			Assert.Equal(Zone.SETASIDE, target2.Zone.Type);
			Assert.Equal(7, target2.Health);
			Assert.Single(game.CurrentPlayer.BoardZone);
			Assert.Equal(5, game.CurrentPlayer.Hero.Damage);
		}

		[Fact]
		public void Aura_LoopBug()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;

			var minion1 = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stormwind Champion"));
			var minion2 = (Minion) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stormwind Champion"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

			Assert.Equal(6, minion1.BaseHealth);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));

			Assert.Equal(7, minion1.BaseHealth);
		}

		[Fact]
		public void QuestCardDrawFirst()
		{
			var game = new Game(
				new GameConfig()
				{
					Player1HeroClass = CardClass.WARRIOR,
					Player1Deck = new List<Card>
					{
						Cards.FromName("Fire Plume's Heart")
					},
					Player2HeroClass = CardClass.HUNTER,
					Player2Deck = new List<Card>
					{
						Cards.FromName("The Marsh Queen")
					},
					FillDecks = true,
					FillDecksPredictably = true,
					Shuffle = true,
					SkipMulligan = false
				});
			game.StartGame();

			Assert.False(game.Player1.Choice.Choices.TrueForAll(p =>
			{
				IPlayable t = game.IdEntityDic[p];
				return !(t is Spell) || !((Spell)t).IsQuest;
			})); // we have a no quest in mulligan! player 1
			Assert.False(game.Player2.Choice.Choices.TrueForAll(p =>
			{
				IPlayable t = game.IdEntityDic[p];
				return !(t is Spell) || !((Spell)t).IsQuest;
			})); // we have a no quest in mulligan! player 2
		}

		[Fact]
		public void SilenceTest()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Shuffle = false,
				FillDecks = false,
				History = false,
				Logging = false,
			});

			game.StartGame();

			Minion testTarget = game.ProcessCard<Minion>("Zilliax", asZeroCost: true);
			game.ProcessCard("Fungalmancer", asZeroCost: true);

			Assert.Equal(testTarget.Card.ATK + 2, testTarget.AttackDamage);
			Assert.Equal(testTarget.Card.Health + 2, testTarget.Health);
			Assert.True(testTarget.HasDivineShield);
			Assert.True(testTarget.HasTaunt);
			Assert.True(testTarget.HasLifeSteal);
			Assert.True(testTarget.AttackableByRush);

			game.ProcessCard("Spellbreaker", testTarget, true);

			Assert.Equal(testTarget.Card.ATK, testTarget.AttackDamage);
			Assert.Equal(testTarget.Card.Health, testTarget.Health);
			Assert.False(testTarget.HasDivineShield);
			Assert.False(testTarget.HasTaunt);
			Assert.False(testTarget.HasLifeSteal);
			Assert.False(testTarget.AttackableByRush);
		}

		[Fact]
		public void SilenceRebuffTest()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>()
				{
					Cards.FromName("Silence"),
					Cards.FromName("Power Word: Shield"),
					Cards.FromName("Murloc Tinyfin"),
					Cards.FromName("Power Word: Shield")
				},
				Player2HeroClass = CardClass.PRIEST,
				Shuffle = false,
				FillDecks = true,
				FillDecksPredictably = true
			});
			game.StartGame();
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Murloc Tinyfin"));
			Assert.Equal(1, game.CurrentPlayer.BoardZone[0].Health);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, "Power Word: Shield", game.CurrentPlayer.BoardZone[0]));
			Assert.Equal(3, game.CurrentPlayer.BoardZone[0].Health);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, "Silence", game.CurrentPlayer.BoardZone[0]));
			Assert.Equal(1, game.CurrentPlayer.BoardZone[0].Health);
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, "Power Word: Shield", game.CurrentPlayer.BoardZone[0]));
			Assert.Equal(3, game.CurrentPlayer.BoardZone[0].Health);
		}

		[Fact]
		public void AfterCastTriggerTest()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PRIEST,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Violet Teacher"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Mindgames"),
				},
				Player2HeroClass = CardClass.PALADIN,
				Player2Deck = new List<Card>
				{
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wisp"),
					Cards.FromName("Wild Pyromancer")
				},
				Shuffle = false,
				FillDecks = false,
			});
			game.StartGame();
			game.Player1.BaseMana = 10;

			Assert.Equal(1, game.CurrentOpponent.DeckZone.Count);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Violet Teacher"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wisp"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Wisp"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Mindgames"));

			Assert.Equal(5, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(game.CurrentPlayer.BoardZone[0].Card.Health, game.CurrentPlayer.BoardZone[0].Health);
		}

		[Fact]
		public void LifestealAuchenaiTest()
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

			game.ProcessCard("Auchenai Soulpriest", asZeroCost: true);
			Minion lifestealAttacker = game.ProcessCard<Minion>("Acolyte of Agony", asZeroCost: true);
			lifestealAttacker.HasCharge = true;

			game.Process(MinionAttackTask.Any(game.CurrentPlayer, lifestealAttacker, game.CurrentOpponent.Hero));

			Assert.Equal(3, game.CurrentPlayer.Hero.Damage);
		}

		[Fact(Skip = "ignore")]
		public void WaitChoices()
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

			game.ProcessCard("Medivh, the Guardian", null, true);
			game.ProcessCard("Free From Amber", null, true);

			Assert.NotNull(game.CurrentPlayer.Choice);
			Assert.Empty(game.CurrentPlayer.BoardZone);
			Assert.Equal(1, game.CurrentPlayer.NumOptionsPlayedThisTurn);

			game.ChooseNthChoice(1);

			Assert.Equal(2, game.CurrentPlayer.BoardZone.Count);
			Assert.Equal(2, game.CurrentPlayer.NumOptionsPlayedThisTurn);
		}

		[Fact]
		public void FindBug()
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

			//game.ProcessCard("Grimscale Oracle");
			//game.ProcessCard("Psychic Scream", asZeroCost: true);

			game.ProcessCard("Rebuke", asZeroCost: true);
		}

		[Fact]
		public void CantBeTargetedBy()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.MAGE,
			});
			game.StartGame();

			Minion target = game.ProcessCard<Minion>("Faerie Dragon", asZeroCost: true);

			Assert.False(game.CurrentPlayer.Hero.HeroPower.IsValidPlayTarget(target));

			var spell = (Spell) Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Fireball"));

			Assert.False(spell.IsValidPlayTarget(target));

			Minion target2 = game.ProcessCard<Minion>("Stonetusk Boar", asZeroCost: true);

			game.ProcessCard(Generic.DrawCard(game.CurrentPlayer, Cards.FromId("ICC_314t7")), asZeroCost: true);

			Assert.True(target2.CantBeTargetedBySpells);
			Assert.True(target2.CantBeTargetedByHeroPowers);
			Assert.False(game.CurrentPlayer.Hero.HeroPower.IsValidPlayTarget(target2));
			Assert.False(spell.IsValidPlayTarget(target2));
		}
	}
}
