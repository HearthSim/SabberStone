using SabberStoneCore.Conditions;
using SabberStoneCore.Config;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.PlayerTasks;
using System.Collections.Generic;
using Xunit;
using Generic = SabberStoneCore.Actions.Generic;

namespace SabberStoneCoreTest.Basic
{

	public class BasicTest
	{
		[Fact]
		public void UtilTest()
		{
			var enumarable = new List<string>() { "A", "B", "C" };
			var dict = new Dictionary<string, int>();
			for (var i = 0; i < 1000; i++)
			{
				var str = Util.RandomElement(enumarable);
				if (dict.ContainsKey(str))
				{
					dict[str] = dict[str] + 1;
				}
				else
				{
					dict[str] = 1;
				}
			}
			Assert.Equal(true, dict["A"] > 300);
			Assert.Equal(true, dict["B"] > 300);
			Assert.Equal(true, dict["C"] > 300);
		}

		[Fact]
		public void GameTest()
		{
			var game = new Game(new GameConfig());
			game.StartGame();

			if (game.CurrentPlayer == game.Player1)
			{
				game.MainEnd();
				Assert.Equal(game.CurrentPlayer, game.Player2); // "Current Player not working in the end turn function.");
			}
			else if (game.CurrentPlayer == game.Player2)
			{
				game.MainEnd();
				Assert.Equal(game.CurrentPlayer, game.Player1); // "Current Player not working in the end turn function.");
			}
		}

		[Fact]
		public void ControllerTest()
		{
			var game = new Game(new GameConfig());
			game.StartGame();

			Assert.Equal(CardClass.HUNTER, game.Player1.HeroClass); // "Hero class isn't matching.");
			Assert.Equal(10, game.Player1.MaxHandSize); // "Max size isn't set correctly.");
			Assert.Equal(10, game.Player1.MaxResources); // "Max ressources aren't set correctly.");
		}

		[Fact]
		public void ConditionTest()
		{
			var game = new Game(new GameConfig());
			game.StartGame();

			var entity1 = Entity.FromCard(game.Player1, Cards.FromId("EX1_011"));
			var entity2 = Entity.FromCard(game.Player1, Cards.FromId("EX1_012"));
			var entity3 = Entity.FromCard(game.Player1, Cards.FromId("EX1_014"));
			var entity4 = Entity.FromCard(game.Player1, Cards.FromId("EX1_015"));
			var entity5 = Entity.FromCard(game.Player1, Cards.FromId("EX1_277"));

			Assert.True(RelaCondition.IsSelf.Eval((ICharacter)entity1, (ICharacter)entity1), "RelaCondition IsSelf is not correct for same entity.");
			Assert.False(RelaCondition.IsSelf.Eval((ICharacter)entity1, (ICharacter)entity2), "RelaCondition IsSelf is not correct for diffrent entity.");

			game.Player1.Board.Add(entity1);
			game.Player1.Board.Add(entity2);
			game.Player1.Board.Add(entity3);

			Assert.False(RelaCondition.IsSideBySide.Eval((ICharacter)entity1, (ICharacter)entity1), "RelaCondition IsSideBySide for same entity shouldn't be true.");
			Assert.True(RelaCondition.IsSideBySide.Eval((ICharacter)entity1, (ICharacter)entity2), "RelaCondition IsSideBySide for entitys side by side (1,2) shouldn't be false.");
			Assert.True(RelaCondition.IsSideBySide.Eval((ICharacter)entity3, (ICharacter)entity2), "RelaCondition IsSideBySide for entitys side by side (3,2) shouldn't be false.");
			Assert.False(RelaCondition.IsSideBySide.Eval((ICharacter)entity3, (ICharacter)entity1), "RelaCondition IsSideBySide for entitys not side by side shouldn't be true.");

		}

		[Fact]
		public void ZoneSwapTest()
		{
			var game = new Game(new GameConfig());
			game.StartGame();

			var entity1 = Entity.FromCard(game.Player1, Cards.FromId("EX1_011"));
			var entity2 = Entity.FromCard(game.Player1, Cards.FromId("EX1_012"));
			var entity3 = Entity.FromCard(game.Player1, Cards.FromId("EX1_014"));

			game.Player1.Board.Add(entity1);
			game.Player1.Board.Add(entity2);
			game.Player1.Board.Add(entity3);

			var pos1 = entity1.ZonePosition;
			var pos2 = entity2.ZonePosition;

			Assert.Equal(entity1, game.Player1.Board[entity1.ZonePosition]);
			Assert.Equal(entity2, game.Player1.Board[entity2.ZonePosition]);

			game.Player1.Board.Swap(entity1, entity2);

			Assert.Equal(entity1, game.Player1.Board[entity1.ZonePosition]);
			Assert.Equal(entity2, game.Player1.Board[entity2.ZonePosition]);

			Assert.True(pos1 == entity2.ZonePosition && pos2 == entity1.ZonePosition, "Swap wasn't correctly executed.");
		}

		[Fact]
		public void DeckFillTest()
		{
			var game = new Game(new GameConfig());
			game.StartGame();

            Assert.Equal(0, game.Player1.Deck.Count);
			game.Player1.Deck.Fill();

			Assert.Equal(game.Player1.Deck.Count, game.Player1.Deck.StartingCards); // "Filling didn't matched max card size for deck.");
		}

		[Fact]
		public void DeckShuffleTest()
		{
			var game = new Game(new GameConfig());
			game.StartGame();

            Assert.Equal(0, game.Player1.Deck.Count);

			game.Player1.Deck.Fill();

			var deckString1 = game.Player1.Deck.FullPrint();

			game.Player1.Deck.Shuffle(0);

			var deckString2 = game.Player1.Deck.FullPrint();

			game.Player1.Deck.Shuffle(10);

			var deckString3 = game.Player1.Deck.FullPrint();

			Assert.Equal(deckString1, deckString2);
			Assert.NotEqual(deckString2, deckString3); // "Shuffling didn't changed the positions in deck.");
		}

		[Fact]
		public void SummonFailTest()
		{
			var game = new Game(new GameConfig { StartPlayer = 1, Player1HeroClass = CardClass.PALADIN, Player2HeroClass = CardClass.MAGE, FillDecks = true });
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

			Assert.Equal(6, game.CurrentPlayer.Board.Count);

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(7, game.CurrentPlayer.Board.Count);

			game.Process(HeroPowerTask.Any(game.CurrentPlayer));

			Assert.Equal(7, game.CurrentPlayer.Board.Count);
		}

		[Fact]
		public void CompleteGameNoPlayTest()
		{
			var game = new Game(new GameConfig { StartPlayer = 1, FillDecks = true });

			game.StartGame();

			Assert.Equal(26, game.CurrentPlayer.Deck.Count);
			Assert.Equal(4, game.CurrentPlayer.Hand.Count);

			Assert.Equal(26, game.CurrentPlayer.Opponent.Deck.Count);
			Assert.Equal(5, game.CurrentPlayer.Opponent.Hand.Count);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(25, game.CurrentPlayer.Deck.Count);
			Assert.Equal(6, game.CurrentPlayer.Hand.Count);

			Assert.Equal(26, game.CurrentPlayer.Opponent.Deck.Count);
			Assert.Equal(4, game.CurrentPlayer.Opponent.Hand.Count);

			for (int i = 0; i < 8; i++)
			{
				game.Process(EndTurnTask.Any(game.CurrentPlayer));
			}

			Assert.Equal(21, game.CurrentPlayer.Deck.Count);
			Assert.Equal(10, game.CurrentPlayer.Hand.Count);

			Assert.Equal(22, game.CurrentPlayer.Opponent.Deck.Count);
			Assert.Equal(8, game.CurrentPlayer.Opponent.Hand.Count);

			for (int i = 0; i < 4; i++)
			{
				game.Process(EndTurnTask.Any(game.CurrentPlayer));
			}

			Assert.Equal(19, game.CurrentPlayer.Deck.Count);
			Assert.Equal(10, game.CurrentPlayer.Hand.Count);

			Assert.Equal(20, game.CurrentPlayer.Opponent.Deck.Count);
			Assert.Equal(10, game.CurrentPlayer.Opponent.Hand.Count);

			for (int i = 0; i < 20; i++)
			{
				game.Process(EndTurnTask.Any(game.CurrentPlayer));
			}

			Assert.Equal(9, game.CurrentPlayer.Deck.Count);
			Assert.Equal(10, game.CurrentPlayer.Hand.Count);

			Assert.Equal(10, game.CurrentPlayer.Opponent.Deck.Count);
			Assert.Equal(10, game.CurrentPlayer.Opponent.Hand.Count);

			for (int i = 0; i < 18; i++)
			{
				game.Process(EndTurnTask.Any(game.CurrentPlayer));
			}

			Assert.Equal(0, game.CurrentPlayer.Deck.Count);
			Assert.Equal(10, game.CurrentPlayer.Hand.Count);

			Assert.Equal(1, game.CurrentPlayer.Opponent.Deck.Count);
			Assert.Equal(10, game.CurrentPlayer.Opponent.Hand.Count);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(0, game.CurrentPlayer.Deck.Count);
			Assert.Equal(10, game.CurrentPlayer.Hand.Count);

			Assert.Equal(0, game.CurrentPlayer.Opponent.Deck.Count);
			Assert.Equal(10, game.CurrentPlayer.Opponent.Hand.Count);

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			Assert.Equal(0, game.CurrentPlayer.Deck.Count);
			Assert.Equal(10, game.CurrentPlayer.Hand.Count);

			Assert.Equal(0, game.CurrentPlayer.Opponent.Deck.Count);
			Assert.Equal(10, game.CurrentPlayer.Opponent.Hand.Count);

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
		public void TauntTest()
		{
			var game = new Game(new GameConfig { StartPlayer = 1, Player1HeroClass = CardClass.ROGUE, Player2HeroClass = CardClass.WARLOCK, FillDecks = true });
			game.StartGame();

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(HeroPowerTask.Any(game.CurrentPlayer));
            
            Assert.True(game.CurrentPlayer.Hero.IsValidAttackTarget(game.CurrentOpponent.Hero));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			var taunt = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Voidwalker"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, taunt));

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

            Assert.True(((ICharacter)taunt).HasTaunt);
            Assert.False(game.CurrentPlayer.Hero.IsValidAttackTarget(game.CurrentOpponent.Hero));
            Assert.True(game.CurrentPlayer.Hero.IsValidAttackTarget(taunt as ICharacter));
		}

		[Fact]
		public void FatigueTest()
		{
			var game = new Game(new GameConfig { StartPlayer = 1, FillDecks = true });
			game.StartGame();

			while (game.State != State.COMPLETE)
			{
				game.Process(EndTurnTask.Any(game.CurrentPlayer));
			}

            Assert.Equal(PlayState.WON, game.Player1.PlayState); // "Fatigue test didn't worked as it should for player 1.");
			Assert.Equal(PlayState.LOST, game.Player2.PlayState); // "Fatigue test didn't worked as it should for player 2.");
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
					FillDecks = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();

			var minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
			var spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Inner Rage"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, minion1));
			Assert.Equal(5, ((Minion)minion1).AttackDamage);
			Assert.Equal(1, ((Minion)minion1).Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			var minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Aldor Peacekeeper"));
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
					FillDecks = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();

			var minion = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Bloodfen Raptor"));
			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion));
			var spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Power Word: Shield"));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, minion));
			Assert.Equal(4, ((Minion)minion).Health);
			game.Process(EndTurnTask.Any(game.CurrentPlayer));
			var spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Hunter's Mark"));
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
					FillDecks = true
				});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;

			game.StartGame();

			var minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stormwind Champion"));
			var minion2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stormwind Champion"));
			var minion3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Shattered Sun Cleric"));

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));

			game.CurrentPlayer.UsedMana = 0;

			game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));

			game.CurrentPlayer.UsedMana = 0;

			game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion3, minion2));

			game.CurrentPlayer.UsedMana = 0;

			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			var spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Flamestrike"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell1));

			game.CurrentPlayer.UsedMana = 0;

			var spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Explosion"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell2));


			var spell3 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Explosion"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell3));

			Assert.Equal(2, ((ICharacter)minion2).Health);

			var spell4 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Arcane Explosion"));
			game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell4));

			Assert.Equal(1, ((ICharacter)minion2).Health);
			Assert.Equal(Zone.PLAY, ((ICharacter)minion2).Zone.Type);
		}

        [Fact]
        public void BasicHealthAuraTest2()
        {
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;

            var minion1 = Generic.DrawCard(game.Player1,Cards.FromName("Murloc Raider"));
            var minion2 = Generic.DrawCard(game.Player1,Cards.FromName("Ironbeak Owl"));
            var spell1 = Generic.DrawCard(game.Player1,Cards.FromName("Power Word: Shield"));

            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, minion1));

            Assert.Equal(3, ((ICharacter)minion1).Health);

            game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion2, minion1));

            Assert.Equal(1, ((ICharacter)minion1).Health);

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var minion3 = Generic.DrawCard(game.Player1,Cards.FromName("Bloodfen Raptor"));
            var minion4 = Generic.DrawCard(game.Player1,Cards.FromName("Ironbeak Owl"));
            var spell2 = Generic.DrawCard(game.Player1,Cards.FromName("Power Word: Shield"));

            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, minion3));

            Assert.Equal(4, ((ICharacter)minion3).Health);

            ((Minion) minion3).Damage = 3;

            game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion4, minion3));

            Assert.Equal(1, ((ICharacter)minion3).Health);

        }

        [Fact]
        public void BasicHealthAuraTest3()
        {
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.PRIEST,
                Player2HeroClass = CardClass.WARLOCK,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            var minion1 = Generic.DrawCard(game.Player1,Cards.FromName("Murloc Raider"));
            var minion2 = Generic.DrawCard(game.Player1,Cards.FromName("Murloc Warleader"));
            var minion3 = Generic.DrawCard(game.Player1,Cards.FromName("Stormwind Champion"));
            var minion4 = Generic.DrawCard(game.Player1,Cards.FromName("Ironbeak Owl"));
            var spell1 = Generic.DrawCard(game.Player1,Cards.FromName("Power Word: Shield"));

            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
            game.Player1.UsedMana = 0;
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
            game.Player1.UsedMana = 0;
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion3));
            game.Player1.UsedMana = 0;
            game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, minion1));

            Assert.Equal(5, ((ICharacter)minion1).Health);
            Assert.Equal(4, ((ICharacter)minion2).Health);
            Assert.Equal(6, ((ICharacter)minion3).Health);

            game.Process(PlayCardTask.MinionTarget(game.CurrentPlayer, minion4, minion2));

            Assert.Equal(4, ((ICharacter)minion1).Health);
            Assert.Equal(4, ((ICharacter)minion2).Health);
            Assert.Equal(6, ((ICharacter)minion3).Health);
            Assert.Equal(2, ((ICharacter)minion4).Health);

            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            var spell2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Hellfire"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, spell2));

            Assert.Equal(1, ((ICharacter)minion1).Health);
            Assert.Equal(1, ((ICharacter)minion2).Health);
            Assert.Equal(3, ((ICharacter)minion3).Health);
            Assert.True(((ICharacter)minion4).IsDead);

        }

        [Fact]
        public void SecretActivation()
        {
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.HUNTER,
                Player2HeroClass = CardClass.ROGUE,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;
            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Knife Juggler"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion1));
            var testCard = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Snake Trap"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stonetusk Boar"));
            game.Process(PlayCardTask.Minion(game.CurrentPlayer, minion2));
            game.Process(MinionAttackTask.Any(game.CurrentPlayer, minion2, minion1));
            Assert.Equal(game.CurrentOpponent.Hero.Health > 27 ? 2 : 1, ((Minion) minion1).Health);
        }

        [Fact]
        public void SecretOnlyOnce()
        {
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                Player1HeroClass = CardClass.HUNTER,
                Player2HeroClass = CardClass.ROGUE,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;
            var testCard1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Snake Trap"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard1));
            var testCard2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Snake Trap"));
            game.Process(PlayCardTask.Spell(game.CurrentPlayer, testCard2));
            Assert.Equal(1, game.CurrentPlayer.Secrets.Count);
        }

        [Fact]
        public void Aura_LoopBug()
        {
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;

            var minion1 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stormwind Champion"));
            var minion2 = Generic.DrawCard(game.CurrentPlayer,Cards.FromName("Stormwind Champion"));
            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

            Assert.Equal(6, minion1[GameTag.HEALTH]);

            game.Process(EndTurnTask.Any(game.CurrentPlayer));
            game.Process(EndTurnTask.Any(game.CurrentPlayer));

            game.Process(PlayCardTask.Any(game.CurrentPlayer, minion2));

            Assert.Equal(7, minion1[GameTag.HEALTH]);
        }

		[Fact]
		public void QuestCardDrawFirst()
		{
			var game = new Game(
				new GameConfig()
				{
					Player1HeroClass = CardClass.WARRIOR,
					DeckPlayer1 = new List<Card>
					{
						Cards.FromName("Fire Plume's Heart")
					},
					Player2HeroClass = CardClass.HUNTER,
					DeckPlayer2 = new List<Card>
					{
						Cards.FromName("The Marsh Queen")
					},
					FillDecks = true,
					Shuffle = true,
					SkipMulligan = false
				});
			game.StartGame();

			Assert.True(game.Player1.Choice.Choices.Exists(p =>
			{
				IPlayable t = game.IdEntityDic[p];
				return ((Spell)t).IsQuest;
			}), "we have no quest in mulligan! player 1");
			Assert.True(game.Player2.Choice.Choices.Exists(p =>
			{
				IPlayable t = game.IdEntityDic[p];
				return ((Spell)t).IsQuest;
			}), "we have no quest in mulligan! player 2");
		}

		[Fact]
        public void OrderOfPlayDeathRattleSylvanasTest()
        {
            var game = new Game(new GameConfig
            {
                StartPlayer = 1,
                FillDecks = true
            });
            game.StartGame();
            game.Player1.BaseMana = 10;

            Assert.Equal(1, 0);
        }

        [Fact]
		public void LoathebMillhouseOrderOfPlayTest()
        {
            // https://youtu.be/Fmfa9NFThsM?t=50

            var game =
                new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.PALADIN,
                    Player2HeroClass = CardClass.MAGE,
                    FillDecks = true
                });
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            game.StartGame();

            Assert.True(false); // "To be implemented.");
		}

        [Fact]
        public void IllidanKnifeJugglerTwilightDrakeResolveTest()
        {
            // https://youtu.be/Ln0BisR_SfY?t=71

            var game =
                new Game(new GameConfig
                {
                    StartPlayer = 1,
                    Player1HeroClass = CardClass.PALADIN,
                    Player2HeroClass = CardClass.MAGE,
                    FillDecks = true
                });
            game.Player1.BaseMana = 10;
            game.Player2.BaseMana = 10;

            game.StartGame();

            Assert.True(false); // "To be implemented.");
		}
	}
}
