using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HearthDb.Enums;
using SabberStone.Config;
using SabberStone.Model;
using SimpleAi.Meta;
using SimpleAi.Score;
using SimpleUi.Deck;

namespace SimpleUi.Core
{
    public class GuiHelper
    {
        public static GameConfig CreateGameConfig(MetaDeck deck1, MetaDeck deck2)
        {
            return new GameConfig()
            {
                StartPlayer = 1,
                Player1Name = "FitzVonGerald",
                Player1HeroClass = deck1.HeroClass,
                DeckPlayer1 = deck1.CardIds.Select(Cards.FromId).ToList(),
                Player2Name = "RehHausZuckFuchs",
                Player2HeroClass = deck2.HeroClass,
                DeckPlayer2 = deck2.CardIds.Select(Cards.FromId).ToList(),
                FillDecks = false,
                Shuffle = true
            };
        }

        public static IEnumerable FormatTypes => Enum.GetValues(typeof(FormatType)).Cast<FormatType>().Where(e => e != FormatType.FT_UNKNOWN);
        public static IEnumerable ClassTypes => Enum.GetValues(typeof(CardClass)).Cast<CardClass>()
                .Where(e =>
                    e != CardClass.INVALID &&
                    e != CardClass.DEATHKNIGHT &&
                    e != CardClass.DREAM &&
                    e != CardClass.NEUTRAL);

        public static IEnumerable StrategyTypes => Enum.GetValues(typeof(Strategy)).Cast<Strategy>();

        public static IScore GetScoring(Strategy s)
        {
            switch (s)
            {
                case Strategy.Aggro:
                    return new AggroScore();
                case Strategy.Midrange:
                    return new MidRangeScore();
                case Strategy.Control:
                    return new ControlScore();
                case Strategy.Ramp:
                    return new RampScore();
                case Strategy.Fatigue:
                    return new FatigueScore();
                default:
                    throw new ArgumentOutOfRangeException(nameof(s), s, null);
            }
        }
    }
}
