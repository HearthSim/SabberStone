using System;
using System.Collections.Generic;
using System.Text;

namespace SabberStoneKettlePlugin
{
    /// <summary>
    /// Collection of all communicated error values throughout the program.
    /// </summary>
    internal static class Errors
    {
        internal const string UNEXPECTED_PAYLOAD_MSG = "This payload was not expected at the moment!";
        internal const int UNEXPECTED_PAYLOAD = 0x1;

        internal const string GAMEQUEUE_FULL_MSG = "There is no more room to start a new game instance!";
        internal const int GAMEQUEUE_FULL = 0x2;

        internal const string MALFORMED_PAYLOAD_MSG = "The packet is malformed!";
        internal const int MALFORMED_PAYLOAD = 0x3;

        internal const string UNKNOWN_GAME_ID_MSG = "The provided game id is unknown!";
        internal const int UNKNOWN_GAME_ID = 0x4;

        internal const string INVALID_CREDENTIALS_MSG = "Invalid credentials!";
        internal const int INVALID_CREDENTIALS = 0x5;

        internal const string NOT_ACTIVE_TURN_MSG = "It's not your turn!";
        internal const int NOT_ACTIVE_TURN = 0x6;

        internal const string INVALID_ID_PROVIDED_MSG = "The provided ID does not correspond to any (valid) data!";
        internal const int INVALID_ID_PROVIDED = 0x7;
    }
}
