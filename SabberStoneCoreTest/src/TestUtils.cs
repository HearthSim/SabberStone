using System;
using System.Collections.Generic;
using System.Text;
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
		/// Play a card that matches the provided name. Returns the created <see cref="IPlayable"/> object from the card.
		/// If you play a minion, the minion's position will be the rightmost position on the board.
		/// </summary>
		/// <returns>The created entity object from the card.</returns>
		public static IPlayable ProcessCard(this Game game, string cardName, IPlayable target = null, bool asZeroCost = false)
	    {
		    IPlayable entity = Generic.DrawCard(game.CurrentPlayer, Cards.FromName(cardName));
		    if (asZeroCost)
			    entity.Cost = 0;
		    game.DeathProcessingAndAuraUpdate();
		    game.Process(PlayCardTask.Any(game.CurrentPlayer, entity, target));
			return entity;
	    }

		/// <summary>
		/// Play the provided entity as current player of the game.
		/// If you play a minion, the minion's position will be the rightmost position on the board.
		/// </summary>
		public static IPlayable ProcessCard(this Game game, IPlayable entity, IPlayable target = null, bool asZeroCost = false)
	    {
		    if (asZeroCost)
			    entity.Cost = 0;
			game.DeathProcessingAndAuraUpdate();
		    game.Process(PlayCardTask.Any(game.CurrentPlayer, entity, target));
		    return entity;
		}

		/// <summary>
		/// Play a card that matches the provided name. Returns the created entity as the given type.
		/// If you play a minion, the minion's position will be the rightmost position on the board.
		/// </summary>
		/// <returns>The created entity object from the card.</returns>
		public static T ProcessCard<T>(this Game game, string cardName, IPlayable target = null, bool asZeroCost = false) where T: IPlayable
	    {
			IPlayable entity = Generic.DrawCard(game.CurrentPlayer, Cards.FromName(cardName));
		    if (!(entity is T t))
			    throw new ArgumentException($"The given card is not {typeof(T)}");
		    if (asZeroCost)
			    entity.Cost = 0;
			game.DeathProcessingAndAuraUpdate();
		    game.Process(PlayCardTask.Any(game.CurrentPlayer, t, target));
		    return t;
		}

		/// <summary>
		/// End the current player's turn.
		/// </summary>
	    public static void EndTurn(this Game game)
	    {
		    game.Process(EndTurnTask.Any(game.CurrentPlayer));
	    }

	    public static void PlayHeroPower(this Game game, IPlayable target = null, int chooseOne = 0, bool asZeroCost = false)
	    {
		    game.Process(HeroPowerTask.Any(game.CurrentPlayer, target, chooseOne, asZeroCost));
	    }
    }
}
