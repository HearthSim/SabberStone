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
	public class KaraCardsGenAdv
	{
		private static void Heroes(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------------- HERO - NEUTRAL
			// [KAR_A01_01] Magic Mirror (*) - COST:0 [ATK:0/HP:30]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39632
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A01_01", new CardDef(new Power
			{
				// TODO [KAR_A01_01] Magic Mirror && Test: Magic Mirror_KAR_A01_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [KAR_A01_01H] Magic Mirror (*) - COST:0 [ATK:0/HP:30]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 40085
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A01_01H", new CardDef(new Power
			{
				// TODO [KAR_A01_01H] Magic Mirror && Test: Magic Mirror_KAR_A01_01H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [KAR_A02_12] Silverware Golem (*) - COST:0 [ATK:0/HP:30]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39725
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_12", new CardDef(new Power
			{
				// TODO [KAR_A02_12] Silverware Golem && Test: Silverware Golem_KAR_A02_12
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [KAR_A02_12H] Silverware Golem (*) - COST:0 [ATK:0/HP:30]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 40083
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_12H", new CardDef(new Power
			{
				// TODO [KAR_A02_12H] Silverware Golem && Test: Silverware Golem_KAR_A02_12H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [KAR_a10_Boss1] White King (*) - COST:0 [ATK:0/HP:20]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39544
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KAR_a10_Boss1", new CardDef(new Power
			{
				// TODO [KAR_a10_Boss1] White King && Test: White King_KAR_a10_Boss1
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [KAR_a10_Boss1H] White King (*) - COST:0 [ATK:0/HP:20]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 40086
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KAR_a10_Boss1H", new CardDef(new Power
			{
				// TODO [KAR_a10_Boss1H] White King && Test: White King_KAR_a10_Boss1H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [KAR_a10_Boss2] Black King (*) - COST:0 [ATK:0/HP:20]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39801
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KAR_a10_Boss2", new CardDef(new Power
			{
				// TODO [KAR_a10_Boss2] Black King && Test: Black King_KAR_a10_Boss2
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [KAR_a10_Boss2H] Black King (*) - COST:0 [ATK:0/HP:20]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39801
			// - CANT_BE_FATIGUED = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KAR_a10_Boss2H", new CardDef(new Power
			{
				// TODO [KAR_a10_Boss2H] Black King && Test: Black King_KAR_a10_Boss2H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [KARA_00_01] Prince Malchezaar (*) - COST:0 [ATK:0/HP:30]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39753
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_00_01", new CardDef(new Power
			{
				// TODO [KARA_00_01] Prince Malchezaar && Test: Prince Malchezaar_KARA_00_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [KARA_00_01H] Prince Malchezaar (*) - COST:0 [ATK:0/HP:60]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 40080
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_00_01H", new CardDef(new Power
			{
				// TODO [KARA_00_01H] Prince Malchezaar && Test: Prince Malchezaar_KARA_00_01H
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [KARA_00_03] Medivh (*) - COST:0 [ATK:0/HP:30]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 40081
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_00_03", new CardDef(new Power
			{
				// TODO [KARA_00_03] Medivh && Test: Medivh_KARA_00_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [KARA_00_03c] Medivh (*) - COST:0
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_00_03c", new CardDef(new Power
			{
				// TODO [KARA_00_03c] Medivh && Test: Medivh_KARA_00_03c
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [KARA_00_03H] Medivh (*) - COST:0 [ATK:0/HP:30]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39756
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_00_03H", new CardDef(new Power
			{
				// TODO [KARA_00_03H] Medivh && Test: Medivh_KARA_00_03H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [KARA_04_01h] The Crone (*) - COST:0 [ATK:0/HP:30]
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39281
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_04_01h", new CardDef(new Power
			{
				// TODO [KARA_04_01h] The Crone && Test: The Crone_KARA_04_01h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [KARA_04_01heroic] The Crone (*) - COST:0 [ATK:0/HP:50]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39281
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_04_01heroic", new CardDef(new Power
			{
				// TODO [KARA_04_01heroic] The Crone && Test: The Crone_KARA_04_01heroic
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [KARA_05_01b] Kindly Grandmother (*) - COST:0 [ATK:0/HP:20]
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39298
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_05_01b", new CardDef(new Power
			{
				// TODO [KARA_05_01b] Kindly Grandmother && Test: Kindly Grandmother_KARA_05_01b
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [KARA_05_01h] Big Bad Wolf (*) - COST:0 [ATK:0/HP:20]
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39298
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_05_01h", new CardDef(new Power
			{
				// TODO [KARA_05_01h] Big Bad Wolf && Test: Big Bad Wolf_KARA_05_01h
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [KARA_05_01hheroic] Big Bad Wolf (*) - COST:0 [ATK:0/HP:20]
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 40266
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_05_01hheroic", new CardDef(new Power
			{
				// TODO [KARA_05_01hheroic] Big Bad Wolf && Test: Big Bad Wolf_KARA_05_01hheroic
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [KARA_06_02] Julianne (*) - COST:0 [ATK:0/HP:15]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39563
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_06_02", new CardDef(new Power
			{
				// TODO [KARA_06_02] Julianne && Test: Julianne_KARA_06_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [KARA_06_02heroic] Julianne (*) - COST:0 [ATK:0/HP:15]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 40276
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_06_02heroic", new CardDef(new Power
			{
				// TODO [KARA_06_02heroic] Julianne && Test: Julianne_KARA_06_02heroic
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [KARA_07_01] Curator (*) - COST:0 [ATK:0/HP:30]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39641
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_07_01", new CardDef(new Power
			{
				// TODO [KARA_07_01] Curator && Test: Curator_KARA_07_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [KARA_07_01heroic] Curator (*) - COST:0 [ATK:0/HP:40]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39641
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_07_01heroic", new CardDef(new Power
			{
				// TODO [KARA_07_01heroic] Curator && Test: Curator_KARA_07_01heroic
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [KARA_08_01] Netherspite (*) - COST:0 [ATK:0/HP:30]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39680
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_08_01", new CardDef(new Power
			{
				// TODO [KARA_08_01] Netherspite && Test: Netherspite_KARA_08_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [KARA_08_01H] Netherspite (*) - COST:0 [ATK:0/HP:30]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 40062
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_08_01H", new CardDef(new Power
			{
				// TODO [KARA_08_01H] Netherspite && Test: Netherspite_KARA_08_01H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [KARA_09_01] Terestian Illhoof (*) - COST:0 [ATK:0/HP:30]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39645
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_09_01", new CardDef(new Power
			{
				// TODO [KARA_09_01] Terestian Illhoof && Test: Terestian Illhoof_KARA_09_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [KARA_09_01heroic] Terestian Illhoof (*) - COST:0 [ATK:0/HP:40]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39645
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_09_01heroic", new CardDef(new Power
			{
				// TODO [KARA_09_01heroic] Terestian Illhoof && Test: Terestian Illhoof_KARA_09_01heroic
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [KARA_09_02] Curator (*) - COST:0 [ATK:0/HP:30]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39645
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_09_02", new CardDef(new Power
			{
				// TODO [KARA_09_02] Curator && Test: Curator_KARA_09_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [KARA_11_01] Nightbane (*) - COST:0 [ATK:0/HP:30]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39667
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_11_01", new CardDef(new Power
			{
				// TODO [KARA_11_01] Nightbane && Test: Nightbane_KARA_11_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [KARA_11_01heroic] Nightbane (*) - COST:0 [ATK:0/HP:30]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39667
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_11_01heroic", new CardDef(new Power
			{
				// TODO [KARA_11_01heroic] Nightbane && Test: Nightbane_KARA_11_01heroic
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [KARA_12_01] Shade of Aran (*) - COST:0 [ATK:0/HP:30]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39669
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_12_01", new CardDef(new Power
			{
				// TODO [KARA_12_01] Shade of Aran && Test: Shade of Aran_KARA_12_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// -------------------------------------------- HERO - MAGE
			// [KARA_12_01H] Shade of Aran (*) - COST:0 [ATK:0/HP:30]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 40107
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_12_01H", new CardDef(new Power
			{
				// TODO [KARA_12_01H] Shade of Aran && Test: Shade of Aran_KARA_12_01H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [KARA_13_01] Nazra Wildaxe (*) - COST:0 [ATK:0/HP:15]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39771
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_13_01", new CardDef(new Power
			{
				// TODO [KARA_13_01] Nazra Wildaxe && Test: Nazra Wildaxe_KARA_13_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - WARRIOR
			// [KARA_13_01H] Nazra Wildaxe (*) - COST:0 [ATK:0/HP:15]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 40733
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_13_01H", new CardDef(new Power
			{
				// TODO [KARA_13_01H] Nazra Wildaxe && Test: Nazra Wildaxe_KARA_13_01H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [KARA_13_06] Prince Malchezaar (*) - COST:0 [ATK:0/HP:30]
			// - Race: demon, Set: kara,
			// --------------------------------------------------------
			// Entourage: KAR_073, KAR_075, KAR_076, KAR_077, KAR_091
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 40563
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_13_06", new CardDef(new[] {"KAR_073","KAR_075","KAR_076","KAR_077","KAR_091"}, new Power
			{
				// TODO [KARA_13_06] Prince Malchezaar && Test: Prince Malchezaar_KARA_13_06
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------------- HERO - NEUTRAL
			// [KARA_13_06H] Prince Malchezaar (*) - COST:0 [ATK:0/HP:30]
			// - Race: demon, Set: kara,
			// --------------------------------------------------------
			// Entourage: KAR_073, KAR_075, KAR_076, KAR_077, KAR_091
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 40763
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_13_06H", new CardDef(new[] {"KAR_073","KAR_075","KAR_076","KAR_077","KAR_091"}, new Power
			{
				// TODO [KARA_13_06H] Prince Malchezaar && Test: Prince Malchezaar_KARA_13_06H
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void HeroPowers(IDictionary<string, CardDef> cards)
		{
			// ----------------------------------- HERO_POWER - NEUTRAL
			// [KAR_A01_02] Reflections (*) - COST:0
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Whenever a minion is played, summon a 1/1 copy of it.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A01_02", new CardDef(new Power
			{
				// TODO [KAR_A01_02] Reflections && Test: Reflections_KAR_A01_02
				InfoCardId = "KAR_A01_02e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [KAR_A01_02H] Reflections (*) - COST:0
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Whenever a minion is played, Magic Mirror summons a 1/1 copy of it.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A01_02H", new CardDef(new Power
			{
				// TODO [KAR_A01_02H] Reflections && Test: Reflections_KAR_A01_02H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [KAR_A02_13] Be Our Guest (*) - COST:0
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a 1/1 Plate.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_13", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [KAR_A02_13] Be Our Guest && Test: Be Our Guest_KAR_A02_13
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [KAR_A02_13H] Be Our Guest (*) - COST:0
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon two 1/1 Plates.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_13H", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [KAR_A02_13H] Be Our Guest && Test: Be Our Guest_KAR_A02_13H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [KAR_A10_22] Castle (*) - COST:2
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       <b>Discover</b> a chess piece.
			// --------------------------------------------------------
			// Entourage: KAR_A10_09, KAR_A10_02, KAR_A10_08, KAR_A10_04, KAR_A10_05
			// --------------------------------------------------------
			// GameTag:
			// - DISCOVER = 1
			// - HIDE_WATERMARK = 1
			// - USE_DISCOVER_VISUALS = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_22", new CardDef(new[] {"KAR_A10_09","KAR_A10_02","KAR_A10_08","KAR_A10_04","KAR_A10_05"}, new Power
			{
				// TODO [KAR_A10_22] Castle && Test: Castle_KAR_A10_22
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [KAR_A10_22H] Castle (*) - COST:1
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Move a friendly minion left. Repeatable.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("KAR_A10_22H", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_FRIENDLY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [KAR_A10_22H] Castle && Test: Castle_KAR_A10_22H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [KAR_A10_33] Cheat (*) - COST:2
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Destroy the left-most enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_33", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINIMUM_ENEMY_MINIONS,1}}, new Power
			{
				// TODO [KAR_A10_33] Cheat && Test: Cheat_KAR_A10_33
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [KARA_00_02] Legion (*) - COST:2
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a 6/6 Abyssal.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_00_02", new CardDef(new Power
			{
				// TODO [KARA_00_02] Legion && Test: Legion_KARA_00_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [KARA_00_02H] Legion (*) - COST:2
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a 6/6 Abyssal.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_00_02H", new CardDef(new Power
			{
				// TODO [KARA_00_02H] Legion && Test: Legion_KARA_00_02H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [KARA_00_04] Brilliance (*) - COST:2
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Draw 3 cards.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_00_04", new CardDef(new Power
			{
				// TODO [KARA_00_04] Brilliance && Test: Brilliance_KARA_00_04
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [KARA_00_04H] Brilliance (*) - COST:2
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Draw 3 cards.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_00_04H", new CardDef(new Power
			{
				// TODO [KARA_00_04H] Brilliance && Test: Brilliance_KARA_00_04H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [KARA_04_02hp] Twister (*) - COST:0
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal 100 damage. Can't be used if Dorothee is alive.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_04_02hp", new CardDef(new Power
			{
				// TODO [KARA_04_02hp] Twister && Test: Twister_KARA_04_02hp
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [KARA_05_01hp] Trembling (*) - COST:0
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b> Enemy minions are 1/1 and cost (1).
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_05_01hp", new CardDef(new Power
			{
				// TODO [KARA_05_01hp] Trembling && Test: Trembling_KARA_05_01hp
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [KARA_05_01hpheroic] Trembling (*) - COST:0
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b> Minions cost (1). Enemy minions are 1/1.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_05_01hpheroic", new CardDef(new Power
			{
				// TODO [KARA_05_01hpheroic] Trembling && Test: Trembling_KARA_05_01hpheroic
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [KARA_06_03hp] True Love (*) - COST:4
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       If you don't have Romulo, summon him.
			// --------------------------------------------------------
			// Entourage: KARA_06_01
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENTIRE_ENTOURAGE_NOT_IN_PLAY = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("KARA_06_03hp", new CardDef(new[] {"KARA_06_01"}, new Dictionary<PlayReq, int>() {{PlayReq.REQ_ENTIRE_ENTOURAGE_NOT_IN_PLAY,0},{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [KARA_06_03hp] True Love && Test: True Love_KARA_06_03hp
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [KARA_06_03hpheroic] True Love (*) - COST:0
			// - Set: kara, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       If you don't have Romulo, summon him.
			// --------------------------------------------------------
			// Entourage: KARA_06_01
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_ENTIRE_ENTOURAGE_NOT_IN_PLAY = 0
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("KARA_06_03hpheroic", new CardDef(new[] {"KARA_06_01"}, new Dictionary<PlayReq, int>() {{PlayReq.REQ_ENTIRE_ENTOURAGE_NOT_IN_PLAY,0},{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [KARA_06_03hpheroic] True Love && Test: True Love_KARA_06_03hpheroic
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [KARA_07_02] Gallery Protection (*) - COST:0
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Your hero has <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_07_02", new CardDef(new Power
			{
				// TODO [KARA_07_02] Gallery Protection && Test: Gallery Protection_KARA_07_02
				InfoCardId = "KARA_07_02e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [KARA_08_02] Nether Rage (*) - COST:2
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give your hero +3 Attack this turn.
			// --------------------------------------------------------
			// Entourage: KARA_08_06, KARA_08_08
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_08_02", new CardDef(new[] {"KARA_08_06","KARA_08_08"}, new Power
			{
				// TODO [KARA_08_02] Nether Rage && Test: Nether Rage_KARA_08_02
				InfoCardId = "KARA_08_02e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [KARA_08_02H] Nether Rage (*) - COST:1
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give your hero +8 Attack this turn.
			// --------------------------------------------------------
			// Entourage: KARA_08_06, KARA_08_08
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_08_02H", new CardDef(new[] {"KARA_08_06","KARA_08_08"}, new Power
			{
				// TODO [KARA_08_02H] Nether Rage && Test: Nether Rage_KARA_08_02H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [KARA_09_04] Dark Pact (*) - COST:0
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Only Icky Imps can damage Illhoof!
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_09_04", new CardDef(new Power
			{
				// TODO [KARA_09_04] Dark Pact && Test: Dark Pact_KARA_09_04
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [KARA_11_02] Manastorm (*) - COST:0
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Players start with 10 Mana Crystals.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_11_02", new CardDef(new Power
			{
				// TODO [KARA_11_02] Manastorm && Test: Manastorm_KARA_11_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [KARA_12_02] Ley Lines (*) - COST:0
			// - Set: kara,
			// --------------------------------------------------------
			// Text: [x]<b>Passive Hero Power</b>
			//       Both players have
			//       <b>Spell Damage +3</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_12_02", new CardDef(new Power
			{
				// TODO [KARA_12_02] Ley Lines && Test: Ley Lines_KARA_12_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [KARA_12_02H] Ley Lines (*) - COST:0
			// - Set: kara,
			// --------------------------------------------------------
			// Text: [x]<b>Passive Hero Power</b>
			//       Both players have
			//       <b>Spell Damage +5</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_12_02H", new CardDef(new Power
			{
				// TODO [KARA_12_02H] Ley Lines && Test: Ley Lines_KARA_12_02H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - WARRIOR
			// [KARA_13_02] The Horde (*) - COST:2
			// - Set: kara,
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Summon a 3/2 Orc.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_13_02", new CardDef(new Power
			{
				// TODO [KARA_13_02] The Horde && Test: The Horde_KARA_13_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - WARRIOR
			// [KARA_13_02H] The Horde (*) - COST:2
			// - Set: kara,
			// --------------------------------------------------------
			// Text: [x]<b>Hero Power</b>
			//       Summon a 3/3 Orc
			//       with <b>Charge</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_13_02H", new CardDef(new Power
			{
				// TODO [KARA_13_02H] The Horde && Test: The Horde_KARA_13_02H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [KARA_13_13] Legion (*) - COST:2
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a 6/6 Abyssal.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_13_13", new CardDef(new Power
			{
				// TODO [KARA_13_13] Legion && Test: Legion_KARA_13_13
				//PowerTask = null,
				//Trigger = null,
			}));

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [KARA_13_13H] Legion (*) - COST:2
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon two 6/6 Abyssals.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_13_13H", new CardDef(new Power
			{
				// TODO [KARA_13_13H] Legion && Test: Legion_KARA_13_13H
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void MageNonCollect(IDictionary<string, CardDef> cards)
		{
			// ------------------------------------------ MINION - MAGE
			// [KARA_00_08] Archmage's Apprentice (*) - COST:2 [ATK:2/HP:4]
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, shuffle a copy of it into your deck.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_00_08", new CardDef(new Power
			{
				// TODO [KARA_00_08] Archmage's Apprentice && Test: Archmage's Apprentice_KARA_00_08
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [KARA_00_05] Archmage's Insight (*) - COST:3
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Your spells cost (0) this turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_00_05", new CardDef(new Power
			{
				// TODO [KARA_00_05] Archmage's Insight && Test: Archmage's Insight_KARA_00_05
				InfoCardId = "KARA_00_05e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [KARA_00_06] Arcane Power (*) - COST:2
			// - Set: kara,
			// --------------------------------------------------------
			// Text: You have <b>Spell Damage</b> +5 this turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("KARA_00_06", new CardDef(new Power
			{
				// TODO [KARA_00_06] Arcane Power && Test: Arcane Power_KARA_00_06
				InfoCardId = "KARA_00_06e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [KARA_00_07] Astral Portal (*) - COST:1
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Summon a random <b>Legendary</b> minion.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("KARA_00_07", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [KARA_00_07] Astral Portal && Test: Astral Portal_KARA_00_07
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [KARA_00_09] Mage Armor (*) - COST:1
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Gain 10 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_00_09", new CardDef(new Power
			{
				// TODO [KARA_00_09] Mage Armor && Test: Mage Armor_KARA_00_09
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [KARA_00_10] Mysterious Rune (*) - COST:3
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Put 5 random Mage <b>Secrets</b> into the battlefield.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_SECRET_ZONE_CAP_FOR_NON_SECRET = 0
			// --------------------------------------------------------
			// RefTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("KARA_00_10", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_SECRET_ZONE_CAP_FOR_NON_SECRET,0}}, new Power
			{
				// TODO [KARA_00_10] Mysterious Rune && Test: Mysterious Rune_KARA_00_10
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [KARA_00_11] Evocation (*) - COST:0
			// - Fac: neutral, Set: kara,
			// --------------------------------------------------------
			// Text: Gain 5 Mana Crystals this turn only.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_00_11", new CardDef(new Power
			{
				// TODO [KARA_00_11] Evocation && Test: Evocation_KARA_00_11
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [KARA_12_03] Flame Wreath (*) - COST:3
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When an enemy attacks, deal 5 damage to all other enemies.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// - ImmuneToSpellpower = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_12_03", new CardDef(new Power
			{
				// TODO [KARA_12_03] Flame Wreath && Test: Flame Wreath_KARA_12_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// ------------------------------------------- SPELL - MAGE
			// [KARA_12_03H] Flame Wreath (*) - COST:3
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When an enemy attacks, deal 10 damage to all other enemies.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// - ImmuneToSpellpower = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_12_03H", new CardDef(new Power
			{
				// TODO [KARA_12_03H] Flame Wreath && Test: Flame Wreath_KARA_12_03H
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void WarlockNonCollect(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - WARLOCK
			// [KARA_00_02a] Abyssal (*) - COST:6 [ATK:6/HP:6]
			// - Race: demon, Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_00_02a", new CardDef(new Power
			{
				// TODO [KARA_00_02a] Abyssal && Test: Abyssal_KARA_00_02a
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARLOCK
			// [KARA_09_08] Kil'rek (*) - COST:4 [ATK:2/HP:6]
			// - Race: demon, Set: kara,
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_09_08", new CardDef(new Power
			{
				// TODO [KARA_09_08] Kil'rek && Test: Kil'rek_KARA_09_08
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARLOCK
			// [KARA_09_08_heroic] Kil'rek (*) - COST:4 [ATK:4/HP:8]
			// - Race: demon, Set: kara,
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_09_08_heroic", new CardDef(new Power
			{
				// TODO [KARA_09_08_heroic] Kil'rek && Test: Kil'rek_KARA_09_08_heroic
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void WarriorNonCollect(IDictionary<string, CardDef> cards)
		{
			// --------------------------------------- MINION - WARRIOR
			// [KARA_13_03] Orc Warrior (*) - COST:2 [ATK:3/HP:2]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_13_03", new CardDef(new Power
			{
				// TODO [KARA_13_03] Orc Warrior && Test: Orc Warrior_KARA_13_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - WARRIOR
			// [KARA_13_03H] Orc Warrior (*) - COST:2 [ATK:3/HP:3]
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_13_03H", new CardDef(new Power
			{
				// TODO [KARA_13_03H] Orc Warrior && Test: Orc Warrior_KARA_13_03H
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		private static void NeutralNonCollect(IDictionary<string, CardDef> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KAR_A01_02e] Reflection (*) - COST:0
			// - Set: kara,
			// --------------------------------------------------------
			// Text: 1/1.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A01_02e", new CardDef(new Power
			{
				// TODO [KAR_A01_02e] Reflection && Test: Reflection_KAR_A01_02e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("KAR_A01_02e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KAR_A02_03e] Fork Charge! (*) - COST:0
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_03e", new CardDef(new Power
			{
				// TODO [KAR_A02_03e] Fork Charge! && Test: Fork Charge!_KAR_A02_03e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("KAR_A02_03e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KAR_A02_04e] A Knife Defense (*) - COST:0
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_04e", new CardDef(new Power
			{
				// TODO [KAR_A02_04e] A Knife Defense && Test: A Knife Defense_KAR_A02_04e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("KAR_A02_04e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KAR_A02_05e] Cupricious Clattering (*) - COST:0
			// - Set: kara,
			// --------------------------------------------------------
			// Text: +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_05e", new CardDef(new Power
			{
				// TODO [KAR_A02_05e] Cupricious Clattering && Test: Cupricious Clattering_KAR_A02_05e
				InfoCardId = "KAR_A02_05e2",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("KAR_A02_05e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KAR_A02_05e2] Cupricious Clattering (*) - COST:0
			// - Set: kara,
			// --------------------------------------------------------
			// Text: +3 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_05e2", new CardDef(new Power
			{
				// TODO [KAR_A02_05e2] Cupricious Clattering && Test: Cupricious Clattering_KAR_A02_05e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("KAR_A02_05e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KAR_A02_06e2] Filled Up (*) - COST:0
			// - Set: kara,
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_06e2", new CardDef(new Power
			{
				// TODO [KAR_A02_06e2] Filled Up && Test: Filled Up_KAR_A02_06e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("KAR_A02_06e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KAR_A02_06He] Filled Up (*) - COST:0
			// - Set: kara,
			// --------------------------------------------------------
			// Text: +3/+3.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_06He", new CardDef(new Power
			{
				// TODO [KAR_A02_06He] Filled Up && Test: Filled Up_KAR_A02_06He
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("KAR_A02_06He")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KAR_A02_09e] Table Set (*) - COST:0
			// - Set: kara,
			// --------------------------------------------------------
			// Text: +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_09e", new CardDef(new Power
			{
				// TODO [KAR_A02_09e] Table Set && Test: Table Set_KAR_A02_09e
				InfoCardId = "KAR_A02_09eH",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("KAR_A02_09e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KAR_A02_09eH] Table Set (*) - COST:0
			// - Set: kara,
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_09eH", new CardDef(new Power
			{
				// TODO [KAR_A02_09eH] Table Set && Test: Table Set_KAR_A02_09eH
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("KAR_A02_09eH")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KARA_00_05e] Insightful (*) - COST:0
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Your spells cost (0).
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_00_05e", new CardDef(new Power
			{
				// TODO [KARA_00_05e] Insightful && Test: Insightful_KARA_00_05e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("KARA_00_05e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KARA_00_06e] Arcanely Powerful (*) - COST:0
			// - Set: kara,
			// --------------------------------------------------------
			// Text: +5 Spell Damage.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("KARA_00_06e", new CardDef(new Power
			{
				// TODO [KARA_00_06e] Arcanely Powerful && Test: Arcanely Powerful_KARA_00_06e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("KARA_00_06e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KARA_05_01e] Trembling Before the Wolf (*) - COST:0
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Shrunk to a 1/1.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_05_01e", new CardDef(new Power
			{
				// TODO [KARA_05_01e] Trembling Before the Wolf && Test: Trembling Before the Wolf_KARA_05_01e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("KARA_05_01e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KARA_06_01e] Death-Marked Love (*) - COST:0
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Julianne is <b>immune</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_06_01e", new CardDef(new Power
			{
				// TODO [KARA_06_01e] Death-Marked Love && Test: Death-Marked Love_KARA_06_01e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("KARA_06_01e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KARA_07_02e] Protecting the Gallery (*) - COST:0
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_07_02e", new CardDef(new Power
			{
				// TODO [KARA_07_02e] Protecting the Gallery && Test: Protecting the Gallery_KARA_07_02e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("KARA_07_02e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KARA_08_02e] Nether Rage (*) - COST:0
			// - Set: kara,
			// --------------------------------------------------------
			// Text: +3 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_08_02e", new CardDef(new Power
			{
				// TODO [KARA_08_02e] Nether Rage && Test: Nether Rage_KARA_08_02e
				InfoCardId = "KARA_08_02eH",
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("KARA_08_02e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KARA_08_02eH] Nether Rage (*) - COST:0
			// - Set: kara,
			// --------------------------------------------------------
			// Text: +8 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_08_02eH", new CardDef(new Power
			{
				// TODO [KARA_08_02eH] Nether Rage && Test: Nether Rage_KARA_08_02eH
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("KARA_08_02eH")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KARA_08_03e] Nether Breath (*) - COST:0
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Health changed to 1.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_08_03e", new CardDef(new Power
			{
				// TODO [KARA_08_03e] Nether Breath && Test: Nether Breath_KARA_08_03e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("KARA_08_03e")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KARA_08_06e2] Blue Beam (*) - COST:0
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Only take 1 damage at a time.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_08_06e2", new CardDef(new Power
			{
				// TODO [KARA_08_06e2] Blue Beam && Test: Blue Beam_KARA_08_06e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("KARA_08_06e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KARA_08_08e2] Red Beam (*) - COST:0
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Has <b>Windfury</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_08_08e2", new CardDef(new Power
			{
				// TODO [KARA_08_08e2] Red Beam && Test: Red Beam_KARA_08_08e2
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("KARA_08_08e2")
			}));

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KARA_13_11e] Enfeeble (*) - COST:0
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Health changed to 1.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_13_11e", new CardDef(new Power
			{
				// TODO [KARA_13_11e] Enfeeble && Test: Enfeeble_KARA_13_11e
				//Enchant = Enchants.Enchants.GetAutoEnchantFromText("KARA_13_11e")
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A02_01] Plate (*) - COST:1 [ATK:1/HP:1]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_01", new CardDef(new Power
			{
				// TODO [KAR_A02_01] Plate && Test: Plate_KAR_A02_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A02_01H] Plate (*) - COST:1 [ATK:2/HP:2]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_01H", new CardDef(new Power
			{
				// TODO [KAR_A02_01H] Plate && Test: Plate_KAR_A02_01H
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A02_03] Fork (*) - COST:3 [ATK:3/HP:1]
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Plates have <b>Charge</b>.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_03", new CardDef(new Power
			{
				// TODO [KAR_A02_03] Fork && Test: Fork_KAR_A02_03
				InfoCardId = "KAR_A02_03e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A02_03H] Fork (*) - COST:2 [ATK:3/HP:3]
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Plates have <b>Charge</b>.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_03H", new CardDef(new Power
			{
				// TODO [KAR_A02_03H] Fork && Test: Fork_KAR_A02_03H
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A02_04] Knife (*) - COST:3 [ATK:5/HP:1]
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Plates have <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_04", new CardDef(new Power
			{
				// TODO [KAR_A02_04] Knife && Test: Knife_KAR_A02_04
				InfoCardId = "KAR_A02_04e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A02_04H] Knife (*) - COST:3 [ATK:5/HP:5]
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Plates have <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_04H", new CardDef(new Power
			{
				// TODO [KAR_A02_04H] Knife && Test: Knife_KAR_A02_04H
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A02_05] Cup (*) - COST:2 [ATK:2/HP:1]
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Plates have +1 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_05", new CardDef(new Power
			{
				// TODO [KAR_A02_05] Cup && Test: Cup_KAR_A02_05
				InfoCardId = "KAR_A02_05e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A02_05H] Cup (*) - COST:2 [ATK:2/HP:2]
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Plates have +3 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_05H", new CardDef(new Power
			{
				// TODO [KAR_A02_05H] Cup && Test: Cup_KAR_A02_05H
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A02_06] Pitcher (*) - COST:4 [ATK:3/HP:3]
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a minion +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("KAR_A02_06", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				// TODO [KAR_A02_06] Pitcher && Test: Pitcher_KAR_A02_06
				InfoCardId = "KAR_A02_06e2",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A02_06H] Pitcher (*) - COST:4 [ATK:5/HP:5]
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a minion +3/+3.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_FRIENDLY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("KAR_A02_06H", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_IF_AVAILABLE,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_FRIENDLY_TARGET,0}}, new Power
			{
				// TODO [KAR_A02_06H] Pitcher && Test: Pitcher_KAR_A02_06H
				InfoCardId = "KAR_A02_06He",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A10_01] Black Pawn (*) - COST:1 [ATK:1/HP:6]
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Auto-Attack:</b> Deal 1 damage to the enemies opposite this minion.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - AUTOATTACK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_01", new CardDef(new Power
			{
				// TODO [KAR_A10_01] Black Pawn && Test: Black Pawn_KAR_A10_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A10_02] White Pawn (*) - COST:1 [ATK:1/HP:6]
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Auto-Attack:</b> Deal 1 damage to the enemies opposite this minion.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - AUTOATTACK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_02", new CardDef(new Power
			{
				// TODO [KAR_A10_02] White Pawn && Test: White Pawn_KAR_A10_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A10_03] Black Rook (*) - COST:3 [ATK:2/HP:6]
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Auto-Attack:</b> Deal 2 damage to the enemies opposite this minion.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - AUTOATTACK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_03", new CardDef(new Power
			{
				// TODO [KAR_A10_03] Black Rook && Test: Black Rook_KAR_A10_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A10_04] White Rook (*) - COST:3 [ATK:2/HP:6]
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Auto-Attack:</b> Deal 2 damage to the enemies opposite this minion.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - AUTOATTACK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_04", new CardDef(new Power
			{
				// TODO [KAR_A10_04] White Rook && Test: White Rook_KAR_A10_04
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A10_05] White Bishop (*) - COST:3 [ATK:0/HP:6]
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Auto-Attack:</b> Restore #2 Health to adjacent minions.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - AUTOATTACK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_05", new CardDef(new Power
			{
				// TODO [KAR_A10_05] White Bishop && Test: White Bishop_KAR_A10_05
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A10_06] Black Bishop (*) - COST:3 [ATK:0/HP:6]
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Auto-Attack:</b> Restore #2 Health to adjacent minions.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - AUTOATTACK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_06", new CardDef(new Power
			{
				// TODO [KAR_A10_06] Black Bishop && Test: Black Bishop_KAR_A10_06
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A10_07] Black Knight (*) - COST:4 [ATK:4/HP:3]
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Charge</b>.
			//       Can't Attack Heroes.
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_07", new CardDef(new Power
			{
				// TODO [KAR_A10_07] Black Knight && Test: Black Knight_KAR_A10_07
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A10_08] White Knight (*) - COST:4 [ATK:4/HP:3]
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Charge</b>.
			//       Can't Attack Heroes.
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_08", new CardDef(new Power
			{
				// TODO [KAR_A10_08] White Knight && Test: White Knight_KAR_A10_08
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A10_09] White Queen (*) - COST:7 [ATK:4/HP:6]
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Auto-Attack:</b> Deal 4 damage to the enemies opposite this minion.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - AUTOATTACK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_09", new CardDef(new Power
			{
				// TODO [KAR_A10_09] White Queen && Test: White Queen_KAR_A10_09
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [KAR_A10_10] Black Queen (*) - COST:7 [ATK:4/HP:6]
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Auto-Attack:</b> Deal 4 damage to the enemies opposite this minion.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - AUTOATTACK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A10_10", new CardDef(new Power
			{
				// TODO [KAR_A10_10] Black Queen && Test: Black Queen_KAR_A10_10
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [KARA_04_01] Dorothee (*) - COST:4 [ATK:0/HP:10]
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Minions to the left have <b>Charge</b>. Minions to the right have <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("KARA_04_01", new CardDef(new Power
			{
				// TODO [KARA_04_01] Dorothee && Test: Dorothee_KARA_04_01
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [KARA_04_05] Flying Monkey (*) - COST:3 [ATK:4/HP:2]
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_04_05", new CardDef(new Power
			{
				// TODO [KARA_04_05] Flying Monkey && Test: Flying Monkey_KARA_04_05
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [KARA_04_05h] Flying Monkey (*) - COST:3 [ATK:5/HP:2]
			// - Set: kara,
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_04_05h", new CardDef(new Power
			{
				// TODO [KARA_04_05h] Flying Monkey && Test: Flying Monkey_KARA_04_05h
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [KARA_06_01] Romulo (*) - COST:4 [ATK:4/HP:2]
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Julianne is <b>Immune</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("KARA_06_01", new CardDef(new Power
			{
				// TODO [KARA_06_01] Romulo && Test: Romulo_KARA_06_01
				InfoCardId = "KARA_06_01e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [KARA_06_01heroic] Romulo (*) - COST:3 [ATK:4/HP:2]
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Julianne is <b>Immune</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("KARA_06_01heroic", new CardDef(new Power
			{
				// TODO [KARA_06_01heroic] Romulo && Test: Romulo_KARA_06_01heroic
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [KARA_08_06] Blue Portal (*) - COST:1 [ATK:0/HP:1]
			// - Set: kara,
			// --------------------------------------------------------
			// Text: The character in the blue beam only takes 1 damage at a time.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_08_06", new CardDef(new Power
			{
				// TODO [KARA_08_06] Blue Portal && Test: Blue Portal_KARA_08_06
				InfoCardId = "KARA_08_06e2",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [KARA_08_08] Red Portal (*) - COST:11 [ATK:0/HP:1]
			// - Set: kara,
			// --------------------------------------------------------
			// Text: The character in the red beam has <b>Windfury</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// RefTag:
			// - WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("KARA_08_08", new CardDef(new Power
			{
				// TODO [KARA_08_08] Red Portal && Test: Red Portal_KARA_08_08
				InfoCardId = "KARA_08_08e2",
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [KARA_09_03a] Icky Imp (*) - COST:1 [ATK:1/HP:1]
			// - Race: demon, Set: kara,
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Resummon this minion and Illhoof loses 2 Health.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_09_03a", new CardDef(new Power
			{
				// TODO [KARA_09_03a] Icky Imp && Test: Icky Imp_KARA_09_03a
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- MINION - NEUTRAL
			// [KARA_09_03a_heroic] Icky Imp (*) - COST:1 [ATK:2/HP:2]
			// - Race: demon, Set: kara,
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Resummon this minion and Illhoof loses 2 Health.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_09_03a_heroic", new CardDef(new Power
			{
				// TODO [KARA_09_03a_heroic] Icky Imp && Test: Icky Imp_KARA_09_03a_heroic
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [KAR_A02_09] Set the Table (*) - COST:4
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Give your Plates +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_09", new CardDef(new Power
			{
				// TODO [KAR_A02_09] Set the Table && Test: Set the Table_KAR_A02_09
				InfoCardId = "KAR_A02_09e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [KAR_A02_09H] Set the Table (*) - COST:4
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Give your Plates +2/+2.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_09H", new CardDef(new Power
			{
				// TODO [KAR_A02_09H] Set the Table && Test: Set the Table_KAR_A02_09H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [KAR_A02_10] Pour a Round (*) - COST:3
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Draw a card for each of your Plates.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_10", new CardDef(new Power
			{
				// TODO [KAR_A02_10] Pour a Round && Test: Pour a Round_KAR_A02_10
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [KAR_A02_11] Tossing Plates (*) - COST:5
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Summon five 1/1 Plates.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_11", new CardDef(new Power
			{
				// TODO [KAR_A02_11] Tossing Plates && Test: Tossing Plates_KAR_A02_11
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_07_03] Murloc Escaping! (*) - COST:1
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Summon a random Murloc.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_07_03", new CardDef(new Power
			{
				// TODO [KARA_07_03] Murloc Escaping! && Test: Murloc Escaping!_KARA_07_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_07_03heroic] Murlocs Escaping! (*) - COST:1
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Summon two random Murlocs.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_07_03heroic", new CardDef(new Power
			{
				// TODO [KARA_07_03heroic] Murlocs Escaping! && Test: Murlocs Escaping!_KARA_07_03heroic
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_07_05] Stampeding Beast! (*) - COST:3
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Summon a random Beast.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_07_05", new CardDef(new Power
			{
				// TODO [KARA_07_05] Stampeding Beast! && Test: Stampeding Beast!_KARA_07_05
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_07_05heroic] Stampeding Beast! (*) - COST:2
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Summon a random Beast.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_07_05heroic", new CardDef(new Power
			{
				// TODO [KARA_07_05heroic] Stampeding Beast! && Test: Stampeding Beast!_KARA_07_05heroic
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_07_06] Demons Loose! (*) - COST:4
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Summon a random Demon.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_07_06", new CardDef(new Power
			{
				// TODO [KARA_07_06] Demons Loose! && Test: Demons Loose!_KARA_07_06
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_07_06heroic] Demons Loose! (*) - COST:3
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Summon a random Demon.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_07_06heroic", new CardDef(new Power
			{
				// TODO [KARA_07_06heroic] Demons Loose! && Test: Demons Loose!_KARA_07_06heroic
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_07_07] Haywire Mech! (*) - COST:3
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Summon a random Mech.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_07_07", new CardDef(new Power
			{
				// TODO [KARA_07_07] Haywire Mech! && Test: Haywire Mech!_KARA_07_07
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_07_07heroic] Haywire Mech! (*) - COST:3
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Summon a random Mech.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_07_07heroic", new CardDef(new Power
			{
				// TODO [KARA_07_07heroic] Haywire Mech! && Test: Haywire Mech!_KARA_07_07heroic
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_07_08] Dragons Free! (*) - COST:6
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Summon a random Dragon.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_07_08", new CardDef(new Power
			{
				// TODO [KARA_07_08] Dragons Free! && Test: Dragons Free!_KARA_07_08
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_07_08heroic] Dragons Free! (*) - COST:5
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Summon a random Dragon.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_07_08heroic", new CardDef(new Power
			{
				// TODO [KARA_07_08heroic] Dragons Free! && Test: Dragons Free!_KARA_07_08heroic
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_08_03] Nether Breath (*) - COST:4
			// - Set: kara,
			// --------------------------------------------------------
			// Text: [x]Change the Health of
			//       all enemy minions to 1.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_08_03", new CardDef(new Power
			{
				// TODO [KARA_08_03] Nether Breath && Test: Nether Breath_KARA_08_03
				InfoCardId = "KARA_08_03e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_08_03H] Nether Breath (*) - COST:3
			// - Set: kara,
			// --------------------------------------------------------
			// Text: [x]Change the Health of
			//       all enemy minions to 1.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_08_03H", new CardDef(new Power
			{
				// TODO [KARA_08_03H] Nether Breath && Test: Nether Breath_KARA_08_03H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_08_04] Empowerment (*) - COST:2
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Give your hero +8 Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_08_04", new CardDef(new Power
			{
				// TODO [KARA_08_04] Empowerment && Test: Empowerment_KARA_08_04
				InfoCardId = "KARA_08_04e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_08_05] Terrifying Roar (*) - COST:3
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Return an enemy minion to your opponent's hand.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 1
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// --------------------------------------------------------
			cards.Add("KARA_08_05", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINIMUM_ENEMY_MINIONS,1},{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_MINION_TARGET,0},{PlayReq.REQ_ENEMY_TARGET,0}}, new Power
			{
				// TODO [KARA_08_05] Terrifying Roar && Test: Terrifying Roar_KARA_08_05
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_08_05H] Terrifying Roar (*) - COST:2
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Return an enemy minion to your opponent's hand.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 1
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("KARA_08_05H", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINIMUM_ENEMY_MINIONS,1},{PlayReq.REQ_TARGET_TO_PLAY,0},{PlayReq.REQ_ENEMY_TARGET,0},{PlayReq.REQ_MINION_TARGET,0}}, new Power
			{
				// TODO [KARA_08_05H] Terrifying Roar && Test: Terrifying Roar_KARA_08_05H
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_09_03] Many Imps! (*) - COST:2
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Summon 2 Icky Imps.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_09_03", new CardDef(new Power
			{
				// TODO [KARA_09_03] Many Imps! && Test: Many Imps!_KARA_09_03
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_09_03heroic] Many Imps! (*) - COST:2
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Summon 2 Icky Imps.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_09_03heroic", new CardDef(new Power
			{
				// TODO [KARA_09_03heroic] Many Imps! && Test: Many Imps!_KARA_09_03heroic
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_09_05] Summon Kil'rek (*) - COST:4
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Summon Kil'rek.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("KARA_09_05", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [KARA_09_05] Summon Kil'rek && Test: Summon Kil'rek_KARA_09_05
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_09_05heroic] Summon Kil'rek (*) - COST:4
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Summon Kil'rek.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("KARA_09_05heroic", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_NUM_MINION_SLOTS,1}}, new Power
			{
				// TODO [KARA_09_05heroic] Summon Kil'rek && Test: Summon Kil'rek_KARA_09_05heroic
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_09_06] Shadow Volley (*) - COST:6
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Deal $3 damage to all non-Demon minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_09_06", new CardDef(new Power
			{
				// TODO [KARA_09_06] Shadow Volley && Test: Shadow Volley_KARA_09_06
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_09_06heroic] Shadow Volley (*) - COST:4
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Deal $3 damage to all non-Demon minions. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_09_06heroic", new CardDef(new Power
			{
				// TODO [KARA_09_06heroic] Shadow Volley && Test: Shadow Volley_KARA_09_06heroic
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_09_07] Steal Life (*) - COST:6
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Deal $5 damage. Restore #5 Health to your hero. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("KARA_09_07", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [KARA_09_07] Steal Life && Test: Steal Life_KARA_09_07
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_09_07heroic] Steal Life (*) - COST:4
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Deal $5 damage. Restore #5 Health to your hero. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("KARA_09_07heroic", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_TARGET_TO_PLAY,0}}, new Power
			{
				// TODO [KARA_09_07heroic] Steal Life && Test: Steal Life_KARA_09_07heroic
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_13_11] Shadow Bolt Volley (*) - COST:3
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Deal $4 damage to three random enemies. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 2
			// --------------------------------------------------------
			cards.Add("KARA_13_11", new CardDef(new Dictionary<PlayReq, int>() {{PlayReq.REQ_MINIMUM_ENEMY_MINIONS,2}}, new Power
			{
				// TODO [KARA_13_11] Shadow Bolt Volley && Test: Shadow Bolt Volley_KARA_13_11
				InfoCardId = "KARA_13_11e",
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_13_12] Demonic Presence (*) - COST:3
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Draw 2 cards.
			//       Gain 10 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_13_12", new CardDef(new Power
			{
				// TODO [KARA_13_12] Demonic Presence && Test: Demonic Presence_KARA_13_12
				//PowerTask = null,
				//Trigger = null,
			}));

			// ---------------------------------------- SPELL - NEUTRAL
			// [KARA_13_12H] Demonic Presence (*) - COST:3
			// - Set: kara,
			// --------------------------------------------------------
			// Text: Draw 3 cards.
			//       Gain 10 Armor.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_13_12H", new CardDef(new Power
			{
				// TODO [KARA_13_12H] Demonic Presence && Test: Demonic Presence_KARA_13_12H
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- WEAPON - NEUTRAL
			// [KAR_A02_02] Spoon (*) - COST:1 [ATK:1/HP:0]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_02", new CardDef(new Power
			{
				// TODO [KAR_A02_02] Spoon && Test: Spoon_KAR_A02_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- WEAPON - NEUTRAL
			// [KAR_A02_02H] Spoon (*) - COST:1 [ATK:3/HP:0]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KAR_A02_02H", new CardDef(new Power
			{
				// TODO [KAR_A02_02H] Spoon && Test: Spoon_KAR_A02_02H
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- WEAPON - NEUTRAL
			// [KARA_05_02] Big Bad Claws (*) - COST:3 [ATK:4/HP:0]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_05_02", new CardDef(new Power
			{
				// TODO [KARA_05_02] Big Bad Claws && Test: Big Bad Claws_KARA_05_02
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- WEAPON - NEUTRAL
			// [KARA_05_02heroic] Big Bad Claws (*) - COST:2 [ATK:4/HP:0]
			// - Set: kara,
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// - HIDE_WATERMARK = 1
			// --------------------------------------------------------
			cards.Add("KARA_05_02heroic", new CardDef(new Power
			{
				// TODO [KARA_05_02heroic] Big Bad Claws && Test: Big Bad Claws_KARA_05_02heroic
				//PowerTask = null,
				//Trigger = null,
			}));

			// --------------------------------------- WEAPON - NEUTRAL
			// [KARA_13_26] Atiesh (*) - COST:3 [ATK:1/HP:0]
			// - Set: kara,
			// --------------------------------------------------------
			// Text: [x]After you cast a spell,
			//       summon a random
			//       minion of that Cost.
			//       Lose 1 Durability.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DURABILITY = 3
			// --------------------------------------------------------
			cards.Add("KARA_13_26", new CardDef(new Power
			{
				// TODO [KARA_13_26] Atiesh && Test: Atiesh_KARA_13_26
				//PowerTask = null,
				//Trigger = null,
			}));

		}

		public static void AddAll(Dictionary<string, CardDef> cards)
		{
			Heroes(cards);
			HeroPowers(cards);
			MageNonCollect(cards);
			WarlockNonCollect(cards);
			WarriorNonCollect(cards);
			NeutralNonCollect(cards);
		}
	}
}
