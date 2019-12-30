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
using System.Collections.Generic;
using SabberStoneCore.Enchants;
using SabberStoneCore.Enums;
using SabberStoneCore.src.Loader;
// ReSharper disable RedundantEmptyObjectOrCollectionInitializer

namespace SabberStoneCore.CardSets.Adventure
{
	public class LoeCardsGenAdv
	{
		private static void Heroes(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------------- HERO - NEUTRAL
			// [LOEA01_01] Sun Raider Phaerix (*) - COST:0 [ATK:0/HP:30]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 14019
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA01_01", new CardDef(new Power
			{
				// TODO [LOEA01_01] Sun Raider Phaerix && Test: Sun Raider Phaerix_LOEA01_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [LOEA01_01h] Sun Raider Phaerix (*) - COST:0 [ATK:0/HP:30]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 38479
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA01_01h", new CardDef(new Power
			{
				// TODO [LOEA01_01h] Sun Raider Phaerix && Test: Sun Raider Phaerix_LOEA01_01h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [LOEA02_01] Zinaar (*) - COST:0 [ATK:0/HP:30]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 14203
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA02_01", new CardDef(new Power
			{
				// TODO [LOEA02_01] Zinaar && Test: Zinaar_LOEA02_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [LOEA02_01h] Zinaar (*) - COST:0 [ATK:0/HP:30]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 38465
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA02_01h", new CardDef(new Power
			{
				// TODO [LOEA02_01h] Zinaar && Test: Zinaar_LOEA02_01h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [LOEA04_01] Temple Escape (*) - COST:0 [ATK:0/HP:100]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 16231
			// - APPEAR_FUNCTIONALLY_DEAD = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA04_01", new CardDef(new Power
			{
				// TODO [LOEA04_01] Temple Escape && Test: Temple Escape_LOEA04_01
				InfoCardId = "LOEA04_01e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [LOEA04_01h] Temple Escape (*) - COST:0 [ATK:0/HP:100]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 38510
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA04_01h", new CardDef(new Power
			{
				// TODO [LOEA04_01h] Temple Escape && Test: Temple Escape_LOEA04_01h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [LOEA05_01] Chieftain Scarvash (*) - COST:0 [ATK:0/HP:30]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 15353
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA05_01", new CardDef(new Power
			{
				// TODO [LOEA05_01] Chieftain Scarvash && Test: Chieftain Scarvash_LOEA05_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [LOEA05_01h] Chieftain Scarvash (*) - COST:0 [ATK:0/HP:30]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 38555
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA05_01h", new CardDef(new Power
			{
				// TODO [LOEA05_01h] Chieftain Scarvash && Test: Chieftain Scarvash_LOEA05_01h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [LOEA07_01] Mine Cart (*) - COST:0 [ATK:0/HP:30]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA07_01", new CardDef(new Power
			{
				// TODO [LOEA07_01] Mine Cart && Test: Mine Cart_LOEA07_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [LOEA07_02] Mine Shaft (*) - COST:0 [ATK:0/HP:80]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 16205
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA07_02", new CardDef(new Power
			{
				// TODO [LOEA07_02] Mine Shaft && Test: Mine Shaft_LOEA07_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [LOEA07_02h] Mine Shaft (*) - COST:0 [ATK:0/HP:80]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 38676
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA07_02h", new CardDef(new Power
			{
				// TODO [LOEA07_02h] Mine Shaft && Test: Mine Shaft_LOEA07_02h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [LOEA08_01] Archaedas (*) - COST:0 [ATK:0/HP:30]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 17145
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA08_01", new CardDef(new Power
			{
				// TODO [LOEA08_01] Archaedas && Test: Archaedas_LOEA08_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [LOEA08_01h] Archaedas (*) - COST:0 [ATK:0/HP:30]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 38588
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA08_01h", new CardDef(new Power
			{
				// TODO [LOEA08_01h] Archaedas && Test: Archaedas_LOEA08_01h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [LOEA09_1] Lord Slitherspear (*) - COST:0 [ATK:0/HP:30]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 24427
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_1", new CardDef(new Power
			{
				// TODO [LOEA09_1] Lord Slitherspear && Test: Lord Slitherspear_LOEA09_1
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [LOEA09_1H] Lord Slitherspear (*) - COST:0 [ATK:0/HP:30]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 38609
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_1H", new CardDef(new Power
			{
				// TODO [LOEA09_1H] Lord Slitherspear && Test: Lord Slitherspear_LOEA09_1H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [LOEA10_1] Giantfin (*) - COST:0 [ATK:0/HP:30]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 10045
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA10_1", new CardDef(new Power
			{
				// TODO [LOEA10_1] Giantfin && Test: Giantfin_LOEA10_1
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [LOEA10_1H] Giantfin (*) - COST:0 [ATK:0/HP:30]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 38617
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA10_1H", new CardDef(new Power
			{
				// TODO [LOEA10_1H] Giantfin && Test: Giantfin_LOEA10_1H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [LOEA12_1] Lady Naz'jar (*) - COST:0 [ATK:0/HP:30]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 17193
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA12_1", new CardDef(new Power
			{
				// TODO [LOEA12_1] Lady Naz'jar && Test: Lady Naz'jar_LOEA12_1
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [LOEA12_1H] Lady Naz'jar (*) - COST:0 [ATK:0/HP:30]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 38620
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA12_1H", new CardDef(new Power
			{
				// TODO [LOEA12_1H] Lady Naz'jar && Test: Lady Naz'jar_LOEA12_1H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [LOEA13_1] Skelesaurus Hex (*) - COST:0 [ATK:0/HP:30]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 19795
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA13_1", new CardDef(new Power
			{
				// TODO [LOEA13_1] Skelesaurus Hex && Test: Skelesaurus Hex_LOEA13_1
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [LOEA13_1h] Skelesaurus Hex (*) - COST:0 [ATK:0/HP:30]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 38705
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA13_1h", new CardDef(new Power
			{
				// TODO [LOEA13_1h] Skelesaurus Hex && Test: Skelesaurus Hex_LOEA13_1h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [LOEA14_1] The Steel Sentinel (*) - COST:0 [ATK:0/HP:30]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 19117
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA14_1", new CardDef(new Power
			{
				// TODO [LOEA14_1] The Steel Sentinel && Test: The Steel Sentinel_LOEA14_1
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [LOEA14_1H] The Steel Sentinel (*) - COST:0 [ATK:0/HP:30]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 38708
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA14_1H", new CardDef(new Power
			{
				// TODO [LOEA14_1H] The Steel Sentinel && Test: The Steel Sentinel_LOEA14_1H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [LOEA15_1] Rafaam (*) - COST:0 [ATK:0/HP:30]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 19292
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA15_1", new CardDef(new Power
			{
				// TODO [LOEA15_1] Rafaam && Test: Rafaam_LOEA15_1
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [LOEA15_1H] Rafaam (*) - COST:0 [ATK:0/HP:30]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 38710
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA15_1H", new CardDef(new Power
			{
				// TODO [LOEA15_1H] Rafaam && Test: Rafaam_LOEA15_1H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [LOEA16_1] Rafaam (*) - COST:0 [ATK:0/HP:30]
			// - Set: loe,
			// --------------------------------------------------------
			// Entourage: LOEA16_18, LOEA16_23, LOEA16_19, LOEA16_22, LOEA16_21, LOEA16_24, LOEA16_25, LOEA16_26, LOEA16_27
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 19613
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_1", new CardDef(new[] {"LOEA16_18","LOEA16_23","LOEA16_19","LOEA16_22","LOEA16_21","LOEA16_24","LOEA16_25","LOEA16_26","LOEA16_27"}, new Power
			{
				// TODO [LOEA16_1] Rafaam && Test: Rafaam_LOEA16_1
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [LOEA16_1H] Rafaam (*) - COST:0 [ATK:0/HP:30]
			// - Set: loe,
			// --------------------------------------------------------
			// Entourage: LOEA16_18H, LOEA16_19H, LOEA16_21H, LOEA16_22H, LOEA16_23H, LOEA16_24H, LOEA16_25H, LOEA16_26H, LOEA16_27H
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 38712
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_1H", new CardDef(new[] {"LOEA16_18H","LOEA16_19H","LOEA16_21H","LOEA16_22H","LOEA16_23H","LOEA16_24H","LOEA16_25H","LOEA16_26H","LOEA16_27H"}, new Power
			{
				// TODO [LOEA16_1H] Rafaam && Test: Rafaam_LOEA16_1H
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void HeroPowers(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA01_02] Blessings of the Sun (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Whoever controls the Rod of the Sun is <b>Immune.</b>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA01_02", new CardDef(new Power
			{
				// TODO [LOEA01_02] Blessings of the Sun && Test: Blessings of the Sun_LOEA01_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA01_02h] Blessings of the Sun (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//        Phaerix is <b>Immune</b> while he controls the Rod of the Sun.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA01_02h", new CardDef(new Power
			{
				// TODO [LOEA01_02h] Blessings of the Sun && Test: Blessings of the Sun_LOEA01_02h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA02_02] Djinn’s Intuition (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Draw a card.
			//       Give your opponent a Wish.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA02_02", new CardDef(new Power
			{
				// TODO [LOEA02_02] Djinn’s Intuition && Test: Djinn’s Intuition_LOEA02_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA02_02h] Djinn’s Intuition (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Draw a card. Gain a Mana Crystal. Give your opponent a Wish.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA02_02h", new CardDef(new Power
			{
				// TODO [LOEA02_02h] Djinn’s Intuition && Test: Djinn’s Intuition_LOEA02_02h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA04_02] Escape! (*) - COST:0
			// - Set: loe, Rarity: free
			// --------------------------------------------------------
			// Text: Encounter new obstacles!
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA04_02", new CardDef(new Power
			{
				// TODO [LOEA04_02] Escape! && Test: Escape!_LOEA04_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA04_02h] Escape! (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Encounter new obstacles!
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA04_02h", new CardDef(new Power
			{
				// TODO [LOEA04_02h] Escape! && Test: Escape!_LOEA04_02h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA05_02] Trogg Hate Minions! (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//        Enemy minions cost (2) more. Swap at the start of your turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA05_02", new CardDef(new Power
			{
				// TODO [LOEA05_02] Trogg Hate Minions! && Test: Trogg Hate Minions!_LOEA05_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA05_02a] Trogg Hate Minions! (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//        Enemy minions cost (2) more. Swap at the start of your turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA05_02a", new CardDef(new Power
			{
				// TODO [LOEA05_02a] Trogg Hate Minions! && Test: Trogg Hate Minions!_LOEA05_02a
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA05_02h] Trogg Hate Minions! (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//        Enemy minions cost (11). Swap at the start of your turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA05_02h", new CardDef(new Power
			{
				// TODO [LOEA05_02h] Trogg Hate Minions! && Test: Trogg Hate Minions!_LOEA05_02h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA05_02ha] Trogg Hate Minions! (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//        Enemy minions cost (11). Swap at the start of your turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA05_02ha", new CardDef(new Power
			{
				// TODO [LOEA05_02ha] Trogg Hate Minions! && Test: Trogg Hate Minions!_LOEA05_02ha
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA05_03] Trogg Hate Spells! (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//        Enemy spells cost (2) more. Swap at the start of your turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA05_03", new CardDef(new Power
			{
				// TODO [LOEA05_03] Trogg Hate Spells! && Test: Trogg Hate Spells!_LOEA05_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA05_03h] Trogg Hate Spells! (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//        Enemy spells cost (11). Swap at the start of your turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA05_03h", new CardDef(new Power
			{
				// TODO [LOEA05_03h] Trogg Hate Spells! && Test: Trogg Hate Spells!_LOEA05_03h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA06_02] Stonesculpting (*) - COST:1
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//        Summon a 0/2 Statue for both players.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA06_02", new CardDef(new Power
			{
				// TODO [LOEA06_02] Stonesculpting && Test: Stonesculpting_LOEA06_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA06_02h] Stonesculpting (*) - COST:1
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//        Summon a Statue for both players.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA06_02h", new CardDef(new Power
			{
				// TODO [LOEA06_02h] Stonesculpting && Test: Stonesculpting_LOEA06_02h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA07_03] Flee the Mine! (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Escape the Troggs!
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA07_03", new CardDef(new Power
			{
				// TODO [LOEA07_03] Flee the Mine! && Test: Flee the Mine!_LOEA07_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA07_03h] Flee the Mine! (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Escape the Troggs!
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA07_03h", new CardDef(new Power
			{
				// TODO [LOEA07_03h] Flee the Mine! && Test: Flee the Mine!_LOEA07_03h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA07_29] Throw Rocks (*) - COST:1
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//        Deal 3 damage to a random enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA07_29", new CardDef(new Power
			{
				// TODO [LOEA07_29] Throw Rocks && Test: Throw Rocks_LOEA07_29
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA09_2] Enraged! (*) - COST:2
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Give your hero +2 attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_2", new CardDef(new Power
			{
				// TODO [LOEA09_2] Enraged! && Test: Enraged!_LOEA09_2
				InfoCardId = "LOEA09_2e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA09_2H] Enraged! (*) - COST:2
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Give your hero +5 attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_2H", new CardDef(new Power
			{
				// TODO [LOEA09_2H] Enraged! && Test: Enraged!_LOEA09_2H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA09_3] Getting Hungry (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a Hungry Naga.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_3", new CardDef(new Power
			{
				// TODO [LOEA09_3] Getting Hungry && Test: Getting Hungry_LOEA09_3
				InfoCardId = "LOEA09_3a",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA09_3b] Getting Hungry (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a 1/1 Hungry Naga.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_3b", new CardDef(new Power
			{
				// TODO [LOEA09_3b] Getting Hungry && Test: Getting Hungry_LOEA09_3b
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA09_3c] Getting Hungry (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a 2/1 Hungry Naga.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_3c", new CardDef(new Power
			{
				// TODO [LOEA09_3c] Getting Hungry && Test: Getting Hungry_LOEA09_3c
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA09_3d] Getting Hungry (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a 5/1 Hungry Naga.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_3d", new CardDef(new Power
			{
				// TODO [LOEA09_3d] Getting Hungry && Test: Getting Hungry_LOEA09_3d
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA09_3H] Endless Hunger (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a Hungry Naga.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_3H", new CardDef(new Power
			{
				// TODO [LOEA09_3H] Endless Hunger && Test: Endless Hunger_LOEA09_3H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA10_2] Mrglmrgl MRGL! (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Draw cards until you have as many in hand as your opponent.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA10_2", new CardDef(new Power
			{
				// TODO [LOEA10_2] Mrglmrgl MRGL! && Test: Mrglmrgl MRGL!_LOEA10_2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA10_2H] Mrglmrgl MRGL! (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Draw 2 cards.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA10_2H", new CardDef(new Power
			{
				// TODO [LOEA10_2H] Mrglmrgl MRGL! && Test: Mrglmrgl MRGL!_LOEA10_2H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA12_2] Pearl of the Tides (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: At the end of your turn, replace all minions with new ones that cost (1) more.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA12_2", new CardDef(new Power
			{
				// TODO [LOEA12_2] Pearl of the Tides && Test: Pearl of the Tides_LOEA12_2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA12_2H] Pearl of the Tides (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: At the end of your turn, replace all minions with new ones. Yours cost (1) more.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA12_2H", new CardDef(new Power
			{
				// TODO [LOEA12_2H] Pearl of the Tides && Test: Pearl of the Tides_LOEA12_2H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA13_2] Ancient Power (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give each player a random card. It costs (0).
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA13_2", new CardDef(new Power
			{
				// TODO [LOEA13_2] Ancient Power && Test: Ancient Power_LOEA13_2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA13_2H] Ancient Power (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Add a random card to your hand. It costs (0).
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA13_2H", new CardDef(new Power
			{
				// TODO [LOEA13_2H] Ancient Power && Test: Ancient Power_LOEA13_2H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA14_2] Platemail Armor (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Your Hero can only take 1 damage at a time.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA14_2", new CardDef(new Power
			{
				// TODO [LOEA14_2] Platemail Armor && Test: Platemail Armor_LOEA14_2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA14_2H] Platemail Armor (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Your Hero and your minions can only take 1 damage at a time.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA14_2H", new CardDef(new Power
			{
				// TODO [LOEA14_2H] Platemail Armor && Test: Platemail Armor_LOEA14_2H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA15_2] Unstable Portal (*) - COST:2
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Add a random minion to your hand. It costs (3) less.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA15_2", new CardDef(new Power
			{
				// TODO [LOEA15_2] Unstable Portal && Test: Unstable Portal_LOEA15_2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA15_2H] Unstable Portal (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Add a random minion to your hand. It costs (3) less.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA15_2H", new CardDef(new Power
			{
				// TODO [LOEA15_2H] Unstable Portal && Test: Unstable Portal_LOEA15_2H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA16_16] Rummage (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Find an artifact.
			// --------------------------------------------------------
			// Entourage: LOEA16_10, LOEA16_11, LOEA16_14, LOEA16_15, LOEA16_6, LOEA16_7, LOEA16_9, LOEA16_12, LOEA16_13, LOEA16_8
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_16", new CardDef(new[] {"LOEA16_10","LOEA16_11","LOEA16_14","LOEA16_15","LOEA16_6","LOEA16_7","LOEA16_9","LOEA16_12","LOEA16_13","LOEA16_8"}, new Power
			{
				// TODO [LOEA16_16] Rummage && Test: Rummage_LOEA16_16
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA16_16H] Rummage (*) - COST:2
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Find an artifact.
			// --------------------------------------------------------
			// Entourage: LOEA16_10, LOEA16_11, LOEA16_14, LOEA16_15, LOEA16_6, LOEA16_7, LOEA16_9, LOEA16_12, LOEA16_13, LOEA16_8
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_16H", new CardDef(new[] {"LOEA16_10","LOEA16_11","LOEA16_14","LOEA16_15","LOEA16_6","LOEA16_7","LOEA16_9","LOEA16_12","LOEA16_13","LOEA16_8"}, new Power
			{
				// TODO [LOEA16_16H] Rummage && Test: Rummage_LOEA16_16H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA16_2] Staff of Origination (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Your hero is <b>Immune</b> while the staff charges.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_2", new CardDef(new Power
			{
				// TODO [LOEA16_2] Staff of Origination && Test: Staff of Origination_LOEA16_2
				InfoCardId = "LOEA16_20e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [LOEA16_2H] Staff of Origination (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Your hero is <b>Immune</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_2H", new CardDef(new Power
			{
				// TODO [LOEA16_2H] Staff of Origination && Test: Staff of Origination_LOEA16_2H
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void HunterNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------------- MINION - HUNTER
			// [LOEA02_10a] Leokk (*) - COST:0 [ATK:2/HP:4]
			// - Race: beast, Set: loe,
			// --------------------------------------------------------
			// Text: Your minions have +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("LOEA02_10a", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [LOEA02_10a] Leokk && Test: Leokk_LOEA02_10a
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- MINION - HUNTER
			// [LOEA02_10c] Misha (*) - COST:0 [ATK:4/HP:4]
			// - Race: beast, Set: loe,
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("LOEA02_10c", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [LOEA02_10c] Misha && Test: Misha_LOEA02_10c
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void Neutral(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - NEUTRAL
			// [LOEA10_3] Murloc Tinyfin - COST:0 [ATK:1/HP:1]
			// - Race: murloc, Set: loe, Rarity: common
			// --------------------------------------------------------
			cards.Add("LOEA10_3", new CardDef(new Power
			{
				// TODO [LOEA10_3] Murloc Tinyfin && Test: Murloc Tinyfin_LOEA10_3
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void NeutralNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOEA01_11he] Heroic Mode (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: +3/+3 if Phaerix controls the Rod.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA01_11he", new CardDef(new Power
			{
				// TODO [LOEA01_11he] Heroic Mode && Test: Heroic Mode_LOEA01_11he
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOEA01_11he")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOEA04_01e] Temple Escape Enchant (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA04_01e", new CardDef(new Power
			{
				// TODO [LOEA04_01e] Temple Escape Enchant && Test: Temple Escape Enchant_LOEA04_01e
				InfoCardId = "LOEA04_01eh",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOEA04_01e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOEA04_01eh] Temple Escape Enchant (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA04_01eh", new CardDef(new Power
			{
				// TODO [LOEA04_01eh] Temple Escape Enchant && Test: Temple Escape Enchant_LOEA04_01eh
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOEA04_01eh")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOEA06_03e] Animated (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: +1/+1 and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA06_03e", new CardDef(new Power
			{
				// TODO [LOEA06_03e] Animated && Test: Animated_LOEA06_03e
				InfoCardId = "LOEA06_03eh",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOEA06_03e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOEA06_03eh] Animated (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: +3/+3 and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA06_03eh", new CardDef(new Power
			{
				// TODO [LOEA06_03eh] Animated && Test: Animated_LOEA06_03eh
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOEA06_03eh")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOEA09_2e] Enraged (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: +2 Attack
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_2e", new CardDef(new Power
			{
				// TODO [LOEA09_2e] Enraged && Test: Enraged_LOEA09_2e
				InfoCardId = "LOEA09_2eH",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOEA09_2e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOEA09_2eH] Enraged (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: +5 Attack
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_2eH", new CardDef(new Power
			{
				// TODO [LOEA09_2eH] Enraged && Test: Enraged_LOEA09_2eH
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOEA09_2eH")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOEA09_3a] Famished (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Quite Hungry.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_3a", new CardDef(new Power
			{
				// TODO [LOEA09_3a] Famished && Test: Famished_LOEA09_3a
				InfoCardId = "LOEA09_3aH",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOEA09_3a")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOEA09_3aH] Famished (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Quite Hungry.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_3aH", new CardDef(new Power
			{
				// TODO [LOEA09_3aH] Famished && Test: Famished_LOEA09_3aH
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOEA09_3aH")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOEA09_7e] Cauldron (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_7e", new CardDef(new Power
			{
				// TODO [LOEA09_7e] Cauldron && Test: Cauldron_LOEA09_7e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOEA09_7e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOEA16_20e] Blessed (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Immune</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_20e", new CardDef(new Power
			{
				// TODO [LOEA16_20e] Blessed && Test: Blessed_LOEA16_20e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOEA16_20e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOEA16_20H] Blessing of the Sun (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Immune</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_20H", new CardDef(new Power
			{
				// TODO [LOEA16_20H] Blessing of the Sun && Test: Blessing of the Sun_LOEA16_20H
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOEA16_20H")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOEA16_21e] Scarvashed (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Costs (1) more.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_21e", new CardDef(new Power
			{
				// TODO [LOEA16_21e] Scarvashed && Test: Scarvashed_LOEA16_21e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOEA16_21e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOEA16_21He] Heroic Scarvashed (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Costs (2) more.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_21He", new CardDef(new Power
			{
				// TODO [LOEA16_21He] Heroic Scarvashed && Test: Heroic Scarvashed_LOEA16_21He
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOEA16_21He")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOEA16_3e] Lantern of Power (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: +10/+10.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_3e", new CardDef(new Power
			{
				// TODO [LOEA16_3e] Lantern of Power && Test: Lantern of Power_LOEA16_3e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOEA16_3e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [LOEA16_8a] Putressed (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Attack and Health swapped.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_8a", new CardDef(new Power
			{
				// TODO [LOEA16_8a] Putressed && Test: Putressed_LOEA16_8a
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("LOEA16_8a")
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA01_11] Rod of the Sun (*) - COST:0 [ATK:0/HP:5]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Surrender this to your opponent.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA01_11", new CardDef(new Power
			{
				// TODO [LOEA01_11] Rod of the Sun && Test: Rod of the Sun_LOEA01_11
				InfoCardId = "LOEA01_11he",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA01_11h] Rod of the Sun (*) - COST:0 [ATK:0/HP:5]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Surrender this to your opponent.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA01_11h", new CardDef(new Power
			{
				// TODO [LOEA01_11h] Rod of the Sun && Test: Rod of the Sun_LOEA01_11h
				InfoCardId = "LOEA01_11he",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA01_12] Tol'vir Hoplite (*) - COST:3 [ATK:5/HP:2]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Deal 5 damage to both heroes.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA01_12", new CardDef(new Power
			{
				// TODO [LOEA01_12] Tol'vir Hoplite && Test: Tol'vir Hoplite_LOEA01_12
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA01_12h] Tol'vir Hoplite (*) - COST:3 [ATK:5/HP:5]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Deal 5 damage to both heroes.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA01_12h", new CardDef(new Power
			{
				// TODO [LOEA01_12h] Tol'vir Hoplite && Test: Tol'vir Hoplite_LOEA01_12h
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA04_13bt] Orsis Guard (*) - COST:4 [ATK:7/HP:5]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA04_13bt", new CardDef(new Power
			{
				// TODO [LOEA04_13bt] Orsis Guard && Test: Orsis Guard_LOEA04_13bt
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA04_13bth] Orsis Guard (*) - COST:4 [ATK:8/HP:8]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA04_13bth", new CardDef(new Power
			{
				// TODO [LOEA04_13bth] Orsis Guard && Test: Orsis Guard_LOEA04_13bth
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA04_23] Giant Insect (*) - COST:7 [ATK:10/HP:3]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA04_23", new CardDef(new Power
			{
				// TODO [LOEA04_23] Giant Insect && Test: Giant Insect_LOEA04_23
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA04_23h] Giant Insect (*) - COST:7 [ATK:10/HP:6]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA04_23h", new CardDef(new Power
			{
				// TODO [LOEA04_23h] Giant Insect && Test: Giant Insect_LOEA04_23h
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA04_24] Anubisath Temple Guard (*) - COST:8 [ATK:5/HP:10]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA04_24", new CardDef(new Power
			{
				// TODO [LOEA04_24] Anubisath Temple Guard && Test: Anubisath Temple Guard_LOEA04_24
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA04_24h] Anubisath Temple Guard (*) - COST:8 [ATK:6/HP:15]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA04_24h", new CardDef(new Power
			{
				// TODO [LOEA04_24h] Anubisath Temple Guard && Test: Anubisath Temple Guard_LOEA04_24h
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA04_25] Seething Statue (*) - COST:8 [ATK:0/HP:9]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: At the end of your turn, deal 2 damage to all enemies.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA04_25", new CardDef(new Power
			{
				// TODO [LOEA04_25] Seething Statue && Test: Seething Statue_LOEA04_25
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA04_25h] Seething Statue (*) - COST:8 [ATK:5/HP:9]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: At the end of your turn, deal 5 damage to all enemies.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA04_25h", new CardDef(new Power
			{
				// TODO [LOEA04_25h] Seething Statue && Test: Seething Statue_LOEA04_25h
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA04_27] Animated Statue (*) - COST:1 [ATK:10/HP:10]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: You've disturbed the ancient statue...
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA04_27", new CardDef(new Power
			{
				// TODO [LOEA04_27] Animated Statue && Test: Animated Statue_LOEA04_27
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA06_02t] Earthen Statue (*) - COST:1 [ATK:0/HP:2]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA06_02t", new CardDef(new Power
			{
				// TODO [LOEA06_02t] Earthen Statue && Test: Earthen Statue_LOEA06_02t
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA06_02th] Earthen Statue (*) - COST:1 [ATK:0/HP:5]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA06_02th", new CardDef(new Power
			{
				// TODO [LOEA06_02th] Earthen Statue && Test: Earthen Statue_LOEA06_02th
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA07_09] Chasing Trogg (*) - COST:4 [ATK:2/HP:6]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA07_09", new CardDef(new Power
			{
				// TODO [LOEA07_09] Chasing Trogg && Test: Chasing Trogg_LOEA07_09
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA07_11] Debris (*) - COST:1 [ATK:0/HP:3]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Taunt.</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA07_11", new CardDef(new Power
			{
				// TODO [LOEA07_11] Debris && Test: Debris_LOEA07_11
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA07_12] Earthen Pursuer (*) - COST:5 [ATK:4/HP:6]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA07_12", new CardDef(new Power
			{
				// TODO [LOEA07_12] Earthen Pursuer && Test: Earthen Pursuer_LOEA07_12
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA07_14] Lumbering Golem (*) - COST:6 [ATK:6/HP:6]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA07_14", new CardDef(new Power
			{
				// TODO [LOEA07_14] Lumbering Golem && Test: Lumbering Golem_LOEA07_14
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA07_24] Spiked Decoy (*) - COST:1 [ATK:3/HP:6]
			// - Race: mechanical, Set: loe,
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       Can't attack.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - CANT_ATTACK = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA07_24", new CardDef(new Power
			{
				// TODO [LOEA07_24] Spiked Decoy && Test: Spiked Decoy_LOEA07_24
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA07_25] Mechanical Parrot (*) - COST:1 [ATK:3/HP:6]
			// - Race: mechanical, Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA07_25", new CardDef(new Power
			{
				// TODO [LOEA07_25] Mechanical Parrot && Test: Mechanical Parrot_LOEA07_25
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA09_10] Hungry Naga (*) - COST:2 [ATK:2/HP:1]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_10", new CardDef(new Power
			{
				// TODO [LOEA09_10] Hungry Naga && Test: Hungry Naga_LOEA09_10
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA09_11] Hungry Naga (*) - COST:3 [ATK:1/HP:1]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_11", new CardDef(new Power
			{
				// TODO [LOEA09_11] Hungry Naga && Test: Hungry Naga_LOEA09_11
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA09_12] Hungry Naga (*) - COST:4 [ATK:2/HP:1]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_12", new CardDef(new Power
			{
				// TODO [LOEA09_12] Hungry Naga && Test: Hungry Naga_LOEA09_12
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA09_13] Hungry Naga (*) - COST:5 [ATK:5/HP:1]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_13", new CardDef(new Power
			{
				// TODO [LOEA09_13] Hungry Naga && Test: Hungry Naga_LOEA09_13
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA09_5] Hungry Naga (*) - COST:1 [ATK:1/HP:1]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_5", new CardDef(new Power
			{
				// TODO [LOEA09_5] Hungry Naga && Test: Hungry Naga_LOEA09_5
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA09_5H] Hungry Naga (*) - COST:3 [ATK:3/HP:3]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_5H", new CardDef(new Power
			{
				// TODO [LOEA09_5H] Hungry Naga && Test: Hungry Naga_LOEA09_5H
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA09_6] Slithering Archer (*) - COST:2 [ATK:2/HP:2]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 1 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_NONSELF_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOEA09_6", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_NONSELF_TARGET,0}}, new Power
			{
				// TODO [LOEA09_6] Slithering Archer && Test: Slithering Archer_LOEA09_6
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA09_6H] Slithering Archer (*) - COST:2 [ATK:2/HP:2]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 2 damage to all enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_6H", new CardDef(new Power
			{
				// TODO [LOEA09_6H] Slithering Archer && Test: Slithering Archer_LOEA09_6H
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA09_7] Cauldron (*) - COST:0 [ATK:0/HP:5]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Deathrattle:</b> Save Sir Finley and stop the Naga onslaught!
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_7", new CardDef(new Power
			{
				// TODO [LOEA09_7] Cauldron && Test: Cauldron_LOEA09_7
				InfoCardId = "LOEA09_7e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA09_7H] Cauldron (*) - COST:0 [ATK:0/HP:10]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Deathrattle:</b> Save Sir Finley!
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_7H", new CardDef(new Power
			{
				// TODO [LOEA09_7H] Cauldron && Test: Cauldron_LOEA09_7H
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA09_8] Slithering Guard (*) - COST:5 [ATK:3/HP:6]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_8", new CardDef(new Power
			{
				// TODO [LOEA09_8] Slithering Guard && Test: Slithering Guard_LOEA09_8
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA09_8H] Slithering Guard (*) - COST:5 [ATK:5/HP:7]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_8H", new CardDef(new Power
			{
				// TODO [LOEA09_8H] Slithering Guard && Test: Slithering Guard_LOEA09_8H
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA15_3] Boneraptor (*) - COST:3 [ATK:2/HP:2]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b>Take control of your opponent's weapon.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA15_3", new CardDef(new Power
			{
				// TODO [LOEA15_3] Boneraptor && Test: Boneraptor_LOEA15_3
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA15_3H] Boneraptor (*) - COST:3 [ATK:2/HP:2]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b>Take control of your opponent's weapon.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA15_3H", new CardDef(new Power
			{
				// TODO [LOEA15_3H] Boneraptor && Test: Boneraptor_LOEA15_3H
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_17] Animated Statue (*) - COST:10 [ATK:10/HP:10]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_17", new CardDef(new Power
			{
				// TODO [LOEA16_17] Animated Statue && Test: Animated Statue_LOEA16_17
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_18] Zinaar (*) - COST:5 [ATK:5/HP:5]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: At the end of your turn, gain a wish.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_18", new CardDef(new Power
			{
				// TODO [LOEA16_18] Zinaar && Test: Zinaar_LOEA16_18
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_18H] Zinaar (*) - COST:10 [ATK:10/HP:10]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: At the end of your turn, gain a wish.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_18H", new CardDef(new Power
			{
				// TODO [LOEA16_18H] Zinaar && Test: Zinaar_LOEA16_18H
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_19] Sun Raider Phaerix (*) - COST:5 [ATK:5/HP:5]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: At the end of your turn, add a Blessing of the Sun to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_19", new CardDef(new Power
			{
				// TODO [LOEA16_19] Sun Raider Phaerix && Test: Sun Raider Phaerix_LOEA16_19
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_19H] Sun Raider Phaerix (*) - COST:10 [ATK:10/HP:10]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Your other minions are <b>Immune</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - AURA = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_19H", new CardDef(new Power
			{
				// TODO [LOEA16_19H] Sun Raider Phaerix && Test: Sun Raider Phaerix_LOEA16_19H
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_21] Chieftain Scarvash (*) - COST:5 [ATK:5/HP:5]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Enemy cards cost (1) more.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - AURA = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_21", new CardDef(new Power
			{
				// TODO [LOEA16_21] Chieftain Scarvash && Test: Chieftain Scarvash_LOEA16_21
				InfoCardId = "LOEA16_21e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_21H] Chieftain Scarvash (*) - COST:10 [ATK:10/HP:10]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Enemy cards cost (2) more.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - AURA = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_21H", new CardDef(new Power
			{
				// TODO [LOEA16_21H] Chieftain Scarvash && Test: Chieftain Scarvash_LOEA16_21H
				InfoCardId = "LOEA16_21He",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_22] Archaedas (*) - COST:5 [ATK:5/HP:5]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: At the end of your turn, turn a random enemy minion into a 0/2 Statue.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_22", new CardDef(new Power
			{
				// TODO [LOEA16_22] Archaedas && Test: Archaedas_LOEA16_22
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_22H] Archaedas (*) - COST:10 [ATK:10/HP:10]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: At the end of your turn, turn a random enemy minion into a 0/2 Statue.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_22H", new CardDef(new Power
			{
				// TODO [LOEA16_22H] Archaedas && Test: Archaedas_LOEA16_22H
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_23] Lord Slitherspear (*) - COST:5 [ATK:5/HP:5]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: At the end of your turn, summon 1/1 Hungry Naga for each enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_23", new CardDef(new Power
			{
				// TODO [LOEA16_23] Lord Slitherspear && Test: Lord Slitherspear_LOEA16_23
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_23H] Lord Slitherspear (*) - COST:10 [ATK:10/HP:10]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: At the end of your turn, summon 1/1 Hungry Naga for each enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_23H", new CardDef(new Power
			{
				// TODO [LOEA16_23H] Lord Slitherspear && Test: Lord Slitherspear_LOEA16_23H
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_24] Giantfin (*) - COST:5 [ATK:5/HP:5]
			// - Race: murloc, Set: loe,
			// --------------------------------------------------------
			// Text: At the end of your turn, draw until you have as many cards as your opponent.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_24", new CardDef(new Power
			{
				// TODO [LOEA16_24] Giantfin && Test: Giantfin_LOEA16_24
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_24H] Giantfin (*) - COST:10 [ATK:10/HP:10]
			// - Race: murloc, Set: loe,
			// --------------------------------------------------------
			// Text: At the end of your turn, draw 2 cards.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_24H", new CardDef(new Power
			{
				// TODO [LOEA16_24H] Giantfin && Test: Giantfin_LOEA16_24H
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_25] Lady Naz'jar (*) - COST:5 [ATK:5/HP:5]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: At the end of your turn, replace all other minions with new ones of the same Cost.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_25", new CardDef(new Power
			{
				// TODO [LOEA16_25] Lady Naz'jar && Test: Lady Naz'jar_LOEA16_25
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_25H] Lady Naz'jar (*) - COST:10 [ATK:10/HP:10]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: At the end of your turn, replace all other minions with new ones of the same Cost.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_25H", new CardDef(new Power
			{
				// TODO [LOEA16_25H] Lady Naz'jar && Test: Lady Naz'jar_LOEA16_25H
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_26] Skelesaurus Hex (*) - COST:5 [ATK:5/HP:5]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: At the end of your turn, give each player a random card. It costs (0).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_26", new CardDef(new Power
			{
				// TODO [LOEA16_26] Skelesaurus Hex && Test: Skelesaurus Hex_LOEA16_26
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_26H] Skelesaurus Hex (*) - COST:10 [ATK:10/HP:10]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: At the end of your turn, put a random card in your hand. It costs (0).
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_26H", new CardDef(new Power
			{
				// TODO [LOEA16_26H] Skelesaurus Hex && Test: Skelesaurus Hex_LOEA16_26H
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_27] The Steel Sentinel (*) - COST:5 [ATK:5/HP:5]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: This minion can only take 1 damage at a time.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_27", new CardDef(new Power
			{
				// TODO [LOEA16_27] The Steel Sentinel && Test: The Steel Sentinel_LOEA16_27
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_27H] The Steel Sentinel (*) - COST:10 [ATK:10/HP:10]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: This minion can only take 1 damage at a time.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_27H", new CardDef(new Power
			{
				// TODO [LOEA16_27H] The Steel Sentinel && Test: The Steel Sentinel_LOEA16_27H
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [LOEA16_5t] Mummy Zombie (*) - COST:3 [ATK:3/HP:3]
			// - Set: loe,
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_5t", new CardDef(new Power
			{
				// TODO [LOEA16_5t] Mummy Zombie && Test: Mummy Zombie_LOEA16_5t
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA02_03] Wish for Power (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Discover</b> a spell.
			// --------------------------------------------------------
			// GameTag:
			// - DISCOVER = 1
			// - HIDE_WATERMARK = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			cards.Add("LOEA02_03", new CardDef(new Power
			{
				// TODO [LOEA02_03] Wish for Power && Test: Wish for Power_LOEA02_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA02_04] Wish for Valor (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Discover</b> a (4)-Cost card.
			// --------------------------------------------------------
			// GameTag:
			// - DISCOVER = 1
			// - HIDE_WATERMARK = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			cards.Add("LOEA02_04", new CardDef(new Power
			{
				// TODO [LOEA02_04] Wish for Valor && Test: Wish for Valor_LOEA02_04
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA02_05] Wish for Glory (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Discover</b> a minion.
			// --------------------------------------------------------
			// GameTag:
			// - DISCOVER = 1
			// - HIDE_WATERMARK = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			cards.Add("LOEA02_05", new CardDef(new Power
			{
				// TODO [LOEA02_05] Wish for Glory && Test: Wish for Glory_LOEA02_05
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA02_06] Wish for More Wishes (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Gain 2 Wishes.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA02_06", new CardDef(new Power
			{
				// TODO [LOEA02_06] Wish for More Wishes && Test: Wish for More Wishes_LOEA02_06
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA02_10] Wish for Companionship (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Discover</b> a Companion.
			// --------------------------------------------------------
			// GameTag:
			// - DISCOVER = 1
			// - HIDE_WATERMARK = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			cards.Add("LOEA02_10", new CardDef(new Power
			{
				// TODO [LOEA02_10] Wish for Companionship && Test: Wish for Companionship_LOEA02_10
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA04_06] Pit of Spikes (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Choose Your Path!</b>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA04_06", new CardDef(new Power
			{
				// TODO [LOEA04_06] Pit of Spikes && Test: Pit of Spikes_LOEA04_06
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA04_06a] Swing Across (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Take 10 damage or no damage, at random.
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA04_06a", new CardDef(new Power
			{
				// TODO [LOEA04_06a] Swing Across && Test: Swing Across_LOEA04_06a
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA04_06b] Walk Across Gingerly (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Take 5 damage.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA04_06b", new CardDef(new Power
			{
				// TODO [LOEA04_06b] Walk Across Gingerly && Test: Walk Across Gingerly_LOEA04_06b
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA04_28] A Glowing Pool (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Drink?</b>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA04_28", new CardDef(new Power
			{
				// TODO [LOEA04_28] A Glowing Pool && Test: A Glowing Pool_LOEA04_28
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA04_28a] Drink Deeply (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA04_28a", new CardDef(new Power
			{
				// TODO [LOEA04_28a] Drink Deeply && Test: Drink Deeply_LOEA04_28a
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA04_28b] Wade Through (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Gain a Mana Crystal
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA04_28b", new CardDef(new Power
			{
				// TODO [LOEA04_28b] Wade Through && Test: Wade Through_LOEA04_28b
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA04_29] The Eye (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Choose Your Path!</b>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA04_29", new CardDef(new Power
			{
				// TODO [LOEA04_29] The Eye && Test: The Eye_LOEA04_29
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA04_29a] Touch It (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Restore 10 Health to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA04_29a", new CardDef(new Power
			{
				// TODO [LOEA04_29a] Touch It && Test: Touch It_LOEA04_29a
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA04_29b] Investigate the Runes (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Draw 2 cards.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA04_29b", new CardDef(new Power
			{
				// TODO [LOEA04_29b] Investigate the Runes && Test: Investigate the Runes_LOEA04_29b
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA04_30] The Darkness (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Take the Shortcut?</b>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA04_30", new CardDef(new Power
			{
				// TODO [LOEA04_30] The Darkness && Test: The Darkness_LOEA04_30
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA04_30a] Take the Shortcut (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Get 1 turn closer to the Exit! Encounter a 7/7 War Golem.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA04_30a", new CardDef(new Power
			{
				// TODO [LOEA04_30a] Take the Shortcut && Test: Take the Shortcut_LOEA04_30a
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA04_31b] No Way! (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Do nothing.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA04_31b", new CardDef(new Power
			{
				// TODO [LOEA04_31b] No Way! && Test: No Way!_LOEA04_31b
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA06_03] Animate Earthen (*) - COST:2
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Give your minions +1/+1 and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_TOTAL_MINIONS = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOEA06_03", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINIMUM_TOTAL_MINIONS,1}}, new Power
			{
				// TODO [LOEA06_03] Animate Earthen && Test: Animate Earthen_LOEA06_03
				InfoCardId = "LOEA06_03e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA06_03h] Animate Earthen (*) - COST:2
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Give your minions +3/+3 and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("LOEA06_03h", new CardDef(new Power
			{
				// TODO [LOEA06_03h] Animate Earthen && Test: Animate Earthen_LOEA06_03h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA06_04] Shattering Spree (*) - COST:2
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Destroy all Statues. For each destroyed, deal 1 damage. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("LOEA06_04", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [LOEA06_04] Shattering Spree && Test: Shattering Spree_LOEA06_04
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA06_04h] Shattering Spree (*) - COST:2
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Destroy all Statues. For each destroyed, deal 3 damage. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("LOEA06_04h", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [LOEA06_04h] Shattering Spree && Test: Shattering Spree_LOEA06_04h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA07_18] Dynamite (*) - COST:1
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Deal $10 damage. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("LOEA07_18", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [LOEA07_18] Dynamite && Test: Dynamite_LOEA07_18
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA07_20] Boom! (*) - COST:1
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Deal $3 damage to all enemy minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA07_20", new CardDef(new Power
			{
				// TODO [LOEA07_20] Boom! && Test: Boom!_LOEA07_20
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA07_21] Barrel Forward (*) - COST:1
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Get 1 turn closer to the Exit!
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA07_21", new CardDef(new Power
			{
				// TODO [LOEA07_21] Barrel Forward && Test: Barrel Forward_LOEA07_21
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA07_26] Consult Brann (*) - COST:1
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Draw 3 cards.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA07_26", new CardDef(new Power
			{
				// TODO [LOEA07_26] Consult Brann && Test: Consult Brann_LOEA07_26
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA07_28] Repairs (*) - COST:1
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Restore #10 Health.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("LOEA07_28", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [LOEA07_28] Repairs && Test: Repairs_LOEA07_28
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA09_9] Naga Repellent (*) - COST:1
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Destroy all Hungry Naga.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_9", new CardDef(new Power
			{
				// TODO [LOEA09_9] Naga Repellent && Test: Naga Repellent_LOEA09_9
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA09_9H] Naga Repellent (*) - COST:1
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Change the Attack of all Hungry Naga to 1.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_9H", new CardDef(new Power
			{
				// TODO [LOEA09_9H] Naga Repellent && Test: Naga Repellent_LOEA09_9H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA10_5] Mrgl Mrgl Nyah Nyah (*) - COST:5
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: Summon 3 Murlocs that died this game.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA10_5", new CardDef(new Power
			{
				// TODO [LOEA10_5] Mrgl Mrgl Nyah Nyah && Test: Mrgl Mrgl Nyah Nyah_LOEA10_5
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA10_5H] Mrgl Mrgl Nyah Nyah (*) - COST:3
			// - Set: loe, Rarity: common
			// --------------------------------------------------------
			// Text: Summon 5 Murlocs that died this game.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA10_5H", new CardDef(new Power
			{
				// TODO [LOEA10_5H] Mrgl Mrgl Nyah Nyah && Test: Mrgl Mrgl Nyah Nyah_LOEA10_5H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA16_10] Hakkari Blood Goblet (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Transform a minion into a 2/1 Pit Snake.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOEA16_10", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [LOEA16_10] Hakkari Blood Goblet && Test: Hakkari Blood Goblet_LOEA16_10
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA16_11] Crown of Kael'thas (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Deal $10 damage randomly split among ALL characters. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_11", new CardDef(new Power
			{
				// TODO [LOEA16_11] Crown of Kael'thas && Test: Crown of Kael'thas_LOEA16_11
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA16_12] Medivh's Locket (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Replace your hand with Unstable Portals.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_12", new CardDef(new Power
			{
				// TODO [LOEA16_12] Medivh's Locket && Test: Medivh's Locket_LOEA16_12
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA16_13] Eye of Orsis (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: <b>Discover</b> a minion and gain 3 copies of it.
			// --------------------------------------------------------
			// GameTag:
			// - DISCOVER = 1
			// - HIDE_WATERMARK = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_13", new CardDef(new Power
			{
				// TODO [LOEA16_13] Eye of Orsis && Test: Eye of Orsis_LOEA16_13
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA16_14] Khadgar's Pipe (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Put a random spell into each player's hand.  Yours costs (0).
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_14", new CardDef(new Power
			{
				// TODO [LOEA16_14] Khadgar's Pipe && Test: Khadgar's Pipe_LOEA16_14
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA16_15] Ysera's Tear (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Gain 4 Mana Crystals this turn only.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_15", new CardDef(new Power
			{
				// TODO [LOEA16_15] Ysera's Tear && Test: Ysera's Tear_LOEA16_15
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA16_20] Blessing of the Sun (*) - COST:1
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Give a minion <b>Immune</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_20", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [LOEA16_20] Blessing of the Sun && Test: Blessing of the Sun_LOEA16_20
				InfoCardId = "LOEA16_20e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA16_3] Lantern of Power (*) - COST:10
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Give a minion +10/+10.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("LOEA16_3", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [LOEA16_3] Lantern of Power && Test: Lantern of Power_LOEA16_3
				InfoCardId = "LOEA16_3e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA16_4] Timepiece of Horror (*) - COST:10
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Deal $10 damage randomly split among all enemies. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - ImmuneToSpellpower = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_4", new CardDef(new Power
			{
				// TODO [LOEA16_4] Timepiece of Horror && Test: Timepiece of Horror_LOEA16_4
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA16_5] Mirror of Doom (*) - COST:10
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Fill your board with 3/3 Mummy Zombies.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_5", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [LOEA16_5] Mirror of Doom && Test: Mirror of Doom_LOEA16_5
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA16_6] Shard of Sulfuras (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Deal $5 damage to ALL characters. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_6", new CardDef(new Power
			{
				// TODO [LOEA16_6] Shard of Sulfuras && Test: Shard of Sulfuras_LOEA16_6
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA16_7] Benediction Splinter (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Restore #10 Health to ALL characters.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_7", new CardDef(new Power
			{
				// TODO [LOEA16_7] Benediction Splinter && Test: Benediction Splinter_LOEA16_7
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA16_8] Putress' Vial (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Destroy a random enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_8", new CardDef(new Power
			{
				// TODO [LOEA16_8] Putress' Vial && Test: Putress' Vial_LOEA16_8
				InfoCardId = "LOEA16_8a",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA16_9] Lothar's Left Greave (*) - COST:0
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Deal $3 damage to all enemies. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA16_9", new CardDef(new Power
			{
				// TODO [LOEA16_9] Lothar's Left Greave && Test: Lothar's Left Greave_LOEA16_9
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA_01] Looming Presence (*) - COST:3
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Draw 2 cards. Gain 4 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA_01", new CardDef(new Power
			{
				// TODO [LOEA_01] Looming Presence && Test: Looming Presence_LOEA_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [LOEA_01H] Looming Presence (*) - COST:3
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Draw 3 cards. Gain 6 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA_01H", new CardDef(new Power
			{
				// TODO [LOEA_01H] Looming Presence && Test: Looming Presence_LOEA_01H
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- WEAPON - NEUTRAL
			// [LOEA09_4] Rare Spear (*) - COST:1 [ATK:1/HP:0]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Whenever your opponent plays a Rare card, gain +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_4", new CardDef(new Power
			{
				// TODO [LOEA09_4] Rare Spear && Test: Rare Spear_LOEA09_4
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- WEAPON - NEUTRAL
			// [LOEA09_4H] Rare Spear (*) - COST:1 [ATK:1/HP:0]
			// - Set: loe,
			// --------------------------------------------------------
			// Text: Whenever your opponent plays a Rare card, gain +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("LOEA09_4H", new CardDef(new Power
			{
				// TODO [LOEA09_4H] Rare Spear && Test: Rare Spear_LOEA09_4H
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		public static void AddAll(Dictionary<string, CardDef> cards)
		{
			Heroes(cards);
			HeroPowers(cards);
			HunterNonCollect(cards);
			Neutral(cards);
			NeutralNonCollect(cards);
		}
	}
}
