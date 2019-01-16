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
//	public class BrmCardsGenAdv
//	{
//		private static void Heroes(Dictionary<string, Power> cards)
//		{
//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA01_1] Coren Direbrew (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// - HERO_POWER = 2314
//			// --------------------------------------------------------
//			cards.Add("BRMA01_1", new Power {
//				// TODO [BRMA01_1] Coren Direbrew && Test: Coren Direbrew_BRMA01_1
//				//Activation = null,
//				//SingleTask = null,
				
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA01_1H] Coren Direbrew (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// - HERO_POWER = 2439
//			// --------------------------------------------------------
//			cards.Add("BRMA01_1H", new List<Power> {
//				// TODO [BRMA01_1H] Coren Direbrew && Test: Coren Direbrew_BRMA01_1H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA02_1] High Justice Grimstone (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2317
//			// --------------------------------------------------------
//			cards.Add("BRMA02_1", new List<Power> {
//				// TODO [BRMA02_1] High Justice Grimstone && Test: High Justice Grimstone_BRMA02_1
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA02_1H] High Justice Grimstone (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2588
//			// --------------------------------------------------------
//			cards.Add("BRMA02_1H", new List<Power> {
//				// TODO [BRMA02_1H] High Justice Grimstone && Test: High Justice Grimstone_BRMA02_1H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA03_1] Emperor Thaurissan (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2321
//			// --------------------------------------------------------
//			cards.Add("BRMA03_1", new List<Power> {
//				// TODO [BRMA03_1] Emperor Thaurissan && Test: Emperor Thaurissan_BRMA03_1
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA03_1H] Emperor Thaurissan (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2321
//			// --------------------------------------------------------
//			cards.Add("BRMA03_1H", new List<Power> {
//				// TODO [BRMA03_1H] Emperor Thaurissan && Test: Emperor Thaurissan_BRMA03_1H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA04_1] Garr (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2325
//			// --------------------------------------------------------
//			cards.Add("BRMA04_1", new List<Power> {
//				// TODO [BRMA04_1] Garr && Test: Garr_BRMA04_1
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA04_1H] Garr (*) - COST:0 [ATK:0/HP:45] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2325
//			// --------------------------------------------------------
//			cards.Add("BRMA04_1H", new List<Power> {
//				// TODO [BRMA04_1H] Garr && Test: Garr_BRMA04_1H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA05_1] Baron Geddon (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2329
//			// --------------------------------------------------------
//			cards.Add("BRMA05_1", new List<Power> {
//				// TODO [BRMA05_1] Baron Geddon && Test: Baron Geddon_BRMA05_1
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA05_1H] Baron Geddon (*) - COST:0 [ATK:0/HP:50] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2445
//			// --------------------------------------------------------
//			cards.Add("BRMA05_1H", new List<Power> {
//				// TODO [BRMA05_1H] Baron Geddon && Test: Baron Geddon_BRMA05_1H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA06_1] Majordomo Executus (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2335
//			// --------------------------------------------------------
//			cards.Add("BRMA06_1", new List<Power> {
//				// TODO [BRMA06_1] Majordomo Executus && Test: Majordomo Executus_BRMA06_1
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA06_1H] Majordomo Executus (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2479
//			// --------------------------------------------------------
//			cards.Add("BRMA06_1H", new List<Power> {
//				// TODO [BRMA06_1H] Majordomo Executus && Test: Majordomo Executus_BRMA06_1H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA06_3] Ragnaros the Firelord (*) - COST:0 [ATK:0/HP:8] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2319
//			// --------------------------------------------------------
//			cards.Add("BRMA06_3", new List<Power> {
//				// TODO [BRMA06_3] Ragnaros the Firelord && Test: Ragnaros the Firelord_BRMA06_3
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA06_3H] Ragnaros the Firelord (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2448
//			// --------------------------------------------------------
//			cards.Add("BRMA06_3H", new List<Power> {
//				// TODO [BRMA06_3H] Ragnaros the Firelord && Test: Ragnaros the Firelord_BRMA06_3H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA07_1] Highlord Omokk (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2338
//			// --------------------------------------------------------
//			cards.Add("BRMA07_1", new List<Power> {
//				// TODO [BRMA07_1] Highlord Omokk && Test: Highlord Omokk_BRMA07_1
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA07_1H] Highlord Omokk (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2451
//			// --------------------------------------------------------
//			cards.Add("BRMA07_1H", new List<Power> {
//				// TODO [BRMA07_1H] Highlord Omokk && Test: Highlord Omokk_BRMA07_1H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA08_1] General Drakkisath (*) - COST:0 [ATK:0/HP:50] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2341
//			// --------------------------------------------------------
//			cards.Add("BRMA08_1", new List<Power> {
//				// TODO [BRMA08_1] General Drakkisath && Test: General Drakkisath_BRMA08_1
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA08_1H] General Drakkisath (*) - COST:0 [ATK:0/HP:50] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2453
//			// --------------------------------------------------------
//			cards.Add("BRMA08_1H", new List<Power> {
//				// TODO [BRMA08_1H] General Drakkisath && Test: General Drakkisath_BRMA08_1H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA09_1] Rend Blackhand (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2345
//			// --------------------------------------------------------
//			cards.Add("BRMA09_1", new List<Power> {
//				// TODO [BRMA09_1] Rend Blackhand && Test: Rend Blackhand_BRMA09_1
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA09_1H] Rend Blackhand (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2530
//			// --------------------------------------------------------
//			cards.Add("BRMA09_1H", new List<Power> {
//				// TODO [BRMA09_1H] Rend Blackhand && Test: Rend Blackhand_BRMA09_1H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA10_1] Razorgore the Untamed (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2356
//			// --------------------------------------------------------
//			cards.Add("BRMA10_1", new List<Power> {
//				// TODO [BRMA10_1] Razorgore the Untamed && Test: Razorgore the Untamed_BRMA10_1
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA10_1H] Razorgore the Untamed (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2475
//			// --------------------------------------------------------
//			cards.Add("BRMA10_1H", new List<Power> {
//				// TODO [BRMA10_1H] Razorgore the Untamed && Test: Razorgore the Untamed_BRMA10_1H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA11_1] Vaelastrasz the Corrupt (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2358
//			// --------------------------------------------------------
//			cards.Add("BRMA11_1", new List<Power> {
//				// TODO [BRMA11_1] Vaelastrasz the Corrupt && Test: Vaelastrasz the Corrupt_BRMA11_1
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA11_1H] Vaelastrasz the Corrupt (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2456
//			// --------------------------------------------------------
//			cards.Add("BRMA11_1H", new List<Power> {
//				// TODO [BRMA11_1H] Vaelastrasz the Corrupt && Test: Vaelastrasz the Corrupt_BRMA11_1H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA12_1] Chromaggus (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2361
//			// --------------------------------------------------------
//			cards.Add("BRMA12_1", new List<Power> {
//				// TODO [BRMA12_1] Chromaggus && Test: Chromaggus_BRMA12_1
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA12_1H] Chromaggus (*) - COST:0 [ATK:0/HP:60] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2458
//			// --------------------------------------------------------
//			cards.Add("BRMA12_1H", new List<Power> {
//				// TODO [BRMA12_1H] Chromaggus && Test: Chromaggus_BRMA12_1H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA12_9] Chromatic Dragonkin (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			cards.Add("BRMA12_9", new List<Power> {
//				// TODO [BRMA12_9] Chromatic Dragonkin && Test: Chromatic Dragonkin_BRMA12_9
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA13_1] Lord Victor Nefarius (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2379
//			// --------------------------------------------------------
//			cards.Add("BRMA13_1", new List<Power> {
//				// TODO [BRMA13_1] Lord Victor Nefarius && Test: Lord Victor Nefarius_BRMA13_1
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA13_1H] Lord Victor Nefarius (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2465
//			// --------------------------------------------------------
//			cards.Add("BRMA13_1H", new List<Power> {
//				// TODO [BRMA13_1H] Lord Victor Nefarius && Test: Lord Victor Nefarius_BRMA13_1H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA13_3] Nefarian (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Entourage: BRMA13_8, BRMA13_7, BRMA13_5, BRMA13_6
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2381
//			// --------------------------------------------------------
//			cards.Add("BRMA13_3", new List<Power> {
//				// TODO [BRMA13_3] Nefarian && Test: Nefarian_BRMA13_3
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA13_3H] Nefarian (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Entourage: BRMA13_8, BRMA13_7, BRMA13_6, BRMA13_5
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2467
//			// --------------------------------------------------------
//			cards.Add("BRMA13_3H", new List<Power> {
//				// TODO [BRMA13_3H] Nefarian && Test: Nefarian_BRMA13_3H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA14_1] Omnotron Defense System (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2388
//			// --------------------------------------------------------
//			cards.Add("BRMA14_1", new List<Power> {
//				// TODO [BRMA14_1] Omnotron Defense System && Test: Omnotron Defense System_BRMA14_1
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA14_1H] Omnotron Defense System (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2469
//			// --------------------------------------------------------
//			cards.Add("BRMA14_1H", new List<Power> {
//				// TODO [BRMA14_1H] Omnotron Defense System && Test: Omnotron Defense System_BRMA14_1H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA15_1] Maloriak (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2397
//			// --------------------------------------------------------
//			cards.Add("BRMA15_1", new List<Power> {
//				// TODO [BRMA15_1] Maloriak && Test: Maloriak_BRMA15_1
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA15_1H] Maloriak (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2592
//			// --------------------------------------------------------
//			cards.Add("BRMA15_1H", new List<Power> {
//				// TODO [BRMA15_1H] Maloriak && Test: Maloriak_BRMA15_1H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA16_1] Atramedes (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2401
//			// --------------------------------------------------------
//			cards.Add("BRMA16_1", new List<Power> {
//				// TODO [BRMA16_1] Atramedes && Test: Atramedes_BRMA16_1
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA16_1H] Atramedes (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2489
//			// --------------------------------------------------------
//			cards.Add("BRMA16_1H", new List<Power> {
//				// TODO [BRMA16_1H] Atramedes && Test: Atramedes_BRMA16_1H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA17_2] Nefarian (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2433
//			// --------------------------------------------------------
//			cards.Add("BRMA17_2", new List<Power> {
//				// TODO [BRMA17_2] Nefarian && Test: Nefarian_BRMA17_2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA17_2H] Nefarian (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2561
//			// --------------------------------------------------------
//			cards.Add("BRMA17_2H", new List<Power> {
//				// TODO [BRMA17_2H] Nefarian && Test: Nefarian_BRMA17_2H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA17_3] Onyxia (*) - COST:0 [ATK:0/HP:15] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2548
//			// --------------------------------------------------------
//			cards.Add("BRMA17_3", new List<Power> {
//				// TODO [BRMA17_3] Onyxia && Test: Onyxia_BRMA17_3
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [BRMA17_3H] Onyxia (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2559
//			// --------------------------------------------------------
//			cards.Add("BRMA17_3H", new List<Power> {
//				// TODO [BRMA17_3H] Onyxia && Test: Onyxia_BRMA17_3H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//		}

//		private static void HeroPowers(Dictionary<string, Power> cards)
//		{
//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA01_2] Pile On! (*) - COST:0 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Put a minion from each deck into the battlefield.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_NUM_MINION_SLOTS = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA01_2", new List<Power> {
//				// TODO [BRMA01_2] Pile On! && Test: Pile On!_BRMA01_2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA01_2H] Pile On! (*) - COST:0 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Put two minions from your deck and one from your opponent's into the battlefield.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_NUM_MINION_SLOTS = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA01_2H", new List<Power> {
//				// TODO [BRMA01_2H] Pile On! && Test: Pile On!_BRMA01_2H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA02_2] Jeering Crowd (*) - COST:1 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Summon a 1/1 Spectator with <b>Taunt</b>.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_NUM_MINION_SLOTS = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA02_2", new List<Power> {
//				// TODO [BRMA02_2] Jeering Crowd && Test: Jeering Crowd_BRMA02_2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA02_2H] Jeering Crowd (*) - COST:0 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Summon a 1/1 Spectator with <b>Taunt</b>.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_NUM_MINION_SLOTS = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA02_2H", new List<Power> {
//				// TODO [BRMA02_2H] Jeering Crowd && Test: Jeering Crowd_BRMA02_2H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA03_2] Power of the Firelord (*) - COST:2 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Deal 30 damage.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_TARGET_TO_PLAY = 0
//			// --------------------------------------------------------
//			cards.Add("BRMA03_2", new List<Power> {
//				// TODO [BRMA03_2] Power of the Firelord && Test: Power of the Firelord_BRMA03_2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA04_2] Magma Pulse (*) - COST:1 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Deal 1 damage to all minions.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA04_2", new List<Power> {
//				// TODO [BRMA04_2] Magma Pulse && Test: Magma Pulse_BRMA04_2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA05_2] Ignite Mana (*) - COST:0 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Deal 5 damage to the enemy hero if they have any unspent Mana.
//			// --------------------------------------------------------
//			cards.Add("BRMA05_2", new List<Power> {
//				// TODO [BRMA05_2] Ignite Mana && Test: Ignite Mana_BRMA05_2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA05_2H] Ignite Mana (*) - COST:0 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Deal 10 damage to the enemy hero if they have any unspent Mana.
//			// --------------------------------------------------------
//			cards.Add("BRMA05_2H", new List<Power> {
//				// TODO [BRMA05_2H] Ignite Mana && Test: Ignite Mana_BRMA05_2H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA06_2] The Majordomo (*) - COST:2 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Summon a 1/3 Flamewaker Acolyte.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_NUM_MINION_SLOTS = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA06_2", new List<Power> {
//				// TODO [BRMA06_2] The Majordomo && Test: The Majordomo_BRMA06_2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA06_2H] The Majordomo (*) - COST:2 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Summon a 3/3 Flamewaker Acolyte.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_NUM_MINION_SLOTS = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA06_2H", new List<Power> {
//				// TODO [BRMA06_2H] The Majordomo && Test: The Majordomo_BRMA06_2H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA07_2] ME SMASH (*) - COST:1 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Destroy a random damaged enemy minion.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_MINIMUM_ENEMY_MINIONS = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA07_2", new List<Power> {
//				// TODO [BRMA07_2] ME SMASH && Test: ME SMASH_BRMA07_2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA07_2H] ME SMASH (*) - COST:0 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Destroy a random enemy minion.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA07_2H", new List<Power> {
//				// TODO [BRMA07_2H] ME SMASH && Test: ME SMASH_BRMA07_2H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA08_2] Intense Gaze (*) - COST:0 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Passive Hero Power</b>
//			//       All cards cost (1). Players are capped at 1 Mana Crystal.
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA08_2", new List<Power> {
//				// TODO [BRMA08_2] Intense Gaze && Test: Intense Gaze_BRMA08_2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA08_2H] Intense Gaze (*) - COST:0 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Passive Hero Power</b>
//			//       All cards cost (1). You are capped at 2 Mana Crystals, and opponent at 1.
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA08_2H", new List<Power> {
//				// TODO [BRMA08_2H] Intense Gaze && Test: Intense Gaze_BRMA08_2H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA09_2] Open the Gates (*) - COST:2 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Summon three 1/1 Whelps. Get a new Hero Power.
//			// --------------------------------------------------------
//			// Entourage: BRMA09_3, BRMA09_4
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_NUM_MINION_SLOTS = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA09_2", new List<Power> {
//				// TODO [BRMA09_2] Open the Gates && Test: Open the Gates_BRMA09_2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA09_2H] Open the Gates (*) - COST:2 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Summon three 2/2 Whelps. Get a new Hero Power.
//			// --------------------------------------------------------
//			// Entourage: BRMA09_3H, BRMA09_4H
//			// --------------------------------------------------------
//			cards.Add("BRMA09_2H", new List<Power> {
//				// TODO [BRMA09_2H] Open the Gates && Test: Open the Gates_BRMA09_2H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA09_3] Old Horde (*) - COST:2 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Summon two 1/1 Orcs with <b>Taunt</b>. Get a new Hero Power.
//			// --------------------------------------------------------
//			// Entourage: BRMA09_2, BRMA09_4, BRMA09_5
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_NUM_MINION_SLOTS = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA09_3", new List<Power> {
//				// TODO [BRMA09_3] Old Horde && Test: Old Horde_BRMA09_3
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA09_3H] Old Horde (*) - COST:2 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Summon two 2/2 Orcs with <b>Taunt</b>. Get a new Hero Power.
//			// --------------------------------------------------------
//			// Entourage: BRMA09_2H, BRMA09_4H, BRMA09_5H
//			// --------------------------------------------------------
//			cards.Add("BRMA09_3H", new List<Power> {
//				// TODO [BRMA09_3H] Old Horde && Test: Old Horde_BRMA09_3H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA09_4] Blackwing (*) - COST:1 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Summon a 3/1 Dragonkin. Get a new Hero Power.
//			// --------------------------------------------------------
//			// Entourage: BRMA09_2, BRMA09_3, BRMA09_5
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_NUM_MINION_SLOTS = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA09_4", new List<Power> {
//				// TODO [BRMA09_4] Blackwing && Test: Blackwing_BRMA09_4
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA09_4H] Blackwing (*) - COST:1 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Summon a 5/4 Dragonkin. Get a new Hero Power.
//			// --------------------------------------------------------
//			// Entourage: BRMA09_2H, BRMA09_3H, BRMA09_5H
//			// --------------------------------------------------------
//			cards.Add("BRMA09_4H", new List<Power> {
//				// TODO [BRMA09_4H] Blackwing && Test: Blackwing_BRMA09_4H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA09_5] Dismount (*) - COST:4 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Summon Gyth. Get a new Hero Power.
//			// --------------------------------------------------------
//			// Entourage: BRMA09_2, BRMA09_3, BRMA09_4
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_NUM_MINION_SLOTS = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA09_5", new List<Power> {
//				// TODO [BRMA09_5] Dismount && Test: Dismount_BRMA09_5
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA09_5H] Dismount (*) - COST:4 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Summon Gyth. Get a new Hero Power.
//			// --------------------------------------------------------
//			// Entourage: BRMA09_2H, BRMA09_3H, BRMA09_4H
//			// --------------------------------------------------------
//			cards.Add("BRMA09_5H", new List<Power> {
//				// TODO [BRMA09_5H] Dismount && Test: Dismount_BRMA09_5H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA10_3] The Rookery (*) - COST:1 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Give all Corrupted Eggs +1 Health, then summon one.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA10_3", new List<Power> {
//				// TODO [BRMA10_3] The Rookery && Test: The Rookery_BRMA10_3
//				new Power
//				{
//					InfoCardId = "BRMA10_3e",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA10_3H] The Rookery (*) - COST:0 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Give all Corrupted Eggs +1 Health, then summon one.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA10_3H", new List<Power> {
//				// TODO [BRMA10_3H] The Rookery && Test: The Rookery_BRMA10_3H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA11_2] Essence of the Red (*) - COST:0 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Each player draws 2 cards.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA11_2", new List<Power> {
//				// TODO [BRMA11_2] Essence of the Red && Test: Essence of the Red_BRMA11_2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA11_2H] Essence of the Red (*) - COST:0 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Each player draws 3 cards. Gain a Mana Crystal.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA11_2H", new List<Power> {
//				// TODO [BRMA11_2H] Essence of the Red && Test: Essence of the Red_BRMA11_2H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA12_10] Mutation (*) - COST:1 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Discard a random card.
//			// --------------------------------------------------------
//			cards.Add("BRMA12_10", new List<Power> {
//				// TODO [BRMA12_10] Mutation && Test: Mutation_BRMA12_10
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA12_2] Brood Affliction (*) - COST:0 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       At the end of your turn, add a Brood Affliction card to your opponent's hand.
//			// --------------------------------------------------------
//			// Entourage: BRMA12_6, BRMA12_5, BRMA12_7, BRMA12_4, BRMA12_3
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA12_2", new List<Power> {
//				// TODO [BRMA12_2] Brood Affliction && Test: Brood Affliction_BRMA12_2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA12_2H] Brood Affliction (*) - COST:0 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       At the end of your turn, add a Brood Affliction card to your opponent's hand.
//			// --------------------------------------------------------
//			// Entourage: BRMA12_3H, BRMA12_4H, BRMA12_5H, BRMA12_6H, BRMA12_7H
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA12_2H", new List<Power> {
//				// TODO [BRMA12_2H] Brood Affliction && Test: Brood Affliction_BRMA12_2H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA13_2] True Form (*) - COST:1 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Let the games begin!
//			// --------------------------------------------------------
//			// Entourage: BRMA13_6, BRMA13_8, BRMA13_7, BRMA13_5
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA13_2", new List<Power> {
//				// TODO [BRMA13_2] True Form && Test: True Form_BRMA13_2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA13_2H] True Form (*) - COST:1 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Let the games begin!
//			// --------------------------------------------------------
//			// Entourage: BRMA13_6, BRMA13_8, BRMA13_7, BRMA13_5
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA13_2H", new List<Power> {
//				// TODO [BRMA13_2H] True Form && Test: True Form_BRMA13_2H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA13_4] Wild Magic (*) - COST:1 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Put a random spell from your opponent's class into your hand.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA13_4", new List<Power> {
//				// TODO [BRMA13_4] Wild Magic && Test: Wild Magic_BRMA13_4
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA13_4H] Wild Magic (*) - COST:1 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Put a random spell from your opponent's class into your hand.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA13_4H", new List<Power> {
//				// TODO [BRMA13_4H] Wild Magic && Test: Wild Magic_BRMA13_4H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA14_10] Activate! (*) - COST:4 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Activate a random Tron.
//			// --------------------------------------------------------
//			// Entourage: BRMA14_3, BRMA14_5, BRMA14_7, BRMA14_9
//			// --------------------------------------------------------
//			cards.Add("BRMA14_10", new List<Power> {
//				// TODO [BRMA14_10] Activate! && Test: Activate!_BRMA14_10
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA14_10H] Activate! (*) - COST:2 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Activate a random Tron.
//			// --------------------------------------------------------
//			// Entourage: BRMA14_3, BRMA14_5H, BRMA14_7H, BRMA14_9H
//			// --------------------------------------------------------
//			cards.Add("BRMA14_10H", new List<Power> {
//				// TODO [BRMA14_10H] Activate! && Test: Activate!_BRMA14_10H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA14_2] Activate Arcanotron (*) - COST:2 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Activate Arcanotron!
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA14_2", new List<Power> {
//				// TODO [BRMA14_2] Activate Arcanotron && Test: Activate Arcanotron_BRMA14_2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA14_2H] Activate Arcanotron (*) - COST:0 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Activate Arcanotron!
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA14_2H", new List<Power> {
//				// TODO [BRMA14_2H] Activate Arcanotron && Test: Activate Arcanotron_BRMA14_2H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA14_4] Activate Toxitron (*) - COST:4 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Activate Toxitron!
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA14_4", new List<Power> {
//				// TODO [BRMA14_4] Activate Toxitron && Test: Activate Toxitron_BRMA14_4
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA14_4H] Activate Toxitron (*) - COST:2 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Activate Toxitron!
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA14_4H", new List<Power> {
//				// TODO [BRMA14_4H] Activate Toxitron && Test: Activate Toxitron_BRMA14_4H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA14_6] Activate Electron (*) - COST:6 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Activate Electron!
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA14_6", new List<Power> {
//				// TODO [BRMA14_6] Activate Electron && Test: Activate Electron_BRMA14_6
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA14_6H] Activate Electron (*) - COST:4 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Activate Electron!
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA14_6H", new List<Power> {
//				// TODO [BRMA14_6H] Activate Electron && Test: Activate Electron_BRMA14_6H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA14_8] Activate Magmatron (*) - COST:8 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Activate Magmatron!
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA14_8", new List<Power> {
//				// TODO [BRMA14_8] Activate Magmatron && Test: Activate Magmatron_BRMA14_8
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA14_8H] Activate Magmatron (*) - COST:6 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Activate Magmatron!
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA14_8H", new List<Power> {
//				// TODO [BRMA14_8H] Activate Magmatron && Test: Activate Magmatron_BRMA14_8H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA15_2] The Alchemist (*) - COST:0 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Passive Hero Power</b>
//			//       Whenever a minion is summoned, swap its Attack and Health.
//			// --------------------------------------------------------
//			cards.Add("BRMA15_2", new List<Power> {
//				// TODO [BRMA15_2] The Alchemist && Test: The Alchemist_BRMA15_2
//				new Power
//				{
//					InfoCardId = "BRMA15_2He",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA15_2H] The Alchemist (*) - COST:0 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Passive Hero Power</b>
//			//       Minions' Attack and Health are swapped.
//			//       Your minions have +2/+2.
//			// --------------------------------------------------------
//			cards.Add("BRMA15_2H", new List<Power> {
//				// TODO [BRMA15_2H] The Alchemist && Test: The Alchemist_BRMA15_2H
//				new Power
//				{
//					InfoCardId = "BRMA15_2He",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA16_2] Echolocate (*) - COST:1 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Equip a weapon that grows as your opponent plays cards.
//			// --------------------------------------------------------
//			cards.Add("BRMA16_2", new List<Power> {
//				// TODO [BRMA16_2] Echolocate && Test: Echolocate_BRMA16_2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA16_2H] Echolocate (*) - COST:0 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Equip a weapon that grows as your opponent plays cards.
//			// --------------------------------------------------------
//			cards.Add("BRMA16_2H", new List<Power> {
//				// TODO [BRMA16_2H] Echolocate && Test: Echolocate_BRMA16_2H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA17_5] Bone Minions (*) - COST:2 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Summon two 2/1 Bone Constructs.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_NUM_MINION_SLOTS = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA17_5", new List<Power> {
//				// TODO [BRMA17_5] Bone Minions && Test: Bone Minions_BRMA17_5
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA17_5H] Bone Minions (*) - COST:2 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Summon two 4/2 Bone Constructs.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_NUM_MINION_SLOTS = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA17_5H", new List<Power> {
//				// TODO [BRMA17_5H] Bone Minions && Test: Bone Minions_BRMA17_5H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA17_8] Nefarian Strikes! (*) - COST:0 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Nefarian rains fire from above!
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA17_8", new List<Power> {
//				// TODO [BRMA17_8] Nefarian Strikes! && Test: Nefarian Strikes!_BRMA17_8
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA17_8H] Nefarian Strikes! (*) - COST:0 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Nefarian rains fire from above!
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA17_8H", new List<Power> {
//				// TODO [BRMA17_8H] Nefarian Strikes! && Test: Nefarian Strikes!_BRMA17_8H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//		}

//		private static void NeutralNonCollect(Dictionary<string, Power> cards)
//		{
//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [BRMA05_3e] Living Bomb (*) - COST:0 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: On Geddon's turn, deal 5 damage to all of your stuff.
//			// --------------------------------------------------------
//			cards.Add("BRMA05_3e", new List<Power> {
//				// TODO [BRMA05_3e] Living Bomb && Test: Living Bomb_BRMA05_3e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [BRMA05_3He] Living Bomb (*) - COST:0 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: On Geddon's turn, deal 10 damage to all of your stuff.
//			// --------------------------------------------------------
//			cards.Add("BRMA05_3He", new List<Power> {
//				// TODO [BRMA05_3He] Living Bomb && Test: Living Bomb_BRMA05_3He
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [BRMA10_3e] Incubation (*) - COST:0 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: Increased Health.
//			// --------------------------------------------------------
//			cards.Add("BRMA10_3e", new List<Power> {
//				// TODO [BRMA10_3e] Incubation && Test: Incubation_BRMA10_3e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [BRMA10_6e] Blind With Rage (*) - COST:0 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: Increased Attack.
//			// --------------------------------------------------------
//			cards.Add("BRMA10_6e", new List<Power> {
//				// TODO [BRMA10_6e] Blind With Rage && Test: Blind With Rage_BRMA10_6e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [BRMA12_8te] Draconic Lineage (*) - COST:0 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: +2/+2
//			// --------------------------------------------------------
//			cards.Add("BRMA12_8te", new List<Power> {
//				// TODO [BRMA12_8te] Draconic Lineage && Test: Draconic Lineage_BRMA12_8te
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [BRMA15_2He] Potion of Might (*) - COST:0 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: +2/+2.
//			// --------------------------------------------------------
//			cards.Add("BRMA15_2He", new List<Power> {
//				// TODO [BRMA15_2He] Potion of Might && Test: Potion of Might_BRMA15_2He
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [BRMA16_3e] Sonic Breath (*) - COST:0 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: +3 Attack.
//			// --------------------------------------------------------
//			cards.Add("BRMA16_3e", new List<Power> {
//				// TODO [BRMA16_3e] Sonic Breath && Test: Sonic Breath_BRMA16_3e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [BRMA16_5e] I hear you... (*) - COST:0 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: Increased Attack.
//			// --------------------------------------------------------
//			cards.Add("BRMA16_5e", new List<Power> {
//				// TODO [BRMA16_5e] I hear you... && Test: I hear you..._BRMA16_5e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA01_3] Dark Iron Bouncer (*) - COST:6 [ATK:4/HP:8] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: Always wins Brawls.
//			// --------------------------------------------------------
//			cards.Add("BRMA01_3", new List<Power> {
//				// TODO [BRMA01_3] Dark Iron Bouncer && Test: Dark Iron Bouncer_BRMA01_3
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA01_4t] Guzzler (*) - COST:1 [ATK:1/HP:1] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Taunt</b>
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA01_4t", new List<Power> {
//				// TODO [BRMA01_4t] Guzzler && Test: Guzzler_BRMA01_4t
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA02_2t] Dark Iron Spectator (*) - COST:1 [ATK:1/HP:1] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Taunt</b>
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA02_2t", new List<Power> {
//				// TODO [BRMA02_2t] Dark Iron Spectator && Test: Dark Iron Spectator_BRMA02_2t
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA03_3] Moira Bronzebeard (*) - COST:2 [ATK:1/HP:3] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: Thaurissan's Hero Power can't be used.
//			//       Never attacks minions unless they have <b>Taunt</b>.
//			// --------------------------------------------------------
//			// GameTag:
//			// - InvisibleDeathrattle = 1
//			// - AURA = 1
//			// --------------------------------------------------------
//			// RefTag:
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA03_3", new List<Power> {
//				// TODO [BRMA03_3] Moira Bronzebeard && Test: Moira Bronzebeard_BRMA03_3
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA03_3H] Moira Bronzebeard (*) - COST:2 [ATK:3/HP:1] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: Thaurissan's Hero Power can't be used.
//			//       Never attacks minions unless they have <b>Taunt</b>.
//			// --------------------------------------------------------
//			// GameTag:
//			// - InvisibleDeathrattle = 1
//			// - AURA = 1
//			// --------------------------------------------------------
//			// RefTag:
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA03_3H", new List<Power> {
//				// TODO [BRMA03_3H] Moira Bronzebeard && Test: Moira Bronzebeard_BRMA03_3H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA04_3] Firesworn (*) - COST:0 [ATK:0/HP:5] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> Deal 1 damage to the enemy hero for each Firesworn that died this turn.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA04_3", new List<Power> {
//				// TODO [BRMA04_3] Firesworn && Test: Firesworn_BRMA04_3
//				new Power
//				{
//					Activation = PowerActivation.DEATHRATTLE,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA04_3H] Firesworn (*) - COST:0 [ATK:0/HP:5] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> Deal 3 damage to the enemy hero for each Firesworn that died this turn.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA04_3H", new List<Power> {
//				// TODO [BRMA04_3H] Firesworn && Test: Firesworn_BRMA04_3H
//				new Power
//				{
//					Activation = PowerActivation.DEATHRATTLE,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA06_4] Flamewaker Acolyte (*) - COST:2 [ATK:1/HP:3] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			cards.Add("BRMA06_4", new List<Power> {
//				// TODO [BRMA06_4] Flamewaker Acolyte && Test: Flamewaker Acolyte_BRMA06_4
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA06_4H] Flamewaker Acolyte (*) - COST:2 [ATK:3/HP:3] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			cards.Add("BRMA06_4H", new List<Power> {
//				// TODO [BRMA06_4H] Flamewaker Acolyte && Test: Flamewaker Acolyte_BRMA06_4H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA09_2Ht] Whelp (*) - COST:1 [ATK:2/HP:2] 
//			// - Race: dragon, Set: brm, 
//			// --------------------------------------------------------
//			cards.Add("BRMA09_2Ht", new List<Power> {
//				// TODO [BRMA09_2Ht] Whelp && Test: Whelp_BRMA09_2Ht
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA09_2t] Whelp (*) - COST:1 [ATK:1/HP:1] 
//			// - Race: dragon, Set: brm, 
//			// --------------------------------------------------------
//			cards.Add("BRMA09_2t", new List<Power> {
//				// TODO [BRMA09_2t] Whelp && Test: Whelp_BRMA09_2t
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA09_3Ht] Old Horde Orc (*) - COST:1 [ATK:2/HP:2] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Taunt</b>
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA09_3Ht", new List<Power> {
//				// TODO [BRMA09_3Ht] Old Horde Orc && Test: Old Horde Orc_BRMA09_3Ht
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA09_3t] Old Horde Orc (*) - COST:1 [ATK:1/HP:1] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Taunt</b>
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA09_3t", new List<Power> {
//				// TODO [BRMA09_3t] Old Horde Orc && Test: Old Horde Orc_BRMA09_3t
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA09_4Ht] Dragonkin (*) - COST:1 [ATK:5/HP:4] 
//			// - Race: dragon, Set: brm, 
//			// --------------------------------------------------------
//			cards.Add("BRMA09_4Ht", new List<Power> {
//				// TODO [BRMA09_4Ht] Dragonkin && Test: Dragonkin_BRMA09_4Ht
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA09_4t] Dragonkin (*) - COST:1 [ATK:3/HP:1] 
//			// - Race: dragon, Set: brm, 
//			// --------------------------------------------------------
//			cards.Add("BRMA09_4t", new List<Power> {
//				// TODO [BRMA09_4t] Dragonkin && Test: Dragonkin_BRMA09_4t
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA09_5Ht] Gyth (*) - COST:3 [ATK:8/HP:8] 
//			// - Race: dragon, Set: brm, Rarity: legendary
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA09_5Ht", new List<Power> {
//				// TODO [BRMA09_5Ht] Gyth && Test: Gyth_BRMA09_5Ht
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA09_5t] Gyth (*) - COST:3 [ATK:8/HP:4] 
//			// - Race: dragon, Set: brm, Rarity: legendary
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA09_5t", new List<Power> {
//				// TODO [BRMA09_5t] Gyth && Test: Gyth_BRMA09_5t
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA10_4] Corrupted Egg (*) - COST:1 [ATK:0/HP:1] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: When this minion has 4 or more Health, it hatches.
//			// --------------------------------------------------------
//			// GameTag:
//			// - InvisibleDeathrattle = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA10_4", new List<Power> {
//				// TODO [BRMA10_4] Corrupted Egg && Test: Corrupted Egg_BRMA10_4
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA10_4H] Corrupted Egg (*) - COST:1 [ATK:0/HP:3] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: When this minion has 5 or more Health, it hatches.
//			// --------------------------------------------------------
//			// GameTag:
//			// - InvisibleDeathrattle = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA10_4H", new List<Power> {
//				// TODO [BRMA10_4H] Corrupted Egg && Test: Corrupted Egg_BRMA10_4H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA10_5] Chromatic Drake (*) - COST:4 [ATK:7/HP:3] 
//			// - Race: dragon, Set: brm, 
//			// --------------------------------------------------------
//			cards.Add("BRMA10_5", new List<Power> {
//				// TODO [BRMA10_5] Chromatic Drake && Test: Chromatic Drake_BRMA10_5
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA10_5H] Chromatic Drake (*) - COST:4 [ATK:7/HP:7] 
//			// - Race: dragon, Set: brm, 
//			// --------------------------------------------------------
//			cards.Add("BRMA10_5H", new List<Power> {
//				// TODO [BRMA10_5H] Chromatic Drake && Test: Chromatic Drake_BRMA10_5H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA12_8t] Chromatic Dragonkin (*) - COST:2 [ATK:2/HP:3] 
//			// - Race: dragon, Set: brm, 
//			// --------------------------------------------------------
//			// Text: Whenever your opponent casts a spell, gain +2/+2.
//			// --------------------------------------------------------
//			cards.Add("BRMA12_8t", new List<Power> {
//				// TODO [BRMA12_8t] Chromatic Dragonkin && Test: Chromatic Dragonkin_BRMA12_8t
//				new Power
//				{
//					InfoCardId = "BRMA12_8te",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA13_5] Son of the Flame (*) - COST:0 [ATK:6/HP:3] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Battlecry:</b> Deal 6 damage.
//			// --------------------------------------------------------
//			// GameTag:
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_TARGET_IF_AVAILABLE = 0
//			// --------------------------------------------------------
//			cards.Add("BRMA13_5", new List<Power> {
//				// TODO [BRMA13_5] Son of the Flame && Test: Son of the Flame_BRMA13_5
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA13_6] Living Lava (*) - COST:0 [ATK:6/HP:6] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Taunt</b>
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA13_6", new List<Power> {
//				// TODO [BRMA13_6] Living Lava && Test: Living Lava_BRMA13_6
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA13_7] Whirling Ash (*) - COST:0 [ATK:4/HP:5] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Windfury</b>
//			// --------------------------------------------------------
//			// GameTag:
//			// - WINDFURY = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA13_7", new List<Power> {
//				// TODO [BRMA13_7] Whirling Ash && Test: Whirling Ash_BRMA13_7
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA14_12] Magmaw (*) - COST:5 [ATK:10/HP:2] 
//			// - Set: brm, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: <b>Taunt</b>
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA14_12", new List<Power> {
//				// TODO [BRMA14_12] Magmaw && Test: Magmaw_BRMA14_12
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA14_3] Arcanotron (*) - COST:0 [ATK:2/HP:2] 
//			// - Race: mechanical, Set: brm, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: Both players have <b>Spell Damage +2</b>.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - SPELLPOWER = 2
//			// --------------------------------------------------------
//			cards.Add("BRMA14_3", new List<Power> {
//				// TODO [BRMA14_3] Arcanotron && Test: Arcanotron_BRMA14_3
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA14_5] Toxitron (*) - COST:1 [ATK:3/HP:3] 
//			// - Race: mechanical, Set: brm, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: At the start of your turn, deal 1 damage to all other minions.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA14_5", new List<Power> {
//				// TODO [BRMA14_5] Toxitron && Test: Toxitron_BRMA14_5
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA14_5H] Toxitron (*) - COST:1 [ATK:4/HP:4] 
//			// - Race: mechanical, Set: brm, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: At the start of your turn, deal 1 damage to all other minions.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA14_5H", new List<Power> {
//				// TODO [BRMA14_5H] Toxitron && Test: Toxitron_BRMA14_5H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA14_7] Electron (*) - COST:3 [ATK:5/HP:5] 
//			// - Race: mechanical, Set: brm, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: All spells cost (3) less.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - AURA = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA14_7", new List<Power> {
//				// TODO [BRMA14_7] Electron && Test: Electron_BRMA14_7
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA14_7H] Electron (*) - COST:3 [ATK:6/HP:6] 
//			// - Race: mechanical, Set: brm, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: All spells cost (3) less.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA14_7H", new List<Power> {
//				// TODO [BRMA14_7H] Electron && Test: Electron_BRMA14_7H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA14_9] Magmatron (*) - COST:5 [ATK:7/HP:7] 
//			// - Race: mechanical, Set: brm, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: Whenever a player plays a card, Magmatron deals 2 damage to them.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - AURA = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA14_9", new List<Power> {
//				// TODO [BRMA14_9] Magmatron && Test: Magmatron_BRMA14_9
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA14_9H] Magmatron (*) - COST:5 [ATK:8/HP:8] 
//			// - Race: mechanical, Set: brm, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: Whenever a player plays a card, Magmatron deals 2 damage to them.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA14_9H", new List<Power> {
//				// TODO [BRMA14_9H] Magmatron && Test: Magmatron_BRMA14_9H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA15_4] Aberration (*) - COST:1 [ATK:1/HP:1] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Charge</b>
//			// --------------------------------------------------------
//			// GameTag:
//			// - CHARGE = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA15_4", new List<Power> {
//				// TODO [BRMA15_4] Aberration && Test: Aberration_BRMA15_4
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA17_6] Bone Construct (*) - COST:1 [ATK:2/HP:1] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			cards.Add("BRMA17_6", new List<Power> {
//				// TODO [BRMA17_6] Bone Construct && Test: Bone Construct_BRMA17_6
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA17_6H] Bone Construct (*) - COST:1 [ATK:4/HP:2] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			cards.Add("BRMA17_6H", new List<Power> {
//				// TODO [BRMA17_6H] Bone Construct && Test: Bone Construct_BRMA17_6H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMA17_7] Chromatic Prototype (*) - COST:2 [ATK:1/HP:4] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: <b>Taunt</b>
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA17_7", new List<Power> {
//				// TODO [BRMA17_7] Chromatic Prototype && Test: Chromatic Prototype_BRMA17_7
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMA01_4] Get 'em! (*) - COST:3 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: Summon four 1/1 Dwarves with <b>Taunt</b>.
//			// --------------------------------------------------------
//			// RefTag:
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA01_4", new List<Power> {
//				// TODO [BRMA01_4] Get 'em! && Test: Get 'em!_BRMA01_4
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMA04_4] Rock Out (*) - COST:3 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: Summon 3 Firesworn. <b>Overload:</b> (2)
//			// --------------------------------------------------------
//			// GameTag:
//			// - OVERLOAD = 2
//			// - OVERLOAD_OWED = 2
//			// --------------------------------------------------------
//			cards.Add("BRMA04_4", new List<Power> {
//				// TODO [BRMA04_4] Rock Out && Test: Rock Out_BRMA04_4
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMA04_4H] Rock Out (*) - COST:3 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: Summon 3 Firesworn. <b>Overload:</b> (2)
//			// --------------------------------------------------------
//			// GameTag:
//			// - OVERLOAD = 2
//			// - OVERLOAD_OWED = 2
//			// --------------------------------------------------------
//			cards.Add("BRMA04_4H", new List<Power> {
//				// TODO [BRMA04_4H] Rock Out && Test: Rock Out_BRMA04_4H
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMA05_3] Living Bomb (*) - COST:4 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: Choose an enemy minion. If it lives until your next turn, deal $5 damage to all enemies. @spelldmg
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_ENEMY_TARGET = 0
//			// - REQ_MINION_TARGET = 0
//			// - REQ_TARGET_TO_PLAY = 0
//			// --------------------------------------------------------
//			cards.Add("BRMA05_3", new List<Power> {
//				// TODO [BRMA05_3] Living Bomb && Test: Living Bomb_BRMA05_3
//				new Power
//				{
//					InfoCardId = "BRMA05_3e",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMA05_3H] Living Bomb (*) - COST:3 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: Choose an enemy minion. If it lives until your next turn, deal $10 damage to all enemies. @spelldmg
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_ENEMY_TARGET = 0
//			// - REQ_MINION_TARGET = 0
//			// - REQ_TARGET_TO_PLAY = 0
//			// --------------------------------------------------------
//			cards.Add("BRMA05_3H", new List<Power> {
//				// TODO [BRMA05_3H] Living Bomb && Test: Living Bomb_BRMA05_3H
//				new Power
//				{
//					InfoCardId = "BRMA05_3He",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMA07_3] TIME FOR SMASH (*) - COST:4 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: Deal $5 damage to a random enemy. Gain 5 Armor. @spelldmg
//			// --------------------------------------------------------
//			cards.Add("BRMA07_3", new List<Power> {
//				// TODO [BRMA07_3] TIME FOR SMASH && Test: TIME FOR SMASH_BRMA07_3
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMA08_3] Drakkisath's Command (*) - COST:1 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: Destroy a minion. Gain 10 Armor.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_MINION_TARGET = 0
//			// - REQ_TARGET_TO_PLAY = 0
//			// --------------------------------------------------------
//			cards.Add("BRMA08_3", new List<Power> {
//				// TODO [BRMA08_3] Drakkisath's Command && Test: Drakkisath's Command_BRMA08_3
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMA09_6] The True Warchief (*) - COST:1 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: Destroy a Legendary minion.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_MINION_TARGET = 0
//			// - REQ_TARGET_TO_PLAY = 0
//			// - REQ_LEGENDARY_TARGET = 0
//			// --------------------------------------------------------
//			cards.Add("BRMA09_6", new List<Power> {
//				// TODO [BRMA09_6] The True Warchief && Test: The True Warchief_BRMA09_6
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMA11_3] Burning Adrenaline (*) - COST:0 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: Deal $2 damage to the enemy hero. @spelldmg
//			// --------------------------------------------------------
//			cards.Add("BRMA11_3", new List<Power> {
//				// TODO [BRMA11_3] Burning Adrenaline && Test: Burning Adrenaline_BRMA11_3
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMA12_3] Brood Affliction: Red (*) - COST:1 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: While this is in your hand, take 1 damage at the start of your turn.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ImmuneToSpellpower = 1
//			// - EVIL_GLOW = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA12_3", new List<Power> {
//				// TODO [BRMA12_3] Brood Affliction: Red && Test: Brood Affliction: Red_BRMA12_3
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMA12_3H] Brood Affliction: Red (*) - COST:3 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: While this is in your hand, take 3 damage at the start of your turn.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ImmuneToSpellpower = 1
//			// - EVIL_GLOW = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA12_3H", new List<Power> {
//				// TODO [BRMA12_3H] Brood Affliction: Red && Test: Brood Affliction: Red_BRMA12_3H
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMA12_4] Brood Affliction: Green (*) - COST:1 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: While this is in your hand, restore 2 health to your opponent at the start of your turn.
//			// --------------------------------------------------------
//			// GameTag:
//			// - EVIL_GLOW = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA12_4", new List<Power> {
//				// TODO [BRMA12_4] Brood Affliction: Green && Test: Brood Affliction: Green_BRMA12_4
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMA12_4H] Brood Affliction: Green (*) - COST:3 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: While this is in your hand, restore 6 health to your opponent at the start of your turn.
//			// --------------------------------------------------------
//			// GameTag:
//			// - EVIL_GLOW = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA12_4H", new List<Power> {
//				// TODO [BRMA12_4H] Brood Affliction: Green && Test: Brood Affliction: Green_BRMA12_4H
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMA12_5] Brood Affliction: Blue (*) - COST:1 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: While this is in your hand, Chromaggus' spells cost (1) less.
//			// --------------------------------------------------------
//			// GameTag:
//			// - EVIL_GLOW = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA12_5", new List<Power> {
//				// TODO [BRMA12_5] Brood Affliction: Blue && Test: Brood Affliction: Blue_BRMA12_5
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMA12_5H] Brood Affliction: Blue (*) - COST:3 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: While this is in your hand, Chromaggus' spells cost (3) less.
//			// --------------------------------------------------------
//			// GameTag:
//			// - EVIL_GLOW = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA12_5H", new List<Power> {
//				// TODO [BRMA12_5H] Brood Affliction: Blue && Test: Brood Affliction: Blue_BRMA12_5H
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMA12_6] Brood Affliction: Black (*) - COST:1 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: While this is in your hand, whenever Chromaggus draws a card, he gets another copy of it.
//			// --------------------------------------------------------
//			// GameTag:
//			// - EVIL_GLOW = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA12_6", new List<Power> {
//				// TODO [BRMA12_6] Brood Affliction: Black && Test: Brood Affliction: Black_BRMA12_6
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMA12_6H] Brood Affliction: Black (*) - COST:3 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: While this is in your hand, whenever Chromaggus draws a card, he gets another copy of it.
//			// --------------------------------------------------------
//			// GameTag:
//			// - EVIL_GLOW = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA12_6H", new List<Power> {
//				// TODO [BRMA12_6H] Brood Affliction: Black && Test: Brood Affliction: Black_BRMA12_6H
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMA12_7] Brood Affliction: Bronze (*) - COST:1 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: While this is in your hand, Chromaggus' minions cost (1) less.
//			// --------------------------------------------------------
//			// GameTag:
//			// - EVIL_GLOW = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA12_7", new List<Power> {
//				// TODO [BRMA12_7] Brood Affliction: Bronze && Test: Brood Affliction: Bronze_BRMA12_7
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMA12_7H] Brood Affliction: Bronze (*) - COST:3 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: While this is in your hand, Chromaggus' minions cost (3) less.
//			// --------------------------------------------------------
//			// GameTag:
//			// - EVIL_GLOW = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA12_7H", new List<Power> {
//				// TODO [BRMA12_7H] Brood Affliction: Bronze && Test: Brood Affliction: Bronze_BRMA12_7H
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMA12_8] Chromatic Mutation (*) - COST:2 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: Transform a minion into a 2/2 Chromatic Dragonkin.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_MINION_TARGET = 0
//			// - REQ_TARGET_TO_PLAY = 0
//			// --------------------------------------------------------
//			cards.Add("BRMA12_8", new List<Power> {
//				// TODO [BRMA12_8] Chromatic Mutation && Test: Chromatic Mutation_BRMA12_8
//				new Power
//				{
//					InfoCardId = "BRMA12_8te",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMA13_8] DIE, INSECT! (*) - COST:0 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: Deal $8 damage to a random enemy. @spelldmg
//			// --------------------------------------------------------
//			// GameTag:
//			// - AFFECTED_BY_SPELL_POWER = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA13_8", new List<Power> {
//				// TODO [BRMA13_8] DIE, INSECT! && Test: DIE, INSECT!_BRMA13_8
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMA14_11] Recharge (*) - COST:0 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: Fill all empty Mana Crystals.
//			// --------------------------------------------------------
//			cards.Add("BRMA14_11", new List<Power> {
//				// TODO [BRMA14_11] Recharge && Test: Recharge_BRMA14_11
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMA15_3] Release the Aberrations! (*) - COST:2 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: Summon 3 Aberrations.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_NUM_MINION_SLOTS = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA15_3", new List<Power> {
//				// TODO [BRMA15_3] Release the Aberrations! && Test: Release the Aberrations!_BRMA15_3
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMA16_3] Sonic Breath (*) - COST:4 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: Deal $3 damage to a minion. Give your weapon +3 Attack. @spelldmg
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_MINION_TARGET = 0
//			// - REQ_TARGET_TO_PLAY = 0
//			// - REQ_WEAPON_EQUIPPED = 0
//			// --------------------------------------------------------
//			cards.Add("BRMA16_3", new List<Power> {
//				// TODO [BRMA16_3] Sonic Breath && Test: Sonic Breath_BRMA16_3
//				new Power
//				{
//					InfoCardId = "BRMA16_3e",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMA16_4] Reverberating Gong (*) - COST:1 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: Destroy your opponent's weapon.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_ENEMY_WEAPON_EQUIPPED = 0
//			// --------------------------------------------------------
//			cards.Add("BRMA16_4", new List<Power> {
//				// TODO [BRMA16_4] Reverberating Gong && Test: Reverberating Gong_BRMA16_4
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMA17_4] LAVA! (*) - COST:2 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: Deal $2 damage to all minions. @spelldmg
//			// --------------------------------------------------------
//			cards.Add("BRMA17_4", new List<Power> {
//				// TODO [BRMA17_4] LAVA! && Test: LAVA!_BRMA17_4
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMA_01] Flameheart (*) - COST:3 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: Draw 2 cards.
//			//       Gain 4 Armor.
//			// --------------------------------------------------------
//			cards.Add("BRMA_01", new List<Power> {
//				// TODO [BRMA_01] Flameheart && Test: Flameheart_BRMA_01
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- WEAPON - NEUTRAL
//			// [BRMA10_6] Razorgore's Claws (*) - COST:1 [ATK:1/HP:0] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: Whenever a Corrupted Egg dies, gain +1 Attack.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DURABILITY = 5
//			// --------------------------------------------------------
//			cards.Add("BRMA10_6", new List<Power> {
//				// TODO [BRMA10_6] Razorgore's Claws && Test: Razorgore's Claws_BRMA10_6
//				new Power
//				{
//					InfoCardId = "BRMA10_6e",
//					Activation = PowerActivation.WEAPON,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- WEAPON - NEUTRAL
//			// [BRMA16_5] Dragonteeth (*) - COST:1 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// Text: Whenever your opponent plays a card, gain +1 Attack.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DURABILITY = 6
//			// --------------------------------------------------------
//			cards.Add("BRMA16_5", new List<Power> {
//				// TODO [BRMA16_5] Dragonteeth && Test: Dragonteeth_BRMA16_5
//				new Power
//				{
//					InfoCardId = "BRMA16_5e",
//					Activation = PowerActivation.WEAPON,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- WEAPON - NEUTRAL
//			// [BRMA17_9] Onyxiclaw (*) - COST:2 [ATK:2/HP:0] 
//			// - Set: brm, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - DURABILITY = 6
//			// --------------------------------------------------------
//			cards.Add("BRMA17_9", new List<Power> {
//				// TODO [BRMA17_9] Onyxiclaw && Test: Onyxiclaw_BRMA17_9
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
//			NeutralNonCollect(cards);
//		}
//	}
//}
