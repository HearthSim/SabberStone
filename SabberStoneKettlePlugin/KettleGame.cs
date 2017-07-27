using Kettle.Adapter;
using SabberStoneCore.Model;
using System.Collections.Generic;

namespace SabberStoneKettlePlugin
{
    /// <summary>
    /// Object which is set on the connection information to identify the game linked
    /// to that connection.
    /// </summary>
    internal class KettleGame
    {
        /// <summary>
        /// The Sabberstone game instance.
        /// </summary>
        public readonly Game Game;

        /// <summary>
        /// Game account identifier of player 1.
        /// </summary>
        public readonly int Player1ID;

        /// <summary>
        /// Game account identifier of player 2.
        /// </summary>
        public readonly int Player2ID;

        /// <summary>
        /// Contains the connection objects for each player.
        /// </summary>
        public readonly KettleConnectionArgs[] Players;

        /// <summary>
        /// List of connections which spectate this game.
        /// </summary>
        public readonly List<KettleConnectionArgs> Spectators;

        public KettleGame(Game game, int player1ID, int player2ID)
        {
            Game = game;
            Player1ID = player1ID;
            Player2ID = player2ID;

            Players = new KettleConnectionArgs[2];
            Spectators = new List<KettleConnectionArgs>();
        }

        // TODO; Expose some properties which are often used.
    }
}
