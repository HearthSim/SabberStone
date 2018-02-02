using System.Collections.Generic;
using SabberStoneCore.Actions;
using SabberStoneCore.Config;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks.PlayerTasks;
using Xunit;

namespace SabberStoneCoreTest.Basic
{
	public class TheoryStressTest
	{
		// TODO TheoryStressTest Patashu - Heute um 14:00 Uhr
		// order of play, auras and on-death triggers are what really stresses your implementation
		// of sequences and phases and steps there's a couple of order of play based tests in the
		// brimstone tests class, added by me. they currently fail, see if you can make them pass :wink:
		// besides those, test things like battlecries that summon minions vs sword of justice,
		// violet teacher vs wild pyromancer, etc

		[Fact]
		public void PhaseTest()
		{

		}

		[Fact]
		public static void EnchantAuraTest()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Preparation"),
					Cards.FromName("Preparation"),
					Cards.FromName("SI:7 Agent"),
					Cards.FromName("Sorcerer's Apprentice"),
					Cards.FromName("Sorcerer's Apprentice"),
					Cards.FromName("Backstab")
				},
				FillDecks = false,
				Shuffle = false
			});
			game.Player1.BaseMana = 10;
			game.StartGame();

			Generic.Draw(game.CurrentPlayer);
			Generic.Draw(game.CurrentPlayer);

			IPlayable eviscerate1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eviscerate"));
			IPlayable eviscerate2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Eviscerate"));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sorcerer's Apprentice"));
			Assert.Equal(1, eviscerate1.Cost);
			Assert.Equal(1, eviscerate2.Cost);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Preparation"));
			Assert.Equal(0, eviscerate1.Cost);
			Assert.Equal(0, eviscerate2.Cost);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, eviscerate1, game.CurrentPlayer.BoardZone[0]));
			Assert.Equal(2, eviscerate2.Cost);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Sorcerer's Apprentice"));
			Assert.Equal(1, eviscerate2.Cost);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Preparation"));
			Assert.Equal(0, eviscerate2.Cost);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "SI:7 Agent", game.CurrentPlayer.BoardZone[0]));
			Assert.Equal(0, eviscerate2.Cost);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Backstab", game.CurrentPlayer.BoardZone[0]));
			Assert.Equal(2, eviscerate2.Cost);

		}

		[Fact]
		public static void AuraTimingTest()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.PALADIN,
				Player2HeroClass = CardClass.HUNTER,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Stormwind Champion")
				},
				Player2Deck = new List<Card>
				{
					Cards.FromName("Fiery Bat")
				},
				FillDecks = false,
				Shuffle = false
			});
			game.Player1.BaseMana = 10;
			game.StartGame();

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Stormwind Champion"));
			game.CurrentPlayer.BoardZone[0].Damage = 4;
			game.Process(HeroPowerTask.Any(game.CurrentPlayer));
			game.Process(EndTurnTask.Any(game.CurrentPlayer));

			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Fiery Bat"));
			game.CurrentPlayer.BoardZone[0].IsExhausted = false;

			while (true)
			{
				Game clone = game.Clone();

				clone.Process(MinionAttackTask.Any(clone.CurrentPlayer, clone.CurrentPlayer.BoardZone[0],
					clone.CurrentOpponent.BoardZone[0]));

				if (clone.CurrentOpponent.Hero.Damage == 7)
					continue;

				Assert.Equal(1, clone.CurrentOpponent.BoardZone.Count);
				Assert.Equal(1, clone.CurrentOpponent.BoardZone[0].AttackDamage);
				Assert.Equal(1, clone.CurrentOpponent.BoardZone[0].Health);
				break;
			}
		}
	}
}
