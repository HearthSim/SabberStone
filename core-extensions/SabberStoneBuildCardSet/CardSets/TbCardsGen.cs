using System.Collections.Generic;
using SabberStoneCore.Enchants;
using SabberStoneCore.Conditions;
using SabberStoneCore.Enums;
using SabberStoneCore.Model;
using SabberStoneCore.Model.Zones;
using SabberStoneCore.Model.Entities;
using SabberStoneCore.Tasks;
using SabberStoneCore.Tasks.SimpleTasks;

namespace SabberStoneCore.CardSets.Undefined
{
	public class TbCardsGen
	{
		private static void Heroes(IDictionary<string, Power> cards)
		{
			// ----------------------------------------- HERO - NEUTRAL
			// [FB_LK008h] Blood-Queen Lana'thel (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 43194
			// --------------------------------------------------------
			cards.Add("FB_LK008h", new Power {
				// TODO [FB_LK008h] Blood-Queen Lana'thel && Test: Blood-Queen Lana'thel_FB_LK008h
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [FB_LK_012h] Lord Marrowgar (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 42447
			// --------------------------------------------------------
			cards.Add("FB_LK_012h", new Power {
				// TODO [FB_LK_012h] Lord Marrowgar && Test: Lord Marrowgar_FB_LK_012h
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [FB_LK_013h] Professor Putricide (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 42876
			// --------------------------------------------------------
			cards.Add("FB_LK_013h", new Power {
				// TODO [FB_LK_013h] Professor Putricide && Test: Professor Putricide_FB_LK_013h
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [FB_LK_014h] Sindragosa (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 45627
			// --------------------------------------------------------
			cards.Add("FB_LK_014h", new Power {
				// TODO [FB_LK_014h] Sindragosa && Test: Sindragosa_FB_LK_014h
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [FB_LK_Raid_Hero] Supreme Lich King (*) - COST:0 [ATK:0/HP:400] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 42457
			// --------------------------------------------------------
			cards.Add("FB_LK_Raid_Hero", new Power {
				// TODO [FB_LK_Raid_Hero] Supreme Lich King && Test: Supreme Lich King_FB_LK_Raid_Hero
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [FB_LK_Raid_Hero_Battledamaged] Supreme Lich King (*) - COST:0 [ATK:0/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 42457
			// --------------------------------------------------------
			cards.Add("FB_LK_Raid_Hero_Battledamaged", new Power {
				// TODO [FB_LK_Raid_Hero_Battledamaged] Supreme Lich King && Test: Supreme Lich King_FB_LK_Raid_Hero_Battledamaged
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [KAR_a10_Boss1H_TB] White King (*) - COST:0 [ATK:0/HP:10] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 40086
			// --------------------------------------------------------
			cards.Add("KAR_a10_Boss1H_TB", new Power {
				// TODO [KAR_a10_Boss1H_TB] White King && Test: White King_KAR_a10_Boss1H_TB
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [KAR_a10_Boss1H_TB22] White King (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 40086
			// --------------------------------------------------------
			cards.Add("KAR_a10_Boss1H_TB22", new Power {
				// TODO [KAR_a10_Boss1H_TB22] White King && Test: White King_KAR_a10_Boss1H_TB22
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [KAR_a10_Boss2H_TB] Black King (*) - COST:0 [ATK:0/HP:10] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39801
			// - CANT_BE_FATIGUED = 1
			// --------------------------------------------------------
			cards.Add("KAR_a10_Boss2H_TB", new Power {
				// TODO [KAR_a10_Boss2H_TB] Black King && Test: Black King_KAR_a10_Boss2H_TB
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - PALADIN
			// [TB_BossRumble_001] Han'Cho (*) - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39240
			// --------------------------------------------------------
			cards.Add("TB_BossRumble_001", new Power {
				// TODO [TB_BossRumble_001] Han'Cho && Test: Han'Cho_TB_BossRumble_001
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- HERO - DRUID
			// [TB_BossRumble_002] Aya Blackpaw (*) - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39240
			// --------------------------------------------------------
			cards.Add("TB_BossRumble_002", new Power {
				// TODO [TB_BossRumble_002] Aya Blackpaw && Test: Aya Blackpaw_TB_BossRumble_002
				//PowerTask = null,
				//Trigger = null,
			});

			// -------------------------------------------- HERO - MAGE
			// [TB_BossRumble_003] Kazakus (*) - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39240
			// --------------------------------------------------------
			cards.Add("TB_BossRumble_003", new Power {
				// TODO [TB_BossRumble_003] Kazakus && Test: Kazakus_TB_BossRumble_003
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_BuildaBoss_001] Catacomb Boss (*) - COST:0 [ATK:0/HP:80] 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_BuildaBoss_001", new Power {
				// TODO [TB_BuildaBoss_001] Catacomb Boss && Test: Catacomb Boss_TB_BuildaBoss_001
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_CoopHero_H_001] Coop Boss (*) - COST:0 [ATK:0/HP:100] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 40221
			// --------------------------------------------------------
			cards.Add("TB_CoopHero_H_001", new Power {
				// TODO [TB_CoopHero_H_001] Coop Boss && Test: Coop Boss_TB_CoopHero_H_001
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_FW_Rag] Ragnaros the Firelord (*) - COST:0 [ATK:0/HP:60] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 2660
			// --------------------------------------------------------
			cards.Add("TB_FW_Rag", new Power {
				// TODO [TB_FW_Rag] Ragnaros the Firelord && Test: Ragnaros the Firelord_TB_FW_Rag
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_HeadlessHorseman_H1] Headless Horseman (*) - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_H1", new Power {
				// TODO [TB_HeadlessHorseman_H1] Headless Horseman && Test: Headless Horseman_TB_HeadlessHorseman_H1
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_HeadlessHorseman_H1a] Headless Horseman (no head) (*) - COST:0 [ATK:0/HP:1] 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_H1a", new Power {
				// TODO [TB_HeadlessHorseman_H1a] Headless Horseman (no head) && Test: Headless Horseman (no head)_TB_HeadlessHorseman_H1a
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_HeadlessHorseman_H2] Stormwind Investigator (*) - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Entourage: TB_HeadlessHorseman_s001a, TB_HeadlessHorseman_s001c, TB_HeadlessHorseman_s001b
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_H2", new Power {
				// TODO [TB_HeadlessHorseman_H2] Stormwind Investigator && Test: Stormwind Investigator_TB_HeadlessHorseman_H2
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_HeadlessHorseman_H2a] Stormwind Investigator Witch (*) - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Entourage: TB_HeadlessHorseman_s001a, TB_HeadlessHorseman_s001c, TB_HeadlessHorseman_s001b
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_H2a", new Power {
				// TODO [TB_HeadlessHorseman_H2a] Stormwind Investigator Witch && Test: Stormwind Investigator Witch_TB_HeadlessHorseman_H2a
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_HeadlessHorseman_H2b] Stormwind Investigator Cat (*) - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Entourage: TB_HeadlessHorseman_s001a, TB_HeadlessHorseman_s001c, TB_HeadlessHorseman_s001b
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_H2b", new Power {
				// TODO [TB_HeadlessHorseman_H2b] Stormwind Investigator Cat && Test: Stormwind Investigator Cat_TB_HeadlessHorseman_H2b
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_HeadlessHorseman_H2c] Stormwind Investigator Pirate (*) - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Entourage: TB_HeadlessHorseman_s001a, TB_HeadlessHorseman_s001c, TB_HeadlessHorseman_s001b
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_H2c", new Power {
				// TODO [TB_HeadlessHorseman_H2c] Stormwind Investigator Pirate && Test: Stormwind Investigator Pirate_TB_HeadlessHorseman_H2c
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_KTRAF_H_1] Kel'Thuzad (*) - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39240
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_H_1", new Power {
				// TODO [TB_KTRAF_H_1] Kel'Thuzad && Test: Kel'Thuzad_TB_KTRAF_H_1
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_KTRAF_H_2] Rafaam (*) - COST:0 [ATK:0/HP:60] 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39236
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_H_2", new Power {
				// TODO [TB_KTRAF_H_2] Rafaam && Test: Rafaam_TB_KTRAF_H_2
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_MechWar_Boss1] Annoy-o-Tron (*) - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			cards.Add("TB_MechWar_Boss1", new Power {
				// TODO [TB_MechWar_Boss1] Annoy-o-Tron && Test: Annoy-o-Tron_TB_MechWar_Boss1
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_MechWar_Boss2] Boom Bot (*) - COST:0 [ATK:0/HP:30] 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			cards.Add("TB_MechWar_Boss2", new Power {
				// TODO [TB_MechWar_Boss2] Boom Bot && Test: Boom Bot_TB_MechWar_Boss2
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_SPT_Boss] City of Stormwind (*) - COST:0 [ATK:0/HP:1000] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39537
			// - HEALTH_DISPLAY = 1
			// - ENABLE_HEALTH_DISPLAY = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_Boss", new Power {
				// TODO [TB_SPT_Boss] City of Stormwind && Test: City of Stormwind_TB_SPT_Boss
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - WARLOCK
			// [TB_SPT_DPromo_Hero] Dark Wanderer (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 42156
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromo_Hero", new Power {
				// TODO [TB_SPT_DPromo_Hero] Dark Wanderer && Test: Dark Wanderer_TB_SPT_DPromo_Hero
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - WARRIOR
			// [TB_SPT_DPromo_Hero2] The Cow King (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - InvisibleDeathrattle = 1
			// - HERO_POWER = 42156
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromo_Hero2", new Power {
				// TODO [TB_SPT_DPromo_Hero2] The Cow King && Test: The Cow King_TB_SPT_DPromo_Hero2
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_SPT_MTH_Boss] Decorated Stormwind (*) - COST:0 [ATK:0/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39537
			// --------------------------------------------------------
			cards.Add("TB_SPT_MTH_Boss", new Power {
				// TODO [TB_SPT_MTH_Boss] Decorated Stormwind && Test: Decorated Stormwind_TB_SPT_MTH_Boss
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_SPT_MTH_Boss0] City of Stormwind (*) - COST:0 [ATK:0/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39537
			// --------------------------------------------------------
			cards.Add("TB_SPT_MTH_Boss0", new Power {
				// TODO [TB_SPT_MTH_Boss0] City of Stormwind && Test: City of Stormwind_TB_SPT_MTH_Boss0
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_SPT_MTH_Boss2] Partytown Stormwind (*) - COST:0 [ATK:0/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39537
			// --------------------------------------------------------
			cards.Add("TB_SPT_MTH_Boss2", new Power {
				// TODO [TB_SPT_MTH_Boss2] Partytown Stormwind && Test: Partytown Stormwind_TB_SPT_MTH_Boss2
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [TB_SPT_MTH_Boss3] Party Capital (*) - COST:0 [ATK:0/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39537
			// --------------------------------------------------------
			cards.Add("TB_SPT_MTH_Boss3", new Power {
				// TODO [TB_SPT_MTH_Boss3] Party Capital && Test: Party Capital_TB_SPT_MTH_Boss3
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [TBA01_1] Ragnaros the Firelord (*) - COST:0 [ATK:0/HP:60] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 2660
			// --------------------------------------------------------
			cards.Add("TBA01_1", new Power {
				// TODO [TBA01_1] Ragnaros the Firelord && Test: Ragnaros the Firelord_TBA01_1
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- HERO - NEUTRAL
			// [TBA01_4] Nefarian (*) - COST:0 [ATK:0/HP:30] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 2653
			// --------------------------------------------------------
			cards.Add("TBA01_4", new Power {
				// TODO [TBA01_4] Nefarian && Test: Nefarian_TBA01_4
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void HeroPowers(IDictionary<string, Power> cards)
		{
			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BRMA01_2H_2_TB] Pile On!!! (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Put a minion from each deck into the battlefield.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("BRMA01_2H_2_TB", new Power {
				// TODO [BRMA01_2H_2_TB] Pile On!!! && Test: Pile On!!!_BRMA01_2H_2_TB
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BRMA02_2_2_TB] Jeering Crowd (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a 1/1 Spectator with <b>Taunt</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("BRMA02_2_2_TB", new Power {
				// TODO [BRMA02_2_2_TB] Jeering Crowd && Test: Jeering Crowd_BRMA02_2_2_TB
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BRMA06_2H_TB] The Majordomo (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a 3/3 Flamewaker Acolyte.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("BRMA06_2H_TB", new Power {
				// TODO [BRMA06_2H_TB] The Majordomo && Test: The Majordomo_BRMA06_2H_TB
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BRMA07_2_2_TB] ME SMASH (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Destroy a random enemy minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 1
			// --------------------------------------------------------
			cards.Add("BRMA07_2_2_TB", new Power {
				// TODO [BRMA07_2_2_TB] ME SMASH && Test: ME SMASH_BRMA07_2_2_TB
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BRMA09_2_TB] Open the Gates (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon three 1/1 Whelps.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("BRMA09_2_TB", new Power {
				// TODO [BRMA09_2_TB] Open the Gates && Test: Open the Gates_BRMA09_2_TB
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BRMA11_2H_2_TB] Essence of the Red (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Each player draws 3 cards. Gain a Mana Crystal.
			// --------------------------------------------------------
			cards.Add("BRMA11_2H_2_TB", new Power {
				// TODO [BRMA11_2H_2_TB] Essence of the Red && Test: Essence of the Red_BRMA11_2H_2_TB
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BRMA13_4_2_TB] Wild Magic (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Put a random spell from your opponent's class into your hand.
			// --------------------------------------------------------
			cards.Add("BRMA13_4_2_TB", new Power {
				// TODO [BRMA13_4_2_TB] Wild Magic && Test: Wild Magic_BRMA13_4_2_TB
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BRMA14_10H_TB] Activate! (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Activate a random Tron.
			// --------------------------------------------------------
			// Entourage: BRMA14_3, BRMA14_5, BRMA14_7, BRMA14_9
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("BRMA14_10H_TB", new Power {
				// TODO [BRMA14_10H_TB] Activate! && Test: Activate!_BRMA14_10H_TB
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [BRMA17_5_TB] Bone Minions (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon two 2/1 Bone Constructs.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("BRMA17_5_TB", new Power {
				// TODO [BRMA17_5_TB] Bone Minions && Test: Bone Minions_BRMA17_5_TB
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [EX1_tk33_2_TB] INFERNO! (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a 6/6 Infernal.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("EX1_tk33_2_TB", new Power {
				// TODO [EX1_tk33_2_TB] INFERNO! && Test: INFERNO!_EX1_tk33_2_TB
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------- HERO_POWER - DEATHKNIGHT
			// [FB_LK005] Remorseless Winter (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal @ damage to the enemy hero. +1 Damage each time.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			cards.Add("FB_LK005", new Power {
				// TODO [FB_LK005] Remorseless Winter && Test: Remorseless Winter_FB_LK005
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [FB_LK007p] Freezing Blast (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       <b>Freeze</b> a random enemy minion and deal 1 damage to it.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			cards.Add("FB_LK007p", new Power {
				// TODO [FB_LK007p] Freezing Blast && Test: Freezing Blast_FB_LK007p
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [NAX11_02H_2_TB] Poison Cloud (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal 1 damage to all enemy minions. If any die, summon a slime.
			// --------------------------------------------------------
			cards.Add("NAX11_02H_2_TB", new Power {
				// TODO [NAX11_02H_2_TB] Poison Cloud && Test: Poison Cloud_NAX11_02H_2_TB
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [NAX12_02H_2_TB] Decimate (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Change the Health of enemy minions to 1.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 1
			// --------------------------------------------------------
			cards.Add("NAX12_02H_2_TB", new Power {
				// TODO [NAX12_02H_2_TB] Decimate && Test: Decimate_NAX12_02H_2_TB
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [NAX3_02_TB] Web Wrap (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Return a random enemy minion to your opponent's hand.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINIMUM_ENEMY_MINIONS = 1
			// --------------------------------------------------------
			cards.Add("NAX3_02_TB", new Power {
				// TODO [NAX3_02_TB] Web Wrap && Test: Web Wrap_NAX3_02_TB
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [NAX8_02H_TB] Harvest (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Draw a card. Gain a Mana Crystal.
			// --------------------------------------------------------
			cards.Add("NAX8_02H_TB", new Power {
				// TODO [NAX8_02H_TB] Harvest && Test: Harvest_NAX8_02H_TB
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------- HERO_POWER - ROGUE
			// [TB_BlingBrawl_Hero1p] Sharpen (*) - COST:2 
			// - Set: tb, Rarity: free
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Increase your weapon's attack by 1
			// --------------------------------------------------------
			cards.Add("TB_BlingBrawl_Hero1p", new Power {
				// TODO [TB_BlingBrawl_Hero1p] Sharpen && Test: Sharpen_TB_BlingBrawl_Hero1p
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_BossRumble_001hp] Smuggle (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give a random minion in your hand +2/+2
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39240
			// --------------------------------------------------------
			cards.Add("TB_BossRumble_001hp", new Power {
				// TODO [TB_BossRumble_001hp] Smuggle && Test: Smuggle_TB_BossRumble_001hp
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_BossRumble_002hp] Construct Golem (*) - COST:4 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a {0} <b>Jade Golem</b>.@Summon a <b>Jade Golem</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39240
			// --------------------------------------------------------
			cards.Add("TB_BossRumble_002hp", new Power {
				// TODO [TB_BossRumble_002hp] Construct Golem && Test: Construct Golem_TB_BossRumble_002hp
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_BossRumble_003hp] Brew Potion (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Add a random Potion to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39240
			// --------------------------------------------------------
			cards.Add("TB_BossRumble_003hp", new Power {
				// TODO [TB_BossRumble_003hp] Brew Potion && Test: Brew Potion_TB_BossRumble_003hp
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_BRMA01_2H_2] Pile On!!! (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Put a minion from each deck into the battlefield.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("TB_BRMA01_2H_2", new Power {
				// TODO [TB_BRMA01_2H_2] Pile On!!! && Test: Pile On!!!_TB_BRMA01_2H_2
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_BRMA10_3H] The Rookery (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give all Corrupted Eggs +1 Health, then summon one.
			// --------------------------------------------------------
			cards.Add("TB_BRMA10_3H", new Power {
				// TODO [TB_BRMA10_3H] The Rookery && Test: The Rookery_TB_BRMA10_3H
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_BuildaBoss_404p] Toxic Fumes (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal 1 damage to all minions.
			// --------------------------------------------------------
			cards.Add("TB_BuildaBoss_404p", new Power {
				// TODO [TB_BuildaBoss_404p] Toxic Fumes && Test: Toxic Fumes_TB_BuildaBoss_404p
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_CoopHero_HP_001] Madness (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Armies!!
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 2379
			// --------------------------------------------------------
			cards.Add("TB_CoopHero_HP_001", new Power {
				// TODO [TB_CoopHero_HP_001] Madness && Test: Madness_TB_CoopHero_HP_001
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_HeadlessHorseman_HP1] Slash (*) - COST:3 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal 2 damage randomly split among all enemies.
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_HP1", new Power {
				// TODO [TB_HeadlessHorseman_HP1] Slash && Test: Slash_TB_HeadlessHorseman_HP1
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_HeadlessHorseman_HP3] Conscript (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Your minions count as Pirates.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_HP3", new Power {
				// TODO [TB_HeadlessHorseman_HP3] Conscript && Test: Conscript_TB_HeadlessHorseman_HP3
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_HeadlessHorseman_HP4] Witchcraft (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       If you have enough mana, your spells cost double and cast a second copy.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39240
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_HP4", new Power {
				// TODO [TB_HeadlessHorseman_HP4] Witchcraft && Test: Witchcraft_TB_HeadlessHorseman_HP4
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_HeadlessHorseman_HP5] Sense Weakness (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Passive Hero Power</b>
			//       Whenever a non-<b>Boss</b> enemy survives damage, summon a 1/1 Cat.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39240
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_HP5", new Power {
				// TODO [TB_HeadlessHorseman_HP5] Sense Weakness && Test: Sense Weakness_TB_HeadlessHorseman_HP5
				InfoCardId = "TB_HeadlessHorseman_HP5e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_KTRAF_HP_KT_3] Necromancy (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Add a random Naxxramas minion to your hand.
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_HP_KT_3", new Power {
				// TODO [TB_KTRAF_HP_KT_3] Necromancy && Test: Necromancy_TB_KTRAF_HP_KT_3
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_KTRAF_HP_RAF3] Staff, First Piece (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Add a random rare card to your hand. It costs (2) less.
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_HP_RAF3", new Power {
				// TODO [TB_KTRAF_HP_RAF3] Staff, First Piece && Test: Staff, First Piece_TB_KTRAF_HP_RAF3
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_KTRAF_HP_RAF4] Staff, Two Pieces (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Add a random epic card to your hand. It costs (3) less.
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_HP_RAF4", new Power {
				// TODO [TB_KTRAF_HP_RAF4] Staff, Two Pieces && Test: Staff, Two Pieces_TB_KTRAF_HP_RAF4
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_KTRAF_HP_RAF5] Staff of Origination (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Add a random legendary minion to your hand. It costs (4) less.
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_HP_RAF5", new Power {
				// TODO [TB_KTRAF_HP_RAF5] Staff of Origination && Test: Staff of Origination_TB_KTRAF_HP_RAF5
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_LevelUp_001] Level Up! (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Level up all the spells in your hand and deck.
			// --------------------------------------------------------
			cards.Add("TB_LevelUp_001", new Power {
				// TODO [TB_LevelUp_001] Level Up! && Test: Level Up!_TB_LevelUp_001
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------- HERO_POWER - DRUID
			// [TB_LOEA13_2] Ancient Power (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give each player a random card. It costs (0).
			// --------------------------------------------------------
			cards.Add("TB_LOEA13_2", new Power {
				// TODO [TB_LOEA13_2] Ancient Power && Test: Ancient Power_TB_LOEA13_2
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_MammothParty_hp001] Decorate (*) - COST:10 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Create *{0}* |4(decoration, decorations) for the Tavern.
			//       Progress: {1}/25
			// --------------------------------------------------------
			cards.Add("TB_MammothParty_hp001", new Power {
				// TODO [TB_MammothParty_hp001] Decorate && Test: Decorate_TB_MammothParty_hp001
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_MammothParty_hp002] Pelt (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal 3 damage to the Piñata.
			// --------------------------------------------------------
			cards.Add("TB_MammothParty_hp002", new Power {
				// TODO [TB_MammothParty_hp002] Pelt && Test: Pelt_TB_MammothParty_hp002
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_MechWar_Boss1_HeroPower] Hello! Hello! Hello! (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Give your lowest attack minion <b>Divine Shield</b> and <b>Taunt</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_FRIENDLY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TB_MechWar_Boss1_HeroPower", new Power {
				// TODO [TB_MechWar_Boss1_HeroPower] Hello! Hello! Hello! && Test: Hello! Hello! Hello!_TB_MechWar_Boss1_HeroPower
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_MechWar_Boss2_HeroPower] Boom Bot Jr. (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Deal 2 damage randomly split among all enemies.
			// --------------------------------------------------------
			cards.Add("TB_MechWar_Boss2_HeroPower", new Power {
				// TODO [TB_MechWar_Boss2_HeroPower] Boom Bot Jr. && Test: Boom Bot Jr._TB_MechWar_Boss2_HeroPower
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_SPT_BossHeroPower] Barracks (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a random Stormwind Soldier.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_BossHeroPower", new Power {
				// TODO [TB_SPT_BossHeroPower] Barracks && Test: Barracks_TB_SPT_BossHeroPower
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - INVALID
			// [TB_SPT_DPromoHP] Diabolical Powers (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Summon a random Imp.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 38981
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoHP", new Power {
				// TODO [TB_SPT_DPromoHP] Diabolical Powers && Test: Diabolical Powers_TB_SPT_DPromoHP
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_SPT_DPromoHP2] So Many... (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Whenever a Hell Bovine Dies, draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 38981
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoHP2", new Power {
				// TODO [TB_SPT_DPromoHP2] So Many... && Test: So Many..._TB_SPT_DPromoHP2
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TB_SPT_MTH_BossHeroPower] Party Barracks (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a random Stormwind Partygoer.
			// --------------------------------------------------------
			// GameTag:
			// - AI_MUST_PLAY = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_MTH_BossHeroPower", new Power {
				// TODO [TB_SPT_MTH_BossHeroPower] Party Barracks && Test: Party Barracks_TB_SPT_MTH_BossHeroPower
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TBA01_5] Wild Magic (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Add a random spell from any class to your hand. It costs (0).
			// --------------------------------------------------------
			cards.Add("TBA01_5", new Power {
				// TODO [TBA01_5] Wild Magic && Test: Wild Magic_TBA01_5
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- HERO_POWER - NEUTRAL
			// [TBA01_6] Molten Rage (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Summon a 5/1 Magma Rager.
			// --------------------------------------------------------
			cards.Add("TBA01_6", new Power {
				// TODO [TBA01_6] Molten Rage && Test: Molten Rage_TBA01_6
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------- HERO_POWER - ROGUE
			// [TP_Bling_HP2] Cash In (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Destroy your weapon, gaining a random one.
			// --------------------------------------------------------
			cards.Add("TP_Bling_HP2", new Power {
				// TODO [TP_Bling_HP2] Cash In && Test: Cash In_TP_Bling_HP2
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void DeathknightNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------ SPELL - DEATHKNIGHT
			// [FB_LK001] Soldiers of the Cold Dark (*) - COST:0 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			// Text: Draw 4 cards.
			// --------------------------------------------------------
			cards.Add("FB_LK001", new Power {
				// TODO [FB_LK001] Soldiers of the Cold Dark && Test: Soldiers of the Cold Dark_FB_LK001
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ SPELL - DEATHKNIGHT
			// [FB_LK006] To My Aid Underling! (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Summon a different Frozen Throne boss.
			//        <i> You aren't worth the Lich King's time.</i>
			// --------------------------------------------------------
			cards.Add("FB_LK006", new Power {
				// TODO [FB_LK006] To My Aid Underling! && Test: To My Aid Underling!_FB_LK006
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void DruidNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------ ENCHANTMENT - DRUID
			// [FB_LK_Druid_Ench_copy] Next Hero: Druid Ench Copy (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Druid cards to your deck.
			// --------------------------------------------------------
			// Entourage: CS2_017
			// --------------------------------------------------------
			cards.Add("FB_LK_Druid_Ench_copy", new Power {
				// TODO [FB_LK_Druid_Ench_copy] Next Hero: Druid Ench Copy && Test: Next Hero: Druid Ench Copy_FB_LK_Druid_Ench_copy
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - DRUID
			// [FB_TagTeam_Druid_Ench] Next Hero: Druid Ench (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Druid cards to your deck.
			// --------------------------------------------------------
			// Entourage: CS2_017
			// --------------------------------------------------------
			cards.Add("FB_TagTeam_Druid_Ench", new Power {
				// TODO [FB_TagTeam_Druid_Ench] Next Hero: Druid Ench && Test: Next Hero: Druid Ench_FB_TagTeam_Druid_Ench
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [FB_Champs_EX1_165] Druid of the Claw (*) - COST:5 [ATK:4/HP:4] 
			// - Fac: neutral, Set: tb, Rarity: common
			// --------------------------------------------------------
			// Text: [x]<b>Choose One -</b> Transform
			//       into a 4/4 with <b>Charge</b>;
			//       or a 4/6 with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_EX1_165", new Power {
				// TODO [FB_Champs_EX1_165] Druid of the Claw && Test: Druid of the Claw_FB_Champs_EX1_165
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [FB_Champs_EX1_165t1] Druid of the Claw (*) - COST:5 [ATK:4/HP:4] 
			// - Set: tb, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_EX1_165t1", new Power {
				// TODO [FB_Champs_EX1_165t1] Druid of the Claw && Test: Druid of the Claw_FB_Champs_EX1_165t1
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [FB_Champs_EX1_165t2] Druid of the Claw (*) - COST:5 [ATK:4/HP:6] 
			// - Set: tb, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_EX1_165t2", new Power {
				// TODO [FB_Champs_EX1_165t2] Druid of the Claw && Test: Druid of the Claw_FB_Champs_EX1_165t2
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [FB_Champs_EX1_166] Keeper of the Grove (*) - COST:4 [ATK:2/HP:4] 
			// - Fac: neutral, Set: tb, Rarity: rare
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Deal_2_damage; or <b>Silence</b> a minion.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			// RefTag:
			// - SILENCE = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_EX1_166", new Power {
				// TODO [FB_Champs_EX1_166] Keeper of the Grove && Test: Keeper of the Grove_FB_Champs_EX1_166
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [FB_Champs_EX1_tk9] Treant (*) - COST:2 [ATK:2/HP:2] 
			// - Fac: neutral, Set: tb, Rarity: common
			// --------------------------------------------------------
			// GameTag:
			// - CHARGE = 1
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_EX1_tk9", new Power {
				// TODO [FB_Champs_EX1_tk9] Treant && Test: Treant_FB_Champs_EX1_tk9
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [FB_Champs_NEW1_008] Ancient of Lore (*) - COST:7 [ATK:5/HP:5] 
			// - Set: tb, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Draw 2 cards; or Restore 5 Health.
			// --------------------------------------------------------
			// GameTag:
			// - CHOOSE_ONE = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("FB_Champs_NEW1_008", new Power {
				// TODO [FB_Champs_NEW1_008] Ancient of Lore && Test: Ancient of Lore_FB_Champs_NEW1_008
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- MINION - DRUID
			// [FB_Champs_OG_044a] Druid of the Claw (*) - COST:5 [ATK:4/HP:6] 
			// - Set: tb, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			//       <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_OG_044a", new Power {
				// TODO [FB_Champs_OG_044a] Druid of the Claw && Test: Druid of the Claw_FB_Champs_OG_044a
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [FB_Champs_EX1_165a] Cat Form (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			cards.Add("FB_Champs_EX1_165a", new Power {
				// TODO [FB_Champs_EX1_165a] Cat Form && Test: Cat Form_FB_Champs_EX1_165a
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [FB_Champs_EX1_165b] Bear Form (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: +2 Health and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("FB_Champs_EX1_165b", new Power {
				// TODO [FB_Champs_EX1_165b] Bear Form && Test: Bear Form_FB_Champs_EX1_165b
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [FB_Champs_EX1_169] Innervate (*) - COST:0 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			// Text: Gain 2 Mana Crystals this turn only.
			// --------------------------------------------------------
			cards.Add("FB_Champs_EX1_169", new Power {
				// TODO [FB_Champs_EX1_169] Innervate && Test: Innervate_FB_Champs_EX1_169
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [FB_Champs_EX1_571] Force of Nature (*) - COST:6 
			// - Fac: neutral, Set: tb, Rarity: epic
			// --------------------------------------------------------
			// Text: Summon three 2/2 Treants with
			//       <b>Charge</b> that die at the end of the turn.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_EX1_571", new Power {
				// TODO [FB_Champs_EX1_571] Force of Nature && Test: Force of Nature_FB_Champs_EX1_571
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [FB_Champs_NEW1_008a] Ancient Teachings (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Draw two cards.
			// --------------------------------------------------------
			cards.Add("FB_Champs_NEW1_008a", new Power {
				// TODO [FB_Champs_NEW1_008a] Ancient Teachings && Test: Ancient Teachings_FB_Champs_NEW1_008a
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [FB_Champs_NEW1_008b] Ancient Secrets (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Restore 5 Health.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("FB_Champs_NEW1_008b", new Power {
				// TODO [FB_Champs_NEW1_008b] Ancient Secrets && Test: Ancient Secrets_FB_Champs_NEW1_008b
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [FB_LK_Druid_copy] Druid (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Select Druid as your next class.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_LK_Druid_copy", new Power {
				// TODO [FB_LK_Druid_copy] Druid && Test: Druid_FB_LK_Druid_copy
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [TB_ClassRandom_Druid] Second Class: Druid (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Add Druid cards to your deck.
			// --------------------------------------------------------
			cards.Add("TB_ClassRandom_Druid", new Power {
				// TODO [TB_ClassRandom_Druid] Second Class: Druid && Test: Second Class: Druid_TB_ClassRandom_Druid
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - DRUID
			// [TB_TagTeam_Druid] Rumble in the Jungle (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Enter the jungle with giant beasts and darker things...
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_TagTeam_Druid", new Power {
				// TODO [TB_TagTeam_Druid] Rumble in the Jungle && Test: Rumble in the Jungle_TB_TagTeam_Druid
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void HunterNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - HUNTER
			// [FB_LK_Hunter_Ench_copy] Next Hero: Hunter Ench Copy (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Hunter cards to your deck.
			// --------------------------------------------------------
			// Entourage: DS1h_292
			// --------------------------------------------------------
			cards.Add("FB_LK_Hunter_Ench_copy", new Power {
				// TODO [FB_LK_Hunter_Ench_copy] Next Hero: Hunter Ench Copy && Test: Next Hero: Hunter Ench Copy_FB_LK_Hunter_Ench_copy
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - HUNTER
			// [FB_TagTeam_Hunter_Ench] Next Hero: Hunter Ench (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Hunter cards to your deck.
			// --------------------------------------------------------
			// Entourage: DS1h_292
			// --------------------------------------------------------
			cards.Add("FB_TagTeam_Hunter_Ench", new Power {
				// TODO [FB_TagTeam_Hunter_Ench] Next Hero: Hunter Ench && Test: Next Hero: Hunter Ench_FB_TagTeam_Hunter_Ench
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [FB_LK_Hunter_copy] Hunter (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Select Hunter as your next class.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_LK_Hunter_copy", new Power {
				// TODO [FB_LK_Hunter_copy] Hunter && Test: Hunter_FB_LK_Hunter_copy
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [TB_ClassRandom_Hunter] Second Class: Hunter (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Add Hunter cards to your deck.
			// --------------------------------------------------------
			cards.Add("TB_ClassRandom_Hunter", new Power {
				// TODO [TB_ClassRandom_Hunter] Second Class: Hunter && Test: Second Class: Hunter_TB_ClassRandom_Hunter
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - HUNTER
			// [TB_TagTeam_Hunter] Unleash the Beasts (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Release a stampede of beasts while hunting for the Marsh Queen!
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_TagTeam_Hunter", new Power {
				// TODO [TB_TagTeam_Hunter] Unleash the Beasts && Test: Unleash the Beasts_TB_TagTeam_Hunter
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void MageNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------- ENCHANTMENT - MAGE
			// [FB_LK_Mage_Ench_copy] Next Hero: Mage Ench Copy (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Mage cards to your deck.
			// --------------------------------------------------------
			// Entourage: CS2_034
			// --------------------------------------------------------
			cards.Add("FB_LK_Mage_Ench_copy", new Power {
				// TODO [FB_LK_Mage_Ench_copy] Next Hero: Mage Ench Copy && Test: Next Hero: Mage Ench Copy_FB_LK_Mage_Ench_copy
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------- ENCHANTMENT - MAGE
			// [FB_TagTeam_Mage_Ench] Next Hero: Mage Ench (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Mage cards to your deck.
			// --------------------------------------------------------
			// Entourage: CS2_034
			// --------------------------------------------------------
			cards.Add("FB_TagTeam_Mage_Ench", new Power {
				// TODO [FB_TagTeam_Mage_Ench] Next Hero: Mage Ench && Test: Next Hero: Mage Ench_FB_TagTeam_Mage_Ench
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------- ENCHANTMENT - MAGE
			// [TagTeamIceBlock] Tag Team Ice Block (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Your hero is <b>Immune</b> this turn.
			// --------------------------------------------------------
			cards.Add("TagTeamIceBlock", new Power {
				// TODO [TagTeamIceBlock] Tag Team Ice Block && Test: Tag Team Ice Block_TagTeamIceBlock
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [FB_LK002] Relentless March (*) - COST:3 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			// Text: Replace your deck with a fresh one.
			//       <i>Death does not feel fatigue</i>
			// --------------------------------------------------------
			cards.Add("FB_LK002", new Power {
				// TODO [FB_LK002] Relentless March && Test: Relentless March_FB_LK002
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [FB_LK_Mage_copy] Mage (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Select Mage as your next class.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_LK_Mage_copy", new Power {
				// TODO [FB_LK_Mage_copy] Mage && Test: Mage_FB_LK_Mage_copy
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [TB_ClassRandom_Mage] Second Class: Mage (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Add Mage cards to your deck.
			// --------------------------------------------------------
			cards.Add("TB_ClassRandom_Mage", new Power {
				// TODO [TB_ClassRandom_Mage] Second Class: Mage && Test: Second Class: Mage_TB_ClassRandom_Mage
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [TB_LevelUp_002] Fireblast (*) - COST:4 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Deal $6 damage. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("TB_LevelUp_002", new Power {
				// TODO [TB_LevelUp_002] Fireblast && Test: Fireblast_TB_LevelUp_002
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------- SPELL - MAGE
			// [TB_TagTeam_Mage] Elemental Secrets (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Guard your secrets and unleash elemental fury!
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_TagTeam_Mage", new Power {
				// TODO [TB_TagTeam_Mage] Elemental Secrets && Test: Elemental Secrets_TB_TagTeam_Mage
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void PaladinNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - PALADIN
			// [FB_LK_Paladin_Ench_copy] Next Hero: Paladin Ench Copy (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Paladin cards to your deck.
			// --------------------------------------------------------
			// Entourage: CS2_101
			// --------------------------------------------------------
			cards.Add("FB_LK_Paladin_Ench_copy", new Power {
				// TODO [FB_LK_Paladin_Ench_copy] Next Hero: Paladin Ench Copy && Test: Next Hero: Paladin Ench Copy_FB_LK_Paladin_Ench_copy
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - PALADIN
			// [FB_TagTeam_Paladin_Ench] Next Hero: Paladin Ench (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Paladin cards to your deck.
			// --------------------------------------------------------
			// Entourage: CS2_101
			// --------------------------------------------------------
			cards.Add("FB_TagTeam_Paladin_Ench", new Power {
				// TODO [FB_TagTeam_Paladin_Ench] Next Hero: Paladin Ench && Test: Next Hero: Paladin Ench_FB_TagTeam_Paladin_Ench
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [FB_LK_Paladin_copy] Paladin (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Select Paladin as your next class.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_LK_Paladin_copy", new Power {
				// TODO [FB_LK_Paladin_copy] Paladin && Test: Paladin_FB_LK_Paladin_copy
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [TB_ClassRandom_Paladin] Second Class: Paladin (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Add Paladin cards to your deck.
			// --------------------------------------------------------
			cards.Add("TB_ClassRandom_Paladin", new Power {
				// TODO [TB_ClassRandom_Paladin] Second Class: Paladin && Test: Second Class: Paladin_TB_ClassRandom_Paladin
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [TB_CoOpv3_200] Follow MY Rules! (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Change the Attack of all other minions to 1.
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_200", new Power {
				// TODO [TB_CoOpv3_200] Follow MY Rules! && Test: Follow MY Rules!_TB_CoOpv3_200
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - PALADIN
			// [TB_TagTeam_Paladin] Dark Light (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Bend the Light to your will, while you unleash the Apocalypse!
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_TagTeam_Paladin", new Power {
				// TODO [TB_TagTeam_Paladin] Dark Light && Test: Dark Light_TB_TagTeam_Paladin
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void PriestNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - PRIEST
			// [FB_LK_Priest_Ench_copy] Next Hero: Priest Ench Copy (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Priest cards to your deck.
			// --------------------------------------------------------
			// Entourage: CS1h_001
			// --------------------------------------------------------
			cards.Add("FB_LK_Priest_Ench_copy", new Power {
				// TODO [FB_LK_Priest_Ench_copy] Next Hero: Priest Ench Copy && Test: Next Hero: Priest Ench Copy_FB_LK_Priest_Ench_copy
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - PRIEST
			// [FB_TagTeam_Priest_Ench] Next Hero: Priest Ench (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Priest cards to your deck.
			// --------------------------------------------------------
			// Entourage: CS1h_001
			// --------------------------------------------------------
			cards.Add("FB_TagTeam_Priest_Ench", new Power {
				// TODO [FB_TagTeam_Priest_Ench] Next Hero: Priest Ench && Test: Next Hero: Priest Ench_FB_TagTeam_Priest_Ench
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [FB_LK_Priest_copy] Priest (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Select Priest as your next class.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_LK_Priest_copy", new Power {
				// TODO [FB_LK_Priest_copy] Priest && Test: Priest_FB_LK_Priest_copy
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [TB_ClassRandom_Priest] Second Class: Priest (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Add Priest cards to your deck.
			// --------------------------------------------------------
			cards.Add("TB_ClassRandom_Priest", new Power {
				// TODO [TB_ClassRandom_Priest] Second Class: Priest && Test: Second Class: Priest_TB_ClassRandom_Priest
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [TB_CoOpv3_002] Twisted Light (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Restore 30 health to Nefarian. Deal 30 damage to all other minions.
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_002", new Power {
				// TODO [TB_CoOpv3_002] Twisted Light && Test: Twisted Light_TB_CoOpv3_002
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [TB_Coopv3_102] Shadow or Light? (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Choose One -</b> Each player draws 2 cards; or Restore 8 Health to each hero.
			// --------------------------------------------------------
			cards.Add("TB_Coopv3_102", new Power {
				// TODO [TB_Coopv3_102] Shadow or Light? && Test: Shadow or Light?_TB_Coopv3_102
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [TB_Coopv3_102a] Secrets of Shadow (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Each player draws 2 cards.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_Coopv3_102a", new Power {
				// TODO [TB_Coopv3_102a] Secrets of Shadow && Test: Secrets of Shadow_TB_Coopv3_102a
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [TB_Coopv3_102b] Alms of Light (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Restore 8 Health to each hero.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_Coopv3_102b", new Power {
				// TODO [TB_Coopv3_102b] Alms of Light && Test: Alms of Light_TB_Coopv3_102b
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - PRIEST
			// [TB_TagTeam_Priest] Unbreakable (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Inspire</b> your minions, even in death.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_TagTeam_Priest", new Power {
				// TODO [TB_TagTeam_Priest] Unbreakable && Test: Unbreakable_TB_TagTeam_Priest
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void RogueNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------ ENCHANTMENT - ROGUE
			// [FB_LK_Rogue_Ench_copy] Next Hero: Rogue Ench Copy (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Rogue cards to your deck.
			// --------------------------------------------------------
			// Entourage: CS2_083b
			// --------------------------------------------------------
			cards.Add("FB_LK_Rogue_Ench_copy", new Power {
				// TODO [FB_LK_Rogue_Ench_copy] Next Hero: Rogue Ench Copy && Test: Next Hero: Rogue Ench Copy_FB_LK_Rogue_Ench_copy
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [FB_TagTeam_Rogue_Ench] Next Hero: Rogue Ench (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Rogue cards to your deck.
			// --------------------------------------------------------
			// Entourage: CS2_083b
			// --------------------------------------------------------
			cards.Add("FB_TagTeam_Rogue_Ench", new Power {
				// TODO [FB_TagTeam_Rogue_Ench] Next Hero: Rogue Ench && Test: Next Hero: Rogue Ench_FB_TagTeam_Rogue_Ench
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [TB_BlingBrawl_Hero1e] Sharpened (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: +1 Attack
			// --------------------------------------------------------
			cards.Add("TB_BlingBrawl_Hero1e", new Power {
				// TODO [TB_BlingBrawl_Hero1e] Sharpened && Test: Sharpened_TB_BlingBrawl_Hero1e
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [TB_ShadowReflection_001e] Shadow Reflection (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Always copy your last played card.
			// --------------------------------------------------------
			cards.Add("TB_ShadowReflection_001e", new Power {
				// TODO [TB_ShadowReflection_001e] Shadow Reflection && Test: Shadow Reflection_TB_ShadowReflection_001e
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [TB_Superfriends001e] Facilitated (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: The next legend you cast this turn costs (3) less.
			// --------------------------------------------------------
			cards.Add("TB_Superfriends001e", new Power {
				// TODO [TB_Superfriends001e] Facilitated && Test: Facilitated_TB_Superfriends001e
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------ ENCHANTMENT - ROGUE
			// [TB_Superfriends002e] Draw Offensive Play (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Draw Offensive Play on first, third, and fifth turn
			// --------------------------------------------------------
			cards.Add("TB_Superfriends002e", new Power {
				// TODO [TB_Superfriends002e] Draw Offensive Play && Test: Draw Offensive Play_TB_Superfriends002e
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [FB_Champs_CS2_233] Blade Flurry (*) - COST:2 
			// - Fac: neutral, Set: tb, Rarity: rare
			// --------------------------------------------------------
			// Text: Destroy your weapon and deal its damage to all enemies. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_WEAPON_EQUIPPED = 0
			// --------------------------------------------------------
			cards.Add("FB_Champs_CS2_233", new Power {
				// TODO [FB_Champs_CS2_233] Blade Flurry && Test: Blade Flurry_FB_Champs_CS2_233
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [FB_LK_Rogue_copy] Rogue (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Select Rogue as your next class.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_LK_Rogue_copy", new Power {
				// TODO [FB_LK_Rogue_copy] Rogue && Test: Rogue_FB_LK_Rogue_copy
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [TB_ClassRandom_Rogue] Second Class: Rogue (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Add Rogue cards to your deck.
			// --------------------------------------------------------
			cards.Add("TB_ClassRandom_Rogue", new Power {
				// TODO [TB_ClassRandom_Rogue] Second Class: Rogue && Test: Second Class: Rogue_TB_ClassRandom_Rogue
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [TB_CoOpv3_201] Cast from Shadow (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Destroy all undamaged minions. Return the rest to their owner's hand.
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_201", new Power {
				// TODO [TB_CoOpv3_201] Cast from Shadow && Test: Cast from Shadow_TB_CoOpv3_201
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [TB_ShadowReflection_001] Shadow Reflection (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Each time you play a card, transform this into a copy of it until the end of your turn.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MUST_PLAY_OTHER_CARD_FIRST = 0
			// --------------------------------------------------------
			cards.Add("TB_ShadowReflection_001", new Power {
				// TODO [TB_ShadowReflection_001] Shadow Reflection && Test: Shadow Reflection_TB_ShadowReflection_001
				InfoCardId = "TB_ShadowReflection_001e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ------------------------------------------ SPELL - ROGUE
			// [TB_TagTeam_Rogue] The Saint (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Assassinate with blinding speed!
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_TagTeam_Rogue", new Power {
				// TODO [TB_TagTeam_Rogue] The Saint && Test: The Saint_TB_TagTeam_Rogue
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void ShamanNonCollect(IDictionary<string, Power> cards)
		{
			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [FB_LK_Shaman_Ench_copy] Next Hero: Shaman Ench Copy (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Shaman cards to your deck.
			// --------------------------------------------------------
			// Entourage: CS2_049
			// --------------------------------------------------------
			cards.Add("FB_LK_Shaman_Ench_copy", new Power {
				// TODO [FB_LK_Shaman_Ench_copy] Next Hero: Shaman Ench Copy && Test: Next Hero: Shaman Ench Copy_FB_LK_Shaman_Ench_copy
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------- ENCHANTMENT - SHAMAN
			// [FB_TagTeam_Shaman_Ench] Next Hero: Shaman Ench (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Shaman cards to your deck.
			// --------------------------------------------------------
			// Entourage: CS2_049
			// --------------------------------------------------------
			cards.Add("FB_TagTeam_Shaman_Ench", new Power {
				// TODO [FB_TagTeam_Shaman_Ench] Next Hero: Shaman Ench && Test: Next Hero: Shaman Ench_FB_TagTeam_Shaman_Ench
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [FB_Champs_EX1_246] Hex (*) - COST:3 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			// Text: Transform a minion into a 0/1 Frog with <b>Taunt</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_EX1_246", new Power {
				// TODO [FB_Champs_EX1_246] Hex && Test: Hex_FB_Champs_EX1_246
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [FB_LK_Shaman_copy] Shaman (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Select Shaman as your next class.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_LK_Shaman_copy", new Power {
				// TODO [FB_LK_Shaman_copy] Shaman && Test: Shaman_FB_LK_Shaman_copy
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [TB_ClassRandom_Shaman] Second Class: Shaman (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Add Shaman cards to your deck.
			// --------------------------------------------------------
			cards.Add("TB_ClassRandom_Shaman", new Power {
				// TODO [TB_ClassRandom_Shaman] Second Class: Shaman && Test: Second Class: Shaman_TB_ClassRandom_Shaman
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [TB_CoOpv3_006] Elemental Eruption (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Deal 4-6 damage to all other minions.
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_006", new Power {
				// TODO [TB_CoOpv3_006] Elemental Eruption && Test: Elemental Eruption_TB_CoOpv3_006
				//PowerTask = null,
				//Trigger = null,
			});

			// ----------------------------------------- SPELL - SHAMAN
			// [TB_TagTeam_Shaman] Totems Versus Secrets (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Uncover your adversary's secrets, while assembling your totem army
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_TagTeam_Shaman", new Power {
				// TODO [TB_TagTeam_Shaman] Totems Versus Secrets && Test: Totems Versus Secrets_TB_TagTeam_Shaman
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- WEAPON - SHAMAN
			// [FB_Champs_KAR_063] Spirit Claws (*) - COST:1 [ATK:1/HP:0] 
			// - Set: tb, Rarity: common
			// --------------------------------------------------------
			// Text: [x]Has +2 Attack while you
			//       have <b>Spell Damage</b>.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 3
			// --------------------------------------------------------
			// RefTag:
			// - SPELLPOWER = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_KAR_063", new Power {
				// TODO [FB_Champs_KAR_063] Spirit Claws && Test: Spirit Claws_FB_Champs_KAR_063
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void WarlockNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [FB_LK_Warlock_Ench_copy] Next Hero: Warlock Ench Copy (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Warlock cards to your deck.
			// --------------------------------------------------------
			// Entourage: CS2_056
			// --------------------------------------------------------
			cards.Add("FB_LK_Warlock_Ench_copy", new Power {
				// TODO [FB_LK_Warlock_Ench_copy] Next Hero: Warlock Ench Copy && Test: Next Hero: Warlock Ench Copy_FB_LK_Warlock_Ench_copy
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - WARLOCK
			// [FB_TagTeam_Warlock_Ench] Next Hero: Warlock Ench (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Warlock cards to your deck.
			// --------------------------------------------------------
			// Entourage: CS2_056
			// --------------------------------------------------------
			cards.Add("FB_TagTeam_Warlock_Ench", new Power {
				// TODO [FB_TagTeam_Warlock_Ench] Next Hero: Warlock Ench && Test: Next Hero: Warlock Ench_FB_TagTeam_Warlock_Ench
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [FB_Champs_EX1_308] Soulfire (*) - COST:0 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			// Text: [x]Deal $4 damage.
			//       Discard a random card. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("FB_Champs_EX1_308", new Power {
				// TODO [FB_Champs_EX1_308] Soulfire && Test: Soulfire_FB_Champs_EX1_308
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [FB_LK_Warlock_copy] Warlock (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Select Warlock as your next class.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_LK_Warlock_copy", new Power {
				// TODO [FB_LK_Warlock_copy] Warlock && Test: Warlock_FB_LK_Warlock_copy
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [TB_ClassRandom_Warlock] Second Class: Warlock (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Add Warlock cards to your deck.
			// --------------------------------------------------------
			cards.Add("TB_ClassRandom_Warlock", new Power {
				// TODO [TB_ClassRandom_Warlock] Second Class: Warlock && Test: Second Class: Warlock_TB_ClassRandom_Warlock
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [TB_SPT_DpromoEX1_312] Twisting Nether? (*) - COST:8 
			// - Fac: neutral, Set: tb, Rarity: epic
			// --------------------------------------------------------
			// Text: This doesn't look like Twisting Nether...
			// --------------------------------------------------------
			cards.Add("TB_SPT_DpromoEX1_312", new Power {
				// TODO [TB_SPT_DpromoEX1_312] Twisting Nether? && Test: Twisting Nether?_TB_SPT_DpromoEX1_312
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARLOCK
			// [TB_TagTeam_Warlock] Death Becomes (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Summon monstrous demons and burn away the enemy's weapons
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_TagTeam_Warlock", new Power {
				// TODO [TB_TagTeam_Warlock] Death Becomes && Test: Death Becomes_TB_TagTeam_Warlock
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void WarriorNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [FB_LK_Warrior_Ench_copy] Next Hero: Warrior Ench Copy (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Warrior cards to your deck.
			// --------------------------------------------------------
			// Entourage: CS2_102
			// --------------------------------------------------------
			cards.Add("FB_LK_Warrior_Ench_copy", new Power {
				// TODO [FB_LK_Warrior_Ench_copy] Next Hero: Warrior Ench Copy && Test: Next Hero: Warrior Ench Copy_FB_LK_Warrior_Ench_copy
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [FB_TagTeam_Warrior_Ench] Next Hero: Warrior Ench (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Add Warrior cards to your deck.
			// --------------------------------------------------------
			// Entourage: CS2_102
			// --------------------------------------------------------
			cards.Add("FB_TagTeam_Warrior_Ench", new Power {
				// TODO [FB_TagTeam_Warrior_Ench] Next Hero: Warrior Ench && Test: Next Hero: Warrior Ench_FB_TagTeam_Warrior_Ench
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - WARRIOR
			// [TB_MP_01e] Charge! (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Has <b>Charge</b>
			// --------------------------------------------------------
			cards.Add("TB_MP_01e", new Power {
				// TODO [TB_MP_01e] Charge! && Test: Charge!_TB_MP_01e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [FB_Champs_CS2_108] Execute (*) - COST:1 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			// Text: Destroy a damaged enemy minion.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_ENEMY_TARGET = 0
			// - REQ_DAMAGED_TARGET = 0
			// --------------------------------------------------------
			cards.Add("FB_Champs_CS2_108", new Power {
				// TODO [FB_Champs_CS2_108] Execute && Test: Execute_FB_Champs_CS2_108
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [FB_LK_Warrior_copy] Warrior (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Select Warrior as your next class.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_LK_Warrior_copy", new Power {
				// TODO [FB_LK_Warrior_copy] Warrior && Test: Warrior_FB_LK_Warrior_copy
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [TB_ClassRandom_Warrior] Second Class: Warrior (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Add Warrior cards to your deck.
			// --------------------------------------------------------
			cards.Add("TB_ClassRandom_Warrior", new Power {
				// TODO [TB_ClassRandom_Warrior] Second Class: Warrior && Test: Second Class: Warrior_TB_ClassRandom_Warrior
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [TB_SPT_DPromoSecre8] Visions of the Assassin (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your opponent plays a minion with <b>Stealth</b>, All minions equip a dagger.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSecre8", new Power {
				// TODO [TB_SPT_DPromoSecre8] Visions of the Assassin && Test: Visions of the Assassin_TB_SPT_DPromoSecre8
				InfoCardId = "TB_SPT_DPromoSecre8e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [TB_SPT_DPromoSecret1] Visions of the Barbarian (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your opponent plays a minion with <b>Charge</b>, THUNDER FURY!
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSecret1", new Power {
				// TODO [TB_SPT_DPromoSecret1] Visions of the Barbarian && Test: Visions of the Barbarian_TB_SPT_DPromoSecret1
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [TB_SPT_DPromoSecret10] Visions of Hate (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When both heroes have 15 or less Health, BRAWL!
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSecret10", new Power {
				// TODO [TB_SPT_DPromoSecret10] Visions of Hate && Test: Visions of Hate_TB_SPT_DPromoSecret10
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [TB_SPT_DPromoSecret2] Visions of the Crusader (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your opponent plays a minion with <b>Taunt</b>, change all minions'
			//       attacks to 1.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSecret2", new Power {
				// TODO [TB_SPT_DPromoSecret2] Visions of the Crusader && Test: Visions of the Crusader_TB_SPT_DPromoSecret2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [TB_SPT_DPromoSecret3] Visions of Valor (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your opponent plays a Legendary minion, give all minions <b>Windfury</b>
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSecret3", new Power {
				// TODO [TB_SPT_DPromoSecret3] Visions of Valor && Test: Visions of Valor_TB_SPT_DPromoSecret3
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [TB_SPT_DPromoSecret4] Visions of Fate (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your opponent takes lethal damage... save him.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSecret4", new Power {
				// TODO [TB_SPT_DPromoSecret4] Visions of Fate && Test: Visions of Fate_TB_SPT_DPromoSecret4
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [TB_SPT_DPromoSecret5] Visions of the Amazon (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your opponent plays a minion with <b>Battlecry</b>, Summon a Mirror Image for both players.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSecret5", new Power {
				// TODO [TB_SPT_DPromoSecret5] Visions of the Amazon && Test: Visions of the Amazon_TB_SPT_DPromoSecret5
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [TB_SPT_DPromoSecret6] Visions of the Sorcerer (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your opponent plays a minion with <b>Spell Damage</b>, Summon 2 Guardians.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSecret6", new Power {
				// TODO [TB_SPT_DPromoSecret6] Visions of the Sorcerer && Test: Visions of the Sorcerer_TB_SPT_DPromoSecret6
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [TB_SPT_DPromoSecret7] Visions of the Necromancer (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your opponent plays a card with <b>Deathrattle</b>, destroy it.
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSecret7", new Power {
				// TODO [TB_SPT_DPromoSecret7] Visions of the Necromancer && Test: Visions of the Necromancer_TB_SPT_DPromoSecret7
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [TB_SPT_DPromoSecret9] Visions of Knowledge (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Secret:</b> When your opponent's hand has 9 or more cards, reduce the cost of all cards in both hands to (1).
			// --------------------------------------------------------
			// GameTag:
			// - SECRET = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSecret9", new Power {
				// TODO [TB_SPT_DPromoSecret9] Visions of Knowledge && Test: Visions of Knowledge_TB_SPT_DPromoSecret9
				InfoCardId = "TB_SPT_DPromoSecret9e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - WARRIOR
			// [TB_TagTeam_Warrior] The Rock (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Enrage your allies, while wielding weapons at your foes!
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_TagTeam_Warrior", new Power {
				// TODO [TB_TagTeam_Warrior] The Rock && Test: The Rock_TB_TagTeam_Warrior
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - WARRIOR
			// [FB_Champs_CS2_106] Fiery War Axe (*) - COST:2 [ATK:3/HP:0] 
			// - Fac: neutral, Set: tb, Rarity: free
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("FB_Champs_CS2_106", new Power {
				// TODO [FB_Champs_CS2_106] Fiery War Axe && Test: Fiery War Axe_FB_Champs_CS2_106
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void DreamNonCollect(IDictionary<string, Power> cards)
		{
			// ------------------------------------ ENCHANTMENT - DREAM
			// [TB_MP_02e] Repurposed (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Draw a card.
			// --------------------------------------------------------
			cards.Add("TB_MP_02e", new Power {
				// TODO [TB_MP_02e] Repurposed && Test: Repurposed_TB_MP_02e
				//PowerTask = null,
				//Trigger = null,
			});

		}

		private static void NeutralNonCollect(IDictionary<string, Power> cards)
		{
			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BRMC_100e] Living Bomb (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: On Ragnaros' turn, deal 5 damage to this side of the board.
			// --------------------------------------------------------
			cards.Add("BRMC_100e", new Power {
				// TODO [BRMC_100e] Living Bomb && Test: Living Bomb_BRMC_100e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BRMC_86e] I Hear You... (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("BRMC_86e", new Power {
				// TODO [BRMC_86e] I Hear You... && Test: I Hear You..._BRMC_86e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BRMC_97e] Burning Adrenaline (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Costs (2) less.
			// --------------------------------------------------------
			cards.Add("BRMC_97e", new Power {
				// TODO [BRMC_97e] Burning Adrenaline && Test: Burning Adrenaline_BRMC_97e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [BRMC_98e] Dragonlust (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: +3 Attack.
			// --------------------------------------------------------
			cards.Add("BRMC_98e", new Power {
				// TODO [BRMC_98e] Dragonlust && Test: Dragonlust_BRMC_98e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_BuildABrawl001] Innkeeper Tools - Build A Brawl (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Play the Brawl as normal or Build a new brawl
			// --------------------------------------------------------
			// Entourage: FB_BuildABrawl001a, FB_BuildABrawl001b, FB_BuildABrawl001c, FB_BuildABrawl003c
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl001", new Power {
				// TODO [FB_BuildABrawl001] Innkeeper Tools - Build A Brawl && Test: Innkeeper Tools - Build A Brawl_FB_BuildABrawl001
				InfoCardId = "FB_BuildABrawl001a_ench",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_BuildABrawl001a_ench] By the Power of Ragnaros! Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Each turn reduce the cost of all cards by (1).
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl001a_ench", new Power {
				// TODO [FB_BuildABrawl001a_ench] By the Power of Ragnaros! Enchant && Test: By the Power of Ragnaros! Enchant_FB_BuildABrawl001a_ench
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_BuildABrawl001b_ench] Randomonium Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Each turn randomize the cost of all cards in your hand.
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl001b_ench", new Power {
				// TODO [FB_BuildABrawl001b_ench] Randomonium Enchant && Test: Randomonium Enchant_FB_BuildABrawl001b_ench
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_BuildABrawl001c_ench] Battle of Tol Barad Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: After a minion is played add a spell of the same mana cost to your hand. 
			//        It costs (0).
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl001c_ench", new Power {
				// TODO [FB_BuildABrawl001c_ench] Battle of Tol Barad Enchant && Test: Battle of Tol Barad Enchant_FB_BuildABrawl001c_ench
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_BuildABrawl002] Innkeeper Tools - Build A Brawl 2 (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Second Tier of Choices for Build A Brawl
			// --------------------------------------------------------
			// Entourage: FB_BuildABrawl002a, FB_BuildABrawl002b, FB_BuildABrawl002c, FB_BuildABrawl003b
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl002", new Power {
				// TODO [FB_BuildABrawl002] Innkeeper Tools - Build A Brawl 2 && Test: Innkeeper Tools - Build A Brawl 2_FB_BuildABrawl002
				InfoCardId = "FB_BuildABrawl002a_ench",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_BuildABrawl002a_ench] Great Summoner Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Spells summon minions of the same mana cost.
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl002a_ench", new Power {
				// TODO [FB_BuildABrawl002a_ench] Great Summoner Enchant && Test: Great Summoner Enchant_FB_BuildABrawl002a_ench
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_BuildABrawl002b_ench] Masked Ball Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: All minions gain <b>Deathrattle:</b> Summon a minion that costs (2) less.
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl002b_ench", new Power {
				// TODO [FB_BuildABrawl002b_ench] Masked Ball Enchant && Test: Masked Ball Enchant_FB_BuildABrawl002b_ench
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_BuildABrawl002c_ench] Servant of Yogg Saron Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: All minons cast a random spell at a random target when played.
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl002c_ench", new Power {
				// TODO [FB_BuildABrawl002c_ench] Servant of Yogg Saron Enchant && Test: Servant of Yogg Saron Enchant_FB_BuildABrawl002c_ench
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_BuildABrawl003] Innkeeper Tools - Build A Brawl 3 (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Third Tier of Choices for Build A Brawl
			// --------------------------------------------------------
			// Entourage: 00000011-91c8-41bf-87c6-63491203f862, FB_BuildABrawl003b, FB_BuildABrawl003c
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl003", new Power {
				// TODO [FB_BuildABrawl003] Innkeeper Tools - Build A Brawl 3 && Test: Innkeeper Tools - Build A Brawl 3_FB_BuildABrawl003
				InfoCardId = "FB_BuildABrawl003b_ench",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_BuildABrawl003b_ench] Clash of the Minions Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: All minions gain <b>Charge</b> and <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl003b_ench", new Power {
				// TODO [FB_BuildABrawl003b_ench] Clash of the Minions Enchant && Test: Clash of the Minions Enchant_FB_BuildABrawl003b_ench
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_BuildABrawl003c_ench] Blood Magic Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: All spells cost health instead of mana
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl003c_ench", new Power {
				// TODO [FB_BuildABrawl003c_ench] Blood Magic Enchant && Test: Blood Magic Enchant_FB_BuildABrawl003c_ench
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_BuildABrawl_Tools_ench] Build-A-Brawl Innkeeper Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Choose a new blend of Tavern Brawls for your Fireside Gathering.
			// --------------------------------------------------------
			// Entourage: FB_IKC_SetupNo, FB_BuildABrawl_Tools_reset
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl_Tools_ench", new Power {
				// TODO [FB_BuildABrawl_Tools_ench] Build-A-Brawl Innkeeper Enchant && Test: Build-A-Brawl Innkeeper Enchant_FB_BuildABrawl_Tools_ench
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_Champs_FP1_028e] Darkness Calls (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("FB_Champs_FP1_028e", new Power {
				// TODO [FB_Champs_FP1_028e] Darkness Calls && Test: Darkness Calls_FB_Champs_FP1_028e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_Champs_SetEvent] Set Mission Event (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Increased stats.
			// --------------------------------------------------------
			cards.Add("FB_Champs_SetEvent", new Power {
				// TODO [FB_Champs_SetEvent] Set Mission Event && Test: Set Mission Event_FB_Champs_SetEvent
				InfoCardId = "FB_Champs_SetEvent_copy",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_Champs_SetEvent_copy] Add FSG Score Screen (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("FB_Champs_SetEvent_copy", new Power {
				// TODO [FB_Champs_SetEvent_copy] Add FSG Score Screen && Test: Add FSG Score Screen_FB_Champs_SetEvent_copy
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_Champs_SetUp_Ench] Champs Setup (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("FB_Champs_SetUp_Ench", new Power {
				// TODO [FB_Champs_SetUp_Ench] Champs Setup && Test: Champs Setup_FB_Champs_SetUp_Ench
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_ELO001] Innkeeper Tools - ELO (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Reset the brawl or play as normal
			// --------------------------------------------------------
			// Entourage: FB_ELO001a, FB_ELO001b
			// --------------------------------------------------------
			cards.Add("FB_ELO001", new Power {
				// TODO [FB_ELO001] Innkeeper Tools - ELO && Test: Innkeeper Tools - ELO_FB_ELO001
				InfoCardId = "FB_ELO001bench",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_ELO001bench] ELO Reset Confirmation (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: FB_ELO001c, FB_ELO001d
			// --------------------------------------------------------
			cards.Add("FB_ELO001bench", new Power {
				// TODO [FB_ELO001bench] ELO Reset Confirmation && Test: ELO Reset Confirmation_FB_ELO001bench
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_ELO002] Competitive Spirits (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Gain an advantage against your opponent.
			// --------------------------------------------------------
			// Entourage: FB_ELO002a, FB_ELO002b, FB_ELO002c
			// --------------------------------------------------------
			cards.Add("FB_ELO002", new Power {
				// TODO [FB_ELO002] Competitive Spirits && Test: Competitive Spirits_FB_ELO002
				InfoCardId = "FB_ELO002_copy",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_ELO002_copy] Greater Competitive Spirits (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Gain an advantage against your opponent.
			// --------------------------------------------------------
			// Entourage: FB_ELO002a_copy, FB_ELO002b_copy, FB_ELO002c_copy
			// --------------------------------------------------------
			cards.Add("FB_ELO002_copy", new Power {
				// TODO [FB_ELO002_copy] Greater Competitive Spirits && Test: Greater Competitive Spirits_FB_ELO002_copy
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_ELO002a_ench] Spirit of Heroism (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Reduce the cost of your Hero Power by (1).
			// --------------------------------------------------------
			cards.Add("FB_ELO002a_ench", new Power {
				// TODO [FB_ELO002a_ench] Spirit of Heroism && Test: Spirit of Heroism_FB_ELO002a_ench
				InfoCardId = "FB_ELO002a_ench_copy",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_ELO002a_ench_copy] Greater Spirit of Heroism (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Replace your starting Hero Power with a better one. It costs (0)
			// --------------------------------------------------------
			cards.Add("FB_ELO002a_ench_copy", new Power {
				// TODO [FB_ELO002a_ench_copy] Greater Spirit of Heroism && Test: Greater Spirit of Heroism_FB_ELO002a_ench_copy
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_ELO002b_ench] Spirit of Wisdom (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Reduce the Cost of all spells in your deck and hand by (1).
			// --------------------------------------------------------
			cards.Add("FB_ELO002b_ench", new Power {
				// TODO [FB_ELO002b_ench] Spirit of Wisdom && Test: Spirit of Wisdom_FB_ELO002b_ench
				InfoCardId = "FB_ELO002b_ench_copy",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_ELO002b_ench_copy] Greater Spirit of Wisdom (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Reduce the Cost of all spells in your deck and hand by (2).
			// --------------------------------------------------------
			cards.Add("FB_ELO002b_ench_copy", new Power {
				// TODO [FB_ELO002b_ench_copy] Greater Spirit of Wisdom && Test: Greater Spirit of Wisdom_FB_ELO002b_ench_copy
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_ELO002c_ench] Spirit of Strength (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Give all minions in your deck and hand +1 Attack.
			// --------------------------------------------------------
			cards.Add("FB_ELO002c_ench", new Power {
				// TODO [FB_ELO002c_ench] Spirit of Strength && Test: Spirit of Strength_FB_ELO002c_ench
				InfoCardId = "FB_ELO002c_ench_copy",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_ELO002c_ench_copy] Greater Spirit of Strength (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Give all minions in your deck and hand +2 Attack.
			// --------------------------------------------------------
			cards.Add("FB_ELO002c_ench_copy", new Power {
				// TODO [FB_ELO002c_ench_copy] Greater Spirit of Strength && Test: Greater Spirit of Strength_FB_ELO002c_ench_copy
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_IKC_AllStar_Setup_Ench] Innkeepers Choice All-Star Squad Setup (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("FB_IKC_AllStar_Setup_Ench", new Power {
				// TODO [FB_IKC_AllStar_Setup_Ench] Innkeepers Choice All-Star Squad Setup && Test: Innkeepers Choice All-Star Squad Setup_FB_IKC_AllStar_Setup_Ench
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_IKC_KeepOld_Ench] Innkeepers Choice Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("FB_IKC_KeepOld_Ench", new Power {
				// TODO [FB_IKC_KeepOld_Ench] Innkeepers Choice Enchant && Test: Innkeepers Choice Enchant_FB_IKC_KeepOld_Ench
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_IKC_KeepSetUp_Ench] Innkeepers Choice Setup (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("FB_IKC_KeepSetUp_Ench", new Power {
				// TODO [FB_IKC_KeepSetUp_Ench] Innkeepers Choice Setup && Test: Innkeepers Choice Setup_FB_IKC_KeepSetUp_Ench
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_LK003] Check for Hero Death in Lich King Raid (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			cards.Add("FB_LK003", new Power {
				// TODO [FB_LK003] Check for Hero Death in Lich King Raid && Test: Check for Hero Death in Lich King Raid_FB_LK003
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_LK009] Swap Hero With Death Knight (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("FB_LK009", new Power {
				// TODO [FB_LK009] Swap Hero With Death Knight && Test: Swap Hero With Death Knight_FB_LK009
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_LK_GetClass_copy] Discover Next Class Copy (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Entourage: FB_LK_Warrior_copy, FB_LK_Druid_copy, FB_LK_Hunter_copy, FB_LK_Mage_copy, FB_LK_Paladin_copy, FB_LK_Priest_copy, FB_LK_Rogue_copy, FB_LK_Shaman_copy, FB_LK_Warlock_copy
			// --------------------------------------------------------
			cards.Add("FB_LK_GetClass_copy", new Power {
				// TODO [FB_LK_GetClass_copy] Discover Next Class Copy && Test: Discover Next Class Copy_FB_LK_GetClass_copy
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_LK_WaitForDiscover] Wait for Discover (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			cards.Add("FB_LK_WaitForDiscover", new Power {
				// TODO [FB_LK_WaitForDiscover] Wait for Discover && Test: Wait for Discover_FB_LK_WaitForDiscover
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_LKStats001] Innkeeper Tools (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Fight the Lich King or make modifications to his health.
			// --------------------------------------------------------
			// Entourage: FB_LKStats001a, FB_LKStats002
			// --------------------------------------------------------
			cards.Add("FB_LKStats001", new Power {
				// TODO [FB_LKStats001] Innkeeper Tools && Test: Innkeeper Tools_FB_LKStats001
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_LKStats002ench] Lich King Modifications Copy (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: FB_LKStats002a, FB_LKStats002b, FB_LKStats002c
			// --------------------------------------------------------
			cards.Add("FB_LKStats002ench", new Power {
				// TODO [FB_LKStats002ench] Lich King Modifications Copy && Test: Lich King Modifications Copy_FB_LKStats002ench
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [FB_TagTeam_WaitForDiscover] Wait for Discover (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			cards.Add("FB_TagTeam_WaitForDiscover", new Power {
				// TODO [FB_TagTeam_WaitForDiscover] Wait for Discover && Test: Wait for Discover_FB_TagTeam_WaitForDiscover
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [HRW02_1e] Overclock (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Increased Attack.
			// --------------------------------------------------------
			cards.Add("HRW02_1e", new Power {
				// TODO [HRW02_1e] Overclock && Test: Overclock_HRW02_1e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [KARA_13_19e] Saddened (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Can't attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("KARA_13_19e", new Power {
				// TODO [KARA_13_19e] Saddened && Test: Saddened_KARA_13_19e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_001] Boss HP Swapper (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: BRMA14_10, BRMA14_10H, BRMA09_4, BRMA09_4H, BRMA17_5, BRMA17_5H, NAX15_04, NAX15_04H, NAX12_02, NAX12_02H, BRM_027p, BRM_027pH, BRMA09_5, BRMA09_5H, BRMA16_2, BRMA16_2H, NAX5_02, NAX5_02H, BRMA11_2, BRMA11_2H, BRMA17_8, BRMA17_8H, NAX15_02, NAX15_02H, NAX14_02, NAX8_02, NAX8_02H, NAX10_03, NAX10_03H, BRMA05_2, BRMA05_2H, BRMA02_2, BRMA02_2H, BRMA04_2, BRMA07_2, BRMA07_2H, NAX6_02, NAX6_02H, BRMA09_2, BRMA09_2H, BRMA01_2, BRMA01_2H, NAX11_02, NAX11_02H, NAX13_02, NAX2_03, NAX2_03H, NAX1_04, NAX1h_04, BRMA06_2, BRMA06_2H, BRMA10_3, BRMA10_3H, NAX7_03, NAX7_03H, NAX9_06, NAX3_02, NAX3_02H, BRMA13_4, BRMA13_4H
			// --------------------------------------------------------
			cards.Add("TB_001", new Power {
				// TODO [TB_001] Boss HP Swapper && Test: Boss HP Swapper_TB_001
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_006e] Big Banana (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Has +2/+2.
			// --------------------------------------------------------
			cards.Add("TB_006e", new Power {
				// TODO [TB_006e] Big Banana && Test: Big Banana_TB_006e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_007e] Deviate Switch (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Attack and Health have been swapped by Deviate Banana.
			// --------------------------------------------------------
			cards.Add("TB_007e", new Power {
				// TODO [TB_007e] Deviate Switch && Test: Deviate Switch_TB_007e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_009] Create 15 Secrets (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: FP1_020, EX1_287, FP1_018, EX1_610, EX1_132, EX1_611, EX1_289, EX1_295, EX1_294, EX1_533, EX1_130, EX1_136, EX1_379, EX1_554, EX1_609, tt_010, EX1_594
			// --------------------------------------------------------
			cards.Add("TB_009", new Power {
				// TODO [TB_009] Create 15 Secrets && Test: Create 15 Secrets_TB_009
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_010] Deckbuilding Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_010", new Power {
				// TODO [TB_010] Deckbuilding Enchant && Test: Deckbuilding Enchant_TB_010
				InfoCardId = "TB_010e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_010e] Choose One of Three (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_010e", new Power {
				// TODO [TB_010e] Choose One of Three && Test: Choose One of Three_TB_010e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_013] Player Choice Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_013", new Power {
				// TODO [TB_013] Player Choice Enchant && Test: Player Choice Enchant_TB_013
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_100th_001] Valeera's Bag Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Playing a spell summons a minion of that type.
			// --------------------------------------------------------
			cards.Add("TB_100th_001", new Power {
				// TODO [TB_100th_001] Valeera's Bag Enchant && Test: Valeera's Bag Enchant_TB_100th_001
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_100th_BananaPlayerEnchant] Bananas on Death (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Spawn Banana
			// --------------------------------------------------------
			cards.Add("TB_100th_BananaPlayerEnchant", new Power {
				// TODO [TB_100th_BananaPlayerEnchant] Bananas on Death && Test: Bananas on Death_TB_100th_BananaPlayerEnchant
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_AllMinionsTauntCharge] Give Taunt and Charge (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: This minion is granted <b>Taunt</b> and <b>Charge</b>.
			// --------------------------------------------------------
			cards.Add("TB_AllMinionsTauntCharge", new Power {
				// TODO [TB_AllMinionsTauntCharge] Give Taunt and Charge && Test: Give Taunt and Charge_TB_AllMinionsTauntCharge
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_BlingBrawl_Blade1e] Blingtron's Blade (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: When this breaks, randomly summon a new weapon.
			// --------------------------------------------------------
			cards.Add("TB_BlingBrawl_Blade1e", new Power {
				// TODO [TB_BlingBrawl_Blade1e] Blingtron's Blade && Test: Blingtron's Blade_TB_BlingBrawl_Blade1e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_BlingBrawl_Blade2e] Blingtron's Blade HERO (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_BlingBrawl_Blade2e", new Power {
				// TODO [TB_BlingBrawl_Blade2e] Blingtron's Blade HERO && Test: Blingtron's Blade HERO_TB_BlingBrawl_Blade2e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Blizzcon2016_GoonsEnchant] The Grimy Goons (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_Blizzcon2016_GoonsEnchant", new Power {
				// TODO [TB_Blizzcon2016_GoonsEnchant] The Grimy Goons && Test: The Grimy Goons_TB_Blizzcon2016_GoonsEnchant
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Blizzcon2016_KabalEnchant] The Kabal (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_Blizzcon2016_KabalEnchant", new Power {
				// TODO [TB_Blizzcon2016_KabalEnchant] The Kabal && Test: The Kabal_TB_Blizzcon2016_KabalEnchant
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Blizzcon2016_LotusEnchant] The Jade Lotus (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_Blizzcon2016_LotusEnchant", new Power {
				// TODO [TB_Blizzcon2016_LotusEnchant] The Jade Lotus && Test: The Jade Lotus_TB_Blizzcon2016_LotusEnchant
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_BoomAnnoy_001e] Loves Annoy-o-tron (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("TB_BoomAnnoy_001e", new Power {
				// TODO [TB_BoomAnnoy_001e] Loves Annoy-o-tron && Test: Loves Annoy-o-tron_TB_BoomAnnoy_001e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_BoomBotFestival_001e] Boom Bot Attached (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Deal 1-4 damage to a random enemy.
			// --------------------------------------------------------
			cards.Add("TB_BoomBotFestival_001e", new Power {
				// TODO [TB_BoomBotFestival_001e] Boom Bot Attached && Test: Boom Bot Attached_TB_BoomBotFestival_001e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_ClassRandom_Pick2nd_100th] Pick your second class (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: TB_ClassRandom_Warrior, TB_ClassRandom_Warlock, TB_ClassRandom_Shaman, TB_ClassRandom_Rogue, TB_ClassRandom_Priest, TB_ClassRandom_Paladin, TB_ClassRandom_Mage, TB_ClassRandom_Hunter, TB_ClassRandom_Druid
			// --------------------------------------------------------
			cards.Add("TB_ClassRandom_Pick2nd_100th", new Power {
				// TODO [TB_ClassRandom_Pick2nd_100th] Pick your second class && Test: Pick your second class_TB_ClassRandom_Pick2nd_100th
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_ClassRandom_PickSecondClass] Pick your second class (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: TB_ClassRandom_Warrior, TB_ClassRandom_Warlock, TB_ClassRandom_Shaman, TB_ClassRandom_Rogue, TB_ClassRandom_Priest, TB_ClassRandom_Paladin, TB_ClassRandom_Mage, TB_ClassRandom_Hunter, TB_ClassRandom_Druid
			// --------------------------------------------------------
			cards.Add("TB_ClassRandom_PickSecondClass", new Power {
				// TODO [TB_ClassRandom_PickSecondClass] Pick your second class && Test: Pick your second class_TB_ClassRandom_PickSecondClass
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_CoOpv3_009e] Going Nova (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: It's about to blow!
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_009e", new Power {
				// TODO [TB_CoOpv3_009e] Going Nova && Test: Going Nova_TB_CoOpv3_009e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_CoOpv3_101e] Team Player Enchantment (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Immune</b> ahile attacking
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_101e", new Power {
				// TODO [TB_CoOpv3_101e] Team Player Enchantment && Test: Team Player Enchantment_TB_CoOpv3_101e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_CoOpv3_104e] Unity (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: +2/+2
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_104e", new Power {
				// TODO [TB_CoOpv3_104e] Unity && Test: Unity_TB_CoOpv3_104e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_CoOpv3_BOSS2e] Getting Angry.... (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Now he's mad....
			// --------------------------------------------------------
			// GameTag:
			// - ENRAGED = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_BOSS2e", new Power {
				// TODO [TB_CoOpv3_BOSS2e] Getting Angry.... && Test: Getting Angry...._TB_CoOpv3_BOSS2e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_CoOpv3_BOSS3e] Enough! (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Nefarian is <b>Immune</b> this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_BOSS3e", new Power {
				// TODO [TB_CoOpv3_BOSS3e] Enough! && Test: Enough!_TB_CoOpv3_BOSS3e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_CoOpv3_BOSS4e] Cowed (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Can't attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_BOSS4e", new Power {
				// TODO [TB_CoOpv3_BOSS4e] Cowed && Test: Cowed_TB_CoOpv3_BOSS4e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_CoOpv3_BOSSe] WHY WON'T YOU DIE!? (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Now he's REALLY mad....
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_BOSSe", new Power {
				// TODO [TB_CoOpv3_BOSSe] WHY WON'T YOU DIE!? && Test: WHY WON'T YOU DIE!?_TB_CoOpv3_BOSSe
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_DeckRecipe_MyDeckID] My Deck ID (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_DeckRecipe_MyDeckID", new Power {
				// TODO [TB_DeckRecipe_MyDeckID] My Deck ID && Test: My Deck ID_TB_DeckRecipe_MyDeckID
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_DiscoverMyDeck_Enchantment] Discover My Deck Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_DiscoverMyDeck_Enchantment", new Power {
				// TODO [TB_DiscoverMyDeck_Enchantment] Discover My Deck Enchant && Test: Discover My Deck Enchant_TB_DiscoverMyDeck_Enchantment
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_EndlessMinions01] Endless Enchantment (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: +2/+2.
			// --------------------------------------------------------
			cards.Add("TB_EndlessMinions01", new Power {
				// TODO [TB_EndlessMinions01] Endless Enchantment && Test: Endless Enchantment_TB_EndlessMinions01
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Face_Ench1] Safe (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: This minion is safe from attacks and cannot have taunt.
			// --------------------------------------------------------
			cards.Add("TB_Face_Ench1", new Power {
				// TODO [TB_Face_Ench1] Safe && Test: Safe_TB_Face_Ench1
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_FireFestEnch] Conflagrate (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Gains Attack for each minion killed.
			// --------------------------------------------------------
			cards.Add("TB_FireFestEnch", new Power {
				// TODO [TB_FireFestEnch] Conflagrate && Test: Conflagrate_TB_FireFestEnch
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_FoxBlessing1] Leech Blessing (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_FoxBlessing1", new Power {
				// TODO [TB_FoxBlessing1] Leech Blessing && Test: Leech Blessing_TB_FoxBlessing1
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_FoxBlessing2] Deadly Blessing (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - POISONOUS = 1
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_FoxBlessing2", new Power {
				// TODO [TB_FoxBlessing2] Deadly Blessing && Test: Deadly Blessing_TB_FoxBlessing2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_FoxBlessing3] Swordmaster Blessing (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Windfury</b>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_FoxBlessing3", new Power {
				// TODO [TB_FoxBlessing3] Swordmaster Blessing && Test: Swordmaster Blessing_TB_FoxBlessing3
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_FoxBlessing4] MEGA BLESSING! (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Mega-Windfury</b>
			// --------------------------------------------------------
			// GameTag:
			// - WINDFURY = 1
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_FoxBlessing4", new Power {
				// TODO [TB_FoxBlessing4] MEGA BLESSING! && Test: MEGA BLESSING!_TB_FoxBlessing4
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_FoxBlessing5] Stealth Blessing (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_FoxBlessing5", new Power {
				// TODO [TB_FoxBlessing5] Stealth Blessing && Test: Stealth Blessing_TB_FoxBlessing5
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_FoxBlessing6] Charge Blessing (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Charge</b>
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_FoxBlessing6", new Power {
				// TODO [TB_FoxBlessing6] Charge Blessing && Test: Charge Blessing_TB_FoxBlessing6
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_FoxBlessingEnch] Fox Blessing Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_FoxBlessingEnch", new Power {
				// TODO [TB_FoxBlessingEnch] Fox Blessing Enchant && Test: Fox Blessing Enchant_TB_FoxBlessingEnch
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_GiftExchange_Enchantment] Cheap Gift (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: This card's cost is reduced.
			// --------------------------------------------------------
			cards.Add("TB_GiftExchange_Enchantment", new Power {
				// TODO [TB_GiftExchange_Enchantment] Cheap Gift && Test: Cheap Gift_TB_GiftExchange_Enchantment
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_GP_01e] Shadow Tower Power (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Can't Attack.
			//       <b>Stealth</b>.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_ATTACK = 1
			// --------------------------------------------------------
			cards.Add("TB_GP_01e", new Power {
				// TODO [TB_GP_01e] Shadow Tower Power && Test: Shadow Tower Power_TB_GP_01e
				InfoCardId = "TB_GP_01e_copy1",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_GP_01e_copy1] Shadow Tower Give My minions Stealth (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Can't Attack.
			//       <b>Stealth</b>.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_ATTACK = 1
			// --------------------------------------------------------
			cards.Add("TB_GP_01e_copy1", new Power {
				// TODO [TB_GP_01e_copy1] Shadow Tower Give My minions Stealth && Test: Shadow Tower Give My minions Stealth_TB_GP_01e_copy1
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_GP_01e_v2] Shadow Tower Stealth (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Stealth</b>.
			// --------------------------------------------------------
			cards.Add("TB_GP_01e_v2", new Power {
				// TODO [TB_GP_01e_v2] Shadow Tower Stealth && Test: Shadow Tower Stealth_TB_GP_01e_v2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_GreatCurves_01] TB_ClockworkCardDealer (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_GreatCurves_01", new Power {
				// TODO [TB_GreatCurves_01] TB_ClockworkCardDealer && Test: TB_ClockworkCardDealer_TB_GreatCurves_01
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_HeadlessHorseman_005e] Yar. (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Increased Attack and Health
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_005e", new Power {
				// TODO [TB_HeadlessHorseman_005e] Yar. && Test: Yar._TB_HeadlessHorseman_005e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_HeadlessHorseman_GameEnch] Pick Costume (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Entourage: TB_HeadlessHorseman_s001a, TB_HeadlessHorseman_s001c, TB_HeadlessHorseman_s001b
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39240
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_GameEnch", new Power {
				// TODO [TB_HeadlessHorseman_GameEnch] Pick Costume && Test: Pick Costume_TB_HeadlessHorseman_GameEnch
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_HeadlessHorseman_HP5e] Senses Weakness (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: +2 Attack
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 39240
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_HP5e", new Power {
				// TODO [TB_HeadlessHorseman_HP5e] Senses Weakness && Test: Senses Weakness_TB_HeadlessHorseman_HP5e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_KaraPortal_003] Saddened Hero Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Give can't attack this turn to enemy minions.
			// --------------------------------------------------------
			// GameTag:
			// - TAG_ONE_TURN_EFFECT = 1
			// --------------------------------------------------------
			cards.Add("TB_KaraPortal_003", new Power {
				// TODO [TB_KaraPortal_003] Saddened Hero Enchant && Test: Saddened Hero Enchant_TB_KaraPortal_003
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_KoboldGiftEnch] Great Father Kobold Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_KoboldGiftEnch", new Power {
				// TODO [TB_KoboldGiftEnch] Great Father Kobold Enchant && Test: Great Father Kobold Enchant_TB_KoboldGiftEnch
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_KTRAF_10e] Dark Power (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Granted power from Noth
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_10e", new Power {
				// TODO [TB_KTRAF_10e] Dark Power && Test: Dark Power_TB_KTRAF_10e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_LethalSetup02] Brawl Progress Saved (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Welcome back! Would you like to restart or continue?
			// --------------------------------------------------------
			// Entourage: TB_LethalSetup001a, TB_LethalSetup001b
			// --------------------------------------------------------
			cards.Add("TB_LethalSetup02", new Power {
				// TODO [TB_LethalSetup02] Brawl Progress Saved && Test: Brawl Progress Saved_TB_LethalSetup02
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_MammothParty_s002ee] Raucous (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: +2/+2
			// --------------------------------------------------------
			// GameTag:
			// - UNTOUCHABLE = 1
			// --------------------------------------------------------
			cards.Add("TB_MammothParty_s002ee", new Power {
				// TODO [TB_MammothParty_s002ee] Raucous && Test: Raucous_TB_MammothParty_s002ee
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_MechWar_CommonCards] TBMechWarCommonCards (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: GVG_069, GVG_079, GVG_034, GVG_048, GVG_049, GVG_088
			// --------------------------------------------------------
			cards.Add("TB_MechWar_CommonCards", new Power {
				// TODO [TB_MechWar_CommonCards] TBMechWarCommonCards && Test: TBMechWarCommonCards_TB_MechWar_CommonCards
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Mini_1e] Miniature (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Mini-sized, set to 1/1
			// --------------------------------------------------------
			cards.Add("TB_Mini_1e", new Power {
				// TODO [TB_Mini_1e] Miniature && Test: Miniature_TB_Mini_1e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_NewBlinkFox] Blink Fox Enchant (*) - COST:0 [ATK:1/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_NewBlinkFox", new Power {
				// TODO [TB_NewBlinkFox] Blink Fox Enchant && Test: Blink Fox Enchant_TB_NewBlinkFox
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003e] Shifting (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Transforming into random dyes.
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003e", new Power {
				// TODO [TB_Noblegarden_003e] Shifting && Test: Shifting_TB_Noblegarden_003e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003t1e] Blue Egg (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: The minion inside has <b>Windfury</b>.
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t1e", new Power {
				// TODO [TB_Noblegarden_003t1e] Blue Egg && Test: Blue Egg_TB_Noblegarden_003t1e
				InfoCardId = "TB_Noblegarden_003t1e2",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003t1e2] Blue Hatchling (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Windfury</b>
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t1e2", new Power {
				// TODO [TB_Noblegarden_003t1e2] Blue Hatchling && Test: Blue Hatchling_TB_Noblegarden_003t1e2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003t2e] Purple Egg (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: The minion inside has <b>Lifesteal</b>.
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t2e", new Power {
				// TODO [TB_Noblegarden_003t2e] Purple Egg && Test: Purple Egg_TB_Noblegarden_003t2e
				InfoCardId = "TB_Noblegarden_003t2e2",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003t2e2] Purple Hatchling (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Lifesteal</b>
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t2e2", new Power {
				// TODO [TB_Noblegarden_003t2e2] Purple Hatchling && Test: Purple Hatchling_TB_Noblegarden_003t2e2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003t3e] Green Egg (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: The minion inside has <b>Poisonous</b>.
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t3e", new Power {
				// TODO [TB_Noblegarden_003t3e] Green Egg && Test: Green Egg_TB_Noblegarden_003t3e
				InfoCardId = "TB_Noblegarden_003t3e2",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003t3e2] Green Hatchling (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t3e2", new Power {
				// TODO [TB_Noblegarden_003t3e2] Green Hatchling && Test: Green Hatchling_TB_Noblegarden_003t3e2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003t4e] Silver Egg (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: The minion inside has <b>Stealth</b>.
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t4e", new Power {
				// TODO [TB_Noblegarden_003t4e] Silver Egg && Test: Silver Egg_TB_Noblegarden_003t4e
				InfoCardId = "TB_Noblegarden_003t4e2",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003t4e2] Silver Hatchling (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t4e2", new Power {
				// TODO [TB_Noblegarden_003t4e2] Silver Hatchling && Test: Silver Hatchling_TB_Noblegarden_003t4e2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003t5e] Orange Egg (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: The minion inside has <b>Rush</b>.
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t5e", new Power {
				// TODO [TB_Noblegarden_003t5e] Orange Egg && Test: Orange Egg_TB_Noblegarden_003t5e
				InfoCardId = "TB_Noblegarden_003t5e2",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003t5e2] Orange Hatchling (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Rush</b>
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t5e2", new Power {
				// TODO [TB_Noblegarden_003t5e2] Orange Hatchling && Test: Orange Hatchling_TB_Noblegarden_003t5e2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003t6e] Pink Egg (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: The minion inside has <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t6e", new Power {
				// TODO [TB_Noblegarden_003t6e] Pink Egg && Test: Pink Egg_TB_Noblegarden_003t6e
				InfoCardId = "TB_Noblegarden_003t6e2",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003t6e2] Pink Hatchling (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t6e2", new Power {
				// TODO [TB_Noblegarden_003t6e2] Pink Hatchling && Test: Pink Hatchling_TB_Noblegarden_003t6e2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003t7e] Gold Egg (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: The minion inside has <b>Divine Shield</b>.
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t7e", new Power {
				// TODO [TB_Noblegarden_003t7e] Gold Egg && Test: Gold Egg_TB_Noblegarden_003t7e
				InfoCardId = "TB_Noblegarden_003t7e2",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003t7e2] Gold Hatchling (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Divine Shield</b>
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t7e2", new Power {
				// TODO [TB_Noblegarden_003t7e2] Gold Hatchling && Test: Gold Hatchling_TB_Noblegarden_003t7e2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003t8e] Red Egg (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: The minion inside has +2/+2.
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t8e", new Power {
				// TODO [TB_Noblegarden_003t8e] Red Egg && Test: Red Egg_TB_Noblegarden_003t8e
				InfoCardId = "TB_Noblegarden_003t8e2",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_003t8e2] Red Hatchling (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: +2/+2
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t8e2", new Power {
				// TODO [TB_Noblegarden_003t8e2] Red Hatchling && Test: Red Hatchling_TB_Noblegarden_003t8e2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Noblegarden_005e] Delicious Carrots (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Increased Attack and Health, moreso for Bunnies
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_005e", new Power {
				// TODO [TB_Noblegarden_005e] Delicious Carrots && Test: Delicious Carrots_TB_Noblegarden_005e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate] Pick Your Fate Build Around (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: TB_PickYourFate_9, TB_PickYourFate_10, TB_PickYourFate_11b, TB_PickYourFate_8
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate", new Power {
				// TODO [TB_PickYourFate] Pick Your Fate Build Around && Test: Pick Your Fate Build Around_TB_PickYourFate
				InfoCardId = "TB_PickYourFate7Ench",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate7Ench] Fate 7 Ench Get a Coin (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate7Ench", new Power {
				// TODO [TB_PickYourFate7Ench] Fate 7 Ench Get a Coin && Test: Fate 7 Ench Get a Coin_TB_PickYourFate7Ench
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_10_Ench] Fate (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_10_Ench", new Power {
				// TODO [TB_PickYourFate_10_Ench] Fate && Test: Fate_TB_PickYourFate_10_Ench
				InfoCardId = "TB_PickYourFate_10_EnchMinion",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_10_EnchMinion] Bonus (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Your <b>Battlecry</b> minions have +1/+1.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_10_EnchMinion", new Power {
				// TODO [TB_PickYourFate_10_EnchMinion] Bonus && Test: Bonus_TB_PickYourFate_10_EnchMinion
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_11_Ench] Fate 11 Ench. Murloc (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_11_Ench", new Power {
				// TODO [TB_PickYourFate_11_Ench] Fate 11 Ench. Murloc && Test: Fate 11 Ench. Murloc_TB_PickYourFate_11_Ench
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_12_Ench] Fate 12 Ench, Confuse (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_12_Ench", new Power {
				// TODO [TB_PickYourFate_12_Ench] Fate 12 Ench, Confuse && Test: Fate 12 Ench, Confuse_TB_PickYourFate_12_Ench
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_1_Ench] Pick Your Fate 1 Ench (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_1_Ench", new Power {
				// TODO [TB_PickYourFate_1_Ench] Pick Your Fate 1 Ench && Test: Pick Your Fate 1 Ench_TB_PickYourFate_1_Ench
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_2_Ench] Pick Your Fate 2 Ench (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_2_Ench", new Power {
				// TODO [TB_PickYourFate_2_Ench] Pick Your Fate 2 Ench && Test: Pick Your Fate 2 Ench_TB_PickYourFate_2_Ench
				InfoCardId = "TB_PickYourFate_2_EnchMinion",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_2_EnchMinion] Fate (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Your owner gets a banana.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_2_EnchMinion", new Power {
				// TODO [TB_PickYourFate_2_EnchMinion] Fate && Test: Fate_TB_PickYourFate_2_EnchMinion
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_2nd] Pick Your Fate Randon 2nd (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: TB_PickYourFate_1, TB_PickYourFate_4, TB_PickYourFate_7_2nd, TB_PickYourFate_3, TB_PickYourFate_6_2nd, TB_PickYourFate_11rand
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_2nd", new Power {
				// TODO [TB_PickYourFate_2nd] Pick Your Fate Randon 2nd && Test: Pick Your Fate Randon 2nd_TB_PickYourFate_2nd
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_3_Ench] Pick Your Fate 3 Ench (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_3_Ench", new Power {
				// TODO [TB_PickYourFate_3_Ench] Pick Your Fate 3 Ench && Test: Pick Your Fate 3 Ench_TB_PickYourFate_3_Ench
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_4_Ench] Pick Your Fate 4 Ench (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_4_Ench", new Power {
				// TODO [TB_PickYourFate_4_Ench] Pick Your Fate 4 Ench && Test: Pick Your Fate 4 Ench_TB_PickYourFate_4_Ench
				InfoCardId = "TB_PickYourFate_4_EnchMinion",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_4_EnchMinion] Fate (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_4_EnchMinion", new Power {
				// TODO [TB_PickYourFate_4_EnchMinion] Fate && Test: Fate_TB_PickYourFate_4_EnchMinion
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_5_Ench] Pick Your Fate 5 Ench (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_5_Ench", new Power {
				// TODO [TB_PickYourFate_5_Ench] Pick Your Fate 5 Ench && Test: Pick Your Fate 5 Ench_TB_PickYourFate_5_Ench
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_7_Ench_2nd] Fate 7 Ench 2nd (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_7_Ench_2nd", new Power {
				// TODO [TB_PickYourFate_7_Ench_2nd] Fate 7 Ench 2nd && Test: Fate 7 Ench 2nd_TB_PickYourFate_7_Ench_2nd
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_7_EnchMiniom2nd] Fate (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> random card in owner's hand costs (0).
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_7_EnchMiniom2nd", new Power {
				// TODO [TB_PickYourFate_7_EnchMiniom2nd] Fate && Test: Fate_TB_PickYourFate_7_EnchMiniom2nd
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_7_EnchMinion] Fate (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Your owner gets a coin.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_7_EnchMinion", new Power {
				// TODO [TB_PickYourFate_7_EnchMinion] Fate && Test: Fate_TB_PickYourFate_7_EnchMinion
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_8_Ench] Fate 8 Get Armor (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_8_Ench", new Power {
				// TODO [TB_PickYourFate_8_Ench] Fate 8 Get Armor && Test: Fate 8 Get Armor_TB_PickYourFate_8_Ench
				InfoCardId = "TB_PickYourFate_8_EnchRand",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_8_EnchRand] Fate 8 Rand 2 armor each turn (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_8_EnchRand", new Power {
				// TODO [TB_PickYourFate_8_EnchRand] Fate 8 Rand 2 armor each turn && Test: Fate 8 Rand 2 armor each turn_TB_PickYourFate_8_EnchRand
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_9_Ench] Fate 9 Ench. Deathrattle bonus (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_9_Ench", new Power {
				// TODO [TB_PickYourFate_9_Ench] Fate 9 Ench. Deathrattle bonus && Test: Fate 9 Ench. Deathrattle bonus_TB_PickYourFate_9_Ench
				InfoCardId = "TB_PickYourFate_9_EnchMinion",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_9_EnchMinion] Bonus (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Your <b>Deathrattle</b> minions have +1/+1.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_9_EnchMinion", new Power {
				// TODO [TB_PickYourFate_9_EnchMinion] Bonus && Test: Bonus_TB_PickYourFate_9_EnchMinion
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_Confused] Fate (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Attack and Health swap at end of each turn.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_Confused", new Power {
				// TODO [TB_PickYourFate_Confused] Fate && Test: Fate_TB_PickYourFate_Confused
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFate_Windfury] Fate (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: This minion has <b>Windfury</b>
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_Windfury", new Power {
				// TODO [TB_PickYourFate_Windfury] Fate && Test: Fate_TB_PickYourFate_Windfury
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_PickYourFateRandom] Pick Your Fate Random (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: TB_PickYourFate_12, TB_PickYourFate_2, TB_PickYourFate_8rand, TB_PickYourFate_6, TB_PickYourFate_5, TB_PickYourFate_7
			// --------------------------------------------------------
			cards.Add("TB_PickYourFateRandom", new Power {
				// TODO [TB_PickYourFateRandom] Pick Your Fate Random && Test: Pick Your Fate Random_TB_PickYourFateRandom
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Pilot1] Mystery Pilot (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Who could it be?!
			// --------------------------------------------------------
			cards.Add("TB_Pilot1", new Power {
				// TODO [TB_Pilot1] Mystery Pilot && Test: Mystery Pilot_TB_Pilot1
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_RandCardCost] TBRandomCardCost (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_RandCardCost", new Power {
				// TODO [TB_RandCardCost] TBRandomCardCost && Test: TBRandomCardCost_TB_RandCardCost
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_RandHero2_001] TB_EnchWhosTheBossNow (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: BRMA07_2_2_TB, BRMA01_2H_2_TB, BRMA17_5_TB, NAX12_02H_2_TB, BRMA02_2_2_TB, NAX11_02H_2_TB, BRMA13_4_2_TB, BRMA09_2_TB, BRMA14_10H_TB, BRMA06_2H_TB, NAX3_02_TB, NAX8_02H_TB
			// --------------------------------------------------------
			cards.Add("TB_RandHero2_001", new Power {
				// TODO [TB_RandHero2_001] TB_EnchWhosTheBossNow && Test: TB_EnchWhosTheBossNow_TB_RandHero2_001
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_RMC_001] TB_EnchRandomManaCost (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_RMC_001", new Power {
				// TODO [TB_RMC_001] TB_EnchRandomManaCost && Test: TB_EnchRandomManaCost_TB_RMC_001
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_SC20_001] Portal Selection (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Entourage: TB_SC20_001a, TB_SC20_001b, TB_SC20_001c
			// --------------------------------------------------------
			cards.Add("TB_SC20_001", new Power {
				// TODO [TB_SC20_001] Portal Selection && Test: Portal Selection_TB_SC20_001
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_Spellwrite_001] SpellCaster (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_Spellwrite_001", new Power {
				// TODO [TB_Spellwrite_001] SpellCaster && Test: SpellCaster_TB_Spellwrite_001
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_SPT_DPromoEnch3] Shield Glare (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Attack changed to 1.
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoEnch3", new Power {
				// TODO [TB_SPT_DPromoEnch3] Shield Glare && Test: Shield Glare_TB_SPT_DPromoEnch3
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_SPT_DPromoSecre8e] Assassin's Stealth (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Stealth</b>.
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSecre8e", new Power {
				// TODO [TB_SPT_DPromoSecre8e] Assassin's Stealth && Test: Assassin's Stealth_TB_SPT_DPromoSecre8e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_SPT_DPromoSecret9e] Knowledge (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Costs (1).
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSecret9e", new Power {
				// TODO [TB_SPT_DPromoSecret9e] Knowledge && Test: Knowledge_TB_SPT_DPromoSecret9e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_SPT_DPromoSpellBovine1e] Herding (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Minion has <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSpellBovine1e", new Power {
				// TODO [TB_SPT_DPromoSpellBovine1e] Herding && Test: Herding_TB_SPT_DPromoSpellBovine1e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_SPT_Minion1e] Will of Stormwind (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Stormwind is granting this card Health.
			// --------------------------------------------------------
			cards.Add("TB_SPT_Minion1e", new Power {
				// TODO [TB_SPT_Minion1e] Will of Stormwind && Test: Will of Stormwind_TB_SPT_Minion1e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_SPT_Minion2e] Emboldened (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Standard Bearer is granting +2 Attack to this minion.
			// --------------------------------------------------------
			cards.Add("TB_SPT_Minion2e", new Power {
				// TODO [TB_SPT_Minion2e] Emboldened && Test: Emboldened_TB_SPT_Minion2e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_SPT_Minion3e] Strength of Stormwind (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Stormwind is granting this card Attack and Health.
			// --------------------------------------------------------
			cards.Add("TB_SPT_Minion3e", new Power {
				// TODO [TB_SPT_Minion3e] Strength of Stormwind && Test: Strength of Stormwind_TB_SPT_Minion3e
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_SwapBossHeroPowerByClass] Swap Boss Hero Power by Class (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_SwapBossHeroPowerByClass", new Power {
				// TODO [TB_SwapBossHeroPowerByClass] Swap Boss Hero Power by Class && Test: Swap Boss Hero Power by Class_TB_SwapBossHeroPowerByClass
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_SwapHeroWithDeathKnight] Swap Hero With Death Knight (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_SwapHeroWithDeathKnight", new Power {
				// TODO [TB_SwapHeroWithDeathKnight] Swap Hero With Death Knight && Test: Swap Hero With Death Knight_TB_SwapHeroWithDeathKnight
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_TagTeam] Check for Hero Death (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_TagTeam", new Power {
				// TODO [TB_TagTeam] Check for Hero Death && Test: Check for Hero Death_TB_TagTeam
				InfoCardId = "TB_TagTeam_GetClass",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_TagTeam_GetClass] Discover Next Class (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Entourage: TB_TagTeam_Paladin, TB_TagTeam_Shaman, TB_TagTeam_Warlock, TB_TagTeam_Druid, TB_TagTeam_Hunter, TB_TagTeam_Mage, TB_TagTeam_Priest, TB_TagTeam_Rogue, TB_TagTeam_Warrior
			// --------------------------------------------------------
			cards.Add("TB_TagTeam_GetClass", new Power {
				// TODO [TB_TagTeam_GetClass] Discover Next Class && Test: Discover Next Class_TB_TagTeam_GetClass
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_VoidSingularityEnch] Void Singularity Spell (*) - COST:0 [ATK:1/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_VoidSingularityEnch", new Power {
				// TODO [TB_VoidSingularityEnch] Void Singularity Spell && Test: Void Singularity Spell_TB_VoidSingularityEnch
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TB_YoggServant_Enchant] Yogg Servant Hero Enchant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_YoggServant_Enchant", new Power {
				// TODO [TB_YoggServant_Enchant] Yogg Servant Hero Enchant && Test: Yogg Servant Hero Enchant_TB_YoggServant_Enchant
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TBST_006] OLDTBST Push Common Card (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: push a common card into player's hand
			// --------------------------------------------------------
			// Entourage: TBST_003, TBST_002, TBST_001
			// --------------------------------------------------------
			cards.Add("TBST_006", new Power {
				// TODO [TBST_006] OLDTBST Push Common Card && Test: OLDTBST Push Common Card_TBST_006
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------- ENCHANTMENT - NEUTRAL
			// [TBUD_1] TBUD Summon Early Minion (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Each turn, if you have less health then a your opponent, summon a free minion
			// --------------------------------------------------------
			// Entourage: CS1_042, CS2_171
			// --------------------------------------------------------
			cards.Add("TBUD_1", new Power {
				// TODO [TBUD_1] TBUD Summon Early Minion && Test: TBUD Summon Early Minion_TBUD_1
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRMC_84] Dragonkin Spellcaster (*) - COST:5 [ATK:4/HP:6] 
			// - Race: dragon, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon two 2/2 Whelps.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BRMC_84", new Power {
				// TODO [BRMC_84] Dragonkin Spellcaster && Test: Dragonkin Spellcaster_BRMC_84
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRMC_85] Lucifron (*) - COST:4 [ATK:4/HP:7] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Cast Corruption on all other minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BRMC_85", new Power {
				// TODO [BRMC_85] Lucifron && Test: Lucifron_BRMC_85
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRMC_86] Atramedes (*) - COST:4 [ATK:2/HP:8] 
			// - Race: dragon, Set: tb, 
			// --------------------------------------------------------
			// Text: Whenever your opponent plays a card, gain +2 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("BRMC_86", new Power {
				// TODO [BRMC_86] Atramedes && Test: Atramedes_BRMC_86
				InfoCardId = "BRMC_86e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRMC_87] Moira Bronzebeard (*) - COST:3 [ATK:4/HP:3] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon Emperor Thaurissan.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BRMC_87", new Power {
				// TODO [BRMC_87] Moira Bronzebeard && Test: Moira Bronzebeard_BRMC_87
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRMC_88] Drakonid Slayer (*) - COST:6 [ATK:6/HP:6] 
			// - Race: dragon, Set: tb, 
			// --------------------------------------------------------
			// Text: Also damages the minions next to whomever he attacks.
			// --------------------------------------------------------
			cards.Add("BRMC_88", new Power {
				// TODO [BRMC_88] Drakonid Slayer && Test: Drakonid Slayer_BRMC_88
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRMC_89] Whirling Ash (*) - COST:2 [ATK:4/HP:5] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Windfury</b>
			// --------------------------------------------------------
			// GameTag:
			// - WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("BRMC_89", new Power {
				// TODO [BRMC_89] Whirling Ash && Test: Whirling Ash_BRMC_89
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRMC_90] Living Lava (*) - COST:2 [ATK:6/HP:6] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("BRMC_90", new Power {
				// TODO [BRMC_90] Living Lava && Test: Living Lava_BRMC_90
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRMC_91] Son of the Flame (*) - COST:3 [ATK:6/HP:3] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Deal 6 damage.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// --------------------------------------------------------
			cards.Add("BRMC_91", new Power {
				// TODO [BRMC_91] Son of the Flame && Test: Son of the Flame_BRMC_91
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRMC_92] Coren Direbrew (*) - COST:4 [ATK:4/HP:8] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Always wins Brawls.
			//        <b>Battlecry:</b> Add a Brawl to your hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("BRMC_92", new Power {
				// TODO [BRMC_92] Coren Direbrew && Test: Coren Direbrew_BRMC_92
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRMC_95] Golemagg (*) - COST:50 [ATK:20/HP:20] 
			// - Set: tb, Rarity: legendary
			// --------------------------------------------------------
			// Text: Costs (1) less for each damage your hero has taken.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("BRMC_95", new Power {
				// TODO [BRMC_95] Golemagg && Test: Golemagg_BRMC_95
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRMC_95he] Core Hound Pup (*) - COST:3 [ATK:2/HP:4] 
			// - Race: beast, Set: tb, 
			// --------------------------------------------------------
			// Text: At the end of each turn, summon all Core Hound Pups that died this turn.
			// --------------------------------------------------------
			cards.Add("BRMC_95he", new Power {
				// TODO [BRMC_95he] Core Hound Pup && Test: Core Hound Pup_BRMC_95he
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRMC_96] High Justice Grimstone (*) - COST:3 [ATK:4/HP:5] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the start of your turn, summon a <b>Legendary</b> minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("BRMC_96", new Power {
				// TODO [BRMC_96] High Justice Grimstone && Test: High Justice Grimstone_BRMC_96
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRMC_97] Vaelastrasz (*) - COST:6 [ATK:7/HP:7] 
			// - Race: dragon, Set: tb, 
			// --------------------------------------------------------
			// Text: Your cards cost (3) less.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("BRMC_97", new Power {
				// TODO [BRMC_97] Vaelastrasz && Test: Vaelastrasz_BRMC_97
				InfoCardId = "BRMC_97e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRMC_98] Razorgore (*) - COST:6 [ATK:4/HP:12] 
			// - Race: dragon, Set: tb, 
			// --------------------------------------------------------
			// Text: At the start of your turn, give your minions +3 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("BRMC_98", new Power {
				// TODO [BRMC_98] Razorgore && Test: Razorgore_BRMC_98
				InfoCardId = "BRMC_98e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRMC_99] Garr (*) - COST:5 [ATK:4/HP:8] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Whenever this minion takes damage, summon a 2/3 Elemental with <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("BRMC_99", new Power {
				// TODO [BRMC_99] Garr && Test: Garr_BRMC_99
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [BRMC_99e] Rock Elemental (*) - COST:2 [ATK:2/HP:3] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("BRMC_99e", new Power {
				// TODO [BRMC_99e] Rock Elemental && Test: Rock Elemental_BRMC_99e
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FB_Champs_CS2_188] Abusive Sergeant (*) - COST:1 [ATK:2/HP:1] 
			// - Fac: alliance, Set: tb, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give a minion +2_Attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("FB_Champs_CS2_188", new Power {
				// TODO [FB_Champs_CS2_188] Abusive Sergeant && Test: Abusive Sergeant_FB_Champs_CS2_188
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FB_Champs_EX1_005] Big Game Hunter (*) - COST:3 [ATK:4/HP:2] 
			// - Set: tb, Rarity: epic
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy a minion with 7 or more Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_IF_AVAILABLE = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_MIN_ATTACK = 7
			// --------------------------------------------------------
			cards.Add("FB_Champs_EX1_005", new Power {
				// TODO [FB_Champs_EX1_005] Big Game Hunter && Test: Big Game Hunter_FB_Champs_EX1_005
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FB_Champs_EX1_029] Leper Gnome (*) - COST:1 [ATK:2/HP:1] 
			// - Fac: neutral, Set: tb, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Deal 2 damage to the enemy_hero.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_EX1_029", new Power {
				// TODO [FB_Champs_EX1_029] Leper Gnome && Test: Leper Gnome_FB_Champs_EX1_029
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FB_Champs_EX1_095] Gadgetzan Auctioneer (*) - COST:5 [ATK:4/HP:4] 
			// - Fac: neutral, Set: tb, Rarity: rare
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, draw a card.
			// --------------------------------------------------------
			cards.Add("FB_Champs_EX1_095", new Power {
				// TODO [FB_Champs_EX1_095] Gadgetzan Auctioneer && Test: Gadgetzan Auctioneer_FB_Champs_EX1_095
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FB_Champs_EX1_556] Harvest Golem (*) - COST:3 [ATK:2/HP:3] 
			// - Fac: neutral, Set: tb, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a 2/1 Damaged Golem.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_EX1_556", new Power {
				// TODO [FB_Champs_EX1_556] Harvest Golem && Test: Harvest Golem_FB_Champs_EX1_556
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FB_Champs_FP1_028] Undertaker (*) - COST:1 [ATK:1/HP:2] 
			// - Set: tb, Rarity: common
			// --------------------------------------------------------
			// Text: Whenever you summon a minion with <b>Deathrattle</b>, gain +1/+1.
			// --------------------------------------------------------
			// RefTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("FB_Champs_FP1_028", new Power {
				// TODO [FB_Champs_FP1_028] Undertaker && Test: Undertaker_FB_Champs_FP1_028
				InfoCardId = "FB_Champs_FP1_028e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FB_Champs_NEW1_019] Knife Juggler (*) - COST:2 [ATK:3/HP:2] 
			// - Set: tb, Rarity: rare
			// --------------------------------------------------------
			// Text: [x]After you summon a
			//       minion, deal 1 damage
			//       to a random enemy.
			// --------------------------------------------------------
			cards.Add("FB_Champs_NEW1_019", new Power {
				// TODO [FB_Champs_NEW1_019] Knife Juggler && Test: Knife Juggler_FB_Champs_NEW1_019
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [FB_Champs_skele21] Damaged Golem (*) - COST:1 [ATK:2/HP:1] 
			// - Fac: neutral, Set: tb, Rarity: common
			// --------------------------------------------------------
			cards.Add("FB_Champs_skele21", new Power {
				// TODO [FB_Champs_skele21] Damaged Golem && Test: Damaged Golem_FB_Champs_skele21
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [HRW02_1] Gearmaster Mechazod (*) - COST:10 [ATK:1/HP:80] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Boss</b>
			//       At the beginning of each turn, Mechazod strikes!
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - InvisibleDeathrattle = 1
			// --------------------------------------------------------
			cards.Add("HRW02_1", new Power {
				// TODO [HRW02_1] Gearmaster Mechazod && Test: Gearmaster Mechazod_HRW02_1
				InfoCardId = "HRW02_1e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [HRW02_2] Gearmaster Mechazod (*) - COST:10 [ATK:1/HP:80] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Boss</b>
			//       At the beginning of each turn, Mechazod strikes!
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("HRW02_2", new Power {
				// TODO [HRW02_2] Gearmaster Mechazod && Test: Gearmaster Mechazod_HRW02_2
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [HRW02_3] Kill Objective: Anub'arak (*) - COST:0 [ATK:1/HP:100] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Wreaks havoc at the beginning of each turn.  Immune to abilites that don't affect heroes.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("HRW02_3", new Power {
				// TODO [HRW02_3] Kill Objective: Anub'arak && Test: Kill Objective: Anub'arak_HRW02_3
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KARA_13_15] Wanda Wonderhooves (*) - COST:2 [ATK:1/HP:2] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Portals cost (1) less. 
			//       <i>Does not count as a minion.</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// --------------------------------------------------------
			cards.Add("KARA_13_15", new Power {
				// TODO [KARA_13_15] Wanda Wonderhooves && Test: Wanda Wonderhooves_KARA_13_15
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KARA_13_16] Susie Sizzlesong (*) - COST:2 [ATK:1/HP:2] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Portals cost (1) less. 
			//       <i>Does not count as a minion.</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// --------------------------------------------------------
			cards.Add("KARA_13_16", new Power {
				// TODO [KARA_13_16] Susie Sizzlesong && Test: Susie Sizzlesong_KARA_13_16
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KARA_13_17] Mark Moonwalker (*) - COST:2 [ATK:1/HP:2] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Portals cost (1) less. 
			//       <i>Does not count as a minion.</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// --------------------------------------------------------
			cards.Add("KARA_13_17", new Power {
				// TODO [KARA_13_17] Mark Moonwalker && Test: Mark Moonwalker_KARA_13_17
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KARA_13_19] Red Riding Hood (*) - COST:5 [ATK:3/HP:2] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Taunt. Deathrattle:</b> Enemies can't attack this turn.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("KARA_13_19", new Power {
				// TODO [KARA_13_19] Red Riding Hood && Test: Red Riding Hood_KARA_13_19
				InfoCardId = "KARA_13_19e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KARA_13_20] Party Elemental (*) - COST:3 [ATK:3/HP:2] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Comes with a party!
			// --------------------------------------------------------
			cards.Add("KARA_13_20", new Power {
				// TODO [KARA_13_20] Party Elemental && Test: Party Elemental_KARA_13_20
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KARA_13_22] Mime (*) - COST:5 [ATK:5/HP:6] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Always <b>silenced</b>.
			// --------------------------------------------------------
			cards.Add("KARA_13_22", new Power {
				// TODO [KARA_13_22] Mime && Test: Mime_KARA_13_22
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [KARA_13_23] Romulo (*) - COST:5 [ATK:3/HP:4] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the end of your turn, restore 3 health to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("KARA_13_23", new Power {
				// TODO [KARA_13_23] Romulo && Test: Romulo_KARA_13_23
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_015] Pirate (*) - COST:2 [ATK:2/HP:3] 
			// - Race: pirate, Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_015", new Power {
				// TODO [TB_015] Pirate && Test: Pirate_TB_015
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_CoOp_Mechazod2] Overloaded Mechazod (*) - COST:10 [ATK:9/HP:80] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Boss</b>
			//       At the beginning of each turn, Mechazod strikes!
			// --------------------------------------------------------
			cards.Add("TB_CoOp_Mechazod2", new Power {
				// TODO [TB_CoOp_Mechazod2] Overloaded Mechazod && Test: Overloaded Mechazod_TB_CoOp_Mechazod2
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_CoOp_Mechazod_OLD] Gearmaster Mechazod (*) - COST:10 [ATK:2/HP:95] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Boss</b>
			//       Mechazod wins if he defeats either of you!
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOp_Mechazod_OLD", new Power {
				// TODO [TB_CoOp_Mechazod_OLD] Gearmaster Mechazod && Test: Gearmaster Mechazod_TB_CoOp_Mechazod_OLD
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_CoOp_Mechazod_V2] Gearmaster Mechazod (*) - COST:10 [ATK:2/HP:95] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Boss</b>
			//       Mechazod wins if he defeats either of you!
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOp_Mechazod_V2", new Power {
				// TODO [TB_CoOp_Mechazod_V2] Gearmaster Mechazod && Test: Gearmaster Mechazod_TB_CoOp_Mechazod_V2
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_CoopHero_001] Netherspite Infernal (*) - COST:2 [ATK:2/HP:3] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the end of each turn, deal 1 damage to all enemies.
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 40221
			// --------------------------------------------------------
			cards.Add("TB_CoopHero_001", new Power {
				// TODO [TB_CoopHero_001] Netherspite Infernal && Test: Netherspite Infernal_TB_CoopHero_001
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_Coopv3_009t] Explosive Rune (*) - COST:2 [ATK:0/HP:3] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the start of your turn, this explodes, dealing 9 damage to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TB_Coopv3_009t", new Power {
				// TODO [TB_Coopv3_009t] Explosive Rune && Test: Explosive Rune_TB_Coopv3_009t
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_Coopv3_100] Dragonscale Warrior (*) - COST:3 [ATK:3/HP:4] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Whenever any player targets this minion with a spell, that player draws a card.
			// --------------------------------------------------------
			// RefTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("TB_Coopv3_100", new Power {
				// TODO [TB_Coopv3_100] Dragonscale Warrior && Test: Dragonscale Warrior_TB_Coopv3_100
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_Coopv3_101] Freewheeling Skulker (*) - COST:5 [ATK:5/HP:6] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the end of your turn, switch sides.
			// --------------------------------------------------------
			cards.Add("TB_Coopv3_101", new Power {
				// TODO [TB_Coopv3_101] Freewheeling Skulker && Test: Freewheeling Skulker_TB_Coopv3_101
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_Coopv3_103] Intrepid Dragonstalker (*) - COST:5 [ATK:3/HP:3] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Whenever ANY player plays a card, gain +1/+1.
			// --------------------------------------------------------
			cards.Add("TB_Coopv3_103", new Power {
				// TODO [TB_Coopv3_103] Intrepid Dragonstalker && Test: Intrepid Dragonstalker_TB_Coopv3_103
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_Coopv3_104] Main Tank (*) - COST:4 [ATK:4/HP:4] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give all other minions +2/+2, except the <b>Boss</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TB_Coopv3_104", new Power {
				// TODO [TB_Coopv3_104] Main Tank && Test: Main Tank_TB_Coopv3_104
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_Coopv3_104_NewClasses] Main Tank (*) - COST:4 [ATK:4/HP:4] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Give all other minions +2/+2, except the <b>Boss</b>.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TB_Coopv3_104_NewClasses", new Power {
				// TODO [TB_Coopv3_104_NewClasses] Main Tank && Test: Main Tank_TB_Coopv3_104_NewClasses
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_Coopv3_105] Raid Healer (*) - COST:4 [ATK:0/HP:7] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Whenever your hero is healed, also heal your teammate for that much.
			// --------------------------------------------------------
			cards.Add("TB_Coopv3_105", new Power {
				// TODO [TB_Coopv3_105] Raid Healer && Test: Raid Healer_TB_Coopv3_105
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_CoOpv3_Boss] Nefarian (*) - COST:10 [ATK:0/HP:200] 
			// - Race: dragon, Set: tb, Rarity: legendary
			// --------------------------------------------------------
			// Text: Can't be targeted by spells.
			//       <b>Boss: </b>Nefarian wins if he defeats either of you!
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - InvisibleDeathrattle = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_Boss", new Power {
				// TODO [TB_CoOpv3_Boss] Nefarian && Test: Nefarian_TB_CoOpv3_Boss
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_CoOpv3_Boss_FB] Nefarian (*) - COST:10 [ATK:0/HP:200] 
			// - Race: dragon, Set: tb, Rarity: legendary
			// --------------------------------------------------------
			// Text: Can't be targeted by spells.
			//       <b>Boss: </b>Nefarian wins if he defeats either of you!
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - InvisibleDeathrattle = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_Boss_FB", new Power {
				// TODO [TB_CoOpv3_Boss_FB] Nefarian && Test: Nefarian_TB_CoOpv3_Boss_FB
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_CoOpv3_Boss_NewClasses] Nefarian (*) - COST:10 [ATK:0/HP:200] 
			// - Race: dragon, Set: tb, Rarity: legendary
			// --------------------------------------------------------
			// Text: Can't be targeted by spells.
			//       <b>Boss: </b>Nefarian wins if he defeats either of you!
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TAUNT = 1
			// - InvisibleDeathrattle = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_Boss_NewClasses", new Power {
				// TODO [TB_CoOpv3_Boss_NewClasses] Nefarian && Test: Nefarian_TB_CoOpv3_Boss_NewClasses
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_Dorothee_001] Dorothee (*) - COST:4 [ATK:0/HP:10] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Minions to the left have <b>Charge</b>. Minions to the right have <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// - UNTOUCHABLE = 1
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// - CHARGE = 1
			// --------------------------------------------------------
			cards.Add("TB_Dorothee_001", new Power {
				// TODO [TB_Dorothee_001] Dorothee && Test: Dorothee_TB_Dorothee_001
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_FireFestival_Brazier] Brazier (*) - COST:8 [ATK:1/HP:1] 
			// - Race: elemental, Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("TB_FireFestival_Brazier", new Power {
				// TODO [TB_FireFestival_Brazier] Brazier && Test: Brazier_TB_FireFestival_Brazier
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_FireFestival_Fireworks] Fireworks (*) - COST:8 [ATK:1/HP:1] 
			// - Race: elemental, Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("TB_FireFestival_Fireworks", new Power {
				// TODO [TB_FireFestival_Fireworks] Fireworks && Test: Fireworks_TB_FireFestival_Fireworks
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_FireFestival_MRag] Mini-Rag (*) - COST:1 [ATK:2/HP:3] 
			// - Race: elemental, Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Can't attack. <b>Immune</b>.
			//       At the end of each turn, burn your enemies randomly.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - CANT_ATTACK = 1
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("TB_FireFestival_MRag", new Power {
				// TODO [TB_FireFestival_MRag] Mini-Rag && Test: Mini-Rag_TB_FireFestival_MRag
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_Frost_Rag] Ragnaros? (*) - COST:3 [ATK:1/HP:4] 
			// - Race: elemental, Set: tb, 
			// --------------------------------------------------------
			// Text: Can't Attack.
			//       <b>Deathrattle:</b> Whoever kills this deals 4 damage to their opponent.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - CANT_ATTACK = 1
			// --------------------------------------------------------
			cards.Add("TB_Frost_Rag", new Power {
				// TODO [TB_Frost_Rag] Ragnaros? && Test: Ragnaros?_TB_Frost_Rag
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_FW_DrBoomMega] Dr. Boom Boom Boom Boom (*) - COST:9 [ATK:9/HP:9] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon six 1/1 Boom Bots. <i>WARNING: Bots may explode.</i>
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TB_FW_DrBoomMega", new Power {
				// TODO [TB_FW_DrBoomMega] Dr. Boom Boom Boom Boom && Test: Dr. Boom Boom Boom Boom_TB_FW_DrBoomMega
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_FW_ImbaTron] Annoy-o-p-Tron (*) - COST:4 [ATK:2/HP:3] 
			// - Race: mechanical, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon Annoy-o-Tron and Psych-o-Tron.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - DIVINE_SHIELD = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TB_FW_ImbaTron", new Power {
				// TODO [TB_FW_ImbaTron] Annoy-o-p-Tron && Test: Annoy-o-p-Tron_TB_FW_ImbaTron
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_FW_Mortar] Dwarf Demolitionist (*) - COST:1 [ATK:1/HP:5] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Whenever you play a card, deal 1-4 damage to a random enemy.
			// --------------------------------------------------------
			cards.Add("TB_FW_Mortar", new Power {
				// TODO [TB_FW_Mortar] Dwarf Demolitionist && Test: Dwarf Demolitionist_TB_FW_Mortar
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_FW_OmegaMax] Force-Tank OMEGA MAX (*) - COST:10 [ATK:10/HP:10] 
			// - Race: mechanical, Set: tb, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Divine Shield.</b>
			//       <b>Battlecry:</b> Summon six Annoy-o-Trons
			// --------------------------------------------------------
			// GameTag:
			// - DIVINE_SHIELD = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TB_FW_OmegaMax", new Power {
				// TODO [TB_FW_OmegaMax] Force-Tank OMEGA MAX && Test: Force-Tank OMEGA MAX_TB_FW_OmegaMax
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_FW_Warper] Omegawarper (*) - COST:3 [ATK:3/HP:5] 
			// - Race: mechanical, Set: tb, 
			// --------------------------------------------------------
			// Text: Both player's Mechs cost (2) less.
			// --------------------------------------------------------
			// GameTag:
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("TB_FW_Warper", new Power {
				// TODO [TB_FW_Warper] Omegawarper && Test: Omegawarper_TB_FW_Warper
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_GiftExchange_Treasure] Winter's Veil Gift (*) - COST:0 [ATK:0/HP:4] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Give current player a Stolen Gift.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TB_GiftExchange_Treasure", new Power {
				// TODO [TB_GiftExchange_Treasure] Winter's Veil Gift && Test: Winter's Veil Gift_TB_GiftExchange_Treasure
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_GP_03] Shadow Tower New (*) - COST:0 [ATK:0/HP:4] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Can't be <b><b>Silence</b>d</b>
			//       Adjacent minions Can't Attack, and have <b>Stealth</b>
			// --------------------------------------------------------
			// GameTag:
			// - InvisibleDeathrattle = 1
			// --------------------------------------------------------
			cards.Add("TB_GP_03", new Power {
				// TODO [TB_GP_03] Shadow Tower New && Test: Shadow Tower New_TB_GP_03
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_HeadlessHorseman_001] Headless Horseman's Head (*) - COST:10 [ATK:2/HP:35] 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Destroy his head to win the game, but watch out for fireballs!
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_001", new Power {
				// TODO [TB_HeadlessHorseman_001] Headless Horseman's Head && Test: Headless Horseman's Head_TB_HeadlessHorseman_001
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_HeadlessHorseman_002] Sinister Squashling (*) - COST:2 [ATK:2/HP:2] 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: After this minion attacks, destroy it and deal 3 damage to all enemies.
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_002", new Power {
				// TODO [TB_HeadlessHorseman_002] Sinister Squashling && Test: Sinister Squashling_TB_HeadlessHorseman_002
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_HeadlessHorseman_003] Pulsing Pumpkin (*) - COST:3 [ATK:0/HP:5] 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: At the start of your turn, destroy this and summon 2 Sinister Squashlings
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_003", new Power {
				// TODO [TB_HeadlessHorseman_003] Pulsing Pumpkin && Test: Pulsing Pumpkin_TB_HeadlessHorseman_003
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_HeadlessHorseman_004] Captain Cookie (*) - COST:5 [ATK:0/HP:3] 
			// - Race: murloc, Set: tb, 
			// --------------------------------------------------------
			// Text: Whenever you summon a Pirate while this is in your hand, give this minion +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_004", new Power {
				// TODO [TB_HeadlessHorseman_004] Captain Cookie && Test: Captain Cookie_TB_HeadlessHorseman_004
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_HeadlessHorseman_005] Spectral Steed (*) - COST:5 [ATK:5/HP:6] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Minions attacking this have a 50% chance to attack a different character.
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_005", new Power {
				// TODO [TB_HeadlessHorseman_005] Spectral Steed && Test: Spectral Steed_TB_HeadlessHorseman_005
				InfoCardId = "TB_HeadlessHorseman_005e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_KaraPortals_003] Party Elemental (*) - COST:3 [ATK:3/HP:2] 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_KaraPortals_003", new Power {
				// TODO [TB_KaraPortals_003] Party Elemental && Test: Party Elemental_TB_KaraPortals_003
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_KoboldGiftMinion] Large Waxy Gift (*) - COST:0 [ATK:0/HP:4] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Add a random <b>Legendary</b> minion to your opponent's hand.
			//        It costs (3) less.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TB_KoboldGiftMinion", new Power {
				// TODO [TB_KoboldGiftMinion] Large Waxy Gift && Test: Large Waxy Gift_TB_KoboldGiftMinion
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_KTRAF_1] Anub'Rekhan (*) - COST:4 [ATK:5/HP:5] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the end of your turn, summon a 3/1 Nerubian.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_1", new Power {
				// TODO [TB_KTRAF_1] Anub'Rekhan && Test: Anub'Rekhan_TB_KTRAF_1
				InfoCardId = "TB_KTRAF_10e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_KTRAF_10] Noth the Plaguebringer (*) - COST:9 [ATK:2/HP:5] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Whenever an enemy minion dies, summon a 1/1 Skeleton and give your other minions +1/+1.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_10", new Power {
				// TODO [TB_KTRAF_10] Noth the Plaguebringer && Test: Noth the Plaguebringer_TB_KTRAF_10
				InfoCardId = "TB_KTRAF_10e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_KTRAF_11] Sapphiron (*) - COST:5 [ATK:5/HP:6] 
			// - Race: dragon, Set: tb, 
			// --------------------------------------------------------
			// Text: At the start of your turn, <b>Freeze</b> a random enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			// RefTag:
			// - FREEZE = 1
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_11", new Power {
				// TODO [TB_KTRAF_11] Sapphiron && Test: Sapphiron_TB_KTRAF_11
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_KTRAF_12] Patchwerk (*) - COST:8 [ATK:5/HP:8] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Destroy a random enemy minion.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_12", new Power {
				// TODO [TB_KTRAF_12] Patchwerk && Test: Patchwerk_TB_KTRAF_12
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_KTRAF_2] Lady Blaumeux (*) - COST:4 [ATK:2/HP:7] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Summon a fellow Horseman.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_2", new Power {
				// TODO [TB_KTRAF_2] Lady Blaumeux && Test: Lady Blaumeux_TB_KTRAF_2
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_KTRAF_2s] Sir Zeliek (*) - COST:4 [ATK:1/HP:5] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Lady Blaumeux is <b>Immune</b>.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			// RefTag:
			// - IMMUNE = 1
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_2s", new Power {
				// TODO [TB_KTRAF_2s] Sir Zeliek && Test: Sir Zeliek_TB_KTRAF_2s
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_KTRAF_3] Gluth (*) - COST:4 [ATK:3/HP:4] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the end of your turn, summon a random Undead.
			// --------------------------------------------------------
			// Entourage: FP1_001, AT_030, LOE_019, EX1_012, EX1_059, FP1_004, EX1_616, FP1_024, tt_004
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_3", new Power {
				// TODO [TB_KTRAF_3] Gluth && Test: Gluth_TB_KTRAF_3
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_KTRAF_4] Gothik the Harvester (*) - COST:4 [ATK:5/HP:4] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Summon a Spectral Gothik for your opponent.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_4", new Power {
				// TODO [TB_KTRAF_4] Gothik the Harvester && Test: Gothik the Harvester_TB_KTRAF_4
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_KTRAF_4m] Spectral Gothik (*) - COST:3 [ATK:0/HP:3] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the start of your turn, deal 4 damage to your hero.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_4m", new Power {
				// TODO [TB_KTRAF_4m] Spectral Gothik && Test: Spectral Gothik_TB_KTRAF_4m
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_KTRAF_5] Grand Widow Faerlina (*) - COST:4 [ATK:0/HP:5] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Has +1 Attack for each card in your opponent's hand.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_5", new Power {
				// TODO [TB_KTRAF_5] Grand Widow Faerlina && Test: Grand Widow Faerlina_TB_KTRAF_5
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_KTRAF_6] Grobbulus (*) - COST:5 [ATK:4/HP:7] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Whenever this kills a minion, summon a <b>Poisonous</b> 2/2 Slime.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			// RefTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_6", new Power {
				// TODO [TB_KTRAF_6] Grobbulus && Test: Grobbulus_TB_KTRAF_6
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_KTRAF_6m] Fallout Slime (*) - COST:1 [ATK:2/HP:2] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Poisonous</b>
			// --------------------------------------------------------
			// GameTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_6m", new Power {
				// TODO [TB_KTRAF_6m] Fallout Slime && Test: Fallout Slime_TB_KTRAF_6m
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_KTRAF_7] Heigan the Unclean (*) - COST:3 [ATK:4/HP:5] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the end of your turn, deal 4 damage to a  random enemy.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_7", new Power {
				// TODO [TB_KTRAF_7] Heigan the Unclean && Test: Heigan the Unclean_TB_KTRAF_7
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_KTRAF_8] Instructor Razuvious (*) - COST:8 [ATK:3/HP:3] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Equip a 5/2 Massive Runeblade.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_8", new Power {
				// TODO [TB_KTRAF_8] Instructor Razuvious && Test: Instructor Razuvious_TB_KTRAF_8
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_KTRAF_Under] Understudy (*) - COST:2 [ATK:0/HP:7] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_Under", new Power {
				// TODO [TB_KTRAF_Under] Understudy && Test: Understudy_TB_KTRAF_Under
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_MammothParty_Boss002] Piñata Golem (*) - COST:10 [ATK:5/HP:85] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Boss, Taunt</b>. Can't be targeted by spells. It's full of candy!
			// --------------------------------------------------------
			// Entourage: TB_MammothParty_303, TB_MammothParty_302, TB_MammothParty_301
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			// RefTag:
			// - BOSS = 1
			// --------------------------------------------------------
			cards.Add("TB_MammothParty_Boss002", new Power {
				// TODO [TB_MammothParty_Boss002] Piñata Golem && Test: Piñata Golem_TB_MammothParty_Boss002
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_MammothParty_m001] Party Crasher (*) - COST:4 [ATK:3/HP:5] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       You don't control how this minion attacks.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - AUTOATTACK = 1
			// --------------------------------------------------------
			cards.Add("TB_MammothParty_m001", new Power {
				// TODO [TB_MammothParty_m001] Party Crasher && Test: Party Crasher_TB_MammothParty_m001
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_MammothParty_m001_alt] Party Crasher (*) - COST:4 [ATK:3/HP:5] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       You don't control how this minion attacks.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - AUTOATTACK = 1
			// --------------------------------------------------------
			cards.Add("TB_MammothParty_m001_alt", new Power {
				// TODO [TB_MammothParty_m001_alt] Party Crasher && Test: Party Crasher_TB_MammothParty_m001_alt
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_MechWar_Minion1] Mech Fan (*) - COST:2 [ATK:1/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TB_MechWar_Minion1", new Power {
				// TODO [TB_MechWar_Minion1] Mech Fan && Test: Mech Fan_TB_MechWar_Minion1
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_MnkWf01] Nadia, Mankrik's Wife (*) - COST:2 [ATK:7/HP:7] 
			// - Race: orc, Set: tb, Rarity: legendary
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			//       <b>Deathrattle</b>: Complete your <b>Quest</b>.
			// --------------------------------------------------------
			// RefTag:
			// - QUEST = 1
			// --------------------------------------------------------
			cards.Add("TB_MnkWf01", new Power {
				// TODO [TB_MnkWf01] Nadia, Mankrik's Wife && Test: Nadia, Mankrik's Wife_TB_MnkWf01
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_Noblegarden_002] Noblegarden Egg (*) - COST:2 [ATK:0/HP:2] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Stealth</b>. At the start of your turn, hatch this into something cute.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_002", new Power {
				// TODO [TB_Noblegarden_002] Noblegarden Egg && Test: Noblegarden Egg_TB_Noblegarden_002
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_Noblegarden_002t1] Bunny (*) - COST:1 [ATK:1/HP:3] 
			// - Race: beast, Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_002t1", new Power {
				// TODO [TB_Noblegarden_002t1] Bunny && Test: Bunny_TB_Noblegarden_002t1
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_Noblegarden_002t2] Noblegarden Goblin (*) - COST:3 [ATK:5/HP:2] 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_002t2", new Power {
				// TODO [TB_Noblegarden_002t2] Noblegarden Goblin && Test: Noblegarden Goblin_TB_Noblegarden_002t2
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_Noblegarden_006] Hawkstrider Hen (*) - COST:6 [ATK:3/HP:7] 
			// - Race: beast, Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Battlecry and Deathrattle:</b> Summon a
			//       Noblegarden Egg.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_006", new Power {
				// TODO [TB_Noblegarden_006] Hawkstrider Hen && Test: Hawkstrider Hen_TB_Noblegarden_006
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_SPT_DPromoCrate1] Weapon Rack (*) - COST:1 [ATK:0/HP:4] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Current turn player gains a random weapon.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoCrate1", new Power {
				// TODO [TB_SPT_DPromoCrate1] Weapon Rack && Test: Weapon Rack_TB_SPT_DPromoCrate1
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_SPT_DPromoCrate2] Discarded Armor (*) - COST:1 [ATK:0/HP:4] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Current turn player gains 5 armor.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoCrate2", new Power {
				// TODO [TB_SPT_DPromoCrate2] Discarded Armor && Test: Discarded Armor_TB_SPT_DPromoCrate2
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_SPT_DPromoCrate3] Chest of Gold! (*) - COST:1 [ATK:0/HP:4] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Current turn player gains gold!
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoCrate3", new Power {
				// TODO [TB_SPT_DPromoCrate3] Chest of Gold! && Test: Chest of Gold!_TB_SPT_DPromoCrate3
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_SPT_DPromoMinion] Hell Bovine (*) - COST:3 [ATK:2/HP:2] 
			// - Race: demon, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Place a copy of this card in your deck.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoMinion", new Power {
				// TODO [TB_SPT_DPromoMinion] Hell Bovine && Test: Hell Bovine_TB_SPT_DPromoMinion
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_SPT_DPromoMinion2] Guardian (*) - COST:3 [ATK:2/HP:4] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At end of your turn, deal 2 damage to the enemies opposite this minion.
			// --------------------------------------------------------
			// GameTag:
			// - CANT_ATTACK = 1
			// --------------------------------------------------------
			// RefTag:
			// - AUTOATTACK = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoMinion2", new Power {
				// TODO [TB_SPT_DPromoMinion2] Guardian && Test: Guardian_TB_SPT_DPromoMinion2
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_SPT_DPromoMinionChamp] Hell Bovine Champion (*) - COST:5 [ATK:4/HP:4] 
			// - Race: demon, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Current turn player gains a random weapon.
			// --------------------------------------------------------
			// Entourage: AT_050, CS2_112, LOE_118, EX1_567, TB_BlingBrawl_Weapon, CS2_106, CFM_631, CS2_080
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoMinionChamp", new Power {
				// TODO [TB_SPT_DPromoMinionChamp] Hell Bovine Champion && Test: Hell Bovine Champion_TB_SPT_DPromoMinionChamp
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_SPT_DPromoMinionInit] Hell Bovine (*) - COST:3 [ATK:2/HP:2] 
			// - Race: demon, Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Place a copy of this card in your deck.
			// --------------------------------------------------------
			// GameTag:
			// - DEATHRATTLE = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoMinionInit", new Power {
				// TODO [TB_SPT_DPromoMinionInit] Hell Bovine && Test: Hell Bovine_TB_SPT_DPromoMinionInit
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_SPT_DpromoPortal] Enigmatic Portal (*) - COST:4 [ATK:0/HP:10] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the start of next turn, your hero is transformed and sucked through the Twisting Nether.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// - IMMUNE = 1
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DpromoPortal", new Power {
				// TODO [TB_SPT_DpromoPortal] Enigmatic Portal && Test: Enigmatic Portal_TB_SPT_DpromoPortal
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_SPT_Minion1] Shieldsman (*) - COST:2 [ATK:0/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Gain Health equal to Stormwind's Attack.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_Minion1", new Power {
				// TODO [TB_SPT_Minion1] Shieldsman && Test: Shieldsman_TB_SPT_Minion1
				InfoCardId = "TB_SPT_Minion1e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_SPT_Minion2] Battle Standard (*) - COST:2 [ATK:0/HP:2] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Adjacent minions have +2 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ADJACENT_BUFF = 1
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_Minion2", new Power {
				// TODO [TB_SPT_Minion2] Battle Standard && Test: Battle Standard_TB_SPT_Minion2
				InfoCardId = "TB_SPT_Minion2e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_SPT_Minion3] Swordsman (*) - COST:3 [ATK:1/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain Attack and Health equal to Stormwind's Attack
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_Minion3", new Power {
				// TODO [TB_SPT_Minion3] Swordsman && Test: Swordsman_TB_SPT_Minion3
				InfoCardId = "TB_SPT_Minion3e",
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_SPT_MTH_Minion1] Happy Partygoer (*) - COST:2 [ATK:0/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			//       <b>Battlecry:</b> Gain Health equal to Stormwind's Attack.
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_MTH_Minion1", new Power {
				// TODO [TB_SPT_MTH_Minion1] Happy Partygoer && Test: Happy Partygoer_TB_SPT_MTH_Minion1
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_SPT_MTH_Minion2] Party Banner (*) - COST:2 [ATK:0/HP:2] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Adjacent minions have +2 Attack.
			// --------------------------------------------------------
			// GameTag:
			// - ADJACENT_BUFF = 1
			// - AURA = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_MTH_Minion2", new Power {
				// TODO [TB_SPT_MTH_Minion2] Party Banner && Test: Party Banner_TB_SPT_MTH_Minion2
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_SPT_MTH_Minion3] Ornery Partygoer (*) - COST:3 [ATK:1/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Battlecry:</b> Gain Attack and Health equal to Stormwind's Attack.
			// --------------------------------------------------------
			// GameTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_MTH_Minion3", new Power {
				// TODO [TB_SPT_MTH_Minion3] Ornery Partygoer && Test: Ornery Partygoer_TB_SPT_MTH_Minion3
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TB_VoidSingularityMinion] Void Singularity (*) - COST:1 [ATK:1/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_VoidSingularityMinion", new Power {
				// TODO [TB_VoidSingularityMinion] Void Singularity && Test: Void Singularity_TB_VoidSingularityMinion
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TBST_001] OLDN3wb Tank (*) - COST:1 [ATK:2/HP:2] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Taunt</b>
			// --------------------------------------------------------
			// GameTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TBST_001", new Power {
				// TODO [TBST_001] OLDN3wb Tank && Test: OLDN3wb Tank_TBST_001
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TBST_002] OLDN3wb Mage (*) - COST:1 [ATK:2/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the end of your turn, deal 1 damage to random enemy minion.
			// --------------------------------------------------------
			cards.Add("TBST_002", new Power {
				// TODO [TBST_002] OLDN3wb Mage && Test: OLDN3wb Mage_TBST_002
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TBST_003] OLDN3wb Healer (*) - COST:1 [ATK:1/HP:1] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the end of your turn, heal 2 damage from adjacent minions.
			// --------------------------------------------------------
			cards.Add("TBST_003", new Power {
				// TODO [TBST_003] OLDN3wb Healer && Test: OLDN3wb Healer_TBST_003
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TBST_004] OLDLegit Healer (*) - COST:3 [ATK:2/HP:2] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the end of your turn, summon a random friendly minion that died this turn.
			// --------------------------------------------------------
			cards.Add("TBST_004", new Power {
				// TODO [TBST_004] OLDLegit Healer && Test: OLDLegit Healer_TBST_004
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- MINION - NEUTRAL
			// [TBST_005] OLDPvP Rogue (*) - COST:3 [ATK:3/HP:6] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Stealth</b>
			//       Regain <b>Stealth</b> when PvP Rogue kills a minion.
			// --------------------------------------------------------
			// GameTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("TBST_005", new Power {
				// TODO [TBST_005] OLDPvP Rogue && Test: OLDPvP Rogue_TBST_005
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BRMA01_2H_2c_TB] Pile On!!! (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Hero Power</b>
			//       Put two minions from your deck and one from your opponent's into the battlefield.
			// --------------------------------------------------------
			cards.Add("BRMA01_2H_2c_TB", new Power {
				// TODO [BRMA01_2H_2c_TB] Pile On!!! && Test: Pile On!!!_BRMA01_2H_2c_TB
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BRMA02_2_2c_TB] Jeering Crowd (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Summon a 1/1 Spectator with <b>Taunt</b>.
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("BRMA02_2_2c_TB", new Power {
				// TODO [BRMA02_2_2c_TB] Jeering Crowd && Test: Jeering Crowd_BRMA02_2_2c_TB
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BRMA07_2_2c_TB] ME SMASH (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Destroy a random enemy minion.
			// --------------------------------------------------------
			cards.Add("BRMA07_2_2c_TB", new Power {
				// TODO [BRMA07_2_2c_TB] ME SMASH && Test: ME SMASH_BRMA07_2_2c_TB
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BRMC_100] Living Bomb (*) - COST:3 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Choose an enemy minion. If it lives until your next turn, deal $5 damage to all enemies. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_ENEMY_TARGET = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("BRMC_100", new Power {
				// TODO [BRMC_100] Living Bomb && Test: Living Bomb_BRMC_100
				InfoCardId = "BRMC_100e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BRMC_83] Open the Gates (*) - COST:8 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Fill your board with 2/2 Whelps.
			// --------------------------------------------------------
			cards.Add("BRMC_83", new Power {
				// TODO [BRMC_83] Open the Gates && Test: Open the Gates_BRMC_83
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BRMC_93] Omnotron Defense System (*) - COST:3 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Summon a random Tron.
			// --------------------------------------------------------
			// Entourage: BRMA14_3, BRMA14_5, BRMA14_7, BRMA14_9
			// --------------------------------------------------------
			cards.Add("BRMC_93", new Power {
				// TODO [BRMC_93] Omnotron Defense System && Test: Omnotron Defense System_BRMC_93
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [BRMC_95h] Core Hound Puppies (*) - COST:3 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Summon two 2/4 Core Hound Pups.
			// --------------------------------------------------------
			cards.Add("BRMC_95h", new Power {
				// TODO [BRMC_95h] Core Hound Puppies && Test: Core Hound Puppies_BRMC_95h
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_BuildABrawl001a] By the Power of Ragnaros! (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the end of your turn, reduce the Cost of cards in your hand by (1).
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl001a", new Power {
				// TODO [FB_BuildABrawl001a] By the Power of Ragnaros! && Test: By the Power of Ragnaros!_FB_BuildABrawl001a
				InfoCardId = "FB_BuildABrawl001a_ench",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_BuildABrawl001b] Randomonium (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the start of your turn, randomize the Cost of cards in your hand.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl001b", new Power {
				// TODO [FB_BuildABrawl001b] Randomonium && Test: Randomonium_FB_BuildABrawl001b
				InfoCardId = "FB_BuildABrawl001b_ench",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_BuildABrawl001c] Battle of Tol Barad (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: After you summon a minion, add a spell of the same Cost to your hand. 
			//        It costs (0).
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl001c", new Power {
				// TODO [FB_BuildABrawl001c] Battle of Tol Barad && Test: Battle of Tol Barad_FB_BuildABrawl001c
				InfoCardId = "FB_BuildABrawl001c_ench",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_BuildABrawl002a] Summoner Competition (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: After you cast a spell, summon a random minion of the same Cost.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl002a", new Power {
				// TODO [FB_BuildABrawl002a] Summoner Competition && Test: Summoner Competition_FB_BuildABrawl002a
				InfoCardId = "FB_BuildABrawl002a_ench",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_BuildABrawl002b] The Masked Ball (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: After you summon a minion, give it "<b>Deathrattle:</b> Summon a minion that costs (2) less."
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl002b", new Power {
				// TODO [FB_BuildABrawl002b] The Masked Ball && Test: The Masked Ball_FB_BuildABrawl002b
				InfoCardId = "FB_BuildABrawl002b_ench",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_BuildABrawl002c] Servant of Yogg Tryouts (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: After you summon a minion, cast a random spell on a random target.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl002c", new Power {
				// TODO [FB_BuildABrawl002c] Servant of Yogg Tryouts && Test: Servant of Yogg Tryouts_FB_BuildABrawl002c
				InfoCardId = "FB_BuildABrawl002c_ench",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_BuildABrawl003b] Clash of the Minions (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: After you summon a minion, give it <b>Charge</b> and <b>Taunt</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl003b", new Power {
				// TODO [FB_BuildABrawl003b] Clash of the Minions && Test: Clash of the Minions_FB_BuildABrawl003b
				InfoCardId = "FB_BuildABrawl003b_ench",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_BuildABrawl003c] Blood Magic (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: All spells cost Health instead of Mana.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl003c", new Power {
				// TODO [FB_BuildABrawl003c] Blood Magic && Test: Blood Magic_FB_BuildABrawl003c
				InfoCardId = "FB_BuildABrawl003c_ench",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_BuildABrawl_Tools_reset] Build-A-Brawl (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Choose a new blend of Tavern Brawls for your Fireside Gathering.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("FB_BuildABrawl_Tools_reset", new Power {
				// TODO [FB_BuildABrawl_Tools_reset] Build-A-Brawl && Test: Build-A-Brawl_FB_BuildABrawl_Tools_reset
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_Champs_Reset] Reset the Brawl (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Reset the Champions' Win Percents to 0.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 12
			// --------------------------------------------------------
			cards.Add("FB_Champs_Reset", new Power {
				// TODO [FB_Champs_Reset] Reset the Brawl && Test: Reset the Brawl_FB_Champs_Reset
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_ELO001a] Play the Brawl (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Continue playing normally.
			// --------------------------------------------------------
			cards.Add("FB_ELO001a", new Power {
				// TODO [FB_ELO001a] Play the Brawl && Test: Play the Brawl_FB_ELO001a
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_ELO001b] Reset the Brawl (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Reset all player wins to 0.
			// --------------------------------------------------------
			cards.Add("FB_ELO001b", new Power {
				// TODO [FB_ELO001b] Reset the Brawl && Test: Reset the Brawl_FB_ELO001b
				InfoCardId = "FB_ELO001bench",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_ELO001c] Confirm (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Reset all Fireside Gathering Player wins. This will end the current game.
			// --------------------------------------------------------
			cards.Add("FB_ELO001c", new Power {
				// TODO [FB_ELO001c] Confirm && Test: Confirm_FB_ELO001c
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_ELO001d] Cancel (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Do NOT reset Fireside Gathering Player wins. Play the Brawl as normal.
			// --------------------------------------------------------
			cards.Add("FB_ELO001d", new Power {
				// TODO [FB_ELO001d] Cancel && Test: Cancel_FB_ELO001d
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_ELO002a] Spirit of Heroism (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Reduce the cost of your Hero Power by (1).
			// --------------------------------------------------------
			cards.Add("FB_ELO002a", new Power {
				// TODO [FB_ELO002a] Spirit of Heroism && Test: Spirit of Heroism_FB_ELO002a
				InfoCardId = "FB_ELO002a_ench",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_ELO002a_copy] Greater Spirit of Heroism (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Replace your starting Hero Power with a better one. It costs (0).
			// --------------------------------------------------------
			cards.Add("FB_ELO002a_copy", new Power {
				// TODO [FB_ELO002a_copy] Greater Spirit of Heroism && Test: Greater Spirit of Heroism_FB_ELO002a_copy
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_ELO002b] Spirit of Wisdom (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Reduce the Cost of all spells in your deck and hand by (1).
			// --------------------------------------------------------
			cards.Add("FB_ELO002b", new Power {
				// TODO [FB_ELO002b] Spirit of Wisdom && Test: Spirit of Wisdom_FB_ELO002b
				InfoCardId = "FB_ELO002b_ench",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_ELO002b_copy] Greater Spirit of Wisdom (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Reduce the Cost of all spells in your deck and hand by (2).
			// --------------------------------------------------------
			cards.Add("FB_ELO002b_copy", new Power {
				// TODO [FB_ELO002b_copy] Greater Spirit of Wisdom && Test: Greater Spirit of Wisdom_FB_ELO002b_copy
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_ELO002c] Spirit of Strength (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Give all minions in your deck and hand 
			//       +1 Attack.
			// --------------------------------------------------------
			cards.Add("FB_ELO002c", new Power {
				// TODO [FB_ELO002c] Spirit of Strength && Test: Spirit of Strength_FB_ELO002c
				InfoCardId = "FB_ELO002c_ench",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_ELO002c_copy] Greater Spirit of Strength (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Give all minions in your deck and hand 
			//       +2 Attack.
			// --------------------------------------------------------
			cards.Add("FB_ELO002c_copy", new Power {
				// TODO [FB_ELO002c_copy] Greater Spirit of Strength && Test: Greater Spirit of Strength_FB_ELO002c_copy
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_IKC_SetupNo] Play! (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Play the brawl normally.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_IKC_SetupNo", new Power {
				// TODO [FB_IKC_SetupNo] Play! && Test: Play!_FB_IKC_SetupNo
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_IKC_SetupYes] Set Up Brawl (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Change the Innkeeper's Choice card.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("FB_IKC_SetupYes", new Power {
				// TODO [FB_IKC_SetupYes] Set Up Brawl && Test: Set Up Brawl_FB_IKC_SetupYes
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_LK004] Calling for Backup (*) - COST:10 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Choose the next Hero.
			// --------------------------------------------------------
			cards.Add("FB_LK004", new Power {
				// TODO [FB_LK004] Calling for Backup && Test: Calling for Backup_FB_LK004
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_LK010] The Final Battle (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Show The Lich King your true form!
			// --------------------------------------------------------
			cards.Add("FB_LK010", new Power {
				// TODO [FB_LK010] The Final Battle && Test: The Final Battle_FB_LK010
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_LK011] Cancelling the Apocalypse! (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Destroy all minions.
			//       <i>Nice try, Uther!</i>
			// --------------------------------------------------------
			cards.Add("FB_LK011", new Power {
				// TODO [FB_LK011] Cancelling the Apocalypse! && Test: Cancelling the Apocalypse!_FB_LK011
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_LK_ClearBoard] A New Hero Approaches (*) - COST:10 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Destroy all minions. Drain all Mana.
			// --------------------------------------------------------
			cards.Add("FB_LK_ClearBoard", new Power {
				// TODO [FB_LK_ClearBoard] A New Hero Approaches && Test: A New Hero Approaches_FB_LK_ClearBoard
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_LK_NewHeroCards] New Hero! (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: A new Hero takes position.
			// --------------------------------------------------------
			cards.Add("FB_LK_NewHeroCards", new Power {
				// TODO [FB_LK_NewHeroCards] New Hero! && Test: New Hero!_FB_LK_NewHeroCards
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_LKDebug001] LK Phase 2 Debug (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Change boss to phase 2
			// --------------------------------------------------------
			cards.Add("FB_LKDebug001", new Power {
				// TODO [FB_LKDebug001] LK Phase 2 Debug && Test: LK Phase 2 Debug_FB_LKDebug001
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_LKDebug002] LK Phase 3 Debug (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Change boss to phase 3
			// --------------------------------------------------------
			cards.Add("FB_LKDebug002", new Power {
				// TODO [FB_LKDebug002] LK Phase 3 Debug && Test: LK Phase 3 Debug_FB_LKDebug002
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_LKStats001a] Fight the Lich King! (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Continue playing normally.
			// --------------------------------------------------------
			cards.Add("FB_LKStats001a", new Power {
				// TODO [FB_LKStats001a] Fight the Lich King! && Test: Fight the Lich King!_FB_LKStats001a
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_LKStats001d] Modify the Lich King (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Change Health, Assign Modifiers.
			// --------------------------------------------------------
			// Entourage: FB_LKStats002a, FB_LKStats002b, FB_LKStats002c
			// --------------------------------------------------------
			cards.Add("FB_LKStats001d", new Power {
				// TODO [FB_LKStats001d] Modify the Lich King && Test: Modify the Lich King_FB_LKStats001d
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_LKStats002] Lich King Modifications (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Increase or Decrease the maximum health of the Lich King.
			// --------------------------------------------------------
			cards.Add("FB_LKStats002", new Power {
				// TODO [FB_LKStats002] Lich King Modifications && Test: Lich King Modifications_FB_LKStats002
				InfoCardId = "FB_LKStats002ench",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_LKStats002a] Increase Health (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Increase the Lich King's maximum health by 10%.
			// --------------------------------------------------------
			// Entourage: FB_LKStats002a, FB_LKStats002b, FB_LKStats002c
			// --------------------------------------------------------
			cards.Add("FB_LKStats002a", new Power {
				// TODO [FB_LKStats002a] Increase Health && Test: Increase Health_FB_LKStats002a
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_LKStats002b] Decrease Health (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Decrease the Lich King's maximum health by 10%
			// --------------------------------------------------------
			// Entourage: FB_LKStats002a, FB_LKStats002b, FB_LKStats002c
			// --------------------------------------------------------
			cards.Add("FB_LKStats002b", new Power {
				// TODO [FB_LKStats002b] Decrease Health && Test: Decrease Health_FB_LKStats002b
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [FB_LKStats002c] Modifications Complete (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Lock in the new maximum health. This will end the setup phase.
			// --------------------------------------------------------
			// Entourage: FB_LKStats001a, 00000011-f9e0-4b0b-852d-9f932641109f
			// --------------------------------------------------------
			cards.Add("FB_LKStats002c", new Power {
				// TODO [FB_LKStats002c] Modifications Complete && Test: Modifications Complete_FB_LKStats002c
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [NAX12_02H_2c_TB] Decimate (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Change the Health of enemy minions to 1.
			// --------------------------------------------------------
			cards.Add("NAX12_02H_2c_TB", new Power {
				// TODO [NAX12_02H_2c_TB] Decimate && Test: Decimate_NAX12_02H_2c_TB
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_006] Big Banana (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Give a minion +2/+2.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TB_006", new Power {
				// TODO [TB_006] Big Banana && Test: Big Banana_TB_006
				InfoCardId = "TB_006e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_007] Deviate Banana (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Swap a minion's Attack and Health.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TB_007", new Power {
				// TODO [TB_007] Deviate Banana && Test: Deviate Banana_TB_007
				InfoCardId = "TB_007e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_008] Rotten Banana (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Deal $1 damage. @spelldmg
			// --------------------------------------------------------
			// GameTag:
			// - AFFECTED_BY_SPELL_POWER = 1
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("TB_008", new Power {
				// TODO [TB_008] Rotten Banana && Test: Rotten Banana_TB_008
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_011] Tarnished Coin (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Gain 1 Mana Crystal this turn only.
			// --------------------------------------------------------
			cards.Add("TB_011", new Power {
				// TODO [TB_011] Tarnished Coin && Test: Tarnished Coin_TB_011
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_012] Choose a New Card! (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Look at 3 random cards. Choose one and shuffle it into your deck.
			// --------------------------------------------------------
			cards.Add("TB_012", new Power {
				// TODO [TB_012] Choose a New Card! && Test: Choose a New Card!_TB_012
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_014] Choose a New Card! (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Look at 3 random cards. Choose one and put it into your hand.
			// --------------------------------------------------------
			cards.Add("TB_014", new Power {
				// TODO [TB_014] Choose a New Card! && Test: Choose a New Card!_TB_014
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpBossSpell_1] Prioritize (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Deal Attack damage to biggest minion.
			// --------------------------------------------------------
			cards.Add("TB_CoOpBossSpell_1", new Power {
				// TODO [TB_CoOpBossSpell_1] Prioritize && Test: Prioritize_TB_CoOpBossSpell_1
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpBossSpell_2] Bomb Salvo (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Deal Attack damage to up to 3 random targets.
			// --------------------------------------------------------
			cards.Add("TB_CoOpBossSpell_2", new Power {
				// TODO [TB_CoOpBossSpell_2] Bomb Salvo && Test: Bomb Salvo_TB_CoOpBossSpell_2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpBossSpell_3] Release Coolant (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Freeze and deal Attack damage to all minions.
			//       Gain 2 Attack.
			// --------------------------------------------------------
			cards.Add("TB_CoOpBossSpell_3", new Power {
				// TODO [TB_CoOpBossSpell_3] Release Coolant && Test: Release Coolant_TB_CoOpBossSpell_3
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpBossSpell_4] Overclock (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Gain 2 Attack.
			// --------------------------------------------------------
			cards.Add("TB_CoOpBossSpell_4", new Power {
				// TODO [TB_CoOpBossSpell_4] Overclock && Test: Overclock_TB_CoOpBossSpell_4
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpBossSpell_5] Double Zap (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Deal Attack damage to both players.
			// --------------------------------------------------------
			cards.Add("TB_CoOpBossSpell_5", new Power {
				// TODO [TB_CoOpBossSpell_5] Double Zap && Test: Double Zap_TB_CoOpBossSpell_5
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpBossSpell_6] Kill the Lorewalker (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Destroy Lorewalker Cho.
			// --------------------------------------------------------
			cards.Add("TB_CoOpBossSpell_6", new Power {
				// TODO [TB_CoOpBossSpell_6] Kill the Lorewalker && Test: Kill the Lorewalker_TB_CoOpBossSpell_6
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoopHero_002] Power (Spell) (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Armies!!
			// --------------------------------------------------------
			// GameTag:
			// - HERO_POWER = 2379
			// --------------------------------------------------------
			cards.Add("TB_CoopHero_002", new Power {
				// TODO [TB_CoopHero_002] Power (Spell) && Test: Power (Spell)_TB_CoopHero_002
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpv3_001] Glorious Finale (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: The true battle begins....
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_001", new Power {
				// TODO [TB_CoOpv3_001] Glorious Finale && Test: Glorious Finale_TB_CoOpv3_001
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpv3_003] Bamboozle (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Swap player's hands.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_003", new Power {
				// TODO [TB_CoOpv3_003] Bamboozle && Test: Bamboozle_TB_CoOpv3_003
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpv3_004] Cleave (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Deal 7 damage to a minion and its owner.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_004", new Power {
				// TODO [TB_CoOpv3_004] Cleave && Test: Cleave_TB_CoOpv3_004
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpv3_005] Cleave (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Deal 4 damage to a minion and its owner.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_005", new Power {
				// TODO [TB_CoOpv3_005] Cleave && Test: Cleave_TB_CoOpv3_005
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpv3_007] Flame Missiles (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Deal 5 damage randomly split among all other characters.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_007", new Power {
				// TODO [TB_CoOpv3_007] Flame Missiles && Test: Flame Missiles_TB_CoOpv3_007
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpv3_008] Flame Missiles (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Deal 10 damage randomly split among all other characters.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_008", new Power {
				// TODO [TB_CoOpv3_008] Flame Missiles && Test: Flame Missiles_TB_CoOpv3_008
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpv3_009] Explosive Rune (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Summon an 'Explosive Rune.'
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_009", new Power {
				// TODO [TB_CoOpv3_009] Explosive Rune && Test: Explosive Rune_TB_CoOpv3_009
				InfoCardId = "TB_CoOpv3_009e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpv3_010] Explosive Runes (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Summon two 'Explosive Runes.'
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_010", new Power {
				// TODO [TB_CoOpv3_010] Explosive Runes && Test: Explosive Runes_TB_CoOpv3_010
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpv3_011] Don't Push Me! (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: He's getting angry....
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_011", new Power {
				// TODO [TB_CoOpv3_011] Don't Push Me! && Test: Don't Push Me!_TB_CoOpv3_011
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpv3_012] Immolate (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Deal 4 damage to each hero.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_012", new Power {
				// TODO [TB_CoOpv3_012] Immolate && Test: Immolate_TB_CoOpv3_012
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpv3_013] Immolate (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Deal 7 damage to each hero.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_013", new Power {
				// TODO [TB_CoOpv3_013] Immolate && Test: Immolate_TB_CoOpv3_013
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpv3_202] Vicious Swipe (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Deal attack damage to 2 random minions.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_202", new Power {
				// TODO [TB_CoOpv3_202] Vicious Swipe && Test: Vicious Swipe_TB_CoOpv3_202
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_CoOpv3_203] Meddling Fool! (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Damage the Lorewalker
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_CoOpv3_203", new Power {
				// TODO [TB_CoOpv3_203] Meddling Fool! && Test: Meddling Fool!_TB_CoOpv3_203
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_DiscoverMyDeck_Discovery] Peruse (*) - COST:1 
			// - Set: tb, Rarity: common
			// --------------------------------------------------------
			// Text: <b>Discover</b> a card from your deck.
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("TB_DiscoverMyDeck_Discovery", new Power {
				// TODO [TB_DiscoverMyDeck_Discovery] Peruse && Test: Peruse_TB_DiscoverMyDeck_Discovery
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_FoxBlessing] Blessing of the Raven (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Each minion summoned gains either <b>Lifesteal</b>, <b>Poisonous</b>, <b>Stealth</b>, <b>Charge</b> or <b>Windfury</b>.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_STATS = 1
			// --------------------------------------------------------
			cards.Add("TB_FoxBlessing", new Power {
				// TODO [TB_FoxBlessing] Blessing of the Raven && Test: Blessing of the Raven_TB_FoxBlessing
				InfoCardId = "TB_FoxBlessing1",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_GiftExchange_Snowball] Hardpacked Snowballs (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Return 3 random enemy minions to your opponent's hand.
			// --------------------------------------------------------
			cards.Add("TB_GiftExchange_Snowball", new Power {
				// TODO [TB_GiftExchange_Snowball] Hardpacked Snowballs && Test: Hardpacked Snowballs_TB_GiftExchange_Snowball
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_GiftExchange_Treasure_Spell] Stolen Winter's Veil Gift (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Discover</b> a random Treasure. Its cost is reduced.
			// --------------------------------------------------------
			// RefTag:
			// - DISCOVER = 1
			// --------------------------------------------------------
			cards.Add("TB_GiftExchange_Treasure_Spell", new Power {
				// TODO [TB_GiftExchange_Treasure_Spell] Stolen Winter's Veil Gift && Test: Stolen Winter's Veil Gift_TB_GiftExchange_Treasure_Spell
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_HeadlessHorseman_s001a] Witch Costume (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Dress up as a Witch. Draw a new hand.
			// --------------------------------------------------------
			// Entourage: EX1_246, CFM_603, LOE_046, LOE_115, KAR_300, OG_179, CS2_013, EX1_277, GVG_001, CS2_023, UNG_948, OG_090, CFM_661, DS1_233, CS2_234, UNG_029, ICC_802, CS2_053
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_s001a", new Power {
				// TODO [TB_HeadlessHorseman_s001a] Witch Costume && Test: Witch Costume_TB_HeadlessHorseman_s001a
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_HeadlessHorseman_s001b] Cat Costume (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Dress up as a Cat.
			//       Draw a new hand.
			// --------------------------------------------------------
			// Entourage: CFM_315, GVG_034, EX1_165, KAR_004, KARA_05_02, CS2_005, UNG_910, EX1_570, AT_042, UNG_812, GVG_046, NAX15_05, KARA_07_05heroic, EX1_028, EX1_534, ICC_079, CS2_011, CS2_012
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_s001b", new Power {
				// TODO [TB_HeadlessHorseman_s001b] Cat Costume && Test: Cat Costume_TB_HeadlessHorseman_s001b
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_HeadlessHorseman_s001c] Pirate Costume (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Dress up as a Pirate. Draw a new hand.
			// --------------------------------------------------------
			// Entourage: CFM_637, GVG_075, GVG_075, NEW1_027, NEW1_027, OG_315, OG_315, AT_070, GVG_025, GVG_025, AT_032, AT_032, CS2_106, ICC_018, OG_312, CS2_080, EX1_133
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_s001c", new Power {
				// TODO [TB_HeadlessHorseman_s001c] Pirate Costume && Test: Pirate Costume_TB_HeadlessHorseman_s001c
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_HeadlessHorseman_s004] Fiery Burst (*) - COST:3 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Deal 2 damage to all enemies.
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_s004", new Power {
				// TODO [TB_HeadlessHorseman_s004] Fiery Burst && Test: Fiery Burst_TB_HeadlessHorseman_s004
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_HeadlessHorseman_s005] Fear (*) - COST:7 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Destroy all enemy minions with 4 or less Attack.
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_s005", new Power {
				// TODO [TB_HeadlessHorseman_s005] Fear && Test: Fear_TB_HeadlessHorseman_s005
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_HeadlessHorseman_XXX] Create Horseman (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Your hero becomes the Horseman. Cast again to become the 2nd form.
			// --------------------------------------------------------
			cards.Add("TB_HeadlessHorseman_XXX", new Power {
				// TODO [TB_HeadlessHorseman_XXX] Create Horseman && Test: Create Horseman_TB_HeadlessHorseman_XXX
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_KaraPortal_001] Party Portal! (*) - COST:3 
			// - Set: tb, Rarity: free
			// --------------------------------------------------------
			// Text: Summon a random Partygoer.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TB_KaraPortal_001", new Power {
				// TODO [TB_KaraPortal_001] Party Portal! && Test: Party Portal!_TB_KaraPortal_001
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_KaraPortal_002] Call Mediva (*) - COST:2 
			// - Set: tb, Rarity: free
			// --------------------------------------------------------
			// Text: Summon a random Mediva
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_MINION_TARGET = 0
			// --------------------------------------------------------
			cards.Add("TB_KaraPortal_002", new Power {
				// TODO [TB_KaraPortal_002] Call Mediva && Test: Call Mediva_TB_KaraPortal_002
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_KoboldGiftSpell] Great Father Kobold Spell (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			cards.Add("TB_KoboldGiftSpell", new Power {
				// TODO [TB_KoboldGiftSpell] Great Father Kobold Spell && Test: Great Father Kobold Spell_TB_KoboldGiftSpell
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_KTRAF_101] Darkness Calls (*) - COST:8 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Summon two random Naxxramas bosses and trigger their <b>Battlecries</b>.
			// --------------------------------------------------------
			// Entourage: TB_KTRAF_1, TB_KTRAF_3, TB_KTRAF_4, TB_KTRAF_5, TB_KTRAF_6, TB_KTRAF_7, TB_KTRAF_8, TB_KTRAF_2, TB_KTRAF_10, TB_KTRAF_12, TB_KTRAF_11
			// --------------------------------------------------------
			// RefTag:
			// - BATTLECRY = 1
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_101", new Power {
				// TODO [TB_KTRAF_101] Darkness Calls && Test: Darkness Calls_TB_KTRAF_101
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_KTRAF_104] Uncover Staff Piece (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Add another piece to your Hero Power.
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_104", new Power {
				// TODO [TB_KTRAF_104] Uncover Staff Piece && Test: Uncover Staff Piece_TB_KTRAF_104
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Lethal002] Puzzle 1 (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Seems simple enough.
			// --------------------------------------------------------
			cards.Add("TB_Lethal002", new Power {
				// TODO [TB_Lethal002] Puzzle 1 && Test: Puzzle 1_TB_Lethal002
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Lethal003] Puzzle 2 (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Survival percentage is 32.33 repeating of course.
			// --------------------------------------------------------
			cards.Add("TB_Lethal003", new Power {
				// TODO [TB_Lethal003] Puzzle 2 && Test: Puzzle 2_TB_Lethal003
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Lethal004] Puzzle 5 (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Go Go Malygos!
			// --------------------------------------------------------
			cards.Add("TB_Lethal004", new Power {
				// TODO [TB_Lethal004] Puzzle 5 && Test: Puzzle 5_TB_Lethal004
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Lethal005] Puzzle 6 (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Heal em to death!
			// --------------------------------------------------------
			cards.Add("TB_Lethal005", new Power {
				// TODO [TB_Lethal005] Puzzle 6 && Test: Puzzle 6_TB_Lethal005
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Lethal006] Puzzle 7 (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: An inspiration to totems everywhere!
			// --------------------------------------------------------
			cards.Add("TB_Lethal006", new Power {
				// TODO [TB_Lethal006] Puzzle 7 && Test: Puzzle 7_TB_Lethal006
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Lethal007] Puzzle 3 (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: BY PUZZLE BE PURGED!
			// --------------------------------------------------------
			cards.Add("TB_Lethal007", new Power {
				// TODO [TB_Lethal007] Puzzle 3 && Test: Puzzle 3_TB_Lethal007
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Lethal008] Puzzle 9 (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: What!? This again?
			// --------------------------------------------------------
			cards.Add("TB_Lethal008", new Power {
				// TODO [TB_Lethal008] Puzzle 9 && Test: Puzzle 9_TB_Lethal008
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Lethal009] Puzzle 4 (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Beasts, Beasts and more Beasts!
			// --------------------------------------------------------
			cards.Add("TB_Lethal009", new Power {
				// TODO [TB_Lethal009] Puzzle 4 && Test: Puzzle 4_TB_Lethal009
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Lethal010] Puzzle 8 (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: A chilly challenge!
			// --------------------------------------------------------
			cards.Add("TB_Lethal010", new Power {
				// TODO [TB_Lethal010] Puzzle 8 && Test: Puzzle 8_TB_Lethal010
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_LethalSetup001a] Continue (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Continue from where you left off.
			// --------------------------------------------------------
			cards.Add("TB_LethalSetup001a", new Power {
				// TODO [TB_LethalSetup001a] Continue && Test: Continue_TB_LethalSetup001a
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_LethalSetup001b] Restart (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Start again at the beginning.
			// --------------------------------------------------------
			cards.Add("TB_LethalSetup001b", new Power {
				// TODO [TB_LethalSetup001b] Restart && Test: Restart_TB_LethalSetup001b
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_MammothParty_301] Rock Candy (*) - COST:3 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Destroy a random Party Crasher.
			// --------------------------------------------------------
			// GameTag:
			// - UNTOUCHABLE = 1
			// --------------------------------------------------------
			cards.Add("TB_MammothParty_301", new Power {
				// TODO [TB_MammothParty_301] Rock Candy && Test: Rock Candy_TB_MammothParty_301
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_MammothParty_302] Regenerative Cookies (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Restore 4 Health to each hero.
			// --------------------------------------------------------
			// GameTag:
			// - UNTOUCHABLE = 1
			// --------------------------------------------------------
			cards.Add("TB_MammothParty_302", new Power {
				// TODO [TB_MammothParty_302] Regenerative Cookies && Test: Regenerative Cookies_TB_MammothParty_302
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_MammothParty_303] Divine Sweets (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Each player draws a card.
			// --------------------------------------------------------
			// GameTag:
			// - UNTOUCHABLE = 1
			// --------------------------------------------------------
			cards.Add("TB_MammothParty_303", new Power {
				// TODO [TB_MammothParty_303] Divine Sweets && Test: Divine Sweets_TB_MammothParty_303
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_MammothParty_s004] Something in the Punch (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Deal 2 damage to all minions other than Party Crashers.
			// --------------------------------------------------------
			// GameTag:
			// - UNTOUCHABLE = 1
			// --------------------------------------------------------
			cards.Add("TB_MammothParty_s004", new Power {
				// TODO [TB_MammothParty_s004] Something in the Punch && Test: Something in the Punch_TB_MammothParty_s004
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_MammothParty_s101] Party Supplies (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Choose One - </b> Destroy a random Party Crasher; or Each player draws a card.
			// --------------------------------------------------------
			cards.Add("TB_MammothParty_s101", new Power {
				// TODO [TB_MammothParty_s101] Party Supplies && Test: Party Supplies_TB_MammothParty_s101
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_MammothParty_s101a] Fruit Plate (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Each player draws a card.
			// --------------------------------------------------------
			// GameTag:
			// - UNTOUCHABLE = 1
			// --------------------------------------------------------
			cards.Add("TB_MammothParty_s101a", new Power {
				// TODO [TB_MammothParty_s101a] Fruit Plate && Test: Fruit Plate_TB_MammothParty_s101a
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_MammothParty_s101b] Like a Sore Thumb (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Destroy a random Party Crasher.
			// --------------------------------------------------------
			// GameTag:
			// - UNTOUCHABLE = 1
			// --------------------------------------------------------
			cards.Add("TB_MammothParty_s101b", new Power {
				// TODO [TB_MammothParty_s101b] Like a Sore Thumb && Test: Like a Sore Thumb_TB_MammothParty_s101b
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_MammothParty_s998] Noise Complaint (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: If the board opposing the <b>Boss</b> is full, destroy all those minions.
			// --------------------------------------------------------
			// GameTag:
			// - UNTOUCHABLE = 1
			// --------------------------------------------------------
			cards.Add("TB_MammothParty_s998", new Power {
				// TODO [TB_MammothParty_s998] Noise Complaint && Test: Noise Complaint_TB_MammothParty_s998
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Marin_001] Journey to the Catacombs (*) - COST:1 
			// - Set: tb, Rarity: legendary
			// --------------------------------------------------------
			// Text: [x]<b>Quest:</b> 7 minions are played
			//        by ANY player.
			//       <b>Reward:</b> Master Chests
			//        for all!
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - ImmuneToSpellpower = 1
			// - QUEST = 1
			// - QUEST_PROGRESS_TOTAL = 7
			// - 676 = 1
			// --------------------------------------------------------
			cards.Add("TB_Marin_001", new Power {
				// TODO [TB_Marin_001] Journey to the Catacombs && Test: Journey to the Catacombs_TB_Marin_001
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Noblegarden_003] Shifting Dye (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Each turn this is in your hand, transform it into a random dye.
			// --------------------------------------------------------
			// Entourage: TB_Noblegarden_003t1, TB_Noblegarden_003t7, TB_Noblegarden_003t3, TB_Noblegarden_003t5, TB_Noblegarden_003t2, TB_Noblegarden_003t4, TB_Noblegarden_003t6, TB_Noblegarden_003t8
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_CANNOT_PLAY_THIS = 0
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003", new Power {
				// TODO [TB_Noblegarden_003] Shifting Dye && Test: Shifting Dye_TB_Noblegarden_003
				InfoCardId = "TB_Noblegarden_003e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Noblegarden_003t1] Blue Shifting Dye (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Dye an Egg. When it hatches, it grants <b>Windfury</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_WITH_RACE = 38
			// --------------------------------------------------------
			// RefTag:
			// - WINDFURY = 1
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t1", new Power {
				// TODO [TB_Noblegarden_003t1] Blue Shifting Dye && Test: Blue Shifting Dye_TB_Noblegarden_003t1
				InfoCardId = "TB_Noblegarden_003t1e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Noblegarden_003t2] Purple Shifting Dye (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Dye an Egg. When it hatches, it grants <b>Lifesteal</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_WITH_RACE = 38
			// --------------------------------------------------------
			// RefTag:
			// - LIFESTEAL = 1
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t2", new Power {
				// TODO [TB_Noblegarden_003t2] Purple Shifting Dye && Test: Purple Shifting Dye_TB_Noblegarden_003t2
				InfoCardId = "TB_Noblegarden_003t2e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Noblegarden_003t3] Green Shifting Dye (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Dye an Egg. When it hatches, it grants <b>Poisonous</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_WITH_RACE = 38
			// --------------------------------------------------------
			// RefTag:
			// - POISONOUS = 1
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t3", new Power {
				// TODO [TB_Noblegarden_003t3] Green Shifting Dye && Test: Green Shifting Dye_TB_Noblegarden_003t3
				InfoCardId = "TB_Noblegarden_003t3e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Noblegarden_003t4] Silver Shifting Dye (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Dye an Egg. When it hatches, it grants <b>Stealth</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_WITH_RACE = 38
			// --------------------------------------------------------
			// RefTag:
			// - STEALTH = 1
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t4", new Power {
				// TODO [TB_Noblegarden_003t4] Silver Shifting Dye && Test: Silver Shifting Dye_TB_Noblegarden_003t4
				InfoCardId = "TB_Noblegarden_003t4e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Noblegarden_003t5] Orange Shifting Dye (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Dye an Egg. When it hatches, it grants <b>Rush</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_WITH_RACE = 38
			// --------------------------------------------------------
			// RefTag:
			// - RUSH = 1
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t5", new Power {
				// TODO [TB_Noblegarden_003t5] Orange Shifting Dye && Test: Orange Shifting Dye_TB_Noblegarden_003t5
				InfoCardId = "TB_Noblegarden_003t5e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Noblegarden_003t6] Pink Shifting Dye (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Dye an Egg. When it hatches, it grants <b>Taunt</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_WITH_RACE = 38
			// --------------------------------------------------------
			// RefTag:
			// - TAUNT = 1
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t6", new Power {
				// TODO [TB_Noblegarden_003t6] Pink Shifting Dye && Test: Pink Shifting Dye_TB_Noblegarden_003t6
				InfoCardId = "TB_Noblegarden_003t6e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Noblegarden_003t7] Gold Shifting Dye (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Dye an Egg. When it hatches, it grants <b>Divine Shield</b>.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_WITH_RACE = 38
			// --------------------------------------------------------
			// RefTag:
			// - DIVINE_SHIELD = 1
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t7", new Power {
				// TODO [TB_Noblegarden_003t7] Gold Shifting Dye && Test: Gold Shifting Dye_TB_Noblegarden_003t7
				InfoCardId = "TB_Noblegarden_003t7e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Noblegarden_003t8] Red Shifting Dye (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Dye an Egg. When it hatches, it grants +2/+2.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// - REQ_MINION_TARGET = 0
			// - REQ_TARGET_WITH_RACE = 38
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_003t8", new Power {
				// TODO [TB_Noblegarden_003t8] Red Shifting Dye && Test: Red Shifting Dye_TB_Noblegarden_003t8
				InfoCardId = "TB_Noblegarden_003t8e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Noblegarden_004] Noblegarden Spoon (*) - COST:3 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Hatch your Noblegarden Eggs!
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_004", new Power {
				// TODO [TB_Noblegarden_004] Noblegarden Spoon && Test: Noblegarden Spoon_TB_Noblegarden_004
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Noblegarden_005] Carrots (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Give friendly minions +1/+1 or +2/+2 if it's a <b>Bunny</b>.
			// --------------------------------------------------------
			cards.Add("TB_Noblegarden_005", new Power {
				// TODO [TB_Noblegarden_005] Carrots && Test: Carrots_TB_Noblegarden_005
				InfoCardId = "TB_Noblegarden_005e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_PickYourFate_1] Dire Fate: Taunt and Charge (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: All minions have <b>Taunt</b> and <b>Charge</b>.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_1", new Power {
				// TODO [TB_PickYourFate_1] Dire Fate: Taunt and Charge && Test: Dire Fate: Taunt and Charge_TB_PickYourFate_1
				InfoCardId = "TB_PickYourFate_10_Ench",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_PickYourFate_10] Battlecry Bonus (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Your <b>Battlecry</b> minions have +1/+1.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_10", new Power {
				// TODO [TB_PickYourFate_10] Battlecry Bonus && Test: Battlecry Bonus_TB_PickYourFate_10
				InfoCardId = "TB_PickYourFate_10_Ench",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_PickYourFate_11b] Murloc Bonus (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Summon a 1/1 Murloc at the end of your turn.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_11b", new Power {
				// TODO [TB_PickYourFate_11b] Murloc Bonus && Test: Murloc Bonus_TB_PickYourFate_11b
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_PickYourFate_11rand] Dire Fate: Murlocs (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Turn each minion in play into a 1/1 Murloc.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_11rand", new Power {
				// TODO [TB_PickYourFate_11rand] Dire Fate: Murlocs && Test: Dire Fate: Murlocs_TB_PickYourFate_11rand
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_PickYourFate_12] Fate: Confusion (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: At the end of each turn, swap all minions' Attack and Health.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_12", new Power {
				// TODO [TB_PickYourFate_12] Fate: Confusion && Test: Fate: Confusion_TB_PickYourFate_12
				InfoCardId = "TB_PickYourFate_12_Ench",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_PickYourFate_2] Fate: Bananas (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: When a minion dies, its owner gets a (1) mana Banana.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_2", new Power {
				// TODO [TB_PickYourFate_2] Fate: Bananas && Test: Fate: Bananas_TB_PickYourFate_2
				InfoCardId = "TB_PickYourFate_2_Ench",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_PickYourFate_3] Dire Fate: Windfury (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: All minions have <b>Windfury</b>.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_3", new Power {
				// TODO [TB_PickYourFate_3] Dire Fate: Windfury && Test: Dire Fate: Windfury_TB_PickYourFate_3
				InfoCardId = "TB_PickYourFate_3_Ench",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_PickYourFate_4] Dire Fate: Card (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: When a minion dies, its owner draws a card.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_4", new Power {
				// TODO [TB_PickYourFate_4] Dire Fate: Card && Test: Dire Fate: Card_TB_PickYourFate_4
				InfoCardId = "TB_PickYourFate_4_Ench",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_PickYourFate_5] Fate: Spells (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Spells cost (1) less.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_5", new Power {
				// TODO [TB_PickYourFate_5] Fate: Spells && Test: Fate: Spells_TB_PickYourFate_5
				InfoCardId = "TB_PickYourFate_5_Ench",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_PickYourFate_6] Fate: Portals (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Shuffle 10 Unstable Portals into each player's deck.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_6", new Power {
				// TODO [TB_PickYourFate_6] Fate: Portals && Test: Fate: Portals_TB_PickYourFate_6
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_PickYourFate_6_2nd] Dire Fate: Unstable Portals (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Place 3 Unstable Portals in each player's hand.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_6_2nd", new Power {
				// TODO [TB_PickYourFate_6_2nd] Dire Fate: Unstable Portals && Test: Dire Fate: Unstable Portals_TB_PickYourFate_6_2nd
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_PickYourFate_7] Fate: Coin (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: When a minion dies, its owner gets a Coin.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_7", new Power {
				// TODO [TB_PickYourFate_7] Fate: Coin && Test: Fate: Coin_TB_PickYourFate_7
				InfoCardId = "TB_PickYourFate_7_Ench_2nd",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_PickYourFate_7_2nd] Dire Fate: Manaburst (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Minions gain <b>Deathrattle:</b> Random card in owner's hand costs (0).
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_7_2nd", new Power {
				// TODO [TB_PickYourFate_7_2nd] Dire Fate: Manaburst && Test: Dire Fate: Manaburst_TB_PickYourFate_7_2nd
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_PickYourFate_8] Spell Bonus (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Whenever you cast a spell, gain 3 Armor.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_8", new Power {
				// TODO [TB_PickYourFate_8] Spell Bonus && Test: Spell Bonus_TB_PickYourFate_8
				InfoCardId = "TB_PickYourFate_8_Ench",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_PickYourFate_8rand] Fate: Armor (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Each player gains 2 Armor on the start of their turn.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_8rand", new Power {
				// TODO [TB_PickYourFate_8rand] Fate: Armor && Test: Fate: Armor_TB_PickYourFate_8rand
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_PickYourFate_9] Deathrattle Bonus (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Your <b>Deathrattle</b> minions have +1/+1.
			// --------------------------------------------------------
			cards.Add("TB_PickYourFate_9", new Power {
				// TODO [TB_PickYourFate_9] Deathrattle Bonus && Test: Deathrattle Bonus_TB_PickYourFate_9
				InfoCardId = "TB_PickYourFate_9_Ench",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Presents_001] Present! (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: When you draw this, <b>Discover</b> a treasure, then draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// - TOPDECK = 1
			// --------------------------------------------------------
			cards.Add("TB_Presents_001", new Power {
				// TODO [TB_Presents_001] Present! && Test: Present!_TB_Presents_001
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Presents_002] Card Present (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Draw a card.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_Presents_002", new Power {
				// TODO [TB_Presents_002] Card Present && Test: Card Present_TB_Presents_002
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Presents_003] Zombie Present (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Summon a 3/3 Zombie.
			// --------------------------------------------------------
			// GameTag:
			// - ELITE = 1
			// --------------------------------------------------------
			cards.Add("TB_Presents_003", new Power {
				// TODO [TB_Presents_003] Zombie Present && Test: Zombie Present_TB_Presents_003
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_SC20_001a] Tech Portals (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Shuffle 20 Tech
			//       Portals into your deck.
			//       Draw 2 Cards.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("TB_SC20_001a", new Power {
				// TODO [TB_SC20_001a] Tech Portals && Test: Tech Portals_TB_SC20_001a
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_SC20_001b] Swarm Portals (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Shuffle 20 Swarm Portals into your deck.
			//       Draw 2 Cards.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("TB_SC20_001b", new Power {
				// TODO [TB_SC20_001b] Swarm Portals && Test: Swarm Portals_TB_SC20_001b
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_SC20_001c] Mind Portals (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Shuffle 20 Mind Portals into your deck.
			//       Draw 2 Cards.
			// --------------------------------------------------------
			// GameTag:
			// - HIDE_COST = 1
			// --------------------------------------------------------
			cards.Add("TB_SC20_001c", new Power {
				// TODO [TB_SC20_001c] Mind Portals && Test: Mind Portals_TB_SC20_001c
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_SC20_002] Tech Portal (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Add a random Tech card to your hand. It costs (3) less.
			// --------------------------------------------------------
			cards.Add("TB_SC20_002", new Power {
				// TODO [TB_SC20_002] Tech Portal && Test: Tech Portal_TB_SC20_002
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_SC20_003] Swarm Portal (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Add a random Swarm card to your hand. It costs (3) less.
			// --------------------------------------------------------
			cards.Add("TB_SC20_003", new Power {
				// TODO [TB_SC20_003] Swarm Portal && Test: Swarm Portal_TB_SC20_003
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_SC20_004] Mind Portal (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Add a random Mind card to your hand. It costs (3) less.
			// --------------------------------------------------------
			cards.Add("TB_SC20_004", new Power {
				// TODO [TB_SC20_004] Mind Portal && Test: Mind Portal_TB_SC20_004
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_SPT_DPromo_EnterPortal] The Portal Opens (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Through the Nether and into...
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromo_EnterPortal", new Power {
				// TODO [TB_SPT_DPromo_EnterPortal] The Portal Opens && Test: The Portal Opens_TB_SPT_DPromo_EnterPortal
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_SPT_DPromoSpell1] Lightning (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Deal $3 damage. @spelldmg
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSpell1", new Power {
				// TODO [TB_SPT_DPromoSpell1] Lightning && Test: Lightning_TB_SPT_DPromoSpell1
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_SPT_DPromoSpell2] Summon Guardians (*) - COST:2 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Summon two 2/4 Guardians.
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_NUM_MINION_SLOTS = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSpell2", new Power {
				// TODO [TB_SPT_DPromoSpell2] Summon Guardians && Test: Summon Guardians_TB_SPT_DPromoSpell2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_SPT_DPromoSpellBovine1] Moo... (*) - COST:6 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Summon 3 Hell Bovines. Give all Hell Bovines <b>Taunt</b>.
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSpellBovine1", new Power {
				// TODO [TB_SPT_DPromoSpellBovine1] Moo... && Test: Moo..._TB_SPT_DPromoSpellBovine1
				InfoCardId = "TB_SPT_DPromoSpellBovine1e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_SPT_DPromoSpellPortal] The Portal Opens (*) - COST:2 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Through the Nether and into...
			// --------------------------------------------------------
			// PlayReq:
			// - REQ_TARGET_TO_PLAY = 0
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSpellPortal", new Power {
				// TODO [TB_SPT_DPromoSpellPortal] The Portal Opens && Test: The Portal Opens_TB_SPT_DPromoSpellPortal
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_SPT_DPromoSpellPortal2] Stampede (*) - COST:4 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Summon 2 Hell Bovines. Give all Hell Bovines <b>Charge</b>.
			// --------------------------------------------------------
			cards.Add("TB_SPT_DPromoSpellPortal2", new Power {
				// TODO [TB_SPT_DPromoSpellPortal2] Stampede && Test: Stampede_TB_SPT_DPromoSpellPortal2
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_Superfriends001] Offensive Play (*) - COST:0 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: The next Legendary minion you play and all your other copies cost (3) less.
			// --------------------------------------------------------
			cards.Add("TB_Superfriends001", new Power {
				// TODO [TB_Superfriends001] Offensive Play && Test: Offensive Play_TB_Superfriends001
				InfoCardId = "TB_Superfriends001e",
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_TagTeam_ClearBoard] Your Next Victim Comes (*) - COST:10 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: Destroy all minions. Drain all Mana. Gain 5 Health.
			// --------------------------------------------------------
			cards.Add("TB_TagTeam_ClearBoard", new Power {
				// TODO [TB_TagTeam_ClearBoard] Your Next Victim Comes && Test: Your Next Victim Comes_TB_TagTeam_ClearBoard
				//PowerTask = null,
				//Trigger = null,
			});

			// ---------------------------------------- SPELL - NEUTRAL
			// [TB_TagTeam_NewHeroCards] New Hero! (*) - COST:0 
			// - Fac: neutral, Set: tb, 
			// --------------------------------------------------------
			// Text: A new Hero takes position.
			// --------------------------------------------------------
			cards.Add("TB_TagTeam_NewHeroCards", new Power {
				// TODO [TB_TagTeam_NewHeroCards] New Hero! && Test: New Hero!_TB_TagTeam_NewHeroCards
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - NEUTRAL
			// [BRMC_94] Sulfuras (*) - COST:2 [ATK:2/HP:0] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: <b>Deathrattle:</b> Your Hero Power becomes 'Deal 8_damage to a random enemy'.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 6
			// - DEATHRATTLE = 1
			// --------------------------------------------------------
			cards.Add("BRMC_94", new Power {
				// TODO [BRMC_94] Sulfuras && Test: Sulfuras_BRMC_94
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - NEUTRAL
			// [TB_BlingBrawl_Weapon] Foam Sword (*) - COST:1 [ATK:2/HP:0] 
			// - Set: tb, 
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("TB_BlingBrawl_Weapon", new Power {
				// TODO [TB_BlingBrawl_Weapon] Foam Sword && Test: Foam Sword_TB_BlingBrawl_Weapon
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - NEUTRAL
			// [TB_KTRAF_08w] Massive Runeblade (*) - COST:3 [ATK:5/HP:0] 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Deals double damage to heroes.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 2
			// --------------------------------------------------------
			cards.Add("TB_KTRAF_08w", new Power {
				// TODO [TB_KTRAF_08w] Massive Runeblade && Test: Massive Runeblade_TB_KTRAF_08w
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - NEUTRAL
			// [TB_SPT_BossWeapon] Armory (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Attack increases over time.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_BossWeapon", new Power {
				// TODO [TB_SPT_BossWeapon] Armory && Test: Armory_TB_SPT_BossWeapon
				//PowerTask = null,
				//Trigger = null,
			});

			// --------------------------------------- WEAPON - NEUTRAL
			// [TB_SPT_MTH_BossWeapon] Party Armory (*) - COST:1 
			// - Set: tb, 
			// --------------------------------------------------------
			// Text: Attack increases over time.
			// --------------------------------------------------------
			// GameTag:
			// - DURABILITY = 1
			// --------------------------------------------------------
			cards.Add("TB_SPT_MTH_BossWeapon", new Power {
				// TODO [TB_SPT_MTH_BossWeapon] Party Armory && Test: Party Armory_TB_SPT_MTH_BossWeapon
				//PowerTask = null,
				//Trigger = null,
			});

		}

		public static void AddAll(Dictionary<string, Power> cards)
		{
			Heroes(cards);
			HeroPowers(cards);
			DeathknightNonCollect(cards);
			DruidNonCollect(cards);
			HunterNonCollect(cards);
			MageNonCollect(cards);
			PaladinNonCollect(cards);
			PriestNonCollect(cards);
			RogueNonCollect(cards);
			ShamanNonCollect(cards);
			WarlockNonCollect(cards);
			WarriorNonCollect(cards);
			DreamNonCollect(cards);
			NeutralNonCollect(cards);
		}
	}
}
