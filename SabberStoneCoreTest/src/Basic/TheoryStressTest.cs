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
				Player1HeroClass = CardClass.ROGUE,
				Player1Deck = new List<Card>
				{
					Cards.FromName("Preparation"),
					Cards.FromName("Preparation"),
					Cards.FromName("SI:7 Agent"),
					Cards.FromName("Sorcerer's Apprentice"),
					Cards.FromName("Sorcerer's Apprentice"),
					Cards.FromName("Backstab")
				}
			});
			game.Player1.BaseMana = 10;
			game.StartGame();

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
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "SI:7 Agent"));
			Assert.Equal(0, eviscerate2.Cost);
			game.Process(PlayCardTask.Any(game.CurrentPlayer, "Backstab"));
			Assert.Equal(2, eviscerate2.Cost);

		}
	}
}
