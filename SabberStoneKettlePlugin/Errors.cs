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
        internal const string GAMEQUEUE_FULL_MSG = "There is no more room to start a new game instance!";
        internal const int GAMEQUEUE_FULL = 0x1;

        internal const string MALFORMED_CREATE_GAME_MSG = "The create game packet is malformed!";
        internal const int MALFORMED_CREATE_GAME = 0x2;
    }
}
