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

//using System.Collections.Generic;
//using SabberStoneCore.Enchants;
//using SabberStoneCore.Conditions;
//using SabberStoneCore.Enums;
//using SabberStoneCore.Model;
//using SabberStoneCore.Model.Zones;
//using SabberStoneCore.Model.Entities;
//using SabberStoneCore.Tasks;
//using SabberStoneCore.Tasks.SimpleTasks;

//namespace SabberStoneCore.CardSets.Adventure
//{
//	public class KaraCardsGenAdv
//	{
//		private static void Heroes(IDictionary<string, List<Power>> cards)
//		{
//			// ----------------------------------------- HERO - NEUTRAL
//			// [KARA_00_01] Prince Malchezaar (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 39753
//			// --------------------------------------------------------
//			cards.Add("KARA_00_01", new List<Power> {
//				// TODO [KARA_00_01] Prince Malchezaar && Test: Prince Malchezaar_KARA_00_01
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [KARA_00_01H] Prince Malchezaar (*) - COST:0 [ATK:0/HP:60] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 40080
//			// --------------------------------------------------------
//			cards.Add("KARA_00_01H", new List<Power> {
//				// TODO [KARA_00_01H] Prince Malchezaar && Test: Prince Malchezaar_KARA_00_01H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// -------------------------------------------- HERO - MAGE
//			// [KARA_00_03] Medivh (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 40081
//			// --------------------------------------------------------
//			cards.Add("KARA_00_03", new List<Power> {
//				// TODO [KARA_00_03] Medivh && Test: Medivh_KARA_00_03
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [KARA_00_03c] Medivh (*) - COST:0 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			cards.Add("KARA_00_03c", new List<Power> {
//				// TODO [KARA_00_03c] Medivh && Test: Medivh_KARA_00_03c
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// -------------------------------------------- HERO - MAGE
//			// [KARA_00_03H] Medivh (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 39756
//			// --------------------------------------------------------
//			cards.Add("KARA_00_03H", new List<Power> {
//				// TODO [KARA_00_03H] Medivh && Test: Medivh_KARA_00_03H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [KARA_04_01h] The Crone (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: kara, Rarity: common
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 39281
//			// --------------------------------------------------------
//			cards.Add("KARA_04_01h", new List<Power> {
//				// TODO [KARA_04_01h] The Crone && Test: The Crone_KARA_04_01h
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [KARA_04_01heroic] The Crone (*) - COST:0 [ATK:0/HP:50] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 39281
//			// --------------------------------------------------------
//			cards.Add("KARA_04_01heroic", new List<Power> {
//				// TODO [KARA_04_01heroic] The Crone && Test: The Crone_KARA_04_01heroic
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [KARA_05_01b] Kindly Grandmother (*) - COST:0 [ATK:0/HP:20] 
//			// - Set: kara, Rarity: common
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 39298
//			// --------------------------------------------------------
//			cards.Add("KARA_05_01b", new List<Power> {
//				// TODO [KARA_05_01b] Kindly Grandmother && Test: Kindly Grandmother_KARA_05_01b
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [KARA_05_01h] Big Bad Wolf (*) - COST:0 [ATK:0/HP:20] 
//			// - Set: kara, Rarity: common
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 39298
//			// --------------------------------------------------------
//			cards.Add("KARA_05_01h", new List<Power> {
//				// TODO [KARA_05_01h] Big Bad Wolf && Test: Big Bad Wolf_KARA_05_01h
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [KARA_05_01hheroic] Big Bad Wolf (*) - COST:0 [ATK:0/HP:20] 
//			// - Set: kara, Rarity: common
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 40266
//			// --------------------------------------------------------
//			cards.Add("KARA_05_01hheroic", new List<Power> {
//				// TODO [KARA_05_01hheroic] Big Bad Wolf && Test: Big Bad Wolf_KARA_05_01hheroic
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [KARA_06_02] Julianne (*) - COST:0 [ATK:0/HP:15] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 39563
//			// --------------------------------------------------------
//			cards.Add("KARA_06_02", new List<Power> {
//				// TODO [KARA_06_02] Julianne && Test: Julianne_KARA_06_02
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [KARA_06_02heroic] Julianne (*) - COST:0 [ATK:0/HP:15] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 40276
//			// --------------------------------------------------------
//			cards.Add("KARA_06_02heroic", new List<Power> {
//				// TODO [KARA_06_02heroic] Julianne && Test: Julianne_KARA_06_02heroic
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [KARA_07_01] Curator (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 39641
//			// --------------------------------------------------------
//			cards.Add("KARA_07_01", new List<Power> {
//				// TODO [KARA_07_01] Curator && Test: Curator_KARA_07_01
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [KARA_07_01heroic] Curator (*) - COST:0 [ATK:0/HP:40] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 39641
//			// --------------------------------------------------------
//			cards.Add("KARA_07_01heroic", new List<Power> {
//				// TODO [KARA_07_01heroic] Curator && Test: Curator_KARA_07_01heroic
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [KARA_08_01] Netherspite (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 39680
//			// --------------------------------------------------------
//			cards.Add("KARA_08_01", new List<Power> {
//				// TODO [KARA_08_01] Netherspite && Test: Netherspite_KARA_08_01
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [KARA_08_01H] Netherspite (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 40062
//			// --------------------------------------------------------
//			cards.Add("KARA_08_01H", new List<Power> {
//				// TODO [KARA_08_01H] Netherspite && Test: Netherspite_KARA_08_01H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [KARA_09_01] Terestian Illhoof (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 39645
//			// --------------------------------------------------------
//			cards.Add("KARA_09_01", new List<Power> {
//				// TODO [KARA_09_01] Terestian Illhoof && Test: Terestian Illhoof_KARA_09_01
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [KARA_09_01heroic] Terestian Illhoof (*) - COST:0 [ATK:0/HP:40] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 39645
//			// --------------------------------------------------------
//			cards.Add("KARA_09_01heroic", new List<Power> {
//				// TODO [KARA_09_01heroic] Terestian Illhoof && Test: Terestian Illhoof_KARA_09_01heroic
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [KARA_09_02] Curator (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 39645
//			// --------------------------------------------------------
//			cards.Add("KARA_09_02", new List<Power> {
//				// TODO [KARA_09_02] Curator && Test: Curator_KARA_09_02
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [KARA_11_01] Nightbane (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 39667
//			// --------------------------------------------------------
//			cards.Add("KARA_11_01", new List<Power> {
//				// TODO [KARA_11_01] Nightbane && Test: Nightbane_KARA_11_01
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [KARA_11_01heroic] Nightbane (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 39667
//			// --------------------------------------------------------
//			cards.Add("KARA_11_01heroic", new List<Power> {
//				// TODO [KARA_11_01heroic] Nightbane && Test: Nightbane_KARA_11_01heroic
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// -------------------------------------------- HERO - MAGE
//			// [KARA_12_01] Shade of Aran (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 39669
//			// --------------------------------------------------------
//			cards.Add("KARA_12_01", new List<Power> {
//				// TODO [KARA_12_01] Shade of Aran && Test: Shade of Aran_KARA_12_01
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// -------------------------------------------- HERO - MAGE
//			// [KARA_12_01H] Shade of Aran (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 40107
//			// --------------------------------------------------------
//			cards.Add("KARA_12_01H", new List<Power> {
//				// TODO [KARA_12_01H] Shade of Aran && Test: Shade of Aran_KARA_12_01H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - WARRIOR
//			// [KARA_13_01] Nazra Wildaxe (*) - COST:0 [ATK:0/HP:15] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 39771
//			// --------------------------------------------------------
//			cards.Add("KARA_13_01", new List<Power> {
//				// TODO [KARA_13_01] Nazra Wildaxe && Test: Nazra Wildaxe_KARA_13_01
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - WARRIOR
//			// [KARA_13_01H] Nazra Wildaxe (*) - COST:0 [ATK:0/HP:15] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 40733
//			// --------------------------------------------------------
//			cards.Add("KARA_13_01H", new List<Power> {
//				// TODO [KARA_13_01H] Nazra Wildaxe && Test: Nazra Wildaxe_KARA_13_01H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [KARA_13_06] Prince Malchezaar (*) - COST:0 [ATK:0/HP:30] 
//			// - Race: demon, Set: kara, 
//			// --------------------------------------------------------
//			// Entourage: KAR_073, KAR_075, KAR_076, KAR_077, KAR_091
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 40563
//			// --------------------------------------------------------
//			cards.Add("KARA_13_06", new List<Power> {
//				// TODO [KARA_13_06] Prince Malchezaar && Test: Prince Malchezaar_KARA_13_06
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [KARA_13_06H] Prince Malchezaar (*) - COST:0 [ATK:0/HP:30] 
//			// - Race: demon, Set: kara, 
//			// --------------------------------------------------------
//			// Entourage: KAR_073, KAR_075, KAR_076, KAR_077, KAR_091
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 40763
//			// --------------------------------------------------------
//			cards.Add("KARA_13_06H", new List<Power> {
//				// TODO [KARA_13_06H] Prince Malchezaar && Test: Prince Malchezaar_KARA_13_06H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//		}

//		private static void HeroPowers(IDictionary<string, List<Power>> cards)
//		{
//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [KARA_00_02] Legion (*) - COST:2 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Summon a 6/6 Abyssal.
//			// --------------------------------------------------------
//			cards.Add("KARA_00_02", new List<Power> {
//				// TODO [KARA_00_02] Legion && Test: Legion_KARA_00_02
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [KARA_00_02H] Legion (*) - COST:2 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Summon a 6/6 Abyssal.
//			// --------------------------------------------------------
//			cards.Add("KARA_00_02H", new List<Power> {
//				// TODO [KARA_00_02H] Legion && Test: Legion_KARA_00_02H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [KARA_00_04] Brilliance (*) - COST:2 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Draw 3 cards.
//			// --------------------------------------------------------
//			cards.Add("KARA_00_04", new List<Power> {
//				// TODO [KARA_00_04] Brilliance && Test: Brilliance_KARA_00_04
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [KARA_00_04H] Brilliance (*) - COST:2 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Draw 3 cards.
//			// --------------------------------------------------------
//			cards.Add("KARA_00_04H", new List<Power> {
//				// TODO [KARA_00_04H] Brilliance && Test: Brilliance_KARA_00_04H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [KARA_04_02hp] Twister (*) - COST:0 
//			// - Set: kara, Rarity: common
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Deal 100 damage. Can't be used if Dorothee is alive.
//			// --------------------------------------------------------
//			cards.Add("KARA_04_02hp", new List<Power> {
//				// TODO [KARA_04_02hp] Twister && Test: Twister_KARA_04_02hp
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [KARA_05_01hp] Trembling (*) - COST:0 
//			// - Set: kara, Rarity: common
//			// --------------------------------------------------------
//			// Text: <b>Passive Hero Power</b> Enemy minions are 1/1 and cost (1).
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_05_01hp", new List<Power> {
//				// TODO [KARA_05_01hp] Trembling && Test: Trembling_KARA_05_01hp
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [KARA_05_01hpheroic] Trembling (*) - COST:0 
//			// - Set: kara, Rarity: common
//			// --------------------------------------------------------
//			// Text: <b>Passive Hero Power</b> Minions cost (1). Enemy minions are 1/1.
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_05_01hpheroic", new List<Power> {
//				// TODO [KARA_05_01hpheroic] Trembling && Test: Trembling_KARA_05_01hpheroic
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [KARA_06_03hp] True Love (*) - COST:4 
//			// - Set: kara, Rarity: common
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       If you don't have Romulo, summon him.
//			// --------------------------------------------------------
//			// Entourage: KARA_06_01
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_NUM_MINION_SLOTS = 1
//			// - REQ_ENTIRE_ENTOURAGE_NOT_IN_PLAY = 0
//			// --------------------------------------------------------
//			cards.Add("KARA_06_03hp", new List<Power> {
//				// TODO [KARA_06_03hp] True Love && Test: True Love_KARA_06_03hp
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [KARA_06_03hpheroic] True Love (*) - COST:0 
//			// - Set: kara, Rarity: common
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       If you don't have Romulo, summon him.
//			// --------------------------------------------------------
//			// Entourage: KARA_06_01
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_NUM_MINION_SLOTS = 1
//			// - REQ_ENTIRE_ENTOURAGE_NOT_IN_PLAY = 0
//			// --------------------------------------------------------
//			cards.Add("KARA_06_03hpheroic", new List<Power> {
//				// TODO [KARA_06_03hpheroic] True Love && Test: True Love_KARA_06_03hpheroic
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [KARA_07_02] Gallery Protection (*) - COST:0 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: <b>Passive Hero Power</b>
//			//       Your hero has <b>Taunt</b>.
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_07_02", new List<Power> {
//				// TODO [KARA_07_02] Gallery Protection && Test: Gallery Protection_KARA_07_02
//				new Power
//				{
//					InfoCardId = "KARA_07_02e",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [KARA_08_02] Nether Rage (*) - COST:2 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Give your hero +3 Attack this turn.
//			// --------------------------------------------------------
//			// Entourage: KARA_08_06, KARA_08_08
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_08_02", new List<Power> {
//				// TODO [KARA_08_02] Nether Rage && Test: Nether Rage_KARA_08_02
//				new Power
//				{
//					InfoCardId = "KARA_08_02e",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [KARA_08_02H] Nether Rage (*) - COST:1 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Give your hero +8 Attack this turn.
//			// --------------------------------------------------------
//			// Entourage: KARA_08_06, KARA_08_08
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_08_02H", new List<Power> {
//				// TODO [KARA_08_02H] Nether Rage && Test: Nether Rage_KARA_08_02H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [KARA_09_04] Dark Pact (*) - COST:0 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: <b>Passive Hero Power</b>
//			//       Only Icky Imps can damage Illhoof!
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_09_04", new List<Power> {
//				// TODO [KARA_09_04] Dark Pact && Test: Dark Pact_KARA_09_04
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [KARA_11_02] Manastorm (*) - COST:0 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: <b>Passive Hero Power</b>
//			//       Players start with 10 Mana Crystals.
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_11_02", new List<Power> {
//				// TODO [KARA_11_02] Manastorm && Test: Manastorm_KARA_11_02
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [KARA_12_02] Ley Lines (*) - COST:0 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: [x]<b>Passive Hero Power</b>
//			//       Both players have
//			//       <b>Spell Damage +3</b>.
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_12_02", new List<Power> {
//				// TODO [KARA_12_02] Ley Lines && Test: Ley Lines_KARA_12_02
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [KARA_12_02H] Ley Lines (*) - COST:0 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: [x]<b>Passive Hero Power</b>
//			//       Both players have
//			//       <b>Spell Damage +5</b>.
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_12_02H", new List<Power> {
//				// TODO [KARA_12_02H] Ley Lines && Test: Ley Lines_KARA_12_02H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - WARRIOR
//			// [KARA_13_02] The Horde (*) - COST:2 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: [x]<b>Hero Power</b>
//			//       Summon a 3/2 Orc.
//			// --------------------------------------------------------
//			cards.Add("KARA_13_02", new List<Power> {
//				// TODO [KARA_13_02] The Horde && Test: The Horde_KARA_13_02
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - WARRIOR
//			// [KARA_13_02H] The Horde (*) - COST:2 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: [x]<b>Hero Power</b>
//			//       Summon a 3/3 Orc
//			//       with <b>Charge</b>.
//			// --------------------------------------------------------
//			cards.Add("KARA_13_02H", new List<Power> {
//				// TODO [KARA_13_02H] The Horde && Test: The Horde_KARA_13_02H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [KARA_13_13] Legion (*) - COST:2 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Summon a 6/6 Abyssal.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_13_13", new List<Power> {
//				// TODO [KARA_13_13] Legion && Test: Legion_KARA_13_13
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [KARA_13_13H] Legion (*) - COST:2 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Summon two 6/6 Abyssals.
//			// --------------------------------------------------------
//			cards.Add("KARA_13_13H", new List<Power> {
//				// TODO [KARA_13_13H] Legion && Test: Legion_KARA_13_13H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//		}

//		private static void MageNonCollect(IDictionary<string, List<Power>> cards)
//		{
//			// ------------------------------------------ MINION - MAGE
//			// [KARA_00_08] Archmage's Apprentice (*) - COST:2 [ATK:2/HP:4] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Whenever you cast a spell, shuffle a copy of it into your deck.
//			// --------------------------------------------------------
//			cards.Add("KARA_00_08", new List<Power> {
//				// TODO [KARA_00_08] Archmage's Apprentice && Test: Archmage's Apprentice_KARA_00_08
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ------------------------------------------- SPELL - MAGE
//			// [KARA_00_05] Archmage's Insight (*) - COST:3 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Your spells cost (0) this turn.
//			// --------------------------------------------------------
//			cards.Add("KARA_00_05", new List<Power> {
//				// TODO [KARA_00_05] Archmage's Insight && Test: Archmage's Insight_KARA_00_05
//				new Power
//				{
//					InfoCardId = "KARA_00_05e",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ------------------------------------------- SPELL - MAGE
//			// [KARA_00_06] Arcane Power (*) - COST:2 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: You have <b>Spell Damage</b> +5 this turn.
//			// --------------------------------------------------------
//			// RefTag:
//			// - SPELLPOWER = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_00_06", new List<Power> {
//				// TODO [KARA_00_06] Arcane Power && Test: Arcane Power_KARA_00_06
//				new Power
//				{
//					InfoCardId = "KARA_00_06e",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ------------------------------------------- SPELL - MAGE
//			// [KARA_00_07] Astral Portal (*) - COST:1 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Summon a random <b>Legendary</b> minion.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_NUM_MINION_SLOTS = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_00_07", new List<Power> {
//				// TODO [KARA_00_07] Astral Portal && Test: Astral Portal_KARA_00_07
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ------------------------------------------- SPELL - MAGE
//			// [KARA_00_09] Mage Armor (*) - COST:1 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Gain 10 Armor.
//			// --------------------------------------------------------
//			cards.Add("KARA_00_09", new List<Power> {
//				// TODO [KARA_00_09] Mage Armor && Test: Mage Armor_KARA_00_09
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ------------------------------------------- SPELL - MAGE
//			// [KARA_00_10] Mysterious Rune (*) - COST:3 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Put 5 random Mage <b>Secrets</b> into the battlefield.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_SECRET_ZONE_CAP_FOR_NON_SECRET = 0
//			// --------------------------------------------------------
//			// RefTag:
//			// - SECRET = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_00_10", new List<Power> {
//				// TODO [KARA_00_10] Mysterious Rune && Test: Mysterious Rune_KARA_00_10
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ------------------------------------------- SPELL - MAGE
//			// [KARA_00_11] Evocation (*) - COST:0 
//			// - Fac: neutral, Set: kara, 
//			// --------------------------------------------------------
//			// Text: Gain 5 Mana Crystals this turn only.
//			// --------------------------------------------------------
//			cards.Add("KARA_00_11", new List<Power> {
//				// TODO [KARA_00_11] Evocation && Test: Evocation_KARA_00_11
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ------------------------------------------- SPELL - MAGE
//			// [KARA_12_03] Flame Wreath (*) - COST:3 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: <b>Secret:</b> When an enemy attacks, deal 5 damage to all other enemies.
//			// --------------------------------------------------------
//			// GameTag:
//			// - SECRET = 1
//			// - ImmuneToSpellpower = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_12_03", new List<Power> {
//				// TODO [KARA_12_03] Flame Wreath && Test: Flame Wreath_KARA_12_03
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ------------------------------------------- SPELL - MAGE
//			// [KARA_12_03H] Flame Wreath (*) - COST:3 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: <b>Secret:</b> When an enemy attacks, deal 10 damage to all other enemies.
//			// --------------------------------------------------------
//			// GameTag:
//			// - SECRET = 1
//			// - ImmuneToSpellpower = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_12_03H", new List<Power> {
//				// TODO [KARA_12_03H] Flame Wreath && Test: Flame Wreath_KARA_12_03H
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//		}

//		private static void WarlockNonCollect(IDictionary<string, List<Power>> cards)
//		{
//			// --------------------------------------- MINION - WARLOCK
//			// [KARA_00_02a] Abyssal (*) - COST:6 [ATK:6/HP:6] 
//			// - Race: demon, Set: kara, 
//			// --------------------------------------------------------
//			cards.Add("KARA_00_02a", new List<Power> {
//				// TODO [KARA_00_02a] Abyssal && Test: Abyssal_KARA_00_02a
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - WARLOCK
//			// [KARA_09_08] Kil'rek (*) - COST:4 [ATK:2/HP:6] 
//			// - Race: demon, Set: kara, 
//			// --------------------------------------------------------
//			// Text: <b>Taunt</b>
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_09_08", new List<Power> {
//				// TODO [KARA_09_08] Kil'rek && Test: Kil'rek_KARA_09_08
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - WARLOCK
//			// [KARA_09_08_heroic] Kil'rek (*) - COST:4 [ATK:4/HP:8] 
//			// - Race: demon, Set: kara, 
//			// --------------------------------------------------------
//			// Text: <b>Taunt</b>
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_09_08_heroic", new List<Power> {
//				// TODO [KARA_09_08_heroic] Kil'rek && Test: Kil'rek_KARA_09_08_heroic
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//		}

//		private static void WarriorNonCollect(IDictionary<string, List<Power>> cards)
//		{
//			// --------------------------------------- MINION - WARRIOR
//			// [KARA_13_03] Orc Warrior (*) - COST:2 [ATK:3/HP:2] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			cards.Add("KARA_13_03", new List<Power> {
//				// TODO [KARA_13_03] Orc Warrior && Test: Orc Warrior_KARA_13_03
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - WARRIOR
//			// [KARA_13_03H] Orc Warrior (*) - COST:2 [ATK:3/HP:3] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: <b>Charge</b>
//			// --------------------------------------------------------
//			// GameTag:
//			// - CHARGE = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_13_03H", new List<Power> {
//				// TODO [KARA_13_03H] Orc Warrior && Test: Orc Warrior_KARA_13_03H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//		}

//		private static void NeutralNonCollect(IDictionary<string, List<Power>> cards)
//		{
//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [KARA_00_05e] Insightful (*) - COST:0 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Your spells cost (0).
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAG_ONE_TURN_EFFECT = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_00_05e", new List<Power> {
//				// TODO [KARA_00_05e] Insightful && Test: Insightful_KARA_00_05e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [KARA_00_06e] Arcanely Powerful (*) - COST:0 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: +5 Spell Damage.
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAG_ONE_TURN_EFFECT = 1
//			// --------------------------------------------------------
//			// RefTag:
//			// - SPELLPOWER = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_00_06e", new List<Power> {
//				// TODO [KARA_00_06e] Arcanely Powerful && Test: Arcanely Powerful_KARA_00_06e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [KARA_05_01e] Trembling Before the Wolf (*) - COST:0 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Shrunk to a 1/1.
//			// --------------------------------------------------------
//			cards.Add("KARA_05_01e", new List<Power> {
//				// TODO [KARA_05_01e] Trembling Before the Wolf && Test: Trembling Before the Wolf_KARA_05_01e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [KARA_06_01e] Death-Marked Love (*) - COST:0 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Julianne is <b>immune</b>.
//			// --------------------------------------------------------
//			cards.Add("KARA_06_01e", new List<Power> {
//				// TODO [KARA_06_01e] Death-Marked Love && Test: Death-Marked Love_KARA_06_01e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [KARA_07_02e] Protecting the Gallery (*) - COST:0 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			cards.Add("KARA_07_02e", new List<Power> {
//				// TODO [KARA_07_02e] Protecting the Gallery && Test: Protecting the Gallery_KARA_07_02e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [KARA_08_02e] Nether Rage (*) - COST:0 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: +3 Attack.
//			// --------------------------------------------------------
//			cards.Add("KARA_08_02e", new List<Power> {
//				// TODO [KARA_08_02e] Nether Rage && Test: Nether Rage_KARA_08_02e
//				new Power
//				{
//					InfoCardId = "KARA_08_02eH",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [KARA_08_02eH] Nether Rage (*) - COST:0 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: +8 Attack.
//			// --------------------------------------------------------
//			cards.Add("KARA_08_02eH", new List<Power> {
//				// TODO [KARA_08_02eH] Nether Rage && Test: Nether Rage_KARA_08_02eH
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [KARA_08_03e] Nether Breath (*) - COST:0 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Health changed to 1.
//			// --------------------------------------------------------
//			cards.Add("KARA_08_03e", new List<Power> {
//				// TODO [KARA_08_03e] Nether Breath && Test: Nether Breath_KARA_08_03e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [KARA_08_06e2] Blue Beam (*) - COST:0 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Only take 1 damage at a time.
//			// --------------------------------------------------------
//			cards.Add("KARA_08_06e2", new List<Power> {
//				// TODO [KARA_08_06e2] Blue Beam && Test: Blue Beam_KARA_08_06e2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [KARA_08_08e2] Red Beam (*) - COST:0 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Has <b>Windfury</b>.
//			// --------------------------------------------------------
//			cards.Add("KARA_08_08e2", new List<Power> {
//				// TODO [KARA_08_08e2] Red Beam && Test: Red Beam_KARA_08_08e2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [KARA_13_11e] Enfeeble (*) - COST:0 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Health changed to 1.
//			// --------------------------------------------------------
//			cards.Add("KARA_13_11e", new List<Power> {
//				// TODO [KARA_13_11e] Enfeeble && Test: Enfeeble_KARA_13_11e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [KARA_04_01] Dorothee (*) - COST:4 [ATK:0/HP:10] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Minions to the left have <b>Charge</b>. Minions to the right have <b>Taunt</b>.
//			// --------------------------------------------------------
//			// RefTag:
//			// - TAUNT = 1
//			// - CHARGE = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_04_01", new List<Power> {
//				// TODO [KARA_04_01] Dorothee && Test: Dorothee_KARA_04_01
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [KARA_04_05] Flying Monkey (*) - COST:3 [ATK:4/HP:2] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: <b>Charge</b>
//			// --------------------------------------------------------
//			// GameTag:
//			// - CHARGE = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_04_05", new List<Power> {
//				// TODO [KARA_04_05] Flying Monkey && Test: Flying Monkey_KARA_04_05
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [KARA_04_05h] Flying Monkey (*) - COST:3 [ATK:5/HP:2] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: <b>Charge</b>
//			// --------------------------------------------------------
//			// GameTag:
//			// - CHARGE = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_04_05h", new List<Power> {
//				// TODO [KARA_04_05h] Flying Monkey && Test: Flying Monkey_KARA_04_05h
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [KARA_06_01] Romulo (*) - COST:4 [ATK:4/HP:2] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Julianne is <b>Immune</b>.
//			// --------------------------------------------------------
//			// RefTag:
//			// - IMMUNE = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_06_01", new List<Power> {
//				// TODO [KARA_06_01] Romulo && Test: Romulo_KARA_06_01
//				new Power
//				{
//					InfoCardId = "KARA_06_01e",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [KARA_06_01heroic] Romulo (*) - COST:3 [ATK:4/HP:2] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Julianne is <b>Immune</b>.
//			// --------------------------------------------------------
//			// RefTag:
//			// - IMMUNE = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_06_01heroic", new List<Power> {
//				// TODO [KARA_06_01heroic] Romulo && Test: Romulo_KARA_06_01heroic
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [KARA_08_06] Blue Portal (*) - COST:1 [ATK:0/HP:1] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: The character in the blue beam only takes 1 damage at a time.
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// - UNTOUCHABLE = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_08_06", new List<Power> {
//				// TODO [KARA_08_06] Blue Portal && Test: Blue Portal_KARA_08_06
//				new Power
//				{
//					InfoCardId = "KARA_08_06e2",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [KARA_08_08] Red Portal (*) - COST:11 [ATK:0/HP:1] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: The character in the red beam has <b>Windfury</b>.
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// - UNTOUCHABLE = 1
//			// --------------------------------------------------------
//			// RefTag:
//			// - WINDFURY = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_08_08", new List<Power> {
//				// TODO [KARA_08_08] Red Portal && Test: Red Portal_KARA_08_08
//				new Power
//				{
//					InfoCardId = "KARA_08_08e2",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [KARA_09_03a] Icky Imp (*) - COST:1 [ATK:1/HP:1] 
//			// - Race: demon, Set: kara, 
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> Resummon this minion and Illhoof loses 2 Health.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_09_03a", new List<Power> {
//				// TODO [KARA_09_03a] Icky Imp && Test: Icky Imp_KARA_09_03a
//				new Power
//				{
//					Activation = PowerActivation.DEATHRATTLE,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [KARA_09_03a_heroic] Icky Imp (*) - COST:1 [ATK:2/HP:2] 
//			// - Race: demon, Set: kara, 
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> Resummon this minion and Illhoof loses 2 Health.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_09_03a_heroic", new List<Power> {
//				// TODO [KARA_09_03a_heroic] Icky Imp && Test: Icky Imp_KARA_09_03a_heroic
//				new Power
//				{
//					Activation = PowerActivation.DEATHRATTLE,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [KARA_07_03] Murloc Escaping! (*) - COST:1 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Summon a random Murloc.
//			// --------------------------------------------------------
//			cards.Add("KARA_07_03", new List<Power> {
//				// TODO [KARA_07_03] Murloc Escaping! && Test: Murloc Escaping!_KARA_07_03
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [KARA_07_03heroic] Murlocs Escaping! (*) - COST:1 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Summon two random Murlocs.
//			// --------------------------------------------------------
//			cards.Add("KARA_07_03heroic", new List<Power> {
//				// TODO [KARA_07_03heroic] Murlocs Escaping! && Test: Murlocs Escaping!_KARA_07_03heroic
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [KARA_07_05] Stampeding Beast! (*) - COST:3 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Summon a random Beast.
//			// --------------------------------------------------------
//			cards.Add("KARA_07_05", new List<Power> {
//				// TODO [KARA_07_05] Stampeding Beast! && Test: Stampeding Beast!_KARA_07_05
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [KARA_07_05heroic] Stampeding Beast! (*) - COST:2 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Summon a random Beast.
//			// --------------------------------------------------------
//			cards.Add("KARA_07_05heroic", new List<Power> {
//				// TODO [KARA_07_05heroic] Stampeding Beast! && Test: Stampeding Beast!_KARA_07_05heroic
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [KARA_07_06] Demons Loose! (*) - COST:4 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Summon a random Demon.
//			// --------------------------------------------------------
//			cards.Add("KARA_07_06", new List<Power> {
//				// TODO [KARA_07_06] Demons Loose! && Test: Demons Loose!_KARA_07_06
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [KARA_07_06heroic] Demons Loose! (*) - COST:3 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Summon a random Demon.
//			// --------------------------------------------------------
//			cards.Add("KARA_07_06heroic", new List<Power> {
//				// TODO [KARA_07_06heroic] Demons Loose! && Test: Demons Loose!_KARA_07_06heroic
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [KARA_07_07] Haywire Mech! (*) - COST:3 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Summon a random Mech.
//			// --------------------------------------------------------
//			cards.Add("KARA_07_07", new List<Power> {
//				// TODO [KARA_07_07] Haywire Mech! && Test: Haywire Mech!_KARA_07_07
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [KARA_07_07heroic] Haywire Mech! (*) - COST:3 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Summon a random Mech.
//			// --------------------------------------------------------
//			cards.Add("KARA_07_07heroic", new List<Power> {
//				// TODO [KARA_07_07heroic] Haywire Mech! && Test: Haywire Mech!_KARA_07_07heroic
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [KARA_07_08] Dragons Free! (*) - COST:6 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Summon a random Dragon.
//			// --------------------------------------------------------
//			cards.Add("KARA_07_08", new List<Power> {
//				// TODO [KARA_07_08] Dragons Free! && Test: Dragons Free!_KARA_07_08
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [KARA_07_08heroic] Dragons Free! (*) - COST:5 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Summon a random Dragon.
//			// --------------------------------------------------------
//			cards.Add("KARA_07_08heroic", new List<Power> {
//				// TODO [KARA_07_08heroic] Dragons Free! && Test: Dragons Free!_KARA_07_08heroic
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [KARA_08_03] Nether Breath (*) - COST:4 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: [x]Change the Health of
//			//       all enemy minions to 1.
//			// --------------------------------------------------------
//			cards.Add("KARA_08_03", new List<Power> {
//				// TODO [KARA_08_03] Nether Breath && Test: Nether Breath_KARA_08_03
//				new Power
//				{
//					InfoCardId = "KARA_08_03e",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [KARA_08_03H] Nether Breath (*) - COST:3 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: [x]Change the Health of
//			//       all enemy minions to 1.
//			// --------------------------------------------------------
//			cards.Add("KARA_08_03H", new List<Power> {
//				// TODO [KARA_08_03H] Nether Breath && Test: Nether Breath_KARA_08_03H
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [KARA_08_04] Empowerment (*) - COST:2 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Give your hero +8 Attack this turn.
//			// --------------------------------------------------------
//			cards.Add("KARA_08_04", new List<Power> {
//				// TODO [KARA_08_04] Empowerment && Test: Empowerment_KARA_08_04
//				new Power
//				{
//					InfoCardId = "KARA_08_04e",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [KARA_08_05] Terrifying Roar (*) - COST:3 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Return an enemy minion to your opponent's hand.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_ENEMY_TARGET = 0
//			// - REQ_MINION_TARGET = 0
//			// - REQ_TARGET_TO_PLAY = 0
//			// - REQ_MINIMUM_ENEMY_MINIONS = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_08_05", new List<Power> {
//				// TODO [KARA_08_05] Terrifying Roar && Test: Terrifying Roar_KARA_08_05
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [KARA_08_05H] Terrifying Roar (*) - COST:2 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Return an enemy minion to your opponent's hand.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_ENEMY_TARGET = 0
//			// - REQ_MINION_TARGET = 0
//			// - REQ_TARGET_TO_PLAY = 0
//			// - REQ_MINIMUM_ENEMY_MINIONS = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_08_05H", new List<Power> {
//				// TODO [KARA_08_05H] Terrifying Roar && Test: Terrifying Roar_KARA_08_05H
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [KARA_09_03] Many Imps! (*) - COST:2 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Summon 2 Icky Imps.
//			// --------------------------------------------------------
//			cards.Add("KARA_09_03", new List<Power> {
//				// TODO [KARA_09_03] Many Imps! && Test: Many Imps!_KARA_09_03
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [KARA_09_03heroic] Many Imps! (*) - COST:2 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Summon 2 Icky Imps.
//			// --------------------------------------------------------
//			cards.Add("KARA_09_03heroic", new List<Power> {
//				// TODO [KARA_09_03heroic] Many Imps! && Test: Many Imps!_KARA_09_03heroic
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [KARA_09_05] Summon Kil'rek (*) - COST:4 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Summon Kil'rek.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_NUM_MINION_SLOTS = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_09_05", new List<Power> {
//				// TODO [KARA_09_05] Summon Kil'rek && Test: Summon Kil'rek_KARA_09_05
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [KARA_09_05heroic] Summon Kil'rek (*) - COST:4 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Summon Kil'rek.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_NUM_MINION_SLOTS = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_09_05heroic", new List<Power> {
//				// TODO [KARA_09_05heroic] Summon Kil'rek && Test: Summon Kil'rek_KARA_09_05heroic
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [KARA_09_06] Shadow Volley (*) - COST:6 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Deal $3 damage to all non-Demon minions. @spelldmg
//			// --------------------------------------------------------
//			cards.Add("KARA_09_06", new List<Power> {
//				// TODO [KARA_09_06] Shadow Volley && Test: Shadow Volley_KARA_09_06
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [KARA_09_06heroic] Shadow Volley (*) - COST:4 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Deal $3 damage to all non-Demon minions. @spelldmg
//			// --------------------------------------------------------
//			cards.Add("KARA_09_06heroic", new List<Power> {
//				// TODO [KARA_09_06heroic] Shadow Volley && Test: Shadow Volley_KARA_09_06heroic
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [KARA_09_07] Steal Life (*) - COST:6 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Deal $5 damage. Restore #5 Health to your hero. @spelldmg
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_TARGET_TO_PLAY = 0
//			// --------------------------------------------------------
//			cards.Add("KARA_09_07", new List<Power> {
//				// TODO [KARA_09_07] Steal Life && Test: Steal Life_KARA_09_07
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [KARA_09_07heroic] Steal Life (*) - COST:4 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Deal $5 damage. Restore #5 Health to your hero. @spelldmg
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_TARGET_TO_PLAY = 0
//			// --------------------------------------------------------
//			cards.Add("KARA_09_07heroic", new List<Power> {
//				// TODO [KARA_09_07heroic] Steal Life && Test: Steal Life_KARA_09_07heroic
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [KARA_13_11] Shadow Bolt Volley (*) - COST:3 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Deal $4 damage to three random enemies. @spelldmg
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_MINIMUM_ENEMY_MINIONS = 2
//			// --------------------------------------------------------
//			cards.Add("KARA_13_11", new List<Power> {
//				// TODO [KARA_13_11] Shadow Bolt Volley && Test: Shadow Bolt Volley_KARA_13_11
//				new Power
//				{
//					InfoCardId = "KARA_13_11e",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [KARA_13_12] Demonic Presence (*) - COST:3 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Draw 2 cards.
//			//       Gain 10 Armor.
//			// --------------------------------------------------------
//			cards.Add("KARA_13_12", new List<Power> {
//				// TODO [KARA_13_12] Demonic Presence && Test: Demonic Presence_KARA_13_12
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [KARA_13_12H] Demonic Presence (*) - COST:3 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: Draw 3 cards.
//			//       Gain 10 Armor.
//			// --------------------------------------------------------
//			cards.Add("KARA_13_12H", new List<Power> {
//				// TODO [KARA_13_12H] Demonic Presence && Test: Demonic Presence_KARA_13_12H
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- WEAPON - NEUTRAL
//			// [KARA_05_02] Big Bad Claws (*) - COST:3 [ATK:4/HP:0] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - DURABILITY = 2
//			// --------------------------------------------------------
//			cards.Add("KARA_05_02", new List<Power> {
//				// TODO [KARA_05_02] Big Bad Claws && Test: Big Bad Claws_KARA_05_02
//				new Power
//				{
//					Activation = PowerActivation.WEAPON,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- WEAPON - NEUTRAL
//			// [KARA_05_02heroic] Big Bad Claws (*) - COST:2 [ATK:4/HP:0] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - DURABILITY = 2
//			// --------------------------------------------------------
//			cards.Add("KARA_05_02heroic", new List<Power> {
//				// TODO [KARA_05_02heroic] Big Bad Claws && Test: Big Bad Claws_KARA_05_02heroic
//				new Power
//				{
//					Activation = PowerActivation.WEAPON,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- WEAPON - NEUTRAL
//			// [KARA_13_26] Atiesh (*) - COST:3 [ATK:1/HP:0] 
//			// - Set: kara, 
//			// --------------------------------------------------------
//			// Text: [x]After you cast a spell,
//			//       summon a random
//			//       minion of that Cost.
//			//       Lose 1 Durability.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DURABILITY = 3
//			// --------------------------------------------------------
//			cards.Add("KARA_13_26", new List<Power> {
//				// TODO [KARA_13_26] Atiesh && Test: Atiesh_KARA_13_26
//				new Power
//				{
//					Activation = PowerActivation.WEAPON,
//					PowerTask = null,
//				},
//			});

//		}

//		public static void AddAll(Dictionary<string, Power> cards)
//		{
//			Heroes(cards);
//			HeroPowers(cards);
//			MageNonCollect(cards);
//			WarlockNonCollect(cards);
//			WarriorNonCollect(cards);
//			NeutralNonCollect(cards);
//		}
//	}
//}
