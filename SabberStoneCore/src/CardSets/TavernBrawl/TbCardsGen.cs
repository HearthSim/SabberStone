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

//namespace SabberStoneCore.CardSets.TavernBrawl
//{
//	public class TbCardsGen
//	{
//		private static void Heroes(IDictionary<string, List<Power>> cards)
//		{
//			// ----------------------------------------- HERO - NEUTRAL
//			// [FB_LK008h] Blood-Queen Lana'thel (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 43194
//			// --------------------------------------------------------
//			cards.Add("FB_LK008h", new List<Power> {
//				// TODO [FB_LK008h] Blood-Queen Lana'thel && Test: Blood-Queen Lana'thel_FB_LK008h
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [FB_LK_012h] Lord Marrowgar (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 42447
//			// --------------------------------------------------------
//			cards.Add("FB_LK_012h", new List<Power> {
//				// TODO [FB_LK_012h] Lord Marrowgar && Test: Lord Marrowgar_FB_LK_012h
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [FB_LK_013h] Professor Putricide (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 42876
//			// --------------------------------------------------------
//			cards.Add("FB_LK_013h", new List<Power> {
//				// TODO [FB_LK_013h] Professor Putricide && Test: Professor Putricide_FB_LK_013h
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [FB_LK_014h] Sindragosa (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 45627
//			// --------------------------------------------------------
//			cards.Add("FB_LK_014h", new List<Power> {
//				// TODO [FB_LK_014h] Sindragosa && Test: Sindragosa_FB_LK_014h
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [FB_LK_Raid_Hero] Supreme Lich King (*) - COST:0 [ATK:0/HP:400] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 42457
//			// --------------------------------------------------------
//			cards.Add("FB_LK_Raid_Hero", new List<Power> {
//				// TODO [FB_LK_Raid_Hero] Supreme Lich King && Test: Supreme Lich King_FB_LK_Raid_Hero
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [FB_LK_Raid_Hero_Battledamaged] Supreme Lich King (*) - COST:0 [ATK:0/HP:1] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 42457
//			// --------------------------------------------------------
//			cards.Add("FB_LK_Raid_Hero_Battledamaged", new List<Power> {
//				// TODO [FB_LK_Raid_Hero_Battledamaged] Supreme Lich King && Test: Supreme Lich King_FB_LK_Raid_Hero_Battledamaged
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [KAR_a10_Boss1H_TB] White King (*) - COST:0 [ATK:0/HP:10] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 40086
//			// --------------------------------------------------------
//			cards.Add("KAR_a10_Boss1H_TB", new List<Power> {
//				// TODO [KAR_a10_Boss1H_TB] White King && Test: White King_KAR_a10_Boss1H_TB
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [KAR_a10_Boss1H_TB22] White King (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 40086
//			// --------------------------------------------------------
//			cards.Add("KAR_a10_Boss1H_TB22", new List<Power> {
//				// TODO [KAR_a10_Boss1H_TB22] White King && Test: White King_KAR_a10_Boss1H_TB22
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [KAR_a10_Boss2H_TB] Black King (*) - COST:0 [ATK:0/HP:10] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 39801
//			// - CANT_BE_FATIGUED = 1
//			// --------------------------------------------------------
//			cards.Add("KAR_a10_Boss2H_TB", new List<Power> {
//				// TODO [KAR_a10_Boss2H_TB] Black King && Test: Black King_KAR_a10_Boss2H_TB
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - PALADIN
//			// [TB_BossRumble_001] Han'Cho (*) - COST:0 [ATK:0/HP:30] 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 39240
//			// --------------------------------------------------------
//			cards.Add("TB_BossRumble_001", new List<Power> {
//				// TODO [TB_BossRumble_001] Han'Cho && Test: Han'Cho_TB_BossRumble_001
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ------------------------------------------- HERO - DRUID
//			// [TB_BossRumble_002] Aya Blackpaw (*) - COST:0 [ATK:0/HP:30] 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 39240
//			// --------------------------------------------------------
//			cards.Add("TB_BossRumble_002", new List<Power> {
//				// TODO [TB_BossRumble_002] Aya Blackpaw && Test: Aya Blackpaw_TB_BossRumble_002
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// -------------------------------------------- HERO - MAGE
//			// [TB_BossRumble_003] Kazakus (*) - COST:0 [ATK:0/HP:30] 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 39240
//			// --------------------------------------------------------
//			cards.Add("TB_BossRumble_003", new List<Power> {
//				// TODO [TB_BossRumble_003] Kazakus && Test: Kazakus_TB_BossRumble_003
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [TB_CoopHero_H_001] Coop Boss (*) - COST:0 [ATK:0/HP:100] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 40221
//			// --------------------------------------------------------
//			cards.Add("TB_CoopHero_H_001", new List<Power> {
//				// TODO [TB_CoopHero_H_001] Coop Boss && Test: Coop Boss_TB_CoopHero_H_001
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [TB_FW_Rag] Ragnaros the Firelord (*) - COST:0 [ATK:0/HP:60] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2660
//			// --------------------------------------------------------
//			cards.Add("TB_FW_Rag", new List<Power> {
//				// TODO [TB_FW_Rag] Ragnaros the Firelord && Test: Ragnaros the Firelord_TB_FW_Rag
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [TB_KTRAF_H_1] Kel'Thuzad (*) - COST:0 [ATK:0/HP:30] 
//			// - Fac: neutral, Set: tb, Rarity: free
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 39240
//			// --------------------------------------------------------
//			cards.Add("TB_KTRAF_H_1", new List<Power> {
//				// TODO [TB_KTRAF_H_1] Kel'Thuzad && Test: Kel'Thuzad_TB_KTRAF_H_1
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [TB_KTRAF_H_2] Rafaam (*) - COST:0 [ATK:0/HP:60] 
//			// - Fac: neutral, Set: tb, Rarity: free
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 39236
//			// --------------------------------------------------------
//			cards.Add("TB_KTRAF_H_2", new List<Power> {
//				// TODO [TB_KTRAF_H_2] Rafaam && Test: Rafaam_TB_KTRAF_H_2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [TB_MechWar_Boss1] Annoy-o-Tron (*) - COST:0 [ATK:0/HP:30] 
//			// - Fac: neutral, Set: tb, Rarity: free
//			// --------------------------------------------------------
//			cards.Add("TB_MechWar_Boss1", new List<Power> {
//				// TODO [TB_MechWar_Boss1] Annoy-o-Tron && Test: Annoy-o-Tron_TB_MechWar_Boss1
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [TB_MechWar_Boss2] Boom Bot (*) - COST:0 [ATK:0/HP:30] 
//			// - Fac: neutral, Set: tb, Rarity: free
//			// --------------------------------------------------------
//			cards.Add("TB_MechWar_Boss2", new List<Power> {
//				// TODO [TB_MechWar_Boss2] Boom Bot && Test: Boom Bot_TB_MechWar_Boss2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [TB_SPT_Boss] City of Stormwind (*) - COST:0 [ATK:0/HP:1] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 39537
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_Boss", new List<Power> {
//				// TODO [TB_SPT_Boss] City of Stormwind && Test: City of Stormwind_TB_SPT_Boss
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - WARLOCK
//			// [TB_SPT_DPromo_Hero] Dark Wanderer (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 42156
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DPromo_Hero", new List<Power> {
//				// TODO [TB_SPT_DPromo_Hero] Dark Wanderer && Test: Dark Wanderer_TB_SPT_DPromo_Hero
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - WARRIOR
//			// [TB_SPT_DPromo_Hero2] The Cow King (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - InvisibleDeathrattle = 1
//			// - HERO_POWER = 42156
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DPromo_Hero2", new List<Power> {
//				// TODO [TB_SPT_DPromo_Hero2] The Cow King && Test: The Cow King_TB_SPT_DPromo_Hero2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [TB_SPT_MTH_Boss] Decorated Stormwind (*) - COST:0 [ATK:0/HP:1] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 39537
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_MTH_Boss", new List<Power> {
//				// TODO [TB_SPT_MTH_Boss] Decorated Stormwind && Test: Decorated Stormwind_TB_SPT_MTH_Boss
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [TB_SPT_MTH_Boss0] City of Stormwind (*) - COST:0 [ATK:0/HP:1] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 39537
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_MTH_Boss0", new List<Power> {
//				// TODO [TB_SPT_MTH_Boss0] City of Stormwind && Test: City of Stormwind_TB_SPT_MTH_Boss0
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [TB_SPT_MTH_Boss2] Partytown Stormwind (*) - COST:0 [ATK:0/HP:1] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 39537
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_MTH_Boss2", new List<Power> {
//				// TODO [TB_SPT_MTH_Boss2] Partytown Stormwind && Test: Partytown Stormwind_TB_SPT_MTH_Boss2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [TB_SPT_MTH_Boss3] Party Capital (*) - COST:0 [ATK:0/HP:1] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 39537
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_MTH_Boss3", new List<Power> {
//				// TODO [TB_SPT_MTH_Boss3] Party Capital && Test: Party Capital_TB_SPT_MTH_Boss3
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [TBA01_1] Ragnaros the Firelord (*) - COST:0 [ATK:0/HP:60] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2660
//			// --------------------------------------------------------
//			cards.Add("TBA01_1", new List<Power> {
//				// TODO [TBA01_1] Ragnaros the Firelord && Test: Ragnaros the Firelord_TBA01_1
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- HERO - NEUTRAL
//			// [TBA01_4] Nefarian (*) - COST:0 [ATK:0/HP:30] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2653
//			// --------------------------------------------------------
//			cards.Add("TBA01_4", new List<Power> {
//				// TODO [TBA01_4] Nefarian && Test: Nefarian_TBA01_4
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
//			// [BRMA01_2H_2_TB] Pile On!!! (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Put a minion from each deck into the battlefield.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_NUM_MINION_SLOTS = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA01_2H_2_TB", new List<Power> {
//				// TODO [BRMA01_2H_2_TB] Pile On!!! && Test: Pile On!!!_BRMA01_2H_2_TB
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA02_2_2_TB] Jeering Crowd (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Summon a 1/1 Spectator with <b>Taunt</b>.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_NUM_MINION_SLOTS = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA02_2_2_TB", new List<Power> {
//				// TODO [BRMA02_2_2_TB] Jeering Crowd && Test: Jeering Crowd_BRMA02_2_2_TB
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA06_2H_TB] The Majordomo (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Summon a 3/3 Flamewaker Acolyte.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_NUM_MINION_SLOTS = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA06_2H_TB", new List<Power> {
//				// TODO [BRMA06_2H_TB] The Majordomo && Test: The Majordomo_BRMA06_2H_TB
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA07_2_2_TB] ME SMASH (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Destroy a random enemy minion.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_MINIMUM_ENEMY_MINIONS = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA07_2_2_TB", new List<Power> {
//				// TODO [BRMA07_2_2_TB] ME SMASH && Test: ME SMASH_BRMA07_2_2_TB
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA09_2_TB] Open the Gates (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Summon three 1/1 Whelps.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_NUM_MINION_SLOTS = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA09_2_TB", new List<Power> {
//				// TODO [BRMA09_2_TB] Open the Gates && Test: Open the Gates_BRMA09_2_TB
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA11_2H_2_TB] Essence of the Red (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Each player draws 3 cards. Gain a Mana Crystal.
//			// --------------------------------------------------------
//			cards.Add("BRMA11_2H_2_TB", new List<Power> {
//				// TODO [BRMA11_2H_2_TB] Essence of the Red && Test: Essence of the Red_BRMA11_2H_2_TB
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA13_4_2_TB] Wild Magic (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Put a random spell from your opponent's class into your hand.
//			// --------------------------------------------------------
//			cards.Add("BRMA13_4_2_TB", new List<Power> {
//				// TODO [BRMA13_4_2_TB] Wild Magic && Test: Wild Magic_BRMA13_4_2_TB
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA14_10H_TB] Activate! (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Activate a random Tron.
//			// --------------------------------------------------------
//			// Entourage: BRMA14_3, BRMA14_5, BRMA14_7, BRMA14_9
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_NUM_MINION_SLOTS = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA14_10H_TB", new List<Power> {
//				// TODO [BRMA14_10H_TB] Activate! && Test: Activate!_BRMA14_10H_TB
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [BRMA17_5_TB] Bone Minions (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Summon two 2/1 Bone Constructs.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_NUM_MINION_SLOTS = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA17_5_TB", new List<Power> {
//				// TODO [BRMA17_5_TB] Bone Minions && Test: Bone Minions_BRMA17_5_TB
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [EX1_tk33_2_TB] INFERNO! (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Summon a 6/6 Infernal.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_NUM_MINION_SLOTS = 1
//			// --------------------------------------------------------
//			cards.Add("EX1_tk33_2_TB", new List<Power> {
//				// TODO [EX1_tk33_2_TB] INFERNO! && Test: INFERNO!_EX1_tk33_2_TB
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ------------------------------- HERO_POWER - DEATHKNIGHT
//			// [FB_LK005] Remorseless Winter (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Deal @ damage to the enemy hero. +1 Damage each time.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("FB_LK005", new List<Power> {
//				// TODO [FB_LK005] Remorseless Winter && Test: Remorseless Winter_FB_LK005
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [FB_LK007p] Freezing Blast (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       <b>Freeze</b>  a random enemy minion and deal 1 damage to it.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("FB_LK007p", new List<Power> {
//				// TODO [FB_LK007p] Freezing Blast && Test: Freezing Blast_FB_LK007p
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [NAX11_02H_2_TB] Poison Cloud (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Deal 1 damage to all enemy minions. If any die, summon a slime.
//			// --------------------------------------------------------
//			cards.Add("NAX11_02H_2_TB", new List<Power> {
//				// TODO [NAX11_02H_2_TB] Poison Cloud && Test: Poison Cloud_NAX11_02H_2_TB
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [NAX12_02H_2_TB] Decimate (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Change the Health of enemy minions to 1.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_MINIMUM_ENEMY_MINIONS = 1
//			// --------------------------------------------------------
//			cards.Add("NAX12_02H_2_TB", new List<Power> {
//				// TODO [NAX12_02H_2_TB] Decimate && Test: Decimate_NAX12_02H_2_TB
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [NAX3_02_TB] Web Wrap (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Return a random enemy minion to your opponent's hand.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_MINIMUM_ENEMY_MINIONS = 1
//			// --------------------------------------------------------
//			cards.Add("NAX3_02_TB", new List<Power> {
//				// TODO [NAX3_02_TB] Web Wrap && Test: Web Wrap_NAX3_02_TB
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [NAX8_02H_TB] Harvest (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Draw a card. Gain a Mana Crystal.
//			// --------------------------------------------------------
//			cards.Add("NAX8_02H_TB", new List<Power> {
//				// TODO [NAX8_02H_TB] Harvest && Test: Harvest_NAX8_02H_TB
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ------------------------------------- HERO_POWER - ROGUE
//			// [TB_BlingBrawl_Hero1p] Sharpen (*) - COST:2 
//			// - Set: tb, Rarity: free
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Increase your weapon's attack by 1
//			// --------------------------------------------------------
//			cards.Add("TB_BlingBrawl_Hero1p", new List<Power> {
//				// TODO [TB_BlingBrawl_Hero1p] Sharpen && Test: Sharpen_TB_BlingBrawl_Hero1p
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [TB_BossRumble_001hp] Smuggle (*) - COST:2 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Give a random minion in your hand +2/+2
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 39240
//			// --------------------------------------------------------
//			cards.Add("TB_BossRumble_001hp", new List<Power> {
//				// TODO [TB_BossRumble_001hp] Smuggle && Test: Smuggle_TB_BossRumble_001hp
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [TB_BossRumble_002hp] Construct Golem (*) - COST:4 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Summon a {0} <b>Jade Golem</b>.@Summon a <b>Jade Golem</b>.
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 39240
//			// --------------------------------------------------------
//			cards.Add("TB_BossRumble_002hp", new List<Power> {
//				// TODO [TB_BossRumble_002hp] Construct Golem && Test: Construct Golem_TB_BossRumble_002hp
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [TB_BossRumble_003hp] Brew Potion (*) - COST:2 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Add a random Potion to your hand.
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 39240
//			// --------------------------------------------------------
//			cards.Add("TB_BossRumble_003hp", new List<Power> {
//				// TODO [TB_BossRumble_003hp] Brew Potion && Test: Brew Potion_TB_BossRumble_003hp
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [TB_BRMA01_2H_2] Pile On!!! (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Put a minion from each deck into the battlefield.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_NUM_MINION_SLOTS = 1
//			// --------------------------------------------------------
//			cards.Add("TB_BRMA01_2H_2", new List<Power> {
//				// TODO [TB_BRMA01_2H_2] Pile On!!! && Test: Pile On!!!_TB_BRMA01_2H_2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [TB_BRMA10_3H] The Rookery (*) - COST:1 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Give all Corrupted Eggs +1 Health, then summon one.
//			// --------------------------------------------------------
//			cards.Add("TB_BRMA10_3H", new List<Power> {
//				// TODO [TB_BRMA10_3H] The Rookery && Test: The Rookery_TB_BRMA10_3H
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [TB_CoopHero_HP_001] Madness (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Armies!!
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2379
//			// --------------------------------------------------------
//			cards.Add("TB_CoopHero_HP_001", new List<Power> {
//				// TODO [TB_CoopHero_HP_001] Madness && Test: Madness_TB_CoopHero_HP_001
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [TB_KTRAF_HP_KT_3] Necromancy (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Add a random Naxxramas minion to your hand. It costs (3) less.
//			// --------------------------------------------------------
//			cards.Add("TB_KTRAF_HP_KT_3", new List<Power> {
//				// TODO [TB_KTRAF_HP_KT_3] Necromancy && Test: Necromancy_TB_KTRAF_HP_KT_3
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [TB_KTRAF_HP_RAF3] Staff, First Piece (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Add a random rare card to your hand. It costs (2) less.
//			// --------------------------------------------------------
//			cards.Add("TB_KTRAF_HP_RAF3", new List<Power> {
//				// TODO [TB_KTRAF_HP_RAF3] Staff, First Piece && Test: Staff, First Piece_TB_KTRAF_HP_RAF3
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [TB_KTRAF_HP_RAF4] Staff, Two Pieces (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Add a random epic card to your hand. It costs (3) less.
//			// --------------------------------------------------------
//			cards.Add("TB_KTRAF_HP_RAF4", new List<Power> {
//				// TODO [TB_KTRAF_HP_RAF4] Staff, Two Pieces && Test: Staff, Two Pieces_TB_KTRAF_HP_RAF4
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [TB_KTRAF_HP_RAF5] Staff of Origination (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Add a random legendary minion to your hand. It costs (4) less.
//			// --------------------------------------------------------
//			cards.Add("TB_KTRAF_HP_RAF5", new List<Power> {
//				// TODO [TB_KTRAF_HP_RAF5] Staff of Origination && Test: Staff of Origination_TB_KTRAF_HP_RAF5
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [TB_LevelUp_001] Level Up! (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Level up all the spells in your hand and deck.
//			// --------------------------------------------------------
//			cards.Add("TB_LevelUp_001", new List<Power> {
//				// TODO [TB_LevelUp_001] Level Up! && Test: Level Up!_TB_LevelUp_001
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ------------------------------------- HERO_POWER - DRUID
//			// [TB_LOEA13_2] Ancient Power (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Give each player a random card. It costs (0).
//			// --------------------------------------------------------
//			cards.Add("TB_LOEA13_2", new List<Power> {
//				// TODO [TB_LOEA13_2] Ancient Power && Test: Ancient Power_TB_LOEA13_2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [TB_MammothParty_hp001] Decorate (*) - COST:10 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Create *{0}* |4(decoration, decorations) for the Tavern.
//			//       Progress: {1}/25
//			// --------------------------------------------------------
//			cards.Add("TB_MammothParty_hp001", new List<Power> {
//				// TODO [TB_MammothParty_hp001] Decorate && Test: Decorate_TB_MammothParty_hp001
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [TB_MammothParty_hp002] Pelt (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Deal 3 damage to the Piñata.
//			// --------------------------------------------------------
//			cards.Add("TB_MammothParty_hp002", new List<Power> {
//				// TODO [TB_MammothParty_hp002] Pelt && Test: Pelt_TB_MammothParty_hp002
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [TB_MechWar_Boss1_HeroPower] Hello! Hello! Hello! (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Give your lowest attack minion <b>Divine Shield</b> and <b>Taunt</b>.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_MINION_TARGET = 0
//			// - REQ_FRIENDLY_TARGET = 0
//			// --------------------------------------------------------
//			cards.Add("TB_MechWar_Boss1_HeroPower", new List<Power> {
//				// TODO [TB_MechWar_Boss1_HeroPower] Hello! Hello! Hello! && Test: Hello! Hello! Hello!_TB_MechWar_Boss1_HeroPower
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [TB_MechWar_Boss2_HeroPower] Boom Bot Jr. (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Deal 2 damage randomly split among all enemies.
//			// --------------------------------------------------------
//			cards.Add("TB_MechWar_Boss2_HeroPower", new List<Power> {
//				// TODO [TB_MechWar_Boss2_HeroPower] Boom Bot Jr. && Test: Boom Bot Jr._TB_MechWar_Boss2_HeroPower
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [TB_SPT_BossHeroPower] Barracks (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Play a random Stormwind Soldier.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_BossHeroPower", new List<Power> {
//				// TODO [TB_SPT_BossHeroPower] Barracks && Test: Barracks_TB_SPT_BossHeroPower
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - INVALID
//			// [TB_SPT_DPromoHP] Diabolical Powers (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Summon a random Imp.
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 38981
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_MINION_TARGET = 0
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DPromoHP", new List<Power> {
//				// TODO [TB_SPT_DPromoHP] Diabolical Powers && Test: Diabolical Powers_TB_SPT_DPromoHP
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [TB_SPT_DPromoHP2] So Many... (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Whenever a Hell Bovine Dies, draw a card.
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 38981
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DPromoHP2", new List<Power> {
//				// TODO [TB_SPT_DPromoHP2] So Many... && Test: So Many..._TB_SPT_DPromoHP2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [TB_SPT_MTH_BossHeroPower] Party Barracks (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Play a random Stormwind Partygoer.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AI_MUST_PLAY = 1
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_MTH_BossHeroPower", new List<Power> {
//				// TODO [TB_SPT_MTH_BossHeroPower] Party Barracks && Test: Party Barracks_TB_SPT_MTH_BossHeroPower
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [TBA01_5] Wild Magic (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Add a random spell from any class to your hand. It costs (0).
//			// --------------------------------------------------------
//			cards.Add("TBA01_5", new List<Power> {
//				// TODO [TBA01_5] Wild Magic && Test: Wild Magic_TBA01_5
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- HERO_POWER - NEUTRAL
//			// [TBA01_6] Molten Rage (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Summon a 5/1 Magma Rager.
//			// --------------------------------------------------------
//			cards.Add("TBA01_6", new List<Power> {
//				// TODO [TBA01_6] Molten Rage && Test: Molten Rage_TBA01_6
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ------------------------------------- HERO_POWER - ROGUE
//			// [TP_Bling_HP2] Cash In (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Destroy your weapon, gaining a random one.
//			// --------------------------------------------------------
//			cards.Add("TP_Bling_HP2", new List<Power> {
//				// TODO [TP_Bling_HP2] Cash In && Test: Cash In_TP_Bling_HP2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//		}

//		private static void DeathknightNonCollect(IDictionary<string, List<Power>> cards)
//		{
//			// ------------------------------------ SPELL - DEATHKNIGHT
//			// [FB_LK001] Soldiers of the Cold Dark (*) - COST:0 
//			// - Fac: neutral, Set: tb, Rarity: free
//			// --------------------------------------------------------
//			// Text: Draw 4 cards.
//			// --------------------------------------------------------
//			cards.Add("FB_LK001", new List<Power> {
//				// TODO [FB_LK001] Soldiers of the Cold Dark && Test: Soldiers of the Cold Dark_FB_LK001
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ------------------------------------ SPELL - DEATHKNIGHT
//			// [FB_LK006] To My Aid Underling! (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: You aren't worth the Lich King's time. 
//			//        Summon a different Frozen Throne boss.
//			// --------------------------------------------------------
//			cards.Add("FB_LK006", new List<Power> {
//				// TODO [FB_LK006] To My Aid Underling! && Test: To My Aid Underling!_FB_LK006
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//		}

//		private static void DruidNonCollect(IDictionary<string, List<Power>> cards)
//		{
//			// ------------------------------------ ENCHANTMENT - DRUID
//			// [FB_LK_Druid_Ench_copy] Next Hero: Druid Ench Copy (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Add Druid cards to your deck.
//			// --------------------------------------------------------
//			// Entourage: CS2_017
//			// --------------------------------------------------------
//			cards.Add("FB_LK_Druid_Ench_copy", new List<Power> {
//				// TODO [FB_LK_Druid_Ench_copy] Next Hero: Druid Ench Copy && Test: Next Hero: Druid Ench Copy_FB_LK_Druid_Ench_copy
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ------------------------------------ ENCHANTMENT - DRUID
//			// [FB_TagTeam_Druid_Ench] Next Hero: Druid Ench (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Add Druid cards to your deck.
//			// --------------------------------------------------------
//			// Entourage: CS2_017
//			// --------------------------------------------------------
//			cards.Add("FB_TagTeam_Druid_Ench", new List<Power> {
//				// TODO [FB_TagTeam_Druid_Ench] Next Hero: Druid Ench && Test: Next Hero: Druid Ench_FB_TagTeam_Druid_Ench
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ------------------------------------------ SPELL - DRUID
//			// [FB_LK_Druid_copy] Druid (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Select Druid as your next class.
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			cards.Add("FB_LK_Druid_copy", new List<Power> {
//				// TODO [FB_LK_Druid_copy] Druid && Test: Druid_FB_LK_Druid_copy
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ------------------------------------------ SPELL - DRUID
//			// [TB_ClassRandom_Druid] Second Class: Druid (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Add Druid cards to your deck.
//			// --------------------------------------------------------
//			cards.Add("TB_ClassRandom_Druid", new List<Power> {
//				// TODO [TB_ClassRandom_Druid] Second Class: Druid && Test: Second Class: Druid_TB_ClassRandom_Druid
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ------------------------------------------ SPELL - DRUID
//			// [TB_TagTeam_Druid] Rumble in the Jungle (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Enter the jungle with giant beasts and darker things...
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			cards.Add("TB_TagTeam_Druid", new List<Power> {
//				// TODO [TB_TagTeam_Druid] Rumble in the Jungle && Test: Rumble in the Jungle_TB_TagTeam_Druid
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//		}

//		private static void HunterNonCollect(IDictionary<string, List<Power>> cards)
//		{
//			// ----------------------------------- ENCHANTMENT - HUNTER
//			// [FB_LK_Hunter_Ench_copy] Next Hero: Hunter Ench Copy (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Add Hunter cards to your deck.
//			// --------------------------------------------------------
//			// Entourage: DS1h_292
//			// --------------------------------------------------------
//			cards.Add("FB_LK_Hunter_Ench_copy", new List<Power> {
//				// TODO [FB_LK_Hunter_Ench_copy] Next Hero: Hunter Ench Copy && Test: Next Hero: Hunter Ench Copy_FB_LK_Hunter_Ench_copy
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- ENCHANTMENT - HUNTER
//			// [FB_TagTeam_Hunter_Ench] Next Hero: Hunter Ench (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Add Hunter cards to your deck.
//			// --------------------------------------------------------
//			// Entourage: DS1h_292
//			// --------------------------------------------------------
//			cards.Add("FB_TagTeam_Hunter_Ench", new List<Power> {
//				// TODO [FB_TagTeam_Hunter_Ench] Next Hero: Hunter Ench && Test: Next Hero: Hunter Ench_FB_TagTeam_Hunter_Ench
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- SPELL - HUNTER
//			// [FB_LK_Hunter_copy] Hunter (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Select Hunter as your next class.
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			cards.Add("FB_LK_Hunter_copy", new List<Power> {
//				// TODO [FB_LK_Hunter_copy] Hunter && Test: Hunter_FB_LK_Hunter_copy
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ----------------------------------------- SPELL - HUNTER
//			// [TB_ClassRandom_Hunter] Second Class: Hunter (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Add Hunter cards to your deck.
//			// --------------------------------------------------------
//			cards.Add("TB_ClassRandom_Hunter", new List<Power> {
//				// TODO [TB_ClassRandom_Hunter] Second Class: Hunter && Test: Second Class: Hunter_TB_ClassRandom_Hunter
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ----------------------------------------- SPELL - HUNTER
//			// [TB_TagTeam_Hunter] Unleash the Beasts (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Release a stampede of beasts while hunting for the Marsh Queen!
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			cards.Add("TB_TagTeam_Hunter", new List<Power> {
//				// TODO [TB_TagTeam_Hunter] Unleash the Beasts && Test: Unleash the Beasts_TB_TagTeam_Hunter
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//		}

//		private static void MageNonCollect(IDictionary<string, List<Power>> cards)
//		{
//			// ------------------------------------- ENCHANTMENT - MAGE
//			// [FB_LK_Mage_Ench_copy] Next Hero: Mage Ench Copy (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Add Mage cards to your deck.
//			// --------------------------------------------------------
//			// Entourage: CS2_034
//			// --------------------------------------------------------
//			cards.Add("FB_LK_Mage_Ench_copy", new List<Power> {
//				// TODO [FB_LK_Mage_Ench_copy] Next Hero: Mage Ench Copy && Test: Next Hero: Mage Ench Copy_FB_LK_Mage_Ench_copy
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ------------------------------------- ENCHANTMENT - MAGE
//			// [FB_TagTeam_Mage_Ench] Next Hero: Mage Ench (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Add Mage cards to your deck.
//			// --------------------------------------------------------
//			// Entourage: CS2_034
//			// --------------------------------------------------------
//			cards.Add("FB_TagTeam_Mage_Ench", new List<Power> {
//				// TODO [FB_TagTeam_Mage_Ench] Next Hero: Mage Ench && Test: Next Hero: Mage Ench_FB_TagTeam_Mage_Ench
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ------------------------------------- ENCHANTMENT - MAGE
//			// [TagTeamIceBlock] Tag Team Ice Block (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Your hero is <b>Immune</b> this turn.
//			// --------------------------------------------------------
//			cards.Add("TagTeamIceBlock", new List<Power> {
//				// TODO [TagTeamIceBlock] Tag Team Ice Block && Test: Tag Team Ice Block_TagTeamIceBlock
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ------------------------------------------- SPELL - MAGE
//			// [FB_LK002] Relentless March (*) - COST:3 
//			// - Fac: neutral, Set: tb, Rarity: free
//			// --------------------------------------------------------
//			// Text: Death does not feel fatigue, replace your deck with a fresh one.
//			// --------------------------------------------------------
//			cards.Add("FB_LK002", new List<Power> {
//				// TODO [FB_LK002] Relentless March && Test: Relentless March_FB_LK002
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ------------------------------------------- SPELL - MAGE
//			// [FB_LK_Mage_copy] Mage (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Select Mage as your next class.
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			cards.Add("FB_LK_Mage_copy", new List<Power> {
//				// TODO [FB_LK_Mage_copy] Mage && Test: Mage_FB_LK_Mage_copy
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ------------------------------------------- SPELL - MAGE
//			// [TB_ClassRandom_Mage] Second Class: Mage (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Add Mage cards to your deck.
//			// --------------------------------------------------------
//			cards.Add("TB_ClassRandom_Mage", new List<Power> {
//				// TODO [TB_ClassRandom_Mage] Second Class: Mage && Test: Second Class: Mage_TB_ClassRandom_Mage
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ------------------------------------------- SPELL - MAGE
//			// [TB_LevelUp_002] Fireblast (*) - COST:4 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Deal $6 damage. @spelldmg
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_TARGET_TO_PLAY = 0
//			// --------------------------------------------------------
//			cards.Add("TB_LevelUp_002", new List<Power> {
//				// TODO [TB_LevelUp_002] Fireblast && Test: Fireblast_TB_LevelUp_002
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ------------------------------------------- SPELL - MAGE
//			// [TB_TagTeam_Mage] Elemental Secrets (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Guard your secrets and unleash elemental fury!
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			cards.Add("TB_TagTeam_Mage", new List<Power> {
//				// TODO [TB_TagTeam_Mage] Elemental Secrets && Test: Elemental Secrets_TB_TagTeam_Mage
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//		}

//		private static void PaladinNonCollect(IDictionary<string, List<Power>> cards)
//		{
//			// ---------------------------------- ENCHANTMENT - PALADIN
//			// [FB_LK_Paladin_Ench_copy] Next Hero: Paladin Ench Copy (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Add Paladin cards to your deck.
//			// --------------------------------------------------------
//			// Entourage: CS2_101
//			// --------------------------------------------------------
//			cards.Add("FB_LK_Paladin_Ench_copy", new List<Power> {
//				// TODO [FB_LK_Paladin_Ench_copy] Next Hero: Paladin Ench Copy && Test: Next Hero: Paladin Ench Copy_FB_LK_Paladin_Ench_copy
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - PALADIN
//			// [FB_TagTeam_Paladin_Ench] Next Hero: Paladin Ench (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Add Paladin cards to your deck.
//			// --------------------------------------------------------
//			// Entourage: CS2_101
//			// --------------------------------------------------------
//			cards.Add("FB_TagTeam_Paladin_Ench", new List<Power> {
//				// TODO [FB_TagTeam_Paladin_Ench] Next Hero: Paladin Ench && Test: Next Hero: Paladin Ench_FB_TagTeam_Paladin_Ench
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------------- SPELL - PALADIN
//			// [FB_LK_Paladin_copy] Paladin (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Select Paladin as your next class.
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			cards.Add("FB_LK_Paladin_copy", new List<Power> {
//				// TODO [FB_LK_Paladin_copy] Paladin && Test: Paladin_FB_LK_Paladin_copy
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - PALADIN
//			// [TB_ClassRandom_Paladin] Second Class: Paladin (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Add Paladin cards to your deck.
//			// --------------------------------------------------------
//			cards.Add("TB_ClassRandom_Paladin", new List<Power> {
//				// TODO [TB_ClassRandom_Paladin] Second Class: Paladin && Test: Second Class: Paladin_TB_ClassRandom_Paladin
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - PALADIN
//			// [TB_CoOpv3_200] Follow MY Rules! (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Change the Attack of all other minions to 1.
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpv3_200", new List<Power> {
//				// TODO [TB_CoOpv3_200] Follow MY Rules! && Test: Follow MY Rules!_TB_CoOpv3_200
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - PALADIN
//			// [TB_TagTeam_Paladin] Dark Light (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Bend the Light to your will, while you unleash the Apocalypse!
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			cards.Add("TB_TagTeam_Paladin", new List<Power> {
//				// TODO [TB_TagTeam_Paladin] Dark Light && Test: Dark Light_TB_TagTeam_Paladin
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//		}

//		private static void PriestNonCollect(IDictionary<string, List<Power>> cards)
//		{
//			// ----------------------------------- ENCHANTMENT - PRIEST
//			// [FB_LK_Priest_Ench_copy] Next Hero: Priest Ench Copy (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Add Priest cards to your deck.
//			// --------------------------------------------------------
//			// Entourage: CS1h_001
//			// --------------------------------------------------------
//			cards.Add("FB_LK_Priest_Ench_copy", new List<Power> {
//				// TODO [FB_LK_Priest_Ench_copy] Next Hero: Priest Ench Copy && Test: Next Hero: Priest Ench Copy_FB_LK_Priest_Ench_copy
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- ENCHANTMENT - PRIEST
//			// [FB_TagTeam_Priest_Ench] Next Hero: Priest Ench (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Add Priest cards to your deck.
//			// --------------------------------------------------------
//			// Entourage: CS1h_001
//			// --------------------------------------------------------
//			cards.Add("FB_TagTeam_Priest_Ench", new List<Power> {
//				// TODO [FB_TagTeam_Priest_Ench] Next Hero: Priest Ench && Test: Next Hero: Priest Ench_FB_TagTeam_Priest_Ench
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- SPELL - PRIEST
//			// [FB_LK_Priest_copy] Priest (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Select Priest as your next class.
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			cards.Add("FB_LK_Priest_copy", new List<Power> {
//				// TODO [FB_LK_Priest_copy] Priest && Test: Priest_FB_LK_Priest_copy
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ----------------------------------------- SPELL - PRIEST
//			// [TB_ClassRandom_Priest] Second Class: Priest (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Add Priest cards to your deck.
//			// --------------------------------------------------------
//			cards.Add("TB_ClassRandom_Priest", new List<Power> {
//				// TODO [TB_ClassRandom_Priest] Second Class: Priest && Test: Second Class: Priest_TB_ClassRandom_Priest
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ----------------------------------------- SPELL - PRIEST
//			// [TB_CoOpv3_002] Twisted Light (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Restore 30 health to Nefarian. Deal 30 damage to all other minions.
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpv3_002", new List<Power> {
//				// TODO [TB_CoOpv3_002] Twisted Light && Test: Twisted Light_TB_CoOpv3_002
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ----------------------------------------- SPELL - PRIEST
//			// [TB_Coopv3_102] Shadow or Light? (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Choose One -</b> Each player draws 2 cards; or Restore 8 Health to each hero.
//			// --------------------------------------------------------
//			cards.Add("TB_Coopv3_102", new List<Power> {
//				// TODO [TB_Coopv3_102] Shadow or Light? && Test: Shadow or Light?_TB_Coopv3_102
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ----------------------------------------- SPELL - PRIEST
//			// [TB_Coopv3_102a] Secrets of Shadow (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Each player draws 2 cards.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_Coopv3_102a", new List<Power> {
//				// TODO [TB_Coopv3_102a] Secrets of Shadow && Test: Secrets of Shadow_TB_Coopv3_102a
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ----------------------------------------- SPELL - PRIEST
//			// [TB_Coopv3_102b] Alms of Light (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Restore 8 Health to each hero.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_Coopv3_102b", new List<Power> {
//				// TODO [TB_Coopv3_102b] Alms of Light && Test: Alms of Light_TB_Coopv3_102b
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ----------------------------------------- SPELL - PRIEST
//			// [TB_TagTeam_Priest] Unbreakable (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Inspire</b> your minions, even in death.
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			cards.Add("TB_TagTeam_Priest", new List<Power> {
//				// TODO [TB_TagTeam_Priest] Unbreakable && Test: Unbreakable_TB_TagTeam_Priest
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//		}

//		private static void RogueNonCollect(IDictionary<string, List<Power>> cards)
//		{
//			// ------------------------------------ ENCHANTMENT - ROGUE
//			// [FB_LK_Rogue_Ench_copy] Next Hero: Rogue Ench Copy (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Add Rogue cards to your deck.
//			// --------------------------------------------------------
//			// Entourage: CS2_083b
//			// --------------------------------------------------------
//			cards.Add("FB_LK_Rogue_Ench_copy", new List<Power> {
//				// TODO [FB_LK_Rogue_Ench_copy] Next Hero: Rogue Ench Copy && Test: Next Hero: Rogue Ench Copy_FB_LK_Rogue_Ench_copy
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ------------------------------------ ENCHANTMENT - ROGUE
//			// [FB_TagTeam_Rogue_Ench] Next Hero: Rogue Ench (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Add Rogue cards to your deck.
//			// --------------------------------------------------------
//			// Entourage: CS2_083b
//			// --------------------------------------------------------
//			cards.Add("FB_TagTeam_Rogue_Ench", new List<Power> {
//				// TODO [FB_TagTeam_Rogue_Ench] Next Hero: Rogue Ench && Test: Next Hero: Rogue Ench_FB_TagTeam_Rogue_Ench
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ------------------------------------ ENCHANTMENT - ROGUE
//			// [TB_BlingBrawl_Hero1e] Sharpened (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: +1 Attack
//			// --------------------------------------------------------
//			cards.Add("TB_BlingBrawl_Hero1e", new List<Power> {
//				// TODO [TB_BlingBrawl_Hero1e] Sharpened && Test: Sharpened_TB_BlingBrawl_Hero1e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ------------------------------------ ENCHANTMENT - ROGUE
//			// [TB_Superfriends001e] Facilitated (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: The next legend you cast this turn costs (3) less.
//			// --------------------------------------------------------
//			cards.Add("TB_Superfriends001e", new List<Power> {
//				// TODO [TB_Superfriends001e] Facilitated && Test: Facilitated_TB_Superfriends001e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ------------------------------------ ENCHANTMENT - ROGUE
//			// [TB_Superfriends002e] Draw Offensive Play (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Draw Offensive Play on first, third, and fifth turn
//			// --------------------------------------------------------
//			cards.Add("TB_Superfriends002e", new List<Power> {
//				// TODO [TB_Superfriends002e] Draw Offensive Play && Test: Draw Offensive Play_TB_Superfriends002e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ------------------------------------------ SPELL - ROGUE
//			// [FB_LK_Rogue_copy] Rogue (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Select Rogue as your next class.
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			cards.Add("FB_LK_Rogue_copy", new List<Power> {
//				// TODO [FB_LK_Rogue_copy] Rogue && Test: Rogue_FB_LK_Rogue_copy
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ------------------------------------------ SPELL - ROGUE
//			// [TB_ClassRandom_Rogue] Second Class: Rogue (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Add Rogue cards to your deck.
//			// --------------------------------------------------------
//			cards.Add("TB_ClassRandom_Rogue", new List<Power> {
//				// TODO [TB_ClassRandom_Rogue] Second Class: Rogue && Test: Second Class: Rogue_TB_ClassRandom_Rogue
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ------------------------------------------ SPELL - ROGUE
//			// [TB_CoOpv3_201] Cast from Shadow (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Destroy all undamaged minions. Return the rest to their owner's hand.
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpv3_201", new List<Power> {
//				// TODO [TB_CoOpv3_201] Cast from Shadow && Test: Cast from Shadow_TB_CoOpv3_201
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ------------------------------------------ SPELL - ROGUE
//			// [TB_TagTeam_Rogue] The Saint (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Assassinate with blinding speed!
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			cards.Add("TB_TagTeam_Rogue", new List<Power> {
//				// TODO [TB_TagTeam_Rogue] The Saint && Test: The Saint_TB_TagTeam_Rogue
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//		}

//		private static void ShamanNonCollect(IDictionary<string, List<Power>> cards)
//		{
//			// ----------------------------------- ENCHANTMENT - SHAMAN
//			// [FB_LK_Shaman_Ench_copy] Next Hero: Shaman Ench Copy (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Add Shaman cards to your deck.
//			// --------------------------------------------------------
//			// Entourage: CS2_049
//			// --------------------------------------------------------
//			cards.Add("FB_LK_Shaman_Ench_copy", new List<Power> {
//				// TODO [FB_LK_Shaman_Ench_copy] Next Hero: Shaman Ench Copy && Test: Next Hero: Shaman Ench Copy_FB_LK_Shaman_Ench_copy
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------- ENCHANTMENT - SHAMAN
//			// [FB_TagTeam_Shaman_Ench] Next Hero: Shaman Ench (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Add Shaman cards to your deck.
//			// --------------------------------------------------------
//			// Entourage: CS2_049
//			// --------------------------------------------------------
//			cards.Add("FB_TagTeam_Shaman_Ench", new List<Power> {
//				// TODO [FB_TagTeam_Shaman_Ench] Next Hero: Shaman Ench && Test: Next Hero: Shaman Ench_FB_TagTeam_Shaman_Ench
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ----------------------------------------- SPELL - SHAMAN
//			// [FB_LK_Shaman_copy] Shaman (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Select Shaman as your next class.
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			cards.Add("FB_LK_Shaman_copy", new List<Power> {
//				// TODO [FB_LK_Shaman_copy] Shaman && Test: Shaman_FB_LK_Shaman_copy
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ----------------------------------------- SPELL - SHAMAN
//			// [TB_ClassRandom_Shaman] Second Class: Shaman (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Add Shaman cards to your deck.
//			// --------------------------------------------------------
//			cards.Add("TB_ClassRandom_Shaman", new List<Power> {
//				// TODO [TB_ClassRandom_Shaman] Second Class: Shaman && Test: Second Class: Shaman_TB_ClassRandom_Shaman
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ----------------------------------------- SPELL - SHAMAN
//			// [TB_CoOpv3_006] Elemental Eruption (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Deal 4-6 damage to all other minions.
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpv3_006", new List<Power> {
//				// TODO [TB_CoOpv3_006] Elemental Eruption && Test: Elemental Eruption_TB_CoOpv3_006
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ----------------------------------------- SPELL - SHAMAN
//			// [TB_TagTeam_Shaman] Totems Versus Secrets (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Uncover your adversary's secrets, while assembling your totem army
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			cards.Add("TB_TagTeam_Shaman", new List<Power> {
//				// TODO [TB_TagTeam_Shaman] Totems Versus Secrets && Test: Totems Versus Secrets_TB_TagTeam_Shaman
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//		}

//		private static void WarlockNonCollect(IDictionary<string, List<Power>> cards)
//		{
//			// ---------------------------------- ENCHANTMENT - WARLOCK
//			// [FB_LK_Warlock_Ench_copy] Next Hero: Warlock Ench Copy (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Add Warlock cards to your deck.
//			// --------------------------------------------------------
//			// Entourage: CS2_056
//			// --------------------------------------------------------
//			cards.Add("FB_LK_Warlock_Ench_copy", new List<Power> {
//				// TODO [FB_LK_Warlock_Ench_copy] Next Hero: Warlock Ench Copy && Test: Next Hero: Warlock Ench Copy_FB_LK_Warlock_Ench_copy
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - WARLOCK
//			// [FB_TagTeam_Warlock_Ench] Next Hero: Warlock Ench (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Add Warlock cards to your deck.
//			// --------------------------------------------------------
//			// Entourage: CS2_056
//			// --------------------------------------------------------
//			cards.Add("FB_TagTeam_Warlock_Ench", new List<Power> {
//				// TODO [FB_TagTeam_Warlock_Ench] Next Hero: Warlock Ench && Test: Next Hero: Warlock Ench_FB_TagTeam_Warlock_Ench
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------------- SPELL - WARLOCK
//			// [FB_LK_Warlock_copy] Warlock (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Select Warlock as your next class.
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			cards.Add("FB_LK_Warlock_copy", new List<Power> {
//				// TODO [FB_LK_Warlock_copy] Warlock && Test: Warlock_FB_LK_Warlock_copy
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - WARLOCK
//			// [TB_ClassRandom_Warlock] Second Class: Warlock (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Add Warlock cards to your deck.
//			// --------------------------------------------------------
//			cards.Add("TB_ClassRandom_Warlock", new List<Power> {
//				// TODO [TB_ClassRandom_Warlock] Second Class: Warlock && Test: Second Class: Warlock_TB_ClassRandom_Warlock
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - WARLOCK
//			// [TB_SPT_DpromoEX1_312] Twisting Nether? (*) - COST:8 
//			// - Fac: neutral, Set: tb, Rarity: epic
//			// --------------------------------------------------------
//			// Text: This doesn't look like Twisting Nether...
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DpromoEX1_312", new List<Power> {
//				// TODO [TB_SPT_DpromoEX1_312] Twisting Nether? && Test: Twisting Nether?_TB_SPT_DpromoEX1_312
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - WARLOCK
//			// [TB_TagTeam_Warlock] Death Becomes (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Summon monstrous demons and burn away the enemy's weapons
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			cards.Add("TB_TagTeam_Warlock", new List<Power> {
//				// TODO [TB_TagTeam_Warlock] Death Becomes && Test: Death Becomes_TB_TagTeam_Warlock
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//		}

//		private static void WarriorNonCollect(IDictionary<string, List<Power>> cards)
//		{
//			// ---------------------------------- ENCHANTMENT - WARRIOR
//			// [FB_LK_Warrior_Ench_copy] Next Hero: Warrior Ench Copy (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Add Warrior cards to your deck.
//			// --------------------------------------------------------
//			// Entourage: CS2_102
//			// --------------------------------------------------------
//			cards.Add("FB_LK_Warrior_Ench_copy", new List<Power> {
//				// TODO [FB_LK_Warrior_Ench_copy] Next Hero: Warrior Ench Copy && Test: Next Hero: Warrior Ench Copy_FB_LK_Warrior_Ench_copy
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - WARRIOR
//			// [FB_TagTeam_Warrior_Ench] Next Hero: Warrior Ench (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Add Warrior cards to your deck.
//			// --------------------------------------------------------
//			// Entourage: CS2_102
//			// --------------------------------------------------------
//			cards.Add("FB_TagTeam_Warrior_Ench", new List<Power> {
//				// TODO [FB_TagTeam_Warrior_Ench] Next Hero: Warrior Ench && Test: Next Hero: Warrior Ench_FB_TagTeam_Warrior_Ench
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - WARRIOR
//			// [TB_MP_01e] Charge! (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Has <b>Charge</b>
//			// --------------------------------------------------------
//			cards.Add("TB_MP_01e", new List<Power> {
//				// TODO [TB_MP_01e] Charge! && Test: Charge!_TB_MP_01e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------------- SPELL - WARRIOR
//			// [FB_LK_Warrior_copy] Warrior (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Select Warrior as your next class.
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			cards.Add("FB_LK_Warrior_copy", new List<Power> {
//				// TODO [FB_LK_Warrior_copy] Warrior && Test: Warrior_FB_LK_Warrior_copy
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - WARRIOR
//			// [TB_ClassRandom_Warrior] Second Class: Warrior (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Add Warrior cards to your deck.
//			// --------------------------------------------------------
//			cards.Add("TB_ClassRandom_Warrior", new List<Power> {
//				// TODO [TB_ClassRandom_Warrior] Second Class: Warrior && Test: Second Class: Warrior_TB_ClassRandom_Warrior
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - WARRIOR
//			// [TB_SPT_DPromoSecre8] Visions of the Assassin (*) - COST:2 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Secret:</b> When your opponent plays a minion with <b>Stealth</b>, All minions equip a dagger.
//			// --------------------------------------------------------
//			// GameTag:
//			// - SECRET = 1
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DPromoSecre8", new List<Power> {
//				// TODO [TB_SPT_DPromoSecre8] Visions of the Assassin && Test: Visions of the Assassin_TB_SPT_DPromoSecre8
//				new Power
//				{
//					InfoCardId = "TB_SPT_DPromoSecre8e",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - WARRIOR
//			// [TB_SPT_DPromoSecret1] Visions of the Barbarian (*) - COST:2 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Secret:</b> When your opponent plays a minion with <b>Charge</b>, THUNDER FURY!
//			// --------------------------------------------------------
//			// GameTag:
//			// - SECRET = 1
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DPromoSecret1", new List<Power> {
//				// TODO [TB_SPT_DPromoSecret1] Visions of the Barbarian && Test: Visions of the Barbarian_TB_SPT_DPromoSecret1
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - WARRIOR
//			// [TB_SPT_DPromoSecret10] Visions of Hate (*) - COST:2 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Secret:</b> When both heroes have 15 or less Health, BRAWL!
//			// --------------------------------------------------------
//			// GameTag:
//			// - SECRET = 1
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DPromoSecret10", new List<Power> {
//				// TODO [TB_SPT_DPromoSecret10] Visions of Hate && Test: Visions of Hate_TB_SPT_DPromoSecret10
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - WARRIOR
//			// [TB_SPT_DPromoSecret2] Visions of the Crusader (*) - COST:2 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Secret:</b> When your opponent plays a minion with <b>Taunt</b>, change all minions'
//			//       attacks to 1.
//			// --------------------------------------------------------
//			// GameTag:
//			// - SECRET = 1
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DPromoSecret2", new List<Power> {
//				// TODO [TB_SPT_DPromoSecret2] Visions of the Crusader && Test: Visions of the Crusader_TB_SPT_DPromoSecret2
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - WARRIOR
//			// [TB_SPT_DPromoSecret3] Visions of Valor (*) - COST:2 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Secret:</b> When your opponent plays a Legendary minion, give all minions <b>Windfury</b>
//			// --------------------------------------------------------
//			// GameTag:
//			// - SECRET = 1
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DPromoSecret3", new List<Power> {
//				// TODO [TB_SPT_DPromoSecret3] Visions of Valor && Test: Visions of Valor_TB_SPT_DPromoSecret3
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - WARRIOR
//			// [TB_SPT_DPromoSecret4] Visions of Fate (*) - COST:2 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Secret:</b> When your opponent takes lethal damage... save him.
//			// --------------------------------------------------------
//			// GameTag:
//			// - SECRET = 1
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DPromoSecret4", new List<Power> {
//				// TODO [TB_SPT_DPromoSecret4] Visions of Fate && Test: Visions of Fate_TB_SPT_DPromoSecret4
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - WARRIOR
//			// [TB_SPT_DPromoSecret5] Visions of the Amazon (*) - COST:2 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Secret:</b> When your opponent plays a minion with <b>Battlecry</b>, Summon a Mirror Image for both players.
//			// --------------------------------------------------------
//			// GameTag:
//			// - SECRET = 1
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DPromoSecret5", new List<Power> {
//				// TODO [TB_SPT_DPromoSecret5] Visions of the Amazon && Test: Visions of the Amazon_TB_SPT_DPromoSecret5
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - WARRIOR
//			// [TB_SPT_DPromoSecret6] Visions of the Sorcerer (*) - COST:2 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Secret:</b> When your opponent plays a minion with <b>Spell Damage</b>, Summon 2 Guardians.
//			// --------------------------------------------------------
//			// GameTag:
//			// - SECRET = 1
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DPromoSecret6", new List<Power> {
//				// TODO [TB_SPT_DPromoSecret6] Visions of the Sorcerer && Test: Visions of the Sorcerer_TB_SPT_DPromoSecret6
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - WARRIOR
//			// [TB_SPT_DPromoSecret7] Visions of the Necromancer (*) - COST:2 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Secret:</b> When your opponent plays a card with <b>Deathrattle</b>, destroy it.
//			// --------------------------------------------------------
//			// GameTag:
//			// - SECRET = 1
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DPromoSecret7", new List<Power> {
//				// TODO [TB_SPT_DPromoSecret7] Visions of the Necromancer && Test: Visions of the Necromancer_TB_SPT_DPromoSecret7
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - WARRIOR
//			// [TB_SPT_DPromoSecret9] Visions of Knowledge (*) - COST:2 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Secret:</b> When your opponent's hand has 9 or more cards, reduce the cost of all cards in both hands to (1).
//			// --------------------------------------------------------
//			// GameTag:
//			// - SECRET = 1
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DPromoSecret9", new List<Power> {
//				// TODO [TB_SPT_DPromoSecret9] Visions of Knowledge && Test: Visions of Knowledge_TB_SPT_DPromoSecret9
//				new Power
//				{
//					InfoCardId = "TB_SPT_DPromoSecret9e",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - WARRIOR
//			// [TB_TagTeam_Warrior] The Rock (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Enrage your allies, while wielding weapons at your foes!
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			cards.Add("TB_TagTeam_Warrior", new List<Power> {
//				// TODO [TB_TagTeam_Warrior] The Rock && Test: The Rock_TB_TagTeam_Warrior
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//		}

//		private static void DreamNonCollect(IDictionary<string, List<Power>> cards)
//		{
//			// ------------------------------------ ENCHANTMENT - DREAM
//			// [TB_MP_02e] Repurposed (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> Draw a card.
//			// --------------------------------------------------------
//			cards.Add("TB_MP_02e", new List<Power> {
//				// TODO [TB_MP_02e] Repurposed && Test: Repurposed_TB_MP_02e
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
//			// [BRMC_100e] Living Bomb (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: On Ragnaros' turn, deal 5 damage to this side of the board.
//			// --------------------------------------------------------
//			cards.Add("BRMC_100e", new List<Power> {
//				// TODO [BRMC_100e] Living Bomb && Test: Living Bomb_BRMC_100e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [BRMC_86e] I Hear You... (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Increased Attack.
//			// --------------------------------------------------------
//			cards.Add("BRMC_86e", new List<Power> {
//				// TODO [BRMC_86e] I Hear You... && Test: I Hear You..._BRMC_86e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [BRMC_97e] Burning Adrenaline (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Costs (2) less.
//			// --------------------------------------------------------
//			cards.Add("BRMC_97e", new List<Power> {
//				// TODO [BRMC_97e] Burning Adrenaline && Test: Burning Adrenaline_BRMC_97e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [BRMC_98e] Dragonlust (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: +3 Attack.
//			// --------------------------------------------------------
//			cards.Add("BRMC_98e", new List<Power> {
//				// TODO [BRMC_98e] Dragonlust && Test: Dragonlust_BRMC_98e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [FB_LK003] Check for Hero Death in Lich King Raid (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("FB_LK003", new List<Power> {
//				// TODO [FB_LK003] Check for Hero Death in Lich King Raid && Test: Check for Hero Death in Lich King Raid_FB_LK003
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [FB_LK009] Swap Hero With Death Knight (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("FB_LK009", new List<Power> {
//				// TODO [FB_LK009] Swap Hero With Death Knight && Test: Swap Hero With Death Knight_FB_LK009
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [FB_LK_GetClass_copy] Discover Next Class Copy (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Entourage: FB_LK_Warrior_copy, FB_LK_Druid_copy, FB_LK_Hunter_copy, FB_LK_Mage_copy, FB_LK_Paladin_copy, FB_LK_Priest_copy, FB_LK_Rogue_copy, FB_LK_Shaman_copy, FB_LK_Warlock_copy
//			// --------------------------------------------------------
//			cards.Add("FB_LK_GetClass_copy", new List<Power> {
//				// TODO [FB_LK_GetClass_copy] Discover Next Class Copy && Test: Discover Next Class Copy_FB_LK_GetClass_copy
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [FB_LK_WaitForDiscover] Wait for Discover (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("FB_LK_WaitForDiscover", new List<Power> {
//				// TODO [FB_LK_WaitForDiscover] Wait for Discover && Test: Wait for Discover_FB_LK_WaitForDiscover
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [FB_LKStats001] Innkeeper Tools (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Fight the Lich King or make modifications to his health.
//			// --------------------------------------------------------
//			// Entourage: FB_LKStats001a, FB_LKStats002
//			// --------------------------------------------------------
//			cards.Add("FB_LKStats001", new List<Power> {
//				// TODO [FB_LKStats001] Innkeeper Tools && Test: Innkeeper Tools_FB_LKStats001
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [FB_LKStats002ench] Lich King Modifications Copy (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Entourage: FB_LKStats002a, FB_LKStats002b, FB_LKStats002c
//			// --------------------------------------------------------
//			cards.Add("FB_LKStats002ench", new List<Power> {
//				// TODO [FB_LKStats002ench] Lich King Modifications Copy && Test: Lich King Modifications Copy_FB_LKStats002ench
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [FB_TagTeam_WaitForDiscover] Wait for Discover (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("FB_TagTeam_WaitForDiscover", new List<Power> {
//				// TODO [FB_TagTeam_WaitForDiscover] Wait for Discover && Test: Wait for Discover_FB_TagTeam_WaitForDiscover
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [HRW02_1e] Overclock (*) - COST:1 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Increased Attack.
//			// --------------------------------------------------------
//			cards.Add("HRW02_1e", new List<Power> {
//				// TODO [HRW02_1e] Overclock && Test: Overclock_HRW02_1e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [KARA_13_19e] Saddened (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Can't attack this turn.
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAG_ONE_TURN_EFFECT = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_13_19e", new List<Power> {
//				// TODO [KARA_13_19e] Saddened && Test: Saddened_KARA_13_19e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_001] Boss HP Swapper (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Entourage: BRMA14_10, BRMA14_10H, BRMA09_4, BRMA09_4H, BRMA17_5, BRMA17_5H, NAX15_04, NAX15_04H, NAX12_02, NAX12_02H, BRM_027p, BRM_027pH, BRMA09_5, BRMA09_5H, BRMA16_2, BRMA16_2H, NAX5_02, NAX5_02H, BRMA11_2, BRMA11_2H, BRMA17_8, BRMA17_8H, NAX15_02, NAX15_02H, NAX14_02, NAX8_02, NAX8_02H, NAX10_03, NAX10_03H, BRMA05_2, BRMA05_2H, BRMA02_2, BRMA02_2H, BRMA04_2, BRMA07_2, BRMA07_2H, NAX6_02, NAX6_02H, BRMA09_2, BRMA09_2H, BRMA01_2, BRMA01_2H, NAX11_02, NAX11_02H, NAX13_02, NAX2_03, NAX2_03H, NAX1_04, NAX1h_04, BRMA06_2, BRMA06_2H, BRMA10_3, BRMA10_3H, NAX7_03, NAX7_03H, NAX9_06, NAX3_02, NAX3_02H, BRMA13_4, BRMA13_4H
//			// --------------------------------------------------------
//			cards.Add("TB_001", new List<Power> {
//				// TODO [TB_001] Boss HP Swapper && Test: Boss HP Swapper_TB_001
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_006e] Big Banana (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Has +2/+2.
//			// --------------------------------------------------------
//			cards.Add("TB_006e", new List<Power> {
//				// TODO [TB_006e] Big Banana && Test: Big Banana_TB_006e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_007e] Deviate Switch (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Attack and Health have been swapped by Deviate Banana.
//			// --------------------------------------------------------
//			cards.Add("TB_007e", new List<Power> {
//				// TODO [TB_007e] Deviate Switch && Test: Deviate Switch_TB_007e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_009] Create 15 Secrets (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Entourage: FP1_020, EX1_287, FP1_018, EX1_610, EX1_132, EX1_611, EX1_289, EX1_295, EX1_294, EX1_533, EX1_130, EX1_136, EX1_379, EX1_554, EX1_609, tt_010, EX1_594
//			// --------------------------------------------------------
//			cards.Add("TB_009", new List<Power> {
//				// TODO [TB_009] Create 15 Secrets && Test: Create 15 Secrets_TB_009
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_010] Deckbuilding Enchant (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("TB_010", new List<Power> {
//				// TODO [TB_010] Deckbuilding Enchant && Test: Deckbuilding Enchant_TB_010
//				new Power
//				{
//					InfoCardId = "TB_010e",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_010e] Choose One of Three (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("TB_010e", new List<Power> {
//				// TODO [TB_010e] Choose One of Three && Test: Choose One of Three_TB_010e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_100th_001] Valeera's Bag Enchant (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Playing a spell summons a minion of that type.
//			// --------------------------------------------------------
//			cards.Add("TB_100th_001", new List<Power> {
//				// TODO [TB_100th_001] Valeera's Bag Enchant && Test: Valeera's Bag Enchant_TB_100th_001
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_100th_BananaPlayerEnchant] Bananas on Death (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Spawn Banana
//			// --------------------------------------------------------
//			cards.Add("TB_100th_BananaPlayerEnchant", new List<Power> {
//				// TODO [TB_100th_BananaPlayerEnchant] Bananas on Death && Test: Bananas on Death_TB_100th_BananaPlayerEnchant
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_AllMinionsTauntCharge] Give Taunt and Charge (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: This minion is granted <b>Taunt</b> and <b>Charge</b>.
//			// --------------------------------------------------------
//			cards.Add("TB_AllMinionsTauntCharge", new List<Power> {
//				// TODO [TB_AllMinionsTauntCharge] Give Taunt and Charge && Test: Give Taunt and Charge_TB_AllMinionsTauntCharge
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_BlingBrawl_Blade1e] Blingtron's Blade (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: When this breaks, randomly summon a new weapon.
//			// --------------------------------------------------------
//			cards.Add("TB_BlingBrawl_Blade1e", new List<Power> {
//				// TODO [TB_BlingBrawl_Blade1e] Blingtron's Blade && Test: Blingtron's Blade_TB_BlingBrawl_Blade1e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_BlingBrawl_Blade2e] Blingtron's Blade HERO (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("TB_BlingBrawl_Blade2e", new List<Power> {
//				// TODO [TB_BlingBrawl_Blade2e] Blingtron's Blade HERO && Test: Blingtron's Blade HERO_TB_BlingBrawl_Blade2e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_Blizzcon2016_GoonsEnchant] The Grimy Goons (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("TB_Blizzcon2016_GoonsEnchant", new List<Power> {
//				// TODO [TB_Blizzcon2016_GoonsEnchant] The Grimy Goons && Test: The Grimy Goons_TB_Blizzcon2016_GoonsEnchant
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_Blizzcon2016_KabalEnchant] The Kabal (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("TB_Blizzcon2016_KabalEnchant", new List<Power> {
//				// TODO [TB_Blizzcon2016_KabalEnchant] The Kabal && Test: The Kabal_TB_Blizzcon2016_KabalEnchant
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_Blizzcon2016_LotusEnchant] The Jade Lotus (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("TB_Blizzcon2016_LotusEnchant", new List<Power> {
//				// TODO [TB_Blizzcon2016_LotusEnchant] The Jade Lotus && Test: The Jade Lotus_TB_Blizzcon2016_LotusEnchant
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_BoomAnnoy_001e] Loves Annoy-o-tron (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: +2/+2.
//			// --------------------------------------------------------
//			cards.Add("TB_BoomAnnoy_001e", new List<Power> {
//				// TODO [TB_BoomAnnoy_001e] Loves Annoy-o-tron && Test: Loves Annoy-o-tron_TB_BoomAnnoy_001e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_BoomBotFestival_001e] Boom Bot Attached (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> Deal 1-4 damage to a random enemy.
//			// --------------------------------------------------------
//			cards.Add("TB_BoomBotFestival_001e", new List<Power> {
//				// TODO [TB_BoomBotFestival_001e] Boom Bot Attached && Test: Boom Bot Attached_TB_BoomBotFestival_001e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_ClassRandom_Pick2nd_100th] Pick your second class (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Entourage: TB_ClassRandom_Warrior, TB_ClassRandom_Warlock, TB_ClassRandom_Shaman, TB_ClassRandom_Rogue, TB_ClassRandom_Priest, TB_ClassRandom_Paladin, TB_ClassRandom_Mage, TB_ClassRandom_Hunter, TB_ClassRandom_Druid
//			// --------------------------------------------------------
//			cards.Add("TB_ClassRandom_Pick2nd_100th", new List<Power> {
//				// TODO [TB_ClassRandom_Pick2nd_100th] Pick your second class && Test: Pick your second class_TB_ClassRandom_Pick2nd_100th
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_ClassRandom_PickSecondClass] Pick your second class (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Entourage: TB_ClassRandom_Warrior, TB_ClassRandom_Warlock, TB_ClassRandom_Shaman, TB_ClassRandom_Rogue, TB_ClassRandom_Priest, TB_ClassRandom_Paladin, TB_ClassRandom_Mage, TB_ClassRandom_Hunter, TB_ClassRandom_Druid
//			// --------------------------------------------------------
//			cards.Add("TB_ClassRandom_PickSecondClass", new List<Power> {
//				// TODO [TB_ClassRandom_PickSecondClass] Pick your second class && Test: Pick your second class_TB_ClassRandom_PickSecondClass
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_CoOpv3_009e] Going Nova (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: It's about to blow!
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpv3_009e", new List<Power> {
//				// TODO [TB_CoOpv3_009e] Going Nova && Test: Going Nova_TB_CoOpv3_009e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_CoOpv3_101e] Team Player Enchantment (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Immune</b> ahile attacking
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpv3_101e", new List<Power> {
//				// TODO [TB_CoOpv3_101e] Team Player Enchantment && Test: Team Player Enchantment_TB_CoOpv3_101e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_CoOpv3_104e] Unity (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: +2/+2
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpv3_104e", new List<Power> {
//				// TODO [TB_CoOpv3_104e] Unity && Test: Unity_TB_CoOpv3_104e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_CoOpv3_BOSS2e] Getting Angry.... (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Now he's mad....
//			// --------------------------------------------------------
//			// GameTag:
//			// - ENRAGED = 1
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpv3_BOSS2e", new List<Power> {
//				// TODO [TB_CoOpv3_BOSS2e] Getting Angry.... && Test: Getting Angry...._TB_CoOpv3_BOSS2e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_CoOpv3_BOSS3e] Enough! (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Nefarian is <b>Immune</b> this turn.
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAG_ONE_TURN_EFFECT = 1
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpv3_BOSS3e", new List<Power> {
//				// TODO [TB_CoOpv3_BOSS3e] Enough! && Test: Enough!_TB_CoOpv3_BOSS3e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_CoOpv3_BOSS4e] Cowed (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Can't attack this turn.
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAG_ONE_TURN_EFFECT = 1
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpv3_BOSS4e", new List<Power> {
//				// TODO [TB_CoOpv3_BOSS4e] Cowed && Test: Cowed_TB_CoOpv3_BOSS4e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_CoOpv3_BOSSe] WHY WON'T YOU DIE!? (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Now he's REALLY mad....
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpv3_BOSSe", new List<Power> {
//				// TODO [TB_CoOpv3_BOSSe] WHY WON'T YOU DIE!? && Test: WHY WON'T YOU DIE!?_TB_CoOpv3_BOSSe
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_DeckRecipe_MyDeckID] My Deck ID (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("TB_DeckRecipe_MyDeckID", new List<Power> {
//				// TODO [TB_DeckRecipe_MyDeckID] My Deck ID && Test: My Deck ID_TB_DeckRecipe_MyDeckID
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_DiscoverMyDeck_Enchantment] Discover My Deck Enchant (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("TB_DiscoverMyDeck_Enchantment", new List<Power> {
//				// TODO [TB_DiscoverMyDeck_Enchantment] Discover My Deck Enchant && Test: Discover My Deck Enchant_TB_DiscoverMyDeck_Enchantment
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_EndlessMinions01] Endless Enchantment (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: +2/+2.
//			// --------------------------------------------------------
//			cards.Add("TB_EndlessMinions01", new List<Power> {
//				// TODO [TB_EndlessMinions01] Endless Enchantment && Test: Endless Enchantment_TB_EndlessMinions01
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_Face_Ench1] Safe (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: This minion is safe from attacks and cannot have taunt.
//			// --------------------------------------------------------
//			cards.Add("TB_Face_Ench1", new List<Power> {
//				// TODO [TB_Face_Ench1] Safe && Test: Safe_TB_Face_Ench1
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_FireFestEnch] Conflagrate (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Gains Attack for each minion killed.
//			// --------------------------------------------------------
//			cards.Add("TB_FireFestEnch", new List<Power> {
//				// TODO [TB_FireFestEnch] Conflagrate && Test: Conflagrate_TB_FireFestEnch
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_GiftExchange_Enchantment] Cheap Gift (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: This card's cost is reduced.
//			// --------------------------------------------------------
//			cards.Add("TB_GiftExchange_Enchantment", new List<Power> {
//				// TODO [TB_GiftExchange_Enchantment] Cheap Gift && Test: Cheap Gift_TB_GiftExchange_Enchantment
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_GP_01e] Shadow Tower Power (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Can't Attack.
//			//       <b>Stealth</b>.
//			// --------------------------------------------------------
//			// GameTag:
//			// - CANT_ATTACK = 1
//			// --------------------------------------------------------
//			cards.Add("TB_GP_01e", new List<Power> {
//				// TODO [TB_GP_01e] Shadow Tower Power && Test: Shadow Tower Power_TB_GP_01e
//				new Power
//				{
//					InfoCardId = "TB_GP_01e_copy1",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_GP_01e_copy1] Shadow Tower Give My minions Stealth (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Can't Attack.
//			//       <b>Stealth</b>.
//			// --------------------------------------------------------
//			// GameTag:
//			// - CANT_ATTACK = 1
//			// --------------------------------------------------------
//			cards.Add("TB_GP_01e_copy1", new List<Power> {
//				// TODO [TB_GP_01e_copy1] Shadow Tower Give My minions Stealth && Test: Shadow Tower Give My minions Stealth_TB_GP_01e_copy1
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_GP_01e_v2] Shadow Tower Stealth (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Stealth</b>.
//			// --------------------------------------------------------
//			cards.Add("TB_GP_01e_v2", new List<Power> {
//				// TODO [TB_GP_01e_v2] Shadow Tower Stealth && Test: Shadow Tower Stealth_TB_GP_01e_v2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_GreatCurves_01] TB_ClockworkCardDealer (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("TB_GreatCurves_01", new List<Power> {
//				// TODO [TB_GreatCurves_01] TB_ClockworkCardDealer && Test: TB_ClockworkCardDealer_TB_GreatCurves_01
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_KaraPortal_003] Saddened Hero Enchant (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Give can't attack this turn to enemy minions.
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAG_ONE_TURN_EFFECT = 1
//			// --------------------------------------------------------
//			cards.Add("TB_KaraPortal_003", new List<Power> {
//				// TODO [TB_KaraPortal_003] Saddened Hero Enchant && Test: Saddened Hero Enchant_TB_KaraPortal_003
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_KTRAF_10e] Dark Power (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Granted power from Noth
//			// --------------------------------------------------------
//			cards.Add("TB_KTRAF_10e", new List<Power> {
//				// TODO [TB_KTRAF_10e] Dark Power && Test: Dark Power_TB_KTRAF_10e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_LethalSetup02] Brawl Progress Saved (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Welcome back! Would you like to restart or continue?
//			// --------------------------------------------------------
//			// Entourage: TB_LethalSetup001a, TB_LethalSetup001b
//			// --------------------------------------------------------
//			cards.Add("TB_LethalSetup02", new List<Power> {
//				// TODO [TB_LethalSetup02] Brawl Progress Saved && Test: Brawl Progress Saved_TB_LethalSetup02
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_MammothParty_s002ee] Raucous (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: +2/+2
//			// --------------------------------------------------------
//			// GameTag:
//			// - UNTOUCHABLE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_MammothParty_s002ee", new List<Power> {
//				// TODO [TB_MammothParty_s002ee] Raucous && Test: Raucous_TB_MammothParty_s002ee
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_MechWar_CommonCards] TBMechWarCommonCards (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Entourage: GVG_069, GVG_079, GVG_034, GVG_048, GVG_049, GVG_088
//			// --------------------------------------------------------
//			cards.Add("TB_MechWar_CommonCards", new List<Power> {
//				// TODO [TB_MechWar_CommonCards] TBMechWarCommonCards && Test: TBMechWarCommonCards_TB_MechWar_CommonCards
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_Mini_1e] Miniature (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Mini-sized, set to 1/1
//			// --------------------------------------------------------
//			cards.Add("TB_Mini_1e", new List<Power> {
//				// TODO [TB_Mini_1e] Miniature && Test: Miniature_TB_Mini_1e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_PickYourFate] Pick Your Fate Build Around (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Entourage: TB_PickYourFate_9, TB_PickYourFate_10, TB_PickYourFate_11b, TB_PickYourFate_8
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate", new List<Power> {
//				// TODO [TB_PickYourFate] Pick Your Fate Build Around && Test: Pick Your Fate Build Around_TB_PickYourFate
//				new Power
//				{
//					InfoCardId = "TB_PickYourFate7Ench",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_PickYourFate7Ench] Fate 7 Ench Get a Coin (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate7Ench", new List<Power> {
//				// TODO [TB_PickYourFate7Ench] Fate 7 Ench Get a Coin && Test: Fate 7 Ench Get a Coin_TB_PickYourFate7Ench
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_PickYourFate_10_Ench] Fate (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_10_Ench", new List<Power> {
//				// TODO [TB_PickYourFate_10_Ench] Fate && Test: Fate_TB_PickYourFate_10_Ench
//				new Power
//				{
//					InfoCardId = "TB_PickYourFate_10_EnchMinion",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_PickYourFate_10_EnchMinion] Bonus (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Your <b>Battlecry</b> minions have +1/+1.
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_10_EnchMinion", new List<Power> {
//				// TODO [TB_PickYourFate_10_EnchMinion] Bonus && Test: Bonus_TB_PickYourFate_10_EnchMinion
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_PickYourFate_11_Ench] Fate 11 Ench. Murloc (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_11_Ench", new List<Power> {
//				// TODO [TB_PickYourFate_11_Ench] Fate 11 Ench. Murloc && Test: Fate 11 Ench. Murloc_TB_PickYourFate_11_Ench
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_PickYourFate_12_Ench] Fate 12 Ench, Confuse (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_12_Ench", new List<Power> {
//				// TODO [TB_PickYourFate_12_Ench] Fate 12 Ench, Confuse && Test: Fate 12 Ench, Confuse_TB_PickYourFate_12_Ench
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_PickYourFate_1_Ench] Pick Your Fate 1 Ench (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_1_Ench", new List<Power> {
//				// TODO [TB_PickYourFate_1_Ench] Pick Your Fate 1 Ench && Test: Pick Your Fate 1 Ench_TB_PickYourFate_1_Ench
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_PickYourFate_2_Ench] Pick Your Fate 2 Ench (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_2_Ench", new List<Power> {
//				// TODO [TB_PickYourFate_2_Ench] Pick Your Fate 2 Ench && Test: Pick Your Fate 2 Ench_TB_PickYourFate_2_Ench
//				new Power
//				{
//					InfoCardId = "TB_PickYourFate_2_EnchMinion",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_PickYourFate_2_EnchMinion] Fate (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> Your owner gets a banana.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_2_EnchMinion", new List<Power> {
//				// TODO [TB_PickYourFate_2_EnchMinion] Fate && Test: Fate_TB_PickYourFate_2_EnchMinion
//				new Power
//				{
//					Activation = PowerActivation.DEATHRATTLE,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_PickYourFate_2nd] Pick Your Fate Randon 2nd (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Entourage: TB_PickYourFate_1, TB_PickYourFate_4, TB_PickYourFate_7_2nd, TB_PickYourFate_3, TB_PickYourFate_6_2nd, TB_PickYourFate_11rand
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_2nd", new List<Power> {
//				// TODO [TB_PickYourFate_2nd] Pick Your Fate Randon 2nd && Test: Pick Your Fate Randon 2nd_TB_PickYourFate_2nd
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_PickYourFate_3_Ench] Pick Your Fate 3 Ench (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_3_Ench", new List<Power> {
//				// TODO [TB_PickYourFate_3_Ench] Pick Your Fate 3 Ench && Test: Pick Your Fate 3 Ench_TB_PickYourFate_3_Ench
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_PickYourFate_4_Ench] Pick Your Fate 4 Ench (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_4_Ench", new List<Power> {
//				// TODO [TB_PickYourFate_4_Ench] Pick Your Fate 4 Ench && Test: Pick Your Fate 4 Ench_TB_PickYourFate_4_Ench
//				new Power
//				{
//					InfoCardId = "TB_PickYourFate_4_EnchMinion",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_PickYourFate_4_EnchMinion] Fate (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> Draw a card.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_4_EnchMinion", new List<Power> {
//				// TODO [TB_PickYourFate_4_EnchMinion] Fate && Test: Fate_TB_PickYourFate_4_EnchMinion
//				new Power
//				{
//					Activation = PowerActivation.DEATHRATTLE,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_PickYourFate_5_Ench] Pick Your Fate 5 Ench (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_5_Ench", new List<Power> {
//				// TODO [TB_PickYourFate_5_Ench] Pick Your Fate 5 Ench && Test: Pick Your Fate 5 Ench_TB_PickYourFate_5_Ench
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_PickYourFate_7_Ench_2nd] Fate 7 Ench 2nd (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_7_Ench_2nd", new List<Power> {
//				// TODO [TB_PickYourFate_7_Ench_2nd] Fate 7 Ench 2nd && Test: Fate 7 Ench 2nd_TB_PickYourFate_7_Ench_2nd
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_PickYourFate_7_EnchMiniom2nd] Fate (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> random card in owner's hand costs (0).
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_7_EnchMiniom2nd", new List<Power> {
//				// TODO [TB_PickYourFate_7_EnchMiniom2nd] Fate && Test: Fate_TB_PickYourFate_7_EnchMiniom2nd
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_PickYourFate_7_EnchMinion] Fate (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> Your owner gets a coin.
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_7_EnchMinion", new List<Power> {
//				// TODO [TB_PickYourFate_7_EnchMinion] Fate && Test: Fate_TB_PickYourFate_7_EnchMinion
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_PickYourFate_8_Ench] Fate 8 Get Armor (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_8_Ench", new List<Power> {
//				// TODO [TB_PickYourFate_8_Ench] Fate 8 Get Armor && Test: Fate 8 Get Armor_TB_PickYourFate_8_Ench
//				new Power
//				{
//					InfoCardId = "TB_PickYourFate_8_EnchRand",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_PickYourFate_8_EnchRand] Fate 8 Rand 2 armor each turn (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_8_EnchRand", new List<Power> {
//				// TODO [TB_PickYourFate_8_EnchRand] Fate 8 Rand 2 armor each turn && Test: Fate 8 Rand 2 armor each turn_TB_PickYourFate_8_EnchRand
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_PickYourFate_9_Ench] Fate 9 Ench. Deathrattle bonus (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_9_Ench", new List<Power> {
//				// TODO [TB_PickYourFate_9_Ench] Fate 9 Ench. Deathrattle bonus && Test: Fate 9 Ench. Deathrattle bonus_TB_PickYourFate_9_Ench
//				new Power
//				{
//					InfoCardId = "TB_PickYourFate_9_EnchMinion",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_PickYourFate_9_EnchMinion] Bonus (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Your <b>Deathrattle</b> minions have +1/+1.
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_9_EnchMinion", new List<Power> {
//				// TODO [TB_PickYourFate_9_EnchMinion] Bonus && Test: Bonus_TB_PickYourFate_9_EnchMinion
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_PickYourFate_Confused] Fate (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Attack and Health swap at end of each turn.
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_Confused", new List<Power> {
//				// TODO [TB_PickYourFate_Confused] Fate && Test: Fate_TB_PickYourFate_Confused
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_PickYourFate_Windfury] Fate (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: This minion has <b>Windfury</b>
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_Windfury", new List<Power> {
//				// TODO [TB_PickYourFate_Windfury] Fate && Test: Fate_TB_PickYourFate_Windfury
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_PickYourFateRandom] Pick Your Fate Random (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Entourage: TB_PickYourFate_12, TB_PickYourFate_2, TB_PickYourFate_8rand, TB_PickYourFate_6, TB_PickYourFate_5, TB_PickYourFate_7
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFateRandom", new List<Power> {
//				// TODO [TB_PickYourFateRandom] Pick Your Fate Random && Test: Pick Your Fate Random_TB_PickYourFateRandom
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_Pilot1] Mystery Pilot (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Who could it be?!
//			// --------------------------------------------------------
//			cards.Add("TB_Pilot1", new List<Power> {
//				// TODO [TB_Pilot1] Mystery Pilot && Test: Mystery Pilot_TB_Pilot1
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_RandCardCost] TBRandomCardCost (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("TB_RandCardCost", new List<Power> {
//				// TODO [TB_RandCardCost] TBRandomCardCost && Test: TBRandomCardCost_TB_RandCardCost
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_RandHero2_001] TB_EnchWhosTheBossNow (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Entourage: BRMA07_2_2_TB, BRMA01_2H_2_TB, BRMA17_5_TB, NAX12_02H_2_TB, BRMA02_2_2_TB, NAX11_02H_2_TB, BRMA13_4_2_TB, BRMA09_2_TB, BRMA14_10H_TB, BRMA06_2H_TB, NAX3_02_TB, NAX8_02H_TB
//			// --------------------------------------------------------
//			cards.Add("TB_RandHero2_001", new List<Power> {
//				// TODO [TB_RandHero2_001] TB_EnchWhosTheBossNow && Test: TB_EnchWhosTheBossNow_TB_RandHero2_001
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_RMC_001] TB_EnchRandomManaCost (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("TB_RMC_001", new List<Power> {
//				// TODO [TB_RMC_001] TB_EnchRandomManaCost && Test: TB_EnchRandomManaCost_TB_RMC_001
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_Spellwrite_001] SpellCaster (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("TB_Spellwrite_001", new List<Power> {
//				// TODO [TB_Spellwrite_001] SpellCaster && Test: SpellCaster_TB_Spellwrite_001
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_SPT_DPromoEnch3] Shield Glare (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Attack changed to 1.
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DPromoEnch3", new List<Power> {
//				// TODO [TB_SPT_DPromoEnch3] Shield Glare && Test: Shield Glare_TB_SPT_DPromoEnch3
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_SPT_DPromoSecre8e] Assassin's Stealth (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Stealth</b>.
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DPromoSecre8e", new List<Power> {
//				// TODO [TB_SPT_DPromoSecre8e] Assassin's Stealth && Test: Assassin's Stealth_TB_SPT_DPromoSecre8e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_SPT_DPromoSecret9e] Knowledge (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Costs (1).
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DPromoSecret9e", new List<Power> {
//				// TODO [TB_SPT_DPromoSecret9e] Knowledge && Test: Knowledge_TB_SPT_DPromoSecret9e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_SPT_DPromoSpellBovine1e] Herding (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Minion has <b>Taunt</b>.
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DPromoSpellBovine1e", new List<Power> {
//				// TODO [TB_SPT_DPromoSpellBovine1e] Herding && Test: Herding_TB_SPT_DPromoSpellBovine1e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_SPT_Minion1e] Will of Stormwind (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Stormwind is granting this card Health.
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_Minion1e", new List<Power> {
//				// TODO [TB_SPT_Minion1e] Will of Stormwind && Test: Will of Stormwind_TB_SPT_Minion1e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_SPT_Minion2e] Emboldened (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Standard Bearer is granting +2 Attack to this minion.
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_Minion2e", new List<Power> {
//				// TODO [TB_SPT_Minion2e] Emboldened && Test: Emboldened_TB_SPT_Minion2e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_SPT_Minion3e] Strength of Stormwind (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Stormwind is granting this card Attack and Health.
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_Minion3e", new List<Power> {
//				// TODO [TB_SPT_Minion3e] Strength of Stormwind && Test: Strength of Stormwind_TB_SPT_Minion3e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_SwapBossHeroPowerByClass] Swap Boss Hero Power by Class (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("TB_SwapBossHeroPowerByClass", new List<Power> {
//				// TODO [TB_SwapBossHeroPowerByClass] Swap Boss Hero Power by Class && Test: Swap Boss Hero Power by Class_TB_SwapBossHeroPowerByClass
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_SwapHeroWithDeathKnight] Swap Hero With Death Knight (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("TB_SwapHeroWithDeathKnight", new List<Power> {
//				// TODO [TB_SwapHeroWithDeathKnight] Swap Hero With Death Knight && Test: Swap Hero With Death Knight_TB_SwapHeroWithDeathKnight
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_TagTeam] Check for Hero Death (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("TB_TagTeam", new List<Power> {
//				// TODO [TB_TagTeam] Check for Hero Death && Test: Check for Hero Death_TB_TagTeam
//				new Power
//				{
//					InfoCardId = "TB_TagTeam_GetClass",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_TagTeam_GetClass] Discover Next Class (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Entourage: TB_TagTeam_Paladin, TB_TagTeam_Shaman, TB_TagTeam_Warlock, TB_TagTeam_Druid, TB_TagTeam_Hunter, TB_TagTeam_Mage, TB_TagTeam_Priest, TB_TagTeam_Rogue, TB_TagTeam_Warrior
//			// --------------------------------------------------------
//			cards.Add("TB_TagTeam_GetClass", new List<Power> {
//				// TODO [TB_TagTeam_GetClass] Discover Next Class && Test: Discover Next Class_TB_TagTeam_GetClass
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TB_YoggServant_Enchant] Yogg Servant Hero Enchant (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("TB_YoggServant_Enchant", new List<Power> {
//				// TODO [TB_YoggServant_Enchant] Yogg Servant Hero Enchant && Test: Yogg Servant Hero Enchant_TB_YoggServant_Enchant
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TBST_006] OLDTBST Push Common Card (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: push a common card into player's hand
//			// --------------------------------------------------------
//			// Entourage: TBST_003, TBST_002, TBST_001
//			// --------------------------------------------------------
//			cards.Add("TBST_006", new List<Power> {
//				// TODO [TBST_006] OLDTBST Push Common Card && Test: OLDTBST Push Common Card_TBST_006
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------- ENCHANTMENT - NEUTRAL
//			// [TBUD_1] TBUD Summon Early Minion (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Each turn, if you have less health then a your opponent, summon a free minion
//			// --------------------------------------------------------
//			// Entourage: CS1_042, CS2_171
//			// --------------------------------------------------------
//			cards.Add("TBUD_1", new List<Power> {
//				// TODO [TBUD_1] TBUD Summon Early Minion && Test: TBUD Summon Early Minion_TBUD_1
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMC_84] Dragonkin Spellcaster (*) - COST:5 [ATK:4/HP:6] 
//			// - Race: dragon, Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Battlecry:</b> Summon two 2/2 Whelps.
//			// --------------------------------------------------------
//			// GameTag:
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			cards.Add("BRMC_84", new List<Power> {
//				// TODO [BRMC_84] Dragonkin Spellcaster && Test: Dragonkin Spellcaster_BRMC_84
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMC_85] Lucifron (*) - COST:4 [ATK:4/HP:7] 
//			// - Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: <b>Battlecry:</b> Cast Corruption on all other minions.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			cards.Add("BRMC_85", new List<Power> {
//				// TODO [BRMC_85] Lucifron && Test: Lucifron_BRMC_85
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMC_86] Atramedes (*) - COST:4 [ATK:2/HP:8] 
//			// - Race: dragon, Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: Whenever your opponent plays a card, gain +2 Attack.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("BRMC_86", new List<Power> {
//				// TODO [BRMC_86] Atramedes && Test: Atramedes_BRMC_86
//				new Power
//				{
//					InfoCardId = "BRMC_86e",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMC_87] Moira Bronzebeard (*) - COST:3 [ATK:4/HP:3] 
//			// - Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> Summon Emperor Thaurissan.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("BRMC_87", new List<Power> {
//				// TODO [BRMC_87] Moira Bronzebeard && Test: Moira Bronzebeard_BRMC_87
//				new Power
//				{
//					Activation = PowerActivation.DEATHRATTLE,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMC_88] Drakonid Slayer (*) - COST:6 [ATK:6/HP:6] 
//			// - Race: dragon, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Also damages the minions next to whomever he attacks.
//			// --------------------------------------------------------
//			cards.Add("BRMC_88", new List<Power> {
//				// TODO [BRMC_88] Drakonid Slayer && Test: Drakonid Slayer_BRMC_88
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMC_89] Whirling Ash (*) - COST:2 [ATK:4/HP:5] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Windfury</b>
//			// --------------------------------------------------------
//			// GameTag:
//			// - WINDFURY = 1
//			// --------------------------------------------------------
//			cards.Add("BRMC_89", new List<Power> {
//				// TODO [BRMC_89] Whirling Ash && Test: Whirling Ash_BRMC_89
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMC_90] Living Lava (*) - COST:2 [ATK:6/HP:6] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Taunt</b>
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("BRMC_90", new List<Power> {
//				// TODO [BRMC_90] Living Lava && Test: Living Lava_BRMC_90
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMC_91] Son of the Flame (*) - COST:3 [ATK:6/HP:3] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Battlecry:</b> Deal 6 damage.
//			// --------------------------------------------------------
//			// GameTag:
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_TARGET_IF_AVAILABLE = 0
//			// --------------------------------------------------------
//			cards.Add("BRMC_91", new List<Power> {
//				// TODO [BRMC_91] Son of the Flame && Test: Son of the Flame_BRMC_91
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMC_92] Coren Direbrew (*) - COST:4 [ATK:4/HP:8] 
//			// - Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: Always wins Brawls.
//			//        <b>Battlecry:</b> Add a Brawl to your hand.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			cards.Add("BRMC_92", new List<Power> {
//				// TODO [BRMC_92] Coren Direbrew && Test: Coren Direbrew_BRMC_92
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMC_95] Golemagg (*) - COST:50 [ATK:20/HP:20] 
//			// - Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: Costs (1) less for each damage your hero has taken.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("BRMC_95", new List<Power> {
//				// TODO [BRMC_95] Golemagg && Test: Golemagg_BRMC_95
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMC_95he] Core Hound Pup (*) - COST:3 [ATK:2/HP:4] 
//			// - Race: beast, Set: tb, 
//			// --------------------------------------------------------
//			// Text: At the end of each turn, summon all Core Hound Pups that died this turn.
//			// --------------------------------------------------------
//			cards.Add("BRMC_95he", new List<Power> {
//				// TODO [BRMC_95he] Core Hound Pup && Test: Core Hound Pup_BRMC_95he
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMC_96] High Justice Grimstone (*) - COST:3 [ATK:4/HP:5] 
//			// - Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: At the start of your turn, summon a <b>Legendary</b> minion.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("BRMC_96", new List<Power> {
//				// TODO [BRMC_96] High Justice Grimstone && Test: High Justice Grimstone_BRMC_96
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMC_97] Vaelastrasz (*) - COST:6 [ATK:7/HP:7] 
//			// - Race: dragon, Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: Your cards cost (3) less.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("BRMC_97", new List<Power> {
//				// TODO [BRMC_97] Vaelastrasz && Test: Vaelastrasz_BRMC_97
//				new Power
//				{
//					InfoCardId = "BRMC_97e",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMC_98] Razorgore (*) - COST:6 [ATK:4/HP:12] 
//			// - Race: dragon, Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: At the start of your turn, give your minions +3 Attack.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("BRMC_98", new List<Power> {
//				// TODO [BRMC_98] Razorgore && Test: Razorgore_BRMC_98
//				new Power
//				{
//					InfoCardId = "BRMC_98e",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMC_99] Garr (*) - COST:5 [ATK:4/HP:8] 
//			// - Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: Whenever this minion takes damage, summon a 2/3 Elemental with <b>Taunt</b>.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			// RefTag:
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("BRMC_99", new List<Power> {
//				// TODO [BRMC_99] Garr && Test: Garr_BRMC_99
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [BRMC_99e] Rock Elemental (*) - COST:2 [ATK:2/HP:3] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Taunt</b>
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("BRMC_99e", new List<Power> {
//				// TODO [BRMC_99e] Rock Elemental && Test: Rock Elemental_BRMC_99e
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [HRW02_1] Gearmaster Mechazod (*) - COST:10 [ATK:1/HP:80] 
//			// - Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: <b>Boss</b>
//			//       At the beginning of each turn, Mechazod strikes!
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - TAUNT = 1
//			// - InvisibleDeathrattle = 1
//			// --------------------------------------------------------
//			cards.Add("HRW02_1", new List<Power> {
//				// TODO [HRW02_1] Gearmaster Mechazod && Test: Gearmaster Mechazod_HRW02_1
//				new Power
//				{
//					InfoCardId = "HRW02_1e",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [HRW02_2] Gearmaster Mechazod (*) - COST:10 [ATK:1/HP:80] 
//			// - Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: <b>Boss</b>
//			//       At the beginning of each turn, Mechazod strikes!
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("HRW02_2", new List<Power> {
//				// TODO [HRW02_2] Gearmaster Mechazod && Test: Gearmaster Mechazod_HRW02_2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [HRW02_3] Kill Objective: Anub'arak (*) - COST:0 [ATK:1/HP:100] 
//			// - Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: Wreaks havoc at the beginning of each turn.  Immune to abilites that don't affect heroes.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("HRW02_3", new List<Power> {
//				// TODO [HRW02_3] Kill Objective: Anub'arak && Test: Kill Objective: Anub'arak_HRW02_3
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [KARA_13_15] Wanda Wonderhooves (*) - COST:2 [ATK:1/HP:2] 
//			// - Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: Portals cost (1) less. 
//			//       <i>Does not count as a minion.</i>
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - HIDE_STATS = 1
//			// - UNTOUCHABLE = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_13_15", new List<Power> {
//				// TODO [KARA_13_15] Wanda Wonderhooves && Test: Wanda Wonderhooves_KARA_13_15
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [KARA_13_16] Susie Sizzlesong (*) - COST:2 [ATK:1/HP:2] 
//			// - Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: Portals cost (1) less. 
//			//       <i>Does not count as a minion.</i>
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - HIDE_STATS = 1
//			// - UNTOUCHABLE = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_13_16", new List<Power> {
//				// TODO [KARA_13_16] Susie Sizzlesong && Test: Susie Sizzlesong_KARA_13_16
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [KARA_13_17] Mark Moonwalker (*) - COST:2 [ATK:1/HP:2] 
//			// - Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: Portals cost (1) less. 
//			//       <i>Does not count as a minion.</i>
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - HIDE_STATS = 1
//			// - UNTOUCHABLE = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_13_17", new List<Power> {
//				// TODO [KARA_13_17] Mark Moonwalker && Test: Mark Moonwalker_KARA_13_17
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [KARA_13_19] Red Riding Hood (*) - COST:5 [ATK:3/HP:2] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Taunt. Deathrattle:</b> Enemies can't attack this turn.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - TAUNT = 1
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_13_19", new List<Power> {
//				// TODO [KARA_13_19] Red Riding Hood && Test: Red Riding Hood_KARA_13_19
//				new Power
//				{
//					InfoCardId = "KARA_13_19e",
//					Activation = PowerActivation.DEATHRATTLE,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [KARA_13_20] Party Elemental (*) - COST:3 [ATK:3/HP:2] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Comes with a party!
//			// --------------------------------------------------------
//			cards.Add("KARA_13_20", new List<Power> {
//				// TODO [KARA_13_20] Party Elemental && Test: Party Elemental_KARA_13_20
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [KARA_13_22] Mime (*) - COST:5 [ATK:5/HP:6] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Always <b>silenced</b>.
//			// --------------------------------------------------------
//			cards.Add("KARA_13_22", new List<Power> {
//				// TODO [KARA_13_22] Mime && Test: Mime_KARA_13_22
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [KARA_13_23] Romulo (*) - COST:5 [ATK:3/HP:4] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: At the end of your turn, restore 3 health to your hero.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("KARA_13_23", new List<Power> {
//				// TODO [KARA_13_23] Romulo && Test: Romulo_KARA_13_23
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_015] Pirate (*) - COST:2 [ATK:2/HP:3] 
//			// - Race: pirate, Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("TB_015", new List<Power> {
//				// TODO [TB_015] Pirate && Test: Pirate_TB_015
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_CoOp_Mechazod2] Overloaded Mechazod (*) - COST:10 [ATK:9/HP:80] 
//			// - Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: <b>Boss</b>
//			//       At the beginning of each turn, Mechazod strikes!
//			// --------------------------------------------------------
//			cards.Add("TB_CoOp_Mechazod2", new List<Power> {
//				// TODO [TB_CoOp_Mechazod2] Overloaded Mechazod && Test: Overloaded Mechazod_TB_CoOp_Mechazod2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_CoOp_Mechazod_OLD] Gearmaster Mechazod (*) - COST:10 [ATK:2/HP:95] 
//			// - Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: <b>Boss</b>
//			//       Mechazod wins if he defeats either of you!
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("TB_CoOp_Mechazod_OLD", new List<Power> {
//				// TODO [TB_CoOp_Mechazod_OLD] Gearmaster Mechazod && Test: Gearmaster Mechazod_TB_CoOp_Mechazod_OLD
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_CoOp_Mechazod_V2] Gearmaster Mechazod (*) - COST:10 [ATK:2/HP:95] 
//			// - Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: <b>Boss</b>
//			//       Mechazod wins if he defeats either of you!
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("TB_CoOp_Mechazod_V2", new List<Power> {
//				// TODO [TB_CoOp_Mechazod_V2] Gearmaster Mechazod && Test: Gearmaster Mechazod_TB_CoOp_Mechazod_V2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_CoopHero_001] Netherspite Infernal (*) - COST:2 [ATK:2/HP:3] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: At the end of each turn, deal 1 damage to all enemies.
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 40221
//			// --------------------------------------------------------
//			cards.Add("TB_CoopHero_001", new List<Power> {
//				// TODO [TB_CoopHero_001] Netherspite Infernal && Test: Netherspite Infernal_TB_CoopHero_001
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_Coopv3_009t] Explosive Rune (*) - COST:2 [ATK:0/HP:3] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: At the start of your turn, this explodes, dealing 9 damage to your hero.
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("TB_Coopv3_009t", new List<Power> {
//				// TODO [TB_Coopv3_009t] Explosive Rune && Test: Explosive Rune_TB_Coopv3_009t
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_Coopv3_100] Dragonscale Warrior (*) - COST:3 [ATK:3/HP:4] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Whenever any player targets this minion with a spell, that player draws a card.
//			// --------------------------------------------------------
//			// RefTag:
//			// - DIVINE_SHIELD = 1
//			// --------------------------------------------------------
//			cards.Add("TB_Coopv3_100", new List<Power> {
//				// TODO [TB_Coopv3_100] Dragonscale Warrior && Test: Dragonscale Warrior_TB_Coopv3_100
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_Coopv3_101] Freewheeling Skulker (*) - COST:5 [ATK:5/HP:6] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: At the end of your turn, switch sides.
//			// --------------------------------------------------------
//			cards.Add("TB_Coopv3_101", new List<Power> {
//				// TODO [TB_Coopv3_101] Freewheeling Skulker && Test: Freewheeling Skulker_TB_Coopv3_101
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_Coopv3_103] Intrepid Dragonstalker (*) - COST:5 [ATK:3/HP:3] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Whenever ANY player plays a card, gain +1/+1.
//			// --------------------------------------------------------
//			cards.Add("TB_Coopv3_103", new List<Power> {
//				// TODO [TB_Coopv3_103] Intrepid Dragonstalker && Test: Intrepid Dragonstalker_TB_Coopv3_103
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_Coopv3_104] Main Tank (*) - COST:4 [ATK:4/HP:4] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Battlecry:</b> Give all other minions +2/+2, except the <b>Boss</b>.
//			// --------------------------------------------------------
//			// GameTag:
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			cards.Add("TB_Coopv3_104", new List<Power> {
//				// TODO [TB_Coopv3_104] Main Tank && Test: Main Tank_TB_Coopv3_104
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_Coopv3_104_NewClasses] Main Tank (*) - COST:4 [ATK:4/HP:4] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Battlecry:</b> Give all other minions +2/+2, except the <b>Boss</b>.
//			// --------------------------------------------------------
//			// GameTag:
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			cards.Add("TB_Coopv3_104_NewClasses", new List<Power> {
//				// TODO [TB_Coopv3_104_NewClasses] Main Tank && Test: Main Tank_TB_Coopv3_104_NewClasses
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_Coopv3_105] Raid Healer (*) - COST:4 [ATK:0/HP:7] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Whenever your hero is healed, also heal your teammate for that much.
//			// --------------------------------------------------------
//			cards.Add("TB_Coopv3_105", new List<Power> {
//				// TODO [TB_Coopv3_105] Raid Healer && Test: Raid Healer_TB_Coopv3_105
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_CoOpv3_Boss] Nefarian (*) - COST:10 [ATK:0/HP:200] 
//			// - Race: dragon, Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: Can't be targeted by spells.
//			//       <b>Boss: </b>Nefarian wins if he defeats either of you!
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - TAUNT = 1
//			// - InvisibleDeathrattle = 1
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpv3_Boss", new List<Power> {
//				// TODO [TB_CoOpv3_Boss] Nefarian && Test: Nefarian_TB_CoOpv3_Boss
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_CoOpv3_Boss_FB] Nefarian (*) - COST:10 [ATK:0/HP:200] 
//			// - Race: dragon, Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: Can't be targeted by spells.
//			//       <b>Boss: </b>Nefarian wins if he defeats either of you!
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - TAUNT = 1
//			// - InvisibleDeathrattle = 1
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpv3_Boss_FB", new List<Power> {
//				// TODO [TB_CoOpv3_Boss_FB] Nefarian && Test: Nefarian_TB_CoOpv3_Boss_FB
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_CoOpv3_Boss_NewClasses] Nefarian (*) - COST:10 [ATK:0/HP:200] 
//			// - Race: dragon, Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: Can't be targeted by spells.
//			//       <b>Boss: </b>Nefarian wins if he defeats either of you!
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - TAUNT = 1
//			// - InvisibleDeathrattle = 1
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpv3_Boss_NewClasses", new List<Power> {
//				// TODO [TB_CoOpv3_Boss_NewClasses] Nefarian && Test: Nefarian_TB_CoOpv3_Boss_NewClasses
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_Dorothee_001] Dorothee (*) - COST:4 [ATK:0/HP:10] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Minions to the left have <b>Charge</b>. Minions to the right have <b>Taunt</b>.
//			// --------------------------------------------------------
//			// GameTag:
//			// - HIDE_STATS = 1
//			// - UNTOUCHABLE = 1
//			// --------------------------------------------------------
//			// RefTag:
//			// - TAUNT = 1
//			// - CHARGE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_Dorothee_001", new List<Power> {
//				// TODO [TB_Dorothee_001] Dorothee && Test: Dorothee_TB_Dorothee_001
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_FireFestival_Brazier] Brazier (*) - COST:8 [ATK:1/HP:1] 
//			// - Race: elemental, Fac: neutral, Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - IMMUNE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_FireFestival_Brazier", new List<Power> {
//				// TODO [TB_FireFestival_Brazier] Brazier && Test: Brazier_TB_FireFestival_Brazier
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_FireFestival_Fireworks] Fireworks (*) - COST:8 [ATK:1/HP:1] 
//			// - Race: elemental, Fac: neutral, Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - IMMUNE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_FireFestival_Fireworks", new List<Power> {
//				// TODO [TB_FireFestival_Fireworks] Fireworks && Test: Fireworks_TB_FireFestival_Fireworks
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_FireFestival_MRag] Mini-Rag (*) - COST:1 [ATK:2/HP:3] 
//			// - Race: elemental, Fac: neutral, Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: Can't attack. <b>Immune</b>.
//			//       At the end of each turn, burn your enemies randomly.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - CANT_ATTACK = 1
//			// - IMMUNE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_FireFestival_MRag", new List<Power> {
//				// TODO [TB_FireFestival_MRag] Mini-Rag && Test: Mini-Rag_TB_FireFestival_MRag
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_Frost_Rag] Ragnaros? (*) - COST:3 [ATK:1/HP:4] 
//			// - Race: elemental, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Can't Attack.
//			//       <b>Deathrattle:</b> Whoever kills this deals 4 damage to their opponent.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DEATHRATTLE = 1
//			// - CANT_ATTACK = 1
//			// --------------------------------------------------------
//			cards.Add("TB_Frost_Rag", new List<Power> {
//				// TODO [TB_Frost_Rag] Ragnaros? && Test: Ragnaros?_TB_Frost_Rag
//				new Power
//				{
//					Activation = PowerActivation.DEATHRATTLE,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_FW_DrBoomMega] Dr. Boom Boom Boom Boom (*) - COST:9 [ATK:9/HP:9] 
//			// - Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: <b>Battlecry:</b> Summon six 1/1 Boom Bots. <i>WARNING: Bots may explode.</i>
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			cards.Add("TB_FW_DrBoomMega", new List<Power> {
//				// TODO [TB_FW_DrBoomMega] Dr. Boom Boom Boom Boom && Test: Dr. Boom Boom Boom Boom_TB_FW_DrBoomMega
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_FW_ImbaTron] Annoy-o-p-Tron (*) - COST:4 [ATK:2/HP:3] 
//			// - Race: mechanical, Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Battlecry:</b> Summon Annoy-o-Tron and Psych-o-Tron.
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAUNT = 1
//			// - DIVINE_SHIELD = 1
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			cards.Add("TB_FW_ImbaTron", new List<Power> {
//				// TODO [TB_FW_ImbaTron] Annoy-o-p-Tron && Test: Annoy-o-p-Tron_TB_FW_ImbaTron
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_FW_Mortar] Dwarf Demolitionist (*) - COST:1 [ATK:1/HP:5] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Whenever you play a card, deal 1-4 damage to a random enemy.
//			// --------------------------------------------------------
//			cards.Add("TB_FW_Mortar", new List<Power> {
//				// TODO [TB_FW_Mortar] Dwarf Demolitionist && Test: Dwarf Demolitionist_TB_FW_Mortar
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_FW_OmegaMax] Force-Tank OMEGA MAX (*) - COST:10 [ATK:10/HP:10] 
//			// - Race: mechanical, Set: tb, Rarity: common
//			// --------------------------------------------------------
//			// Text: <b>Divine Shield.</b>
//			//       <b>Battlecry:</b> Summon six Annoy-o-Trons
//			// --------------------------------------------------------
//			// GameTag:
//			// - DIVINE_SHIELD = 1
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			cards.Add("TB_FW_OmegaMax", new List<Power> {
//				// TODO [TB_FW_OmegaMax] Force-Tank OMEGA MAX && Test: Force-Tank OMEGA MAX_TB_FW_OmegaMax
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_FW_Warper] Omegawarper (*) - COST:3 [ATK:3/HP:5] 
//			// - Race: mechanical, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Both player's Mechs cost (2) less.
//			// --------------------------------------------------------
//			// GameTag:
//			// - AURA = 1
//			// --------------------------------------------------------
//			cards.Add("TB_FW_Warper", new List<Power> {
//				// TODO [TB_FW_Warper] Omegawarper && Test: Omegawarper_TB_FW_Warper
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_GiftExchange_Treasure] Winter's Veil Gift (*) - COST:0 [ATK:0/HP:4] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> Give current player a Stolen Gift.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_GiftExchange_Treasure", new List<Power> {
//				// TODO [TB_GiftExchange_Treasure] Winter's Veil Gift && Test: Winter's Veil Gift_TB_GiftExchange_Treasure
//				new Power
//				{
//					Activation = PowerActivation.DEATHRATTLE,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_GP_03] Shadow Tower New (*) - COST:0 [ATK:0/HP:4] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Can't be <b><b>Silence</b>d</b>
//			//       Adjacent minions Can't Attack, and have <b>Stealth</b>
//			// --------------------------------------------------------
//			// GameTag:
//			// - InvisibleDeathrattle = 1
//			// --------------------------------------------------------
//			cards.Add("TB_GP_03", new List<Power> {
//				// TODO [TB_GP_03] Shadow Tower New && Test: Shadow Tower New_TB_GP_03
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_KaraPortals_003] Party Elemental (*) - COST:3 [ATK:3/HP:2] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			cards.Add("TB_KaraPortals_003", new List<Power> {
//				// TODO [TB_KaraPortals_003] Party Elemental && Test: Party Elemental_TB_KaraPortals_003
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_KTRAF_1] Anub'Rekhan (*) - COST:4 [ATK:5/HP:5] 
//			// - Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: At the end of your turn, summon a 3/1 Nerubian.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_KTRAF_1", new List<Power> {
//				// TODO [TB_KTRAF_1] Anub'Rekhan && Test: Anub'Rekhan_TB_KTRAF_1
//				new Power
//				{
//					InfoCardId = "TB_KTRAF_10e",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_KTRAF_10] Noth the Plaguebringer (*) - COST:9 [ATK:2/HP:5] 
//			// - Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: Whenever an enemy minion dies, summon a 1/1 Skeleton and give your other minions +1/+1.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_KTRAF_10", new List<Power> {
//				// TODO [TB_KTRAF_10] Noth the Plaguebringer && Test: Noth the Plaguebringer_TB_KTRAF_10
//				new Power
//				{
//					InfoCardId = "TB_KTRAF_10e",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_KTRAF_11] Sapphiron (*) - COST:5 [ATK:5/HP:6] 
//			// - Race: dragon, Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: At the start of your turn, <b>Freeze</b> a random enemy minion.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			// RefTag:
//			// - FREEZE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_KTRAF_11", new List<Power> {
//				// TODO [TB_KTRAF_11] Sapphiron && Test: Sapphiron_TB_KTRAF_11
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_KTRAF_12] Patchwerk (*) - COST:8 [ATK:5/HP:8] 
//			// - Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: <b>Battlecry:</b> Destroy a random enemy minion.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			cards.Add("TB_KTRAF_12", new List<Power> {
//				// TODO [TB_KTRAF_12] Patchwerk && Test: Patchwerk_TB_KTRAF_12
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_KTRAF_2] Lady Blaumeux (*) - COST:4 [ATK:2/HP:7] 
//			// - Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: <b>Battlecry:</b> Summon a fellow Horseman.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			cards.Add("TB_KTRAF_2", new List<Power> {
//				// TODO [TB_KTRAF_2] Lady Blaumeux && Test: Lady Blaumeux_TB_KTRAF_2
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_KTRAF_2s] Sir Zeliek (*) - COST:4 [ATK:1/HP:5] 
//			// - Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: Lady Blaumeux is <b>Immune</b>.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			// RefTag:
//			// - IMMUNE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_KTRAF_2s", new List<Power> {
//				// TODO [TB_KTRAF_2s] Sir Zeliek && Test: Sir Zeliek_TB_KTRAF_2s
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_KTRAF_3] Gluth (*) - COST:4 [ATK:3/HP:4] 
//			// - Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: At the end of your turn, summon a random Undead.
//			// --------------------------------------------------------
//			// Entourage: FP1_001, AT_030, LOE_019, EX1_012, EX1_059, FP1_004, EX1_616, FP1_024, tt_004
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_KTRAF_3", new List<Power> {
//				// TODO [TB_KTRAF_3] Gluth && Test: Gluth_TB_KTRAF_3
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_KTRAF_4] Gothik the Harvester (*) - COST:4 [ATK:5/HP:4] 
//			// - Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> Summon a Spectral Gothik for your opponent.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_KTRAF_4", new List<Power> {
//				// TODO [TB_KTRAF_4] Gothik the Harvester && Test: Gothik the Harvester_TB_KTRAF_4
//				new Power
//				{
//					Activation = PowerActivation.DEATHRATTLE,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_KTRAF_4m] Spectral Gothik (*) - COST:3 [ATK:0/HP:3] 
//			// - Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: At the start of your turn, deal 4 damage to your hero.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_KTRAF_4m", new List<Power> {
//				// TODO [TB_KTRAF_4m] Spectral Gothik && Test: Spectral Gothik_TB_KTRAF_4m
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_KTRAF_5] Grand Widow Faerlina (*) - COST:4 [ATK:0/HP:5] 
//			// - Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: Has +1 Attack for each card in your opponent's hand.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_KTRAF_5", new List<Power> {
//				// TODO [TB_KTRAF_5] Grand Widow Faerlina && Test: Grand Widow Faerlina_TB_KTRAF_5
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_KTRAF_6] Grobbulus (*) - COST:5 [ATK:4/HP:7] 
//			// - Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: Whenever this kills a minion, summon a <b>Poisonous</b> 2/2 Slime.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			// RefTag:
//			// - POISONOUS = 1
//			// --------------------------------------------------------
//			cards.Add("TB_KTRAF_6", new List<Power> {
//				// TODO [TB_KTRAF_6] Grobbulus && Test: Grobbulus_TB_KTRAF_6
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_KTRAF_6m] Fallout Slime (*) - COST:1 [ATK:2/HP:2] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Poisonous</b>
//			// --------------------------------------------------------
//			// GameTag:
//			// - POISONOUS = 1
//			// --------------------------------------------------------
//			cards.Add("TB_KTRAF_6m", new List<Power> {
//				// TODO [TB_KTRAF_6m] Fallout Slime && Test: Fallout Slime_TB_KTRAF_6m
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_KTRAF_7] Heigan the Unclean (*) - COST:3 [ATK:4/HP:5] 
//			// - Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: At the end of your turn, deal 4 damage to a  random enemy.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_KTRAF_7", new List<Power> {
//				// TODO [TB_KTRAF_7] Heigan the Unclean && Test: Heigan the Unclean_TB_KTRAF_7
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_KTRAF_8] Instructor Razuvious (*) - COST:8 [ATK:3/HP:3] 
//			// - Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: <b>Battlecry:</b> Equip a 5/2 Massive Runeblade.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			cards.Add("TB_KTRAF_8", new List<Power> {
//				// TODO [TB_KTRAF_8] Instructor Razuvious && Test: Instructor Razuvious_TB_KTRAF_8
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_KTRAF_Under] Understudy (*) - COST:2 [ATK:0/HP:7] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Taunt</b>
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("TB_KTRAF_Under", new List<Power> {
//				// TODO [TB_KTRAF_Under] Understudy && Test: Understudy_TB_KTRAF_Under
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_MammothParty_Boss002] Piñata Golem (*) - COST:10 [ATK:5/HP:85] 
//			// - Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: <b>Boss, Taunt</b>. Can't be targeted by spells. It's full of candy!
//			// --------------------------------------------------------
//			// Entourage: TB_MammothParty_303, TB_MammothParty_302, TB_MammothParty_301
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			// RefTag:
//			// - BOSS = 1
//			// --------------------------------------------------------
//			cards.Add("TB_MammothParty_Boss002", new List<Power> {
//				// TODO [TB_MammothParty_Boss002] Piñata Golem && Test: Piñata Golem_TB_MammothParty_Boss002
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_MammothParty_m001] Party Crasher (*) - COST:4 [ATK:3/HP:5] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Taunt</b>
//			//       You don't control how this minion attacks.
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAUNT = 1
//			// - AUTOATTACK = 1
//			// --------------------------------------------------------
//			cards.Add("TB_MammothParty_m001", new List<Power> {
//				// TODO [TB_MammothParty_m001] Party Crasher && Test: Party Crasher_TB_MammothParty_m001
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_MammothParty_m001_alt] Party Crasher (*) - COST:4 [ATK:3/HP:5] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Taunt</b>
//			//       You don't control how this minion attacks.
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAUNT = 1
//			// - AUTOATTACK = 1
//			// --------------------------------------------------------
//			cards.Add("TB_MammothParty_m001_alt", new List<Power> {
//				// TODO [TB_MammothParty_m001_alt] Party Crasher && Test: Party Crasher_TB_MammothParty_m001_alt
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_MechWar_Minion1] Mech Fan (*) - COST:2 [ATK:1/HP:1] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Taunt</b>
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("TB_MechWar_Minion1", new List<Power> {
//				// TODO [TB_MechWar_Minion1] Mech Fan && Test: Mech Fan_TB_MechWar_Minion1
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_MnkWf01] Nadia, Mankrik's Wife (*) - COST:2 [ATK:7/HP:7] 
//			// - Race: orc, Set: tb, Rarity: legendary
//			// --------------------------------------------------------
//			// Text: <b>Stealth</b>
//			//       <b>Deathrattle</b>: Complete your <b>Quest</b>.
//			// --------------------------------------------------------
//			// RefTag:
//			// - QUEST = 1
//			// --------------------------------------------------------
//			cards.Add("TB_MnkWf01", new List<Power> {
//				// TODO [TB_MnkWf01] Nadia, Mankrik's Wife && Test: Nadia, Mankrik's Wife_TB_MnkWf01
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_SPT_DPromoCrate1] Weapon Rack (*) - COST:1 [ATK:0/HP:4] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> Current turn player gains a random weapon.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DPromoCrate1", new List<Power> {
//				// TODO [TB_SPT_DPromoCrate1] Weapon Rack && Test: Weapon Rack_TB_SPT_DPromoCrate1
//				new Power
//				{
//					Activation = PowerActivation.DEATHRATTLE,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_SPT_DPromoCrate2] Discarded Armor (*) - COST:1 [ATK:0/HP:4] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> Current turn player gains 5 armor.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DPromoCrate2", new List<Power> {
//				// TODO [TB_SPT_DPromoCrate2] Discarded Armor && Test: Discarded Armor_TB_SPT_DPromoCrate2
//				new Power
//				{
//					Activation = PowerActivation.DEATHRATTLE,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_SPT_DPromoCrate3] Chest of Gold! (*) - COST:1 [ATK:0/HP:4] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> Current turn player gains gold!
//			// --------------------------------------------------------
//			// GameTag:
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DPromoCrate3", new List<Power> {
//				// TODO [TB_SPT_DPromoCrate3] Chest of Gold! && Test: Chest of Gold!_TB_SPT_DPromoCrate3
//				new Power
//				{
//					Activation = PowerActivation.DEATHRATTLE,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_SPT_DPromoMinion] Hell Bovine (*) - COST:3 [ATK:2/HP:2] 
//			// - Race: demon, Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> Place a copy of this card in your deck.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DPromoMinion", new List<Power> {
//				// TODO [TB_SPT_DPromoMinion] Hell Bovine && Test: Hell Bovine_TB_SPT_DPromoMinion
//				new Power
//				{
//					Activation = PowerActivation.DEATHRATTLE,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_SPT_DPromoMinion2] Guardian (*) - COST:3 [ATK:2/HP:4] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: At end of your turn, deal 2 damage to the enemies opposite this minion.
//			// --------------------------------------------------------
//			// GameTag:
//			// - CANT_ATTACK = 1
//			// --------------------------------------------------------
//			// RefTag:
//			// - AUTOATTACK = 1
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DPromoMinion2", new List<Power> {
//				// TODO [TB_SPT_DPromoMinion2] Guardian && Test: Guardian_TB_SPT_DPromoMinion2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_SPT_DPromoMinionChamp] Hell Bovine Champion (*) - COST:5 [ATK:4/HP:4] 
//			// - Race: demon, Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> Current turn player gains a random weapon.
//			// --------------------------------------------------------
//			// Entourage: AT_050, CS2_112, LOE_118, EX1_567, TB_BlingBrawl_Weapon, CS2_106, CFM_631, CS2_080
//			// --------------------------------------------------------
//			// GameTag:
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DPromoMinionChamp", new List<Power> {
//				// TODO [TB_SPT_DPromoMinionChamp] Hell Bovine Champion && Test: Hell Bovine Champion_TB_SPT_DPromoMinionChamp
//				new Power
//				{
//					Activation = PowerActivation.DEATHRATTLE,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_SPT_DPromoMinionInit] Hell Bovine (*) - COST:3 [ATK:2/HP:2] 
//			// - Race: demon, Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> Place a copy of this card in your deck.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DEATHRATTLE = 1
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DPromoMinionInit", new List<Power> {
//				// TODO [TB_SPT_DPromoMinionInit] Hell Bovine && Test: Hell Bovine_TB_SPT_DPromoMinionInit
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = null,
//				},
//				new Power
//				{
//					Activation = PowerActivation.DEATHRATTLE,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_SPT_DpromoPortal] Enigmatic Portal (*) - COST:4 [ATK:0/HP:10] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: At the start of next turn, your hero is transformed and sucked through the Twisting Nether.
//			// --------------------------------------------------------
//			// GameTag:
//			// - BATTLECRY = 1
//			// - IMMUNE = 1
//			// - HIDE_STATS = 1
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DpromoPortal", new List<Power> {
//				// TODO [TB_SPT_DpromoPortal] Enigmatic Portal && Test: Enigmatic Portal_TB_SPT_DpromoPortal
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_SPT_Minion1] Shieldsman (*) - COST:2 [ATK:0/HP:1] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Taunt</b>
//			//       <b>Battlecry:</b> Gain Health equal to Stormwind's Attack.
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAUNT = 1
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_Minion1", new List<Power> {
//				// TODO [TB_SPT_Minion1] Shieldsman && Test: Shieldsman_TB_SPT_Minion1
//				new Power
//				{
//					InfoCardId = "TB_SPT_Minion1e",
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_SPT_Minion2] Battle Standard (*) - COST:2 [ATK:0/HP:2] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Adjacent minions have +2 Attack.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ADJACENT_BUFF = 1
//			// - AURA = 1
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_Minion2", new List<Power> {
//				// TODO [TB_SPT_Minion2] Battle Standard && Test: Battle Standard_TB_SPT_Minion2
//				new Power
//				{
//					InfoCardId = "TB_SPT_Minion2e",
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_SPT_Minion3] Swordsman (*) - COST:3 [ATK:1/HP:1] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Battlecry:</b> Gain Attack and Health equal to Stormwind's Attack
//			// --------------------------------------------------------
//			// GameTag:
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_Minion3", new List<Power> {
//				// TODO [TB_SPT_Minion3] Swordsman && Test: Swordsman_TB_SPT_Minion3
//				new Power
//				{
//					InfoCardId = "TB_SPT_Minion3e",
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_SPT_MTH_Minion1] Happy Partygoer (*) - COST:2 [ATK:0/HP:1] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Taunt</b>
//			//       <b>Battlecry:</b> Gain Health equal to Stormwind's Attack.
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAUNT = 1
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_MTH_Minion1", new List<Power> {
//				// TODO [TB_SPT_MTH_Minion1] Happy Partygoer && Test: Happy Partygoer_TB_SPT_MTH_Minion1
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_SPT_MTH_Minion2] Party Banner (*) - COST:2 [ATK:0/HP:2] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Adjacent minions have +2 Attack.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ADJACENT_BUFF = 1
//			// - AURA = 1
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_MTH_Minion2", new List<Power> {
//				// TODO [TB_SPT_MTH_Minion2] Party Banner && Test: Party Banner_TB_SPT_MTH_Minion2
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TB_SPT_MTH_Minion3] Ornery Partygoer (*) - COST:3 [ATK:1/HP:1] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Battlecry:</b> Gain Attack and Health equal to Stormwind's Attack.
//			// --------------------------------------------------------
//			// GameTag:
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_MTH_Minion3", new List<Power> {
//				// TODO [TB_SPT_MTH_Minion3] Ornery Partygoer && Test: Ornery Partygoer_TB_SPT_MTH_Minion3
//				new Power
//				{
//					Activation = PowerActivation.BATTLECRY,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TBST_001] OLDN3wb Tank (*) - COST:1 [ATK:2/HP:2] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Taunt</b>
//			// --------------------------------------------------------
//			// GameTag:
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("TBST_001", new List<Power> {
//				// TODO [TBST_001] OLDN3wb Tank && Test: OLDN3wb Tank_TBST_001
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TBST_002] OLDN3wb Mage (*) - COST:1 [ATK:2/HP:1] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: At the end of your turn, deal 1 damage to random enemy minion.
//			// --------------------------------------------------------
//			cards.Add("TBST_002", new List<Power> {
//				// TODO [TBST_002] OLDN3wb Mage && Test: OLDN3wb Mage_TBST_002
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TBST_003] OLDN3wb Healer (*) - COST:1 [ATK:1/HP:1] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: At the end of your turn, heal 2 damage from adjacent minions.
//			// --------------------------------------------------------
//			cards.Add("TBST_003", new List<Power> {
//				// TODO [TBST_003] OLDN3wb Healer && Test: OLDN3wb Healer_TBST_003
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TBST_004] OLDLegit Healer (*) - COST:3 [ATK:2/HP:2] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: At the end of your turn, summon a random friendly minion that died this turn.
//			// --------------------------------------------------------
//			cards.Add("TBST_004", new List<Power> {
//				// TODO [TBST_004] OLDLegit Healer && Test: OLDLegit Healer_TBST_004
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// --------------------------------------- MINION - NEUTRAL
//			// [TBST_005] OLDPvP Rogue (*) - COST:3 [ATK:3/HP:6] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Stealth</b>
//			//       Regain <b>Stealth</b> when PvP Rogue kills a minion.
//			// --------------------------------------------------------
//			// GameTag:
//			// - STEALTH = 1
//			// --------------------------------------------------------
//			cards.Add("TBST_005", new List<Power> {
//				// TODO [TBST_005] OLDPvP Rogue && Test: OLDPvP Rogue_TBST_005
//				new Power
//				{
//					//Activation = null,
//					//SingleTask = null,
//				}
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMA01_2H_2c_TB] Pile On!!! (*) - COST:1 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Hero Power</b>
//			//       Put two minions from your deck and one from your opponent's into the battlefield.
//			// --------------------------------------------------------
//			cards.Add("BRMA01_2H_2c_TB", new List<Power> {
//				// TODO [BRMA01_2H_2c_TB] Pile On!!! && Test: Pile On!!!_BRMA01_2H_2c_TB
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMA02_2_2c_TB] Jeering Crowd (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Summon a 1/1 Spectator with <b>Taunt</b>.
//			// --------------------------------------------------------
//			// RefTag:
//			// - TAUNT = 1
//			// --------------------------------------------------------
//			cards.Add("BRMA02_2_2c_TB", new List<Power> {
//				// TODO [BRMA02_2_2c_TB] Jeering Crowd && Test: Jeering Crowd_BRMA02_2_2c_TB
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMA07_2_2c_TB] ME SMASH (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Destroy a random enemy minion.
//			// --------------------------------------------------------
//			cards.Add("BRMA07_2_2c_TB", new List<Power> {
//				// TODO [BRMA07_2_2c_TB] ME SMASH && Test: ME SMASH_BRMA07_2_2c_TB
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMC_100] Living Bomb (*) - COST:3 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Choose an enemy minion. If it lives until your next turn, deal $5 damage to all enemies. @spelldmg
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_ENEMY_TARGET = 0
//			// - REQ_MINION_TARGET = 0
//			// - REQ_TARGET_TO_PLAY = 0
//			// --------------------------------------------------------
//			cards.Add("BRMC_100", new List<Power> {
//				// TODO [BRMC_100] Living Bomb && Test: Living Bomb_BRMC_100
//				new Power
//				{
//					InfoCardId = "BRMC_100e",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMC_83] Open the Gates (*) - COST:8 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Fill your board with 2/2 Whelps.
//			// --------------------------------------------------------
//			cards.Add("BRMC_83", new List<Power> {
//				// TODO [BRMC_83] Open the Gates && Test: Open the Gates_BRMC_83
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMC_93] Omnotron Defense System (*) - COST:3 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Summon a random Tron.
//			// --------------------------------------------------------
//			// Entourage: BRMA14_3, BRMA14_5, BRMA14_7, BRMA14_9
//			// --------------------------------------------------------
//			cards.Add("BRMC_93", new List<Power> {
//				// TODO [BRMC_93] Omnotron Defense System && Test: Omnotron Defense System_BRMC_93
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [BRMC_95h] Core Hound Puppies (*) - COST:3 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Summon two 2/4 Core Hound Pups.
//			// --------------------------------------------------------
//			cards.Add("BRMC_95h", new List<Power> {
//				// TODO [BRMC_95h] Core Hound Puppies && Test: Core Hound Puppies_BRMC_95h
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [FB_LK004] Calling for Backup (*) - COST:10 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Choose the next Hero.
//			// --------------------------------------------------------
//			cards.Add("FB_LK004", new List<Power> {
//				// TODO [FB_LK004] Calling for Backup && Test: Calling for Backup_FB_LK004
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [FB_LK010] The Final Battle (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Show The Lich King your true form!
//			// --------------------------------------------------------
//			cards.Add("FB_LK010", new List<Power> {
//				// TODO [FB_LK010] The Final Battle && Test: The Final Battle_FB_LK010
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [FB_LK011] Cancelling the Apocalypse! (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Destroy all minions. Nice try, Uther!
//			// --------------------------------------------------------
//			cards.Add("FB_LK011", new List<Power> {
//				// TODO [FB_LK011] Cancelling the Apocalypse! && Test: Cancelling the Apocalypse!_FB_LK011
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [FB_LK_ClearBoard] A New Hero Approaches (*) - COST:10 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Destroy all minions. Drain all Mana.
//			// --------------------------------------------------------
//			cards.Add("FB_LK_ClearBoard", new List<Power> {
//				// TODO [FB_LK_ClearBoard] A New Hero Approaches && Test: A New Hero Approaches_FB_LK_ClearBoard
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [FB_LK_NewHeroCards] New Hero! (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: A new Hero takes position.
//			// --------------------------------------------------------
//			cards.Add("FB_LK_NewHeroCards", new List<Power> {
//				// TODO [FB_LK_NewHeroCards] New Hero! && Test: New Hero!_FB_LK_NewHeroCards
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [FB_LKDebug001] LK Phase 2 Debug (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Change boss to phase 2
//			// --------------------------------------------------------
//			cards.Add("FB_LKDebug001", new List<Power> {
//				// TODO [FB_LKDebug001] LK Phase 2 Debug && Test: LK Phase 2 Debug_FB_LKDebug001
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [FB_LKDebug002] LK Phase 3 Debug (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Change boss to phase 3
//			// --------------------------------------------------------
//			cards.Add("FB_LKDebug002", new List<Power> {
//				// TODO [FB_LKDebug002] LK Phase 3 Debug && Test: LK Phase 3 Debug_FB_LKDebug002
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [FB_LKStats001a] Fight the Lich King! (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Continue playing normally.
//			// --------------------------------------------------------
//			cards.Add("FB_LKStats001a", new List<Power> {
//				// TODO [FB_LKStats001a] Fight the Lich King! && Test: Fight the Lich King!_FB_LKStats001a
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [FB_LKStats001d] Modify the Lich King (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Change Health, Assign Modifiers.
//			// --------------------------------------------------------
//			// Entourage: FB_LKStats002a, FB_LKStats002b, FB_LKStats002c
//			// --------------------------------------------------------
//			cards.Add("FB_LKStats001d", new List<Power> {
//				// TODO [FB_LKStats001d] Modify the Lich King && Test: Modify the Lich King_FB_LKStats001d
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [FB_LKStats002] Lich King Modifications (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Increase or Decrease the maximum health of The Lich King.
//			// --------------------------------------------------------
//			cards.Add("FB_LKStats002", new List<Power> {
//				// TODO [FB_LKStats002] Lich King Modifications && Test: Lich King Modifications_FB_LKStats002
//				new Power
//				{
//					InfoCardId = "FB_LKStats002ench",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [FB_LKStats002a] Increase Health (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Increase The Lich King's maximum health by 10%.
//			// --------------------------------------------------------
//			// Entourage: FB_LKStats002a, FB_LKStats002b, FB_LKStats002c
//			// --------------------------------------------------------
//			cards.Add("FB_LKStats002a", new List<Power> {
//				// TODO [FB_LKStats002a] Increase Health && Test: Increase Health_FB_LKStats002a
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [FB_LKStats002b] Decrease Health (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Decrease The Lich King's maximum health by 10%
//			// --------------------------------------------------------
//			// Entourage: FB_LKStats002a, FB_LKStats002b, FB_LKStats002c
//			// --------------------------------------------------------
//			cards.Add("FB_LKStats002b", new List<Power> {
//				// TODO [FB_LKStats002b] Decrease Health && Test: Decrease Health_FB_LKStats002b
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [FB_LKStats002c] Modifications Complete (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Lock in the new maximum health. This will end the current game.
//			// --------------------------------------------------------
//			// Entourage: FB_LKStats001a, 00000011-f9e0-4b0b-852d-9f932641109f
//			// --------------------------------------------------------
//			cards.Add("FB_LKStats002c", new List<Power> {
//				// TODO [FB_LKStats002c] Modifications Complete && Test: Modifications Complete_FB_LKStats002c
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [NAX12_02H_2c_TB] Decimate (*) - COST:1 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Change the Health of enemy minions to 1.
//			// --------------------------------------------------------
//			cards.Add("NAX12_02H_2c_TB", new List<Power> {
//				// TODO [NAX12_02H_2c_TB] Decimate && Test: Decimate_NAX12_02H_2c_TB
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_006] Big Banana (*) - COST:1 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Give a minion +2/+2.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_MINION_TARGET = 0
//			// - REQ_TARGET_TO_PLAY = 0
//			// --------------------------------------------------------
//			cards.Add("TB_006", new List<Power> {
//				// TODO [TB_006] Big Banana && Test: Big Banana_TB_006
//				new Power
//				{
//					InfoCardId = "TB_006e",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_007] Deviate Banana (*) - COST:1 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Swap a minion's Attack and Health.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_MINION_TARGET = 0
//			// - REQ_TARGET_TO_PLAY = 0
//			// --------------------------------------------------------
//			cards.Add("TB_007", new List<Power> {
//				// TODO [TB_007] Deviate Banana && Test: Deviate Banana_TB_007
//				new Power
//				{
//					InfoCardId = "TB_007e",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_008] Rotten Banana (*) - COST:1 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Deal $1 damage. @spelldmg
//			// --------------------------------------------------------
//			// GameTag:
//			// - AFFECTED_BY_SPELL_POWER = 1
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_TARGET_TO_PLAY = 0
//			// --------------------------------------------------------
//			cards.Add("TB_008", new List<Power> {
//				// TODO [TB_008] Rotten Banana && Test: Rotten Banana_TB_008
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_011] Tarnished Coin (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Gain 1 Mana Crystal this turn only.
//			// --------------------------------------------------------
//			cards.Add("TB_011", new List<Power> {
//				// TODO [TB_011] Tarnished Coin && Test: Tarnished Coin_TB_011
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_012] Choose a New Card! (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Look at 3 random cards. Choose one and shuffle it into your deck.
//			// --------------------------------------------------------
//			cards.Add("TB_012", new List<Power> {
//				// TODO [TB_012] Choose a New Card! && Test: Choose a New Card!_TB_012
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_014] Choose a New Card! (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Look at 3 random cards. Choose one and put it into your hand.
//			// --------------------------------------------------------
//			cards.Add("TB_014", new List<Power> {
//				// TODO [TB_014] Choose a New Card! && Test: Choose a New Card!_TB_014
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_CoOpBossSpell_1] Prioritize (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Deal Attack damage to biggest minion.
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpBossSpell_1", new List<Power> {
//				// TODO [TB_CoOpBossSpell_1] Prioritize && Test: Prioritize_TB_CoOpBossSpell_1
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_CoOpBossSpell_2] Bomb Salvo (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Deal Attack damage to up to 3 random targets.
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpBossSpell_2", new List<Power> {
//				// TODO [TB_CoOpBossSpell_2] Bomb Salvo && Test: Bomb Salvo_TB_CoOpBossSpell_2
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_CoOpBossSpell_3] Release Coolant (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Freeze and deal Attack damage to all minions.
//			//       Gain 2 Attack.
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpBossSpell_3", new List<Power> {
//				// TODO [TB_CoOpBossSpell_3] Release Coolant && Test: Release Coolant_TB_CoOpBossSpell_3
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_CoOpBossSpell_4] Overclock (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Gain 2 Attack.
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpBossSpell_4", new List<Power> {
//				// TODO [TB_CoOpBossSpell_4] Overclock && Test: Overclock_TB_CoOpBossSpell_4
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_CoOpBossSpell_5] Double Zap (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Deal Attack damage to both players.
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpBossSpell_5", new List<Power> {
//				// TODO [TB_CoOpBossSpell_5] Double Zap && Test: Double Zap_TB_CoOpBossSpell_5
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_CoOpBossSpell_6] Kill the Lorewalker (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Destroy Lorewalker Cho.
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpBossSpell_6", new List<Power> {
//				// TODO [TB_CoOpBossSpell_6] Kill the Lorewalker && Test: Kill the Lorewalker_TB_CoOpBossSpell_6
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_CoopHero_002] Power (Spell) (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Armies!!
//			// --------------------------------------------------------
//			// GameTag:
//			// - HERO_POWER = 2379
//			// --------------------------------------------------------
//			cards.Add("TB_CoopHero_002", new List<Power> {
//				// TODO [TB_CoopHero_002] Power (Spell) && Test: Power (Spell)_TB_CoopHero_002
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_CoOpv3_001] Glorious Finale (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: The true battle begins....
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpv3_001", new List<Power> {
//				// TODO [TB_CoOpv3_001] Glorious Finale && Test: Glorious Finale_TB_CoOpv3_001
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_CoOpv3_003] Bamboozle (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Swap player's hands.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpv3_003", new List<Power> {
//				// TODO [TB_CoOpv3_003] Bamboozle && Test: Bamboozle_TB_CoOpv3_003
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_CoOpv3_004] Cleave (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Deal 7 damage to a minion and its owner.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpv3_004", new List<Power> {
//				// TODO [TB_CoOpv3_004] Cleave && Test: Cleave_TB_CoOpv3_004
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_CoOpv3_005] Cleave (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Deal 4 damage to a minion and its owner.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpv3_005", new List<Power> {
//				// TODO [TB_CoOpv3_005] Cleave && Test: Cleave_TB_CoOpv3_005
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_CoOpv3_007] Flame Missiles (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Deal 5 damage randomly split among all other characters.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpv3_007", new List<Power> {
//				// TODO [TB_CoOpv3_007] Flame Missiles && Test: Flame Missiles_TB_CoOpv3_007
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_CoOpv3_008] Flame Missiles (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Deal 10 damage randomly split among all other characters.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpv3_008", new List<Power> {
//				// TODO [TB_CoOpv3_008] Flame Missiles && Test: Flame Missiles_TB_CoOpv3_008
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_CoOpv3_009] Explosive Rune (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Summon an 'Explosive Rune.'
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpv3_009", new List<Power> {
//				// TODO [TB_CoOpv3_009] Explosive Rune && Test: Explosive Rune_TB_CoOpv3_009
//				new Power
//				{
//					InfoCardId = "TB_CoOpv3_009e",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_CoOpv3_010] Explosive Runes (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Summon two 'Explosive Runes.'
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpv3_010", new List<Power> {
//				// TODO [TB_CoOpv3_010] Explosive Runes && Test: Explosive Runes_TB_CoOpv3_010
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_CoOpv3_011] Don't Push Me! (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: He's getting angry....
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpv3_011", new List<Power> {
//				// TODO [TB_CoOpv3_011] Don't Push Me! && Test: Don't Push Me!_TB_CoOpv3_011
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_CoOpv3_012] Immolate (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Deal 4 damage to each hero.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpv3_012", new List<Power> {
//				// TODO [TB_CoOpv3_012] Immolate && Test: Immolate_TB_CoOpv3_012
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_CoOpv3_013] Immolate (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Deal 7 damage to each hero.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpv3_013", new List<Power> {
//				// TODO [TB_CoOpv3_013] Immolate && Test: Immolate_TB_CoOpv3_013
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_CoOpv3_202] Vicious Swipe (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Deal attack damage to 2 random minions.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpv3_202", new List<Power> {
//				// TODO [TB_CoOpv3_202] Vicious Swipe && Test: Vicious Swipe_TB_CoOpv3_202
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_CoOpv3_203] Meddling Fool! (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Damage the Lorewalker
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_CoOpv3_203", new List<Power> {
//				// TODO [TB_CoOpv3_203] Meddling Fool! && Test: Meddling Fool!_TB_CoOpv3_203
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_DiscoverMyDeck_Discovery] Peruse (*) - COST:1 
//			// - Set: tb, Rarity: common
//			// --------------------------------------------------------
//			// Text: <b>Discover</b> a card from your deck.
//			// --------------------------------------------------------
//			// RefTag:
//			// - DISCOVER = 1
//			// --------------------------------------------------------
//			cards.Add("TB_DiscoverMyDeck_Discovery", new List<Power> {
//				// TODO [TB_DiscoverMyDeck_Discovery] Peruse && Test: Peruse_TB_DiscoverMyDeck_Discovery
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_GiftExchange_Snowball] Hardpacked Snowballs (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Return 3 random enemy minions to your opponent's hand.
//			// --------------------------------------------------------
//			cards.Add("TB_GiftExchange_Snowball", new List<Power> {
//				// TODO [TB_GiftExchange_Snowball] Hardpacked Snowballs && Test: Hardpacked Snowballs_TB_GiftExchange_Snowball
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_GiftExchange_Treasure_Spell] Stolen Winter's Veil Gift (*) - COST:1 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Discover</b> a random Treasure. Its cost is reduced.
//			// --------------------------------------------------------
//			// RefTag:
//			// - DISCOVER = 1
//			// --------------------------------------------------------
//			cards.Add("TB_GiftExchange_Treasure_Spell", new List<Power> {
//				// TODO [TB_GiftExchange_Treasure_Spell] Stolen Winter's Veil Gift && Test: Stolen Winter's Veil Gift_TB_GiftExchange_Treasure_Spell
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_KaraPortal_001] Party Portal! (*) - COST:3 
//			// - Set: tb, Rarity: free
//			// --------------------------------------------------------
//			// Text: Summon a random Partygoer.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_MINION_TARGET = 0
//			// --------------------------------------------------------
//			cards.Add("TB_KaraPortal_001", new List<Power> {
//				// TODO [TB_KaraPortal_001] Party Portal! && Test: Party Portal!_TB_KaraPortal_001
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_KaraPortal_002] Call Mediva (*) - COST:2 
//			// - Set: tb, Rarity: free
//			// --------------------------------------------------------
//			// Text: Summon a random Mediva
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_MINION_TARGET = 0
//			// --------------------------------------------------------
//			cards.Add("TB_KaraPortal_002", new List<Power> {
//				// TODO [TB_KaraPortal_002] Call Mediva && Test: Call Mediva_TB_KaraPortal_002
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_KTRAF_101] Darkness Calls (*) - COST:8 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Summon two random Naxxramas bosses and trigger their <b>Battlecries</b>.
//			// --------------------------------------------------------
//			// Entourage: TB_KTRAF_1, TB_KTRAF_3, TB_KTRAF_4, TB_KTRAF_5, TB_KTRAF_6, TB_KTRAF_7, TB_KTRAF_8, TB_KTRAF_2, TB_KTRAF_10, TB_KTRAF_12, TB_KTRAF_11
//			// --------------------------------------------------------
//			// RefTag:
//			// - BATTLECRY = 1
//			// --------------------------------------------------------
//			cards.Add("TB_KTRAF_101", new List<Power> {
//				// TODO [TB_KTRAF_101] Darkness Calls && Test: Darkness Calls_TB_KTRAF_101
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_KTRAF_104] Uncover Staff Piece (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Add another piece to your Hero Power.
//			// --------------------------------------------------------
//			cards.Add("TB_KTRAF_104", new List<Power> {
//				// TODO [TB_KTRAF_104] Uncover Staff Piece && Test: Uncover Staff Piece_TB_KTRAF_104
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_Lethal002] Puzzle 1 (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Seems simple enough.
//			// --------------------------------------------------------
//			cards.Add("TB_Lethal002", new List<Power> {
//				// TODO [TB_Lethal002] Puzzle 1 && Test: Puzzle 1_TB_Lethal002
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_Lethal003] Puzzle 2 (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Survival percentage is 32.33 repeating of course.
//			// --------------------------------------------------------
//			cards.Add("TB_Lethal003", new List<Power> {
//				// TODO [TB_Lethal003] Puzzle 2 && Test: Puzzle 2_TB_Lethal003
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_Lethal004] Puzzle 5 (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Go Go Malygos!
//			// --------------------------------------------------------
//			cards.Add("TB_Lethal004", new List<Power> {
//				// TODO [TB_Lethal004] Puzzle 5 && Test: Puzzle 5_TB_Lethal004
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_Lethal005] Puzzle 6 (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Heal em to death!
//			// --------------------------------------------------------
//			cards.Add("TB_Lethal005", new List<Power> {
//				// TODO [TB_Lethal005] Puzzle 6 && Test: Puzzle 6_TB_Lethal005
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_Lethal006] Puzzle 7 (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: An inspiration to totems everywhere!
//			// --------------------------------------------------------
//			cards.Add("TB_Lethal006", new List<Power> {
//				// TODO [TB_Lethal006] Puzzle 7 && Test: Puzzle 7_TB_Lethal006
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_Lethal007] Puzzle 3 (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: BY PUZZLE BE PURGED!
//			// --------------------------------------------------------
//			cards.Add("TB_Lethal007", new List<Power> {
//				// TODO [TB_Lethal007] Puzzle 3 && Test: Puzzle 3_TB_Lethal007
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_Lethal008] Puzzle 9 (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: What!? This again?
//			// --------------------------------------------------------
//			cards.Add("TB_Lethal008", new List<Power> {
//				// TODO [TB_Lethal008] Puzzle 9 && Test: Puzzle 9_TB_Lethal008
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_Lethal009] Puzzle 4 (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Beasts, Beasts and more Beasts!
//			// --------------------------------------------------------
//			cards.Add("TB_Lethal009", new List<Power> {
//				// TODO [TB_Lethal009] Puzzle 4 && Test: Puzzle 4_TB_Lethal009
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_Lethal010] Puzzle 8 (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: A chilly challenge!
//			// --------------------------------------------------------
//			cards.Add("TB_Lethal010", new List<Power> {
//				// TODO [TB_Lethal010] Puzzle 8 && Test: Puzzle 8_TB_Lethal010
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_LethalSetup001a] Continue (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Continue from where you left off.
//			// --------------------------------------------------------
//			cards.Add("TB_LethalSetup001a", new List<Power> {
//				// TODO [TB_LethalSetup001a] Continue && Test: Continue_TB_LethalSetup001a
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_LethalSetup001b] Restart (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Start again at the beginning.
//			// --------------------------------------------------------
//			cards.Add("TB_LethalSetup001b", new List<Power> {
//				// TODO [TB_LethalSetup001b] Restart && Test: Restart_TB_LethalSetup001b
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_MammothParty_301] Rock Candy (*) - COST:3 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Destroy a random Party Crasher.
//			// --------------------------------------------------------
//			// GameTag:
//			// - UNTOUCHABLE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_MammothParty_301", new List<Power> {
//				// TODO [TB_MammothParty_301] Rock Candy && Test: Rock Candy_TB_MammothParty_301
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_MammothParty_302] Regenerative Cookies (*) - COST:1 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Restore 4 Health to each hero.
//			// --------------------------------------------------------
//			// GameTag:
//			// - UNTOUCHABLE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_MammothParty_302", new List<Power> {
//				// TODO [TB_MammothParty_302] Regenerative Cookies && Test: Regenerative Cookies_TB_MammothParty_302
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_MammothParty_303] Divine Sweets (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Each player draws a card.
//			// --------------------------------------------------------
//			// GameTag:
//			// - UNTOUCHABLE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_MammothParty_303", new List<Power> {
//				// TODO [TB_MammothParty_303] Divine Sweets && Test: Divine Sweets_TB_MammothParty_303
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_MammothParty_s004] Something in the Punch (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Deal 2 damage to all minions other than Party Crashers.
//			// --------------------------------------------------------
//			// GameTag:
//			// - UNTOUCHABLE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_MammothParty_s004", new List<Power> {
//				// TODO [TB_MammothParty_s004] Something in the Punch && Test: Something in the Punch_TB_MammothParty_s004
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_MammothParty_s101] Party Supplies (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Choose One - </b> Destroy a random Party Crasher; or Each player draws a card.
//			// --------------------------------------------------------
//			cards.Add("TB_MammothParty_s101", new List<Power> {
//				// TODO [TB_MammothParty_s101] Party Supplies && Test: Party Supplies_TB_MammothParty_s101
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_MammothParty_s101a] Fruit Plate (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Each player draws a card.
//			// --------------------------------------------------------
//			// GameTag:
//			// - UNTOUCHABLE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_MammothParty_s101a", new List<Power> {
//				// TODO [TB_MammothParty_s101a] Fruit Plate && Test: Fruit Plate_TB_MammothParty_s101a
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_MammothParty_s101b] Like a Sore Thumb (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Destroy a random Party Crasher.
//			// --------------------------------------------------------
//			// GameTag:
//			// - UNTOUCHABLE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_MammothParty_s101b", new List<Power> {
//				// TODO [TB_MammothParty_s101b] Like a Sore Thumb && Test: Like a Sore Thumb_TB_MammothParty_s101b
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_MammothParty_s998] Noise Complaint (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: If the board opposing the <b>Boss</b> is full, destroy all those minions.
//			// --------------------------------------------------------
//			// GameTag:
//			// - UNTOUCHABLE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_MammothParty_s998", new List<Power> {
//				// TODO [TB_MammothParty_s998] Noise Complaint && Test: Noise Complaint_TB_MammothParty_s998
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_PickYourFate_1] Dire Fate: Taunt and Charge (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: All minions have <b>Taunt</b> and <b>Charge</b>.
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_1", new List<Power> {
//				// TODO [TB_PickYourFate_1] Dire Fate: Taunt and Charge && Test: Dire Fate: Taunt and Charge_TB_PickYourFate_1
//				new Power
//				{
//					InfoCardId = "TB_PickYourFate_10_Ench",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_PickYourFate_10] Battlecry Bonus (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Your <b>Battlecry</b> minions have +1/+1.
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_10", new List<Power> {
//				// TODO [TB_PickYourFate_10] Battlecry Bonus && Test: Battlecry Bonus_TB_PickYourFate_10
//				new Power
//				{
//					InfoCardId = "TB_PickYourFate_10_Ench",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_PickYourFate_11b] Murloc Bonus (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Summon a 1/1 Murloc at the end of your turn.
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_11b", new List<Power> {
//				// TODO [TB_PickYourFate_11b] Murloc Bonus && Test: Murloc Bonus_TB_PickYourFate_11b
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_PickYourFate_11rand] Dire Fate: Murlocs (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Turn each minion in play into a 1/1 Murloc.
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_11rand", new List<Power> {
//				// TODO [TB_PickYourFate_11rand] Dire Fate: Murlocs && Test: Dire Fate: Murlocs_TB_PickYourFate_11rand
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_PickYourFate_12] Fate: Confusion (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: At the end of each turn, swap all minions' Attack and Health.
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_12", new List<Power> {
//				// TODO [TB_PickYourFate_12] Fate: Confusion && Test: Fate: Confusion_TB_PickYourFate_12
//				new Power
//				{
//					InfoCardId = "TB_PickYourFate_12_Ench",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_PickYourFate_2] Fate: Bananas (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: When a minion dies, its owner gets a (1) mana Banana.
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_2", new List<Power> {
//				// TODO [TB_PickYourFate_2] Fate: Bananas && Test: Fate: Bananas_TB_PickYourFate_2
//				new Power
//				{
//					InfoCardId = "TB_PickYourFate_2_Ench",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_PickYourFate_3] Dire Fate: Windfury (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: All minions have <b>Windfury</b>.
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_3", new List<Power> {
//				// TODO [TB_PickYourFate_3] Dire Fate: Windfury && Test: Dire Fate: Windfury_TB_PickYourFate_3
//				new Power
//				{
//					InfoCardId = "TB_PickYourFate_3_Ench",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_PickYourFate_4] Dire Fate: Card (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: When a minion dies, its owner draws a card.
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_4", new List<Power> {
//				// TODO [TB_PickYourFate_4] Dire Fate: Card && Test: Dire Fate: Card_TB_PickYourFate_4
//				new Power
//				{
//					InfoCardId = "TB_PickYourFate_4_Ench",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_PickYourFate_5] Fate: Spells (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Spells cost (1) less.
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_5", new List<Power> {
//				// TODO [TB_PickYourFate_5] Fate: Spells && Test: Fate: Spells_TB_PickYourFate_5
//				new Power
//				{
//					InfoCardId = "TB_PickYourFate_5_Ench",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_PickYourFate_6] Fate: Portals (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Shuffle 10 Unstable Portals into each player's deck.
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_6", new List<Power> {
//				// TODO [TB_PickYourFate_6] Fate: Portals && Test: Fate: Portals_TB_PickYourFate_6
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_PickYourFate_6_2nd] Dire Fate: Unstable Portals (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Place 3 Unstable Portals in each player's hand.
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_6_2nd", new List<Power> {
//				// TODO [TB_PickYourFate_6_2nd] Dire Fate: Unstable Portals && Test: Dire Fate: Unstable Portals_TB_PickYourFate_6_2nd
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_PickYourFate_7] Fate: Coin (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: When a minion dies, its owner gets a Coin.
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_7", new List<Power> {
//				// TODO [TB_PickYourFate_7] Fate: Coin && Test: Fate: Coin_TB_PickYourFate_7
//				new Power
//				{
//					InfoCardId = "TB_PickYourFate_7_Ench_2nd",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_PickYourFate_7_2nd] Dire Fate: Manaburst (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Minions gain <b>Deathrattle:</b> Random card in owner's hand costs (0).
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_7_2nd", new List<Power> {
//				// TODO [TB_PickYourFate_7_2nd] Dire Fate: Manaburst && Test: Dire Fate: Manaburst_TB_PickYourFate_7_2nd
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_PickYourFate_8] Spell Bonus (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Whenever you cast a spell, gain 3 Armor.
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_8", new List<Power> {
//				// TODO [TB_PickYourFate_8] Spell Bonus && Test: Spell Bonus_TB_PickYourFate_8
//				new Power
//				{
//					InfoCardId = "TB_PickYourFate_8_Ench",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_PickYourFate_8rand] Fate: Armor (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Each player gains 2 Armor on the start of their turn.
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_8rand", new List<Power> {
//				// TODO [TB_PickYourFate_8rand] Fate: Armor && Test: Fate: Armor_TB_PickYourFate_8rand
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_PickYourFate_9] Deathrattle Bonus (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Your <b>Deathrattle</b> minions have +1/+1.
//			// --------------------------------------------------------
//			cards.Add("TB_PickYourFate_9", new List<Power> {
//				// TODO [TB_PickYourFate_9] Deathrattle Bonus && Test: Deathrattle Bonus_TB_PickYourFate_9
//				new Power
//				{
//					InfoCardId = "TB_PickYourFate_9_Ench",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_Presents_001] Present! (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: When you draw this, <b>Discover</b> a treasure, then draw a card.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// - TOPDECK = 1
//			// --------------------------------------------------------
//			cards.Add("TB_Presents_001", new List<Power> {
//				// TODO [TB_Presents_001] Present! && Test: Present!_TB_Presents_001
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_Presents_002] Card Present (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Draw a card.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_Presents_002", new List<Power> {
//				// TODO [TB_Presents_002] Card Present && Test: Card Present_TB_Presents_002
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_Presents_003] Zombie Present (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Summon a 3/3 Zombie.
//			// --------------------------------------------------------
//			// GameTag:
//			// - ELITE = 1
//			// --------------------------------------------------------
//			cards.Add("TB_Presents_003", new List<Power> {
//				// TODO [TB_Presents_003] Zombie Present && Test: Zombie Present_TB_Presents_003
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_SPT_DPromo_EnterPortal] The Portal Opens (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Through the Nether and into...
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DPromo_EnterPortal", new List<Power> {
//				// TODO [TB_SPT_DPromo_EnterPortal] The Portal Opens && Test: The Portal Opens_TB_SPT_DPromo_EnterPortal
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_SPT_DPromoSpell1] Lightning (*) - COST:2 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Deal $3 damage. @spelldmg
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_TARGET_TO_PLAY = 0
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DPromoSpell1", new List<Power> {
//				// TODO [TB_SPT_DPromoSpell1] Lightning && Test: Lightning_TB_SPT_DPromoSpell1
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_SPT_DPromoSpell2] Summon Guardians (*) - COST:2 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Summon two 2/4 Guardians.
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_NUM_MINION_SLOTS = 1
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DPromoSpell2", new List<Power> {
//				// TODO [TB_SPT_DPromoSpell2] Summon Guardians && Test: Summon Guardians_TB_SPT_DPromoSpell2
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_SPT_DPromoSpellBovine1] Moo... (*) - COST:6 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Summon 3 Hell Bovines. Give all Hell Bovines <b>Taunt</b>.
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DPromoSpellBovine1", new List<Power> {
//				// TODO [TB_SPT_DPromoSpellBovine1] Moo... && Test: Moo..._TB_SPT_DPromoSpellBovine1
//				new Power
//				{
//					InfoCardId = "TB_SPT_DPromoSpellBovine1e",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_SPT_DPromoSpellPortal] The Portal Opens (*) - COST:2 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Through the Nether and into...
//			// --------------------------------------------------------
//			// PlayReq:
//			// - REQ_TARGET_TO_PLAY = 0
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DPromoSpellPortal", new List<Power> {
//				// TODO [TB_SPT_DPromoSpellPortal] The Portal Opens && Test: The Portal Opens_TB_SPT_DPromoSpellPortal
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_SPT_DPromoSpellPortal2] Stampede (*) - COST:4 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Summon 2 Hell Bovines. Give all Hell Bovines <b>Charge</b>.
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_DPromoSpellPortal2", new List<Power> {
//				// TODO [TB_SPT_DPromoSpellPortal2] Stampede && Test: Stampede_TB_SPT_DPromoSpellPortal2
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_Superfriends001] Offensive Play (*) - COST:0 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: The next Legendary minion you play and all your other copies cost (3) less.
//			// --------------------------------------------------------
//			cards.Add("TB_Superfriends001", new List<Power> {
//				// TODO [TB_Superfriends001] Offensive Play && Test: Offensive Play_TB_Superfriends001
//				new Power
//				{
//					InfoCardId = "TB_Superfriends001e",
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_TagTeam_ClearBoard] Your Next Victim Comes (*) - COST:10 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: Destroy all minions. Drain all Mana. Gain 5 Health.
//			// --------------------------------------------------------
//			cards.Add("TB_TagTeam_ClearBoard", new List<Power> {
//				// TODO [TB_TagTeam_ClearBoard] Your Next Victim Comes && Test: Your Next Victim Comes_TB_TagTeam_ClearBoard
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// ---------------------------------------- SPELL - NEUTRAL
//			// [TB_TagTeam_NewHeroCards] New Hero! (*) - COST:0 
//			// - Fac: neutral, Set: tb, 
//			// --------------------------------------------------------
//			// Text: A new Hero takes position.
//			// --------------------------------------------------------
//			cards.Add("TB_TagTeam_NewHeroCards", new List<Power> {
//				// TODO [TB_TagTeam_NewHeroCards] New Hero! && Test: New Hero!_TB_TagTeam_NewHeroCards
//				new Power
//				{
//					Activation = PowerActivation.SPELL,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- WEAPON - NEUTRAL
//			// [BRMC_94] Sulfuras (*) - COST:2 [ATK:2/HP:0] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: <b>Deathrattle:</b> Your Hero Power becomes 'Deal 8 damage to a random enemy'.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DURABILITY = 6
//			// - DEATHRATTLE = 1
//			// --------------------------------------------------------
//			cards.Add("BRMC_94", new List<Power> {
//				// TODO [BRMC_94] Sulfuras && Test: Sulfuras_BRMC_94
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
//			// [TB_BlingBrawl_Weapon] Foam Sword (*) - COST:1 [ATK:2/HP:0] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// GameTag:
//			// - DURABILITY = 2
//			// --------------------------------------------------------
//			cards.Add("TB_BlingBrawl_Weapon", new List<Power> {
//				// TODO [TB_BlingBrawl_Weapon] Foam Sword && Test: Foam Sword_TB_BlingBrawl_Weapon
//				new Power
//				{
//					Activation = PowerActivation.WEAPON,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- WEAPON - NEUTRAL
//			// [TB_KTRAF_08w] Massive Runeblade (*) - COST:3 [ATK:5/HP:0] 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Deals double damage to heroes.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DURABILITY = 2
//			// --------------------------------------------------------
//			cards.Add("TB_KTRAF_08w", new List<Power> {
//				// TODO [TB_KTRAF_08w] Massive Runeblade && Test: Massive Runeblade_TB_KTRAF_08w
//				new Power
//				{
//					Activation = PowerActivation.WEAPON,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- WEAPON - NEUTRAL
//			// [TB_SPT_BossWeapon] Armory (*) - COST:1 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Attack increases over time.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DURABILITY = 1
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_BossWeapon", new List<Power> {
//				// TODO [TB_SPT_BossWeapon] Armory && Test: Armory_TB_SPT_BossWeapon
//				new Power
//				{
//					Activation = PowerActivation.WEAPON,
//					PowerTask = null,
//				},
//			});

//			// --------------------------------------- WEAPON - NEUTRAL
//			// [TB_SPT_MTH_BossWeapon] Party Armory (*) - COST:1 
//			// - Set: tb, 
//			// --------------------------------------------------------
//			// Text: Attack increases over time.
//			// --------------------------------------------------------
//			// GameTag:
//			// - DURABILITY = 1
//			// --------------------------------------------------------
//			cards.Add("TB_SPT_MTH_BossWeapon", new List<Power> {
//				// TODO [TB_SPT_MTH_BossWeapon] Party Armory && Test: Party Armory_TB_SPT_MTH_BossWeapon
//				new Power
//				{
//					Activation = PowerActivation.WEAPON,
//					PowerTask = null,
//				},
//			});

//		}

//		public static void AddAll(Dictionary<string, List<Power>> cards)
//		{
//			Heroes(cards);
//			HeroPowers(cards);
//			DeathknightNonCollect(cards);
//			DruidNonCollect(cards);
//			HunterNonCollect(cards);
//			MageNonCollect(cards);
//			PaladinNonCollect(cards);
//			PriestNonCollect(cards);
//			RogueNonCollect(cards);
//			ShamanNonCollect(cards);
//			WarlockNonCollect(cards);
//			WarriorNonCollect(cards);
//			DreamNonCollect(cards);
//			NeutralNonCollect(cards);
//		}
//	}
//}
