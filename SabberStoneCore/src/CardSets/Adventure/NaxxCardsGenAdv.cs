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
//	public class NaxxCardsGenAdv
//	{
//		private static void Heroes(IDictionary<string, List<Power>> cards)
//		{
//			// ----------------------------------------- HERO - NEUTRAL
//			// [NAX10_01] Patchwerk (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// - HERO_POWER = 1886
//			// --------------------------------------------------------
//			cards.Add("NAX10_01", new List<Power> {
//				// TODO [NAX10_01] Patchwerk && Test: Patchwerk_NAX10_01
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [NAX10_01H] Patchwerk (*) - COST:0 [ATK:0/HP:45] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// - HERO_POWER = 2133
//			// --------------------------------------------------------
//			cards.Add("NAX10_01H", new List<Power> {
//				// TODO [NAX10_01H] Patchwerk && Test: Patchwerk_NAX10_01H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [NAX11_01] Grobbulus (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 1888
//			// --------------------------------------------------------
//			cards.Add("NAX11_01", new List<Power> {
//				// TODO [NAX11_01] Grobbulus && Test: Grobbulus_NAX11_01
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [NAX11_01H] Grobbulus (*) - COST:0 [ATK:0/HP:45] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2135
//			// --------------------------------------------------------
//			cards.Add("NAX11_01H", new List<Power> {
//				// TODO [NAX11_01H] Grobbulus && Test: Grobbulus_NAX11_01H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [NAX12_01] Gluth (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 1891
//			// --------------------------------------------------------
//			cards.Add("NAX12_01", new List<Power> {
//				// TODO [NAX12_01] Gluth && Test: Gluth_NAX12_01
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [NAX12_01H] Gluth (*) - COST:0 [ATK:0/HP:45] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2141
//			// --------------------------------------------------------
//			cards.Add("NAX12_01H", new List<Power> {
//				// TODO [NAX12_01H] Gluth && Test: Gluth_NAX12_01H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [NAX13_01] Thaddius (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 1897
//			// --------------------------------------------------------
//			cards.Add("NAX13_01", new List<Power> {
//				// TODO [NAX13_01] Thaddius && Test: Thaddius_NAX13_01
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [NAX13_01H] Thaddius (*) - COST:0 [ATK:0/HP:45] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 1897
//			// --------------------------------------------------------
//			cards.Add("NAX13_01H", new List<Power> {
//				// TODO [NAX13_01H] Thaddius && Test: Thaddius_NAX13_01H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [NAX14_01] Sapphiron (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 1905
//			// --------------------------------------------------------
//			cards.Add("NAX14_01", new List<Power> {
//				// TODO [NAX14_01] Sapphiron && Test: Sapphiron_NAX14_01
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [NAX14_01H] Sapphiron (*) - COST:0 [ATK:0/HP:45] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 1905
//			// --------------------------------------------------------
//			cards.Add("NAX14_01H", new List<Power> {
//				// TODO [NAX14_01H] Sapphiron && Test: Sapphiron_NAX14_01H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [NAX15_01] Kel'Thuzad (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 1901
//			// --------------------------------------------------------
//			cards.Add("NAX15_01", new List<Power> {
//				// TODO [NAX15_01] Kel'Thuzad && Test: Kel'Thuzad_NAX15_01
//				new Power
//				{
//					InfoCardId = "NAX15_01e",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [NAX15_01H] Kel'Thuzad (*) - COST:0 [ATK:0/HP:45] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2148
//			// --------------------------------------------------------
//			cards.Add("NAX15_01H", new List<Power> {
//				// TODO [NAX15_01H] Kel'Thuzad && Test: Kel'Thuzad_NAX15_01H
//				new Power
//				{
//					InfoCardId = "NAX15_01He",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [NAX1_01] Anub'Rekhan (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 1831
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_NUM_MINION_SLOTS = 1
//			// --------------------------------------------------------
//			cards.Add("NAX1_01", new List<Power> {
//				// TODO [NAX1_01] Anub'Rekhan && Test: Anub'Rekhan_NAX1_01
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [NAX1h_01] Anub'Rekhan (*) - COST:0 [ATK:0/HP:45] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2103
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_NUM_MINION_SLOTS = 1
//			// --------------------------------------------------------
//			cards.Add("NAX1h_01", new List<Power> {
//				// TODO [NAX1h_01] Anub'Rekhan && Test: Anub'Rekhan_NAX1h_01
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [NAX2_01] Grand Widow Faerlina (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 1840
//			// --------------------------------------------------------
//			cards.Add("NAX2_01", new List<Power> {
//				// TODO [NAX2_01] Grand Widow Faerlina && Test: Grand Widow Faerlina_NAX2_01
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [NAX2_01H] Grand Widow Faerlina (*) - COST:0 [ATK:0/HP:45] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2105
//			// --------------------------------------------------------
//			cards.Add("NAX2_01H", new List<Power> {
//				// TODO [NAX2_01H] Grand Widow Faerlina && Test: Grand Widow Faerlina_NAX2_01H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [NAX3_01] Maexxna (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 1867
//			// --------------------------------------------------------
//			cards.Add("NAX3_01", new List<Power> {
//				// TODO [NAX3_01] Maexxna && Test: Maexxna_NAX3_01
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [NAX3_01H] Maexxna (*) - COST:0 [ATK:0/HP:45] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2107
//			// --------------------------------------------------------
//			cards.Add("NAX3_01H", new List<Power> {
//				// TODO [NAX3_01H] Maexxna && Test: Maexxna_NAX3_01H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// -------------------------------------------- HERO - MAGE
//			// [NAX4_01] Noth the Plaguebringer (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 1849
//			// --------------------------------------------------------
//			cards.Add("NAX4_01", new List<Power> {
//				// TODO [NAX4_01] Noth the Plaguebringer && Test: Noth the Plaguebringer_NAX4_01
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// -------------------------------------------- HERO - MAGE
//			// [NAX4_01H] Noth the Plaguebringer (*) - COST:0 [ATK:0/HP:45] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2115
//			// --------------------------------------------------------
//			cards.Add("NAX4_01H", new List<Power> {
//				// TODO [NAX4_01H] Noth the Plaguebringer && Test: Noth the Plaguebringer_NAX4_01H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - WARLOCK
//			// [NAX5_01] Heigan the Unclean (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 1854
//			// --------------------------------------------------------
//			cards.Add("NAX5_01", new List<Power> {
//				// TODO [NAX5_01] Heigan the Unclean && Test: Heigan the Unclean_NAX5_01
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - WARLOCK
//			// [NAX5_01H] Heigan the Unclean (*) - COST:0 [ATK:0/HP:45] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2117
//			// --------------------------------------------------------
//			cards.Add("NAX5_01H", new List<Power> {
//				// TODO [NAX5_01H] Heigan the Unclean && Test: Heigan the Unclean_NAX5_01H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [NAX6_01] Loatheb (*) - COST:0 [ATK:0/HP:75] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 1862
//			// --------------------------------------------------------
//			cards.Add("NAX6_01", new List<Power> {
//				// TODO [NAX6_01] Loatheb && Test: Loatheb_NAX6_01
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [NAX6_01H] Loatheb (*) - COST:0 [ATK:0/HP:99] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2119
//			// --------------------------------------------------------
//			cards.Add("NAX6_01H", new List<Power> {
//				// TODO [NAX6_01H] Loatheb && Test: Loatheb_NAX6_01H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [NAX7_01] Instructor Razuvious (*) - COST:0 [ATK:0/HP:40] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 1870
//			// --------------------------------------------------------
//			cards.Add("NAX7_01", new List<Power> {
//				// TODO [NAX7_01] Instructor Razuvious && Test: Instructor Razuvious_NAX7_01
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [NAX7_01H] Instructor Razuvious (*) - COST:0 [ATK:0/HP:55] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2129
//			// --------------------------------------------------------
//			cards.Add("NAX7_01H", new List<Power> {
//				// TODO [NAX7_01H] Instructor Razuvious && Test: Instructor Razuvious_NAX7_01H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [NAX8_01] Gothik the Harvester (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 1872
//			// --------------------------------------------------------
//			cards.Add("NAX8_01", new List<Power> {
//				// TODO [NAX8_01] Gothik the Harvester && Test: Gothik the Harvester_NAX8_01
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [NAX8_01H] Gothik the Harvester (*) - COST:0 [ATK:0/HP:45] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2121
//			// --------------------------------------------------------
//			cards.Add("NAX8_01H", new List<Power> {
//				// TODO [NAX8_01H] Gothik the Harvester && Test: Gothik the Harvester_NAX8_01H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [NAX9_01] Baron Rivendare (*) - COST:0 [ATK:0/HP:7] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 1883
//			// --------------------------------------------------------
//			cards.Add("NAX9_01", new List<Power> {
//				// TODO [NAX9_01] Baron Rivendare && Test: Baron Rivendare_NAX9_01
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [NAX9_01H] Baron Rivendare (*) - COST:0 [ATK:0/HP:14] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 1883
//			// --------------------------------------------------------
//			cards.Add("NAX9_01H", new List<Power> {
//				// TODO [NAX9_01H] Baron Rivendare && Test: Baron Rivendare_NAX9_01H
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
//			// [NAX10_03] Hateful Strike (*) - COST:4 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Destroy a minion.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_MINION_TARGET = 0
//			// - REQ_TARGET_TO_PLAY = 0
//			// --------------------------------------------------------
//			cards.Add("NAX10_03", new List<Power> {
//				// TODO [NAX10_03] Hateful Strike && Test: Hateful Strike_NAX10_03
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [NAX10_03H] Hateful Strike (*) - COST:4 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Destroy a minion.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_MINION_TARGET = 0
//			// - REQ_TARGET_TO_PLAY = 0
//			// --------------------------------------------------------
//			cards.Add("NAX10_03H", new List<Power> {
//				// TODO [NAX10_03H] Hateful Strike && Test: Hateful Strike_NAX10_03H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [NAX11_02] Poison Cloud (*) - COST:2 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Deal 1 damage to all minions. If any die, summon a slime.
//			// --------------------------------------------------------
//			cards.Add("NAX11_02", new List<Power> {
//				// TODO [NAX11_02] Poison Cloud && Test: Poison Cloud_NAX11_02
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [NAX11_02H] Poison Cloud (*) - COST:0 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Deal 2 damage to all enemies. If any die, summon a slime.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("NAX11_02H", new List<Power> {
//				// TODO [NAX11_02H] Poison Cloud && Test: Poison Cloud_NAX11_02H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [NAX12_02] Decimate (*) - COST:2 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Change the Health of all minions to 1.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_MINIMUM_ENEMY_MINIONS = 1
//			// --------------------------------------------------------
//			cards.Add("NAX12_02", new List<Power> {
//				// TODO [NAX12_02] Decimate && Test: Decimate_NAX12_02
//				new Power
//				{
//					InfoCardId = "NAX12_02e",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [NAX12_02H] Decimate (*) - COST:0 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Change the Health of enemy minions to 1.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_MINIMUM_ENEMY_MINIONS = 1
//			// --------------------------------------------------------
//			cards.Add("NAX12_02H", new List<Power> {
//				// TODO [NAX12_02H] Decimate && Test: Decimate_NAX12_02H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [NAX13_02] Polarity Shift (*) - COST:0 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Swap the Attack and Health of all minions.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("NAX13_02", new List<Power> {
//				// TODO [NAX13_02] Polarity Shift && Test: Polarity Shift_NAX13_02
//				new Power
//				{
//					InfoCardId = "NAX13_02e",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [NAX14_02] Frost Breath (*) - COST:0 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Destroy all enemy minions that aren't <b>Frozen</b>.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("NAX14_02", new List<Power> {
//				// TODO [NAX14_02] Frost Breath && Test: Frost Breath_NAX14_02
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [NAX15_02] Frost Blast (*) - COST:0 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Deal 2 damage to the enemy hero and <b>Freeze</b> it.
//			// --------------------------------------------------------
//			// GameTag:
//			// - FREEZE = 1
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("NAX15_02", new List<Power> {
//				// TODO [NAX15_02] Frost Blast && Test: Frost Blast_NAX15_02
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [NAX15_02H] Frost Blast (*) - COST:0 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Deal 3 damage to the enemy hero and <b>Freeze</b> it.
//			// --------------------------------------------------------
//			// GameTag:
//			// - FREEZE = 1
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("NAX15_02H", new List<Power> {
//				// TODO [NAX15_02H] Frost Blast && Test: Frost Blast_NAX15_02H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [NAX15_04] Chains (*) - COST:8 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Take control of a random enemy minion until end of turn.
//			// --------------------------------------------------------
//			cards.Add("NAX15_04", new List<Power> {
//				// TODO [NAX15_04] Chains && Test: Chains_NAX15_04
//				new Power
//				{
//					InfoCardId = "NAX15_04a",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [NAX15_04H] Chains (*) - COST:8 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Take control of a random enemy minion.
//			// --------------------------------------------------------
//			cards.Add("NAX15_04H", new List<Power> {
//				// TODO [NAX15_04H] Chains && Test: Chains_NAX15_04H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [NAX1_04] Skitter (*) - COST:2 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Summon a 3/1 Nerubian.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_NUM_MINION_SLOTS = 1
//			// --------------------------------------------------------
//			cards.Add("NAX1_04", new List<Power> {
//				// TODO [NAX1_04] Skitter && Test: Skitter_NAX1_04
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [NAX1h_04] Skitter (*) - COST:2 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Summon a 4/4 Nerubian.
//			// --------------------------------------------------------
//			cards.Add("NAX1h_04", new List<Power> {
//				// TODO [NAX1h_04] Skitter && Test: Skitter_NAX1h_04
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [NAX2_03] Rain of Fire (*) - COST:2 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Fire a missile for each card in your opponent's hand.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ImmuneToSpellpower = 1
//			// --------------------------------------------------------
//			cards.Add("NAX2_03", new List<Power> {
//				// TODO [NAX2_03] Rain of Fire && Test: Rain of Fire_NAX2_03
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [NAX2_03H] Rain of Fire (*) - COST:1 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Fire a missile for each card in your opponent's hand.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ImmuneToSpellpower = 1
//			// --------------------------------------------------------
//			cards.Add("NAX2_03H", new List<Power> {
//				// TODO [NAX2_03H] Rain of Fire && Test: Rain of Fire_NAX2_03H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [NAX3_02] Web Wrap (*) - COST:3 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Return a random enemy minion to your opponent's hand.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_MINIMUM_ENEMY_MINIONS = 1
//			// --------------------------------------------------------
//			cards.Add("NAX3_02", new List<Power> {
//				// TODO [NAX3_02] Web Wrap && Test: Web Wrap_NAX3_02
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [NAX3_02H] Web Wrap (*) - COST:0 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Return 2 random enemy minions to your opponent's hand.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("NAX3_02H", new List<Power> {
//				// TODO [NAX3_02H] Web Wrap && Test: Web Wrap_NAX3_02H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [NAX4_04] Raise Dead (*) - COST:0 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Passive Hero Power</b>
//			//       Whenever an enemy dies, raise a 1/1 Skeleton.
//			// --------------------------------------------------------
//			cards.Add("NAX4_04", new List<Power> {
//				// TODO [NAX4_04] Raise Dead && Test: Raise Dead_NAX4_04
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [NAX4_04H] Raise Dead (*) - COST:0 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Passive Hero Power</b>
//			//       Whenever an enemy dies, raise a 5/5 Skeleton.
//			// --------------------------------------------------------
//			cards.Add("NAX4_04H", new List<Power> {
//				// TODO [NAX4_04H] Raise Dead && Test: Raise Dead_NAX4_04H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [NAX5_02] Eruption (*) - COST:1 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Deal 2 damage to the left-most enemy minion.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_MINIMUM_ENEMY_MINIONS = 1
//			// --------------------------------------------------------
//			cards.Add("NAX5_02", new List<Power> {
//				// TODO [NAX5_02] Eruption && Test: Eruption_NAX5_02
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [NAX5_02H] Eruption (*) - COST:0 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Deal 3 damage to the left-most enemy minion.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_MINIMUM_ENEMY_MINIONS = 0
//			// --------------------------------------------------------
//			cards.Add("NAX5_02H", new List<Power> {
//				// TODO [NAX5_02H] Eruption && Test: Eruption_NAX5_02H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [NAX6_02] Necrotic Aura (*) - COST:2 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Deal 3 damage to the enemy hero.
//			// --------------------------------------------------------
//			cards.Add("NAX6_02", new List<Power> {
//				// TODO [NAX6_02] Necrotic Aura && Test: Necrotic Aura_NAX6_02
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [NAX6_02H] Necrotic Aura (*) - COST:0 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Deal 3 damage to the enemy hero.
//			// --------------------------------------------------------
//			cards.Add("NAX6_02H", new List<Power> {
//				// TODO [NAX6_02H] Necrotic Aura && Test: Necrotic Aura_NAX6_02H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [NAX7_03] Unbalancing Strike (*) - COST:2 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Deal 3 damage.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_TARGET_TO_PLAY = 0
//			// --------------------------------------------------------
//			cards.Add("NAX7_03", new List<Power> {
//				// TODO [NAX7_03] Unbalancing Strike && Test: Unbalancing Strike_NAX7_03
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [NAX7_03H] Unbalancing Strike (*) - COST:1 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Deal 4 damage.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_TARGET_TO_PLAY = 0
//			// --------------------------------------------------------
//			cards.Add("NAX7_03H", new List<Power> {
//				// TODO [NAX7_03H] Unbalancing Strike && Test: Unbalancing Strike_NAX7_03H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [NAX8_02] Harvest (*) - COST:2 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Draw a card.
//			// --------------------------------------------------------
//			cards.Add("NAX8_02", new List<Power> {
//				// TODO [NAX8_02] Harvest && Test: Harvest_NAX8_02
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [NAX8_02H] Harvest (*) - COST:1 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Draw a card. Gain a Mana Crystal.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("NAX8_02H", new List<Power> {
//				// TODO [NAX8_02H] Harvest && Test: Harvest_NAX8_02H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [NAX9_06] Unholy Shadow (*) - COST:5 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Draw 2 cards.
//			// --------------------------------------------------------
//			cards.Add("NAX9_06", new List<Power> {
//				// TODO [NAX9_06] Unholy Shadow && Test: Unholy Shadow_NAX9_06
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
//			// [NAX11_04e] Mutating Injection (*) - COST:0 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: +4/+4 and <b>Taunt</b>.
//			// --------------------------------------------------------
//			// RefTag:
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("NAX11_04e", new List<Power> {
//				// TODO [NAX11_04e] Mutating Injection && Test: Mutating Injection_NAX11_04e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [NAX12_02e] Decimate (*) - COST:0 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: Health changed to 1.
//			// --------------------------------------------------------
//			cards.Add("NAX12_02e", new List<Power> {
//				// TODO [NAX12_02e] Decimate && Test: Decimate_NAX12_02e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [NAX12_03e] Extra Teeth (*) - COST:0 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: Increased Attack.
//			// --------------------------------------------------------
//			cards.Add("NAX12_03e", new List<Power> {
//				// TODO [NAX12_03e] Extra Teeth && Test: Extra Teeth_NAX12_03e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [NAX12_04e] Enrage (*) - COST:0 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: +6 Attack this turn.
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAG_ONE_TURN_EFFECT = 1
//			// --------------------------------------------------------
//			cards.Add("NAX12_04e", new List<Power> {
//				// TODO [NAX12_04e] Enrage && Test: Enrage_NAX12_04e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [NAX13_02e] Polarity (*) - COST:0 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: Attack and Health swapped.
//			// --------------------------------------------------------
//			cards.Add("NAX13_02e", new List<Power> {
//				// TODO [NAX13_02e] Polarity && Test: Polarity_NAX13_02e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [NAX13_03e] Supercharged (*) - COST:0 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: +2 Health.
//			// --------------------------------------------------------
//			cards.Add("NAX13_03e", new List<Power> {
//				// TODO [NAX13_03e] Supercharged && Test: Supercharged_NAX13_03e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [NAX15_01e] Interloper! (*) - COST:0 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			cards.Add("NAX15_01e", new List<Power> {
//				// TODO [NAX15_01e] Interloper! && Test: Interloper!_NAX15_01e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [NAX15_01He] Interloper! (*) - COST:0 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			cards.Add("NAX15_01He", new List<Power> {
//				// TODO [NAX15_01He] Interloper! && Test: Interloper!_NAX15_01He
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [NAX15_04a] Slave of Kel'Thuzad (*) - COST:0 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: MINE!
//			// --------------------------------------------------------
//			cards.Add("NAX15_04a", new List<Power> {
//				// TODO [NAX15_04a] Slave of Kel'Thuzad && Test: Slave of Kel'Thuzad_NAX15_04a
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [NAX6_03te] Fungal Growth (*) - COST:0 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: Increased Attack.
//			// --------------------------------------------------------
//			cards.Add("NAX6_03te", new List<Power> {
//				// TODO [NAX6_03te] Fungal Growth && Test: Fungal Growth_NAX6_03te
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [NAX9_07e] Mark of the Horsemen (*) - COST:0 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: +1/+1.
//			// --------------------------------------------------------
//			cards.Add("NAX9_07e", new List<Power> {
//				// TODO [NAX9_07e] Mark of the Horsemen && Test: Mark of the Horsemen_NAX9_07e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [NAX11_03] Fallout Slime (*) - COST:1 [ATK:2/HP:2] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			cards.Add("NAX11_03", new List<Power> {
//				// TODO [NAX11_03] Fallout Slime && Test: Fallout Slime_NAX11_03
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [NAX13_04H] Feugen (*) - COST:5 [ATK:4/HP:7] 
//			// - Set: naxx, Rarity: legendary
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("NAX13_04H", new List<Power> {
//				// TODO [NAX13_04H] Feugen && Test: Feugen_NAX13_04H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [NAX13_05H] Stalagg (*) - COST:5 [ATK:7/HP:4] 
//			// - Set: naxx, Rarity: legendary
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("NAX13_05H", new List<Power> {
//				// TODO [NAX13_05H] Stalagg && Test: Stalagg_NAX13_05H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [NAX14_03] Frozen Champion (*) - COST:5 [ATK:2/HP:10] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: Permanently Frozen.  Adjacent minions are Immune to Frost Breath.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AURA = 1
//			// --------------------------------------------------------
//			// RefTag:
//			// - FREEZE = 1
//			// --------------------------------------------------------
//			cards.Add("NAX14_03", new List<Power> {
//				// TODO [NAX14_03] Frozen Champion && Test: Frozen Champion_NAX14_03
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [NAX15_03n] Guardian of Icecrown (*) - COST:4 [ATK:3/HP:3] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Taunt</b>
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("NAX15_03n", new List<Power> {
//				// TODO [NAX15_03n] Guardian of Icecrown && Test: Guardian of Icecrown_NAX15_03n
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [NAX15_03t] Guardian of Icecrown (*) - COST:4 [ATK:5/HP:5] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Taunt</b>
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("NAX15_03t", new List<Power> {
//				// TODO [NAX15_03t] Guardian of Icecrown && Test: Guardian of Icecrown_NAX15_03t
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [NAX15_05] Mr. Bigglesworth (*) - COST:0 [ATK:1/HP:1] 
//			// - Race: beast, Set: naxx, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: <i>This is Kel'Thuzad's kitty.</i>
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - InvisibleDeathrattle = 1
//			// --------------------------------------------------------
//			cards.Add("NAX15_05", new List<Power> {
//				// TODO [NAX15_05] Mr. Bigglesworth && Test: Mr. Bigglesworth_NAX15_05
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [NAX1_03] Nerubian (*) - COST:2 [ATK:3/HP:1] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			cards.Add("NAX1_03", new List<Power> {
//				// TODO [NAX1_03] Nerubian && Test: Nerubian_NAX1_03
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [NAX1h_03] Nerubian (*) - COST:2 [ATK:4/HP:4] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			cards.Add("NAX1h_03", new List<Power> {
//				// TODO [NAX1h_03] Nerubian && Test: Nerubian_NAX1h_03
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [NAX2_05] Worshipper (*) - COST:3 [ATK:1/HP:4] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: Your hero has +1 Attack on your turn.
//			// --------------------------------------------------------
//			// GameTag:
//			// - InvisibleDeathrattle = 1
//			// - AURA = 1
//			// --------------------------------------------------------
//			cards.Add("NAX2_05", new List<Power> {
//				// TODO [NAX2_05] Worshipper && Test: Worshipper_NAX2_05
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [NAX2_05H] Worshipper (*) - COST:3 [ATK:2/HP:4] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: Your hero has +3 Attack on your turn.
//			// --------------------------------------------------------
//			// GameTag:
//			// - InvisibleDeathrattle = 1
//			// - AURA = 1
//			// --------------------------------------------------------
//			cards.Add("NAX2_05H", new List<Power> {
//				// TODO [NAX2_05H] Worshipper && Test: Worshipper_NAX2_05H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [NAX4_03] Skeleton (*) - COST:1 [ATK:1/HP:1] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			cards.Add("NAX4_03", new List<Power> {
//				// TODO [NAX4_03] Skeleton && Test: Skeleton_NAX4_03
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [NAX4_03H] Skeleton (*) - COST:5 [ATK:5/HP:5] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			cards.Add("NAX4_03H", new List<Power> {
//				// TODO [NAX4_03H] Skeleton && Test: Skeleton_NAX4_03H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [NAX6_03t] Spore (*) - COST:0 [ATK:0/HP:1] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> Give all enemy minions +8 Attack.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("NAX6_03t", new List<Power> {
//				// TODO [NAX6_03t] Spore && Test: Spore_NAX6_03t
//				new Power
//				{
//					InfoCardId = "NAX6_03te",
//					Activation = PowerActivation.DEATHRATTLE,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [NAX7_02] Understudy (*) - COST:2 [ATK:0/HP:7] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Taunt</b>
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("NAX7_02", new List<Power> {
//				// TODO [NAX7_02] Understudy && Test: Understudy_NAX7_02
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [NAX8_03] Unrelenting Trainee (*) - COST:1 [ATK:2/HP:2] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> Summon a Spectral Trainee for your opponent.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("NAX8_03", new List<Power> {
//				// TODO [NAX8_03] Unrelenting Trainee && Test: Unrelenting Trainee_NAX8_03
//				new Power
//				{
//					Activation = PowerActivation.DEATHRATTLE,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [NAX8_03t] Spectral Trainee (*) - COST:1 [ATK:0/HP:2] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: At the start of your turn, deal 1 damage to your hero.
//			// --------------------------------------------------------
//			cards.Add("NAX8_03t", new List<Power> {
//				// TODO [NAX8_03t] Spectral Trainee && Test: Spectral Trainee_NAX8_03t
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [NAX8_04] Unrelenting Warrior (*) - COST:3 [ATK:3/HP:4] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> Summon a Spectral Warrior for your opponent.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("NAX8_04", new List<Power> {
//				// TODO [NAX8_04] Unrelenting Warrior && Test: Unrelenting Warrior_NAX8_04
//				new Power
//				{
//					Activation = PowerActivation.DEATHRATTLE,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [NAX8_04t] Spectral Warrior (*) - COST:3 [ATK:0/HP:4] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: At the start of your turn, deal 1 damage to your hero.
//			// --------------------------------------------------------
//			cards.Add("NAX8_04t", new List<Power> {
//				// TODO [NAX8_04t] Spectral Warrior && Test: Spectral Warrior_NAX8_04t
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [NAX8_05] Unrelenting Rider (*) - COST:6 [ATK:5/HP:6] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> Summon a Spectral Rider for your opponent.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("NAX8_05", new List<Power> {
//				// TODO [NAX8_05] Unrelenting Rider && Test: Unrelenting Rider_NAX8_05
//				new Power
//				{
//					Activation = PowerActivation.DEATHRATTLE,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [NAX8_05t] Spectral Rider (*) - COST:5 [ATK:0/HP:6] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: At the start of your turn, deal 1 damage to your hero.
//			// --------------------------------------------------------
//			cards.Add("NAX8_05t", new List<Power> {
//				// TODO [NAX8_05t] Spectral Rider && Test: Spectral Rider_NAX8_05t
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [NAX9_02] Lady Blaumeux (*) - COST:3 [ATK:1/HP:7] 
//			// - Set: naxx, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: Your hero is <b>Immune</b>.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			// RefTag:
//			// - IMMUNE = 1
//			// --------------------------------------------------------
//			cards.Add("NAX9_02", new List<Power> {
//				// TODO [NAX9_02] Lady Blaumeux && Test: Lady Blaumeux_NAX9_02
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [NAX9_02H] Lady Blaumeux (*) - COST:3 [ATK:2/HP:7] 
//			// - Set: naxx, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: Your hero is <b>Immune</b>.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			// RefTag:
//			// - IMMUNE = 1
//			// --------------------------------------------------------
//			cards.Add("NAX9_02H", new List<Power> {
//				// TODO [NAX9_02H] Lady Blaumeux && Test: Lady Blaumeux_NAX9_02H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [NAX9_03] Thane Korth'azz (*) - COST:3 [ATK:1/HP:7] 
//			// - Set: naxx, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: Your hero is <b>Immune</b>.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			// RefTag:
//			// - IMMUNE = 1
//			// --------------------------------------------------------
//			cards.Add("NAX9_03", new List<Power> {
//				// TODO [NAX9_03] Thane Korth'azz && Test: Thane Korth'azz_NAX9_03
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [NAX9_03H] Thane Korth'azz (*) - COST:3 [ATK:2/HP:7] 
//			// - Set: naxx, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: Your hero is <b>Immune</b>.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			// RefTag:
//			// - IMMUNE = 1
//			// --------------------------------------------------------
//			cards.Add("NAX9_03H", new List<Power> {
//				// TODO [NAX9_03H] Thane Korth'azz && Test: Thane Korth'azz_NAX9_03H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [NAX9_04] Sir Zeliek (*) - COST:3 [ATK:1/HP:7] 
//			// - Set: naxx, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: Your hero is <b>Immune</b>.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			// RefTag:
//			// - IMMUNE = 1
//			// --------------------------------------------------------
//			cards.Add("NAX9_04", new List<Power> {
//				// TODO [NAX9_04] Sir Zeliek && Test: Sir Zeliek_NAX9_04
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [NAX9_04H] Sir Zeliek (*) - COST:3 [ATK:2/HP:7] 
//			// - Set: naxx, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: Your hero is <b>Immune</b>.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			// RefTag:
//			// - IMMUNE = 1
//			// --------------------------------------------------------
//			cards.Add("NAX9_04H", new List<Power> {
//				// TODO [NAX9_04H] Sir Zeliek && Test: Sir Zeliek_NAX9_04H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [NAXM_001] Necroknight (*) - COST:4 [ATK:5/HP:6] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> Destroy the minions next to this one as well.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("NAXM_001", new List<Power> {
//				// TODO [NAXM_001] Necroknight && Test: Necroknight_NAXM_001
//				new Power
//				{
//					Activation = PowerActivation.DEATHRATTLE,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [NAXM_002] Skeletal Smith (*) - COST:3 [ATK:4/HP:3] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> Destroy your opponent's weapon.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("NAXM_002", new List<Power> {
//				// TODO [NAXM_002] Skeletal Smith && Test: Skeletal Smith_NAXM_002
//				new Power
//				{
//					Activation = PowerActivation.DEATHRATTLE,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [NAX11_04] Mutating Injection (*) - COST:3 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: Give a minion +4/+4 and <b>Taunt</b>.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_MINION_TARGET = 0
//			// - REQ_TARGET_TO_PLAY = 0
//			// --------------------------------------------------------
//			// RefTag:
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("NAX11_04", new List<Power> {
//				// TODO [NAX11_04] Mutating Injection && Test: Mutating Injection_NAX11_04
//				new Power
//				{
//					InfoCardId = "NAX11_04e",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [NAX12_04] Enrage (*) - COST:3 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: Give your hero +6 Attack this turn.
//			// --------------------------------------------------------
//			cards.Add("NAX12_04", new List<Power> {
//				// TODO [NAX12_04] Enrage && Test: Enrage_NAX12_04
//				new Power
//				{
//					InfoCardId = "NAX12_04e",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [NAX13_03] Supercharge (*) - COST:2 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: Give your minions +2 Health.
//			// --------------------------------------------------------
//			cards.Add("NAX13_03", new List<Power> {
//				// TODO [NAX13_03] Supercharge && Test: Supercharge_NAX13_03
//				new Power
//				{
//					InfoCardId = "NAX13_03e",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [NAX14_04] Pure Cold (*) - COST:5 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: Deal $8 damage to the enemy hero, and <b>Freeze</b> it. @spelldmg
//			// --------------------------------------------------------
//			// GameTag:
//			// - FREEZE = 1
//			// --------------------------------------------------------
//			cards.Add("NAX14_04", new List<Power> {
//				// TODO [NAX14_04] Pure Cold && Test: Pure Cold_NAX14_04
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [NAX1_05] Locust Swarm (*) - COST:7 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: Deal $3 damage to all enemy minions. Restore #3 Health to your hero. @spelldmg
//			// --------------------------------------------------------
//			cards.Add("NAX1_05", new List<Power> {
//				// TODO [NAX1_05] Locust Swarm && Test: Locust Swarm_NAX1_05
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [NAX3_03] Necrotic Poison (*) - COST:2 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: Destroy a minion.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_MINION_TARGET = 0
//			// - REQ_TARGET_TO_PLAY = 0
//			// --------------------------------------------------------
//			cards.Add("NAX3_03", new List<Power> {
//				// TODO [NAX3_03] Necrotic Poison && Test: Necrotic Poison_NAX3_03
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [NAX4_05] Plague (*) - COST:6 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: Destroy all non-Skeleton minions.
//			// --------------------------------------------------------
//			cards.Add("NAX4_05", new List<Power> {
//				// TODO [NAX4_05] Plague && Test: Plague_NAX4_05
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [NAX5_03] Mindpocalypse (*) - COST:2 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: Both players draw 2 cards and gain a Mana Crystal.
//			// --------------------------------------------------------
//			cards.Add("NAX5_03", new List<Power> {
//				// TODO [NAX5_03] Mindpocalypse && Test: Mindpocalypse_NAX5_03
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [NAX6_03] Deathbloom (*) - COST:4 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: Deal $5 damage to a minion. Summon a Spore. @spelldmg
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_MINION_TARGET = 0
//			// - REQ_TARGET_TO_PLAY = 0
//			// --------------------------------------------------------
//			cards.Add("NAX6_03", new List<Power> {
//				// TODO [NAX6_03] Deathbloom && Test: Deathbloom_NAX6_03
//				new Power
//				{
//					InfoCardId = "NAX6_03te",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [NAX6_04] Sporeburst (*) - COST:1 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: Deal $1 damage to all enemy minions. Summon a Spore. @spelldmg
//			// --------------------------------------------------------
//			cards.Add("NAX6_04", new List<Power> {
//				// TODO [NAX6_04] Sporeburst && Test: Sporeburst_NAX6_04
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [NAX7_05] Mind Control Crystal (*) - COST:1 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: Activate the Crystal to control the Understudies!
//			// --------------------------------------------------------
//			cards.Add("NAX7_05", new List<Power> {
//				// TODO [NAX7_05] Mind Control Crystal && Test: Mind Control Crystal_NAX7_05
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [NAX9_07] Mark of the Horsemen (*) - COST:5 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: Give your minions and your weapon +1/+1.
//			// --------------------------------------------------------
//			cards.Add("NAX9_07", new List<Power> {
//				// TODO [NAX9_07] Mark of the Horsemen && Test: Mark of the Horsemen_NAX9_07
//				new Power
//				{
//					InfoCardId = "NAX9_07e",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- WEAPON - NEUTRAL
//			// [NAX10_02] Hook (*) - COST:3 [ATK:5/HP:0] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> Put this weapon into your hand.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DURABILITY = 8
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("NAX10_02", new List<Power> {
//				// TODO [NAX10_02] Hook && Test: Hook_NAX10_02
//				new Power
//				{
//					Activation = PowerActivation.WEAPON,
//					PowerTask = null,
//				},
//				new Power
//				{
//					Activation = PowerActivation.DEATHRATTLE,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- WEAPON - NEUTRAL
//			// [NAX10_02H] Hook (*) - COST:3 [ATK:4/HP:0] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: <b>Windfury</b>
//			//       <b>Deathrattle:</b> Put this weapon into your hand.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DURABILITY = 8
//			// - WINDFURY = 1
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("NAX10_02H", new List<Power> {
//				// TODO [NAX10_02H] Hook && Test: Hook_NAX10_02H
//				new Power
//				{
//					Activation = PowerActivation.WEAPON,
//					PowerTask = null,
//				},
//				new Power
//				{
//					Activation = PowerActivation.DEATHRATTLE,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- WEAPON - NEUTRAL
//			// [NAX12_03] Jaws (*) - COST:1 [ATK:1/HP:0] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: Whenever a minion with <b>Deathrattle</b> dies, gain +2 Attack.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DURABILITY = 5
//			// --------------------------------------------------------
//			// RefTag:
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("NAX12_03", new List<Power> {
//				// TODO [NAX12_03] Jaws && Test: Jaws_NAX12_03
//				new Power
//				{
//					InfoCardId = "NAX12_03e",
//					Activation = PowerActivation.WEAPON,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- WEAPON - NEUTRAL
//			// [NAX12_03H] Jaws (*) - COST:1 [ATK:3/HP:0] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: Whenever a minion with <b>Deathrattle</b> dies, gain +2 Attack.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DURABILITY = 5
//			// --------------------------------------------------------
//			// RefTag:
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("NAX12_03H", new List<Power> {
//				// TODO [NAX12_03H] Jaws && Test: Jaws_NAX12_03H
//				new Power
//				{
//					Activation = PowerActivation.WEAPON,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- WEAPON - NEUTRAL
//			// [NAX7_04] Massive Runeblade (*) - COST:3 [ATK:5/HP:0] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: Deals double damage to heroes.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DURABILITY = 2
//			// --------------------------------------------------------
//			cards.Add("NAX7_04", new List<Power> {
//				// TODO [NAX7_04] Massive Runeblade && Test: Massive Runeblade_NAX7_04
//				new Power
//				{
//					Activation = PowerActivation.WEAPON,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- WEAPON - NEUTRAL
//			// [NAX7_04H] Massive Runeblade (*) - COST:3 [ATK:10/HP:0] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: Deals double damage to heroes.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DURABILITY = 2
//			// --------------------------------------------------------
//			cards.Add("NAX7_04H", new List<Power> {
//				// TODO [NAX7_04H] Massive Runeblade && Test: Massive Runeblade_NAX7_04H
//				new Power
//				{
//					Activation = PowerActivation.WEAPON,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- WEAPON - NEUTRAL
//			// [NAX9_05] Runeblade (*) - COST:3 [ATK:1/HP:0] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: Has +3 Attack if the other Horsemen are dead.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DURABILITY = 3
//			// --------------------------------------------------------
//			cards.Add("NAX9_05", new List<Power> {
//				// TODO [NAX9_05] Runeblade && Test: Runeblade_NAX9_05
//				new Power
//				{
//					Activation = PowerActivation.WEAPON,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- WEAPON - NEUTRAL
//			// [NAX9_05H] Runeblade (*) - COST:3 [ATK:2/HP:0] 
//			// - Set: naxx, 
//			// --------------------------------------------------------
//			// Text: Has +6 Attack if the other Horsemen are dead.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DURABILITY = 3
//			// --------------------------------------------------------
//			cards.Add("NAX9_05H", new List<Power> {
//				// TODO [NAX9_05H] Runeblade && Test: Runeblade_NAX9_05H
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
