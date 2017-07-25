using Kettle.Adapter;
using SabberStoneCore.Model;

namespace SabberStoneKettlePlugin
{
    /// <summary>
    /// Object which is set on the connection information to identify the game linked
    /// to that connection.
    /// </summary>
    class KettleGameToken
    {
        /// <summary>
        /// The Sabberstone game instance.
        /// </summary>
        public readonly Game Game;

        /// <summary>
        /// The player instance, attached to the game instance mentioned by `Game` property.
        /// </summary>
        public readonly Controller Player;

        /// <summary>
        /// The connection object of the other player.
        /// </summary>
        public KettleConnectionArgs OtherPlayerConnection;

        public KettleGameToken(Game game, Controller player)
        {
            Game = game;
            Player = player;
        }

        // TODO; Expose some properties which are often used.

        /// <summary>
        /// Gets a value indicating whether this player is currently executing it's turn.
        /// </summary>
        /// <value>
        ///   <c>true</c> it's the turn of the current player; otherwise, <c>false</c>.
        /// </value>
        public bool IsPlayerTurn => Game.CurrentPlayer == Player;

        /// <summary>
        /// Gets a value indicating whether this game instance has started.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is started; otherwise, <c>false</c>.
        /// </value>
        // TODO
        public bool IsGameStarted => false;
    }
}
