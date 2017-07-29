using Kettle.Adapter;
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

        public KettleUserToken()
        {
        }

        public bool SetGame(KettleGame game)
        {
            if (_gameToken != null) return false;

            _gameToken = game;
            return true;
        }
    }
}
