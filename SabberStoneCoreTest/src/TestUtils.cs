using System;
using SabberStoneCore.Actions;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks.PlayerTasks;

namespace SabberStoneCoreTest
{
	/// <summary>
	/// Helper methods for unit tests
	/// </summary>
    internal static class TestUtils
    {
		/// <summary>
		/// Plays a card that matches the provided name. Returns the created <see cref="IPlayable"/> object from the card.
		/// If you play a minion, the minion's position will be the rightmost position on the board.
		/// </summary>
		/// <returns>The created entity object from the card.</returns>
		public static IPlayable ProcessCard(this Game game, string cardName, IPlayable target = null, bool asZeroCost = false, int chooseOne = 0, int zonePosition = -1)
	    {
			if (!(target is ICharacter character))
				throw new ArgumentException($"Can't target non-charater entity {target}");

			IPlayable entity = Generic.DrawCard(game.CurrentPlayer, Cards.FromName(cardName));
		    if (asZeroCost)
			    entity.Cost = 0;
		    game.DeathProcessingAndAuraUpdate();
		    game.Process(PlayCardTask.Any(game.CurrentPlayer, entity, character, zonePosition, chooseOne));
			return entity;
	    }

		/// <summary>
		/// Plays the provided entity as current player of the game.
		/// If you play a minion, the minion's position will be the rightmost position on the board.
		/// </summary>
		public static IPlayable ProcessCard(this Game game, IPlayable entity, IPlayable target = null, bool asZeroCost = false, int chooseOne = 0, int zonePosition = -1)
	    {
			if (!(target is ICharacter character))
				throw new ArgumentException($"Can't target non-charater entity {target}");

			if (asZeroCost)
			    entity.Cost = 0;
			game.DeathProcessingAndAuraUpdate();
		    game.Process(PlayCardTask.Any(game.CurrentPlayer, entity, character, zonePosition, chooseOne));
		    return entity;
		}

		/// <summary>
		/// Plays a card that matches the provided name. Returns the created entity as the given type.
		/// If you play a minion, the minion's position will be the rightmost position on the board.
		/// </summary>
		/// <returns>The created entity object from the card.</returns>
		public static T ProcessCard<T>(this Game game, string cardName, IPlayable target = null, bool asZeroCost = false, int chooseOne = 0, int zonePosition = -1) where T: IPlayable
	    {
			IPlayable entity = Generic.DrawCard(game.CurrentPlayer, Cards.FromName(cardName));
		    if (!(entity is T t))
			    throw new ArgumentException($"The given card is not {typeof(T)}");
			if (!(target is ICharacter character))
				throw new ArgumentException($"Can't target non-charater entity {target}");
		    if (asZeroCost)
			    entity.Cost = 0;
			game.DeathProcessingAndAuraUpdate();
		    game.Process(PlayCardTask.Any(game.CurrentPlayer, t, character, zonePosition, chooseOne));
		    return t;
		}

	    public static T ProcessCard<T>(this Game game, T entity, IPlayable target = null, bool asZeroCost = false, int chooseOne = 0, int zonePosition = -1) where T : IPlayable
	    {
			if (!(target is ICharacter character))
				throw new ArgumentException($"Can't target non-charater entity {target}");

			if (asZeroCost)
			    entity.Cost = 0;
		    game.DeathProcessingAndAuraUpdate();
		    game.Process(PlayCardTask.Any(game.CurrentPlayer, entity, character, zonePosition, chooseOne));
		    return entity;
	    }

		/// <summary>
		/// Ends the current player's turn.
		/// </summary>
		public static void EndTurn(this Game game)
	    {
		    game.Process(EndTurnTask.Any(game.CurrentPlayer));
	    }

		/// <summary>
		/// Plays current player's Hero Power.
		/// </summary>
	    public static void PlayHeroPower(this Game game, IPlayable target = null, int chooseOne = 0, bool asZeroCost = false, bool autoRefresh = false)
	    {
			if (!(target is ICharacter character))
				throw new ArgumentException($"Can't target non-charater entity {target}");

			game.Process(HeroPowerTask.Any(game.CurrentPlayer, character, chooseOne, asZeroCost));
		    if (autoRefresh)
			    game.CurrentPlayer.Hero.HeroPower.IsExhausted = false;
	    }

	    /// <summary>
	    /// Choose Nth item from choices (the leftest one is 1)
	    /// </summary>
	    public static void ChooseNthChoice(this Game game, int n)
	    {
		    if (n > game.CurrentPlayer.Choice.Choices.Count)
			    throw new ArgumentOutOfRangeException();

		    game.Process(ChooseTask.Pick(game.CurrentPlayer, game.CurrentPlayer.Choice.Choices[n - 1]));
	    }

	    public static void Kill(this Minion m)
	    {
		    if (m.Zone.Type != SabberStoneCore.Enums.Zone.PLAY)
			    throw new ArgumentException($"{m} is not in the board.");

			m.ToBeDestroyed = true;
		    m.Game.DeathProcessingAndAuraUpdate();
	    }
    }
}
