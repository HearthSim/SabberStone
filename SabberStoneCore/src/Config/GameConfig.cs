using System.Collections.Generic;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;

namespace SabberStoneCore.Config
{
    public class GameConfig
    {
        public int StartPlayer { get; set; } = -1;

        public string Player1Name { get; set; } = "Player1";

        public ECardClass Player1HeroClass { get; set; } = ECardClass.HUNTER;

        public string Player2Name { get; set; } = "Player2";

        public ECardClass Player2HeroClass { get; set; } = ECardClass.MAGE;

        public EFormatType GameRule { get; set; } = EFormatType.FT_STANDARD;

        public List<Card> DeckPlayer1 { get; set; } = null;

        public List<Card> DeckPlayer2 { get; set; } = null;

        public bool FillDecks { get; set; } = false;

        public bool DrawPool { get; set; } = false;

        public bool Shuffle { get; set; } = true;

        public bool Splitting { get; set; } = false;

        public bool Logging { get; set; } = true;

        public bool History { get; set; } = true;

        public bool SkipMulligan { get; set; } = true;

        public GameConfig Clone()
        {
            return (GameConfig) this.MemberwiseClone();
        }
    }
}
