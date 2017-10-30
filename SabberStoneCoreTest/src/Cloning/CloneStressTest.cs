using System;
using Xunit;
using SabberStoneCore.Config;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks.PlayerTasks;

using Generic = SabberStoneCore.Actions.Generic;
using System.Collections.Generic;

namespace SabberStoneCoreTest.Cloning
{

	public class CloneStressTest
	{
		[Fact]
		public void CloneSameSame()
		{
			var rnd = new Random();
			CardClass[] classes = new[]
			{
				CardClass.DRUID, CardClass.HUNTER, CardClass.MAGE, CardClass.PALADIN, CardClass.PRIEST,
				CardClass.ROGUE, CardClass.SHAMAN, CardClass.WARLOCK, CardClass.WARRIOR
			};
			bool flag = true;
			for (int i = 0; i < 100 && flag; i++)
			{
				var game = new Game(new GameConfig
				{
					StartPlayer = 1,
					Player1HeroClass = classes[rnd.Next(classes.Length)],
					Player2HeroClass = classes[rnd.Next(classes.Length)],
					FillDecks = true
				});
				game.StartGame();

				while (game.State != State.COMPLETE)
				{
					List<SabberStoneCore.Tasks.PlayerTask> options = game.CurrentPlayer.Options();
					SabberStoneCore.Tasks.PlayerTask option = options[rnd.Next(options.Count)];
					game.Process(option);
					if (game.CurrentPlayer.GraveyardZone.Any(p => p.Zone.Type == Zone.HAND) || game.CurrentOpponent.GraveyardZone.Any(p => p.Zone.Type == Zone.HAND))
						;
					Game cloneGame = game.Clone();
					string str1 = game.Hash();
					string str2 = cloneGame.Hash();
					flag &= str1.Equals(str2);
					if (!flag)
					{
						break;
					}
				}
			}
			Assert.True(flag);
		}

		[Fact]
		public void CloneSameState()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.SHAMAN,
				FillDecks = true
			});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();
			Game clone = game.Clone();
			Assert.Equal(game.Hash(), clone.Hash());

			SabberStoneCore.Model.Entities.IPlayable spell1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lightning Bolt"));
			SabberStoneCore.Model.Entities.IPlayable minion1 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Stonetusk Boar"));
			SabberStoneCore.Model.Entities.IPlayable spell2 = Generic.DrawCard(game.CurrentPlayer, Cards.FromName("Lightning Bolt"));

			SabberStoneCore.Model.Entities.IPlayable cSpell1 = Generic.DrawCard(clone.CurrentPlayer, Cards.FromName("Lightning Bolt"));
			SabberStoneCore.Model.Entities.IPlayable cSpell2 = Generic.DrawCard(clone.CurrentPlayer, Cards.FromName("Lightning Bolt"));
			SabberStoneCore.Model.Entities.IPlayable cMinion1 = Generic.DrawCard(clone.CurrentPlayer, Cards.FromName("Stonetusk Boar"));

			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell1, game.CurrentOpponent.Hero));
			game.Process(PlayCardTask.SpellTarget(game.CurrentPlayer, spell2, game.CurrentOpponent.Hero));
			game.Process(PlayCardTask.Any(game.CurrentPlayer, minion1));

			clone.Process(PlayCardTask.Any(clone.CurrentPlayer, cMinion1));
			clone.Process(PlayCardTask.SpellTarget(clone.CurrentPlayer, cSpell2, clone.CurrentOpponent.Hero));
			clone.Process(PlayCardTask.SpellTarget(clone.CurrentPlayer, cSpell1, clone.CurrentOpponent.Hero));

			GameTag[] ignored = new GameTag[] { GameTag.LAST_CARD_PLAYED, GameTag.ENTITY_ID };

			Assert.Equal(game.Hash(ignored), clone.Hash(ignored));
		}

		[Fact]
		public void CloneEndTurnTask()
		{
			var game = new Game(new GameConfig
			{
				StartPlayer = 1,
				Player1HeroClass = CardClass.SHAMAN,
				Player2HeroClass = CardClass.SHAMAN,
				FillDecks = true
			});
			game.Player1.BaseMana = 10;
			game.Player2.BaseMana = 10;
			game.StartGame();
			Game clone = game.Clone();
			Assert.Equal(game.Hash(), clone.Hash());

			clone.Process(EndTurnTask.Any(clone.CurrentPlayer));

			Assert.NotEqual(game.CurrentPlayer.Name, clone.CurrentPlayer.Name);

			clone.Process(EndTurnTask.Any(clone.CurrentPlayer));

			Assert.Equal(game.CurrentPlayer.Name, clone.CurrentPlayer.Name);
		}
	}
}
