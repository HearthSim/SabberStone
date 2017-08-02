using System;
using System.Collections.Generic;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model
{
    public class Tag
    {
        public EGameTag GameTag { get; }
        public TagValue TagValue { get; }

        public Tag(EGameTag gameTag, TagValue tagValue)
        {
            GameTag = gameTag;
            TagValue = tagValue;
        }

        public override string ToString()
        {
            var s = GameTag.ToString() + " = ";
            var v = TagValue.ToString();
            try
            {
                if (TypedTags.ContainsKey(GameTag))
                    v = Enum.GetName(TypedTags[GameTag], (int)TagValue);
            }
            catch (Exception)
            {
                // ignored
            }
            return s + v;
        }

        public static readonly Dictionary<EGameTag, System.Type> TypedTags = new Dictionary<EGameTag, System.Type> {
                [EGameTag.STATE] = typeof(EState),
                [EGameTag.ZONE] = typeof(EZone),
                [EGameTag.STEP] = typeof(EStep),
                [EGameTag.NEXT_STEP] = typeof(EStep),
                [EGameTag.PLAYSTATE] = typeof(EPlayState),
                [EGameTag.CARDTYPE] = typeof(ECardType),
                [EGameTag.MULLIGAN_STATE] = typeof(EMulligan),
                [EGameTag.CARD_SET] = typeof(ECardSet),
                [EGameTag.CLASS] = typeof(ECardClass),
                [EGameTag.RARITY] = typeof(ERarity),
                [EGameTag.FACTION] = typeof(EFaction),
                [EGameTag.CARDRACE] = typeof(ERace),
                [EGameTag.ENCHANTMENT_BIRTH_VISUAL] = typeof(EEnchantmentVisual),
                [EGameTag.ENCHANTMENT_IDLE_VISUAL] = typeof(EEnchantmentVisual),
                [EGameTag.GOLD_REWARD_STATE] = typeof(EGoldRewardState)
            };
    }
}