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

        internal const string MALFORMED_CREATE_GAME_MSG = "The create game packet is malformed!";
        internal const int MALFORMED_CREATE_GAME = 0x3;

        internal const string UNKNOWN_GAME_ID_MSG = "The provided game id is unknown!";
        internal const int UNKNOWN_GAME_ID = 0x4;

        internal const string INVALID_CREDENTIALS_MSG = "Invalid credentials!";
        internal const int INVALID_CREDENTIALS = 0x5;


    }
}
