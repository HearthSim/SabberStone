using Kettle.Adapter;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace SabberStoneKettlePlugin
{
	/// <summary>
	/// Object which is set on the connection information to identify the game linked
	/// to that connection.
	/// </summary>
	internal class KettleGame
    {
        /// <summary>
        /// The maximum amount of accounts playing the game.
        /// </summary>
        private const int MAX_PLAYERS = 2;

        /// <summary>
        /// Identifies the relation between a player and the game instance.
        /// </summary>
        internal enum PLAYER_TYPE
        {
            INVALID,
            PLAYER,
            SPECTATOR
        };

        /// <summary>
        /// The Sabberstone game instance.
        /// </summary>
        public readonly Game Game;

        /// <summary>
        /// The ID's of the game accounts.
        /// </summary>
        public readonly int[] PlayerIDs;

        /// <summary>
        /// The passwords for each player to access the game.
        /// </summary>
        private readonly string[] PlayerPasswords;

        /// <summary>
        /// The passwords for non-players to enter the game as spectators.
        /// </summary>
        private readonly string[] SpectatorPasswords;

        /// <summary>
        /// Contains the connection objects for each player.
        /// </summary>
        private readonly KettleConnectionArgs[] Players;

        /// <summary>
        /// List of connections which spectate this game.
        /// </summary>
        private readonly List<KettleConnectionArgs> Spectators;

        /// <summary>
        /// Set of all spectator connection objects. This set is used to quickly query 
        /// if a given connection already is attached as spectator.
        /// </summary>
        private readonly HashSet<KettleConnectionArgs> _spectatorSet;

        /// <summary>
        /// Gets a value indicating whether both players have joined this game.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [all players joined]; otherwise, <c>false</c>.
        /// </value>
        public bool AllPlayersJoined => Players.Where(x => x != null).Count() == 2;

        public KettleGame(Game game, int player1ID, int player2ID,
            string player1Password, string player1SpectatorPassword,
            string player2Password, string player2SpectatorPassword)
        {
            Game = game;

            PlayerIDs = new int[MAX_PLAYERS];
            PlayerPasswords = new string[MAX_PLAYERS];
            SpectatorPasswords = new string[MAX_PLAYERS];

            PlayerIDs[0] = player1ID;
            PlayerIDs[1] = player2ID;

            PlayerPasswords[0] = player1Password;
            PlayerPasswords[1] = player2Password;

            SpectatorPasswords[0] = player1SpectatorPassword;
            SpectatorPasswords[1] = player2SpectatorPassword;

            Players = new KettleConnectionArgs[MAX_PLAYERS];
            Spectators = new List<KettleConnectionArgs>();
            _spectatorSet = new HashSet<KettleConnectionArgs>();
        }

        /// <summary>
        /// Tries to attach the provided user to this game.
        /// </summary>
        /// <param name="userID">The user identifier.</param>
        /// <param name="password">The password.</param>
        /// <param name="e">The e.</param>
        /// <returns></returns>
        public PLAYER_TYPE TryJoinGame(int userID, string password, KettleConnectionArgs e)
        {
            if (AllPlayersJoined) // TODO; Might have to update this to facilitate reconnect.
            {
                if (MatchSpectator(password))
                {
                    if (_spectatorSet.Add(e))
                    {
                        // The set didn't already contain this connection object.
                        Spectators.Add(e);
                    }
                    return PLAYER_TYPE.SPECTATOR;
                }
            }
            else
            {
                var playerIdx = MatchPlayer(userID, password);
                if (playerIdx != -1)
                {
                    // playerIdx contains the index corresponding to the player details.
                    // At that index we'll store the connection arguments.
                    Players[playerIdx] = e;
                    return PLAYER_TYPE.PLAYER;
                }
                else
                {
                    // Credentials are not from player, but might be from spectator.
                    if (MatchSpectator(password))
                    {
                        if (_spectatorSet.Add(e))
                        {
                            // The set didn't already contain this connection object.
                            Spectators.Add(e);
                        }
                        return PLAYER_TYPE.SPECTATOR;
                    }
                }
            }

            return PLAYER_TYPE.INVALID;
        }

        private bool MatchSpectator(string password)
        {
            if (string.IsNullOrWhiteSpace(password)) return false;
            return SpectatorPasswords.Any(x => x == password);
        }

        private int MatchPlayer(int userID, string password)
        {
            for (int i = 0; i < MAX_PLAYERS; ++i)
            {
                int targetPlayerID = PlayerIDs[i];
                string targetPassword = PlayerPasswords[i];
                if (targetPlayerID == userID && password == targetPassword)
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Processes the provided task and automatically send updates to all 
        /// players and spectators.
        /// </summary>
        /// <param name="task">The task.</param>
        /// <returns></returns>
        public bool ProcessAndUpdate(PlayerTask task)
        {
            if (!AllPlayersJoined) return false;

            Game.Process(task);

            // TODO; send state updates to all interested parties.

            /* Pregame MULLIGAN PHASE */
            if (Game.Step == Step.BEGIN_MULLIGAN &&
                Game.Player1.MulliganState == Mulligan.DONE &&
                Game.Player1.MulliganState == Mulligan.DONE)
            {
                // Initiate first turn.
                Game.MainBegin();

                // TODO; send MAIN_ACTION phase history update.

                return true;
            }

            /* Player TURN switch */
            // TODO; send turn options.

            return true;
        }
    }
}
