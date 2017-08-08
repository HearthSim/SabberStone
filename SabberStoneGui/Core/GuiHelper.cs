using System;
using System.Collections;
using System.Linq;
using SabberStoneCore.Enums;
using SabberStoneCore.Config;
using SabberStoneCore.Model;
using SabberStoneGui.Deck;
using SabberStoneCoreGui.Score;
using SabberStoneCoreGui.Meta;

namespace SabberStoneGui.Core
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
                Player1Deck = deck1.CardIds.Select(Cards.FromId).ToList(),
                Player2Name = "RehHausZuckFuchs",
                Player2HeroClass = deck2.HeroClass,
                Player2Deck = deck2.CardIds.Select(Cards.FromId).ToList(),
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
