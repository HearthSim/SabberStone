using SabberStoneCore.Model;

namespace SabberStoneKettlePlugin
{
    /// <summary>
    /// Object which is attached to a connection to provide meta-information.
    /// </summary>
    class KettleUserToken
    {

        /// <summary>
        /// Gets the game token.
        /// </summary>
        /// <value>
        /// The game token.
        /// </value>
        public KettleGame GameToken => _gameToken;
        private KettleGame _gameToken;

        /// <summary>
        /// The object used to perform actions within a Sabberstone game.
        /// </summary>
        public Controller PlayerController => _playerController;
        private Controller _playerController;

        /// <summary>
        /// Gets a value indicating whether the current turn is assigned to this player or not..
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is player turn; otherwise, <c>false</c>.
        /// </value>
        public bool IsPlayerTurn
        {
            get
            {
                if (_gameToken == null || _playerController == null) return false;
                return _gameToken.Game.CurrentPlayer == _playerController;
            }
        }

        public KettleUserToken()
        {
        }

        /// <summary>
        /// Store the Sabberstone game instance into this token. The controller object
        /// representing the player is also set.
        /// 
        /// The provided user ID must have been registered onto the game already!
        /// </summary>
        /// <param name="game">The game.</param>
        /// <param name="userID">The user identifier.</param>
        /// <returns></returns>
        public bool LinkGame(KettleGame game, int userID)
        {
            if (_gameToken != null) return false;

            // Check controller object.
            int maxPlayers = game.PlayerIDs.Length;
            for(int i = 0; i < maxPlayers; ++i)
            {
                int targetID = game.PlayerIDs[i];
                if(targetID == userID)
                {
                    // Store reference to game.
                    _gameToken = game;
                    
                    // Get controller for this player.
                    // Entity ID's are 1-indexed. First entity is ALWAYS the game itself.
                    // The second entity is the first player!
                    int playerEntityID = i + 2;
                    _playerController = game.Game.ControllerById(playerEntityID);
                    return true;
                }
            }

            return false;
        }
    }
}
