using Kettle.Protocol;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SabberStoneKettlePlugin
{
    internal static class KettleConversion
    {
        public static Card KettleHeroToCard(HeroEnum hero)
        {
            switch (hero)
            {
                case HeroEnum.Rexxar:
                    return Cards.FromId("HERO_05");
                case HeroEnum.Alleria_Windrunner:
                    return Cards.FromId("HERO_05a");
                case HeroEnum.Anduin_Wrynn:
                    return Cards.FromId("HERO_09");
                case HeroEnum.Tyrande_Whisperwind:
                    return Cards.FromId("HERO_09a");
                case HeroEnum.Garrosh_Hellscream:
                    return Cards.FromId("HERO_01");
                case HeroEnum.Magni_Bronzebeard:
                    return Cards.FromId("HERO_01a");
                case HeroEnum.GulDan:
                    return Cards.FromId("HERO_07");
                case HeroEnum.Jaina_Proudmoore:
                    return Cards.FromId("HERO_08");
                case HeroEnum.Khadgar:
                    return Cards.FromId("HERO_08b");
                case HeroEnum.Lady_Liadrin:
                    return Cards.FromId("HERO_04a");
                case HeroEnum.Uther_Lightbringer:
                    return Cards.FromId("HERO_04");
                case HeroEnum.Maiev_Shadowsong:
                    return Cards.FromId("HERO_03a");
                case HeroEnum.Valeera_Sanguinar:
                    return Cards.FromId("HERO_03");
                case HeroEnum.Thrall:
                    return Cards.FromId("HERO_02");
                case HeroEnum.Morgl_the_Oracle:
                    return Cards.FromId("HERO_02a");
                case HeroEnum.Malfurion_Stormrage:
                    return Cards.FromId("HERO_06");

                case HeroEnum.Invalid:
                default:
                    throw new ArgumentException("Provide a correct hero enum value");
            }
        }

        public static FormatType KettleGameModeToFormat(GameScenarioEnum scenario)
        {
            switch (scenario)
            {
                case GameScenarioEnum.Match_Arena:
                case GameScenarioEnum.Match_Standard:
                case GameScenarioEnum.Ranked_Standard:
                    return FormatType.FT_STANDARD;
                case GameScenarioEnum.Match_Wild:
                case GameScenarioEnum.Ranked_Wild:
                    return FormatType.FT_WILD;
                case GameScenarioEnum.Invalid:
                default:
                    return FormatType.FT_UNKNOWN;
            }
        }

    }
}
