#region copyright
// SabberStone, Hearthstone Simulator in C# .NET Core
// Copyright (C) 2017-2019 SabberStone Team, darkfriend77 & rnilva
//
// SabberStone is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License.
// SabberStone is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
#endregion
using System;
using System.Collections.Generic;
using SabberStoneCore.Enums;

namespace SabberStoneCore.Model
{
	public struct Tag
	{
		public GameTag GameTag { get; }
		public TagValue TagValue { get; }

		public Tag(GameTag gameTag, TagValue tagValue)
		{
			GameTag = gameTag;
			TagValue = tagValue;
		}

		public override string ToString()
		{
			string s = GameTag.ToString() + " = ";
			string v = TagValue.ToString();
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

		public static readonly Dictionary<GameTag, System.Type> TypedTags = new Dictionary<GameTag, System.Type>
		{
			[GameTag.STATE] = typeof(State),
			[GameTag.ZONE] = typeof(Zone),
			[GameTag.STEP] = typeof(Step),
			[GameTag.NEXT_STEP] = typeof(Step),
			[GameTag.PLAYSTATE] = typeof(PlayState),
			[GameTag.CARDTYPE] = typeof(CardType),
			[GameTag.MULLIGAN_STATE] = typeof(Mulligan),
			[GameTag.CARD_SET] = typeof(CardSet),
			[GameTag.CLASS] = typeof(CardClass),
			[GameTag.RARITY] = typeof(Rarity),
			[GameTag.FACTION] = typeof(Faction),
			[GameTag.CARDRACE] = typeof(Race),
			[GameTag.ENCHANTMENT_BIRTH_VISUAL] = typeof(EnchantmentVisual),
			[GameTag.ENCHANTMENT_IDLE_VISUAL] = typeof(EnchantmentVisual),
			[GameTag.GOLD_REWARD_STATE] = typeof(GoldRewardState)
		};
	}
}
