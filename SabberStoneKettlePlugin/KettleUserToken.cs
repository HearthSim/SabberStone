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
        /// Gets or sets the game token.
        /// </summary>
        /// <value>
        /// The game token.
        /// </value>
        public KettleGame GameToken
        {
            get => _gameToken;
            set
            {
                // Only allow the gametoken to be set exactly once!
                if (value != null && _gameToken == null)
                {
                    _gameToken = value;
                }
            }
        }
        private KettleGame _gameToken;

        public KettleUserToken()
        {
        }
    }
}
