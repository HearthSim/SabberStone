using SabberStoneCore.Config;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCoreGui.Meta;
using SabberStoneCoreGui.Score;
using SabberStoneGui.Deck;
using System;
using System.Collections;
using System.Linq;

namespace SabberStoneGui.Core
{
	public class GuiHelper
	{
		public static GameConfig CreateGameConfig(MetaDeck deck1, MetaDeck deck2)
		{
			return new GameConfig()
			{
				StartPlayerIdx = 1,
				Player1Name = "FitzVonGerald",
				Player1CardClass = deck1.HeroClass,
				Player1Deck = deck1.CardIds.Select(Cards.FromId).ToList(),
				Player2Name = "RehHausZuckFuchs",
				Player2CardClass = deck2.HeroClass,
				Player2Deck = deck2.CardIds.Select(Cards.FromId).ToList(),
				FillDecks = false,
				Shuffle = true
			};
		}

		public static IEnumerable FormatTypes => Enum.GetValues(typeof(EFormatType)).Cast<EFormatType>().Where(e => e != EFormatType.FT_UNKNOWN);
		public static IEnumerable ClassTypes => Enum.GetValues(typeof(ECardClass)).Cast<ECardClass>()
				.Where(e =>
					e != ECardClass.INVALID &&
					e != ECardClass.DEATHKNIGHT &&
					e != ECardClass.DREAM &&
					e != ECardClass.NEUTRAL);

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
