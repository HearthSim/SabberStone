using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace SabberStoneKettlePlugin.slave
{
    /// <summary>
    /// Object which controls the game instances allocated to a specific slave.
    /// </summary>
    internal class GameStore
    {
        /// <summary>
        /// The game instance counter.
        /// </summary>
        private readonly Semaphore _instanceCounter;

        /// <summary>
        /// All registered games.
        /// </summary>
        private readonly Dictionary<string, KettleGame> _registeredGames;

        public GameStore(int maxInstances)
        {
            Debug.Assert(maxInstances > 0);

            _instanceCounter = new Semaphore(0, maxInstances);
            _registeredGames = new Dictionary<string, KettleGame>(maxInstances);
        }

        /// <summary>
        /// Gets the Kettle Game object from the specified ID.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public KettleGame GetGame(string id)
        {
            if (!_registeredGames.ContainsKey(id))
            {
                return null;
            }

            return _registeredGames[id];
        }

        /// <summary>
        /// Registers a Kettle Game object.
        /// </summary>
        /// <param name="game">The game.</param>
        /// <param name="gameID">The game identifier.</param>
        /// <returns></returns>
        public bool RegisterGame(KettleGame game, out string gameID)
        {
            if (!_instanceCounter.WaitOne(0))
            {
                // We hit the maximum of games at the moment!
                gameID = "";
                return false;
            }

            // Build a new ID for reference.
            gameID = Guid.NewGuid().ToString();
            _registeredGames[gameID] = game;
            return true;
        }

        /// <summary>
        /// Unregisters a Kettle Game object.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public bool UnregisterGame(string id)
        {
            var result = _registeredGames.Remove(id);
            if (result)
            {
                _instanceCounter.Release();
                return true;
            }

            return false;
        }
    }
}
